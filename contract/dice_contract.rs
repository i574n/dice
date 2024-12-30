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
#![allow(unused_assignments)]
mod module_faa356c0 {
    pub mod Dice_contract {
        use super::*;
        type DateTime = ();
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
        use fable_library_rust::Native_::getZero;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
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
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<Dice_contract::US0>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Dice_contract::US0),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(Dice_contract::US3),
            US4_1(Dice_contract::US3),
            US4_2(Dice_contract::US3),
            US4_3(Dice_contract::US3),
            US4_4(Dice_contract::US3),
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0(string),
            US5_1,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(u8, LrcPtr<Dice_contract::UH0>),
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0(u8, Func0<LrcPtr<Dice_contract::UH1>>),
            UH1_1,
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(Func0<LrcPtr<Dice_contract::UH1>>),
            US6_1(LrcPtr<Dice_contract::UH1>),
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut5 {
            pub l0: MutCell<Dice_contract::US6>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US7 {
            US7_0(u8),
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<Dice_contract::US7>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(u64, LrcPtr<Dice_contract::UH0>),
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH2 {
            UH2_0(u64, Func0<LrcPtr<Dice_contract::UH2>>),
            UH2_1,
        }
        impl core::fmt::Display for UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0(u64),
            US9_1,
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method4(v0_1: string) -> string {
            v0_1
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Dice_contract::US5 {
            Dice_contract::US5::US5_0(v0_1)
        }
        pub fn method6() -> Func1<string, Dice_contract::US5> {
            Func1::new(move |v: string| Dice_contract::closure3((), v))
        }
        pub fn method3(v0_1: string) -> string {
            panic!(
                "{}",
                sprintf!(
                    "env.get_environment_variable / target: {} / var: {}",
                    Dice_contract::US4::US4_2(Dice_contract::US3::US3_2),
                    v0_1
                ),
            )
        }
        pub fn method2() -> (Dice_contract::US1, Dice_contract::US2) {
            let v1: string = Dice_contract::method3(string("TRACE_LEVEL"));
            let v6: Dice_contract::US1 = if string("Verbose") == (v1.clone()) {
                Dice_contract::US1::US1_0(Dice_contract::US0::US0_0)
            } else {
                Dice_contract::US1::US1_1
            };
            (
                match &v6 {
                    Dice_contract::US1::US1_0(v6_0_0) => Dice_contract::US1::US1_0(
                        match &v6 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v13: Dice_contract::US1 = if string("Debug") == (v1.clone()) {
                            Dice_contract::US1::US1_0(Dice_contract::US0::US0_1)
                        } else {
                            Dice_contract::US1::US1_1
                        };
                        match &v13 {
                            Dice_contract::US1::US1_0(v13_0_0) => Dice_contract::US1::US1_0(
                                match &v13 {
                                    Dice_contract::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v20: Dice_contract::US1 = if string("Info") == (v1.clone()) {
                                    Dice_contract::US1::US1_0(Dice_contract::US0::US0_2)
                                } else {
                                    Dice_contract::US1::US1_1
                                };
                                match &v20 {
                                    Dice_contract::US1::US1_0(v20_0_0) => {
                                        Dice_contract::US1::US1_0(
                                            match &v20 {
                                                Dice_contract::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v27: Dice_contract::US1 =
                                            if string("Warning") == (v1.clone()) {
                                                Dice_contract::US1::US1_0(Dice_contract::US0::US0_3)
                                            } else {
                                                Dice_contract::US1::US1_1
                                            };
                                        match &v27 {
                                            Dice_contract::US1::US1_0(v27_0_0) => {
                                                Dice_contract::US1::US1_0(
                                                    match &v27 {
                                                        Dice_contract::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v34: Dice_contract::US1 =
                                                    if string("Critical") == (v1.clone()) {
                                                        Dice_contract::US1::US1_0(
                                                            Dice_contract::US0::US0_4,
                                                        )
                                                    } else {
                                                        Dice_contract::US1::US1_1
                                                    };
                                                match &v34 {
                                                    Dice_contract::US1::US1_0(v34_0_0) => {
                                                        Dice_contract::US1::US1_0(
                                                            match &v34 {
                                                                Dice_contract::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => Dice_contract::US1::US1_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if (Dice_contract::method3(string("AUTOMATION"))) != string("True") {
                    Dice_contract::US2::US2_1
                } else {
                    let v58: DateTime = unbox::<DateTime>(&getZero());
                    Dice_contract::US2::US2_0(unbox::<i64>(&getZero()))
                },
            )
        }
        pub fn closure4(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
            v0_1: Dice_contract::US0,
        ) -> (
            LrcPtr<Dice_contract::Mut0>,
            LrcPtr<Dice_contract::Mut1>,
            LrcPtr<Dice_contract::Mut2>,
            LrcPtr<Dice_contract::Mut3>,
            LrcPtr<Dice_contract::Mut4>,
            Option<i64>,
        ) {
            let v64: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v65: &str = option_env!("AUTOMATION").unwrap_or("");
            let v72: std::string::String = String::from(v65);
            let _run_target_args__v1: (Dice_contract::US1, Dice_contract::US2) = (
                Dice_contract::US1::US1_1,
                if (fable_library_rust::String_::fromString(v72)) != string("True") {
                    Dice_contract::US2::US2_1
                } else {
                    Dice_contract::US2::US2_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v132: Dice_contract::US2 = _run_target_args__v1.1.clone();
            let v131: Dice_contract::US1 = _run_target_args__v1.0.clone();
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
                    l0: MutCell::new(match &v131 {
                        Dice_contract::US1::US1_0(v131_0_0) => match &v131 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v132 {
                    Dice_contract::US2::US2_0(v132_0_0) => Some(match &v132 {
                        Dice_contract::US2::US2_0(x) => x.clone(),
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
                ) = Dice_contract::method1(Dice_contract::US0::US0_0);
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
        pub fn method0(v0_1: Dice_contract::US0) -> bool {
            let v3: () = {
                Dice_contract::closure2((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = Dice_contract::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v35: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                        LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure5(unitVar: (), v0_1: i64) -> Dice_contract::US2 {
            Dice_contract::US2::US2_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Dice_contract::US2> {
            Func1::new(move |v: i64| Dice_contract::closure5((), v))
        }
        pub fn method9() -> string {
            string("hh:mm:ss")
        }
        pub fn method10() -> string {
            string("HH:mm:ss")
        }
        pub fn method7(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v272: u64 = near_sdk::env::block_timestamp();
            let v286: Dice_contract::US2 =
                defaultValue(Dice_contract::US2::US2_1, map(Dice_contract::method8(), v5));
            let v298: u64 = (match &v286 {
                Dice_contract::US2::US2_0(v286_0_0) => {
                    (v272)
                        - (match &v286 {
                            Dice_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v272,
            }) / 1000000000_u64;
            let v299: u64 = (v298) % 60_u64;
            let v301: u64 = ((v298) / 60_u64) % 60_u64;
            let v303: u64 = ((v298) / 3600_u64) % 24_u64;
            let v305: std::string::String = format!("{:02}:{:02}:{:02}", v303, v301, v299);
            fable_library_rust::String_::fromString(v305)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure6(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append((v0_1.l0.get().clone()), (v1));
            v0_1.l0.set(v3);
            ()
        }
        pub fn method12(v0_1: char) -> string {
            let v2: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v8: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v6: string = Dice_contract::method12(getCharAt(toLower(string("Debug")), 0_i32));
            let v73: &str = inline_colorization::color_bright_blue;
            let v80: &str = &*v6;
            let v99: &str = inline_colorization::color_reset;
            let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
            fable_library_rust::String_::fromString(v101)
        }
        pub fn method16(v0_1: i32, v1: string) -> string {
            let v3: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v10: () = {
                Dice_contract::closure6(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Dice_contract::closure6(v3.clone(), string("seed_excess_len"), ());
                ()
            };
            let v28: () = {
                Dice_contract::closure6(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Dice_contract::closure6(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Dice_contract::closure6(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Dice_contract::closure6(v3.clone(), string("seed_excess"), ());
                ()
            };
            let v62: () = {
                Dice_contract::closure6(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Dice_contract::closure6(v3.clone(), v1, ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method17(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method15(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Dice_contract::method16(v8, v9);
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice_contract.contribute_seed"),
                v10
            ))
        }
        pub fn closure7(v0_1: LrcPtr<Dice_contract::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
        pub fn method18(v0_1: string) {
            let v3: () = {
                Dice_contract::closure2((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = Dice_contract::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v20: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v37: () = {
                Dice_contract::closure7(patternInput.0.clone(), ());
                ()
            };
            let v53: string = if (v20.l0.get().clone()) == string("") {
                v0_1.clone()
            } else {
                if (v0_1.clone()) == string("") {
                    v20.l0.get().clone()
                } else {
                    append(
                        (append((v20.l0.get().clone()), string("\n"))),
                        (v0_1.clone()),
                    )
                }
            };
            let v60: &str = &*v53.clone();
            let v79 = v60.chars();
            let v81 = v79;
            let v83: Vec<char> = v81.collect::<Vec<_>>();
            let v85: Vec<Vec<char>> = v83
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v87: bool = true;
            let _vec_map: Vec<_> = v85
                .into_iter()
                .map(|x| {
                    //;
                    let v89: Vec<char> = x;
                    let v91: std::string::String = String::from_iter(v89);
                    let v93: bool = true;
                    v91
                })
                .collect::<Vec<_>>();
            let v95: Vec<std::string::String> = _vec_map;
            if if (v0_1.clone()) != string("") {
                (v95.clone().len() as i32) <= 1_i32
            } else {
                false
            } {
                v20.l0.set(v53);
                ()
            } else {
                v20.l0.set(string(""));
                {
                    let v112: bool = true;
                    v95.into_iter().for_each(|x| {
                        //;
                        let v114: std::string::String = x;
                        let v116: bool = true;
                        near_sdk::log!("{}", v114);
                        let v118: bool = true;
                        let v120: bool = true;
                    }); //;
                    ()
                }
            }
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure1(v0_1: i32, v1: Vec<u8>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v6: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method15(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice_contract::method7(v20, v21, v22, v23, v24, v25),
                    Dice_contract::method11(),
                    v0_1,
                    sprintf!("{:?}", v1),
                ))
            };
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method19() -> Func0<()> {
            Func0::new(move || Dice_contract::closure10((), ()))
        }
        pub fn method20() {
            let v2: () = {
                Dice_contract::closure2((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ) = Dice_contract::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v19: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
                Dice_contract::closure7(patternInput.0.clone(), ());
                ()
            };
            let v53: string = if (v19.l0.get().clone()) == string("") {
                string("")
            } else {
                v19.l0.get().clone()
            };
            let v60: &str = &*v53;
            let v79 = v60.chars();
            let v81 = v79;
            let v83: Vec<char> = v81.collect::<Vec<_>>();
            let v85: Vec<Vec<char>> = v83
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v87: bool = true;
            let _vec_map: Vec<_> = v85
                .into_iter()
                .map(|x| {
                    //;
                    let v89: Vec<char> = x;
                    let v91: std::string::String = String::from_iter(v89);
                    let v93: bool = true;
                    v91
                })
                .collect::<Vec<_>>();
            let v95: Vec<std::string::String> = _vec_map;
            v19.l0.set(string(""));
            {
                let v111: bool = true;
                v95.into_iter().for_each(|x| {
                    //;
                    let v113: std::string::String = x;
                    let v115: bool = true;
                    near_sdk::log!("{}", v113);
                    let v117: bool = true;
                    let v119: bool = true;
                }); //;
                ()
            }
            ((patternInput.1.clone()).l0.get().clone())(string(""))
        }
        pub fn closure11(v0_1: Func0<()>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v5: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v37: string = Dice_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v38: string = Dice_contract::method11();
                Dice_contract::method20()
            };
        }
        pub fn closure13(v0_1: u8, v1: LrcPtr<Dice_contract::UH0>) -> LrcPtr<Dice_contract::UH0> {
            LrcPtr::new(Dice_contract::UH0::UH0_1(v0_1, v1))
        }
        pub fn closure12(
            unitVar: (),
            v0_1: u8,
        ) -> Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_contract::UH0>| Dice_contract::closure13(v0_1, v)
            })
        }
        pub fn method21() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure12((), v))
        }
        pub fn closure14(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method22(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: LrcPtr<Dice_contract::UH1> = Dice_contract::method22(
                        match v0_1.as_ref() {
                            Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1.clone(),
                    );
                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                        match v0_1.as_ref() {
                            Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Func0::new({
                            let v4 = v4.clone();
                            move || Dice_contract::closure14(v4.clone(), ())
                        }),
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
        pub fn method23(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v5: LrcPtr<Dice_contract::UH1> =
                        Dice_contract::method23((v0_1_0_1)(), v1.clone());
                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                        (((((v0_1_0_0.clone() as i64) - 1_i64) + 6_i64) % 6_i64) + 1_i64) as u8,
                        Func0::new({
                            let v5 = v5.clone();
                            move || Dice_contract::closure15(v5.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn method24(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    LrcPtr::new(Dice_contract::UH0::UH0_1(
                        v0_1_0_0.clone(),
                        Dice_contract::method24((v0_1_0_1)(), v1.clone()),
                    ))
                }
            }
        }
        pub fn method25(v0_1: LrcPtr<Dice_contract::UH0>, v1: List<u8>) -> List<u8> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice_contract::method25(
                        match v0_1.as_ref() {
                            Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1.clone(),
                    ),
                ),
            }
        }
        pub fn method27(
            v0_1: u64,
            v1: std::string::String,
            v2: std::string::String,
            v3: u64,
            v4: u64,
            v5: u64,
            v6: string,
            v7: std::string::String,
            v8: std::string::String,
            v9: string,
            v10: string,
            v11: usize,
            v12: string,
            v13: string,
            v14: string,
        ) -> string {
            let v16: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v23: () = {
                Dice_contract::closure6(v16.clone(), string("{ "), ());
                ()
            };
            let v32: () = {
                Dice_contract::closure6(v16.clone(), string("max"), ());
                ()
            };
            let v41: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v49: () = {
                Dice_contract::closure6(v16.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v58: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v67: () = {
                Dice_contract::closure6(v16.clone(), string("key"), ());
                ()
            };
            let v75: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v88: std::string::String = format!("{:#?}", v1);
            let v113: () = {
                Dice_contract::closure6(
                    v16.clone(),
                    fable_library_rust::String_::fromString(v88),
                    (),
                );
                ()
            };
            let v121: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v130: () = {
                Dice_contract::closure6(v16.clone(), string("proof"), ());
                ()
            };
            let v138: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v151: std::string::String = format!("{:#?}", v2);
            let v176: () = {
                Dice_contract::closure6(
                    v16.clone(),
                    fable_library_rust::String_::fromString(v151),
                    (),
                );
                ()
            };
            let v184: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v193: () = {
                Dice_contract::closure6(v16.clone(), string("block_timestamp"), ());
                ()
            };
            let v201: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v209: () = {
                Dice_contract::closure6(v16.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v217: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v226: () = {
                Dice_contract::closure6(v16.clone(), string("block_height"), ());
                ()
            };
            let v234: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v242: () = {
                Dice_contract::closure6(v16.clone(), sprintf!("{}", v4), ());
                ()
            };
            let v250: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v259: () = {
                Dice_contract::closure6(v16.clone(), string("epoch_height"), ());
                ()
            };
            let v267: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v275: () = {
                Dice_contract::closure6(v16.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v283: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v292: () = {
                Dice_contract::closure6(v16.clone(), string("account_balance"), ());
                ()
            };
            let v300: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v308: () = {
                Dice_contract::closure6(v16.clone(), v6, ());
                ()
            };
            let v316: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v325: () = {
                Dice_contract::closure6(v16.clone(), string("signer_account_id"), ());
                ()
            };
            let v333: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v346: std::string::String = format!("{:#?}", v7);
            let v371: () = {
                Dice_contract::closure6(
                    v16.clone(),
                    fable_library_rust::String_::fromString(v346),
                    (),
                );
                ()
            };
            let v379: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v388: () = {
                Dice_contract::closure6(v16.clone(), string("predecessor_account_id"), ());
                ()
            };
            let v396: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v409: std::string::String = format!("{:#?}", v8);
            let v434: () = {
                Dice_contract::closure6(
                    v16.clone(),
                    fable_library_rust::String_::fromString(v409),
                    (),
                );
                ()
            };
            let v442: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v451: () = {
                Dice_contract::closure6(v16.clone(), string("seed"), ());
                ()
            };
            let v459: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v467: () = {
                Dice_contract::closure6(v16.clone(), v9, ());
                ()
            };
            let v475: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v484: () = {
                Dice_contract::closure6(v16.clone(), string("seeds"), ());
                ()
            };
            let v492: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v500: () = {
                Dice_contract::closure6(v16.clone(), v10, ());
                ()
            };
            let v508: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v517: () = {
                Dice_contract::closure6(v16.clone(), string("entropy_len"), ());
                ()
            };
            let v525: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v538: std::string::String = format!("{:#?}", v11);
            let v563: () = {
                Dice_contract::closure6(
                    v16.clone(),
                    fable_library_rust::String_::fromString(v538),
                    (),
                );
                ()
            };
            let v571: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v580: () = {
                Dice_contract::closure6(v16.clone(), string("entropy"), ());
                ()
            };
            let v588: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v596: () = {
                Dice_contract::closure6(v16.clone(), v12, ());
                ()
            };
            let v604: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v613: () = {
                Dice_contract::closure6(v16.clone(), string("hash_u8"), ());
                ()
            };
            let v621: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v629: () = {
                Dice_contract::closure6(v16.clone(), v13, ());
                ()
            };
            let v637: () = {
                Dice_contract::closure6(v16.clone(), string("; "), ());
                ()
            };
            let v646: () = {
                Dice_contract::closure6(v16.clone(), string("rolls"), ());
                ()
            };
            let v654: () = {
                Dice_contract::closure6(v16.clone(), string(" = "), ());
                ()
            };
            let v662: () = {
                Dice_contract::closure6(v16.clone(), v14, ());
                ()
            };
            let v671: () = {
                Dice_contract::closure6(v16.clone(), string(" }"), ());
                ()
            };
            v16.l0.get().clone()
        }
        pub fn method26(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u64,
            v9: std::string::String,
            v10: std::string::String,
            v11: u64,
            v12: u64,
            v13: u64,
            v14: string,
            v15: std::string::String,
            v16: std::string::String,
            v17: string,
            v18: string,
            v19: usize,
            v20: string,
            v21: string,
            v22: string,
        ) -> string {
            let v23: string = Dice_contract::method27(
                v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22,
            );
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice_contract.generate_random_number"),
                v23
            ))
        }
        pub fn closure16(
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
            v10: near_sdk::AccountId,
            v11: Vec<u8>,
            v12: Vec<u8>,
            v13: LrcPtr<Dice_contract::UH0>,
            unitVar: (),
        ) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v18: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v37: Option<i64> = patternInput.5.clone();
                let v36: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v35: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v34: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v33: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v32: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                let v50: string = Dice_contract::method7(
                    v32.clone(),
                    v33.clone(),
                    v34.clone(),
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                );
                let v51: string = Dice_contract::method11();
                let v52: string = sprintf!("{:?}", v8);
                let v56: std::string::String = v9.to_string();
                let v58: std::string::String = v10.to_string();
                let v59: string = sprintf!("{:?}", v4);
                let v62: string = sprintf!("{:?}", v0_1);
                let v66: usize = v11.clone().len();
                let v67: string = sprintf!("{:?}", v11);
                let v70: string = sprintf!("{:?}", v12);
                let v76: Array<u8> = toArray(Dice_contract::method25(v13, empty::<u8>()));
                Dice_contract::method18(Dice_contract::method26(
                    v32,
                    v33,
                    v34,
                    v35,
                    v36,
                    v37,
                    v50,
                    v51,
                    v3,
                    v1,
                    v2,
                    v7,
                    v6,
                    v5,
                    v52,
                    v56,
                    v58,
                    v59,
                    v62,
                    v66,
                    v67,
                    v70,
                    sprintf!("{:?}", v76.to_vec()),
                ))
            };
        }
        pub fn method28(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            '_method28: loop {
                break '_method28 (match v0_1.get().clone().as_ref() {
                    Dice_contract::UH0::UH0_0 => v1.get().clone(),
                    Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice_contract::UH0> =
                            match v0_1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
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
                        continue '_method28;
                    }
                });
            }
        }
        pub fn method29(
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
                        Dice_contract::method29(
                            match v0_1.as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            v1.clone(),
                        ),
                    ))
                }
            }
        }
        pub fn closure17(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn closure18(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::Mut5>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            let v2: Dice_contract::US6 = v1.l0.get().clone();
            match &v2 {
                Dice_contract::US6::US6_0(v2_0_0) => {
                    let v5: LrcPtr<Dice_contract::UH1> = (v2_0_0)();
                    let v12: LrcPtr<Dice_contract::UH1> = match v5.as_ref() {
                        Dice_contract::UH1::UH1_1 => LrcPtr::new(Dice_contract::UH1::UH1_1),
                        Dice_contract::UH1::UH1_0(v5_0_0, v5_0_1) => {
                            LrcPtr::new(Dice_contract::UH1::UH1_0(
                                v5_0_0.clone(),
                                Dice_contract::method30(v0_1.clone(), v5_0_1.clone()),
                            ))
                        }
                    };
                    v1.l0.set(Dice_contract::US6::US6_1(v12.clone()));
                    v12
                }
                Dice_contract::US6::US6_1(v2_1_0) => v2_1_0.clone(),
            }
        }
        pub fn method30(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
        ) -> Func0<LrcPtr<Dice_contract::UH1>> {
            let v3: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                l0: MutCell::new(Dice_contract::US6::US6_0(v1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3 = v3.clone();
                move || Dice_contract::closure18(v0_1.clone(), v3.clone(), ())
            })
        }
        pub fn method33(v0_1: u64, v1: u64, v2: i8) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), string("max"), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), string("p"), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), string("n"), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method32(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u64,
            v9: u64,
            v10: i8,
        ) -> string {
            let v11: string = Dice_contract::method33(v8, v9, v10);
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.calculate_dice_count"),
                v11
            ))
        }
        pub fn closure19(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v7: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method32(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice_contract::method7(v21, v22, v23, v24, v25, v26),
                    Dice_contract::method11(),
                    v0_1,
                    v2,
                    v1,
                ))
            };
        }
        pub fn method31(v0_1: u64, v1: i8, v2: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1: MutCell<i8> = MutCell::new(v1);
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method31: loop {
                break '_method31 (if (v2.get().clone()) < (v0_1.get().clone()) {
                    let v4: u64 = (v2.get().clone()) * 6_u64;
                    if (v4) > (v2.get().clone()) {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_temp: i8 = (v1.get().clone()) + 1_i8;
                        let v2_temp: u64 = v4;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        continue '_method31;
                    } else {
                        let v10: () = {
                            Dice_contract::closure19(
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
                    let v53: () = {
                        Dice_contract::closure19(
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
        pub fn method37(v0_1: i64, v1: i64, v2: i64, v3: string) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v12: () = {
                Dice_contract::closure6(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Dice_contract::closure6(v5.clone(), string("current_index"), ());
                ()
            };
            let v30: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice_contract::closure6(v5.clone(), string("; "), ());
                ()
            };
            let v56: () = {
                Dice_contract::closure6(v5.clone(), string("acc"), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v80: () = {
                Dice_contract::closure6(v5.clone(), string("; "), ());
                ()
            };
            let v89: () = {
                Dice_contract::closure6(v5.clone(), string("len"), ());
                ()
            };
            let v97: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v105: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v5.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v5.clone(), string("last_item"), ());
                ()
            };
            let v130: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Dice_contract::closure6(v5.clone(), v3, ());
                ()
            };
            let v147: () = {
                Dice_contract::closure6(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method36(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: i64,
            v10: i64,
            v11: string,
        ) -> string {
            let v12: string = Dice_contract::method37(v8, v9, v10, v11);
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.create_sequential_roller / roll"),
                v12
            ))
        }
        pub fn closure20(v0_1: i64, v1: i64, v2: i64, v3: Option<u8>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v8: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method36(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Dice_contract::method7(v22, v23, v24, v25, v26, v27),
                    Dice_contract::method11(),
                    v0_1,
                    v1,
                    v2,
                    sprintf!("{:?}", v3),
                ))
            };
        }
        pub fn method38(v0_1: i64, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US7 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method38: loop {
                break '_method38 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US7::US7_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice_contract::US7::US7_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method38;
                        }
                    }
                });
            }
        }
        pub fn method40() -> string {
            let v1: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            v1.l0.get().clone()
        }
        pub fn method39(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            let v8: string = Dice_contract::method40();
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.create_sequential_roller / roll / None"),
                v8
            ))
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v4: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v23: Option<i64> = patternInput.5.clone();
                let v22: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v21: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v20: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v19: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v18: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method39(
                    v18.clone(),
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    Dice_contract::method7(v18, v19, v20, v21, v22, v23),
                    Dice_contract::method11(),
                ))
            };
        }
        pub fn method35(
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
            '_method35: loop {
                break '_method35 ({
                    let v5: i64 = v1.l0.get().clone();
                    let v6: i64 = v2.l0.get().clone();
                    let v7: i64 = v3.l0.get().clone();
                    let v8: Dice_contract::US7 = v4.l0.get().clone();
                    let v18: () = {
                        Dice_contract::closure20(
                            v5,
                            v6,
                            v7,
                            match &v8 {
                                Dice_contract::US7::US7_0(v8_0_0) => Some(match &v8 {
                                    Dice_contract::US7::US7_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => None::<u8>,
                            },
                            (),
                        );
                        ()
                    };
                    let v61: LrcPtr<Dice_contract::UH1> = v0_1();
                    let v63: Dice_contract::US7 = Dice_contract::method38(v1.l0.get().clone(), v61);
                    match &v63 {
                        Dice_contract::US7::US7_0(v63_0_0) => {
                            let v64: u8 = match &v63 {
                                Dice_contract::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v66: i64 = (v1.l0.get().clone()) + 1_i64;
                            v1.l0.set(v66);
                            v4.l0.set(Dice_contract::US7::US7_0(v64));
                            v64
                        }
                        _ => {
                            let v70: () = {
                                Dice_contract::closure21((), ());
                                ()
                            };
                            if (v3.l0.get().clone()) == -1_i64 {
                                let v112: i64 = v1.l0.get().clone();
                                v3.l0.set(v112);
                                ()
                            }
                            {
                                let v118: i64 = if (v2.l0.get().clone()) >= (v3.l0.get().clone()) {
                                    1_i64
                                } else {
                                    (v2.l0.get().clone()) + 1_i64
                                };
                                v2.l0.set(v118);
                                {
                                    let v120: i64 = (v2.l0.get().clone()) - 1_i64;
                                    v1.l0.set(v120);
                                    v4.l0.set(Dice_contract::US7::US7_1);
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
                                        continue '_method35;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method43(v0_1: i8, v1: u64, v2: u64) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), string("power"), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), string("acc"), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), string("result"), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method42(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i8,
            v9: u64,
            v10: u64,
        ) -> string {
            let v11: string = Dice_contract::method43(v8, v9, v10);
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure22(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v7: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method42(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice_contract::method7(v21, v22, v23, v24, v25, v26),
                    Dice_contract::method11(),
                    v1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn closure86(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_1)
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice_contract::closure86((), ())),
            ))
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice_contract::closure85((), ())),
            ))
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice_contract::closure84((), ())),
            ))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice_contract::closure83((), ())),
            ))
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice_contract::closure82((), ())),
            ))
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice_contract::closure81((), ())),
            ))
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice_contract::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice_contract::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice_contract::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice_contract::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice_contract::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice_contract::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice_contract::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice_contract::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice_contract::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice_contract::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice_contract::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice_contract::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice_contract::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice_contract::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice_contract::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice_contract::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice_contract::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice_contract::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice_contract::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice_contract::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice_contract::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice_contract::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice_contract::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice_contract::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice_contract::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice_contract::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice_contract::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice_contract::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice_contract::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice_contract::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice_contract::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice_contract::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice_contract::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice_contract::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice_contract::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice_contract::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice_contract::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice_contract::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice_contract::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice_contract::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice_contract::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice_contract::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice_contract::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice_contract::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice_contract::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice_contract::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice_contract::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice_contract::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice_contract::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice_contract::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice_contract::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice_contract::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice_contract::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice_contract::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice_contract::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice_contract::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice_contract::closure24((), ())),
            ))
        }
        pub fn method44(v0_1: i8, v1: LrcPtr<Dice_contract::UH2>) -> Dice_contract::US9 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH2>> = MutCell::new(v1.clone());
            '_method44: loop {
                break '_method44 (match v1.get().clone().as_ref() {
                    Dice_contract::UH2::UH2_1 => Dice_contract::US9::US9_1,
                    Dice_contract::UH2::UH2_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice_contract::US9::US9_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH2> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method44;
                        }
                    }
                });
            }
        }
        pub fn method46(v0_1: i8, v1: u64, v2: u8, v3: u64) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v12: () = {
                Dice_contract::closure6(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Dice_contract::closure6(v5.clone(), string("power"), ());
                ()
            };
            let v30: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice_contract::closure6(v5.clone(), string("; "), ());
                ()
            };
            let v56: () = {
                Dice_contract::closure6(v5.clone(), string("acc"), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v80: () = {
                Dice_contract::closure6(v5.clone(), string("; "), ());
                ()
            };
            let v89: () = {
                Dice_contract::closure6(v5.clone(), string("roll"), ());
                ()
            };
            let v97: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v105: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v5.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v5.clone(), string("value"), ());
                ()
            };
            let v130: () = {
                Dice_contract::closure6(v5.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v147: () = {
                Dice_contract::closure6(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method45(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i8,
            v9: u64,
            v10: u8,
            v11: u64,
        ) -> string {
            let v12: string = Dice_contract::method46(v8, v9, v10, v11);
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure87(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v8: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method45(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Dice_contract::method7(v22, v23, v24, v25, v26, v27),
                    Dice_contract::method11(),
                    v1,
                    v0_1,
                    v2,
                    v3,
                ))
            };
        }
        pub fn method48(v0_1: i8, v1: u64, v2: u8) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), string("power"), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), string("acc"), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), string("roll"), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method47(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i8,
            v9: u64,
            v10: u8,
        ) -> string {
            let v11: string = Dice_contract::method48(v8, v9, v10);
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure88(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v7: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method47(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice_contract::method7(v21, v22, v23, v24, v25, v26),
                    Dice_contract::method11(),
                    v1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method41(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US8 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method41: loop {
                break '_method41 (if (v0_1.get().clone()) < 0_i8 {
                    let v4: u64 = (v2.get().clone()) + 1_u64;
                    let v7: () = {
                        Dice_contract::closure22(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US8::US8_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US8::US8_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v50: LrcPtr<Dice_contract::UH0> = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v49: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v49) > 1_u8 {
                                let v55: Dice_contract::US9 = Dice_contract::method44(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure23((), ())),
                                    )),
                                );
                                let v62: u64 = (((v49) - 1_u8) as u64)
                                    * (match &v55 {
                                        Dice_contract::US9::US9_0(v55_0_0) => match &v55 {
                                            Dice_contract::US9::US9_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v65: () = {
                                    Dice_contract::closure87(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v49,
                                        v62,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v50;
                                    let v2_temp: u64 = (v2.get().clone()) + (v62);
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method41;
                                }
                            } else {
                                let v110: () = {
                                    Dice_contract::closure88(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v49,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v50.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method41;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method49(
            v0_1: i8,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut0>,
            v5: LrcPtr<Dice_contract::Mut6>,
            v6: i8,
        ) -> LrcPtr<Dice_contract::UH0> {
            if (v6) < (v0_1) {
                LrcPtr::new(Dice_contract::UH0::UH0_1(
                    Dice_contract::method35(
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                    ),
                    Dice_contract::method49(v0_1, v1, v2, v3, v4, v5, (v6) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice_contract::UH0::UH0_0)
            }
        }
        pub fn method50(
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
            '_method50: loop {
                break '_method50 ({
                    let v8: i8 = (v6.get().clone()) + 1_i8;
                    if (v6.get().clone()) < (v8) {
                        Dice_contract::method34(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            LrcPtr::new(Dice_contract::UH0::UH0_1(
                                Dice_contract::method35(
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
                        let v14: Dice_contract::US8 =
                            Dice_contract::method41(v6.get().clone(), v7.get().clone(), 0_u64);
                        if let Dice_contract::US8::US8_0(v14_0_0, v14_0_1) = &v14 {
                            let v15: u64 = v14_0_0.clone();
                            if (v15) <= (v5.get().clone()) {
                                v15
                            } else {
                                let v0_1_temp = v0_1.get().clone();
                                let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                                let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                                let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                                let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                                let v5_temp: u64 = v5.get().clone();
                                let v6_temp: i8 = v6.get().clone();
                                let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method49(
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
                                continue '_method50;
                            }
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                            let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                            let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                            let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                            let v5_temp: u64 = v5.get().clone();
                            let v6_temp: i8 = v6.get().clone();
                            let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method49(
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
                            continue '_method50;
                        }
                    }
                });
            }
        }
        pub fn method34(
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
            '_method34: loop {
                break '_method34 (if (v8.get().clone()) < ((v6.get().clone()) + 1_i8) {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                    let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                    let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                    let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                    let v5_temp: u64 = v5.get().clone();
                    let v6_temp: i8 = v6.get().clone();
                    let v7_temp: LrcPtr<Dice_contract::UH0> =
                        LrcPtr::new(Dice_contract::UH0::UH0_1(
                            Dice_contract::method35(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            ),
                            v7.get().clone(),
                        ));
                    let v8_temp: i8 = (v8.get().clone()) + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1.set(v1_temp);
                    v2.set(v2_temp);
                    v3.set(v3_temp);
                    v4.set(v4_temp);
                    v5.set(v5_temp);
                    v6.set(v6_temp);
                    v7.set(v7_temp);
                    v8.set(v8_temp);
                    continue '_method34;
                } else {
                    let v16: Dice_contract::US8 =
                        Dice_contract::method41(v6.get().clone(), v7.get().clone(), 0_u64);
                    if let Dice_contract::US8::US8_0(v16_0_0, v16_0_1) = &v16 {
                        let v17: u64 = v16_0_0.clone();
                        if (v17) <= (v5.get().clone()) {
                            v17
                        } else {
                            Dice_contract::method50(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                                Dice_contract::method49(
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
                        Dice_contract::method50(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            Dice_contract::method49(
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
        pub fn method51() -> Func0<()> {
            Func0::new(move || Dice_contract::closure10((), ()))
        }
        pub fn closure89(v0_1: Func0<()>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v5: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v37: string = Dice_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v38: string = Dice_contract::method11();
                Dice_contract::method20()
            };
        }
        pub fn method52(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method52: loop {
                break '_method52 (match v0_1.get().clone().as_ref() {
                    Dice_contract::UH0::UH0_0 => v1.get().clone(),
                    Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice_contract::UH0> =
                            match v0_1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                        let v1_temp: i8 = (v1.get().clone()) + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method52;
                    }
                });
            }
        }
        pub fn method54(v0_1: u64, v1: string, v2: string) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), string("max"), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), string("rolls"), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), v1, ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), string("result"), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), v2, ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method53(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u64,
            v9: string,
            v10: string,
        ) -> string {
            let v11: string = Dice_contract::method54(v8, v9, v10);
            Dice_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice_contract.roll_within_bounds"),
                v11
            ))
        }
        pub fn closure90(v0_1: u64, v1: Vec<u8>, v2: Option<u64>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v7: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method18(Dice_contract::method53(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice_contract::method7(v21, v22, v23, v24, v25, v26),
                    Dice_contract::method11(),
                    v0_1,
                    sprintf!("{:?}", v1),
                    sprintf!("{:?}", v2),
                ))
            };
        }
        pub fn method55() -> Func0<()> {
            Func0::new(move || Dice_contract::closure10((), ()))
        }
        pub fn closure91(v0_1: Func0<()>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v5: () = {
                    Dice_contract::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice_contract::Mut0>,
                    LrcPtr<Dice_contract::Mut1>,
                    LrcPtr<Dice_contract::Mut2>,
                    LrcPtr<Dice_contract::Mut3>,
                    LrcPtr<Dice_contract::Mut4>,
                    Option<i64>,
                ) = Dice_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v37: string = Dice_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v38: string = Dice_contract::method11();
                Dice_contract::method20()
            };
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
                                                         getZero::<()>();
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
                    () /* = getZero();
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
                    let v78: i32 = (v54.len() as i32) - (100_i32);
                    if (v78) > 0_i32 {
                        let v84: () = {
                            Dice_contract::closure1(
                                v78,
                                v54.drain(0..v78 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v130: () = {
                            Dice_contract::closure11(Dice_contract::method19(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v174: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
              let v176: bool =
                  true; */
 // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) {
                //;
                self.contribute_seed(seed) //;
            } //;
        } /* c;
          {
              let v184: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
              let v186: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v191: std::string::String = key;
                    let v193: std::string::String = proof;
                    let v195: u64 = max;
                    let v197: &mut near_sdk::store::vec::Vector<u8> = &mut self.0 .1;
                    let v199: Vec<u8> = near_sdk::env::random_seed();
                    let v201: u64 = near_sdk::env::epoch_height();
                    let v203: u64 = near_sdk::env::block_height();
                    let v205: u64 = near_sdk::env::block_timestamp();
                    let v207: near_token::NearToken = near_sdk::env::account_balance();
                    let v209: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v211: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v213: &near_sdk::store::vec::Vector<u8> = &*v197;
                    let v215: Vec<u8> = v213.iter().map(|x| *x).collect::<Vec<_>>();
                    let v217: _ = v201.to_le_bytes();
                    let v219: Vec<u8> = v217.to_vec();
                    let v221: _ = v203.to_le_bytes();
                    let v223: Vec<u8> = v221.to_vec();
                    let v225: _ = v205.to_le_bytes();
                    let v227: Vec<u8> = v225.to_vec();
                    let v229: u128 = v207.clone().as_yoctonear();
                    let v231: _ = v229.to_le_bytes();
                    let v233: Vec<u8> = v231.to_vec();
                    let v235: &[u8] = v209.as_bytes();
                    let v237: Vec<u8> = v235.to_vec();
                    let v239: &[u8] = v211.as_bytes();
                    let v246: Array<Vec<u8>> = new_array(&[
                        v199.clone(),
                        v215,
                        v219,
                        v223,
                        v227,
                        v233,
                        v237,
                        v239.to_vec(),
                        v193.clone().into_bytes(),
                        v191.clone().into_bytes(),
                    ]);
                    let v248: Vec<Vec<u8>> = v246.to_vec();
                    let v250: Vec<u8> = v248.concat();
                    let v252: Vec<u8> = near_sdk::env::keccak512(&v250.clone());
                    let v254: bool = true;
                    v197.extend(v252.clone()); //;
                    let v274: i32 = (v197.len() as i32) - (100_i32);
                    if (v274) > 0_i32 {
                        let v280: () = {
                            Dice_contract::closure1(
                                v274,
                                v197.drain(0..v274 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v326: () = {
                            Dice_contract::closure11(Dice_contract::method19(), ());
                            ()
                        };
                        let v367: List<u8> = ofArray(fable_library_rust::NativeArray_::array_from(
                            v252.clone().clone(),
                        ));
                        let v402: LrcPtr<Dice_contract::UH0> = Dice_contract::method24(
                            Dice_contract::method23(
                                Dice_contract::method22(
                                    foldBack(
                                        Func2::new(
                                            move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                                                (Dice_contract::method21())(b0)(b1)
                                            },
                                        ),
                                        v367,
                                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                                    ),
                                    LrcPtr::new(Dice_contract::UH1::UH1_1),
                                ),
                                LrcPtr::new(Dice_contract::UH1::UH1_1),
                            ),
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                        );
                        let v405: () = {
                            Dice_contract::closure16(
                                v197,
                                v191,
                                v193,
                                v195,
                                v199,
                                v201,
                                v203,
                                v205,
                                v207,
                                v209,
                                v211,
                                v250,
                                v252,
                                v402.clone(),
                                (),
                            );
                            ()
                        };
                        let v481: LrcPtr<Dice_contract::UH1> = Dice_contract::method22(
                            Dice_contract::method29(
                                v402.clone(),
                                Dice_contract::method28(
                                    v402,
                                    LrcPtr::new(Dice_contract::UH0::UH0_0),
                                ),
                            ),
                            LrcPtr::new(Dice_contract::UH1::UH1_1),
                        );
                        let v497: u64 = Dice_contract::method34(
                            Dice_contract::method30(
                                v481.clone(),
                                Func0::new({
                                    let v481 = v481.clone();
                                    move || Dice_contract::closure17(v481.clone(), ())
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
                                l0: MutCell::new(Dice_contract::US7::US7_1),
                            }),
                            v195,
                            (if (v195) == 1_u64 {
                                1_i8
                            } else {
                                Dice_contract::method31(v195, 0_i8, 1_u64)
                            }) - 1_i8,
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                            0_i8,
                        );
                        let v501: () = {
                            Dice_contract::closure89(Dice_contract::method51(), ());
                            ()
                        };
                        v497 //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v546: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy;
              let v548: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v553: u64 = max;
                    let v555: Vec<u8> = rolls;
                    let v558: List<u8> = ofArray(fable_library_rust::NativeArray_::array_from(
                        v555.clone().clone(),
                    ));
                    let v566: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method21())(b0)(b1)
                        }),
                        v558,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v592: Dice_contract::US8 = Dice_contract::method41(
                        (Dice_contract::method52(v566.clone(), 0_i8)) - 1_i8,
                        v566,
                        0_u64,
                    );
                    let v602: Dice_contract::US9 =
                        if let Dice_contract::US8::US8_0(v592_0_0, v592_0_1) = &v592 {
                            let v593: u64 = v592_0_0.clone();
                            if if (v593) >= 1_u64 {
                                (v593) <= (v553)
                            } else {
                                false
                            } {
                                Dice_contract::US9::US9_0(v593)
                            } else {
                                Dice_contract::US9::US9_1
                            }
                        } else {
                            Dice_contract::US9::US9_1
                        };
                    let v609: Option<u64> = match &v602 {
                        Dice_contract::US9::US9_0(v602_0_0) => Some(match &v602 {
                            Dice_contract::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v612: () = {
                        Dice_contract::closure90(v553, v555, v609.clone(), ());
                        ()
                    };
                    let v661: () = {
                        Dice_contract::closure91(Dice_contract::method55(), ());
                        ()
                    };
                    v609 //;
                } //;
            } //;
        } /* c;
          {
              let v705: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy;
              let v707: bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy;
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
              let v720:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy;
              let v722:
                      bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v726: bool = true;
            {
                (); // ?? / i': 1uy / n: 12uy;
                let v728: bool = true;
                {
                    (); // ?? / i': 2uy / n: 12uy;
                    let v730: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 12uy;
                        let v732: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 12uy;
                            let v734: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 12uy;
                                let v736: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 12uy;
                                    let v738: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 12uy;
                                        let v740: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 12uy;
                                            let v742: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 12uy;
                                                let v744: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 12uy;
                                                    let v746: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 12uy;
                                                        let v748: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 12uy;
                                                            let v750: bool = true;
                                                            {
                                                                {
                                                                    (); // ? / i': 13uy / n: 12uy;
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
