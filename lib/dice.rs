#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
static SPIRAL_NATIVE_RNG: std::sync::atomic::AtomicU64 = std::sync::atomic::AtomicU64::new(0);
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
#[derive(Clone)]
enum US0 {
    US0_One,
    US0_Two,
    US0_Three,
    US0_Four,
    US0_Five,
    US0_Six,
}
struct Mut0 { l0: i64 }
struct Mut1 { l0: Rc<dyn Fn(Rc<str>) -> ()> }
struct Mut2 { l0: bool }
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum US1 {
    US1_Verbose,
    US1_Debug,
    US1_Info,
    US1_Warning,
    US1_Critical,
}
struct Mut4 { l0: US1 }
#[derive(Clone)]
enum US2 {
    US2_Some(US1),
    US2_None,
}
struct Mut5 { l0: i32, l1: US2 }
#[derive(Clone)]
enum US3 {
    US3_Some(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US3_None,
}
#[derive(Clone)]
enum US4 {
    US4_Some([i64; 3]),
    US4_None,
}
impl US0 {
    fn tag(&self) -> i32 {
        match self {
            US0::US0_One => 0,
            US0::US0_Two => 1,
            US0::US0_Three => 2,
            US0::US0_Four => 3,
            US0::US0_Five => 4,
            US0::US0_Six => 5,
        }
    }
}
fn go_0(mut v0: i32, mut v1: i64) -> i32 {
    loop {
        let mut v2: bool = v1 >= 4738381338321616896i64;
        if v2 {
            return v0;
        } else {
            let v3: i32 = v0.wrapping_add(1i32);
            let v4: i64 = v1.wrapping_mul(6i64);
            (v0, v1) = (v3, v4);
            continue;
        }
    }
}
fn read_2(mut v0: i32, mut v1: i64, mut v2: i64) -> i64 {
    loop {
        let v3: bool = v0 <= 0i32;
        if v3 {
            return v2;
        } else {
            let v4: i64 = (0i32 as i64);
            let v5: i64 = (6i32 as i64);
            let v6: u64 = SPIRAL_NATIVE_RNG.load(std::sync::atomic::Ordering::Relaxed);
            let v7: bool = v6 == 0u64;
            let v22: u64 = if v7 {
                let mut v8: std::collections::hash_map::DefaultHasher = std::hash::BuildHasher::build_hasher(&std::collections::hash_map::RandomState::new());
                let v10: bool = true; // 1;
                let mut v8 = v8;
                let mut v12: std::time::SystemTime = std::time::SystemTime::now();
                let mut v13: std::time::Duration = v12.duration_since(std::time::UNIX_EPOCH).unwrap_or_default();
                let v14: u64 = v13.as_secs();
                let mut v15: u64 = v14.wrapping_mul(1000000000u64);
                let v16: u32 = v13.subsec_nanos();
                let v17: u64 = (v16 as u64);
                let v18: u64 = v15.wrapping_add(v17);
                std::hash::Hasher::write_u64(&mut v8, v18);
                let v19: u64 = std::hash::Hasher::finish(&v8);
                std::hash::Hasher::write_u64(&mut v8, v19);
                let v20: u64 = std::hash::Hasher::finish(&v8);
                let v21: u64 = v19 | 1u64;
                v21
            } else {
                v6
            };
            let v23: u64 = v22.wrapping_shl((13i32) as u32);
            let v24: u64 = v22 ^ v23;
            let v25: u64 = v24.wrapping_shr((7i32) as u32);
            let v26: u64 = v24 ^ v25;
            let v27: u64 = v26.wrapping_shl((17i32) as u32);
            let v28: u64 = v26 ^ v27;
            SPIRAL_NATIVE_RNG.store(v28, std::sync::atomic::Ordering::Relaxed);
            let v29: i64 = v5.wrapping_sub(v4);
            let mut v30: bool = v29 <= 0i64;
            let v35: i64 = if v30 {
                v4
            } else {
                let v31: u64 = (v29 as u64);
                let v32: u64 = v28.wrapping_rem(v31);
                let v33: i64 = (v32 as i64);
                let v34: i64 = v4.wrapping_add(v33);
                v34
            };
            let v36: i32 = ((v35) as i32);
            let v37: bool = 0i32 == v36;
            let v52: US0 = if v37 {
                US0::US0_One
            } else {
                let v39: bool = 1i32 == v36;
                if v39 {
                    US0::US0_Two
                } else {
                    let v41: bool = 2i32 == v36;
                    if v41 {
                        US0::US0_Three
                    } else {
                        let mut v43: bool = 3i32 == v36;
                        if v43 {
                            US0::US0_Four
                        } else {
                            let v45: bool = 4i32 == v36;
                            if v45 {
                                US0::US0_Five
                            } else {
                                US0::US0_Six
                            }
                        }
                    }
                }
            };
            let v53: i32 = v0.wrapping_sub(1i32);
            let v54: i64 = v1.wrapping_mul(6i64);
            let v55: i32 = (v52.tag() as i32);
            let v56: i64 = (v55 as i64);
            let v57: i64 = v56.wrapping_mul(v1);
            let v58: i64 = v2.wrapping_add(v57);
            (v0, v1, v2) = (v53, v54, v58);
            continue;
        }
    }
}
fn roll_fresh_1(mut v0: i64, mut v1: i32) -> i64 {
    loop {
        let mut v2: i64 = 1i64;
        let v3: i64 = 0i64;
        let v4: i64 = read_2(v1, v2, v3);
        let v5: bool = v4 < v0;
        if v5 {
            let v6: i64 = v4.wrapping_add(1i64);
            return v6;
        } else {
            continue;
        }
    }
}
fn get_environment_variable_4(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = Rc::<str>::from(std::env::var(&*v0).unwrap_or_default());
    v1
}
fn method5(mut v0: &Rc<RefCell<Mut5>>) -> bool {
    let mut v1: i32 = v0.borrow().l0;
    let mut v2: bool = v1 > 0i32;
    v2
}
fn closure1() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn new_trace_state_3(mut v0: US1) -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
    let mut v1: bool = cfg!(target_arch = "wasm32");
    let v45: US2 = if v1 {
        US2::US2_None
    } else {
        let v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
        let v4: Rc<str> = get_environment_variable_4(v3);
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
        let v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
        let v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
        let v14: Rc<str> = Rc::<str>::from(v13.to_lowercase());
        let mut v15: Rc<RefCell<Vec<(Rc<str>, US1)>>> = Rc::new(RefCell::new(Vec::new()));
        let v16: US1 = US1::US1_Verbose;
        v15.borrow_mut().push((v13, v16));
        let v17: US1 = US1::US1_Debug;
        v15.borrow_mut().push((v11, v17));
        let v18: US1 = US1::US1_Info;
        v15.borrow_mut().push((v9, v18));
        let v19: US1 = US1::US1_Warning;
        v15.borrow_mut().push((v7, v19));
        let v20: US1 = US1::US1_Critical;
        v15.borrow_mut().push((v5, v20));
        let v21: US1 = US1::US1_Verbose;
        v15.borrow_mut().push((v14, v21));
        let v22: US1 = US1::US1_Debug;
        v15.borrow_mut().push((v12, v22));
        let v23: US1 = US1::US1_Info;
        v15.borrow_mut().push((v10, v23));
        let v24: US1 = US1::US1_Warning;
        v15.borrow_mut().push((v8, v24));
        let v25: US1 = US1::US1_Critical;
        v15.borrow_mut().push((v6, v25));
        let v26: Rc<Vec<(Rc<str>, US1)>> = Rc::new(v15.borrow().clone());
        let v27: Rc<RefCell<Vec<(Rc<str>, US1)>>> = Rc::new(RefCell::new((v26).as_ref().clone()));
        let v28: i32 = (v27.clone().borrow().len() as i32);
        let v29: US2 = US2::US2_None;
        let mut v30: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: v28, l1: v29 }));
        while method5(&v30) {
            let v32: i32 = v30.borrow().l0;
            let v33: i32 = v32.wrapping_sub(1i32);
            let v34: US2 = v30.borrow().l1.clone();
            let (mut v35, mut v36): (Rc<str>, US1) = v27.borrow()[v33 as usize].clone();
            let mut v43: US2 = match &v34 {
                US2::US2_None => {
                    let v38: bool = v35 == v4 ;
                    if v38 {
                        US2::US2_Some(v36)
                    } else {
                        US2::US2_None
                    }
                }
                US2::US2_Some(v37) => {
                    let v37: US1 = v37.clone();
                    v34
                }
            };
            v30.borrow_mut().l0 = v33;
            v30.borrow_mut().l1 = v43;
            ()
        };
        let v44: US2 = v30.borrow().l1.clone();
        v44
    };
    let mut v46: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let v47: Rc<dyn Fn(Rc<str>) -> ()> = closure1();
    let v48: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v47 }));
    let v49: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v51: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v50 }));
    let v54: US1 = match v45 {
        US2::US2_None => {
            v0
        }
        US2::US2_Some(v52) => {
            let v52: US1 = v52;
            v52
        }
    };
    let v55: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v54 }));
    let v56: Option<i64> = None;
    (v46, v48, v49, v51, v55, v56)
}
fn fresh_c0() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US1 = US1::US1_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_3(v0);
        (v1, v2, v3, v4, v5, v6)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c2() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US1 = US1::US1_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_3(v0);
        (v1, v2, v3, v4, v5, v6)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method8(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn method9(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
fn method7(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let v3: i32 = method8(v0.clone(), v1, v2);
    let v4: i32 = v1.wrapping_sub(1i32);
    let v5: Rc<str> = string_slice(&v0, v3 as i64, v4 as i64);
    let v6: i32 = (v5.clone().len() as i32);
    let v7: i32 = method9(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5, 0i32 as i64, v7 as i64);
    v8
}
fn method11(mut v0: &Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let v3: Rc<str> = string_concat(&[&*v2, &*v1]);
    v0.borrow_mut().l0 = v3;
    ()
}
fn format_real_10(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method11(&v2, v3);
    let v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method13(mut v0: Option<[i64; 3]>) -> Option<[i64; 3]> {
    v0
}
fn closure3() -> Rc<dyn Fn(([i64; 3])) -> US4> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(([i64; 3])) -> US4> = Rc::new(move |mut v0: ([i64; 3])| -> US4 {
        let mut v1: [i64; 3] = (v0);
        US4::US4_Some(v1)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn time_12(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let v6: Option<[i64; 3]> = spiral_cfg_local_clock();
    let v7: Option<[i64; 3]> = method13(v6);
    let mut v8: Rc<dyn Fn(([i64; 3])) -> US4> = closure3();
    let mut v9: Option<US4> = v7.map(|x| v8(x));
    let v11: US4 = US4::US4_None;
    let mut v12: US4 = v11.clone();
    let mut v13: US4 = v9.unwrap_or(v12);
    let v27: u64 = match v13 {
        US4::US4_None => {
            let v23: u64 = spiral_cfg_epoch_nanos();
            let v24: u64 = v23.wrapping_div(1000000000u64);
            let v25: u64 = v24.wrapping_rem(86400u64);
            v25
        }
        US4::US4_Some(v14) => {
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
    let mut v43: Rc<str> = Rc::<str>::from((v38).to_string());
    let mut v46: Rc<str> = string_concat(&[&*v36, &*v42, &*v43, ":"]);
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
fn level_str_14() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let v3: Rc<str> = string_concat(&[&*v0, "d", &*v2]);
    v3
}
fn method6(mut v0: &Rc<RefCell<Mut0>>, mut v1: &Rc<RefCell<Mut1>>, mut v2: &Rc<RefCell<Mut2>>, mut v3: &Rc<RefCell<Mut3>>, mut v4: &Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: &Rc<RefCell<Mut0>>, mut v7: &Rc<RefCell<Mut1>>, mut v8: &Rc<RefCell<Mut2>>, mut v9: &Rc<RefCell<Mut3>>, mut v10: &Rc<RefCell<Mut4>>, mut v11: Option<i64>, mut v12: i64) -> Rc<str> {
    let mut v13: bool = cfg!(target_arch = "wasm32");
    let v34: Rc<str> = if v13 {
        let v14: Rc<str> = format_real_10(v12);
        let v18: Rc<str> = string_concat(&["d dice.main / { result = ", &*v14, " }"]);
        v18
    } else {
        let v19: i64 = v0.borrow().l0;
        let v20: Rc<str> = time_12(v6, v7, v8, v9, v10, v11);
        let v22: Rc<str> = format_real_10(v19);
        let v24: Rc<str> = level_str_14();
        let v29: Rc<str> = format_real_10(v12);
        let v33: Rc<str> = string_concat(&[&*v20, " ", &*v22, &*v24, " dice.main / { result = ", &*v29, " }"]);
        v33
    };
    method7(v34)
}
fn closure4() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn spiral_main() -> i32 {
    let mut v1: i32 = 0i32;
    let mut v2: i64 = 1i64;
    let v3: i32 = go_0(v1, v2);
    let v4: i64 = 4738381338321616896i64;
    let v5: i64 = roll_fresh_1(v4, v3);
    let v6: bool = matches!(option_env!("SPIRAL_TRACE_FLOOR"), Some("Info" | "Warning" | "Critical"));
    let v28: bool = if v6 {
        true
    } else {
        let mut v8: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v8); };
        let v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v11, mut v12, mut v13, mut v14, mut v15, mut v16): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v10);
        let v17: US1 = v15.borrow().l0.clone();
        let v22: i32 = match v17 {
            US1::US1_Critical => {
                50i32
            }
            US1::US1_Debug => {
                20i32
            }
            US1::US1_Info => {
                30i32
            }
            US1::US1_Verbose => {
                10i32
            }
            US1::US1_Warning => {
                40i32
            }
        };
        let v23: bool = v13.borrow().l0;
        let v24: bool = v23 == false;
        let v26: bool = if v24 {
            false
        } else {
            let v25: bool = 20i32 >= v22;
            v25
        };
        let v27: bool = v26 == false;
        v27
    };
    let v75: US3 = if v28 {
        US3::US3_None
    } else {
        let v31: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
        { let _ = spiral_trace_hold(&v31); };
        let v33: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        let (mut v34, mut v35, mut v36, mut v37, mut v38, mut v39): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v33);
        let v40: Rc<str> = method6(&v34, &v35, &v36, &v37, &v38, v39.clone(), &v34, &v35, &v36, &v37, &v38, v39, v5);
        { let _ = spiral_trace_hold(&v31); };
        let (mut v43, mut v44, mut v45, mut v46, mut v47, mut v48): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v33);
        let v49: i64 = v43.borrow().l0;
        let v50: i64 = v49.wrapping_add(1i64);
        v43.borrow_mut().l0 = v50;
        let v51: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let v52: bool = cfg!(target_arch = "wasm32");
        if v52 {
            let v53: Rc<str> = v46.borrow().l0.clone();
            let v54: bool = &*v53 == "";
            let v61: Rc<str> = if v54 {
                v40.clone()
            } else {
                let v55: bool = &*v40 == "";
                if v55 {
                    let v56: Rc<str> = v46.borrow().l0.clone();
                    v56
                } else {
                    let v57: Rc<str> = v46.borrow().l0.clone();
                    let v59: Rc<str> = string_concat(&[&*v57, "\n", &*v40]);
                    v59
                }
            };
            let v63: usize = v61.len();
            let v64: i32 = ((v63) as i32);
            let v65: i32 = v64.wrapping_add(14999i32);
            let v66: i32 = v65.wrapping_div(15000i32);
            let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v68: bool = v40 != v67 ;
            let v70: bool = if v68 {
                let v69: bool = v66 <= 1i32;
                v69
            } else {
                false
            };
            if v70 {
                v46.borrow_mut().l0 = v61;
                ()
            } else {
                v46.borrow_mut().l0 = v67;
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v61); };
                ()
            }
        } else {
            println!("{}", v40);
            ()
        };
        let mut v73: Rc<dyn Fn(Rc<str>) -> ()> = v44.borrow().l0.clone();
        v73(v40);
        US3::US3_Some(v43, v44, v45, v46, v47, v48)
    };
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 1 });
}
