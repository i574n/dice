#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
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
static SPIRAL_NATIVE_RNG: std::sync::atomic::AtomicU64 = std::sync::atomic::AtomicU64::new(0);
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
    US4_Some(i64, Rc<UH0>),
    US4_None,
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
fn closure1() -> Rc<dyn Fn(Rc<str>) -> ()> {
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
    let v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = Rc::<str>::from(v3.to_lowercase());
    let v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
    let v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
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
    let mut v42: US1 = v28.borrow().l1.clone();
    let mut v43: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let v44: Rc<dyn Fn(Rc<str>) -> ()> = closure1();
    let mut v45: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v44 }));
    let v46: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v47 }));
    let mut v51: US0 = match v42 {
        US1::US1_None => {
            v0
        }
        US1::US1_Some(v49) => {
            let v49: US0 = v49;
            v49
        }
    };
    let v52: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v51 }));
    let v53: Option<i64> = None;
    (v43, v45, v46, v48, v52, v53)
}
fn fresh_c0() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0);
        (v1, v2, v3, v4, v5, v6)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c2() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0);
        (v1, v2, v3, v4, v5, v6)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method4(mut v0: Option<[i64; 3]>) -> Option<[i64; 3]> {
    v0
}
fn closure3() -> Rc<dyn Fn(([i64; 3])) -> US3> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(([i64; 3])) -> US3> = Rc::new(move |mut v0: ([i64; 3])| -> US3 {
        let mut v1: [i64; 3] = (v0);
        US3::US3_Some(v1)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let v6: Option<[i64; 3]> = spiral_cfg_local_clock();
    let v7: Option<[i64; 3]> = method4(v6);
    let mut v8: Rc<dyn Fn(([i64; 3])) -> US3> = closure3();
    let mut v9: Option<US3> = v7.map(|x| v8(x));
    let v11: US3 = US3::US3_None;
    let v12: US3 = v11.clone();
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
    let mut v42: Rc<str> = if v39 {
        let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v40
    } else {
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v41
    };
    let mut v43: Rc<str> = Rc::<str>::from((v38).to_string());
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v43));
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v44));
    let v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) }));
    let mut v47: u64 = v27.wrapping_rem(60u64);
    let mut v48: bool = v47 < 10u64;
    let mut v51: Rc<str> = if v48 {
        let v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v49
    } else {
        let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v50
    };
    let v52: Rc<str> = Rc::<str>::from((v47).to_string());
    let v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
    let v54: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v53));
    v54
}
fn method7(mut v0: &Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3;
    ()
}
fn format_real_6(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let v3: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method7(&v2, v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
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
    let v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_6(v3);
    let v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method10(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let v3: bool = v2 >= v1;
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
                let v12: i32 = v2.wrapping_add(1i32);
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
            let v3: i32 = v1.wrapping_sub(1i32);
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
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
    let v3: i32 = method10(v0.clone(), v1, v2);
    let mut v4: i32 = v1.wrapping_sub(1i32);
    let v5: Rc<str> = string_slice(&v0, v3 as i64, v4 as i64);
    let v6: i32 = (v5.clone().len() as i32);
    let v7: i32 = method11(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5, 0i32 as i64, v7 as i64);
    v8
}
fn format_real_12(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method7(&v2, v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn format_real_13(mut v0: i8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method7(&v2, v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method8(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>) -> Rc<str> {
    let mut v8: i64 = v0.borrow().l0;
    let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v10: Rc<str> = format_real_12(v8);
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v9, v10));
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v7));
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.calculate_dice_count"); } LIT.with(|lit| lit.clone()) }));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v16: i64 = 4738381338321616896i64;
    let v17: Rc<str> = format_real_12(v16);
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("max = "); } LIT.with(|lit| lit.clone()) }, v17));
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v18, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", v19, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("p"); } LIT.with(|lit| lit.clone()) }));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v22: i64 = 4738381338321616896i64;
    let v23: Rc<str> = format_real_12(v22);
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v23));
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v24, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("n"); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: i8 = 24i8;
    let v29: Rc<str> = format_real_13(v28);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v32));
    method9(v33)
}
fn closure4() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn roll_dice_15() -> u8 {
    let mut v0: i64 = (1u8 as i64);
    let mut v1: i64 = (7u8 as i64);
    let mut v2: u64 = SPIRAL_NATIVE_RNG.load(std::sync::atomic::Ordering::Relaxed);
    let v3: bool = v2 == 0u64;
    let v18: u64 = if v3 {
        let mut v4: std::collections::hash_map::DefaultHasher = std::hash::BuildHasher::build_hasher(&std::collections::hash_map::RandomState::new());
        let v6: bool = true; // 1;
        let mut v4 = v4;
        let mut v8: std::time::SystemTime = std::time::SystemTime::now();
        let mut v9: std::time::Duration = v8.duration_since(std::time::UNIX_EPOCH).unwrap_or_default();
        let v10: u64 = v9.as_secs();
        let v11: u64 = v10.wrapping_mul(1000000000u64);
        let v12: u32 = v9.subsec_nanos();
        let mut v13: u64 = (v12 as u64);
        let v14: u64 = v11.wrapping_add(v13);
        std::hash::Hasher::write_u64(&mut v4, v14);
        let v15: u64 = std::hash::Hasher::finish(&v4);
        std::hash::Hasher::write_u64(&mut v4, v15);
        let v16: u64 = std::hash::Hasher::finish(&v4);
        let v17: u64 = v15 | 1u64;
        v17
    } else {
        v2
    };
    let v19: u64 = v18.wrapping_shl((13i32) as u32);
    let v20: u64 = v18 ^ v19;
    let v21: u64 = v20.wrapping_shr((7i32) as u32);
    let v22: u64 = v20 ^ v21;
    let v23: u64 = v22.wrapping_shl((17i32) as u32);
    let v24: u64 = v22 ^ v23;
    SPIRAL_NATIVE_RNG.store(v24, std::sync::atomic::Ordering::Relaxed);
    let v25: i64 = v1.wrapping_sub(v0);
    let v26: bool = v25 <= 0i64;
    let v31: i64 = if v26 {
        v0
    } else {
        let v27: u64 = (v25 as u64);
        let mut v28: u64 = v24.wrapping_rem(v27);
        let v29: i64 = (v28 as i64);
        let v30: i64 = v0.wrapping_add(v29);
        v30
    };
    let v32: u8 = ((v31) as u8);
    v32
}
fn method41(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: i64) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = -1i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_12(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method40(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    let mut v2: i64 = v1.wrapping_add(1i64);
    let v3: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
    let v25: bool = if v3 {
        true
    } else {
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v5); };
        let v7: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v8, mut v9, mut v10, mut v11, mut v12, mut v13): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v7);
        let v14: US0 = v12.borrow().l0.clone();
        let v19: i32 = match v14 {
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
        let v20: bool = v10.borrow().l0;
        let v21: bool = v20 == false;
        let v23: bool = if v21 {
            false
        } else {
            let v22: bool = 20i32 >= v19;
            v22
        };
        let v24: bool = v23 == false;
        v24
    };
    let v74: US2 = if v25 {
        US2::US2_None
    } else {
        let mut v28: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v28); };
        let v30: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v31, mut v32, mut v33, mut v34, mut v35, mut v36): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v30);
        let v37: Rc<str> = method3(&v31, &v32, &v33, &v34, &v35, v36.clone());
        let v38: Rc<str> = method5();
        let v39: Rc<str> = method41(&v31, &v32, &v33, &v34, &v35, v36, v37, v38, v1, v2);
        { let _ = spiral_trace_hold(&v28); };
        let (mut v42, mut v43, mut v44, mut v45, mut v46, mut v47): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v30);
        let mut v48: i64 = v42.borrow().l0;
        let v49: i64 = v48.wrapping_add(1i64);
        v42.borrow_mut().l0 = v49;
        let mut v50: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v51: bool = cfg!(target_arch = "wasm32");
        if v51 {
            let v52: Rc<str> = v45.borrow().l0.clone();
            let v53: bool = &*v52 == "";
            let v60: Rc<str> = if v53 {
                v39.clone()
            } else {
                let v54: bool = &*v39 == "";
                if v54 {
                    let v55: Rc<str> = v45.borrow().l0.clone();
                    v55
                } else {
                    let v56: Rc<str> = v45.borrow().l0.clone();
                    let v57: Rc<str> = Rc::<str>::from(format!("{}{}", v56, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v39.clone()));
                    v58
                }
            };
            let v62: usize = v60.len();
            let v63: i32 = ((v62) as i32);
            let v64: i32 = v63.wrapping_add(14999i32);
            let v65: i32 = v64.wrapping_div(15000i32);
            let v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v67: bool = v39 != v66 ;
            let v69: bool = if v67 {
                let v68: bool = v65 <= 1i32;
                v68
            } else {
                false
            };
            if v69 {
                v45.borrow_mut().l0 = v60;
                ()
            } else {
                v45.borrow_mut().l0 = v66;
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v60); };
                ()
            }
        } else {
            println!("{}", v39);
            ()
        };
        let mut v72: Rc<dyn Fn(Rc<str>) -> ()> = v43.borrow().l0.clone();
        v72(v39);
        US2::US2_Some(v42, v43, v44, v45, v46, v47)
    };
    US4::US4_Some(v2, v0)
}
fn format_real_43(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method7(&v2, v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method42(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 0i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method44(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 0i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method39(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v30: bool = if v8 {
                    true
                } else {
                    let v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v10); };
                    let v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
                    let v19: US0 = v17.borrow().l0.clone();
                    let v24: i32 = match v19 {
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
                    let v25: bool = v15.borrow().l0;
                    let v26: bool = v25 == false;
                    let mut v28: bool = if v26 {
                        false
                    } else {
                        let v27: bool = 20i32 >= v24;
                        v27
                    };
                    let v29: bool = v28 == false;
                    v29
                };
                let v79: US2 = if v30 {
                    US2::US2_None
                } else {
                    let v33: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v33); };
                    let v35: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v36, mut v37, mut v38, mut v39, mut v40, mut v41): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v35);
                    let mut v42: Rc<str> = method3(&v36, &v37, &v38, &v39, &v40, v41.clone());
                    let mut v43: Rc<str> = method5();
                    let v44: Rc<str> = method42(&v36, &v37, &v38, &v39, &v40, v41, v42, v43, v1, v3, v7);
                    { let _ = spiral_trace_hold(&v33); };
                    let (mut v47, mut v48, mut v49, mut v50, mut v51, mut v52): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v35);
                    let v53: i64 = v47.borrow().l0;
                    let v54: i64 = v53.wrapping_add(1i64);
                    v47.borrow_mut().l0 = v54;
                    let v55: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v56: bool = cfg!(target_arch = "wasm32");
                    if v56 {
                        let v57: Rc<str> = v50.borrow().l0.clone();
                        let v58: bool = &*v57 == "";
                        let v65: Rc<str> = if v58 {
                            v44.clone()
                        } else {
                            let v59: bool = &*v44 == "";
                            if v59 {
                                let v60: Rc<str> = v50.borrow().l0.clone();
                                v60
                            } else {
                                let v61: Rc<str> = v50.borrow().l0.clone();
                                let v62: Rc<str> = Rc::<str>::from(format!("{}{}", v61, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v44.clone()));
                                v63
                            }
                        };
                        let v67: usize = v65.len();
                        let v68: i32 = ((v67) as i32);
                        let v69: i32 = v68.wrapping_add(14999i32);
                        let mut v70: i32 = v69.wrapping_div(15000i32);
                        let v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v72: bool = v44 != v71 ;
                        let v74: bool = if v72 {
                            let v73: bool = v70 <= 1i32;
                            v73
                        } else {
                            false
                        };
                        if v74 {
                            v50.borrow_mut().l0 = v65;
                            ()
                        } else {
                            v50.borrow_mut().l0 = v71;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v65); };
                            ()
                        }
                    } else {
                        println!("{}", v44);
                        ()
                    };
                    let mut v77: Rc<dyn Fn(Rc<str>) -> ()> = v48.borrow().l0.clone();
                    v77(v44);
                    US2::US2_Some(v47, v48, v49, v50, v51, v52)
                };
                let v80: i64 = v1.wrapping_add(v7);
                method40(v4, v80)
            } else {
                let v82: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v104: bool = if v82 {
                    true
                } else {
                    let v84: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v84); };
                    let v86: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v87, mut v88, mut v89, mut v90, mut v91, mut v92): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v86);
                    let v93: US0 = v91.borrow().l0.clone();
                    let v98: i32 = match v93 {
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
                    let v99: bool = v89.borrow().l0;
                    let v100: bool = v99 == false;
                    let v102: bool = if v100 {
                        false
                    } else {
                        let v101: bool = 20i32 >= v98;
                        v101
                    };
                    let v103: bool = v102 == false;
                    v103
                };
                let v153: US2 = if v104 {
                    US2::US2_None
                } else {
                    let v107: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v107); };
                    let v109: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v110, mut v111, mut v112, mut v113, mut v114, mut v115): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v109);
                    let v116: Rc<str> = method3(&v110, &v111, &v112, &v113, &v114, v115.clone());
                    let v117: Rc<str> = method5();
                    let mut v118: Rc<str> = method44(&v110, &v111, &v112, &v113, &v114, v115, v116, v117, v1, v3);
                    { let _ = spiral_trace_hold(&v107); };
                    let (mut v121, mut v122, mut v123, mut v124, mut v125, mut v126): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v109);
                    let v127: i64 = v121.borrow().l0;
                    let v128: i64 = v127.wrapping_add(1i64);
                    v121.borrow_mut().l0 = v128;
                    let v129: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v130: bool = cfg!(target_arch = "wasm32");
                    if v130 {
                        let v131: Rc<str> = v124.borrow().l0.clone();
                        let v132: bool = &*v131 == "";
                        let v139: Rc<str> = if v132 {
                            v118.clone()
                        } else {
                            let v133: bool = &*v118 == "";
                            if v133 {
                                let v134: Rc<str> = v124.borrow().l0.clone();
                                v134
                            } else {
                                let v135: Rc<str> = v124.borrow().l0.clone();
                                let v136: Rc<str> = Rc::<str>::from(format!("{}{}", v135, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v118.clone()));
                                v137
                            }
                        };
                        let v141: usize = v139.len();
                        let v142: i32 = ((v141) as i32);
                        let v143: i32 = v142.wrapping_add(14999i32);
                        let v144: i32 = v143.wrapping_div(15000i32);
                        let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v146: bool = v118 != v145 ;
                        let v148: bool = if v146 {
                            let v147: bool = v144 <= 1i32;
                            v147
                        } else {
                            false
                        };
                        if v148 {
                            v124.borrow_mut().l0 = v139;
                            ()
                        } else {
                            v124.borrow_mut().l0 = v145;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v139); };
                            ()
                        }
                    } else {
                        println!("{}", v118);
                        ()
                    };
                    let mut v151: Rc<dyn Fn(Rc<str>) -> ()> = v122.borrow().l0.clone();
                    v151(v118);
                    US2::US2_Some(v121, v122, v123, v124, v125, v126)
                };
                method40(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method45(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 1i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method46(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 1i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method38(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(6i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method45(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method39(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method46(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method39(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method47(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 2i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method48(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 2i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method37(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(36i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method47(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method38(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method48(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method38(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method49(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 3i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method50(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 3i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method36(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(216i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method49(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method37(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method50(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method37(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method51(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 4i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method52(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 4i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method35(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(1296i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method51(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method36(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method52(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method36(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method53(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 5i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method54(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 5i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method34(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(7776i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method53(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method35(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method54(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method35(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method55(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 6i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method56(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 6i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method33(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(46656i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method55(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method34(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method56(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method34(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method57(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 7i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method58(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 7i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method32(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(279936i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method57(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method33(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method58(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method33(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method59(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 8i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method60(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 8i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method31(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(1679616i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method59(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method32(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method60(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method32(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method61(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 9i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method62(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 9i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method30(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(10077696i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method61(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method31(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method62(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method31(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method63(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 10i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method64(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 10i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method29(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(60466176i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method63(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method30(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method64(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method30(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method65(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 11i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method66(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 11i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method28(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(362797056i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method65(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method29(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method66(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method29(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method67(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 12i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method68(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 12i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method27(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(2176782336i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method67(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method28(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method68(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method28(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method69(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 13i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method70(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 13i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method26(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(13060694016i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method69(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method27(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method70(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method27(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method71(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 14i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method72(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 14i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method25(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(78364164096i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method71(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method26(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method72(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method26(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method73(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 15i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method74(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 15i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method24(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(470184984576i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method73(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method25(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method74(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method25(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method75(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 16i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method76(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 16i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method23(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(2821109907456i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method75(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method24(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method76(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method24(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method77(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 17i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method78(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 17i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method22(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(16926659444736i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method77(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method23(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method78(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method23(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method79(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 18i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method80(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 18i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method21(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(101559956668416i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method79(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method22(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method80(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method22(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method81(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 19i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method82(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 19i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method20(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(609359740010496i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method81(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method21(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method82(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method21(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method83(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 20i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method84(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 20i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method19(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(3656158440062976i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method83(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method20(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method84(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method20(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method85(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 21i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method86(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 21i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method18(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(21936950640377856i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method85(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method19(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method86(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method19(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method87(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 22i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method88(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 22i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method17(mut v0: Rc<UH0>, mut v1: i64) -> US4 {
    match Rc::unwrap_or_clone(v0) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = v3;
            let mut v4: Rc<UH0> = v4;
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(131621703842267136i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method87(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method18(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method88(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method18(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method89(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8, mut v10: i64) -> Rc<str> {
    let v11: i64 = v0.borrow().l0;
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let mut v13: Rc<str> = format_real_12(v11);
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v19: i8 = 23i8;
    let v20: Rc<str> = format_real_13(v19);
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v20));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v25: Rc<str> = format_real_12(v8);
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v30: Rc<str> = format_real_43(v9);
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("value"); } LIT.with(|lit| lit.clone()) }));
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v35: Rc<str> = format_real_12(v10);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v36));
    let v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v38));
    method9(v39)
}
fn method90(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64, mut v9: u8) -> Rc<str> {
    let v10: i64 = v0.borrow().l0;
    let v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v12: Rc<str> = format_real_12(v10);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.accumulate_dice_rolls"); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v18: i8 = 23i8;
    let v19: Rc<str> = format_real_13(v18);
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("power = "); } LIT.with(|lit| lit.clone()) }, v19));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("acc"); } LIT.with(|lit| lit.clone()) }));
    let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v24: Rc<str> = format_real_12(v8);
    let v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
    let v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) }));
    let v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("roll"); } LIT.with(|lit| lit.clone()) }));
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) }));
    let v29: Rc<str> = format_real_43(v9);
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v30));
    let v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v33: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v32));
    method9(v33)
}
fn method16(mut v0: &Rc<UH0>, mut v1: i64) -> US4 {
    match &**v0 {
        UH0::UH0_Cons(v3, v4) => {
            let v3: u8 = *v3;
            let mut v4: Rc<UH0> = v4.clone();
            let v5: bool = v3 > 1u8;
            if v5 {
                let v6: u8 = v3.wrapping_sub(1u8);
                let v7: i64 = (v6 as i64);
                let mut v8: i64 = v7.wrapping_mul(789730223053602816i64);
                let mut v9: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v31: bool = if v9 {
                    true
                } else {
                    let v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v11); };
                    let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                    let v20: US0 = v18.borrow().l0.clone();
                    let v25: i32 = match v20 {
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
                    let v26: bool = v16.borrow().l0;
                    let v27: bool = v26 == false;
                    let v29: bool = if v27 {
                        false
                    } else {
                        let mut v28: bool = 20i32 >= v25;
                        v28
                    };
                    let v30: bool = v29 == false;
                    v30
                };
                let v80: US2 = if v31 {
                    US2::US2_None
                } else {
                    let v34: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v34); };
                    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let mut v43: Rc<str> = method3(&v37, &v38, &v39, &v40, &v41, v42.clone());
                    let v44: Rc<str> = method5();
                    let mut v45: Rc<str> = method89(&v37, &v38, &v39, &v40, &v41, v42, v43, v44, v1, v3, v8);
                    { let _ = spiral_trace_hold(&v34); };
                    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v36);
                    let v54: i64 = v48.borrow().l0;
                    let v55: i64 = v54.wrapping_add(1i64);
                    v48.borrow_mut().l0 = v55;
                    let v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v57: bool = cfg!(target_arch = "wasm32");
                    if v57 {
                        let v58: Rc<str> = v51.borrow().l0.clone();
                        let v59: bool = &*v58 == "";
                        let v66: Rc<str> = if v59 {
                            v45.clone()
                        } else {
                            let v60: bool = &*v45 == "";
                            if v60 {
                                let v61: Rc<str> = v51.borrow().l0.clone();
                                v61
                            } else {
                                let v62: Rc<str> = v51.borrow().l0.clone();
                                let v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v45.clone()));
                                v64
                            }
                        };
                        let v68: usize = v66.len();
                        let v69: i32 = ((v68) as i32);
                        let mut v70: i32 = v69.wrapping_add(14999i32);
                        let v71: i32 = v70.wrapping_div(15000i32);
                        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v73: bool = v45 != v72 ;
                        let v75: bool = if v73 {
                            let v74: bool = v71 <= 1i32;
                            v74
                        } else {
                            false
                        };
                        if v75 {
                            v51.borrow_mut().l0 = v66;
                            ()
                        } else {
                            v51.borrow_mut().l0 = v72;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v66); };
                            ()
                        }
                    } else {
                        println!("{}", v45);
                        ()
                    };
                    let mut v78: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                    v78(v45);
                    US2::US2_Some(v48, v49, v50, v51, v52, v53)
                };
                let v81: i64 = v1.wrapping_add(v8);
                method17(v4, v81)
            } else {
                let v83: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
                let v105: bool = if v83 {
                    true
                } else {
                    let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v85); };
                    let v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v94: US0 = v92.borrow().l0.clone();
                    let v99: i32 = match v94 {
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
                    let v100: bool = v90.borrow().l0;
                    let v101: bool = v100 == false;
                    let v103: bool = if v101 {
                        false
                    } else {
                        let v102: bool = 20i32 >= v99;
                        v102
                    };
                    let v104: bool = v103 == false;
                    v104
                };
                let v154: US2 = if v105 {
                    US2::US2_None
                } else {
                    let v108: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
                    { let _ = spiral_trace_hold(&v108); };
                    let v110: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    let (mut v111, mut v112, mut v113, mut v114, mut v115, mut v116): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v117: Rc<str> = method3(&v111, &v112, &v113, &v114, &v115, v116.clone());
                    let mut v118: Rc<str> = method5();
                    let v119: Rc<str> = method90(&v111, &v112, &v113, &v114, &v115, v116, v117, v118, v1, v3);
                    { let _ = spiral_trace_hold(&v108); };
                    let (mut v122, mut v123, mut v124, mut v125, mut v126, mut v127): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v110);
                    let v128: i64 = v122.borrow().l0;
                    let v129: i64 = v128.wrapping_add(1i64);
                    v122.borrow_mut().l0 = v129;
                    let v130: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let v131: bool = cfg!(target_arch = "wasm32");
                    if v131 {
                        let v132: Rc<str> = v125.borrow().l0.clone();
                        let v133: bool = &*v132 == "";
                        let v140: Rc<str> = if v133 {
                            v119.clone()
                        } else {
                            let v134: bool = &*v119 == "";
                            if v134 {
                                let v135: Rc<str> = v125.borrow().l0.clone();
                                v135
                            } else {
                                let v136: Rc<str> = v125.borrow().l0.clone();
                                let v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                                let v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v119.clone()));
                                v138
                            }
                        };
                        let v142: usize = v140.len();
                        let v143: i32 = ((v142) as i32);
                        let v144: i32 = v143.wrapping_add(14999i32);
                        let mut v145: i32 = v144.wrapping_div(15000i32);
                        let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v147: bool = v119 != v146 ;
                        let v149: bool = if v147 {
                            let v148: bool = v145 <= 1i32;
                            v148
                        } else {
                            false
                        };
                        if v149 {
                            v125.borrow_mut().l0 = v140;
                            ()
                        } else {
                            v125.borrow_mut().l0 = v146;
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v119);
                        ()
                    };
                    let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v123.borrow().l0.clone();
                    v152(v119);
                    US2::US2_Some(v122, v123, v124, v125, v126, v127)
                };
                method17(v4, v1)
            }
        }
        UH0::UH0_Nil => {
            US4::US4_None
        }
    }
}
fn method14(mut v0: Rc<UH0>, mut v1: i8) -> i64 {
    loop {
        let mut v2: bool = v1 < 24i8;
        if v2 {
            let v3: u8 = roll_dice_15();
            let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(v3, v0));
            let v5: i8 = v1.wrapping_add(1i8);
            (v0, v1) = (v4, v5);
            continue;
        } else {
            let v7: i64 = 0i64;
            let mut v8: US4 = method16(&v0, v7);
            match v8 {
                US4::US4_Some(v9, v10) => {
                    let mut v9: i64 = v9;
                    let v10: Rc<UH0> = v10;
                    let v11: bool = v9 <= 4738381338321616896i64;
                    if v11 {
                        return v9;
                    } else {
                        let v12: u8 = roll_dice_15();
                        let mut v13: u8 = roll_dice_15();
                        let v14: u8 = roll_dice_15();
                        let v15: u8 = roll_dice_15();
                        let v16: u8 = roll_dice_15();
                        let v17: u8 = roll_dice_15();
                        let v18: u8 = roll_dice_15();
                        let v19: u8 = roll_dice_15();
                        let v20: u8 = roll_dice_15();
                        let v21: u8 = roll_dice_15();
                        let v22: u8 = roll_dice_15();
                        let v23: u8 = roll_dice_15();
                        let v24: u8 = roll_dice_15();
                        let v25: u8 = roll_dice_15();
                        let v26: u8 = roll_dice_15();
                        let v27: u8 = roll_dice_15();
                        let mut v28: u8 = roll_dice_15();
                        let v29: u8 = roll_dice_15();
                        let v30: u8 = roll_dice_15();
                        let v31: u8 = roll_dice_15();
                        let v32: u8 = roll_dice_15();
                        let v33: u8 = roll_dice_15();
                        let v34: u8 = roll_dice_15();
                        let v35: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                        let v36: Rc<UH0> = Rc::new(UH0::UH0_Cons(v34, v35));
                        let v37: Rc<UH0> = Rc::new(UH0::UH0_Cons(v33, v36));
                        let v38: Rc<UH0> = Rc::new(UH0::UH0_Cons(v32, v37));
                        let v39: Rc<UH0> = Rc::new(UH0::UH0_Cons(v31, v38));
                        let mut v40: Rc<UH0> = Rc::new(UH0::UH0_Cons(v30, v39));
                        let v41: Rc<UH0> = Rc::new(UH0::UH0_Cons(v29, v40));
                        let mut v42: Rc<UH0> = Rc::new(UH0::UH0_Cons(v28, v41));
                        let mut v43: Rc<UH0> = Rc::new(UH0::UH0_Cons(v27, v42));
                        let v44: Rc<UH0> = Rc::new(UH0::UH0_Cons(v26, v43));
                        let mut v45: Rc<UH0> = Rc::new(UH0::UH0_Cons(v25, v44));
                        let v46: Rc<UH0> = Rc::new(UH0::UH0_Cons(v24, v45));
                        let mut v47: Rc<UH0> = Rc::new(UH0::UH0_Cons(v23, v46));
                        let mut v48: Rc<UH0> = Rc::new(UH0::UH0_Cons(v22, v47));
                        let v49: Rc<UH0> = Rc::new(UH0::UH0_Cons(v21, v48));
                        let mut v50: Rc<UH0> = Rc::new(UH0::UH0_Cons(v20, v49));
                        let mut v51: Rc<UH0> = Rc::new(UH0::UH0_Cons(v19, v50));
                        let v52: Rc<UH0> = Rc::new(UH0::UH0_Cons(v18, v51));
                        let v53: Rc<UH0> = Rc::new(UH0::UH0_Cons(v17, v52));
                        let v54: Rc<UH0> = Rc::new(UH0::UH0_Cons(v16, v53));
                        let v55: Rc<UH0> = Rc::new(UH0::UH0_Cons(v15, v54));
                        let v56: Rc<UH0> = Rc::new(UH0::UH0_Cons(v14, v55));
                        let v57: Rc<UH0> = Rc::new(UH0::UH0_Cons(v13, v56));
                        let v58: Rc<UH0> = Rc::new(UH0::UH0_Cons(v12, v57));
                        let v59: i8 = 23i8;
                        (v0, v1) = (v58, v59);
                        continue;
                    }
                }
                _ => {
                    let v62: u8 = roll_dice_15();
                    let v63: u8 = roll_dice_15();
                    let v64: u8 = roll_dice_15();
                    let v65: u8 = roll_dice_15();
                    let v66: u8 = roll_dice_15();
                    let v67: u8 = roll_dice_15();
                    let v68: u8 = roll_dice_15();
                    let v69: u8 = roll_dice_15();
                    let mut v70: u8 = roll_dice_15();
                    let v71: u8 = roll_dice_15();
                    let mut v72: u8 = roll_dice_15();
                    let v73: u8 = roll_dice_15();
                    let v74: u8 = roll_dice_15();
                    let v75: u8 = roll_dice_15();
                    let v76: u8 = roll_dice_15();
                    let mut v77: u8 = roll_dice_15();
                    let mut v78: u8 = roll_dice_15();
                    let v79: u8 = roll_dice_15();
                    let v80: u8 = roll_dice_15();
                    let v81: u8 = roll_dice_15();
                    let v82: u8 = roll_dice_15();
                    let v83: u8 = roll_dice_15();
                    let v84: u8 = roll_dice_15();
                    let v85: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                    let v86: Rc<UH0> = Rc::new(UH0::UH0_Cons(v84, v85));
                    let v87: Rc<UH0> = Rc::new(UH0::UH0_Cons(v83, v86));
                    let v88: Rc<UH0> = Rc::new(UH0::UH0_Cons(v82, v87));
                    let v89: Rc<UH0> = Rc::new(UH0::UH0_Cons(v81, v88));
                    let v90: Rc<UH0> = Rc::new(UH0::UH0_Cons(v80, v89));
                    let v91: Rc<UH0> = Rc::new(UH0::UH0_Cons(v79, v90));
                    let v92: Rc<UH0> = Rc::new(UH0::UH0_Cons(v78, v91));
                    let v93: Rc<UH0> = Rc::new(UH0::UH0_Cons(v77, v92));
                    let v94: Rc<UH0> = Rc::new(UH0::UH0_Cons(v76, v93));
                    let v95: Rc<UH0> = Rc::new(UH0::UH0_Cons(v75, v94));
                    let v96: Rc<UH0> = Rc::new(UH0::UH0_Cons(v74, v95));
                    let v97: Rc<UH0> = Rc::new(UH0::UH0_Cons(v73, v96));
                    let v98: Rc<UH0> = Rc::new(UH0::UH0_Cons(v72, v97));
                    let v99: Rc<UH0> = Rc::new(UH0::UH0_Cons(v71, v98));
                    let v100: Rc<UH0> = Rc::new(UH0::UH0_Cons(v70, v99));
                    let v101: Rc<UH0> = Rc::new(UH0::UH0_Cons(v69, v100));
                    let v102: Rc<UH0> = Rc::new(UH0::UH0_Cons(v68, v101));
                    let v103: Rc<UH0> = Rc::new(UH0::UH0_Cons(v67, v102));
                    let v104: Rc<UH0> = Rc::new(UH0::UH0_Cons(v66, v103));
                    let v105: Rc<UH0> = Rc::new(UH0::UH0_Cons(v65, v104));
                    let v106: Rc<UH0> = Rc::new(UH0::UH0_Cons(v64, v105));
                    let v107: Rc<UH0> = Rc::new(UH0::UH0_Cons(v63, v106));
                    let v108: Rc<UH0> = Rc::new(UH0::UH0_Cons(v62, v107));
                    let v109: i8 = 23i8;
                    (v0, v1) = (v108, v109);
                    continue;
                }
            }
        }
    }
}
fn method91(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i64) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0;
    let v10: Rc<str> = Rc::<str>::from(format!("{}{}", v6, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v11: Rc<str> = format_real_12(v9);
    let v12: Rc<str> = Rc::<str>::from(format!("{}{}", v10, v11));
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v7));
    let v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) }));
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dice.main"); } LIT.with(|lit| lit.clone()) }));
    let v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) }));
    let v17: Rc<str> = format_real_12(v8);
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result = "); } LIT.with(|lit| lit.clone()) }, v17));
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) }, v18));
    let v20: Rc<str> = Rc::<str>::from(format!("{}{}", v19, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) }));
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v20));
    method9(v21)
}
fn spiral_main() -> i32 {
    let mut v1: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
    let v23: bool = if v1 {
        true
    } else {
        let v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v3); };
        let v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v5);
        let v12: US0 = v10.borrow().l0.clone();
        let v17: i32 = match v12 {
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
        let v18: bool = v8.borrow().l0;
        let v19: bool = v18 == false;
        let v21: bool = if v19 {
            false
        } else {
            let v20: bool = 20i32 >= v17;
            v20
        };
        let v22: bool = v21 == false;
        v22
    };
    let mut v72: US2 = if v23 {
        US2::US2_None
    } else {
        let v26: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v26); };
        let mut v28: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v29, mut v30, mut v31, mut v32, mut v33, mut v34): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v28);
        let v35: Rc<str> = method3(&v29, &v30, &v31, &v32, &v33, v34.clone());
        let v36: Rc<str> = method5();
        let v37: Rc<str> = method8(&v29, &v30, &v31, &v32, &v33, v34, v35, v36);
        { let _ = spiral_trace_hold(&v26); };
        let (mut v40, mut v41, mut v42, mut v43, mut v44, mut v45): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v28);
        let v46: i64 = v40.borrow().l0;
        let mut v47: i64 = v46.wrapping_add(1i64);
        v40.borrow_mut().l0 = v47;
        let mut v48: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let v49: bool = cfg!(target_arch = "wasm32");
        if v49 {
            let mut v50: Rc<str> = v43.borrow().l0.clone();
            let mut v51: bool = &*v50 == "";
            let v58: Rc<str> = if v51 {
                v37.clone()
            } else {
                let v52: bool = &*v37 == "";
                if v52 {
                    let v53: Rc<str> = v43.borrow().l0.clone();
                    v53
                } else {
                    let v54: Rc<str> = v43.borrow().l0.clone();
                    let v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let v56: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v37.clone()));
                    v56
                }
            };
            let v60: usize = v58.len();
            let v61: i32 = ((v60) as i32);
            let v62: i32 = v61.wrapping_add(14999i32);
            let v63: i32 = v62.wrapping_div(15000i32);
            let v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v65: bool = v37 != v64 ;
            let v67: bool = if v65 {
                let v66: bool = v63 <= 1i32;
                v66
            } else {
                false
            };
            if v67 {
                v43.borrow_mut().l0 = v58;
                ()
            } else {
                v43.borrow_mut().l0 = v64;
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v58); };
                ()
            }
        } else {
            println!("{}", v37);
            ()
        };
        let mut v70: Rc<dyn Fn(Rc<str>) -> ()> = v41.borrow().l0.clone();
        v70(v37);
        US2::US2_Some(v40, v41, v42, v43, v44, v45)
    };
    let v73: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let v74: i8 = 0i8;
    let v75: i64 = method14(v73, v74);
    let v76: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
    let v98: bool = if v76 {
        true
    } else {
        let mut v78: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v78); };
        let v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v81, mut v82, mut v83, mut v84, mut v85, mut v86): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v80);
        let v87: US0 = v85.borrow().l0.clone();
        let v92: i32 = match v87 {
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
        let v93: bool = v83.borrow().l0;
        let v94: bool = v93 == false;
        let v96: bool = if v94 {
            false
        } else {
            let v95: bool = 20i32 >= v92;
            v95
        };
        let v97: bool = v96 == false;
        v97
    };
    let v147: US2 = if v98 {
        US2::US2_None
    } else {
        let v101: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v101); };
        let v103: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v104, mut v105, mut v106, mut v107, mut v108, mut v109): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v103);
        let v110: Rc<str> = method3(&v104, &v105, &v106, &v107, &v108, v109.clone());
        let v111: Rc<str> = method5();
        let v112: Rc<str> = method91(&v104, &v105, &v106, &v107, &v108, v109, v110, v111, v75);
        { let _ = spiral_trace_hold(&v101); };
        let (mut v115, mut v116, mut v117, mut v118, mut v119, mut v120): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v103);
        let mut v121: i64 = v115.borrow().l0;
        let mut v122: i64 = v121.wrapping_add(1i64);
        v115.borrow_mut().l0 = v122;
        let v123: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v124: bool = cfg!(target_arch = "wasm32");
        if v124 {
            let mut v125: Rc<str> = v118.borrow().l0.clone();
            let v126: bool = &*v125 == "";
            let v133: Rc<str> = if v126 {
                v112.clone()
            } else {
                let v127: bool = &*v112 == "";
                if v127 {
                    let v128: Rc<str> = v118.borrow().l0.clone();
                    v128
                } else {
                    let v129: Rc<str> = v118.borrow().l0.clone();
                    let v130: Rc<str> = Rc::<str>::from(format!("{}{}", v129, { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let v131: Rc<str> = Rc::<str>::from(format!("{}{}", v130, v112.clone()));
                    v131
                }
            };
            let v135: usize = v133.len();
            let v136: i32 = ((v135) as i32);
            let v137: i32 = v136.wrapping_add(14999i32);
            let v138: i32 = v137.wrapping_div(15000i32);
            let v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v140: bool = v112 != v139 ;
            let v142: bool = if v140 {
                let v141: bool = v138 <= 1i32;
                v141
            } else {
                false
            };
            if v142 {
                v118.borrow_mut().l0 = v133;
                ()
            } else {
                v118.borrow_mut().l0 = v139;
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v133); };
                ()
            }
        } else {
            println!("{}", v112);
            ()
        };
        let mut v145: Rc<dyn Fn(Rc<str>) -> ()> = v116.borrow().l0.clone();
        v145(v112);
        US2::US2_Some(v115, v116, v117, v118, v119, v120)
    };
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 1 });
}
