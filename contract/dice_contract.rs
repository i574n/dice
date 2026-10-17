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
    v1.clone()
}
fn method2(mut v0: i32, mut v1: Rc<RefCell<Mut5>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
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
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
    let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
    let mut v13: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new(Vec::new()));
    let mut v14: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v11.clone(), v14.clone()));
    let mut v15: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v9.clone(), v15.clone()));
    let mut v16: US0 = US0::US0_Info;
    v13.borrow_mut().push((v7.clone(), v16.clone()));
    let mut v17: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v5.clone(), v17.clone()));
    let mut v18: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v3.clone(), v18.clone()));
    let mut v19: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v12.clone(), v19.clone()));
    let mut v20: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v10.clone(), v20.clone()));
    let mut v21: US0 = US0::US0_Info;
    v13.borrow_mut().push((v8.clone(), v21.clone()));
    let mut v22: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v6.clone(), v22.clone()));
    let mut v23: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v4.clone(), v23.clone()));
    let mut v24: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v13.borrow().clone());
    let mut v25: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let mut v26: i32 = (v25.clone().borrow().len() as i32);
    let mut v27: US1 = US1::US1_None;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: 0i32, l1: v27.clone() }));
    while method2(v26, v28.clone()) {
        let mut v30: i32 = v28.borrow().l0.clone();
        let mut v31: i32 = v30.wrapping_neg();
        let mut v32: i32 = v31.wrapping_add(v26);
        let mut v33: i32 = v32.wrapping_sub(1i32);
        let mut v34: US1 = v28.borrow().l1.clone();
        let (mut v35, mut v36): (Rc<str>, US0) = v25.clone().borrow()[v33 as usize].clone();
        let mut v43: US1 = match &v34 {
            US1::US1_None => {
                let mut v38: bool = v35 == v2 ;
                if v38 {
                    US1::US1_Some(v36.clone())
                } else {
                    US1::US1_None
                }
            }
            US1::US1_Some(v37) => {
                let mut v37: US0 = v37.clone();
                v34.clone()
            }
        };
        let mut v44: i32 = v30.wrapping_add(1i32);
        v28.borrow_mut().l0 = v44;
        v28.borrow_mut().l1 = v43.clone();
        ()
    };
    let mut v45: US1 = v28.borrow().l1.clone();
    let mut v46: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let mut v47: Rc<dyn Fn(Rc<str>) -> ()> = closure2();
    let mut v48: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v47.clone() }));
    let mut v49: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v50.clone() }));
    let mut v54: US0 = match &v45 {
        US1::US1_None => {
            v0.clone()
        }
        US1::US1_Some(v52) => {
            let mut v52: US0 = v52.clone();
            v52.clone()
        }
    };
    let mut v55: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v54.clone() }));
    let mut v56: Option<i64> = None;
    (v46.clone(), v48.clone(), v49.clone(), v51.clone(), v55.clone(), v56.clone())
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
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
        let mut v12: &[u8] = { let owned: Rc<str> = (v11).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v13: SpiralNearVec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::store::vec::Vector::new(v12); #[cfg(not(target_arch = "wasm32"))] let v = SpiralNearVec(<std::vec::Vec<u8>>::new()); v };
        (2u32, v13)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v6: u64 = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; h * 3600 + m * 60 + s };
    let mut v7: u64 = v6.wrapping_div(3600u64);
    let mut v8: bool = v7 < 10u64;
    let mut v11: Rc<str> = if v8 {
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v9.clone()
    } else {
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v10.clone()
    };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{:?}", v7));
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: u64 = v6.wrapping_div(60u64);
    let mut v17: u64 = v16.wrapping_rem(60u64);
    let mut v18: bool = v17 < 10u64;
    let mut v21: Rc<str> = if v18 {
        let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v19.clone()
    } else {
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v20.clone()
    };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{:?}", v17));
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v23));
    let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v14));
    let mut v26: u64 = v6.wrapping_rem(60u64);
    let mut v27: bool = v26 < 10u64;
    let mut v30: Rc<str> = if v27 {
        let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v28.clone()
    } else {
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v29.clone()
    };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{:?}", v26));
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v32));
    v33.clone()
}
fn method6(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3.clone();
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
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7.clone()
}
fn method9(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v1;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v11: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                if v6 {
                    true
                } else {
                    let mut v7: bool = v4 == b'\r';
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
            let mut v5: bool = v4 == b' ';
            let mut v7: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'/';
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
    let mut v5: Rc<str> = string_slice(&v0.clone(), v3 as i64, v4 as i64);
    let mut v6: i32 = (v5.clone().len() as i32);
    let mut v7: i32 = method10(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5.clone(), 0i32 as i64, v7 as i64);
    v8.clone()
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
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.contribute_seed"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess_len"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess_len"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess_len = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = format_real_12(v8);
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v27));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v25));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v9));
    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v38));
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
        let mut v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v12: US0 = US0::US0_Info;
        v10.borrow_mut().l0 = v12.clone();
        { (v0).extend((v1).clone()); };
        let mut v13: u32 = ((v0).len() as u32);
        let mut v14: i32 = (v13 as i32);
        let mut v15: usize = ((100i32) as usize);
        let mut v16: i32 = (v15 as i32);
        let mut v17: i32 = v14.wrapping_sub(v16);
        let mut v18: bool = v17 > 0i32;
        if v18 {
            let mut v20: Vec<u8> = v0.drain(0..v17 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v23, mut v24, mut v25, mut v26, mut v27, mut v28): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v29: US0 = v27.borrow().l0.clone();
            let mut v34: i32 = match &v29 {
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
            let mut v35: bool = v25.borrow().l0.clone();
            let mut v36: bool = v35 == false;
            let mut v38: bool = if v36 {
                false
            } else {
                let mut v37: bool = 20i32 >= v34;
                v37
            };
            let mut v39: bool = v38 == false;
            let mut v85: US2 = if v39 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v3); };
                let (mut v43, mut v44, mut v45, mut v46, mut v47, mut v48): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v49: Rc<str> = method3(v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone());
                let mut v50: Rc<str> = method4();
                let mut v51: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v20)).s() });
                let mut v52: Rc<str> = method7(v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone(), v50.clone(), v17, v51.clone());
                { let _ = spiral_trace_hold(&v3); };
                let (mut v55, mut v56, mut v57, mut v58, mut v59, mut v60): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v61: i64 = v55.borrow().l0.clone();
                let mut v62: i64 = v61.wrapping_add(1i64);
                v55.borrow_mut().l0 = v62;
                let mut v63: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v64: bool = cfg!(target_arch = "wasm32");
                if v64 {
                    let mut v65: Rc<str> = v58.borrow().l0.clone();
                    let mut v66: bool = v65.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v74: Rc<str> = if v66 {
                        v52.clone()
                    } else {
                        let mut v67: bool = v52.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v67 {
                            let mut v68: Rc<str> = v58.borrow().l0.clone();
                            v68.clone()
                        } else {
                            let mut v69: Rc<str> = v58.borrow().l0.clone();
                            let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v71: Rc<str> = Rc::<str>::from(format!("{}{}", v69, v70));
                            let mut v72: Rc<str> = Rc::<str>::from(format!("{}{}", v71, v52));
                            v72.clone()
                        }
                    };
                    let mut v76: i32 = ((v74.chars().count() + 14999) / 15000) as i32;
                    let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v78: bool = v52 != v77 ;
                    let mut v80: bool = if v78 {
                        let mut v79: bool = v76 <= 1i32;
                        v79
                    } else {
                        false
                    };
                    if v80 {
                        v58.borrow_mut().l0 = v74.clone();
                        ()
                    } else {
                        v58.borrow_mut().l0 = v77.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v74); };
                        ()
                    }
                } else {
                    println!("{}", v52);
                    ()
                };
                let mut v83: Rc<dyn Fn(Rc<str>) -> ()> = v56.borrow().l0.clone();
                v83(v52.clone());
                US2::US2_Some(v55.clone(), v56.clone(), v57.clone(), v58.clone(), v59.clone(), v60.clone())
            };
            ()
        };
        let mut v86: Rc<dyn Fn() -> ()> = method13();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v89, mut v90, mut v91, mut v92, mut v93, mut v94): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v95: US0 = v93.borrow().l0.clone();
        let mut v100: i32 = match &v95 {
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
        let mut v101: bool = v91.borrow().l0.clone();
        let mut v102: bool = v101 == false;
        let mut v104: bool = if v102 {
            false
        } else {
            let mut v103: bool = 20i32 >= v100;
            v103
        };
        let mut v105: bool = v104 == false;
        let mut v149: US2 = if v105 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v109, mut v110, mut v111, mut v112, mut v113, mut v114): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v115: Rc<str> = method3(v109.clone(), v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone());
            let mut v116: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v119, mut v120, mut v121, mut v122, mut v123, mut v124): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v125: i64 = v119.borrow().l0.clone();
            let mut v126: i64 = v125.wrapping_add(1i64);
            v119.borrow_mut().l0 = v126;
            let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v128: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v129: bool = cfg!(target_arch = "wasm32");
            if v129 {
                let mut v130: Rc<str> = v122.borrow().l0.clone();
                let mut v131: bool = v130.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v139: Rc<str> = if v131 {
                    v127.clone()
                } else {
                    let mut v132: bool = v127.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v132 {
                        let mut v133: Rc<str> = v122.borrow().l0.clone();
                        v133.clone()
                    } else {
                        let mut v134: Rc<str> = v122.borrow().l0.clone();
                        let mut v135: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v136: Rc<str> = Rc::<str>::from(format!("{}{}", v134, v135));
                        let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v127));
                        v137.clone()
                    }
                };
                let mut v141: i32 = ((v139.chars().count() + 14999) / 15000) as i32;
                let mut v142: bool = v127 != v127 ;
                let mut v144: bool = if v142 {
                    let mut v143: bool = v141 <= 1i32;
                    v143
                } else {
                    false
                };
                if v144 {
                    v122.borrow_mut().l0 = v139.clone();
                    ()
                } else {
                    v122.borrow_mut().l0 = v127.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v139); };
                    ()
                }
            } else {
                println!("{}", v127);
                ()
            };
            let mut v147: Rc<dyn Fn(Rc<str>) -> ()> = v120.borrow().l0.clone();
            v147(v127.clone());
            US2::US2_Some(v119.clone(), v120.clone(), v121.clone(), v122.clone(), v123.clone(), v124.clone())
        };
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method14(mut v0: Vec<u8>) -> Vec<u8> {
    v0.clone()
}
fn method15(mut v0: Rc<Vec<u8>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: u8 = (v0)[v1 as usize].clone();
            let mut v5: i32 = v1.wrapping_sub(1i32);
            let mut v6: Rc<UH0> = Rc::new(UH0::UH0_Cons(v4, v2.clone()));
            (v0, v1, v2) = (v0.clone(), v5, v6.clone());
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
            let mut v4: Rc<UH1> = method16(v3.clone(), v1.clone());
            let mut v5: Rc<dyn Fn() -> Rc<UH1>> = closure8(v4.clone());
            Rc::new(UH1::UH1_StreamCons(v2, v5.clone()))
        }
        UH0::UH0_Nil => {
            v1.clone()
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
            let mut v5: Rc<UH1> = method17(v4.clone(), v1.clone());
            let mut v6: i64 = (v2 as i64);
            let mut v7: i64 = v6.wrapping_sub(1i64);
            let mut v8: i64 = v7.wrapping_add(6i64);
            let mut v9: i64 = v8.wrapping_rem(6i64);
            let mut v10: i64 = v9.wrapping_add(1i64);
            let mut v11: u8 = (v10 as u8);
            let mut v12: Rc<dyn Fn() -> Rc<UH1>> = closure9(v5.clone());
            Rc::new(UH1::UH1_StreamCons(v11, v12.clone()))
        }
        UH1::UH1_StreamNil => {
            v1.clone()
        }
    }
}
fn method18(mut v0: Rc<UH1>, mut v1: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH1::UH1_StreamCons(v2, v3) => {
            let mut v2: u8 = *v2;
            let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
            let mut v4: Rc<UH1> = v3();
            let mut v5: Rc<UH0> = method18(v4.clone(), v1.clone());
            Rc::new(UH0::UH0_Cons(v2, v5.clone()))
        }
        UH1::UH1_StreamNil => {
            v1.clone()
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
                let mut v5: i32 = v2.wrapping_add(1i32);
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
    let mut v23: i64 = v0.borrow().l0.clone();
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v24));
    let mut v26: Rc<str> = format_real_11(v23);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v7));
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v24));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.generate_random_number"); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = format_real_21(v8);
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("key"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v44));
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v38));
    let mut v47: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v9)).s() });
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v47));
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v42));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("proof"); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v50));
    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v38));
    let mut v53: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v10)).s() });
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v53));
    let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v42));
    let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_timestamp"); } LIT.with(|lit| lit.clone()) };
    let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v56));
    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v38));
    let mut v59: Rc<str> = format_real_21(v11);
    let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
    let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v42));
    let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_height"); } LIT.with(|lit| lit.clone()) };
    let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", v61, v62));
    let mut v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v38));
    let mut v65: Rc<str> = format_real_21(v12);
    let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v64, v65));
    let mut v67: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v42));
    let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epoch_height"); } LIT.with(|lit| lit.clone()) };
    let mut v69: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v68));
    let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", v69, v38));
    let mut v71: Rc<str> = format_real_21(v13);
    let mut v72: Rc<str> = Rc::<str>::from(format!("{}{}", v70, v71));
    let mut v73: Rc<str> = Rc::<str>::from(format!("{}{}", v72, v42));
    let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_balance"); } LIT.with(|lit| lit.clone()) };
    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v73, v74));
    let mut v76: Rc<str> = Rc::<str>::from(format!("{}{}", v75, v38));
    let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", v76, v14));
    let mut v78: Rc<str> = Rc::<str>::from(format!("{}{}", v77, v42));
    let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("signer_account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v80: Rc<str> = Rc::<str>::from(format!("{}{}", v78, v79));
    let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", v80, v38));
    let mut v82: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v15)).s() });
    let mut v83: Rc<str> = Rc::<str>::from(format!("{}{}", v81, v82));
    let mut v84: Rc<str> = Rc::<str>::from(format!("{}{}", v83, v42));
    let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("predecessor_account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v84, v85));
    let mut v87: Rc<str> = Rc::<str>::from(format!("{}{}", v86, v38));
    let mut v88: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v16)).s() });
    let mut v89: Rc<str> = Rc::<str>::from(format!("{}{}", v87, v88));
    let mut v90: Rc<str> = Rc::<str>::from(format!("{}{}", v89, v42));
    let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed"); } LIT.with(|lit| lit.clone()) };
    let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v91));
    let mut v93: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v38));
    let mut v94: Rc<str> = Rc::<str>::from(format!("{}{}", v93, v17));
    let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v42));
    let mut v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
    let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", v95, v96));
    let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v97, v38));
    let mut v99: Rc<str> = Rc::<str>::from(format!("{}{}", v98, v18));
    let mut v100: Rc<str> = Rc::<str>::from(format!("{}{}", v99, v42));
    let mut v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("entropy_len"); } LIT.with(|lit| lit.clone()) };
    let mut v102: Rc<str> = Rc::<str>::from(format!("{}{}", v100, v101));
    let mut v103: Rc<str> = Rc::<str>::from(format!("{}{}", v102, v38));
    let mut v104: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<usize>") } } (&&W(&v19)).s() });
    let mut v105: Rc<str> = Rc::<str>::from(format!("{}{}", v103, v104));
    let mut v106: Rc<str> = Rc::<str>::from(format!("{}{}", v105, v42));
    let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("entropy"); } LIT.with(|lit| lit.clone()) };
    let mut v108: Rc<str> = Rc::<str>::from(format!("{}{}", v106, v107));
    let mut v109: Rc<str> = Rc::<str>::from(format!("{}{}", v108, v38));
    let mut v110: Rc<str> = Rc::<str>::from(format!("{}{}", v109, v20));
    let mut v111: Rc<str> = Rc::<str>::from(format!("{}{}", v110, v42));
    let mut v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash_u8"); } LIT.with(|lit| lit.clone()) };
    let mut v113: Rc<str> = Rc::<str>::from(format!("{}{}", v111, v112));
    let mut v114: Rc<str> = Rc::<str>::from(format!("{}{}", v113, v38));
    let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", v114, v21));
    let mut v116: Rc<str> = Rc::<str>::from(format!("{}{}", v115, v42));
    let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v118: Rc<str> = Rc::<str>::from(format!("{}{}", v116, v117));
    let mut v119: Rc<str> = Rc::<str>::from(format!("{}{}", v118, v38));
    let mut v120: Rc<str> = Rc::<str>::from(format!("{}{}", v119, v22));
    let mut v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v122: Rc<str> = Rc::<str>::from(format!("{}{}", v121, v120));
    let mut v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v124: Rc<str> = Rc::<str>::from(format!("{}{}", v122, v123));
    let mut v125: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v124));
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
            let mut v4: Rc<UH0> = method23(v3.clone(), v1.clone());
            Rc::new(UH0::UH0_Cons(v2, v4.clone()))
        }
        UH0::UH0_Nil => {
            v1.clone()
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
                let mut v5: Rc<UH1> = v4();
                let mut v12: Rc<UH1> = match &*v5 {
                    UH1::UH1_StreamCons(v7, v8) => {
                        let mut v7: u8 = *v7;
                        let mut v8: Rc<dyn Fn() -> Rc<UH1>> = v8.clone();
                        let mut v9: Rc<dyn Fn() -> Rc<UH1>> = method24(v0.clone(), v8.clone());
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
    let mut v2: US3 = US3::US3_NotComputed(v1.clone());
    let mut v3: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: v2.clone() }));
    closure11(v0.clone(), v3.clone())
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
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_21(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("p"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v26));
    let mut v35: Rc<str> = format_real_21(v9);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("n"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v26));
    let mut v41: Rc<str> = format_real_27(v10);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v46));
    method8(v47.clone())
}
fn method25(mut v0: u64, mut v1: i8, mut v2: u64) -> i8 {
    loop {
        let mut v3: bool = v2 < v0;
        if v3 {
            let mut v4: bool = v2 > 3074457345618258602u64;
            if v4 {
                let mut v5: Rc<str> = format_real_21(v0);
                let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count / max: "); } LIT.with(|lit| lit.clone()) };
                let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v5));
                let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" is above the largest supported bound "); } LIT.with(|lit| lit.clone()) };
                let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v7, v8));
                let mut v10: Rc<str> = format_real_21(v2);
                let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v9, v10));
                return std::panic::panic_any::<std::string::String>(format!("{}", v11.clone()));
            } else {
                let mut v13: i8 = v1.wrapping_add(1i8);
                let mut v14: u64 = v2.wrapping_mul(6u64);
                (v0, v1, v2) = (v0, v13, v14);
                continue;
            }
        } else {
            let mut v18: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
            { let _ = spiral_trace_hold(&v18); };
            let mut v20: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v21, mut v22, mut v23, mut v24, mut v25, mut v26): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v20) };
            let mut v27: US0 = v25.borrow().l0.clone();
            let mut v32: i32 = match &v27 {
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
            let mut v33: bool = v23.borrow().l0.clone();
            let mut v34: bool = v33 == false;
            let mut v36: bool = if v34 {
                false
            } else {
                let mut v35: bool = 20i32 >= v32;
                v35
            };
            let mut v37: bool = v36 == false;
            let mut v82: US2 = if v37 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v18); };
                let (mut v41, mut v42, mut v43, mut v44, mut v45, mut v46): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v20) };
                let mut v47: Rc<str> = method3(v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone(), v46.clone());
                let mut v48: Rc<str> = method4();
                let mut v49: Rc<str> = method26(v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v0, v2, v1);
                { let _ = spiral_trace_hold(&v18); };
                let (mut v52, mut v53, mut v54, mut v55, mut v56, mut v57): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v20) };
                let mut v58: i64 = v52.borrow().l0.clone();
                let mut v59: i64 = v58.wrapping_add(1i64);
                v52.borrow_mut().l0 = v59;
                let mut v60: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v61: bool = cfg!(target_arch = "wasm32");
                if v61 {
                    let mut v62: Rc<str> = v55.borrow().l0.clone();
                    let mut v63: bool = v62.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v71: Rc<str> = if v63 {
                        v49.clone()
                    } else {
                        let mut v64: bool = v49.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v64 {
                            let mut v65: Rc<str> = v55.borrow().l0.clone();
                            v65.clone()
                        } else {
                            let mut v66: Rc<str> = v55.borrow().l0.clone();
                            let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v67));
                            let mut v69: Rc<str> = Rc::<str>::from(format!("{}{}", v68, v49));
                            v69.clone()
                        }
                    };
                    let mut v73: i32 = ((v71.chars().count() + 14999) / 15000) as i32;
                    let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v75: bool = v49 != v74 ;
                    let mut v77: bool = if v75 {
                        let mut v76: bool = v73 <= 1i32;
                        v76
                    } else {
                        false
                    };
                    if v77 {
                        v55.borrow_mut().l0 = v71.clone();
                        ()
                    } else {
                        v55.borrow_mut().l0 = v74.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v71); };
                        ()
                    }
                } else {
                    println!("{}", v49);
                    ()
                };
                let mut v80: Rc<dyn Fn(Rc<str>) -> ()> = v53.borrow().l0.clone();
                v80(v49.clone());
                US2::US2_Some(v52.clone(), v53.clone(), v54.clone(), v55.clone(), v56.clone(), v57.clone())
            };
            return v1;
        }
    }
}
fn method30(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: i64, mut v10: i64, mut v11: Rc<str>) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0.clone();
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let mut v15: Rc<str> = format_real_11(v12);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v7));
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v13));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll"); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("current_index"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("current_index"); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("current_index = "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = format_real_11(v8);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v27));
    let mut v36: Rc<str> = format_real_11(v9);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("len"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v27));
    let mut v42: Rc<str> = format_real_11(v10);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("last_item"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v27));
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v11));
    let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v48));
    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v51));
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v52));
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
                    let mut v6: i64 = v0.wrapping_sub(1i64);
                    let mut v7: Rc<UH1> = v3();
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
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v9));
    let mut v11: Rc<str> = format_real_11(v8);
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v10, v11));
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v7));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v9));
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll / None"); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = format_real_33();
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    method8(v20.clone())
}
fn method29(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>) -> u8 {
    loop {
        let mut v5: i64 = v1.borrow().l0.clone();
        let mut v6: i64 = v2.borrow().l0.clone();
        let mut v7: i64 = v3.borrow().l0.clone();
        let mut v8: US4 = v4.borrow().l0.clone();
        let mut v13: Option<u8> = match &v8 {
            US4::US4_None => {
                let mut v11: Option<u8> = None;
                v11.clone()
            }
            US4::US4_Some(v9) => {
                let mut v9: u8 = *v9;
                let mut v10: Option<u8> = Some(v9.clone());
                v10.clone()
            }
        };
        let mut v15: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v15); };
        let mut v17: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v18, mut v19, mut v20, mut v21, mut v22, mut v23): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
        let mut v24: US0 = v22.borrow().l0.clone();
        let mut v29: i32 = match &v24 {
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
        let mut v30: bool = v20.borrow().l0.clone();
        let mut v31: bool = v30 == false;
        let mut v33: bool = if v31 {
            false
        } else {
            let mut v32: bool = 20i32 >= v29;
            v32
        };
        let mut v34: bool = v33 == false;
        let mut v80: US2 = if v34 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v15); };
            let (mut v38, mut v39, mut v40, mut v41, mut v42, mut v43): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
            let mut v44: Rc<str> = method3(v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone());
            let mut v45: Rc<str> = method4();
            let mut v46: Rc<str> = Rc::<str>::from(match &v13 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v47: Rc<str> = method30(v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone(), v5, v6, v7, v46.clone());
            { let _ = spiral_trace_hold(&v15); };
            let (mut v50, mut v51, mut v52, mut v53, mut v54, mut v55): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
            let mut v56: i64 = v50.borrow().l0.clone();
            let mut v57: i64 = v56.wrapping_add(1i64);
            v50.borrow_mut().l0 = v57;
            let mut v58: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v59: bool = cfg!(target_arch = "wasm32");
            if v59 {
                let mut v60: Rc<str> = v53.borrow().l0.clone();
                let mut v61: bool = v60.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v69: Rc<str> = if v61 {
                    v47.clone()
                } else {
                    let mut v62: bool = v47.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v62 {
                        let mut v63: Rc<str> = v53.borrow().l0.clone();
                        v63.clone()
                    } else {
                        let mut v64: Rc<str> = v53.borrow().l0.clone();
                        let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v64, v65));
                        let mut v67: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v47));
                        v67.clone()
                    }
                };
                let mut v71: i32 = ((v69.chars().count() + 14999) / 15000) as i32;
                let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v73: bool = v47 != v72 ;
                let mut v75: bool = if v73 {
                    let mut v74: bool = v71 <= 1i32;
                    v74
                } else {
                    false
                };
                if v75 {
                    v53.borrow_mut().l0 = v69.clone();
                    ()
                } else {
                    v53.borrow_mut().l0 = v72.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v69); };
                    ()
                }
            } else {
                println!("{}", v47);
                ()
            };
            let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v51.borrow().l0.clone();
            v78(v47.clone());
            US2::US2_Some(v50.clone(), v51.clone(), v52.clone(), v53.clone(), v54.clone(), v55.clone())
        };
        let mut v81: Rc<UH1> = v0();
        let mut v82: i64 = v1.borrow().l0.clone();
        let mut v83: US4 = method31(v82, v81.clone());
        match &v83 {
            US4::US4_None => {
                { let _ = spiral_trace_hold(&v15); };
                let (mut v90, mut v91, mut v92, mut v93, mut v94, mut v95): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
                let mut v96: US0 = v94.borrow().l0.clone();
                let mut v101: i32 = match &v96 {
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
                let mut v102: bool = v92.borrow().l0.clone();
                let mut v103: bool = v102 == false;
                let mut v105: bool = if v103 {
                    false
                } else {
                    let mut v104: bool = 20i32 >= v101;
                    v104
                };
                let mut v106: bool = v105 == false;
                let mut v151: US2 = if v106 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v15); };
                    let (mut v110, mut v111, mut v112, mut v113, mut v114, mut v115): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
                    let mut v116: Rc<str> = method3(v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone());
                    let mut v117: Rc<str> = method4();
                    let mut v118: Rc<str> = method32(v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone());
                    { let _ = spiral_trace_hold(&v15); };
                    let (mut v121, mut v122, mut v123, mut v124, mut v125, mut v126): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v17) };
                    let mut v127: i64 = v121.borrow().l0.clone();
                    let mut v128: i64 = v127.wrapping_add(1i64);
                    v121.borrow_mut().l0 = v128;
                    let mut v129: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                    let mut v130: bool = cfg!(target_arch = "wasm32");
                    if v130 {
                        let mut v131: Rc<str> = v124.borrow().l0.clone();
                        let mut v132: bool = v131.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v140: Rc<str> = if v132 {
                            v118.clone()
                        } else {
                            let mut v133: bool = v118.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v133 {
                                let mut v134: Rc<str> = v124.borrow().l0.clone();
                                v134.clone()
                            } else {
                                let mut v135: Rc<str> = v124.borrow().l0.clone();
                                let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v136));
                                let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v118));
                                v138.clone()
                            }
                        };
                        let mut v142: i32 = ((v140.chars().count() + 14999) / 15000) as i32;
                        let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v144: bool = v118 != v143 ;
                        let mut v146: bool = if v144 {
                            let mut v145: bool = v142 <= 1i32;
                            v145
                        } else {
                            false
                        };
                        if v146 {
                            v124.borrow_mut().l0 = v140.clone();
                            ()
                        } else {
                            v124.borrow_mut().l0 = v143.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v118);
                        ()
                    };
                    let mut v149: Rc<dyn Fn(Rc<str>) -> ()> = v122.borrow().l0.clone();
                    v149(v118.clone());
                    US2::US2_Some(v121.clone(), v122.clone(), v123.clone(), v124.clone(), v125.clone(), v126.clone())
                };
                let mut v152: i64 = v3.borrow().l0.clone();
                let mut v153: bool = v152 == -1i64;
                if v153 {
                    let mut v154: i64 = v1.borrow().l0.clone();
                    v3.borrow_mut().l0 = v154;
                    ()
                };
                let mut v155: i64 = v2.borrow().l0.clone();
                let mut v156: i64 = v3.borrow().l0.clone();
                let mut v157: bool = v155 >= v156;
                let mut v160: i64 = if v157 {
                    1i64
                } else {
                    let mut v158: i64 = v2.borrow().l0.clone();
                    let mut v159: i64 = v158.wrapping_add(1i64);
                    v159
                };
                v2.borrow_mut().l0 = v160;
                let mut v161: i64 = v2.borrow().l0.clone();
                let mut v162: i64 = v161.wrapping_sub(1i64);
                v1.borrow_mut().l0 = v162;
                let mut v163: US4 = US4::US4_None;
                v4.borrow_mut().l0 = v163.clone();
                (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
                continue;
            }
            US4::US4_Some(v84) => {
                let mut v84: u8 = *v84;
                let mut v85: i64 = v1.borrow().l0.clone();
                let mut v86: i64 = v85.wrapping_add(1i64);
                v1.borrow_mut().l0 = v86;
                let mut v87: US4 = US4::US4_Some(v84);
                v4.borrow_mut().l0 = v87.clone();
                return v84;
            }
        }
    }
}
fn method35(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u64) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_27(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v26));
    let mut v35: Rc<str> = format_real_21(v9);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v26));
    let mut v41: Rc<str> = format_real_21(v10);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v46));
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
                    let mut v6: i8 = v0.wrapping_sub(1i8);
                    let mut v7: Rc<UH2> = v3();
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
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let mut v15: Rc<str> = format_real_11(v12);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v7));
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v13));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = format_real_27(v8);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v27));
    let mut v36: Rc<str> = format_real_21(v9);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v27));
    let mut v42: Rc<str> = format_real_38(v10);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v27));
    let mut v48: Rc<str> = format_real_21(v11);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v53));
    method8(v54.clone())
}
fn method39(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u8) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_27(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v26));
    let mut v35: Rc<str> = format_real_21(v9);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v26));
    let mut v41: Rc<str> = format_real_38(v10);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v46));
    method8(v47.clone())
}
fn method34(mut v0: i8, mut v1: Rc<UH0>, mut v2: u64) -> US5 {
    loop {
        let mut v3: bool = v0 < 0i8;
        if v3 {
            let mut v4: u64 = v2.wrapping_add(1u64);
            let mut v6: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
            { let _ = spiral_trace_hold(&v6); };
            let mut v8: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v9, mut v10, mut v11, mut v12, mut v13, mut v14): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
            let mut v15: US0 = v13.borrow().l0.clone();
            let mut v20: i32 = match &v15 {
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
            let mut v21: bool = v11.borrow().l0.clone();
            let mut v22: bool = v21 == false;
            let mut v24: bool = if v22 {
                false
            } else {
                let mut v23: bool = 20i32 >= v20;
                v23
            };
            let mut v25: bool = v24 == false;
            let mut v70: US2 = if v25 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v6); };
                let (mut v29, mut v30, mut v31, mut v32, mut v33, mut v34): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                let mut v35: Rc<str> = method3(v29.clone(), v30.clone(), v31.clone(), v32.clone(), v33.clone(), v34.clone());
                let mut v36: Rc<str> = method4();
                let mut v37: Rc<str> = method35(v29.clone(), v30.clone(), v31.clone(), v32.clone(), v33.clone(), v34.clone(), v35.clone(), v36.clone(), v0, v2, v4);
                { let _ = spiral_trace_hold(&v6); };
                let (mut v40, mut v41, mut v42, mut v43, mut v44, mut v45): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                let mut v46: i64 = v40.borrow().l0.clone();
                let mut v47: i64 = v46.wrapping_add(1i64);
                v40.borrow_mut().l0 = v47;
                let mut v48: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v49: bool = cfg!(target_arch = "wasm32");
                if v49 {
                    let mut v50: Rc<str> = v43.borrow().l0.clone();
                    let mut v51: bool = v50.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v59: Rc<str> = if v51 {
                        v37.clone()
                    } else {
                        let mut v52: bool = v37.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v52 {
                            let mut v53: Rc<str> = v43.borrow().l0.clone();
                            v53.clone()
                        } else {
                            let mut v54: Rc<str> = v43.borrow().l0.clone();
                            let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v56: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v55));
                            let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v56, v37));
                            v57.clone()
                        }
                    };
                    let mut v61: i32 = ((v59.chars().count() + 14999) / 15000) as i32;
                    let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v63: bool = v37 != v62 ;
                    let mut v65: bool = if v63 {
                        let mut v64: bool = v61 <= 1i32;
                        v64
                    } else {
                        false
                    };
                    if v65 {
                        v43.borrow_mut().l0 = v59.clone();
                        ()
                    } else {
                        v43.borrow_mut().l0 = v62.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v59); };
                        ()
                    }
                } else {
                    println!("{}", v37);
                    ()
                };
                let mut v68: Rc<dyn Fn(Rc<str>) -> ()> = v41.borrow().l0.clone();
                v68(v37.clone());
                US2::US2_Some(v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone())
            };
            return US5::US5_Some(v4, v1.clone());
        } else {
            match &*v1 {
                UH0::UH0_Cons(v73, v74) => {
                    let mut v73: u8 = *v73;
                    let mut v74: Rc<UH0> = v74.clone();
                    let mut v75: bool = v73 > 1u8;
                    if v75 {
                        let mut v76: u64 = 1u64;
                        let mut v77: Rc<dyn Fn() -> Rc<UH2>> = closure12();
                        let mut v78: Rc<UH2> = Rc::new(UH2::UH2_StreamCons(v76, v77.clone()));
                        let mut v79: US6 = method36(v0, v78.clone());
                        let mut v83: u64 = match &v79 {
                            US6::US6_None => {
                                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
                            }
                            US6::US6_Some(v80) => {
                                let mut v80: u64 = *v80;
                                v80
                            }
                        };
                        let mut v84: u8 = v73.wrapping_sub(1u8);
                        let mut v85: u64 = (v84 as u64);
                        let mut v86: u64 = v85.wrapping_mul(v83);
                        let mut v88: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                        { let _ = spiral_trace_hold(&v88); };
                        let mut v90: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v91, mut v92, mut v93, mut v94, mut v95, mut v96): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v90) };
                        let mut v97: US0 = v95.borrow().l0.clone();
                        let mut v102: i32 = match &v97 {
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
                        let mut v103: bool = v93.borrow().l0.clone();
                        let mut v104: bool = v103 == false;
                        let mut v106: bool = if v104 {
                            false
                        } else {
                            let mut v105: bool = 20i32 >= v102;
                            v105
                        };
                        let mut v107: bool = v106 == false;
                        let mut v152: US2 = if v107 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v88); };
                            let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v90) };
                            let mut v117: Rc<str> = method3(v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone());
                            let mut v118: Rc<str> = method4();
                            let mut v119: Rc<str> = method37(v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v0, v2, v73, v86);
                            { let _ = spiral_trace_hold(&v88); };
                            let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v90) };
                            let mut v128: i64 = v122.borrow().l0.clone();
                            let mut v129: i64 = v128.wrapping_add(1i64);
                            v122.borrow_mut().l0 = v129;
                            let mut v130: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let mut v131: bool = cfg!(target_arch = "wasm32");
                            if v131 {
                                let mut v132: Rc<str> = v125.borrow().l0.clone();
                                let mut v133: bool = v132.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v141: Rc<str> = if v133 {
                                    v119.clone()
                                } else {
                                    let mut v134: bool = v119.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v134 {
                                        let mut v135: Rc<str> = v125.borrow().l0.clone();
                                        v135.clone()
                                    } else {
                                        let mut v136: Rc<str> = v125.borrow().l0.clone();
                                        let mut v137: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v137));
                                        let mut v139: Rc<str> = Rc::<str>::from(format!("{}{}", v138, v119));
                                        v139.clone()
                                    }
                                };
                                let mut v143: i32 = ((v141.chars().count() + 14999) / 15000) as i32;
                                let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v145: bool = v119 != v144 ;
                                let mut v147: bool = if v145 {
                                    let mut v146: bool = v143 <= 1i32;
                                    v146
                                } else {
                                    false
                                };
                                if v147 {
                                    v125.borrow_mut().l0 = v141.clone();
                                    ()
                                } else {
                                    v125.borrow_mut().l0 = v144.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v141); };
                                    ()
                                }
                            } else {
                                println!("{}", v119);
                                ()
                            };
                            let mut v150: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                            v150(v119.clone());
                            US2::US2_Some(v122.clone(), v123.clone(), v124.clone(), v125.clone(), v126.clone(), v127.clone())
                        };
                        let mut v153: u64 = v2.wrapping_add(v86);
                        let mut v154: i8 = v0.wrapping_sub(1i8);
                        (v0, v1, v2) = (v154, v74.clone(), v153);
                        continue;
                    } else {
                        let mut v157: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
                        { let _ = spiral_trace_hold(&v157); };
                        let mut v159: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v160, mut v161, mut v162, mut v163, mut v164, mut v165): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v159) };
                        let mut v166: US0 = v164.borrow().l0.clone();
                        let mut v171: i32 = match &v166 {
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
                        let mut v172: bool = v162.borrow().l0.clone();
                        let mut v173: bool = v172 == false;
                        let mut v175: bool = if v173 {
                            false
                        } else {
                            let mut v174: bool = 20i32 >= v171;
                            v174
                        };
                        let mut v176: bool = v175 == false;
                        let mut v221: US2 = if v176 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v157); };
                            let (mut v180, mut v181, mut v182, mut v183, mut v184, mut v185): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v159) };
                            let mut v186: Rc<str> = method3(v180.clone(), v181.clone(), v182.clone(), v183.clone(), v184.clone(), v185.clone());
                            let mut v187: Rc<str> = method4();
                            let mut v188: Rc<str> = method39(v180.clone(), v181.clone(), v182.clone(), v183.clone(), v184.clone(), v185.clone(), v186.clone(), v187.clone(), v0, v2, v73);
                            { let _ = spiral_trace_hold(&v157); };
                            let (mut v191, mut v192, mut v193, mut v194, mut v195, mut v196): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v159) };
                            let mut v197: i64 = v191.borrow().l0.clone();
                            let mut v198: i64 = v197.wrapping_add(1i64);
                            v191.borrow_mut().l0 = v198;
                            let mut v199: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let mut v200: bool = cfg!(target_arch = "wasm32");
                            if v200 {
                                let mut v201: Rc<str> = v194.borrow().l0.clone();
                                let mut v202: bool = v201.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v210: Rc<str> = if v202 {
                                    v188.clone()
                                } else {
                                    let mut v203: bool = v188.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v203 {
                                        let mut v204: Rc<str> = v194.borrow().l0.clone();
                                        v204.clone()
                                    } else {
                                        let mut v205: Rc<str> = v194.borrow().l0.clone();
                                        let mut v206: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v207: Rc<str> = Rc::<str>::from(format!("{}{}", v205, v206));
                                        let mut v208: Rc<str> = Rc::<str>::from(format!("{}{}", v207, v188));
                                        v208.clone()
                                    }
                                };
                                let mut v212: i32 = ((v210.chars().count() + 14999) / 15000) as i32;
                                let mut v213: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v214: bool = v188 != v213 ;
                                let mut v216: bool = if v214 {
                                    let mut v215: bool = v212 <= 1i32;
                                    v215
                                } else {
                                    false
                                };
                                if v216 {
                                    v194.borrow_mut().l0 = v210.clone();
                                    ()
                                } else {
                                    v194.borrow_mut().l0 = v213.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v210); };
                                    ()
                                }
                            } else {
                                println!("{}", v188);
                                ()
                            };
                            let mut v219: Rc<dyn Fn(Rc<str>) -> ()> = v192.borrow().l0.clone();
                            v219(v188.clone());
                            US2::US2_Some(v191.clone(), v192.clone(), v193.clone(), v194.clone(), v195.clone(), v196.clone())
                        };
                        let mut v222: i8 = v0.wrapping_sub(1i8);
                        (v0, v1, v2) = (v222, v74.clone(), v2);
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
    let mut v7: bool = v6 < v0;
    if v7 {
        let mut v8: u8 = method29(v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone());
        let mut v9: i8 = v6.wrapping_add(1i8);
        let mut v10: Rc<UH0> = method40(v0, v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v9);
        Rc::new(UH0::UH0_Cons(v8, v10.clone()))
    } else {
        { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) }
    }
}
fn method41(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>, mut v5: u64, mut v6: i8, mut v7: Rc<UH0>) -> u64 {
    loop {
        let mut v8: i8 = v6.wrapping_add(1i8);
        let mut v9: bool = v6 < v8;
        if v9 {
            let mut v10: u8 = method29(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
            let mut v11: Rc<UH0> = Rc::new(UH0::UH0_Cons(v10, v7.clone()));
            return method28(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v11.clone(), v8);
        } else {
            let mut v13: u64 = 0u64;
            let mut v14: US5 = method34(v6, v7.clone(), v13);
            match &v14 {
                US5::US5_Some(v15, v16) => {
                    let mut v15: u64 = *v15;
                    let mut v16: Rc<UH0> = v16.clone();
                    let mut v17: bool = v15 <= v5;
                    if v17 {
                        return v15;
                    } else {
                        let mut v18: i8 = 0i8;
                        let mut v19: Rc<UH0> = method40(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v18);
                        (v0, v1, v2, v3, v4, v5, v6, v7) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v19.clone());
                        continue;
                    }
                }
                _ => {
                    let mut v22: i8 = 0i8;
                    let mut v23: Rc<UH0> = method40(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v22);
                    (v0, v1, v2, v3, v4, v5, v6, v7) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v23.clone());
                    continue;
                }
            }
        }
    }
}
fn method28(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>, mut v5: u64, mut v6: i8, mut v7: Rc<UH0>, mut v8: i8) -> u64 {
    loop {
        let mut v9: i8 = v6.wrapping_add(1i8);
        let mut v10: bool = v8 < v9;
        if v10 {
            let mut v11: u8 = method29(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
            let mut v12: Rc<UH0> = Rc::new(UH0::UH0_Cons(v11, v7.clone()));
            let mut v13: i8 = v8.wrapping_add(1i8);
            (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v12.clone(), v13);
            continue;
        } else {
            let mut v15: u64 = 0u64;
            let mut v16: US5 = method34(v6, v7.clone(), v15);
            match &v16 {
                US5::US5_Some(v17, v18) => {
                    let mut v17: u64 = *v17;
                    let mut v18: Rc<UH0> = v18.clone();
                    let mut v19: bool = v17 <= v5;
                    if v19 {
                        return v17;
                    } else {
                        let mut v20: i8 = 0i8;
                        let mut v21: Rc<UH0> = method40(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v20);
                        return method41(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v21.clone());
                    }
                }
                _ => {
                    let mut v24: i8 = 0i8;
                    let mut v25: Rc<UH0> = method40(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v24);
                    return method41(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v25.clone());
                }
            }
        }
    }
}
fn method42() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure7() -> Rc<dyn Fn(&mut SpiralNearVec<u8>, std::string::String, std::string::String, u64) -> u64> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut SpiralNearVec<u8>, std::string::String, std::string::String, u64) -> u64> = Rc::new(move |mut v0: &mut SpiralNearVec<u8>, mut v1: std::string::String, mut v2: std::string::String, mut v3: u64| -> u64 {
        let mut v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v5); };
        let mut v7: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v8, mut v9, mut v10, mut v11, mut v12, mut v13): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v14: US0 = US0::US0_Info;
        v12.borrow_mut().l0 = v14.clone();
        let mut v15: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::random_seed(); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        let mut v16: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::epoch_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v17: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v18: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_timestamp(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v19: u128 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::account_balance().as_yoctonear(); #[cfg(not(target_arch = "wasm32"))] let v = 1u128; v };
        let mut v20: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::signer_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v21: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::predecessor_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v23: &SpiralNearVec<u8> = &*v0;
        let mut v24: Vec<u8> = (v23).iter().cloned().collect::<std::vec::Vec<_>>();
        let mut v25: _ = (v16).to_le_bytes().to_vec();
        let mut v26: Vec<u8> = (v25).clone();
        let mut v27: _ = (v17).to_le_bytes().to_vec();
        let mut v28: Vec<u8> = (v27).clone();
        let mut v29: _ = (v18).to_le_bytes().to_vec();
        let mut v30: Vec<u8> = (v29).clone();
        let mut v31: u128 = (v19.clone());
        let mut v32: _ = (v31).to_le_bytes().to_vec();
        let mut v33: Vec<u8> = (v32).clone();
        let mut v34: &[u8] = (v20).as_bytes();
        let mut v35: Vec<u8> = (v34).to_vec();
        let mut v36: &[u8] = (v21).as_bytes();
        let mut v37: Vec<u8> = (v36).to_vec();
        let mut v38: Vec<u8> = (v2).as_bytes().to_vec();
        let mut v39: Vec<u8> = (v1).as_bytes().to_vec();
        let mut v40: Rc<RefCell<Vec<Vec<u8>>>> = Rc::new(RefCell::new(vec![v15.clone(), v24.clone(), v26.clone(), v28.clone(), v30.clone(), v33.clone(), v35.clone(), v37.clone(), v38.clone(), v39.clone()]));
        let mut v41: Vec<Vec<u8>> = (v40).borrow().clone();
        let mut v42: Vec<u8> = (v41).concat();
        let mut v43: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::keccak512(&(v42.clone())); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        { (v0).extend((v43).clone()); };
        let mut v44: u32 = ((v0).len() as u32);
        let mut v45: i32 = (v44 as i32);
        let mut v46: usize = ((100i32) as usize);
        let mut v47: i32 = (v46 as i32);
        let mut v48: i32 = v45.wrapping_sub(v47);
        let mut v49: bool = v48 > 0i32;
        if v49 {
            let mut v51: Vec<u8> = v0.drain(0..v48 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v54, mut v55, mut v56, mut v57, mut v58, mut v59): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v60: US0 = v58.borrow().l0.clone();
            let mut v65: i32 = match &v60 {
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
            let mut v66: bool = v56.borrow().l0.clone();
            let mut v67: bool = v66 == false;
            let mut v69: bool = if v67 {
                false
            } else {
                let mut v68: bool = 20i32 >= v65;
                v68
            };
            let mut v70: bool = v69 == false;
            let mut v116: US2 = if v70 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v5); };
                let (mut v74, mut v75, mut v76, mut v77, mut v78, mut v79): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v80: Rc<str> = method3(v74.clone(), v75.clone(), v76.clone(), v77.clone(), v78.clone(), v79.clone());
                let mut v81: Rc<str> = method4();
                let mut v82: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v51)).s() });
                let mut v83: Rc<str> = method7(v74.clone(), v75.clone(), v76.clone(), v77.clone(), v78.clone(), v79.clone(), v80.clone(), v81.clone(), v48, v82.clone());
                { let _ = spiral_trace_hold(&v5); };
                let (mut v86, mut v87, mut v88, mut v89, mut v90, mut v91): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v92: i64 = v86.borrow().l0.clone();
                let mut v93: i64 = v92.wrapping_add(1i64);
                v86.borrow_mut().l0 = v93;
                let mut v94: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v95: bool = cfg!(target_arch = "wasm32");
                if v95 {
                    let mut v96: Rc<str> = v89.borrow().l0.clone();
                    let mut v97: bool = v96.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v105: Rc<str> = if v97 {
                        v83.clone()
                    } else {
                        let mut v98: bool = v83.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v98 {
                            let mut v99: Rc<str> = v89.borrow().l0.clone();
                            v99.clone()
                        } else {
                            let mut v100: Rc<str> = v89.borrow().l0.clone();
                            let mut v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v102: Rc<str> = Rc::<str>::from(format!("{}{}", v100, v101));
                            let mut v103: Rc<str> = Rc::<str>::from(format!("{}{}", v102, v83));
                            v103.clone()
                        }
                    };
                    let mut v107: i32 = ((v105.chars().count() + 14999) / 15000) as i32;
                    let mut v108: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v109: bool = v83 != v108 ;
                    let mut v111: bool = if v109 {
                        let mut v110: bool = v107 <= 1i32;
                        v110
                    } else {
                        false
                    };
                    if v111 {
                        v89.borrow_mut().l0 = v105.clone();
                        ()
                    } else {
                        v89.borrow_mut().l0 = v108.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v105); };
                        ()
                    }
                } else {
                    println!("{}", v83);
                    ()
                };
                let mut v114: Rc<dyn Fn(Rc<str>) -> ()> = v87.borrow().l0.clone();
                v114(v83.clone());
                US2::US2_Some(v86.clone(), v87.clone(), v88.clone(), v89.clone(), v90.clone(), v91.clone())
            };
            ()
        };
        let mut v117: Rc<dyn Fn() -> ()> = method13();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v120, mut v121, mut v122, mut v123, mut v124, mut v125): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v126: US0 = v124.borrow().l0.clone();
        let mut v131: i32 = match &v126 {
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
        let mut v132: bool = v122.borrow().l0.clone();
        let mut v133: bool = v132 == false;
        let mut v135: bool = if v133 {
            false
        } else {
            let mut v134: bool = 20i32 >= v131;
            v134
        };
        let mut v136: bool = v135 == false;
        let mut v180: US2 = if v136 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v140, mut v141, mut v142, mut v143, mut v144, mut v145): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v146: Rc<str> = method3(v140.clone(), v141.clone(), v142.clone(), v143.clone(), v144.clone(), v145.clone());
            let mut v147: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v150, mut v151, mut v152, mut v153, mut v154, mut v155): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v156: i64 = v150.borrow().l0.clone();
            let mut v157: i64 = v156.wrapping_add(1i64);
            v150.borrow_mut().l0 = v157;
            let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v159: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v160: bool = cfg!(target_arch = "wasm32");
            if v160 {
                let mut v161: Rc<str> = v153.borrow().l0.clone();
                let mut v162: bool = v161.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v170: Rc<str> = if v162 {
                    v158.clone()
                } else {
                    let mut v163: bool = v158.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v163 {
                        let mut v164: Rc<str> = v153.borrow().l0.clone();
                        v164.clone()
                    } else {
                        let mut v165: Rc<str> = v153.borrow().l0.clone();
                        let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v167: Rc<str> = Rc::<str>::from(format!("{}{}", v165, v166));
                        let mut v168: Rc<str> = Rc::<str>::from(format!("{}{}", v167, v158));
                        v168.clone()
                    }
                };
                let mut v172: i32 = ((v170.chars().count() + 14999) / 15000) as i32;
                let mut v173: bool = v158 != v158 ;
                let mut v175: bool = if v173 {
                    let mut v174: bool = v172 <= 1i32;
                    v174
                } else {
                    false
                };
                if v175 {
                    v153.borrow_mut().l0 = v170.clone();
                    ()
                } else {
                    v153.borrow_mut().l0 = v158.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v170); };
                    ()
                }
            } else {
                println!("{}", v158);
                ()
            };
            let mut v178: Rc<dyn Fn(Rc<str>) -> ()> = v151.borrow().l0.clone();
            v178(v158.clone());
            US2::US2_Some(v150.clone(), v151.clone(), v152.clone(), v153.clone(), v154.clone(), v155.clone())
        };
        let mut v181: Vec<u8> = method14(v43.clone());
        let mut v182: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v181));
        let mut v183: Rc<Vec<u8>> = Rc::new((v182).borrow().clone());
        let mut v184: i32 = (v183).len() as i32;
        let mut v185: i32 = v184.wrapping_sub(1i32);
        let mut v186: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let mut v187: Rc<UH0> = method15(v183.clone(), v185, v186.clone());
        let mut v188: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) };
        let mut v189: Rc<UH1> = method16(v187.clone(), v188.clone());
        let mut v190: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) };
        let mut v191: Rc<UH1> = method17(v189.clone(), v190.clone());
        let mut v192: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let mut v193: Rc<UH0> = method18(v191.clone(), v192.clone());
        { let _ = spiral_trace_hold(&v5); };
        let (mut v196, mut v197, mut v198, mut v199, mut v200, mut v201): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v202: US0 = v200.borrow().l0.clone();
        let mut v207: i32 = match &v202 {
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
        let mut v208: bool = v198.borrow().l0.clone();
        let mut v209: bool = v208 == false;
        let mut v211: bool = if v209 {
            false
        } else {
            let mut v210: bool = 20i32 >= v207;
            v210
        };
        let mut v212: bool = v211 == false;
        let mut v274: US2 = if v212 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v216, mut v217, mut v218, mut v219, mut v220, mut v221): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v222: Rc<str> = method3(v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone(), v221.clone());
            let mut v223: Rc<str> = method4();
            let mut v224: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<u128>") } } (&&W(&v19)).s() });
            let mut v226: std::string::String = v20.to_string();
            let mut v228: std::string::String = v21.to_string();
            let mut v229: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v15)).s() });
            let mut v230: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<&mut SpiralNearVec<u8>>") } } (&&W(&v0)).s() });
            let mut v231: usize = ((v42).len() as usize);
            let mut v232: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v42)).s() });
            let mut v233: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v43)).s() });
            let mut v234: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
            let mut v235: i32 = 0i32;
            let mut v236: i32 = method19(v234.clone(), v193.clone(), v235);
            let mut v237: Rc<Vec<u8>> = Rc::new(v234.borrow().clone());
            let mut v238: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v237).as_ref().clone()));
            let mut v239: Vec<u8> = (v238).borrow().clone();
            let mut v240: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v239)).s() });
            let mut v241: Rc<str> = method20(v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone(), v221.clone(), v222.clone(), v223.clone(), v3, v1.clone(), v2.clone(), v18, v17, v16, v224.clone(), v226.clone(), v228.clone(), v229.clone(), v230.clone(), v231.clone(), v232.clone(), v233.clone(), v240.clone());
            { let _ = spiral_trace_hold(&v5); };
            let (mut v244, mut v245, mut v246, mut v247, mut v248, mut v249): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v250: i64 = v244.borrow().l0.clone();
            let mut v251: i64 = v250.wrapping_add(1i64);
            v244.borrow_mut().l0 = v251;
            let mut v252: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v253: bool = cfg!(target_arch = "wasm32");
            if v253 {
                let mut v254: Rc<str> = v247.borrow().l0.clone();
                let mut v255: bool = v254.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v263: Rc<str> = if v255 {
                    v241.clone()
                } else {
                    let mut v256: bool = v241.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v256 {
                        let mut v257: Rc<str> = v247.borrow().l0.clone();
                        v257.clone()
                    } else {
                        let mut v258: Rc<str> = v247.borrow().l0.clone();
                        let mut v259: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v260: Rc<str> = Rc::<str>::from(format!("{}{}", v258, v259));
                        let mut v261: Rc<str> = Rc::<str>::from(format!("{}{}", v260, v241));
                        v261.clone()
                    }
                };
                let mut v265: i32 = ((v263.chars().count() + 14999) / 15000) as i32;
                let mut v266: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v267: bool = v241 != v266 ;
                let mut v269: bool = if v267 {
                    let mut v268: bool = v265 <= 1i32;
                    v268
                } else {
                    false
                };
                if v269 {
                    v247.borrow_mut().l0 = v263.clone();
                    ()
                } else {
                    v247.borrow_mut().l0 = v266.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v263); };
                    ()
                }
            } else {
                println!("{}", v241);
                ()
            };
            let mut v272: Rc<dyn Fn(Rc<str>) -> ()> = v245.borrow().l0.clone();
            v272(v241.clone());
            US2::US2_Some(v244.clone(), v245.clone(), v246.clone(), v247.clone(), v248.clone(), v249.clone())
        };
        let mut v275: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let mut v276: Rc<UH0> = method22(v193.clone(), v275.clone());
        let mut v277: Rc<UH0> = method23(v193.clone(), v276.clone());
        let mut v278: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_StreamNil); } CASE.with(|case| case.clone()) };
        let mut v279: Rc<UH1> = method16(v277.clone(), v278.clone());
        let mut v280: Rc<dyn Fn() -> Rc<UH1>> = closure10(v279.clone());
        let mut v281: Rc<dyn Fn() -> Rc<UH1>> = method24(v279.clone(), v280.clone());
        let mut v282: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i64 }));
        let mut v283: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
        let mut v284: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: -1i64 }));
        let mut v285: US4 = US4::US4_None;
        let mut v286: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: v285.clone() }));
        let mut v287: bool = v3 == 1u64;
        let mut v291: i8 = if v287 {
            1i8
        } else {
            let mut v288: i8 = 0i8;
            let mut v289: u64 = 1u64;
            method25(v3, v288, v289)
        };
        let mut v292: i8 = v291.wrapping_sub(1i8);
        let mut v293: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let mut v294: i8 = 0i8;
        let mut v295: u64 = method28(v281.clone(), v282.clone(), v283.clone(), v284.clone(), v286.clone(), v3, v292, v293.clone(), v294);
        let mut v296: Rc<dyn Fn() -> ()> = method42();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v299, mut v300, mut v301, mut v302, mut v303, mut v304): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v305: US0 = v303.borrow().l0.clone();
        let mut v310: i32 = match &v305 {
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
        let mut v311: bool = v301.borrow().l0.clone();
        let mut v312: bool = v311 == false;
        let mut v314: bool = if v312 {
            false
        } else {
            let mut v313: bool = 20i32 >= v310;
            v313
        };
        let mut v315: bool = v314 == false;
        let mut v359: US2 = if v315 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v319, mut v320, mut v321, mut v322, mut v323, mut v324): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v325: Rc<str> = method3(v319.clone(), v320.clone(), v321.clone(), v322.clone(), v323.clone(), v324.clone());
            let mut v326: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v329, mut v330, mut v331, mut v332, mut v333, mut v334): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v335: i64 = v329.borrow().l0.clone();
            let mut v336: i64 = v335.wrapping_add(1i64);
            v329.borrow_mut().l0 = v336;
            let mut v337: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v338: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v339: bool = cfg!(target_arch = "wasm32");
            if v339 {
                let mut v340: Rc<str> = v332.borrow().l0.clone();
                let mut v341: bool = v340.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v349: Rc<str> = if v341 {
                    v337.clone()
                } else {
                    let mut v342: bool = v337.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v342 {
                        let mut v343: Rc<str> = v332.borrow().l0.clone();
                        v343.clone()
                    } else {
                        let mut v344: Rc<str> = v332.borrow().l0.clone();
                        let mut v345: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v346: Rc<str> = Rc::<str>::from(format!("{}{}", v344, v345));
                        let mut v347: Rc<str> = Rc::<str>::from(format!("{}{}", v346, v337));
                        v347.clone()
                    }
                };
                let mut v351: i32 = ((v349.chars().count() + 14999) / 15000) as i32;
                let mut v352: bool = v337 != v337 ;
                let mut v354: bool = if v352 {
                    let mut v353: bool = v351 <= 1i32;
                    v353
                } else {
                    false
                };
                if v354 {
                    v332.borrow_mut().l0 = v349.clone();
                    ()
                } else {
                    v332.borrow_mut().l0 = v337.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v349); };
                    ()
                }
            } else {
                println!("{}", v337);
                ()
            };
            let mut v357: Rc<dyn Fn(Rc<str>) -> ()> = v330.borrow().l0.clone();
            v357(v337.clone());
            US2::US2_Some(v329.clone(), v330.clone(), v331.clone(), v332.clone(), v333.clone(), v334.clone())
        };
        v295
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method43(mut v0: Rc<UH0>, mut v1: i8) -> i8 {
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
fn method44(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.roll_within_bounds"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_21(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v26));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v9));
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v30));
    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v26));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v10));
    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v43));
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v44));
    method8(v45.clone())
}
fn method45() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure76() -> Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> = Rc::new(move |mut v0: u64, mut v1: Vec<u8>| -> Option<u64> {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c1();
        { let _ = spiral_trace_hold(&v3); };
        let mut v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v12: US0 = US0::US0_Info;
        v10.borrow_mut().l0 = v12.clone();
        let mut v13: Vec<u8> = method14(v1.clone());
        let mut v14: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v13));
        let mut v15: Rc<Vec<u8>> = Rc::new((v14).borrow().clone());
        let mut v16: i32 = (v15).len() as i32;
        let mut v17: i32 = v16.wrapping_sub(1i32);
        let mut v18: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
        let mut v19: Rc<UH0> = method15(v15.clone(), v17, v18.clone());
        let mut v20: i8 = 0i8;
        let mut v21: i8 = method43(v19.clone(), v20);
        let mut v22: i8 = v21.wrapping_sub(1i8);
        let mut v23: u64 = 0u64;
        let mut v24: US5 = method34(v22, v19.clone(), v23);
        let mut v34: US6 = match &v24 {
            US5::US5_Some(v25, v26) => {
                let mut v25: u64 = *v25;
                let mut v26: Rc<UH0> = v26.clone();
                let mut v27: bool = v25 >= 1u64;
                let mut v29: bool = if v27 {
                    let mut v28: bool = v25 <= v0;
                    v28
                } else {
                    false
                };
                if v29 {
                    US6::US6_Some(v25)
                } else {
                    US6::US6_None
                }
            }
            _ => {
                US6::US6_None
            }
        };
        let mut v39: Option<u64> = match &v34 {
            US6::US6_None => {
                let mut v37: Option<u64> = None;
                v37.clone()
            }
            US6::US6_Some(v35) => {
                let mut v35: u64 = *v35;
                let mut v36: Option<u64> = Some(v35.clone());
                v36.clone()
            }
        };
        { let _ = spiral_trace_hold(&v3); };
        let (mut v42, mut v43, mut v44, mut v45, mut v46, mut v47): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v48: US0 = v46.borrow().l0.clone();
        let mut v53: i32 = match &v48 {
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
        let mut v54: bool = v44.borrow().l0.clone();
        let mut v55: bool = v54 == false;
        let mut v57: bool = if v55 {
            false
        } else {
            let mut v56: bool = 20i32 >= v53;
            v56
        };
        let mut v58: bool = v57 == false;
        let mut v105: US2 = if v58 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v62, mut v63, mut v64, mut v65, mut v66, mut v67): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v68: Rc<str> = method3(v62.clone(), v63.clone(), v64.clone(), v65.clone(), v66.clone(), v67.clone());
            let mut v69: Rc<str> = method4();
            let mut v70: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1)).s() });
            let mut v71: Rc<str> = Rc::<str>::from(match &v39 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v72: Rc<str> = method44(v62.clone(), v63.clone(), v64.clone(), v65.clone(), v66.clone(), v67.clone(), v68.clone(), v69.clone(), v0, v70.clone(), v71.clone());
            { let _ = spiral_trace_hold(&v3); };
            let (mut v75, mut v76, mut v77, mut v78, mut v79, mut v80): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v81: i64 = v75.borrow().l0.clone();
            let mut v82: i64 = v81.wrapping_add(1i64);
            v75.borrow_mut().l0 = v82;
            let mut v83: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v84: bool = cfg!(target_arch = "wasm32");
            if v84 {
                let mut v85: Rc<str> = v78.borrow().l0.clone();
                let mut v86: bool = v85.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v94: Rc<str> = if v86 {
                    v72.clone()
                } else {
                    let mut v87: bool = v72.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v87 {
                        let mut v88: Rc<str> = v78.borrow().l0.clone();
                        v88.clone()
                    } else {
                        let mut v89: Rc<str> = v78.borrow().l0.clone();
                        let mut v90: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v91: Rc<str> = Rc::<str>::from(format!("{}{}", v89, v90));
                        let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v91, v72));
                        v92.clone()
                    }
                };
                let mut v96: i32 = ((v94.chars().count() + 14999) / 15000) as i32;
                let mut v97: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v98: bool = v72 != v97 ;
                let mut v100: bool = if v98 {
                    let mut v99: bool = v96 <= 1i32;
                    v99
                } else {
                    false
                };
                if v100 {
                    v78.borrow_mut().l0 = v94.clone();
                    ()
                } else {
                    v78.borrow_mut().l0 = v97.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v94); };
                    ()
                }
            } else {
                println!("{}", v72);
                ()
            };
            let mut v103: Rc<dyn Fn(Rc<str>) -> ()> = v76.borrow().l0.clone();
            v103(v72.clone());
            US2::US2_Some(v75.clone(), v76.clone(), v77.clone(), v78.clone(), v79.clone(), v80.clone())
        };
        let mut v106: Rc<dyn Fn() -> ()> = method45();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v109, mut v110, mut v111, mut v112, mut v113, mut v114): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v115: US0 = v113.borrow().l0.clone();
        let mut v120: i32 = match &v115 {
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
        let mut v121: bool = v111.borrow().l0.clone();
        let mut v122: bool = v121 == false;
        let mut v124: bool = if v122 {
            false
        } else {
            let mut v123: bool = 20i32 >= v120;
            v123
        };
        let mut v125: bool = v124 == false;
        let mut v169: US2 = if v125 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v129, mut v130, mut v131, mut v132, mut v133, mut v134): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v135: Rc<str> = method3(v129.clone(), v130.clone(), v131.clone(), v132.clone(), v133.clone(), v134.clone());
            let mut v136: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v139, mut v140, mut v141, mut v142, mut v143, mut v144): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v145: i64 = v139.borrow().l0.clone();
            let mut v146: i64 = v145.wrapping_add(1i64);
            v139.borrow_mut().l0 = v146;
            let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v148: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v149: bool = cfg!(target_arch = "wasm32");
            if v149 {
                let mut v150: Rc<str> = v142.borrow().l0.clone();
                let mut v151: bool = v150.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v159: Rc<str> = if v151 {
                    v147.clone()
                } else {
                    let mut v152: bool = v147.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v152 {
                        let mut v153: Rc<str> = v142.borrow().l0.clone();
                        v153.clone()
                    } else {
                        let mut v154: Rc<str> = v142.borrow().l0.clone();
                        let mut v155: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v156: Rc<str> = Rc::<str>::from(format!("{}{}", v154, v155));
                        let mut v157: Rc<str> = Rc::<str>::from(format!("{}{}", v156, v147));
                        v157.clone()
                    }
                };
                let mut v161: i32 = ((v159.chars().count() + 14999) / 15000) as i32;
                let mut v162: bool = v147 != v147 ;
                let mut v164: bool = if v162 {
                    let mut v163: bool = v161 <= 1i32;
                    v163
                } else {
                    false
                };
                if v164 {
                    v142.borrow_mut().l0 = v159.clone();
                    ()
                } else {
                    v142.borrow_mut().l0 = v147.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v159); };
                    ()
                }
            } else {
                println!("{}", v147);
                ()
            };
            let mut v167: Rc<dyn Fn(Rc<str>) -> ()> = v140.borrow().l0.clone();
            v167(v147.clone());
            US2::US2_Some(v139.clone(), v140.clone(), v141.clone(), v142.clone(), v143.clone(), v144.clone())
        };
        v39.clone()
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
