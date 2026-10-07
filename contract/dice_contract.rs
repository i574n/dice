#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_patterns, unreachable_code, while_true)]
#![recursion_limit = "512"]
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
    // A slice that starts or ends inside a code point fails like the C and Delphi backends (abort / Halt(3)).
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
    US0_0,
    US0_1,
    US0_2,
    US0_3,
    US0_4,
}
impl US0 {
    fn tag(&self) -> i32 {
        match self {
            US0::US0_0 => 0,
            US0::US0_1 => 1,
            US0::US0_2 => 2,
            US0::US0_3 => 3,
            US0::US0_4 => 4,
        }
    }
}
struct Mut4 { l0: US0 }
#[derive(Clone)]
enum US1 {
    US1_0(US0),
    US1_1,
}
impl US1 {
    fn tag(&self) -> i32 {
        match self {
            US1::US1_0(..) => 0,
            US1::US1_1 => 1,
        }
    }
}
struct Mut5 { l0: i32, l1: US1 }
#[derive(Clone)]
enum US2 {
    US2_0(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US2_1,
}
impl US2 {
    fn tag(&self) -> i32 {
        match self {
            US2::US2_0(..) => 0,
            US2::US2_1 => 1,
        }
    }
}
#[derive(Clone)]
enum UH0 {
    UH0_0,
    UH0_1(u8, Rc<UH0>),
}
impl UH0 {
    fn tag(&self) -> i32 {
        match self {
            UH0::UH0_0 => 0,
            UH0::UH0_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum UH1 {
    UH1_0(u8, Rc<dyn Fn() -> Rc<UH1>>),
    UH1_1,
}
impl UH1 {
    fn tag(&self) -> i32 {
        match self {
            UH1::UH1_0(..) => 0,
            UH1::UH1_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US3 {
    US3_0(Rc<dyn Fn() -> Rc<UH1>>),
    US3_1(Rc<UH1>),
}
impl US3 {
    fn tag(&self) -> i32 {
        match self {
            US3::US3_0(..) => 0,
            US3::US3_1(..) => 1,
        }
    }
}
struct Mut6 { l0: US3 }
#[derive(Clone)]
enum US4 {
    US4_0(u8),
    US4_1,
}
impl US4 {
    fn tag(&self) -> i32 {
        match self {
            US4::US4_0(..) => 0,
            US4::US4_1 => 1,
        }
    }
}
struct Mut7 { l0: US4 }
#[derive(Clone)]
enum US5 {
    US5_0(u64, Rc<UH0>),
    US5_1,
}
impl US5 {
    fn tag(&self) -> i32 {
        match self {
            US5::US5_0(..) => 0,
            US5::US5_1 => 1,
        }
    }
}
#[derive(Clone)]
enum UH2 {
    UH2_0(u64, Rc<dyn Fn() -> Rc<UH2>>),
    UH2_1,
}
impl UH2 {
    fn tag(&self) -> i32 {
        match self {
            UH2::UH2_0(..) => 0,
            UH2::UH2_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US6 {
    US6_0(u64),
    US6_1,
}
impl US6 {
    fn tag(&self) -> i32 {
        match self {
            US6::US6_0(..) => 0,
            US6::US6_1 => 1,
        }
    }
}
fn method1(mut v0: Rc<str>) -> Rc<str> {
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
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method0(mut v0: US0) -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = method1(v1.clone());
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
    let mut v14: US0 = US0::US0_0;
    v13.borrow_mut().push((v11.clone(), v14.clone()));
    let mut v15: US0 = US0::US0_1;
    v13.borrow_mut().push((v9.clone(), v15.clone()));
    let mut v16: US0 = US0::US0_2;
    v13.borrow_mut().push((v7.clone(), v16.clone()));
    let mut v17: US0 = US0::US0_3;
    v13.borrow_mut().push((v5.clone(), v17.clone()));
    let mut v18: US0 = US0::US0_4;
    v13.borrow_mut().push((v3.clone(), v18.clone()));
    let mut v19: US0 = US0::US0_0;
    v13.borrow_mut().push((v12.clone(), v19.clone()));
    let mut v20: US0 = US0::US0_1;
    v13.borrow_mut().push((v10.clone(), v20.clone()));
    let mut v21: US0 = US0::US0_2;
    v13.borrow_mut().push((v8.clone(), v21.clone()));
    let mut v22: US0 = US0::US0_3;
    v13.borrow_mut().push((v6.clone(), v22.clone()));
    let mut v23: US0 = US0::US0_4;
    v13.borrow_mut().push((v4.clone(), v23.clone()));
    let mut v24: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v13.borrow().clone());
    let mut v25: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let mut v26: i32 = (v25.clone().borrow().len() as i32);
    let mut v27: US1 = US1::US1_1;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: 0i32, l1: v27.clone() }));
    while method2(v26, v28.clone()) {
        let mut v30: i32 = v28.borrow().l0.clone();
        let mut v31: i32 = -(v30);
        let mut v32: i32 = v31 + v26;
        let mut v33: i32 = v32 - 1i32;
        let mut v34: US1 = v28.borrow().l1.clone();
        let (mut v35, mut v36): (Rc<str>, US0) = v25.clone().borrow()[v33 as usize].clone();
        let mut v43: US1 = match &v34 {
            US1::US1_1 => { // None
                let mut v38: bool = v35 == v2 ;
                if v38 {
                    US1::US1_0(v36.clone())
                } else {
                    US1::US1_1
                }
            }
            US1::US1_0(v37) => { // Some
                let mut v37: US0 = v37.clone();
                v34.clone()
            }
            _ => unreachable!(),
        };
        let mut v44: i32 = v30 + 1i32;
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
        US1::US1_1 => { // None
            v0.clone()
        }
        US1::US1_0(v52) => { // Some
            let mut v52: US0 = v52.clone();
            v52.clone()
        }
        _ => unreachable!(),
    };
    let mut v55: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v54.clone() }));
    let mut v56: Option<i64> = None;
    (v46.clone(), v48.clone(), v49.clone(), v51.clone(), v55.clone(), v56.clone())
}
fn closure1() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_0;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = method0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure3() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_0;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = method0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure0() -> Rc<dyn Fn() -> (u32, SpiralNearVec<u8>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (u32, SpiralNearVec<u8>)> = Rc::new(move || -> (u32, SpiralNearVec<u8>) {
        let mut v42: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v42); };
        let mut v125: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v126, mut v127, mut v128, mut v129, mut v130, mut v131): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v125) };
        let mut v152: US0 = US0::US0_2;
        v130.borrow_mut().l0 = v152.clone();
        let mut v201: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
        let mut v202: &[u8] = { let owned: Rc<str> = (v201).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v262: SpiralNearVec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::store::vec::Vector::new(v202); #[cfg(not(target_arch = "wasm32"))] let v = SpiralNearVec(<std::vec::Vec<u8>>::new()); v };
        (2u32, v262)
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v955: u64 = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; h * 3600 + m * 60 + s };
    let mut v956: u64 = v955 / 3600u64;
    let mut v957: bool = v956 < 10u64;
    let mut v960: Rc<str> = if v957 {
        let mut v958: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v958.clone()
    } else {
        let mut v959: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v959.clone()
    };
    let mut v977: Rc<str> = Rc::<str>::from(format!("{:?}", v956));
    let mut v981: Rc<str> = Rc::<str>::from(format!("{}{}", v960, v977));
    let mut v992: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
    let mut v993: Rc<str> = Rc::<str>::from(format!("{}{}", v981, v992));
    let mut v997: u64 = v955 / 60u64;
    let mut v998: u64 = v997 % 60u64;
    let mut v999: bool = v998 < 10u64;
    let mut v1002: Rc<str> = if v999 {
        let mut v1000: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1000.clone()
    } else {
        let mut v1001: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1001.clone()
    };
    let mut v1003: Rc<str> = Rc::<str>::from(format!("{:?}", v998));
    let mut v1004: Rc<str> = Rc::<str>::from(format!("{}{}", v1002, v1003));
    let mut v1005: Rc<str> = Rc::<str>::from(format!("{}{}", v993, v1004));
    let mut v1006: Rc<str> = Rc::<str>::from(format!("{}{}", v1005, v992));
    let mut v1007: u64 = v955 % 60u64;
    let mut v1008: bool = v1007 < 10u64;
    let mut v1011: Rc<str> = if v1008 {
        let mut v1009: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1009.clone()
    } else {
        let mut v1010: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1010.clone()
    };
    let mut v1012: Rc<str> = Rc::<str>::from(format!("{:?}", v1007));
    let mut v1013: Rc<str> = Rc::<str>::from(format!("{}{}", v1011, v1012));
    let mut v1014: Rc<str> = Rc::<str>::from(format!("{}{}", v1006, v1013));
    v1014.clone()
}
fn method6(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method5(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v2.clone(), v19.clone());
    let mut v23: Rc<str> = v2.borrow().l0.clone();
    v23.clone()
}
fn method4() -> Rc<str> {
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v9: Rc<str> = Rc::<str>::from(v8.to_lowercase());
    let mut v10: u8 = v9.clone().as_bytes()[0i32 as usize];
    let mut v11: Rc<str> = method5(v10);
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v11));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v18));
    v21.clone()
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
                let mut v12: i32 = v2 + 1i32;
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
            let mut v3: i32 = v1 - 1i32;
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
    let mut v4: i32 = v1 - 1i32;
    let mut v12: Rc<str> = string_slice(&v0.clone(), v3 as i64, v4 as i64);
    let mut v15: i32 = (v12.clone().len() as i32);
    let mut v16: i32 = method10(v12.clone(), v15);
    let mut v24: Rc<str> = string_slice(&v12.clone(), 0i32 as i64, v16 as i64);
    v24.clone()
}
fn method11(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v19.clone());
    let mut v23: Rc<str> = v2.borrow().l0.clone();
    v23.clone()
}
fn method13(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method14(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess_len"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method15(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method16(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method17(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed_excess"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method18(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method12(mut v0: i32, mut v1: Rc<str>) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method13(v3.clone());
    method14(v3.clone());
    method15(v3.clone());
    let mut v89: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v3.clone(), v89.clone());
    method16(v3.clone());
    method17(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method18(v3.clone());
    let mut v162: Rc<str> = v3.borrow().l0.clone();
    v162.clone()
}
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let mut v15: Rc<str> = method11(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v7));
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v13));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.contribute_seed"); } LIT.with(|lit| lit.clone()) };
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v29));
    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v44));
    let mut v49: Rc<str> = method12(v8, v9.clone());
    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v49));
    method8(v50.clone())
}
fn closure5() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure6() -> Rc<dyn Fn() -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> ()> = Rc::new(move || -> () {
        ()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method19() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure4() -> Rc<dyn Fn(&mut SpiralNearVec<u8>, Vec<u8>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut SpiralNearVec<u8>, Vec<u8>) -> ()> = Rc::new(move |mut v0: &mut SpiralNearVec<u8>, mut v1: Vec<u8>| -> () {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v3); };
        let mut v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v12: US0 = US0::US0_2;
        v10.borrow_mut().l0 = v12.clone();
        { (v0).extend((v1).clone()); };
        let mut v62: u32 = ((v0).len() as u32);
        let mut v248: i32 = (v62 as i32);
        let mut v364: usize = ((100i32) as usize);
        let mut v482: i32 = (v364 as i32);
        let mut v486: i32 = v248 - v482;
        let mut v487: bool = v486 > 0i32;
        if v487 {
            let mut v489: Vec<u8> = v0.drain(0..v486 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v492, mut v493, mut v494, mut v495, mut v496, mut v497): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v498: US0 = v496.borrow().l0.clone();
            let mut v503: i32 = match &v498 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v504: bool = v494.borrow().l0.clone();
            let mut v505: bool = v504 == false;
            let mut v507: bool = if v505 {
                false
            } else {
                let mut v506: bool = 20i32 >= v503;
                v506
            };
            let mut v508: bool = v507 == false;
            let mut v589: US2 = if v508 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v3); };
                let (mut v512, mut v513, mut v514, mut v515, mut v516, mut v517): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v518: Rc<str> = method3(v512.clone(), v513.clone(), v514.clone(), v515.clone(), v516.clone(), v517.clone());
                let mut v519: Rc<str> = method4();
                let mut v526: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v489)).s() });
                let mut v530: Rc<str> = method7(v512.clone(), v513.clone(), v514.clone(), v515.clone(), v516.clone(), v517.clone(), v518.clone(), v519.clone(), v486, v526.clone());
                { let _ = spiral_trace_hold(&v3); };
                let (mut v533, mut v534, mut v535, mut v536, mut v537, mut v538): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v539: i64 = v533.borrow().l0.clone();
                let mut v540: i64 = v539 + 1i64;
                v533.borrow_mut().l0 = v540;
                let mut v541: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v542: bool = cfg!(target_arch = "wasm32");
                if v542 {
                    let mut v543: Rc<str> = v536.borrow().l0.clone();
                    let mut v544: bool = v543.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v565: Rc<str> = if v544 {
                        v530.clone()
                    } else {
                        let mut v545: bool = v530.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v545 {
                            let mut v546: Rc<str> = v536.borrow().l0.clone();
                            v546.clone()
                        } else {
                            let mut v547: Rc<str> = v536.borrow().l0.clone();
                            let mut v558: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v559: Rc<str> = Rc::<str>::from(format!("{}{}", v547, v558));
                            let mut v563: Rc<str> = Rc::<str>::from(format!("{}{}", v559, v530));
                            v563.clone()
                        }
                    };
                    let mut v567: i32 = ((v565.chars().count() + 14999) / 15000) as i32;
                    let mut v578: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v579: bool = v530 != v578 ;
                    let mut v584: bool = if v579 {
                        let mut v583: bool = v567 <= 1i32;
                        v583
                    } else {
                        false
                    };
                    if v584 {
                        v536.borrow_mut().l0 = v565.clone();
                        ()
                    } else {
                        v536.borrow_mut().l0 = v578.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v565); };
                        ()
                    }
                } else {
                    println!("{}", v530);
                    ()
                };
                let mut v587: Rc<dyn Fn(Rc<str>) -> ()> = v534.borrow().l0.clone();
                v587(v530.clone());
                US2::US2_0(v533.clone(), v534.clone(), v535.clone(), v536.clone(), v537.clone(), v538.clone())
            };
            ()
        };
        let mut v611: Rc<dyn Fn() -> ()> = method19();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v614, mut v615, mut v616, mut v617, mut v618, mut v619): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v620: US0 = v618.borrow().l0.clone();
        let mut v625: i32 = match &v620 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v626: bool = v616.borrow().l0.clone();
        let mut v627: bool = v626 == false;
        let mut v629: bool = if v627 {
            false
        } else {
            let mut v628: bool = 20i32 >= v625;
            v628
        };
        let mut v630: bool = v629 == false;
        let mut v674: US2 = if v630 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v634, mut v635, mut v636, mut v637, mut v638, mut v639): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v640: Rc<str> = method3(v634.clone(), v635.clone(), v636.clone(), v637.clone(), v638.clone(), v639.clone());
            let mut v641: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v644, mut v645, mut v646, mut v647, mut v648, mut v649): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v650: i64 = v644.borrow().l0.clone();
            let mut v651: i64 = v650 + 1i64;
            v644.borrow_mut().l0 = v651;
            let mut v652: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v653: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v654: bool = cfg!(target_arch = "wasm32");
            if v654 {
                let mut v655: Rc<str> = v647.borrow().l0.clone();
                let mut v656: bool = v655.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v664: Rc<str> = if v656 {
                    v652.clone()
                } else {
                    let mut v657: bool = v652.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v657 {
                        let mut v658: Rc<str> = v647.borrow().l0.clone();
                        v658.clone()
                    } else {
                        let mut v659: Rc<str> = v647.borrow().l0.clone();
                        let mut v660: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v661: Rc<str> = Rc::<str>::from(format!("{}{}", v659, v660));
                        let mut v662: Rc<str> = Rc::<str>::from(format!("{}{}", v661, v652));
                        v662.clone()
                    }
                };
                let mut v666: i32 = ((v664.chars().count() + 14999) / 15000) as i32;
                let mut v667: bool = v652 != v652 ;
                let mut v669: bool = if v667 {
                    let mut v668: bool = v666 <= 1i32;
                    v668
                } else {
                    false
                };
                if v669 {
                    v647.borrow_mut().l0 = v664.clone();
                    ()
                } else {
                    v647.borrow_mut().l0 = v652.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v664); };
                    ()
                }
            } else {
                println!("{}", v652);
                ()
            };
            let mut v672: Rc<dyn Fn(Rc<str>) -> ()> = v645.borrow().l0.clone();
            v672(v652.clone());
            US2::US2_0(v644.clone(), v645.clone(), v646.clone(), v647.clone(), v648.clone(), v649.clone())
        };
        ()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method20(mut v0: Vec<u8>) -> Vec<u8> {
    v0.clone()
}
fn method21(mut v0: Rc<Vec<u8>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: u8 = (v0)[v1 as usize].clone();
            let mut v5: i32 = v1 - 1i32;
            let mut v6: Rc<UH0> = Rc::new(UH0::UH0_1(v4, v2.clone()));
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
fn method22(mut v0: Rc<UH0>, mut v1: Rc<UH1>) -> Rc<UH1> {
    match &*v0 {
        UH0::UH0_1(v2, v3) => { // Cons
            let mut v2: u8 = v2.clone();
            let mut v3: Rc<UH0> = v3.clone();
            let mut v4: Rc<UH1> = method22(v3.clone(), v1.clone());
            let mut v5: Rc<dyn Fn() -> Rc<UH1>> = closure8(v4.clone());
            Rc::new(UH1::UH1_0(v2, v5.clone()))
        }
        UH0::UH0_0 => { // Nil
            v1.clone()
        }
        _ => unreachable!(),
    }
}
fn closure9(mut v0: Rc<UH1>) -> Rc<dyn Fn() -> Rc<UH1>> {
    Rc::new(move || -> Rc<UH1> {
        v0.clone()
    })
}
fn method23(mut v0: Rc<UH1>, mut v1: Rc<UH1>) -> Rc<UH1> {
    match &*v0 {
        UH1::UH1_0(v2, v3) => { // StreamCons
            let mut v2: u8 = v2.clone();
            let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
            let mut v4: Rc<UH1> = v3();
            let mut v5: Rc<UH1> = method23(v4.clone(), v1.clone());
            let mut v6: i64 = (v2 as i64);
            let mut v7: i64 = v6 - 1i64;
            let mut v8: i64 = v7 + 6i64;
            let mut v9: i64 = v8 % 6i64;
            let mut v10: i64 = v9 + 1i64;
            let mut v11: u8 = (v10 as u8);
            let mut v12: Rc<dyn Fn() -> Rc<UH1>> = closure9(v5.clone());
            Rc::new(UH1::UH1_0(v11, v12.clone()))
        }
        UH1::UH1_1 => { // StreamNil
            v1.clone()
        }
        _ => unreachable!(),
    }
}
fn method24(mut v0: Rc<UH1>, mut v1: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH1::UH1_0(v2, v3) => { // StreamCons
            let mut v2: u8 = v2.clone();
            let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
            let mut v4: Rc<UH1> = v3();
            let mut v5: Rc<UH0> = method24(v4.clone(), v1.clone());
            Rc::new(UH0::UH0_1(v2, v5.clone()))
        }
        UH1::UH1_1 => { // StreamNil
            v1.clone()
        }
        _ => unreachable!(),
    }
}
fn method25(mut v0: Rc<RefCell<Vec<u8>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_1(v3, v4) => { // Cons
                let mut v3: u8 = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                v0.borrow_mut().push(v3);
                let mut v5: i32 = v2 + 1i32;
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v2;
            }
            _ => unreachable!(),
        }
    }
}
fn method28(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method29(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("key"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method30(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("proof"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method31(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_timestamp"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method32(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_height"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method33(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epoch_height"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method34(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_balance"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method35(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("signer_account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method36(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("predecessor_account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method37(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seed"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method38(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method39(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("entropy_len"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method40(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("entropy"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method41(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash_u8"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method42(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method27(mut v0: u64, mut v1: std::string::String, mut v2: std::string::String, mut v3: u64, mut v4: u64, mut v5: u64, mut v6: Rc<str>, mut v7: std::string::String, mut v8: std::string::String, mut v9: Rc<str>, mut v10: Rc<str>, mut v11: usize, mut v12: Rc<str>, mut v13: Rc<str>, mut v14: Rc<str>) -> Rc<str> {
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v15.clone() }));
    method13(v16.clone());
    method28(v16.clone());
    method15(v16.clone());
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v16.clone(), v46.clone());
    method16(v16.clone());
    method29(v16.clone());
    method15(v16.clone());
    let mut v90: std::string::String = format!("{:#?}", v1);
    let mut v92: Rc<str> = Rc::<str>::from(v90);
    method6(v16.clone(), v92.clone());
    method16(v16.clone());
    method30(v16.clone());
    method15(v16.clone());
    let mut v120: std::string::String = format!("{:#?}", v2);
    let mut v122: Rc<str> = Rc::<str>::from(v120);
    method6(v16.clone(), v122.clone());
    method16(v16.clone());
    method31(v16.clone());
    method15(v16.clone());
    let mut v146: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v16.clone(), v146.clone());
    method16(v16.clone());
    method32(v16.clone());
    method15(v16.clone());
    let mut v170: Rc<str> = Rc::<str>::from(format!("{}", v4));
    method6(v16.clone(), v170.clone());
    method16(v16.clone());
    method33(v16.clone());
    method15(v16.clone());
    let mut v194: Rc<str> = Rc::<str>::from(format!("{}", v5));
    method6(v16.clone(), v194.clone());
    method16(v16.clone());
    method34(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v6.clone());
    method16(v16.clone());
    method35(v16.clone());
    method15(v16.clone());
    let mut v242: std::string::String = format!("{:#?}", v7);
    let mut v244: Rc<str> = Rc::<str>::from(v242);
    method6(v16.clone(), v244.clone());
    method16(v16.clone());
    method36(v16.clone());
    method15(v16.clone());
    let mut v269: std::string::String = format!("{:#?}", v8);
    let mut v271: Rc<str> = Rc::<str>::from(v269);
    method6(v16.clone(), v271.clone());
    method16(v16.clone());
    method37(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v9.clone());
    method16(v16.clone());
    method38(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v10.clone());
    method16(v16.clone());
    method39(v16.clone());
    method15(v16.clone());
    let mut v358: std::string::String = format!("{:#?}", v11);
    let mut v360: Rc<str> = Rc::<str>::from(v358);
    method6(v16.clone(), v360.clone());
    method16(v16.clone());
    method40(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v12.clone());
    method16(v16.clone());
    method41(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v13.clone());
    method16(v16.clone());
    method42(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v14.clone());
    method18(v16.clone());
    let mut v433: Rc<str> = v16.borrow().l0.clone();
    v433.clone()
}
fn method26(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: std::string::String, mut v10: std::string::String, mut v11: u64, mut v12: u64, mut v13: u64, mut v14: Rc<str>, mut v15: std::string::String, mut v16: std::string::String, mut v17: Rc<str>, mut v18: Rc<str>, mut v19: usize, mut v20: Rc<str>, mut v21: Rc<str>, mut v22: Rc<str>) -> Rc<str> {
    let mut v23: i64 = v0.borrow().l0.clone();
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v24));
    let mut v26: Rc<str> = method11(v23);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v7));
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v24));
    let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.generate_random_number"); } LIT.with(|lit| lit.clone()) };
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v40));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v45));
    let mut v47: Rc<str> = method27(v8, v9.clone(), v10.clone(), v11, v12, v13, v14.clone(), v15.clone(), v16.clone(), v17.clone(), v18.clone(), v19.clone(), v20.clone(), v21.clone(), v22.clone());
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v47));
    method8(v48.clone())
}
fn method43(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v0 {
            UH0::UH0_1(v2, v3) => { // Cons
                let mut v2: u8 = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: Rc<UH0> = Rc::new(UH0::UH0_1(v2, v1.clone()));
                (v0, v1) = (v3.clone(), v4.clone());
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v1.clone();
            }
            _ => unreachable!(),
        }
    }
}
fn method44(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH0::UH0_1(v2, v3) => { // Cons
            let mut v2: u8 = v2.clone();
            let mut v3: Rc<UH0> = v3.clone();
            let mut v4: Rc<UH0> = method44(v3.clone(), v1.clone());
            Rc::new(UH0::UH0_1(v2, v4.clone()))
        }
        UH0::UH0_0 => { // Nil
            v1.clone()
        }
        _ => unreachable!(),
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
            US3::US3_1(v3) => { // Computed
                let mut v3: Rc<UH1> = v3.clone();
                v3.clone()
            }
            US3::US3_0(v4) => { // NotComputed
                let mut v4: Rc<dyn Fn() -> Rc<UH1>> = v4.clone();
                let mut v5: Rc<UH1> = v4();
                let mut v12: Rc<UH1> = match &*v5 {
                    UH1::UH1_0(v7, v8) => { // StreamCons
                        let mut v7: u8 = v7.clone();
                        let mut v8: Rc<dyn Fn() -> Rc<UH1>> = v8.clone();
                        let mut v9: Rc<dyn Fn() -> Rc<UH1>> = method45(v0.clone(), v8.clone());
                        Rc::new(UH1::UH1_0(v7, v9.clone()))
                    }
                    UH1::UH1_1 => { // StreamNil
                        { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) }
                    }
                    _ => unreachable!(),
                };
                let mut v13: US3 = US3::US3_1(v12.clone());
                v1.borrow_mut().l0 = v13.clone();
                v12.clone()
            }
            _ => unreachable!(),
        }
    })
}
fn method45(mut v0: Rc<UH1>, mut v1: Rc<dyn Fn() -> Rc<UH1>>) -> Rc<dyn Fn() -> Rc<UH1>> {
    let mut v2: US3 = US3::US3_0(v1.clone());
    let mut v3: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: v2.clone() }));
    closure11(v0.clone(), v3.clone())
}
fn method47(mut v0: u64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method50(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("p"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method51(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("n"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method49(mut v0: u64, mut v1: u64, mut v2: i8) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method28(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v5.clone());
    method16(v4.clone());
    method50(v4.clone());
    method15(v4.clone());
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v29.clone());
    method16(v4.clone());
    method51(v4.clone());
    method15(v4.clone());
    let mut v69: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v69.clone());
    method18(v4.clone());
    let mut v73: Rc<str> = v4.borrow().l0.clone();
    v73.clone()
}
fn method48(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: u64, mut v10: i8) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count"); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v28));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v33));
    let mut v35: Rc<str> = method49(v8, v9, v10);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    method8(v36.clone())
}
fn method46(mut v0: u64, mut v1: i8, mut v2: u64) -> i8 {
    loop {
        let mut v3: bool = v2 < v0;
        if v3 {
            let mut v4: bool = v2 > 3074457345618258602u64;
            if v4 {
                let mut v5: Rc<str> = method47(v0);
                let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count / max: "); } LIT.with(|lit| lit.clone()) };
                let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v5));
                let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" is above the largest supported bound "); } LIT.with(|lit| lit.clone()) };
                let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v31));
                let mut v36: Rc<str> = method47(v2);
                let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v36));
                return std::panic::panic_any::<std::string::String>(format!("{}", v37.clone()));
            } else {
                let mut v39: i8 = v1 + 1i8;
                let mut v40: u64 = v2 * 6u64;
                (v0, v1, v2) = (v0, v39, v40);
                continue;
            }
        } else {
            let mut v44: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
            { let _ = spiral_trace_hold(&v44); };
            let mut v46: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v47, mut v48, mut v49, mut v50, mut v51, mut v52): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v46) };
            let mut v53: US0 = v51.borrow().l0.clone();
            let mut v58: i32 = match &v53 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v59: bool = v49.borrow().l0.clone();
            let mut v60: bool = v59 == false;
            let mut v62: bool = if v60 {
                false
            } else {
                let mut v61: bool = 20i32 >= v58;
                v61
            };
            let mut v63: bool = v62 == false;
            let mut v108: US2 = if v63 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v44); };
                let (mut v67, mut v68, mut v69, mut v70, mut v71, mut v72): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v46) };
                let mut v73: Rc<str> = method3(v67.clone(), v68.clone(), v69.clone(), v70.clone(), v71.clone(), v72.clone());
                let mut v74: Rc<str> = method4();
                let mut v75: Rc<str> = method48(v67.clone(), v68.clone(), v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone(), v74.clone(), v0, v2, v1);
                { let _ = spiral_trace_hold(&v44); };
                let (mut v78, mut v79, mut v80, mut v81, mut v82, mut v83): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v46) };
                let mut v84: i64 = v78.borrow().l0.clone();
                let mut v85: i64 = v84 + 1i64;
                v78.borrow_mut().l0 = v85;
                let mut v86: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v87: bool = cfg!(target_arch = "wasm32");
                if v87 {
                    let mut v88: Rc<str> = v81.borrow().l0.clone();
                    let mut v89: bool = v88.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v97: Rc<str> = if v89 {
                        v75.clone()
                    } else {
                        let mut v90: bool = v75.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v90 {
                            let mut v91: Rc<str> = v81.borrow().l0.clone();
                            v91.clone()
                        } else {
                            let mut v92: Rc<str> = v81.borrow().l0.clone();
                            let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v94: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v93));
                            let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v75));
                            v95.clone()
                        }
                    };
                    let mut v99: i32 = ((v97.chars().count() + 14999) / 15000) as i32;
                    let mut v100: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v101: bool = v75 != v100 ;
                    let mut v103: bool = if v101 {
                        let mut v102: bool = v99 <= 1i32;
                        v102
                    } else {
                        false
                    };
                    if v103 {
                        v81.borrow_mut().l0 = v97.clone();
                        ()
                    } else {
                        v81.borrow_mut().l0 = v100.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v97); };
                        ()
                    }
                } else {
                    println!("{}", v75);
                    ()
                };
                let mut v106: Rc<dyn Fn(Rc<str>) -> ()> = v79.borrow().l0.clone();
                v106(v75.clone());
                US2::US2_0(v78.clone(), v79.clone(), v80.clone(), v81.clone(), v82.clone(), v83.clone())
            };
            return v1;
        }
    }
}
fn method56(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("current_index"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method57(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method58(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("len"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method59(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("last_item"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method55(mut v0: i64, mut v1: i64, mut v2: i64, mut v3: Rc<str>) -> Rc<str> {
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    method13(v5.clone());
    method56(v5.clone());
    method15(v5.clone());
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v5.clone(), v29.clone());
    method16(v5.clone());
    method57(v5.clone());
    method15(v5.clone());
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v5.clone(), v53.clone());
    method16(v5.clone());
    method58(v5.clone());
    method15(v5.clone());
    let mut v77: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v5.clone(), v77.clone());
    method16(v5.clone());
    method59(v5.clone());
    method15(v5.clone());
    method6(v5.clone(), v3.clone());
    method18(v5.clone());
    let mut v101: Rc<str> = v5.borrow().l0.clone();
    v101.clone()
}
fn method54(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: i64, mut v10: i64, mut v11: Rc<str>) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0.clone();
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let mut v15: Rc<str> = method11(v12);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v7));
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v13));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll"); } LIT.with(|lit| lit.clone()) };
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v29));
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v34));
    let mut v36: Rc<str> = method55(v8, v9, v10, v11.clone());
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    method8(v37.clone())
}
fn method60(mut v0: i64, mut v1: Rc<UH1>) -> US4 {
    loop {
        match &*v1 {
            UH1::UH1_0(v2, v3) => { // StreamCons
                let mut v2: u8 = v2.clone();
                let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
                let mut v4: bool = v0 <= 0i64;
                if v4 {
                    return US4::US4_0(v2);
                } else {
                    let mut v6: i64 = v0 - 1i64;
                    let mut v7: Rc<UH1> = v3();
                    (v0, v1) = (v6, v7.clone());
                    continue;
                }
            }
            UH1::UH1_1 => { // StreamNil
                return US4::US4_1;
            }
            _ => unreachable!(),
        }
    }
}
fn method62() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v1: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v0.clone() }));
    let mut v2: Rc<str> = v1.borrow().l0.clone();
    v2.clone()
}
fn method61(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>) -> Rc<str> {
    let mut v8: i64 = v0.borrow().l0.clone();
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v9));
    let mut v11: Rc<str> = method11(v8);
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v10, v11));
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v7));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v9));
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll / None"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v25));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v30));
    let mut v32: Rc<str> = method62();
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    method8(v33.clone())
}
fn method53(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>) -> u8 {
    loop {
        let mut v5: i64 = v1.borrow().l0.clone();
        let mut v6: i64 = v2.borrow().l0.clone();
        let mut v7: i64 = v3.borrow().l0.clone();
        let mut v8: US4 = v4.borrow().l0.clone();
        let mut v43: Option<u8> = match &v8 {
            US4::US4_1 => { // None
                let mut v38: Option<u8> = None;
                v38.clone()
            }
            US4::US4_0(v9) => { // Some
                let mut v9: u8 = v9.clone();
                let mut v26: Option<u8> = Some(v9.clone());
                v26.clone()
            }
            _ => unreachable!(),
        };
        let mut v45: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v45); };
        let mut v47: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
        let mut v54: US0 = v52.borrow().l0.clone();
        let mut v59: i32 = match &v54 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v60: bool = v50.borrow().l0.clone();
        let mut v61: bool = v60 == false;
        let mut v63: bool = if v61 {
            false
        } else {
            let mut v62: bool = 20i32 >= v59;
            v62
        };
        let mut v64: bool = v63 == false;
        let mut v148: US2 = if v64 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v45); };
            let (mut v68, mut v69, mut v70, mut v71, mut v72, mut v73): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
            let mut v74: Rc<str> = method3(v68.clone(), v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone());
            let mut v75: Rc<str> = method4();
            let mut v82: Rc<str> = Rc::<str>::from(match &v43 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v115: Rc<str> = method54(v68.clone(), v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone(), v74.clone(), v75.clone(), v5, v6, v7, v82.clone());
            { let _ = spiral_trace_hold(&v45); };
            let (mut v118, mut v119, mut v120, mut v121, mut v122, mut v123): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
            let mut v124: i64 = v118.borrow().l0.clone();
            let mut v125: i64 = v124 + 1i64;
            v118.borrow_mut().l0 = v125;
            let mut v126: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v127: bool = cfg!(target_arch = "wasm32");
            if v127 {
                let mut v128: Rc<str> = v121.borrow().l0.clone();
                let mut v129: bool = v128.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v137: Rc<str> = if v129 {
                    v115.clone()
                } else {
                    let mut v130: bool = v115.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v130 {
                        let mut v131: Rc<str> = v121.borrow().l0.clone();
                        v131.clone()
                    } else {
                        let mut v132: Rc<str> = v121.borrow().l0.clone();
                        let mut v133: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v134: Rc<str> = Rc::<str>::from(format!("{}{}", v132, v133));
                        let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v134, v115));
                        v135.clone()
                    }
                };
                let mut v139: i32 = ((v137.chars().count() + 14999) / 15000) as i32;
                let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v141: bool = v115 != v140 ;
                let mut v143: bool = if v141 {
                    let mut v142: bool = v139 <= 1i32;
                    v142
                } else {
                    false
                };
                if v143 {
                    v121.borrow_mut().l0 = v137.clone();
                    ()
                } else {
                    v121.borrow_mut().l0 = v140.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v137); };
                    ()
                }
            } else {
                println!("{}", v115);
                ()
            };
            let mut v146: Rc<dyn Fn(Rc<str>) -> ()> = v119.borrow().l0.clone();
            v146(v115.clone());
            US2::US2_0(v118.clone(), v119.clone(), v120.clone(), v121.clone(), v122.clone(), v123.clone())
        };
        let mut v149: Rc<UH1> = v0();
        let mut v150: i64 = v1.borrow().l0.clone();
        let mut v151: US4 = method60(v150, v149.clone());
        match &v151 {
            US4::US4_1 => { // None
                { let _ = spiral_trace_hold(&v45); };
                let (mut v158, mut v159, mut v160, mut v161, mut v162, mut v163): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
                let mut v164: US0 = v162.borrow().l0.clone();
                let mut v169: i32 = match &v164 {
                    US0::US0_4 => { // Critical
                        50i32
                    }
                    US0::US0_1 => { // Debug
                        20i32
                    }
                    US0::US0_2 => { // Info
                        30i32
                    }
                    US0::US0_0 => { // Verbose
                        10i32
                    }
                    US0::US0_3 => { // Warning
                        40i32
                    }
                    _ => unreachable!(),
                };
                let mut v170: bool = v160.borrow().l0.clone();
                let mut v171: bool = v170 == false;
                let mut v173: bool = if v171 {
                    false
                } else {
                    let mut v172: bool = 20i32 >= v169;
                    v172
                };
                let mut v174: bool = v173 == false;
                let mut v219: US2 = if v174 {
                    US2::US2_1
                } else {
                    { let _ = spiral_trace_hold(&v45); };
                    let (mut v178, mut v179, mut v180, mut v181, mut v182, mut v183): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
                    let mut v184: Rc<str> = method3(v178.clone(), v179.clone(), v180.clone(), v181.clone(), v182.clone(), v183.clone());
                    let mut v185: Rc<str> = method4();
                    let mut v186: Rc<str> = method61(v178.clone(), v179.clone(), v180.clone(), v181.clone(), v182.clone(), v183.clone(), v184.clone(), v185.clone());
                    { let _ = spiral_trace_hold(&v45); };
                    let (mut v189, mut v190, mut v191, mut v192, mut v193, mut v194): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
                    let mut v195: i64 = v189.borrow().l0.clone();
                    let mut v196: i64 = v195 + 1i64;
                    v189.borrow_mut().l0 = v196;
                    let mut v197: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                    let mut v198: bool = cfg!(target_arch = "wasm32");
                    if v198 {
                        let mut v199: Rc<str> = v192.borrow().l0.clone();
                        let mut v200: bool = v199.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v208: Rc<str> = if v200 {
                            v186.clone()
                        } else {
                            let mut v201: bool = v186.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v201 {
                                let mut v202: Rc<str> = v192.borrow().l0.clone();
                                v202.clone()
                            } else {
                                let mut v203: Rc<str> = v192.borrow().l0.clone();
                                let mut v204: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v205: Rc<str> = Rc::<str>::from(format!("{}{}", v203, v204));
                                let mut v206: Rc<str> = Rc::<str>::from(format!("{}{}", v205, v186));
                                v206.clone()
                            }
                        };
                        let mut v210: i32 = ((v208.chars().count() + 14999) / 15000) as i32;
                        let mut v211: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v212: bool = v186 != v211 ;
                        let mut v214: bool = if v212 {
                            let mut v213: bool = v210 <= 1i32;
                            v213
                        } else {
                            false
                        };
                        if v214 {
                            v192.borrow_mut().l0 = v208.clone();
                            ()
                        } else {
                            v192.borrow_mut().l0 = v211.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v208); };
                            ()
                        }
                    } else {
                        println!("{}", v186);
                        ()
                    };
                    let mut v217: Rc<dyn Fn(Rc<str>) -> ()> = v190.borrow().l0.clone();
                    v217(v186.clone());
                    US2::US2_0(v189.clone(), v190.clone(), v191.clone(), v192.clone(), v193.clone(), v194.clone())
                };
                let mut v220: i64 = v3.borrow().l0.clone();
                let mut v221: bool = v220 == -1i64;
                if v221 {
                    let mut v222: i64 = v1.borrow().l0.clone();
                    v3.borrow_mut().l0 = v222;
                    ()
                };
                let mut v223: i64 = v2.borrow().l0.clone();
                let mut v224: i64 = v3.borrow().l0.clone();
                let mut v225: bool = v223 >= v224;
                let mut v228: i64 = if v225 {
                    1i64
                } else {
                    let mut v226: i64 = v2.borrow().l0.clone();
                    let mut v227: i64 = v226 + 1i64;
                    v227
                };
                v2.borrow_mut().l0 = v228;
                let mut v229: i64 = v2.borrow().l0.clone();
                let mut v230: i64 = v229 - 1i64;
                v1.borrow_mut().l0 = v230;
                let mut v231: US4 = US4::US4_1;
                v4.borrow_mut().l0 = v231.clone();
                (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
                continue;
            }
            US4::US4_0(v152) => { // Some
                let mut v152: u8 = v152.clone();
                let mut v153: i64 = v1.borrow().l0.clone();
                let mut v154: i64 = v153 + 1i64;
                v1.borrow_mut().l0 = v154;
                let mut v155: US4 = US4::US4_0(v152);
                v4.borrow_mut().l0 = v155.clone();
                return v152;
            }
            _ => unreachable!(),
        }
    }
}
fn method66(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method67(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method65(mut v0: i8, mut v1: u64, mut v2: u64) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method66(v4.clone());
    method15(v4.clone());
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v28.clone());
    method16(v4.clone());
    method57(v4.clone());
    method15(v4.clone());
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v29.clone());
    method16(v4.clone());
    method67(v4.clone());
    method15(v4.clone());
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v53.clone());
    method18(v4.clone());
    let mut v54: Rc<str> = v4.borrow().l0.clone();
    v54.clone()
}
fn method64(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u64) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v28));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v33));
    let mut v35: Rc<str> = method65(v8, v9, v10);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    method8(v36.clone())
}
fn closure75() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_1); } CASE.with(|case| case.clone()) }
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure74() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure75();
        Rc::new(UH2::UH2_0(9223372036854775808u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure73() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure74();
        Rc::new(UH2::UH2_0(4611686018427387904u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure72() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure73();
        Rc::new(UH2::UH2_0(6917529027641081856u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure71() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure72();
        Rc::new(UH2::UH2_0(1152921504606846976u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure70() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure71();
        Rc::new(UH2::UH2_0(15564440312192434176u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure69() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure70();
        Rc::new(UH2::UH2_0(11817445422220181504u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure68() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure69();
        Rc::new(UH2::UH2_0(5044031582654955520u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure67() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure68();
        Rc::new(UH2::UH2_0(6989586621679009792u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure66() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure67();
        Rc::new(UH2::UH2_0(16537217831704461312u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure65() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure66();
        Rc::new(UH2::UH2_0(11979575008805519360u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure64() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure65();
        Rc::new(UH2::UH2_0(14294425217273954304u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure63() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure64();
        Rc::new(UH2::UH2_0(2382404202878992384u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure62() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure63();
        Rc::new(UH2::UH2_0(6545982058383015936u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure61() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure62();
        Rc::new(UH2::UH2_0(10314369046585278464u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure60() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure61();
        Rc::new(UH2::UH2_0(4793518853382471680u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure59() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure60();
        Rc::new(UH2::UH2_0(3873377154515337216u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure58() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure59();
        Rc::new(UH2::UH2_0(645562859085889536u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure57() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure58();
        Rc::new(UH2::UH2_0(107593809847648256u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure56() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure57();
        Rc::new(UH2::UH2_0(3092389647259533312u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure55() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure56();
        Rc::new(UH2::UH2_0(9738770311398031360u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure54() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure55();
        Rc::new(UH2::UH2_0(16995415113324298240u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure53() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure54();
        Rc::new(UH2::UH2_0(8981483876790566912u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure52() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure53();
        Rc::new(UH2::UH2_0(13794743361938128896u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure51() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure52();
        Rc::new(UH2::UH2_0(2299123893656354816u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure50() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure51();
        Rc::new(UH2::UH2_0(3457644661227651072u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure49() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure50();
        Rc::new(UH2::UH2_0(576274110204608512u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure48() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure49();
        Rc::new(UH2::UH2_0(6244960376270618624u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure47() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure48();
        Rc::new(UH2::UH2_0(13338656111851470848u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure46() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure47();
        Rc::new(UH2::UH2_0(14520938734448279552u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure45() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure46();
        Rc::new(UH2::UH2_0(14717985838214414336u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure44() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure45();
        Rc::new(UH2::UH2_0(5527454985320660992u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure43() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure44();
        Rc::new(UH2::UH2_0(16293529225644736512u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure42() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure43();
        Rc::new(UH2::UH2_0(11938960241128898560u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure41() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure42();
        Rc::new(UH2::UH2_0(8138741398091333632u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure40() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure41();
        Rc::new(UH2::UH2_0(7505371590918406144u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure39() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure40();
        Rc::new(UH2::UH2_0(16623181993244360704u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure38() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure39();
        Rc::new(UH2::UH2_0(8919445023443910656u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure37() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure38();
        Rc::new(UH2::UH2_0(4561031516192243712u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure36() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure37();
        Rc::new(UH2::UH2_0(9983543956220149760u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure35() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure36();
        Rc::new(UH2::UH2_0(4738381338321616896u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure34() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure35();
        Rc::new(UH2::UH2_0(789730223053602816u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure33() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure34();
        Rc::new(UH2::UH2_0(131621703842267136u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure32() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure33();
        Rc::new(UH2::UH2_0(21936950640377856u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure31() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure32();
        Rc::new(UH2::UH2_0(3656158440062976u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure30() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure31();
        Rc::new(UH2::UH2_0(609359740010496u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure29() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure30();
        Rc::new(UH2::UH2_0(101559956668416u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure28() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure29();
        Rc::new(UH2::UH2_0(16926659444736u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure27() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure28();
        Rc::new(UH2::UH2_0(2821109907456u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure26() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure27();
        Rc::new(UH2::UH2_0(470184984576u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure25() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure26();
        Rc::new(UH2::UH2_0(78364164096u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure24() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure25();
        Rc::new(UH2::UH2_0(13060694016u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure23() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure24();
        Rc::new(UH2::UH2_0(2176782336u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure22() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure23();
        Rc::new(UH2::UH2_0(362797056u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure21() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure22();
        Rc::new(UH2::UH2_0(60466176u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure20() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure21();
        Rc::new(UH2::UH2_0(10077696u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure19() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure20();
        Rc::new(UH2::UH2_0(1679616u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure18() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure19();
        Rc::new(UH2::UH2_0(279936u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure17() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure18();
        Rc::new(UH2::UH2_0(46656u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure16() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure17();
        Rc::new(UH2::UH2_0(7776u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure15() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure16();
        Rc::new(UH2::UH2_0(1296u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure14() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure15();
        Rc::new(UH2::UH2_0(216u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure13() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure14();
        Rc::new(UH2::UH2_0(36u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure12() -> Rc<dyn Fn() -> Rc<UH2>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> Rc<UH2>> = Rc::new(move || -> Rc<UH2> {
        let mut v0: Rc<dyn Fn() -> Rc<UH2>> = closure13();
        Rc::new(UH2::UH2_0(6u64, v0.clone()))
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method68(mut v0: i8, mut v1: Rc<UH2>) -> US6 {
    loop {
        match &*v1 {
            UH2::UH2_0(v2, v3) => { // StreamCons
                let mut v2: u64 = v2.clone();
                let mut v3: Rc<dyn Fn() -> Rc<UH2>> = v3.clone();
                let mut v4: bool = v0 <= 0i8;
                if v4 {
                    return US6::US6_0(v2);
                } else {
                    let mut v6: i8 = v0 - 1i8;
                    let mut v7: Rc<UH2> = v3();
                    (v0, v1) = (v6, v7.clone());
                    continue;
                }
            }
            UH2::UH2_1 => { // StreamNil
                return US6::US6_1;
            }
            _ => unreachable!(),
        }
    }
}
fn method71(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method72(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method70(mut v0: i8, mut v1: u64, mut v2: u8, mut v3: u64) -> Rc<str> {
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    method13(v5.clone());
    method66(v5.clone());
    method15(v5.clone());
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v5.clone(), v6.clone());
    method16(v5.clone());
    method57(v5.clone());
    method15(v5.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v5.clone(), v7.clone());
    method16(v5.clone());
    method71(v5.clone());
    method15(v5.clone());
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v5.clone(), v38.clone());
    method16(v5.clone());
    method72(v5.clone());
    method15(v5.clone());
    let mut v65: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v5.clone(), v65.clone());
    method18(v5.clone());
    let mut v66: Rc<str> = v5.borrow().l0.clone();
    v66.clone()
}
fn method69(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u8, mut v11: u64) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0.clone();
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let mut v15: Rc<str> = method11(v12);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v7));
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v13));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let mut v23: Rc<str> = method70(v8, v9, v10, v11);
    let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
    method8(v24.clone())
}
fn method74(mut v0: i8, mut v1: u64, mut v2: u8) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method66(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v5.clone());
    method16(v4.clone());
    method57(v4.clone());
    method15(v4.clone());
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v6.clone());
    method16(v4.clone());
    method71(v4.clone());
    method15(v4.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v7.clone());
    method18(v4.clone());
    let mut v8: Rc<str> = v4.borrow().l0.clone();
    v8.clone()
}
fn method73(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u8) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method74(v8, v9, v10);
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method63(mut v0: i8, mut v1: Rc<UH0>, mut v2: u64) -> US5 {
    loop {
        let mut v3: bool = v0 < 0i8;
        if v3 {
            let mut v4: u64 = v2 + 1u64;
            let mut v6: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
            { let _ = spiral_trace_hold(&v6); };
            let mut v8: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v9, mut v10, mut v11, mut v12, mut v13, mut v14): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
            let mut v15: US0 = v13.borrow().l0.clone();
            let mut v20: i32 = match &v15 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
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
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v6); };
                let (mut v29, mut v30, mut v31, mut v32, mut v33, mut v34): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                let mut v35: Rc<str> = method3(v29.clone(), v30.clone(), v31.clone(), v32.clone(), v33.clone(), v34.clone());
                let mut v36: Rc<str> = method4();
                let mut v37: Rc<str> = method64(v29.clone(), v30.clone(), v31.clone(), v32.clone(), v33.clone(), v34.clone(), v35.clone(), v36.clone(), v0, v2, v4);
                { let _ = spiral_trace_hold(&v6); };
                let (mut v40, mut v41, mut v42, mut v43, mut v44, mut v45): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                let mut v46: i64 = v40.borrow().l0.clone();
                let mut v47: i64 = v46 + 1i64;
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
                US2::US2_0(v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone())
            };
            return US5::US5_0(v4, v1.clone());
        } else {
            match &*v1 {
                UH0::UH0_1(v73, v74) => { // Cons
                    let mut v73: u8 = v73.clone();
                    let mut v74: Rc<UH0> = v74.clone();
                    let mut v75: bool = v73 > 1u8;
                    if v75 {
                        let mut v76: u64 = 1u64;
                        let mut v77: Rc<dyn Fn() -> Rc<UH2>> = closure12();
                        let mut v78: Rc<UH2> = Rc::new(UH2::UH2_0(v76, v77.clone()));
                        let mut v79: US6 = method68(v0, v78.clone());
                        let mut v83: u64 = match &v79 {
                            US6::US6_1 => { // None
                                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
                            }
                            US6::US6_0(v80) => { // Some
                                let mut v80: u64 = v80.clone();
                                v80
                            }
                            _ => unreachable!(),
                        };
                        let mut v84: u8 = v73 - 1u8;
                        let mut v85: u64 = (v84 as u64);
                        let mut v86: u64 = v85 * v83;
                        let mut v88: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
                        { let _ = spiral_trace_hold(&v88); };
                        let mut v90: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v91, mut v92, mut v93, mut v94, mut v95, mut v96): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v90) };
                        let mut v97: US0 = v95.borrow().l0.clone();
                        let mut v102: i32 = match &v97 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
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
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v88); };
                            let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v90) };
                            let mut v117: Rc<str> = method3(v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone());
                            let mut v118: Rc<str> = method4();
                            let mut v119: Rc<str> = method69(v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v0, v2, v73, v86);
                            { let _ = spiral_trace_hold(&v88); };
                            let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v90) };
                            let mut v128: i64 = v122.borrow().l0.clone();
                            let mut v129: i64 = v128 + 1i64;
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
                            US2::US2_0(v122.clone(), v123.clone(), v124.clone(), v125.clone(), v126.clone(), v127.clone())
                        };
                        let mut v153: u64 = v2 + v86;
                        let mut v154: i8 = v0 - 1i8;
                        (v0, v1, v2) = (v154, v74.clone(), v153);
                        continue;
                    } else {
                        let mut v157: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
                        { let _ = spiral_trace_hold(&v157); };
                        let mut v159: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v160, mut v161, mut v162, mut v163, mut v164, mut v165): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v159) };
                        let mut v166: US0 = v164.borrow().l0.clone();
                        let mut v171: i32 = match &v166 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
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
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v157); };
                            let (mut v180, mut v181, mut v182, mut v183, mut v184, mut v185): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v159) };
                            let mut v186: Rc<str> = method3(v180.clone(), v181.clone(), v182.clone(), v183.clone(), v184.clone(), v185.clone());
                            let mut v187: Rc<str> = method4();
                            let mut v188: Rc<str> = method73(v180.clone(), v181.clone(), v182.clone(), v183.clone(), v184.clone(), v185.clone(), v186.clone(), v187.clone(), v0, v2, v73);
                            { let _ = spiral_trace_hold(&v157); };
                            let (mut v191, mut v192, mut v193, mut v194, mut v195, mut v196): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v159) };
                            let mut v197: i64 = v191.borrow().l0.clone();
                            let mut v198: i64 = v197 + 1i64;
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
                            US2::US2_0(v191.clone(), v192.clone(), v193.clone(), v194.clone(), v195.clone(), v196.clone())
                        };
                        let mut v222: i8 = v0 - 1i8;
                        (v0, v1, v2) = (v222, v74.clone(), v2);
                        continue;
                    }
                }
                UH0::UH0_0 => { // Nil
                    return US5::US5_1;
                }
                _ => unreachable!(),
            }
        }
    }
}
fn method75(mut v0: i8, mut v1: Rc<dyn Fn() -> Rc<UH1>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut0>>, mut v5: Rc<RefCell<Mut7>>, mut v6: i8) -> Rc<UH0> {
    let mut v7: bool = v6 < v0;
    if v7 {
        let mut v8: u8 = method53(v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone());
        let mut v9: i8 = v6 + 1i8;
        let mut v10: Rc<UH0> = method75(v0, v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v9);
        Rc::new(UH0::UH0_1(v8, v10.clone()))
    } else {
        { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) }
    }
}
fn method76(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>, mut v5: u64, mut v6: i8, mut v7: Rc<UH0>) -> u64 {
    loop {
        let mut v8: i8 = v6 + 1i8;
        let mut v9: bool = v6 < v8;
        if v9 {
            let mut v10: u8 = method53(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
            let mut v11: Rc<UH0> = Rc::new(UH0::UH0_1(v10, v7.clone()));
            return method52(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v11.clone(), v8);
        } else {
            let mut v13: u64 = 0u64;
            let mut v14: US5 = method63(v6, v7.clone(), v13);
            match &v14 {
                US5::US5_0(v15, v16) => { // Some
                    let mut v15: u64 = v15.clone();
                    let mut v16: Rc<UH0> = v16.clone();
                    let mut v17: bool = v15 <= v5;
                    if v17 {
                        return v15;
                    } else {
                        let mut v18: i8 = 0i8;
                        let mut v19: Rc<UH0> = method75(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v18);
                        (v0, v1, v2, v3, v4, v5, v6, v7) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v19.clone());
                        continue;
                    }
                }
                _ => {
                    let mut v22: i8 = 0i8;
                    let mut v23: Rc<UH0> = method75(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v22);
                    (v0, v1, v2, v3, v4, v5, v6, v7) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v23.clone());
                    continue;
                }
            }
        }
    }
}
fn method52(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>, mut v5: u64, mut v6: i8, mut v7: Rc<UH0>, mut v8: i8) -> u64 {
    loop {
        let mut v9: i8 = v6 + 1i8;
        let mut v10: bool = v8 < v9;
        if v10 {
            let mut v11: u8 = method53(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
            let mut v12: Rc<UH0> = Rc::new(UH0::UH0_1(v11, v7.clone()));
            let mut v13: i8 = v8 + 1i8;
            (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v12.clone(), v13);
            continue;
        } else {
            let mut v15: u64 = 0u64;
            let mut v16: US5 = method63(v6, v7.clone(), v15);
            match &v16 {
                US5::US5_0(v17, v18) => { // Some
                    let mut v17: u64 = v17.clone();
                    let mut v18: Rc<UH0> = v18.clone();
                    let mut v19: bool = v17 <= v5;
                    if v19 {
                        return v17;
                    } else {
                        let mut v20: i8 = 0i8;
                        let mut v21: Rc<UH0> = method75(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v20);
                        return method76(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v21.clone());
                    }
                }
                _ => {
                    let mut v24: i8 = 0i8;
                    let mut v25: Rc<UH0> = method75(v6, v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v24);
                    return method76(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v25.clone());
                }
            }
        }
    }
}
fn method77() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure7() -> Rc<dyn Fn(&mut SpiralNearVec<u8>, std::string::String, std::string::String, u64) -> u64> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut SpiralNearVec<u8>, std::string::String, std::string::String, u64) -> u64> = Rc::new(move |mut v0: &mut SpiralNearVec<u8>, mut v1: std::string::String, mut v2: std::string::String, mut v3: u64| -> u64 {
        let mut v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v5); };
        let mut v7: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v8, mut v9, mut v10, mut v11, mut v12, mut v13): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v14: US0 = US0::US0_2;
        v12.borrow_mut().l0 = v14.clone();
        let mut v59: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::random_seed(); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        let mut v119: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::epoch_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v144: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v157: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_timestamp(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v205: u128 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::account_balance().as_yoctonear(); #[cfg(not(target_arch = "wasm32"))] let v = 1u128; v };
        let mut v265: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::signer_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v290: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::predecessor_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v339: &SpiralNearVec<u8> = &*v0;
        let mut v364: Vec<u8> = (v339).iter().cloned().collect::<std::vec::Vec<_>>();
        let mut v412: _ = (v119).to_le_bytes().to_vec();
        let mut v437: Vec<u8> = (v412).clone();
        let mut v441: _ = (v144).to_le_bytes().to_vec();
        let mut v442: Vec<u8> = (v441).clone();
        let mut v443: _ = (v157).to_le_bytes().to_vec();
        let mut v444: Vec<u8> = (v443).clone();
        let mut v489: u128 = (v205.clone());
        let mut v514: _ = (v489).to_le_bytes().to_vec();
        let mut v518: Vec<u8> = (v514).clone();
        let mut v528: &[u8] = (v265).as_bytes();
        let mut v541: Vec<u8> = (v528).to_vec();
        let mut v545: &[u8] = (v290).as_bytes();
        let mut v546: Vec<u8> = (v545).to_vec();
        let mut v556: Vec<u8> = (v2).as_bytes().to_vec();
        let mut v560: Vec<u8> = (v1).as_bytes().to_vec();
        let mut v561: Rc<RefCell<Vec<Vec<u8>>>> = Rc::new(RefCell::new(vec![v59.clone(), v364.clone(), v437.clone(), v442.clone(), v444.clone(), v518.clone(), v541.clone(), v546.clone(), v556.clone(), v560.clone()]));
        let mut v606: Vec<Vec<u8>> = (v561).borrow().clone();
        let mut v631: Vec<u8> = (v606).concat();
        let mut v644: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::keccak512(&(v631.clone())); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        { (v0).extend((v644).clone()); };
        let mut v648: u32 = ((v0).len() as u32);
        let mut v649: i32 = (v648 as i32);
        let mut v650: usize = ((100i32) as usize);
        let mut v651: i32 = (v650 as i32);
        let mut v652: i32 = v649 - v651;
        let mut v653: bool = v652 > 0i32;
        if v653 {
            let mut v655: Vec<u8> = v0.drain(0..v652 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v658, mut v659, mut v660, mut v661, mut v662, mut v663): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v664: US0 = v662.borrow().l0.clone();
            let mut v669: i32 = match &v664 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v670: bool = v660.borrow().l0.clone();
            let mut v671: bool = v670 == false;
            let mut v673: bool = if v671 {
                false
            } else {
                let mut v672: bool = 20i32 >= v669;
                v672
            };
            let mut v674: bool = v673 == false;
            let mut v720: US2 = if v674 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v5); };
                let (mut v678, mut v679, mut v680, mut v681, mut v682, mut v683): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v684: Rc<str> = method3(v678.clone(), v679.clone(), v680.clone(), v681.clone(), v682.clone(), v683.clone());
                let mut v685: Rc<str> = method4();
                let mut v686: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v655)).s() });
                let mut v687: Rc<str> = method7(v678.clone(), v679.clone(), v680.clone(), v681.clone(), v682.clone(), v683.clone(), v684.clone(), v685.clone(), v652, v686.clone());
                { let _ = spiral_trace_hold(&v5); };
                let (mut v690, mut v691, mut v692, mut v693, mut v694, mut v695): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v696: i64 = v690.borrow().l0.clone();
                let mut v697: i64 = v696 + 1i64;
                v690.borrow_mut().l0 = v697;
                let mut v698: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v699: bool = cfg!(target_arch = "wasm32");
                if v699 {
                    let mut v700: Rc<str> = v693.borrow().l0.clone();
                    let mut v701: bool = v700.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v709: Rc<str> = if v701 {
                        v687.clone()
                    } else {
                        let mut v702: bool = v687.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v702 {
                            let mut v703: Rc<str> = v693.borrow().l0.clone();
                            v703.clone()
                        } else {
                            let mut v704: Rc<str> = v693.borrow().l0.clone();
                            let mut v705: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v706: Rc<str> = Rc::<str>::from(format!("{}{}", v704, v705));
                            let mut v707: Rc<str> = Rc::<str>::from(format!("{}{}", v706, v687));
                            v707.clone()
                        }
                    };
                    let mut v711: i32 = ((v709.chars().count() + 14999) / 15000) as i32;
                    let mut v712: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v713: bool = v687 != v712 ;
                    let mut v715: bool = if v713 {
                        let mut v714: bool = v711 <= 1i32;
                        v714
                    } else {
                        false
                    };
                    if v715 {
                        v693.borrow_mut().l0 = v709.clone();
                        ()
                    } else {
                        v693.borrow_mut().l0 = v712.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v709); };
                        ()
                    }
                } else {
                    println!("{}", v687);
                    ()
                };
                let mut v718: Rc<dyn Fn(Rc<str>) -> ()> = v691.borrow().l0.clone();
                v718(v687.clone());
                US2::US2_0(v690.clone(), v691.clone(), v692.clone(), v693.clone(), v694.clone(), v695.clone())
            };
            ()
        };
        let mut v721: Rc<dyn Fn() -> ()> = method19();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v724, mut v725, mut v726, mut v727, mut v728, mut v729): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v730: US0 = v728.borrow().l0.clone();
        let mut v735: i32 = match &v730 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v736: bool = v726.borrow().l0.clone();
        let mut v737: bool = v736 == false;
        let mut v739: bool = if v737 {
            false
        } else {
            let mut v738: bool = 20i32 >= v735;
            v738
        };
        let mut v740: bool = v739 == false;
        let mut v784: US2 = if v740 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v744, mut v745, mut v746, mut v747, mut v748, mut v749): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v750: Rc<str> = method3(v744.clone(), v745.clone(), v746.clone(), v747.clone(), v748.clone(), v749.clone());
            let mut v751: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v754, mut v755, mut v756, mut v757, mut v758, mut v759): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v760: i64 = v754.borrow().l0.clone();
            let mut v761: i64 = v760 + 1i64;
            v754.borrow_mut().l0 = v761;
            let mut v762: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v763: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v764: bool = cfg!(target_arch = "wasm32");
            if v764 {
                let mut v765: Rc<str> = v757.borrow().l0.clone();
                let mut v766: bool = v765.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v774: Rc<str> = if v766 {
                    v762.clone()
                } else {
                    let mut v767: bool = v762.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v767 {
                        let mut v768: Rc<str> = v757.borrow().l0.clone();
                        v768.clone()
                    } else {
                        let mut v769: Rc<str> = v757.borrow().l0.clone();
                        let mut v770: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v771: Rc<str> = Rc::<str>::from(format!("{}{}", v769, v770));
                        let mut v772: Rc<str> = Rc::<str>::from(format!("{}{}", v771, v762));
                        v772.clone()
                    }
                };
                let mut v776: i32 = ((v774.chars().count() + 14999) / 15000) as i32;
                let mut v777: bool = v762 != v762 ;
                let mut v779: bool = if v777 {
                    let mut v778: bool = v776 <= 1i32;
                    v778
                } else {
                    false
                };
                if v779 {
                    v757.borrow_mut().l0 = v774.clone();
                    ()
                } else {
                    v757.borrow_mut().l0 = v762.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v774); };
                    ()
                }
            } else {
                println!("{}", v762);
                ()
            };
            let mut v782: Rc<dyn Fn(Rc<str>) -> ()> = v755.borrow().l0.clone();
            v782(v762.clone());
            US2::US2_0(v754.clone(), v755.clone(), v756.clone(), v757.clone(), v758.clone(), v759.clone())
        };
        let mut v829: Vec<u8> = method20(v644.clone());
        let mut v830: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v829));
        let mut v862: Rc<Vec<u8>> = Rc::new((v830).borrow().clone());
        let mut v996: i32 = (v862).len() as i32;
        let mut v997: i32 = v996 - 1i32;
        let mut v998: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v999: Rc<UH0> = method21(v862.clone(), v997, v998.clone());
        let mut v1003: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v1004: Rc<UH1> = method22(v999.clone(), v1003.clone());
        let mut v1005: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v1006: Rc<UH1> = method23(v1004.clone(), v1005.clone());
        let mut v1007: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1008: Rc<UH0> = method24(v1006.clone(), v1007.clone());
        { let _ = spiral_trace_hold(&v5); };
        let (mut v1011, mut v1012, mut v1013, mut v1014, mut v1015, mut v1016): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v1017: US0 = v1015.borrow().l0.clone();
        let mut v1022: i32 = match &v1017 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v1023: bool = v1013.borrow().l0.clone();
        let mut v1024: bool = v1023 == false;
        let mut v1026: bool = if v1024 {
            false
        } else {
            let mut v1025: bool = 20i32 >= v1022;
            v1025
        };
        let mut v1027: bool = v1026 == false;
        let mut v1247: US2 = if v1027 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1031, mut v1032, mut v1033, mut v1034, mut v1035, mut v1036): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1037: Rc<str> = method3(v1031.clone(), v1032.clone(), v1033.clone(), v1034.clone(), v1035.clone(), v1036.clone());
            let mut v1038: Rc<str> = method4();
            let mut v1045: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<u128>") } } (&&W(&v205)).s() });
            let mut v1050: std::string::String = v265.to_string();
            let mut v1052: std::string::String = v290.to_string();
            let mut v1053: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v59)).s() });
            let mut v1060: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<&mut SpiralNearVec<u8>>") } } (&&W(&v0)).s() });
            let mut v1108: usize = ((v631).len() as usize);
            let mut v1124: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v631)).s() });
            let mut v1125: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v644)).s() });
            let mut v1137: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
            let mut v1138: i32 = 0i32;
            let mut v1139: i32 = method25(v1137.clone(), v1008.clone(), v1138);
            let mut v1140: Rc<Vec<u8>> = Rc::new(v1137.borrow().clone());
            let mut v1196: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v1140).as_ref().clone()));
            let mut v1209: Vec<u8> = (v1196).borrow().clone();
            let mut v1213: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1209)).s() });
            let mut v1214: Rc<str> = method26(v1031.clone(), v1032.clone(), v1033.clone(), v1034.clone(), v1035.clone(), v1036.clone(), v1037.clone(), v1038.clone(), v3, v1.clone(), v2.clone(), v157, v144, v119, v1045.clone(), v1050.clone(), v1052.clone(), v1053.clone(), v1060.clone(), v1108.clone(), v1124.clone(), v1125.clone(), v1213.clone());
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1217, mut v1218, mut v1219, mut v1220, mut v1221, mut v1222): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1223: i64 = v1217.borrow().l0.clone();
            let mut v1224: i64 = v1223 + 1i64;
            v1217.borrow_mut().l0 = v1224;
            let mut v1225: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v1226: bool = cfg!(target_arch = "wasm32");
            if v1226 {
                let mut v1227: Rc<str> = v1220.borrow().l0.clone();
                let mut v1228: bool = v1227.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1236: Rc<str> = if v1228 {
                    v1214.clone()
                } else {
                    let mut v1229: bool = v1214.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1229 {
                        let mut v1230: Rc<str> = v1220.borrow().l0.clone();
                        v1230.clone()
                    } else {
                        let mut v1231: Rc<str> = v1220.borrow().l0.clone();
                        let mut v1232: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1233: Rc<str> = Rc::<str>::from(format!("{}{}", v1231, v1232));
                        let mut v1234: Rc<str> = Rc::<str>::from(format!("{}{}", v1233, v1214));
                        v1234.clone()
                    }
                };
                let mut v1238: i32 = ((v1236.chars().count() + 14999) / 15000) as i32;
                let mut v1239: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1240: bool = v1214 != v1239 ;
                let mut v1242: bool = if v1240 {
                    let mut v1241: bool = v1238 <= 1i32;
                    v1241
                } else {
                    false
                };
                if v1242 {
                    v1220.borrow_mut().l0 = v1236.clone();
                    ()
                } else {
                    v1220.borrow_mut().l0 = v1239.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1236); };
                    ()
                }
            } else {
                println!("{}", v1214);
                ()
            };
            let mut v1245: Rc<dyn Fn(Rc<str>) -> ()> = v1218.borrow().l0.clone();
            v1245(v1214.clone());
            US2::US2_0(v1217.clone(), v1218.clone(), v1219.clone(), v1220.clone(), v1221.clone(), v1222.clone())
        };
        let mut v1248: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1249: Rc<UH0> = method43(v1008.clone(), v1248.clone());
        let mut v1250: Rc<UH0> = method44(v1008.clone(), v1249.clone());
        let mut v1251: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v1252: Rc<UH1> = method22(v1250.clone(), v1251.clone());
        let mut v1253: Rc<dyn Fn() -> Rc<UH1>> = closure10(v1252.clone());
        let mut v1254: Rc<dyn Fn() -> Rc<UH1>> = method45(v1252.clone(), v1253.clone());
        let mut v1255: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i64 }));
        let mut v1256: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
        let mut v1257: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: -1i64 }));
        let mut v1258: US4 = US4::US4_1;
        let mut v1259: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: v1258.clone() }));
        let mut v1260: bool = v3 == 1u64;
        let mut v1264: i8 = if v1260 {
            1i8
        } else {
            let mut v1261: i8 = 0i8;
            let mut v1262: u64 = 1u64;
            method46(v3, v1261, v1262)
        };
        let mut v1265: i8 = v1264 - 1i8;
        let mut v1266: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1267: i8 = 0i8;
        let mut v1268: u64 = method52(v1254.clone(), v1255.clone(), v1256.clone(), v1257.clone(), v1259.clone(), v3, v1265, v1266.clone(), v1267);
        let mut v1269: Rc<dyn Fn() -> ()> = method77();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v1272, mut v1273, mut v1274, mut v1275, mut v1276, mut v1277): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v1278: US0 = v1276.borrow().l0.clone();
        let mut v1283: i32 = match &v1278 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v1284: bool = v1274.borrow().l0.clone();
        let mut v1285: bool = v1284 == false;
        let mut v1287: bool = if v1285 {
            false
        } else {
            let mut v1286: bool = 20i32 >= v1283;
            v1286
        };
        let mut v1288: bool = v1287 == false;
        let mut v1332: US2 = if v1288 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1292, mut v1293, mut v1294, mut v1295, mut v1296, mut v1297): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1298: Rc<str> = method3(v1292.clone(), v1293.clone(), v1294.clone(), v1295.clone(), v1296.clone(), v1297.clone());
            let mut v1299: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1302, mut v1303, mut v1304, mut v1305, mut v1306, mut v1307): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1308: i64 = v1302.borrow().l0.clone();
            let mut v1309: i64 = v1308 + 1i64;
            v1302.borrow_mut().l0 = v1309;
            let mut v1310: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1311: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v1312: bool = cfg!(target_arch = "wasm32");
            if v1312 {
                let mut v1313: Rc<str> = v1305.borrow().l0.clone();
                let mut v1314: bool = v1313.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1322: Rc<str> = if v1314 {
                    v1310.clone()
                } else {
                    let mut v1315: bool = v1310.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1315 {
                        let mut v1316: Rc<str> = v1305.borrow().l0.clone();
                        v1316.clone()
                    } else {
                        let mut v1317: Rc<str> = v1305.borrow().l0.clone();
                        let mut v1318: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1319: Rc<str> = Rc::<str>::from(format!("{}{}", v1317, v1318));
                        let mut v1320: Rc<str> = Rc::<str>::from(format!("{}{}", v1319, v1310));
                        v1320.clone()
                    }
                };
                let mut v1324: i32 = ((v1322.chars().count() + 14999) / 15000) as i32;
                let mut v1325: bool = v1310 != v1310 ;
                let mut v1327: bool = if v1325 {
                    let mut v1326: bool = v1324 <= 1i32;
                    v1326
                } else {
                    false
                };
                if v1327 {
                    v1305.borrow_mut().l0 = v1322.clone();
                    ()
                } else {
                    v1305.borrow_mut().l0 = v1310.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1322); };
                    ()
                }
            } else {
                println!("{}", v1310);
                ()
            };
            let mut v1330: Rc<dyn Fn(Rc<str>) -> ()> = v1303.borrow().l0.clone();
            v1330(v1310.clone());
            US2::US2_0(v1302.clone(), v1303.clone(), v1304.clone(), v1305.clone(), v1306.clone(), v1307.clone())
        };
        v1268
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method78(mut v0: Rc<UH0>, mut v1: i8) -> i8 {
    loop {
        match &*v0 {
            UH0::UH0_1(v2, v3) => { // Cons
                let mut v2: u8 = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: i8 = v1 + 1i8;
                (v0, v1) = (v3.clone(), v4);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v1;
            }
            _ => unreachable!(),
        }
    }
}
fn method80(mut v0: u64, mut v1: Rc<str>, mut v2: Rc<str>) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method28(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v5.clone());
    method16(v4.clone());
    method42(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v1.clone());
    method16(v4.clone());
    method67(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v2.clone());
    method18(v4.clone());
    let mut v6: Rc<str> = v4.borrow().l0.clone();
    v6.clone()
}
fn method79(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.roll_within_bounds"); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v28));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v33));
    let mut v35: Rc<str> = method80(v8, v9.clone(), v10.clone());
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    method8(v36.clone())
}
fn method81() -> Rc<dyn Fn() -> ()> {
    closure6()
}
fn closure76() -> Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64, Vec<u8>) -> Option<u64>> = Rc::new(move |mut v0: u64, mut v1: Vec<u8>| -> Option<u64> {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v3); };
        let mut v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v12: US0 = US0::US0_2;
        v10.borrow_mut().l0 = v12.clone();
        let mut v13: Vec<u8> = method20(v1.clone());
        let mut v14: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v13));
        let mut v15: Rc<Vec<u8>> = Rc::new((v14).borrow().clone());
        let mut v16: i32 = (v15).len() as i32;
        let mut v17: i32 = v16 - 1i32;
        let mut v18: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v19: Rc<UH0> = method21(v15.clone(), v17, v18.clone());
        let mut v20: i8 = 0i8;
        let mut v21: i8 = method78(v19.clone(), v20);
        let mut v22: i8 = v21 - 1i8;
        let mut v23: u64 = 0u64;
        let mut v24: US5 = method63(v22, v19.clone(), v23);
        let mut v34: US6 = match &v24 {
            US5::US5_0(v25, v26) => { // Some
                let mut v25: u64 = v25.clone();
                let mut v26: Rc<UH0> = v26.clone();
                let mut v27: bool = v25 >= 1u64;
                let mut v29: bool = if v27 {
                    let mut v28: bool = v25 <= v0;
                    v28
                } else {
                    false
                };
                if v29 {
                    US6::US6_0(v25)
                } else {
                    US6::US6_1
                }
            }
            _ => {
                US6::US6_1
            }
        };
        let mut v69: Option<u64> = match &v34 {
            US6::US6_1 => { // None
                let mut v64: Option<u64> = None;
                v64.clone()
            }
            US6::US6_0(v35) => { // Some
                let mut v35: u64 = v35.clone();
                let mut v52: Option<u64> = Some(v35.clone());
                v52.clone()
            }
            _ => unreachable!(),
        };
        { let _ = spiral_trace_hold(&v3); };
        let (mut v72, mut v73, mut v74, mut v75, mut v76, mut v77): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v78: US0 = v76.borrow().l0.clone();
        let mut v83: i32 = match &v78 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v84: bool = v74.borrow().l0.clone();
        let mut v85: bool = v84 == false;
        let mut v87: bool = if v85 {
            false
        } else {
            let mut v86: bool = 20i32 >= v83;
            v86
        };
        let mut v88: bool = v87 == false;
        let mut v150: US2 = if v88 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v92, mut v93, mut v94, mut v95, mut v96, mut v97): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v98: Rc<str> = method3(v92.clone(), v93.clone(), v94.clone(), v95.clone(), v96.clone(), v97.clone());
            let mut v99: Rc<str> = method4();
            let mut v100: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1)).s() });
            let mut v107: Rc<str> = Rc::<str>::from(match &v69 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v117: Rc<str> = method79(v92.clone(), v93.clone(), v94.clone(), v95.clone(), v96.clone(), v97.clone(), v98.clone(), v99.clone(), v0, v100.clone(), v107.clone());
            { let _ = spiral_trace_hold(&v3); };
            let (mut v120, mut v121, mut v122, mut v123, mut v124, mut v125): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v126: i64 = v120.borrow().l0.clone();
            let mut v127: i64 = v126 + 1i64;
            v120.borrow_mut().l0 = v127;
            let mut v128: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v129: bool = cfg!(target_arch = "wasm32");
            if v129 {
                let mut v130: Rc<str> = v123.borrow().l0.clone();
                let mut v131: bool = v130.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v139: Rc<str> = if v131 {
                    v117.clone()
                } else {
                    let mut v132: bool = v117.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v132 {
                        let mut v133: Rc<str> = v123.borrow().l0.clone();
                        v133.clone()
                    } else {
                        let mut v134: Rc<str> = v123.borrow().l0.clone();
                        let mut v135: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v136: Rc<str> = Rc::<str>::from(format!("{}{}", v134, v135));
                        let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v117));
                        v137.clone()
                    }
                };
                let mut v141: i32 = ((v139.chars().count() + 14999) / 15000) as i32;
                let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v143: bool = v117 != v142 ;
                let mut v145: bool = if v143 {
                    let mut v144: bool = v141 <= 1i32;
                    v144
                } else {
                    false
                };
                if v145 {
                    v123.borrow_mut().l0 = v139.clone();
                    ()
                } else {
                    v123.borrow_mut().l0 = v142.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v139); };
                    ()
                }
            } else {
                println!("{}", v117);
                ()
            };
            let mut v148: Rc<dyn Fn(Rc<str>) -> ()> = v121.borrow().l0.clone();
            v148(v117.clone());
            US2::US2_0(v120.clone(), v121.clone(), v122.clone(), v123.clone(), v124.clone(), v125.clone())
        };
        let mut v151: Rc<dyn Fn() -> ()> = method81();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v154, mut v155, mut v156, mut v157, mut v158, mut v159): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v160: US0 = v158.borrow().l0.clone();
        let mut v165: i32 = match &v160 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v166: bool = v156.borrow().l0.clone();
        let mut v167: bool = v166 == false;
        let mut v169: bool = if v167 {
            false
        } else {
            let mut v168: bool = 20i32 >= v165;
            v168
        };
        let mut v170: bool = v169 == false;
        let mut v214: US2 = if v170 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v174, mut v175, mut v176, mut v177, mut v178, mut v179): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v180: Rc<str> = method3(v174.clone(), v175.clone(), v176.clone(), v177.clone(), v178.clone(), v179.clone());
            let mut v181: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v184, mut v185, mut v186, mut v187, mut v188, mut v189): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v190: i64 = v184.borrow().l0.clone();
            let mut v191: i64 = v190 + 1i64;
            v184.borrow_mut().l0 = v191;
            let mut v192: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v193: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v194: bool = cfg!(target_arch = "wasm32");
            if v194 {
                let mut v195: Rc<str> = v187.borrow().l0.clone();
                let mut v196: bool = v195.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v204: Rc<str> = if v196 {
                    v192.clone()
                } else {
                    let mut v197: bool = v192.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v197 {
                        let mut v198: Rc<str> = v187.borrow().l0.clone();
                        v198.clone()
                    } else {
                        let mut v199: Rc<str> = v187.borrow().l0.clone();
                        let mut v200: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v201: Rc<str> = Rc::<str>::from(format!("{}{}", v199, v200));
                        let mut v202: Rc<str> = Rc::<str>::from(format!("{}{}", v201, v192));
                        v202.clone()
                    }
                };
                let mut v206: i32 = ((v204.chars().count() + 14999) / 15000) as i32;
                let mut v207: bool = v192 != v192 ;
                let mut v209: bool = if v207 {
                    let mut v208: bool = v206 <= 1i32;
                    v208
                } else {
                    false
                };
                if v209 {
                    v187.borrow_mut().l0 = v204.clone();
                    ()
                } else {
                    v187.borrow_mut().l0 = v192.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v204); };
                    ()
                }
            } else {
                println!("{}", v192);
                ()
            };
            let mut v212: Rc<dyn Fn(Rc<str>) -> ()> = v185.borrow().l0.clone();
            v212(v192.clone());
            US2::US2_0(v184.clone(), v185.clone(), v186.clone(), v187.clone(), v188.clone(), v189.clone())
        };
        v69.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
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
