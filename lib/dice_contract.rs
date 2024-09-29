#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_1d76f080 {
    pub mod Dice {
        use super::*;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Dice::Mut0>,
                        LrcPtr<Dice::Mut1>,
                        LrcPtr<Dice::Mut2>,
                        LrcPtr<Dice::Mut3>,
                        LrcPtr<Dice::Mut4>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Dice::Mut0>,
                                LrcPtr<Dice::Mut1>,
                                LrcPtr<Dice::Mut2>,
                                LrcPtr<Dice::Mut3>,
                                LrcPtr<Dice::Mut4>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Dice::Mut0>,
                                LrcPtr<Dice::Mut1>,
                                LrcPtr<Dice::Mut2>,
                                LrcPtr<Dice::Mut3>,
                                LrcPtr<Dice::Mut4>,
                                Option<i64>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        pub trait IOsEnviron {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + Clone + 'static> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH0 {
            UH0_0(u8, Func0<LrcPtr<Dice::UH0>>),
            UH0_1,
        }
        impl core::fmt::Display for Dice::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH1 {
            UH1_0,
            UH1_1(u8, LrcPtr<Dice::UH1>),
        }
        impl core::fmt::Display for Dice::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for Dice::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Dice::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Dice::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Dice::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Dice::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<Dice::US0>,
        }
        impl core::fmt::Display for Dice::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(string),
            US1_1,
        }
        impl core::fmt::Display for Dice::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Dice::US0),
            US2_1,
        }
        impl core::fmt::Display for Dice::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
        }
        impl core::fmt::Display for Dice::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0(Func0<LrcPtr<Dice::UH0>>),
            US4_1(LrcPtr<Dice::UH0>),
        }
        impl core::fmt::Display for Dice::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut5 {
            pub l0: MutCell<Dice::US4>,
        }
        impl core::fmt::Display for Dice::Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(u8),
            US5_1,
        }
        impl core::fmt::Display for Dice::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut6 {
            pub l0: MutCell<Dice::US5>,
        }
        impl core::fmt::Display for Dice::Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(u64, LrcPtr<Dice::UH1>),
            US6_1,
        }
        impl core::fmt::Display for Dice::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH2 {
            UH2_0(u64, Func0<LrcPtr<Dice::UH2>>),
            UH2_1,
        }
        impl core::fmt::Display for Dice::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(u64),
            US7_1,
        }
        impl core::fmt::Display for Dice::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0(i64, LrcPtr<Dice::UH1>),
            US8_1,
        }
        impl core::fmt::Display for Dice::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure2(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn method0(
            v0_1: i64,
            v1_1: LrcPtr<Dice::UH0>,
            v2_1: LrcPtr<Dice::UH0>,
        ) -> LrcPtr<Dice::UH0> {
            match v1_1.as_ref() {
                Dice::UH0::UH0_1 => v2_1.clone(),
                Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                    let v6: LrcPtr<Dice::UH0> = Dice::method0(v0_1, (v1_1_0_1)(), v2_1.clone());
                    LrcPtr::new(Dice::UH0::UH0_0(
                        ((v1_1_0_0.clone() as i64 - 1_i64 + v0_1) % v0_1 + 1_i64) as u8,
                        Func0::new({
                            let v6 = v6.clone();
                            move || Dice::closure2(v6.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure1(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
            Dice::method0(v0_1, v1_1, LrcPtr::new(Dice::UH0::UH0_1))
        }
        pub fn closure0(unitVar: (), v0_1: i64) -> Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice::UH0>| Dice::closure1(v0_1, v)
            })
        }
        pub fn method2() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method4() -> string {
            string("")
        }
        pub fn closure6(unitVar: (), v0_1: string) -> Dice::US1 {
            Dice::US1::US1_0(v0_1)
        }
        pub fn method5() -> Func1<string, Dice::US1> {
            Func1::new(move |v: string| Dice::closure6((), v))
        }
        pub fn method3(v0_1: string) -> string {
            let v33: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v35: bool = true;
            let _result_map_ = v33.map(|x| {
                //;
                let v37: std::string::String = x;
                let v39: string = fable_library_rust::String_::fromString(v37);
                let v41: bool = true;
                v39
            });
            let v43: Result<string, std::env::VarError> = _result_map_;
            let v44: string = Dice::method4();
            v43.unwrap_or(v44)
        }
        pub fn method6() -> string {
            string("AUTOMATION")
        }
        pub fn closure7(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
            v0_1: Dice::US0,
        ) -> (
            LrcPtr<Dice::Mut0>,
            LrcPtr<Dice::Mut1>,
            LrcPtr<Dice::Mut2>,
            LrcPtr<Dice::Mut3>,
            LrcPtr<Dice::Mut4>,
            Option<i64>,
        ) {
            let v117: string = string("env!(\"AUTOMATION\")");
            let v118: &str = env!("AUTOMATION");
            let v125: std::string::String = String::from(v118);
            let _v1: (Dice::US2, Dice::US3) = (
                Dice::US2::US2_1,
                if fable_library_rust::String_::fromString(v125) != string("True") {
                    Dice::US3::US3_1
                } else {
                    Dice::US3::US3_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v352: Dice::US3 = _v1.1.clone();
            let v351: Dice::US2 = _v1.0.clone();
            (
                LrcPtr::new(Dice::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Dice::closure7((), v))),
                }),
                LrcPtr::new(Dice::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Dice::Mut4 {
                    l0: MutCell::new(match &v351 {
                        Dice::US2::US2_0(v351_0_0) => match &v351 {
                            Dice::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v352 {
                    Dice::US3::US3_0(v352_0_0) => Some(match &v352 {
                        Dice::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) {
            if Dice::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = Dice::method1(Dice::US0::US0_0);
                Dice::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure8(unitVar: (), v0_1: i64) -> Dice::US3 {
            Dice::US3::US3_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Dice::US3> {
            Func1::new(move |v: i64| Dice::closure8((), v))
        }
        pub fn method9() -> string {
            string("hh:mm:ss")
        }
        pub fn method10() -> string {
            string("HH:mm:ss")
        }
        pub fn method7(
            v0_1: LrcPtr<Dice::Mut0>,
            v1_1: LrcPtr<Dice::Mut1>,
            v2_1: LrcPtr<Dice::Mut2>,
            v3_1: LrcPtr<Dice::Mut3>,
            v4_1: LrcPtr<Dice::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v130: u64 = near_sdk::env::block_timestamp();
            let v144: Dice::US3 = defaultValue(Dice::US3::US3_1, map(Dice::method8(), v5));
            let v154: u64 = match &v144 {
                Dice::US3::US3_0(v144_0_0) => {
                    v130 - match &v144 {
                        Dice::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v130,
            } / 1000000000_u64;
            let v155: u64 = v154 % 60_u64;
            let v157: u64 = v154 / 60_u64 % 60_u64;
            let v159: u64 = v154 / 3600_u64 % 24_u64;
            let v161: std::string::String = format!("{:02}:{:02}:{:02}", v159, v157, v155);
            fable_library_rust::String_::fromString(v161)
        }
        pub fn method12() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v5: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v79: &str = inline_colorization::color_bright_blue;
            let v86: &str = &*v5;
            let v102: &str = inline_colorization::color_reset;
            let v104: std::string::String = format!("{}{}{}", v79, v86, v102);
            fable_library_rust::String_::fromString(v104)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn method13() -> string {
            let v1_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method15(
            v0_1: string,
            v1_1: string,
            v2_1: string,
            v3_1: i64,
            v4_1: string,
        ) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!("{} {} #{} {} / {}", v0_1, v1_1, v3_1, v2_1, v4_1),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure9(v0_1: LrcPtr<Dice::Mut0>, unitVar: ()) {
            let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2_1);
            ()
        }
        pub fn closure11(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure10(unitVar: (), v0_1: string) {
            let v3_1: () = {
                Dice::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn method16(
            v0_1: string,
            v1_1: LrcPtr<Dice::Mut0>,
            v2_1: LrcPtr<Dice::Mut1>,
            v3_1: LrcPtr<Dice::Mut2>,
            v4_1: LrcPtr<Dice::Mut3>,
            v5: LrcPtr<Dice::Mut4>,
            v6: Option<i64>,
        ) {
            let v9: () = {
                Dice::closure9(v1_1, ());
                ()
            };
            let v25: string = if v4_1.l0.get().clone() == string("") {
                v0_1.clone()
            } else {
                if v0_1.clone() == string("") {
                    v4_1.l0.get().clone()
                } else {
                    append(append(v4_1.l0.get().clone(), string("\n")), v0_1.clone())
                }
            };
            let v32: &str = &*v25.clone();
            let v48 = v32.chars();
            let v50 = v48;
            let v52: Vec<char> = v50.collect::<Vec<_>>();
            let v54: Vec<Vec<char>> = v52
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v56: bool = true;
            let _vec_map: Vec<_> = v54
                .into_iter()
                .map(|x| {
                    //;
                    let v58: Vec<char> = x;
                    let v60: std::string::String = String::from_iter(v58);
                    let v62: bool = true;
                    v60
                })
                .collect::<Vec<_>>();
            let v64: Vec<std::string::String> = _vec_map;
            if if v0_1.clone() != string("") {
                v64.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v4_1.l0.set(v25);
                ()
            } else {
                v4_1.l0.set(string(""));
                {
                    let v76: bool = true;
                    v64.into_iter().for_each(|x| {
                        //;
                        let v78: std::string::String = x;
                        let v80: bool = true;
                        near_sdk::log!("{}", v78);
                        let v82: bool = true;
                        let v84: bool = true;
                    }); //;
                    ()
                }
            }
            ();
            (v2_1.l0.get().clone())(v0_1)
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) {
            fn v1_1() {
                Dice::closure5((), ());
            }
            let v2_1: () = {
                v1_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v34: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v34,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v41: () = {
                    v1_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v55: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v81: string = Dice::method15(
                    Dice::method7(
                        v55.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.create_sequential_roller ()"),
                    v55.l0.get().clone(),
                    Dice::method13(),
                );
                let v83: () = {
                    v1_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method17(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            '_method17: loop {
                break '_method17 (match v0_1.get().clone().as_ref() {
                    Dice::UH1::UH1_0 => v1_1.get().clone(),
                    Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = match v0_1.get().clone().as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_1_temp: LrcPtr<Dice::UH1> = LrcPtr::new(Dice::UH1::UH1_1(
                            match v0_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method17;
                    }
                });
            }
        }
        pub fn method18(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => LrcPtr::new(Dice::UH1::UH1_1(
                    match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice::method18(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn closure12(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn method19(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH0> = Dice::method19(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    );
                    LrcPtr::new(Dice::UH0::UH0_0(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Func0::new({
                            let v4_1 = v4_1.clone();
                            move || Dice::closure12(v4_1.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure13(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn closure14(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: LrcPtr<Dice::Mut5>,
            unitVar: (),
        ) -> LrcPtr<Dice::UH0> {
            let v2_1: Dice::US4 = v1_1.l0.get().clone();
            match &v2_1 {
                Dice::US4::US4_0(v2_1_0_0) => {
                    let v5: LrcPtr<Dice::UH0> = (v2_1_0_0)();
                    let v12: LrcPtr<Dice::UH0> = match v5.as_ref() {
                        Dice::UH0::UH0_1 => LrcPtr::new(Dice::UH0::UH0_1),
                        Dice::UH0::UH0_0(v5_0_0, v5_0_1) => LrcPtr::new(Dice::UH0::UH0_0(
                            v5_0_0.clone(),
                            Dice::method20(v0_1, v5_0_1.clone()),
                        )),
                    };
                    v1_1.l0.set(Dice::US4::US4_1(v12.clone()));
                    v12
                }
                Dice::US4::US4_1(v2_1_1_0) => v2_1_1_0.clone(),
            }
        }
        pub fn method20(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
        ) -> Func0<LrcPtr<Dice::UH0>> {
            let v3_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::US4::US4_0(v1_1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3_1 = v3_1.clone();
                move || Dice::closure14(v0_1.clone(), v3_1.clone(), ())
            })
        }
        pub fn closure17(v0_1: LrcPtr<Dice::Mut3>, v1_1: string, unitVar: ()) {
            let v3_1: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3_1);
            ()
        }
        pub fn method22(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: Option<u8>) -> string {
            let v5: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v12: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("current_index")), ());
                ()
            };
            let v30: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v64: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("len")), ());
                ()
            };
            let v97: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("last_item")), ());
                ()
            };
            let v130: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v143: std::string::String = format!("{:#?}", v3_1);
            let v165: () = {
                Dice::closure17(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v143)),
                    (),
                );
                ()
            };
            let v174: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn closure16(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: Option<u8>, unitVar: ()) {
            fn v5() {
                Dice::closure5((), ());
            }
            let v6: () = {
                v5();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v38: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.create_sequential_roller / roll"),
                    v59.l0.get().clone(),
                    Dice::method22(v0_1, v1_1, v2_1, v3_1),
                );
                let v87: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method23(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> Dice::US5 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1_1.clone());
            '_method23: loop {
                break '_method23 (match v1_1.get().clone().as_ref() {
                    Dice::UH0::UH0_1 => Dice::US5::US5_1,
                    Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get().clone() <= 0_i64 {
                            Dice::US5::US5_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = v0_1.get().clone() - 1_i64;
                            let v1_1_temp: LrcPtr<Dice::UH0> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method23;
                        }
                    }
                });
            }
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) {
            fn v1_1() {
                Dice::closure5((), ());
            }
            let v2_1: () = {
                v1_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v34: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v34,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v41: () = {
                    v1_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v55: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v81: string = Dice::method15(
                    Dice::method7(
                        v55.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.create_sequential_roller / roll / None"),
                    v55.l0.get().clone(),
                    Dice::method13(),
                );
                let v83: () = {
                    v1_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method21(
            v0_1: Func0<LrcPtr<Dice::UH0>>,
            v1_1: LrcPtr<Dice::Mut0>,
            v2_1: LrcPtr<Dice::Mut0>,
            v3_1: LrcPtr<Dice::Mut0>,
            v4_1: LrcPtr<Dice::Mut6>,
        ) -> u8 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Dice::Mut0>> = MutCell::new(v1_1.clone());
            let v2_1: MutCell<LrcPtr<Dice::Mut0>> = MutCell::new(v2_1.clone());
            let v3_1: MutCell<LrcPtr<Dice::Mut0>> = MutCell::new(v3_1.clone());
            let v4_1: MutCell<LrcPtr<Dice::Mut6>> = MutCell::new(v4_1.clone());
            '_method21: loop {
                break '_method21 ({
                    let v5: i64 = v1_1.l0.get().clone();
                    let v6: i64 = v2_1.l0.get().clone();
                    let v7: i64 = v3_1.l0.get().clone();
                    let v8: Dice::US5 = v4_1.l0.get().clone();
                    let v18: () = {
                        Dice::closure16(
                            v5,
                            v6,
                            v7,
                            match &v8 {
                                Dice::US5::US5_0(v8_0_0) => Some(match &v8 {
                                    Dice::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => None::<u8>,
                            },
                            (),
                        );
                        ()
                    };
                    let v134: LrcPtr<Dice::UH0> = v0_1();
                    let v136: Dice::US5 = Dice::method23(v1_1.l0.get().clone(), v134);
                    match &v136 {
                        Dice::US5::US5_0(v136_0_0) => {
                            let v137: u8 = match &v136 {
                                Dice::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v139: i64 = v1_1.l0.get().clone() + 1_i64;
                            v1_1.l0.set(v139);
                            v4_1.l0.set(Dice::US5::US5_0(v137));
                            v137
                        }
                        _ => {
                            let v143: () = {
                                Dice::closure18((), ());
                                ()
                            };
                            if v3_1.l0.get().clone() == -1_i64 {
                                let v261: i64 = v1_1.l0.get().clone();
                                v3_1.l0.set(v261);
                                ()
                            }
                            {
                                let v267: i64 = if v2_1.l0.get().clone() >= v3_1.l0.get().clone() {
                                    1_i64
                                } else {
                                    v2_1.l0.get().clone() + 1_i64
                                };
                                v2_1.l0.set(v267);
                                {
                                    let v269: i64 = v2_1.l0.get().clone() - 1_i64;
                                    v1_1.l0.set(v269);
                                    v4_1.l0.set(Dice::US5::US5_1);
                                    {
                                        let v0_1_temp = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Dice::Mut0> = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Dice::Mut0> = v2_1.get().clone();
                                        let v3_1_temp: LrcPtr<Dice::Mut0> = v3_1.get().clone();
                                        let v4_1_temp: LrcPtr<Dice::Mut6> = v4_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        v4_1.set(v4_1_temp);
                                        continue '_method21;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure15(
            v0_1: Func0<LrcPtr<Dice::UH0>>,
            v1_1: LrcPtr<Dice::Mut0>,
            v2_1: LrcPtr<Dice::Mut0>,
            v3_1: LrcPtr<Dice::Mut0>,
            v4_1: LrcPtr<Dice::Mut6>,
            unitVar: (),
        ) -> u8 {
            Dice::method21(v0_1, v1_1, v2_1, v3_1, v4_1)
        }
        pub fn closure3(unitVar: (), v0_1: LrcPtr<Dice::UH1>) -> Func0<u8> {
            let v3_1: () = {
                Dice::closure4((), ());
                ()
            };
            let v123: LrcPtr<Dice::UH0> = Dice::method19(
                Dice::method18(
                    v0_1.clone(),
                    Dice::method17(v0_1, LrcPtr::new(Dice::UH1::UH1_0)),
                ),
                LrcPtr::new(Dice::UH0::UH0_1),
            );
            let v125 = Dice::method20(
                v123.clone(),
                Func0::new({
                    let v123 = v123.clone();
                    move || Dice::closure13(v123.clone(), ())
                }),
            );
            let v126: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(0_i64),
            });
            let v127: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(1_i64),
            });
            let v128: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(-1_i64),
            });
            let v130: LrcPtr<Dice::Mut6> = LrcPtr::new(Dice::Mut6 {
                l0: MutCell::new(Dice::US5::US5_1),
            });
            Func0::new({
                let v125 = v125.clone();
                let v126 = v126.clone();
                let v127 = v127.clone();
                let v128 = v128.clone();
                let v130 = v130.clone();
                move || {
                    Dice::closure15(
                        v125.clone(),
                        v126.clone(),
                        v127.clone(),
                        v128.clone(),
                        v130.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method25(v0_1: u64, v1_1: i8, v2_1: u64) -> string {
            let v4_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v11: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("max")), ());
                ()
            };
            let v29: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("n")), ());
                ()
            };
            let v63: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("p")), ());
                ()
            };
            let v96: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn closure22(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.calculate_dice_count"),
                    v58.l0.get().clone(),
                    Dice::method25(v0_1, v1_1, v2_1),
                );
                let v86: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method24(v0_1: u64, v1_1: i8, v2_1: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method24: loop {
                break '_method24 (if v2_1.get().clone() < v0_1.get().clone() {
                    let v4_1: u64 = v2_1.get().clone() * 6_u64;
                    if v4_1 > v2_1.get().clone() {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                        let v2_1_temp: u64 = v4_1;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method24;
                    } else {
                        let v10: () = {
                            Dice::closure22(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                (),
                            );
                            ()
                        };
                        v1_1.get().clone()
                    }
                } else {
                    let v129: () = {
                        Dice::closure22(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            (),
                        );
                        ()
                    };
                    v1_1.get().clone()
                });
            }
        }
        pub fn method28(v0_1: i8, v1_1: u64, v2_1: u64) -> string {
            let v4_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v11: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn closure23(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method28(v1_1, v0_1, v2_1),
                );
                let v86: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure87(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_1)
        }
        pub fn closure86(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice::closure87((), ())),
            ))
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice::closure86((), ())),
            ))
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice::closure85((), ())),
            ))
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice::closure84((), ())),
            ))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice::closure83((), ())),
            ))
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice::closure82((), ())),
            ))
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice::closure81((), ())),
            ))
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice::closure25((), ())),
            ))
        }
        pub fn method29(v0_1: i8, v1_1: LrcPtr<Dice::UH2>) -> Dice::US7 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH2>> = MutCell::new(v1_1.clone());
            '_method29: loop {
                break '_method29 (match v1_1.get().clone().as_ref() {
                    Dice::UH2::UH2_1 => Dice::US7::US7_1,
                    Dice::UH2::UH2_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get().clone() <= 0_i8 {
                            Dice::US7::US7_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                            let v1_1_temp: LrcPtr<Dice::UH2> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method29;
                        }
                    }
                });
            }
        }
        pub fn method30(v0_1: i8, v1_1: u64, v2_1: u8, v3_1: u64) -> string {
            let v5: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v12: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v30: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v64: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v97: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("value")), ());
                ()
            };
            let v130: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v3_1), ());
                ()
            };
            let v147: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn closure88(v0_1: u64, v1_1: i8, v2_1: u8, v3_1: u64, unitVar: ()) {
            fn v5() {
                Dice::closure5((), ());
            }
            let v6: () = {
                v5();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v38: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v59.l0.get().clone(),
                    Dice::method30(v1_1, v0_1, v2_1, v3_1),
                );
                let v87: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method31(v0_1: i8, v1_1: u64, v2_1: u8) -> string {
            let v4_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v11: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v96: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn closure89(v0_1: u64, v1_1: i8, v2_1: u8, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method31(v1_1, v0_1, v2_1),
                );
                let v86: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method27(v0_1: i8, v1_1: LrcPtr<Dice::UH1>, v2_1: u64) -> Dice::US6 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method27: loop {
                break '_method27 (if v0_1.get().clone() < 0_i8 {
                    let v4_1: u64 = v2_1.get().clone() + 1_u64;
                    let v7: () = {
                        Dice::closure23(v2_1.get().clone(), v0_1.get().clone(), v4_1, ());
                        ()
                    };
                    Dice::US6::US6_0(v4_1, v1_1.get().clone())
                } else {
                    match v1_1.get().clone().as_ref() {
                        Dice::UH1::UH1_0 => Dice::US6::US6_1,
                        Dice::UH1::UH1_1(v1_1_1_0, v1_1_1_1) => {
                            let v126: LrcPtr<Dice::UH1> = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v125: u8 = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v125 > 1_u8 {
                                let v131: Dice::US7 = Dice::method29(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice::closure24((), ())),
                                    )),
                                );
                                let v138: u64 = (v125 - 1_u8) as u64
                                    * match &v131 {
                                        Dice::US7::US7_0(v131_0_0) => match &v131 {
                                            Dice::US7::US7_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                let v141: () = {
                                    Dice::closure88(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v125,
                                        v138,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v126;
                                    let v2_1_temp: u64 = v2_1.get().clone() + v138;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method27;
                                }
                            } else {
                                let v262: () = {
                                    Dice::closure89(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v125,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v126.clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method27;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method32(v0_1: i8, v1_1: Func0<u8>, v2_1: i8) -> LrcPtr<Dice::UH1> {
            if v2_1 < v0_1 {
                LrcPtr::new(Dice::UH1::UH1_1(
                    v1_1(),
                    Dice::method32(v0_1, v1_1, v2_1 + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice::UH1::UH1_0)
            }
        }
        pub fn method33(
            v0_1: Func0<u8>,
            v1_1: bool,
            v2_1: u64,
            v3_1: i8,
            v4_1: LrcPtr<Dice::UH1>,
        ) -> u64 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1_1: MutCell<bool> = MutCell::new(v1_1);
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            let v3_1: MutCell<i8> = MutCell::new(v3_1);
            let v4_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v4_1.clone());
            '_method33: loop {
                break '_method33 ({
                    let v5: i8 = v3_1.get().clone() + 1_i8;
                    if v3_1.get().clone() < v5 {
                        Dice::method26(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone())),
                            v5,
                        )
                    } else {
                        let v11: Dice::US6 =
                            Dice::method27(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                        if let Dice::US6::US6_0(v11_0_0, v11_0_1) = &v11 {
                            let v12: u64 = match &v11 {
                                Dice::US6::US6_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v12 <= v2_1.get().clone() {
                                v12
                            } else {
                                if v1_1.get().clone() {
                                    let v0_1_temp = v0_1.get().clone();
                                    let v1_1_temp: bool = v1_1.get().clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    let v3_1_temp: i8 = v3_1.get().clone();
                                    let v4_1_temp: LrcPtr<Dice::UH1> = Dice::method32(
                                        v3_1.get().clone(),
                                        v0_1.get().clone(),
                                        0_i8,
                                    );
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method33;
                                } else {
                                    Dice::method26(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v2_1.get().clone(),
                                        v3_1.get().clone(),
                                        LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone())),
                                        v5,
                                    )
                                }
                            }
                        } else {
                            if v1_1.get().clone() {
                                let v0_1_temp = v0_1.get().clone();
                                let v1_1_temp: bool = v1_1.get().clone();
                                let v2_1_temp: u64 = v2_1.get().clone();
                                let v3_1_temp: i8 = v3_1.get().clone();
                                let v4_1_temp: LrcPtr<Dice::UH1> =
                                    Dice::method32(v3_1.get().clone(), v0_1.get().clone(), 0_i8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                continue '_method33;
                            } else {
                                Dice::method26(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone())),
                                    v5,
                                )
                            }
                        }
                    }
                });
            }
        }
        pub fn method26(
            v0_1: Func0<u8>,
            v1_1: bool,
            v2_1: u64,
            v3_1: i8,
            v4_1: LrcPtr<Dice::UH1>,
            v5: i8,
        ) -> u64 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1_1: MutCell<bool> = MutCell::new(v1_1);
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            let v3_1: MutCell<i8> = MutCell::new(v3_1);
            let v4_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v4_1.clone());
            let v5: MutCell<i8> = MutCell::new(v5);
            '_method26: loop {
                break '_method26 (if v5.get().clone() < v3_1.get().clone() + 1_i8 {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_1_temp: bool = v1_1.get().clone();
                    let v2_1_temp: u64 = v2_1.get().clone();
                    let v3_1_temp: i8 = v3_1.get().clone();
                    let v4_1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone()));
                    let v5_temp: i8 = v5.get().clone() + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    v2_1.set(v2_1_temp);
                    v3_1.set(v3_1_temp);
                    v4_1.set(v4_1_temp);
                    v5.set(v5_temp);
                    continue '_method26;
                } else {
                    let v13: Dice::US6 =
                        Dice::method27(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                    if let Dice::US6::US6_0(v13_0_0, v13_0_1) = &v13 {
                        let v14: u64 = match &v13 {
                            Dice::US6::US6_0(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v14 <= v2_1.get().clone() {
                            v14
                        } else {
                            if v1_1.get().clone() {
                                Dice::method33(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    Dice::method32(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
                                )
                            } else {
                                let v0_1_temp = v0_1.get().clone();
                                let v1_1_temp: bool = v1_1.get().clone();
                                let v2_1_temp: u64 = v2_1.get().clone();
                                let v3_1_temp: i8 = v3_1.get().clone();
                                let v4_1_temp: LrcPtr<Dice::UH1> =
                                    LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone()));
                                let v5_temp: i8 = v5.get().clone() + 1_i8;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                v5.set(v5_temp);
                                continue '_method26;
                            }
                        }
                    } else {
                        if v1_1.get().clone() {
                            Dice::method33(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                Dice::method32(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
                            )
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_1_temp: bool = v1_1.get().clone();
                            let v2_1_temp: u64 = v2_1.get().clone();
                            let v3_1_temp: i8 = v3_1.get().clone();
                            let v4_1_temp: LrcPtr<Dice::UH1> =
                                LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone()));
                            let v5_temp: i8 = v5.get().clone() + 1_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            v5.set(v5_temp);
                            continue '_method26;
                        }
                    }
                });
            }
        }
        pub fn closure21(v0_1: Func0<u8>, v1_1: bool, v2_1: u64) -> u64 {
            Dice::method26(
                v0_1,
                v1_1,
                v2_1,
                (if v2_1 == 1_u64 {
                    1_i8
                } else {
                    Dice::method24(v2_1, 0_i8, 1_u64)
                }) - 1_i8,
                LrcPtr::new(Dice::UH1::UH1_0),
                0_i8,
            )
        }
        pub fn closure20(v0_1: Func0<u8>, v1_1: bool) -> Func1<u64, u64> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: u64| Dice::closure21(v0_1.clone(), v1_1, v)
            })
        }
        pub fn closure19(unitVar: (), v0_1: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice::closure20(v0_1.clone(), v)
            })
        }
        pub fn method34(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method34: loop {
                break '_method34 (match v0_1.get().clone().as_ref() {
                    Dice::UH1::UH1_0 => v1_1.get().clone(),
                    Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = match v0_1.get().clone().as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method34;
                    }
                });
            }
        }
        pub fn closure91(v0_1: u64, v1_1: LrcPtr<Dice::UH1>) -> Option<u64> {
            let v6: Dice::US6 =
                Dice::method27(Dice::method34(v1_1.clone(), 0_i8) - 1_i8, v1_1, 0_u64);
            let v16: Dice::US7 = if let Dice::US6::US6_0(v6_0_0, v6_0_1) = &v6 {
                let v7: u64 = match &v6 {
                    Dice::US6::US6_0(x, _) => x.clone(),
                    _ => unreachable!(),
                };
                if if v7 >= 1_u64 { v7 <= v0_1 } else { false } {
                    Dice::US7::US7_0(v7)
                } else {
                    Dice::US7::US7_1
                }
            } else {
                Dice::US7::US7_1
            };
            match &v16 {
                Dice::US7::US7_0(v16_0_0) => Some(match &v16 {
                    Dice::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<u64>,
            }
        }
        pub fn closure90(unitVar: (), v0_1: u64) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice::UH1>| Dice::closure91(v0_1, v)
            })
        }
        pub fn method35(v0_1: i64, v1_1: i8, v2_1: i64) -> string {
            let v4_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v11: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("max")), ());
                ()
            };
            let v29: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("n")), ());
                ()
            };
            let v63: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("p")), ());
                ()
            };
            let v96: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn closure93(unitVar: (), unitVar_1: ()) {
            fn v1_1() {
                Dice::closure5((), ());
            }
            let v2_1: () = {
                v1_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v34: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v34,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v41: () = {
                    v1_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v55: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v55.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.calculate_dice_count"),
                    v55.l0.get().clone(),
                    Dice::method35(i64::MAX, 24_i8, 4738381338321616896_i64),
                );
                let v86: () = {
                    v1_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method37() -> u8 {
            panic!("{}", string("common.random\' / target=Rust(Contract)"),)
        }
        pub fn method39(v0_1: i8, v1_1: i64, v2_1: u8, v3_1: i64) -> string {
            let v5: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v12: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v30: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v64: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v97: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string("value")), ());
                ()
            };
            let v130: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", v3_1), ());
                ()
            };
            let v147: () = {
                Dice::closure17(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn closure94(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(23_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure95(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(22_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure96(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(21_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure97(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(20_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure98(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(19_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure99(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(18_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure100(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(17_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure101(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(16_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure102(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(15_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure103(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(14_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure104(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(13_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure105(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(12_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure106(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(11_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure107(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(10_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure108(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(9_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure109(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(8_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure110(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(7_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure111(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(6_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure112(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(5_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure113(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(4_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure114(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(3_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure115(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(2_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure116(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(1_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure117(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v4_1() {
                Dice::closure5((), ());
            }
            let v5: () = {
                v4_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v37: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice::method15(
                    Dice::method7(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice::method39(0_i8, v0_1, v1_1, v2_1),
                );
                let v87: () = {
                    v4_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method64(v0_1: i8, v1_1: i64, v2_1: i64) -> string {
            let v4_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v11: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn closure118(v0_1: i64, v1_1: i64, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method64(-1_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method63(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            let v2_1: i64 = v1_1 + 1_i64;
            let v5: () = {
                Dice::closure118(v1_1, v2_1, ());
                ()
            };
            Dice::US8::US8_0(v2_1, v0_1)
        }
        pub fn method65(v0_1: i8, v1_1: i64, v2_1: u8) -> string {
            let v4_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v11: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v96: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure17(v4_1.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn closure119(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(0_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method62(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v7: i64 = (v3_1 - 1_u8) as i64;
                        let v10: () = {
                            Dice::closure117(v1_1, v3_1, v7, ());
                            ()
                        };
                        Dice::method63(v4_1.clone(), v1_1 + v7)
                    } else {
                        let v131: () = {
                            Dice::closure119(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method63(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure120(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(1_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method61(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 6_i64;
                        let v11: () = {
                            Dice::closure116(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method62(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure120(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method62(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure121(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(2_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method60(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 36_i64;
                        let v11: () = {
                            Dice::closure115(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method61(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure121(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method61(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure122(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(3_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method59(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 216_i64;
                        let v11: () = {
                            Dice::closure114(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method60(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure122(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method60(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure123(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(4_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method58(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 1296_i64;
                        let v11: () = {
                            Dice::closure113(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method59(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure123(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method59(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure124(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(5_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method57(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 7776_i64;
                        let v11: () = {
                            Dice::closure112(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method58(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure124(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method58(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure125(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(6_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method56(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 46656_i64;
                        let v11: () = {
                            Dice::closure111(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method57(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure125(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method57(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure126(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(7_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method55(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 279936_i64;
                        let v11: () = {
                            Dice::closure110(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method56(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure126(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method56(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure127(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(8_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method54(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 1679616_i64;
                        let v11: () = {
                            Dice::closure109(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method55(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure127(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method55(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure128(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(9_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method53(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 10077696_i64;
                        let v11: () = {
                            Dice::closure108(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method54(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure128(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method54(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure129(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(10_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method52(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 60466176_i64;
                        let v11: () = {
                            Dice::closure107(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method53(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure129(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method53(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure130(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(11_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method51(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 362797056_i64;
                        let v11: () = {
                            Dice::closure106(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method52(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure130(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method52(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure131(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(12_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method50(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 2176782336_i64;
                        let v11: () = {
                            Dice::closure105(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method51(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure131(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method51(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure132(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(13_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method49(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 13060694016_i64;
                        let v11: () = {
                            Dice::closure104(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method50(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure132(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method50(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure133(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(14_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method48(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 78364164096_i64;
                        let v11: () = {
                            Dice::closure103(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method49(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure133(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method49(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure134(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(15_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method47(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 470184984576_i64;
                        let v11: () = {
                            Dice::closure102(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method48(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure134(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method48(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure135(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(16_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method46(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 2821109907456_i64;
                        let v11: () = {
                            Dice::closure101(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method47(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure135(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method47(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure136(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(17_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method45(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 16926659444736_i64;
                        let v11: () = {
                            Dice::closure100(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method46(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure136(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method46(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure137(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(18_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method44(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 101559956668416_i64;
                        let v11: () = {
                            Dice::closure99(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method45(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure137(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method45(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure138(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(19_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method43(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 609359740010496_i64;
                        let v11: () = {
                            Dice::closure98(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method44(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure138(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method44(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure139(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(20_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method42(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 3656158440062976_i64;
                        let v11: () = {
                            Dice::closure97(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method43(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure139(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method43(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure140(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(21_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method41(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 21936950640377856_i64;
                        let v11: () = {
                            Dice::closure96(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method42(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure140(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method42(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure141(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(22_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method40(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 131621703842267136_i64;
                        let v11: () = {
                            Dice::closure95(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method41(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure141(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method41(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure142(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v3_1() {
                Dice::closure5((), ());
            }
            let v4_1: () = {
                v3_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v36: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice::method15(
                    Dice::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.accumulate_dice_rolls"),
                    v57.l0.get().clone(),
                    Dice::method65(23_i8, v0_1, v1_1),
                );
                let v86: () = {
                    v3_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method38(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US8::US8_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 789730223053602816_i64;
                        let v11: () = {
                            Dice::closure94(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method40(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v132: () = {
                            Dice::closure142(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method40(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method36(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i64 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method36: loop {
                break '_method36 (if v1_1.get().clone() < 24_i8 {
                    let v0_1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(), v0_1.get().clone()));
                    let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method36;
                } else {
                    let v8: Dice::US8 = Dice::method38(v0_1.get().clone(), 0_i64);
                    if let Dice::US8::US8_0(v8_0_0, v8_0_1) = &v8 {
                        let v9: i64 = match &v8 {
                            Dice::US8::US8_0(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v9 <= i64::MAX {
                            v9
                        } else {
                            let v0_1_temp: LrcPtr<Dice::UH1> =
                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                            let v1_1_temp: i8 = 23_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method36;
                        }
                    } else {
                        let v0_1_temp: LrcPtr<Dice::UH1> =
                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method37(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                        let v1_1_temp: i8 = 23_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method36;
                    }
                });
            }
        }
        pub fn method66(v0_1: i64) -> string {
            let v2_1: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                l0: MutCell::new(Dice::method14()),
            });
            let v9: () = {
                Dice::closure17(v2_1.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Dice::closure17(v2_1.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v27: () = {
                Dice::closure17(v2_1.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Dice::closure17(v2_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Dice::closure17(v2_1.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2_1.l0.get().clone()
        }
        pub fn closure143(v0_1: i64, unitVar: ()) {
            fn v2_1() {
                Dice::closure5((), ());
            }
            let v3_1: () = {
                v2_1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut0>,
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut2>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                Option<i64>,
            ) = getValue(Dice::TraceState::trace_state().get().clone());
            let v35: Dice::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2_1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Dice::Mut0> = patternInput_1.0.clone();
                let v82: string = Dice::method15(
                    Dice::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice::method11(),
                    string("dice.main"),
                    v56.l0.get().clone(),
                    Dice::method66(v0_1),
                );
                let v84: () = {
                    v2_1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut0>,
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut2>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    Option<i64>,
                ) = getValue(Dice::TraceState::trace_state().get().clone());
                Dice::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure92(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3_1: () = {
                Dice::closure93((), ());
                ()
            };
            let v127: () = {
                Dice::closure143(Dice::method36(LrcPtr::new(Dice::UH1::UH1_0), 0_i8), ());
                ()
            };
            0_i32
        }
        pub fn v0() -> Func1<i64, Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>>> {
            static v0: OnceInit<Func1<i64, Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>>>> =
                OnceInit::new();
            v0.get_or_init(|| Func1::new(move |v: i64| Dice::closure0((), v)))
                .clone()
        }
        pub fn rotate_numbers(x: i64) -> Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>> {
            (Dice::v0())(x)
        }
        pub fn v1() -> Func1<LrcPtr<Dice::UH1>, Func0<u8>> {
            static v1: OnceInit<Func1<LrcPtr<Dice::UH1>, Func0<u8>>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: LrcPtr<Dice::UH1>| Dice::closure3((), v)))
                .clone()
        }
        pub fn create_sequential_roller(x: LrcPtr<Dice::UH1>) -> Func0<u8> {
            (Dice::v1())(x)
        }
        pub fn v2() -> Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>> {
            static v2: OnceInit<Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>>> = OnceInit::new();
            v2.get_or_init(|| Func1::new(move |v: Func0<u8>| Dice::closure19((), v)))
                .clone()
        }
        pub fn roll_progressively(x: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            (Dice::v2())(x)
        }
        pub fn v3() -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>> {
            static v3: OnceInit<Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>>> =
                OnceInit::new();
            v3.get_or_init(|| Func1::new(move |v: u64| Dice::closure90((), v)))
                .clone()
        }
        pub fn roll_within_bounds(x: u64) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            (Dice::v3())(x)
        }
        pub fn v4() -> Func1<Array<string>, i32> {
            static v4: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v4.get_or_init(|| Func1::new(move |v: Array<string>| Dice::closure92((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Dice::v4())(args)
        }
    }
}
pub use module_1d76f080::*;
#[path = "../deps/polyglot/lib/fsharp/Common_contract.rs"]
mod module_6140596b;
pub use module_6140596b::*;
#[path = "../deps/polyglot/lib/spiral/async__contract.rs"]
mod module_daedefb8;
pub use module_daedefb8::*;
#[path = "../deps/polyglot/lib/spiral/common_contract.rs"]
mod module_70286a4c;
pub use module_70286a4c::*;
#[path = "../deps/polyglot/lib/spiral/crypto_contract.rs"]
mod module_4a98a962;
pub use module_4a98a962::*;
#[path = "../deps/polyglot/lib/spiral/date_time_contract.rs"]
mod module_94ca555f;
pub use module_94ca555f::*;
#[path = "../deps/polyglot/lib/spiral/file_system_contract.rs"]
mod module_b697ea1d;
pub use module_b697ea1d::*;
#[path = "../deps/polyglot/lib/spiral/lib_contract.rs"]
mod module_ed8da8a6;
pub use module_ed8da8a6::*;
#[path = "../deps/polyglot/lib/spiral/networking_contract.rs"]
mod module_9dd8007f;
pub use module_9dd8007f::*;
#[path = "../deps/polyglot/lib/spiral/platform_contract.rs"]
mod module_4c4781e;
pub use module_4c4781e::*;
#[path = "../deps/polyglot/lib/spiral/runtime_contract.rs"]
mod module_c40559dd;
pub use module_c40559dd::*;
#[path = "../deps/polyglot/lib/spiral/sm_contract.rs"]
mod module_fc92da1f;
pub use module_fc92da1f::*;
#[path = "../deps/polyglot/lib/spiral/threading_contract.rs"]
mod module_af40e92f;
pub use module_af40e92f::*;
#[path = "../deps/polyglot/lib/spiral/trace_contract.rs"]
mod module_981750e0;
pub use module_981750e0::*;
pub mod Polyglot {
    pub use crate::module_6140596b::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::main(array_from(args));
}
