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
mod module_aadd22c3 {
    pub mod Dice_contract {
        use super::*;
        type DateTime = ();
        use fable_library_rust::List_::List;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toString;
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
            US4_5(Dice_contract::US3),
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
                    Dice_contract::US4::US4_3(Dice_contract::US3::US3_2),
                    v0_1
                ),
            )
        }
        pub fn method2() -> (Dice_contract::US1, Dice_contract::US2) {
            let v1: string = Dice_contract::method3(string("TRACE_LEVEL"));
            let v6: string = toLower(string("Critical"));
            let v13: string = toLower(string("Warning"));
            let v20: string = toLower(string("Info"));
            let v27: string = toLower(string("Debug"));
            let v34: string = toLower(string("Verbose"));
            let v41: Dice_contract::US1 = if string("Verbose") == (v1.clone()) {
                Dice_contract::US1::US1_0(Dice_contract::US0::US0_0)
            } else {
                Dice_contract::US1::US1_1
            };
            (
                match &v41 {
                    Dice_contract::US1::US1_0(v41_0_0) => Dice_contract::US1::US1_0(
                        match &v41 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v48: Dice_contract::US1 = if string("Debug") == (v1.clone()) {
                            Dice_contract::US1::US1_0(Dice_contract::US0::US0_1)
                        } else {
                            Dice_contract::US1::US1_1
                        };
                        match &v48 {
                            Dice_contract::US1::US1_0(v48_0_0) => Dice_contract::US1::US1_0(
                                match &v48 {
                                    Dice_contract::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v55: Dice_contract::US1 = if string("Info") == (v1.clone()) {
                                    Dice_contract::US1::US1_0(Dice_contract::US0::US0_2)
                                } else {
                                    Dice_contract::US1::US1_1
                                };
                                match &v55 {
                                    Dice_contract::US1::US1_0(v55_0_0) => {
                                        Dice_contract::US1::US1_0(
                                            match &v55 {
                                                Dice_contract::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v62: Dice_contract::US1 =
                                            if string("Warning") == (v1.clone()) {
                                                Dice_contract::US1::US1_0(Dice_contract::US0::US0_3)
                                            } else {
                                                Dice_contract::US1::US1_1
                                            };
                                        match &v62 {
                                            Dice_contract::US1::US1_0(v62_0_0) => {
                                                Dice_contract::US1::US1_0(
                                                    match &v62 {
                                                        Dice_contract::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v69: Dice_contract::US1 =
                                                    if string("Critical") == (v1.clone()) {
                                                        Dice_contract::US1::US1_0(
                                                            Dice_contract::US0::US0_4,
                                                        )
                                                    } else {
                                                        Dice_contract::US1::US1_1
                                                    };
                                                match &v69 {
                                                    Dice_contract::US1::US1_0(v69_0_0) => {
                                                        Dice_contract::US1::US1_0(
                                                            match &v69 {
                                                                Dice_contract::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v76: Dice_contract::US1 =
                                                            if (v34.clone()) == (v1.clone()) {
                                                                Dice_contract::US1::US1_0(
                                                                    Dice_contract::US0::US0_0,
                                                                )
                                                            } else {
                                                                Dice_contract::US1::US1_1
                                                            };
                                                        match &v76 {
                                                         Dice_contract::US1::US1_0(v76_0_0)
                                                         =>
                                                         Dice_contract::US1::US1_0(match &v76
                                                                                       {
                                                                                       Dice_contract::US1::US1_0(x)
                                                                                       =>
                                                                                       x.clone(),
                                                                                       _
                                                                                       =>
                                                                                       unreachable!(),
                                                                                   }.clone()),
                                                         _ => {
                                                             let v83:
                                                                     Dice_contract::US1 =
                                                                 if (v27.clone())
                                                                        ==
                                                                        (v1.clone())
                                                                    {
                                                                     Dice_contract::US1::US1_0(Dice_contract::US0::US0_1)
                                                                 } else {
                                                                     Dice_contract::US1::US1_1
                                                                 };
                                                             match &v83 {
                                                                 Dice_contract::US1::US1_0(v83_0_0)
                                                                 =>
                                                                 Dice_contract::US1::US1_0(match &v83
                                                                                               {
                                                                                               Dice_contract::US1::US1_0(x)
                                                                                               =>
                                                                                               x.clone(),
                                                                                               _
                                                                                               =>
                                                                                               unreachable!(),
                                                                                           }.clone()),
                                                                 _ => {
                                                                     let v90:
                                                                             Dice_contract::US1 =
                                                                         if (v20.clone())
                                                                                ==
                                                                                (v1.clone())
                                                                            {
                                                                             Dice_contract::US1::US1_0(Dice_contract::US0::US0_2)
                                                                         } else {
                                                                             Dice_contract::US1::US1_1
                                                                         };
                                                                     match &v90
                                                                         {
                                                                         Dice_contract::US1::US1_0(v90_0_0)
                                                                         =>
                                                                         Dice_contract::US1::US1_0(match &v90
                                                                                                       {
                                                                                                       Dice_contract::US1::US1_0(x)
                                                                                                       =>
                                                                                                       x.clone(),
                                                                                                       _
                                                                                                       =>
                                                                                                       unreachable!(),
                                                                                                   }.clone()),
                                                                         _ =>
                                                                         {
                                                                             let v97:
                                                                                     Dice_contract::US1 =
                                                                                 if (v13.clone())
                                                                                        ==
                                                                                        (v1.clone())
                                                                                    {
                                                                                     Dice_contract::US1::US1_0(Dice_contract::US0::US0_3)
                                                                                 } else {
                                                                                     Dice_contract::US1::US1_1
                                                                                 };
                                                                             match &v97
                                                                                 {
                                                                                 Dice_contract::US1::US1_0(v97_0_0)
                                                                                 =>
                                                                                 Dice_contract::US1::US1_0(match &v97
                                                                                                               {
                                                                                                               Dice_contract::US1::US1_0(x)
                                                                                                               =>
                                                                                                               x.clone(),
                                                                                                               _
                                                                                                               =>
                                                                                                               unreachable!(),
                                                                                                           }.clone()),
                                                                                 _
                                                                                 =>
                                                                                 {
                                                                                     let v104:
                                                                                             Dice_contract::US1 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1.clone())
                                                                                            {
                                                                                             Dice_contract::US1::US1_0(Dice_contract::US0::US0_4)
                                                                                         } else {
                                                                                             Dice_contract::US1::US1_1
                                                                                         };
                                                                                     match &v104
                                                                                         {
                                                                                         Dice_contract::US1::US1_0(v104_0_0)
                                                                                         =>
                                                                                         Dice_contract::US1::US1_0(match &v104
                                                                                                                       {
                                                                                                                       Dice_contract::US1::US1_0(x)
                                                                                                                       =>
                                                                                                                       x.clone(),
                                                                                                                       _
                                                                                                                       =>
                                                                                                                       unreachable!(),
                                                                                                                   }.clone()),
                                                                                         _
                                                                                         =>
                                                                                         Dice_contract::US1::US1_1,
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
                            }
                        }
                    }
                },
                if (Dice_contract::method3(string("AUTOMATION"))) != string("True") {
                    Dice_contract::US2::US2_1
                } else {
                    let v147: DateTime = unbox::<DateTime>(fable_library_rust::Native_::getZero());
                    Dice_contract::US2::US2_0(unbox::<i64>(fable_library_rust::Native_::getZero()))
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
            let v88: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v89: &str = option_env!("AUTOMATION").unwrap_or("");
            let v100: std::string::String = String::from(v89);
            let _run_target_args__v3: (Dice_contract::US1, Dice_contract::US2) = (
                Dice_contract::US1::US1_1,
                if (fable_library_rust::String_::fromString(v100)) != string("True") {
                    Dice_contract::US2::US2_1
                } else {
                    Dice_contract::US2::US2_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v173: Dice_contract::US2 = _run_target_args__v3.1.clone();
            let v172: Dice_contract::US1 = _run_target_args__v3.0.clone();
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
                    l0: MutCell::new(match &v172 {
                        Dice_contract::US1::US1_0(v172_0_0) => match &v172 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v173 {
                    Dice_contract::US2::US2_0(v173_0_0) => Some(match &v173 {
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
            let v17: () = {
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
            let v56: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
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
                    v56,
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
            let v551: u64 = near_sdk::env::block_timestamp();
            let v576: Dice_contract::US2 =
                defaultValue(Dice_contract::US2::US2_1, map(Dice_contract::method8(), v5));
            let v589: u64 = (match &v576 {
                Dice_contract::US2::US2_0(v576_0_0) => {
                    (v551)
                        - (match &v576 {
                            Dice_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v551,
            }) / 1000000000_u64;
            let v590: u64 = (v589) % 60_u64;
            let v592: u64 = ((v589) / 60_u64) % 60_u64;
            let v594: u64 = ((v589) / 3600_u64) % 24_u64;
            let v596: std::string::String = format!("{:02}:{:02}:{:02}", v594, v592, v590);
            fable_library_rust::String_::fromString(v596)
        }
        pub fn method12() -> string {
            string("")
        }
        pub fn closure6(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string, unitVar: ()) {
            let v4: string = append((v0_1.l0.get().clone()), (v1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method13() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v7: char = getCharAt(toLower(string("Debug")), 0_i32);
            let v9: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v24: () = {
                Dice_contract::closure6(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v131: &str = inline_colorization::color_bright_blue;
            let v142: &str = &*v30;
            let v166: &str = inline_colorization::color_reset;
            let v168: std::string::String = format!("{}{}{}", v131, v142, v166);
            fable_library_rust::String_::fromString(v168)
        }
        pub fn method15(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method14(
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
            let v11: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v25: () = {
                Dice_contract::closure6(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Dice_contract::closure6(v11.clone(), string("seed_excess_len"), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v11.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Dice_contract::closure6(v11.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v102: () = {
                Dice_contract::closure6(v11.clone(), string("; "), ());
                ()
            };
            let v121: () = {
                Dice_contract::closure6(v11.clone(), string("seed_excess"), ());
                ()
            };
            let v138: () = {
                Dice_contract::closure6(v11.clone(), string(" = "), ());
                ()
            };
            let v155: () = {
                Dice_contract::closure6(v11.clone(), v9, ());
                ()
            };
            let v174: () = {
                Dice_contract::closure6(v11.clone(), string(" }"), ());
                ()
            };
            let v180: string = v11.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice_contract.contribute_seed"),
                    )),
                    string(" / "),
                )),
                (v180),
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
            let v4: () = {
                Dice_contract::closure9(v0_1, ());
                ()
            };
            ()
        }
        pub fn method16(v0_1: string) {
            let v17: () = {
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
            let v41: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v60: () = {
                Dice_contract::closure7(patternInput.0.clone(), ());
                ()
            };
            let v83: string = if (v41.l0.get().clone()) == string("") {
                v0_1.clone()
            } else {
                if (v0_1.clone()) == string("") {
                    v41.l0.get().clone()
                } else {
                    append(
                        (append((v41.l0.get().clone()), string("\n"))),
                        (v0_1.clone()),
                    )
                }
            };
            let v94: &str = &*v83.clone();
            let v118 = v94.chars();
            let v120 = v118;
            let v122: Vec<char> = v120.collect::<Vec<_>>();
            let v124: Vec<Vec<char>> = v122
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v126: bool = true;
            let _vec_map: Vec<_> = v124
                .into_iter()
                .map(|x| {
                    //;
                    let v128: Vec<char> = x;
                    let v130: std::string::String = String::from_iter(v128);
                    let v132: bool = true;
                    v130
                })
                .collect::<Vec<_>>();
            let v134: Vec<std::string::String> = _vec_map;
            if if (v0_1.clone()) != string("") {
                (v134.clone().len() as i32) <= 1_i32
            } else {
                false
            } {
                v41.l0.set(v83);
                ()
            } else {
                v41.l0.set(string(""));
                {
                    let v159: bool = true;
                    v134.into_iter().for_each(|x| {
                        //;
                        let v161: std::string::String = x;
                        let v163: bool = true;
                        near_sdk::log!("{}", v161);
                        let v165: bool = true;
                        let v167: bool = true;
                    }); //;
                    ()
                }
            }
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure1(v0_1: i32, v1: Vec<u8>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v20: () = {
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
                let v46: Option<i64> = patternInput.5.clone();
                let v45: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v44: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v43: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v42: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v41: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method14(
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    Dice_contract::method7(v41, v42, v43, v44, v45, v46),
                    Dice_contract::method11(),
                    v0_1,
                    sprintf!("{:?}", v1),
                ))
            };
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method17() -> Func0<()> {
            Func0::new(move || Dice_contract::closure10((), ()))
        }
        pub fn method18() {
            let v16: () = {
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
            let v40: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v59: () = {
                Dice_contract::closure7(patternInput.0.clone(), ());
                ()
            };
            let v83: string = if (v40.l0.get().clone()) == string("") {
                string("")
            } else {
                v40.l0.get().clone()
            };
            let v94: &str = &*v83;
            let v118 = v94.chars();
            let v120 = v118;
            let v122: Vec<char> = v120.collect::<Vec<_>>();
            let v124: Vec<Vec<char>> = v122
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v126: bool = true;
            let _vec_map: Vec<_> = v124
                .into_iter()
                .map(|x| {
                    //;
                    let v128: Vec<char> = x;
                    let v130: std::string::String = String::from_iter(v128);
                    let v132: bool = true;
                    v130
                })
                .collect::<Vec<_>>();
            let v134: Vec<std::string::String> = _vec_map;
            v40.l0.set(string(""));
            {
                let v157: bool = true;
                v134.into_iter().for_each(|x| {
                    //;
                    let v159: std::string::String = x;
                    let v161: bool = true;
                    near_sdk::log!("{}", v159);
                    let v163: bool = true;
                    let v165: bool = true;
                }); //;
                ()
            }
            ((patternInput.1.clone()).l0.get().clone())(string(""))
        }
        pub fn closure11(v0_1: Func0<()>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v19: () = {
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
                let v58: string = Dice_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v59: string = Dice_contract::method11();
                Dice_contract::method18()
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
        pub fn method19() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure12((), v))
        }
        pub fn closure14(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method20(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: LrcPtr<Dice_contract::UH1> = Dice_contract::method20(
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
        pub fn method21(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v5: LrcPtr<Dice_contract::UH1> =
                        Dice_contract::method21((v0_1_0_1)(), v1.clone());
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
        pub fn method22(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    LrcPtr::new(Dice_contract::UH0::UH0_1(
                        v0_1_0_0.clone(),
                        Dice_contract::method22((v0_1_0_1)(), v1.clone()),
                    ))
                }
            }
        }
        pub fn method23(v0_1: LrcPtr<Dice_contract::UH0>, v1: List<u8>) -> List<u8> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice_contract::method23(
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
        pub fn method24(
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
            let v24: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v38: () = {
                Dice_contract::closure6(v24.clone(), string("{ "), ());
                ()
            };
            let v57: () = {
                Dice_contract::closure6(v24.clone(), string("max"), ());
                ()
            };
            let v76: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v24.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v115: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v134: () = {
                Dice_contract::closure6(v24.clone(), string("key"), ());
                ()
            };
            let v151: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v171: std::string::String = format!("{:#?}", v9);
            let v207: () = {
                Dice_contract::closure6(
                    v24.clone(),
                    fable_library_rust::String_::fromString(v171),
                    (),
                );
                ()
            };
            let v224: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v243: () = {
                Dice_contract::closure6(v24.clone(), string("proof"), ());
                ()
            };
            let v260: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v280: std::string::String = format!("{:#?}", v10);
            let v316: () = {
                Dice_contract::closure6(
                    v24.clone(),
                    fable_library_rust::String_::fromString(v280),
                    (),
                );
                ()
            };
            let v333: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v352: () = {
                Dice_contract::closure6(v24.clone(), string("block_timestamp"), ());
                ()
            };
            let v369: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v389: () = {
                Dice_contract::closure6(v24.clone(), sprintf!("{}", v11), ());
                ()
            };
            let v406: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v425: () = {
                Dice_contract::closure6(v24.clone(), string("block_height"), ());
                ()
            };
            let v442: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v462: () = {
                Dice_contract::closure6(v24.clone(), sprintf!("{}", v12), ());
                ()
            };
            let v479: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v498: () = {
                Dice_contract::closure6(v24.clone(), string("epoch_height"), ());
                ()
            };
            let v515: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v535: () = {
                Dice_contract::closure6(v24.clone(), sprintf!("{}", v13), ());
                ()
            };
            let v552: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v571: () = {
                Dice_contract::closure6(v24.clone(), string("account_balance"), ());
                ()
            };
            let v588: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v605: () = {
                Dice_contract::closure6(v24.clone(), v14, ());
                ()
            };
            let v622: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v641: () = {
                Dice_contract::closure6(v24.clone(), string("signer_account_id"), ());
                ()
            };
            let v658: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v678: std::string::String = format!("{:#?}", v15);
            let v714: () = {
                Dice_contract::closure6(
                    v24.clone(),
                    fable_library_rust::String_::fromString(v678),
                    (),
                );
                ()
            };
            let v731: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v750: () = {
                Dice_contract::closure6(v24.clone(), string("predecessor_account_id"), ());
                ()
            };
            let v767: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v787: std::string::String = format!("{:#?}", v16);
            let v823: () = {
                Dice_contract::closure6(
                    v24.clone(),
                    fable_library_rust::String_::fromString(v787),
                    (),
                );
                ()
            };
            let v840: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v859: () = {
                Dice_contract::closure6(v24.clone(), string("seed"), ());
                ()
            };
            let v876: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v893: () = {
                Dice_contract::closure6(v24.clone(), v17, ());
                ()
            };
            let v910: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v929: () = {
                Dice_contract::closure6(v24.clone(), string("seeds"), ());
                ()
            };
            let v946: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v963: () = {
                Dice_contract::closure6(v24.clone(), v18, ());
                ()
            };
            let v980: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v999: () = {
                Dice_contract::closure6(v24.clone(), string("entropy_len"), ());
                ()
            };
            let v1016: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v1036: std::string::String = format!("{:#?}", v19);
            let v1072: () = {
                Dice_contract::closure6(
                    v24.clone(),
                    fable_library_rust::String_::fromString(v1036),
                    (),
                );
                ()
            };
            let v1089: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v1108: () = {
                Dice_contract::closure6(v24.clone(), string("entropy"), ());
                ()
            };
            let v1125: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v1142: () = {
                Dice_contract::closure6(v24.clone(), v20, ());
                ()
            };
            let v1159: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v1178: () = {
                Dice_contract::closure6(v24.clone(), string("hash_u8"), ());
                ()
            };
            let v1195: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v1212: () = {
                Dice_contract::closure6(v24.clone(), v21, ());
                ()
            };
            let v1229: () = {
                Dice_contract::closure6(v24.clone(), string("; "), ());
                ()
            };
            let v1248: () = {
                Dice_contract::closure6(v24.clone(), string("rolls"), ());
                ()
            };
            let v1265: () = {
                Dice_contract::closure6(v24.clone(), string(" = "), ());
                ()
            };
            let v1282: () = {
                Dice_contract::closure6(v24.clone(), v22, ());
                ()
            };
            let v1301: () = {
                Dice_contract::closure6(v24.clone(), string(" }"), ());
                ()
            };
            let v1307: string = v24.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice_contract.generate_random_number"),
                    )),
                    string(" / "),
                )),
                (v1307),
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
                let v32: () = {
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
                let v58: Option<i64> = patternInput.5.clone();
                let v57: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v56: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v55: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v54: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v53: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                let v71: string = Dice_contract::method7(
                    v53.clone(),
                    v54.clone(),
                    v55.clone(),
                    v56.clone(),
                    v57.clone(),
                    v58.clone(),
                );
                let v72: string = Dice_contract::method11();
                let v74: string = sprintf!("{:?}", v8);
                let v78: std::string::String = v9.to_string();
                let v80: std::string::String = v10.to_string();
                let v82: string = sprintf!("{:?}", v4);
                let v86: string = sprintf!("{:?}", v0_1);
                let v90: usize = v11.clone().len();
                let v92: string = sprintf!("{:?}", v11);
                let v96: string = sprintf!("{:?}", v12);
                let v103: Array<u8> = toArray(Dice_contract::method23(v13, empty::<u8>()));
                Dice_contract::method16(Dice_contract::method24(
                    v53,
                    v54,
                    v55,
                    v56,
                    v57,
                    v58,
                    v71,
                    v72,
                    v3,
                    v1,
                    v2,
                    v7,
                    v6,
                    v5,
                    v74,
                    v78,
                    v80,
                    v82,
                    v86,
                    v90,
                    v92,
                    v96,
                    sprintf!("{:?}", v103.to_vec()),
                ))
            };
        }
        pub fn method25(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            '_method25: loop {
                break '_method25 (match v0_1.get().clone().as_ref() {
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
                        continue '_method25;
                    }
                });
            }
        }
        pub fn method26(
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
                        Dice_contract::method26(
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
                                Dice_contract::method27(v0_1.clone(), v5_0_1.clone()),
                            ))
                        }
                    };
                    v1.l0.set(Dice_contract::US6::US6_1(v12.clone()));
                    v12
                }
                Dice_contract::US6::US6_1(v2_1_0) => v2_1_0.clone(),
            }
        }
        pub fn method27(
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
        pub fn method29(
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
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v26: () = {
                Dice_contract::closure6(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Dice_contract::closure6(v12.clone(), string("max"), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v103: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v12.clone(), string("p"), ());
                ()
            };
            let v139: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v159: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v176: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v195: () = {
                Dice_contract::closure6(v12.clone(), string("n"), ());
                ()
            };
            let v212: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v232: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v10), ());
                ()
            };
            let v251: () = {
                Dice_contract::closure6(v12.clone(), string(" }"), ());
                ()
            };
            let v257: string = v12.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice.calculate_dice_count"),
                    )),
                    string(" / "),
                )),
                (v257),
            ))
        }
        pub fn closure19(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v21: () = {
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
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method29(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Dice_contract::method7(v42, v43, v44, v45, v46, v47),
                    Dice_contract::method11(),
                    v0_1,
                    v2,
                    v1,
                ))
            };
        }
        pub fn method28(v0_1: u64, v1: i8, v2: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1: MutCell<i8> = MutCell::new(v1);
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method28: loop {
                break '_method28 (if (v2.get().clone()) < (v0_1.get().clone()) {
                    let v4: u64 = (v2.get().clone()) * 6_u64;
                    if (v4) > (v2.get().clone()) {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_temp: i8 = (v1.get().clone()) + 1_i8;
                        let v2_temp: u64 = v4;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        continue '_method28;
                    } else {
                        let v70: () = {
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
                    let v194: () = {
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
        pub fn method32(
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
            let v13: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v27: () = {
                Dice_contract::closure6(v13.clone(), string("{ "), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v13.clone(), string("current_index"), ());
                ()
            };
            let v65: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v85: () = {
                Dice_contract::closure6(v13.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v13.clone(), string("; "), ());
                ()
            };
            let v123: () = {
                Dice_contract::closure6(v13.clone(), string("acc"), ());
                ()
            };
            let v140: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v160: () = {
                Dice_contract::closure6(v13.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v177: () = {
                Dice_contract::closure6(v13.clone(), string("; "), ());
                ()
            };
            let v196: () = {
                Dice_contract::closure6(v13.clone(), string("len"), ());
                ()
            };
            let v213: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v233: () = {
                Dice_contract::closure6(v13.clone(), sprintf!("{}", v10), ());
                ()
            };
            let v250: () = {
                Dice_contract::closure6(v13.clone(), string("; "), ());
                ()
            };
            let v269: () = {
                Dice_contract::closure6(v13.clone(), string("last_item"), ());
                ()
            };
            let v286: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v303: () = {
                Dice_contract::closure6(v13.clone(), v11, ());
                ()
            };
            let v322: () = {
                Dice_contract::closure6(v13.clone(), string(" }"), ());
                ()
            };
            let v328: string = v13.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice.create_sequential_roller / roll"),
                    )),
                    string(" / "),
                )),
                (v328),
            ))
        }
        pub fn closure20(v0_1: i64, v1: i64, v2: i64, v3: Option<u8>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v22: () = {
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
                let v48: Option<i64> = patternInput.5.clone();
                let v47: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v46: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v45: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v44: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v43: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method32(
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    v48.clone(),
                    Dice_contract::method7(v43, v44, v45, v46, v47, v48),
                    Dice_contract::method11(),
                    v0_1,
                    v1,
                    v2,
                    sprintf!("{:?}", v3),
                ))
            };
        }
        pub fn method33(v0_1: i64, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US7 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method33: loop {
                break '_method33 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US7::US7_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice_contract::US7::US7_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method33;
                        }
                    }
                });
            }
        }
        pub fn method34(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            let v9: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v10: string = v9.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice.create_sequential_roller / roll / None"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) {
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
                let v44: Option<i64> = patternInput.5.clone();
                let v43: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v42: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v41: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v40: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v39: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method34(
                    v39.clone(),
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    Dice_contract::method7(v39, v40, v41, v42, v43, v44),
                    Dice_contract::method11(),
                ))
            };
        }
        pub fn method31(
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
            '_method31: loop {
                break '_method31 ({
                    let v5: i64 = v1.l0.get().clone();
                    let v6: i64 = v2.l0.get().clone();
                    let v7: i64 = v3.l0.get().clone();
                    let v8: Dice_contract::US7 = v4.l0.get().clone();
                    let v86: () = {
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
                    let v151: LrcPtr<Dice_contract::UH1> = v0_1();
                    let v153: Dice_contract::US7 =
                        Dice_contract::method33(v1.l0.get().clone(), v151);
                    match &v153 {
                        Dice_contract::US7::US7_0(v153_0_0) => {
                            let v154: u8 = match &v153 {
                                Dice_contract::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v156: i64 = (v1.l0.get().clone()) + 1_i64;
                            v1.l0.set(v156);
                            v4.l0.set(Dice_contract::US7::US7_0(v154));
                            v154
                        }
                        _ => {
                            let v220: () = {
                                Dice_contract::closure21((), ());
                                ()
                            };
                            if (v3.l0.get().clone()) == -1_i64 {
                                let v283: i64 = v1.l0.get().clone();
                                v3.l0.set(v283);
                                ()
                            }
                            {
                                let v289: i64 = if (v2.l0.get().clone()) >= (v3.l0.get().clone()) {
                                    1_i64
                                } else {
                                    (v2.l0.get().clone()) + 1_i64
                                };
                                v2.l0.set(v289);
                                {
                                    let v291: i64 = (v2.l0.get().clone()) - 1_i64;
                                    v1.l0.set(v291);
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
                                        continue '_method31;
                                    }
                                }
                            }
                        }
                    }
                });
            }
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
            v8: i8,
            v9: u64,
            v10: u64,
        ) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v26: () = {
                Dice_contract::closure6(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Dice_contract::closure6(v12.clone(), string("power"), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v103: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v12.clone(), string("acc"), ());
                ()
            };
            let v139: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v159: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v176: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v195: () = {
                Dice_contract::closure6(v12.clone(), string("result"), ());
                ()
            };
            let v212: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v232: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v10), ());
                ()
            };
            let v251: () = {
                Dice_contract::closure6(v12.clone(), string(" }"), ());
                ()
            };
            let v257: string = v12.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (v257),
            ))
        }
        pub fn closure22(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v21: () = {
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
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method36(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Dice_contract::method7(v42, v43, v44, v45, v46, v47),
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
        pub fn method37(v0_1: i8, v1: LrcPtr<Dice_contract::UH2>) -> Dice_contract::US9 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH2>> = MutCell::new(v1.clone());
            '_method37: loop {
                break '_method37 (match v1.get().clone().as_ref() {
                    Dice_contract::UH2::UH2_1 => Dice_contract::US9::US9_1,
                    Dice_contract::UH2::UH2_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice_contract::US9::US9_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH2> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method37;
                        }
                    }
                });
            }
        }
        pub fn method38(
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
            let v13: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v27: () = {
                Dice_contract::closure6(v13.clone(), string("{ "), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v13.clone(), string("power"), ());
                ()
            };
            let v65: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v85: () = {
                Dice_contract::closure6(v13.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v13.clone(), string("; "), ());
                ()
            };
            let v123: () = {
                Dice_contract::closure6(v13.clone(), string("acc"), ());
                ()
            };
            let v140: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v160: () = {
                Dice_contract::closure6(v13.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v177: () = {
                Dice_contract::closure6(v13.clone(), string("; "), ());
                ()
            };
            let v196: () = {
                Dice_contract::closure6(v13.clone(), string("roll"), ());
                ()
            };
            let v213: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v233: () = {
                Dice_contract::closure6(v13.clone(), sprintf!("{}", v10), ());
                ()
            };
            let v250: () = {
                Dice_contract::closure6(v13.clone(), string("; "), ());
                ()
            };
            let v269: () = {
                Dice_contract::closure6(v13.clone(), string("value"), ());
                ()
            };
            let v286: () = {
                Dice_contract::closure6(v13.clone(), string(" = "), ());
                ()
            };
            let v306: () = {
                Dice_contract::closure6(v13.clone(), sprintf!("{}", v11), ());
                ()
            };
            let v325: () = {
                Dice_contract::closure6(v13.clone(), string(" }"), ());
                ()
            };
            let v331: string = v13.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (v331),
            ))
        }
        pub fn closure87(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v22: () = {
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
                let v48: Option<i64> = patternInput.5.clone();
                let v47: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v46: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v45: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v44: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v43: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method38(
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    v48.clone(),
                    Dice_contract::method7(v43, v44, v45, v46, v47, v48),
                    Dice_contract::method11(),
                    v1,
                    v0_1,
                    v2,
                    v3,
                ))
            };
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
            v8: i8,
            v9: u64,
            v10: u8,
        ) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v26: () = {
                Dice_contract::closure6(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Dice_contract::closure6(v12.clone(), string("power"), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v103: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v12.clone(), string("acc"), ());
                ()
            };
            let v139: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v159: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v176: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v195: () = {
                Dice_contract::closure6(v12.clone(), string("roll"), ());
                ()
            };
            let v212: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v232: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v10), ());
                ()
            };
            let v251: () = {
                Dice_contract::closure6(v12.clone(), string(" }"), ());
                ()
            };
            let v257: string = v12.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (v257),
            ))
        }
        pub fn closure88(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v21: () = {
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
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method39(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Dice_contract::method7(v42, v43, v44, v45, v46, v47),
                    Dice_contract::method11(),
                    v1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method35(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US8 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method35: loop {
                break '_method35 (if (v0_1.get().clone()) < 0_i8 {
                    let v4: u64 = (v2.get().clone()) + 1_u64;
                    let v67: () = {
                        Dice_contract::closure22(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US8::US8_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US8::US8_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v131: LrcPtr<Dice_contract::UH0> =
                                match v1.get().clone().as_ref() {
                                    Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v130: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v130) > 1_u8 {
                                let v136: Dice_contract::US9 = Dice_contract::method37(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure23((), ())),
                                    )),
                                );
                                let v143: u64 = (((v130) - 1_u8) as u64)
                                    * (match &v136 {
                                        Dice_contract::US9::US9_0(v136_0_0) => match &v136 {
                                            Dice_contract::US9::US9_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v206: () = {
                                    Dice_contract::closure87(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v130,
                                        v143,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v131;
                                    let v2_temp: u64 = (v2.get().clone()) + (v143);
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method35;
                                }
                            } else {
                                let v332: () = {
                                    Dice_contract::closure88(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v130,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v131.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method35;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method40(
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
                    Dice_contract::method31(
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                    ),
                    Dice_contract::method40(v0_1, v1, v2, v3, v4, v5, (v6) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice_contract::UH0::UH0_0)
            }
        }
        pub fn method41(
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
            '_method41: loop {
                break '_method41 ({
                    let v8: i8 = (v6.get().clone()) + 1_i8;
                    if (v6.get().clone()) < (v8) {
                        Dice_contract::method30(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            LrcPtr::new(Dice_contract::UH0::UH0_1(
                                Dice_contract::method31(
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
                            Dice_contract::method35(v6.get().clone(), v7.get().clone(), 0_u64);
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
                                let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method40(
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
                                continue '_method41;
                            }
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                            let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                            let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                            let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                            let v5_temp: u64 = v5.get().clone();
                            let v6_temp: i8 = v6.get().clone();
                            let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method40(
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
                            continue '_method41;
                        }
                    }
                });
            }
        }
        pub fn method30(
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
            '_method30: loop {
                break '_method30 (if (v8.get().clone()) < ((v6.get().clone()) + 1_i8) {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                    let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                    let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                    let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                    let v5_temp: u64 = v5.get().clone();
                    let v6_temp: i8 = v6.get().clone();
                    let v7_temp: LrcPtr<Dice_contract::UH0> =
                        LrcPtr::new(Dice_contract::UH0::UH0_1(
                            Dice_contract::method31(
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
                    continue '_method30;
                } else {
                    let v16: Dice_contract::US8 =
                        Dice_contract::method35(v6.get().clone(), v7.get().clone(), 0_u64);
                    if let Dice_contract::US8::US8_0(v16_0_0, v16_0_1) = &v16 {
                        let v17: u64 = v16_0_0.clone();
                        if (v17) <= (v5.get().clone()) {
                            v17
                        } else {
                            Dice_contract::method41(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                                Dice_contract::method40(
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
                        Dice_contract::method41(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            Dice_contract::method40(
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
        pub fn method42() -> Func0<()> {
            Func0::new(move || Dice_contract::closure10((), ()))
        }
        pub fn closure89(v0_1: Func0<()>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v19: () = {
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
                let v58: string = Dice_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v59: string = Dice_contract::method11();
                Dice_contract::method18()
            };
        }
        pub fn method43(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method43: loop {
                break '_method43 (match v0_1.get().clone().as_ref() {
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
                        continue '_method43;
                    }
                });
            }
        }
        pub fn method44(
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
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            let v26: () = {
                Dice_contract::closure6(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Dice_contract::closure6(v12.clone(), string("max"), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Dice_contract::closure6(v12.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v103: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v12.clone(), string("rolls"), ());
                ()
            };
            let v139: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v156: () = {
                Dice_contract::closure6(v12.clone(), v9, ());
                ()
            };
            let v173: () = {
                Dice_contract::closure6(v12.clone(), string("; "), ());
                ()
            };
            let v192: () = {
                Dice_contract::closure6(v12.clone(), string("result"), ());
                ()
            };
            let v209: () = {
                Dice_contract::closure6(v12.clone(), string(" = "), ());
                ()
            };
            let v226: () = {
                Dice_contract::closure6(v12.clone(), v10, ());
                ()
            };
            let v245: () = {
                Dice_contract::closure6(v12.clone(), string(" }"), ());
                ()
            };
            let v251: string = v12.l0.get().clone();
            Dice_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice_contract.roll_within_bounds"),
                    )),
                    string(" / "),
                )),
                (v251),
            ))
        }
        pub fn closure90(v0_1: u64, v1: Vec<u8>, v2: Option<u64>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v21: () = {
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
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Dice_contract::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Dice_contract::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Dice_contract::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Dice_contract::Mut0> = patternInput.0.clone();
                Dice_contract::method16(Dice_contract::method44(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Dice_contract::method7(v42, v43, v44, v45, v46, v47),
                    Dice_contract::method11(),
                    v0_1,
                    sprintf!("{:?}", v1),
                    sprintf!("{:?}", v2),
                ))
            };
        }
        pub fn method45() -> Func0<()> {
            Func0::new(move || Dice_contract::closure10((), ()))
        }
        pub fn closure91(v0_1: Func0<()>, unitVar: ()) {
            if Dice_contract::method0(Dice_contract::US0::US0_1) {
                let v19: () = {
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
                let v58: string = Dice_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v59: string = Dice_contract::method11();
                Dice_contract::method18()
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
                let v19: */
            (u32, near_sdk::store::vec::Vector<u8>), /* =
                                                         fable_library_rust::Native_::getZero::<()>();
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
                    let v33: bool = true; /*;
                    let v35: */
                    () /* = fable_library_rust::Native_::getZero();
                    let v39: bool = true; */;
                    let v41: string = string("b\"seeds\"");
                    let v42: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (2_u32, near_sdk::store::vec::Vector::new(v42));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
        {
        let v49: bool =
        true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
        let v51: bool =
        true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed(&mut self, seed: Vec<u8>) {
                //;
                {
                    let v56: &mut near_sdk::store::vec::Vector<u8> = &mut self.0.1;
                    let v58: Vec<u8> = seed;
                    let v60: bool = true;
                    v56.extend(v58); //;
                    let v93: i32 = (v56.len() as i32) - (100_i32);
                    if (v93) > 0_i32 {
                        let v163: () = {
                            Dice_contract::closure1(
                                v93,
                                v56.drain(0..v93 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v290: () = {
                            Dice_contract::closure11(Dice_contract::method17(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v355: bool =
        true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
        let v357: bool =
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
        let v365: bool =
        true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
        let v367: bool =
        true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v372: std::string::String = key;
                    let v374: std::string::String = proof;
                    let v376: u64 = max;
                    let v378: &mut near_sdk::store::vec::Vector<u8> = &mut self.0.1;
                    let v380: Vec<u8> = near_sdk::env::random_seed();
                    let v382: u64 = near_sdk::env::epoch_height();
                    let v384: u64 = near_sdk::env::block_height();
                    let v386: u64 = near_sdk::env::block_timestamp();
                    let v388: near_token::NearToken = near_sdk::env::account_balance();
                    let v390: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v392: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v394: &near_sdk::store::vec::Vector<u8> = &*v378;
                    let v396: Vec<u8> = v394.iter().map(|x| *x).collect::<Vec<_>>();
                    let v398: _ = v382.to_le_bytes();
                    let v400: Vec<u8> = v398.to_vec();
                    let v402: _ = v384.to_le_bytes();
                    let v404: Vec<u8> = v402.to_vec();
                    let v406: _ = v386.to_le_bytes();
                    let v408: Vec<u8> = v406.to_vec();
                    let v410: u128 = v388.clone().as_yoctonear();
                    let v412: _ = v410.to_le_bytes();
                    let v414: Vec<u8> = v412.to_vec();
                    let v416: &[u8] = v390.as_bytes();
                    let v418: Vec<u8> = v416.to_vec();
                    let v420: &[u8] = v392.as_bytes();
                    let v427: Array<Vec<u8>> = new_array(&[
                        v380.clone(),
                        v396,
                        v400,
                        v404,
                        v408,
                        v414,
                        v418,
                        v420.to_vec(),
                        v374.clone().into_bytes(),
                        v372.clone().into_bytes(),
                    ]);
                    let v429: Vec<Vec<u8>> = v427.to_vec();
                    let v431: Vec<u8> = v429.concat();
                    let v433: Vec<u8> = near_sdk::env::keccak512(&v431.clone());
                    let v435: bool = true;
                    v378.extend(v433.clone()); //;
                    let v468: i32 = (v378.len() as i32) - (100_i32);
                    if (v468) > 0_i32 {
                        let v538: () = {
                            Dice_contract::closure1(
                                v468,
                                v378.drain(0..v468 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v665: () = {
                            Dice_contract::closure11(Dice_contract::method17(), ());
                            ()
                        };
                        let v728: List<u8> = ofArray(fable_library_rust::NativeArray_::array_from(
                            v433.clone().clone(),
                        ));
                        let v775: LrcPtr<Dice_contract::UH0> = Dice_contract::method22(
                            Dice_contract::method21(
                                Dice_contract::method20(
                                    foldBack(
                                        Func2::new(
                                            move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                                                (Dice_contract::method19())(b0)(b1)
                                            },
                                        ),
                                        v728,
                                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                                    ),
                                    LrcPtr::new(Dice_contract::UH1::UH1_1),
                                ),
                                LrcPtr::new(Dice_contract::UH1::UH1_1),
                            ),
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                        );
                        let v877: () = {
                            Dice_contract::closure16(
                                v378,
                                v372,
                                v374,
                                v376,
                                v380,
                                v382,
                                v384,
                                v386,
                                v388,
                                v390,
                                v392,
                                v431,
                                v433,
                                v775.clone(),
                                (),
                            );
                            ()
                        };
                        let v981: LrcPtr<Dice_contract::UH1> = Dice_contract::method20(
                            Dice_contract::method26(
                                v775.clone(),
                                Dice_contract::method25(
                                    v775,
                                    LrcPtr::new(Dice_contract::UH0::UH0_0),
                                ),
                            ),
                            LrcPtr::new(Dice_contract::UH1::UH1_1),
                        );
                        let v997: u64 = Dice_contract::method30(
                            Dice_contract::method27(
                                v981.clone(),
                                Func0::new({
                                    let v981 = v981.clone();
                                    move || Dice_contract::closure17(v981.clone(), ())
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
                            v376,
                            (if (v376) == 1_u64 {
                                1_i8
                            } else {
                                Dice_contract::method28(v376, 0_i8, 1_u64)
                            }) - 1_i8,
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                            0_i8,
                        );
                        let v1060: () = {
                            Dice_contract::closure89(Dice_contract::method42(), ());
                            ()
                        };
                        v997 //;
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v1126: bool =
        true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy;
        let v1128: bool =
        true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v1133: u64 = max;
                    let v1135: Vec<u8> = rolls;
                    let v1139: List<u8> = ofArray(fable_library_rust::NativeArray_::array_from(
                        v1135.clone().clone(),
                    ));
                    let v1152: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method19())(b0)(b1)
                        }),
                        v1139,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v1185: Dice_contract::US8 = Dice_contract::method35(
                        (Dice_contract::method43(v1152.clone(), 0_i8)) - 1_i8,
                        v1152,
                        0_u64,
                    );
                    let v1195: Dice_contract::US9 =
                        if let Dice_contract::US8::US8_0(v1185_0_0, v1185_0_1) = &v1185 {
                            let v1186: u64 = v1185_0_0.clone();
                            if if (v1186) >= 1_u64 {
                                (v1186) <= (v1133)
                            } else {
                                false
                            } {
                                Dice_contract::US9::US9_0(v1186)
                            } else {
                                Dice_contract::US9::US9_1
                            }
                        } else {
                            Dice_contract::US9::US9_1
                        };
                    let v1206: Option<u64> = match &v1195 {
                        Dice_contract::US9::US9_0(v1195_0_0) => Some(match &v1195 {
                            Dice_contract::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v1277: () = {
                        Dice_contract::closure90(v1133, v1135, v1206.clone(), ());
                        ()
                    };
                    let v1408: () = {
                        Dice_contract::closure91(Dice_contract::method45(), ());
                        ()
                    };
                    v1206 //;
                } //;
            } //;
        } /* c;
        {
        let v1473: bool =
        true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy;
        let v1475: bool =
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
        let v1488:
        bool =
        true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy;
        let v1490:
        bool =
        true; */
 // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v1494: bool = true;
            {
                (); // ?? / i': 1uy / n: 12uy;
                let v1496: bool = true;
                {
                    (); // ?? / i': 2uy / n: 12uy;
                    let v1498: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 12uy;
                        let v1500: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 12uy;
                            let v1502: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 12uy;
                                let v1504: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 12uy;
                                    let v1506: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 12uy;
                                        let v1508: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 12uy;
                                            let v1510: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 12uy;
                                                let v1512: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 12uy;
                                                    let v1514: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 12uy;
                                                        let v1516: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 12uy;
                                                            let v1518: bool = true;
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
pub use module_aadd22c3::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/async__contract.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/common_contract.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/crypto_contract.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/date_time_contract.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/file_system_contract.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/lib_contract.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/networking_contract.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/platform_contract.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/runtime_contract.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/sm_contract.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/threading_contract.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/trace_contract.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../deps/polyglot/lib/fsharp/Common_contract.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
