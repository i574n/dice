#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
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
impl Default for Mut0 {
    fn default() -> Self {
        Mut0 { l0: <i64>::default() }
    }
}
struct Mut1 { l0: Rc<dyn Fn(Rc<str>) -> ()> }
impl Default for Mut1 {
    fn default() -> Self {
        Mut1 { l0: { let f: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(|mut v0: Rc<str>| -> () { () }); f } }
    }
}
struct Mut2 { l0: bool }
impl Default for Mut2 {
    fn default() -> Self {
        Mut2 { l0: <bool>::default() }
    }
}
struct Mut3 { l0: Rc<str> }
impl Default for Mut3 {
    fn default() -> Self {
        Mut3 { l0: { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) } }
    }
}
#[derive(Clone)]
enum US0 {
    US0_Verbose,
    US0_Debug,
    US0_Info,
    US0_Warning,
    US0_Critical,
}
impl US0 {
    fn tag(&self) -> i32 {
        match self {
            US0::US0_Verbose => 0,
            US0::US0_Debug => 1,
            US0::US0_Info => 2,
            US0::US0_Warning => 3,
            US0::US0_Critical => 4,
        }
    }
}
impl Default for US0 {
    fn default() -> Self {
        US0::US0_Verbose
    }
}
struct Mut4 { l0: US0 }
impl Default for Mut4 {
    fn default() -> Self {
        Mut4 { l0: <US0>::default() }
    }
}
#[derive(Clone)]
enum US1 {
    US1_Some(US0),
    US1_None,
}
impl US1 {
    fn tag(&self) -> i32 {
        match self {
            US1::US1_Some(..) => 0,
            US1::US1_None => 1,
        }
    }
}
impl Default for US1 {
    fn default() -> Self {
        US1::US1_Some(<US0>::default())
    }
}
struct Mut5 { l0: i32, l1: US1 }
impl Default for Mut5 {
    fn default() -> Self {
        Mut5 { l0: <i32>::default(), l1: <US1>::default() }
    }
}
#[derive(Clone)]
enum US2 {
    US2_Some(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US2_None,
}
impl US2 {
    fn tag(&self) -> i32 {
        match self {
            US2::US2_Some(..) => 0,
            US2::US2_None => 1,
        }
    }
}
#[derive(Clone)]
enum UH0 {
    UH0_Nil,
    UH0_Cons(u8, Rc<UH0>),
}
impl UH0 {
    fn tag(&self) -> i32 {
        match self {
            UH0::UH0_Nil => 0,
            UH0::UH0_Cons(..) => 1,
        }
    }
}
impl Default for UH0 {
    fn default() -> Self {
        UH0::UH0_Nil
    }
}
#[derive(Clone)]
enum US3 {
    US3_Some(i64, Rc<UH0>),
    US3_None,
}
impl US3 {
    fn tag(&self) -> i32 {
        match self {
            US3::US3_Some(..) => 0,
            US3::US3_None => 1,
        }
    }
}
impl Default for US3 {
    fn default() -> Self {
        US3::US3_Some(<i64>::default(), <Rc<UH0>>::default())
    }
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
fn closure1() -> Rc<dyn Fn(Rc<str>) -> ()> {
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
    let mut v47: Rc<dyn Fn(Rc<str>) -> ()> = closure1();
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
fn fresh_c0() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c2() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
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
fn format_real_12(mut v0: i8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>) -> Rc<str> {
    let mut v8: i64 = v0.borrow().l0.clone();
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v9));
    let mut v11: Rc<str> = format_real_11(v8);
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v10, v11));
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v7));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v9));
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count"); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max"); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) };
    let mut v25: i64 = 4738381338321616896i64;
    let mut v26: Rc<str> = format_real_11(v25);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v26));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("p"); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v23));
    let mut v33: i64 = 4738381338321616896i64;
    let mut v34: Rc<str> = format_real_11(v33);
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v34));
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v28));
    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("n"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v23));
    let mut v40: i8 = 24i8;
    let mut v41: Rc<str> = format_real_12(v40);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v46));
    method8(v47.clone())
}
fn closure3() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn roll_dice_14() -> u8 {
    let mut v1: u8 = { use std::sync::atomic::{AtomicU64, Ordering}; use std::hash::{BuildHasher, Hasher}; static SPIRAL_NATIVE_RNG: AtomicU64 = AtomicU64::new(0); let mut x = SPIRAL_NATIVE_RNG.load(Ordering::Relaxed); if x == 0 { let mut h = std::collections::hash_map::RandomState::new().build_hasher(); h.write_u128(std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_nanos()).unwrap_or(0)); x = h.finish() | 1; } x ^= x << 13; x ^= x >> 7; x ^= x << 17; SPIRAL_NATIVE_RNG.store(x, Ordering::Relaxed); let span = (7u8 as i128) - (1u8 as i128); let n = if span <= 0 { 0 } else { (x as i128) % span }; ((1u8 as i128) + n) as _ };
    v1
}
fn method40(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: i64) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = -1i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_11(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method39(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    let mut v2: i64 = v1.wrapping_add(1i64);
    let mut v4: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
    { let _ = spiral_trace_hold(&v4); };
    let mut v6: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    let (mut v7, mut v8, mut v9, mut v10, mut v11, mut v12): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
    let mut v13: US0 = v11.borrow().l0.clone();
    let mut v18: i32 = match &v13 {
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
    let mut v19: bool = v9.borrow().l0.clone();
    let mut v20: bool = v19 == false;
    let mut v22: bool = if v20 {
        false
    } else {
        let mut v21: bool = 20i32 >= v18;
        v21
    };
    let mut v23: bool = v22 == false;
    let mut v68: US2 = if v23 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v4); };
        let (mut v27, mut v28, mut v29, mut v30, mut v31, mut v32): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
        let mut v33: Rc<str> = method3(v27.clone(), v28.clone(), v29.clone(), v30.clone(), v31.clone(), v32.clone());
        let mut v34: Rc<str> = method4();
        let mut v35: Rc<str> = method40(v27.clone(), v28.clone(), v29.clone(), v30.clone(), v31.clone(), v32.clone(), v33.clone(), v34.clone(), v1, v2);
        { let _ = spiral_trace_hold(&v4); };
        let (mut v38, mut v39, mut v40, mut v41, mut v42, mut v43): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
        let mut v44: i64 = v38.borrow().l0.clone();
        let mut v45: i64 = v44.wrapping_add(1i64);
        v38.borrow_mut().l0 = v45;
        let mut v46: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
        let mut v47: bool = cfg!(target_arch = "wasm32");
        if v47 {
            let mut v48: Rc<str> = v41.borrow().l0.clone();
            let mut v49: bool = v48.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v57: Rc<str> = if v49 {
                v35.clone()
            } else {
                let mut v50: bool = v35.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v50 {
                    let mut v51: Rc<str> = v41.borrow().l0.clone();
                    v51.clone()
                } else {
                    let mut v52: Rc<str> = v41.borrow().l0.clone();
                    let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v53));
                    let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v35));
                    v55.clone()
                }
            };
            let mut v59: i32 = ((v57.chars().count() + 14999) / 15000) as i32;
            let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v61: bool = v35 != v60 ;
            let mut v63: bool = if v61 {
                let mut v62: bool = v59 <= 1i32;
                v62
            } else {
                false
            };
            if v63 {
                v41.borrow_mut().l0 = v57.clone();
                ()
            } else {
                v41.borrow_mut().l0 = v60.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v57); };
                ()
            }
        } else {
            println!("{}", v35);
            ()
        };
        let mut v66: Rc<dyn Fn(Rc<str>) -> ()> = v39.borrow().l0.clone();
        v66(v35.clone());
        US2::US2_Some(v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone())
    };
    US3::US3_Some(v2, v0.clone())
}
fn format_real_42(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method41(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 0i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method43(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 0i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method38(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v9: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v9); };
                let mut v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v12, mut v13, mut v14, mut v15, mut v16, mut v17): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v11) };
                let mut v18: US0 = v16.borrow().l0.clone();
                let mut v23: i32 = match &v18 {
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
                let mut v24: bool = v14.borrow().l0.clone();
                let mut v25: bool = v24 == false;
                let mut v27: bool = if v25 {
                    false
                } else {
                    let mut v26: bool = 20i32 >= v23;
                    v26
                };
                let mut v28: bool = v27 == false;
                let mut v73: US2 = if v28 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v9); };
                    let (mut v32, mut v33, mut v34, mut v35, mut v36, mut v37): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v11) };
                    let mut v38: Rc<str> = method3(v32.clone(), v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone());
                    let mut v39: Rc<str> = method4();
                    let mut v40: Rc<str> = method41(v32.clone(), v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v1, v3, v7);
                    { let _ = spiral_trace_hold(&v9); };
                    let (mut v43, mut v44, mut v45, mut v46, mut v47, mut v48): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v11) };
                    let mut v49: i64 = v43.borrow().l0.clone();
                    let mut v50: i64 = v49.wrapping_add(1i64);
                    v43.borrow_mut().l0 = v50;
                    let mut v51: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v52: bool = cfg!(target_arch = "wasm32");
                    if v52 {
                        let mut v53: Rc<str> = v46.borrow().l0.clone();
                        let mut v54: bool = v53.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v62: Rc<str> = if v54 {
                            v40.clone()
                        } else {
                            let mut v55: bool = v40.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v55 {
                                let mut v56: Rc<str> = v46.borrow().l0.clone();
                                v56.clone()
                            } else {
                                let mut v57: Rc<str> = v46.borrow().l0.clone();
                                let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v58));
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v59, v40));
                                v60.clone()
                            }
                        };
                        let mut v64: i32 = ((v62.chars().count() + 14999) / 15000) as i32;
                        let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v66: bool = v40 != v65 ;
                        let mut v68: bool = if v66 {
                            let mut v67: bool = v64 <= 1i32;
                            v67
                        } else {
                            false
                        };
                        if v68 {
                            v46.borrow_mut().l0 = v62.clone();
                            ()
                        } else {
                            v46.borrow_mut().l0 = v65.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v62); };
                            ()
                        }
                    } else {
                        println!("{}", v40);
                        ()
                    };
                    let mut v71: Rc<dyn Fn(Rc<str>) -> ()> = v44.borrow().l0.clone();
                    v71(v40.clone());
                    US2::US2_Some(v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone())
                };
                let mut v74: i64 = v1.wrapping_add(v7);
                method39(v4.clone(), v74)
            } else {
                let mut v77: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v77); };
                let mut v79: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v80, mut v81, mut v82, mut v83, mut v84, mut v85): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v79) };
                let mut v86: US0 = v84.borrow().l0.clone();
                let mut v91: i32 = match &v86 {
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
                let mut v92: bool = v82.borrow().l0.clone();
                let mut v93: bool = v92 == false;
                let mut v95: bool = if v93 {
                    false
                } else {
                    let mut v94: bool = 20i32 >= v91;
                    v94
                };
                let mut v96: bool = v95 == false;
                let mut v141: US2 = if v96 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v77); };
                    let (mut v100, mut v101, mut v102, mut v103, mut v104, mut v105): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v79) };
                    let mut v106: Rc<str> = method3(v100.clone(), v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone());
                    let mut v107: Rc<str> = method4();
                    let mut v108: Rc<str> = method43(v100.clone(), v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v77); };
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v79) };
                    let mut v117: i64 = v111.borrow().l0.clone();
                    let mut v118: i64 = v117.wrapping_add(1i64);
                    v111.borrow_mut().l0 = v118;
                    let mut v119: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v120: bool = cfg!(target_arch = "wasm32");
                    if v120 {
                        let mut v121: Rc<str> = v114.borrow().l0.clone();
                        let mut v122: bool = v121.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v130: Rc<str> = if v122 {
                            v108.clone()
                        } else {
                            let mut v123: bool = v108.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v123 {
                                let mut v124: Rc<str> = v114.borrow().l0.clone();
                                v124.clone()
                            } else {
                                let mut v125: Rc<str> = v114.borrow().l0.clone();
                                let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v127: Rc<str> = Rc::<str>::from(format!("{}{}", v125, v126));
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v127, v108));
                                v128.clone()
                            }
                        };
                        let mut v132: i32 = ((v130.chars().count() + 14999) / 15000) as i32;
                        let mut v133: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v134: bool = v108 != v133 ;
                        let mut v136: bool = if v134 {
                            let mut v135: bool = v132 <= 1i32;
                            v135
                        } else {
                            false
                        };
                        if v136 {
                            v114.borrow_mut().l0 = v130.clone();
                            ()
                        } else {
                            v114.borrow_mut().l0 = v133.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v130); };
                            ()
                        }
                    } else {
                        println!("{}", v108);
                        ()
                    };
                    let mut v139: Rc<dyn Fn(Rc<str>) -> ()> = v112.borrow().l0.clone();
                    v139(v108.clone());
                    US2::US2_Some(v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone())
                };
                method39(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method44(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 1i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method45(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 1i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method37(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(6i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method44(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method38(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method45(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method38(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method46(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 2i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method47(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 2i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method36(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(36i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method46(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method37(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method47(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method37(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method48(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 3i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method49(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 3i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method35(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(216i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method48(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method36(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method49(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method36(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method50(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 4i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method51(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 4i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method34(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(1296i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method50(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method35(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method51(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method35(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method52(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 5i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method53(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 5i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method33(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(7776i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method52(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method34(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method53(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method34(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method54(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 6i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method55(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 6i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method32(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(46656i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method54(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method33(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method55(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method33(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method56(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 7i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method57(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 7i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method31(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(279936i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method56(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method32(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method57(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method32(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method58(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 8i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method59(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 8i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method30(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(1679616i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method58(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method31(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method59(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method31(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method60(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 9i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method61(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 9i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method29(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(10077696i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method60(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method30(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method61(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method30(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method62(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 10i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method63(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 10i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method28(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(60466176i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method62(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method29(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method63(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method29(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method64(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 11i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method65(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 11i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method27(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(362797056i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method64(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method28(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method65(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method28(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method66(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 12i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method67(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 12i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method26(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(2176782336i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method66(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method27(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method67(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method27(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method68(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 13i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method69(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 13i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method25(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(13060694016i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method68(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method26(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method69(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method26(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method70(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 14i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method71(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 14i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method24(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(78364164096i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method70(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method25(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method71(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method25(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method72(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 15i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method73(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 15i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method23(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(470184984576i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method72(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method24(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method73(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method24(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method74(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 16i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method75(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 16i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method22(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(2821109907456i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method74(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method23(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method75(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method23(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method76(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 17i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method77(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 17i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method21(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(16926659444736i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method76(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method22(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method77(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method22(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method78(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 18i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method79(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 18i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method20(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(101559956668416i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method78(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method21(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method79(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method21(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method80(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 19i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method81(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 19i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method19(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(609359740010496i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method80(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method20(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method81(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method20(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method82(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 20i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method83(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 20i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method18(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(3656158440062976i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method82(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method19(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method83(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method19(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method84(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 21i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method85(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 21i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method17(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(21936950640377856i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method84(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method18(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method85(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method18(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method86(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 22i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method87(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 22i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method16(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(131621703842267136i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method86(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method17(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method87(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method17(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method88(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
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
    let mut v28: i8 = 23i8;
    let mut v29: Rc<str> = format_real_12(v28);
    let mut v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v26));
    let mut v36: Rc<str> = format_real_11(v8);
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v31));
    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v26));
    let mut v42: Rc<str> = format_real_42(v9);
    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v31));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v26));
    let mut v48: Rc<str> = format_real_11(v10);
    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v49));
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v53));
    method8(v54.clone())
}
fn method89(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: i8 = 23i8;
    let mut v28: Rc<str> = format_real_12(v27);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v28));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v25));
    let mut v35: Rc<str> = format_real_11(v8);
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
    let mut v41: Rc<str> = format_real_42(v9);
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v42));
    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v45));
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v46));
    method8(v47.clone())
}
fn method15(mut v0: Rc<UH0>, mut v1: i64) -> US3 {
    match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: bool = v3 > 1u8;
            if v5 {
                let mut v6: u8 = v3.wrapping_sub(1u8);
                let mut v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(789730223053602816i64);
                let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v10); };
                let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                let mut v19: US0 = v17.borrow().l0.clone();
                let mut v24: i32 = match &v19 {
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
                let mut v25: bool = v15.borrow().l0.clone();
                let mut v26: bool = v25 == false;
                let mut v28: bool = if v26 {
                    false
                } else {
                    let mut v27: bool = 20i32 >= v24;
                    v27
                };
                let mut v29: bool = v28 == false;
                let mut v74: US2 = if v29 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v39: Rc<str> = method3(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
                    let mut v40: Rc<str> = method4();
                    let mut v41: Rc<str> = method88(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v1, v3, v8);
                    { let _ = spiral_trace_hold(&v10); };
                    let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v12) };
                    let mut v50: i64 = v44.borrow().l0.clone();
                    let mut v51: i64 = v50.wrapping_add(1i64);
                    v44.borrow_mut().l0 = v51;
                    let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v53: bool = cfg!(target_arch = "wasm32");
                    if v53 {
                        let mut v54: Rc<str> = v47.borrow().l0.clone();
                        let mut v55: bool = v54.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v63: Rc<str> = if v55 {
                            v41.clone()
                        } else {
                            let mut v56: bool = v41.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v56 {
                                let mut v57: Rc<str> = v47.borrow().l0.clone();
                                v57.clone()
                            } else {
                                let mut v58: Rc<str> = v47.borrow().l0.clone();
                                let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v41));
                                v61.clone()
                            }
                        };
                        let mut v65: i32 = ((v63.chars().count() + 14999) / 15000) as i32;
                        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v67: bool = v41 != v66 ;
                        let mut v69: bool = if v67 {
                            let mut v68: bool = v65 <= 1i32;
                            v68
                        } else {
                            false
                        };
                        if v69 {
                            v47.borrow_mut().l0 = v63.clone();
                            ()
                        } else {
                            v47.borrow_mut().l0 = v66.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                            ()
                        }
                    } else {
                        println!("{}", v41);
                        ()
                    };
                    let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
                    v72(v41.clone());
                    US2::US2_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
                };
                let mut v75: i64 = v1.wrapping_add(v8);
                method16(v4.clone(), v75)
            } else {
                let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                { let _ = spiral_trace_hold(&v78); };
                let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                let mut v87: US0 = v85.borrow().l0.clone();
                let mut v92: i32 = match &v87 {
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
                let mut v93: bool = v83.borrow().l0.clone();
                let mut v94: bool = v93 == false;
                let mut v96: bool = if v94 {
                    false
                } else {
                    let mut v95: bool = 20i32 >= v92;
                    v95
                };
                let mut v97: bool = v96 == false;
                let mut v142: US2 = if v97 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v101, mut v102, mut v103, mut v104, mut v105, mut v106): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v107: Rc<str> = method3(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone());
                    let mut v108: Rc<str> = method4();
                    let mut v109: Rc<str> = method89(v101.clone(), v102.clone(), v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v1, v3);
                    { let _ = spiral_trace_hold(&v78); };
                    let (mut v112, mut v113, mut v114, mut v115, mut v116, mut v117): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v80) };
                    let mut v118: i64 = v112.borrow().l0.clone();
                    let mut v119: i64 = v118.wrapping_add(1i64);
                    v112.borrow_mut().l0 = v119;
                    let mut v120: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
                    let mut v121: bool = cfg!(target_arch = "wasm32");
                    if v121 {
                        let mut v122: Rc<str> = v115.borrow().l0.clone();
                        let mut v123: bool = v122.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v131: Rc<str> = if v123 {
                            v109.clone()
                        } else {
                            let mut v124: bool = v109.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v124 {
                                let mut v125: Rc<str> = v115.borrow().l0.clone();
                                v125.clone()
                            } else {
                                let mut v126: Rc<str> = v115.borrow().l0.clone();
                                let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                                let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v109));
                                v129.clone()
                            }
                        };
                        let mut v133: i32 = ((v131.chars().count() + 14999) / 15000) as i32;
                        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v135: bool = v109 != v134 ;
                        let mut v137: bool = if v135 {
                            let mut v136: bool = v133 <= 1i32;
                            v136
                        } else {
                            false
                        };
                        if v137 {
                            v115.borrow_mut().l0 = v131.clone();
                            ()
                        } else {
                            v115.borrow_mut().l0 = v134.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v131); };
                            ()
                        }
                    } else {
                        println!("{}", v109);
                        ()
                    };
                    let mut v140: Rc<dyn Fn(Rc<str>) -> ()> = v113.borrow().l0.clone();
                    v140(v109.clone());
                    US2::US2_Some(v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone())
                };
                method16(v4.clone(), v1)
            }
        }
        UH0::UH0_Nil => {
            US3::US3_None
        }
    }
}
fn method13(mut v0: Rc<UH0>, mut v1: i8) -> i64 {
    loop {
        let mut v2: bool = v1 < 24i8;
        if v2 {
            let mut v3: u8 = roll_dice_14();
            let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(v3, v0.clone()));
            let mut v5: i8 = v1.wrapping_add(1i8);
            (v0, v1) = (v4.clone(), v5);
            continue;
        } else {
            let mut v7: i64 = 0i64;
            let mut v8: US3 = method15(v0.clone(), v7);
            match &v8 {
                US3::US3_Some(v9, v10) => {
                    let mut v9: i64 = *v9;
                    let mut v10: Rc<UH0> = v10.clone();
                    let mut v11: bool = v9 <= 4738381338321616896i64;
                    if v11 {
                        return v9;
                    } else {
                        let mut v12: u8 = roll_dice_14();
                        let mut v13: u8 = roll_dice_14();
                        let mut v14: u8 = roll_dice_14();
                        let mut v15: u8 = roll_dice_14();
                        let mut v16: u8 = roll_dice_14();
                        let mut v17: u8 = roll_dice_14();
                        let mut v18: u8 = roll_dice_14();
                        let mut v19: u8 = roll_dice_14();
                        let mut v20: u8 = roll_dice_14();
                        let mut v21: u8 = roll_dice_14();
                        let mut v22: u8 = roll_dice_14();
                        let mut v23: u8 = roll_dice_14();
                        let mut v24: u8 = roll_dice_14();
                        let mut v25: u8 = roll_dice_14();
                        let mut v26: u8 = roll_dice_14();
                        let mut v27: u8 = roll_dice_14();
                        let mut v28: u8 = roll_dice_14();
                        let mut v29: u8 = roll_dice_14();
                        let mut v30: u8 = roll_dice_14();
                        let mut v31: u8 = roll_dice_14();
                        let mut v32: u8 = roll_dice_14();
                        let mut v33: u8 = roll_dice_14();
                        let mut v34: u8 = roll_dice_14();
                        let mut v35: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                        let mut v36: Rc<UH0> = Rc::new(UH0::UH0_Cons(v34, v35.clone()));
                        let mut v37: Rc<UH0> = Rc::new(UH0::UH0_Cons(v33, v36.clone()));
                        let mut v38: Rc<UH0> = Rc::new(UH0::UH0_Cons(v32, v37.clone()));
                        let mut v39: Rc<UH0> = Rc::new(UH0::UH0_Cons(v31, v38.clone()));
                        let mut v40: Rc<UH0> = Rc::new(UH0::UH0_Cons(v30, v39.clone()));
                        let mut v41: Rc<UH0> = Rc::new(UH0::UH0_Cons(v29, v40.clone()));
                        let mut v42: Rc<UH0> = Rc::new(UH0::UH0_Cons(v28, v41.clone()));
                        let mut v43: Rc<UH0> = Rc::new(UH0::UH0_Cons(v27, v42.clone()));
                        let mut v44: Rc<UH0> = Rc::new(UH0::UH0_Cons(v26, v43.clone()));
                        let mut v45: Rc<UH0> = Rc::new(UH0::UH0_Cons(v25, v44.clone()));
                        let mut v46: Rc<UH0> = Rc::new(UH0::UH0_Cons(v24, v45.clone()));
                        let mut v47: Rc<UH0> = Rc::new(UH0::UH0_Cons(v23, v46.clone()));
                        let mut v48: Rc<UH0> = Rc::new(UH0::UH0_Cons(v22, v47.clone()));
                        let mut v49: Rc<UH0> = Rc::new(UH0::UH0_Cons(v21, v48.clone()));
                        let mut v50: Rc<UH0> = Rc::new(UH0::UH0_Cons(v20, v49.clone()));
                        let mut v51: Rc<UH0> = Rc::new(UH0::UH0_Cons(v19, v50.clone()));
                        let mut v52: Rc<UH0> = Rc::new(UH0::UH0_Cons(v18, v51.clone()));
                        let mut v53: Rc<UH0> = Rc::new(UH0::UH0_Cons(v17, v52.clone()));
                        let mut v54: Rc<UH0> = Rc::new(UH0::UH0_Cons(v16, v53.clone()));
                        let mut v55: Rc<UH0> = Rc::new(UH0::UH0_Cons(v15, v54.clone()));
                        let mut v56: Rc<UH0> = Rc::new(UH0::UH0_Cons(v14, v55.clone()));
                        let mut v57: Rc<UH0> = Rc::new(UH0::UH0_Cons(v13, v56.clone()));
                        let mut v58: Rc<UH0> = Rc::new(UH0::UH0_Cons(v12, v57.clone()));
                        let mut v59: i8 = 23i8;
                        (v0, v1) = (v58.clone(), v59);
                        continue;
                    }
                }
                _ => {
                    let mut v62: u8 = roll_dice_14();
                    let mut v63: u8 = roll_dice_14();
                    let mut v64: u8 = roll_dice_14();
                    let mut v65: u8 = roll_dice_14();
                    let mut v66: u8 = roll_dice_14();
                    let mut v67: u8 = roll_dice_14();
                    let mut v68: u8 = roll_dice_14();
                    let mut v69: u8 = roll_dice_14();
                    let mut v70: u8 = roll_dice_14();
                    let mut v71: u8 = roll_dice_14();
                    let mut v72: u8 = roll_dice_14();
                    let mut v73: u8 = roll_dice_14();
                    let mut v74: u8 = roll_dice_14();
                    let mut v75: u8 = roll_dice_14();
                    let mut v76: u8 = roll_dice_14();
                    let mut v77: u8 = roll_dice_14();
                    let mut v78: u8 = roll_dice_14();
                    let mut v79: u8 = roll_dice_14();
                    let mut v80: u8 = roll_dice_14();
                    let mut v81: u8 = roll_dice_14();
                    let mut v82: u8 = roll_dice_14();
                    let mut v83: u8 = roll_dice_14();
                    let mut v84: u8 = roll_dice_14();
                    let mut v85: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                    let mut v86: Rc<UH0> = Rc::new(UH0::UH0_Cons(v84, v85.clone()));
                    let mut v87: Rc<UH0> = Rc::new(UH0::UH0_Cons(v83, v86.clone()));
                    let mut v88: Rc<UH0> = Rc::new(UH0::UH0_Cons(v82, v87.clone()));
                    let mut v89: Rc<UH0> = Rc::new(UH0::UH0_Cons(v81, v88.clone()));
                    let mut v90: Rc<UH0> = Rc::new(UH0::UH0_Cons(v80, v89.clone()));
                    let mut v91: Rc<UH0> = Rc::new(UH0::UH0_Cons(v79, v90.clone()));
                    let mut v92: Rc<UH0> = Rc::new(UH0::UH0_Cons(v78, v91.clone()));
                    let mut v93: Rc<UH0> = Rc::new(UH0::UH0_Cons(v77, v92.clone()));
                    let mut v94: Rc<UH0> = Rc::new(UH0::UH0_Cons(v76, v93.clone()));
                    let mut v95: Rc<UH0> = Rc::new(UH0::UH0_Cons(v75, v94.clone()));
                    let mut v96: Rc<UH0> = Rc::new(UH0::UH0_Cons(v74, v95.clone()));
                    let mut v97: Rc<UH0> = Rc::new(UH0::UH0_Cons(v73, v96.clone()));
                    let mut v98: Rc<UH0> = Rc::new(UH0::UH0_Cons(v72, v97.clone()));
                    let mut v99: Rc<UH0> = Rc::new(UH0::UH0_Cons(v71, v98.clone()));
                    let mut v100: Rc<UH0> = Rc::new(UH0::UH0_Cons(v70, v99.clone()));
                    let mut v101: Rc<UH0> = Rc::new(UH0::UH0_Cons(v69, v100.clone()));
                    let mut v102: Rc<UH0> = Rc::new(UH0::UH0_Cons(v68, v101.clone()));
                    let mut v103: Rc<UH0> = Rc::new(UH0::UH0_Cons(v67, v102.clone()));
                    let mut v104: Rc<UH0> = Rc::new(UH0::UH0_Cons(v66, v103.clone()));
                    let mut v105: Rc<UH0> = Rc::new(UH0::UH0_Cons(v65, v104.clone()));
                    let mut v106: Rc<UH0> = Rc::new(UH0::UH0_Cons(v64, v105.clone()));
                    let mut v107: Rc<UH0> = Rc::new(UH0::UH0_Cons(v63, v106.clone()));
                    let mut v108: Rc<UH0> = Rc::new(UH0::UH0_Cons(v62, v107.clone()));
                    let mut v109: i8 = 23i8;
                    (v0, v1) = (v108.clone(), v109);
                    continue;
                }
            }
        }
    }
}
fn method90(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.main"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = format_real_11(v8);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v27));
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v31));
    method8(v32.clone())
}
fn spiral_main() -> i32 {
    let mut v2: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
    { let _ = spiral_trace_hold(&v2); };
    let mut v4: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    let (mut v5, mut v6, mut v7, mut v8, mut v9, mut v10): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
    let mut v11: US0 = v9.borrow().l0.clone();
    let mut v16: i32 = match &v11 {
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
    let mut v17: bool = v7.borrow().l0.clone();
    let mut v18: bool = v17 == false;
    let mut v20: bool = if v18 {
        false
    } else {
        let mut v19: bool = 20i32 >= v16;
        v19
    };
    let mut v21: bool = v20 == false;
    let mut v66: US2 = if v21 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v2); };
        let (mut v25, mut v26, mut v27, mut v28, mut v29, mut v30): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
        let mut v31: Rc<str> = method3(v25.clone(), v26.clone(), v27.clone(), v28.clone(), v29.clone(), v30.clone());
        let mut v32: Rc<str> = method4();
        let mut v33: Rc<str> = method7(v25.clone(), v26.clone(), v27.clone(), v28.clone(), v29.clone(), v30.clone(), v31.clone(), v32.clone());
        { let _ = spiral_trace_hold(&v2); };
        let (mut v36, mut v37, mut v38, mut v39, mut v40, mut v41): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
        let mut v42: i64 = v36.borrow().l0.clone();
        let mut v43: i64 = v42.wrapping_add(1i64);
        v36.borrow_mut().l0 = v43;
        let mut v44: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
        let mut v45: bool = cfg!(target_arch = "wasm32");
        if v45 {
            let mut v46: Rc<str> = v39.borrow().l0.clone();
            let mut v47: bool = v46.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v55: Rc<str> = if v47 {
                v33.clone()
            } else {
                let mut v48: bool = v33.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v48 {
                    let mut v49: Rc<str> = v39.borrow().l0.clone();
                    v49.clone()
                } else {
                    let mut v50: Rc<str> = v39.borrow().l0.clone();
                    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v51));
                    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v33));
                    v53.clone()
                }
            };
            let mut v57: i32 = ((v55.chars().count() + 14999) / 15000) as i32;
            let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v59: bool = v33 != v58 ;
            let mut v61: bool = if v59 {
                let mut v60: bool = v57 <= 1i32;
                v60
            } else {
                false
            };
            if v61 {
                v39.borrow_mut().l0 = v55.clone();
                ()
            } else {
                v39.borrow_mut().l0 = v58.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v55); };
                ()
            }
        } else {
            println!("{}", v33);
            ()
        };
        let mut v64: Rc<dyn Fn(Rc<str>) -> ()> = v37.borrow().l0.clone();
        v64(v33.clone());
        US2::US2_Some(v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone())
    };
    let mut v67: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let mut v68: i8 = 0i8;
    let mut v69: i64 = method13(v67.clone(), v68);
    { let _ = spiral_trace_hold(&v2); };
    let (mut v72, mut v73, mut v74, mut v75, mut v76, mut v77): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
    let mut v78: US0 = v76.borrow().l0.clone();
    let mut v83: i32 = match &v78 {
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
    let mut v84: bool = v74.borrow().l0.clone();
    let mut v85: bool = v84 == false;
    let mut v87: bool = if v85 {
        false
    } else {
        let mut v86: bool = 20i32 >= v83;
        v86
    };
    let mut v88: bool = v87 == false;
    let mut v133: US2 = if v88 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v2); };
        let (mut v92, mut v93, mut v94, mut v95, mut v96, mut v97): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
        let mut v98: Rc<str> = method3(v92.clone(), v93.clone(), v94.clone(), v95.clone(), v96.clone(), v97.clone());
        let mut v99: Rc<str> = method4();
        let mut v100: Rc<str> = method90(v92.clone(), v93.clone(), v94.clone(), v95.clone(), v96.clone(), v97.clone(), v98.clone(), v99.clone(), v69);
        { let _ = spiral_trace_hold(&v2); };
        let (mut v103, mut v104, mut v105, mut v106, mut v107, mut v108): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
        let mut v109: i64 = v103.borrow().l0.clone();
        let mut v110: i64 = v109.wrapping_add(1i64);
        v103.borrow_mut().l0 = v110;
        let mut v111: Rc<dyn Fn(Rc<str>) -> ()> = closure3();
        let mut v112: bool = cfg!(target_arch = "wasm32");
        if v112 {
            let mut v113: Rc<str> = v106.borrow().l0.clone();
            let mut v114: bool = v113.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v122: Rc<str> = if v114 {
                v100.clone()
            } else {
                let mut v115: bool = v100.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v115 {
                    let mut v116: Rc<str> = v106.borrow().l0.clone();
                    v116.clone()
                } else {
                    let mut v117: Rc<str> = v106.borrow().l0.clone();
                    let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v119: Rc<str> = Rc::<str>::from(format!("{}{}", v117, v118));
                    let mut v120: Rc<str> = Rc::<str>::from(format!("{}{}", v119, v100));
                    v120.clone()
                }
            };
            let mut v124: i32 = ((v122.chars().count() + 14999) / 15000) as i32;
            let mut v125: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v126: bool = v100 != v125 ;
            let mut v128: bool = if v126 {
                let mut v127: bool = v124 <= 1i32;
                v127
            } else {
                false
            };
            if v128 {
                v106.borrow_mut().l0 = v122.clone();
                ()
            } else {
                v106.borrow_mut().l0 = v125.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v122); };
                ()
            }
        } else {
            println!("{}", v100);
            ()
        };
        let mut v131: Rc<dyn Fn(Rc<str>) -> ()> = v104.borrow().l0.clone();
        v131(v100.clone());
        US2::US2_Some(v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone())
    };
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 101 });
}
