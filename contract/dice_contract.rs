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
mod module_faa356c0 {
    pub mod Dice_contract {
        use super::*;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
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
                        LrcPtr<Dice_contract::Mut0>,
                        LrcPtr<Dice_contract::Mut1>,
                        LrcPtr<Dice_contract::Mut2>,
                        LrcPtr<Dice_contract::Mut3>,
                        LrcPtr<Dice_contract::Mut4>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Dice_contract::Mut0>,
                                LrcPtr<Dice_contract::Mut1>,
                                LrcPtr<Dice_contract::Mut2>,
                                LrcPtr<Dice_contract::Mut3>,
                                LrcPtr<Dice_contract::Mut4>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Dice_contract::Mut0>,
                                LrcPtr<Dice_contract::Mut1>,
                                LrcPtr<Dice_contract::Mut2>,
                                LrcPtr<Dice_contract::Mut3>,
                                LrcPtr<Dice_contract::Mut4>,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for Dice_contract::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Dice_contract::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Dice_contract::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Dice_contract::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Dice_contract::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<Dice_contract::US0>,
        }
        impl core::fmt::Display for Dice_contract::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(string),
            US1_1,
        }
        impl core::fmt::Display for Dice_contract::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Dice_contract::US0),
            US2_1,
        }
        impl core::fmt::Display for Dice_contract::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
        }
        impl core::fmt::Display for Dice_contract::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH0 {
            UH0_0,
            UH0_1(u8, LrcPtr<Dice_contract::UH0>),
        }
        impl core::fmt::Display for Dice_contract::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0(u8, Func0<LrcPtr<Dice_contract::UH1>>),
            UH1_1,
        }
        impl core::fmt::Display for Dice_contract::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0(Func0<LrcPtr<Dice_contract::UH1>>),
            US4_1(LrcPtr<Dice_contract::UH1>),
        }
        impl core::fmt::Display for Dice_contract::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut5 {
            pub l0: MutCell<Dice_contract::US4>,
        }
        impl core::fmt::Display for Dice_contract::Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(u8),
            US5_1,
        }
        impl core::fmt::Display for Dice_contract::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut6 {
            pub l0: MutCell<Dice_contract::US5>,
        }
        impl core::fmt::Display for Dice_contract::Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(u64, LrcPtr<Dice_contract::UH0>),
            US6_1,
        }
        impl core::fmt::Display for Dice_contract::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH2 {
            UH2_0(u64, Func0<LrcPtr<Dice_contract::UH2>>),
            UH2_1,
        }
        impl core::fmt::Display for Dice_contract::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(u64),
            US7_1,
        }
        impl core::fmt::Display for Dice_contract::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method1() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method3() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Dice_contract::US1 {
            Dice_contract::US1::US1_0(v0_1)
        }
        pub fn method4() -> Func1<string, Dice_contract::US1> {
            Func1::new(move |v: string| Dice_contract::closure3((), v))
        }
        pub fn method2(v0_1: string) -> string {
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
            let v44: string = Dice_contract::method3();
            v43.unwrap_or(v44)
        }
        pub fn method5() -> string {
            string("AUTOMATION")
        }
        pub fn closure4(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method0(
            v0_1: Dice_contract::US0,
        ) -> (
            LrcPtr<Dice_contract::Mut0>,
            LrcPtr<Dice_contract::Mut1>,
            LrcPtr<Dice_contract::Mut2>,
            LrcPtr<Dice_contract::Mut3>,
            LrcPtr<Dice_contract::Mut4>,
            Option<i64>,
        ) {
            let v117: string = string("env!(\"AUTOMATION\")");
            let v118: &str = env!("AUTOMATION");
            let v125: std::string::String = String::from(v118);
            let _v1: (Dice_contract::US2, Dice_contract::US3) = (
                Dice_contract::US2::US2_1,
                if fable_library_rust::String_::fromString(v125) != string("True") {
                    Dice_contract::US3::US3_1
                } else {
                    Dice_contract::US3::US3_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v352: Dice_contract::US3 = _v1.1.clone();
            let v351: Dice_contract::US2 = _v1.0.clone();
            (
                LrcPtr::new(Dice_contract::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Dice_contract::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Dice_contract::closure4((), v))),
                }),
                LrcPtr::new(Dice_contract::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Dice_contract::Mut4 {
                    l0: MutCell::new(match &v351 {
                        Dice_contract::US2::US2_0(v351_0_0) => match &v351 {
                            Dice_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v352 {
                    Dice_contract::US3::US3_0(v352_0_0) => Some(match &v352 {
                        Dice_contract::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) {
            if Dice_contract::TraceState::trace_state()
                .get()
                .clone()
                .is_none()
            {
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::method0(Dice_contract::US0::US0_0);
                Dice_contract::TraceState::trace_state().set(Some((
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
        pub fn closure5(unitVar: (), v0_1: i64) -> Dice_contract::US3 {
            Dice_contract::US3::US3_0(v0_1)
        }
        pub fn method7() -> Func1<i64, Dice_contract::US3> {
            Func1::new(move |v: i64| Dice_contract::closure5((), v))
        }
        pub fn method8() -> string {
            string("hh:mm:ss")
        }
        pub fn method9() -> string {
            string("HH:mm:ss")
        }
        pub fn method6(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v130: u64 = near_sdk::env::block_timestamp();
            let v144: Dice_contract::US3 =
                defaultValue(Dice_contract::US3::US3_1, map(Dice_contract::method7(), v5));
            let v154: u64 = match &v144 {
                Dice_contract::US3::US3_0(v144_0_0) => {
                    v130 - match &v144 {
                        Dice_contract::US3::US3_0(x) => x.clone(),
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
        pub fn method11() -> string {
            string("\u{001b}[0m")
        }
        pub fn method10() -> string {
            let v5: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v79: &str = inline_colorization::color_bright_blue;
            let v86: &str = &*v5;
            let v102: &str = inline_colorization::color_reset;
            let v104: std::string::String = format!("{}{}{}", v79, v86, v102);
            fable_library_rust::String_::fromString(v104)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure6(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method12(v0_1: string) -> string {
            let v2: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v9: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string("seed_excess")), ());
                ()
            };
            let v27: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice_contract.contribute_seed"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure7(v0_1: LrcPtr<Dice_contract::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure9(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure8(unitVar: (), v0_1: string) {
            let v3: () = {
                Dice_contract::closure9(v0_1, ());
                ()
            };
            ()
        }
        pub fn method15(
            v0_1: string,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut1>,
            v3: LrcPtr<Dice_contract::Mut2>,
            v4: LrcPtr<Dice_contract::Mut3>,
            v5: LrcPtr<Dice_contract::Mut4>,
            v6: Option<i64>,
        ) {
            let v9: () = {
                Dice_contract::closure7(v1, ());
                ()
            };
            let v25: string = if v4.l0.get().clone() == string("") {
                v0_1.clone()
            } else {
                if v0_1.clone() == string("") {
                    v4.l0.get().clone()
                } else {
                    append(append(v4.l0.get().clone(), string("\n")), v0_1.clone())
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
                v4.l0.set(v25);
                ()
            } else {
                v4.l0.set(string(""));
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
            (v2.l0.get().clone())(v0_1)
        }
        pub fn closure1(v0_1: Vec<u8>, unitVar: ()) {
            fn v2() {
                Dice_contract::closure2((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v35: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v81: string = Dice_contract::method14(
                    Dice_contract::method6(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v56.l0.get().clone(),
                    Dice_contract::method12(sprintf!("{:?}", v0_1)),
                );
                let v83: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
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
        pub fn closure11(v0_1: u8, v1: LrcPtr<Dice_contract::UH0>) -> LrcPtr<Dice_contract::UH0> {
            LrcPtr::new(Dice_contract::UH0::UH0_1(v0_1, v1))
        }
        pub fn closure10(
            unitVar: (),
            v0_1: u8,
        ) -> Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_contract::UH0>| Dice_contract::closure11(v0_1, v)
            })
        }
        pub fn method16() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure10((), v))
        }
        pub fn closure12(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method17(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: LrcPtr<Dice_contract::UH1> = Dice_contract::method17(
                        match v0_1.as_ref() {
                            Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1.clone(),
                    );
                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                        match v0_1.as_ref() {
                            Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Func0::new({
                            let v4 = v4.clone();
                            move || Dice_contract::closure12(v4.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure13(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method18(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v5: LrcPtr<Dice_contract::UH1> =
                        Dice_contract::method18((v0_1_0_1)(), v1.clone());
                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                        ((v0_1_0_0.clone() as i64 - 1_i64 + 6_i64) % 6_i64 + 1_i64) as u8,
                        Func0::new({
                            let v5 = v5.clone();
                            move || Dice_contract::closure13(v5.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn method19(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    LrcPtr::new(Dice_contract::UH0::UH0_1(
                        v0_1_0_0.clone(),
                        Dice_contract::method19((v0_1_0_1)(), v1.clone()),
                    ))
                }
            }
        }
        pub fn method20(v0_1: LrcPtr<Dice_contract::UH0>, v1: List<u8>) -> List<u8> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice_contract::method20(
                        match v0_1.as_ref() {
                            Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1.clone(),
                    ),
                ),
            }
        }
        pub fn method21(
            v0_1: u64,
            v1: std::string::String,
            v2: std::string::String,
            v3: u64,
            v4: u64,
            v5: u64,
            v6: string,
            v7: std::string::String,
            v8: string,
            v9: string,
            v10: usize,
            v11: string,
            v12: string,
            v13: string,
        ) -> string {
            let v15: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v22: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v31: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("max")), ());
                ()
            };
            let v40: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v48: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v57: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v66: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("key")), ());
                ()
            };
            let v74: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v87: std::string::String = format!("{:#?}", v1);
            let v109: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v87)),
                    (),
                );
                ()
            };
            let v117: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v126: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("proof")), ());
                ()
            };
            let v134: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v147: std::string::String = format!("{:#?}", v2);
            let v169: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v147)),
                    (),
                );
                ()
            };
            let v177: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v186: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("block_timestamp")), ());
                ()
            };
            let v194: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v202: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v210: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v219: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("block_height")), ());
                ()
            };
            let v227: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v235: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v4), ());
                ()
            };
            let v243: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v252: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("epoch_height")), ());
                ()
            };
            let v260: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v268: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v276: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v285: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("account_balance")), ());
                ()
            };
            let v293: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v301: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v6), ());
                ()
            };
            let v309: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v318: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", string("signer_account_id")),
                    (),
                );
                ()
            };
            let v326: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v339: std::string::String = format!("{:#?}", v7);
            let v361: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v339)),
                    (),
                );
                ()
            };
            let v369: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v378: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("seed")), ());
                ()
            };
            let v386: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v394: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v402: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v411: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("seeds")), ());
                ()
            };
            let v419: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v427: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v435: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v444: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("entropy_len")), ());
                ()
            };
            let v452: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v465: std::string::String = format!("{:#?}", v10);
            let v487: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v465)),
                    (),
                );
                ()
            };
            let v495: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v504: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("entropy")), ());
                ()
            };
            let v512: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v520: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v11), ());
                ()
            };
            let v528: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v537: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("hash_u8")), ());
                ()
            };
            let v545: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v553: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v12), ());
                ()
            };
            let v561: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v570: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("rolls")), ());
                ()
            };
            let v578: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v586: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v13), ());
                ()
            };
            let v595: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v15.l0.get().clone()
        }
        pub fn method22(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice_contract.generate_random_number"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure14(
            v0_1: &mut near_sdk::store::vec::Vector<u8>,
            v1: std::string::String,
            v2: std::string::String,
            v3: u64,
            v4: Vec<u8>,
            v5: u64,
            v6: u64,
            v7: u64,
            v8: near_token::NearToken,
            v9: near_sdk::AccountId,
            v10: Vec<u8>,
            v11: Vec<u8>,
            v12: LrcPtr<Dice_contract::UH0>,
            unitVar: (),
        ) {
            fn v14() {
                Dice_contract::closure2((), ());
            }
            let v15: () = {
                v14();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v47: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v47,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v54: () = {
                    v14();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v68: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v86: string = Dice_contract::method6(
                    v68.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v87: string = Dice_contract::method10();
                let v88: i64 = v68.l0.get().clone();
                let v89: string = sprintf!("{:?}", v8);
                let v93: std::string::String = v9.to_string();
                let v94: string = sprintf!("{:?}", v4);
                let v97: string = sprintf!("{:?}", v0_1);
                let v101: usize = v10.clone().len();
                let v102: string = sprintf!("{:?}", v10);
                let v105: string = sprintf!("{:?}", v11);
                let v111: Array<u8> = toArray(Dice_contract::method20(v12, empty::<u8>()));
                let v120: string = Dice_contract::method22(
                    v86,
                    v87,
                    v88,
                    Dice_contract::method21(
                        v3,
                        v1,
                        v2,
                        v7,
                        v6,
                        v5,
                        v89,
                        v93,
                        v94,
                        v97,
                        v101,
                        v102,
                        v105,
                        sprintf!("{:?}", v111.to_vec()),
                    ),
                );
                let v122: () = {
                    v14();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
                    v120,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method23(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            '_method23: loop {
                break '_method23 (match v0_1.get().clone().as_ref() {
                    Dice_contract::UH0::UH0_0 => v1.get().clone(),
                    Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice_contract::UH0> =
                            match v0_1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                        let v1_temp: LrcPtr<Dice_contract::UH0> =
                            LrcPtr::new(Dice_contract::UH0::UH0_1(
                                match v0_1.get().clone().as_ref() {
                                    Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                },
                                v1.get().clone(),
                            ));
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method23;
                    }
                });
            }
        }
        pub fn method24(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    LrcPtr::new(Dice_contract::UH0::UH0_1(
                        match v0_1.as_ref() {
                            Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Dice_contract::method24(
                            match v0_1.as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1.clone(),
                        ),
                    ))
                }
            }
        }
        pub fn closure15(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn closure16(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::Mut5>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            let v2: Dice_contract::US4 = v1.l0.get().clone();
            match &v2 {
                Dice_contract::US4::US4_0(v2_0_0) => {
                    let v5: LrcPtr<Dice_contract::UH1> = (v2_0_0)();
                    let v12: LrcPtr<Dice_contract::UH1> = match v5.as_ref() {
                        Dice_contract::UH1::UH1_1 => LrcPtr::new(Dice_contract::UH1::UH1_1),
                        Dice_contract::UH1::UH1_0(v5_0_0, v5_0_1) => {
                            LrcPtr::new(Dice_contract::UH1::UH1_0(
                                v5_0_0.clone(),
                                Dice_contract::method25(v0_1, v5_0_1.clone()),
                            ))
                        }
                    };
                    v1.l0.set(Dice_contract::US4::US4_1(v12.clone()));
                    v12
                }
                Dice_contract::US4::US4_1(v2_1_0) => v2_1_0.clone(),
            }
        }
        pub fn method25(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
        ) -> Func0<LrcPtr<Dice_contract::UH1>> {
            let v3: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                l0: MutCell::new(Dice_contract::US4::US4_0(v1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3 = v3.clone();
                move || Dice_contract::closure16(v0_1.clone(), v3.clone(), ())
            })
        }
        pub fn method27(v0_1: u64, v1: u64, v2: i8) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("max")), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("p")), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("n")), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method28(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice.calculate_dice_count"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure17(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v4() {
                Dice_contract::closure2((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v37: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v80: string = Dice_contract::method28(
                    Dice_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v58.l0.get().clone(),
                    Dice_contract::method27(v0_1, v2, v1),
                );
                let v82: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
                    v80,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method26(v0_1: u64, v1: i8, v2: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1: MutCell<i8> = MutCell::new(v1);
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method26: loop {
                break '_method26 (if v2.get().clone() < v0_1.get().clone() {
                    let v4: u64 = v2.get().clone() * 6_u64;
                    if v4 > v2.get().clone() {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_temp: i8 = v1.get().clone() + 1_i8;
                        let v2_temp: u64 = v4;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        continue '_method26;
                    } else {
                        let v10: () = {
                            Dice_contract::closure17(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                (),
                            );
                            ()
                        };
                        v1.get().clone()
                    }
                } else {
                    let v125: () = {
                        Dice_contract::closure17(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            (),
                        );
                        ()
                    };
                    v1.get().clone()
                });
            }
        }
        pub fn method31(v0_1: i64, v1: i64, v2: i64, v3: string) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v12: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("current_index")), ());
                ()
            };
            let v30: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v80: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("len")), ());
                ()
            };
            let v97: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("last_item")), ());
                ()
            };
            let v130: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v147: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method32(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice.create_sequential_roller / roll"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure18(v0_1: i64, v1: i64, v2: i64, v3: Option<u8>, unitVar: ()) {
            fn v5() {
                Dice_contract::closure2((), ());
            }
            let v6: () = {
                v5();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v38: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice_contract::method32(
                    Dice_contract::method6(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v59.l0.get().clone(),
                    Dice_contract::method31(v0_1, v1, v2, sprintf!("{:?}", v3)),
                );
                let v86: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
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
        pub fn method33(v0_1: i64, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US5 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method33: loop {
                break '_method33 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US5::US5_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if v0_1.get().clone() <= 0_i64 {
                            Dice_contract::US5::US5_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = v0_1.get().clone() - 1_i64;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method33;
                        }
                    }
                });
            }
        }
        pub fn method34() -> string {
            let v1: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            v1.l0.get().clone()
        }
        pub fn method35(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice.create_sequential_roller / roll / None"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) {
            fn v1() {
                Dice_contract::closure2((), ());
            }
            let v2: () = {
                v1();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v34: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v34,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v41: () = {
                    v1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v55: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v77: string = Dice_contract::method35(
                    Dice_contract::method6(
                        v55.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v55.l0.get().clone(),
                    Dice_contract::method34(),
                );
                let v79: () = {
                    v1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
                    v77,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method30(
            v0_1: Func0<LrcPtr<Dice_contract::UH1>>,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut6>,
        ) -> u8 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v1.clone());
            let v2: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v2.clone());
            let v3: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v3.clone());
            let v4: MutCell<LrcPtr<Dice_contract::Mut6>> = MutCell::new(v4.clone());
            '_method30: loop {
                break '_method30 ({
                    let v5: i64 = v1.l0.get().clone();
                    let v6: i64 = v2.l0.get().clone();
                    let v7: i64 = v3.l0.get().clone();
                    let v8: Dice_contract::US5 = v4.l0.get().clone();
                    let v18: () = {
                        Dice_contract::closure18(
                            v5,
                            v6,
                            v7,
                            match &v8 {
                                Dice_contract::US5::US5_0(v8_0_0) => Some(match &v8 {
                                    Dice_contract::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => None::<u8>,
                            },
                            (),
                        );
                        ()
                    };
                    let v133: LrcPtr<Dice_contract::UH1> = v0_1();
                    let v135: Dice_contract::US5 =
                        Dice_contract::method33(v1.l0.get().clone(), v133);
                    match &v135 {
                        Dice_contract::US5::US5_0(v135_0_0) => {
                            let v136: u8 = match &v135 {
                                Dice_contract::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v138: i64 = v1.l0.get().clone() + 1_i64;
                            v1.l0.set(v138);
                            v4.l0.set(Dice_contract::US5::US5_0(v136));
                            v136
                        }
                        _ => {
                            let v142: () = {
                                Dice_contract::closure19((), ());
                                ()
                            };
                            if v3.l0.get().clone() == -1_i64 {
                                let v256: i64 = v1.l0.get().clone();
                                v3.l0.set(v256);
                                ()
                            }
                            {
                                let v262: i64 = if v2.l0.get().clone() >= v3.l0.get().clone() {
                                    1_i64
                                } else {
                                    v2.l0.get().clone() + 1_i64
                                };
                                v2.l0.set(v262);
                                {
                                    let v264: i64 = v2.l0.get().clone() - 1_i64;
                                    v1.l0.set(v264);
                                    v4.l0.set(Dice_contract::US5::US5_1);
                                    {
                                        let v0_1_temp = v0_1.get().clone();
                                        let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                                        let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                                        let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                                        let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1.set(v1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method30;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method37(v0_1: i8, v1: u64, v2: u64) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method38(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice.accumulate_dice_rolls"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure20(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v4() {
                Dice_contract::closure2((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v37: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v80: string = Dice_contract::method38(
                    Dice_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v58.l0.get().clone(),
                    Dice_contract::method37(v1, v0_1, v2),
                );
                let v82: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
                    v80,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_1)
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice_contract::closure84((), ())),
            ))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice_contract::closure83((), ())),
            ))
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice_contract::closure82((), ())),
            ))
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice_contract::closure81((), ())),
            ))
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice_contract::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice_contract::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice_contract::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice_contract::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice_contract::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice_contract::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice_contract::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice_contract::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice_contract::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice_contract::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice_contract::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice_contract::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice_contract::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice_contract::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice_contract::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice_contract::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice_contract::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice_contract::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice_contract::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice_contract::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice_contract::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice_contract::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice_contract::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice_contract::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice_contract::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice_contract::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice_contract::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice_contract::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice_contract::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice_contract::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice_contract::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice_contract::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice_contract::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice_contract::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice_contract::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice_contract::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice_contract::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice_contract::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice_contract::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice_contract::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice_contract::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice_contract::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice_contract::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice_contract::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice_contract::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice_contract::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice_contract::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice_contract::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice_contract::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice_contract::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice_contract::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice_contract::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice_contract::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice_contract::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice_contract::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice_contract::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice_contract::closure24((), ())),
            ))
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice_contract::closure23((), ())),
            ))
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice_contract::closure22((), ())),
            ))
        }
        pub fn method39(v0_1: i8, v1: LrcPtr<Dice_contract::UH2>) -> Dice_contract::US7 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH2>> = MutCell::new(v1.clone());
            '_method39: loop {
                break '_method39 (match v1.get().clone().as_ref() {
                    Dice_contract::UH2::UH2_1 => Dice_contract::US7::US7_1,
                    Dice_contract::UH2::UH2_0(v1_0_0, v1_0_1) => {
                        if v0_1.get().clone() <= 0_i8 {
                            Dice_contract::US7::US7_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH2> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method39;
                        }
                    }
                });
            }
        }
        pub fn method40(v0_1: i8, v1: u64, v2: u8, v3: u64) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v12: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v30: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v80: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v97: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("value")), ());
                ()
            };
            let v130: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v147: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn closure85(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
            fn v5() {
                Dice_contract::closure2((), ());
            }
            let v6: () = {
                v5();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v38: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v81: string = Dice_contract::method38(
                    Dice_contract::method6(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v59.l0.get().clone(),
                    Dice_contract::method40(v1, v0_1, v2, v3),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
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
        pub fn method41(v0_1: i8, v1: u64, v2: u8) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn closure86(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
            fn v4() {
                Dice_contract::closure2((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v37: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v80: string = Dice_contract::method38(
                    Dice_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v58.l0.get().clone(),
                    Dice_contract::method41(v1, v0_1, v2),
                );
                let v82: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
                    v80,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method36(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US6 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method36: loop {
                break '_method36 (if v0_1.get().clone() < 0_i8 {
                    let v4: u64 = v2.get().clone() + 1_u64;
                    let v7: () = {
                        Dice_contract::closure20(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US6::US6_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US6::US6_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v122: LrcPtr<Dice_contract::UH0> = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v121: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v121 > 1_u8 {
                                let v127: Dice_contract::US7 = Dice_contract::method39(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure21((), ())),
                                    )),
                                );
                                let v134: u64 = (v121 - 1_u8) as u64
                                    * match &v127 {
                                        Dice_contract::US7::US7_0(v127_0_0) => match &v127 {
                                            Dice_contract::US7::US7_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                let v137: () = {
                                    Dice_contract::closure85(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v121,
                                        v134,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v122;
                                    let v2_temp: u64 = v2.get().clone() + v134;
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method36;
                                }
                            } else {
                                let v254: () = {
                                    Dice_contract::closure86(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v121,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v122.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method36;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method42(
            v0_1: i8,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut0>,
            v5: LrcPtr<Dice_contract::Mut6>,
            v6: i8,
        ) -> LrcPtr<Dice_contract::UH0> {
            if v6 < v0_1 {
                LrcPtr::new(Dice_contract::UH0::UH0_1(
                    Dice_contract::method30(
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                    ),
                    Dice_contract::method42(v0_1, v1, v2, v3, v4, v5, v6 + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice_contract::UH0::UH0_0)
            }
        }
        pub fn method43(
            v0_1: Func0<LrcPtr<Dice_contract::UH1>>,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut6>,
            v5: u64,
            v6: i8,
            v7: LrcPtr<Dice_contract::UH0>,
        ) -> u64 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v1.clone());
            let v2: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v2.clone());
            let v3: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v3.clone());
            let v4: MutCell<LrcPtr<Dice_contract::Mut6>> = MutCell::new(v4.clone());
            let v5: MutCell<u64> = MutCell::new(v5);
            let v6: MutCell<i8> = MutCell::new(v6);
            let v7: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v7.clone());
            '_method43: loop {
                break '_method43 ({
                    let v8: i8 = v6.get().clone() + 1_i8;
                    if v6.get().clone() < v8 {
                        Dice_contract::method29(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            LrcPtr::new(Dice_contract::UH0::UH0_1(
                                Dice_contract::method30(
                                    v0_1.get().clone(),
                                    v1.get().clone(),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                ),
                                v7.get().clone(),
                            )),
                            v8,
                        )
                    } else {
                        let v14: Dice_contract::US6 =
                            Dice_contract::method36(v6.get().clone(), v7.get().clone(), 0_u64);
                        if let Dice_contract::US6::US6_0(v14_0_0, v14_0_1) = &v14 {
                            let v15: u64 = match &v14 {
                                Dice_contract::US6::US6_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v15 <= v5.get().clone() {
                                v15
                            } else {
                                let v0_1_temp = v0_1.get().clone();
                                let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                                let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                                let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                                let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                                let v5_temp: u64 = v5.get().clone();
                                let v6_temp: i8 = v6.get().clone();
                                let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method42(
                                    v6.get().clone(),
                                    v0_1.get().clone(),
                                    v1.get().clone(),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    0_i8,
                                );
                                v0_1.set(v0_1_temp);
                                v1.set(v1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                v7.set(v7_temp);
                                continue '_method43;
                            }
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                            let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                            let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                            let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                            let v5_temp: u64 = v5.get().clone();
                            let v6_temp: i8 = v6.get().clone();
                            let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method42(
                                v6.get().clone(),
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                0_i8,
                            );
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            v5.set(v5_temp);
                            v6.set(v6_temp);
                            v7.set(v7_temp);
                            continue '_method43;
                        }
                    }
                });
            }
        }
        pub fn method29(
            v0_1: Func0<LrcPtr<Dice_contract::UH1>>,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut6>,
            v5: u64,
            v6: i8,
            v7: LrcPtr<Dice_contract::UH0>,
            v8: i8,
        ) -> u64 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v1.clone());
            let v2: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v2.clone());
            let v3: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v3.clone());
            let v4: MutCell<LrcPtr<Dice_contract::Mut6>> = MutCell::new(v4.clone());
            let v5: MutCell<u64> = MutCell::new(v5);
            let v6: MutCell<i8> = MutCell::new(v6);
            let v7: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v7.clone());
            let v8: MutCell<i8> = MutCell::new(v8);
            '_method29: loop {
                break '_method29 (if v8.get().clone() < v6.get().clone() + 1_i8 {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                    let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                    let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                    let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                    let v5_temp: u64 = v5.get().clone();
                    let v6_temp: i8 = v6.get().clone();
                    let v7_temp: LrcPtr<Dice_contract::UH0> =
                        LrcPtr::new(Dice_contract::UH0::UH0_1(
                            Dice_contract::method30(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            ),
                            v7.get().clone(),
                        ));
                    let v8_temp: i8 = v8.get().clone() + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1.set(v1_temp);
                    v2.set(v2_temp);
                    v3.set(v3_temp);
                    v4.set(v4_temp);
                    v5.set(v5_temp);
                    v6.set(v6_temp);
                    v7.set(v7_temp);
                    v8.set(v8_temp);
                    continue '_method29;
                } else {
                    let v16: Dice_contract::US6 =
                        Dice_contract::method36(v6.get().clone(), v7.get().clone(), 0_u64);
                    if let Dice_contract::US6::US6_0(v16_0_0, v16_0_1) = &v16 {
                        let v17: u64 = match &v16 {
                            Dice_contract::US6::US6_0(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v17 <= v5.get().clone() {
                            v17
                        } else {
                            Dice_contract::method43(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                                Dice_contract::method42(
                                    v6.get().clone(),
                                    v0_1.get().clone(),
                                    v1.get().clone(),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    0_i8,
                                ),
                            )
                        }
                    } else {
                        Dice_contract::method43(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            Dice_contract::method42(
                                v6.get().clone(),
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                0_i8,
                            ),
                        )
                    }
                });
            }
        }
        pub fn closure87(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method44() -> Func0<()> {
            Func0::new(move || Dice_contract::closure87((), ()))
        }
        pub fn method45(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
        ) {
            let v8: () = {
                Dice_contract::closure7(v0_1, ());
                ()
            };
            let v25: string = if v3.l0.get().clone() == string("") {
                string("")
            } else {
                v3.l0.get().clone()
            };
            let v32: &str = &*v25;
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
            v3.l0.set(string(""));
            {
                let v75: bool = true;
                v64.into_iter().for_each(|x| {
                    //;
                    let v77: std::string::String = x;
                    let v79: bool = true;
                    near_sdk::log!("{}", v77);
                    let v81: bool = true;
                    let v83: bool = true;
                }); //;
                ()
            }
            ();
            (v1.l0.get().clone())(string(""))
        }
        pub fn closure88(v0_1: Func0<()>, unitVar: ()) {
            fn v2() {
                Dice_contract::closure2((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v35: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v74: string = Dice_contract::method6(
                    patternInput_1.0.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v75: string = Dice_contract::method10();
                let v77: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method45(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method46(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method46: loop {
                break '_method46 (match v0_1.get().clone().as_ref() {
                    Dice_contract::UH0::UH0_0 => v1.get().clone(),
                    Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice_contract::UH0> =
                            match v0_1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                        let v1_temp: i8 = v1.get().clone() + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method46;
                    }
                });
            }
        }
        pub fn method47(v0_1: u64, v1: string, v2: string) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("max")), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("rolls")), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method48(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice_contract.roll_within_bounds"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure89(v0_1: u64, v1: Vec<u8>, v2: Option<u64>, unitVar: ()) {
            fn v4() {
                Dice_contract::closure2((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v37: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v86: string = Dice_contract::method48(
                    Dice_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v58.l0.get().clone(),
                    Dice_contract::method47(v0_1, sprintf!("{:?}", v1), sprintf!("{:?}", v2)),
                );
                let v88: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method15(
                    v86,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method49() -> Func0<()> {
            Func0::new(move || Dice_contract::closure87((), ()))
        }
        pub fn closure90(v0_1: Func0<()>, unitVar: ()) {
            fn v2() {
                Dice_contract::closure2((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v35: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v74: string = Dice_contract::method6(
                    patternInput_1.0.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v75: string = Dice_contract::method10();
                let v77: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                Dice_contract::method45(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        #[derive(
            //;
            near_sdk::PanicOnDefault, //;
            borsh::BorshDeserialize,  //;
            borsh::BorshSerialize,    //;
        )] //;
        pub struct OldState {
            //;
            version: u32,                            //;
            seeds: near_sdk::store::vec::Vector<u8>, //;
        } //;
        #[near_sdk::near_bindgen] //;
        #[derive(
            //;
            near_sdk::PanicOnDefault, //;
            borsh::BorshDeserialize,  //;
            borsh::BorshSerialize,    //;
        )] //;
        pub struct State(
            //;
            /*;
            {
                let v18: */
            (u32, near_sdk::store::vec::Vector<u8>), /* =
                                                        defaultOf::<()>();
                                                     */
        );
        impl From<OldState> for State {
            //;
            fn from(old_state: OldState) -> Self {
                //;
                Self((old_state.version + 1, old_state.seeds)) //;
            } //;
        } //;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[init] //;
            pub fn new() -> Self {
                // 1;
                {
                    let v32: bool = true; /*;
                                          let v33: */
                    () /* = defaultOf();
                    let v37: bool = true; */;
                    let v39: string = string("b\"seeds\"");
                    let v40: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (2_u32, near_sdk::store::vec::Vector::new(v40));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v47: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v49: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed(&mut self, seed: Vec<u8>) {
                //;
                {
                    let v54: &mut near_sdk::store::vec::Vector<u8> = &mut self.0 .1;
                    let v56: Vec<u8> = seed;
                    let v58: bool = true;
                    v54.extend(v56); //;
                    let v68: i32 = v54.len() as i32 - 100_i32;
                    if v68 > 0_i32 {
                        let v74: () = {
                            Dice_contract::closure1(
                                v54.drain(0..v68 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                } //;
            } //;
        } /* c;
          {
              let v193: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 2uy;
              let v195: bool =
                  true; */
 // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) {
                //;
                self.contribute_seed(seed) //;
            } //;
        } /* c;
          {
              let v203: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 4uy / n: 1uy;
              let v205: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 4uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v210: std::string::String = key;
                    let v212: std::string::String = proof;
                    let v214: u64 = max;
                    let v216: &mut near_sdk::store::vec::Vector<u8> = &mut self.0 .1;
                    let v218: Vec<u8> = near_sdk::env::random_seed();
                    let v220: u64 = near_sdk::env::epoch_height();
                    let v222: u64 = near_sdk::env::block_height();
                    let v224: u64 = near_sdk::env::block_timestamp();
                    let v226: near_token::NearToken = near_sdk::env::account_balance();
                    let v228: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v230: &near_sdk::store::vec::Vector<u8> = &*v216;
                    let v232: Vec<u8> = v230.iter().map(|x| *x).collect::<Vec<_>>();
                    let v234: _ = v220.to_le_bytes();
                    let v236: Vec<u8> = v234.to_vec();
                    let v238: _ = v222.to_le_bytes();
                    let v240: Vec<u8> = v238.to_vec();
                    let v242: _ = v224.to_le_bytes();
                    let v244: Vec<u8> = v242.to_vec();
                    let v246: u128 = v226.clone().as_yoctonear();
                    let v248: _ = v246.to_le_bytes();
                    let v250: Vec<u8> = v248.to_vec();
                    let v252: &[u8] = v228.as_bytes();
                    let v259: Array<Vec<u8>> = new_array(&[
                        v218.clone(),
                        v232,
                        v236,
                        v240,
                        v244,
                        v250,
                        v252.to_vec(),
                        v212.clone().into_bytes(),
                        v210.clone().into_bytes(),
                    ]);
                    let v261: Vec<Vec<u8>> = v259.to_vec();
                    let v263: Vec<u8> = v261.concat();
                    let v265: Vec<u8> = near_sdk::env::keccak512(&v263.clone());
                    let v267: bool = true;
                    v216.extend(v265.clone()); //;
                    let v277: i32 = v216.len() as i32 - 100_i32;
                    if v277 > 0_i32 {
                        let v283: () = {
                            Dice_contract::closure1(
                                v216.drain(0..v277 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v400: List<u8> =
                            ofArray(fable_library_rust::NativeArray_::array_from(v265.clone()));
                        let v416: LrcPtr<Dice_contract::UH0> = Dice_contract::method19(
                            Dice_contract::method18(
                                Dice_contract::method17(
                                    foldBack(
                                        Func2::new(
                                            move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                                                (Dice_contract::method16())(b0)(b1)
                                            },
                                        ),
                                        v400,
                                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                                    ),
                                    LrcPtr::new(Dice_contract::UH1::UH1_1),
                                ),
                                LrcPtr::new(Dice_contract::UH1::UH1_1),
                            ),
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                        );
                        let v419: () = {
                            Dice_contract::closure14(
                                v216,
                                v210,
                                v212,
                                v214,
                                v218,
                                v220,
                                v222,
                                v224,
                                v226,
                                v228,
                                v263,
                                v265,
                                v416.clone(),
                                (),
                            );
                            ()
                        };
                        let v565: LrcPtr<Dice_contract::UH1> = Dice_contract::method17(
                            Dice_contract::method24(
                                v416.clone(),
                                Dice_contract::method23(
                                    v416,
                                    LrcPtr::new(Dice_contract::UH0::UH0_0),
                                ),
                            ),
                            LrcPtr::new(Dice_contract::UH1::UH1_1),
                        );
                        let v581: u64 = Dice_contract::method29(
                            Dice_contract::method25(
                                v565.clone(),
                                Func0::new({
                                    let v565 = v565.clone();
                                    move || Dice_contract::closure15(v565.clone(), ())
                                }),
                            ),
                            LrcPtr::new(Dice_contract::Mut0 {
                                l0: MutCell::new(0_i64),
                            }),
                            LrcPtr::new(Dice_contract::Mut0 {
                                l0: MutCell::new(1_i64),
                            }),
                            LrcPtr::new(Dice_contract::Mut0 {
                                l0: MutCell::new(-1_i64),
                            }),
                            LrcPtr::new(Dice_contract::Mut6 {
                                l0: MutCell::new(Dice_contract::US5::US5_1),
                            }),
                            v214,
                            (if v214 == 1_u64 {
                                1_i8
                            } else {
                                Dice_contract::method26(v214, 0_i8, 1_u64)
                            }) - 1_i8,
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                            0_i8,
                        );
                        let v585: () = {
                            Dice_contract::closure88(Dice_contract::method44(), ());
                            ()
                        };
                        v581 //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v700: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 3uy;
              let v702: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v707: u64 = max;
                    let v709: Vec<u8> = rolls;
                    let v712: List<u8> =
                        ofArray(fable_library_rust::NativeArray_::array_from(v709.clone()));
                    let v718: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method16())(b0)(b1)
                        }),
                        v712,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v727: Dice_contract::US6 = Dice_contract::method36(
                        Dice_contract::method46(v718.clone(), 0_i8) - 1_i8,
                        v718,
                        0_u64,
                    );
                    let v737: Dice_contract::US7 =
                        if let Dice_contract::US6::US6_0(v727_0_0, v727_0_1) = &v727 {
                            let v728: u64 = match &v727 {
                                Dice_contract::US6::US6_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if if v728 >= 1_u64 { v728 <= v707 } else { false } {
                                Dice_contract::US7::US7_0(v728)
                            } else {
                                Dice_contract::US7::US7_1
                            }
                        } else {
                            Dice_contract::US7::US7_1
                        };
                    let v744: Option<u64> = match &v737 {
                        Dice_contract::US7::US7_0(v737_0_0) => Some(match &v737 {
                            Dice_contract::US7::US7_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v747: () = {
                        Dice_contract::closure89(v707, v709, v744.clone(), ());
                        ()
                    };
                    let v868: () = {
                        Dice_contract::closure90(Dice_contract::method49(), ());
                        ()
                    };
                    v744 //;
                } //;
            } //;
        } /* c;
          {
              let v982: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 8uy / n: 2uy;
              let v984: bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 8uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[result_serializer(borsh)] //;
            pub fn roll_within_bounds_borsh(
                //;
                &self,                               //;
                #[serializer(borsh)] max: u64,       //;
                #[serializer(borsh)] rolls: Vec<u8>, //;
            ) -> Option<u64> {
                //;
                self.roll_within_bounds(max, rolls) //;
            } //;
        } /* c;
          {
              let v997: bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 10uy / n: 1uy;
              let v999: bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 10uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v1003: bool = true;
            {
                (); // ?? / i': 1uy / n: 11uy;
                let v1005: bool = true;
                {
                    (); // ?? / i': 2uy / n: 11uy;
                    let v1007: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 11uy;
                        let v1009: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 11uy;
                            let v1011: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 11uy;
                                let v1013: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 11uy;
                                    let v1015: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 11uy;
                                        let v1017: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 11uy;
                                            let v1019: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 11uy;
                                                let v1021: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 11uy;
                                                    let v1023: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 11uy;
                                                        let v1025: bool = true;
                                                        {
                                                            {
                                                                (); // ? / i': 12uy / n: 11uy;
                                                                ()
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Dice_contract::closure0((), ())))
                .clone()
        }
        on_startup!(());
    }
}
pub use module_faa356c0::*;
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
