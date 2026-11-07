#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
#[cfg(target_arch = "wasm32")]
struct SpiralBumpAlloc;
#[cfg(target_arch = "wasm32")]
static SPIRAL_BUMP_NEXT: std::sync::atomic::AtomicUsize = std::sync::atomic::AtomicUsize::new(0);
#[cfg(target_arch = "wasm32")]
unsafe impl std::alloc::GlobalAlloc for SpiralBumpAlloc {
    unsafe fn alloc(&self, layout: std::alloc::Layout) -> *mut u8 {
        use std::sync::atomic::Ordering::Relaxed;
        let have = core::arch::wasm32::memory_size(0) * 65536;
        let next = match SPIRAL_BUMP_NEXT.load(Relaxed) { 0 => have, next => next };
        let start = (next + layout.align() - 1) & !(layout.align() - 1);
        let end = start + layout.size();
        if end > have && core::arch::wasm32::memory_grow(0, (end - have).div_ceil(65536)) == usize::MAX {
            return std::ptr::null_mut();
        }
        SPIRAL_BUMP_NEXT.store(end, Relaxed);
        start as *mut u8
    }
    unsafe fn dealloc(&self, _: *mut u8, _: std::alloc::Layout) {}
}
#[cfg(target_arch = "wasm32")]
#[global_allocator]
static SPIRAL_BUMP: SpiralBumpAlloc = SpiralBumpAlloc;
#[near_sdk::near(contract_state)]
#[derive(near_sdk::PanicOnDefault)]
pub struct State((u32, Vec<u8>));
#[derive(near_sdk::PanicOnDefault, borsh::BorshDeserialize, borsh::BorshSerialize)]
pub struct OldState {
    version: u32,
    seeds: near_sdk::store::vec::Vector<u8>,
}
impl From<OldState> for State {
    fn from(mut old_state: OldState) -> Self {
        let seeds = old_state.seeds.iter().copied().collect();
        old_state.seeds.clear();
        old_state.seeds.flush();
        Self((old_state.version + 1, seeds))
    }
}
#[near_sdk::near]
impl State {
    #[init]
    pub fn new() -> Self {
        Self(dice_contract_new())
    }
    #[private]
    #[init(ignore_state)]
    pub fn migrate() -> Self {
        let raw = near_sdk::env::storage_read(b"STATE")
            .unwrap_or_else(|| near_sdk::env::panic_str("dice_contract.migrate / no state to migrate"));
        if raw.len() >= 4 && u32::from_le_bytes([raw[0], raw[1], raw[2], raw[3]]) >= 3 {
            near_sdk::env::panic_str("dice_contract.migrate / the state is already migrated")
        }
        borsh::from_slice::<OldState>(&raw)
            .unwrap_or_else(|_| near_sdk::env::panic_str("dice_contract.migrate / the state is not the old layout"))
            .into()
    }
}
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
}
#[near_sdk::near]
impl State {
    pub fn contribute_seed(&mut self, seed: Vec<u8>) {
        dice_contract_contribute_seed(&mut self.0.1, seed)
    }
    pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) {
        self.contribute_seed(seed)
    }
}
struct SpiralDebug<T>(T);
trait SpiralDebugShow {
    fn show(&self) -> String;
}
impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> {
    fn show(&self) -> String { format!("{:?}", self.0) }
}
trait SpiralTypeShow {
    fn show(&self) -> String;
}
impl<T> SpiralTypeShow for &SpiralDebug<T> {
    fn show(&self) -> String { String::from(std::any::type_name::<T>()) }
}
#[cfg(target_arch = "wasm32")]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> { None }
#[cfg(all(windows, not(target_arch = "wasm32")))]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> {
    #[repr(C)] struct St([u16; 8]);
    unsafe extern "system" { fn GetLocalTime(t: *mut St); }
    let mut t = St([0; 8]);
    unsafe { GetLocalTime(&mut t) };
    Some([i64::from(t.0[4]), i64::from(t.0[5]), i64::from(t.0[6])])
}
#[cfg(all(unix, not(target_arch = "wasm32")))]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> {
    #[repr(C, align(8))] struct Tm([i32; 16]);
    unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; }
    let now = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs());
    let secs = std::os::raw::c_long::try_from(now.unwrap_or(0)).unwrap_or(0);
    let mut tm = Tm([0; 16]);
    unsafe { localtime_r(&secs, &mut tm) };
    Some([i64::from(tm.0[2]), i64::from(tm.0[1]), i64::from(tm.0[0])])
}
#[cfg(not(any(windows, unix, target_arch = "wasm32")))]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> { None }
#[cfg(target_arch = "wasm32")]
fn spiral_cfg_epoch_nanos() -> u64 { near_sdk::env::block_timestamp() }
#[cfg(not(target_arch = "wasm32"))]
fn spiral_cfg_epoch_nanos() -> u64 {
    let since = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH);
    since.map(|d| u64::try_from(d.as_nanos()).unwrap_or(0)).unwrap_or(0)
}
#[cfg(target_arch = "wasm32")]
fn spiral_trace_near_log(text: &str) {
    use std::sync::atomic::{AtomicUsize, Ordering};
    static LOGGED: AtomicUsize = AtomicUsize::new(0);
    let mut rest = text;
    while !rest.is_empty() {
        let used = LOGGED.load(Ordering::Relaxed);
        let budget = 16000usize.saturating_sub(used);
        if budget < 13 {
            break;
        }
        let mut end = rest.len().min(15000);
        while !rest.is_char_boundary(end) {
            end -= 1;
        }
        let (chunk, tail) = rest.split_at(end);
        if chunk.len() <= budget {
            LOGGED.store(used + chunk.len(), Ordering::Relaxed);
            near_sdk::env::log_str(chunk);
            rest = tail;
        } else {
            let mut cut = budget - 12;
            while !chunk.is_char_boundary(cut) {
                cut -= 1;
            }
            let s = format!("{} [truncated]", &chunk[..cut]);
            LOGGED.store(used + s.len(), Ordering::Relaxed);
            near_sdk::env::log_str(&s);
            break;
        }
    }
}
#[near_sdk::near]
impl State {
    pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
        dice_contract_generate_random_number(&mut self.0.1, key, proof, max)
    }
}
#[near_sdk::near]
impl State {
    pub fn roll_within_bounds(max: u64, rolls: Vec<u8>) -> Option<u64> {
        dice_contract_roll_within_bounds(max, rolls)
    }
    #[result_serializer(borsh)]
    pub fn roll_within_bounds_borsh(
        #[serializer(borsh)] max: u64,
        #[serializer(borsh)] rolls: Vec<u8>,
    ) -> Option<u64> {
        Self::roll_within_bounds(max, rolls)
    }
}
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) }; }
    if (bytes[from as usize] & 0xC0) == 0x80 || (to + 1 < length && (bytes[(to + 1) as usize] & 0xC0) == 0x80) { std::process::exit(3); }
    let slice = &bytes[from as usize..(to + 1) as usize];
    match std::str::from_utf8(slice) { Ok(text) => Rc::<str>::from(text), Err(error) => Rc::<str>::from(std::str::from_utf8(&slice[..error.valid_up_to()]).unwrap_or("")) }
}
fn string_concat(parts: &[&str]) -> Rc<str> {
    let mut joined = Rc::<[u8]>::new_uninit_slice(parts.iter().map(|part| part.len()).sum());
    let bytes = Rc::get_mut(&mut joined).unwrap().as_mut_ptr() as *mut u8;
    let mut at = 0;
    for part in parts {
        unsafe { std::ptr::copy_nonoverlapping(part.as_ptr(), bytes.add(at), part.len()) };
        at += part.len();
    }
    unsafe { Rc::from_raw(Rc::into_raw(joined.assume_init()) as *const str) }
}
pub struct Mut0 { pub l0: i64 }
pub struct Mut1 { pub l0: Rc<dyn Fn(Rc<str>) -> ()> }
pub struct Mut2 { pub l0: bool }
pub struct Mut3 { pub l0: Rc<str> }
#[derive(Clone)]
enum US0 {
    US0_Verbose,
    US0_Debug,
    US0_Info,
    US0_Warning,
    US0_Critical,
}
pub struct Mut4 { pub l0: US0 }
#[derive(Clone)]
enum US1 {
    US1_Some(US0),
    US1_None,
}
pub struct Mut5 { pub l0: i32, pub l1: US1 }
#[derive(Clone)]
enum US2 {
    US2_Some(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US2_None,
}
#[derive(Clone)]
enum US3 {
    US3_Some([i64; 3]),
    US3_None,
}
#[derive(Clone)]
enum US5 {
    US5_EmptyRange,
    US5_AboveLargest(u64, u64),
}
#[derive(Clone)]
enum US4 {
    US4_Ok(u64),
    US4_Error(US5),
}
#[derive(Clone)]
enum US6 {
    US6_One,
    US6_Two,
    US6_Three,
    US6_Four,
    US6_Five,
    US6_Six,
}
#[derive(Clone)]
enum US7 {
    US7_Some(US6),
    US7_None,
}
#[derive(Clone)]
enum UH0 {
    UH0_Nil,
    UH0_Cons(u8, Rc<UH0>),
}
#[derive(Clone)]
enum UH1 {
    UH1_Nil,
    UH1_Cons(US6, Rc<UH1>),
}
#[derive(Clone)]
enum US8 {
    US8_Some(Rc<UH1>),
    US8_None,
}
#[derive(Clone)]
enum US9 {
    US9_Some(u64),
    US9_None,
}
impl US6 {
    fn tag(&self) -> i32 {
        match self {
            US6::US6_One => 0,
            US6::US6_Two => 1,
            US6::US6_Three => 2,
            US6::US6_Four => 3,
            US6::US6_Five => 4,
            US6::US6_Six => 5,
        }
    }
}
fn get_environment_variable_1(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = Rc::<str>::from(std::env::var(&*v0).unwrap_or_default());
    v1
}
fn method2(mut v0: &Rc<RefCell<Mut5>>) -> bool {
    let mut v1: i32 = v0.borrow().l0;
    let mut v2: bool = v1 > 0i32;
    v2
}
fn closure2() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn new_trace_state_0(mut v0: US0) -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
    let mut v1: bool = cfg!(target_arch = "wasm32");
    let v45: US1 = if v1 {
        US1::US1_None
    } else {
        let v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
        let v4: Rc<str> = get_environment_variable_1(v3);
        ;
        ;
        ;
        ;
        ;
        let v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
        let v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
        let v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
        let v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
        let v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
        let v14: Rc<str> = Rc::<str>::from(v13.to_lowercase());
        let mut v15: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new(Vec::new()));
        let v16: US0 = US0::US0_Verbose;
        v15.borrow_mut().push((v13, v16));
        let v17: US0 = US0::US0_Debug;
        v15.borrow_mut().push((v11, v17));
        let v18: US0 = US0::US0_Info;
        v15.borrow_mut().push((v9, v18));
        let v19: US0 = US0::US0_Warning;
        v15.borrow_mut().push((v7, v19));
        let v20: US0 = US0::US0_Critical;
        v15.borrow_mut().push((v5, v20));
        let v21: US0 = US0::US0_Verbose;
        v15.borrow_mut().push((v14, v21));
        let v22: US0 = US0::US0_Debug;
        v15.borrow_mut().push((v12, v22));
        let v23: US0 = US0::US0_Info;
        v15.borrow_mut().push((v10, v23));
        let v24: US0 = US0::US0_Warning;
        v15.borrow_mut().push((v8, v24));
        let v25: US0 = US0::US0_Critical;
        v15.borrow_mut().push((v6, v25));
        let v26: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v15.borrow().clone());
        let v27: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v26).as_ref().clone()));
        let v28: i32 = (v27.clone().borrow().len() as i32);
        let v29: US1 = US1::US1_None;
        let mut v30: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: v28, l1: v29 }));
        while method2(&v30) {
            let v32: i32 = v30.borrow().l0;
            let v33: i32 = v32.wrapping_sub(1i32);
            let v34: US1 = v30.borrow().l1.clone();
            let (mut v35, mut v36): (Rc<str>, US0) = v27.borrow()[v33 as usize].clone();
            let v43: US1 = match &v34 {
                US1::US1_None => {
                    let v38: bool = v35 == v4 ;
                    if v38 {
                        US1::US1_Some(v36)
                    } else {
                        US1::US1_None
                    }
                }
                US1::US1_Some(v37) => {
                    let v37: US0 = v37.clone();
                    v34
                }
            };
            v30.borrow_mut().l0 = v33;
            v30.borrow_mut().l1 = v43;
            ()
        };
        let v44: US1 = v30.borrow().l1.clone();
        v44
    };
    let v46: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let v47: Rc<dyn Fn(Rc<str>) -> ()> = closure2();
    let v48: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v47 }));
    let v49: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v51: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v50 }));
    let v54: US0 = match v45 {
        US1::US1_None => {
            v0
        }
        US1::US1_Some(v52) => {
            let v52: US0 = v52;
            v52
        }
    };
    let v55: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v54 }));
    let v56: Option<i64> = None;
    (v46, v48, v49, v51, v55, v56)
}
fn fresh_c1() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0);
        (v1, v2, v3, v4, v5, v6)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c3() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0);
        (v1, v2, v3, v4, v5, v6)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure0() -> Rc<dyn Fn() -> (u32, Vec<u8>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (u32, Vec<u8>)> = Rc::new(move || -> (u32, Vec<u8>) {
        let mut v1: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v1); };
        let v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v4, mut v5, mut v6, mut v7, mut v8, mut v9): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v3);
        let mut v10: US0 = US0::US0_Debug;
        v8.borrow_mut().l0 = v10;
        let v11: Vec<u8> = Vec::new();
        (3u32, v11)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method5(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let v3: bool = v2 >= v1;
        if v3 {
            return v1;
        } else {
            let v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let v5: bool = v4 == b' ';
            let v11: bool = if v5 {
                true
            } else {
                let v6: bool = v4 == b'\t';
                if v6 {
                    true
                } else {
                    let v7: bool = v4 == b'\r';
                    if v7 {
                        true
                    } else {
                        let mut v8: bool = v4 == b'\n';
                        v8
                    }
                }
            };
            if v11 {
                let mut v12: i32 = v2.wrapping_add(1i32);
                v2 = v12;
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn method6(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let v3: i32 = v1.wrapping_sub(1i32);
            let v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let v5: bool = v4 == b' ';
            let v7: bool = if v5 {
                true
            } else {
                let v6: bool = v4 == b'/';
                v6
            };
            if v7 {
                v1 = v3;
                continue;
            } else {
                return v3;
            }
        }
    }
}
fn method4(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let v3: i32 = method5(v0.clone(), v1, v2);
    let v4: i32 = v1.wrapping_sub(1i32);
    let v5: Rc<str> = string_slice(&v0, v3 as i64, v4 as i64);
    let v6: i32 = (v5.clone().len() as i32);
    let v7: i32 = method6(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5, 0i32 as i64, v7 as i64);
    v8
}
fn method8(mut v0: Option<[i64; 3]>) -> Option<[i64; 3]> {
    v0
}
fn closure5() -> Rc<dyn Fn(([i64; 3])) -> US3> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(([i64; 3])) -> US3> = Rc::new(move |mut v0: ([i64; 3])| -> US3 {
        let mut v1: [i64; 3] = (v0);
        US3::US3_Some(v1)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn time_7(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let v6: Option<[i64; 3]> = spiral_cfg_local_clock();
    let v7: Option<[i64; 3]> = method8(v6);
    let mut v8: Rc<dyn Fn(([i64; 3])) -> US3> = closure5();
    let mut v9: Option<US3> = v7.map(|x| v8(x));
    let v11: US3 = US3::US3_None;
    let mut v12: US3 = v11.clone();
    let v13: US3 = v9.unwrap_or(v12);
    let v27: u64 = match v13 {
        US3::US3_None => {
            let v23: u64 = spiral_cfg_epoch_nanos();
            let v24: u64 = v23.wrapping_div(1000000000u64);
            let v25: u64 = v24.wrapping_rem(86400u64);
            v25
        }
        US3::US3_Some(v14) => {
            let v14: [i64; 3] = v14;
            let mut v15: i64 = v14[0];
            let v16: i64 = v15.wrapping_mul(3600i64);
            let v17: i64 = v14[1];
            let v18: i64 = v17.wrapping_mul(60i64);
            let v19: i64 = v16.wrapping_add(v18);
            let v20: i64 = v14[2];
            let v21: i64 = v19.wrapping_add(v20);
            let v22: u64 = (v21 as u64);
            v22
        }
    };
    let v28: u64 = v27.wrapping_div(3600u64);
    let v29: u64 = v28.wrapping_rem(24u64);
    let mut v30: bool = v29 < 10u64;
    let v33: Rc<str> = if v30 {
        let v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v31
    } else {
        let v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v32
    };
    let v34: Rc<str> = Rc::<str>::from((v29).to_string());
    let v36: Rc<str> = string_concat(&[&*v33, &*v34, ":"]);
    let v37: u64 = v27.wrapping_div(60u64);
    let v38: u64 = v37.wrapping_rem(60u64);
    let v39: bool = v38 < 10u64;
    let v42: Rc<str> = if v39 {
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v40
    } else {
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v41
    };
    let v43: Rc<str> = Rc::<str>::from((v38).to_string());
    let v46: Rc<str> = string_concat(&[&*v36, &*v42, &*v43, ":"]);
    let v47: u64 = v27.wrapping_rem(60u64);
    let v48: bool = v47 < 10u64;
    let v51: Rc<str> = if v48 {
        let v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v49
    } else {
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v50
    };
    let v52: Rc<str> = Rc::<str>::from((v47).to_string());
    let v54: Rc<str> = string_concat(&[&*v46, &*v51, &*v52]);
    v54
}
fn method10(mut v0: &Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let v3: Rc<str> = string_concat(&[&*v2, &*v1]);
    v0.borrow_mut().l0 = v3;
    ()
}
fn format_real_9(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method10(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn level_str_11() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let v3: Rc<str> = string_concat(&[&*v0, "d", &*v2]);
    v3
}
fn method3(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: &Rc<RefCell<Mut0>>, mut v7: &Rc<RefCell<Mut1>>, mut v8: &Rc<RefCell<Mut2>>, mut v9: &Rc<RefCell<Mut3>>, mut v10: &Rc<RefCell<Mut4>>, mut v11: Option<i64>, mut v12: usize, mut v13: Rc<str>) -> Rc<str> {
    let v14: bool = cfg!(target_arch = "wasm32");
    let v39: Rc<str> = if v14 {
        let mut v15: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<usize>") } } (&&W(&v12)).s() });
        let v21: Rc<str> = string_concat(&["d dice_contract.contribute_seed / { seed_len = ", &*v15, "; seed_excess = ", &*v13, " }"]);
        v21
    } else {
        let v22: i64 = v0.borrow().l0;
        let v23: Rc<str> = time_7(v6, v7, v8, v9, v10, v11);
        let v25: Rc<str> = format_real_9(v22);
        let v27: Rc<str> = level_str_11();
        let v32: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<usize>") } } (&&W(&v12)).s() });
        let v38: Rc<str> = string_concat(&[&*v23, " ", &*v25, &*v27, " dice_contract.contribute_seed / { seed_len = ", &*v32, "; seed_excess = ", &*v13, " }"]);
        v38
    };
    method4(v39)
}
fn closure6() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure4() -> Rc<dyn Fn(&mut Vec<u8>, Vec<u8>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut Vec<u8>, Vec<u8>) -> ()> = Rc::new(move |mut v0: &mut Vec<u8>, mut v1: Vec<u8>| -> () {
        let v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v3); };
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
        let mut v12: US0 = US0::US0_Debug;
        v10.borrow_mut().l0 = v12;
        let v13: usize = ((v1).len() as usize);
        (v0).extend_from_slice(&(v1));
        let v14: usize = (v0).len();
        let mut v15: u64 = ((v14) as u64);
        let v16: usize = ((100i32) as usize);
        let v17: u64 = ((v16) as u64);
        let v18: bool = v15 > v17;
        let v20: u64 = if v18 {
            let v19: u64 = v15.wrapping_sub(v17);
            v19
        } else {
            0u64
        };
        let v21: usize = ((v20) as usize);
        let v22: Vec<u8> = (v0).drain(..v21).collect::<Vec<_>>();
        let v23: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
        let v43: bool = if v23 {
            true
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v26, mut v27, mut v28, mut v29, mut v30, mut v31): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v32: US0 = v30.borrow().l0.clone();
            let v37: i32 = match v32 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let v38: bool = v28.borrow().l0;
            let v39: bool = v38 == false;
            let v41: bool = if v39 {
                false
            } else {
                let v40: bool = 20i32 >= v37;
                v40
            };
            let v42: bool = v41 == false;
            v42
        };
        let v89: US2 = if v43 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v47, mut v48, mut v49, mut v50, mut v51, mut v52): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v53: Rc<str> = Rc::<str>::from((v22).iter().flat_map(|b| [b >> 4, b & 15]).map(|n| char::from(b"0123456789abcdef"[n as usize])).collect::<String>());
            let v54: Rc<str> = method3(&v47, &v48, &v49, &v50, &v51, v52.clone(), &v47, &v48, &v49, &v50, &v51, v52.clone(), v13, v53);
            { let _ = spiral_trace_hold(&v3); };
            let (mut v57, mut v58, mut v59, mut v60, mut v61, mut v62): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v63: i64 = v57.borrow().l0;
            let v64: i64 = v63.wrapping_add(1i64);
            v57.borrow_mut().l0 = v64;
            let v65: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v66: bool = cfg!(target_arch = "wasm32");
            if v66 {
                let v67: Rc<str> = v60.borrow().l0.clone();
                let v68: bool = &*v67 == "";
                let v75: Rc<str> = if v68 {
                    v54.clone()
                } else {
                    let v69: bool = &*v54 == "";
                    if v69 {
                        let v70: Rc<str> = v60.borrow().l0.clone();
                        v70
                    } else {
                        let v71: Rc<str> = v60.borrow().l0.clone();
                        let v73: Rc<str> = string_concat(&[&*v71, "\n", &*v54]);
                        v73
                    }
                };
                let v77: usize = v75.len();
                let v78: i32 = ((v77) as i32);
                let v79: i32 = v78.wrapping_add(14999i32);
                let v80: i32 = v79.wrapping_div(15000i32);
                let v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v82: bool = v54 != v81 ;
                let v84: bool = if v82 {
                    let v83: bool = v80 <= 1i32;
                    v83
                } else {
                    false
                };
                if v84 {
                    v60.borrow_mut().l0 = v75;
                    ()
                } else {
                    v60.borrow_mut().l0 = v81;
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v75); };
                    ()
                }
            } else {
                println!("{}", v54);
                ()
            };
            let mut v87: Rc<dyn Fn(Rc<str>) -> ()> = v58.borrow().l0.clone();
            v87(v54);
            US2::US2_Some(v57, v58, v59, v60, v61, v62)
        };
        { let _ = spiral_trace_hold(&v3); };
        let (mut v92, mut v93, mut v94, mut v95, mut v96, mut v97): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
        let v98: US0 = v96.borrow().l0.clone();
        let v103: i32 = match v98 {
            US0::US0_Critical => {
                50i32
            }
            US0::US0_Debug => {
                20i32
            }
            US0::US0_Info => {
                30i32
            }
            US0::US0_Verbose => {
                10i32
            }
            US0::US0_Warning => {
                40i32
            }
        };
        let v104: bool = v94.borrow().l0;
        let v105: bool = v104 == false;
        let v107: bool = if v105 {
            false
        } else {
            let v106: bool = 50i32 >= v103;
            v106
        };
        let v108: bool = v107 == false;
        let v152: US2 = if v108 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            { let _ = spiral_trace_hold(&v3); };
            let (mut v120, mut v121, mut v122, mut v123, mut v124, mut v125): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v126: i64 = v120.borrow().l0;
            let v127: i64 = v126.wrapping_add(1i64);
            v120.borrow_mut().l0 = v127;
            let v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v129: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v130: bool = cfg!(target_arch = "wasm32");
            if v130 {
                let v131: Rc<str> = v123.borrow().l0.clone();
                let v132: bool = &*v131 == "";
                let v139: Rc<str> = if v132 {
                    v128.clone()
                } else {
                    let v133: bool = &*v128 == "";
                    if v133 {
                        let v134: Rc<str> = v123.borrow().l0.clone();
                        v134
                    } else {
                        let v135: Rc<str> = v123.borrow().l0.clone();
                        let v137: Rc<str> = string_concat(&[&*v135, "\n", &*v128]);
                        v137
                    }
                };
                let v141: usize = v139.len();
                let v142: i32 = ((v141) as i32);
                let v143: i32 = v142.wrapping_add(14999i32);
                let v144: i32 = v143.wrapping_div(15000i32);
                let mut v145: bool = v128 != v128 ;
                let v147: bool = if v145 {
                    let v146: bool = v144 <= 1i32;
                    v146
                } else {
                    false
                };
                if v147 {
                    v123.borrow_mut().l0 = v139;
                    ()
                } else {
                    v123.borrow_mut().l0 = v128.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v139); };
                    ()
                }
            } else {
                println!("{}", v128);
                ()
            };
            let mut v150: Rc<dyn Fn(Rc<str>) -> ()> = v121.borrow().l0.clone();
            v150(v128);
            US2::US2_Some(v120, v121, v122, v123, v124, v125)
        };
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn format_real_12(mut v0: u64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method10(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn go_13(mut v0: u64, mut v1: i32, mut v2: u64) -> i32 {
    loop {
        let v3: bool = v2 >= v0;
        if v3 {
            return v1;
        } else {
            let v4: i32 = v1.wrapping_add(1i32);
            let v5: u64 = v2.wrapping_mul(6u64);
            (v1, v2) = (v4, v5);
            continue;
        }
    }
}
fn draw_hashed_16(mut v0: Rc<RefCell<Vec<u8>>>, mut v1: i32) -> (US6, Rc<RefCell<Vec<u8>>>, i32) {
    loop {
        let mut v2: i32 = (v0.clone().borrow().len() as i32);
        let v3: bool = v1 >= v2;
        if v3 {
            let v4: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(near_sdk::env::keccak512((v0).borrow().as_slice())));
            let v5: i32 = 0i32;
            (v0, v1) = (v4, v5);
            continue;
        } else {
            let mut v9: u8 = v0.borrow()[v1 as usize];
            let mut v10: bool = v9 < 252u8;
            let v31: US7 = if v10 {
                let v11: u8 = v9.wrapping_rem(6u8);
                let mut v12: i32 = (v11 as i32);
                let v13: bool = 0i32 == v12;
                let v28: US6 = if v13 {
                    US6::US6_One
                } else {
                    let mut v15: bool = 1i32 == v12;
                    if v15 {
                        US6::US6_Two
                    } else {
                        let v17: bool = 2i32 == v12;
                        if v17 {
                            US6::US6_Three
                        } else {
                            let v19: bool = 3i32 == v12;
                            if v19 {
                                US6::US6_Four
                            } else {
                                let v21: bool = 4i32 == v12;
                                if v21 {
                                    US6::US6_Five
                                } else {
                                    US6::US6_Six
                                }
                            }
                        }
                    }
                };
                US7::US7_Some(v28)
            } else {
                US7::US7_None
            };
            match v31 {
                US7::US7_None => {
                    let v34: i32 = v1.wrapping_add(1i32);
                    v1 = v34;
                    continue;
                }
                US7::US7_Some(v32) => {
                    let v32: US6 = v32;
                    let v33: i32 = v1.wrapping_add(1i32);
                    return (v32, v0, v33);
                }
            }
        }
    }
}
fn read_15(mut v0: i32, mut v1: u64, mut v2: u64, mut v3: Rc<RefCell<Vec<u8>>>, mut v4: i32) -> (u64, Rc<RefCell<Vec<u8>>>, i32) {
    loop {
        let v5: bool = v0 <= 0i32;
        if v5 {
            return (v2, v3, v4);
        } else {
            let (mut v6, mut v7, mut v8): (US6, Rc<RefCell<Vec<u8>>>, i32) = draw_hashed_16(v3, v4);
            let mut v9: i32 = v0.wrapping_sub(1i32);
            let mut v10: u64 = v1.wrapping_mul(6u64);
            let v11: i32 = (v6.tag() as i32);
            let mut v12: u64 = (v11 as u64);
            let v13: u64 = v12.wrapping_mul(v1);
            let v14: u64 = v2.wrapping_add(v13);
            (v0, v1, v2, v3, v4) = (v9, v10, v14, v7, v8);
            continue;
        }
    }
}
fn roll_fresh_14(mut v0: u64, mut v1: i32, mut v2: Rc<RefCell<Vec<u8>>>, mut v3: i32) -> (u64, Rc<RefCell<Vec<u8>>>, i32) {
    loop {
        let v4: u64 = 1u64;
        let v5: u64 = 0u64;
        let (mut v6, mut v7, mut v8): (u64, Rc<RefCell<Vec<u8>>>, i32) = read_15(v1, v4, v5, v2, v3);
        let mut v9: bool = v6 < v0;
        if v9 {
            let mut v10: u64 = v6.wrapping_add(1u64);
            return (v10, v7, v8);
        } else {
            (v2, v3) = (v7, v8);
            continue;
        }
    }
}
fn method17(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<RefCell<Mut0>>, mut v7: Rc<RefCell<Mut1>>, mut v8: Rc<RefCell<Mut2>>, mut v9: Rc<RefCell<Mut3>>, mut v10: Rc<RefCell<Mut4>>, mut v11: Option<i64>, mut v12: Rc<str>, mut v13: u64, mut v14: u64) -> Rc<str> {
    let mut v15: bool = cfg!(target_arch = "wasm32");
    let v44: Rc<str> = if v15 {
        let v18: Rc<str> = format_real_12(v13);
        let v21: Rc<str> = format_real_12(v14);
        let v25: Rc<str> = string_concat(&["d ", &*v12, " / { max = ", &*v18, "; result = ", &*v21, " }"]);
        v25
    } else {
        let v26: i64 = v0.borrow().l0;
        let v27: Rc<str> = time_7(&v6, &v7, &v8, &v9, &v10, v11);
        let v29: Rc<str> = format_real_9(v26);
        let v31: Rc<str> = level_str_11();
        let v36: Rc<str> = format_real_12(v13);
        let v39: Rc<str> = format_real_12(v14);
        let v43: Rc<str> = string_concat(&[&*v27, " ", &*v29, &*v31, " ", &*v12, " / { max = ", &*v36, "; result = ", &*v39, " }"]);
        v43
    };
    method4(v44)
}
fn closure7() -> Rc<dyn Fn(&mut Vec<u8>, std::string::String, std::string::String, u64) -> u64> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut Vec<u8>, std::string::String, std::string::String, u64) -> u64> = Rc::new(move |mut v0: &mut Vec<u8>, mut v1: std::string::String, mut v2: std::string::String, mut v3: u64| -> u64 {
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v5); };
        let v7: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v8, mut v9, mut v10, mut v11, mut v12, mut v13): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
        let v14: US0 = US0::US0_Debug;
        v12.borrow_mut().l0 = v14;
        let v16: Rc<str> = Rc::<str>::from(String::as_str(&v1));
        let v18: Rc<str> = Rc::<str>::from(String::as_str(&v2));
        let v19: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v0).clone()));
        let v20: bool = v3 < 1u64;
        let v28: US4 = if v20 {
            let v21: US5 = US5::US5_EmptyRange;
            US4::US4_Error(v21)
        } else {
            let v23: bool = v3 > 4738381338321616896u64;
            if v23 {
                let v24: US5 = US5::US5_AboveLargest(v3, 4738381338321616896u64);
                US4::US4_Error(v24)
            } else {
                US4::US4_Ok(v3)
            }
        };
        let v44: u64 = match v28 {
            US4::US4_Error(v30) => {
                let mut v30: US5 = v30;
                let v40: Rc<str> = match v30 {
                    US5::US5_AboveLargest(v32, v33) => {
                        let v32: u64 = v32;
                        let v33: u64 = v33;
                        let v34: Rc<str> = format_real_12(v32);
                        let v37: Rc<str> = format_real_12(v33);
                        let v38: Rc<str> = string_concat(&["max: ", &*v34, " is above the largest supported bound ", &*v37]);
                        v38
                    }
                    US5::US5_EmptyRange => {
                        let v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max must be at least 1"); } LIT.with(|lit| lit.clone()) };
                        v31
                    }
                };
                let v41: Rc<str> = string_concat(&["dice_contract.generate_random_number / ", &*v40]);
                let v42: u64 = near_sdk::env::panic_str(&*v41);
                v42
            }
            US4::US4_Ok(v29) => {
                let v29: u64 = v29;
                v29
            }
        };
        let (mut v45, mut v46): (u64, u64) = { let balance = near_sdk::env::account_balance().as_yoctonear(); (balance as u64, (balance >> 64) as u64) };
        let v47: u64 = near_sdk::env::block_height();
        let v48: u64 = near_sdk::env::block_timestamp();
        let v49: u64 = near_sdk::env::epoch_height();
        let v50: Rc<str> = Rc::<str>::from(near_sdk::env::predecessor_account_id().as_str());
        let v51: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(near_sdk::env::random_seed()));
        let v52: Rc<str> = Rc::<str>::from(near_sdk::env::signer_account_id().as_str());
        let v53: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v52.as_bytes().to_vec()));
        let v54: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v18.as_bytes().to_vec()));
        let v55: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v50.as_bytes().to_vec()));
        let v56: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v16.as_bytes().to_vec()));
        let mut v57: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v49).to_le_bytes().to_vec()));
        let v58: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v48).to_le_bytes().to_vec()));
        let v59: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v47).to_le_bytes().to_vec()));
        let mut v60: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v45).to_le_bytes().to_vec()));
        let v61: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v46).to_le_bytes().to_vec()));
        let v62: i32 = (v61.clone().borrow().len() as i32);
        let v63: i32 = (v60.clone().borrow().len() as i32);
        let v64: i32 = v62.wrapping_add(v63);
        let v65: i32 = (v59.clone().borrow().len() as i32);
        let v66: i32 = v64.wrapping_add(v65);
        let v67: i32 = (v58.clone().borrow().len() as i32);
        let v68: i32 = v66.wrapping_add(v67);
        let v69: i32 = (v57.clone().borrow().len() as i32);
        let v70: i32 = v68.wrapping_add(v69);
        let v71: i32 = (v56.clone().borrow().len() as i32);
        let v72: i32 = v70.wrapping_add(v71);
        let v73: i32 = (v55.clone().borrow().len() as i32);
        let v74: i32 = v72.wrapping_add(v73);
        let v75: i32 = (v54.clone().borrow().len() as i32);
        let v76: i32 = v74.wrapping_add(v75);
        let v77: i32 = (v51.clone().borrow().len() as i32);
        let v78: i32 = v76.wrapping_add(v77);
        let v79: i32 = (v19.clone().borrow().len() as i32);
        let v80: i32 = v78.wrapping_add(v79);
        let v81: i32 = (v53.clone().borrow().len() as i32);
        let mut v82: i32 = v80.wrapping_add(v81);
        let v83: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(vec![<u8>::default(); v82 as usize]));
        { let part = (v61).borrow(); (v83).borrow_mut()[(0i32) as usize..(0i32) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v60).borrow(); (v83).borrow_mut()[(v62) as usize..(v62) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v59).borrow(); (v83).borrow_mut()[(v64) as usize..(v64) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v58).borrow(); (v83).borrow_mut()[(v66) as usize..(v66) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v57).borrow(); (v83).borrow_mut()[(v68) as usize..(v68) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v56).borrow(); (v83).borrow_mut()[(v70) as usize..(v70) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v55).borrow(); (v83).borrow_mut()[(v72) as usize..(v72) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v54).borrow(); (v83).borrow_mut()[(v74) as usize..(v74) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v51).borrow(); (v83).borrow_mut()[(v76) as usize..(v76) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v19).borrow(); (v83).borrow_mut()[(v78) as usize..(v78) as usize + part.len()].copy_from_slice(&part); };
        { let part = (v53).borrow(); (v83).borrow_mut()[(v80) as usize..(v80) as usize + part.len()].copy_from_slice(&part); };
        let v84: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(near_sdk::env::keccak512((v83).borrow().as_slice())));
        let mut v85: bool = v44 == 1u64;
        let v89: i32 = if v85 {
            1i32
        } else {
            let v86: i32 = 0i32;
            let mut v87: u64 = 1u64;
            go_13(v44, v86, v87)
        };
        let v90: i32 = 0i32;
        let (mut v91, mut v92, mut v93): (u64, Rc<RefCell<Vec<u8>>>, i32) = roll_fresh_14(v44, v89, v84.clone(), v90);
        (v0).extend_from_slice(&(v84).borrow());
        let v94: usize = (v0).len();
        let v95: u64 = ((v94) as u64);
        let v96: usize = ((100i32) as usize);
        let v97: u64 = ((v96) as u64);
        let v98: bool = v95 > v97;
        let v100: u64 = if v98 {
            let v99: u64 = v95.wrapping_sub(v97);
            v99
        } else {
            0u64
        };
        let v101: usize = ((v100) as usize);
        let v102: Vec<u8> = (v0).drain(..v101).collect::<Vec<_>>();
        let v103: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
        let mut v123: bool = if v103 {
            true
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v106, mut v107, mut v108, mut v109, mut v110, mut v111): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
            let mut v112: US0 = v110.borrow().l0.clone();
            let v117: i32 = match v112 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let v118: bool = v108.borrow().l0;
            let v119: bool = v118 == false;
            let v121: bool = if v119 {
                false
            } else {
                let mut v120: bool = 20i32 >= v117;
                v120
            };
            let v122: bool = v121 == false;
            v122
        };
        let v223: US2 = if v123 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v127, mut v128, mut v129, mut v130, mut v131, mut v132): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
            let v133: Rc<str> = Rc::<str>::from((v19).borrow().iter().flat_map(|b| [b >> 4, b & 15]).map(|n| char::from(b"0123456789abcdef"[n as usize])).collect::<String>());
            let v134: Rc<str> = Rc::<str>::from((v51).borrow().iter().flat_map(|b| [b >> 4, b & 15]).map(|n| char::from(b"0123456789abcdef"[n as usize])).collect::<String>());
            let v135: Rc<str> = format_real_12(v49);
            let v136: Rc<str> = format_real_12(v48);
            let v137: Rc<str> = format_real_12(v47);
            let v138: Rc<str> = format_real_12(v45);
            let v139: Rc<str> = format_real_12(v46);
            let v183: Rc<str> = Rc::<str>::from((v84).borrow().iter().flat_map(|b| [b >> 4, b & 15]).map(|n| char::from(b"0123456789abcdef"[n as usize])).collect::<String>());
            let v184: Rc<str> = string_concat(&["dice_contract.generate_random_number account_balance_high = ", &*v139, "; account_balance_low = ", &*v138, "; block_height = ", &*v137, "; block_timestamp = ", &*v136, "; epoch_height = ", &*v135, "; key = ", &*v16, "; predecessor = ", &*v50, "; proof = ", &*v18, "; seed = ", &*v134, "; seeds = ", &*v133, "; signer = ", &*v52, "; hash = ", &*v183]);
            let v185: bool = &*v184 == "";
            let v188: Rc<str> = if v185 {
                let v186: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v186
            } else {
                method17(v127.clone(), v128.clone(), v129.clone(), v130.clone(), v131.clone(), v132.clone(), v127.clone(), v128.clone(), v129.clone(), v130.clone(), v131.clone(), v132.clone(), v184, v3, v91)
            };
            { let _ = spiral_trace_hold(&v5); };
            let (mut v191, mut v192, mut v193, mut v194, mut v195, mut v196): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
            let v197: i64 = v191.borrow().l0;
            let v198: i64 = v197.wrapping_add(1i64);
            v191.borrow_mut().l0 = v198;
            let v199: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v200: bool = cfg!(target_arch = "wasm32");
            if v200 {
                let v201: Rc<str> = v194.borrow().l0.clone();
                let v202: bool = &*v201 == "";
                let v209: Rc<str> = if v202 {
                    v188.clone()
                } else {
                    let v203: bool = &*v188 == "";
                    if v203 {
                        let v204: Rc<str> = v194.borrow().l0.clone();
                        v204
                    } else {
                        let v205: Rc<str> = v194.borrow().l0.clone();
                        let v207: Rc<str> = string_concat(&[&*v205, "\n", &*v188]);
                        v207
                    }
                };
                let v211: usize = v209.len();
                let v212: i32 = ((v211) as i32);
                let v213: i32 = v212.wrapping_add(14999i32);
                let v214: i32 = v213.wrapping_div(15000i32);
                let v215: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v216: bool = v188 != v215 ;
                let v218: bool = if v216 {
                    let v217: bool = v214 <= 1i32;
                    v217
                } else {
                    false
                };
                if v218 {
                    v194.borrow_mut().l0 = v209;
                    ()
                } else {
                    v194.borrow_mut().l0 = v215;
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v209); };
                    ()
                }
            } else {
                println!("{}", v188);
                ()
            };
            let mut v221: Rc<dyn Fn(Rc<str>) -> ()> = v192.borrow().l0.clone();
            v221(v188);
            US2::US2_Some(v191, v192, v193, v194, v195, v196)
        };
        { let _ = spiral_trace_hold(&v5); };
        let (mut v226, mut v227, mut v228, mut v229, mut v230, mut v231): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
        let v232: US0 = v230.borrow().l0.clone();
        let v237: i32 = match v232 {
            US0::US0_Critical => {
                50i32
            }
            US0::US0_Debug => {
                20i32
            }
            US0::US0_Info => {
                30i32
            }
            US0::US0_Verbose => {
                10i32
            }
            US0::US0_Warning => {
                40i32
            }
        };
        let v238: bool = v228.borrow().l0;
        let v239: bool = v238 == false;
        let v241: bool = if v239 {
            false
        } else {
            let v240: bool = 50i32 >= v237;
            v240
        };
        let v242: bool = v241 == false;
        let v286: US2 = if v242 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v246, mut v247, mut v248, mut v249, mut v250, mut v251): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
            { let _ = spiral_trace_hold(&v5); };
            let (mut v254, mut v255, mut v256, mut v257, mut v258, mut v259): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
            let v260: i64 = v254.borrow().l0;
            let v261: i64 = v260.wrapping_add(1i64);
            v254.borrow_mut().l0 = v261;
            let v262: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v263: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v264: bool = cfg!(target_arch = "wasm32");
            if v264 {
                let v265: Rc<str> = v257.borrow().l0.clone();
                let v266: bool = &*v265 == "";
                let v273: Rc<str> = if v266 {
                    v262.clone()
                } else {
                    let v267: bool = &*v262 == "";
                    if v267 {
                        let v268: Rc<str> = v257.borrow().l0.clone();
                        v268
                    } else {
                        let v269: Rc<str> = v257.borrow().l0.clone();
                        let v271: Rc<str> = string_concat(&[&*v269, "\n", &*v262]);
                        v271
                    }
                };
                let v275: usize = v273.len();
                let v276: i32 = ((v275) as i32);
                let v277: i32 = v276.wrapping_add(14999i32);
                let v278: i32 = v277.wrapping_div(15000i32);
                let v279: bool = v262 != v262 ;
                let v281: bool = if v279 {
                    let v280: bool = v278 <= 1i32;
                    v280
                } else {
                    false
                };
                if v281 {
                    v257.borrow_mut().l0 = v273;
                    ()
                } else {
                    v257.borrow_mut().l0 = v262.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v273); };
                    ()
                }
            } else {
                println!("{}", v262);
                ()
            };
            let mut v284: Rc<dyn Fn(Rc<str>) -> ()> = v255.borrow().l0.clone();
            v284(v262);
            US2::US2_Some(v254, v255, v256, v257, v258, v259)
        };
        v91
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method18(mut v0: Vec<u8>) -> Vec<u8> {
    v0
}
fn method19(mut v0: Rc<Vec<u8>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let v3: bool = v1 < 0i32;
        if v3 {
            return v2;
        } else {
            let v4: usize = ((v1) as usize);
            let v5: u8 = (v0)[v4].clone();
            let v6: i32 = v1.wrapping_sub(1i32);
            let v7: Rc<UH0> = Rc::new(UH0::UH0_Cons(v5, v2));
            (v1, v2) = (v6, v7);
            continue;
        }
    }
}
fn method21(mut v0: Rc<UH1>, mut v1: Rc<UH1>) -> Rc<UH1> {
    loop {
        match Rc::unwrap_or_clone(v0) {
            UH1::UH1_Cons(v2, v3) => {
                let mut v2: US6 = v2;
                let v3: Rc<UH1> = v3;
                let v4: Rc<UH1> = Rc::new(UH1::UH1_Cons(v2, v1));
                (v0, v1) = (v3, v4);
                continue;
            }
            UH1::UH1_Nil => {
                return v1;
            }
        }
    }
}
fn go_20(mut v0: Rc<UH0>, mut v1: Rc<UH1>) -> US8 {
    loop {
        match Rc::unwrap_or_clone(v0) {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: u8 = v2;
                let v3: Rc<UH0> = v3;
                let v4: bool = v2 >= 1u8;
                let v6: bool = if v4 {
                    let v5: bool = v2 <= 6u8;
                    v5
                } else {
                    false
                };
                let v27: US7 = if v6 {
                    let v7: u8 = v2.wrapping_sub(1u8);
                    let mut v8: i32 = (v7 as i32);
                    let mut v9: bool = 0i32 == v8;
                    let v24: US6 = if v9 {
                        US6::US6_One
                    } else {
                        let v11: bool = 1i32 == v8;
                        if v11 {
                            US6::US6_Two
                        } else {
                            let v13: bool = 2i32 == v8;
                            if v13 {
                                US6::US6_Three
                            } else {
                                let mut v15: bool = 3i32 == v8;
                                if v15 {
                                    US6::US6_Four
                                } else {
                                    let v17: bool = 4i32 == v8;
                                    if v17 {
                                        US6::US6_Five
                                    } else {
                                        US6::US6_Six
                                    }
                                }
                            }
                        }
                    };
                    US7::US7_Some(v24)
                } else {
                    US7::US7_None
                };
                match v27 {
                    US7::US7_None => {
                        return US8::US8_None;
                    }
                    US7::US7_Some(v28) => {
                        let v28: US6 = v28;
                        let v29: Rc<UH1> = Rc::new(UH1::UH1_Cons(v28, v1));
                        (v0, v1) = (v3, v29);
                        continue;
                    }
                }
            }
            UH0::UH0_Nil => {
                let v34: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
                let v35: Rc<UH1> = method21(v1, v34);
                return US8::US8_Some(v35);
            }
        }
    }
}
fn method22(mut v0: Rc<UH1>, mut v1: i32) -> i32 {
    loop {
        match Rc::unwrap_or_clone(v0) {
            UH1::UH1_Cons(v2, v3) => {
                let mut v2: US6 = v2;
                let v3: Rc<UH1> = v3;
                let v4: i32 = v1.wrapping_add(1i32);
                (v0, v1) = (v3, v4);
                continue;
            }
            UH1::UH1_Nil => {
                return v1;
            }
        }
    }
}
fn go_23(mut v0: u64, mut v1: i32, mut v2: Rc<UH1>, mut v3: u64) -> US9 {
    loop {
        let v4: bool = v1 <= 0i32;
        if v4 {
            let v5: bool = v3 < v0;
            if v5 {
                let v6: u64 = v3.wrapping_add(1u64);
                return US9::US9_Some(v6);
            } else {
                return US9::US9_None;
            }
        } else {
            match Rc::unwrap_or_clone(v2) {
                UH1::UH1_Cons(v10, v11) => {
                    let mut v10: US6 = v10;
                    let v11: Rc<UH1> = v11;
                    let mut v12: i32 = (v10.tag() as i32);
                    let v13: u64 = (v12 as u64);
                    let v14: bool = v13 >= v0;
                    let v19: bool = if v14 {
                        true
                    } else {
                        let mut v15: u64 = v0.wrapping_sub(1u64);
                        let v16: u64 = v15.wrapping_sub(v13);
                        let v17: u64 = v16.wrapping_div(6u64);
                        let v18: bool = v3 > v17;
                        v18
                    };
                    if v19 {
                        return US9::US9_None;
                    } else {
                        let v21: i32 = v1.wrapping_sub(1i32);
                        let v22: u64 = v3.wrapping_mul(6u64);
                        let v23: u64 = v22.wrapping_add(v13);
                        (v1, v2, v3) = (v21, v11, v23);
                        continue;
                    }
                }
                UH1::UH1_Nil => {
                    return US9::US9_None;
                }
            }
        }
    }
}
fn method24(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: &Rc<RefCell<Mut0>>, mut v7: &Rc<RefCell<Mut1>>, mut v8: &Rc<RefCell<Mut2>>, mut v9: &Rc<RefCell<Mut3>>, mut v10: &Rc<RefCell<Mut4>>, mut v11: Option<i64>, mut v12: u64, mut v13: Rc<str>, mut v14: Rc<str>) -> Rc<str> {
    let mut v15: bool = cfg!(target_arch = "wasm32");
    let v44: Rc<str> = if v15 {
        let v16: Rc<str> = format_real_12(v12);
        let v24: Rc<str> = string_concat(&["d dice_contract.roll_within_bounds / { max = ", &*v16, "; rolls = ", &*v13, "; result = ", &*v14, " }"]);
        v24
    } else {
        let v25: i64 = v0.borrow().l0;
        let v26: Rc<str> = time_7(v6, v7, v8, v9, v10, v11);
        let v28: Rc<str> = format_real_9(v25);
        let mut v30: Rc<str> = level_str_11();
        let v35: Rc<str> = format_real_12(v12);
        let v43: Rc<str> = string_concat(&[&*v26, " ", &*v28, &*v30, " dice_contract.roll_within_bounds / { max = ", &*v35, "; rolls = ", &*v13, "; result = ", &*v14, " }"]);
        v43
    };
    method4(v44)
}
fn closure8() -> Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> = Rc::new(move |mut v0: u64, mut v1: Vec<u8>| -> Option<u64> {
        let v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v3); };
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
        let mut v12: US0 = US0::US0_Debug;
        v10.borrow_mut().l0 = v12;
        let v13: Vec<u8> = method18(v1.clone());
        let v14: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v13));
        let mut v15: Rc<Vec<u8>> = Rc::new((v14).borrow().clone());
        let v16: usize = (v15).len();
        let v17: i32 = ((v16) as i32);
        let v18: i32 = v17.wrapping_sub(1i32);
        let v19: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let v20: Rc<UH0> = method19(v15, v18, v19);
        let v21: bool = v0 < 1u64;
        let v29: US4 = if v21 {
            let v22: US5 = US5::US5_EmptyRange;
            US4::US4_Error(v22)
        } else {
            let v24: bool = v0 > 4738381338321616896u64;
            if v24 {
                let v25: US5 = US5::US5_AboveLargest(v0, 4738381338321616896u64);
                US4::US4_Error(v25)
            } else {
                US4::US4_Ok(v0)
            }
        };
        let mut v30: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
        let v31: US8 = go_20(v20, v30);
        let v41: US9 = match v29 {
            US4::US4_Ok(v32) => {
                let v32: u64 = v32;
                match v31 {
                    US8::US8_Some(v33) => {
                        let v33: Rc<UH1> = v33;
                        let v34: i32 = 0i32;
                        let v35: i32 = method22(v33.clone(), v34);
                        let v36: u64 = 0u64;
                        go_23(v32, v35, v33, v36)
                    }
                    _ => {
                        US9::US9_None
                    }
                }
            }
            _ => {
                US9::US9_None
            }
        };
        let v46: Option<u64> = match v41 {
            US9::US9_None => {
                let v44: Option<u64> = None;
                v44
            }
            US9::US9_Some(v42) => {
                let v42: u64 = v42;
                let v43: Option<u64> = Some(v42.clone());
                v43
            }
        };
        let v47: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
        let v67: bool = if v47 {
            true
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v50, mut v51, mut v52, mut v53, mut v54, mut v55): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v56: US0 = v54.borrow().l0.clone();
            let v61: i32 = match v56 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let v62: bool = v52.borrow().l0;
            let v63: bool = v62 == false;
            let v65: bool = if v63 {
                false
            } else {
                let v64: bool = 20i32 >= v61;
                v64
            };
            let v66: bool = v65 == false;
            v66
        };
        let v114: US2 = if v67 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v71, mut v72, mut v73, mut v74, mut v75, mut v76): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v77: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1)).s() });
            let v78: Rc<str> = Rc::<str>::from(match &v46 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let v79: Rc<str> = method24(&v71, &v72, &v73, &v74, &v75, v76.clone(), &v71, &v72, &v73, &v74, &v75, v76.clone(), v0, v77, v78);
            { let _ = spiral_trace_hold(&v3); };
            let (mut v82, mut v83, mut v84, mut v85, mut v86, mut v87): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v88: i64 = v82.borrow().l0;
            let v89: i64 = v88.wrapping_add(1i64);
            v82.borrow_mut().l0 = v89;
            let v90: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v91: bool = cfg!(target_arch = "wasm32");
            if v91 {
                let v92: Rc<str> = v85.borrow().l0.clone();
                let v93: bool = &*v92 == "";
                let v100: Rc<str> = if v93 {
                    v79.clone()
                } else {
                    let v94: bool = &*v79 == "";
                    if v94 {
                        let v95: Rc<str> = v85.borrow().l0.clone();
                        v95
                    } else {
                        let v96: Rc<str> = v85.borrow().l0.clone();
                        let v98: Rc<str> = string_concat(&[&*v96, "\n", &*v79]);
                        v98
                    }
                };
                let v102: usize = v100.len();
                let v103: i32 = ((v102) as i32);
                let v104: i32 = v103.wrapping_add(14999i32);
                let v105: i32 = v104.wrapping_div(15000i32);
                let v106: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v107: bool = v79 != v106 ;
                let v109: bool = if v107 {
                    let v108: bool = v105 <= 1i32;
                    v108
                } else {
                    false
                };
                if v109 {
                    v85.borrow_mut().l0 = v100;
                    ()
                } else {
                    v85.borrow_mut().l0 = v106;
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v100); };
                    ()
                }
            } else {
                println!("{}", v79);
                ()
            };
            let mut v112: Rc<dyn Fn(Rc<str>) -> ()> = v83.borrow().l0.clone();
            v112(v79);
            US2::US2_Some(v82, v83, v84, v85, v86, v87)
        };
        { let _ = spiral_trace_hold(&v3); };
        let (mut v117, mut v118, mut v119, mut v120, mut v121, mut v122): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
        let mut v123: US0 = v121.borrow().l0.clone();
        let v128: i32 = match v123 {
            US0::US0_Critical => {
                50i32
            }
            US0::US0_Debug => {
                20i32
            }
            US0::US0_Info => {
                30i32
            }
            US0::US0_Verbose => {
                10i32
            }
            US0::US0_Warning => {
                40i32
            }
        };
        let v129: bool = v119.borrow().l0;
        let v130: bool = v129 == false;
        let v132: bool = if v130 {
            false
        } else {
            let v131: bool = 50i32 >= v128;
            v131
        };
        let v133: bool = v132 == false;
        let v177: US2 = if v133 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v137, mut v138, mut v139, mut v140, mut v141, mut v142): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            { let _ = spiral_trace_hold(&v3); };
            let (mut v145, mut v146, mut v147, mut v148, mut v149, mut v150): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v151: i64 = v145.borrow().l0;
            let v152: i64 = v151.wrapping_add(1i64);
            v145.borrow_mut().l0 = v152;
            let v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v154: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v155: bool = cfg!(target_arch = "wasm32");
            if v155 {
                let v156: Rc<str> = v148.borrow().l0.clone();
                let v157: bool = &*v156 == "";
                let v164: Rc<str> = if v157 {
                    v153.clone()
                } else {
                    let v158: bool = &*v153 == "";
                    if v158 {
                        let v159: Rc<str> = v148.borrow().l0.clone();
                        v159
                    } else {
                        let v160: Rc<str> = v148.borrow().l0.clone();
                        let v162: Rc<str> = string_concat(&[&*v160, "\n", &*v153]);
                        v162
                    }
                };
                let v166: usize = v164.len();
                let v167: i32 = ((v166) as i32);
                let v168: i32 = v167.wrapping_add(14999i32);
                let v169: i32 = v168.wrapping_div(15000i32);
                let v170: bool = v153 != v153 ;
                let v172: bool = if v170 {
                    let v171: bool = v169 <= 1i32;
                    v171
                } else {
                    false
                };
                if v172 {
                    v148.borrow_mut().l0 = v164;
                    ()
                } else {
                    v148.borrow_mut().l0 = v153.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v164); };
                    ()
                }
            } else {
                println!("{}", v153);
                ()
            };
            let mut v175: Rc<dyn Fn(Rc<str>) -> ()> = v146.borrow().l0.clone();
            v175(v153);
            US2::US2_Some(v145, v146, v147, v148, v149, v150)
        };
        v46
    }); } CLOSURE.with(|closure| closure.clone())
}
pub fn dice_contract_new() -> (u32, Vec<u8>) {
    closure0()()
}
pub fn dice_contract_contribute_seed(v0: &mut Vec<u8>, v1: Vec<u8>) -> () {
    closure4()(v0, v1)
}
pub fn dice_contract_generate_random_number(v0: &mut Vec<u8>, v1: std::string::String, v2: std::string::String, v3: u64) -> u64 {
    closure7()(v0, v1, v2, v3)
}
pub fn dice_contract_roll_within_bounds(v0: u64, v1: Vec<u8>) -> Option<u64> {
    closure8()(v0, v1)
}
pub type SpiralShape_3e912ab56359 = Mut0;
pub type SpiralShape_3e0040a0a65b = Mut1;
pub type SpiralShape_8c8c1533c8a6 = Mut2;
pub type SpiralShape_97df63ebabc3 = Mut3;
pub type SpiralShape_bfe005d97257 = Mut4;
pub type SpiralShape_66576ccbb4a6 = Mut5;
