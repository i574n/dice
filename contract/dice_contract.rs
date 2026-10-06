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
        let mut v84: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v84); };
        let mut v167: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v168, mut v169, mut v170, mut v171, mut v172, mut v173): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v167) };
        let mut v194: US0 = US0::US0_2;
        v172.borrow_mut().l0 = v194.clone();
        let mut v213: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("seeds"); } LIT.with(|lit| lit.clone()) };
        let mut v214: &[u8] = { let owned: Rc<str> = (v213).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v229: SpiralNearVec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::store::vec::Vector::new(v214); #[cfg(not(target_arch = "wasm32"))] let v = SpiralNearVec(<std::vec::Vec<u8>>::new()); v };
        (2u32, v229)
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v7: Rc<str> = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; let mut buf = String::new(); let push = |buf: &mut String, n: u64| { if n < 10 { buf.push(char::from(48)); } buf.push_str(&n.to_string()); }; push(&mut buf, h); buf.push(char::from(58)); push(&mut buf, m); buf.push(char::from(58)); push(&mut buf, s); Rc::<str>::from(buf) };
    v7.clone()
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
    let mut v4: Rc<str> = method5(v3);
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
    let mut v5: Rc<str> = string_slice(&v0.clone(), v3 as i64, v4 as i64);
    let mut v6: i32 = (v5.clone().len() as i32);
    let mut v7: i32 = method10(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5.clone(), 0i32 as i64, v7 as i64);
    v8.clone()
}
fn method11(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
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
    let mut v4: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v3.clone(), v4.clone());
    method16(v3.clone());
    method17(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method18(v3.clone());
    let mut v5: Rc<str> = v3.borrow().l0.clone();
    v5.clone()
}
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = method11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.contribute_seed"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = method12(v8, v9.clone());
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    method8(v22.clone())
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
        let mut v37: u32 = ((v0).len() as u32);
        let mut v212: i32 = (v37 as i32);
        let mut v328: usize = ((100i32) as usize);
        let mut v446: i32 = (v328 as i32);
        let mut v450: i32 = v212 - v446;
        let mut v451: bool = v450 > 0i32;
        if v451 {
            let mut v453: Vec<u8> = v0.drain(0..v450 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v1031, mut v1032, mut v1033, mut v1034, mut v1035, mut v1036): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v1037: US0 = v1035.borrow().l0.clone();
            let mut v1042: i32 = match &v1037 {
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
            let mut v1043: bool = v1033.borrow().l0.clone();
            let mut v1044: bool = v1043 == false;
            let mut v1046: bool = if v1044 {
                false
            } else {
                let mut v1045: bool = 20i32 >= v1042;
                v1045
            };
            let mut v1047: bool = v1046 == false;
            let mut v1093: US2 = if v1047 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v3); };
                let (mut v1051, mut v1052, mut v1053, mut v1054, mut v1055, mut v1056): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v1057: Rc<str> = method3(v1051.clone(), v1052.clone(), v1053.clone(), v1054.clone(), v1055.clone(), v1056.clone());
                let mut v1058: Rc<str> = method4();
                let mut v1059: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v453)).s() });
                let mut v1060: Rc<str> = method7(v1051.clone(), v1052.clone(), v1053.clone(), v1054.clone(), v1055.clone(), v1056.clone(), v1057.clone(), v1058.clone(), v450, v1059.clone());
                { let _ = spiral_trace_hold(&v3); };
                let (mut v1063, mut v1064, mut v1065, mut v1066, mut v1067, mut v1068): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
                let mut v1069: i64 = v1063.borrow().l0.clone();
                let mut v1070: i64 = v1069 + 1i64;
                v1063.borrow_mut().l0 = v1070;
                let mut v1071: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v1072: bool = cfg!(target_arch = "wasm32");
                if v1072 {
                    let mut v1073: Rc<str> = v1066.borrow().l0.clone();
                    let mut v1074: bool = v1073.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v1082: Rc<str> = if v1074 {
                        v1060.clone()
                    } else {
                        let mut v1075: bool = v1060.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v1075 {
                            let mut v1076: Rc<str> = v1066.borrow().l0.clone();
                            v1076.clone()
                        } else {
                            let mut v1077: Rc<str> = v1066.borrow().l0.clone();
                            let mut v1078: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v1079: Rc<str> = Rc::<str>::from(format!("{}{}", v1077, v1078));
                            let mut v1080: Rc<str> = Rc::<str>::from(format!("{}{}", v1079, v1060));
                            v1080.clone()
                        }
                    };
                    let mut v1084: i32 = ((v1082.chars().count() + 14999) / 15000) as i32;
                    let mut v1085: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v1086: bool = v1060 != v1085 ;
                    let mut v1088: bool = if v1086 {
                        let mut v1087: bool = v1084 <= 1i32;
                        v1087
                    } else {
                        false
                    };
                    if v1088 {
                        v1066.borrow_mut().l0 = v1082.clone();
                        ()
                    } else {
                        v1066.borrow_mut().l0 = v1085.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1082); };
                        ()
                    }
                } else {
                    println!("{}", v1060);
                    ()
                };
                let mut v1091: Rc<dyn Fn(Rc<str>) -> ()> = v1064.borrow().l0.clone();
                v1091(v1060.clone());
                US2::US2_0(v1063.clone(), v1064.clone(), v1065.clone(), v1066.clone(), v1067.clone(), v1068.clone())
            };
            ()
        };
        let mut v1139: Rc<dyn Fn() -> ()> = method19();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v1288, mut v1289, mut v1290, mut v1291, mut v1292, mut v1293): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v1294: US0 = v1292.borrow().l0.clone();
        let mut v1299: i32 = match &v1294 {
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
        let mut v1300: bool = v1290.borrow().l0.clone();
        let mut v1301: bool = v1300 == false;
        let mut v1303: bool = if v1301 {
            false
        } else {
            let mut v1302: bool = 20i32 >= v1299;
            v1302
        };
        let mut v1304: bool = v1303 == false;
        let mut v1348: US2 = if v1304 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v1308, mut v1309, mut v1310, mut v1311, mut v1312, mut v1313): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v1314: Rc<str> = method3(v1308.clone(), v1309.clone(), v1310.clone(), v1311.clone(), v1312.clone(), v1313.clone());
            let mut v1315: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v1318, mut v1319, mut v1320, mut v1321, mut v1322, mut v1323): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v1324: i64 = v1318.borrow().l0.clone();
            let mut v1325: i64 = v1324 + 1i64;
            v1318.borrow_mut().l0 = v1325;
            let mut v1326: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1327: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v1328: bool = cfg!(target_arch = "wasm32");
            if v1328 {
                let mut v1329: Rc<str> = v1321.borrow().l0.clone();
                let mut v1330: bool = v1329.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1338: Rc<str> = if v1330 {
                    v1326.clone()
                } else {
                    let mut v1331: bool = v1326.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1331 {
                        let mut v1332: Rc<str> = v1321.borrow().l0.clone();
                        v1332.clone()
                    } else {
                        let mut v1333: Rc<str> = v1321.borrow().l0.clone();
                        let mut v1334: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1335: Rc<str> = Rc::<str>::from(format!("{}{}", v1333, v1334));
                        let mut v1336: Rc<str> = Rc::<str>::from(format!("{}{}", v1335, v1326));
                        v1336.clone()
                    }
                };
                let mut v1340: i32 = ((v1338.chars().count() + 14999) / 15000) as i32;
                let mut v1341: bool = v1326 != v1326 ;
                let mut v1343: bool = if v1341 {
                    let mut v1342: bool = v1340 <= 1i32;
                    v1342
                } else {
                    false
                };
                if v1343 {
                    v1321.borrow_mut().l0 = v1338.clone();
                    ()
                } else {
                    v1321.borrow_mut().l0 = v1326.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1338); };
                    ()
                }
            } else {
                println!("{}", v1326);
                ()
            };
            let mut v1346: Rc<dyn Fn(Rc<str>) -> ()> = v1319.borrow().l0.clone();
            v1346(v1326.clone());
            US2::US2_0(v1318.clone(), v1319.clone(), v1320.clone(), v1321.clone(), v1322.clone(), v1323.clone())
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
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v16.clone(), v17.clone());
    method16(v16.clone());
    method29(v16.clone());
    method15(v16.clone());
    let mut v19: std::string::String = format!("{:#?}", v1);
    let mut v21: Rc<str> = Rc::<str>::from(v19);
    method6(v16.clone(), v21.clone());
    method16(v16.clone());
    method30(v16.clone());
    method15(v16.clone());
    let mut v23: std::string::String = format!("{:#?}", v2);
    let mut v25: Rc<str> = Rc::<str>::from(v23);
    method6(v16.clone(), v25.clone());
    method16(v16.clone());
    method31(v16.clone());
    method15(v16.clone());
    let mut v26: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v16.clone(), v26.clone());
    method16(v16.clone());
    method32(v16.clone());
    method15(v16.clone());
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}", v4));
    method6(v16.clone(), v27.clone());
    method16(v16.clone());
    method33(v16.clone());
    method15(v16.clone());
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}", v5));
    method6(v16.clone(), v28.clone());
    method16(v16.clone());
    method34(v16.clone());
    method15(v16.clone());
    method6(v16.clone(), v6.clone());
    method16(v16.clone());
    method35(v16.clone());
    method15(v16.clone());
    let mut v30: std::string::String = format!("{:#?}", v7);
    let mut v32: Rc<str> = Rc::<str>::from(v30);
    method6(v16.clone(), v32.clone());
    method16(v16.clone());
    method36(v16.clone());
    method15(v16.clone());
    let mut v34: std::string::String = format!("{:#?}", v8);
    let mut v36: Rc<str> = Rc::<str>::from(v34);
    method6(v16.clone(), v36.clone());
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
    let mut v38: std::string::String = format!("{:#?}", v11);
    let mut v40: Rc<str> = Rc::<str>::from(v38);
    method6(v16.clone(), v40.clone());
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
    let mut v41: Rc<str> = v16.borrow().l0.clone();
    v41.clone()
}
fn method26(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: std::string::String, mut v10: std::string::String, mut v11: u64, mut v12: u64, mut v13: u64, mut v14: Rc<str>, mut v15: std::string::String, mut v16: std::string::String, mut v17: Rc<str>, mut v18: Rc<str>, mut v19: usize, mut v20: Rc<str>, mut v21: Rc<str>, mut v22: Rc<str>) -> Rc<str> {
    let mut v23: i64 = v0.borrow().l0.clone();
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v24));
    let mut v26: Rc<str> = method11(v23);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v7));
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v24));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.generate_random_number"); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = method27(v8, v9.clone(), v10.clone(), v11, v12, v13, v14.clone(), v15.clone(), v16.clone(), v17.clone(), v18.clone(), v19.clone(), v20.clone(), v21.clone(), v22.clone());
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v34));
    method8(v35.clone())
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
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v6.clone());
    method16(v4.clone());
    method51(v4.clone());
    method15(v4.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v7.clone());
    method18(v4.clone());
    let mut v8: Rc<str> = v4.borrow().l0.clone();
    v8.clone()
}
fn method48(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: u64, mut v9: u64, mut v10: i8) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method49(v8, v9, v10);
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
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
            let mut v190: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
            { let _ = spiral_trace_hold(&v190); };
            let mut v192: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v193, mut v194, mut v195, mut v196, mut v197, mut v198): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v192) };
            let mut v199: US0 = v197.borrow().l0.clone();
            let mut v204: i32 = match &v199 {
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
            let mut v205: bool = v195.borrow().l0.clone();
            let mut v206: bool = v205 == false;
            let mut v208: bool = if v206 {
                false
            } else {
                let mut v207: bool = 20i32 >= v204;
                v207
            };
            let mut v209: bool = v208 == false;
            let mut v254: US2 = if v209 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v190); };
                let (mut v213, mut v214, mut v215, mut v216, mut v217, mut v218): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v192) };
                let mut v219: Rc<str> = method3(v213.clone(), v214.clone(), v215.clone(), v216.clone(), v217.clone(), v218.clone());
                let mut v220: Rc<str> = method4();
                let mut v221: Rc<str> = method48(v213.clone(), v214.clone(), v215.clone(), v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone(), v0, v2, v1);
                { let _ = spiral_trace_hold(&v190); };
                let (mut v224, mut v225, mut v226, mut v227, mut v228, mut v229): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v192) };
                let mut v230: i64 = v224.borrow().l0.clone();
                let mut v231: i64 = v230 + 1i64;
                v224.borrow_mut().l0 = v231;
                let mut v232: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v233: bool = cfg!(target_arch = "wasm32");
                if v233 {
                    let mut v234: Rc<str> = v227.borrow().l0.clone();
                    let mut v235: bool = v234.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v243: Rc<str> = if v235 {
                        v221.clone()
                    } else {
                        let mut v236: bool = v221.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v236 {
                            let mut v237: Rc<str> = v227.borrow().l0.clone();
                            v237.clone()
                        } else {
                            let mut v238: Rc<str> = v227.borrow().l0.clone();
                            let mut v239: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v240: Rc<str> = Rc::<str>::from(format!("{}{}", v238, v239));
                            let mut v241: Rc<str> = Rc::<str>::from(format!("{}{}", v240, v221));
                            v241.clone()
                        }
                    };
                    let mut v245: i32 = ((v243.chars().count() + 14999) / 15000) as i32;
                    let mut v246: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v247: bool = v221 != v246 ;
                    let mut v249: bool = if v247 {
                        let mut v248: bool = v245 <= 1i32;
                        v248
                    } else {
                        false
                    };
                    if v249 {
                        v227.borrow_mut().l0 = v243.clone();
                        ()
                    } else {
                        v227.borrow_mut().l0 = v246.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v243); };
                        ()
                    }
                } else {
                    println!("{}", v221);
                    ()
                };
                let mut v252: Rc<dyn Fn(Rc<str>) -> ()> = v225.borrow().l0.clone();
                v252(v221.clone());
                US2::US2_0(v224.clone(), v225.clone(), v226.clone(), v227.clone(), v228.clone(), v229.clone())
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
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v5.clone(), v6.clone());
    method16(v5.clone());
    method57(v5.clone());
    method15(v5.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v5.clone(), v7.clone());
    method16(v5.clone());
    method58(v5.clone());
    method15(v5.clone());
    let mut v8: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v5.clone(), v8.clone());
    method16(v5.clone());
    method59(v5.clone());
    method15(v5.clone());
    method6(v5.clone(), v3.clone());
    method18(v5.clone());
    let mut v9: Rc<str> = v5.borrow().l0.clone();
    v9.clone()
}
fn method54(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: i64, mut v10: i64, mut v11: Rc<str>) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0.clone();
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v13));
    let mut v15: Rc<str> = method11(v12);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v7));
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v13));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll"); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let mut v23: Rc<str> = method55(v8, v9, v10, v11.clone());
    let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
    method8(v24.clone())
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
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.create_sequential_roller / roll / None"); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = method62();
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    method8(v20.clone())
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
        let mut v233: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v233); };
        let mut v235: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v236, mut v237, mut v238, mut v239, mut v240, mut v241): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v235) };
        let mut v242: US0 = v240.borrow().l0.clone();
        let mut v247: i32 = match &v242 {
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
        let mut v248: bool = v238.borrow().l0.clone();
        let mut v249: bool = v248 == false;
        let mut v251: bool = if v249 {
            false
        } else {
            let mut v250: bool = 20i32 >= v247;
            v250
        };
        let mut v252: bool = v251 == false;
        let mut v298: US2 = if v252 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v233); };
            let (mut v256, mut v257, mut v258, mut v259, mut v260, mut v261): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v235) };
            let mut v262: Rc<str> = method3(v256.clone(), v257.clone(), v258.clone(), v259.clone(), v260.clone(), v261.clone());
            let mut v263: Rc<str> = method4();
            let mut v264: Rc<str> = Rc::<str>::from(match &v43 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v265: Rc<str> = method54(v256.clone(), v257.clone(), v258.clone(), v259.clone(), v260.clone(), v261.clone(), v262.clone(), v263.clone(), v5, v6, v7, v264.clone());
            { let _ = spiral_trace_hold(&v233); };
            let (mut v268, mut v269, mut v270, mut v271, mut v272, mut v273): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v235) };
            let mut v274: i64 = v268.borrow().l0.clone();
            let mut v275: i64 = v274 + 1i64;
            v268.borrow_mut().l0 = v275;
            let mut v276: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v277: bool = cfg!(target_arch = "wasm32");
            if v277 {
                let mut v278: Rc<str> = v271.borrow().l0.clone();
                let mut v279: bool = v278.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v287: Rc<str> = if v279 {
                    v265.clone()
                } else {
                    let mut v280: bool = v265.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v280 {
                        let mut v281: Rc<str> = v271.borrow().l0.clone();
                        v281.clone()
                    } else {
                        let mut v282: Rc<str> = v271.borrow().l0.clone();
                        let mut v283: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v284: Rc<str> = Rc::<str>::from(format!("{}{}", v282, v283));
                        let mut v285: Rc<str> = Rc::<str>::from(format!("{}{}", v284, v265));
                        v285.clone()
                    }
                };
                let mut v289: i32 = ((v287.chars().count() + 14999) / 15000) as i32;
                let mut v290: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v291: bool = v265 != v290 ;
                let mut v293: bool = if v291 {
                    let mut v292: bool = v289 <= 1i32;
                    v292
                } else {
                    false
                };
                if v293 {
                    v271.borrow_mut().l0 = v287.clone();
                    ()
                } else {
                    v271.borrow_mut().l0 = v290.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v287); };
                    ()
                }
            } else {
                println!("{}", v265);
                ()
            };
            let mut v296: Rc<dyn Fn(Rc<str>) -> ()> = v269.borrow().l0.clone();
            v296(v265.clone());
            US2::US2_0(v268.clone(), v269.clone(), v270.clone(), v271.clone(), v272.clone(), v273.clone())
        };
        let mut v350: Rc<UH1> = v0();
        let mut v351: i64 = v1.borrow().l0.clone();
        let mut v352: US4 = method60(v351, v350.clone());
        match &v352 {
            US4::US4_1 => { // None
                { let _ = spiral_trace_hold(&v233); };
                let (mut v505, mut v506, mut v507, mut v508, mut v509, mut v510): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v235) };
                let mut v511: US0 = v509.borrow().l0.clone();
                let mut v516: i32 = match &v511 {
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
                let mut v517: bool = v507.borrow().l0.clone();
                let mut v518: bool = v517 == false;
                let mut v520: bool = if v518 {
                    false
                } else {
                    let mut v519: bool = 20i32 >= v516;
                    v519
                };
                let mut v521: bool = v520 == false;
                let mut v566: US2 = if v521 {
                    US2::US2_1
                } else {
                    { let _ = spiral_trace_hold(&v233); };
                    let (mut v525, mut v526, mut v527, mut v528, mut v529, mut v530): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v235) };
                    let mut v531: Rc<str> = method3(v525.clone(), v526.clone(), v527.clone(), v528.clone(), v529.clone(), v530.clone());
                    let mut v532: Rc<str> = method4();
                    let mut v533: Rc<str> = method61(v525.clone(), v526.clone(), v527.clone(), v528.clone(), v529.clone(), v530.clone(), v531.clone(), v532.clone());
                    { let _ = spiral_trace_hold(&v233); };
                    let (mut v536, mut v537, mut v538, mut v539, mut v540, mut v541): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v235) };
                    let mut v542: i64 = v536.borrow().l0.clone();
                    let mut v543: i64 = v542 + 1i64;
                    v536.borrow_mut().l0 = v543;
                    let mut v544: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                    let mut v545: bool = cfg!(target_arch = "wasm32");
                    if v545 {
                        let mut v546: Rc<str> = v539.borrow().l0.clone();
                        let mut v547: bool = v546.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v555: Rc<str> = if v547 {
                            v533.clone()
                        } else {
                            let mut v548: bool = v533.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v548 {
                                let mut v549: Rc<str> = v539.borrow().l0.clone();
                                v549.clone()
                            } else {
                                let mut v550: Rc<str> = v539.borrow().l0.clone();
                                let mut v551: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v552: Rc<str> = Rc::<str>::from(format!("{}{}", v550, v551));
                                let mut v553: Rc<str> = Rc::<str>::from(format!("{}{}", v552, v533));
                                v553.clone()
                            }
                        };
                        let mut v557: i32 = ((v555.chars().count() + 14999) / 15000) as i32;
                        let mut v558: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v559: bool = v533 != v558 ;
                        let mut v561: bool = if v559 {
                            let mut v560: bool = v557 <= 1i32;
                            v560
                        } else {
                            false
                        };
                        if v561 {
                            v539.borrow_mut().l0 = v555.clone();
                            ()
                        } else {
                            v539.borrow_mut().l0 = v558.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v555); };
                            ()
                        }
                    } else {
                        println!("{}", v533);
                        ()
                    };
                    let mut v564: Rc<dyn Fn(Rc<str>) -> ()> = v537.borrow().l0.clone();
                    v564(v533.clone());
                    US2::US2_0(v536.clone(), v537.clone(), v538.clone(), v539.clone(), v540.clone(), v541.clone())
                };
                let mut v611: i64 = v3.borrow().l0.clone();
                let mut v612: bool = v611 == -1i64;
                if v612 {
                    let mut v613: i64 = v1.borrow().l0.clone();
                    v3.borrow_mut().l0 = v613;
                    ()
                };
                let mut v614: i64 = v2.borrow().l0.clone();
                let mut v615: i64 = v3.borrow().l0.clone();
                let mut v616: bool = v614 >= v615;
                let mut v619: i64 = if v616 {
                    1i64
                } else {
                    let mut v617: i64 = v2.borrow().l0.clone();
                    let mut v618: i64 = v617 + 1i64;
                    v618
                };
                v2.borrow_mut().l0 = v619;
                let mut v620: i64 = v2.borrow().l0.clone();
                let mut v621: i64 = v620 - 1i64;
                v1.borrow_mut().l0 = v621;
                let mut v622: US4 = US4::US4_1;
                v4.borrow_mut().l0 = v622.clone();
                (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone());
                continue;
            }
            US4::US4_0(v353) => { // Some
                let mut v353: u8 = v353.clone();
                let mut v354: i64 = v1.borrow().l0.clone();
                let mut v355: i64 = v354 + 1i64;
                v1.borrow_mut().l0 = v355;
                let mut v356: US4 = US4::US4_0(v353);
                v4.borrow_mut().l0 = v356.clone();
                return v353;
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
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v5.clone());
    method16(v4.clone());
    method57(v4.clone());
    method15(v4.clone());
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v6.clone());
    method16(v4.clone());
    method67(v4.clone());
    method15(v4.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v7.clone());
    method18(v4.clone());
    let mut v8: Rc<str> = v4.borrow().l0.clone();
    v8.clone()
}
fn method64(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i8, mut v9: u64, mut v10: u64) -> Rc<str> {
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
    let mut v22: Rc<str> = method65(v8, v9, v10);
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
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
    let mut v8: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v5.clone(), v8.clone());
    method16(v5.clone());
    method72(v5.clone());
    method15(v5.clone());
    let mut v9: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v5.clone(), v9.clone());
    method18(v5.clone());
    let mut v10: Rc<str> = v5.borrow().l0.clone();
    v10.clone()
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
            let mut v152: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
            { let _ = spiral_trace_hold(&v152); };
            let mut v154: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v155, mut v156, mut v157, mut v158, mut v159, mut v160): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v154) };
            let mut v161: US0 = v159.borrow().l0.clone();
            let mut v166: i32 = match &v161 {
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
            let mut v167: bool = v157.borrow().l0.clone();
            let mut v168: bool = v167 == false;
            let mut v170: bool = if v168 {
                false
            } else {
                let mut v169: bool = 20i32 >= v166;
                v169
            };
            let mut v171: bool = v170 == false;
            let mut v216: US2 = if v171 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v152); };
                let (mut v175, mut v176, mut v177, mut v178, mut v179, mut v180): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v154) };
                let mut v181: Rc<str> = method3(v175.clone(), v176.clone(), v177.clone(), v178.clone(), v179.clone(), v180.clone());
                let mut v182: Rc<str> = method4();
                let mut v183: Rc<str> = method64(v175.clone(), v176.clone(), v177.clone(), v178.clone(), v179.clone(), v180.clone(), v181.clone(), v182.clone(), v0, v2, v4);
                { let _ = spiral_trace_hold(&v152); };
                let (mut v186, mut v187, mut v188, mut v189, mut v190, mut v191): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v154) };
                let mut v192: i64 = v186.borrow().l0.clone();
                let mut v193: i64 = v192 + 1i64;
                v186.borrow_mut().l0 = v193;
                let mut v194: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v195: bool = cfg!(target_arch = "wasm32");
                if v195 {
                    let mut v196: Rc<str> = v189.borrow().l0.clone();
                    let mut v197: bool = v196.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v205: Rc<str> = if v197 {
                        v183.clone()
                    } else {
                        let mut v198: bool = v183.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v198 {
                            let mut v199: Rc<str> = v189.borrow().l0.clone();
                            v199.clone()
                        } else {
                            let mut v200: Rc<str> = v189.borrow().l0.clone();
                            let mut v201: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v202: Rc<str> = Rc::<str>::from(format!("{}{}", v200, v201));
                            let mut v203: Rc<str> = Rc::<str>::from(format!("{}{}", v202, v183));
                            v203.clone()
                        }
                    };
                    let mut v207: i32 = ((v205.chars().count() + 14999) / 15000) as i32;
                    let mut v208: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v209: bool = v183 != v208 ;
                    let mut v211: bool = if v209 {
                        let mut v210: bool = v207 <= 1i32;
                        v210
                    } else {
                        false
                    };
                    if v211 {
                        v189.borrow_mut().l0 = v205.clone();
                        ()
                    } else {
                        v189.borrow_mut().l0 = v208.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v205); };
                        ()
                    }
                } else {
                    println!("{}", v183);
                    ()
                };
                let mut v214: Rc<dyn Fn(Rc<str>) -> ()> = v187.borrow().l0.clone();
                v214(v183.clone());
                US2::US2_0(v186.clone(), v187.clone(), v188.clone(), v189.clone(), v190.clone(), v191.clone())
            };
            return US5::US5_0(v4, v1.clone());
        } else {
            match &*v1 {
                UH0::UH0_1(v263, v264) => { // Cons
                    let mut v263: u8 = v263.clone();
                    let mut v264: Rc<UH0> = v264.clone();
                    let mut v265: bool = v263 > 1u8;
                    if v265 {
                        let mut v266: u64 = 1u64;
                        let mut v267: Rc<dyn Fn() -> Rc<UH2>> = closure12();
                        let mut v268: Rc<UH2> = Rc::new(UH2::UH2_0(v266, v267.clone()));
                        let mut v269: US6 = method68(v0, v268.clone());
                        let mut v273: u64 = match &v269 {
                            US6::US6_1 => { // None
                                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
                            }
                            US6::US6_0(v270) => { // Some
                                let mut v270: u64 = v270.clone();
                                v270
                            }
                            _ => unreachable!(),
                        };
                        let mut v274: u8 = v263 - 1u8;
                        let mut v275: u64 = (v274 as u64);
                        let mut v276: u64 = v275 * v273;
                        let mut v424: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
                        { let _ = spiral_trace_hold(&v424); };
                        let mut v426: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v427, mut v428, mut v429, mut v430, mut v431, mut v432): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v426) };
                        let mut v433: US0 = v431.borrow().l0.clone();
                        let mut v438: i32 = match &v433 {
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
                        let mut v439: bool = v429.borrow().l0.clone();
                        let mut v440: bool = v439 == false;
                        let mut v442: bool = if v440 {
                            false
                        } else {
                            let mut v441: bool = 20i32 >= v438;
                            v441
                        };
                        let mut v443: bool = v442 == false;
                        let mut v488: US2 = if v443 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v424); };
                            let (mut v447, mut v448, mut v449, mut v450, mut v451, mut v452): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v426) };
                            let mut v453: Rc<str> = method3(v447.clone(), v448.clone(), v449.clone(), v450.clone(), v451.clone(), v452.clone());
                            let mut v454: Rc<str> = method4();
                            let mut v455: Rc<str> = method69(v447.clone(), v448.clone(), v449.clone(), v450.clone(), v451.clone(), v452.clone(), v453.clone(), v454.clone(), v0, v2, v263, v276);
                            { let _ = spiral_trace_hold(&v424); };
                            let (mut v458, mut v459, mut v460, mut v461, mut v462, mut v463): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v426) };
                            let mut v464: i64 = v458.borrow().l0.clone();
                            let mut v465: i64 = v464 + 1i64;
                            v458.borrow_mut().l0 = v465;
                            let mut v466: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let mut v467: bool = cfg!(target_arch = "wasm32");
                            if v467 {
                                let mut v468: Rc<str> = v461.borrow().l0.clone();
                                let mut v469: bool = v468.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v477: Rc<str> = if v469 {
                                    v455.clone()
                                } else {
                                    let mut v470: bool = v455.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v470 {
                                        let mut v471: Rc<str> = v461.borrow().l0.clone();
                                        v471.clone()
                                    } else {
                                        let mut v472: Rc<str> = v461.borrow().l0.clone();
                                        let mut v473: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v474: Rc<str> = Rc::<str>::from(format!("{}{}", v472, v473));
                                        let mut v475: Rc<str> = Rc::<str>::from(format!("{}{}", v474, v455));
                                        v475.clone()
                                    }
                                };
                                let mut v479: i32 = ((v477.chars().count() + 14999) / 15000) as i32;
                                let mut v480: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v481: bool = v455 != v480 ;
                                let mut v483: bool = if v481 {
                                    let mut v482: bool = v479 <= 1i32;
                                    v482
                                } else {
                                    false
                                };
                                if v483 {
                                    v461.borrow_mut().l0 = v477.clone();
                                    ()
                                } else {
                                    v461.borrow_mut().l0 = v480.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v477); };
                                    ()
                                }
                            } else {
                                println!("{}", v455);
                                ()
                            };
                            let mut v486: Rc<dyn Fn(Rc<str>) -> ()> = v459.borrow().l0.clone();
                            v486(v455.clone());
                            US2::US2_0(v458.clone(), v459.clone(), v460.clone(), v461.clone(), v462.clone(), v463.clone())
                        };
                        let mut v533: u64 = v2 + v276;
                        let mut v534: i8 = v0 - 1i8;
                        (v0, v1, v2) = (v534, v264.clone(), v533);
                        continue;
                    } else {
                        let mut v683: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
                        { let _ = spiral_trace_hold(&v683); };
                        let mut v685: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v686, mut v687, mut v688, mut v689, mut v690, mut v691): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v685) };
                        let mut v692: US0 = v690.borrow().l0.clone();
                        let mut v697: i32 = match &v692 {
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
                        let mut v698: bool = v688.borrow().l0.clone();
                        let mut v699: bool = v698 == false;
                        let mut v701: bool = if v699 {
                            false
                        } else {
                            let mut v700: bool = 20i32 >= v697;
                            v700
                        };
                        let mut v702: bool = v701 == false;
                        let mut v747: US2 = if v702 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v683); };
                            let (mut v706, mut v707, mut v708, mut v709, mut v710, mut v711): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v685) };
                            let mut v712: Rc<str> = method3(v706.clone(), v707.clone(), v708.clone(), v709.clone(), v710.clone(), v711.clone());
                            let mut v713: Rc<str> = method4();
                            let mut v714: Rc<str> = method73(v706.clone(), v707.clone(), v708.clone(), v709.clone(), v710.clone(), v711.clone(), v712.clone(), v713.clone(), v0, v2, v263);
                            { let _ = spiral_trace_hold(&v683); };
                            let (mut v717, mut v718, mut v719, mut v720, mut v721, mut v722): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v685) };
                            let mut v723: i64 = v717.borrow().l0.clone();
                            let mut v724: i64 = v723 + 1i64;
                            v717.borrow_mut().l0 = v724;
                            let mut v725: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let mut v726: bool = cfg!(target_arch = "wasm32");
                            if v726 {
                                let mut v727: Rc<str> = v720.borrow().l0.clone();
                                let mut v728: bool = v727.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v736: Rc<str> = if v728 {
                                    v714.clone()
                                } else {
                                    let mut v729: bool = v714.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v729 {
                                        let mut v730: Rc<str> = v720.borrow().l0.clone();
                                        v730.clone()
                                    } else {
                                        let mut v731: Rc<str> = v720.borrow().l0.clone();
                                        let mut v732: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v733: Rc<str> = Rc::<str>::from(format!("{}{}", v731, v732));
                                        let mut v734: Rc<str> = Rc::<str>::from(format!("{}{}", v733, v714));
                                        v734.clone()
                                    }
                                };
                                let mut v738: i32 = ((v736.chars().count() + 14999) / 15000) as i32;
                                let mut v739: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v740: bool = v714 != v739 ;
                                let mut v742: bool = if v740 {
                                    let mut v741: bool = v738 <= 1i32;
                                    v741
                                } else {
                                    false
                                };
                                if v742 {
                                    v720.borrow_mut().l0 = v736.clone();
                                    ()
                                } else {
                                    v720.borrow_mut().l0 = v739.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v736); };
                                    ()
                                }
                            } else {
                                println!("{}", v714);
                                ()
                            };
                            let mut v745: Rc<dyn Fn(Rc<str>) -> ()> = v718.borrow().l0.clone();
                            v745(v714.clone());
                            US2::US2_0(v717.clone(), v718.clone(), v719.clone(), v720.clone(), v721.clone(), v722.clone())
                        };
                        let mut v792: i8 = v0 - 1i8;
                        (v0, v1, v2) = (v792, v264.clone(), v2);
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
        let mut v25: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::random_seed(); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        let mut v40: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::epoch_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v55: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_height(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v62: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_timestamp(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        let mut v73: u128 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::account_balance().as_yoctonear(); #[cfg(not(target_arch = "wasm32"))] let v = 1u128; v };
        let mut v88: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::signer_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v103: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::predecessor_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v119: &SpiralNearVec<u8> = &*v0;
        let mut v134: Vec<u8> = (v119).iter().cloned().collect::<std::vec::Vec<_>>();
        let mut v149: _ = (v40).to_le_bytes().to_vec();
        let mut v164: Vec<u8> = (v149).clone();
        let mut v169: _ = (v55).to_le_bytes().to_vec();
        let mut v170: Vec<u8> = (v169).clone();
        let mut v171: _ = (v62).to_le_bytes().to_vec();
        let mut v172: Vec<u8> = (v171).clone();
        let mut v183: u128 = (v73.clone());
        let mut v198: _ = (v183).to_le_bytes().to_vec();
        let mut v203: Vec<u8> = (v198).clone();
        let mut v214: &[u8] = (v88).as_bytes();
        let mut v229: Vec<u8> = (v214).to_vec();
        let mut v234: &[u8] = (v103).as_bytes();
        let mut v235: Vec<u8> = (v234).to_vec();
        let mut v246: Vec<u8> = (v2).as_bytes().to_vec();
        let mut v251: Vec<u8> = (v1).as_bytes().to_vec();
        let mut v252: Rc<RefCell<Vec<Vec<u8>>>> = Rc::new(RefCell::new(vec![v25.clone(), v134.clone(), v164.clone(), v170.clone(), v172.clone(), v203.clone(), v229.clone(), v235.clone(), v246.clone(), v251.clone()]));
        let mut v263: Vec<Vec<u8>> = (v252).borrow().clone();
        let mut v278: Vec<u8> = (v263).concat();
        let mut v293: Vec<u8> = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::keccak512(&(v278.clone())); #[cfg(not(target_arch = "wasm32"))] let v = <std::vec::Vec<u8>>::from([1u8, 5, 4, 4, 5]); v };
        { (v0).extend((v293).clone()); };
        let mut v298: u32 = ((v0).len() as u32);
        let mut v299: i32 = (v298 as i32);
        let mut v300: usize = ((100i32) as usize);
        let mut v301: i32 = (v300 as i32);
        let mut v302: i32 = v299 - v301;
        let mut v303: bool = v302 > 0i32;
        if v303 {
            let mut v305: Vec<u8> = v0.drain(0..v302 as u32).collect::<Vec<_>>();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v308, mut v309, mut v310, mut v311, mut v312, mut v313): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v314: US0 = v312.borrow().l0.clone();
            let mut v319: i32 = match &v314 {
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
            let mut v320: bool = v310.borrow().l0.clone();
            let mut v321: bool = v320 == false;
            let mut v323: bool = if v321 {
                false
            } else {
                let mut v322: bool = 20i32 >= v319;
                v322
            };
            let mut v324: bool = v323 == false;
            let mut v370: US2 = if v324 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v5); };
                let (mut v328, mut v329, mut v330, mut v331, mut v332, mut v333): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v334: Rc<str> = method3(v328.clone(), v329.clone(), v330.clone(), v331.clone(), v332.clone(), v333.clone());
                let mut v335: Rc<str> = method4();
                let mut v336: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v305)).s() });
                let mut v337: Rc<str> = method7(v328.clone(), v329.clone(), v330.clone(), v331.clone(), v332.clone(), v333.clone(), v334.clone(), v335.clone(), v302, v336.clone());
                { let _ = spiral_trace_hold(&v5); };
                let (mut v340, mut v341, mut v342, mut v343, mut v344, mut v345): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
                let mut v346: i64 = v340.borrow().l0.clone();
                let mut v347: i64 = v346 + 1i64;
                v340.borrow_mut().l0 = v347;
                let mut v348: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v349: bool = cfg!(target_arch = "wasm32");
                if v349 {
                    let mut v350: Rc<str> = v343.borrow().l0.clone();
                    let mut v351: bool = v350.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v359: Rc<str> = if v351 {
                        v337.clone()
                    } else {
                        let mut v352: bool = v337.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v352 {
                            let mut v353: Rc<str> = v343.borrow().l0.clone();
                            v353.clone()
                        } else {
                            let mut v354: Rc<str> = v343.borrow().l0.clone();
                            let mut v355: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v356: Rc<str> = Rc::<str>::from(format!("{}{}", v354, v355));
                            let mut v357: Rc<str> = Rc::<str>::from(format!("{}{}", v356, v337));
                            v357.clone()
                        }
                    };
                    let mut v361: i32 = ((v359.chars().count() + 14999) / 15000) as i32;
                    let mut v362: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v363: bool = v337 != v362 ;
                    let mut v365: bool = if v363 {
                        let mut v364: bool = v361 <= 1i32;
                        v364
                    } else {
                        false
                    };
                    if v365 {
                        v343.borrow_mut().l0 = v359.clone();
                        ()
                    } else {
                        v343.borrow_mut().l0 = v362.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v359); };
                        ()
                    }
                } else {
                    println!("{}", v337);
                    ()
                };
                let mut v368: Rc<dyn Fn(Rc<str>) -> ()> = v341.borrow().l0.clone();
                v368(v337.clone());
                US2::US2_0(v340.clone(), v341.clone(), v342.clone(), v343.clone(), v344.clone(), v345.clone())
            };
            ()
        };
        let mut v371: Rc<dyn Fn() -> ()> = method19();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v374, mut v375, mut v376, mut v377, mut v378, mut v379): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v380: US0 = v378.borrow().l0.clone();
        let mut v385: i32 = match &v380 {
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
        let mut v386: bool = v376.borrow().l0.clone();
        let mut v387: bool = v386 == false;
        let mut v389: bool = if v387 {
            false
        } else {
            let mut v388: bool = 20i32 >= v385;
            v388
        };
        let mut v390: bool = v389 == false;
        let mut v434: US2 = if v390 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v394, mut v395, mut v396, mut v397, mut v398, mut v399): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v400: Rc<str> = method3(v394.clone(), v395.clone(), v396.clone(), v397.clone(), v398.clone(), v399.clone());
            let mut v401: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v404, mut v405, mut v406, mut v407, mut v408, mut v409): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v410: i64 = v404.borrow().l0.clone();
            let mut v411: i64 = v410 + 1i64;
            v404.borrow_mut().l0 = v411;
            let mut v412: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v413: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v414: bool = cfg!(target_arch = "wasm32");
            if v414 {
                let mut v415: Rc<str> = v407.borrow().l0.clone();
                let mut v416: bool = v415.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v424: Rc<str> = if v416 {
                    v412.clone()
                } else {
                    let mut v417: bool = v412.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v417 {
                        let mut v418: Rc<str> = v407.borrow().l0.clone();
                        v418.clone()
                    } else {
                        let mut v419: Rc<str> = v407.borrow().l0.clone();
                        let mut v420: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v421: Rc<str> = Rc::<str>::from(format!("{}{}", v419, v420));
                        let mut v422: Rc<str> = Rc::<str>::from(format!("{}{}", v421, v412));
                        v422.clone()
                    }
                };
                let mut v426: i32 = ((v424.chars().count() + 14999) / 15000) as i32;
                let mut v427: bool = v412 != v412 ;
                let mut v429: bool = if v427 {
                    let mut v428: bool = v426 <= 1i32;
                    v428
                } else {
                    false
                };
                if v429 {
                    v407.borrow_mut().l0 = v424.clone();
                    ()
                } else {
                    v407.borrow_mut().l0 = v412.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v424); };
                    ()
                }
            } else {
                println!("{}", v412);
                ()
            };
            let mut v432: Rc<dyn Fn(Rc<str>) -> ()> = v405.borrow().l0.clone();
            v432(v412.clone());
            US2::US2_0(v404.clone(), v405.clone(), v406.clone(), v407.clone(), v408.clone(), v409.clone())
        };
        let mut v445: Vec<u8> = method20(v293.clone());
        let mut v446: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(v445));
        let mut v467: Rc<Vec<u8>> = Rc::new((v446).borrow().clone());
        let mut v607: i32 = (v467).len() as i32;
        let mut v608: i32 = v607 - 1i32;
        let mut v609: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v610: Rc<UH0> = method21(v467.clone(), v608, v609.clone());
        let mut v614: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v615: Rc<UH1> = method22(v610.clone(), v614.clone());
        let mut v616: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v617: Rc<UH1> = method23(v615.clone(), v616.clone());
        let mut v618: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v619: Rc<UH0> = method24(v617.clone(), v618.clone());
        { let _ = spiral_trace_hold(&v5); };
        let (mut v987, mut v988, mut v989, mut v990, mut v991, mut v992): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v993: US0 = v991.borrow().l0.clone();
        let mut v998: i32 = match &v993 {
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
        let mut v999: bool = v989.borrow().l0.clone();
        let mut v1000: bool = v999 == false;
        let mut v1002: bool = if v1000 {
            false
        } else {
            let mut v1001: bool = 20i32 >= v998;
            v1001
        };
        let mut v1003: bool = v1002 == false;
        let mut v1065: US2 = if v1003 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1007, mut v1008, mut v1009, mut v1010, mut v1011, mut v1012): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1013: Rc<str> = method3(v1007.clone(), v1008.clone(), v1009.clone(), v1010.clone(), v1011.clone(), v1012.clone());
            let mut v1014: Rc<str> = method4();
            let mut v1015: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<u128>") } } (&&W(&v73)).s() });
            let mut v1017: std::string::String = v88.to_string();
            let mut v1019: std::string::String = v103.to_string();
            let mut v1020: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v25)).s() });
            let mut v1021: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<&mut SpiralNearVec<u8>>") } } (&&W(&v0)).s() });
            let mut v1022: usize = ((v278).len() as usize);
            let mut v1023: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v278)).s() });
            let mut v1024: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v293)).s() });
            let mut v1025: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
            let mut v1026: i32 = 0i32;
            let mut v1027: i32 = method25(v1025.clone(), v619.clone(), v1026);
            let mut v1028: Rc<Vec<u8>> = Rc::new(v1025.borrow().clone());
            let mut v1029: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v1028).as_ref().clone()));
            let mut v1030: Vec<u8> = (v1029).borrow().clone();
            let mut v1031: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1030)).s() });
            let mut v1032: Rc<str> = method26(v1007.clone(), v1008.clone(), v1009.clone(), v1010.clone(), v1011.clone(), v1012.clone(), v1013.clone(), v1014.clone(), v3, v1.clone(), v2.clone(), v62, v55, v40, v1015.clone(), v1017.clone(), v1019.clone(), v1020.clone(), v1021.clone(), v1022.clone(), v1023.clone(), v1024.clone(), v1031.clone());
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1035, mut v1036, mut v1037, mut v1038, mut v1039, mut v1040): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1041: i64 = v1035.borrow().l0.clone();
            let mut v1042: i64 = v1041 + 1i64;
            v1035.borrow_mut().l0 = v1042;
            let mut v1043: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v1044: bool = cfg!(target_arch = "wasm32");
            if v1044 {
                let mut v1045: Rc<str> = v1038.borrow().l0.clone();
                let mut v1046: bool = v1045.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1054: Rc<str> = if v1046 {
                    v1032.clone()
                } else {
                    let mut v1047: bool = v1032.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1047 {
                        let mut v1048: Rc<str> = v1038.borrow().l0.clone();
                        v1048.clone()
                    } else {
                        let mut v1049: Rc<str> = v1038.borrow().l0.clone();
                        let mut v1050: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1051: Rc<str> = Rc::<str>::from(format!("{}{}", v1049, v1050));
                        let mut v1052: Rc<str> = Rc::<str>::from(format!("{}{}", v1051, v1032));
                        v1052.clone()
                    }
                };
                let mut v1056: i32 = ((v1054.chars().count() + 14999) / 15000) as i32;
                let mut v1057: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1058: bool = v1032 != v1057 ;
                let mut v1060: bool = if v1058 {
                    let mut v1059: bool = v1056 <= 1i32;
                    v1059
                } else {
                    false
                };
                if v1060 {
                    v1038.borrow_mut().l0 = v1054.clone();
                    ()
                } else {
                    v1038.borrow_mut().l0 = v1057.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1054); };
                    ()
                }
            } else {
                println!("{}", v1032);
                ()
            };
            let mut v1063: Rc<dyn Fn(Rc<str>) -> ()> = v1036.borrow().l0.clone();
            v1063(v1032.clone());
            US2::US2_0(v1035.clone(), v1036.clone(), v1037.clone(), v1038.clone(), v1039.clone(), v1040.clone())
        };
        let mut v1127: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1128: Rc<UH0> = method43(v619.clone(), v1127.clone());
        let mut v1129: Rc<UH0> = method44(v619.clone(), v1128.clone());
        let mut v1130: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_1); } CASE.with(|case| case.clone()) };
        let mut v1131: Rc<UH1> = method22(v1129.clone(), v1130.clone());
        let mut v1132: Rc<dyn Fn() -> Rc<UH1>> = closure10(v1131.clone());
        let mut v1133: Rc<dyn Fn() -> Rc<UH1>> = method45(v1131.clone(), v1132.clone());
        let mut v1134: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i64 }));
        let mut v1135: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
        let mut v1136: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: -1i64 }));
        let mut v1137: US4 = US4::US4_1;
        let mut v1138: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: v1137.clone() }));
        let mut v1139: bool = v3 == 1u64;
        let mut v1143: i8 = if v1139 {
            1i8
        } else {
            let mut v1140: i8 = 0i8;
            let mut v1141: u64 = 1u64;
            method46(v3, v1140, v1141)
        };
        let mut v1144: i8 = v1143 - 1i8;
        let mut v1145: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
        let mut v1146: i8 = 0i8;
        let mut v1147: u64 = method52(v1133.clone(), v1134.clone(), v1135.clone(), v1136.clone(), v1138.clone(), v3, v1144, v1145.clone(), v1146);
        let mut v1148: Rc<dyn Fn() -> ()> = method77();
        { let _ = spiral_trace_hold(&v5); };
        let (mut v1297, mut v1298, mut v1299, mut v1300, mut v1301, mut v1302): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
        let mut v1303: US0 = v1301.borrow().l0.clone();
        let mut v1308: i32 = match &v1303 {
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
        let mut v1309: bool = v1299.borrow().l0.clone();
        let mut v1310: bool = v1309 == false;
        let mut v1312: bool = if v1310 {
            false
        } else {
            let mut v1311: bool = 20i32 >= v1308;
            v1311
        };
        let mut v1313: bool = v1312 == false;
        let mut v1357: US2 = if v1313 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1317, mut v1318, mut v1319, mut v1320, mut v1321, mut v1322): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1323: Rc<str> = method3(v1317.clone(), v1318.clone(), v1319.clone(), v1320.clone(), v1321.clone(), v1322.clone());
            let mut v1324: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v5); };
            let (mut v1327, mut v1328, mut v1329, mut v1330, mut v1331, mut v1332): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v7) };
            let mut v1333: i64 = v1327.borrow().l0.clone();
            let mut v1334: i64 = v1333 + 1i64;
            v1327.borrow_mut().l0 = v1334;
            let mut v1335: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1336: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v1337: bool = cfg!(target_arch = "wasm32");
            if v1337 {
                let mut v1338: Rc<str> = v1330.borrow().l0.clone();
                let mut v1339: bool = v1338.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1347: Rc<str> = if v1339 {
                    v1335.clone()
                } else {
                    let mut v1340: bool = v1335.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1340 {
                        let mut v1341: Rc<str> = v1330.borrow().l0.clone();
                        v1341.clone()
                    } else {
                        let mut v1342: Rc<str> = v1330.borrow().l0.clone();
                        let mut v1343: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1344: Rc<str> = Rc::<str>::from(format!("{}{}", v1342, v1343));
                        let mut v1345: Rc<str> = Rc::<str>::from(format!("{}{}", v1344, v1335));
                        v1345.clone()
                    }
                };
                let mut v1349: i32 = ((v1347.chars().count() + 14999) / 15000) as i32;
                let mut v1350: bool = v1335 != v1335 ;
                let mut v1352: bool = if v1350 {
                    let mut v1351: bool = v1349 <= 1i32;
                    v1351
                } else {
                    false
                };
                if v1352 {
                    v1330.borrow_mut().l0 = v1347.clone();
                    ()
                } else {
                    v1330.borrow_mut().l0 = v1335.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1347); };
                    ()
                }
            } else {
                println!("{}", v1335);
                ()
            };
            let mut v1355: Rc<dyn Fn(Rc<str>) -> ()> = v1328.borrow().l0.clone();
            v1355(v1335.clone());
            US2::US2_0(v1327.clone(), v1328.clone(), v1329.clone(), v1330.clone(), v1331.clone(), v1332.clone())
        };
        v1147
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
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice_contract.roll_within_bounds"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method80(v8, v9.clone(), v10.clone());
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
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
        let (mut v240, mut v241, mut v242, mut v243, mut v244, mut v245): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v246: US0 = v244.borrow().l0.clone();
        let mut v251: i32 = match &v246 {
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
        let mut v252: bool = v242.borrow().l0.clone();
        let mut v253: bool = v252 == false;
        let mut v255: bool = if v253 {
            false
        } else {
            let mut v254: bool = 20i32 >= v251;
            v254
        };
        let mut v256: bool = v255 == false;
        let mut v303: US2 = if v256 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v260, mut v261, mut v262, mut v263, mut v264, mut v265): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v266: Rc<str> = method3(v260.clone(), v261.clone(), v262.clone(), v263.clone(), v264.clone(), v265.clone());
            let mut v267: Rc<str> = method4();
            let mut v268: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<u8>>") } } (&&W(&v1)).s() });
            let mut v269: Rc<str> = Rc::<str>::from(match &v69 { Some(v) => format!("Some {:?}", v), None => String::from("None") });
            let mut v270: Rc<str> = method79(v260.clone(), v261.clone(), v262.clone(), v263.clone(), v264.clone(), v265.clone(), v266.clone(), v267.clone(), v0, v268.clone(), v269.clone());
            { let _ = spiral_trace_hold(&v3); };
            let (mut v273, mut v274, mut v275, mut v276, mut v277, mut v278): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v279: i64 = v273.borrow().l0.clone();
            let mut v280: i64 = v279 + 1i64;
            v273.borrow_mut().l0 = v280;
            let mut v281: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v282: bool = cfg!(target_arch = "wasm32");
            if v282 {
                let mut v283: Rc<str> = v276.borrow().l0.clone();
                let mut v284: bool = v283.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v292: Rc<str> = if v284 {
                    v270.clone()
                } else {
                    let mut v285: bool = v270.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v285 {
                        let mut v286: Rc<str> = v276.borrow().l0.clone();
                        v286.clone()
                    } else {
                        let mut v287: Rc<str> = v276.borrow().l0.clone();
                        let mut v288: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v289: Rc<str> = Rc::<str>::from(format!("{}{}", v287, v288));
                        let mut v290: Rc<str> = Rc::<str>::from(format!("{}{}", v289, v270));
                        v290.clone()
                    }
                };
                let mut v294: i32 = ((v292.chars().count() + 14999) / 15000) as i32;
                let mut v295: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v296: bool = v270 != v295 ;
                let mut v298: bool = if v296 {
                    let mut v297: bool = v294 <= 1i32;
                    v297
                } else {
                    false
                };
                if v298 {
                    v276.borrow_mut().l0 = v292.clone();
                    ()
                } else {
                    v276.borrow_mut().l0 = v295.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v292); };
                    ()
                }
            } else {
                println!("{}", v270);
                ()
            };
            let mut v301: Rc<dyn Fn(Rc<str>) -> ()> = v274.borrow().l0.clone();
            v301(v270.clone());
            US2::US2_0(v273.clone(), v274.clone(), v275.clone(), v276.clone(), v277.clone(), v278.clone())
        };
        let mut v356: Rc<dyn Fn() -> ()> = method81();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v505, mut v506, mut v507, mut v508, mut v509, mut v510): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v511: US0 = v509.borrow().l0.clone();
        let mut v516: i32 = match &v511 {
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
        let mut v517: bool = v507.borrow().l0.clone();
        let mut v518: bool = v517 == false;
        let mut v520: bool = if v518 {
            false
        } else {
            let mut v519: bool = 20i32 >= v516;
            v519
        };
        let mut v521: bool = v520 == false;
        let mut v565: US2 = if v521 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v525, mut v526, mut v527, mut v528, mut v529, mut v530): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v531: Rc<str> = method3(v525.clone(), v526.clone(), v527.clone(), v528.clone(), v529.clone(), v530.clone());
            let mut v532: Rc<str> = method4();
            { let _ = spiral_trace_hold(&v3); };
            let (mut v535, mut v536, mut v537, mut v538, mut v539, mut v540): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v541: i64 = v535.borrow().l0.clone();
            let mut v542: i64 = v541 + 1i64;
            v535.borrow_mut().l0 = v542;
            let mut v543: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v544: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v545: bool = cfg!(target_arch = "wasm32");
            if v545 {
                let mut v546: Rc<str> = v538.borrow().l0.clone();
                let mut v547: bool = v546.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v555: Rc<str> = if v547 {
                    v543.clone()
                } else {
                    let mut v548: bool = v543.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v548 {
                        let mut v549: Rc<str> = v538.borrow().l0.clone();
                        v549.clone()
                    } else {
                        let mut v550: Rc<str> = v538.borrow().l0.clone();
                        let mut v551: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v552: Rc<str> = Rc::<str>::from(format!("{}{}", v550, v551));
                        let mut v553: Rc<str> = Rc::<str>::from(format!("{}{}", v552, v543));
                        v553.clone()
                    }
                };
                let mut v557: i32 = ((v555.chars().count() + 14999) / 15000) as i32;
                let mut v558: bool = v543 != v543 ;
                let mut v560: bool = if v558 {
                    let mut v559: bool = v557 <= 1i32;
                    v559
                } else {
                    false
                };
                if v560 {
                    v538.borrow_mut().l0 = v555.clone();
                    ()
                } else {
                    v538.borrow_mut().l0 = v543.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v555); };
                    ()
                }
            } else {
                println!("{}", v543);
                ()
            };
            let mut v563: Rc<dyn Fn(Rc<str>) -> ()> = v536.borrow().l0.clone();
            v563(v543.clone());
            US2::US2_0(v535.clone(), v536.clone(), v537.clone(), v538.clone(), v539.clone(), v540.clone())
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
