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
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
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
            US4_6(Dice_contract::US3),
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
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ),
            US6_1,
        }
        impl core::fmt::Display for US6 {
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
        pub enum US7 {
            US7_0(Func0<LrcPtr<Dice_contract::UH1>>),
            US7_1(LrcPtr<Dice_contract::UH1>),
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut5 {
            pub l0: MutCell<Dice_contract::US7>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(u8),
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<Dice_contract::US8>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0(u64, LrcPtr<Dice_contract::UH0>),
            US9_1,
        }
        impl core::fmt::Display for US9 {
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
        pub enum US10 {
            US10_0(u64),
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method3(v0_1: string) -> string {
            v0_1
        }
        pub fn method4() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Dice_contract::US5 {
            Dice_contract::US5::US5_0(v0_1)
        }
        pub fn method5() -> Func1<string, Dice_contract::US5> {
            Func1::new(move |v: string| Dice_contract::closure3((), v))
        }
        pub fn method2(v0_1: string) -> string {
            panic!(
                "{}",
                sprintf!(
                    "env.get_environment_variable / target: {} / var: {}",
                    Dice_contract::US4::US4_4(Dice_contract::US3::US3_2),
                    v0_1
                ),
            )
        }
        pub fn method1() -> (Dice_contract::US1, Dice_contract::US2) {
            let v1: string = Dice_contract::method2(string("TRACE_LEVEL"));
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
                if (Dice_contract::method2(string("AUTOMATION"))) != string("True") {
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
            let v94: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v95: &str = option_env!("AUTOMATION").unwrap_or("");
            let v106: std::string::String = String::from(v95);
            let _run_target_args__v3: (Dice_contract::US1, Dice_contract::US2) = (
                Dice_contract::US1::US1_1,
                if (fable_library_rust::String_::fromString(v106)) != string("True") {
                    Dice_contract::US2::US2_1
                } else {
                    Dice_contract::US2::US2_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v185: Dice_contract::US2 = _run_target_args__v3.1.clone();
            let v184: Dice_contract::US1 = _run_target_args__v3.0.clone();
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
                    l0: MutCell::new(match &v184 {
                        Dice_contract::US1::US1_0(v184_0_0) => match &v184 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v185 {
                    Dice_contract::US2::US2_0(v185_0_0) => Some(match &v185 {
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
        pub fn closure5(unitVar: (), v0_1: i64) -> Dice_contract::US2 {
            Dice_contract::US2::US2_0(v0_1)
        }
        pub fn method7() -> Func1<i64, Dice_contract::US2> {
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
            let v638: u64 = near_sdk::env::block_timestamp();
            let v663: Dice_contract::US2 =
                defaultValue(Dice_contract::US2::US2_1, map(Dice_contract::method7(), v5));
            let v676: u64 = (match &v663 {
                Dice_contract::US2::US2_0(v663_0_0) => {
                    (v638)
                        - (match &v663 {
                            Dice_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v638,
            }) / 1000000000_u64;
            let v677: u64 = (v676) % 60_u64;
            let v679: u64 = ((v676) / 60_u64) % 60_u64;
            let v681: u64 = ((v676) / 3600_u64) % 24_u64;
            let v683: std::string::String = format!("{:02}:{:02}:{:02}", v681, v679, v677);
            fable_library_rust::String_::fromString(v683)
        }
        pub fn method12() -> string {
            string("")
        }
        pub fn method13(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string) {
            let v4: string = append((v0_1.l0.get().clone()), (v1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method11(v0_1: char) -> string {
            let v3: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v3.clone(), sprintf!("{}", v0_1));
            v3.l0.get().clone()
        }
        pub fn method10() -> string {
            let v83: &str = inline_colorization::color_bright_blue;
            let v94: std::string::String = String::from(v83);
            let v139: string = append(
                (fable_library_rust::String_::fromString(v94)),
                (Dice_contract::method11(getCharAt(toLower(string("Debug")), 0_i32))),
            );
            let v225: &str = inline_colorization::color_reset;
            let v236: std::string::String = String::from(v225);
            append((v139), (fable_library_rust::String_::fromString(v236)))
        }
        pub fn method15(v0_1: i32, v1: string) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v4.clone(), string("{ "));
            Dice_contract::method13(v4.clone(), string("seed_excess_len"));
            Dice_contract::method13(v4.clone(), string(" = "));
            Dice_contract::method13(v4.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v4.clone(), string("; "));
            Dice_contract::method13(v4.clone(), string("seed_excess"));
            Dice_contract::method13(v4.clone(), string(" = "));
            Dice_contract::method13(v4.clone(), v1);
            Dice_contract::method13(v4.clone(), string(" }"));
            v4.l0.get().clone()
        }
        pub fn method16(v0_1: string) -> string {
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
            let v10: string = Dice_contract::method15(v8, v9);
            Dice_contract::method16(append(
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
                (v10),
            ))
        }
        pub fn closure6(v0_1: LrcPtr<Dice_contract::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure8(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure7(unitVar: (), v0_1: string) {
            let v4: () = {
                Dice_contract::closure8(v0_1, ());
                ()
            };
            ()
        }
        pub fn closure1(v0_1: i32, v1: Vec<u8>, unitVar: ()) {
            fn v17() {
                Dice_contract::closure2((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v341: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v59,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v82: () = {
                        v17();
                        ()
                    };
                    let patternInput_1: (
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
                    let v110: Option<i64> = patternInput_1.5.clone();
                    let v109: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v108: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v107: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v106: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v105: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v129: string = Dice_contract::method14(
                        v105.clone(),
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        v110.clone(),
                        Dice_contract::method6(v105, v106, v107, v108, v109, v110),
                        Dice_contract::method10(),
                        v0_1,
                        sprintf!("{:?}", v1),
                    );
                    let v145: () = {
                        v17();
                        ()
                    };
                    let patternInput_2: (
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
                    let v171: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v169: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v168: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v190: () = {
                        Dice_contract::closure6(v168.clone(), ());
                        ()
                    };
                    let v213: string = if (v171.l0.get().clone()) == string("") {
                        v129.clone()
                    } else {
                        if (v129.clone()) == string("") {
                            v171.l0.get().clone()
                        } else {
                            append(
                                (append((v171.l0.get().clone()), string("\n"))),
                                (v129.clone()),
                            )
                        }
                    };
                    let v224: &str = &*v213.clone();
                    let v251 = v224.chars();
                    let v253 = v251;
                    let v255: Vec<char> = v253.collect::<Vec<_>>();
                    let v257: Vec<Vec<char>> = v255
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v259: bool = true;
                    let _vec_map: Vec<_> = v257
                        .into_iter()
                        .map(|x| {
                            //;
                            let v261: Vec<char> = x;
                            let v263: std::string::String = String::from_iter(v261);
                            let v265: bool = true;
                            v263
                        })
                        .collect::<Vec<_>>();
                    let v267: Vec<std::string::String> = _vec_map;
                    if if (v129.clone()) != string("") {
                        (v267.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v171.l0.set(v213);
                        ()
                    } else {
                        v171.l0.set(string(""));
                        {
                            let v330: bool = true;
                            v267.into_iter().for_each(|x| {
                                //;
                                let v332: std::string::String = x;
                                let v334: bool = true;
                                near_sdk::log!("{}", v332);
                                let v336: bool = true;
                                let v338: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v169.l0.get().clone())(v129);
                    Dice_contract::US6::US6_0(
                        v168,
                        v169,
                        patternInput_2.2.clone(),
                        v171,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn closure9(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method17() -> Func0<()> {
            Func0::new(move || Dice_contract::closure9((), ()))
        }
        pub fn closure10(v0_1: Func0<()>, unitVar: ()) {
            fn v16() {
                Dice_contract::closure2((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v334: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v58,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v81: () = {
                        v16();
                        ()
                    };
                    let patternInput_1: (
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
                    let v122: string = Dice_contract::method6(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v123: string = Dice_contract::method10();
                    let v139: () = {
                        v16();
                        ()
                    };
                    let patternInput_2: (
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
                    let v165: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v163: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v162: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v184: () = {
                        Dice_contract::closure6(v162.clone(), ());
                        ()
                    };
                    let v208: string = if (v165.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v165.l0.get().clone()
                    };
                    let v219: &str = &*v208;
                    let v246 = v219.chars();
                    let v248 = v246;
                    let v250: Vec<char> = v248.collect::<Vec<_>>();
                    let v252: Vec<Vec<char>> = v250
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v254: bool = true;
                    let _vec_map: Vec<_> = v252
                        .into_iter()
                        .map(|x| {
                            //;
                            let v256: Vec<char> = x;
                            let v258: std::string::String = String::from_iter(v256);
                            let v260: bool = true;
                            v258
                        })
                        .collect::<Vec<_>>();
                    let v262: Vec<std::string::String> = _vec_map;
                    v165.l0.set(string(""));
                    {
                        let v323: bool = true;
                        v262.into_iter().for_each(|x| {
                            //;
                            let v325: std::string::String = x;
                            let v327: bool = true;
                            near_sdk::log!("{}", v325);
                            let v329: bool = true;
                            let v331: bool = true;
                        }); //;
                        ()
                    }
                    (v163.l0.get().clone())(string(""));
                    Dice_contract::US6::US6_0(
                        v162,
                        v163,
                        patternInput_2.2.clone(),
                        v165,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn closure12(v0_1: u8, v1: LrcPtr<Dice_contract::UH0>) -> LrcPtr<Dice_contract::UH0> {
            LrcPtr::new(Dice_contract::UH0::UH0_1(v0_1, v1))
        }
        pub fn closure11(
            unitVar: (),
            v0_1: u8,
        ) -> Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_contract::UH0>| Dice_contract::closure12(v0_1, v)
            })
        }
        pub fn method18() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure11((), v))
        }
        pub fn closure13(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method19(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: LrcPtr<Dice_contract::UH1> = Dice_contract::method19(
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
                            move || Dice_contract::closure13(v4.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure14(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method20(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v5: LrcPtr<Dice_contract::UH1> =
                        Dice_contract::method20((v0_1_0_1)(), v1.clone());
                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                        (((((v0_1_0_0.clone() as i64) - 1_i64) + 6_i64) % 6_i64) + 1_i64) as u8,
                        Func0::new({
                            let v5 = v5.clone();
                            move || Dice_contract::closure14(v5.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn method21(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    LrcPtr::new(Dice_contract::UH0::UH0_1(
                        v0_1_0_0.clone(),
                        Dice_contract::method21((v0_1_0_1)(), v1.clone()),
                    ))
                }
            }
        }
        pub fn method22(v0_1: LrcPtr<Dice_contract::UH0>, v1: List<u8>) -> List<u8> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice_contract::method22(
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
            let v17: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v17.clone(), string("{ "));
            Dice_contract::method13(v17.clone(), string("max"));
            Dice_contract::method13(v17.clone(), string(" = "));
            Dice_contract::method13(v17.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v17.clone(), string("; "));
            Dice_contract::method13(v17.clone(), string("key"));
            Dice_contract::method13(v17.clone(), string(" = "));
            {
                let v141: std::string::String = format!("{:#?}", v1);
                Dice_contract::method13(v17.clone(), fable_library_rust::String_::fromString(v141));
                Dice_contract::method13(v17.clone(), string("; "));
                Dice_contract::method13(v17.clone(), string("proof"));
                Dice_contract::method13(v17.clone(), string(" = "));
                {
                    let v240: std::string::String = format!("{:#?}", v2);
                    Dice_contract::method13(
                        v17.clone(),
                        fable_library_rust::String_::fromString(v240),
                    );
                    Dice_contract::method13(v17.clone(), string("; "));
                    Dice_contract::method13(v17.clone(), string("block_timestamp"));
                    Dice_contract::method13(v17.clone(), string(" = "));
                    Dice_contract::method13(v17.clone(), sprintf!("{}", v3));
                    Dice_contract::method13(v17.clone(), string("; "));
                    Dice_contract::method13(v17.clone(), string("block_height"));
                    Dice_contract::method13(v17.clone(), string(" = "));
                    Dice_contract::method13(v17.clone(), sprintf!("{}", v4));
                    Dice_contract::method13(v17.clone(), string("; "));
                    Dice_contract::method13(v17.clone(), string("epoch_height"));
                    Dice_contract::method13(v17.clone(), string(" = "));
                    Dice_contract::method13(v17.clone(), sprintf!("{}", v5));
                    Dice_contract::method13(v17.clone(), string("; "));
                    Dice_contract::method13(v17.clone(), string("account_balance"));
                    Dice_contract::method13(v17.clone(), string(" = "));
                    Dice_contract::method13(v17.clone(), v6);
                    Dice_contract::method13(v17.clone(), string("; "));
                    Dice_contract::method13(v17.clone(), string("signer_account_id"));
                    Dice_contract::method13(v17.clone(), string(" = "));
                    {
                        let v585: std::string::String = format!("{:#?}", v7);
                        Dice_contract::method13(
                            v17.clone(),
                            fable_library_rust::String_::fromString(v585),
                        );
                        Dice_contract::method13(v17.clone(), string("; "));
                        Dice_contract::method13(v17.clone(), string("predecessor_account_id"));
                        Dice_contract::method13(v17.clone(), string(" = "));
                        {
                            let v684: std::string::String = format!("{:#?}", v8);
                            Dice_contract::method13(
                                v17.clone(),
                                fable_library_rust::String_::fromString(v684),
                            );
                            Dice_contract::method13(v17.clone(), string("; "));
                            Dice_contract::method13(v17.clone(), string("seed"));
                            Dice_contract::method13(v17.clone(), string(" = "));
                            Dice_contract::method13(v17.clone(), v9);
                            Dice_contract::method13(v17.clone(), string("; "));
                            Dice_contract::method13(v17.clone(), string("seeds"));
                            Dice_contract::method13(v17.clone(), string(" = "));
                            Dice_contract::method13(v17.clone(), v10);
                            Dice_contract::method13(v17.clone(), string("; "));
                            Dice_contract::method13(v17.clone(), string("entropy_len"));
                            Dice_contract::method13(v17.clone(), string(" = "));
                            {
                                let v897: std::string::String = format!("{:#?}", v11);
                                Dice_contract::method13(
                                    v17.clone(),
                                    fable_library_rust::String_::fromString(v897),
                                );
                                Dice_contract::method13(v17.clone(), string("; "));
                                Dice_contract::method13(v17.clone(), string("entropy"));
                                Dice_contract::method13(v17.clone(), string(" = "));
                                Dice_contract::method13(v17.clone(), v12);
                                Dice_contract::method13(v17.clone(), string("; "));
                                Dice_contract::method13(v17.clone(), string("hash_u8"));
                                Dice_contract::method13(v17.clone(), string(" = "));
                                Dice_contract::method13(v17.clone(), v13);
                                Dice_contract::method13(v17.clone(), string("; "));
                                Dice_contract::method13(v17.clone(), string("rolls"));
                                Dice_contract::method13(v17.clone(), string(" = "));
                                Dice_contract::method13(v17.clone(), v14);
                                Dice_contract::method13(v17.clone(), string(" }"));
                                v17.l0.get().clone()
                            }
                        }
                    }
                }
            }
        }
        pub fn method23(
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
            let v23: string = Dice_contract::method24(
                v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22,
            );
            Dice_contract::method16(append(
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
                (v23),
            ))
        }
        pub fn closure15(
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
            fn v29() {
                Dice_contract::closure2((), ());
            }
            let v30: () = {
                v29();
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
            let v71: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v392: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v71,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v94: () = {
                        v29();
                        ()
                    };
                    let patternInput_1: (
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
                    let v122: Option<i64> = patternInput_1.5.clone();
                    let v121: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v120: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v119: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v118: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v117: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v135: string = Dice_contract::method6(
                        v117.clone(),
                        v118.clone(),
                        v119.clone(),
                        v120.clone(),
                        v121.clone(),
                        v122.clone(),
                    );
                    let v136: string = Dice_contract::method10();
                    let v138: string = sprintf!("{:?}", v8);
                    let v142: std::string::String = v9.to_string();
                    let v144: std::string::String = v10.to_string();
                    let v146: string = sprintf!("{:?}", v4);
                    let v150: string = sprintf!("{:?}", v0_1);
                    let v154: usize = v11.clone().len();
                    let v156: string = sprintf!("{:?}", v11);
                    let v160: string = sprintf!("{:?}", v12);
                    let v171: Array<u8> = toArray(Dice_contract::method22(v13, empty::<u8>()));
                    let v180: string = Dice_contract::method23(
                        v117,
                        v118,
                        v119,
                        v120,
                        v121,
                        v122,
                        v135,
                        v136,
                        v3,
                        v1,
                        v2,
                        v7,
                        v6,
                        v5,
                        v138,
                        v142,
                        v144,
                        v146,
                        v150,
                        v154,
                        v156,
                        v160,
                        sprintf!("{:?}", v171.to_vec()),
                    );
                    let v196: () = {
                        v29();
                        ()
                    };
                    let patternInput_2: (
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
                    let v222: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v220: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v219: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v241: () = {
                        Dice_contract::closure6(v219.clone(), ());
                        ()
                    };
                    let v264: string = if (v222.l0.get().clone()) == string("") {
                        v180.clone()
                    } else {
                        if (v180.clone()) == string("") {
                            v222.l0.get().clone()
                        } else {
                            append(
                                (append((v222.l0.get().clone()), string("\n"))),
                                (v180.clone()),
                            )
                        }
                    };
                    let v275: &str = &*v264.clone();
                    let v302 = v275.chars();
                    let v304 = v302;
                    let v306: Vec<char> = v304.collect::<Vec<_>>();
                    let v308: Vec<Vec<char>> = v306
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v310: bool = true;
                    let _vec_map: Vec<_> = v308
                        .into_iter()
                        .map(|x| {
                            //;
                            let v312: Vec<char> = x;
                            let v314: std::string::String = String::from_iter(v312);
                            let v316: bool = true;
                            v314
                        })
                        .collect::<Vec<_>>();
                    let v318: Vec<std::string::String> = _vec_map;
                    if if (v180.clone()) != string("") {
                        (v318.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v222.l0.set(v264);
                        ()
                    } else {
                        v222.l0.set(string(""));
                        {
                            let v381: bool = true;
                            v318.into_iter().for_each(|x| {
                                //;
                                let v383: std::string::String = x;
                                let v385: bool = true;
                                near_sdk::log!("{}", v383);
                                let v387: bool = true;
                                let v389: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v220.l0.get().clone())(v180);
                    Dice_contract::US6::US6_0(
                        v219,
                        v220,
                        patternInput_2.2.clone(),
                        v222,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
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
        pub fn closure16(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn closure17(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::Mut5>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            let v2: Dice_contract::US7 = v1.l0.get().clone();
            match &v2 {
                Dice_contract::US7::US7_0(v2_0_0) => {
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
                    v1.l0.set(Dice_contract::US7::US7_1(v12.clone()));
                    v12
                }
                Dice_contract::US7::US7_1(v2_1_0) => v2_1_0.clone(),
            }
        }
        pub fn method27(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
        ) -> Func0<LrcPtr<Dice_contract::UH1>> {
            let v3: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                l0: MutCell::new(Dice_contract::US7::US7_0(v1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3 = v3.clone();
                move || Dice_contract::closure17(v0_1.clone(), v3.clone(), ())
            })
        }
        pub fn method30(v0_1: u64, v1: u64, v2: i8) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v5.clone(), string("{ "));
            Dice_contract::method13(v5.clone(), string("max"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("p"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v1));
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("n"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v2));
            Dice_contract::method13(v5.clone(), string(" }"));
            v5.l0.get().clone()
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
            let v11: string = Dice_contract::method30(v8, v9, v10);
            Dice_contract::method16(append(
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
                (v11),
            ))
        }
        pub fn closure18(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v18() {
                Dice_contract::closure2((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v338: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v60,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v83: () = {
                        v18();
                        ()
                    };
                    let patternInput_1: (
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
                    let v111: Option<i64> = patternInput_1.5.clone();
                    let v110: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v109: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v108: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v107: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v106: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v126: string = Dice_contract::method29(
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        v110.clone(),
                        v111.clone(),
                        Dice_contract::method6(v106, v107, v108, v109, v110, v111),
                        Dice_contract::method10(),
                        v0_1,
                        v2,
                        v1,
                    );
                    let v142: () = {
                        v18();
                        ()
                    };
                    let patternInput_2: (
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
                    let v168: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v166: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v165: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v187: () = {
                        Dice_contract::closure6(v165.clone(), ());
                        ()
                    };
                    let v210: string = if (v168.l0.get().clone()) == string("") {
                        v126.clone()
                    } else {
                        if (v126.clone()) == string("") {
                            v168.l0.get().clone()
                        } else {
                            append(
                                (append((v168.l0.get().clone()), string("\n"))),
                                (v126.clone()),
                            )
                        }
                    };
                    let v221: &str = &*v210.clone();
                    let v248 = v221.chars();
                    let v250 = v248;
                    let v252: Vec<char> = v250.collect::<Vec<_>>();
                    let v254: Vec<Vec<char>> = v252
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v256: bool = true;
                    let _vec_map: Vec<_> = v254
                        .into_iter()
                        .map(|x| {
                            //;
                            let v258: Vec<char> = x;
                            let v260: std::string::String = String::from_iter(v258);
                            let v262: bool = true;
                            v260
                        })
                        .collect::<Vec<_>>();
                    let v264: Vec<std::string::String> = _vec_map;
                    if if (v126.clone()) != string("") {
                        (v264.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v168.l0.set(v210);
                        ()
                    } else {
                        v168.l0.set(string(""));
                        {
                            let v327: bool = true;
                            v264.into_iter().for_each(|x| {
                                //;
                                let v329: std::string::String = x;
                                let v331: bool = true;
                                near_sdk::log!("{}", v329);
                                let v333: bool = true;
                                let v335: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v166.l0.get().clone())(v126);
                    Dice_contract::US6::US6_0(
                        v165,
                        v166,
                        patternInput_2.2.clone(),
                        v168,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
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
                        let v359: () = {
                            Dice_contract::closure18(
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
                    let v1064: () = {
                        Dice_contract::closure18(
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
        pub fn method34(v0_1: i64, v1: i64, v2: i64, v3: string) -> string {
            let v6: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v6.clone(), string("{ "));
            Dice_contract::method13(v6.clone(), string("current_index"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v6.clone(), string("; "));
            Dice_contract::method13(v6.clone(), string("acc"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), sprintf!("{}", v1));
            Dice_contract::method13(v6.clone(), string("; "));
            Dice_contract::method13(v6.clone(), string("len"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), sprintf!("{}", v2));
            Dice_contract::method13(v6.clone(), string("; "));
            Dice_contract::method13(v6.clone(), string("last_item"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), v3);
            Dice_contract::method13(v6.clone(), string(" }"));
            v6.l0.get().clone()
        }
        pub fn method33(
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
            let v12: string = Dice_contract::method34(v8, v9, v10, v11);
            Dice_contract::method16(append(
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
                (v12),
            ))
        }
        pub fn closure19(v0_1: i64, v1: i64, v2: i64, v3: Option<u8>, unitVar: ()) {
            fn v19() {
                Dice_contract::closure2((), ());
            }
            let v20: () = {
                v19();
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
            let v61: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v343: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v61,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v84: () = {
                        v19();
                        ()
                    };
                    let patternInput_1: (
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
                    let v112: Option<i64> = patternInput_1.5.clone();
                    let v111: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v110: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v109: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v108: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v107: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v131: string = Dice_contract::method33(
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        v110.clone(),
                        v111.clone(),
                        v112.clone(),
                        Dice_contract::method6(v107, v108, v109, v110, v111, v112),
                        Dice_contract::method10(),
                        v0_1,
                        v1,
                        v2,
                        sprintf!("{:?}", v3),
                    );
                    let v147: () = {
                        v19();
                        ()
                    };
                    let patternInput_2: (
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
                    let v173: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v171: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v170: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v192: () = {
                        Dice_contract::closure6(v170.clone(), ());
                        ()
                    };
                    let v215: string = if (v173.l0.get().clone()) == string("") {
                        v131.clone()
                    } else {
                        if (v131.clone()) == string("") {
                            v173.l0.get().clone()
                        } else {
                            append(
                                (append((v173.l0.get().clone()), string("\n"))),
                                (v131.clone()),
                            )
                        }
                    };
                    let v226: &str = &*v215.clone();
                    let v253 = v226.chars();
                    let v255 = v253;
                    let v257: Vec<char> = v255.collect::<Vec<_>>();
                    let v259: Vec<Vec<char>> = v257
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v261: bool = true;
                    let _vec_map: Vec<_> = v259
                        .into_iter()
                        .map(|x| {
                            //;
                            let v263: Vec<char> = x;
                            let v265: std::string::String = String::from_iter(v263);
                            let v267: bool = true;
                            v265
                        })
                        .collect::<Vec<_>>();
                    let v269: Vec<std::string::String> = _vec_map;
                    if if (v131.clone()) != string("") {
                        (v269.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v173.l0.set(v215);
                        ()
                    } else {
                        v173.l0.set(string(""));
                        {
                            let v332: bool = true;
                            v269.into_iter().for_each(|x| {
                                //;
                                let v334: std::string::String = x;
                                let v336: bool = true;
                                near_sdk::log!("{}", v334);
                                let v338: bool = true;
                                let v340: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v171.l0.get().clone())(v131);
                    Dice_contract::US6::US6_0(
                        v170,
                        v171,
                        patternInput_2.2.clone(),
                        v173,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn method35(v0_1: i64, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US8 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method35: loop {
                break '_method35 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US8::US8_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice_contract::US8::US8_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method35;
                        }
                    }
                });
            }
        }
        pub fn method37() -> string {
            let v2: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            v2.l0.get().clone()
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
        ) -> string {
            let v8: string = Dice_contract::method37();
            Dice_contract::method16(append(
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
                (v8),
            ))
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) {
            fn v15() {
                Dice_contract::closure2((), ());
            }
            let v16: () = {
                v15();
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
            let v57: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v335: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v57,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v80: () = {
                        v15();
                        ()
                    };
                    let patternInput_1: (
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
                    let v108: Option<i64> = patternInput_1.5.clone();
                    let v107: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v106: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v105: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v104: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v103: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v123: string = Dice_contract::method36(
                        v103.clone(),
                        v104.clone(),
                        v105.clone(),
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        Dice_contract::method6(v103, v104, v105, v106, v107, v108),
                        Dice_contract::method10(),
                    );
                    let v139: () = {
                        v15();
                        ()
                    };
                    let patternInput_2: (
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
                    let v165: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v163: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v162: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v184: () = {
                        Dice_contract::closure6(v162.clone(), ());
                        ()
                    };
                    let v207: string = if (v165.l0.get().clone()) == string("") {
                        v123.clone()
                    } else {
                        if (v123.clone()) == string("") {
                            v165.l0.get().clone()
                        } else {
                            append(
                                (append((v165.l0.get().clone()), string("\n"))),
                                (v123.clone()),
                            )
                        }
                    };
                    let v218: &str = &*v207.clone();
                    let v245 = v218.chars();
                    let v247 = v245;
                    let v249: Vec<char> = v247.collect::<Vec<_>>();
                    let v251: Vec<Vec<char>> = v249
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v253: bool = true;
                    let _vec_map: Vec<_> = v251
                        .into_iter()
                        .map(|x| {
                            //;
                            let v255: Vec<char> = x;
                            let v257: std::string::String = String::from_iter(v255);
                            let v259: bool = true;
                            v257
                        })
                        .collect::<Vec<_>>();
                    let v261: Vec<std::string::String> = _vec_map;
                    if if (v123.clone()) != string("") {
                        (v261.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v165.l0.set(v207);
                        ()
                    } else {
                        v165.l0.set(string(""));
                        {
                            let v324: bool = true;
                            v261.into_iter().for_each(|x| {
                                //;
                                let v326: std::string::String = x;
                                let v328: bool = true;
                                near_sdk::log!("{}", v326);
                                let v330: bool = true;
                                let v332: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v163.l0.get().clone())(v123);
                    Dice_contract::US6::US6_0(
                        v162,
                        v163,
                        patternInput_2.2.clone(),
                        v165,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn method32(
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
            '_method32: loop {
                break '_method32 ({
                    let v5: i64 = v1.l0.get().clone();
                    let v6: i64 = v2.l0.get().clone();
                    let v7: i64 = v3.l0.get().clone();
                    let v8: Dice_contract::US8 = v4.l0.get().clone();
                    let v375: () = {
                        Dice_contract::closure19(
                            v5,
                            v6,
                            v7,
                            match &v8 {
                                Dice_contract::US8::US8_0(v8_0_0) => Some(match &v8 {
                                    Dice_contract::US8::US8_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => None::<u8>,
                            },
                            (),
                        );
                        ()
                    };
                    let v732: LrcPtr<Dice_contract::UH1> = v0_1();
                    let v734: Dice_contract::US8 =
                        Dice_contract::method35(v1.l0.get().clone(), v732);
                    match &v734 {
                        Dice_contract::US8::US8_0(v734_0_0) => {
                            let v735: u8 = match &v734 {
                                Dice_contract::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v737: i64 = (v1.l0.get().clone()) + 1_i64;
                            v1.l0.set(v737);
                            v4.l0.set(Dice_contract::US8::US8_0(v735));
                            v735
                        }
                        _ => {
                            let v1090: () = {
                                Dice_contract::closure20((), ());
                                ()
                            };
                            if (v3.l0.get().clone()) == -1_i64 {
                                let v1445: i64 = v1.l0.get().clone();
                                v3.l0.set(v1445);
                                ()
                            }
                            {
                                let v1451: i64 = if (v2.l0.get().clone()) >= (v3.l0.get().clone()) {
                                    1_i64
                                } else {
                                    (v2.l0.get().clone()) + 1_i64
                                };
                                v2.l0.set(v1451);
                                {
                                    let v1453: i64 = (v2.l0.get().clone()) - 1_i64;
                                    v1.l0.set(v1453);
                                    v4.l0.set(Dice_contract::US8::US8_1);
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
                                        continue '_method32;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method40(v0_1: i8, v1: u64, v2: u64) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v5.clone(), string("{ "));
            Dice_contract::method13(v5.clone(), string("power"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("acc"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v1));
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("result"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v2));
            Dice_contract::method13(v5.clone(), string(" }"));
            v5.l0.get().clone()
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
            v10: u64,
        ) -> string {
            let v11: string = Dice_contract::method40(v8, v9, v10);
            Dice_contract::method16(append(
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
                (v11),
            ))
        }
        pub fn closure21(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v18() {
                Dice_contract::closure2((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v338: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v60,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v83: () = {
                        v18();
                        ()
                    };
                    let patternInput_1: (
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
                    let v111: Option<i64> = patternInput_1.5.clone();
                    let v110: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v109: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v108: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v107: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v106: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v126: string = Dice_contract::method39(
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        v110.clone(),
                        v111.clone(),
                        Dice_contract::method6(v106, v107, v108, v109, v110, v111),
                        Dice_contract::method10(),
                        v1,
                        v0_1,
                        v2,
                    );
                    let v142: () = {
                        v18();
                        ()
                    };
                    let patternInput_2: (
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
                    let v168: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v166: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v165: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v187: () = {
                        Dice_contract::closure6(v165.clone(), ());
                        ()
                    };
                    let v210: string = if (v168.l0.get().clone()) == string("") {
                        v126.clone()
                    } else {
                        if (v126.clone()) == string("") {
                            v168.l0.get().clone()
                        } else {
                            append(
                                (append((v168.l0.get().clone()), string("\n"))),
                                (v126.clone()),
                            )
                        }
                    };
                    let v221: &str = &*v210.clone();
                    let v248 = v221.chars();
                    let v250 = v248;
                    let v252: Vec<char> = v250.collect::<Vec<_>>();
                    let v254: Vec<Vec<char>> = v252
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v256: bool = true;
                    let _vec_map: Vec<_> = v254
                        .into_iter()
                        .map(|x| {
                            //;
                            let v258: Vec<char> = x;
                            let v260: std::string::String = String::from_iter(v258);
                            let v262: bool = true;
                            v260
                        })
                        .collect::<Vec<_>>();
                    let v264: Vec<std::string::String> = _vec_map;
                    if if (v126.clone()) != string("") {
                        (v264.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v168.l0.set(v210);
                        ()
                    } else {
                        v168.l0.set(string(""));
                        {
                            let v327: bool = true;
                            v264.into_iter().for_each(|x| {
                                //;
                                let v329: std::string::String = x;
                                let v331: bool = true;
                                near_sdk::log!("{}", v329);
                                let v333: bool = true;
                                let v335: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v166.l0.get().clone())(v126);
                    Dice_contract::US6::US6_0(
                        v165,
                        v166,
                        patternInput_2.2.clone(),
                        v168,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_1)
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice_contract::closure85((), ())),
            ))
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice_contract::closure84((), ())),
            ))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice_contract::closure83((), ())),
            ))
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice_contract::closure82((), ())),
            ))
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice_contract::closure81((), ())),
            ))
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice_contract::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice_contract::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice_contract::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice_contract::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice_contract::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice_contract::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice_contract::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice_contract::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice_contract::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice_contract::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice_contract::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice_contract::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice_contract::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice_contract::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice_contract::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice_contract::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice_contract::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice_contract::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice_contract::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice_contract::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice_contract::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice_contract::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice_contract::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice_contract::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice_contract::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice_contract::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice_contract::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice_contract::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice_contract::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice_contract::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice_contract::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice_contract::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice_contract::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice_contract::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice_contract::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice_contract::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice_contract::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice_contract::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice_contract::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice_contract::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice_contract::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice_contract::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice_contract::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice_contract::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice_contract::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice_contract::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice_contract::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice_contract::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice_contract::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice_contract::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice_contract::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice_contract::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice_contract::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice_contract::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice_contract::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice_contract::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice_contract::closure24((), ())),
            ))
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice_contract::closure23((), ())),
            ))
        }
        pub fn method41(v0_1: i8, v1: LrcPtr<Dice_contract::UH2>) -> Dice_contract::US10 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH2>> = MutCell::new(v1.clone());
            '_method41: loop {
                break '_method41 (match v1.get().clone().as_ref() {
                    Dice_contract::UH2::UH2_1 => Dice_contract::US10::US10_1,
                    Dice_contract::UH2::UH2_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice_contract::US10::US10_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH2> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method41;
                        }
                    }
                });
            }
        }
        pub fn method43(v0_1: i8, v1: u64, v2: u8, v3: u64) -> string {
            let v6: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v6.clone(), string("{ "));
            Dice_contract::method13(v6.clone(), string("power"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v6.clone(), string("; "));
            Dice_contract::method13(v6.clone(), string("acc"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), sprintf!("{}", v1));
            Dice_contract::method13(v6.clone(), string("; "));
            Dice_contract::method13(v6.clone(), string("roll"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), sprintf!("{}", v2));
            Dice_contract::method13(v6.clone(), string("; "));
            Dice_contract::method13(v6.clone(), string("value"));
            Dice_contract::method13(v6.clone(), string(" = "));
            Dice_contract::method13(v6.clone(), sprintf!("{}", v3));
            Dice_contract::method13(v6.clone(), string(" }"));
            v6.l0.get().clone()
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
            v10: u8,
            v11: u64,
        ) -> string {
            let v12: string = Dice_contract::method43(v8, v9, v10, v11);
            Dice_contract::method16(append(
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
                (v12),
            ))
        }
        pub fn closure86(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
            fn v19() {
                Dice_contract::closure2((), ());
            }
            let v20: () = {
                v19();
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
            let v61: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v339: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v61,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v84: () = {
                        v19();
                        ()
                    };
                    let patternInput_1: (
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
                    let v112: Option<i64> = patternInput_1.5.clone();
                    let v111: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v110: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v109: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v108: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v107: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v127: string = Dice_contract::method42(
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        v110.clone(),
                        v111.clone(),
                        v112.clone(),
                        Dice_contract::method6(v107, v108, v109, v110, v111, v112),
                        Dice_contract::method10(),
                        v1,
                        v0_1,
                        v2,
                        v3,
                    );
                    let v143: () = {
                        v19();
                        ()
                    };
                    let patternInput_2: (
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
                    let v169: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v167: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v166: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v188: () = {
                        Dice_contract::closure6(v166.clone(), ());
                        ()
                    };
                    let v211: string = if (v169.l0.get().clone()) == string("") {
                        v127.clone()
                    } else {
                        if (v127.clone()) == string("") {
                            v169.l0.get().clone()
                        } else {
                            append(
                                (append((v169.l0.get().clone()), string("\n"))),
                                (v127.clone()),
                            )
                        }
                    };
                    let v222: &str = &*v211.clone();
                    let v249 = v222.chars();
                    let v251 = v249;
                    let v253: Vec<char> = v251.collect::<Vec<_>>();
                    let v255: Vec<Vec<char>> = v253
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v257: bool = true;
                    let _vec_map: Vec<_> = v255
                        .into_iter()
                        .map(|x| {
                            //;
                            let v259: Vec<char> = x;
                            let v261: std::string::String = String::from_iter(v259);
                            let v263: bool = true;
                            v261
                        })
                        .collect::<Vec<_>>();
                    let v265: Vec<std::string::String> = _vec_map;
                    if if (v127.clone()) != string("") {
                        (v265.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v169.l0.set(v211);
                        ()
                    } else {
                        v169.l0.set(string(""));
                        {
                            let v328: bool = true;
                            v265.into_iter().for_each(|x| {
                                //;
                                let v330: std::string::String = x;
                                let v332: bool = true;
                                near_sdk::log!("{}", v330);
                                let v334: bool = true;
                                let v336: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v167.l0.get().clone())(v127);
                    Dice_contract::US6::US6_0(
                        v166,
                        v167,
                        patternInput_2.2.clone(),
                        v169,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn method45(v0_1: i8, v1: u64, v2: u8) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v5.clone(), string("{ "));
            Dice_contract::method13(v5.clone(), string("power"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("acc"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v1));
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("roll"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v2));
            Dice_contract::method13(v5.clone(), string(" }"));
            v5.l0.get().clone()
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
            v8: i8,
            v9: u64,
            v10: u8,
        ) -> string {
            let v11: string = Dice_contract::method45(v8, v9, v10);
            Dice_contract::method16(append(
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
                (v11),
            ))
        }
        pub fn closure87(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
            fn v18() {
                Dice_contract::closure2((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v338: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v60,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v83: () = {
                        v18();
                        ()
                    };
                    let patternInput_1: (
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
                    let v111: Option<i64> = patternInput_1.5.clone();
                    let v110: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v109: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v108: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v107: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v106: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v126: string = Dice_contract::method44(
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        v110.clone(),
                        v111.clone(),
                        Dice_contract::method6(v106, v107, v108, v109, v110, v111),
                        Dice_contract::method10(),
                        v1,
                        v0_1,
                        v2,
                    );
                    let v142: () = {
                        v18();
                        ()
                    };
                    let patternInput_2: (
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
                    let v168: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v166: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v165: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v187: () = {
                        Dice_contract::closure6(v165.clone(), ());
                        ()
                    };
                    let v210: string = if (v168.l0.get().clone()) == string("") {
                        v126.clone()
                    } else {
                        if (v126.clone()) == string("") {
                            v168.l0.get().clone()
                        } else {
                            append(
                                (append((v168.l0.get().clone()), string("\n"))),
                                (v126.clone()),
                            )
                        }
                    };
                    let v221: &str = &*v210.clone();
                    let v248 = v221.chars();
                    let v250 = v248;
                    let v252: Vec<char> = v250.collect::<Vec<_>>();
                    let v254: Vec<Vec<char>> = v252
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v256: bool = true;
                    let _vec_map: Vec<_> = v254
                        .into_iter()
                        .map(|x| {
                            //;
                            let v258: Vec<char> = x;
                            let v260: std::string::String = String::from_iter(v258);
                            let v262: bool = true;
                            v260
                        })
                        .collect::<Vec<_>>();
                    let v264: Vec<std::string::String> = _vec_map;
                    if if (v126.clone()) != string("") {
                        (v264.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v168.l0.set(v210);
                        ()
                    } else {
                        v168.l0.set(string(""));
                        {
                            let v327: bool = true;
                            v264.into_iter().for_each(|x| {
                                //;
                                let v329: std::string::String = x;
                                let v331: bool = true;
                                near_sdk::log!("{}", v329);
                                let v333: bool = true;
                                let v335: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v166.l0.get().clone())(v126);
                    Dice_contract::US6::US6_0(
                        v165,
                        v166,
                        patternInput_2.2.clone(),
                        v168,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn method38(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US9 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method38: loop {
                break '_method38 (if (v0_1.get().clone()) < 0_i8 {
                    let v4: u64 = (v2.get().clone()) + 1_u64;
                    let v356: () = {
                        Dice_contract::closure21(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US9::US9_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US9::US9_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v712: LrcPtr<Dice_contract::UH0> =
                                match v1.get().clone().as_ref() {
                                    Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v711: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v711) > 1_u8 {
                                let v717: Dice_contract::US10 = Dice_contract::method41(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure22((), ())),
                                    )),
                                );
                                let v724: u64 = (((v711) - 1_u8) as u64)
                                    * (match &v717 {
                                        Dice_contract::US10::US10_0(v717_0_0) => match &v717 {
                                            Dice_contract::US10::US10_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v1076: () = {
                                    Dice_contract::closure86(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v711,
                                        v724,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v712;
                                    let v2_temp: u64 = (v2.get().clone()) + (v724);
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method38;
                                }
                            } else {
                                let v1783: () = {
                                    Dice_contract::closure87(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v711,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v712.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method38;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method46(
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
                    Dice_contract::method32(
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                    ),
                    Dice_contract::method46(v0_1, v1, v2, v3, v4, v5, (v6) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice_contract::UH0::UH0_0)
            }
        }
        pub fn method47(
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
            '_method47: loop {
                break '_method47 ({
                    let v8: i8 = (v6.get().clone()) + 1_i8;
                    if (v6.get().clone()) < (v8) {
                        Dice_contract::method31(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            LrcPtr::new(Dice_contract::UH0::UH0_1(
                                Dice_contract::method32(
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
                        let v14: Dice_contract::US9 =
                            Dice_contract::method38(v6.get().clone(), v7.get().clone(), 0_u64);
                        if let Dice_contract::US9::US9_0(v14_0_0, v14_0_1) = &v14 {
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
                                let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method46(
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
                                continue '_method47;
                            }
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                            let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                            let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                            let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                            let v5_temp: u64 = v5.get().clone();
                            let v6_temp: i8 = v6.get().clone();
                            let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method46(
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
                            continue '_method47;
                        }
                    }
                });
            }
        }
        pub fn method31(
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
            '_method31: loop {
                break '_method31 (if (v8.get().clone()) < ((v6.get().clone()) + 1_i8) {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                    let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                    let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                    let v4_temp: LrcPtr<Dice_contract::Mut6> = v4.get().clone();
                    let v5_temp: u64 = v5.get().clone();
                    let v6_temp: i8 = v6.get().clone();
                    let v7_temp: LrcPtr<Dice_contract::UH0> =
                        LrcPtr::new(Dice_contract::UH0::UH0_1(
                            Dice_contract::method32(
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
                    continue '_method31;
                } else {
                    let v16: Dice_contract::US9 =
                        Dice_contract::method38(v6.get().clone(), v7.get().clone(), 0_u64);
                    if let Dice_contract::US9::US9_0(v16_0_0, v16_0_1) = &v16 {
                        let v17: u64 = v16_0_0.clone();
                        if (v17) <= (v5.get().clone()) {
                            v17
                        } else {
                            Dice_contract::method47(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                                Dice_contract::method46(
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
                        Dice_contract::method47(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            Dice_contract::method46(
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
        pub fn method48() -> Func0<()> {
            Func0::new(move || Dice_contract::closure9((), ()))
        }
        pub fn closure88(v0_1: Func0<()>, unitVar: ()) {
            fn v16() {
                Dice_contract::closure2((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v334: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v58,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v81: () = {
                        v16();
                        ()
                    };
                    let patternInput_1: (
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
                    let v122: string = Dice_contract::method6(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v123: string = Dice_contract::method10();
                    let v139: () = {
                        v16();
                        ()
                    };
                    let patternInput_2: (
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
                    let v165: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v163: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v162: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v184: () = {
                        Dice_contract::closure6(v162.clone(), ());
                        ()
                    };
                    let v208: string = if (v165.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v165.l0.get().clone()
                    };
                    let v219: &str = &*v208;
                    let v246 = v219.chars();
                    let v248 = v246;
                    let v250: Vec<char> = v248.collect::<Vec<_>>();
                    let v252: Vec<Vec<char>> = v250
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v254: bool = true;
                    let _vec_map: Vec<_> = v252
                        .into_iter()
                        .map(|x| {
                            //;
                            let v256: Vec<char> = x;
                            let v258: std::string::String = String::from_iter(v256);
                            let v260: bool = true;
                            v258
                        })
                        .collect::<Vec<_>>();
                    let v262: Vec<std::string::String> = _vec_map;
                    v165.l0.set(string(""));
                    {
                        let v323: bool = true;
                        v262.into_iter().for_each(|x| {
                            //;
                            let v325: std::string::String = x;
                            let v327: bool = true;
                            near_sdk::log!("{}", v325);
                            let v329: bool = true;
                            let v331: bool = true;
                        }); //;
                        ()
                    }
                    (v163.l0.get().clone())(string(""));
                    Dice_contract::US6::US6_0(
                        v162,
                        v163,
                        patternInput_2.2.clone(),
                        v165,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn method49(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method49: loop {
                break '_method49 (match v0_1.get().clone().as_ref() {
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
                        continue '_method49;
                    }
                });
            }
        }
        pub fn method51(v0_1: u64, v1: string, v2: string) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method12()),
            });
            Dice_contract::method13(v5.clone(), string("{ "));
            Dice_contract::method13(v5.clone(), string("max"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), sprintf!("{}", v0_1));
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("rolls"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), v1);
            Dice_contract::method13(v5.clone(), string("; "));
            Dice_contract::method13(v5.clone(), string("result"));
            Dice_contract::method13(v5.clone(), string(" = "));
            Dice_contract::method13(v5.clone(), v2);
            Dice_contract::method13(v5.clone(), string(" }"));
            v5.l0.get().clone()
        }
        pub fn method50(
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
            let v11: string = Dice_contract::method51(v8, v9, v10);
            Dice_contract::method16(append(
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
                (v11),
            ))
        }
        pub fn closure89(v0_1: u64, v1: Vec<u8>, v2: Option<u64>, unitVar: ()) {
            fn v18() {
                Dice_contract::closure2((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v346: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v60,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v83: () = {
                        v18();
                        ()
                    };
                    let patternInput_1: (
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
                    let v111: Option<i64> = patternInput_1.5.clone();
                    let v110: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                    let v109: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                    let v108: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                    let v107: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                    let v106: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                    let v134: string = Dice_contract::method50(
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        v110.clone(),
                        v111.clone(),
                        Dice_contract::method6(v106, v107, v108, v109, v110, v111),
                        Dice_contract::method10(),
                        v0_1,
                        sprintf!("{:?}", v1),
                        sprintf!("{:?}", v2),
                    );
                    let v150: () = {
                        v18();
                        ()
                    };
                    let patternInput_2: (
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
                    let v176: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v174: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v173: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v195: () = {
                        Dice_contract::closure6(v173.clone(), ());
                        ()
                    };
                    let v218: string = if (v176.l0.get().clone()) == string("") {
                        v134.clone()
                    } else {
                        if (v134.clone()) == string("") {
                            v176.l0.get().clone()
                        } else {
                            append(
                                (append((v176.l0.get().clone()), string("\n"))),
                                (v134.clone()),
                            )
                        }
                    };
                    let v229: &str = &*v218.clone();
                    let v256 = v229.chars();
                    let v258 = v256;
                    let v260: Vec<char> = v258.collect::<Vec<_>>();
                    let v262: Vec<Vec<char>> = v260
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v264: bool = true;
                    let _vec_map: Vec<_> = v262
                        .into_iter()
                        .map(|x| {
                            //;
                            let v266: Vec<char> = x;
                            let v268: std::string::String = String::from_iter(v266);
                            let v270: bool = true;
                            v268
                        })
                        .collect::<Vec<_>>();
                    let v272: Vec<std::string::String> = _vec_map;
                    if if (v134.clone()) != string("") {
                        (v272.clone().len() as i32) <= 1_i32
                    } else {
                        false
                    } {
                        v176.l0.set(v218);
                        ()
                    } else {
                        v176.l0.set(string(""));
                        {
                            let v335: bool = true;
                            v272.into_iter().for_each(|x| {
                                //;
                                let v337: std::string::String = x;
                                let v339: bool = true;
                                near_sdk::log!("{}", v337);
                                let v341: bool = true;
                                let v343: bool = true;
                            }); //;
                            ()
                        }
                    }
                    (v174.l0.get().clone())(v134);
                    Dice_contract::US6::US6_0(
                        v173,
                        v174,
                        patternInput_2.2.clone(),
                        v176,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn method52() -> Func0<()> {
            Func0::new(move || Dice_contract::closure9((), ()))
        }
        pub fn closure90(v0_1: Func0<()>, unitVar: ()) {
            fn v16() {
                Dice_contract::closure2((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            let v334: Dice_contract::US6 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v58,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US6::US6_1
                } else {
                    let v81: () = {
                        v16();
                        ()
                    };
                    let patternInput_1: (
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
                    let v122: string = Dice_contract::method6(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v123: string = Dice_contract::method10();
                    let v139: () = {
                        v16();
                        ()
                    };
                    let patternInput_2: (
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
                    let v165: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v163: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v162: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v184: () = {
                        Dice_contract::closure6(v162.clone(), ());
                        ()
                    };
                    let v208: string = if (v165.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v165.l0.get().clone()
                    };
                    let v219: &str = &*v208;
                    let v246 = v219.chars();
                    let v248 = v246;
                    let v250: Vec<char> = v248.collect::<Vec<_>>();
                    let v252: Vec<Vec<char>> = v250
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v254: bool = true;
                    let _vec_map: Vec<_> = v252
                        .into_iter()
                        .map(|x| {
                            //;
                            let v256: Vec<char> = x;
                            let v258: std::string::String = String::from_iter(v256);
                            let v260: bool = true;
                            v258
                        })
                        .collect::<Vec<_>>();
                    let v262: Vec<std::string::String> = _vec_map;
                    v165.l0.set(string(""));
                    {
                        let v323: bool = true;
                        v262.into_iter().for_each(|x| {
                            //;
                            let v325: std::string::String = x;
                            let v327: bool = true;
                            near_sdk::log!("{}", v325);
                            let v329: bool = true;
                            let v331: bool = true;
                        }); //;
                        ()
                    }
                    (v163.l0.get().clone())(string(""));
                    Dice_contract::US6::US6_0(
                        v162,
                        v163,
                        patternInput_2.2.clone(),
                        v165,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
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
                    let v169: i32 = (v56.len() as i32) - (100_i32);
                    if (v169) > 0_i32 {
                        let v528: () = {
                            Dice_contract::closure1(
                                v169,
                                v56.drain(0..v169 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v1235: () = {
                            Dice_contract::closure10(Dice_contract::method17(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v1591: bool =
        true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
        let v1593: bool =
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
        let v1601: bool =
        true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
        let v1603: bool =
        true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v1608: std::string::String = key;
                    let v1610: std::string::String = proof;
                    let v1612: u64 = max;
                    let v1614: &mut near_sdk::store::vec::Vector<u8> = &mut self.0.1;
                    let v1616: Vec<u8> = near_sdk::env::random_seed();
                    let v1618: u64 = near_sdk::env::epoch_height();
                    let v1620: u64 = near_sdk::env::block_height();
                    let v1622: u64 = near_sdk::env::block_timestamp();
                    let v1624: near_token::NearToken = near_sdk::env::account_balance();
                    let v1626: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v1628: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v1630: &near_sdk::store::vec::Vector<u8> = &*v1614;
                    let v1632: Vec<u8> = v1630.iter().map(|x| *x).collect::<Vec<_>>();
                    let v1634: _ = v1618.to_le_bytes();
                    let v1636: Vec<u8> = v1634.to_vec();
                    let v1638: _ = v1620.to_le_bytes();
                    let v1640: Vec<u8> = v1638.to_vec();
                    let v1642: _ = v1622.to_le_bytes();
                    let v1644: Vec<u8> = v1642.to_vec();
                    let v1646: u128 = v1624.clone().as_yoctonear();
                    let v1648: _ = v1646.to_le_bytes();
                    let v1650: Vec<u8> = v1648.to_vec();
                    let v1652: &[u8] = v1626.as_bytes();
                    let v1654: Vec<u8> = v1652.to_vec();
                    let v1656: &[u8] = v1628.as_bytes();
                    let v1663: Array<Vec<u8>> = new_array(&[
                        v1616.clone(),
                        v1632,
                        v1636,
                        v1640,
                        v1644,
                        v1650,
                        v1654,
                        v1656.to_vec(),
                        v1610.clone().into_bytes(),
                        v1608.clone().into_bytes(),
                    ]);
                    let v1665: Vec<Vec<u8>> = v1663.to_vec();
                    let v1667: Vec<u8> = v1665.concat();
                    let v1669: Vec<u8> = near_sdk::env::keccak512(&v1667.clone());
                    let v1671: bool = true;
                    v1614.extend(v1669.clone()); //;
                    let v1780: i32 = (v1614.len() as i32) - (100_i32);
                    if (v1780) > 0_i32 {
                        let v2139: () = {
                            Dice_contract::closure1(
                                v1780,
                                v1614.drain(0..v1780 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v2846: () = {
                            Dice_contract::closure10(Dice_contract::method17(), ());
                            ()
                        };
                        let v3200: List<u8> = ofArray(
                            fable_library_rust::NativeArray_::array_from(v1669.clone().clone()),
                        );
                        let v3247: LrcPtr<Dice_contract::UH0> = Dice_contract::method21(
                            Dice_contract::method20(
                                Dice_contract::method19(
                                    foldBack(
                                        Func2::new(
                                            move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                                                (Dice_contract::method18())(b0)(b1)
                                            },
                                        ),
                                        v3200,
                                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                                    ),
                                    LrcPtr::new(Dice_contract::UH1::UH1_1),
                                ),
                                LrcPtr::new(Dice_contract::UH1::UH1_1),
                            ),
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                        );
                        let v3642: () = {
                            Dice_contract::closure15(
                                v1614,
                                v1608,
                                v1610,
                                v1612,
                                v1616,
                                v1618,
                                v1620,
                                v1622,
                                v1624,
                                v1626,
                                v1628,
                                v1667,
                                v1669,
                                v3247.clone(),
                                (),
                            );
                            ()
                        };
                        let v4042: LrcPtr<Dice_contract::UH1> = Dice_contract::method19(
                            Dice_contract::method26(
                                v3247.clone(),
                                Dice_contract::method25(
                                    v3247,
                                    LrcPtr::new(Dice_contract::UH0::UH0_0),
                                ),
                            ),
                            LrcPtr::new(Dice_contract::UH1::UH1_1),
                        );
                        let v4058: u64 = Dice_contract::method31(
                            Dice_contract::method27(
                                v4042.clone(),
                                Func0::new({
                                    let v4042 = v4042.clone();
                                    move || Dice_contract::closure16(v4042.clone(), ())
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
                                l0: MutCell::new(Dice_contract::US8::US8_1),
                            }),
                            v1612,
                            (if (v1612) == 1_u64 {
                                1_i8
                            } else {
                                Dice_contract::method28(v1612, 0_i8, 1_u64)
                            }) - 1_i8,
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                            0_i8,
                        );
                        let v4409: () = {
                            Dice_contract::closure88(Dice_contract::method48(), ());
                            ()
                        };
                        v4058 //;
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v4766: bool =
        true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy;
        let v4768: bool =
        true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v4773: u64 = max;
                    let v4775: Vec<u8> = rolls;
                    let v4779: List<u8> = ofArray(fable_library_rust::NativeArray_::array_from(
                        v4775.clone().clone(),
                    ));
                    let v4792: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method18())(b0)(b1)
                        }),
                        v4779,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v4825: Dice_contract::US9 = Dice_contract::method38(
                        (Dice_contract::method49(v4792.clone(), 0_i8)) - 1_i8,
                        v4792,
                        0_u64,
                    );
                    let v4835: Dice_contract::US10 =
                        if let Dice_contract::US9::US9_0(v4825_0_0, v4825_0_1) = &v4825 {
                            let v4826: u64 = v4825_0_0.clone();
                            if if (v4826) >= 1_u64 {
                                (v4826) <= (v4773)
                            } else {
                                false
                            } {
                                Dice_contract::US10::US10_0(v4826)
                            } else {
                                Dice_contract::US10::US10_1
                            }
                        } else {
                            Dice_contract::US10::US10_1
                        };
                    let v4846: Option<u64> = match &v4835 {
                        Dice_contract::US10::US10_0(v4835_0_0) => Some(match &v4835 {
                            Dice_contract::US10::US10_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v5206: () = {
                        Dice_contract::closure89(v4773, v4775, v4846.clone(), ());
                        ()
                    };
                    let v5917: () = {
                        Dice_contract::closure90(Dice_contract::method52(), ());
                        ()
                    };
                    v4846 //;
                } //;
            } //;
        } /* c;
        {
        let v6273: bool =
        true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy;
        let v6275: bool =
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
        let v6288:
        bool =
        true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy;
        let v6290:
        bool =
        true; */
 // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v6294: bool = true;
            {
                (); // ?? / i': 1uy / n: 12uy;
                let v6296: bool = true;
                {
                    (); // ?? / i': 2uy / n: 12uy;
                    let v6298: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 12uy;
                        let v6300: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 12uy;
                            let v6302: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 12uy;
                                let v6304: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 12uy;
                                    let v6306: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 12uy;
                                        let v6308: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 12uy;
                                            let v6310: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 12uy;
                                                let v6312: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 12uy;
                                                    let v6314: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 12uy;
                                                        let v6316: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 12uy;
                                                            let v6318: bool = true;
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
