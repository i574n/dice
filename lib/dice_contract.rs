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
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_7c9aa503 {
    pub mod Dice {
        use super::*;
        type DateTime = ();
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
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
                        LrcPtr<Dice::Mut1>,
                        LrcPtr<Dice::Mut3>,
                        LrcPtr<Dice::Mut4>,
                        LrcPtr<Dice::Mut5>,
                        LrcPtr<Dice::Mut6>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Dice::Mut1>,
                                LrcPtr<Dice::Mut3>,
                                LrcPtr<Dice::Mut4>,
                                LrcPtr<Dice::Mut5>,
                                LrcPtr<Dice::Mut6>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Dice::Mut1>,
                                LrcPtr<Dice::Mut3>,
                                LrcPtr<Dice::Mut4>,
                                LrcPtr<Dice::Mut5>,
                                LrcPtr<Dice::Mut6>,
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
        #[derive(Clone, Debug)]
        pub enum UH0 {
            UH0_0(u8, Func0<LrcPtr<Dice::UH0>>),
            UH0_1,
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH1 {
            UH1_0,
            UH1_1(u8, LrcPtr<Dice::UH1>),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(Func0<LrcPtr<Dice::UH0>>),
            US0_1(LrcPtr<Dice::UH0>),
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut0 {
            pub l0: MutCell<Dice::US0>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut1 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(u8),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<Dice::US1>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0,
            US2_1,
            US2_2,
            US2_3,
            US2_4,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut3 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<Dice::US2>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0(Dice::US2),
            US3_1,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(i64),
            US4_1,
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0,
            US5_1,
            US5_2,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US6 {
            US6_0(Dice::US5),
            US6_1(Dice::US5),
            US6_2(Dice::US5),
            US6_3(Dice::US5),
            US6_4(Dice::US5),
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US7 {
            US7_0(string),
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(u64, LrcPtr<Dice::UH1>),
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH2 {
            UH2_0(u64, Func0<LrcPtr<Dice::UH2>>),
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
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US10 {
            US10_0(i64, LrcPtr<Dice::UH1>),
            US10_1,
        }
        impl core::fmt::Display for US10 {
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
                        (((((v1_1_0_0.clone() as i64) - 1_i64) + (v0_1)) % (v0_1)) + 1_i64) as u8,
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
        pub fn method1(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            '_method1: loop {
                break '_method1 (match v0_1.get().clone().as_ref() {
                    Dice::UH1::UH1_0 => v1_1.get().clone(),
                    Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = match v0_1.get().clone().as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v1_1_temp: LrcPtr<Dice::UH1> = LrcPtr::new(Dice::UH1::UH1_1(
                            match v0_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method1;
                    }
                });
            }
        }
        pub fn method2(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => LrcPtr::new(Dice::UH1::UH1_1(
                    match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice::method2(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn closure4(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn method3(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH0> = Dice::method3(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    );
                    LrcPtr::new(Dice::UH0::UH0_0(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Func0::new({
                            let v4_1 = v4_1.clone();
                            move || Dice::closure4(v4_1.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure5(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn closure6(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: LrcPtr<Dice::Mut0>,
            unitVar: (),
        ) -> LrcPtr<Dice::UH0> {
            let v2_1: Dice::US0 = v1_1.l0.get().clone();
            match &v2_1 {
                Dice::US0::US0_0(v2_1_0_0) => {
                    let v5: LrcPtr<Dice::UH0> = (v2_1_0_0)();
                    let v12: LrcPtr<Dice::UH0> = match v5.as_ref() {
                        Dice::UH0::UH0_1 => LrcPtr::new(Dice::UH0::UH0_1),
                        Dice::UH0::UH0_0(v5_0_0, v5_0_1) => LrcPtr::new(Dice::UH0::UH0_0(
                            v5_0_0.clone(),
                            Dice::method4(v0_1.clone(), v5_0_1.clone()),
                        )),
                    };
                    v1_1.l0.set(Dice::US0::US0_1(v12.clone()));
                    v12
                }
                Dice::US0::US0_1(v2_1_1_0) => v2_1_1_0.clone(),
            }
        }
        pub fn method4(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
        ) -> Func0<LrcPtr<Dice::UH0>> {
            let v3_1: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(Dice::US0::US0_0(v1_1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3_1 = v3_1.clone();
                move || Dice::closure6(v0_1.clone(), v3_1.clone(), ())
            })
        }
        pub fn method10(v0_1: string) -> string {
            v0_1
        }
        pub fn method11() -> string {
            string("")
        }
        pub fn closure10(unitVar: (), v0_1: string) -> Dice::US7 {
            Dice::US7::US7_0(v0_1)
        }
        pub fn method12() -> Func1<string, Dice::US7> {
            Func1::new(move |v: string| Dice::closure10((), v))
        }
        pub fn method9(v0_1: string) -> string {
            panic!(
                "{}",
                sprintf!(
                    "env.get_environment_variable / target: {} / var: {}",
                    Dice::US6::US6_2(Dice::US5::US5_2),
                    v0_1
                ),
            )
        }
        pub fn method8() -> (Dice::US3, Dice::US4) {
            let v1_1: string = Dice::method9(string("TRACE_LEVEL"));
            let v6: Dice::US3 = if string("Verbose") == (v1_1.clone()) {
                Dice::US3::US3_0(Dice::US2::US2_0)
            } else {
                Dice::US3::US3_1
            };
            (
                match &v6 {
                    Dice::US3::US3_0(v6_0_0) => Dice::US3::US3_0(
                        match &v6 {
                            Dice::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v13: Dice::US3 = if string("Debug") == (v1_1.clone()) {
                            Dice::US3::US3_0(Dice::US2::US2_1)
                        } else {
                            Dice::US3::US3_1
                        };
                        match &v13 {
                            Dice::US3::US3_0(v13_0_0) => Dice::US3::US3_0(
                                match &v13 {
                                    Dice::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v20: Dice::US3 = if string("Info") == (v1_1.clone()) {
                                    Dice::US3::US3_0(Dice::US2::US2_2)
                                } else {
                                    Dice::US3::US3_1
                                };
                                match &v20 {
                                    Dice::US3::US3_0(v20_0_0) => Dice::US3::US3_0(
                                        match &v20 {
                                            Dice::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v27: Dice::US3 = if string("Warning") == (v1_1.clone())
                                        {
                                            Dice::US3::US3_0(Dice::US2::US2_3)
                                        } else {
                                            Dice::US3::US3_1
                                        };
                                        match &v27 {
                                            Dice::US3::US3_0(v27_0_0) => Dice::US3::US3_0(
                                                match &v27 {
                                                    Dice::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            ),
                                            _ => {
                                                let v34: Dice::US3 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Dice::US3::US3_0(Dice::US2::US2_4)
                                                    } else {
                                                        Dice::US3::US3_1
                                                    };
                                                match &v34 {
                                                    Dice::US3::US3_0(v34_0_0) => Dice::US3::US3_0(
                                                        match &v34 {
                                                            Dice::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    ),
                                                    _ => Dice::US3::US3_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if (Dice::method9(string("AUTOMATION"))) != string("True") {
                    Dice::US4::US4_1
                } else {
                    let v58: DateTime = unbox::<DateTime>(fable_library_rust::Native_::getZero());
                    Dice::US4::US4_0(unbox::<i64>(fable_library_rust::Native_::getZero()))
                },
            )
        }
        pub fn closure11(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method7(
            v0_1: Dice::US2,
        ) -> (
            LrcPtr<Dice::Mut1>,
            LrcPtr<Dice::Mut3>,
            LrcPtr<Dice::Mut4>,
            LrcPtr<Dice::Mut5>,
            LrcPtr<Dice::Mut6>,
            Option<i64>,
        ) {
            let v64: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v65: &str = option_env!("AUTOMATION").unwrap_or("");
            let v72: std::string::String = String::from(v65);
            let _run_target_args__v1: (Dice::US3, Dice::US4) = (
                Dice::US3::US3_1,
                if (fable_library_rust::String_::fromString(v72)) != string("True") {
                    Dice::US4::US4_1
                } else {
                    Dice::US4::US4_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v132: Dice::US4 = _run_target_args__v1.1.clone();
            let v131: Dice::US3 = _run_target_args__v1.0.clone();
            (
                LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Func1::new(move |v: string| Dice::closure11((), v))),
                }),
                LrcPtr::new(Dice::Mut4 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Dice::Mut5 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Dice::Mut6 {
                    l0: MutCell::new(match &v131 {
                        Dice::US3::US3_0(v131_0_0) => match &v131 {
                            Dice::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v132 {
                    Dice::US4::US4_0(v132_0_0) => Some(match &v132 {
                        Dice::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure9(unitVar: (), unitVar_1: ()) {
            if Dice::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::method7(Dice::US2::US2_0);
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
        pub fn method6(v0_1: Dice::US2) -> bool {
            let v3_1: () = {
                Dice::closure9((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                LrcPtr<Dice::Mut5>,
                LrcPtr<Dice::Mut6>,
                Option<i64>,
            ) = Dice::TraceState::trace_state().get().clone().unwrap();
            let v35: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                        LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                        LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                        LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                        LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                        LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                        LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                        LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                        LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure12(unitVar: (), v0_1: i64) -> Dice::US4 {
            Dice::US4::US4_0(v0_1)
        }
        pub fn method14() -> Func1<i64, Dice::US4> {
            Func1::new(move |v: i64| Dice::closure12((), v))
        }
        pub fn method15() -> string {
            string("hh:mm:ss")
        }
        pub fn method16() -> string {
            string("HH:mm:ss")
        }
        pub fn method13(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
        ) -> string {
            let v272: u64 = near_sdk::env::block_timestamp();
            let v286: Dice::US4 = defaultValue(Dice::US4::US4_1, map(Dice::method14(), v5));
            let v298: u64 = (match &v286 {
                Dice::US4::US4_0(v286_0_0) => {
                    (v272)
                        - (match &v286 {
                            Dice::US4::US4_0(x) => x.clone(),
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
        pub fn method19() -> string {
            string("")
        }
        pub fn closure13(v0_1: LrcPtr<Dice::Mut5>, v1_1: string, unitVar: ()) {
            let v3_1: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v3_1);
            ()
        }
        pub fn method18(v0_1: char) -> string {
            let v2_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v8: () = {
                Dice::closure13(v2_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2_1.l0.get().clone()
        }
        pub fn method20() -> string {
            string("\u{001b}[0m")
        }
        pub fn method17() -> string {
            let v6: string = Dice::method18(getCharAt(toLower(string("Debug")), 0_i32));
            let v73: &str = inline_colorization::color_bright_blue;
            let v80: &str = &*v6;
            let v99: &str = inline_colorization::color_reset;
            let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
            fable_library_rust::String_::fromString(v101)
        }
        pub fn method22(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: string) -> string {
            let v5: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v12: () = {
                Dice::closure13(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Dice::closure13(v5.clone(), string("current_index"), ());
                ()
            };
            let v30: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v5.clone(), string("acc"), ());
                ()
            };
            let v64: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v89: () = {
                Dice::closure13(v5.clone(), string("len"), ());
                ()
            };
            let v97: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v105: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice::closure13(v5.clone(), string("last_item"), ());
                ()
            };
            let v130: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Dice::closure13(v5.clone(), v3_1, ());
                ()
            };
            let v147: () = {
                Dice::closure13(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method23(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method21(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: i64,
            v10: i64,
            v11: string,
        ) -> string {
            let v12: string = Dice::method22(v8, v9, v10, v11);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.create_sequential_roller / roll"),
                v12
            ))
        }
        pub fn closure14(v0_1: LrcPtr<Dice::Mut1>, unitVar: ()) {
            let v2_1: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2_1);
            ()
        }
        pub fn closure16(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure15(unitVar: (), v0_1: string) {
            let v3_1: () = {
                Dice::closure16(v0_1, ());
                ()
            };
            ()
        }
        pub fn method24(v0_1: string) {
            let v3_1: () = {
                Dice::closure9((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                LrcPtr<Dice::Mut5>,
                LrcPtr<Dice::Mut6>,
                Option<i64>,
            ) = Dice::TraceState::trace_state().get().clone().unwrap();
            let v20: LrcPtr<Dice::Mut5> = patternInput.3.clone();
            let v37: () = {
                Dice::closure14(patternInput.0.clone(), ());
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
        pub fn closure8(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: Option<u8>, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v8: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v25: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v24: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v23: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v22: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method21(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Dice::method13(v22, v23, v24, v25, v26, v27),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                    sprintf!("{:?}", v3_1),
                ))
            };
        }
        pub fn method25(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> Dice::US1 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1_1.clone());
            '_method25: loop {
                break '_method25 (match v1_1.get().clone().as_ref() {
                    Dice::UH0::UH0_1 => Dice::US1::US1_1,
                    Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice::US1::US1_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_1_temp: LrcPtr<Dice::UH0> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method25;
                        }
                    }
                });
            }
        }
        pub fn method27() -> string {
            let v1_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method26(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            let v8: string = Dice::method27();
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.create_sequential_roller / roll / None"),
                v8
            ))
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v4_1: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v23: Option<i64> = patternInput.5.clone();
                let v22: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v21: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v20: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v19: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v18: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method26(
                    v18.clone(),
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    Dice::method13(v18, v19, v20, v21, v22, v23),
                    Dice::method17(),
                ))
            };
        }
        pub fn method5(
            v0_1: Func0<LrcPtr<Dice::UH0>>,
            v1_1: LrcPtr<Dice::Mut1>,
            v2_1: LrcPtr<Dice::Mut1>,
            v3_1: LrcPtr<Dice::Mut1>,
            v4_1: LrcPtr<Dice::Mut2>,
        ) -> u8 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v1_1.clone());
            let v2_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v2_1.clone());
            let v3_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v3_1.clone());
            let v4_1: MutCell<LrcPtr<Dice::Mut2>> = MutCell::new(v4_1.clone());
            '_method5: loop {
                break '_method5 ({
                    let v5: i64 = v1_1.l0.get().clone();
                    let v6: i64 = v2_1.l0.get().clone();
                    let v7: i64 = v3_1.l0.get().clone();
                    let v8: Dice::US1 = v4_1.l0.get().clone();
                    let v18: () = {
                        Dice::closure8(
                            v5,
                            v6,
                            v7,
                            match &v8 {
                                Dice::US1::US1_0(v8_0_0) => Some(match &v8 {
                                    Dice::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => None::<u8>,
                            },
                            (),
                        );
                        ()
                    };
                    let v61: LrcPtr<Dice::UH0> = v0_1();
                    let v63: Dice::US1 = Dice::method25(v1_1.l0.get().clone(), v61);
                    match &v63 {
                        Dice::US1::US1_0(v63_0_0) => {
                            let v64: u8 = match &v63 {
                                Dice::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v66: i64 = (v1_1.l0.get().clone()) + 1_i64;
                            v1_1.l0.set(v66);
                            v4_1.l0.set(Dice::US1::US1_0(v64));
                            v64
                        }
                        _ => {
                            let v70: () = {
                                Dice::closure17((), ());
                                ()
                            };
                            if (v3_1.l0.get().clone()) == -1_i64 {
                                let v112: i64 = v1_1.l0.get().clone();
                                v3_1.l0.set(v112);
                                ()
                            }
                            {
                                let v118: i64 =
                                    if (v2_1.l0.get().clone()) >= (v3_1.l0.get().clone()) {
                                        1_i64
                                    } else {
                                        (v2_1.l0.get().clone()) + 1_i64
                                    };
                                v2_1.l0.set(v118);
                                {
                                    let v120: i64 = (v2_1.l0.get().clone()) - 1_i64;
                                    v1_1.l0.set(v120);
                                    v4_1.l0.set(Dice::US1::US1_1);
                                    {
                                        let v0_1_temp = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Dice::Mut1> = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Dice::Mut1> = v2_1.get().clone();
                                        let v3_1_temp: LrcPtr<Dice::Mut1> = v3_1.get().clone();
                                        let v4_1_temp: LrcPtr<Dice::Mut2> = v4_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        v4_1.set(v4_1_temp);
                                        continue '_method5;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure7(
            v0_1: Func0<LrcPtr<Dice::UH0>>,
            v1_1: LrcPtr<Dice::Mut1>,
            v2_1: LrcPtr<Dice::Mut1>,
            v3_1: LrcPtr<Dice::Mut1>,
            v4_1: LrcPtr<Dice::Mut2>,
            unitVar: (),
        ) -> u8 {
            Dice::method5(v0_1, v1_1, v2_1, v3_1, v4_1)
        }
        pub fn closure3(unitVar: (), v0_1: LrcPtr<Dice::UH1>) -> Func0<u8> {
            let v5: LrcPtr<Dice::UH0> = Dice::method3(
                Dice::method2(
                    v0_1.clone(),
                    Dice::method1(v0_1, LrcPtr::new(Dice::UH1::UH1_0)),
                ),
                LrcPtr::new(Dice::UH0::UH0_1),
            );
            let v7 = Dice::method4(
                v5.clone(),
                Func0::new({
                    let v5 = v5.clone();
                    move || Dice::closure5(v5.clone(), ())
                }),
            );
            let v8: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                l0: MutCell::new(0_i64),
            });
            let v9: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                l0: MutCell::new(1_i64),
            });
            let v10: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                l0: MutCell::new(-1_i64),
            });
            let v12: LrcPtr<Dice::Mut2> = LrcPtr::new(Dice::Mut2 {
                l0: MutCell::new(Dice::US1::US1_1),
            });
            Func0::new({
                let v10 = v10.clone();
                let v12 = v12.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice::closure7(
                        v7.clone(),
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v12.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method30(v0_1: u64, v1_1: u64, v2_1: i8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v11: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice::closure13(v4_1.clone(), string("max"), ());
                ()
            };
            let v29: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice::closure13(v4_1.clone(), string("p"), ());
                ()
            };
            let v63: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice::closure13(v4_1.clone(), string("n"), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method29(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u64,
            v9: u64,
            v10: i8,
        ) -> string {
            let v11: string = Dice::method30(v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.calculate_dice_count"),
                v11
            ))
        }
        pub fn closure21(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method29(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v2_1,
                    v1_1,
                ))
            };
        }
        pub fn method28(v0_1: u64, v1_1: i8, v2_1: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method28: loop {
                break '_method28 (if (v2_1.get().clone()) < (v0_1.get().clone()) {
                    let v4_1: u64 = (v2_1.get().clone()) * 6_u64;
                    if (v4_1) > (v2_1.get().clone()) {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_1_temp: i8 = (v1_1.get().clone()) + 1_i8;
                        let v2_1_temp: u64 = v4_1;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method28;
                    } else {
                        let v10: () = {
                            Dice::closure21(
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
                    let v53: () = {
                        Dice::closure21(
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
        pub fn method34(v0_1: i8, v1_1: u64, v2_1: u64) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v11: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v29: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v63: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice::closure13(v4_1.clone(), string("result"), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method33(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i8,
            v9: u64,
            v10: u64,
        ) -> string {
            let v11: string = Dice::method34(v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure22(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method33(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v1_1,
                    v0_1,
                    v2_1,
                ))
            };
        }
        pub fn closure86(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_1)
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice::closure86((), ())),
            ))
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice::closure85((), ())),
            ))
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice::closure84((), ())),
            ))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice::closure83((), ())),
            ))
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice::closure82((), ())),
            ))
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice::closure81((), ())),
            ))
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice::closure24((), ())),
            ))
        }
        pub fn method35(v0_1: i8, v1_1: LrcPtr<Dice::UH2>) -> Dice::US9 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH2>> = MutCell::new(v1_1.clone());
            '_method35: loop {
                break '_method35 (match v1_1.get().clone().as_ref() {
                    Dice::UH2::UH2_1 => Dice::US9::US9_1,
                    Dice::UH2::UH2_0(v1_1_0_0, v1_1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice::US9::US9_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_1_temp: LrcPtr<Dice::UH2> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method35;
                        }
                    }
                });
            }
        }
        pub fn method37(v0_1: i8, v1_1: u64, v2_1: u8, v3_1: u64) -> string {
            let v5: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v12: () = {
                Dice::closure13(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Dice::closure13(v5.clone(), string("power"), ());
                ()
            };
            let v30: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v5.clone(), string("acc"), ());
                ()
            };
            let v64: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v89: () = {
                Dice::closure13(v5.clone(), string("roll"), ());
                ()
            };
            let v97: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v105: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice::closure13(v5.clone(), string("value"), ());
                ()
            };
            let v130: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v3_1), ());
                ()
            };
            let v147: () = {
                Dice::closure13(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method36(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i8,
            v9: u64,
            v10: u8,
            v11: u64,
        ) -> string {
            let v12: string = Dice::method37(v8, v9, v10, v11);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure87(v0_1: u64, v1_1: i8, v2_1: u8, v3_1: u64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v8: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v25: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v24: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v23: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v22: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method36(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Dice::method13(v22, v23, v24, v25, v26, v27),
                    Dice::method17(),
                    v1_1,
                    v0_1,
                    v2_1,
                    v3_1,
                ))
            };
        }
        pub fn method39(v0_1: i8, v1_1: u64, v2_1: u8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v11: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v29: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v63: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice::closure13(v4_1.clone(), string("roll"), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method38(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i8,
            v9: u64,
            v10: u8,
        ) -> string {
            let v11: string = Dice::method39(v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure88(v0_1: u64, v1_1: i8, v2_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method38(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v1_1,
                    v0_1,
                    v2_1,
                ))
            };
        }
        pub fn method32(v0_1: i8, v1_1: LrcPtr<Dice::UH1>, v2_1: u64) -> Dice::US8 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method32: loop {
                break '_method32 (if (v0_1.get().clone()) < 0_i8 {
                    let v4_1: u64 = (v2_1.get().clone()) + 1_u64;
                    let v7: () = {
                        Dice::closure22(v2_1.get().clone(), v0_1.get().clone(), v4_1, ());
                        ()
                    };
                    Dice::US8::US8_0(v4_1, v1_1.get().clone())
                } else {
                    match v1_1.get().clone().as_ref() {
                        Dice::UH1::UH1_0 => Dice::US8::US8_1,
                        Dice::UH1::UH1_1(v1_1_1_0, v1_1_1_1) => {
                            let v50: LrcPtr<Dice::UH1> = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v49: u8 = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v49) > 1_u8 {
                                let v55: Dice::US9 = Dice::method35(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice::closure23((), ())),
                                    )),
                                );
                                let v62: u64 = (((v49) - 1_u8) as u64)
                                    * (match &v55 {
                                        Dice::US9::US9_0(v55_0_0) => match &v55 {
                                            Dice::US9::US9_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v65: () = {
                                    Dice::closure87(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v49,
                                        v62,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v50;
                                    let v2_1_temp: u64 = (v2_1.get().clone()) + (v62);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method32;
                                }
                            } else {
                                let v110: () = {
                                    Dice::closure88(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v49,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v50.clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method32;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method40(v0_1: i8, v1_1: Func0<u8>, v2_1: i8) -> LrcPtr<Dice::UH1> {
            if (v2_1) < (v0_1) {
                LrcPtr::new(Dice::UH1::UH1_1(
                    v1_1(),
                    Dice::method40(v0_1, v1_1, (v2_1) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice::UH1::UH1_0)
            }
        }
        pub fn method41(
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
            '_method41: loop {
                break '_method41 ({
                    let v5: i8 = (v3_1.get().clone()) + 1_i8;
                    if (v3_1.get().clone()) < (v5) {
                        Dice::method31(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone())),
                            v5,
                        )
                    } else {
                        let v11: Dice::US8 =
                            Dice::method32(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                        if let Dice::US8::US8_0(v11_0_0, v11_0_1) = &v11 {
                            let v12: u64 = v11_0_0.clone();
                            if (v12) <= (v2_1.get().clone()) {
                                v12
                            } else {
                                if v1_1.get().clone() {
                                    let v0_1_temp = v0_1.get().clone();
                                    let v1_1_temp: bool = v1_1.get().clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    let v3_1_temp: i8 = v3_1.get().clone();
                                    let v4_1_temp: LrcPtr<Dice::UH1> = Dice::method40(
                                        v3_1.get().clone(),
                                        v0_1.get().clone(),
                                        0_i8,
                                    );
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method41;
                                } else {
                                    Dice::method31(
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
                                    Dice::method40(v3_1.get().clone(), v0_1.get().clone(), 0_i8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                continue '_method41;
                            } else {
                                Dice::method31(
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
        pub fn method31(
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
            '_method31: loop {
                break '_method31 (if (v5.get().clone()) < ((v3_1.get().clone()) + 1_i8) {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_1_temp: bool = v1_1.get().clone();
                    let v2_1_temp: u64 = v2_1.get().clone();
                    let v3_1_temp: i8 = v3_1.get().clone();
                    let v4_1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone()));
                    let v5_temp: i8 = (v5.get().clone()) + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    v2_1.set(v2_1_temp);
                    v3_1.set(v3_1_temp);
                    v4_1.set(v4_1_temp);
                    v5.set(v5_temp);
                    continue '_method31;
                } else {
                    let v13: Dice::US8 =
                        Dice::method32(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                    if let Dice::US8::US8_0(v13_0_0, v13_0_1) = &v13 {
                        let v14: u64 = v13_0_0.clone();
                        if (v14) <= (v2_1.get().clone()) {
                            v14
                        } else {
                            if v1_1.get().clone() {
                                Dice::method41(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    Dice::method40(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
                                )
                            } else {
                                let v0_1_temp = v0_1.get().clone();
                                let v1_1_temp: bool = v1_1.get().clone();
                                let v2_1_temp: u64 = v2_1.get().clone();
                                let v3_1_temp: i8 = v3_1.get().clone();
                                let v4_1_temp: LrcPtr<Dice::UH1> =
                                    LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone()));
                                let v5_temp: i8 = (v5.get().clone()) + 1_i8;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                v5.set(v5_temp);
                                continue '_method31;
                            }
                        }
                    } else {
                        if v1_1.get().clone() {
                            Dice::method41(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                Dice::method40(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
                            )
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_1_temp: bool = v1_1.get().clone();
                            let v2_1_temp: u64 = v2_1.get().clone();
                            let v3_1_temp: i8 = v3_1.get().clone();
                            let v4_1_temp: LrcPtr<Dice::UH1> =
                                LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone()));
                            let v5_temp: i8 = (v5.get().clone()) + 1_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            v5.set(v5_temp);
                            continue '_method31;
                        }
                    }
                });
            }
        }
        pub fn closure20(v0_1: Func0<u8>, v1_1: bool, v2_1: u64) -> u64 {
            Dice::method31(
                v0_1,
                v1_1,
                v2_1,
                (if (v2_1) == 1_u64 {
                    1_i8
                } else {
                    Dice::method28(v2_1, 0_i8, 1_u64)
                }) - 1_i8,
                LrcPtr::new(Dice::UH1::UH1_0),
                0_i8,
            )
        }
        pub fn closure19(v0_1: Func0<u8>, v1_1: bool) -> Func1<u64, u64> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: u64| Dice::closure20(v0_1.clone(), v1_1, v)
            })
        }
        pub fn closure18(unitVar: (), v0_1: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice::closure19(v0_1.clone(), v)
            })
        }
        pub fn method42(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method42: loop {
                break '_method42 (match v0_1.get().clone().as_ref() {
                    Dice::UH1::UH1_0 => v1_1.get().clone(),
                    Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = match v0_1.get().clone().as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v1_1_temp: i8 = (v1_1.get().clone()) + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method42;
                    }
                });
            }
        }
        pub fn closure90(v0_1: u64, v1_1: LrcPtr<Dice::UH1>) -> Option<u64> {
            let v6: Dice::US8 =
                Dice::method32((Dice::method42(v1_1.clone(), 0_i8)) - 1_i8, v1_1, 0_u64);
            let v16: Dice::US9 = if let Dice::US8::US8_0(v6_0_0, v6_0_1) = &v6 {
                let v7: u64 = v6_0_0.clone();
                if if (v7) >= 1_u64 { (v7) <= (v0_1) } else { false } {
                    Dice::US9::US9_0(v7)
                } else {
                    Dice::US9::US9_1
                }
            } else {
                Dice::US9::US9_1
            };
            match &v16 {
                Dice::US9::US9_0(v16_0_0) => Some(match &v16 {
                    Dice::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<u64>,
            }
        }
        pub fn closure89(unitVar: (), v0_1: u64) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice::UH1>| Dice::closure90(v0_1, v)
            })
        }
        pub fn method44(v0_1: i64, v1_1: i64, v2_1: i8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v11: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice::closure13(v4_1.clone(), string("max"), ());
                ()
            };
            let v29: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice::closure13(v4_1.clone(), string("p"), ());
                ()
            };
            let v63: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice::closure13(v4_1.clone(), string("n"), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method43(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            let v11: string = Dice::method44(i64::MAX, 4738381338321616896_i64, 24_i8);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.calculate_dice_count"),
                v11
            ))
        }
        pub fn closure92(unitVar: (), unitVar_1: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v4_1: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v23: Option<i64> = patternInput.5.clone();
                let v22: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v21: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v20: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v19: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v18: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method43(
                    v18.clone(),
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    Dice::method13(v18, v19, v20, v21, v22, v23),
                    Dice::method17(),
                ))
            };
        }
        pub fn method46() -> u8 {
            panic!("{}", string("common.random\' / target=Rust(Contract)"),)
        }
        pub fn method49(v0_1: i8, v1_1: i64, v2_1: u8, v3_1: i64) -> string {
            let v5: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v12: () = {
                Dice::closure13(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Dice::closure13(v5.clone(), string("power"), ());
                ()
            };
            let v30: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v5.clone(), string("acc"), ());
                ()
            };
            let v64: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v89: () = {
                Dice::closure13(v5.clone(), string("roll"), ());
                ()
            };
            let v97: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v105: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Dice::closure13(v5.clone(), string("value"), ());
                ()
            };
            let v130: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v3_1), ());
                ()
            };
            let v147: () = {
                Dice::closure13(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method48(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(23_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure93(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method48(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method51(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(22_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure94(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method51(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method53(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(21_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure95(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method53(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method55(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(20_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure96(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method55(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method57(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(19_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure97(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method57(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method59(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(18_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure98(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method59(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method61(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(17_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure99(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method61(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method63(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(16_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure100(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method63(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method65(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(15_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure101(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method65(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method67(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(14_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure102(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method67(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method69(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(13_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure103(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method69(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method71(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(12_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure104(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method71(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method73(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(11_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure105(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method73(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method75(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(10_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure106(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method75(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method77(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(9_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure107(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method77(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method79(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(8_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure108(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method79(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method81(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(7_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure109(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method81(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method83(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(6_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure110(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method83(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method85(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(5_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure111(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method85(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method87(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(4_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure112(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method87(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method89(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(3_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure113(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method89(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method91(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(2_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure114(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method91(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method93(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(1_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure115(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method93(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method95(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method49(0_i8, v8, v9, v10);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v12
            ))
        }
        pub fn closure116(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v7: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v24: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v23: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v22: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v21: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method95(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Dice::method13(v21, v22, v23, v24, v25, v26),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                ))
            };
        }
        pub fn method98(v0_1: i8, v1_1: i64, v2_1: i64) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v11: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v29: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v63: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice::closure13(v4_1.clone(), string("result"), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method97(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: i64,
        ) -> string {
            let v11: string = Dice::method98(-1_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure117(v0_1: i64, v1_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method97(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method96(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            let v2_1: i64 = (v1_1) + 1_i64;
            let v5: () = {
                Dice::closure117(v1_1, v2_1, ());
                ()
            };
            Dice::US10::US10_0(v2_1, v0_1)
        }
        pub fn method100(v0_1: i8, v1_1: i64, v2_1: u8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v11: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v29: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v63: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Dice::closure13(v4_1.clone(), string("roll"), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v113: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method99(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(0_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure118(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method99(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method94(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v7: i64 = ((v3_1) - 1_u8) as i64;
                        let v10: () = {
                            Dice::closure116(v1_1, v3_1, v7, ());
                            ()
                        };
                        Dice::method96(v4_1.clone(), (v1_1) + (v7))
                    } else {
                        let v54: () = {
                            Dice::closure118(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method96(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method101(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(1_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure119(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method101(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method92(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 6_i64;
                        let v11: () = {
                            Dice::closure115(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method94(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure119(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method94(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method102(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(2_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure120(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method102(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method90(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 36_i64;
                        let v11: () = {
                            Dice::closure114(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method92(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure120(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method92(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method103(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(3_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure121(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method103(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method88(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 216_i64;
                        let v11: () = {
                            Dice::closure113(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method90(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure121(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method90(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method104(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(4_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure122(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method104(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method86(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 1296_i64;
                        let v11: () = {
                            Dice::closure112(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method88(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure122(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method88(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method105(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(5_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure123(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method105(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method84(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 7776_i64;
                        let v11: () = {
                            Dice::closure111(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method86(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure123(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method86(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method106(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(6_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure124(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method106(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method82(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 46656_i64;
                        let v11: () = {
                            Dice::closure110(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method84(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure124(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method84(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method107(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(7_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure125(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method107(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method80(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 279936_i64;
                        let v11: () = {
                            Dice::closure109(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method82(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure125(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method82(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method108(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(8_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure126(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method108(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method78(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 1679616_i64;
                        let v11: () = {
                            Dice::closure108(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method80(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure126(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method80(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method109(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(9_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure127(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method109(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method76(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 10077696_i64;
                        let v11: () = {
                            Dice::closure107(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method78(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure127(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method78(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method110(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(10_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure128(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method110(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method74(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 60466176_i64;
                        let v11: () = {
                            Dice::closure106(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method76(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure128(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method76(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method111(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(11_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure129(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method111(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method72(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 362797056_i64;
                        let v11: () = {
                            Dice::closure105(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method74(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure129(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method74(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method112(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(12_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure130(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method112(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method70(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 2176782336_i64;
                        let v11: () = {
                            Dice::closure104(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method72(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure130(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method72(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method113(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(13_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure131(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method113(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method68(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 13060694016_i64;
                        let v11: () = {
                            Dice::closure103(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method70(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure131(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method70(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method114(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(14_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure132(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method114(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method66(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 78364164096_i64;
                        let v11: () = {
                            Dice::closure102(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method68(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure132(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method68(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method115(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(15_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure133(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method115(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method64(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 470184984576_i64;
                        let v11: () = {
                            Dice::closure101(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method66(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure133(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method66(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method116(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(16_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure134(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method116(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method62(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 2821109907456_i64;
                        let v11: () = {
                            Dice::closure100(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method64(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure134(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method64(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method117(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(17_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure135(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method117(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method60(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 16926659444736_i64;
                        let v11: () = {
                            Dice::closure99(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method62(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure135(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method62(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method118(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(18_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure136(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method118(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method58(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 101559956668416_i64;
                        let v11: () = {
                            Dice::closure98(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method60(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure136(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method60(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method119(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(19_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure137(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method119(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method56(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 609359740010496_i64;
                        let v11: () = {
                            Dice::closure97(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method58(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure137(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method58(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method120(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(20_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure138(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method120(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method54(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 3656158440062976_i64;
                        let v11: () = {
                            Dice::closure96(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method56(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure138(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method56(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method121(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(21_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure139(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method121(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method52(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 21936950640377856_i64;
                        let v11: () = {
                            Dice::closure95(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method54(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure139(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method54(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method122(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(22_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure140(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method122(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method50(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 131621703842267136_i64;
                        let v11: () = {
                            Dice::closure94(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method52(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure140(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method52(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method123(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
            v9: u8,
        ) -> string {
            let v11: string = Dice::method100(23_i8, v8, v9);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.accumulate_dice_rolls"),
                v11
            ))
        }
        pub fn closure141(v0_1: i64, v1_1: u8, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v6: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v23: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v22: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v21: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v20: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method123(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Dice::method13(v20, v21, v22, v23, v24, v25),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method47(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US10 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US10::US10_1,
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v3_1: u8 = match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if (v3_1) > 1_u8 {
                        let v8: i64 = (((v3_1) - 1_u8) as i64) * 789730223053602816_i64;
                        let v11: () = {
                            Dice::closure93(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method50(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v55: () = {
                            Dice::closure141(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method50(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method45(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i64 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method45: loop {
                break '_method45 (if (v1_1.get().clone()) < 24_i8 {
                    let v0_1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(), v0_1.get().clone()));
                    let v1_1_temp: i8 = (v1_1.get().clone()) + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method45;
                } else {
                    let v8: Dice::US10 = Dice::method47(v0_1.get().clone(), 0_i64);
                    if let Dice::US10::US10_0(v8_0_0, v8_0_1) = &v8 {
                        let v9: i64 = v8_0_0.clone();
                        if (v9) <= i64::MAX {
                            v9
                        } else {
                            let v0_1_temp: LrcPtr<Dice::UH1> =
                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                            let v1_1_temp: i8 = 23_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method45;
                        }
                    } else {
                        let v0_1_temp: LrcPtr<Dice::UH1> =
                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method46(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                        let v1_1_temp: i8 = 23_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method45;
                    }
                });
            }
        }
        pub fn method125(v0_1: i64) -> string {
            let v2_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            let v9: () = {
                Dice::closure13(v2_1.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Dice::closure13(v2_1.clone(), string("result"), ());
                ()
            };
            let v27: () = {
                Dice::closure13(v2_1.clone(), string(" = "), ());
                ()
            };
            let v35: () = {
                Dice::closure13(v2_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Dice::closure13(v2_1.clone(), string(" }"), ());
                ()
            };
            v2_1.l0.get().clone()
        }
        pub fn method124(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i64,
        ) -> string {
            let v9: string = Dice::method125(v8);
            Dice::method23(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("dice.main"),
                v9
            ))
        }
        pub fn closure142(v0_1: i64, unitVar: ()) {
            if Dice::method6(Dice::US2::US2_1) {
                let v5: () = {
                    Dice::closure9((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Dice::Mut6> = patternInput.4.clone();
                let v22: LrcPtr<Dice::Mut5> = patternInput.3.clone();
                let v21: LrcPtr<Dice::Mut4> = patternInput.2.clone();
                let v20: LrcPtr<Dice::Mut3> = patternInput.1.clone();
                let v19: LrcPtr<Dice::Mut1> = patternInput.0.clone();
                Dice::method24(Dice::method124(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Dice::method13(v19, v20, v21, v22, v23, v24),
                    Dice::method17(),
                    v0_1,
                ))
            };
        }
        pub fn closure91(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3_1: () = {
                Dice::closure92((), ());
                ()
            };
            let v48: () = {
                Dice::closure142(Dice::method45(LrcPtr::new(Dice::UH1::UH1_0), 0_i8), ());
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
            v2.get_or_init(|| Func1::new(move |v: Func0<u8>| Dice::closure18((), v)))
                .clone()
        }
        pub fn roll_progressively(x: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            (Dice::v2())(x)
        }
        pub fn v3() -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>> {
            static v3: OnceInit<Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>>> =
                OnceInit::new();
            v3.get_or_init(|| Func1::new(move |v: u64| Dice::closure89((), v)))
                .clone()
        }
        pub fn roll_within_bounds(x: u64) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            (Dice::v3())(x)
        }
        pub fn v4() -> Func1<Array<string>, i32> {
            static v4: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v4.get_or_init(|| Func1::new(move |v: Array<string>| Dice::closure91((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Dice::v4())(args)
        }
    }
}
pub use module_7c9aa503::*;
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
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::main(array_from(args));
}
