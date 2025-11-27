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
        use fable_library_rust::Exception_::try_catch;
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
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Exception;
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
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(i32),
            US0_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(i32),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US2 {
            US2_0(usize),
            US2_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0(usize),
            US3_1,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0,
            US4_1,
            US4_2,
            US4_3,
            US4_4,
        }
        impl core::fmt::Display for US4 {
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
            pub l0: MutCell<Dice_contract::US4>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0(Dice_contract::US4),
            US5_1,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US6 {
            US6_0(i64),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US7 {
            US7_0,
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(Dice_contract::US7),
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0,
            US9_1,
            US9_2,
            US9_3,
            US9_4,
            US9_5(Dice_contract::US8),
            US9_6,
            US9_7,
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US10 {
            US10_0(string),
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(i64),
            US11_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ),
            US12_1,
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US13 {
            US13_0(char),
            US13_1,
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut5 {
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
        pub enum US14 {
            US14_0(Func0<LrcPtr<Dice_contract::UH1>>),
            US14_1(LrcPtr<Dice_contract::UH1>),
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut6 {
            pub l0: MutCell<Dice_contract::US14>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US15 {
            US15_0(u8),
            US15_1,
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut7 {
            pub l0: MutCell<Dice_contract::US15>,
        }
        impl core::fmt::Display for Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US16 {
            US16_0(u64, LrcPtr<Dice_contract::UH0>),
            US16_1,
        }
        impl core::fmt::Display for US16 {
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
        pub enum US17 {
            US17_0(u64),
            US17_1,
        }
        impl core::fmt::Display for US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(v0_1: u32, unitVar: ()) -> i32 {
            v0_1 as i32
        }
        pub fn closure2(unitVar: (), v0_1: i32) -> Dice_contract::US0 {
            Dice_contract::US0::US0_0(v0_1)
        }
        pub fn closure3(unitVar: (), v0_1: Func0<LrcPtr<Exception>>) -> LrcPtr<Exception> {
            v0_1()
        }
        pub fn closure4(unitVar: (), v0_1: LrcPtr<Exception>) -> Dice_contract::US0 {
            Dice_contract::US0::US0_1(v0_1)
        }
        pub fn method0(v0_1: u32) -> Dice_contract::US0 {
            try_catch(
                || Dice_contract::closure2((), Dice_contract::closure1(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Dice_contract::closure4(
                        (),
                        Dice_contract::closure3(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> usize {
            100_i32 as usize
        }
        pub fn closure6(unitVar: (), v0_1: usize) -> Dice_contract::US2 {
            Dice_contract::US2::US2_0(v0_1)
        }
        pub fn closure7(unitVar: (), v0_1: LrcPtr<Exception>) -> Dice_contract::US2 {
            Dice_contract::US2::US2_1(v0_1)
        }
        pub fn method1() -> Dice_contract::US2 {
            try_catch(
                || Dice_contract::closure6((), Dice_contract::closure5((), ())),
                |ex: LrcPtr<Exception>| {
                    Dice_contract::closure7(
                        (),
                        Dice_contract::closure3(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn closure8(v0_1: usize, unitVar: ()) -> i32 {
            v0_1 as i32
        }
        pub fn method2(v0_1: usize) -> Dice_contract::US0 {
            try_catch(
                || Dice_contract::closure2((), Dice_contract::closure8(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Dice_contract::closure4(
                        (),
                        Dice_contract::closure3(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn method7() -> string {
            string("")
        }
        pub fn method10() -> string {
            string("")
        }
        pub fn method11(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string) {
            let v5: string = append((v0_1.l0.get().clone()), (v1));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method9(v0_1: Dice_contract::US9) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method11(v12.clone(), sprintf!("{:?}", v0_1));
            v12.l0.get().clone()
        }
        pub fn method12(v0_1: string) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method11(v12.clone(), v0_1);
            v12.l0.get().clone()
        }
        pub fn method8(v0_1: string) -> string {
            panic!(
                "{}",
                append(
                    (append(
                        (append(
                            string("env.get_environment_variable / target: "),
                            (Dice_contract::method9(Dice_contract::US9::US9_5(
                                Dice_contract::US8::US8_0(Dice_contract::US7::US7_0)
                            )))
                        )),
                        string(" / var: ")
                    )),
                    (Dice_contract::method12(v0_1))
                ),
            )
        }
        pub fn method13(v0_1: string) -> string {
            panic!(
                "{}",
                append(
                    (append(
                        (append(
                            string("env.get_environment_variable / target: "),
                            (Dice_contract::method9(Dice_contract::US9::US9_5(
                                Dice_contract::US8::US8_0(Dice_contract::US7::US7_1)
                            )))
                        )),
                        string(" / var: ")
                    )),
                    (Dice_contract::method12(v0_1))
                ),
            )
        }
        pub fn closure11(unitVar: (), v0_1: string) -> Dice_contract::US10 {
            Dice_contract::US10::US10_0(v0_1)
        }
        pub fn method14() -> Func1<string, Dice_contract::US10> {
            Func1::new(move |v: string| Dice_contract::closure11((), v))
        }
        pub fn method5(v0_1: string) -> string {
            Dice_contract::method13(v0_1)
        }
        pub fn closure12(v0_1: i64, unitVar: ()) -> i64 {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: i64) -> Dice_contract::US11 {
            Dice_contract::US11::US11_0(v0_1)
        }
        pub fn closure14(unitVar: (), v0_1: LrcPtr<Exception>) -> Dice_contract::US11 {
            Dice_contract::US11::US11_1(v0_1)
        }
        pub fn method15(v0_1: i64) -> Dice_contract::US11 {
            try_catch(
                || Dice_contract::closure13((), Dice_contract::closure12(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Dice_contract::closure14(
                        (),
                        Dice_contract::closure3(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn method4() -> (Dice_contract::US5, Dice_contract::US6) {
            let v1: string = Dice_contract::method5(string("TRACE_LEVEL"));
            let v8: string = toLower(string("Critical"));
            let v26: string = toLower(string("Warning"));
            let v44: string = toLower(string("Info"));
            let v62: string = toLower(string("Debug"));
            let v80: string = toLower(string("Verbose"));
            let v96: Dice_contract::US5 = if string("Verbose") == (v1.clone()) {
                Dice_contract::US5::US5_0(Dice_contract::US4::US4_0)
            } else {
                Dice_contract::US5::US5_1
            };
            (
                match &v96 {
                    Dice_contract::US5::US5_0(v96_0_0) => Dice_contract::US5::US5_0(
                        match &v96 {
                            Dice_contract::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v103: Dice_contract::US5 = if string("Debug") == (v1.clone()) {
                            Dice_contract::US5::US5_0(Dice_contract::US4::US4_1)
                        } else {
                            Dice_contract::US5::US5_1
                        };
                        match &v103 {
                            Dice_contract::US5::US5_0(v103_0_0) => Dice_contract::US5::US5_0(
                                match &v103 {
                                    Dice_contract::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v110: Dice_contract::US5 = if string("Info") == (v1.clone()) {
                                    Dice_contract::US5::US5_0(Dice_contract::US4::US4_2)
                                } else {
                                    Dice_contract::US5::US5_1
                                };
                                match &v110 {
                                    Dice_contract::US5::US5_0(v110_0_0) => {
                                        Dice_contract::US5::US5_0(
                                            match &v110 {
                                                Dice_contract::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v117: Dice_contract::US5 =
                                            if string("Warning") == (v1.clone()) {
                                                Dice_contract::US5::US5_0(Dice_contract::US4::US4_3)
                                            } else {
                                                Dice_contract::US5::US5_1
                                            };
                                        match &v117 {
                                            Dice_contract::US5::US5_0(v117_0_0) => {
                                                Dice_contract::US5::US5_0(
                                                    match &v117 {
                                                        Dice_contract::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v124: Dice_contract::US5 =
                                                    if string("Critical") == (v1.clone()) {
                                                        Dice_contract::US5::US5_0(
                                                            Dice_contract::US4::US4_4,
                                                        )
                                                    } else {
                                                        Dice_contract::US5::US5_1
                                                    };
                                                match &v124 {
                                                    Dice_contract::US5::US5_0(v124_0_0) => {
                                                        Dice_contract::US5::US5_0(
                                                            match &v124 {
                                                                Dice_contract::US5::US5_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v131: Dice_contract::US5 =
                                                            if (v80.clone()) == (v1.clone()) {
                                                                Dice_contract::US5::US5_0(
                                                                    Dice_contract::US4::US4_0,
                                                                )
                                                            } else {
                                                                Dice_contract::US5::US5_1
                                                            };
                                                        match &v131 {
                                                         Dice_contract::US5::US5_0(v131_0_0)
                                                         =>
                                                         Dice_contract::US5::US5_0(match &v131
                                                                                       {
                                                                                       Dice_contract::US5::US5_0(x)
                                                                                       =>
                                                                                       x.clone(),
                                                                                       _
                                                                                       =>
                                                                                       unreachable!(),
                                                                                   }.clone()),
                                                         _ => {
                                                             let v138:
                                                                     Dice_contract::US5 =
                                                                 if (v62.clone())
                                                                        ==
                                                                        (v1.clone())
                                                                    {
                                                                     Dice_contract::US5::US5_0(Dice_contract::US4::US4_1)
                                                                 } else {
                                                                     Dice_contract::US5::US5_1
                                                                 };
                                                             match &v138 {
                                                                 Dice_contract::US5::US5_0(v138_0_0)
                                                                 =>
                                                                 Dice_contract::US5::US5_0(match &v138
                                                                                               {
                                                                                               Dice_contract::US5::US5_0(x)
                                                                                               =>
                                                                                               x.clone(),
                                                                                               _
                                                                                               =>
                                                                                               unreachable!(),
                                                                                           }.clone()),
                                                                 _ => {
                                                                     let v145:
                                                                             Dice_contract::US5 =
                                                                         if (v44.clone())
                                                                                ==
                                                                                (v1.clone())
                                                                            {
                                                                             Dice_contract::US5::US5_0(Dice_contract::US4::US4_2)
                                                                         } else {
                                                                             Dice_contract::US5::US5_1
                                                                         };
                                                                     match &v145
                                                                         {
                                                                         Dice_contract::US5::US5_0(v145_0_0)
                                                                         =>
                                                                         Dice_contract::US5::US5_0(match &v145
                                                                                                       {
                                                                                                       Dice_contract::US5::US5_0(x)
                                                                                                       =>
                                                                                                       x.clone(),
                                                                                                       _
                                                                                                       =>
                                                                                                       unreachable!(),
                                                                                                   }.clone()),
                                                                         _ =>
                                                                         {
                                                                             let v152:
                                                                                     Dice_contract::US5 =
                                                                                 if (v26.clone())
                                                                                        ==
                                                                                        (v1.clone())
                                                                                    {
                                                                                     Dice_contract::US5::US5_0(Dice_contract::US4::US4_3)
                                                                                 } else {
                                                                                     Dice_contract::US5::US5_1
                                                                                 };
                                                                             match &v152
                                                                                 {
                                                                                 Dice_contract::US5::US5_0(v152_0_0)
                                                                                 =>
                                                                                 Dice_contract::US5::US5_0(match &v152
                                                                                                               {
                                                                                                               Dice_contract::US5::US5_0(x)
                                                                                                               =>
                                                                                                               x.clone(),
                                                                                                               _
                                                                                                               =>
                                                                                                               unreachable!(),
                                                                                                           }.clone()),
                                                                                 _
                                                                                 =>
                                                                                 {
                                                                                     let v159:
                                                                                             Dice_contract::US5 =
                                                                                         if (v8.clone())
                                                                                                ==
                                                                                                (v1.clone())
                                                                                            {
                                                                                             Dice_contract::US5::US5_0(Dice_contract::US4::US4_4)
                                                                                         } else {
                                                                                             Dice_contract::US5::US5_1
                                                                                         };
                                                                                     match &v159
                                                                                         {
                                                                                         Dice_contract::US5::US5_0(v159_0_0)
                                                                                         =>
                                                                                         Dice_contract::US5::US5_0(match &v159
                                                                                                                       {
                                                                                                                       Dice_contract::US5::US5_0(x)
                                                                                                                       =>
                                                                                                                       x.clone(),
                                                                                                                       _
                                                                                                                       =>
                                                                                                                       unreachable!(),
                                                                                                                   }.clone()),
                                                                                         _
                                                                                         =>
                                                                                         Dice_contract::US5::US5_1,
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
                if (Dice_contract::method5(string("AUTOMATION"))) != string("True") {
                    Dice_contract::US6::US6_1
                } else {
                    let v236: DateTime = unbox::<DateTime>(fable_library_rust::Native_::getZero());
                    let v463: Dice_contract::US11 = Dice_contract::method15(unbox::<i64>(
                        fable_library_rust::Native_::getZero(),
                    ));
                    let v484: Dice_contract::US6 = match &v463 {
                        Dice_contract::US11::US11_0(v463_0_0) => {
                            Dice_contract::US6::US6_0(v463_0_0.clone())
                        }
                        _ => Dice_contract::US6::US6_1,
                    };
                    Dice_contract::US6::US6_0(match &v484 {
                        Dice_contract::US6::US6_0(v484_0_0) => match &v484 {
                            Dice_contract::US6::US6_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    })
                },
            )
        }
        pub fn closure15(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method3(
            v0_1: Dice_contract::US4,
        ) -> (
            LrcPtr<Dice_contract::Mut0>,
            LrcPtr<Dice_contract::Mut1>,
            LrcPtr<Dice_contract::Mut2>,
            LrcPtr<Dice_contract::Mut3>,
            LrcPtr<Dice_contract::Mut4>,
            Option<i64>,
        ) {
            let v260: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v261: &str = option_env!("AUTOMATION").unwrap_or("");
            let v296: std::string::String = String::from(v261);
            let _run_target_args__v5: (Dice_contract::US5, Dice_contract::US6) = (
                Dice_contract::US5::US5_1,
                if (fable_library_rust::String_::fromString(v296)) != string("True") {
                    Dice_contract::US6::US6_1
                } else {
                    Dice_contract::US6::US6_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v563: Dice_contract::US6 = _run_target_args__v5.1.clone();
            let v562: Dice_contract::US5 = _run_target_args__v5.0.clone();
            (
                LrcPtr::new(Dice_contract::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Dice_contract::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Dice_contract::closure15((), v))),
                }),
                LrcPtr::new(Dice_contract::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Dice_contract::Mut4 {
                    l0: MutCell::new(match &v562 {
                        Dice_contract::US5::US5_0(v562_0_0) => match &v562 {
                            Dice_contract::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v563 {
                    Dice_contract::US6::US6_0(v563_0_0) => Some(match &v563 {
                        Dice_contract::US6::US6_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) {
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
                ) = Dice_contract::method3(Dice_contract::US4::US4_0);
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
        pub fn closure16(unitVar: (), v0_1: i64) -> Dice_contract::US6 {
            Dice_contract::US6::US6_0(v0_1)
        }
        pub fn method17() -> Func1<i64, Dice_contract::US6> {
            Func1::new(move |v: i64| Dice_contract::closure16((), v))
        }
        pub fn method18() -> string {
            string("hh:mm:ss")
        }
        pub fn method19() -> string {
            string("HH:mm:ss")
        }
        pub fn method16(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v3344: u64 = near_sdk::env::block_timestamp();
            let v3470: Dice_contract::US6 = defaultValue(
                Dice_contract::US6::US6_1,
                map(Dice_contract::method17(), v5),
            );
            let v3579: u64 = (match &v3470 {
                Dice_contract::US6::US6_0(v3470_0_0) => {
                    (v3344)
                        - (match &v3470 {
                            Dice_contract::US6::US6_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v3344,
            }) / 1000000000_u64;
            let v3580: u64 = (v3579) % 60_u64;
            let v3582: u64 = ((v3579) / 60_u64) % 60_u64;
            let v3584: u64 = ((v3579) / 3600_u64) % 24_u64;
            let v3586: std::string::String = format!("{:02}:{:02}:{:02}", v3584, v3582, v3580);
            fable_library_rust::String_::fromString(v3586)
        }
        pub fn method21(v0_1: char) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method11(v12.clone(), sprintf!("{}", v0_1));
            v12.l0.get().clone()
        }
        pub fn method20() -> string {
            let v224: &str = inline_colorization::color_bright_blue;
            let v259: std::string::String = String::from(v224);
            let v361: string = append(
                (fable_library_rust::String_::fromString(v259)),
                (Dice_contract::method21(getCharAt(toLower(string("Debug")), 0_i32))),
            );
            let v597: &str = inline_colorization::color_reset;
            let v632: std::string::String = String::from(v597);
            append((v361), (fable_library_rust::String_::fromString(v632)))
        }
        pub fn method23(v0_1: i64) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method11(v12.clone(), sprintf!("{}", v0_1));
            v12.l0.get().clone()
        }
        pub fn method25(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("{ "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method26(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("seed_excess_len"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method27(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" = "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method28(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("; "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method29(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("seed_excess"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method30(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" }"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method24(v0_1: i32, v1: string) -> string {
            let v13: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v13.clone());
            Dice_contract::method26(v13.clone());
            Dice_contract::method27(v13.clone());
            Dice_contract::method11(v13.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v13.clone());
            Dice_contract::method29(v13.clone());
            Dice_contract::method27(v13.clone());
            Dice_contract::method11(v13.clone(), v1);
            Dice_contract::method30(v13.clone());
            v13.l0.get().clone()
        }
        pub fn method33(v0_1: char, v1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1: MutCell<i64> = MutCell::new(v1);
            '_method33: loop {
                break '_method33 (if (v1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Dice_contract::US13 = if (v1.get().clone()) == 0_i64 {
                        Dice_contract::US13::US13_0(' ')
                    } else {
                        let v5: i64 = (v1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Dice_contract::US13::US13_0('\t')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Dice_contract::US13::US13_0('\r')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Dice_contract::US13::US13_0('\n')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Dice_contract::US13::US13_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Dice_contract::US13::US13_0(v19_0_0) => match &v19 {
                                Dice_contract::US13::US13_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_temp: i64 = (v1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method33;
                    }
                });
            }
        }
        pub fn method32(v0_1: string, v1: i32, v2: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            let v2: MutCell<i32> = MutCell::new(v2);
            '_method32: loop {
                break '_method32 (if (v2.get().clone()) >= (v1.get().clone()) {
                    v1.get().clone()
                } else {
                    if Dice_contract::method33(
                        getCharAt(v0_1.get().clone(), v2.get().clone()),
                        0_i64,
                    ) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone();
                        let v2_temp: i32 = (v2.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        continue '_method32;
                    } else {
                        v2.get().clone()
                    }
                });
            }
        }
        pub fn method35(v0_1: char, v1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1: MutCell<i64> = MutCell::new(v1);
            '_method35: loop {
                break '_method35 (if (v1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Dice_contract::US13 = if (v1.get().clone()) == 0_i64 {
                        Dice_contract::US13::US13_0(' ')
                    } else {
                        let v5: i64 = (v1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Dice_contract::US13::US13_0('/')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Dice_contract::US13::US13_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Dice_contract::US13::US13_0(v11_0_0) => match &v11 {
                                Dice_contract::US13::US13_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_temp: i64 = (v1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method35;
                    }
                });
            }
        }
        pub fn method34(v0_1: string, v1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method34: loop {
                break '_method34 (if (v1.get().clone()) <= 0_i32 {
                    0_i32
                } else {
                    let v3: i32 = (v1.get().clone()) - 1_i32;
                    if Dice_contract::method35(getCharAt(v0_1.get().clone(), v3), 0_i64) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_temp: i32 = v3;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method34;
                    } else {
                        v3
                    }
                });
            }
        }
        pub fn method31(v0_1: string) -> string {
            let v1: i32 = length(v0_1.clone());
            let v716: string = getSlice(
                v0_1.clone(),
                Some(Dice_contract::method32(v0_1, v1, 0_i32)),
                Some(v1),
            );
            getSlice(
                v716.clone(),
                Some(0_i32),
                Some(Dice_contract::method34(v716.clone(), length(v716))),
            )
        }
        pub fn method22(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice_contract.contribute_seed"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method24(v8, v9)),
            ))
        }
        pub fn closure17(v0_1: LrcPtr<Dice_contract::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure19(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure18(unitVar: (), v0_1: string) {
            let v33: () = {
                Dice_contract::closure19(v0_1, ());
                ()
            };
            ()
        }
        pub fn method36(v0_1: i32, v1: LrcPtr<Dice_contract::Mut5>) -> bool {
            (v1.l0.get().clone()) < (v0_1)
        }
        pub fn closure9(v0_1: i32, v1: Vec<u8>, unitVar: ()) {
            fn v63() {
                Dice_contract::closure10((), ());
            }
            let v64: () = {
                v63();
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
            let v160: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v710: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v160,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v229: () = {
                    v63();
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
                let v283: Option<i64> = patternInput_1.5.clone();
                let v282: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v281: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v280: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v279: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v278: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v341: string = Dice_contract::method22(
                    v278.clone(),
                    v279.clone(),
                    v280.clone(),
                    v281.clone(),
                    v282.clone(),
                    v283.clone(),
                    Dice_contract::method16(v278, v279, v280, v281, v282, v283),
                    Dice_contract::method20(),
                    v0_1,
                    sprintf!("{:?}", v1),
                );
                let v403: () = {
                    v63();
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
                let v455: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v453: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v452: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v505: () = {
                    Dice_contract::closure17(v452.clone(), ());
                    ()
                };
                let v554: string = if (v455.l0.get().clone()) == string("") {
                    v341.clone()
                } else {
                    if (v341.clone()) == string("") {
                        v455.l0.get().clone()
                    } else {
                        append(
                            (append((v455.l0.get().clone()), string("\n"))),
                            (v341.clone()),
                        )
                    }
                };
                let v589: &str = &*v554.clone();
                let v662 = v589.chars();
                let v664 = v662;
                let v666: Vec<char> = v664.collect::<Vec<_>>();
                let v668: Vec<Vec<char>> = v666
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v670: bool = true;
                let _vec_map: Vec<_> = v668
                    .into_iter()
                    .map(|x| {
                        //;
                        let v672: Vec<char> = x;
                        let v674: std::string::String = String::from_iter(v672);
                        let v676: bool = true;
                        v674
                    })
                    .collect::<Vec<_>>();
                let v678: Vec<std::string::String> = _vec_map;
                let v680: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v678.clone());
                let v681: i32 = get_Count(v680.clone());
                if if (v341.clone()) != string("") {
                    (v681) <= 1_i32
                } else {
                    false
                } {
                    v455.l0.set(v554);
                    ()
                } else {
                    v455.l0.set(string(""));
                    {
                        let v701: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v681, v701.clone()) {
                            let v703: i32 = v701.l0.get().clone();
                            let v704: std::string::String = v680[v703].clone();
                            let v706: bool = true;
                            near_sdk::log!("{}", v704);
                            let v707: i32 = (v703) + 1_i32;
                            v701.l0.set(v707);
                            ()
                        }
                        ()
                    }
                }
                (v453.l0.get().clone())(v341);
                Dice_contract::US12::US12_0(
                    v452,
                    v453,
                    patternInput_2.2.clone(),
                    v455,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method37() -> Func0<()> {
            Func0::new(move || Dice_contract::closure20((), ()))
        }
        pub fn closure21(v0_1: Func0<()>, unitVar: ()) {
            fn v62() {
                Dice_contract::closure10((), ());
            }
            let v63: () = {
                v62();
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
            let v159: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v692: Dice_contract::US12 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v159,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US12::US12_1
                } else {
                    let v228: () = {
                        v62();
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
                    let v324: string = Dice_contract::method16(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v325: string = Dice_contract::method20();
                    let v387: () = {
                        v62();
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
                    let v439: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v437: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v436: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v489: () = {
                        Dice_contract::closure17(v436.clone(), ());
                        ()
                    };
                    let v539: string = if (v439.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v439.l0.get().clone()
                    };
                    let v574: &str = &*v539;
                    let v647 = v574.chars();
                    let v649 = v647;
                    let v651: Vec<char> = v649.collect::<Vec<_>>();
                    let v653: Vec<Vec<char>> = v651
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v655: bool = true;
                    let _vec_map: Vec<_> = v653
                        .into_iter()
                        .map(|x| {
                            //;
                            let v657: Vec<char> = x;
                            let v659: std::string::String = String::from_iter(v657);
                            let v661: bool = true;
                            v659
                        })
                        .collect::<Vec<_>>();
                    let v663: Vec<std::string::String> = _vec_map;
                    let v665: Array<std::string::String> =
                        fable_library_rust::NativeArray_::array_from(v663.clone());
                    let v666: i32 = get_Count(v665.clone());
                    v439.l0.set(string(""));
                    {
                        let v683: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v666, v683.clone()) {
                            let v685: i32 = v683.l0.get().clone();
                            let v686: std::string::String = v665[v685].clone();
                            let v688: bool = true;
                            near_sdk::log!("{}", v686);
                            let v689: i32 = (v685) + 1_i32;
                            v683.l0.set(v689);
                            ()
                        }
                        ()
                    }
                    (v437.l0.get().clone())(string(""));
                    Dice_contract::US12::US12_0(
                        v436,
                        v437,
                        patternInput_2.2.clone(),
                        v439,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ();
            ()
        }
        pub fn closure23(v0_1: u8, v1: LrcPtr<Dice_contract::UH0>) -> LrcPtr<Dice_contract::UH0> {
            LrcPtr::new(Dice_contract::UH0::UH0_1(v0_1, v1))
        }
        pub fn closure22(
            unitVar: (),
            v0_1: u8,
        ) -> Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_contract::UH0>| Dice_contract::closure23(v0_1, v)
            })
        }
        pub fn method38() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure22((), v))
        }
        pub fn closure24(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method39(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: LrcPtr<Dice_contract::UH1> = Dice_contract::method39(
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
                            move || Dice_contract::closure24(v4.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure25(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method40(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v5: LrcPtr<Dice_contract::UH1> =
                        Dice_contract::method40((v0_1_0_1)(), v1.clone());
                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                        (((((v0_1_0_0.clone() as i64) - 1_i64) + 6_i64) % 6_i64) + 1_i64) as u8,
                        Func0::new({
                            let v5 = v5.clone();
                            move || Dice_contract::closure25(v5.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn method41(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    LrcPtr::new(Dice_contract::UH0::UH0_1(
                        v0_1_0_0.clone(),
                        Dice_contract::method41((v0_1_0_1)(), v1.clone()),
                    ))
                }
            }
        }
        pub fn method42(v0_1: LrcPtr<Dice_contract::UH0>, v1: List<u8>) -> List<u8> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice_contract::method42(
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
        pub fn method45(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("max"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method46(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("key"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method47(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("proof"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method48(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("block_timestamp"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method49(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("block_height"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method50(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("epoch_height"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method51(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("account_balance"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method52(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("signer_account_id"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method53(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("predecessor_account_id"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method54(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("seed"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method55(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("seeds"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method56(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("entropy_len"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method57(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("entropy"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method58(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("hash_u8"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method59(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("rolls"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method44(
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
            let v26: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v26.clone());
            Dice_contract::method45(v26.clone());
            Dice_contract::method27(v26.clone());
            Dice_contract::method11(v26.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v26.clone());
            Dice_contract::method46(v26.clone());
            Dice_contract::method27(v26.clone());
            {
                let v966: std::string::String = format!("{:#?}", v1);
                Dice_contract::method11(v26.clone(), fable_library_rust::String_::fromString(v966));
                Dice_contract::method28(v26.clone());
                Dice_contract::method47(v26.clone());
                Dice_contract::method27(v26.clone());
                {
                    let v1574: std::string::String = format!("{:#?}", v2);
                    Dice_contract::method11(
                        v26.clone(),
                        fable_library_rust::String_::fromString(v1574),
                    );
                    Dice_contract::method28(v26.clone());
                    Dice_contract::method48(v26.clone());
                    Dice_contract::method27(v26.clone());
                    Dice_contract::method11(v26.clone(), sprintf!("{}", v3));
                    Dice_contract::method28(v26.clone());
                    Dice_contract::method49(v26.clone());
                    Dice_contract::method27(v26.clone());
                    Dice_contract::method11(v26.clone(), sprintf!("{}", v4));
                    Dice_contract::method28(v26.clone());
                    Dice_contract::method50(v26.clone());
                    Dice_contract::method27(v26.clone());
                    Dice_contract::method11(v26.clone(), sprintf!("{}", v5));
                    Dice_contract::method28(v26.clone());
                    Dice_contract::method51(v26.clone());
                    Dice_contract::method27(v26.clone());
                    Dice_contract::method11(v26.clone(), v6);
                    Dice_contract::method28(v26.clone());
                    Dice_contract::method52(v26.clone());
                    Dice_contract::method27(v26.clone());
                    {
                        let v4256: std::string::String = format!("{:#?}", v7);
                        Dice_contract::method11(
                            v26.clone(),
                            fable_library_rust::String_::fromString(v4256),
                        );
                        Dice_contract::method28(v26.clone());
                        Dice_contract::method53(v26.clone());
                        Dice_contract::method27(v26.clone());
                        {
                            let v4864: std::string::String = format!("{:#?}", v8);
                            Dice_contract::method11(
                                v26.clone(),
                                fable_library_rust::String_::fromString(v4864),
                            );
                            Dice_contract::method28(v26.clone());
                            Dice_contract::method54(v26.clone());
                            Dice_contract::method27(v26.clone());
                            Dice_contract::method11(v26.clone(), v9);
                            Dice_contract::method28(v26.clone());
                            Dice_contract::method55(v26.clone());
                            Dice_contract::method27(v26.clone());
                            Dice_contract::method11(v26.clone(), v10);
                            Dice_contract::method28(v26.clone());
                            Dice_contract::method56(v26.clone());
                            Dice_contract::method27(v26.clone());
                            {
                                let v6464: std::string::String = format!("{:#?}", v11);
                                Dice_contract::method11(
                                    v26.clone(),
                                    fable_library_rust::String_::fromString(v6464),
                                );
                                Dice_contract::method28(v26.clone());
                                Dice_contract::method57(v26.clone());
                                Dice_contract::method27(v26.clone());
                                Dice_contract::method11(v26.clone(), v12);
                                Dice_contract::method28(v26.clone());
                                Dice_contract::method58(v26.clone());
                                Dice_contract::method27(v26.clone());
                                Dice_contract::method11(v26.clone(), v13);
                                Dice_contract::method28(v26.clone());
                                Dice_contract::method59(v26.clone());
                                Dice_contract::method27(v26.clone());
                                Dice_contract::method11(v26.clone(), v14);
                                Dice_contract::method30(v26.clone());
                                v26.l0.get().clone()
                            }
                        }
                    }
                }
            }
        }
        pub fn method43(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice_contract.generate_random_number"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method44(
                    v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22,
                )),
            ))
        }
        pub fn closure26(
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
            fn v75() {
                Dice_contract::closure10((), ());
            }
            let v76: () = {
                v75();
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
            let v172: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v837: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v172,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v241: () = {
                    v75();
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
                let v295: Option<i64> = patternInput_1.5.clone();
                let v294: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v293: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v292: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v291: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v290: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v337: string = Dice_contract::method16(
                    v290.clone(),
                    v291.clone(),
                    v292.clone(),
                    v293.clone(),
                    v294.clone(),
                    v295.clone(),
                );
                let v338: string = Dice_contract::method20();
                let v341: string = sprintf!("{:?}", v8);
                let v354: std::string::String = v9.to_string();
                let v356: std::string::String = v10.to_string();
                let v359: string = sprintf!("{:?}", v4);
                let v373: string = sprintf!("{:?}", v0_1);
                let v386: usize = v11.clone().len();
                let v389: string = sprintf!("{:?}", v11);
                let v403: string = sprintf!("{:?}", v12);
                let v440: Array<u8> = toArray(Dice_contract::method42(v13, empty::<u8>()));
                let v468: string = Dice_contract::method43(
                    v290,
                    v291,
                    v292,
                    v293,
                    v294,
                    v295,
                    v337,
                    v338,
                    v3,
                    v1,
                    v2,
                    v7,
                    v6,
                    v5,
                    v341,
                    v354,
                    v356,
                    v359,
                    v373,
                    v386,
                    v389,
                    v403,
                    sprintf!("{:?}", v440.to_vec()),
                );
                let v530: () = {
                    v75();
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
                let v582: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v580: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v579: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v632: () = {
                    Dice_contract::closure17(v579.clone(), ());
                    ()
                };
                let v681: string = if (v582.l0.get().clone()) == string("") {
                    v468.clone()
                } else {
                    if (v468.clone()) == string("") {
                        v582.l0.get().clone()
                    } else {
                        append(
                            (append((v582.l0.get().clone()), string("\n"))),
                            (v468.clone()),
                        )
                    }
                };
                let v716: &str = &*v681.clone();
                let v789 = v716.chars();
                let v791 = v789;
                let v793: Vec<char> = v791.collect::<Vec<_>>();
                let v795: Vec<Vec<char>> = v793
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v797: bool = true;
                let _vec_map: Vec<_> = v795
                    .into_iter()
                    .map(|x| {
                        //;
                        let v799: Vec<char> = x;
                        let v801: std::string::String = String::from_iter(v799);
                        let v803: bool = true;
                        v801
                    })
                    .collect::<Vec<_>>();
                let v805: Vec<std::string::String> = _vec_map;
                let v807: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v805.clone());
                let v808: i32 = get_Count(v807.clone());
                if if (v468.clone()) != string("") {
                    (v808) <= 1_i32
                } else {
                    false
                } {
                    v582.l0.set(v681);
                    ()
                } else {
                    v582.l0.set(string(""));
                    {
                        let v828: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v808, v828.clone()) {
                            let v830: i32 = v828.l0.get().clone();
                            let v831: std::string::String = v807[v830].clone();
                            let v833: bool = true;
                            near_sdk::log!("{}", v831);
                            let v834: i32 = (v830) + 1_i32;
                            v828.l0.set(v834);
                            ()
                        }
                        ()
                    }
                }
                (v580.l0.get().clone())(v468);
                Dice_contract::US12::US12_0(
                    v579,
                    v580,
                    patternInput_2.2.clone(),
                    v582,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn method60(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            '_method60: loop {
                break '_method60 (match v0_1.get().clone().as_ref() {
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
                        continue '_method60;
                    }
                });
            }
        }
        pub fn method61(
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
                        Dice_contract::method61(
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
        pub fn closure27(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn closure28(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::Mut6>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            let v2: Dice_contract::US14 = v1.l0.get().clone();
            match &v2 {
                Dice_contract::US14::US14_0(v2_0_0) => {
                    let v5: LrcPtr<Dice_contract::UH1> = (v2_0_0)();
                    let v12: LrcPtr<Dice_contract::UH1> = match v5.as_ref() {
                        Dice_contract::UH1::UH1_1 => LrcPtr::new(Dice_contract::UH1::UH1_1),
                        Dice_contract::UH1::UH1_0(v5_0_0, v5_0_1) => {
                            LrcPtr::new(Dice_contract::UH1::UH1_0(
                                v5_0_0.clone(),
                                Dice_contract::method62(v0_1.clone(), v5_0_1.clone()),
                            ))
                        }
                    };
                    v1.l0.set(Dice_contract::US14::US14_1(v12.clone()));
                    v12
                }
                Dice_contract::US14::US14_1(v2_1_0) => v2_1_0.clone(),
            }
        }
        pub fn method62(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
        ) -> Func0<LrcPtr<Dice_contract::UH1>> {
            let v3: LrcPtr<Dice_contract::Mut6> = LrcPtr::new(Dice_contract::Mut6 {
                l0: MutCell::new(Dice_contract::US14::US14_0(v1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3 = v3.clone();
                move || Dice_contract::closure28(v0_1.clone(), v3.clone(), ())
            })
        }
        pub fn method66(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("p"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method67(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("n"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method65(v0_1: u64, v1: u64, v2: i8) -> string {
            let v14: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v14.clone());
            Dice_contract::method45(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v14.clone());
            Dice_contract::method66(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v1));
            Dice_contract::method28(v14.clone());
            Dice_contract::method67(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v2));
            Dice_contract::method30(v14.clone());
            v14.l0.get().clone()
        }
        pub fn method64(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.calculate_dice_count"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method65(v8, v9, v10)),
            ))
        }
        pub fn closure29(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v64() {
                Dice_contract::closure10((), ());
            }
            let v65: () = {
                v64();
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
            let v161: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v697: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v161,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v230: () = {
                    v64();
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
                let v284: Option<i64> = patternInput_1.5.clone();
                let v283: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v282: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v281: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v280: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v279: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v328: string = Dice_contract::method64(
                    v279.clone(),
                    v280.clone(),
                    v281.clone(),
                    v282.clone(),
                    v283.clone(),
                    v284.clone(),
                    Dice_contract::method16(v279, v280, v281, v282, v283, v284),
                    Dice_contract::method20(),
                    v0_1,
                    v2,
                    v1,
                );
                let v390: () = {
                    v64();
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
                let v442: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v440: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v439: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v492: () = {
                    Dice_contract::closure17(v439.clone(), ());
                    ()
                };
                let v541: string = if (v442.l0.get().clone()) == string("") {
                    v328.clone()
                } else {
                    if (v328.clone()) == string("") {
                        v442.l0.get().clone()
                    } else {
                        append(
                            (append((v442.l0.get().clone()), string("\n"))),
                            (v328.clone()),
                        )
                    }
                };
                let v576: &str = &*v541.clone();
                let v649 = v576.chars();
                let v651 = v649;
                let v653: Vec<char> = v651.collect::<Vec<_>>();
                let v655: Vec<Vec<char>> = v653
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v657: bool = true;
                let _vec_map: Vec<_> = v655
                    .into_iter()
                    .map(|x| {
                        //;
                        let v659: Vec<char> = x;
                        let v661: std::string::String = String::from_iter(v659);
                        let v663: bool = true;
                        v661
                    })
                    .collect::<Vec<_>>();
                let v665: Vec<std::string::String> = _vec_map;
                let v667: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v665.clone());
                let v668: i32 = get_Count(v667.clone());
                if if (v328.clone()) != string("") {
                    (v668) <= 1_i32
                } else {
                    false
                } {
                    v442.l0.set(v541);
                    ()
                } else {
                    v442.l0.set(string(""));
                    {
                        let v688: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v668, v688.clone()) {
                            let v690: i32 = v688.l0.get().clone();
                            let v691: std::string::String = v667[v690].clone();
                            let v693: bool = true;
                            near_sdk::log!("{}", v691);
                            let v694: i32 = (v690) + 1_i32;
                            v688.l0.set(v694);
                            ()
                        }
                        ()
                    }
                }
                (v440.l0.get().clone())(v328);
                Dice_contract::US12::US12_0(
                    v439,
                    v440,
                    patternInput_2.2.clone(),
                    v442,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn method63(v0_1: u64, v1: i8, v2: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1: MutCell<i8> = MutCell::new(v1);
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method63: loop {
                break '_method63 (if (v2.get().clone()) < (v0_1.get().clone()) {
                    let v4: u64 = (v2.get().clone()) * 6_u64;
                    if (v4) > (v2.get().clone()) {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_temp: i8 = (v1.get().clone()) + 1_i8;
                        let v2_temp: u64 = v4;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        continue '_method63;
                    } else {
                        let v1497: () = {
                            Dice_contract::closure29(
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
                    let v3738: () = {
                        Dice_contract::closure29(
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
        pub fn method72(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("current_index"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method73(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("acc"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method74(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("len"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method75(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("last_item"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method71(v0_1: i64, v1: i64, v2: i64, v3: string) -> string {
            let v15: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v15.clone());
            Dice_contract::method72(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v15.clone());
            Dice_contract::method73(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), sprintf!("{}", v1));
            Dice_contract::method28(v15.clone());
            Dice_contract::method74(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), sprintf!("{}", v2));
            Dice_contract::method28(v15.clone());
            Dice_contract::method75(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), v3);
            Dice_contract::method30(v15.clone());
            v15.l0.get().clone()
        }
        pub fn method70(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.create_sequential_roller / roll"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method71(v8, v9, v10, v11)),
            ))
        }
        pub fn closure30(v0_1: i64, v1: i64, v2: i64, v3: Option<u8>, unitVar: ()) {
            fn v65() {
                Dice_contract::closure10((), ());
            }
            let v66: () = {
                v65();
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
            let v162: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v712: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v162,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v231: () = {
                    v65();
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
                let v285: Option<i64> = patternInput_1.5.clone();
                let v284: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v283: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v282: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v281: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v280: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v343: string = Dice_contract::method70(
                    v280.clone(),
                    v281.clone(),
                    v282.clone(),
                    v283.clone(),
                    v284.clone(),
                    v285.clone(),
                    Dice_contract::method16(v280, v281, v282, v283, v284, v285),
                    Dice_contract::method20(),
                    v0_1,
                    v1,
                    v2,
                    sprintf!("{:?}", v3),
                );
                let v405: () = {
                    v65();
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
                let v457: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v455: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v454: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v507: () = {
                    Dice_contract::closure17(v454.clone(), ());
                    ()
                };
                let v556: string = if (v457.l0.get().clone()) == string("") {
                    v343.clone()
                } else {
                    if (v343.clone()) == string("") {
                        v457.l0.get().clone()
                    } else {
                        append(
                            (append((v457.l0.get().clone()), string("\n"))),
                            (v343.clone()),
                        )
                    }
                };
                let v591: &str = &*v556.clone();
                let v664 = v591.chars();
                let v666 = v664;
                let v668: Vec<char> = v666.collect::<Vec<_>>();
                let v670: Vec<Vec<char>> = v668
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v672: bool = true;
                let _vec_map: Vec<_> = v670
                    .into_iter()
                    .map(|x| {
                        //;
                        let v674: Vec<char> = x;
                        let v676: std::string::String = String::from_iter(v674);
                        let v678: bool = true;
                        v676
                    })
                    .collect::<Vec<_>>();
                let v680: Vec<std::string::String> = _vec_map;
                let v682: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v680.clone());
                let v683: i32 = get_Count(v682.clone());
                if if (v343.clone()) != string("") {
                    (v683) <= 1_i32
                } else {
                    false
                } {
                    v457.l0.set(v556);
                    ()
                } else {
                    v457.l0.set(string(""));
                    {
                        let v703: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v683, v703.clone()) {
                            let v705: i32 = v703.l0.get().clone();
                            let v706: std::string::String = v682[v705].clone();
                            let v708: bool = true;
                            near_sdk::log!("{}", v706);
                            let v709: i32 = (v705) + 1_i32;
                            v703.l0.set(v709);
                            ()
                        }
                        ()
                    }
                }
                (v455.l0.get().clone())(v343);
                Dice_contract::US12::US12_0(
                    v454,
                    v455,
                    patternInput_2.2.clone(),
                    v457,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn method76(v0_1: i64, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US15 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method76: loop {
                break '_method76 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US15::US15_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice_contract::US15::US15_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method76;
                        }
                    }
                });
            }
        }
        pub fn method78() -> string {
            let v11: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            v11.l0.get().clone()
        }
        pub fn method77(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.create_sequential_roller / roll / None"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method78()),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) {
            fn v61() {
                Dice_contract::closure10((), ());
            }
            let v62: () = {
                v61();
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
            let v158: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v694: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v158,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v227: () = {
                    v61();
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
                let v281: Option<i64> = patternInput_1.5.clone();
                let v280: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v279: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v278: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v277: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v276: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v325: string = Dice_contract::method77(
                    v276.clone(),
                    v277.clone(),
                    v278.clone(),
                    v279.clone(),
                    v280.clone(),
                    v281.clone(),
                    Dice_contract::method16(v276, v277, v278, v279, v280, v281),
                    Dice_contract::method20(),
                );
                let v387: () = {
                    v61();
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
                let v439: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v437: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v436: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v489: () = {
                    Dice_contract::closure17(v436.clone(), ());
                    ()
                };
                let v538: string = if (v439.l0.get().clone()) == string("") {
                    v325.clone()
                } else {
                    if (v325.clone()) == string("") {
                        v439.l0.get().clone()
                    } else {
                        append(
                            (append((v439.l0.get().clone()), string("\n"))),
                            (v325.clone()),
                        )
                    }
                };
                let v573: &str = &*v538.clone();
                let v646 = v573.chars();
                let v648 = v646;
                let v650: Vec<char> = v648.collect::<Vec<_>>();
                let v652: Vec<Vec<char>> = v650
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v654: bool = true;
                let _vec_map: Vec<_> = v652
                    .into_iter()
                    .map(|x| {
                        //;
                        let v656: Vec<char> = x;
                        let v658: std::string::String = String::from_iter(v656);
                        let v660: bool = true;
                        v658
                    })
                    .collect::<Vec<_>>();
                let v662: Vec<std::string::String> = _vec_map;
                let v664: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v662.clone());
                let v665: i32 = get_Count(v664.clone());
                if if (v325.clone()) != string("") {
                    (v665) <= 1_i32
                } else {
                    false
                } {
                    v439.l0.set(v538);
                    ()
                } else {
                    v439.l0.set(string(""));
                    {
                        let v685: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v665, v685.clone()) {
                            let v687: i32 = v685.l0.get().clone();
                            let v688: std::string::String = v664[v687].clone();
                            let v690: bool = true;
                            near_sdk::log!("{}", v688);
                            let v691: i32 = (v687) + 1_i32;
                            v685.l0.set(v691);
                            ()
                        }
                        ()
                    }
                }
                (v437.l0.get().clone())(v325);
                Dice_contract::US12::US12_0(
                    v436,
                    v437,
                    patternInput_2.2.clone(),
                    v439,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn method69(
            v0_1: Func0<LrcPtr<Dice_contract::UH1>>,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut7>,
        ) -> u8 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v1.clone());
            let v2: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v2.clone());
            let v3: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v3.clone());
            let v4: MutCell<LrcPtr<Dice_contract::Mut7>> = MutCell::new(v4.clone());
            '_method69: loop {
                break '_method69 ({
                    let v5: i64 = v1.l0.get().clone();
                    let v6: i64 = v2.l0.get().clone();
                    let v7: i64 = v3.l0.get().clone();
                    let v8: Dice_contract::US15 = v4.l0.get().clone();
                    let v1557: () = {
                        Dice_contract::closure30(
                            v5,
                            v6,
                            v7,
                            match &v8 {
                                Dice_contract::US15::US15_0(v8_0_0) => Some(match &v8 {
                                    Dice_contract::US15::US15_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => None::<u8>,
                            },
                            (),
                        );
                        ()
                    };
                    let v2322: LrcPtr<Dice_contract::UH1> = v0_1();
                    let v2324: Dice_contract::US15 =
                        Dice_contract::method76(v1.l0.get().clone(), v2322);
                    match &v2324 {
                        Dice_contract::US15::US15_0(v2324_0_0) => {
                            let v2325: u8 = match &v2324 {
                                Dice_contract::US15::US15_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v2327: i64 = (v1.l0.get().clone()) + 1_i64;
                            v1.l0.set(v2327);
                            v4.l0.set(Dice_contract::US15::US15_0(v2325));
                            v2325
                        }
                        _ => {
                            let v3818: () = {
                                Dice_contract::closure31((), ());
                                ()
                            };
                            if (v3.l0.get().clone()) == -1_i64 {
                                let v4571: i64 = v1.l0.get().clone();
                                v3.l0.set(v4571);
                                ()
                            }
                            {
                                let v4577: i64 = if (v2.l0.get().clone()) >= (v3.l0.get().clone()) {
                                    1_i64
                                } else {
                                    (v2.l0.get().clone()) + 1_i64
                                };
                                v2.l0.set(v4577);
                                {
                                    let v4579: i64 = (v2.l0.get().clone()) - 1_i64;
                                    v1.l0.set(v4579);
                                    v4.l0.set(Dice_contract::US15::US15_1);
                                    {
                                        let v0_1_temp = v0_1.get().clone();
                                        let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                                        let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                                        let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                                        let v4_temp: LrcPtr<Dice_contract::Mut7> = v4.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1.set(v1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method69;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method82(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("power"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method83(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("result"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method81(v0_1: i8, v1: u64, v2: u64) -> string {
            let v14: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v14.clone());
            Dice_contract::method82(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v14.clone());
            Dice_contract::method73(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v1));
            Dice_contract::method28(v14.clone());
            Dice_contract::method83(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v2));
            Dice_contract::method30(v14.clone());
            v14.l0.get().clone()
        }
        pub fn method80(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method81(v8, v9, v10)),
            ))
        }
        pub fn closure32(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v64() {
                Dice_contract::closure10((), ());
            }
            let v65: () = {
                v64();
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
            let v161: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v697: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v161,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v230: () = {
                    v64();
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
                let v284: Option<i64> = patternInput_1.5.clone();
                let v283: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v282: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v281: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v280: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v279: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v328: string = Dice_contract::method80(
                    v279.clone(),
                    v280.clone(),
                    v281.clone(),
                    v282.clone(),
                    v283.clone(),
                    v284.clone(),
                    Dice_contract::method16(v279, v280, v281, v282, v283, v284),
                    Dice_contract::method20(),
                    v1,
                    v0_1,
                    v2,
                );
                let v390: () = {
                    v64();
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
                let v442: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v440: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v439: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v492: () = {
                    Dice_contract::closure17(v439.clone(), ());
                    ()
                };
                let v541: string = if (v442.l0.get().clone()) == string("") {
                    v328.clone()
                } else {
                    if (v328.clone()) == string("") {
                        v442.l0.get().clone()
                    } else {
                        append(
                            (append((v442.l0.get().clone()), string("\n"))),
                            (v328.clone()),
                        )
                    }
                };
                let v576: &str = &*v541.clone();
                let v649 = v576.chars();
                let v651 = v649;
                let v653: Vec<char> = v651.collect::<Vec<_>>();
                let v655: Vec<Vec<char>> = v653
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v657: bool = true;
                let _vec_map: Vec<_> = v655
                    .into_iter()
                    .map(|x| {
                        //;
                        let v659: Vec<char> = x;
                        let v661: std::string::String = String::from_iter(v659);
                        let v663: bool = true;
                        v661
                    })
                    .collect::<Vec<_>>();
                let v665: Vec<std::string::String> = _vec_map;
                let v667: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v665.clone());
                let v668: i32 = get_Count(v667.clone());
                if if (v328.clone()) != string("") {
                    (v668) <= 1_i32
                } else {
                    false
                } {
                    v442.l0.set(v541);
                    ()
                } else {
                    v442.l0.set(string(""));
                    {
                        let v688: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v668, v688.clone()) {
                            let v690: i32 = v688.l0.get().clone();
                            let v691: std::string::String = v667[v690].clone();
                            let v693: bool = true;
                            near_sdk::log!("{}", v691);
                            let v694: i32 = (v690) + 1_i32;
                            v688.l0.set(v694);
                            ()
                        }
                        ()
                    }
                }
                (v440.l0.get().clone())(v328);
                Dice_contract::US12::US12_0(
                    v439,
                    v440,
                    patternInput_2.2.clone(),
                    v442,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn closure96(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_1)
        }
        pub fn closure95(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice_contract::closure96((), ())),
            ))
        }
        pub fn closure94(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice_contract::closure95((), ())),
            ))
        }
        pub fn closure93(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice_contract::closure94((), ())),
            ))
        }
        pub fn closure92(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice_contract::closure93((), ())),
            ))
        }
        pub fn closure91(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice_contract::closure92((), ())),
            ))
        }
        pub fn closure90(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice_contract::closure91((), ())),
            ))
        }
        pub fn closure89(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice_contract::closure90((), ())),
            ))
        }
        pub fn closure88(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice_contract::closure89((), ())),
            ))
        }
        pub fn closure87(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice_contract::closure88((), ())),
            ))
        }
        pub fn closure86(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice_contract::closure87((), ())),
            ))
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice_contract::closure86((), ())),
            ))
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice_contract::closure85((), ())),
            ))
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice_contract::closure84((), ())),
            ))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice_contract::closure83((), ())),
            ))
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice_contract::closure82((), ())),
            ))
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice_contract::closure81((), ())),
            ))
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice_contract::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice_contract::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice_contract::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice_contract::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice_contract::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice_contract::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice_contract::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice_contract::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice_contract::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice_contract::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice_contract::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice_contract::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice_contract::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice_contract::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice_contract::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice_contract::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice_contract::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice_contract::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice_contract::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice_contract::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice_contract::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice_contract::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice_contract::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice_contract::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice_contract::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice_contract::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice_contract::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice_contract::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice_contract::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice_contract::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice_contract::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice_contract::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice_contract::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice_contract::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice_contract::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice_contract::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice_contract::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice_contract::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice_contract::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice_contract::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice_contract::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice_contract::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice_contract::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice_contract::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice_contract::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice_contract::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH2> {
            LrcPtr::new(Dice_contract::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice_contract::closure34((), ())),
            ))
        }
        pub fn method84(v0_1: i8, v1: LrcPtr<Dice_contract::UH2>) -> Dice_contract::US17 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH2>> = MutCell::new(v1.clone());
            '_method84: loop {
                break '_method84 (match v1.get().clone().as_ref() {
                    Dice_contract::UH2::UH2_1 => Dice_contract::US17::US17_1,
                    Dice_contract::UH2::UH2_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice_contract::US17::US17_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH2> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method84;
                        }
                    }
                });
            }
        }
        pub fn method87(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("roll"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method88(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("value"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method86(v0_1: i8, v1: u64, v2: u8, v3: u64) -> string {
            let v15: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v15.clone());
            Dice_contract::method82(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v15.clone());
            Dice_contract::method73(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), sprintf!("{}", v1));
            Dice_contract::method28(v15.clone());
            Dice_contract::method87(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), sprintf!("{}", v2));
            Dice_contract::method28(v15.clone());
            Dice_contract::method88(v15.clone());
            Dice_contract::method27(v15.clone());
            Dice_contract::method11(v15.clone(), sprintf!("{}", v3));
            Dice_contract::method30(v15.clone());
            v15.l0.get().clone()
        }
        pub fn method85(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method86(v8, v9, v10, v11)),
            ))
        }
        pub fn closure97(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
            fn v65() {
                Dice_contract::closure10((), ());
            }
            let v66: () = {
                v65();
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
            let v162: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v698: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v162,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v231: () = {
                    v65();
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
                let v285: Option<i64> = patternInput_1.5.clone();
                let v284: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v283: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v282: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v281: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v280: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v329: string = Dice_contract::method85(
                    v280.clone(),
                    v281.clone(),
                    v282.clone(),
                    v283.clone(),
                    v284.clone(),
                    v285.clone(),
                    Dice_contract::method16(v280, v281, v282, v283, v284, v285),
                    Dice_contract::method20(),
                    v1,
                    v0_1,
                    v2,
                    v3,
                );
                let v391: () = {
                    v65();
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
                let v443: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v441: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v440: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v493: () = {
                    Dice_contract::closure17(v440.clone(), ());
                    ()
                };
                let v542: string = if (v443.l0.get().clone()) == string("") {
                    v329.clone()
                } else {
                    if (v329.clone()) == string("") {
                        v443.l0.get().clone()
                    } else {
                        append(
                            (append((v443.l0.get().clone()), string("\n"))),
                            (v329.clone()),
                        )
                    }
                };
                let v577: &str = &*v542.clone();
                let v650 = v577.chars();
                let v652 = v650;
                let v654: Vec<char> = v652.collect::<Vec<_>>();
                let v656: Vec<Vec<char>> = v654
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v658: bool = true;
                let _vec_map: Vec<_> = v656
                    .into_iter()
                    .map(|x| {
                        //;
                        let v660: Vec<char> = x;
                        let v662: std::string::String = String::from_iter(v660);
                        let v664: bool = true;
                        v662
                    })
                    .collect::<Vec<_>>();
                let v666: Vec<std::string::String> = _vec_map;
                let v668: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v666.clone());
                let v669: i32 = get_Count(v668.clone());
                if if (v329.clone()) != string("") {
                    (v669) <= 1_i32
                } else {
                    false
                } {
                    v443.l0.set(v542);
                    ()
                } else {
                    v443.l0.set(string(""));
                    {
                        let v689: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v669, v689.clone()) {
                            let v691: i32 = v689.l0.get().clone();
                            let v692: std::string::String = v668[v691].clone();
                            let v694: bool = true;
                            near_sdk::log!("{}", v692);
                            let v695: i32 = (v691) + 1_i32;
                            v689.l0.set(v695);
                            ()
                        }
                        ()
                    }
                }
                (v441.l0.get().clone())(v329);
                Dice_contract::US12::US12_0(
                    v440,
                    v441,
                    patternInput_2.2.clone(),
                    v443,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn method90(v0_1: i8, v1: u64, v2: u8) -> string {
            let v14: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v14.clone());
            Dice_contract::method82(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v14.clone());
            Dice_contract::method73(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v1));
            Dice_contract::method28(v14.clone());
            Dice_contract::method87(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v2));
            Dice_contract::method30(v14.clone());
            v14.l0.get().clone()
        }
        pub fn method89(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method90(v8, v9, v10)),
            ))
        }
        pub fn closure98(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
            fn v64() {
                Dice_contract::closure10((), ());
            }
            let v65: () = {
                v64();
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
            let v161: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v697: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v161,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v230: () = {
                    v64();
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
                let v284: Option<i64> = patternInput_1.5.clone();
                let v283: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v282: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v281: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v280: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v279: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v328: string = Dice_contract::method89(
                    v279.clone(),
                    v280.clone(),
                    v281.clone(),
                    v282.clone(),
                    v283.clone(),
                    v284.clone(),
                    Dice_contract::method16(v279, v280, v281, v282, v283, v284),
                    Dice_contract::method20(),
                    v1,
                    v0_1,
                    v2,
                );
                let v390: () = {
                    v64();
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
                let v442: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v440: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v439: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v492: () = {
                    Dice_contract::closure17(v439.clone(), ());
                    ()
                };
                let v541: string = if (v442.l0.get().clone()) == string("") {
                    v328.clone()
                } else {
                    if (v328.clone()) == string("") {
                        v442.l0.get().clone()
                    } else {
                        append(
                            (append((v442.l0.get().clone()), string("\n"))),
                            (v328.clone()),
                        )
                    }
                };
                let v576: &str = &*v541.clone();
                let v649 = v576.chars();
                let v651 = v649;
                let v653: Vec<char> = v651.collect::<Vec<_>>();
                let v655: Vec<Vec<char>> = v653
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v657: bool = true;
                let _vec_map: Vec<_> = v655
                    .into_iter()
                    .map(|x| {
                        //;
                        let v659: Vec<char> = x;
                        let v661: std::string::String = String::from_iter(v659);
                        let v663: bool = true;
                        v661
                    })
                    .collect::<Vec<_>>();
                let v665: Vec<std::string::String> = _vec_map;
                let v667: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v665.clone());
                let v668: i32 = get_Count(v667.clone());
                if if (v328.clone()) != string("") {
                    (v668) <= 1_i32
                } else {
                    false
                } {
                    v442.l0.set(v541);
                    ()
                } else {
                    v442.l0.set(string(""));
                    {
                        let v688: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v668, v688.clone()) {
                            let v690: i32 = v688.l0.get().clone();
                            let v691: std::string::String = v667[v690].clone();
                            let v693: bool = true;
                            near_sdk::log!("{}", v691);
                            let v694: i32 = (v690) + 1_i32;
                            v688.l0.set(v694);
                            ()
                        }
                        ()
                    }
                }
                (v440.l0.get().clone())(v328);
                Dice_contract::US12::US12_0(
                    v439,
                    v440,
                    patternInput_2.2.clone(),
                    v442,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn method79(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US16 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method79: loop {
                break '_method79 (if (v0_1.get().clone()) < 0_i8 {
                    let v4: u64 = (v2.get().clone()) + 1_u64;
                    let v1494: () = {
                        Dice_contract::closure32(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US16::US16_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US16::US16_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v2248: LrcPtr<Dice_contract::UH0> = match v1.get().clone().as_ref()
                            {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v2247: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v2247) > 1_u8 {
                                let v2253: Dice_contract::US17 = Dice_contract::method84(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure33((), ())),
                                    )),
                                );
                                let v2260: u64 = (((v2247) - 1_u8) as u64)
                                    * (match &v2253 {
                                        Dice_contract::US17::US17_0(v2253_0_0) => match &v2253 {
                                            Dice_contract::US17::US17_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v3750: () = {
                                    Dice_contract::closure97(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v2247,
                                        v2260,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v2248;
                                    let v2_temp: u64 = (v2.get().clone()) + (v2260);
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method79;
                                }
                            } else {
                                let v5993: () = {
                                    Dice_contract::closure98(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v2247,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v2248.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method79;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method91(
            v0_1: i8,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut0>,
            v5: LrcPtr<Dice_contract::Mut7>,
            v6: i8,
        ) -> LrcPtr<Dice_contract::UH0> {
            if (v6) < (v0_1) {
                LrcPtr::new(Dice_contract::UH0::UH0_1(
                    Dice_contract::method69(
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                    ),
                    Dice_contract::method91(v0_1, v1, v2, v3, v4, v5, (v6) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice_contract::UH0::UH0_0)
            }
        }
        pub fn method92(
            v0_1: Func0<LrcPtr<Dice_contract::UH1>>,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut7>,
            v5: u64,
            v6: i8,
            v7: LrcPtr<Dice_contract::UH0>,
        ) -> u64 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v1.clone());
            let v2: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v2.clone());
            let v3: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v3.clone());
            let v4: MutCell<LrcPtr<Dice_contract::Mut7>> = MutCell::new(v4.clone());
            let v5: MutCell<u64> = MutCell::new(v5);
            let v6: MutCell<i8> = MutCell::new(v6);
            let v7: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v7.clone());
            '_method92: loop {
                break '_method92 ({
                    let v8: i8 = (v6.get().clone()) + 1_i8;
                    if (v6.get().clone()) < (v8) {
                        Dice_contract::method68(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            LrcPtr::new(Dice_contract::UH0::UH0_1(
                                Dice_contract::method69(
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
                        let v14: Dice_contract::US16 =
                            Dice_contract::method79(v6.get().clone(), v7.get().clone(), 0_u64);
                        if let Dice_contract::US16::US16_0(v14_0_0, v14_0_1) = &v14 {
                            let v15: u64 = v14_0_0.clone();
                            if (v15) <= (v5.get().clone()) {
                                v15
                            } else {
                                let v0_1_temp = v0_1.get().clone();
                                let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                                let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                                let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                                let v4_temp: LrcPtr<Dice_contract::Mut7> = v4.get().clone();
                                let v5_temp: u64 = v5.get().clone();
                                let v6_temp: i8 = v6.get().clone();
                                let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method91(
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
                                continue '_method92;
                            }
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                            let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                            let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                            let v4_temp: LrcPtr<Dice_contract::Mut7> = v4.get().clone();
                            let v5_temp: u64 = v5.get().clone();
                            let v6_temp: i8 = v6.get().clone();
                            let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method91(
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
                            continue '_method92;
                        }
                    }
                });
            }
        }
        pub fn method68(
            v0_1: Func0<LrcPtr<Dice_contract::UH1>>,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut0>,
            v3: LrcPtr<Dice_contract::Mut0>,
            v4: LrcPtr<Dice_contract::Mut7>,
            v5: u64,
            v6: i8,
            v7: LrcPtr<Dice_contract::UH0>,
            v8: i8,
        ) -> u64 {
            let v0_1 = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v1.clone());
            let v2: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v2.clone());
            let v3: MutCell<LrcPtr<Dice_contract::Mut0>> = MutCell::new(v3.clone());
            let v4: MutCell<LrcPtr<Dice_contract::Mut7>> = MutCell::new(v4.clone());
            let v5: MutCell<u64> = MutCell::new(v5);
            let v6: MutCell<i8> = MutCell::new(v6);
            let v7: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v7.clone());
            let v8: MutCell<i8> = MutCell::new(v8);
            '_method68: loop {
                break '_method68 (if (v8.get().clone()) < ((v6.get().clone()) + 1_i8) {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                    let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                    let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                    let v4_temp: LrcPtr<Dice_contract::Mut7> = v4.get().clone();
                    let v5_temp: u64 = v5.get().clone();
                    let v6_temp: i8 = v6.get().clone();
                    let v7_temp: LrcPtr<Dice_contract::UH0> =
                        LrcPtr::new(Dice_contract::UH0::UH0_1(
                            Dice_contract::method69(
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
                    continue '_method68;
                } else {
                    let v16: Dice_contract::US16 =
                        Dice_contract::method79(v6.get().clone(), v7.get().clone(), 0_u64);
                    if let Dice_contract::US16::US16_0(v16_0_0, v16_0_1) = &v16 {
                        let v17: u64 = v16_0_0.clone();
                        if (v17) <= (v5.get().clone()) {
                            v17
                        } else {
                            Dice_contract::method92(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                                Dice_contract::method91(
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
                        Dice_contract::method92(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            Dice_contract::method91(
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
        pub fn method93() -> Func0<()> {
            Func0::new(move || Dice_contract::closure20((), ()))
        }
        pub fn closure99(v0_1: Func0<()>, unitVar: ()) {
            fn v62() {
                Dice_contract::closure10((), ());
            }
            let v63: () = {
                v62();
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
            let v159: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v692: Dice_contract::US12 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v159,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US12::US12_1
                } else {
                    let v228: () = {
                        v62();
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
                    let v324: string = Dice_contract::method16(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v325: string = Dice_contract::method20();
                    let v387: () = {
                        v62();
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
                    let v439: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v437: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v436: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v489: () = {
                        Dice_contract::closure17(v436.clone(), ());
                        ()
                    };
                    let v539: string = if (v439.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v439.l0.get().clone()
                    };
                    let v574: &str = &*v539;
                    let v647 = v574.chars();
                    let v649 = v647;
                    let v651: Vec<char> = v649.collect::<Vec<_>>();
                    let v653: Vec<Vec<char>> = v651
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v655: bool = true;
                    let _vec_map: Vec<_> = v653
                        .into_iter()
                        .map(|x| {
                            //;
                            let v657: Vec<char> = x;
                            let v659: std::string::String = String::from_iter(v657);
                            let v661: bool = true;
                            v659
                        })
                        .collect::<Vec<_>>();
                    let v663: Vec<std::string::String> = _vec_map;
                    let v665: Array<std::string::String> =
                        fable_library_rust::NativeArray_::array_from(v663.clone());
                    let v666: i32 = get_Count(v665.clone());
                    v439.l0.set(string(""));
                    {
                        let v683: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v666, v683.clone()) {
                            let v685: i32 = v683.l0.get().clone();
                            let v686: std::string::String = v665[v685].clone();
                            let v688: bool = true;
                            near_sdk::log!("{}", v686);
                            let v689: i32 = (v685) + 1_i32;
                            v683.l0.set(v689);
                            ()
                        }
                        ()
                    }
                    (v437.l0.get().clone())(string(""));
                    Dice_contract::US12::US12_0(
                        v436,
                        v437,
                        patternInput_2.2.clone(),
                        v439,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ();
            ()
        }
        pub fn method94(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method94: loop {
                break '_method94 (match v0_1.get().clone().as_ref() {
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
                        continue '_method94;
                    }
                });
            }
        }
        pub fn method96(v0_1: u64, v1: string, v2: string) -> string {
            let v14: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method10()),
            });
            Dice_contract::method25(v14.clone());
            Dice_contract::method45(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), sprintf!("{}", v0_1));
            Dice_contract::method28(v14.clone());
            Dice_contract::method59(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), v1);
            Dice_contract::method28(v14.clone());
            Dice_contract::method83(v14.clone());
            Dice_contract::method27(v14.clone());
            Dice_contract::method11(v14.clone(), v2);
            Dice_contract::method30(v14.clone());
            v14.l0.get().clone()
        }
        pub fn method95(
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
            Dice_contract::method31(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice_contract::method23(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice_contract.roll_within_bounds"),
                    )),
                    string(" / "),
                )),
                (Dice_contract::method96(v8, v9, v10)),
            ))
        }
        pub fn closure100(v0_1: u64, v1: Vec<u8>, v2: Option<u64>, unitVar: ()) {
            fn v64() {
                Dice_contract::closure10((), ());
            }
            let v65: () = {
                v64();
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
            let v161: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v725: Dice_contract::US12 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v161,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice_contract::US12::US12_1
            } else {
                let v230: () = {
                    v64();
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
                let v284: Option<i64> = patternInput_1.5.clone();
                let v283: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v282: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v281: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v280: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v279: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v356: string = Dice_contract::method95(
                    v279.clone(),
                    v280.clone(),
                    v281.clone(),
                    v282.clone(),
                    v283.clone(),
                    v284.clone(),
                    Dice_contract::method16(v279, v280, v281, v282, v283, v284),
                    Dice_contract::method20(),
                    v0_1,
                    sprintf!("{:?}", v1),
                    sprintf!("{:?}", v2),
                );
                let v418: () = {
                    v64();
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
                let v470: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v468: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v467: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v520: () = {
                    Dice_contract::closure17(v467.clone(), ());
                    ()
                };
                let v569: string = if (v470.l0.get().clone()) == string("") {
                    v356.clone()
                } else {
                    if (v356.clone()) == string("") {
                        v470.l0.get().clone()
                    } else {
                        append(
                            (append((v470.l0.get().clone()), string("\n"))),
                            (v356.clone()),
                        )
                    }
                };
                let v604: &str = &*v569.clone();
                let v677 = v604.chars();
                let v679 = v677;
                let v681: Vec<char> = v679.collect::<Vec<_>>();
                let v683: Vec<Vec<char>> = v681
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v685: bool = true;
                let _vec_map: Vec<_> = v683
                    .into_iter()
                    .map(|x| {
                        //;
                        let v687: Vec<char> = x;
                        let v689: std::string::String = String::from_iter(v687);
                        let v691: bool = true;
                        v689
                    })
                    .collect::<Vec<_>>();
                let v693: Vec<std::string::String> = _vec_map;
                let v695: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v693.clone());
                let v696: i32 = get_Count(v695.clone());
                if if (v356.clone()) != string("") {
                    (v696) <= 1_i32
                } else {
                    false
                } {
                    v470.l0.set(v569);
                    ()
                } else {
                    v470.l0.set(string(""));
                    {
                        let v716: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v696, v716.clone()) {
                            let v718: i32 = v716.l0.get().clone();
                            let v719: std::string::String = v695[v718].clone();
                            let v721: bool = true;
                            near_sdk::log!("{}", v719);
                            let v722: i32 = (v718) + 1_i32;
                            v716.l0.set(v722);
                            ()
                        }
                        ()
                    }
                }
                (v468.l0.get().clone())(v356);
                Dice_contract::US12::US12_0(
                    v467,
                    v468,
                    patternInput_2.2.clone(),
                    v470,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ();
            ()
        }
        pub fn method97() -> Func0<()> {
            Func0::new(move || Dice_contract::closure20((), ()))
        }
        pub fn closure101(v0_1: Func0<()>, unitVar: ()) {
            fn v62() {
                Dice_contract::closure10((), ());
            }
            let v63: () = {
                v62();
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
            let v159: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v692: Dice_contract::US12 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v159,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Dice_contract::US4::US4_0, 0_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_1, 1_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_2, 2_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_3, 3_i32)),
                                LrcPtr::new((Dice_contract::US4::US4_4, 4_i32)),
                            ])))),
                        ))
                }) == false
                {
                    Dice_contract::US12::US12_1
                } else {
                    let v228: () = {
                        v62();
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
                    let v324: string = Dice_contract::method16(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v325: string = Dice_contract::method20();
                    let v387: () = {
                        v62();
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
                    let v439: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v437: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v436: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v489: () = {
                        Dice_contract::closure17(v436.clone(), ());
                        ()
                    };
                    let v539: string = if (v439.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v439.l0.get().clone()
                    };
                    let v574: &str = &*v539;
                    let v647 = v574.chars();
                    let v649 = v647;
                    let v651: Vec<char> = v649.collect::<Vec<_>>();
                    let v653: Vec<Vec<char>> = v651
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v655: bool = true;
                    let _vec_map: Vec<_> = v653
                        .into_iter()
                        .map(|x| {
                            //;
                            let v657: Vec<char> = x;
                            let v659: std::string::String = String::from_iter(v657);
                            let v661: bool = true;
                            v659
                        })
                        .collect::<Vec<_>>();
                    let v663: Vec<std::string::String> = _vec_map;
                    let v665: Array<std::string::String> =
                        fable_library_rust::NativeArray_::array_from(v663.clone());
                    let v666: i32 = get_Count(v665.clone());
                    v439.l0.set(string(""));
                    {
                        let v683: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method36(v666, v683.clone()) {
                            let v685: i32 = v683.l0.get().clone();
                            let v686: std::string::String = v665[v685].clone();
                            let v688: bool = true;
                            near_sdk::log!("{}", v686);
                            let v689: i32 = (v685) + 1_i32;
                            v683.l0.set(v689);
                            ()
                        }
                        ()
                    }
                    (v437.l0.get().clone())(string(""));
                    Dice_contract::US12::US12_0(
                        v436,
                        v437,
                        patternInput_2.2.clone(),
                        v439,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ();
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
                let v20: */
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
                    let v43: bool = true; /*;
                    let v46: */
                    () /* = fable_library_rust::Native_::getZero();
                    let v59: bool = true; */;
                    let v61: string = string("b\"seeds\"");
                    let v62: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (2_u32, near_sdk::store::vec::Vector::new(v62));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
        {
        let v69: bool =
        true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
        let v71: bool =
        true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed(&mut self, seed: Vec<u8>) {
                //;
                {
                    let v76: &mut near_sdk::store::vec::Vector<u8> = &mut self.0.1;
                    let v78: Vec<u8> = seed;
                    let v80: bool = true;
                    v76.extend(v78); //;
                    let v271: Dice_contract::US0 = Dice_contract::method0(v76.len());
                    let v292: Dice_contract::US1 = match &v271 {
                        Dice_contract::US0::US0_0(v271_0_0) => {
                            Dice_contract::US1::US1_0(v271_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v339: i32 = match &v292 {
                        Dice_contract::US1::US1_0(v292_0_0) => match &v292 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v450: Dice_contract::US2 = Dice_contract::method1();
                    let v471: Dice_contract::US3 = match &v450 {
                        Dice_contract::US2::US2_0(v450_0_0) => {
                            Dice_contract::US3::US3_0(v450_0_0.clone())
                        }
                        _ => Dice_contract::US3::US3_1,
                    };
                    let v707: Dice_contract::US0 = Dice_contract::method2(match &v471 {
                        Dice_contract::US3::US3_0(v471_0_0) => match &v471 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    });
                    let v728: Dice_contract::US1 = match &v707 {
                        Dice_contract::US0::US0_0(v707_0_0) => {
                            Dice_contract::US1::US1_0(v707_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v873: i32 = (v339)
                        - (match &v728 {
                            Dice_contract::US1::US1_0(v728_0_0) => match &v728 {
                                Dice_contract::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        });
                    if (v873) > 0_i32 {
                        let v2394: () = {
                            Dice_contract::closure9(
                                v873,
                                v76.drain(0..v873 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v4643: () = {
                            Dice_contract::closure21(Dice_contract::method37(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v5396: bool =
        true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
        let v5398: bool =
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
        let v5406: bool =
        true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
        let v5408: bool =
        true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v5413: std::string::String = key;
                    let v5415: std::string::String = proof;
                    let v5417: u64 = max;
                    let v5419: &mut near_sdk::store::vec::Vector<u8> = &mut self.0.1;
                    let v5421: Vec<u8> = near_sdk::env::random_seed();
                    let v5423: u64 = near_sdk::env::epoch_height();
                    let v5425: u64 = near_sdk::env::block_height();
                    let v5427: u64 = near_sdk::env::block_timestamp();
                    let v5429: near_token::NearToken = near_sdk::env::account_balance();
                    let v5431: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v5433: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v5435: &near_sdk::store::vec::Vector<u8> = &*v5419;
                    let v5437: Vec<u8> = v5435.iter().map(|x| *x).collect::<Vec<_>>();
                    let v5439: _ = v5423.to_le_bytes();
                    let v5441: Vec<u8> = v5439.to_vec();
                    let v5443: _ = v5425.to_le_bytes();
                    let v5445: Vec<u8> = v5443.to_vec();
                    let v5447: _ = v5427.to_le_bytes();
                    let v5449: Vec<u8> = v5447.to_vec();
                    let v5451: u128 = v5429.clone().as_yoctonear();
                    let v5453: _ = v5451.to_le_bytes();
                    let v5455: Vec<u8> = v5453.to_vec();
                    let v5457: &[u8] = v5431.as_bytes();
                    let v5459: Vec<u8> = v5457.to_vec();
                    let v5461: &[u8] = v5433.as_bytes();
                    let v5468: Array<Vec<u8>> = new_array(&[
                        v5421.clone(),
                        v5437,
                        v5441,
                        v5445,
                        v5449,
                        v5455,
                        v5459,
                        v5461.to_vec(),
                        v5415.clone().into_bytes(),
                        v5413.clone().into_bytes(),
                    ]);
                    let v5470: Vec<Vec<u8>> = v5468.to_vec();
                    let v5472: Vec<u8> = v5470.concat();
                    let v5474: Vec<u8> = near_sdk::env::keccak512(&v5472.clone());
                    let v5476: bool = true;
                    v5419.extend(v5474.clone()); //;
                    let v5667: Dice_contract::US0 = Dice_contract::method0(v5419.len());
                    let v5688: Dice_contract::US1 = match &v5667 {
                        Dice_contract::US0::US0_0(v5667_0_0) => {
                            Dice_contract::US1::US1_0(v5667_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v5735: i32 = match &v5688 {
                        Dice_contract::US1::US1_0(v5688_0_0) => match &v5688 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v5846: Dice_contract::US2 = Dice_contract::method1();
                    let v5867: Dice_contract::US3 = match &v5846 {
                        Dice_contract::US2::US2_0(v5846_0_0) => {
                            Dice_contract::US3::US3_0(v5846_0_0.clone())
                        }
                        _ => Dice_contract::US3::US3_1,
                    };
                    let v6103: Dice_contract::US0 = Dice_contract::method2(match &v5867 {
                        Dice_contract::US3::US3_0(v5867_0_0) => match &v5867 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    });
                    let v6124: Dice_contract::US1 = match &v6103 {
                        Dice_contract::US0::US0_0(v6103_0_0) => {
                            Dice_contract::US1::US1_0(v6103_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v6269: i32 = (v5735)
                        - (match &v6124 {
                            Dice_contract::US1::US1_0(v6124_0_0) => match &v6124 {
                                Dice_contract::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        });
                    if (v6269) > 0_i32 {
                        let v7790: () = {
                            Dice_contract::closure9(
                                v6269,
                                v5419.drain(0..v6269 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v10039: () = {
                            Dice_contract::closure21(Dice_contract::method37(), ());
                            ()
                        };
                        let v10791: List<u8> = ofArray(
                            fable_library_rust::NativeArray_::array_from(v5474.clone().clone()),
                        );
                        let v10911: LrcPtr<Dice_contract::UH0> = Dice_contract::method41(
                            Dice_contract::method40(
                                Dice_contract::method39(
                                    foldBack(
                                        Func2::new(
                                            move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                                                (Dice_contract::method38())(b0)(b1)
                                            },
                                        ),
                                        v10791,
                                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                                    ),
                                    LrcPtr::new(Dice_contract::UH1::UH1_1),
                                ),
                                LrcPtr::new(Dice_contract::UH1::UH1_1),
                            ),
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                        );
                        let v12657: () = {
                            Dice_contract::closure26(
                                v5419,
                                v5413,
                                v5415,
                                v5417,
                                v5421,
                                v5423,
                                v5425,
                                v5427,
                                v5429,
                                v5431,
                                v5433,
                                v5472,
                                v5474,
                                v10911.clone(),
                                (),
                            );
                            ()
                        };
                        let v13541: LrcPtr<Dice_contract::UH1> = Dice_contract::method39(
                            Dice_contract::method61(
                                v10911.clone(),
                                Dice_contract::method60(
                                    v10911,
                                    LrcPtr::new(Dice_contract::UH0::UH0_0),
                                ),
                            ),
                            LrcPtr::new(Dice_contract::UH1::UH1_1),
                        );
                        let v13557: u64 = Dice_contract::method68(
                            Dice_contract::method62(
                                v13541.clone(),
                                Func0::new({
                                    let v13541 = v13541.clone();
                                    move || Dice_contract::closure27(v13541.clone(), ())
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
                            LrcPtr::new(Dice_contract::Mut7 {
                                l0: MutCell::new(Dice_contract::US15::US15_1),
                            }),
                            v5417,
                            (if (v5417) == 1_u64 {
                                1_i8
                            } else {
                                Dice_contract::method63(v5417, 0_i8, 1_u64)
                            }) - 1_i8,
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                            0_i8,
                        );
                        let v15042: () = {
                            Dice_contract::closure99(Dice_contract::method93(), ());
                            ()
                        };
                        v13557 //;
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v15796: bool =
        true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy;
        let v15798: bool =
        true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v15803: u64 = max;
                    let v15805: Vec<u8> = rolls;
                    let v15810: List<u8> = ofArray(fable_library_rust::NativeArray_::array_from(
                        v15805.clone().clone(),
                    ));
                    let v15839: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method38())(b0)(b1)
                        }),
                        v15810,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v15929: Dice_contract::US16 = Dice_contract::method79(
                        (Dice_contract::method94(v15839.clone(), 0_i8)) - 1_i8,
                        v15839,
                        0_u64,
                    );
                    let v15939: Dice_contract::US17 =
                        if let Dice_contract::US16::US16_0(v15929_0_0, v15929_0_1) = &v15929 {
                            let v15930: u64 = v15929_0_0.clone();
                            if if (v15930) >= 1_u64 {
                                (v15930) <= (v15803)
                            } else {
                                false
                            } {
                                Dice_contract::US17::US17_0(v15930)
                            } else {
                                Dice_contract::US17::US17_1
                            }
                        } else {
                            Dice_contract::US17::US17_1
                        };
                    let v15970: Option<u64> = match &v15939 {
                        Dice_contract::US17::US17_0(v15939_0_0) => Some(match &v15939 {
                            Dice_contract::US17::US17_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v17516: () = {
                        Dice_contract::closure100(v15803, v15805, v15970.clone(), ());
                        ()
                    };
                    let v19779: () = {
                        Dice_contract::closure101(Dice_contract::method97(), ());
                        ()
                    };
                    v15970 //;
                } //;
            } //;
        } /* c;
        {
        let v20532: bool =
        true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy;
        let v20534: bool =
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
        let v20547:
        bool =
        true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy;
        let v20549:
        bool =
        true; */
 // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v20553: bool = true;
            {
                (); // ?? / i': 1uy / n: 12uy;
                let v20555: bool = true;
                {
                    (); // ?? / i': 2uy / n: 12uy;
                    let v20557: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 12uy;
                        let v20559: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 12uy;
                            let v20561: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 12uy;
                                let v20563: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 12uy;
                                    let v20565: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 12uy;
                                        let v20567: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 12uy;
                                            let v20569: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 12uy;
                                                let v20571: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 12uy;
                                                    let v20573: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 12uy;
                                                        let v20575: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 12uy;
                                                            let v20577: bool = true;
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
