#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
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
        let mut v31: i32 = v30.wrapping_neg();
        let mut v32: i32 = v31.wrapping_add(v26);
        let mut v33: i32 = v32.wrapping_sub(1i32);
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
        US1::US1_1 => { // None
            v0.clone()
        }
        US1::US1_0(v52) => { // Some
            let mut v52: US0 = v52.clone();
            v52.clone()
        }
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
        let mut v54: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v54); };
        let mut v143: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v144, mut v145, mut v146, mut v147, mut v148, mut v149): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v143) };
        let mut v211: US0 = US0::US0_2;
        v148.borrow_mut().l0 = v211.clone();
        let mut v261: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
        let mut v262: &[u8] = { let owned: Rc<str> = (v261).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v334: SpiralNearVec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::store::vec::Vector::new(v262); #[cfg(not(target_arch = "wasm32"))] let v = SpiralNearVec(<std::vec::Vec<u8>>::new()); v };
        (2u32, v334)
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v1037: u64 = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; h * 3600 + m * 60 + s };
    let mut v1038: u64 = v1037.wrapping_div(3600u64);
    let mut v1039: bool = v1038 < 10u64;
    let mut v1042: Rc<str> = if v1039 {
        let mut v1040: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1040.clone()
    } else {
        let mut v1041: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1041.clone()
    };
    let mut v1060: Rc<str> = Rc::<str>::from(format!("{:?}", v1038));
    let mut v1065: Rc<str> = Rc::<str>::from(format!("{}{}", v1042, v1060));
    let mut v1076: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
    let mut v1077: Rc<str> = Rc::<str>::from(format!("{}{}", v1065, v1076));
    let mut v1082: u64 = v1037.wrapping_div(60u64);
    let mut v1083: u64 = v1082.wrapping_rem(60u64);
    let mut v1084: bool = v1083 < 10u64;
    let mut v1087: Rc<str> = if v1084 {
        let mut v1085: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1085.clone()
    } else {
        let mut v1086: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1086.clone()
    };
    let mut v1088: Rc<str> = Rc::<str>::from(format!("{:?}", v1083));
    let mut v1089: Rc<str> = Rc::<str>::from(format!("{}{}", v1087, v1088));
    let mut v1090: Rc<str> = Rc::<str>::from(format!("{}{}", v1077, v1089));
    let mut v1091: Rc<str> = Rc::<str>::from(format!("{}{}", v1090, v1076));
    let mut v1092: u64 = v1037.wrapping_rem(60u64);
    let mut v1093: bool = v1092 < 10u64;
    let mut v1096: Rc<str> = if v1093 {
        let mut v1094: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1094.clone()
    } else {
        let mut v1095: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1095.clone()
    };
    let mut v1097: Rc<str> = Rc::<str>::from(format!("{:?}", v1092));
    let mut v1098: Rc<str> = Rc::<str>::from(format!("{}{}", v1096, v1097));
    let mut v1099: Rc<str> = Rc::<str>::from(format!("{}{}", v1091, v1098));
    v1099.clone()
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
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v2.clone(), v20.clone());
    let mut v25: Rc<str> = v2.borrow().l0.clone();
    v25.clone()
}
fn method4() -> Rc<str> {
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let mut v11: u8 = v10.clone().as_bytes()[0i32 as usize];
    let mut v12: Rc<str> = method5(v11);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v12));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v19));
    v23.clone()
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
    let mut v12: Rc<str> = string_slice(&v0.clone(), v3 as i64, v4 as i64);
    let mut v16: i32 = (v12.clone().len() as i32);
    let mut v17: i32 = method10(v12.clone(), v16);
    let mut v25: Rc<str> = string_slice(&v12.clone(), 0i32 as i64, v17 as i64);
    v25.clone()
}
fn method11(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v20.clone());
    let mut v25: Rc<str> = v2.borrow().l0.clone();
    v25.clone()
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
    let mut v96: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v3.clone(), v96.clone());
    method16(v3.clone());
    method17(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method18(v3.clone());
    let mut v176: Rc<str> = v3.borrow().l0.clone();
    v176.clone()
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
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v45));
    let mut v51: Rc<str> = method12(v8, v9.clone());
    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v51));
    method8(v52.clone())
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
        let mut v63: u32 = ((v0).len() as u32);
        let mut v284: i32 = (v63 as i32);
        let mut v423: usize = ((100i32) as usize);
        let mut v563: i32 = (v423 as i32);
        let mut v568: i32 = v284.wrapping_sub(v563);
        let mut v569: bool = v568 > 0i32;
        if v569 {
            let mut v571: Vec<u8> = v0.drain(0..v568 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v574, mut v575, mut v576, mut v577, mut v578, mut v579): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v580: US0 = v578.borrow().l0.clone();
            let mut v585: i32 = match &v580 {
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
            };
            let mut v586: bool = v576.borrow().l0.clone();
            let mut v587: bool = v586 == false;
            let mut v589: bool = if v587 {
                false
            } else {
                let mut v588: bool = 20i32 >= v585;
                v588
            };
            let mut v590: bool = v589 == false;
            let mut v674: US2 = if v590 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v3); };
                let (mut v594, mut v595, mut v596, mut v597, mut v598, mut v599): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v600: Rc<str> = method3(v594.clone(), v595.clone(), v596.clone(), v597.clone(), v598.clone(), v599.clone());
                let mut v601: Rc<str> = method4();
                let mut v608: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v571)).s() });
                let mut v613: Rc<str> = method7(v594.clone(), v595.clone(), v596.clone(), v597.clone(), v598.clone(), v599.clone(), v600.clone(), v601.clone(), v568, v608.clone());
                { let _ = spiral_trace_hold(&v3); };
                let (mut v616, mut v617, mut v618, mut v619, mut v620, mut v621): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v622: i64 = v616.borrow().l0.clone();
                let mut v623: i64 = v622.wrapping_add(1i64);
                v616.borrow_mut().l0 = v623;
                let mut v624: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v625: bool = cfg!(target_arch = "wasm32");
                if v625 {
                    let mut v626: Rc<str> = v619.borrow().l0.clone();
                    let mut v627: bool = v626.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v649: Rc<str> = if v627 {
                        v613.clone()
                    } else {
                        let mut v628: bool = v613.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v628 {
                            let mut v629: Rc<str> = v619.borrow().l0.clone();
                            v629.clone()
                        } else {
                            let mut v630: Rc<str> = v619.borrow().l0.clone();
                            let mut v641: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v642: Rc<str> = Rc::<str>::from(format!("{}{}", v630, v641));
                            let mut v647: Rc<str> = Rc::<str>::from(format!("{}{}", v642, v613));
                            v647.clone()
                        }
                    };
                    let mut v651: i32 = ((v649.chars().count() + 14999) / 15000) as i32;
                    let mut v662: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v663: bool = v613 != v662 ;
                    let mut v669: bool = if v663 {
                        let mut v668: bool = v651 <= 1i32;
                        v668
                    } else {
                        false
                    };
                    if v669 {
                        v619.borrow_mut().l0 = v649.clone();
                        ()
                    } else {
                        v619.borrow_mut().l0 = v662.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v649); };
                        ()
                    }
                } else {
                    println!("{}", v613);
                    ()
                };
                let mut v672: Rc<dyn Fn(Rc<str>) -> ()> = v617.borrow().l0.clone();
                v672(v613.clone());
                US2::US2_0(v616.clone(), v617.clone(), v618.clone(), v619.clone(), v620.clone(), v621.clone())
            };
            ()
        };
        let mut v697: Rc<dyn Fn() -> ()> = method19();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v700, mut v701, mut v702, mut v703, mut v704, mut v705): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v706: US0 = v704.borrow().l0.clone();
        let mut v711: i32 = match &v706 {
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
        };
        let mut v712: bool = v702.borrow().l0.clone();
        let mut v713: bool = v712 == false;
        let mut v715: bool = if v713 {
            false
        } else {
            let mut v714: bool = 20i32 >= v711;
            v714
        };
        let mut v716: bool = v715 == false;
        let mut v760: US2 = if v716 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v720, mut v721, mut v722, mut v723, mut v724, mut v725): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v726: Rc<str> = method3(v720.clone(), v721.clone(), v722.clone(), v723.clone(), v724.clone(), v725.clone());
            let mut v727: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v730, mut v731, mut v732, mut v733, mut v734, mut v735): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v736: i64 = v730.borrow().l0.clone();
            let mut v737: i64 = v736.wrapping_add(1i64);
            v730.borrow_mut().l0 = v737;
            let mut v738: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v739: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v740: bool = cfg!(target_arch = "wasm32");
            if v740 {
                let mut v741: Rc<str> = v733.borrow().l0.clone();
                let mut v742: bool = v741.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v750: Rc<str> = if v742 {
                    v738.clone()
                } else {
                    let mut v743: bool = v738.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v743 {
                        let mut v744: Rc<str> = v733.borrow().l0.clone();
                        v744.clone()
                    } else {
                        let mut v745: Rc<str> = v733.borrow().l0.clone();
                        let mut v746: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v747: Rc<str> = Rc::<str>::from(format!("{}{}", v745, v746));
                        let mut v748: Rc<str> = Rc::<str>::from(format!("{}{}", v747, v738));
                        v748.clone()
                    }
                };
                let mut v752: i32 = ((v750.chars().count() + 14999) / 15000) as i32;
                let mut v753: bool = v738 != v738 ;
                let mut v755: bool = if v753 {
                    let mut v754: bool = v752 <= 1i32;
                    v754
                } else {
                    false
                };
                if v755 {
                    v733.borrow_mut().l0 = v750.clone();
                    ()
                } else {
                    v733.borrow_mut().l0 = v738.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v750); };
                    ()
                }
            } else {
                println!("{}", v738);
                ()
            };
            let mut v758: Rc<dyn Fn(Rc<str>) -> ()> = v731.borrow().l0.clone();
            v758(v738.clone());
            US2::US2_0(v730.clone(), v731.clone(), v732.clone(), v733.clone(), v734.clone(), v735.clone())
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
            let mut v5: i32 = v1.wrapping_sub(1i32);
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
            let mut v2: u8 = *v2;
            let mut v3: Rc<UH0> = v3.clone();
            let mut v4: Rc<UH1> = method22(v3.clone(), v1.clone());
            let mut v5: Rc<dyn Fn() -> Rc<UH1>> = closure8(v4.clone());
            Rc::new(UH1::UH1_0(v2, v5.clone()))
        }
        UH0::UH0_0 => { // Nil
            v1.clone()
        }
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
            let mut v2: u8 = *v2;
            let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
            let mut v4: Rc<UH1> = v3();
            let mut v5: Rc<UH1> = method23(v4.clone(), v1.clone());
            let mut v6: i64 = (v2 as i64);
            let mut v7: i64 = v6.wrapping_sub(1i64);
            let mut v8: i64 = v7.wrapping_add(6i64);
            let mut v9: i64 = v8.wrapping_rem(6i64);
            let mut v10: i64 = v9.wrapping_add(1i64);
            let mut v11: u8 = (v10 as u8);
            let mut v12: Rc<dyn Fn() -> Rc<UH1>> = closure9(v5.clone());
            Rc::new(UH1::UH1_0(v11, v12.clone()))
        }
        UH1::UH1_1 => { // StreamNil
            v1.clone()
        }
    }
}
fn method24(mut v0: Rc<UH1>, mut v1: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH1::UH1_0(v2, v3) => { // StreamCons
            let mut v2: u8 = *v2;
            let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
            let mut v4: Rc<UH1> = v3();
            let mut v5: Rc<UH0> = method24(v4.clone(), v1.clone());
            Rc::new(UH0::UH0_1(v2, v5.clone()))
        }
        UH1::UH1_1 => { // StreamNil
            v1.clone()
        }
    }
}
fn method25(mut v0: Rc<RefCell<Vec<u8>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_1(v3, v4) => { // Cons
                let mut v3: u8 = *v3;
                let mut v4: Rc<UH0> = v4.clone();
                v0.borrow_mut().push(v3);
                let mut v5: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v2;
            }
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
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v16.clone(), v48.clone());
    method16(v16.clone());
    method29(v16.clone());
    method15(v16.clone());
    let mut v96: std::string::String = format!("{:#?}", v1);
    let mut v98: Rc<str> = Rc::<str>::from(v96);
    method6(v16.clone(), v98.clone());
    method16(v16.clone());
    method30(v16.clone());
    method15(v16.clone());
    let mut v129: std::string::String = format!("{:#?}", v2);
    let mut v131: Rc<str> = Rc::<str>::from(v129);
    method6(v16.clone(), v131.clone());
    method16(v16.clone());
    method31(v16.clone());
    method15(v16.clone());
    let mut v157: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v16.clone(), v157.clone());
    method16(v16.clone());
    method32(v16.clone());
    method15(v16.clone());
    let mut v183: Rc<str> = Rc::<str>::from(format!("{}", v4));
    method6(v16.clone(), v183.clone());
    method16(v16.clone());
    method33(v16.clone());
    method15(v16.clone());
    let mut v209: Rc<str> = Rc::<str>::from(format!("{}", v5));
    method6(v16.clone(), v209.clone());
    method16(v16.clone());
    method34(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v6.clone());
    method16(v16.clone());
    method35(v16.clone());
    method15(v16.clone());
    let mut v261: std::string::String = format!("{:#?}", v7);
    let mut v263: Rc<str> = Rc::<str>::from(v261);
    method6(v16.clone(), v263.clone());
    method16(v16.clone());
    method36(v16.clone());
    method15(v16.clone());
    let mut v290: std::string::String = format!("{:#?}", v8);
    let mut v292: Rc<str> = Rc::<str>::from(v290);
    method6(v16.clone(), v292.clone());
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
    let mut v386: std::string::String = format!("{:#?}", v11);
    let mut v388: Rc<str> = Rc::<str>::from(v386);
    method6(v16.clone(), v388.clone());
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
    let mut v468: Rc<str> = v16.borrow().l0.clone();
    v468.clone()
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
    let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v46));
    let mut v48: Rc<str> = method27(v8, v9.clone(), v10.clone(), v11, v12, v13, v14.clone(), v15.clone(), v16.clone(), v17.clone(), v18.clone(), v19.clone(), v20.clone(), v21.clone(), v22.clone());
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    method8(v49.clone())
}
fn method43(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v0 {
            UH0::UH0_1(v2, v3) => { // Cons
                let mut v2: u8 = *v2;
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: Rc<UH0> = Rc::new(UH0::UH0_1(v2, v1.clone()));
                (v0, v1) = (v3.clone(), v4.clone());
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v1.clone();
            }
        }
    }
}
fn method44(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH0::UH0_1(v2, v3) => { // Cons
            let mut v2: u8 = *v2;
            let mut v3: Rc<UH0> = v3.clone();
            let mut v4: Rc<UH0> = method44(v3.clone(), v1.clone());
            Rc::new(UH0::UH0_1(v2, v4.clone()))
        }
        UH0::UH0_0 => { // Nil
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
            US3::US3_1(v3) => { // Computed
                let mut v3: Rc<UH1> = v3.clone();
                v3.clone()
            }
            US3::US3_0(v4) => { // NotComputed
                let mut v4: Rc<dyn Fn() -> Rc<UH1>> = v4.clone();
                let mut v5: Rc<UH1> = v4();
                let mut v12: Rc<UH1> = match &*v5 {
                    UH1::UH1_0(v7, v8) => { // StreamCons
                        let mut v7: u8 = *v7;
                        let mut v8: Rc<dyn Fn() -> Rc<UH1>> = v8.clone();
                        let mut v9: Rc<dyn Fn() -> Rc<UH1>> = method45(v0.clone(), v8.clone());
                        Rc::new(UH1::UH1_0(v7, v9.clone()))
                    }
                    UH1::UH1_1 => { // StreamNil
                        { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) }
                    }
                };
                let mut v13: US3 = US3::US3_1(v12.clone());
                v1.borrow_mut().l0 = v13.clone();
                v12.clone()
            }
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
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v31.clone());
    method16(v4.clone());
    method51(v4.clone());
    method15(v4.clone());
    let mut v74: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v74.clone());
    method18(v4.clone());
    let mut v79: Rc<str> = v4.borrow().l0.clone();
    v79.clone()
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
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v34));
    let mut v36: Rc<str> = method49(v8, v9, v10);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    method8(v37.clone())
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
                let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" is above the largest supported bound "); } LIT.with(|lit| lit.clone()) };
                let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
                let mut v38: Rc<str> = method47(v2);
                let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v38));
                return std::panic::panic_any::<std::string::String>(format!("{}", v39.clone()));
            } else {
                let mut v41: i8 = v1.wrapping_add(1i8);
                let mut v42: u64 = v2.wrapping_mul(6u64);
                (v0, v1, v2) = (v0, v41, v42);
                continue;
            }
        } else {
            let mut v46: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
            { let _ = spiral_trace_hold(&v46); };
            let mut v48: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v49, mut v50, mut v51, mut v52, mut v53, mut v54): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v48) };
            let mut v55: US0 = v53.borrow().l0.clone();
            let mut v60: i32 = match &v55 {
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
            };
            let mut v61: bool = v51.borrow().l0.clone();
            let mut v62: bool = v61 == false;
            let mut v64: bool = if v62 {
                false
            } else {
                let mut v63: bool = 20i32 >= v60;
                v63
            };
            let mut v65: bool = v64 == false;
            let mut v110: US2 = if v65 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v46); };
                let (mut v69, mut v70, mut v71, mut v72, mut v73, mut v74): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v48) };
                let mut v75: Rc<str> = method3(v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone(), v74.clone());
                let mut v76: Rc<str> = method4();
                let mut v77: Rc<str> = method48(v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone(), v74.clone(), v75.clone(), v76.clone(), v0, v2, v1);
                { let _ = spiral_trace_hold(&v46); };
                let (mut v80, mut v81, mut v82, mut v83, mut v84, mut v85): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v48) };
                let mut v86: i64 = v80.borrow().l0.clone();
                let mut v87: i64 = v86.wrapping_add(1i64);
                v80.borrow_mut().l0 = v87;
                let mut v88: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v89: bool = cfg!(target_arch = "wasm32");
                if v89 {
                    let mut v90: Rc<str> = v83.borrow().l0.clone();
                    let mut v91: bool = v90.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v99: Rc<str> = if v91 {
                        v77.clone()
                    } else {
                        let mut v92: bool = v77.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v92 {
                            let mut v93: Rc<str> = v83.borrow().l0.clone();
                            v93.clone()
                        } else {
                            let mut v94: Rc<str> = v83.borrow().l0.clone();
                            let mut v95: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v96: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v95));
                            let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", v96, v77));
                            v97.clone()
                        }
                    };
                    let mut v101: i32 = ((v99.chars().count() + 14999) / 15000) as i32;
                    let mut v102: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v103: bool = v77 != v102 ;
                    let mut v105: bool = if v103 {
                        let mut v104: bool = v101 <= 1i32;
                        v104
                    } else {
                        false
                    };
                    if v105 {
                        v83.borrow_mut().l0 = v99.clone();
                        ()
                    } else {
                        v83.borrow_mut().l0 = v102.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v99); };
                        ()
                    }
                } else {
                    println!("{}", v77);
                    ()
                };
                let mut v108: Rc<dyn Fn(Rc<str>) -> ()> = v81.borrow().l0.clone();
                v108(v77.clone());
                US2::US2_0(v80.clone(), v81.clone(), v82.clone(), v83.clone(), v84.clone(), v85.clone())
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
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v5.clone(), v31.clone());
    method16(v5.clone());
    method57(v5.clone());
    method15(v5.clone());
    let mut v57: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v5.clone(), v57.clone());
    method16(v5.clone());
    method58(v5.clone());
    method15(v5.clone());
    let mut v83: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v5.clone(), v83.clone());
    method16(v5.clone());
    method59(v5.clone());
    method15(v5.clone());
    method6(v5.clone(), v3.clone());
    method18(v5.clone());
    let mut v109: Rc<str> = v5.borrow().l0.clone();
    v109.clone()
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
    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v35));
    let mut v37: Rc<str> = method55(v8, v9, v10, v11.clone());
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
    method8(v38.clone())
}
fn method60(mut v0: i64, mut v1: Rc<UH1>) -> US4 {
    loop {
        match &*v1 {
            UH1::UH1_0(v2, v3) => { // StreamCons
                let mut v2: u8 = *v2;
                let mut v3: Rc<dyn Fn() -> Rc<UH1>> = v3.clone();
                let mut v4: bool = v0 <= 0i64;
                if v4 {
                    return US4::US4_0(v2);
                } else {
                    let mut v6: i64 = v0.wrapping_sub(1i64);
                    let mut v7: Rc<UH1> = v3();
                    (v0, v1) = (v6, v7.clone());
                    continue;
                }
            }
            UH1::UH1_1 => { // StreamNil
                return US4::US4_1;
            }
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
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v31));
    let mut v33: Rc<str> = method62();
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    method8(v34.clone())
}
fn method53(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>) -> u8 {
    loop {
        let mut v5: i64 = v1.borrow().l0.clone();
        let mut v6: i64 = v2.borrow().l0.clone();
        let mut v7: i64 = v3.borrow().l0.clone();
        let mut v8: US4 = v4.borrow().l0.clone();
        let mut v56: Option<u8> = match &v8 {
            US4::US4_1 => { // None
                let mut v50: Option<u8> = None;
                v50.clone()
            }
            US4::US4_0(v9) => { // Some
                let mut v9: u8 = *v9;
                let mut v27: Option<u8> = Some(v9.clone());
                v27.clone()
            }
        };
        let mut v58: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v58); };
        let mut v60: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v61, mut v62, mut v63, mut v64, mut v65, mut v66): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v60) };
        let mut v67: US0 = v65.borrow().l0.clone();
        let mut v72: i32 = match &v67 {
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
        };
        let mut v73: bool = v63.borrow().l0.clone();
        let mut v74: bool = v73 == false;
        let mut v76: bool = if v74 {
            false
        } else {
            let mut v75: bool = 20i32 >= v72;
            v75
        };
        let mut v77: bool = v76 == false;
        let mut v164: US2 = if v77 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v58); };
            let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v60) };
            let mut v87: Rc<str> = method3(v81.clone(), v82.clone(), v83.clone(), v84.clone(), v85.clone(), v86.clone());
            let mut v88: Rc<str> = method4();
            let mut v95: Rc<str> = Rc::<str>::from(match &v56 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v131: Rc<str> = method54(v81.clone(), v82.clone(), v83.clone(), v84.clone(), v85.clone(), v86.clone(), v87.clone(), v88.clone(), v5, v6, v7, v95.clone());
            { let _ = spiral_trace_hold(&v58); };
            let (mut v134, mut v135, mut v136, mut v137, mut v138, mut v139): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v60) };
            let mut v140: i64 = v134.borrow().l0.clone();
            let mut v141: i64 = v140.wrapping_add(1i64);
            v134.borrow_mut().l0 = v141;
            let mut v142: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v143: bool = cfg!(target_arch = "wasm32");
            if v143 {
                let mut v144: Rc<str> = v137.borrow().l0.clone();
                let mut v145: bool = v144.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v153: Rc<str> = if v145 {
                    v131.clone()
                } else {
                    let mut v146: bool = v131.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v146 {
                        let mut v147: Rc<str> = v137.borrow().l0.clone();
                        v147.clone()
                    } else {
                        let mut v148: Rc<str> = v137.borrow().l0.clone();
                        let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v150: Rc<str> = Rc::<str>::from(format!("{}{}", v148, v149));
                        let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v150, v131));
                        v151.clone()
                    }
                };
                let mut v155: i32 = ((v153.chars().count() + 14999) / 15000) as i32;
                let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v157: bool = v131 != v156 ;
                let mut v159: bool = if v157 {
                    let mut v158: bool = v155 <= 1i32;
                    v158
                } else {
                    false
                };
                if v159 {
                    v137.borrow_mut().l0 = v153.clone();
                    ()
                } else {
                    v137.borrow_mut().l0 = v156.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v153); };
                    ()
                }
            } else {
                println!("{}", v131);
                ()
            };
            let mut v162: Rc<dyn Fn(Rc<str>) -> ()> = v135.borrow().l0.clone();
            v162(v131.clone());
            US2::US2_0(v134.clone(), v135.clone(), v136.clone(), v137.clone(), v138.clone(), v139.clone())
        };
        let mut v165: Rc<UH1> = v0();
        let mut v166: i64 = v1.borrow().l0.clone();
        let mut v167: US4 = method60(v166, v165.clone());
        match &v167 {
            US4::US4_1 => { // None
                { let _ = spiral_trace_hold(&v58); };
                let (mut v174, mut v175, mut v176, mut v177, mut v178, mut v179): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v60) };
                let mut v180: US0 = v178.borrow().l0.clone();
                let mut v185: i32 = match &v180 {
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
                };
                let mut v186: bool = v176.borrow().l0.clone();
                let mut v187: bool = v186 == false;
                let mut v189: bool = if v187 {
                    false
                } else {
                    let mut v188: bool = 20i32 >= v185;
                    v188
                };
                let mut v190: bool = v189 == false;
                let mut v235: US2 = if v190 {
                    US2::US2_1
                } else {
                    { let _ = spiral_trace_hold(&v58); };
                    let (mut v194, mut v195, mut v196, mut v197, mut v198, mut v199): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v60) };
                    let mut v200: Rc<str> = method3(v194.clone(), v195.clone(), v196.clone(), v197.clone(), v198.clone(), v199.clone());
                    let mut v201: Rc<str> = method4();
                    let mut v202: Rc<str> = method61(v194.clone(), v195.clone(), v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone());
                    { let _ = spiral_trace_hold(&v58); };
                    let (mut v205, mut v206, mut v207, mut v208, mut v209, mut v210): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v60) };
                    let mut v211: i64 = v205.borrow().l0.clone();
                    let mut v212: i64 = v211.wrapping_add(1i64);
                    v205.borrow_mut().l0 = v212;
                    let mut v213: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                    let mut v214: bool = cfg!(target_arch = "wasm32");
                    if v214 {
                        let mut v215: Rc<str> = v208.borrow().l0.clone();
                        let mut v216: bool = v215.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v224: Rc<str> = if v216 {
                            v202.clone()
                        } else {
                            let mut v217: bool = v202.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v217 {
                                let mut v218: Rc<str> = v208.borrow().l0.clone();
                                v218.clone()
                            } else {
                                let mut v219: Rc<str> = v208.borrow().l0.clone();
                                let mut v220: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v221: Rc<str> = Rc::<str>::from(format!("{}{}", v219, v220));
                                let mut v222: Rc<str> = Rc::<str>::from(format!("{}{}", v221, v202));
                                v222.clone()
                            }
                        };
                        let mut v226: i32 = ((v224.chars().count() + 14999) / 15000) as i32;
                        let mut v227: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v228: bool = v202 != v227 ;
                        let mut v230: bool = if v228 {
                            let mut v229: bool = v226 <= 1i32;
                            v229
                        } else {
                            false
                        };
                        if v230 {
                            v208.borrow_mut().l0 = v224.clone();
                            ()
                        } else {
                            v208.borrow_mut().l0 = v227.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v224); };
                            ()
                        }
                    } else {
                        println!("{}", v202);
                        ()
                    };
                    let mut v233: Rc<dyn Fn(Rc<str>) -> ()> = v206.borrow().l0.clone();
                    v233(v202.clone());
                    US2::US2_0(v205.clone(), v206.clone(), v207.clone(), v208.clone(), v209.clone(), v210.clone())
                };
                let mut v236: i64 = v3.borrow().l0.clone();
                let mut v237: bool = v236 == -1i64;
                if v237 {
                    let mut v238: i64 = v1.borrow().l0.clone();
                    v3.borrow_mut().l0 = v238;
                    ()
                };
                let mut v239: i64 = v2.borrow().l0.clone();
                let mut v240: i64 = v3.borrow().l0.clone();
                let mut v241: bool = v239 >= v240;
                let mut v244: i64 = if v241 {
                    1i64
                } else {
                    let mut v242: i64 = v2.borrow().l0.clone();
                    let mut v243: i64 = v242.wrapping_add(1i64);
                    v243
                };
                v2.borrow_mut().l0 = v244;
                let mut v245: i64 = v2.borrow().l0.clone();
                let mut v246: i64 = v245.wrapping_sub(1i64);
                v1.borrow_mut().l0 = v246;
                let mut v247: US4 = US4::US4_1;
                v4.borrow_mut().l0 = v247.clone();
                (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
                continue;
            }
            US4::US4_0(v168) => { // Some
                let mut v168: u8 = *v168;
                let mut v169: i64 = v1.borrow().l0.clone();
                let mut v170: i64 = v169.wrapping_add(1i64);
                v1.borrow_mut().l0 = v170;
                let mut v171: US4 = US4::US4_0(v168);
                v4.borrow_mut().l0 = v171.clone();
                return v168;
            }
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
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v30.clone());
    method16(v4.clone());
    method57(v4.clone());
    method15(v4.clone());
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v31.clone());
    method16(v4.clone());
    method67(v4.clone());
    method15(v4.clone());
    let mut v57: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v57.clone());
    method18(v4.clone());
    let mut v58: Rc<str> = v4.borrow().l0.clone();
    v58.clone()
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
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v34));
    let mut v36: Rc<str> = method65(v8, v9, v10);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    method8(v37.clone())
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
                let mut v2: u64 = *v2;
                let mut v3: Rc<dyn Fn() -> Rc<UH2>> = v3.clone();
                let mut v4: bool = v0 <= 0i8;
                if v4 {
                    return US6::US6_0(v2);
                } else {
                    let mut v6: i8 = v0.wrapping_sub(1i8);
                    let mut v7: Rc<UH2> = v3();
                    (v0, v1) = (v6, v7.clone());
                    continue;
                }
            }
            UH2::UH2_1 => { // StreamNil
                return US6::US6_1;
            }
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
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v5.clone(), v40.clone());
    method16(v5.clone());
    method72(v5.clone());
    method15(v5.clone());
    let mut v70: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v5.clone(), v70.clone());
    method18(v5.clone());
    let mut v71: Rc<str> = v5.borrow().l0.clone();
    v71.clone()
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
            let mut v4: u64 = v2.wrapping_add(1u64);
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
                US2::US2_0(v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v45.clone())
            };
            return US5::US5_0(v4, v1.clone());
        } else {
            match &*v1 {
                UH0::UH0_1(v73, v74) => { // Cons
                    let mut v73: u8 = *v73;
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
                                let mut v80: u64 = *v80;
                                v80
                            }
                        };
                        let mut v84: u8 = v73.wrapping_sub(1u8);
                        let mut v85: u64 = (v84 as u64);
                        let mut v86: u64 = v85.wrapping_mul(v83);
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
                            US2::US2_0(v122.clone(), v123.clone(), v124.clone(), v125.clone(), v126.clone(), v127.clone())
                        };
                        let mut v153: u64 = v2.wrapping_add(v86);
                        let mut v154: i8 = v0.wrapping_sub(1i8);
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
                            US2::US2_0(v191.clone(), v192.clone(), v193.clone(), v194.clone(), v195.clone(), v196.clone())
                        };
                        let mut v222: i8 = v0.wrapping_sub(1i8);
                        (v0, v1, v2) = (v222, v74.clone(), v2);
                        continue;
                    }
                }
                UH0::UH0_0 => { // Nil
                    return US5::US5_1;
                }
            }
        }
    }
}
fn method75(mut v0: i8, mut v1: Rc<dyn Fn() -> Rc<UH1>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut0>>, mut v5: Rc<RefCell<Mut7>>, mut v6: i8) -> Rc<UH0> {
    let mut v7: bool = v6 < v0;
    if v7 {
        let mut v8: u8 = method53(v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone());
        let mut v9: i8 = v6.wrapping_add(1i8);
        let mut v10: Rc<UH0> = method75(v0, v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v9);
        Rc::new(UH0::UH0_1(v8, v10.clone()))
    } else {
        { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) }
    }
}
fn method76(mut v0: Rc<dyn Fn() -> Rc<UH1>>, mut v1: Rc<RefCell<Mut0>>, mut v2: Rc<RefCell<Mut0>>, mut v3: Rc<RefCell<Mut0>>, mut v4: Rc<RefCell<Mut7>>, mut v5: u64, mut v6: i8, mut v7: Rc<UH0>) -> u64 {
    loop {
        let mut v8: i8 = v6.wrapping_add(1i8);
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
                    let mut v15: u64 = *v15;
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
        let mut v9: i8 = v6.wrapping_add(1i8);
        let mut v10: bool = v8 < v9;
        if v10 {
            let mut v11: u8 = method53(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
            let mut v12: Rc<UH0> = Rc::new(UH0::UH0_1(v11, v7.clone()));
            let mut v13: i8 = v8.wrapping_add(1i8);
            (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6, v12.clone(), v13);
            continue;
        } else {
            let mut v15: u64 = 0u64;
            let mut v16: US5 = method63(v6, v7.clone(), v15);
            match &v16 {
                US5::US5_0(v17, v18) => { // Some
                    let mut v17: u64 = *v17;
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
        let mut v60: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::random_seed(); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        let mut v132: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::epoch_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v168: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v182: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_timestamp(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v232: u128 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::account_balance().as_yoctonear(); #[cfg(not(target_arch = "wasm32"))] let v = 1u128; v };
        let mut v304: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::signer_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v340: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::predecessor_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v391: &SpiralNearVec<u8> = &*v0;
        let mut v427: Vec<u8> = (v391).iter().cloned().collect::<std::vec::Vec<_>>();
        let mut v477: _ = (v132).to_le_bytes().to_vec();
        let mut v513: Vec<u8> = (v477).clone();
        let mut v518: _ = (v168).to_le_bytes().to_vec();
        let mut v519: Vec<u8> = (v518).clone();
        let mut v520: _ = (v182).to_le_bytes().to_vec();
        let mut v521: Vec<u8> = (v520).clone();
        let mut v567: u128 = (v232.clone());
        let mut v603: _ = (v567).to_le_bytes().to_vec();
        let mut v608: Vec<u8> = (v603).clone();
        let mut v618: &[u8] = (v304).as_bytes();
        let mut v632: Vec<u8> = (v618).to_vec();
        let mut v637: &[u8] = (v340).as_bytes();
        let mut v638: Vec<u8> = (v637).to_vec();
        let mut v648: Vec<u8> = (v2).as_bytes().to_vec();
        let mut v653: Vec<u8> = (v1).as_bytes().to_vec();
        let mut v654: Rc<RefCell<Vec<Vec<u8>>>> = Rc::new(RefCell::new(vec![v60.clone(), v427.clone(), v513.clone(), v519.clone(), v521.clone(), v608.clone(), v632.clone(), v638.clone(), v648.clone(), v653.clone()]));
        let mut v700: Vec<Vec<u8>> = (v654).borrow().clone();
        let mut v736: Vec<u8> = (v700).concat();
        let mut v750: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::keccak512(&(v736.clone())); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        { (v0).extend((v750).clone()); };
        let mut v755: u32 = ((v0).len() as u32);
        let mut v756: i32 = (v755 as i32);
        let mut v757: usize = ((100i32) as usize);
        let mut v758: i32 = (v757 as i32);
        let mut v759: i32 = v756.wrapping_sub(v758);
        let mut v760: bool = v759 > 0i32;
        if v760 {
            let mut v762: Vec<u8> = v0.drain(0..v759 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v765, mut v766, mut v767, mut v768, mut v769, mut v770): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v771: US0 = v769.borrow().l0.clone();
            let mut v776: i32 = match &v771 {
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
            };
            let mut v777: bool = v767.borrow().l0.clone();
            let mut v778: bool = v777 == false;
            let mut v780: bool = if v778 {
                false
            } else {
                let mut v779: bool = 20i32 >= v776;
                v779
            };
            let mut v781: bool = v780 == false;
            let mut v827: US2 = if v781 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v5); };
                let (mut v785, mut v786, mut v787, mut v788, mut v789, mut v790): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v791: Rc<str> = method3(v785.clone(), v786.clone(), v787.clone(), v788.clone(), v789.clone(), v790.clone());
                let mut v792: Rc<str> = method4();
                let mut v793: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v762)).s() });
                let mut v794: Rc<str> = method7(v785.clone(), v786.clone(), v787.clone(), v788.clone(), v789.clone(), v790.clone(), v791.clone(), v792.clone(), v759, v793.clone());
                { let _ = spiral_trace_hold(&v5); };
                let (mut v797, mut v798, mut v799, mut v800, mut v801, mut v802): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v803: i64 = v797.borrow().l0.clone();
                let mut v804: i64 = v803.wrapping_add(1i64);
                v797.borrow_mut().l0 = v804;
                let mut v805: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v806: bool = cfg!(target_arch = "wasm32");
                if v806 {
                    let mut v807: Rc<str> = v800.borrow().l0.clone();
                    let mut v808: bool = v807.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v816: Rc<str> = if v808 {
                        v794.clone()
                    } else {
                        let mut v809: bool = v794.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v809 {
                            let mut v810: Rc<str> = v800.borrow().l0.clone();
                            v810.clone()
                        } else {
                            let mut v811: Rc<str> = v800.borrow().l0.clone();
                            let mut v812: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v813: Rc<str> = Rc::<str>::from(format!("{}{}", v811, v812));
                            let mut v814: Rc<str> = Rc::<str>::from(format!("{}{}", v813, v794));
                            v814.clone()
                        }
                    };
                    let mut v818: i32 = ((v816.chars().count() + 14999) / 15000) as i32;
                    let mut v819: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v820: bool = v794 != v819 ;
                    let mut v822: bool = if v820 {
                        let mut v821: bool = v818 <= 1i32;
                        v821
                    } else {
                        false
                    };
                    if v822 {
                        v800.borrow_mut().l0 = v816.clone();
                        ()
                    } else {
                        v800.borrow_mut().l0 = v819.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v816); };
                        ()
                    }
                } else {
                    println!("{}", v794);
                    ()
                };
                let mut v825: Rc<dyn Fn(Rc<str>) -> ()> = v798.borrow().l0.clone();
                v825(v794.clone());
                US2::US2_0(v797.clone(), v798.clone(), v799.clone(), v800.clone(), v801.clone(), v802.clone())
            };
            ()
        };
        let mut v828: Rc<dyn Fn() -> ()> = method19();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v831, mut v832, mut v833, mut v834, mut v835, mut v836): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v837: US0 = v835.borrow().l0.clone();
        let mut v842: i32 = match &v837 {
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
        };
        let mut v843: bool = v833.borrow().l0.clone();
        let mut v844: bool = v843 == false;
        let mut v846: bool = if v844 {
            false
        } else {
            let mut v845: bool = 20i32 >= v842;
            v845
        };
        let mut v847: bool = v846 == false;
        let mut v891: US2 = if v847 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v851, mut v852, mut v853, mut v854, mut v855, mut v856): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v857: Rc<str> = method3(v851.clone(), v852.clone(), v853.clone(), v854.clone(), v855.clone(), v856.clone());
            let mut v858: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v861, mut v862, mut v863, mut v864, mut v865, mut v866): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v867: i64 = v861.borrow().l0.clone();
            let mut v868: i64 = v867.wrapping_add(1i64);
            v861.borrow_mut().l0 = v868;
            let mut v869: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v870: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v871: bool = cfg!(target_arch = "wasm32");
            if v871 {
                let mut v872: Rc<str> = v864.borrow().l0.clone();
                let mut v873: bool = v872.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v881: Rc<str> = if v873 {
                    v869.clone()
                } else {
                    let mut v874: bool = v869.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v874 {
                        let mut v875: Rc<str> = v864.borrow().l0.clone();
                        v875.clone()
                    } else {
                        let mut v876: Rc<str> = v864.borrow().l0.clone();
                        let mut v877: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v878: Rc<str> = Rc::<str>::from(format!("{}{}", v876, v877));
                        let mut v879: Rc<str> = Rc::<str>::from(format!("{}{}", v878, v869));
                        v879.clone()
                    }
                };
                let mut v883: i32 = ((v881.chars().count() + 14999) / 15000) as i32;
                let mut v884: bool = v869 != v869 ;
                let mut v886: bool = if v884 {
                    let mut v885: bool = v883 <= 1i32;
                    v885
                } else {
                    false
                };
                if v886 {
                    v864.borrow_mut().l0 = v881.clone();
                    ()
                } else {
                    v864.borrow_mut().l0 = v869.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v881); };
                    ()
                }
            } else {
                println!("{}", v869);
                ()
            };
            let mut v889: Rc<dyn Fn(Rc<str>) -> ()> = v862.borrow().l0.clone();
            v889(v869.clone());
            US2::US2_0(v861.clone(), v862.clone(), v863.clone(), v864.clone(), v865.clone(), v866.clone())
        };
        let mut v937: Vec<u8> = method20(v750.clone());
        let mut v938: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v937));
        let mut v982: Rc<Vec<u8>> = Rc::new((v938).borrow().clone());
        let mut v1125: i32 = (v982).len() as i32;
        let mut v1126: i32 = v1125.wrapping_sub(1i32);
        let mut v1127: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1128: Rc<UH0> = method21(v982.clone(), v1126, v1127.clone());
        let mut v1136: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v1137: Rc<UH1> = method22(v1128.clone(), v1136.clone());
        let mut v1138: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v1139: Rc<UH1> = method23(v1137.clone(), v1138.clone());
        let mut v1140: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1141: Rc<UH0> = method24(v1139.clone(), v1140.clone());
        { let _ = spiral_trace_hold(&v5); };
        let (mut v1144, mut v1145, mut v1146, mut v1147, mut v1148, mut v1149): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v1150: US0 = v1148.borrow().l0.clone();
        let mut v1155: i32 = match &v1150 {
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
        };
        let mut v1156: bool = v1146.borrow().l0.clone();
        let mut v1157: bool = v1156 == false;
        let mut v1159: bool = if v1157 {
            false
        } else {
            let mut v1158: bool = 20i32 >= v1155;
            v1158
        };
        let mut v1160: bool = v1159 == false;
        let mut v1409: US2 = if v1160 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1164, mut v1165, mut v1166, mut v1167, mut v1168, mut v1169): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1170: Rc<str> = method3(v1164.clone(), v1165.clone(), v1166.clone(), v1167.clone(), v1168.clone(), v1169.clone());
            let mut v1171: Rc<str> = method4();
            let mut v1178: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<u128>") } } (&&W(&v232)).s() });
            let mut v1184: std::string::String = v304.to_string();
            let mut v1186: std::string::String = v340.to_string();
            let mut v1187: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v60)).s() });
            let mut v1194: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<&mut SpiralNearVec<u8>>") } } (&&W(&v0)).s() });
            let mut v1244: usize = ((v736).len() as usize);
            let mut v1271: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v736)).s() });
            let mut v1272: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v750)).s() });
            let mut v1284: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
            let mut v1285: i32 = 0i32;
            let mut v1286: i32 = method25(v1284.clone(), v1141.clone(), v1285);
            let mut v1287: Rc<Vec<u8>> = Rc::new(v1284.borrow().clone());
            let mut v1356: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v1287).as_ref().clone()));
            let mut v1370: Vec<u8> = (v1356).borrow().clone();
            let mut v1375: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1370)).s() });
            let mut v1376: Rc<str> = method26(v1164.clone(), v1165.clone(), v1166.clone(), v1167.clone(), v1168.clone(), v1169.clone(), v1170.clone(), v1171.clone(), v3, v1.clone(), v2.clone(), v182, v168, v132, v1178.clone(), v1184.clone(), v1186.clone(), v1187.clone(), v1194.clone(), v1244.clone(), v1271.clone(), v1272.clone(), v1375.clone());
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1379, mut v1380, mut v1381, mut v1382, mut v1383, mut v1384): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1385: i64 = v1379.borrow().l0.clone();
            let mut v1386: i64 = v1385.wrapping_add(1i64);
            v1379.borrow_mut().l0 = v1386;
            let mut v1387: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v1388: bool = cfg!(target_arch = "wasm32");
            if v1388 {
                let mut v1389: Rc<str> = v1382.borrow().l0.clone();
                let mut v1390: bool = v1389.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1398: Rc<str> = if v1390 {
                    v1376.clone()
                } else {
                    let mut v1391: bool = v1376.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1391 {
                        let mut v1392: Rc<str> = v1382.borrow().l0.clone();
                        v1392.clone()
                    } else {
                        let mut v1393: Rc<str> = v1382.borrow().l0.clone();
                        let mut v1394: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1395: Rc<str> = Rc::<str>::from(format!("{}{}", v1393, v1394));
                        let mut v1396: Rc<str> = Rc::<str>::from(format!("{}{}", v1395, v1376));
                        v1396.clone()
                    }
                };
                let mut v1400: i32 = ((v1398.chars().count() + 14999) / 15000) as i32;
                let mut v1401: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1402: bool = v1376 != v1401 ;
                let mut v1404: bool = if v1402 {
                    let mut v1403: bool = v1400 <= 1i32;
                    v1403
                } else {
                    false
                };
                if v1404 {
                    v1382.borrow_mut().l0 = v1398.clone();
                    ()
                } else {
                    v1382.borrow_mut().l0 = v1401.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1398); };
                    ()
                }
            } else {
                println!("{}", v1376);
                ()
            };
            let mut v1407: Rc<dyn Fn(Rc<str>) -> ()> = v1380.borrow().l0.clone();
            v1407(v1376.clone());
            US2::US2_0(v1379.clone(), v1380.clone(), v1381.clone(), v1382.clone(), v1383.clone(), v1384.clone())
        };
        let mut v1410: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1411: Rc<UH0> = method43(v1141.clone(), v1410.clone());
        let mut v1412: Rc<UH0> = method44(v1141.clone(), v1411.clone());
        let mut v1413: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v1414: Rc<UH1> = method22(v1412.clone(), v1413.clone());
        let mut v1415: Rc<dyn Fn() -> Rc<UH1>> = closure10(v1414.clone());
        let mut v1416: Rc<dyn Fn() -> Rc<UH1>> = method45(v1414.clone(), v1415.clone());
        let mut v1417: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i64 }));
        let mut v1418: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
        let mut v1419: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: -1i64 }));
        let mut v1420: US4 = US4::US4_1;
        let mut v1421: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: v1420.clone() }));
        let mut v1422: bool = v3 == 1u64;
        let mut v1426: i8 = if v1422 {
            1i8
        } else {
            let mut v1423: i8 = 0i8;
            let mut v1424: u64 = 1u64;
            method46(v3, v1423, v1424)
        };
        let mut v1427: i8 = v1426.wrapping_sub(1i8);
        let mut v1428: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1429: i8 = 0i8;
        let mut v1430: u64 = method52(v1416.clone(), v1417.clone(), v1418.clone(), v1419.clone(), v1421.clone(), v3, v1427, v1428.clone(), v1429);
        let mut v1431: Rc<dyn Fn() -> ()> = method77();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v1434, mut v1435, mut v1436, mut v1437, mut v1438, mut v1439): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v1440: US0 = v1438.borrow().l0.clone();
        let mut v1445: i32 = match &v1440 {
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
        };
        let mut v1446: bool = v1436.borrow().l0.clone();
        let mut v1447: bool = v1446 == false;
        let mut v1449: bool = if v1447 {
            false
        } else {
            let mut v1448: bool = 20i32 >= v1445;
            v1448
        };
        let mut v1450: bool = v1449 == false;
        let mut v1494: US2 = if v1450 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1454, mut v1455, mut v1456, mut v1457, mut v1458, mut v1459): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1460: Rc<str> = method3(v1454.clone(), v1455.clone(), v1456.clone(), v1457.clone(), v1458.clone(), v1459.clone());
            let mut v1461: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1464, mut v1465, mut v1466, mut v1467, mut v1468, mut v1469): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1470: i64 = v1464.borrow().l0.clone();
            let mut v1471: i64 = v1470.wrapping_add(1i64);
            v1464.borrow_mut().l0 = v1471;
            let mut v1472: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1473: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v1474: bool = cfg!(target_arch = "wasm32");
            if v1474 {
                let mut v1475: Rc<str> = v1467.borrow().l0.clone();
                let mut v1476: bool = v1475.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1484: Rc<str> = if v1476 {
                    v1472.clone()
                } else {
                    let mut v1477: bool = v1472.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1477 {
                        let mut v1478: Rc<str> = v1467.borrow().l0.clone();
                        v1478.clone()
                    } else {
                        let mut v1479: Rc<str> = v1467.borrow().l0.clone();
                        let mut v1480: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1481: Rc<str> = Rc::<str>::from(format!("{}{}", v1479, v1480));
                        let mut v1482: Rc<str> = Rc::<str>::from(format!("{}{}", v1481, v1472));
                        v1482.clone()
                    }
                };
                let mut v1486: i32 = ((v1484.chars().count() + 14999) / 15000) as i32;
                let mut v1487: bool = v1472 != v1472 ;
                let mut v1489: bool = if v1487 {
                    let mut v1488: bool = v1486 <= 1i32;
                    v1488
                } else {
                    false
                };
                if v1489 {
                    v1467.borrow_mut().l0 = v1484.clone();
                    ()
                } else {
                    v1467.borrow_mut().l0 = v1472.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1484); };
                    ()
                }
            } else {
                println!("{}", v1472);
                ()
            };
            let mut v1492: Rc<dyn Fn(Rc<str>) -> ()> = v1465.borrow().l0.clone();
            v1492(v1472.clone());
            US2::US2_0(v1464.clone(), v1465.clone(), v1466.clone(), v1467.clone(), v1468.clone(), v1469.clone())
        };
        v1430
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method78(mut v0: Rc<UH0>, mut v1: i8) -> i8 {
    loop {
        match &*v0 {
            UH0::UH0_1(v2, v3) => { // Cons
                let mut v2: u8 = *v2;
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: i8 = v1.wrapping_add(1i8);
                (v0, v1) = (v3.clone(), v4);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v1;
            }
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
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v34));
    let mut v36: Rc<str> = method80(v8, v9.clone(), v10.clone());
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    method8(v37.clone())
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
        let mut v17: i32 = v16.wrapping_sub(1i32);
        let mut v18: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v19: Rc<UH0> = method21(v15.clone(), v17, v18.clone());
        let mut v20: i8 = 0i8;
        let mut v21: i8 = method78(v19.clone(), v20);
        let mut v22: i8 = v21.wrapping_sub(1i8);
        let mut v23: u64 = 0u64;
        let mut v24: US5 = method63(v22, v19.clone(), v23);
        let mut v34: US6 = match &v24 {
            US5::US5_0(v25, v26) => { // Some
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
                    US6::US6_0(v25)
                } else {
                    US6::US6_1
                }
            }
            _ => {
                US6::US6_1
            }
        };
        let mut v82: Option<u64> = match &v34 {
            US6::US6_1 => { // None
                let mut v76: Option<u64> = None;
                v76.clone()
            }
            US6::US6_0(v35) => { // Some
                let mut v35: u64 = *v35;
                let mut v53: Option<u64> = Some(v35.clone());
                v53.clone()
            }
        };
        { let _ = spiral_trace_hold(&v3); };
        let (mut v85, mut v86, mut v87, mut v88, mut v89, mut v90): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v91: US0 = v89.borrow().l0.clone();
        let mut v96: i32 = match &v91 {
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
        };
        let mut v97: bool = v87.borrow().l0.clone();
        let mut v98: bool = v97 == false;
        let mut v100: bool = if v98 {
            false
        } else {
            let mut v99: bool = 20i32 >= v96;
            v99
        };
        let mut v101: bool = v100 == false;
        let mut v164: US2 = if v101 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v105, mut v106, mut v107, mut v108, mut v109, mut v110): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v111: Rc<str> = method3(v105.clone(), v106.clone(), v107.clone(), v108.clone(), v109.clone(), v110.clone());
            let mut v112: Rc<str> = method4();
            let mut v113: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1)).s() });
            let mut v120: Rc<str> = Rc::<str>::from(match &v82 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v131: Rc<str> = method79(v105.clone(), v106.clone(), v107.clone(), v108.clone(), v109.clone(), v110.clone(), v111.clone(), v112.clone(), v0, v113.clone(), v120.clone());
            { let _ = spiral_trace_hold(&v3); };
            let (mut v134, mut v135, mut v136, mut v137, mut v138, mut v139): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v140: i64 = v134.borrow().l0.clone();
            let mut v141: i64 = v140.wrapping_add(1i64);
            v134.borrow_mut().l0 = v141;
            let mut v142: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v143: bool = cfg!(target_arch = "wasm32");
            if v143 {
                let mut v144: Rc<str> = v137.borrow().l0.clone();
                let mut v145: bool = v144.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v153: Rc<str> = if v145 {
                    v131.clone()
                } else {
                    let mut v146: bool = v131.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v146 {
                        let mut v147: Rc<str> = v137.borrow().l0.clone();
                        v147.clone()
                    } else {
                        let mut v148: Rc<str> = v137.borrow().l0.clone();
                        let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v150: Rc<str> = Rc::<str>::from(format!("{}{}", v148, v149));
                        let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v150, v131));
                        v151.clone()
                    }
                };
                let mut v155: i32 = ((v153.chars().count() + 14999) / 15000) as i32;
                let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v157: bool = v131 != v156 ;
                let mut v159: bool = if v157 {
                    let mut v158: bool = v155 <= 1i32;
                    v158
                } else {
                    false
                };
                if v159 {
                    v137.borrow_mut().l0 = v153.clone();
                    ()
                } else {
                    v137.borrow_mut().l0 = v156.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v153); };
                    ()
                }
            } else {
                println!("{}", v131);
                ()
            };
            let mut v162: Rc<dyn Fn(Rc<str>) -> ()> = v135.borrow().l0.clone();
            v162(v131.clone());
            US2::US2_0(v134.clone(), v135.clone(), v136.clone(), v137.clone(), v138.clone(), v139.clone())
        };
        let mut v165: Rc<dyn Fn() -> ()> = method81();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v168, mut v169, mut v170, mut v171, mut v172, mut v173): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v174: US0 = v172.borrow().l0.clone();
        let mut v179: i32 = match &v174 {
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
        };
        let mut v180: bool = v170.borrow().l0.clone();
        let mut v181: bool = v180 == false;
        let mut v183: bool = if v181 {
            false
        } else {
            let mut v182: bool = 20i32 >= v179;
            v182
        };
        let mut v184: bool = v183 == false;
        let mut v228: US2 = if v184 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v188, mut v189, mut v190, mut v191, mut v192, mut v193): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v194: Rc<str> = method3(v188.clone(), v189.clone(), v190.clone(), v191.clone(), v192.clone(), v193.clone());
            let mut v195: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v198, mut v199, mut v200, mut v201, mut v202, mut v203): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v204: i64 = v198.borrow().l0.clone();
            let mut v205: i64 = v204.wrapping_add(1i64);
            v198.borrow_mut().l0 = v205;
            let mut v206: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v207: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v208: bool = cfg!(target_arch = "wasm32");
            if v208 {
                let mut v209: Rc<str> = v201.borrow().l0.clone();
                let mut v210: bool = v209.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v218: Rc<str> = if v210 {
                    v206.clone()
                } else {
                    let mut v211: bool = v206.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v211 {
                        let mut v212: Rc<str> = v201.borrow().l0.clone();
                        v212.clone()
                    } else {
                        let mut v213: Rc<str> = v201.borrow().l0.clone();
                        let mut v214: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v215: Rc<str> = Rc::<str>::from(format!("{}{}", v213, v214));
                        let mut v216: Rc<str> = Rc::<str>::from(format!("{}{}", v215, v206));
                        v216.clone()
                    }
                };
                let mut v220: i32 = ((v218.chars().count() + 14999) / 15000) as i32;
                let mut v221: bool = v206 != v206 ;
                let mut v223: bool = if v221 {
                    let mut v222: bool = v220 <= 1i32;
                    v222
                } else {
                    false
                };
                if v223 {
                    v201.borrow_mut().l0 = v218.clone();
                    ()
                } else {
                    v201.borrow_mut().l0 = v206.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v218); };
                    ()
                }
            } else {
                println!("{}", v206);
                ()
            };
            let mut v226: Rc<dyn Fn(Rc<str>) -> ()> = v199.borrow().l0.clone();
            v226(v206.clone());
            US2::US2_0(v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone(), v203.clone())
        };
        v82.clone()
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
