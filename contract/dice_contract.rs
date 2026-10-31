#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)] #![recursion_limit = "512"]
use std::cell::RefCell;
use std::rc::Rc;
#[derive(near_sdk::PanicOnDefault, borsh::BorshDeserialize, borsh::BorshSerialize)]
pub struct OldState {
    version: u32,
    seeds: near_sdk::store::vec::Vector<u8>,
}
#[near_sdk::near_bindgen]
#[derive(near_sdk::PanicOnDefault, borsh::BorshDeserialize, borsh::BorshSerialize)]
pub struct State((u32, near_sdk::store::vec::Vector<u8>));
impl From<OldState> for State {
    fn from(old_state: OldState) -> Self {
        Self((old_state.version + 1, old_state.seeds))
    }
}
#[near_sdk::near_bindgen]
impl State {
    #[init]
    pub fn new() -> Self {
        Self(dice_contract_new())
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
    pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
        dice_contract_roll_within_bounds(max, rolls)
    }
    #[result_serializer(borsh)]
    pub fn roll_within_bounds_borsh(
        &self,
        #[serializer(borsh)] max: u64,
        #[serializer(borsh)] rolls: Vec<u8>,
    ) -> Option<u64> {
        self.roll_within_bounds(max, rolls)
    }
}
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
}
#[cfg(target_arch = "wasm32")]
type SpiralNearVec<T> = near_sdk::store::vec::Vector<T>;
#[cfg(not(target_arch = "wasm32"))]
struct SpiralNearVec<T>(std::vec::Vec<T>);
#[cfg(not(target_arch = "wasm32"))]
impl<T> SpiralNearVec<T> {
    fn len(&self) -> usize { self.0.len() }
    fn extend<I: IntoIterator<Item = T>>(&mut self, iter: I) { self.0.extend(iter); }
    fn drain(&mut self, range: std::ops::Range<u32>) -> std::vec::Drain<'_, T> {
        self.0.drain((range.start as usize)..(range.end as usize))
    }
    fn iter(&self) -> std::slice::Iter<'_, T> { self.0.iter() }
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
fn spiral_trace_near_log(text: &str) {
    use std::sync::atomic::{AtomicUsize, Ordering};
    static LOGGED: AtomicUsize = AtomicUsize::new(0);
    let cs: Vec<char> = text.chars().collect();
    for c in cs.chunks(15000) {
        let s: String = c.iter().collect();
        let used = LOGGED.load(Ordering::Relaxed);
        let budget = 16000usize.saturating_sub(used);
        if budget < 13 {
            break;
        }
        let s = if s.len() <= budget {
            s
        } else {
            let mut end = budget - 12;
            while !s.is_char_boundary(end) {
                end -= 1;
            }
            format!("{} [truncated]", &s[..end])
        };
        LOGGED.store(used + s.len(), Ordering::Relaxed);
        near_sdk::env::log_str(&s);
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
struct Mut0 { l0: i64 }
struct Mut1 { l0: Rc<dyn Fn(Rc<str>) -> ()> }
struct Mut2 { l0: bool }
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum US0 {
    US0_Verbose,
    US0_Debug,
    US0_Info,
    US0_Warning,
    US0_Critical,
}
struct Mut4 { l0: US0 }
#[derive(Clone)]
enum US1 {
    US1_Some(US0),
    US1_None,
}
struct Mut5 { l0: i32, l1: US1 }
#[derive(Clone)]
enum US2 {
    US2_Some(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US2_None,
}
#[derive(Clone)]
enum UH0 {
    UH0_Nil,
    UH0_Cons(u8, Rc<UH0>),
}
#[derive(Clone)]
enum UH1 {
    UH1_StreamCons(u8, Rc<dyn Fn() -> Rc<UH1>>),
    UH1_StreamNil,
}
#[derive(Clone)]
enum US3 {
    US3_NotComputed(Rc<dyn Fn() -> Rc<UH1>>),
    US3_Computed(Rc<UH1>),
}
struct Mut6 { l0: US3 }
#[derive(Clone)]
enum US4 {
    US4_Some(u8),
    US4_None,
}
struct Mut7 { l0: US4 }
#[derive(Clone)]
enum US5 {
    US5_Some(u64, Rc<UH0>),
    US5_None,
}
#[derive(Clone)]
enum UH2 {
    UH2_StreamCons(u64, Rc<dyn Fn() -> Rc<UH2>>),
    UH2_StreamNil,
}
#[derive(Clone)]
enum US6 {
    US6_Some(u64),
    US6_None,
}
fn get_environment_variable_1(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = Rc::<str>::from(std::env::var(&*v0).unwrap_or_default());
    v1
}
fn method2(mut v0: Rc<RefCell<Mut5>>) -> bool {
    let mut v1: i32 = v0.borrow().l0.clone();
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
    let mut v2: Rc<str> = get_environment_variable_1(v1.clone());
    ;
    ;
    ;
    ;
    ;
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = Rc::<str>::from(v3.to_lowercase());
    let v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
    let v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
    let v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
    let mut v13: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new(Vec::new()));
    let v14: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v11.clone(), v14.clone()));
    let v15: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v9.clone(), v15.clone()));
    let v16: US0 = US0::US0_Info;
    v13.borrow_mut().push((v7.clone(), v16.clone()));
    let v17: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v5.clone(), v17.clone()));
    let v18: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v3.clone(), v18.clone()));
    let v19: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v12.clone(), v19.clone()));
    let v20: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v10.clone(), v20.clone()));
    let v21: US0 = US0::US0_Info;
    v13.borrow_mut().push((v8.clone(), v21.clone()));
    let v22: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v6.clone(), v22.clone()));
    let v23: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v4.clone(), v23.clone()));
    let v24: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v13.borrow().clone());
    let v25: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let v26: i32 = (v25.clone().borrow().len() as i32);
    let v27: US1 = US1::US1_None;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: v26, l1: v27.clone() }));
    while method2(v28.clone()) {
        let v30: i32 = v28.borrow().l0.clone();
        let v31: i32 = v30.wrapping_sub(1i32);
        let v32: US1 = v28.borrow().l1.clone();
        let (mut v33, mut v34): (Rc<str>, US0) = v25.clone().borrow()[v31 as usize].clone();
        let v41: US1 = match &v32 {
            US1::US1_None => {
                let v36: bool = v33 == v2 ;
                if v36 {
                    US1::US1_Some(v34.clone())
                } else {
                    US1::US1_None
                }
            }
            US1::US1_Some(v35) => {
                let v35: US0 = v35.clone();
                v32.clone()
            }
        };
        v28.borrow_mut().l0 = v31;
        v28.borrow_mut().l1 = v41.clone();
        ()
    };
    let v42: US1 = v28.borrow().l1.clone();
    let mut v43: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let v44: Rc<dyn Fn(Rc<str>) -> ()> = closure2();
    let v45: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v44.clone() }));
    let v46: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v48: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v47.clone() }));
    let v51: US0 = match &v42 {
        US1::US1_None => {
            v0.clone()
        }
        US1::US1_Some(v49) => {
            let v49: US0 = v49.clone();
            v49.clone()
        }
    };
    let mut v52: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v51.clone() }));
    let mut v53: Option<i64> = None;
    (v43.clone(), v45.clone(), v46.clone(), v48.clone(), v52.clone(), v53.clone())
}
fn fresh_c1() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c3() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure0() -> Rc<dyn Fn() -> (u32, SpiralNearVec<u8>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (u32, SpiralNearVec<u8>)> = Rc::new(move || -> (u32, SpiralNearVec<u8>) {
        let mut v1: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v1); };
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v4, mut v5, mut v6, mut v7, mut v8, mut v9): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v3) };
        let mut v10: US0 = US0::US0_Info;
        v8.borrow_mut().l0 = v10.clone();
        let v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
        let mut v12: &[u8] = { let owned: Rc<str> = (v11).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v13: SpiralNearVec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::store::vec::Vector::new(v12); #[cfg(not(target_arch = "wasm32"))] let v = SpiralNearVec(<std::vec::Vec<u8>>::new()); v };
        (2u32, v13)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let v6: u64 = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; h * 3600 + m * 60 + s };
    let v7: u64 = v6.wrapping_div(3600u64);
    let mut v8: bool = v7 < 10u64;
    let v11: Rc<str> = if v8 {
        let v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v9.clone()
    } else {
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v10.clone()
    };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, Rc::<str>::from(format!("{:?}", v7))));
    let v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let v16: u64 = v6.wrapping_div(60u64);
    let v17: u64 = v16.wrapping_rem(60u64);
    let v18: bool = v17 < 10u64;
    let v21: Rc<str> = if v18 {
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v19.clone()
    } else {
        let v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v20.clone()
    };
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v15, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{:?}", v17)))))), v14));
    let v26: u64 = v6.wrapping_rem(60u64);
    let v27: bool = v26 < 10u64;
    let v30: Rc<str> = if v27 {
        let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v28.clone()
    } else {
        let v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v29.clone()
    };
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v25, Rc::<str>::from(format!("{}{}", v30, Rc::<str>::from(format!("{:?}", v26))))));
    v33.clone()
}
fn method6(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3;
    ()
}
fn format_real_5(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method4() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.clone().as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_5(v3);
    let v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7.clone()
}
fn method9(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v1;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
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
                (v0, v1, v2) = (v0.clone(), v1, v12);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn method10(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let mut v3: i32 = v1.wrapping_sub(1i32);
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let v5: bool = v4 == b' ';
            let v7: bool = if v5 {
                true
            } else {
                let v6: bool = v4 == b'/';
                v6
            };
            if v7 {
                (v0, v1) = (v0.clone(), v3);
                continue;
            } else {
                return v3;
            }
        }
    }
}
fn method8(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let mut v3: i32 = method9(v0.clone(), v1, v2);
    let mut v4: i32 = v1.wrapping_sub(1i32);
    let v5: Rc<str> = string_slice(&v0, v3 as i64, v4 as i64);
    let v6: i32 = (v5.clone().len() as i32);
    let v7: i32 = method10(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5, 0i32 as i64, v7 as i64);
    v8
}
fn format_real_11(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn format_real_12(mut v0: i32) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.contribute_seed"); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess_len"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess_len"); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess_len = "); } LIT.with(|lit| lit.clone()) };
    let v27: Rc<str> = format_real_12(v8);
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v27));
    let v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess"); } LIT.with(|lit| lit.clone()) };
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v25)), v9));
    let v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v36, v37))));
    method8(v39.clone())
}
fn closure5() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure6() -> Rc<dyn Fn() -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> ()> = Rc::new(move || -> () {
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method13() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure4() -> Rc<dyn Fn(&mut SpiralNearVec<u8>, Vec<u8>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut SpiralNearVec<u8>, Vec<u8>) -> ()> = Rc::new(move |mut v0: &mut SpiralNearVec<u8>, mut v1: Vec<u8>| -> () {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v3); };
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v12: US0 = US0::US0_Info;
        v10.borrow_mut().l0 = v12.clone();
        { (v0).extend((v1).clone()); };
        let mut v13: u32 = ((v0).len() as u32);
        let v14: i32 = (v13 as i32);
        let v15: usize = ((100i32) as usize);
        let v16: i32 = (v15 as i32);
        let v17: i32 = v14.wrapping_sub(v16);
        let v18: bool = v17 > 0i32;
        if v18 {
            let v20: Vec<u8> = v0.drain(0..v17 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v23, mut v24, mut v25, mut v26, mut v27, mut v28): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let v29: US0 = v27.borrow().l0.clone();
            let v34: i32 = match &v29 {
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
            let v35: bool = v25.borrow().l0.clone();
            let v36: bool = v35 == false;
            let v38: bool = if v36 {
                false
            } else {
                let v37: bool = 20i32 >= v34;
                v37
            };
            let v39: bool = v38 == false;
            let v88: US2 = if v39 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v3); };
                let (mut v43, mut v44, mut v45, mut v46, mut v47, mut v48): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let v49: Rc<str> = method3(v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone());
                let mut v50: Rc<str> = method4();
                let v51: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v20)).s() });
                let mut v52: Rc<str> = method7(v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone(), v50.clone(), v17, v51.clone());
                { let _ = spiral_trace_hold(&v3); };
                let (mut v55, mut v56, mut v57, mut v58, mut v59, mut v60): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let v61: i64 = v55.borrow().l0.clone();
                let v62: i64 = v61.wrapping_add(1i64);
                v55.borrow_mut().l0 = v62;
                let v63: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v64: bool = cfg!(target_arch = "wasm32");
                if v64 {
                    let v65: Rc<str> = v58.borrow().l0.clone();
                    let v66: bool = &*v65 == "";
                    let v74: Rc<str> = if v66 {
                        v52.clone()
                    } else {
                        let v67: bool = &*v52 == "";
                        if v67 {
                            let v68: Rc<str> = v58.borrow().l0.clone();
                            v68.clone()
                        } else {
                            let v69: Rc<str> = v58.borrow().l0.clone();
                            let v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v72: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v69, v70)), v52));
                            v72.clone()
                        }
                    };
                    let mut v76: usize = v74.chars().count();
                    let v77: i32 = ((v76) as i32);
                    let v78: i32 = v77.wrapping_add(14999i32);
                    let mut v79: i32 = v78.wrapping_div(15000i32);
                    let v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v81: bool = v52 != v80 ;
                    let mut v83: bool = if v81 {
                        let v82: bool = v79 <= 1i32;
                        v82
                    } else {
                        false
                    };
                    if v83 {
                        v58.borrow_mut().l0 = v74.clone();
                        ()
                    } else {
                        v58.borrow_mut().l0 = v80.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v74); };
                        ()
                    }
                } else {
                    println!("{}", v52);
                    ()
                };
                let mut v86: Rc<dyn Fn(Rc<str>) -> ()> = v56.borrow().l0.clone();
                v86(v52.clone());
                US2::US2_Some(v55.clone(), v56.clone(), v57.clone(), v58.clone(), v59.clone(), v60.clone())
            };
            ()
        };
        let mut v89: Rc<dyn Fn() -> ()> = method13();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v92, mut v93, mut v94, mut v95, mut v96, mut v97): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let v98: US0 = v96.borrow().l0.clone();
        let v103: i32 = match &v98 {
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
        let v104: bool = v94.borrow().l0.clone();
        let v105: bool = v104 == false;
        let mut v107: bool = if v105 {
            false
        } else {
            let v106: bool = 20i32 >= v103;
            v106
        };
        let v108: bool = v107 == false;
        let mut v155: US2 = if v108 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let v118: Rc<str> = method3(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone());
            let v119: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v128: i64 = v122.borrow().l0.clone();
            let v129: i64 = v128.wrapping_add(1i64);
            v122.borrow_mut().l0 = v129;
            let v130: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v131: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let v132: bool = cfg!(target_arch = "wasm32");
            if v132 {
                let v133: Rc<str> = v125.borrow().l0.clone();
                let v134: bool = &*v133 == "";
                let v142: Rc<str> = if v134 {
                    v130.clone()
                } else {
                    let v135: bool = &*v130 == "";
                    if v135 {
                        let v136: Rc<str> = v125.borrow().l0.clone();
                        v136.clone()
                    } else {
                        let v137: Rc<str> = v125.borrow().l0.clone();
                        let v138: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v140: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v137, v138)), v130));
                        v140.clone()
                    }
                };
                let v144: usize = v142.chars().count();
                let v145: i32 = ((v144) as i32);
                let mut v146: i32 = v145.wrapping_add(14999i32);
                let v147: i32 = v146.wrapping_div(15000i32);
                let v148: bool = v130 != v130 ;
                let v150: bool = if v148 {
                    let v149: bool = v147 <= 1i32;
                    v149
                } else {
                    false
                };
                if v150 {
                    v125.borrow_mut().l0 = v142.clone();
                    ()
                } else {
                    v125.borrow_mut().l0 = v130.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v142); };
                    ()
                }
            } else {
                println!("{}", v130);
                ()
            };
            let mut v153: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
            v153(v130.clone());
            US2::US2_Some(v122.clone(), v123.clone(), v124.clone(), v125.clone(), v126.clone(), v127.clone())
        };
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method14(mut v0: Vec<u8>) -> Vec<u8> {
    v0
}
fn method15(mut v0: Rc<Vec<u8>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: usize = ((v1) as usize);
            let v5: u8 = (v0)[v4].clone();
            let v6: i32 = v1.wrapping_sub(1i32);
            let v7: Rc<UH0> = Rc::new(UH0::UH0_Cons(v5, v2.clone()));
            (v0, v1, v2) = (v0.clone(), v6, v7.clone());
            continue;
        }
    }
}
fn closure8(mut v0: Rc<UH1>) -> Rc<dyn Fn() -> Rc<UH1>> {
    Rc::new(move || -> Rc<UH1> {
        v0.clone()
    })
}
fn method16(mut v0: Rc<UH0>, mut v1: Rc<UH1>) -> Rc<UH1> {
    match &*v0 {
        UH0::UH0_Cons(v2, v3) => {
            let mut v2: u8 = *v2;
            let mut v3: Rc<UH0> = v3.clone();
            let mut v4: Rc<UH1> = method16(v3, v1.clone());
            let v5: Rc<dyn Fn() -> Rc<UH1>> = closure8(v4);
            Rc::new(UH1::UH1_StreamCons(v2, v5))
        }
        UH0::UH0_Nil => {
            v1
        }
    }
}
fn closure9(mut v0: Rc<UH1>) -> Rc<dyn Fn() -> Rc<UH1>> {
    Rc::new(move || -> Rc<UH1> {
        v0.clone()
    })
}
fn method17(mut v0: Rc<UH1>, mut v1: Rc<UH1>) -> Rc<UH1> {
    match &*v0 {
        UH1::UH1_StreamCons(v2, v3) => {
            let mut v2: u8 = *v2;
            let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
            let mut v4: Rc<UH1> = v3();
            let v5: Rc<UH1> = method17(v4, v1.clone());
            let v6: i64 = (v2 as i64);
            let v7: i64 = v6.wrapping_sub(1i64);
            let mut v8: i64 = v7.wrapping_add(6i64);
            let v9: i64 = v8.wrapping_rem(6i64);
            let mut v10: i64 = v9.wrapping_add(1i64);
            let v11: u8 = (v10 as u8);
            let mut v12: Rc<dyn Fn() -> Rc<UH1>> = closure9(v5);
            Rc::new(UH1::UH1_StreamCons(v11, v12))
        }
        UH1::UH1_StreamNil => {
            v1
        }
    }
}
fn method18(mut v0: Rc<UH1>, mut v1: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH1::UH1_StreamCons(v2, v3) => {
            let mut v2: u8 = *v2;
            let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
            let mut v4: Rc<UH1> = v3();
            let v5: Rc<UH0> = method18(v4, v1.clone());
            Rc::new(UH0::UH0_Cons(v2, v5))
        }
        UH1::UH1_StreamNil => {
            v1
        }
    }
}
fn method19(mut v0: Rc<RefCell<Vec<u8>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: u8 = *v3;
                let mut v4: Rc<UH0> = v4.clone();
                v0.borrow_mut().push(v3);
                let v5: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH0::UH0_Nil => {
                return v2;
            }
        }
    }
}
fn format_real_21(mut v0: u64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method20(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: std::string::String, mut v10: std::string::String, mut v11: u64, mut v12: u64, mut v13: u64, mut v14: Rc<str>, mut v15: std::string::String, mut v16: std::string::String, mut v17: Rc<str>, mut v18: Rc<str>, mut v19: usize, mut v20: Rc<str>, mut v21: Rc<str>, mut v22: Rc<str>) -> Rc<str> {
    let v23: i64 = v0.borrow().l0.clone();
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v24));
    let v26: Rc<str> = format_real_11(v23);
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v7)), v24));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.generate_random_number"); } LIT.with(|lit| lit.clone()) };
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = format_real_21(v8);
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
    let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("key"); } LIT.with(|lit| lit.clone()) };
    let v46: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v43, v44)), v38));
    let v47: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v9)).s() });
    let v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v46, v47)), v42));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("proof"); } LIT.with(|lit| lit.clone()) };
    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v38));
    let mut v53: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v10)).s() });
    let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v52, v53)), v42));
    let v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_timestamp"); } LIT.with(|lit| lit.clone()) };
    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v55, v56)), v38));
    let v59: Rc<str> = format_real_21(v11);
    let v61: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v58, v59)), v42));
    let v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_height"); } LIT.with(|lit| lit.clone()) };
    let v64: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v61, v62)), v38));
    let v65: Rc<str> = format_real_21(v12);
    let v67: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v64, v65)), v42));
    let v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epoch_height"); } LIT.with(|lit| lit.clone()) };
    let v70: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v67, v68)), v38));
    let mut v71: Rc<str> = format_real_21(v13);
    let v73: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v70, v71)), v42));
    let v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_balance"); } LIT.with(|lit| lit.clone()) };
    let v78: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v73, v74)), v38)), v14)), v42));
    let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("signer_account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v78, v79)), v38));
    let v82: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v15)).s() });
    let v84: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v81, v82)), v42));
    let v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("predecessor_account_id"); } LIT.with(|lit| lit.clone()) };
    let v87: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v84, v85)), v38));
    let v88: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v16)).s() });
    let v90: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v87, v88)), v42));
    let v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed"); } LIT.with(|lit| lit.clone()) };
    let v95: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v90, v91)), v38)), v17)), v42));
    let v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
    let v100: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v95, v96)), v38)), v18)), v42));
    let v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("entropy_len"); } LIT.with(|lit| lit.clone()) };
    let v103: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v100, v101)), v38));
    let v104: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<usize>") } } (&&W(&v19)).s() });
    let v106: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v103, v104)), v42));
    let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("entropy"); } LIT.with(|lit| lit.clone()) };
    let v111: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v106, v107)), v38)), v20)), v42));
    let v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash_u8"); } LIT.with(|lit| lit.clone()) };
    let v116: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v111, v112)), v38)), v21)), v42));
    let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rolls"); } LIT.with(|lit| lit.clone()) };
    let v120: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v116, v117)), v38)), v22));
    let v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v122: Rc<str> = Rc::<str>::from(format!("{}{}", v121, v120));
    let v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v125: Rc<str> = Rc::<str>::from(format!("{}{}", v33, Rc::<str>::from(format!("{}{}", v122, v123))));
    method8(v125.clone())
}
fn method22(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v0 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: u8 = *v2;
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(v2, v1.clone()));
                (v0, v1) = (v3.clone(), v4.clone());
                continue;
            }
            UH0::UH0_Nil => {
                return v1.clone();
            }
        }
    }
}
fn method23(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH0::UH0_Cons(v2, v3) => {
            let mut v2: u8 = *v2;
            let mut v3: Rc<UH0> = v3.clone();
            let mut v4: Rc<UH0> = method23(v3, v1.clone());
            Rc::new(UH0::UH0_Cons(v2, v4))
        }
        UH0::UH0_Nil => {
            v1
        }
    }
}
fn closure10(mut v0: Rc<UH1>) -> Rc<dyn Fn() -> Rc<UH1>> {
    Rc::new(move || -> Rc<UH1> {
        v0.clone()
    })
}
fn closure11(mut v0: Rc<UH1>, mut v1: Rc<RefCell<Mut6>>) -> Rc<dyn Fn() -> Rc<UH1>> {
    Rc::new(move || -> Rc<UH1> {
        let mut v2: US3 = v1.borrow().l0.clone();
        match &v2 {
            US3::US3_Computed(v3) => {
                let mut v3: Rc<UH1> = v3.clone();
                v3.clone()
            }
            US3::US3_NotComputed(v4) => {
                let mut v4: Rc<dyn Fn() -> Rc<UH1>> = v4.clone();
                let v5: Rc<UH1> = v4();
                let mut v12: Rc<UH1> = match &*v5 {
                    UH1::UH1_StreamCons(v7, v8) => {
                        let v7: u8 = *v7;
                        let mut v8: Rc<dyn Fn() -> Rc<UH1>> = v8.clone();
                        let v9: Rc<dyn Fn() -> Rc<UH1>> = method24(v0.clone(), v8.clone());
                        Rc::new(UH1::UH1_StreamCons(v7, v9.clone()))
                    }
                    UH1::UH1_StreamNil => {
                        { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) }
                    }
                };
                let mut v13: US3 = US3::US3_Computed(v12.clone());
                v1.borrow_mut().l0 = v13.clone();
                v12.clone()
            }
        }
    })
}
fn method24(mut v0: Rc<UH1>, mut v1: Rc<dyn Fn() -> Rc<UH1>>) -> Rc<dyn Fn() -> Rc<UH1>> {
    let mut v2: US3 = US3::US3_NotComputed(v1);
    let mut v3: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: v2 }));
    closure11(v0, v3)
}
fn format_real_27(mut v0: i8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method26(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: u64, mut v10: i8) -> Rc<str> {
    let v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let v14: Rc<str> = format_real_11(v11);
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_21(v8);
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("p"); } LIT.with(|lit| lit.clone()) };
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26));
    let v35: Rc<str> = format_real_21(v9);
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v34, v35)), v30));
    let v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("n"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v37, v38)), v26));
    let v41: Rc<str> = format_real_27(v10);
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v47: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v44, v45))));
    method8(v47.clone())
}
fn method25(mut v0: u64, mut v1: i8, mut v2: u64) -> i8 {
    loop {
        let mut v3: bool = v2 < v0;
        if v3 {
            let mut v4: bool = v2 > 3074457345618258602u64;
            if v4 {
                let v5: Rc<str> = format_real_21(v0);
                let v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count / max: "); } LIT.with(|lit| lit.clone()) };
                let v7: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v5));
                let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" is above the largest supported bound "); } LIT.with(|lit| lit.clone()) };
                let v9: Rc<str> = Rc::<str>::from(format!("{}{}", v7, v8));
                let mut v10: Rc<str> = format_real_21(v2);
                let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v9, v10));
                return std::panic::panic_any::<std::string::String>(format!("{}", v11.clone()));
            } else {
                let mut v13: i8 = v1.wrapping_add(1i8);
                let v14: u64 = v2.wrapping_mul(6u64);
                (v0, v1, v2) = (v0, v13, v14);
                continue;
            }
        } else {
            let v18: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
            { let _ = spiral_trace_hold(&v18); };
            let v20: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v21, mut v22, mut v23, mut v24, mut v25, mut v26): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v20) };
            let v27: US0 = v25.borrow().l0.clone();
            let v32: i32 = match &v27 {
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
            let v33: bool = v23.borrow().l0.clone();
            let v34: bool = v33 == false;
            let v36: bool = if v34 {
                false
            } else {
                let v35: bool = 20i32 >= v32;
                v35
            };
            let v37: bool = v36 == false;
            let v85: US2 = if v37 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v18); };
                let (mut v41, mut v42, mut v43, mut v44, mut v45, mut v46): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v20) };
                let v47: Rc<str> = method3(v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone(), v46.clone());
                let v48: Rc<str> = method4();
                let v49: Rc<str> = method26(v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v0, v2, v1);
                { let _ = spiral_trace_hold(&v18); };
                let (mut v52, mut v53, mut v54, mut v55, mut v56, mut v57): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v20) };
                let mut v58: i64 = v52.borrow().l0.clone();
                let v59: i64 = v58.wrapping_add(1i64);
                v52.borrow_mut().l0 = v59;
                let v60: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v61: bool = cfg!(target_arch = "wasm32");
                if v61 {
                    let v62: Rc<str> = v55.borrow().l0.clone();
                    let v63: bool = &*v62 == "";
                    let mut v71: Rc<str> = if v63 {
                        v49.clone()
                    } else {
                        let v64: bool = &*v49 == "";
                        if v64 {
                            let v65: Rc<str> = v55.borrow().l0.clone();
                            v65.clone()
                        } else {
                            let v66: Rc<str> = v55.borrow().l0.clone();
                            let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v69: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v66, v67)), v49));
                            v69.clone()
                        }
                    };
                    let v73: usize = v71.chars().count();
                    let v74: i32 = ((v73) as i32);
                    let v75: i32 = v74.wrapping_add(14999i32);
                    let mut v76: i32 = v75.wrapping_div(15000i32);
                    let v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v78: bool = v49 != v77 ;
                    let v80: bool = if v78 {
                        let mut v79: bool = v76 <= 1i32;
                        v79
                    } else {
                        false
                    };
                    if v80 {
                        v55.borrow_mut().l0 = v71.clone();
                        ()
                    } else {
                        v55.borrow_mut().l0 = v77.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v71); };
                        ()
                    }
                } else {
                    println!("{}", v49);
                    ()
                };
                let mut v83: Rc<dyn Fn(Rc<str>) -> ()> = v53.borrow().l0.clone();
                v83(v49.clone());
                US2::US2_Some(v52.clone(), v53.clone(), v54.clone(), v55.clone(), v56.clone(), v57.clone())
            };
            return v1;
        }
    }
}
fn method30(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: i64, mut v10: i64, mut v11: Rc<str>) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0.clone();
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let v15: Rc<str> = format_real_11(v12);
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v14, v15)), v7)), v13));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll"); } LIT.with(|lit| lit.clone()) };
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("current_index"); } LIT.with(|lit| lit.clone()) };
    let v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("current_index"); } LIT.with(|lit| lit.clone()) };
    let v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("current_index = "); } LIT.with(|lit| lit.clone()) };
    let v29: Rc<str> = format_real_11(v8);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v27));
    let v36: Rc<str> = format_real_11(v9);
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v31));
    let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("len"); } LIT.with(|lit| lit.clone()) };
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v27));
    let v42: Rc<str> = format_real_11(v10);
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v41, v42)), v31));
    let v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("last_item"); } LIT.with(|lit| lit.clone()) };
    let v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, v45)), v27)), v11));
    let v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v48));
    let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v22, Rc::<str>::from(format!("{}{}", v50, v51))));
    method8(v53.clone())
}
fn method31(mut v0: i64, mut v1: Rc<UH1>) -> US4 {
    loop {
        match &*v1 {
            UH1::UH1_StreamCons(v2, v3) => {
                let mut v2: u8 = *v2;
                let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
                let mut v4: bool = v0 <= 0i64;
                if v4 {
                    return US4::US4_Some(v2);
                } else {
                    let v6: i64 = v0.wrapping_sub(1i64);
                    let v7: Rc<UH1> = v3();
                    (v0, v1) = (v6, v7.clone());
                    continue;
                }
            }
            UH1::UH1_StreamNil => {
                return US4::US4_None;
            }
        }
    }
}
fn format_real_33() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v1: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v0.clone() }));
    let mut v2: Rc<str> = v1.borrow().l0.clone();
    v2.clone()
}
fn method32(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>) -> Rc<str> {
    let mut v8: i64 = v0.borrow().l0.clone();
    let v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v9));
    let v11: Rc<str> = format_real_11(v8);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v10, v11)), v7)), v9));
    let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll / None"); } LIT.with(|lit| lit.clone()) };
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = format_real_33();
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    method8(v20.clone())
}
fn method29(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>) -> u8 {
    loop {
        let v5: i64 = v1.borrow().l0.clone();
        let v6: i64 = v2.borrow().l0.clone();
        let v7: i64 = v3.borrow().l0.clone();
        let mut v8: US4 = v4.borrow().l0.clone();
        let mut v13: Option<u8> = match &v8 {
            US4::US4_None => {
                let v11: Option<u8> = None;
                v11.clone()
            }
            US4::US4_Some(v9) => {
                let v9: u8 = *v9;
                let mut v10: Option<u8> = Some(v9.clone());
                v10.clone()
            }
        };
        let v15: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v15); };
        let v17: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v18, mut v19, mut v20, mut v21, mut v22, mut v23): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
        let v24: US0 = v22.borrow().l0.clone();
        let v29: i32 = match &v24 {
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
        let v30: bool = v20.borrow().l0.clone();
        let v31: bool = v30 == false;
        let v33: bool = if v31 {
            false
        } else {
            let v32: bool = 20i32 >= v29;
            v32
        };
        let v34: bool = v33 == false;
        let mut v83: US2 = if v34 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v15); };
            let (mut v38, mut v39, mut v40, mut v41, mut v42, mut v43): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
            let v44: Rc<str> = method3(v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone());
            let v45: Rc<str> = method4();
            let v46: Rc<str> = Rc::<str>::from(match &v13 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let v47: Rc<str> = method30(v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone(), v5, v6, v7, v46.clone());
            { let _ = spiral_trace_hold(&v15); };
            let (mut v50, mut v51, mut v52, mut v53, mut v54, mut v55): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
            let v56: i64 = v50.borrow().l0.clone();
            let v57: i64 = v56.wrapping_add(1i64);
            v50.borrow_mut().l0 = v57;
            let mut v58: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let v59: bool = cfg!(target_arch = "wasm32");
            if v59 {
                let v60: Rc<str> = v53.borrow().l0.clone();
                let v61: bool = &*v60 == "";
                let v69: Rc<str> = if v61 {
                    v47.clone()
                } else {
                    let v62: bool = &*v47 == "";
                    if v62 {
                        let v63: Rc<str> = v53.borrow().l0.clone();
                        v63.clone()
                    } else {
                        let v64: Rc<str> = v53.borrow().l0.clone();
                        let v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v67: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v64, v65)), v47));
                        v67.clone()
                    }
                };
                let mut v71: usize = v69.chars().count();
                let v72: i32 = ((v71) as i32);
                let v73: i32 = v72.wrapping_add(14999i32);
                let v74: i32 = v73.wrapping_div(15000i32);
                let v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v76: bool = v47 != v75 ;
                let v78: bool = if v76 {
                    let v77: bool = v74 <= 1i32;
                    v77
                } else {
                    false
                };
                if v78 {
                    v53.borrow_mut().l0 = v69.clone();
                    ()
                } else {
                    v53.borrow_mut().l0 = v75.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v69); };
                    ()
                }
            } else {
                println!("{}", v47);
                ()
            };
            let mut v81: Rc<dyn Fn(Rc<str>) -> ()> = v51.borrow().l0.clone();
            v81(v47.clone());
            US2::US2_Some(v50.clone(), v51.clone(), v52.clone(), v53.clone(), v54.clone(), v55.clone())
        };
        let v84: Rc<UH1> = v0();
        let v85: i64 = v1.borrow().l0.clone();
        let mut v86: US4 = method31(v85, v84.clone());
        match &v86 {
            US4::US4_None => {
                { let _ = spiral_trace_hold(&v15); };
                let (mut v93, mut v94, mut v95, mut v96, mut v97, mut v98): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
                let v99: US0 = v97.borrow().l0.clone();
                let v104: i32 = match &v99 {
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
                let v105: bool = v95.borrow().l0.clone();
                let v106: bool = v105 == false;
                let v108: bool = if v106 {
                    false
                } else {
                    let mut v107: bool = 20i32 >= v104;
                    v107
                };
                let v109: bool = v108 == false;
                let v157: US2 = if v109 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v15); };
                    let (mut v113, mut v114, mut v115, mut v116, mut v117, mut v118): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
                    let v119: Rc<str> = method3(v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone());
                    let v120: Rc<str> = method4();
                    let v121: Rc<str> = method32(v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v119.clone(), v120.clone());
                    { let _ = spiral_trace_hold(&v15); };
                    let (mut v124, mut v125, mut v126, mut v127, mut v128, mut v129): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
                    let v130: i64 = v124.borrow().l0.clone();
                    let v131: i64 = v130.wrapping_add(1i64);
                    v124.borrow_mut().l0 = v131;
                    let v132: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                    let v133: bool = cfg!(target_arch = "wasm32");
                    if v133 {
                        let v134: Rc<str> = v127.borrow().l0.clone();
                        let v135: bool = &*v134 == "";
                        let mut v143: Rc<str> = if v135 {
                            v121.clone()
                        } else {
                            let v136: bool = &*v121 == "";
                            if v136 {
                                let v137: Rc<str> = v127.borrow().l0.clone();
                                v137.clone()
                            } else {
                                let v138: Rc<str> = v127.borrow().l0.clone();
                                let v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let v141: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v138, v139)), v121));
                                v141.clone()
                            }
                        };
                        let v145: usize = v143.chars().count();
                        let mut v146: i32 = ((v145) as i32);
                        let v147: i32 = v146.wrapping_add(14999i32);
                        let v148: i32 = v147.wrapping_div(15000i32);
                        let v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v150: bool = v121 != v149 ;
                        let v152: bool = if v150 {
                            let v151: bool = v148 <= 1i32;
                            v151
                        } else {
                            false
                        };
                        if v152 {
                            v127.borrow_mut().l0 = v143.clone();
                            ()
                        } else {
                            v127.borrow_mut().l0 = v149.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v143); };
                            ()
                        }
                    } else {
                        println!("{}", v121);
                        ()
                    };
                    let mut v155: Rc<dyn Fn(Rc<str>) -> ()> = v125.borrow().l0.clone();
                    v155(v121.clone());
                    US2::US2_Some(v124.clone(), v125.clone(), v126.clone(), v127.clone(), v128.clone(), v129.clone())
                };
                let v158: i64 = v3.borrow().l0.clone();
                let v159: bool = v158 == -1i64;
                if v159 {
                    let v160: i64 = v1.borrow().l0.clone();
                    v3.borrow_mut().l0 = v160;
                    ()
                };
                let v161: i64 = v2.borrow().l0.clone();
                let v162: i64 = v3.borrow().l0.clone();
                let v163: bool = v161 >= v162;
                let v166: i64 = if v163 {
                    1i64
                } else {
                    let v164: i64 = v2.borrow().l0.clone();
                    let v165: i64 = v164.wrapping_add(1i64);
                    v165
                };
                v2.borrow_mut().l0 = v166;
                let v167: i64 = v2.borrow().l0.clone();
                let v168: i64 = v167.wrapping_sub(1i64);
                v1.borrow_mut().l0 = v168;
                let v169: US4 = US4::US4_None;
                v4.borrow_mut().l0 = v169.clone();
                (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
                continue;
            }
            US4::US4_Some(v87) => {
                let v87: u8 = *v87;
                let v88: i64 = v1.borrow().l0.clone();
                let mut v89: i64 = v88.wrapping_add(1i64);
                v1.borrow_mut().l0 = v89;
                let v90: US4 = US4::US4_Some(v87);
                v4.borrow_mut().l0 = v90.clone();
                return v87;
            }
        }
    }
}
fn method35(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let v14: Rc<str> = format_real_11(v11);
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_27(v8);
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26));
    let v35: Rc<str> = format_real_21(v9);
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v34, v35)), v30));
    let v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v37, v38)), v26));
    let v41: Rc<str> = format_real_21(v10);
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v47: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v44, v45))));
    method8(v47.clone())
}
fn closure75() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_StreamNil); } CASE.with(|case| case.clone()) }
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure74() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure75();
        Rc::new(UH2::UH2_StreamCons(9223372036854775808u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure73() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure74();
        Rc::new(UH2::UH2_StreamCons(4611686018427387904u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure72() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure73();
        Rc::new(UH2::UH2_StreamCons(6917529027641081856u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure71() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure72();
        Rc::new(UH2::UH2_StreamCons(1152921504606846976u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure70() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure71();
        Rc::new(UH2::UH2_StreamCons(15564440312192434176u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure69() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure70();
        Rc::new(UH2::UH2_StreamCons(11817445422220181504u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure68() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure69();
        Rc::new(UH2::UH2_StreamCons(5044031582654955520u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure67() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure68();
        Rc::new(UH2::UH2_StreamCons(6989586621679009792u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure66() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure67();
        Rc::new(UH2::UH2_StreamCons(16537217831704461312u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure65() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure66();
        Rc::new(UH2::UH2_StreamCons(11979575008805519360u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure64() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure65();
        Rc::new(UH2::UH2_StreamCons(14294425217273954304u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure63() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure64();
        Rc::new(UH2::UH2_StreamCons(2382404202878992384u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure62() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure63();
        Rc::new(UH2::UH2_StreamCons(6545982058383015936u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure61() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure62();
        Rc::new(UH2::UH2_StreamCons(10314369046585278464u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure60() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure61();
        Rc::new(UH2::UH2_StreamCons(4793518853382471680u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure59() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure60();
        Rc::new(UH2::UH2_StreamCons(3873377154515337216u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure58() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure59();
        Rc::new(UH2::UH2_StreamCons(645562859085889536u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure57() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure58();
        Rc::new(UH2::UH2_StreamCons(107593809847648256u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure56() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure57();
        Rc::new(UH2::UH2_StreamCons(3092389647259533312u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure55() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure56();
        Rc::new(UH2::UH2_StreamCons(9738770311398031360u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure54() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure55();
        Rc::new(UH2::UH2_StreamCons(16995415113324298240u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure53() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure54();
        Rc::new(UH2::UH2_StreamCons(8981483876790566912u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure52() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure53();
        Rc::new(UH2::UH2_StreamCons(13794743361938128896u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure51() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure52();
        Rc::new(UH2::UH2_StreamCons(2299123893656354816u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure50() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure51();
        Rc::new(UH2::UH2_StreamCons(3457644661227651072u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure49() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure50();
        Rc::new(UH2::UH2_StreamCons(576274110204608512u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure48() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure49();
        Rc::new(UH2::UH2_StreamCons(6244960376270618624u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure47() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure48();
        Rc::new(UH2::UH2_StreamCons(13338656111851470848u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure46() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure47();
        Rc::new(UH2::UH2_StreamCons(14520938734448279552u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure45() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure46();
        Rc::new(UH2::UH2_StreamCons(14717985838214414336u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure44() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure45();
        Rc::new(UH2::UH2_StreamCons(5527454985320660992u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure43() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure44();
        Rc::new(UH2::UH2_StreamCons(16293529225644736512u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure42() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure43();
        Rc::new(UH2::UH2_StreamCons(11938960241128898560u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure41() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure42();
        Rc::new(UH2::UH2_StreamCons(8138741398091333632u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure40() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure41();
        Rc::new(UH2::UH2_StreamCons(7505371590918406144u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure39() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure40();
        Rc::new(UH2::UH2_StreamCons(16623181993244360704u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure38() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure39();
        Rc::new(UH2::UH2_StreamCons(8919445023443910656u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure37() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure38();
        Rc::new(UH2::UH2_StreamCons(4561031516192243712u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure36() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure37();
        Rc::new(UH2::UH2_StreamCons(9983543956220149760u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure35() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure36();
        Rc::new(UH2::UH2_StreamCons(4738381338321616896u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure34() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure35();
        Rc::new(UH2::UH2_StreamCons(789730223053602816u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure33() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure34();
        Rc::new(UH2::UH2_StreamCons(131621703842267136u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure32() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure33();
        Rc::new(UH2::UH2_StreamCons(21936950640377856u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure31() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure32();
        Rc::new(UH2::UH2_StreamCons(3656158440062976u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure30() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure31();
        Rc::new(UH2::UH2_StreamCons(609359740010496u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure29() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure30();
        Rc::new(UH2::UH2_StreamCons(101559956668416u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure28() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure29();
        Rc::new(UH2::UH2_StreamCons(16926659444736u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure27() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure28();
        Rc::new(UH2::UH2_StreamCons(2821109907456u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure26() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure27();
        Rc::new(UH2::UH2_StreamCons(470184984576u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure25() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure26();
        Rc::new(UH2::UH2_StreamCons(78364164096u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure24() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure25();
        Rc::new(UH2::UH2_StreamCons(13060694016u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure23() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure24();
        Rc::new(UH2::UH2_StreamCons(2176782336u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure22() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure23();
        Rc::new(UH2::UH2_StreamCons(362797056u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure21() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure22();
        Rc::new(UH2::UH2_StreamCons(60466176u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure20() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure21();
        Rc::new(UH2::UH2_StreamCons(10077696u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure19() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure20();
        Rc::new(UH2::UH2_StreamCons(1679616u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure18() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure19();
        Rc::new(UH2::UH2_StreamCons(279936u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure17() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure18();
        Rc::new(UH2::UH2_StreamCons(46656u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure16() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure17();
        Rc::new(UH2::UH2_StreamCons(7776u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure15() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure16();
        Rc::new(UH2::UH2_StreamCons(1296u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure14() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure15();
        Rc::new(UH2::UH2_StreamCons(216u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure13() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure14();
        Rc::new(UH2::UH2_StreamCons(36u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure12() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure13();
        Rc::new(UH2::UH2_StreamCons(6u64, v0.clone()))
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method36(mut v0: i8, mut v1: Rc<UH2>) -> US6 {
    loop {
        match &*v1 {
            UH2::UH2_StreamCons(v2, v3) => {
                let mut v2: u64 = *v2;
                let mut v3: Rc<dyn Fn() -> Rc<UH2>> = v3.clone();
                let mut v4: bool = v0 <= 0i8;
                if v4 {
                    return US6::US6_Some(v2);
                } else {
                    let v6: i8 = v0.wrapping_sub(1i8);
                    let v7: Rc<UH2> = v3();
                    (v0, v1) = (v6, v7.clone());
                    continue;
                }
            }
            UH2::UH2_StreamNil => {
                return US6::US6_None;
            }
        }
    }
}
fn format_real_38(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method37(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u8, mut v11: u64) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0.clone();
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let v15: Rc<str> = format_real_11(v12);
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v14, v15)), v7)), v13));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let v29: Rc<str> = format_real_27(v8);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v27));
    let v36: Rc<str> = format_real_21(v9);
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v31));
    let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v27));
    let v42: Rc<str> = format_real_38(v10);
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v41, v42)), v31));
    let v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, v45)), v27));
    let v48: Rc<str> = format_real_21(v11);
    let v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v54: Rc<str> = Rc::<str>::from(format!("{}{}", v22, Rc::<str>::from(format!("{}{}", v51, v52))));
    method8(v54.clone())
}
fn method39(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u8) -> Rc<str> {
    let v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let v14: Rc<str> = format_real_11(v11);
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_27(v8);
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26));
    let v35: Rc<str> = format_real_21(v9);
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v34, v35)), v30));
    let v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v37, v38)), v26));
    let v41: Rc<str> = format_real_38(v10);
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v47: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v44, v45))));
    method8(v47.clone())
}
fn method34(mut v0: i8, mut v1: Rc<UH0>, mut v2: u64) -> US5 {
    loop {
        let mut v3: bool = v0 < 0i8;
        if v3 {
            let mut v4: u64 = v2.wrapping_add(1u64);
            let v6: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
            { let _ = spiral_trace_hold(&v6); };
            let mut v8: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v9, mut v10, mut v11, mut v12, mut v13, mut v14): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
            let v15: US0 = v13.borrow().l0.clone();
            let v20: i32 = match &v15 {
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
            let v21: bool = v11.borrow().l0.clone();
            let v22: bool = v21 == false;
            let v24: bool = if v22 {
                false
            } else {
                let v23: bool = 20i32 >= v20;
                v23
            };
            let v25: bool = v24 == false;
            let v73: US2 = if v25 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v6); };
                let (mut v29, mut v30, mut v31, mut v32, mut v33, mut v34): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                let v35: Rc<str> = method3(v29.clone(), v30.clone(), v31.clone(), v32.clone(), v33.clone(), v34.clone());
                let v36: Rc<str> = method4();
                let v37: Rc<str> = method35(v29.clone(), v30.clone(), v31.clone(), v32.clone(), v33.clone(), v34.clone(), v35.clone(), v36.clone(), v0, v2, v4);
                { let _ = spiral_trace_hold(&v6); };
                let (mut v40, mut v41, mut v42, mut v43, mut v44, mut v45): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                let v46: i64 = v40.borrow().l0.clone();
                let v47: i64 = v46.wrapping_add(1i64);
                v40.borrow_mut().l0 = v47;
                let v48: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v49: bool = cfg!(target_arch = "wasm32");
                if v49 {
                    let mut v50: Rc<str> = v43.borrow().l0.clone();
                    let v51: bool = &*v50 == "";
                    let v59: Rc<str> = if v51 {
                        v37.clone()
                    } else {
                        let mut v52: bool = &*v37 == "";
                        if v52 {
                            let mut v53: Rc<str> = v43.borrow().l0.clone();
                            v53.clone()
                        } else {
                            let v54: Rc<str> = v43.borrow().l0.clone();
                            let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v54, v55)), v37));
                            v57.clone()
                        }
                    };
                    let v61: usize = v59.chars().count();
                    let v62: i32 = ((v61) as i32);
                    let v63: i32 = v62.wrapping_add(14999i32);
                    let v64: i32 = v63.wrapping_div(15000i32);
                    let v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v66: bool = v37 != v65 ;
                    let v68: bool = if v66 {
                        let v67: bool = v64 <= 1i32;
                        v67
                    } else {
                        false
                    };
                    if v68 {
                        v43.borrow_mut().l0 = v59.clone();
                        ()
                    } else {
                        v43.borrow_mut().l0 = v65.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v59); };
                        ()
                    }
                } else {
                    println!("{}", v37);
                    ()
                };
                let mut v71: Rc<dyn Fn(Rc<str>) -> ()> = v41.borrow().l0.clone();
                v71(v37.clone());
                US2::US2_Some(v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone())
            };
            return US5::US5_Some(v4, v1.clone());
        } else {
            match &*v1 {
                UH0::UH0_Cons(v76, v77) => {
                    let mut v76: u8 = *v76;
                    let v77: Rc<UH0> = v77.clone();
                    let v78: bool = v76 > 1u8;
                    if v78 {
                        let mut v79: u64 = 1u64;
                        let v80: Rc<dyn Fn() -> Rc<UH2>> = closure12();
                        let mut v81: Rc<UH2> = Rc::new(UH2::UH2_StreamCons(v79, v80.clone()));
                        let v82: US6 = method36(v0, v81.clone());
                        let mut v86: u64 = match &v82 {
                            US6::US6_None => {
                                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
                            }
                            US6::US6_Some(v83) => {
                                let mut v83: u64 = *v83;
                                v83
                            }
                        };
                        let v87: u8 = v76.wrapping_sub(1u8);
                        let v88: u64 = (v87 as u64);
                        let mut v89: u64 = v88.wrapping_mul(v86);
                        let v91: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                        { let _ = spiral_trace_hold(&v91); };
                        let v93: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v94, mut v95, mut v96, mut v97, mut v98, mut v99): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v93) };
                        let v100: US0 = v98.borrow().l0.clone();
                        let v105: i32 = match &v100 {
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
                        let v106: bool = v96.borrow().l0.clone();
                        let mut v107: bool = v106 == false;
                        let v109: bool = if v107 {
                            false
                        } else {
                            let v108: bool = 20i32 >= v105;
                            v108
                        };
                        let v110: bool = v109 == false;
                        let v158: US2 = if v110 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v91); };
                            let (mut v114, mut v115, mut v116, mut v117, mut v118, mut v119): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v93) };
                            let v120: Rc<str> = method3(v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v119.clone());
                            let v121: Rc<str> = method4();
                            let mut v122: Rc<str> = method37(v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v119.clone(), v120.clone(), v121.clone(), v0, v2, v76, v89);
                            { let _ = spiral_trace_hold(&v91); };
                            let (mut v125, mut v126, mut v127, mut v128, mut v129, mut v130): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v93) };
                            let v131: i64 = v125.borrow().l0.clone();
                            let v132: i64 = v131.wrapping_add(1i64);
                            v125.borrow_mut().l0 = v132;
                            let v133: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v134: bool = cfg!(target_arch = "wasm32");
                            if v134 {
                                let v135: Rc<str> = v128.borrow().l0.clone();
                                let v136: bool = &*v135 == "";
                                let v144: Rc<str> = if v136 {
                                    v122.clone()
                                } else {
                                    let v137: bool = &*v122 == "";
                                    if v137 {
                                        let v138: Rc<str> = v128.borrow().l0.clone();
                                        v138.clone()
                                    } else {
                                        let v139: Rc<str> = v128.borrow().l0.clone();
                                        let v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v142: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v139, v140)), v122));
                                        v142.clone()
                                    }
                                };
                                let mut v146: usize = v144.chars().count();
                                let v147: i32 = ((v146) as i32);
                                let v148: i32 = v147.wrapping_add(14999i32);
                                let v149: i32 = v148.wrapping_div(15000i32);
                                let v150: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v151: bool = v122 != v150 ;
                                let mut v153: bool = if v151 {
                                    let v152: bool = v149 <= 1i32;
                                    v152
                                } else {
                                    false
                                };
                                if v153 {
                                    v128.borrow_mut().l0 = v144.clone();
                                    ()
                                } else {
                                    v128.borrow_mut().l0 = v150.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v144); };
                                    ()
                                }
                            } else {
                                println!("{}", v122);
                                ()
                            };
                            let mut v156: Rc<dyn Fn(Rc<str>) -> ()> = v126.borrow().l0.clone();
                            v156(v122.clone());
                            US2::US2_Some(v125.clone(), v126.clone(), v127.clone(), v128.clone(), v129.clone(), v130.clone())
                        };
                        let v159: u64 = v2.wrapping_add(v89);
                        let v160: i8 = v0.wrapping_sub(1i8);
                        (v0, v1, v2) = (v160, v77.clone(), v159);
                        continue;
                    } else {
                        let v163: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                        { let _ = spiral_trace_hold(&v163); };
                        let v165: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v166, mut v167, mut v168, mut v169, mut v170, mut v171): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v165) };
                        let v172: US0 = v170.borrow().l0.clone();
                        let v177: i32 = match &v172 {
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
                        let v178: bool = v168.borrow().l0.clone();
                        let v179: bool = v178 == false;
                        let v181: bool = if v179 {
                            false
                        } else {
                            let v180: bool = 20i32 >= v177;
                            v180
                        };
                        let v182: bool = v181 == false;
                        let v230: US2 = if v182 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v163); };
                            let (mut v186, mut v187, mut v188, mut v189, mut v190, mut v191): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v165) };
                            let v192: Rc<str> = method3(v186.clone(), v187.clone(), v188.clone(), v189.clone(), v190.clone(), v191.clone());
                            let v193: Rc<str> = method4();
                            let v194: Rc<str> = method39(v186.clone(), v187.clone(), v188.clone(), v189.clone(), v190.clone(), v191.clone(), v192.clone(), v193.clone(), v0, v2, v76);
                            { let _ = spiral_trace_hold(&v163); };
                            let (mut v197, mut v198, mut v199, mut v200, mut v201, mut v202): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v165) };
                            let v203: i64 = v197.borrow().l0.clone();
                            let v204: i64 = v203.wrapping_add(1i64);
                            v197.borrow_mut().l0 = v204;
                            let v205: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v206: bool = cfg!(target_arch = "wasm32");
                            if v206 {
                                let v207: Rc<str> = v200.borrow().l0.clone();
                                let v208: bool = &*v207 == "";
                                let v216: Rc<str> = if v208 {
                                    v194.clone()
                                } else {
                                    let v209: bool = &*v194 == "";
                                    if v209 {
                                        let v210: Rc<str> = v200.borrow().l0.clone();
                                        v210.clone()
                                    } else {
                                        let v211: Rc<str> = v200.borrow().l0.clone();
                                        let v212: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v214: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v211, v212)), v194));
                                        v214.clone()
                                    }
                                };
                                let v218: usize = v216.chars().count();
                                let v219: i32 = ((v218) as i32);
                                let v220: i32 = v219.wrapping_add(14999i32);
                                let v221: i32 = v220.wrapping_div(15000i32);
                                let v222: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v223: bool = v194 != v222 ;
                                let v225: bool = if v223 {
                                    let v224: bool = v221 <= 1i32;
                                    v224
                                } else {
                                    false
                                };
                                if v225 {
                                    v200.borrow_mut().l0 = v216.clone();
                                    ()
                                } else {
                                    v200.borrow_mut().l0 = v222.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v216); };
                                    ()
                                }
                            } else {
                                println!("{}", v194);
                                ()
                            };
                            let mut v228: Rc<dyn Fn(Rc<str>) -> ()> = v198.borrow().l0.clone();
                            v228(v194.clone());
                            US2::US2_Some(v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone())
                        };
                        let v231: i8 = v0.wrapping_sub(1i8);
                        (v0, v1, v2) = (v231, v77.clone(), v2);
                        continue;
                    }
                }
                UH0::UH0_Nil => {
                    return US5::US5_None;
                }
            }
        }
    }
}
fn method40(mut v0: i8, mut v1: Rc<dyn Fn() -> Rc<UH1>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut0>>, mut v5: Rc<RefCell<Mut7>>, mut v6: i8) -> Rc<UH0> {
    let v7: bool = v6 < v0;
    if v7 {
        let mut v8: u8 = method29(v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone());
        let v9: i8 = v6.wrapping_add(1i8);
        let mut v10: Rc<UH0> = method40(v0, v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v9);
        Rc::new(UH0::UH0_Cons(v8, v10.clone()))
    } else {
        { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) }
    }
}
fn method28(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>, mut v5: u64, mut v6: i8, mut v7: Rc<UH0>, mut v8: i8) -> u64 {
    loop {
        let v9: i8 = v6.wrapping_add(1i8);
        let mut v10: bool = v8 < v9;
        if v10 {
            let v11: u8 = method29(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
            let mut v12: Rc<UH0> = Rc::new(UH0::UH0_Cons(v11, v7.clone()));
            let mut v13: i8 = v8.wrapping_add(1i8);
            (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v12.clone(), v13);
            continue;
        } else {
            let v15: u64 = 0u64;
            let v16: US5 = method34(v6, v7.clone(), v15);
            match &v16 {
                US5::US5_Some(v17, v18) => {
                    let v17: u64 = *v17;
                    let v18: Rc<UH0> = v18.clone();
                    let v19: bool = v17 <= v5;
                    if v19 {
                        return v17;
                    } else {
                        let v20: i8 = 0i8;
                        let v21: Rc<UH0> = method40(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v20);
                        (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v21.clone(), v6);
                        continue;
                    }
                }
                _ => {
                    let v24: i8 = 0i8;
                    let v25: Rc<UH0> = method40(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v24);
                    (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v25.clone(), v6);
                    continue;
                }
            }
        }
    }
}
fn method41() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure7() -> Rc<dyn Fn(&mut SpiralNearVec<u8>, std::string::String, std::string::String, u64) -> u64> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut SpiralNearVec<u8>, std::string::String, std::string::String, u64) -> u64> = Rc::new(move |mut v0: &mut SpiralNearVec<u8>, mut v1: std::string::String, mut v2: std::string::String, mut v3: u64| -> u64 {
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v5); };
        let v7: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v8, mut v9, mut v10, mut v11, mut v12, mut v13): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let v14: US0 = US0::US0_Info;
        v12.borrow_mut().l0 = v14.clone();
        let v15: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::random_seed(); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        let v16: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::epoch_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let v17: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let v18: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_timestamp(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let v19: u128 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::account_balance().as_yoctonear(); #[cfg(not(target_arch = "wasm32"))] let v = 1u128; v };
        let v20: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::signer_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let v21: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::predecessor_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let v23: &SpiralNearVec<u8> = &*v0;
        let v24: Vec<u8> = (v23).iter().cloned().collect::<std::vec::Vec<_>>();
        let v25: _ = (v16).to_le_bytes().to_vec();
        let v26: Vec<u8> = (v25).clone();
        let v27: _ = (v17).to_le_bytes().to_vec();
        let mut v28: Vec<u8> = (v27).clone();
        let v29: _ = (v18).to_le_bytes().to_vec();
        let v30: Vec<u8> = (v29).clone();
        let v31: u128 = (v19.clone());
        let v32: _ = (v31).to_le_bytes().to_vec();
        let v33: Vec<u8> = (v32).clone();
        let v34: &[u8] = (v20).as_bytes();
        let v35: Vec<u8> = (v34).to_vec();
        let v36: &[u8] = (v21).as_bytes();
        let v37: Vec<u8> = (v36).to_vec();
        let v38: Vec<u8> = (v2).as_bytes().to_vec();
        let v39: Vec<u8> = (v1).as_bytes().to_vec();
        let mut v40: Rc<RefCell<Vec<Vec<u8>>>> = Rc::new(RefCell::new(vec![v15.clone(), v24.clone(), v26.clone(), v28.clone(), v30.clone(), v33.clone(), v35.clone(), v37.clone(), v38.clone(), v39.clone()]));
        let v41: Vec<Vec<u8>> = (v40).borrow().clone();
        let v42: Vec<u8> = (v41).concat();
        let mut v43: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::keccak512(&(v42.clone())); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        { (v0).extend((v43).clone()); };
        let v44: u32 = ((v0).len() as u32);
        let v45: i32 = (v44 as i32);
        let v46: usize = ((100i32) as usize);
        let v47: i32 = (v46 as i32);
        let v48: i32 = v45.wrapping_sub(v47);
        let v49: bool = v48 > 0i32;
        if v49 {
            let v51: Vec<u8> = v0.drain(0..v48 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v54, mut v55, mut v56, mut v57, mut v58, mut v59): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let v60: US0 = v58.borrow().l0.clone();
            let v65: i32 = match &v60 {
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
            let v66: bool = v56.borrow().l0.clone();
            let v67: bool = v66 == false;
            let v69: bool = if v67 {
                false
            } else {
                let v68: bool = 20i32 >= v65;
                v68
            };
            let v70: bool = v69 == false;
            let v119: US2 = if v70 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v5); };
                let (mut v74, mut v75, mut v76, mut v77, mut v78, mut v79): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let v80: Rc<str> = method3(v74.clone(), v75.clone(), v76.clone(), v77.clone(), v78.clone(), v79.clone());
                let mut v81: Rc<str> = method4();
                let v82: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v51)).s() });
                let mut v83: Rc<str> = method7(v74.clone(), v75.clone(), v76.clone(), v77.clone(), v78.clone(), v79.clone(), v80.clone(), v81.clone(), v48, v82.clone());
                { let _ = spiral_trace_hold(&v5); };
                let (mut v86, mut v87, mut v88, mut v89, mut v90, mut v91): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let v92: i64 = v86.borrow().l0.clone();
                let v93: i64 = v92.wrapping_add(1i64);
                v86.borrow_mut().l0 = v93;
                let v94: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v95: bool = cfg!(target_arch = "wasm32");
                if v95 {
                    let v96: Rc<str> = v89.borrow().l0.clone();
                    let v97: bool = &*v96 == "";
                    let v105: Rc<str> = if v97 {
                        v83.clone()
                    } else {
                        let v98: bool = &*v83 == "";
                        if v98 {
                            let v99: Rc<str> = v89.borrow().l0.clone();
                            v99.clone()
                        } else {
                            let v100: Rc<str> = v89.borrow().l0.clone();
                            let v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v103: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v100, v101)), v83));
                            v103.clone()
                        }
                    };
                    let mut v107: usize = v105.chars().count();
                    let v108: i32 = ((v107) as i32);
                    let v109: i32 = v108.wrapping_add(14999i32);
                    let v110: i32 = v109.wrapping_div(15000i32);
                    let v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v112: bool = v83 != v111 ;
                    let v114: bool = if v112 {
                        let v113: bool = v110 <= 1i32;
                        v113
                    } else {
                        false
                    };
                    if v114 {
                        v89.borrow_mut().l0 = v105.clone();
                        ()
                    } else {
                        v89.borrow_mut().l0 = v111.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v105); };
                        ()
                    }
                } else {
                    println!("{}", v83);
                    ()
                };
                let mut v117: Rc<dyn Fn(Rc<str>) -> ()> = v87.borrow().l0.clone();
                v117(v83.clone());
                US2::US2_Some(v86.clone(), v87.clone(), v88.clone(), v89.clone(), v90.clone(), v91.clone())
            };
            ()
        };
        let v120: Rc<dyn Fn() -> ()> = method13();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v123, mut v124, mut v125, mut v126, mut v127, mut v128): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let v129: US0 = v127.borrow().l0.clone();
        let v134: i32 = match &v129 {
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
        let v135: bool = v125.borrow().l0.clone();
        let v136: bool = v135 == false;
        let v138: bool = if v136 {
            false
        } else {
            let v137: bool = 20i32 >= v134;
            v137
        };
        let v139: bool = v138 == false;
        let v186: US2 = if v139 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v143, mut v144, mut v145, mut v146, mut v147, mut v148): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let v149: Rc<str> = method3(v143.clone(), v144.clone(), v145.clone(), v146.clone(), v147.clone(), v148.clone());
            let v150: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v153, mut v154, mut v155, mut v156, mut v157, mut v158): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let v159: i64 = v153.borrow().l0.clone();
            let v160: i64 = v159.wrapping_add(1i64);
            v153.borrow_mut().l0 = v160;
            let v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v162: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let v163: bool = cfg!(target_arch = "wasm32");
            if v163 {
                let v164: Rc<str> = v156.borrow().l0.clone();
                let v165: bool = &*v164 == "";
                let v173: Rc<str> = if v165 {
                    v161.clone()
                } else {
                    let v166: bool = &*v161 == "";
                    if v166 {
                        let v167: Rc<str> = v156.borrow().l0.clone();
                        v167.clone()
                    } else {
                        let v168: Rc<str> = v156.borrow().l0.clone();
                        let v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v171: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v168, v169)), v161));
                        v171.clone()
                    }
                };
                let v175: usize = v173.chars().count();
                let v176: i32 = ((v175) as i32);
                let v177: i32 = v176.wrapping_add(14999i32);
                let v178: i32 = v177.wrapping_div(15000i32);
                let v179: bool = v161 != v161 ;
                let v181: bool = if v179 {
                    let v180: bool = v178 <= 1i32;
                    v180
                } else {
                    false
                };
                if v181 {
                    v156.borrow_mut().l0 = v173.clone();
                    ()
                } else {
                    v156.borrow_mut().l0 = v161.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v173); };
                    ()
                }
            } else {
                println!("{}", v161);
                ()
            };
            let mut v184: Rc<dyn Fn(Rc<str>) -> ()> = v154.borrow().l0.clone();
            v184(v161.clone());
            US2::US2_Some(v153.clone(), v154.clone(), v155.clone(), v156.clone(), v157.clone(), v158.clone())
        };
        let v187: Vec<u8> = method14(v43.clone());
        let v188: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v187));
        let v189: Rc<Vec<u8>> = Rc::new((v188).borrow().clone());
        let v190: usize = (v189).len();
        let v191: i32 = ((v190) as i32);
        let v192: i32 = v191.wrapping_sub(1i32);
        let v193: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let v194: Rc<UH0> = method15(v189.clone(), v192, v193.clone());
        let v195: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) };
        let v196: Rc<UH1> = method16(v194.clone(), v195.clone());
        let mut v197: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) };
        let v198: Rc<UH1> = method17(v196.clone(), v197.clone());
        let v199: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let mut v200: Rc<UH0> = method18(v198.clone(), v199.clone());
        { let _ = spiral_trace_hold(&v5); };
        let (mut v203, mut v204, mut v205, mut v206, mut v207, mut v208): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let v209: US0 = v207.borrow().l0.clone();
        let v214: i32 = match &v209 {
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
        let v215: bool = v205.borrow().l0.clone();
        let v216: bool = v215 == false;
        let v218: bool = if v216 {
            false
        } else {
            let v217: bool = 20i32 >= v214;
            v217
        };
        let v219: bool = v218 == false;
        let v284: US2 = if v219 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v223, mut v224, mut v225, mut v226, mut v227, mut v228): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let v229: Rc<str> = method3(v223.clone(), v224.clone(), v225.clone(), v226.clone(), v227.clone(), v228.clone());
            let v230: Rc<str> = method4();
            let v231: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<u128>") } } (&&W(&v19)).s() });
            let v233: std::string::String = v20.to_string();
            let v235: std::string::String = v21.to_string();
            let v236: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v15)).s() });
            let v237: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<&mut SpiralNearVec<u8>>") } } (&&W(&v0)).s() });
            let v238: usize = ((v42).len() as usize);
            let v239: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v42)).s() });
            let v240: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v43)).s() });
            let v241: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
            let v242: i32 = 0i32;
            let v243: i32 = method19(v241.clone(), v200.clone(), v242);
            let v244: Rc<Vec<u8>> = Rc::new(v241.borrow().clone());
            let v245: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v244).as_ref().clone()));
            let v246: Vec<u8> = (v245).borrow().clone();
            let v247: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v246)).s() });
            let v248: Rc<str> = method20(v223.clone(), v224.clone(), v225.clone(), v226.clone(), v227.clone(), v228.clone(), v229.clone(), v230.clone(), v3, v1.clone(), v2.clone(), v18, v17, v16, v231.clone(), v233.clone(), v235.clone(), v236.clone(), v237.clone(), v238.clone(), v239.clone(), v240.clone(), v247.clone());
            { let _ = spiral_trace_hold(&v5); };
            let (mut v251, mut v252, mut v253, mut v254, mut v255, mut v256): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let v257: i64 = v251.borrow().l0.clone();
            let v258: i64 = v257.wrapping_add(1i64);
            v251.borrow_mut().l0 = v258;
            let v259: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let v260: bool = cfg!(target_arch = "wasm32");
            if v260 {
                let v261: Rc<str> = v254.borrow().l0.clone();
                let v262: bool = &*v261 == "";
                let v270: Rc<str> = if v262 {
                    v248.clone()
                } else {
                    let v263: bool = &*v248 == "";
                    if v263 {
                        let v264: Rc<str> = v254.borrow().l0.clone();
                        v264.clone()
                    } else {
                        let v265: Rc<str> = v254.borrow().l0.clone();
                        let v266: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v268: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v265, v266)), v248));
                        v268.clone()
                    }
                };
                let v272: usize = v270.chars().count();
                let v273: i32 = ((v272) as i32);
                let v274: i32 = v273.wrapping_add(14999i32);
                let v275: i32 = v274.wrapping_div(15000i32);
                let v276: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v277: bool = v248 != v276 ;
                let v279: bool = if v277 {
                    let v278: bool = v275 <= 1i32;
                    v278
                } else {
                    false
                };
                if v279 {
                    v254.borrow_mut().l0 = v270.clone();
                    ()
                } else {
                    v254.borrow_mut().l0 = v276.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v270); };
                    ()
                }
            } else {
                println!("{}", v248);
                ()
            };
            let mut v282: Rc<dyn Fn(Rc<str>) -> ()> = v252.borrow().l0.clone();
            v282(v248.clone());
            US2::US2_Some(v251.clone(), v252.clone(), v253.clone(), v254.clone(), v255.clone(), v256.clone())
        };
        let v285: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let v286: Rc<UH0> = method22(v200.clone(), v285.clone());
        let v287: Rc<UH0> = method23(v200.clone(), v286.clone());
        let v288: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) };
        let v289: Rc<UH1> = method16(v287.clone(), v288.clone());
        let v290: Rc<dyn Fn() -> Rc<UH1>> = closure10(v289.clone());
        let v291: Rc<dyn Fn() -> Rc<UH1>> = method24(v289.clone(), v290.clone());
        let v292: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i64 }));
        let v293: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
        let v294: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: -1i64 }));
        let v295: US4 = US4::US4_None;
        let v296: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: v295.clone() }));
        let v297: bool = v3 == 1u64;
        let v301: i8 = if v297 {
            1i8
        } else {
            let v298: i8 = 0i8;
            let v299: u64 = 1u64;
            method25(v3, v298, v299)
        };
        let v302: i8 = v301.wrapping_sub(1i8);
        let v303: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let v304: i8 = 0i8;
        let v305: u64 = method28(v291.clone(), v292.clone(), v293.clone(), v294.clone(), v296.clone(), v3, v302, v303.clone(), v304);
        let v306: Rc<dyn Fn() -> ()> = method41();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v309, mut v310, mut v311, mut v312, mut v313, mut v314): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let v315: US0 = v313.borrow().l0.clone();
        let v320: i32 = match &v315 {
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
        let v321: bool = v311.borrow().l0.clone();
        let v322: bool = v321 == false;
        let v324: bool = if v322 {
            false
        } else {
            let v323: bool = 20i32 >= v320;
            v323
        };
        let v325: bool = v324 == false;
        let v372: US2 = if v325 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v329, mut v330, mut v331, mut v332, mut v333, mut v334): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let v335: Rc<str> = method3(v329.clone(), v330.clone(), v331.clone(), v332.clone(), v333.clone(), v334.clone());
            let v336: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v339, mut v340, mut v341, mut v342, mut v343, mut v344): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let v345: i64 = v339.borrow().l0.clone();
            let v346: i64 = v345.wrapping_add(1i64);
            v339.borrow_mut().l0 = v346;
            let v347: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v348: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let v349: bool = cfg!(target_arch = "wasm32");
            if v349 {
                let v350: Rc<str> = v342.borrow().l0.clone();
                let v351: bool = &*v350 == "";
                let v359: Rc<str> = if v351 {
                    v347.clone()
                } else {
                    let v352: bool = &*v347 == "";
                    if v352 {
                        let v353: Rc<str> = v342.borrow().l0.clone();
                        v353.clone()
                    } else {
                        let v354: Rc<str> = v342.borrow().l0.clone();
                        let v355: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v357: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v354, v355)), v347));
                        v357.clone()
                    }
                };
                let v361: usize = v359.chars().count();
                let v362: i32 = ((v361) as i32);
                let v363: i32 = v362.wrapping_add(14999i32);
                let v364: i32 = v363.wrapping_div(15000i32);
                let v365: bool = v347 != v347 ;
                let v367: bool = if v365 {
                    let v366: bool = v364 <= 1i32;
                    v366
                } else {
                    false
                };
                if v367 {
                    v342.borrow_mut().l0 = v359.clone();
                    ()
                } else {
                    v342.borrow_mut().l0 = v347.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v359); };
                    ()
                }
            } else {
                println!("{}", v347);
                ()
            };
            let mut v370: Rc<dyn Fn(Rc<str>) -> ()> = v340.borrow().l0.clone();
            v370(v347.clone());
            US2::US2_Some(v339.clone(), v340.clone(), v341.clone(), v342.clone(), v343.clone(), v344.clone())
        };
        v305
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method42(mut v0: Rc<UH0>, mut v1: i8) -> i8 {
    loop {
        match &*v0 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: u8 = *v2;
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: i8 = v1.wrapping_add(1i8);
                (v0, v1) = (v3.clone(), v4);
                continue;
            }
            UH0::UH0_Nil => {
                return v1;
            }
        }
    }
}
fn method43(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let v14: Rc<str> = format_real_11(v11);
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.roll_within_bounds"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_21(v8);
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rolls"); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26)), v9)), v30));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v26)), v10));
    let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method8(v45.clone())
}
fn method44() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure76() -> Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> = Rc::new(move |mut v0: u64, mut v1: Vec<u8>| -> Option<u64> {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v3); };
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v12: US0 = US0::US0_Info;
        v10.borrow_mut().l0 = v12.clone();
        let mut v13: Vec<u8> = method14(v1.clone());
        let v14: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v13));
        let v15: Rc<Vec<u8>> = Rc::new((v14).borrow().clone());
        let v16: usize = (v15).len();
        let v17: i32 = ((v16) as i32);
        let v18: i32 = v17.wrapping_sub(1i32);
        let v19: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let v20: Rc<UH0> = method15(v15.clone(), v18, v19.clone());
        let v21: i8 = 0i8;
        let v22: i8 = method42(v20.clone(), v21);
        let v23: i8 = v22.wrapping_sub(1i8);
        let v24: u64 = 0u64;
        let v25: US5 = method34(v23, v20.clone(), v24);
        let v35: US6 = match &v25 {
            US5::US5_Some(v26, v27) => {
                let v26: u64 = *v26;
                let v27: Rc<UH0> = v27.clone();
                let mut v28: bool = v26 >= 1u64;
                let v30: bool = if v28 {
                    let v29: bool = v26 <= v0;
                    v29
                } else {
                    false
                };
                if v30 {
                    US6::US6_Some(v26)
                } else {
                    US6::US6_None
                }
            }
            _ => {
                US6::US6_None
            }
        };
        let mut v40: Option<u64> = match &v35 {
            US6::US6_None => {
                let v38: Option<u64> = None;
                v38.clone()
            }
            US6::US6_Some(v36) => {
                let v36: u64 = *v36;
                let v37: Option<u64> = Some(v36.clone());
                v37.clone()
            }
        };
        { let _ = spiral_trace_hold(&v3); };
        let (mut v43, mut v44, mut v45, mut v46, mut v47, mut v48): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let v49: US0 = v47.borrow().l0.clone();
        let v54: i32 = match &v49 {
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
        let mut v55: bool = v45.borrow().l0.clone();
        let v56: bool = v55 == false;
        let mut v58: bool = if v56 {
            false
        } else {
            let v57: bool = 20i32 >= v54;
            v57
        };
        let v59: bool = v58 == false;
        let v109: US2 = if v59 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v63, mut v64, mut v65, mut v66, mut v67, mut v68): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let v69: Rc<str> = method3(v63.clone(), v64.clone(), v65.clone(), v66.clone(), v67.clone(), v68.clone());
            let v70: Rc<str> = method4();
            let mut v71: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1)).s() });
            let v72: Rc<str> = Rc::<str>::from(match &v40 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let v73: Rc<str> = method43(v63.clone(), v64.clone(), v65.clone(), v66.clone(), v67.clone(), v68.clone(), v69.clone(), v70.clone(), v0, v71.clone(), v72.clone());
            { let _ = spiral_trace_hold(&v3); };
            let (mut v76, mut v77, mut v78, mut v79, mut v80, mut v81): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let v82: i64 = v76.borrow().l0.clone();
            let mut v83: i64 = v82.wrapping_add(1i64);
            v76.borrow_mut().l0 = v83;
            let v84: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let v85: bool = cfg!(target_arch = "wasm32");
            if v85 {
                let mut v86: Rc<str> = v79.borrow().l0.clone();
                let v87: bool = &*v86 == "";
                let v95: Rc<str> = if v87 {
                    v73.clone()
                } else {
                    let v88: bool = &*v73 == "";
                    if v88 {
                        let mut v89: Rc<str> = v79.borrow().l0.clone();
                        v89.clone()
                    } else {
                        let v90: Rc<str> = v79.borrow().l0.clone();
                        let v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v93: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v90, v91)), v73));
                        v93.clone()
                    }
                };
                let v97: usize = v95.chars().count();
                let v98: i32 = ((v97) as i32);
                let v99: i32 = v98.wrapping_add(14999i32);
                let v100: i32 = v99.wrapping_div(15000i32);
                let v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v102: bool = v73 != v101 ;
                let v104: bool = if v102 {
                    let v103: bool = v100 <= 1i32;
                    v103
                } else {
                    false
                };
                if v104 {
                    v79.borrow_mut().l0 = v95.clone();
                    ()
                } else {
                    v79.borrow_mut().l0 = v101.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v95); };
                    ()
                }
            } else {
                println!("{}", v73);
                ()
            };
            let mut v107: Rc<dyn Fn(Rc<str>) -> ()> = v77.borrow().l0.clone();
            v107(v73.clone());
            US2::US2_Some(v76.clone(), v77.clone(), v78.clone(), v79.clone(), v80.clone(), v81.clone())
        };
        let v110: Rc<dyn Fn() -> ()> = method44();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v113, mut v114, mut v115, mut v116, mut v117, mut v118): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let v119: US0 = v117.borrow().l0.clone();
        let mut v124: i32 = match &v119 {
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
        let mut v125: bool = v115.borrow().l0.clone();
        let v126: bool = v125 == false;
        let mut v128: bool = if v126 {
            false
        } else {
            let mut v127: bool = 20i32 >= v124;
            v127
        };
        let v129: bool = v128 == false;
        let v176: US2 = if v129 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v133, mut v134, mut v135, mut v136, mut v137, mut v138): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let v139: Rc<str> = method3(v133.clone(), v134.clone(), v135.clone(), v136.clone(), v137.clone(), v138.clone());
            let v140: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v143, mut v144, mut v145, mut v146, mut v147, mut v148): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let v149: i64 = v143.borrow().l0.clone();
            let v150: i64 = v149.wrapping_add(1i64);
            v143.borrow_mut().l0 = v150;
            let v151: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v152: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v153: bool = cfg!(target_arch = "wasm32");
            if v153 {
                let v154: Rc<str> = v146.borrow().l0.clone();
                let mut v155: bool = &*v154 == "";
                let v163: Rc<str> = if v155 {
                    v151.clone()
                } else {
                    let mut v156: bool = &*v151 == "";
                    if v156 {
                        let v157: Rc<str> = v146.borrow().l0.clone();
                        v157.clone()
                    } else {
                        let v158: Rc<str> = v146.borrow().l0.clone();
                        let v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v161: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v158, v159)), v151));
                        v161.clone()
                    }
                };
                let v165: usize = v163.chars().count();
                let v166: i32 = ((v165) as i32);
                let v167: i32 = v166.wrapping_add(14999i32);
                let v168: i32 = v167.wrapping_div(15000i32);
                let v169: bool = v151 != v151 ;
                let v171: bool = if v169 {
                    let v170: bool = v168 <= 1i32;
                    v170
                } else {
                    false
                };
                if v171 {
                    v146.borrow_mut().l0 = v163.clone();
                    ()
                } else {
                    v146.borrow_mut().l0 = v151.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v163); };
                    ()
                }
            } else {
                println!("{}", v151);
                ()
            };
            let mut v174: Rc<dyn Fn(Rc<str>) -> ()> = v144.borrow().l0.clone();
            v174(v151.clone());
            US2::US2_Some(v143.clone(), v144.clone(), v145.clone(), v146.clone(), v147.clone(), v148.clone())
        };
        v40.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
pub fn dice_contract_new() -> (u32, SpiralNearVec<u8>) {
    closure0()()
}
pub fn dice_contract_contribute_seed(v0: &mut SpiralNearVec<u8>, v1: Vec<u8>) -> () {
    closure4()(v0, v1)
}
pub fn dice_contract_generate_random_number(v0: &mut SpiralNearVec<u8>, v1: std::string::String, v2: std::string::String, v3: u64) -> u64 {
    closure7()(v0, v1, v2, v3)
}
pub fn dice_contract_roll_within_bounds(v0: u64, v1: Vec<u8>) -> Option<u64> {
    closure76()(v0, v1)
}
