#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)] #![recursion_limit = "512"]
use std::cell::RefCell;
use std::rc::Rc;
#[derive(near_sdk::PanicOnDefault, borsh::BorshDeserialize, borsh::BorshSerialize)]
pub struct OldState {
    version: u32,
    seeds: near_sdk::store::vec::Vector<u8>,
}
#[near_sdk::near(contract_state)]
#[derive(near_sdk::PanicOnDefault)]
pub struct State((u32, Vec<u8>));
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
    pub fn contribute_seed(&mut self, seed: Vec<u8>) {
        dice_contract_contribute_seed(&mut self.0.1, seed)
    }
    pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) {
        self.contribute_seed(seed)
    }
    pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
        dice_contract_generate_random_number(&mut self.0.1, key, proof, max)
    }
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
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
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
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) }; }
    if (bytes[from as usize] & 0xC0) == 0x80 || (to + 1 < length && (bytes[(to + 1) as usize] & 0xC0) == 0x80) { std::process::exit(3); }
    let slice = &bytes[from as usize..(to + 1) as usize];
    match std::str::from_utf8(slice) { Ok(text) => Rc::<str>::from(text), Err(error) => Rc::<str>::from(std::str::from_utf8(&slice[..error.valid_up_to()]).unwrap_or("")) }
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
enum UH0 {
    UH0_Nil,
    UH0_Cons(u8, Rc<UH0>),
}
#[derive(Clone)]
enum US4 {
    US4_Some(u64, Rc<UH0>),
    US4_None,
}
#[derive(Clone)]
enum UH1 {
    UH1_StreamCons(u64, Rc<dyn Fn() -> Rc<UH1>>),
    UH1_StreamNil,
}
#[derive(Clone)]
enum US5 {
    US5_Some(u64),
    US5_None,
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
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = get_environment_variable_1(v1);
    ;
    ;
    ;
    ;
    ;
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let v4: Rc<str> = Rc::<str>::from(v3.to_lowercase());
    let v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
    let v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
    let mut v13: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new(Vec::new()));
    let v14: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v11, v14));
    let v15: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v9, v15));
    let v16: US0 = US0::US0_Info;
    v13.borrow_mut().push((v7, v16));
    let v17: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v5, v17));
    let v18: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v3, v18));
    let v19: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v12, v19));
    let v20: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v10, v20));
    let v21: US0 = US0::US0_Info;
    v13.borrow_mut().push((v8, v21));
    let v22: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v6, v22));
    let v23: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v4, v23));
    let v24: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v13.borrow().clone());
    let v25: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let v26: i32 = (v25.clone().borrow().len() as i32);
    let v27: US1 = US1::US1_None;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: v26, l1: v27 }));
    while method2(&v28) {
        let v30: i32 = v28.borrow().l0;
        let v31: i32 = v30.wrapping_sub(1i32);
        let v32: US1 = v28.borrow().l1.clone();
        let (mut v33, mut v34): (Rc<str>, US0) = v25.borrow()[v31 as usize].clone();
        let v41: US1 = match &v32 {
            US1::US1_None => {
                let v36: bool = v33 == v2 ;
                if v36 {
                    US1::US1_Some(v34)
                } else {
                    US1::US1_None
                }
            }
            US1::US1_Some(v35) => {
                let v35: US0 = v35.clone();
                v32
            }
        };
        v28.borrow_mut().l0 = v31;
        v28.borrow_mut().l1 = v41;
        ()
    };
    let v42: US1 = v28.borrow().l1.clone();
    let v43: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let mut v44: Rc<dyn Fn(Rc<str>) -> ()> = closure2();
    let v45: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v44 }));
    let v46: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v48: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v47 }));
    let v51: US0 = match v42 {
        US1::US1_None => {
            v0
        }
        US1::US1_Some(v49) => {
            let v49: US0 = v49;
            v49
        }
    };
    let mut v52: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v51 }));
    let v53: Option<i64> = None;
    (v43, v45, v46, v48, v52, v53)
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
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v4, mut v5, mut v6, mut v7, mut v8, mut v9): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v3);
        let mut v10: US0 = US0::US0_Debug;
        v8.borrow_mut().l0 = v10;
        let v11: Vec<u8> = std::vec::Vec::<u8>::new();
        (3u32, v11)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method4(mut v0: Option<[i64; 3]>) -> Option<[i64; 3]> {
    v0
}
fn closure5() -> Rc<dyn Fn(([i64; 3])) -> US3> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(([i64; 3])) -> US3> = Rc::new(move |mut v0: ([i64; 3])| -> US3 {
        let mut v1: [i64; 3] = (v0);
        US3::US3_Some(v1)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let v6: Option<[i64; 3]> = spiral_cfg_local_clock();
    let v7: Option<[i64; 3]> = method4(v6);
    let mut v8: Rc<dyn Fn(([i64; 3])) -> US3> = closure5();
    let mut v9: Option<US3> = v7.map(|x| v8(x));
    let v11: US3 = US3::US3_None;
    let mut v12: US3 = v11.clone();
    let mut v13: US3 = v9.unwrap_or(v12);
    let v27: u64 = match v13 {
        US3::US3_None => {
            let v23: u64 = spiral_cfg_epoch_nanos();
            let v24: u64 = v23.wrapping_div(1000000000u64);
            let v25: u64 = v24.wrapping_rem(86400u64);
            v25
        }
        US3::US3_Some(v14) => {
            let v14: [i64; 3] = v14;
            let v15: i64 = v14[0];
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
    let mut v28: u64 = v27.wrapping_div(3600u64);
    let v29: u64 = v28.wrapping_rem(24u64);
    let v30: bool = v29 < 10u64;
    let v33: Rc<str> = if v30 {
        let v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v31
    } else {
        let v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v32
    };
    let v34: Rc<str> = Rc::<str>::from((v29).to_string());
    let v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v34));
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) }));
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
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v43));
    let v45: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v44));
    let v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) }));
    let mut v47: u64 = v27.wrapping_rem(60u64);
    let v48: bool = v47 < 10u64;
    let v51: Rc<str> = if v48 {
        let v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v49
    } else {
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v50
    };
    let mut v52: Rc<str> = Rc::<str>::from((v47).to_string());
    let v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let v54: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v53));
    v54
}
fn method7(mut v0: &Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3;
    ()
}
fn format_real_6(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method7(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method5() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let v4: Rc<str> = format_real_6(v3);
    let v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method10(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
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
fn method11(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let mut v3: i32 = v1.wrapping_sub(1i32);
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
fn method9(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let mut v3: i32 = method10(v0.clone(), v1, v2);
    let v4: i32 = v1.wrapping_sub(1i32);
    let v5: Rc<str> = string_slice(&v0, v3 as i64, v4 as i64);
    let v6: i32 = (v5.clone().len() as i32);
    let v7: i32 = method11(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5, 0i32 as i64, v7 as i64);
    v8
}
fn format_real_12(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method7(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method8(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: usize, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.contribute_seed"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<usize>") } } (&&W(&v8)).s() });
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_len = "); } LIT.with(|lit| lit.clone()) }, v18));
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", v19, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess"); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v9));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v23));
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v24, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v25));
    method9(v26)
}
fn closure6() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure7() -> Rc<dyn Fn() -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> ()> = Rc::new(move || -> () {
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method13() -> Rc<dyn Fn() -> ()> {
    closure7()
}
fn closure4() -> Rc<dyn Fn(&mut Vec<u8>, Vec<u8>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut Vec<u8>, Vec<u8>) -> ()> = Rc::new(move |mut v0: &mut Vec<u8>, mut v1: Vec<u8>| -> () {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v3); };
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
        let mut v12: US0 = US0::US0_Debug;
        v10.borrow_mut().l0 = v12;
        let mut v13: usize = ((v1).len() as usize);
        let v14: usize = ((100i32) as usize);
        let v15: Vec<u8> = { let s = &mut *(v0); s.extend_from_slice(&(v1)); let excess = s.len().saturating_sub(v14); s.drain(..excess).collect::<std::vec::Vec<u8>>() };
        let v16: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
        let v36: bool = if v16 {
            true
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v19, mut v20, mut v21, mut v22, mut v23, mut v24): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v25: US0 = v23.borrow().l0.clone();
            let v30: i32 = match v25 {
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
            let v31: bool = v21.borrow().l0;
            let v32: bool = v31 == false;
            let v34: bool = if v32 {
                false
            } else {
                let v33: bool = 20i32 >= v30;
                v33
            };
            let v35: bool = v34 == false;
            v35
        };
        let v84: US2 = if v36 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v40, mut v41, mut v42, mut v43, mut v44, mut v45): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v46: Rc<str> = method3(&v40, &v41, &v42, &v43, &v44, v45.clone());
            let mut v47: Rc<str> = method5();
            let v48: Rc<str> = { const D: &[u8; 16] = b"0123456789abcdef"; let b = &(v15); let mut s = std::string::String::with_capacity(b.len() * 2); for x in b.iter() { s.push(D[(*x >> 4) as usize] as char); s.push(D[(*x & 15) as usize] as char); } std::rc::Rc::<str>::from(s) };
            let v49: Rc<str> = method8(&v40, &v41, &v42, &v43, &v44, v45, v46, v47, v13, v48);
            { let _ = spiral_trace_hold(&v3); };
            let (mut v52, mut v53, mut v54, mut v55, mut v56, mut v57): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v58: i64 = v52.borrow().l0;
            let v59: i64 = v58.wrapping_add(1i64);
            v52.borrow_mut().l0 = v59;
            let v60: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v61: bool = cfg!(target_arch = "wasm32");
            if v61 {
                let v62: Rc<str> = v55.borrow().l0.clone();
                let v63: bool = &*v62 == "";
                let v70: Rc<str> = if v63 {
                    v49.clone()
                } else {
                    let v64: bool = &*v49 == "";
                    if v64 {
                        let v65: Rc<str> = v55.borrow().l0.clone();
                        v65
                    } else {
                        let v66: Rc<str> = v55.borrow().l0.clone();
                        let v67: Rc<str> = Rc::<str>::from(format!("{}{}", v66, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                        let v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v49.clone()));
                        v68
                    }
                };
                let v72: usize = v70.len();
                let v73: i32 = ((v72) as i32);
                let mut v74: i32 = v73.wrapping_add(14999i32);
                let v75: i32 = v74.wrapping_div(15000i32);
                let v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v77: bool = v49 != v76 ;
                let v79: bool = if v77 {
                    let mut v78: bool = v75 <= 1i32;
                    v78
                } else {
                    false
                };
                if v79 {
                    v55.borrow_mut().l0 = v70;
                    ()
                } else {
                    v55.borrow_mut().l0 = v76;
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v70); };
                    ()
                }
            } else {
                println!("{}", v49);
                ()
            };
            let mut v82: Rc<dyn Fn(Rc<str>) -> ()> = v53.borrow().l0.clone();
            v82(v49);
            US2::US2_Some(v52, v53, v54, v55, v56, v57)
        };
        let v85: Rc<dyn Fn() -> ()> = method13();
        let v86: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
        let v106: bool = if v86 {
            true
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v89, mut v90, mut v91, mut v92, mut v93, mut v94): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v95: US0 = v93.borrow().l0.clone();
            let v100: i32 = match v95 {
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
            let v101: bool = v91.borrow().l0;
            let v102: bool = v101 == false;
            let v104: bool = if v102 {
                false
            } else {
                let v103: bool = 20i32 >= v100;
                v103
            };
            let mut v105: bool = v104 == false;
            v105
        };
        let v152: US2 = if v106 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v110, mut v111, mut v112, mut v113, mut v114, mut v115): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v116: Rc<str> = method3(&v110, &v111, &v112, &v113, &v114, v115);
            let v117: Rc<str> = method5();
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
                let mut v132: bool = &*v131 == "";
                let v139: Rc<str> = if v132 {
                    v128.clone()
                } else {
                    let v133: bool = &*v128 == "";
                    if v133 {
                        let v134: Rc<str> = v123.borrow().l0.clone();
                        v134
                    } else {
                        let mut v135: Rc<str> = v123.borrow().l0.clone();
                        let v136: Rc<str> = Rc::<str>::from(format!("{}{}", v135, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                        let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v128.clone()));
                        v137
                    }
                };
                let v141: usize = v139.len();
                let v142: i32 = ((v141) as i32);
                let v143: i32 = v142.wrapping_add(14999i32);
                let v144: i32 = v143.wrapping_div(15000i32);
                let v145: bool = v128 != v128 ;
                let v147: bool = if v145 {
                    let mut v146: bool = v144 <= 1i32;
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
fn format_real_14(mut v0: u64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method7(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method15(mut v0: u64, mut v1: u64, mut v2: Vec<u8>, mut v3: u64) -> u64 {
    loop {
        let v4: bool = v3 >= 8u64;
        if v4 {
            let v5: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::keccak512(&(v2)); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
            let v6: u64 = 0u64;
            (v2, v3) = (v5, v6);
            continue;
        } else {
            let mut v8: u64 = (0..8usize).fold(0u64, |w, j| w | (u64::from((v2)[(8 * (v3) as usize + j) % (v2).len()]) << (8 * j)));
            let mut v9: bool = v8 <= v1;
            if v9 {
                let mut v10: u64 = v8.wrapping_rem(v0);
                let v11: u64 = v10.wrapping_add(1u64);
                return v11;
            } else {
                let mut v12: u64 = v3.wrapping_add(1u64);
                v3 = v12;
                continue;
            }
        }
    }
}
fn method16(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: u64, mut v10: std::string::String, mut v11: std::string::String, mut v12: u64, mut v13: u64, mut v14: u64, mut v15: Rc<str>, mut v16: std::string::String, mut v17: std::string::String, mut v18: Rc<str>, mut v19: Rc<str>, mut v20: Rc<str>) -> Rc<str> {
    let v21: i64 = v0.borrow().l0;
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = format_real_12(v21);
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v7));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.generate_random_number"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_14(v8);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) }, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v30, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = format_real_14(v9);
    let v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v34));
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("key"); } LIT.with(|lit| lit.clone()) }));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v10)).s() });
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("proof"); } LIT.with(|lit| lit.clone()) }));
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let mut v44: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v11)).s() });
    let v45: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v44));
    let v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_timestamp"); } LIT.with(|lit| lit.clone()) }));
    let v48: Rc<str> = Rc::<str>::from(format!("{}{}", v47, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v49: Rc<str> = format_real_14(v12);
    let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
    let v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_height"); } LIT.with(|lit| lit.clone()) }));
    let v53: Rc<str> = Rc::<str>::from(format!("{}{}", v52, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v54: Rc<str> = format_real_14(v13);
    let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v53, v54));
    let v56: Rc<str> = Rc::<str>::from(format!("{}{}", v55, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v57: Rc<str> = Rc::<str>::from(format!("{}{}", v56, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epoch_height"); } LIT.with(|lit| lit.clone()) }));
    let v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v59: Rc<str> = format_real_14(v14);
    let v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
    let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v62: Rc<str> = Rc::<str>::from(format!("{}{}", v61, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_balance"); } LIT.with(|lit| lit.clone()) }));
    let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v15));
    let v65: Rc<str> = Rc::<str>::from(format!("{}{}", v64, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v66: Rc<str> = Rc::<str>::from(format!("{}{}", v65, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("signer_account_id"); } LIT.with(|lit| lit.clone()) }));
    let v67: Rc<str> = Rc::<str>::from(format!("{}{}", v66, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v68: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v16)).s() });
    let v69: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v68));
    let v70: Rc<str> = Rc::<str>::from(format!("{}{}", v69, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v71: Rc<str> = Rc::<str>::from(format!("{}{}", v70, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("predecessor_account_id"); } LIT.with(|lit| lit.clone()) }));
    let v72: Rc<str> = Rc::<str>::from(format!("{}{}", v71, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v73: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v17)).s() });
    let mut v74: Rc<str> = Rc::<str>::from(format!("{}{}", v72, v73));
    let v75: Rc<str> = Rc::<str>::from(format!("{}{}", v74, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v76: Rc<str> = Rc::<str>::from(format!("{}{}", v75, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed"); } LIT.with(|lit| lit.clone()) }));
    let v77: Rc<str> = Rc::<str>::from(format!("{}{}", v76, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let mut v78: Rc<str> = Rc::<str>::from(format!("{}{}", v77, v18));
    let v79: Rc<str> = Rc::<str>::from(format!("{}{}", v78, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v80: Rc<str> = Rc::<str>::from(format!("{}{}", v79, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) }));
    let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", v80, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let mut v82: Rc<str> = Rc::<str>::from(format!("{}{}", v81, v19));
    let v83: Rc<str> = Rc::<str>::from(format!("{}{}", v82, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v84: Rc<str> = Rc::<str>::from(format!("{}{}", v83, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash"); } LIT.with(|lit| lit.clone()) }));
    let v85: Rc<str> = Rc::<str>::from(format!("{}{}", v84, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v86: Rc<str> = Rc::<str>::from(format!("{}{}", v85, v20));
    let v87: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v86));
    let v88: Rc<str> = Rc::<str>::from(format!("{}{}", v87, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v89: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v88));
    method9(v89)
}
fn method17() -> Rc<dyn Fn() -> ()> {
    closure7()
}
fn closure8() -> Rc<dyn Fn(&mut Vec<u8>, std::string::String, std::string::String, u64) -> u64> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut Vec<u8>, std::string::String, std::string::String, u64) -> u64> = Rc::new(move |mut v0: &mut Vec<u8>, mut v1: std::string::String, mut v2: std::string::String, mut v3: u64| -> u64 {
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v5); };
        let v7: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v8, mut v9, mut v10, mut v11, mut v12, mut v13): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
        let v14: US0 = US0::US0_Debug;
        v12.borrow_mut().l0 = v14;
        let v15: bool = v3 == 0u64;
        if v15 {
            let v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.generate_random_number / max must be at least 1"); } LIT.with(|lit| lit.clone()) };
            let v17: u64 = { #[cfg(target_arch = "wasm32")] near_sdk::env::panic_str(&*(v16.clone())); #[cfg(not(target_arch = "wasm32"))] std::panic::panic_any::<std::string::String>((v16).to_string()) };
            v17
        } else {
            let v18: bool = v3 > 4738381338321616896u64;
            if v18 {
                let v19: Rc<str> = format_real_14(v3);
                let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.generate_random_number / max: "); } LIT.with(|lit| lit.clone()) }, v19));
                let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" is above the largest supported bound "); } LIT.with(|lit| lit.clone()) }));
                let v22: u64 = 4738381338321616896u64;
                let v23: Rc<str> = format_real_14(v22);
                let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v23));
                let v25: u64 = { #[cfg(target_arch = "wasm32")] near_sdk::env::panic_str(&*(v24.clone())); #[cfg(not(target_arch = "wasm32"))] std::panic::panic_any::<std::string::String>((v24).to_string()) };
                v25
            } else {
                let v26: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::random_seed(); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
                let v27: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::epoch_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
                let mut v28: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
                let v29: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_timestamp(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
                let v30: u128 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::account_balance().as_yoctonear(); #[cfg(not(target_arch = "wasm32"))] let v = 1u128; v };
                let v31: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::signer_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
                let v32: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::predecessor_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
                let v33: Vec<u8> = (v0).clone();
                let v34: _ = (v27).to_le_bytes().to_vec();
                let v35: Vec<u8> = (v34).clone();
                let v36: _ = (v28).to_le_bytes().to_vec();
                let v37: Vec<u8> = (v36).clone();
                let v38: _ = (v29).to_le_bytes().to_vec();
                let v39: Vec<u8> = (v38).clone();
                let v40: u128 = (v30.clone());
                let v41: _ = (v40).to_le_bytes().to_vec();
                let v42: Vec<u8> = (v41).clone();
                let v43: &[u8] = (v31).as_bytes();
                let mut v44: Vec<u8> = (v43).to_vec();
                let v45: &[u8] = (v32).as_bytes();
                let v46: Vec<u8> = (v45).to_vec();
                let mut v47: Vec<u8> = (v2).as_bytes().to_vec();
                let v48: Vec<u8> = (v1).as_bytes().to_vec();
                let v49: Rc<RefCell<Vec<Vec<u8>>>> = Rc::new(RefCell::new(vec![v26.clone(), v33.clone(), v35, v37, v39, v42, v44, v46, v47, v48]));
                let v50: Vec<Vec<u8>> = (v49).borrow().clone();
                let v51: Vec<u8> = (v50).concat();
                let mut v52: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::keccak512(&(v51)); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
                let v53: usize = ((100i32) as usize);
                let v54: Vec<u8> = { let s = &mut *(v0); s.extend_from_slice(&(v52.clone())); let excess = s.len().saturating_sub(v53); s.drain(..excess).collect::<std::vec::Vec<u8>>() };
                let mut v55: u64 = 18446744073709551615u64.wrapping_sub(v3);
                let v56: u64 = v55.wrapping_add(1u64);
                let v57: u64 = v56.wrapping_rem(v3);
                let v58: u64 = 18446744073709551615u64.wrapping_sub(v57);
                let v59: u64 = 0u64;
                let v60: u64 = method15(v3, v58, v52.clone(), v59);
                let v61: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let mut v81: bool = if v61 {
                    true
                } else {
                    { let _ = spiral_trace_hold(&v5); };
                    let (mut v64, mut v65, mut v66, mut v67, mut v68, mut v69): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
                    let v70: US0 = v68.borrow().l0.clone();
                    let v75: i32 = match v70 {
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
                    let v76: bool = v66.borrow().l0;
                    let v77: bool = v76 == false;
                    let v79: bool = if v77 {
                        false
                    } else {
                        let mut v78: bool = 20i32 >= v75;
                        v78
                    };
                    let v80: bool = v79 == false;
                    v80
                };
                let v137: US2 = if v81 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v5); };
                    let (mut v85, mut v86, mut v87, mut v88, mut v89, mut v90): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
                    let v91: Rc<str> = method3(&v85, &v86, &v87, &v88, &v89, v90.clone());
                    let v92: Rc<str> = method5();
                    let v93: u128 = (v30);
                    let v94: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<u128>") } } (&&W(&v93)).s() });
                    let v96: std::string::String = v31.to_string();
                    let v98: std::string::String = v32.to_string();
                    let v99: Rc<str> = { const D: &[u8; 16] = b"0123456789abcdef"; let b = &(v26); let mut s = std::string::String::with_capacity(b.len() * 2); for x in b.iter() { s.push(D[(*x >> 4) as usize] as char); s.push(D[(*x & 15) as usize] as char); } std::rc::Rc::<str>::from(s) };
                    let v100: Rc<str> = { const D: &[u8; 16] = b"0123456789abcdef"; let b = &(v33); let mut s = std::string::String::with_capacity(b.len() * 2); for x in b.iter() { s.push(D[(*x >> 4) as usize] as char); s.push(D[(*x & 15) as usize] as char); } std::rc::Rc::<str>::from(s) };
                    let v101: Rc<str> = { const D: &[u8; 16] = b"0123456789abcdef"; let b = &(v52); let mut s = std::string::String::with_capacity(b.len() * 2); for x in b.iter() { s.push(D[(*x >> 4) as usize] as char); s.push(D[(*x & 15) as usize] as char); } std::rc::Rc::<str>::from(s) };
                    let v102: Rc<str> = method16(&v85, &v86, &v87, &v88, &v89, v90, v91, v92, v3, v60, v1, v2, v29, v28, v27, v94, v96, v98, v99, v100, v101);
                    { let _ = spiral_trace_hold(&v5); };
                    let (mut v105, mut v106, mut v107, mut v108, mut v109, mut v110): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
                    let v111: i64 = v105.borrow().l0;
                    let v112: i64 = v111.wrapping_add(1i64);
                    v105.borrow_mut().l0 = v112;
                    let v113: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
                    let v114: bool = cfg!(target_arch = "wasm32");
                    if v114 {
                        let v115: Rc<str> = v108.borrow().l0.clone();
                        let v116: bool = &*v115 == "";
                        let mut v123: Rc<str> = if v116 {
                            v102.clone()
                        } else {
                            let v117: bool = &*v102 == "";
                            if v117 {
                                let v118: Rc<str> = v108.borrow().l0.clone();
                                v118
                            } else {
                                let v119: Rc<str> = v108.borrow().l0.clone();
                                let mut v120: Rc<str> = Rc::<str>::from(format!("{}{}", v119, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v121: Rc<str> = Rc::<str>::from(format!("{}{}", v120, v102.clone()));
                                v121
                            }
                        };
                        let v125: usize = v123.len();
                        let v126: i32 = ((v125) as i32);
                        let v127: i32 = v126.wrapping_add(14999i32);
                        let v128: i32 = v127.wrapping_div(15000i32);
                        let v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v130: bool = v102 != v129 ;
                        let mut v132: bool = if v130 {
                            let v131: bool = v128 <= 1i32;
                            v131
                        } else {
                            false
                        };
                        if v132 {
                            v108.borrow_mut().l0 = v123;
                            ()
                        } else {
                            v108.borrow_mut().l0 = v129;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v123); };
                            ()
                        }
                    } else {
                        println!("{}", v102);
                        ()
                    };
                    let mut v135: Rc<dyn Fn(Rc<str>) -> ()> = v106.borrow().l0.clone();
                    v135(v102);
                    US2::US2_Some(v105, v106, v107, v108, v109, v110)
                };
                let v138: Rc<dyn Fn() -> ()> = method17();
                let v139: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v159: bool = if v139 {
                    true
                } else {
                    { let _ = spiral_trace_hold(&v5); };
                    let (mut v142, mut v143, mut v144, mut v145, mut v146, mut v147): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
                    let v148: US0 = v146.borrow().l0.clone();
                    let v153: i32 = match v148 {
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
                    let v154: bool = v144.borrow().l0;
                    let v155: bool = v154 == false;
                    let v157: bool = if v155 {
                        false
                    } else {
                        let v156: bool = 20i32 >= v153;
                        v156
                    };
                    let v158: bool = v157 == false;
                    v158
                };
                let v205: US2 = if v159 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v5); };
                    let (mut v163, mut v164, mut v165, mut v166, mut v167, mut v168): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
                    let v169: Rc<str> = method3(&v163, &v164, &v165, &v166, &v167, v168);
                    let v170: Rc<str> = method5();
                    { let _ = spiral_trace_hold(&v5); };
                    let (mut v173, mut v174, mut v175, mut v176, mut v177, mut v178): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
                    let v179: i64 = v173.borrow().l0;
                    let v180: i64 = v179.wrapping_add(1i64);
                    v173.borrow_mut().l0 = v180;
                    let v181: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v182: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
                    let v183: bool = cfg!(target_arch = "wasm32");
                    if v183 {
                        let v184: Rc<str> = v176.borrow().l0.clone();
                        let v185: bool = &*v184 == "";
                        let v192: Rc<str> = if v185 {
                            v181.clone()
                        } else {
                            let v186: bool = &*v181 == "";
                            if v186 {
                                let v187: Rc<str> = v176.borrow().l0.clone();
                                v187
                            } else {
                                let v188: Rc<str> = v176.borrow().l0.clone();
                                let v189: Rc<str> = Rc::<str>::from(format!("{}{}", v188, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v190: Rc<str> = Rc::<str>::from(format!("{}{}", v189, v181.clone()));
                                v190
                            }
                        };
                        let v194: usize = v192.len();
                        let v195: i32 = ((v194) as i32);
                        let v196: i32 = v195.wrapping_add(14999i32);
                        let v197: i32 = v196.wrapping_div(15000i32);
                        let v198: bool = v181 != v181 ;
                        let v200: bool = if v198 {
                            let v199: bool = v197 <= 1i32;
                            v199
                        } else {
                            false
                        };
                        if v200 {
                            v176.borrow_mut().l0 = v192;
                            ()
                        } else {
                            v176.borrow_mut().l0 = v181.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v192); };
                            ()
                        }
                    } else {
                        println!("{}", v181);
                        ()
                    };
                    let mut v203: Rc<dyn Fn(Rc<str>) -> ()> = v174.borrow().l0.clone();
                    v203(v181);
                    US2::US2_Some(v173, v174, v175, v176, v177, v178)
                };
                v60
            }
        }
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method18(mut v0: Vec<u8>) -> Vec<u8> {
    v0
}
fn method19(mut v0: Rc<Vec<u8>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let mut v3: bool = v1 < 0i32;
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
fn method20(mut v0: Rc<UH0>, mut v1: i8) -> i8 {
    loop {
        match Rc::unwrap_or_clone(v0) {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: u8 = v2;
                let mut v3: Rc<UH0> = v3;
                let v4: i8 = v1.wrapping_add(1i8);
                (v0, v1) = (v3, v4);
                continue;
            }
            UH0::UH0_Nil => {
                return v1;
            }
        }
    }
}
fn format_real_23(mut v0: i8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method7(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method22(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: Rc<str> = format_real_23(v8);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_14(v9);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_14(v10);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v32));
    method9(v33)
}
fn closure73() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) }
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure72() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure73();
        Rc::new(UH1::UH1_StreamCons(9223372036854775808u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure71() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure72();
        Rc::new(UH1::UH1_StreamCons(4611686018427387904u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure70() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure71();
        Rc::new(UH1::UH1_StreamCons(6917529027641081856u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure69() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure70();
        Rc::new(UH1::UH1_StreamCons(1152921504606846976u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure68() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure69();
        Rc::new(UH1::UH1_StreamCons(15564440312192434176u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure67() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure68();
        Rc::new(UH1::UH1_StreamCons(11817445422220181504u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure66() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure67();
        Rc::new(UH1::UH1_StreamCons(5044031582654955520u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure65() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure66();
        Rc::new(UH1::UH1_StreamCons(6989586621679009792u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure64() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure65();
        Rc::new(UH1::UH1_StreamCons(16537217831704461312u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure63() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure64();
        Rc::new(UH1::UH1_StreamCons(11979575008805519360u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure62() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure63();
        Rc::new(UH1::UH1_StreamCons(14294425217273954304u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure61() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure62();
        Rc::new(UH1::UH1_StreamCons(2382404202878992384u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure60() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure61();
        Rc::new(UH1::UH1_StreamCons(6545982058383015936u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure59() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure60();
        Rc::new(UH1::UH1_StreamCons(10314369046585278464u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure58() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure59();
        Rc::new(UH1::UH1_StreamCons(4793518853382471680u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure57() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure58();
        Rc::new(UH1::UH1_StreamCons(3873377154515337216u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure56() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure57();
        Rc::new(UH1::UH1_StreamCons(645562859085889536u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure55() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure56();
        Rc::new(UH1::UH1_StreamCons(107593809847648256u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure54() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure55();
        Rc::new(UH1::UH1_StreamCons(3092389647259533312u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure53() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure54();
        Rc::new(UH1::UH1_StreamCons(9738770311398031360u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure52() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure53();
        Rc::new(UH1::UH1_StreamCons(16995415113324298240u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure51() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure52();
        Rc::new(UH1::UH1_StreamCons(8981483876790566912u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure50() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure51();
        Rc::new(UH1::UH1_StreamCons(13794743361938128896u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure49() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure50();
        Rc::new(UH1::UH1_StreamCons(2299123893656354816u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure48() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure49();
        Rc::new(UH1::UH1_StreamCons(3457644661227651072u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure47() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure48();
        Rc::new(UH1::UH1_StreamCons(576274110204608512u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure46() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure47();
        Rc::new(UH1::UH1_StreamCons(6244960376270618624u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure45() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure46();
        Rc::new(UH1::UH1_StreamCons(13338656111851470848u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure44() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure45();
        Rc::new(UH1::UH1_StreamCons(14520938734448279552u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure43() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure44();
        Rc::new(UH1::UH1_StreamCons(14717985838214414336u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure42() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure43();
        Rc::new(UH1::UH1_StreamCons(5527454985320660992u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure41() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure42();
        Rc::new(UH1::UH1_StreamCons(16293529225644736512u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure40() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure41();
        Rc::new(UH1::UH1_StreamCons(11938960241128898560u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure39() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure40();
        Rc::new(UH1::UH1_StreamCons(8138741398091333632u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure38() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure39();
        Rc::new(UH1::UH1_StreamCons(7505371590918406144u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure37() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure38();
        Rc::new(UH1::UH1_StreamCons(16623181993244360704u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure36() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure37();
        Rc::new(UH1::UH1_StreamCons(8919445023443910656u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure35() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure36();
        Rc::new(UH1::UH1_StreamCons(4561031516192243712u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure34() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure35();
        Rc::new(UH1::UH1_StreamCons(9983543956220149760u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure33() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure34();
        Rc::new(UH1::UH1_StreamCons(4738381338321616896u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure32() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure33();
        Rc::new(UH1::UH1_StreamCons(789730223053602816u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure31() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure32();
        Rc::new(UH1::UH1_StreamCons(131621703842267136u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure30() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure31();
        Rc::new(UH1::UH1_StreamCons(21936950640377856u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure29() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure30();
        Rc::new(UH1::UH1_StreamCons(3656158440062976u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure28() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure29();
        Rc::new(UH1::UH1_StreamCons(609359740010496u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure27() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure28();
        Rc::new(UH1::UH1_StreamCons(101559956668416u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure26() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure27();
        Rc::new(UH1::UH1_StreamCons(16926659444736u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure25() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure26();
        Rc::new(UH1::UH1_StreamCons(2821109907456u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure24() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure25();
        Rc::new(UH1::UH1_StreamCons(470184984576u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure23() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure24();
        Rc::new(UH1::UH1_StreamCons(78364164096u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure22() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure23();
        Rc::new(UH1::UH1_StreamCons(13060694016u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure21() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure22();
        Rc::new(UH1::UH1_StreamCons(2176782336u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure20() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure21();
        Rc::new(UH1::UH1_StreamCons(362797056u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure19() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure20();
        Rc::new(UH1::UH1_StreamCons(60466176u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure18() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure19();
        Rc::new(UH1::UH1_StreamCons(10077696u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure17() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure18();
        Rc::new(UH1::UH1_StreamCons(1679616u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure16() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure17();
        Rc::new(UH1::UH1_StreamCons(279936u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure15() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure16();
        Rc::new(UH1::UH1_StreamCons(46656u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure14() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure15();
        Rc::new(UH1::UH1_StreamCons(7776u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure13() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure14();
        Rc::new(UH1::UH1_StreamCons(1296u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure12() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure13();
        Rc::new(UH1::UH1_StreamCons(216u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure11() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure12();
        Rc::new(UH1::UH1_StreamCons(36u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure10() -> Rc<dyn Fn() -> Rc<UH1>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH1>> = Rc::new(move || -> Rc<UH1> {
        let mut v0: Rc<dyn Fn() -> Rc<UH1>> = closure11();
        Rc::new(UH1::UH1_StreamCons(6u64, v0))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method24(mut v0: i8, mut v1: Rc<UH1>) -> US5 {
    loop {
        match Rc::unwrap_or_clone(v1) {
            UH1::UH1_StreamCons(v2, v3) => {
                let mut v2: u64 = v2;
                let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3;
                let v4: bool = v0 <= 0i8;
                if v4 {
                    return US5::US5_Some(v2);
                } else {
                    let v6: i8 = v0.wrapping_sub(1i8);
                    let v7: Rc<UH1> = v3();
                    (v0, v1) = (v6, v7);
                    continue;
                }
            }
            UH1::UH1_StreamNil => {
                return US5::US5_None;
            }
        }
    }
}
fn format_real_26(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method7(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method25(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u8, mut v11: u64) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0;
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v14: Rc<str> = format_real_12(v12);
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v18, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v20: Rc<str> = format_real_23(v8);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_14(v9);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_26(v10);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_14(v11);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v38));
    method9(v39)
}
fn method27(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u8) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: Rc<str> = format_real_23(v8);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_14(v9);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_26(v10);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v32));
    method9(v33)
}
fn method21(mut v0: i8, mut v1: Rc<UH0>, mut v2: u64) -> US4 {
    loop {
        let mut v3: bool = v0 < 0i8;
        if v3 {
            let v4: u64 = v2.wrapping_add(1u64);
            let v5: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
            let v27: bool = if v5 {
                true
            } else {
                let v7: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                { let _ = spiral_trace_hold(&v7); };
                let mut v9: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                let (mut v10, mut v11, mut v12, mut v13, mut v14, mut v15): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v9);
                let v16: US0 = v14.borrow().l0.clone();
                let v21: i32 = match v16 {
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
                let v22: bool = v12.borrow().l0;
                let v23: bool = v22 == false;
                let v25: bool = if v23 {
                    false
                } else {
                    let v24: bool = 20i32 >= v21;
                    v24
                };
                let v26: bool = v25 == false;
                v26
            };
            let v76: US2 = if v27 {
                US2::US2_None
            } else {
                let v30: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                { let _ = spiral_trace_hold(&v30); };
                let v32: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v32);
                let v39: Rc<str> = method3(&v33, &v34, &v35, &v36, &v37, v38.clone());
                let v40: Rc<str> = method5();
                let v41: Rc<str> = method22(&v33, &v34, &v35, &v36, &v37, v38, v39, v40, v0, v2, v4);
                { let _ = spiral_trace_hold(&v30); };
                let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v32);
                let v50: i64 = v44.borrow().l0;
                let v51: i64 = v50.wrapping_add(1i64);
                v44.borrow_mut().l0 = v51;
                let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
                let v53: bool = cfg!(target_arch = "wasm32");
                if v53 {
                    let v54: Rc<str> = v47.borrow().l0.clone();
                    let mut v55: bool = &*v54 == "";
                    let v62: Rc<str> = if v55 {
                        v41.clone()
                    } else {
                        let v56: bool = &*v41 == "";
                        if v56 {
                            let v57: Rc<str> = v47.borrow().l0.clone();
                            v57
                        } else {
                            let v58: Rc<str> = v47.borrow().l0.clone();
                            let v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                            let v60: Rc<str> = Rc::<str>::from(format!("{}{}", v59, v41.clone()));
                            v60
                        }
                    };
                    let v64: usize = v62.len();
                    let v65: i32 = ((v64) as i32);
                    let v66: i32 = v65.wrapping_add(14999i32);
                    let v67: i32 = v66.wrapping_div(15000i32);
                    let v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v69: bool = v41 != v68 ;
                    let v71: bool = if v69 {
                        let v70: bool = v67 <= 1i32;
                        v70
                    } else {
                        false
                    };
                    if v71 {
                        v47.borrow_mut().l0 = v62;
                        ()
                    } else {
                        v47.borrow_mut().l0 = v68;
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v62); };
                        ()
                    }
                } else {
                    println!("{}", v41);
                    ()
                };
                let mut v74: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                v74(v41);
                US2::US2_Some(v44, v45, v46, v47, v48, v49)
            };
            return US4::US4_Some(v4, v1);
        } else {
            match Rc::unwrap_or_clone(v1) {
                UH0::UH0_Cons(v79, v80) => {
                    let v79: u8 = v79;
                    let v80: Rc<UH0> = v80;
                    let mut v81: bool = v79 > 1u8;
                    if v81 {
                        let mut v82: u64 = 1u64;
                        let v83: Rc<dyn Fn() -> Rc<UH1>> = closure10();
                        let v84: Rc<UH1> = Rc::new(UH1::UH1_StreamCons(v82, v83));
                        let v85: US5 = method24(v0, v84);
                        let v89: u64 = match v85 {
                            US5::US5_None => {
                                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
                            }
                            US5::US5_Some(v86) => {
                                let v86: u64 = v86;
                                v86
                            }
                        };
                        let v90: u8 = v79.wrapping_sub(1u8);
                        let v91: u64 = (v90 as u64);
                        let v92: u64 = v91.wrapping_mul(v89);
                        let v93: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                        let v115: bool = if v93 {
                            true
                        } else {
                            let v95: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                            { let _ = spiral_trace_hold(&v95); };
                            let v97: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                            let (mut v98, mut v99, mut v100, mut v101, mut v102, mut v103): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v97);
                            let v104: US0 = v102.borrow().l0.clone();
                            let v109: i32 = match v104 {
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
                            let v110: bool = v100.borrow().l0;
                            let v111: bool = v110 == false;
                            let v113: bool = if v111 {
                                false
                            } else {
                                let v112: bool = 20i32 >= v109;
                                v112
                            };
                            let v114: bool = v113 == false;
                            v114
                        };
                        let v164: US2 = if v115 {
                            US2::US2_None
                        } else {
                            let v118: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                            { let _ = spiral_trace_hold(&v118); };
                            let mut v120: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                            let (mut v121, mut v122, mut v123, mut v124, mut v125, mut v126): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v120);
                            let v127: Rc<str> = method3(&v121, &v122, &v123, &v124, &v125, v126.clone());
                            let v128: Rc<str> = method5();
                            let v129: Rc<str> = method25(&v121, &v122, &v123, &v124, &v125, v126, v127, v128, v0, v2, v79, v92);
                            { let _ = spiral_trace_hold(&v118); };
                            let (mut v132, mut v133, mut v134, mut v135, mut v136, mut v137): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v120);
                            let v138: i64 = v132.borrow().l0;
                            let v139: i64 = v138.wrapping_add(1i64);
                            v132.borrow_mut().l0 = v139;
                            let v140: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
                            let v141: bool = cfg!(target_arch = "wasm32");
                            if v141 {
                                let v142: Rc<str> = v135.borrow().l0.clone();
                                let v143: bool = &*v142 == "";
                                let mut v150: Rc<str> = if v143 {
                                    v129.clone()
                                } else {
                                    let v144: bool = &*v129 == "";
                                    if v144 {
                                        let v145: Rc<str> = v135.borrow().l0.clone();
                                        v145
                                    } else {
                                        let mut v146: Rc<str> = v135.borrow().l0.clone();
                                        let v147: Rc<str> = Rc::<str>::from(format!("{}{}", v146, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                        let v148: Rc<str> = Rc::<str>::from(format!("{}{}", v147, v129.clone()));
                                        v148
                                    }
                                };
                                let v152: usize = v150.len();
                                let v153: i32 = ((v152) as i32);
                                let v154: i32 = v153.wrapping_add(14999i32);
                                let v155: i32 = v154.wrapping_div(15000i32);
                                let v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v157: bool = v129 != v156 ;
                                let v159: bool = if v157 {
                                    let v158: bool = v155 <= 1i32;
                                    v158
                                } else {
                                    false
                                };
                                if v159 {
                                    v135.borrow_mut().l0 = v150;
                                    ()
                                } else {
                                    v135.borrow_mut().l0 = v156;
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v150); };
                                    ()
                                }
                            } else {
                                println!("{}", v129);
                                ()
                            };
                            let mut v162: Rc<dyn Fn(Rc<str>) -> ()> = v133.borrow().l0.clone();
                            v162(v129);
                            US2::US2_Some(v132, v133, v134, v135, v136, v137)
                        };
                        let v165: u64 = v2.wrapping_add(v92);
                        let v166: i8 = v0.wrapping_sub(1i8);
                        (v0, v1, v2) = (v166, v80, v165);
                        continue;
                    } else {
                        let v168: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                        let v190: bool = if v168 {
                            true
                        } else {
                            let v170: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                            { let _ = spiral_trace_hold(&v170); };
                            let v172: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                            let (mut v173, mut v174, mut v175, mut v176, mut v177, mut v178): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v172);
                            let v179: US0 = v177.borrow().l0.clone();
                            let v184: i32 = match v179 {
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
                            let v185: bool = v175.borrow().l0;
                            let v186: bool = v185 == false;
                            let v188: bool = if v186 {
                                false
                            } else {
                                let v187: bool = 20i32 >= v184;
                                v187
                            };
                            let v189: bool = v188 == false;
                            v189
                        };
                        let v239: US2 = if v190 {
                            US2::US2_None
                        } else {
                            let v193: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                            { let _ = spiral_trace_hold(&v193); };
                            let v195: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                            let (mut v196, mut v197, mut v198, mut v199, mut v200, mut v201): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v195);
                            let v202: Rc<str> = method3(&v196, &v197, &v198, &v199, &v200, v201.clone());
                            let mut v203: Rc<str> = method5();
                            let v204: Rc<str> = method27(&v196, &v197, &v198, &v199, &v200, v201, v202, v203, v0, v2, v79);
                            { let _ = spiral_trace_hold(&v193); };
                            let (mut v207, mut v208, mut v209, mut v210, mut v211, mut v212): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v195);
                            let v213: i64 = v207.borrow().l0;
                            let v214: i64 = v213.wrapping_add(1i64);
                            v207.borrow_mut().l0 = v214;
                            let v215: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
                            let v216: bool = cfg!(target_arch = "wasm32");
                            if v216 {
                                let v217: Rc<str> = v210.borrow().l0.clone();
                                let v218: bool = &*v217 == "";
                                let v225: Rc<str> = if v218 {
                                    v204.clone()
                                } else {
                                    let v219: bool = &*v204 == "";
                                    if v219 {
                                        let v220: Rc<str> = v210.borrow().l0.clone();
                                        v220
                                    } else {
                                        let v221: Rc<str> = v210.borrow().l0.clone();
                                        let v222: Rc<str> = Rc::<str>::from(format!("{}{}", v221, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                        let v223: Rc<str> = Rc::<str>::from(format!("{}{}", v222, v204.clone()));
                                        v223
                                    }
                                };
                                let v227: usize = v225.len();
                                let v228: i32 = ((v227) as i32);
                                let v229: i32 = v228.wrapping_add(14999i32);
                                let v230: i32 = v229.wrapping_div(15000i32);
                                let v231: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v232: bool = v204 != v231 ;
                                let v234: bool = if v232 {
                                    let v233: bool = v230 <= 1i32;
                                    v233
                                } else {
                                    false
                                };
                                if v234 {
                                    v210.borrow_mut().l0 = v225;
                                    ()
                                } else {
                                    v210.borrow_mut().l0 = v231;
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v225); };
                                    ()
                                }
                            } else {
                                println!("{}", v204);
                                ()
                            };
                            let mut v237: Rc<dyn Fn(Rc<str>) -> ()> = v208.borrow().l0.clone();
                            v237(v204);
                            US2::US2_Some(v207, v208, v209, v210, v211, v212)
                        };
                        let v240: i8 = v0.wrapping_sub(1i8);
                        (v0, v1) = (v240, v80);
                        continue;
                    }
                }
                UH0::UH0_Nil => {
                    return US4::US4_None;
                }
            }
        }
    }
}
fn method28(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.roll_within_bounds"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: Rc<str> = format_real_14(v8);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rolls"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v9));
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v24, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v10));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v28));
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v29, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v30));
    method9(v31)
}
fn method29() -> Rc<dyn Fn() -> ()> {
    closure7()
}
fn closure9() -> Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> = Rc::new(move |mut v0: u64, mut v1: Vec<u8>| -> Option<u64> {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v3); };
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
        let mut v12: US0 = US0::US0_Debug;
        v10.borrow_mut().l0 = v12;
        let mut v13: Vec<u8> = method18(v1.clone());
        let v14: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v13));
        let v15: Rc<Vec<u8>> = Rc::new((v14).borrow().clone());
        let v16: usize = (v15).len();
        let v17: i32 = ((v16) as i32);
        let v18: i32 = v17.wrapping_sub(1i32);
        let v19: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let v20: Rc<UH0> = method19(v15, v18, v19);
        let v21: i8 = 0i8;
        let v22: i8 = method20(v20.clone(), v21);
        let v23: i8 = v22.wrapping_sub(1i8);
        let v24: u64 = 0u64;
        let v25: US4 = method21(v23, v20, v24);
        let v35: US5 = match v25 {
            US4::US4_Some(v26, v27) => {
                let v26: u64 = v26;
                let v27: Rc<UH0> = v27;
                let mut v28: bool = v26 >= 1u64;
                let v30: bool = if v28 {
                    let v29: bool = v26 <= v0;
                    v29
                } else {
                    false
                };
                if v30 {
                    US5::US5_Some(v26)
                } else {
                    US5::US5_None
                }
            }
            _ => {
                US5::US5_None
            }
        };
        let v40: Option<u64> = match v35 {
            US5::US5_None => {
                let v38: Option<u64> = None;
                v38
            }
            US5::US5_Some(v36) => {
                let v36: u64 = v36;
                let v37: Option<u64> = Some(v36.clone());
                v37
            }
        };
        let v41: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
        let v61: bool = if v41 {
            true
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v50: US0 = v48.borrow().l0.clone();
            let mut v55: i32 = match v50 {
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
            let v56: bool = v46.borrow().l0;
            let v57: bool = v56 == false;
            let v59: bool = if v57 {
                false
            } else {
                let v58: bool = 20i32 >= v55;
                v58
            };
            let v60: bool = v59 == false;
            v60
        };
        let v110: US2 = if v61 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v65, mut v66, mut v67, mut v68, mut v69, mut v70): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v71: Rc<str> = method3(&v65, &v66, &v67, &v68, &v69, v70.clone());
            let v72: Rc<str> = method5();
            let v73: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1)).s() });
            let mut v74: Rc<str> = Rc::<str>::from(match &v40 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let v75: Rc<str> = method28(&v65, &v66, &v67, &v68, &v69, v70, v71, v72, v0, v73, v74);
            { let _ = spiral_trace_hold(&v3); };
            let (mut v78, mut v79, mut v80, mut v81, mut v82, mut v83): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v84: i64 = v78.borrow().l0;
            let v85: i64 = v84.wrapping_add(1i64);
            v78.borrow_mut().l0 = v85;
            let v86: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v87: bool = cfg!(target_arch = "wasm32");
            if v87 {
                let v88: Rc<str> = v81.borrow().l0.clone();
                let v89: bool = &*v88 == "";
                let v96: Rc<str> = if v89 {
                    v75.clone()
                } else {
                    let v90: bool = &*v75 == "";
                    if v90 {
                        let v91: Rc<str> = v81.borrow().l0.clone();
                        v91
                    } else {
                        let v92: Rc<str> = v81.borrow().l0.clone();
                        let v93: Rc<str> = Rc::<str>::from(format!("{}{}", v92, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                        let v94: Rc<str> = Rc::<str>::from(format!("{}{}", v93, v75.clone()));
                        v94
                    }
                };
                let v98: usize = v96.len();
                let v99: i32 = ((v98) as i32);
                let v100: i32 = v99.wrapping_add(14999i32);
                let v101: i32 = v100.wrapping_div(15000i32);
                let v102: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v103: bool = v75 != v102 ;
                let mut v105: bool = if v103 {
                    let v104: bool = v101 <= 1i32;
                    v104
                } else {
                    false
                };
                if v105 {
                    v81.borrow_mut().l0 = v96;
                    ()
                } else {
                    v81.borrow_mut().l0 = v102;
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v96); };
                    ()
                }
            } else {
                println!("{}", v75);
                ()
            };
            let mut v108: Rc<dyn Fn(Rc<str>) -> ()> = v79.borrow().l0.clone();
            v108(v75);
            US2::US2_Some(v78, v79, v80, v81, v82, v83)
        };
        let v111: Rc<dyn Fn() -> ()> = method29();
        let v112: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
        let mut v132: bool = if v112 {
            true
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v115, mut v116, mut v117, mut v118, mut v119, mut v120): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v121: US0 = v119.borrow().l0.clone();
            let v126: i32 = match v121 {
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
            let v127: bool = v117.borrow().l0;
            let v128: bool = v127 == false;
            let v130: bool = if v128 {
                false
            } else {
                let v129: bool = 20i32 >= v126;
                v129
            };
            let v131: bool = v130 == false;
            v131
        };
        let v178: US2 = if v132 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v136, mut v137, mut v138, mut v139, mut v140, mut v141): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v142: Rc<str> = method3(&v136, &v137, &v138, &v139, &v140, v141);
            let v143: Rc<str> = method5();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v146, mut v147, mut v148, mut v149, mut v150, mut v151): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
            let v152: i64 = v146.borrow().l0;
            let v153: i64 = v152.wrapping_add(1i64);
            v146.borrow_mut().l0 = v153;
            let v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v155: Rc<dyn Fn(Rc<str>) -> ()> = closure6();
            let v156: bool = cfg!(target_arch = "wasm32");
            if v156 {
                let v157: Rc<str> = v149.borrow().l0.clone();
                let v158: bool = &*v157 == "";
                let v165: Rc<str> = if v158 {
                    v154.clone()
                } else {
                    let v159: bool = &*v154 == "";
                    if v159 {
                        let v160: Rc<str> = v149.borrow().l0.clone();
                        v160
                    } else {
                        let v161: Rc<str> = v149.borrow().l0.clone();
                        let mut v162: Rc<str> = Rc::<str>::from(format!("{}{}", v161, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                        let v163: Rc<str> = Rc::<str>::from(format!("{}{}", v162, v154.clone()));
                        v163
                    }
                };
                let v167: usize = v165.len();
                let v168: i32 = ((v167) as i32);
                let v169: i32 = v168.wrapping_add(14999i32);
                let v170: i32 = v169.wrapping_div(15000i32);
                let v171: bool = v154 != v154 ;
                let mut v173: bool = if v171 {
                    let v172: bool = v170 <= 1i32;
                    v172
                } else {
                    false
                };
                if v173 {
                    v149.borrow_mut().l0 = v165;
                    ()
                } else {
                    v149.borrow_mut().l0 = v154.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v165); };
                    ()
                }
            } else {
                println!("{}", v154);
                ()
            };
            let mut v176: Rc<dyn Fn(Rc<str>) -> ()> = v147.borrow().l0.clone();
            v176(v154);
            US2::US2_Some(v146, v147, v148, v149, v150, v151)
        };
        v40
    }); } CLOSURE.with(|closure| closure.clone())
}
pub fn dice_contract_new() -> (u32, Vec<u8>) {
    closure0()()
}
pub fn dice_contract_contribute_seed(v0: &mut Vec<u8>, v1: Vec<u8>) -> () {
    closure4()(v0, v1)
}
pub fn dice_contract_generate_random_number(v0: &mut Vec<u8>, v1: std::string::String, v2: std::string::String, v3: u64) -> u64 {
    closure8()(v0, v1, v2, v3)
}
pub fn dice_contract_roll_within_bounds(v0: u64, v1: Vec<u8>) -> Option<u64> {
    closure9()(v0, v1)
}
pub type SpiralShape_3e912ab56359 = Mut0;
pub type SpiralShape_3e0040a0a65b = Mut1;
pub type SpiralShape_8c8c1533c8a6 = Mut2;
pub type SpiralShape_97df63ebabc3 = Mut3;
pub type SpiralShape_bfe005d97257 = Mut4;
pub type SpiralShape_66576ccbb4a6 = Mut5;
