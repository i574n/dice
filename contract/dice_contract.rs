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
        use fable_library_rust::String_::toString;
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
            US7_2,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(Dice_contract::US7),
            US8_1(Dice_contract::US7),
            US8_2(Dice_contract::US7),
            US8_3(Dice_contract::US7),
            US8_4(Dice_contract::US7),
            US8_5(Dice_contract::US7),
            US8_6(Dice_contract::US7),
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0(string),
            US9_1,
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(i64),
            US10_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(
                LrcPtr<Dice_contract::Mut0>,
                LrcPtr<Dice_contract::Mut1>,
                LrcPtr<Dice_contract::Mut2>,
                LrcPtr<Dice_contract::Mut3>,
                LrcPtr<Dice_contract::Mut4>,
                Option<i64>,
            ),
            US11_1,
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US12 {
            US12_0(char),
            US12_1,
        }
        impl core::fmt::Display for US12 {
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
        pub enum US13 {
            US13_0(Func0<LrcPtr<Dice_contract::UH1>>),
            US13_1(LrcPtr<Dice_contract::UH1>),
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut6 {
            pub l0: MutCell<Dice_contract::US13>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US14 {
            US14_0(u8),
            US14_1,
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut7 {
            pub l0: MutCell<Dice_contract::US14>,
        }
        impl core::fmt::Display for Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US15 {
            US15_0(u64, LrcPtr<Dice_contract::UH0>),
            US15_1,
        }
        impl core::fmt::Display for US15 {
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
        pub enum US16 {
            US16_0(u64),
            US16_1,
        }
        impl core::fmt::Display for US16 {
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
        pub fn closure11(unitVar: (), v0_1: string) -> Dice_contract::US9 {
            Dice_contract::US9::US9_0(v0_1)
        }
        pub fn method8() -> Func1<string, Dice_contract::US9> {
            Func1::new(move |v: string| Dice_contract::closure11((), v))
        }
        pub fn method5(v0_1: string) -> string {
            panic!(
                "{}",
                sprintf!(
                    "env.get_environment_variable / target: {} / var: {}",
                    Dice_contract::US8::US8_4(Dice_contract::US7::US7_2),
                    v0_1
                ),
            )
        }
        pub fn closure12(v0_1: i64, unitVar: ()) -> i64 {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: i64) -> Dice_contract::US10 {
            Dice_contract::US10::US10_0(v0_1)
        }
        pub fn closure14(unitVar: (), v0_1: LrcPtr<Exception>) -> Dice_contract::US10 {
            Dice_contract::US10::US10_1(v0_1)
        }
        pub fn method9(v0_1: i64) -> Dice_contract::US10 {
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
            let v6: string = toLower(string("Critical"));
            let v20: string = toLower(string("Warning"));
            let v34: string = toLower(string("Info"));
            let v48: string = toLower(string("Debug"));
            let v62: string = toLower(string("Verbose"));
            let v76: Dice_contract::US5 = if string("Verbose") == (v1.clone()) {
                Dice_contract::US5::US5_0(Dice_contract::US4::US4_0)
            } else {
                Dice_contract::US5::US5_1
            };
            (
                match &v76 {
                    Dice_contract::US5::US5_0(v76_0_0) => Dice_contract::US5::US5_0(
                        match &v76 {
                            Dice_contract::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v83: Dice_contract::US5 = if string("Debug") == (v1.clone()) {
                            Dice_contract::US5::US5_0(Dice_contract::US4::US4_1)
                        } else {
                            Dice_contract::US5::US5_1
                        };
                        match &v83 {
                            Dice_contract::US5::US5_0(v83_0_0) => Dice_contract::US5::US5_0(
                                match &v83 {
                                    Dice_contract::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v90: Dice_contract::US5 = if string("Info") == (v1.clone()) {
                                    Dice_contract::US5::US5_0(Dice_contract::US4::US4_2)
                                } else {
                                    Dice_contract::US5::US5_1
                                };
                                match &v90 {
                                    Dice_contract::US5::US5_0(v90_0_0) => {
                                        Dice_contract::US5::US5_0(
                                            match &v90 {
                                                Dice_contract::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v97: Dice_contract::US5 =
                                            if string("Warning") == (v1.clone()) {
                                                Dice_contract::US5::US5_0(Dice_contract::US4::US4_3)
                                            } else {
                                                Dice_contract::US5::US5_1
                                            };
                                        match &v97 {
                                            Dice_contract::US5::US5_0(v97_0_0) => {
                                                Dice_contract::US5::US5_0(
                                                    match &v97 {
                                                        Dice_contract::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v104: Dice_contract::US5 =
                                                    if string("Critical") == (v1.clone()) {
                                                        Dice_contract::US5::US5_0(
                                                            Dice_contract::US4::US4_4,
                                                        )
                                                    } else {
                                                        Dice_contract::US5::US5_1
                                                    };
                                                match &v104 {
                                                    Dice_contract::US5::US5_0(v104_0_0) => {
                                                        Dice_contract::US5::US5_0(
                                                            match &v104 {
                                                                Dice_contract::US5::US5_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v111: Dice_contract::US5 =
                                                            if (v62.clone()) == (v1.clone()) {
                                                                Dice_contract::US5::US5_0(
                                                                    Dice_contract::US4::US4_0,
                                                                )
                                                            } else {
                                                                Dice_contract::US5::US5_1
                                                            };
                                                        match &v111 {
                                                         Dice_contract::US5::US5_0(v111_0_0)
                                                         =>
                                                         Dice_contract::US5::US5_0(match &v111
                                                                                       {
                                                                                       Dice_contract::US5::US5_0(x)
                                                                                       =>
                                                                                       x.clone(),
                                                                                       _
                                                                                       =>
                                                                                       unreachable!(),
                                                                                   }.clone()),
                                                         _ => {
                                                             let v118:
                                                                     Dice_contract::US5 =
                                                                 if (v48.clone())
                                                                        ==
                                                                        (v1.clone())
                                                                    {
                                                                     Dice_contract::US5::US5_0(Dice_contract::US4::US4_1)
                                                                 } else {
                                                                     Dice_contract::US5::US5_1
                                                                 };
                                                             match &v118 {
                                                                 Dice_contract::US5::US5_0(v118_0_0)
                                                                 =>
                                                                 Dice_contract::US5::US5_0(match &v118
                                                                                               {
                                                                                               Dice_contract::US5::US5_0(x)
                                                                                               =>
                                                                                               x.clone(),
                                                                                               _
                                                                                               =>
                                                                                               unreachable!(),
                                                                                           }.clone()),
                                                                 _ => {
                                                                     let v125:
                                                                             Dice_contract::US5 =
                                                                         if (v34.clone())
                                                                                ==
                                                                                (v1.clone())
                                                                            {
                                                                             Dice_contract::US5::US5_0(Dice_contract::US4::US4_2)
                                                                         } else {
                                                                             Dice_contract::US5::US5_1
                                                                         };
                                                                     match &v125
                                                                         {
                                                                         Dice_contract::US5::US5_0(v125_0_0)
                                                                         =>
                                                                         Dice_contract::US5::US5_0(match &v125
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
                                                                             let v132:
                                                                                     Dice_contract::US5 =
                                                                                 if (v20.clone())
                                                                                        ==
                                                                                        (v1.clone())
                                                                                    {
                                                                                     Dice_contract::US5::US5_0(Dice_contract::US4::US4_3)
                                                                                 } else {
                                                                                     Dice_contract::US5::US5_1
                                                                                 };
                                                                             match &v132
                                                                                 {
                                                                                 Dice_contract::US5::US5_0(v132_0_0)
                                                                                 =>
                                                                                 Dice_contract::US5::US5_0(match &v132
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
                                                                                     let v139:
                                                                                             Dice_contract::US5 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1.clone())
                                                                                            {
                                                                                             Dice_contract::US5::US5_0(Dice_contract::US4::US4_4)
                                                                                         } else {
                                                                                             Dice_contract::US5::US5_1
                                                                                         };
                                                                                     match &v139
                                                                                         {
                                                                                         Dice_contract::US5::US5_0(v139_0_0)
                                                                                         =>
                                                                                         Dice_contract::US5::US5_0(match &v139
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
                    let v198: DateTime = unbox::<DateTime>(fable_library_rust::Native_::getZero());
                    let v365: Dice_contract::US10 = Dice_contract::method9(unbox::<i64>(
                        fable_library_rust::Native_::getZero(),
                    ));
                    let v384: Dice_contract::US6 = match &v365 {
                        Dice_contract::US10::US10_0(v365_0_0) => {
                            Dice_contract::US6::US6_0(v365_0_0.clone())
                        }
                        _ => Dice_contract::US6::US6_1,
                    };
                    Dice_contract::US6::US6_0(match &v384 {
                        Dice_contract::US6::US6_0(v384_0_0) => match &v384 {
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
            let v199: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v200: &str = option_env!("AUTOMATION").unwrap_or("");
            let v218: std::string::String = String::from(v200);
            let _run_target_args__v3: (Dice_contract::US5, Dice_contract::US6) = (
                Dice_contract::US5::US5_1,
                if (fable_library_rust::String_::fromString(v218)) != string("True") {
                    Dice_contract::US6::US6_1
                } else {
                    Dice_contract::US6::US6_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v395: Dice_contract::US6 = _run_target_args__v3.1.clone();
            let v394: Dice_contract::US5 = _run_target_args__v3.0.clone();
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
                    l0: MutCell::new(match &v394 {
                        Dice_contract::US5::US5_0(v394_0_0) => match &v394 {
                            Dice_contract::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v395 {
                    Dice_contract::US6::US6_0(v395_0_0) => Some(match &v395 {
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
        pub fn method11() -> Func1<i64, Dice_contract::US6> {
            Func1::new(move |v: i64| Dice_contract::closure16((), v))
        }
        pub fn method12() -> string {
            string("hh:mm:ss")
        }
        pub fn method13() -> string {
            string("HH:mm:ss")
        }
        pub fn method10(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v1757: u64 = near_sdk::env::block_timestamp();
            let v1819: Dice_contract::US6 = defaultValue(
                Dice_contract::US6::US6_1,
                map(Dice_contract::method11(), v5),
            );
            let v1846: u64 = (match &v1819 {
                Dice_contract::US6::US6_0(v1819_0_0) => {
                    (v1757)
                        - (match &v1819 {
                            Dice_contract::US6::US6_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v1757,
            }) / 1000000000_u64;
            let v1847: u64 = (v1846) % 60_u64;
            let v1849: u64 = ((v1846) / 60_u64) % 60_u64;
            let v1851: u64 = ((v1846) / 3600_u64) % 24_u64;
            let v1853: std::string::String = format!("{:02}:{:02}:{:02}", v1851, v1849, v1847);
            fable_library_rust::String_::fromString(v1853)
        }
        pub fn method16() -> string {
            string("")
        }
        pub fn method17(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string) {
            let v4: string = append((v0_1.l0.get().clone()), (v1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method15(v0_1: char) -> string {
            let v10: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method17(v10.clone(), sprintf!("{}", v0_1));
            v10.l0.get().clone()
        }
        pub fn method14() -> string {
            let v181: &str = inline_colorization::color_bright_blue;
            let v199: std::string::String = String::from(v181);
            let v293: string = append(
                (fable_library_rust::String_::fromString(v199)),
                (Dice_contract::method15(getCharAt(toLower(string("Debug")), 0_i32))),
            );
            let v484: &str = inline_colorization::color_reset;
            let v502: std::string::String = String::from(v484);
            append((v293), (fable_library_rust::String_::fromString(v502)))
        }
        pub fn method20(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("{ "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method21(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("seed_excess_len"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method22(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string(" = "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method23(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("; "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method24(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("seed_excess"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method25(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string(" }"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method19(v0_1: i32, v1: string) -> string {
            let v11: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v11.clone());
            Dice_contract::method21(v11.clone());
            Dice_contract::method22(v11.clone());
            Dice_contract::method17(v11.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v11.clone());
            Dice_contract::method24(v11.clone());
            Dice_contract::method22(v11.clone());
            Dice_contract::method17(v11.clone(), v1);
            Dice_contract::method25(v11.clone());
            v11.l0.get().clone()
        }
        pub fn method28(v0_1: char, v1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1: MutCell<i64> = MutCell::new(v1);
            '_method28: loop {
                break '_method28 (if (v1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Dice_contract::US12 = if (v1.get().clone()) == 0_i64 {
                        Dice_contract::US12::US12_0(' ')
                    } else {
                        let v5: i64 = (v1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Dice_contract::US12::US12_0('\t')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Dice_contract::US12::US12_0('\r')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Dice_contract::US12::US12_0('\n')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Dice_contract::US12::US12_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Dice_contract::US12::US12_0(v19_0_0) => match &v19 {
                                Dice_contract::US12::US12_0(x) => x.clone(),
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
                        continue '_method28;
                    }
                });
            }
        }
        pub fn method27(v0_1: string, v1: i32, v2: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            let v2: MutCell<i32> = MutCell::new(v2);
            '_method27: loop {
                break '_method27 (if (v2.get().clone()) >= (v1.get().clone()) {
                    v1.get().clone()
                } else {
                    if Dice_contract::method28(
                        getCharAt(v0_1.get().clone(), v2.get().clone()),
                        0_i64,
                    ) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone();
                        let v2_temp: i32 = (v2.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        continue '_method27;
                    } else {
                        v2.get().clone()
                    }
                });
            }
        }
        pub fn method30(v0_1: char, v1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1: MutCell<i64> = MutCell::new(v1);
            '_method30: loop {
                break '_method30 (if (v1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Dice_contract::US12 = if (v1.get().clone()) == 0_i64 {
                        Dice_contract::US12::US12_0(' ')
                    } else {
                        let v5: i64 = (v1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Dice_contract::US12::US12_0('/')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Dice_contract::US12::US12_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Dice_contract::US12::US12_0(v11_0_0) => match &v11 {
                                Dice_contract::US12::US12_0(x) => x.clone(),
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
                        continue '_method30;
                    }
                });
            }
        }
        pub fn method29(v0_1: string, v1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method29: loop {
                break '_method29 (if (v1.get().clone()) <= 0_i32 {
                    0_i32
                } else {
                    let v3: i32 = (v1.get().clone()) - 1_i32;
                    if Dice_contract::method30(getCharAt(v0_1.get().clone(), v3), 0_i64) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_temp: i32 = v3;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method29;
                    } else {
                        v3
                    }
                });
            }
        }
        pub fn method26(v0_1: string) -> string {
            let v1: i32 = length(v0_1.clone());
            let v492: string = getSlice(
                v0_1.clone(),
                Some(Dice_contract::method27(v0_1, v1, 0_i32)),
                Some(v1),
            );
            getSlice(
                v492.clone(),
                Some(0_i32),
                Some(Dice_contract::method29(v492.clone(), length(v492))),
            )
        }
        pub fn method18(
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
            let v10: string = Dice_contract::method19(v8, v9);
            Dice_contract::method26(append(
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
        pub fn closure17(v0_1: LrcPtr<Dice_contract::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure19(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure18(unitVar: (), v0_1: string) {
            let v22: () = {
                Dice_contract::closure19(v0_1, ());
                ()
            };
            ()
        }
        pub fn method31(v0_1: i32, v1: LrcPtr<Dice_contract::Mut5>) -> bool {
            (v1.l0.get().clone()) < (v0_1)
        }
        pub fn closure9(v0_1: i32, v1: Vec<u8>, unitVar: ()) {
            fn v32() {
                Dice_contract::closure10((), ());
            }
            let v33: () = {
                v32();
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
            let v111: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v525: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v111,
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
                Dice_contract::US11::US11_1
            } else {
                let v149: () = {
                    v32();
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
                let v192: Option<i64> = patternInput_1.5.clone();
                let v191: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v190: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v189: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v188: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v187: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v240: string = Dice_contract::method18(
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    Dice_contract::method10(v187, v188, v189, v190, v191, v192),
                    Dice_contract::method14(),
                    v0_1,
                    sprintf!("{:?}", v1),
                );
                let v271: () = {
                    v32();
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
                let v312: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v310: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v309: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v353: () = {
                    Dice_contract::closure17(v309.clone(), ());
                    ()
                };
                let v394: string = if (v312.l0.get().clone()) == string("") {
                    v240.clone()
                } else {
                    if (v240.clone()) == string("") {
                        v312.l0.get().clone()
                    } else {
                        append(
                            (append((v312.l0.get().clone()), string("\n"))),
                            (v240.clone()),
                        )
                    }
                };
                let v412: &str = &*v394.clone();
                let v481 = v412.chars();
                let v483 = v481;
                let v485: Vec<char> = v483.collect::<Vec<_>>();
                let v487: Vec<Vec<char>> = v485
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v489: bool = true;
                let _vec_map: Vec<_> = v487
                    .into_iter()
                    .map(|x| {
                        //;
                        let v491: Vec<char> = x;
                        let v493: std::string::String = String::from_iter(v491);
                        let v495: bool = true;
                        v493
                    })
                    .collect::<Vec<_>>();
                let v497: Vec<std::string::String> = _vec_map;
                let v499: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v497.clone());
                let v500: i32 = get_Count(v499.clone());
                if if (v240.clone()) != string("") {
                    (v500) <= 1_i32
                } else {
                    false
                } {
                    v312.l0.set(v394);
                    ()
                } else {
                    v312.l0.set(string(""));
                    {
                        let v516: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v500, v516.clone()) {
                            let v518: i32 = v516.l0.get().clone();
                            let v519: std::string::String = v499[v518].clone();
                            let v521: bool = true;
                            near_sdk::log!("{}", v519);
                            let v522: i32 = (v518) + 1_i32;
                            v516.l0.set(v522);
                            ()
                        }
                        ()
                    }
                }
                (v310.l0.get().clone())(v240);
                Dice_contract::US11::US11_0(
                    v309,
                    v310,
                    patternInput_2.2.clone(),
                    v312,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method32() -> Func0<()> {
            Func0::new(move || Dice_contract::closure20((), ()))
        }
        pub fn closure21(v0_1: Func0<()>, unitVar: ()) {
            fn v31() {
                Dice_contract::closure10((), ());
            }
            let v32: () = {
                v31();
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
            let v110: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v511: Dice_contract::US11 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v110,
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
                    Dice_contract::US11::US11_1
                } else {
                    let v148: () = {
                        v31();
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
                    let v226: string = Dice_contract::method10(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v227: string = Dice_contract::method14();
                    let v258: () = {
                        v31();
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
                    let v299: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v297: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v296: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v340: () = {
                        Dice_contract::closure17(v296.clone(), ());
                        ()
                    };
                    let v382: string = if (v299.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v299.l0.get().clone()
                    };
                    let v400: &str = &*v382;
                    let v469 = v400.chars();
                    let v471 = v469;
                    let v473: Vec<char> = v471.collect::<Vec<_>>();
                    let v475: Vec<Vec<char>> = v473
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v477: bool = true;
                    let _vec_map: Vec<_> = v475
                        .into_iter()
                        .map(|x| {
                            //;
                            let v479: Vec<char> = x;
                            let v481: std::string::String = String::from_iter(v479);
                            let v483: bool = true;
                            v481
                        })
                        .collect::<Vec<_>>();
                    let v485: Vec<std::string::String> = _vec_map;
                    let v487: Array<std::string::String> =
                        fable_library_rust::NativeArray_::array_from(v485.clone());
                    let v488: i32 = get_Count(v487.clone());
                    v299.l0.set(string(""));
                    {
                        let v502: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v488, v502.clone()) {
                            let v504: i32 = v502.l0.get().clone();
                            let v505: std::string::String = v487[v504].clone();
                            let v507: bool = true;
                            near_sdk::log!("{}", v505);
                            let v508: i32 = (v504) + 1_i32;
                            v502.l0.set(v508);
                            ()
                        }
                        ()
                    }
                    (v297.l0.get().clone())(string(""));
                    Dice_contract::US11::US11_0(
                        v296,
                        v297,
                        patternInput_2.2.clone(),
                        v299,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
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
        pub fn method33() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure22((), v))
        }
        pub fn closure24(
            v0_1: LrcPtr<Dice_contract::UH1>,
            unitVar: (),
        ) -> LrcPtr<Dice_contract::UH1> {
            v0_1
        }
        pub fn method34(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: LrcPtr<Dice_contract::UH1> = Dice_contract::method34(
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
        pub fn method35(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH1>,
        ) -> LrcPtr<Dice_contract::UH1> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v5: LrcPtr<Dice_contract::UH1> =
                        Dice_contract::method35((v0_1_0_1)(), v1.clone());
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
        pub fn method36(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            match v0_1.as_ref() {
                Dice_contract::UH1::UH1_1 => v1.clone(),
                Dice_contract::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    LrcPtr::new(Dice_contract::UH0::UH0_1(
                        v0_1_0_0.clone(),
                        Dice_contract::method36((v0_1_0_1)(), v1.clone()),
                    ))
                }
            }
        }
        pub fn method37(v0_1: LrcPtr<Dice_contract::UH0>, v1: List<u8>) -> List<u8> {
            match v0_1.as_ref() {
                Dice_contract::UH0::UH0_0 => v1.clone(),
                Dice_contract::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice_contract::method37(
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
        pub fn method40(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("max"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method41(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("key"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method42(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("proof"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method43(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("block_timestamp"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method44(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("block_height"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method45(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("epoch_height"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method46(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("account_balance"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method47(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("signer_account_id"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method48(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("predecessor_account_id"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method49(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("seed"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method50(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("seeds"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method51(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("entropy_len"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method52(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("entropy"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method53(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("hash_u8"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method54(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("rolls"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method39(
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
            let v24: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v24.clone());
            Dice_contract::method40(v24.clone());
            Dice_contract::method22(v24.clone());
            Dice_contract::method17(v24.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v24.clone());
            Dice_contract::method41(v24.clone());
            Dice_contract::method22(v24.clone());
            {
                let v366: std::string::String = format!("{:#?}", v1);
                Dice_contract::method17(v24.clone(), fable_library_rust::String_::fromString(v366));
                Dice_contract::method23(v24.clone());
                Dice_contract::method42(v24.clone());
                Dice_contract::method22(v24.clone());
                {
                    let v632: std::string::String = format!("{:#?}", v2);
                    Dice_contract::method17(
                        v24.clone(),
                        fable_library_rust::String_::fromString(v632),
                    );
                    Dice_contract::method23(v24.clone());
                    Dice_contract::method43(v24.clone());
                    Dice_contract::method22(v24.clone());
                    Dice_contract::method17(v24.clone(), sprintf!("{}", v3));
                    Dice_contract::method23(v24.clone());
                    Dice_contract::method44(v24.clone());
                    Dice_contract::method22(v24.clone());
                    Dice_contract::method17(v24.clone(), sprintf!("{}", v4));
                    Dice_contract::method23(v24.clone());
                    Dice_contract::method45(v24.clone());
                    Dice_contract::method22(v24.clone());
                    Dice_contract::method17(v24.clone(), sprintf!("{}", v5));
                    Dice_contract::method23(v24.clone());
                    Dice_contract::method46(v24.clone());
                    Dice_contract::method22(v24.clone());
                    Dice_contract::method17(v24.clone(), v6);
                    Dice_contract::method23(v24.clone());
                    Dice_contract::method47(v24.clone());
                    Dice_contract::method22(v24.clone());
                    {
                        let v1637: std::string::String = format!("{:#?}", v7);
                        Dice_contract::method17(
                            v24.clone(),
                            fable_library_rust::String_::fromString(v1637),
                        );
                        Dice_contract::method23(v24.clone());
                        Dice_contract::method48(v24.clone());
                        Dice_contract::method22(v24.clone());
                        {
                            let v1903: std::string::String = format!("{:#?}", v8);
                            Dice_contract::method17(
                                v24.clone(),
                                fable_library_rust::String_::fromString(v1903),
                            );
                            Dice_contract::method23(v24.clone());
                            Dice_contract::method49(v24.clone());
                            Dice_contract::method22(v24.clone());
                            Dice_contract::method17(v24.clone(), v9);
                            Dice_contract::method23(v24.clone());
                            Dice_contract::method50(v24.clone());
                            Dice_contract::method22(v24.clone());
                            Dice_contract::method17(v24.clone(), v10);
                            Dice_contract::method23(v24.clone());
                            Dice_contract::method51(v24.clone());
                            Dice_contract::method22(v24.clone());
                            {
                                let v2519: std::string::String = format!("{:#?}", v11);
                                Dice_contract::method17(
                                    v24.clone(),
                                    fable_library_rust::String_::fromString(v2519),
                                );
                                Dice_contract::method23(v24.clone());
                                Dice_contract::method52(v24.clone());
                                Dice_contract::method22(v24.clone());
                                Dice_contract::method17(v24.clone(), v12);
                                Dice_contract::method23(v24.clone());
                                Dice_contract::method53(v24.clone());
                                Dice_contract::method22(v24.clone());
                                Dice_contract::method17(v24.clone(), v13);
                                Dice_contract::method23(v24.clone());
                                Dice_contract::method54(v24.clone());
                                Dice_contract::method22(v24.clone());
                                Dice_contract::method17(v24.clone(), v14);
                                Dice_contract::method25(v24.clone());
                                v24.l0.get().clone()
                            }
                        }
                    }
                }
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
            let v23: string = Dice_contract::method39(
                v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22,
            );
            Dice_contract::method26(append(
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
            fn v44() {
                Dice_contract::closure10((), ());
            }
            let v45: () = {
                v44();
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
            let v123: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v631: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v123,
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
                Dice_contract::US11::US11_1
            } else {
                let v161: () = {
                    v44();
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
                let v204: Option<i64> = patternInput_1.5.clone();
                let v203: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v202: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v201: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v200: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v199: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v239: string = Dice_contract::method10(
                    v199.clone(),
                    v200.clone(),
                    v201.clone(),
                    v202.clone(),
                    v203.clone(),
                    v204.clone(),
                );
                let v240: string = Dice_contract::method14();
                let v242: string = sprintf!("{:?}", v8);
                let v253: std::string::String = v9.to_string();
                let v255: std::string::String = v10.to_string();
                let v257: string = sprintf!("{:?}", v4);
                let v268: string = sprintf!("{:?}", v0_1);
                let v279: usize = v11.clone().len();
                let v281: string = sprintf!("{:?}", v11);
                let v292: string = sprintf!("{:?}", v12);
                let v323: Array<u8> = toArray(Dice_contract::method37(v13, empty::<u8>()));
                let v346: string = Dice_contract::method38(
                    v199,
                    v200,
                    v201,
                    v202,
                    v203,
                    v204,
                    v239,
                    v240,
                    v3,
                    v1,
                    v2,
                    v7,
                    v6,
                    v5,
                    v242,
                    v253,
                    v255,
                    v257,
                    v268,
                    v279,
                    v281,
                    v292,
                    sprintf!("{:?}", v323.to_vec()),
                );
                let v377: () = {
                    v44();
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
                let v418: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v416: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v415: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v459: () = {
                    Dice_contract::closure17(v415.clone(), ());
                    ()
                };
                let v500: string = if (v418.l0.get().clone()) == string("") {
                    v346.clone()
                } else {
                    if (v346.clone()) == string("") {
                        v418.l0.get().clone()
                    } else {
                        append(
                            (append((v418.l0.get().clone()), string("\n"))),
                            (v346.clone()),
                        )
                    }
                };
                let v518: &str = &*v500.clone();
                let v587 = v518.chars();
                let v589 = v587;
                let v591: Vec<char> = v589.collect::<Vec<_>>();
                let v593: Vec<Vec<char>> = v591
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v595: bool = true;
                let _vec_map: Vec<_> = v593
                    .into_iter()
                    .map(|x| {
                        //;
                        let v597: Vec<char> = x;
                        let v599: std::string::String = String::from_iter(v597);
                        let v601: bool = true;
                        v599
                    })
                    .collect::<Vec<_>>();
                let v603: Vec<std::string::String> = _vec_map;
                let v605: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v603.clone());
                let v606: i32 = get_Count(v605.clone());
                if if (v346.clone()) != string("") {
                    (v606) <= 1_i32
                } else {
                    false
                } {
                    v418.l0.set(v500);
                    ()
                } else {
                    v418.l0.set(string(""));
                    {
                        let v622: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v606, v622.clone()) {
                            let v624: i32 = v622.l0.get().clone();
                            let v625: std::string::String = v605[v624].clone();
                            let v627: bool = true;
                            near_sdk::log!("{}", v625);
                            let v628: i32 = (v624) + 1_i32;
                            v622.l0.set(v628);
                            ()
                        }
                        ()
                    }
                }
                (v416.l0.get().clone())(v346);
                Dice_contract::US11::US11_0(
                    v415,
                    v416,
                    patternInput_2.2.clone(),
                    v418,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method55(
            v0_1: LrcPtr<Dice_contract::UH0>,
            v1: LrcPtr<Dice_contract::UH0>,
        ) -> LrcPtr<Dice_contract::UH0> {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            '_method55: loop {
                break '_method55 (match v0_1.get().clone().as_ref() {
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
                        continue '_method55;
                    }
                });
            }
        }
        pub fn method56(
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
                        Dice_contract::method56(
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
            let v2: Dice_contract::US13 = v1.l0.get().clone();
            match &v2 {
                Dice_contract::US13::US13_0(v2_0_0) => {
                    let v5: LrcPtr<Dice_contract::UH1> = (v2_0_0)();
                    let v12: LrcPtr<Dice_contract::UH1> = match v5.as_ref() {
                        Dice_contract::UH1::UH1_1 => LrcPtr::new(Dice_contract::UH1::UH1_1),
                        Dice_contract::UH1::UH1_0(v5_0_0, v5_0_1) => {
                            LrcPtr::new(Dice_contract::UH1::UH1_0(
                                v5_0_0.clone(),
                                Dice_contract::method57(v0_1.clone(), v5_0_1.clone()),
                            ))
                        }
                    };
                    v1.l0.set(Dice_contract::US13::US13_1(v12.clone()));
                    v12
                }
                Dice_contract::US13::US13_1(v2_1_0) => v2_1_0.clone(),
            }
        }
        pub fn method57(
            v0_1: LrcPtr<Dice_contract::UH1>,
            v1: Func0<LrcPtr<Dice_contract::UH1>>,
        ) -> Func0<LrcPtr<Dice_contract::UH1>> {
            let v3: LrcPtr<Dice_contract::Mut6> = LrcPtr::new(Dice_contract::Mut6 {
                l0: MutCell::new(Dice_contract::US13::US13_0(v1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3 = v3.clone();
                move || Dice_contract::closure28(v0_1.clone(), v3.clone(), ())
            })
        }
        pub fn method61(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("p"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method62(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("n"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method60(v0_1: u64, v1: u64, v2: i8) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v12.clone());
            Dice_contract::method40(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v12.clone());
            Dice_contract::method61(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v1));
            Dice_contract::method23(v12.clone());
            Dice_contract::method62(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v2));
            Dice_contract::method25(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method59(
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
            let v11: string = Dice_contract::method60(v8, v9, v10);
            Dice_contract::method26(append(
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
        pub fn closure29(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v33() {
                Dice_contract::closure10((), ());
            }
            let v34: () = {
                v33();
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
            let v112: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v515: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v112,
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
                Dice_contract::US11::US11_1
            } else {
                let v150: () = {
                    v33();
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
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v230: string = Dice_contract::method59(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Dice_contract::method10(v188, v189, v190, v191, v192, v193),
                    Dice_contract::method14(),
                    v0_1,
                    v2,
                    v1,
                );
                let v261: () = {
                    v33();
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
                let v302: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v300: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Dice_contract::closure17(v299.clone(), ());
                    ()
                };
                let v384: string = if (v302.l0.get().clone()) == string("") {
                    v230.clone()
                } else {
                    if (v230.clone()) == string("") {
                        v302.l0.get().clone()
                    } else {
                        append(
                            (append((v302.l0.get().clone()), string("\n"))),
                            (v230.clone()),
                        )
                    }
                };
                let v402: &str = &*v384.clone();
                let v471 = v402.chars();
                let v473 = v471;
                let v475: Vec<char> = v473.collect::<Vec<_>>();
                let v477: Vec<Vec<char>> = v475
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v479: bool = true;
                let _vec_map: Vec<_> = v477
                    .into_iter()
                    .map(|x| {
                        //;
                        let v481: Vec<char> = x;
                        let v483: std::string::String = String::from_iter(v481);
                        let v485: bool = true;
                        v483
                    })
                    .collect::<Vec<_>>();
                let v487: Vec<std::string::String> = _vec_map;
                let v489: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v487.clone());
                let v490: i32 = get_Count(v489.clone());
                if if (v230.clone()) != string("") {
                    (v490) <= 1_i32
                } else {
                    false
                } {
                    v302.l0.set(v384);
                    ()
                } else {
                    v302.l0.set(string(""));
                    {
                        let v506: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v490, v506.clone()) {
                            let v508: i32 = v506.l0.get().clone();
                            let v509: std::string::String = v489[v508].clone();
                            let v511: bool = true;
                            near_sdk::log!("{}", v509);
                            let v512: i32 = (v508) + 1_i32;
                            v506.l0.set(v512);
                            ()
                        }
                        ()
                    }
                }
                (v300.l0.get().clone())(v230);
                Dice_contract::US11::US11_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    v302,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method58(v0_1: u64, v1: i8, v2: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1: MutCell<i8> = MutCell::new(v1);
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method58: loop {
                break '_method58 (if (v2.get().clone()) < (v0_1.get().clone()) {
                    let v4: u64 = (v2.get().clone()) * 6_u64;
                    if (v4) > (v2.get().clone()) {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_temp: i8 = (v1.get().clone()) + 1_i8;
                        let v2_temp: u64 = v4;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        continue '_method58;
                    } else {
                        let v559: () = {
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
                    let v1668: () = {
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
        pub fn method67(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("current_index"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method68(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("acc"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method69(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("len"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method70(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("last_item"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method66(v0_1: i64, v1: i64, v2: i64, v3: string) -> string {
            let v13: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v13.clone());
            Dice_contract::method67(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v13.clone());
            Dice_contract::method68(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), sprintf!("{}", v1));
            Dice_contract::method23(v13.clone());
            Dice_contract::method69(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), sprintf!("{}", v2));
            Dice_contract::method23(v13.clone());
            Dice_contract::method70(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), v3);
            Dice_contract::method25(v13.clone());
            v13.l0.get().clone()
        }
        pub fn method65(
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
            let v12: string = Dice_contract::method66(v8, v9, v10, v11);
            Dice_contract::method26(append(
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
        pub fn closure30(v0_1: i64, v1: i64, v2: i64, v3: Option<u8>, unitVar: ()) {
            fn v34() {
                Dice_contract::closure10((), ());
            }
            let v35: () = {
                v34();
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
            let v113: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v527: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v113,
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
                Dice_contract::US11::US11_1
            } else {
                let v151: () = {
                    v34();
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
                let v194: Option<i64> = patternInput_1.5.clone();
                let v193: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v192: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v191: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v190: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v189: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v242: string = Dice_contract::method65(
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    v194.clone(),
                    Dice_contract::method10(v189, v190, v191, v192, v193, v194),
                    Dice_contract::method14(),
                    v0_1,
                    v1,
                    v2,
                    sprintf!("{:?}", v3),
                );
                let v273: () = {
                    v34();
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
                let v314: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v312: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v311: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v355: () = {
                    Dice_contract::closure17(v311.clone(), ());
                    ()
                };
                let v396: string = if (v314.l0.get().clone()) == string("") {
                    v242.clone()
                } else {
                    if (v242.clone()) == string("") {
                        v314.l0.get().clone()
                    } else {
                        append(
                            (append((v314.l0.get().clone()), string("\n"))),
                            (v242.clone()),
                        )
                    }
                };
                let v414: &str = &*v396.clone();
                let v483 = v414.chars();
                let v485 = v483;
                let v487: Vec<char> = v485.collect::<Vec<_>>();
                let v489: Vec<Vec<char>> = v487
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v491: bool = true;
                let _vec_map: Vec<_> = v489
                    .into_iter()
                    .map(|x| {
                        //;
                        let v493: Vec<char> = x;
                        let v495: std::string::String = String::from_iter(v493);
                        let v497: bool = true;
                        v495
                    })
                    .collect::<Vec<_>>();
                let v499: Vec<std::string::String> = _vec_map;
                let v501: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v499.clone());
                let v502: i32 = get_Count(v501.clone());
                if if (v242.clone()) != string("") {
                    (v502) <= 1_i32
                } else {
                    false
                } {
                    v314.l0.set(v396);
                    ()
                } else {
                    v314.l0.set(string(""));
                    {
                        let v518: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v502, v518.clone()) {
                            let v520: i32 = v518.l0.get().clone();
                            let v521: std::string::String = v501[v520].clone();
                            let v523: bool = true;
                            near_sdk::log!("{}", v521);
                            let v524: i32 = (v520) + 1_i32;
                            v518.l0.set(v524);
                            ()
                        }
                        ()
                    }
                }
                (v312.l0.get().clone())(v242);
                Dice_contract::US11::US11_0(
                    v311,
                    v312,
                    patternInput_2.2.clone(),
                    v314,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method71(v0_1: i64, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US14 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method71: loop {
                break '_method71 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US14::US14_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice_contract::US14::US14_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method71;
                        }
                    }
                });
            }
        }
        pub fn method73() -> string {
            let v9: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            v9.l0.get().clone()
        }
        pub fn method72(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            let v8: string = Dice_contract::method73();
            Dice_contract::method26(append(
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
        pub fn closure31(unitVar: (), unitVar_1: ()) {
            fn v30() {
                Dice_contract::closure10((), ());
            }
            let v31: () = {
                v30();
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
            let v109: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v512: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v109,
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
                Dice_contract::US11::US11_1
            } else {
                let v147: () = {
                    v30();
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
                let v190: Option<i64> = patternInput_1.5.clone();
                let v189: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v188: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v187: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v186: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v185: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v227: string = Dice_contract::method72(
                    v185.clone(),
                    v186.clone(),
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    Dice_contract::method10(v185, v186, v187, v188, v189, v190),
                    Dice_contract::method14(),
                );
                let v258: () = {
                    v30();
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
                let v299: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v297: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v296: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v340: () = {
                    Dice_contract::closure17(v296.clone(), ());
                    ()
                };
                let v381: string = if (v299.l0.get().clone()) == string("") {
                    v227.clone()
                } else {
                    if (v227.clone()) == string("") {
                        v299.l0.get().clone()
                    } else {
                        append(
                            (append((v299.l0.get().clone()), string("\n"))),
                            (v227.clone()),
                        )
                    }
                };
                let v399: &str = &*v381.clone();
                let v468 = v399.chars();
                let v470 = v468;
                let v472: Vec<char> = v470.collect::<Vec<_>>();
                let v474: Vec<Vec<char>> = v472
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v476: bool = true;
                let _vec_map: Vec<_> = v474
                    .into_iter()
                    .map(|x| {
                        //;
                        let v478: Vec<char> = x;
                        let v480: std::string::String = String::from_iter(v478);
                        let v482: bool = true;
                        v480
                    })
                    .collect::<Vec<_>>();
                let v484: Vec<std::string::String> = _vec_map;
                let v486: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v484.clone());
                let v487: i32 = get_Count(v486.clone());
                if if (v227.clone()) != string("") {
                    (v487) <= 1_i32
                } else {
                    false
                } {
                    v299.l0.set(v381);
                    ()
                } else {
                    v299.l0.set(string(""));
                    {
                        let v503: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v487, v503.clone()) {
                            let v505: i32 = v503.l0.get().clone();
                            let v506: std::string::String = v486[v505].clone();
                            let v508: bool = true;
                            near_sdk::log!("{}", v506);
                            let v509: i32 = (v505) + 1_i32;
                            v503.l0.set(v509);
                            ()
                        }
                        ()
                    }
                }
                (v297.l0.get().clone())(v227);
                Dice_contract::US11::US11_0(
                    v296,
                    v297,
                    patternInput_2.2.clone(),
                    v299,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method64(
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
            '_method64: loop {
                break '_method64 ({
                    let v5: i64 = v1.l0.get().clone();
                    let v6: i64 = v2.l0.get().clone();
                    let v7: i64 = v3.l0.get().clone();
                    let v8: Dice_contract::US14 = v4.l0.get().clone();
                    let v596: () = {
                        Dice_contract::closure30(
                            v5,
                            v6,
                            v7,
                            match &v8 {
                                Dice_contract::US14::US14_0(v8_0_0) => Some(match &v8 {
                                    Dice_contract::US14::US14_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => None::<u8>,
                            },
                            (),
                        );
                        ()
                    };
                    let v1164: LrcPtr<Dice_contract::UH1> = v0_1();
                    let v1166: Dice_contract::US14 =
                        Dice_contract::method71(v1.l0.get().clone(), v1164);
                    match &v1166 {
                        Dice_contract::US14::US14_0(v1166_0_0) => {
                            let v1167: u8 = match &v1166 {
                                Dice_contract::US14::US14_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v1169: i64 = (v1.l0.get().clone()) + 1_i64;
                            v1.l0.set(v1169);
                            v4.l0.set(Dice_contract::US14::US14_0(v1167));
                            v1167
                        }
                        _ => {
                            let v1722: () = {
                                Dice_contract::closure31((), ());
                                ()
                            };
                            if (v3.l0.get().clone()) == -1_i64 {
                                let v2281: i64 = v1.l0.get().clone();
                                v3.l0.set(v2281);
                                ()
                            }
                            {
                                let v2287: i64 = if (v2.l0.get().clone()) >= (v3.l0.get().clone()) {
                                    1_i64
                                } else {
                                    (v2.l0.get().clone()) + 1_i64
                                };
                                v2.l0.set(v2287);
                                {
                                    let v2289: i64 = (v2.l0.get().clone()) - 1_i64;
                                    v1.l0.set(v2289);
                                    v4.l0.set(Dice_contract::US14::US14_1);
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
                                        continue '_method64;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method77(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("power"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method78(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("result"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method76(v0_1: i8, v1: u64, v2: u64) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v12.clone());
            Dice_contract::method77(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v12.clone());
            Dice_contract::method68(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v1));
            Dice_contract::method23(v12.clone());
            Dice_contract::method78(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v2));
            Dice_contract::method25(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method75(
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
            let v11: string = Dice_contract::method76(v8, v9, v10);
            Dice_contract::method26(append(
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
        pub fn closure32(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
            fn v33() {
                Dice_contract::closure10((), ());
            }
            let v34: () = {
                v33();
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
            let v112: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v515: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v112,
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
                Dice_contract::US11::US11_1
            } else {
                let v150: () = {
                    v33();
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
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v230: string = Dice_contract::method75(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Dice_contract::method10(v188, v189, v190, v191, v192, v193),
                    Dice_contract::method14(),
                    v1,
                    v0_1,
                    v2,
                );
                let v261: () = {
                    v33();
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
                let v302: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v300: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Dice_contract::closure17(v299.clone(), ());
                    ()
                };
                let v384: string = if (v302.l0.get().clone()) == string("") {
                    v230.clone()
                } else {
                    if (v230.clone()) == string("") {
                        v302.l0.get().clone()
                    } else {
                        append(
                            (append((v302.l0.get().clone()), string("\n"))),
                            (v230.clone()),
                        )
                    }
                };
                let v402: &str = &*v384.clone();
                let v471 = v402.chars();
                let v473 = v471;
                let v475: Vec<char> = v473.collect::<Vec<_>>();
                let v477: Vec<Vec<char>> = v475
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v479: bool = true;
                let _vec_map: Vec<_> = v477
                    .into_iter()
                    .map(|x| {
                        //;
                        let v481: Vec<char> = x;
                        let v483: std::string::String = String::from_iter(v481);
                        let v485: bool = true;
                        v483
                    })
                    .collect::<Vec<_>>();
                let v487: Vec<std::string::String> = _vec_map;
                let v489: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v487.clone());
                let v490: i32 = get_Count(v489.clone());
                if if (v230.clone()) != string("") {
                    (v490) <= 1_i32
                } else {
                    false
                } {
                    v302.l0.set(v384);
                    ()
                } else {
                    v302.l0.set(string(""));
                    {
                        let v506: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v490, v506.clone()) {
                            let v508: i32 = v506.l0.get().clone();
                            let v509: std::string::String = v489[v508].clone();
                            let v511: bool = true;
                            near_sdk::log!("{}", v509);
                            let v512: i32 = (v508) + 1_i32;
                            v506.l0.set(v512);
                            ()
                        }
                        ()
                    }
                }
                (v300.l0.get().clone())(v230);
                Dice_contract::US11::US11_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    v302,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
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
        pub fn method79(v0_1: i8, v1: LrcPtr<Dice_contract::UH2>) -> Dice_contract::US16 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH2>> = MutCell::new(v1.clone());
            '_method79: loop {
                break '_method79 (match v1.get().clone().as_ref() {
                    Dice_contract::UH2::UH2_1 => Dice_contract::US16::US16_1,
                    Dice_contract::UH2::UH2_0(v1_0_0, v1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice_contract::US16::US16_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH2> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method79;
                        }
                    }
                });
            }
        }
        pub fn method82(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("roll"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method83(v0_1: LrcPtr<Dice_contract::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("value"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method81(v0_1: i8, v1: u64, v2: u8, v3: u64) -> string {
            let v13: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v13.clone());
            Dice_contract::method77(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v13.clone());
            Dice_contract::method68(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), sprintf!("{}", v1));
            Dice_contract::method23(v13.clone());
            Dice_contract::method82(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), sprintf!("{}", v2));
            Dice_contract::method23(v13.clone());
            Dice_contract::method83(v13.clone());
            Dice_contract::method22(v13.clone());
            Dice_contract::method17(v13.clone(), sprintf!("{}", v3));
            Dice_contract::method25(v13.clone());
            v13.l0.get().clone()
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
            v10: u8,
            v11: u64,
        ) -> string {
            let v12: string = Dice_contract::method81(v8, v9, v10, v11);
            Dice_contract::method26(append(
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
        pub fn closure97(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
            fn v34() {
                Dice_contract::closure10((), ());
            }
            let v35: () = {
                v34();
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
            let v113: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v516: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v113,
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
                Dice_contract::US11::US11_1
            } else {
                let v151: () = {
                    v34();
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
                let v194: Option<i64> = patternInput_1.5.clone();
                let v193: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v192: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v191: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v190: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v189: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v231: string = Dice_contract::method80(
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    v194.clone(),
                    Dice_contract::method10(v189, v190, v191, v192, v193, v194),
                    Dice_contract::method14(),
                    v1,
                    v0_1,
                    v2,
                    v3,
                );
                let v262: () = {
                    v34();
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
                let v303: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v301: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v300: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v344: () = {
                    Dice_contract::closure17(v300.clone(), ());
                    ()
                };
                let v385: string = if (v303.l0.get().clone()) == string("") {
                    v231.clone()
                } else {
                    if (v231.clone()) == string("") {
                        v303.l0.get().clone()
                    } else {
                        append(
                            (append((v303.l0.get().clone()), string("\n"))),
                            (v231.clone()),
                        )
                    }
                };
                let v403: &str = &*v385.clone();
                let v472 = v403.chars();
                let v474 = v472;
                let v476: Vec<char> = v474.collect::<Vec<_>>();
                let v478: Vec<Vec<char>> = v476
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v480: bool = true;
                let _vec_map: Vec<_> = v478
                    .into_iter()
                    .map(|x| {
                        //;
                        let v482: Vec<char> = x;
                        let v484: std::string::String = String::from_iter(v482);
                        let v486: bool = true;
                        v484
                    })
                    .collect::<Vec<_>>();
                let v488: Vec<std::string::String> = _vec_map;
                let v490: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v488.clone());
                let v491: i32 = get_Count(v490.clone());
                if if (v231.clone()) != string("") {
                    (v491) <= 1_i32
                } else {
                    false
                } {
                    v303.l0.set(v385);
                    ()
                } else {
                    v303.l0.set(string(""));
                    {
                        let v507: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v491, v507.clone()) {
                            let v509: i32 = v507.l0.get().clone();
                            let v510: std::string::String = v490[v509].clone();
                            let v512: bool = true;
                            near_sdk::log!("{}", v510);
                            let v513: i32 = (v509) + 1_i32;
                            v507.l0.set(v513);
                            ()
                        }
                        ()
                    }
                }
                (v301.l0.get().clone())(v231);
                Dice_contract::US11::US11_0(
                    v300,
                    v301,
                    patternInput_2.2.clone(),
                    v303,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method85(v0_1: i8, v1: u64, v2: u8) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v12.clone());
            Dice_contract::method77(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v12.clone());
            Dice_contract::method68(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v1));
            Dice_contract::method23(v12.clone());
            Dice_contract::method82(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v2));
            Dice_contract::method25(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method84(
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
            let v11: string = Dice_contract::method85(v8, v9, v10);
            Dice_contract::method26(append(
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
        pub fn closure98(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
            fn v33() {
                Dice_contract::closure10((), ());
            }
            let v34: () = {
                v33();
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
            let v112: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v515: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v112,
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
                Dice_contract::US11::US11_1
            } else {
                let v150: () = {
                    v33();
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
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v230: string = Dice_contract::method84(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Dice_contract::method10(v188, v189, v190, v191, v192, v193),
                    Dice_contract::method14(),
                    v1,
                    v0_1,
                    v2,
                );
                let v261: () = {
                    v33();
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
                let v302: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v300: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Dice_contract::closure17(v299.clone(), ());
                    ()
                };
                let v384: string = if (v302.l0.get().clone()) == string("") {
                    v230.clone()
                } else {
                    if (v230.clone()) == string("") {
                        v302.l0.get().clone()
                    } else {
                        append(
                            (append((v302.l0.get().clone()), string("\n"))),
                            (v230.clone()),
                        )
                    }
                };
                let v402: &str = &*v384.clone();
                let v471 = v402.chars();
                let v473 = v471;
                let v475: Vec<char> = v473.collect::<Vec<_>>();
                let v477: Vec<Vec<char>> = v475
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v479: bool = true;
                let _vec_map: Vec<_> = v477
                    .into_iter()
                    .map(|x| {
                        //;
                        let v481: Vec<char> = x;
                        let v483: std::string::String = String::from_iter(v481);
                        let v485: bool = true;
                        v483
                    })
                    .collect::<Vec<_>>();
                let v487: Vec<std::string::String> = _vec_map;
                let v489: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v487.clone());
                let v490: i32 = get_Count(v489.clone());
                if if (v230.clone()) != string("") {
                    (v490) <= 1_i32
                } else {
                    false
                } {
                    v302.l0.set(v384);
                    ()
                } else {
                    v302.l0.set(string(""));
                    {
                        let v506: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v490, v506.clone()) {
                            let v508: i32 = v506.l0.get().clone();
                            let v509: std::string::String = v489[v508].clone();
                            let v511: bool = true;
                            near_sdk::log!("{}", v509);
                            let v512: i32 = (v508) + 1_i32;
                            v506.l0.set(v512);
                            ()
                        }
                        ()
                    }
                }
                (v300.l0.get().clone())(v230);
                Dice_contract::US11::US11_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    v302,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method74(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US15 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method74: loop {
                break '_method74 (if (v0_1.get().clone()) < 0_i8 {
                    let v4: u64 = (v2.get().clone()) + 1_u64;
                    let v556: () = {
                        Dice_contract::closure32(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US15::US15_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US15::US15_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v1116: LrcPtr<Dice_contract::UH0> = match v1.get().clone().as_ref()
                            {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v1115: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v1115) > 1_u8 {
                                let v1121: Dice_contract::US16 = Dice_contract::method79(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure33((), ())),
                                    )),
                                );
                                let v1128: u64 = (((v1115) - 1_u8) as u64)
                                    * (match &v1121 {
                                        Dice_contract::US16::US16_0(v1121_0_0) => match &v1121 {
                                            Dice_contract::US16::US16_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v1680: () = {
                                    Dice_contract::closure97(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v1115,
                                        v1128,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v1116;
                                    let v2_temp: u64 = (v2.get().clone()) + (v1128);
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method74;
                                }
                            } else {
                                let v2791: () = {
                                    Dice_contract::closure98(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v1115,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v1116.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method74;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method86(
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
                    Dice_contract::method64(
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                    ),
                    Dice_contract::method86(v0_1, v1, v2, v3, v4, v5, (v6) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice_contract::UH0::UH0_0)
            }
        }
        pub fn method87(
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
            '_method87: loop {
                break '_method87 ({
                    let v8: i8 = (v6.get().clone()) + 1_i8;
                    if (v6.get().clone()) < (v8) {
                        Dice_contract::method63(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            LrcPtr::new(Dice_contract::UH0::UH0_1(
                                Dice_contract::method64(
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
                        let v14: Dice_contract::US15 =
                            Dice_contract::method74(v6.get().clone(), v7.get().clone(), 0_u64);
                        if let Dice_contract::US15::US15_0(v14_0_0, v14_0_1) = &v14 {
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
                                let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method86(
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
                                continue '_method87;
                            }
                        } else {
                            let v0_1_temp = v0_1.get().clone();
                            let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                            let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                            let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                            let v4_temp: LrcPtr<Dice_contract::Mut7> = v4.get().clone();
                            let v5_temp: u64 = v5.get().clone();
                            let v6_temp: i8 = v6.get().clone();
                            let v7_temp: LrcPtr<Dice_contract::UH0> = Dice_contract::method86(
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
                            continue '_method87;
                        }
                    }
                });
            }
        }
        pub fn method63(
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
            '_method63: loop {
                break '_method63 (if (v8.get().clone()) < ((v6.get().clone()) + 1_i8) {
                    let v0_1_temp = v0_1.get().clone();
                    let v1_temp: LrcPtr<Dice_contract::Mut0> = v1.get().clone();
                    let v2_temp: LrcPtr<Dice_contract::Mut0> = v2.get().clone();
                    let v3_temp: LrcPtr<Dice_contract::Mut0> = v3.get().clone();
                    let v4_temp: LrcPtr<Dice_contract::Mut7> = v4.get().clone();
                    let v5_temp: u64 = v5.get().clone();
                    let v6_temp: i8 = v6.get().clone();
                    let v7_temp: LrcPtr<Dice_contract::UH0> =
                        LrcPtr::new(Dice_contract::UH0::UH0_1(
                            Dice_contract::method64(
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
                    continue '_method63;
                } else {
                    let v16: Dice_contract::US15 =
                        Dice_contract::method74(v6.get().clone(), v7.get().clone(), 0_u64);
                    if let Dice_contract::US15::US15_0(v16_0_0, v16_0_1) = &v16 {
                        let v17: u64 = v16_0_0.clone();
                        if (v17) <= (v5.get().clone()) {
                            v17
                        } else {
                            Dice_contract::method87(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                                Dice_contract::method86(
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
                        Dice_contract::method87(
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            Dice_contract::method86(
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
        pub fn method88() -> Func0<()> {
            Func0::new(move || Dice_contract::closure20((), ()))
        }
        pub fn closure99(v0_1: Func0<()>, unitVar: ()) {
            fn v31() {
                Dice_contract::closure10((), ());
            }
            let v32: () = {
                v31();
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
            let v110: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v511: Dice_contract::US11 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v110,
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
                    Dice_contract::US11::US11_1
                } else {
                    let v148: () = {
                        v31();
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
                    let v226: string = Dice_contract::method10(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v227: string = Dice_contract::method14();
                    let v258: () = {
                        v31();
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
                    let v299: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v297: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v296: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v340: () = {
                        Dice_contract::closure17(v296.clone(), ());
                        ()
                    };
                    let v382: string = if (v299.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v299.l0.get().clone()
                    };
                    let v400: &str = &*v382;
                    let v469 = v400.chars();
                    let v471 = v469;
                    let v473: Vec<char> = v471.collect::<Vec<_>>();
                    let v475: Vec<Vec<char>> = v473
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v477: bool = true;
                    let _vec_map: Vec<_> = v475
                        .into_iter()
                        .map(|x| {
                            //;
                            let v479: Vec<char> = x;
                            let v481: std::string::String = String::from_iter(v479);
                            let v483: bool = true;
                            v481
                        })
                        .collect::<Vec<_>>();
                    let v485: Vec<std::string::String> = _vec_map;
                    let v487: Array<std::string::String> =
                        fable_library_rust::NativeArray_::array_from(v485.clone());
                    let v488: i32 = get_Count(v487.clone());
                    v299.l0.set(string(""));
                    {
                        let v502: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v488, v502.clone()) {
                            let v504: i32 = v502.l0.get().clone();
                            let v505: std::string::String = v487[v504].clone();
                            let v507: bool = true;
                            near_sdk::log!("{}", v505);
                            let v508: i32 = (v504) + 1_i32;
                            v502.l0.set(v508);
                            ()
                        }
                        ()
                    }
                    (v297.l0.get().clone())(string(""));
                    Dice_contract::US11::US11_0(
                        v296,
                        v297,
                        patternInput_2.2.clone(),
                        v299,
                        patternInput_2.4.clone(),
                        patternInput_2.5.clone(),
                    )
                };
            ()
        }
        pub fn method89(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method89: loop {
                break '_method89 (match v0_1.get().clone().as_ref() {
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
                        continue '_method89;
                    }
                });
            }
        }
        pub fn method91(v0_1: u64, v1: string, v2: string) -> string {
            let v12: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method16()),
            });
            Dice_contract::method20(v12.clone());
            Dice_contract::method40(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), sprintf!("{}", v0_1));
            Dice_contract::method23(v12.clone());
            Dice_contract::method54(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), v1);
            Dice_contract::method23(v12.clone());
            Dice_contract::method78(v12.clone());
            Dice_contract::method22(v12.clone());
            Dice_contract::method17(v12.clone(), v2);
            Dice_contract::method25(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method90(
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
            let v11: string = Dice_contract::method91(v8, v9, v10);
            Dice_contract::method26(append(
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
        pub fn closure100(v0_1: u64, v1: Vec<u8>, v2: Option<u64>, unitVar: ()) {
            fn v33() {
                Dice_contract::closure10((), ());
            }
            let v34: () = {
                v33();
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
            let v112: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v537: Dice_contract::US11 = if (if ((patternInput.2.clone()).l0.get().clone())
                == false
            {
                false
            } else {
                1_i32
                    >= (find(
                        v112,
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
                Dice_contract::US11::US11_1
            } else {
                let v150: () = {
                    v33();
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
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Dice_contract::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Dice_contract::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Dice_contract::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Dice_contract::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v252: string = Dice_contract::method90(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Dice_contract::method10(v188, v189, v190, v191, v192, v193),
                    Dice_contract::method14(),
                    v0_1,
                    sprintf!("{:?}", v1),
                    sprintf!("{:?}", v2),
                );
                let v283: () = {
                    v33();
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
                let v324: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                let v322: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                let v321: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                let v365: () = {
                    Dice_contract::closure17(v321.clone(), ());
                    ()
                };
                let v406: string = if (v324.l0.get().clone()) == string("") {
                    v252.clone()
                } else {
                    if (v252.clone()) == string("") {
                        v324.l0.get().clone()
                    } else {
                        append(
                            (append((v324.l0.get().clone()), string("\n"))),
                            (v252.clone()),
                        )
                    }
                };
                let v424: &str = &*v406.clone();
                let v493 = v424.chars();
                let v495 = v493;
                let v497: Vec<char> = v495.collect::<Vec<_>>();
                let v499: Vec<Vec<char>> = v497
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v501: bool = true;
                let _vec_map: Vec<_> = v499
                    .into_iter()
                    .map(|x| {
                        //;
                        let v503: Vec<char> = x;
                        let v505: std::string::String = String::from_iter(v503);
                        let v507: bool = true;
                        v505
                    })
                    .collect::<Vec<_>>();
                let v509: Vec<std::string::String> = _vec_map;
                let v511: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v509.clone());
                let v512: i32 = get_Count(v511.clone());
                if if (v252.clone()) != string("") {
                    (v512) <= 1_i32
                } else {
                    false
                } {
                    v324.l0.set(v406);
                    ()
                } else {
                    v324.l0.set(string(""));
                    {
                        let v528: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v512, v528.clone()) {
                            let v530: i32 = v528.l0.get().clone();
                            let v531: std::string::String = v511[v530].clone();
                            let v533: bool = true;
                            near_sdk::log!("{}", v531);
                            let v534: i32 = (v530) + 1_i32;
                            v528.l0.set(v534);
                            ()
                        }
                        ()
                    }
                }
                (v322.l0.get().clone())(v252);
                Dice_contract::US11::US11_0(
                    v321,
                    v322,
                    patternInput_2.2.clone(),
                    v324,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method92() -> Func0<()> {
            Func0::new(move || Dice_contract::closure20((), ()))
        }
        pub fn closure101(v0_1: Func0<()>, unitVar: ()) {
            fn v31() {
                Dice_contract::closure10((), ());
            }
            let v32: () = {
                v31();
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
            let v110: Dice_contract::US4 = (patternInput.4.clone()).l0.get().clone();
            let v511: Dice_contract::US11 =
                if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                    false
                } else {
                    1_i32
                        >= (find(
                            v110,
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
                    Dice_contract::US11::US11_1
                } else {
                    let v148: () = {
                        v31();
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
                    let v226: string = Dice_contract::method10(
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    );
                    let v227: string = Dice_contract::method14();
                    let v258: () = {
                        v31();
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
                    let v299: LrcPtr<Dice_contract::Mut3> = patternInput_2.3.clone();
                    let v297: LrcPtr<Dice_contract::Mut1> = patternInput_2.1.clone();
                    let v296: LrcPtr<Dice_contract::Mut0> = patternInput_2.0.clone();
                    let v340: () = {
                        Dice_contract::closure17(v296.clone(), ());
                        ()
                    };
                    let v382: string = if (v299.l0.get().clone()) == string("") {
                        string("")
                    } else {
                        v299.l0.get().clone()
                    };
                    let v400: &str = &*v382;
                    let v469 = v400.chars();
                    let v471 = v469;
                    let v473: Vec<char> = v471.collect::<Vec<_>>();
                    let v475: Vec<Vec<char>> = v473
                        .chunks(15000)
                        .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                        .collect::<Vec<_>>();
                    let v477: bool = true;
                    let _vec_map: Vec<_> = v475
                        .into_iter()
                        .map(|x| {
                            //;
                            let v479: Vec<char> = x;
                            let v481: std::string::String = String::from_iter(v479);
                            let v483: bool = true;
                            v481
                        })
                        .collect::<Vec<_>>();
                    let v485: Vec<std::string::String> = _vec_map;
                    let v487: Array<std::string::String> =
                        fable_library_rust::NativeArray_::array_from(v485.clone());
                    let v488: i32 = get_Count(v487.clone());
                    v299.l0.set(string(""));
                    {
                        let v502: LrcPtr<Dice_contract::Mut5> = LrcPtr::new(Dice_contract::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice_contract::method31(v488, v502.clone()) {
                            let v504: i32 = v502.l0.get().clone();
                            let v505: std::string::String = v487[v504].clone();
                            let v507: bool = true;
                            near_sdk::log!("{}", v505);
                            let v508: i32 = (v504) + 1_i32;
                            v502.l0.set(v508);
                            ()
                        }
                        ()
                    }
                    (v297.l0.get().clone())(string(""));
                    Dice_contract::US11::US11_0(
                        v296,
                        v297,
                        patternInput_2.2.clone(),
                        v299,
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
                    let v40: bool = true; /*;
                    let v42: */
                    () /* = fable_library_rust::Native_::getZero();
                    let v53: bool = true; */;
                    let v55: string = string("b\"seeds\"");
                    let v56: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (2_u32, near_sdk::store::vec::Vector::new(v56));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
        {
        let v63: bool =
        true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
        let v65: bool =
        true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed(&mut self, seed: Vec<u8>) {
                //;
                {
                    let v70: &mut near_sdk::store::vec::Vector<u8> = &mut self.0.1;
                    let v72: Vec<u8> = seed;
                    let v74: bool = true;
                    v70.extend(v72); //;
                    let v156: Dice_contract::US0 = Dice_contract::method0(v70.len());
                    let v175: Dice_contract::US1 = match &v156 {
                        Dice_contract::US0::US0_0(v156_0_0) => {
                            Dice_contract::US1::US1_0(v156_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v212: i32 = match &v175 {
                        Dice_contract::US1::US1_0(v175_0_0) => match &v175 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v295: Dice_contract::US2 = Dice_contract::method1();
                    let v314: Dice_contract::US3 = match &v295 {
                        Dice_contract::US2::US2_0(v295_0_0) => {
                            Dice_contract::US3::US3_0(v295_0_0.clone())
                        }
                        _ => Dice_contract::US3::US3_1,
                    };
                    let v431: Dice_contract::US0 = Dice_contract::method2(match &v314 {
                        Dice_contract::US3::US3_0(v314_0_0) => match &v314 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    });
                    let v450: Dice_contract::US1 = match &v431 {
                        Dice_contract::US0::US0_0(v431_0_0) => {
                            Dice_contract::US1::US1_0(v431_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v564: i32 = (v212)
                        - (match &v450 {
                            Dice_contract::US1::US1_0(v450_0_0) => match &v450 {
                                Dice_contract::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        });
                    if (v564) > 0_i32 {
                        let v1130: () = {
                            Dice_contract::closure9(
                                v564,
                                v70.drain(0..v564 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v2248: () = {
                            Dice_contract::closure21(Dice_contract::method32(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v2808: bool =
        true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
        let v2810: bool =
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
        let v2818: bool =
        true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
        let v2820: bool =
        true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v2825: std::string::String = key;
                    let v2827: std::string::String = proof;
                    let v2829: u64 = max;
                    let v2831: &mut near_sdk::store::vec::Vector<u8> = &mut self.0.1;
                    let v2833: Vec<u8> = near_sdk::env::random_seed();
                    let v2835: u64 = near_sdk::env::epoch_height();
                    let v2837: u64 = near_sdk::env::block_height();
                    let v2839: u64 = near_sdk::env::block_timestamp();
                    let v2841: near_token::NearToken = near_sdk::env::account_balance();
                    let v2843: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v2845: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v2847: &near_sdk::store::vec::Vector<u8> = &*v2831;
                    let v2849: Vec<u8> = v2847.iter().map(|x| *x).collect::<Vec<_>>();
                    let v2851: _ = v2835.to_le_bytes();
                    let v2853: Vec<u8> = v2851.to_vec();
                    let v2855: _ = v2837.to_le_bytes();
                    let v2857: Vec<u8> = v2855.to_vec();
                    let v2859: _ = v2839.to_le_bytes();
                    let v2861: Vec<u8> = v2859.to_vec();
                    let v2863: u128 = v2841.clone().as_yoctonear();
                    let v2865: _ = v2863.to_le_bytes();
                    let v2867: Vec<u8> = v2865.to_vec();
                    let v2869: &[u8] = v2843.as_bytes();
                    let v2871: Vec<u8> = v2869.to_vec();
                    let v2873: &[u8] = v2845.as_bytes();
                    let v2880: Array<Vec<u8>> = new_array(&[
                        v2833.clone(),
                        v2849,
                        v2853,
                        v2857,
                        v2861,
                        v2867,
                        v2871,
                        v2873.to_vec(),
                        v2827.clone().into_bytes(),
                        v2825.clone().into_bytes(),
                    ]);
                    let v2882: Vec<Vec<u8>> = v2880.to_vec();
                    let v2884: Vec<u8> = v2882.concat();
                    let v2886: Vec<u8> = near_sdk::env::keccak512(&v2884.clone());
                    let v2888: bool = true;
                    v2831.extend(v2886.clone()); //;
                    let v2970: Dice_contract::US0 = Dice_contract::method0(v2831.len());
                    let v2989: Dice_contract::US1 = match &v2970 {
                        Dice_contract::US0::US0_0(v2970_0_0) => {
                            Dice_contract::US1::US1_0(v2970_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v3026: i32 = match &v2989 {
                        Dice_contract::US1::US1_0(v2989_0_0) => match &v2989 {
                            Dice_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v3109: Dice_contract::US2 = Dice_contract::method1();
                    let v3128: Dice_contract::US3 = match &v3109 {
                        Dice_contract::US2::US2_0(v3109_0_0) => {
                            Dice_contract::US3::US3_0(v3109_0_0.clone())
                        }
                        _ => Dice_contract::US3::US3_1,
                    };
                    let v3245: Dice_contract::US0 = Dice_contract::method2(match &v3128 {
                        Dice_contract::US3::US3_0(v3128_0_0) => match &v3128 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    });
                    let v3264: Dice_contract::US1 = match &v3245 {
                        Dice_contract::US0::US0_0(v3245_0_0) => {
                            Dice_contract::US1::US1_0(v3245_0_0.clone())
                        }
                        _ => Dice_contract::US1::US1_1,
                    };
                    let v3378: i32 = (v3026)
                        - (match &v3264 {
                            Dice_contract::US1::US1_0(v3264_0_0) => match &v3264 {
                                Dice_contract::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        });
                    if (v3378) > 0_i32 {
                        let v3944: () = {
                            Dice_contract::closure9(
                                v3378,
                                v2831.drain(0..v3378 as u32).collect::<Vec<_>>(),
                                (),
                            );
                            ()
                        };
                        ()
                    }
                    {
                        let v5062: () = {
                            Dice_contract::closure21(Dice_contract::method32(), ());
                            ()
                        };
                        let v5620: List<u8> = ofArray(
                            fable_library_rust::NativeArray_::array_from(v2886.clone().clone()),
                        );
                        let v5702: LrcPtr<Dice_contract::UH0> = Dice_contract::method36(
                            Dice_contract::method35(
                                Dice_contract::method34(
                                    foldBack(
                                        Func2::new(
                                            move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                                                (Dice_contract::method33())(b0)(b1)
                                            },
                                        ),
                                        v5620,
                                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                                    ),
                                    LrcPtr::new(Dice_contract::UH1::UH1_1),
                                ),
                                LrcPtr::new(Dice_contract::UH1::UH1_1),
                            ),
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                        );
                        let v6359: () = {
                            Dice_contract::closure26(
                                v2831,
                                v2825,
                                v2827,
                                v2829,
                                v2833,
                                v2835,
                                v2837,
                                v2839,
                                v2841,
                                v2843,
                                v2845,
                                v2884,
                                v2886,
                                v5702.clone(),
                                (),
                            );
                            ()
                        };
                        let v7025: LrcPtr<Dice_contract::UH1> = Dice_contract::method34(
                            Dice_contract::method56(
                                v5702.clone(),
                                Dice_contract::method55(
                                    v5702,
                                    LrcPtr::new(Dice_contract::UH0::UH0_0),
                                ),
                            ),
                            LrcPtr::new(Dice_contract::UH1::UH1_1),
                        );
                        let v7041: u64 = Dice_contract::method63(
                            Dice_contract::method57(
                                v7025.clone(),
                                Func0::new({
                                    let v7025 = v7025.clone();
                                    move || Dice_contract::closure27(v7025.clone(), ())
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
                                l0: MutCell::new(Dice_contract::US14::US14_1),
                            }),
                            v2829,
                            (if (v2829) == 1_u64 {
                                1_i8
                            } else {
                                Dice_contract::method58(v2829, 0_i8, 1_u64)
                            }) - 1_i8,
                            LrcPtr::new(Dice_contract::UH0::UH0_0),
                            0_i8,
                        );
                        let v7592: () = {
                            Dice_contract::closure99(Dice_contract::method88(), ());
                            ()
                        };
                        v7041 //;
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v8153: bool =
        true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy;
        let v8155: bool =
        true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v8160: u64 = max;
                    let v8162: Vec<u8> = rolls;
                    let v8166: List<u8> = ofArray(fable_library_rust::NativeArray_::array_from(
                        v8162.clone().clone(),
                    ));
                    let v8186: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method33())(b0)(b1)
                        }),
                        v8166,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v8247: Dice_contract::US15 = Dice_contract::method74(
                        (Dice_contract::method89(v8186.clone(), 0_i8)) - 1_i8,
                        v8186,
                        0_u64,
                    );
                    let v8257: Dice_contract::US16 =
                        if let Dice_contract::US15::US15_0(v8247_0_0, v8247_0_1) = &v8247 {
                            let v8248: u64 = v8247_0_0.clone();
                            if if (v8248) >= 1_u64 {
                                (v8248) <= (v8160)
                            } else {
                                false
                            } {
                                Dice_contract::US16::US16_0(v8248)
                            } else {
                                Dice_contract::US16::US16_1
                            }
                        } else {
                            Dice_contract::US16::US16_1
                        };
                    let v8282: Option<u64> = match &v8257 {
                        Dice_contract::US16::US16_0(v8257_0_0) => Some(match &v8257 {
                            Dice_contract::US16::US16_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v8856: () = {
                        Dice_contract::closure100(v8160, v8162, v8282.clone(), ());
                        ()
                    };
                    let v9985: () = {
                        Dice_contract::closure101(Dice_contract::method92(), ());
                        ()
                    };
                    v8282 //;
                } //;
            } //;
        } /* c;
        {
        let v10545: bool =
        true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy;
        let v10547: bool =
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
        let v10560:
        bool =
        true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy;
        let v10562:
        bool =
        true; */
 // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v10566: bool = true;
            {
                (); // ?? / i': 1uy / n: 12uy;
                let v10568: bool = true;
                {
                    (); // ?? / i': 2uy / n: 12uy;
                    let v10570: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 12uy;
                        let v10572: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 12uy;
                            let v10574: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 12uy;
                                let v10576: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 12uy;
                                    let v10578: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 12uy;
                                        let v10580: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 12uy;
                                            let v10582: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 12uy;
                                                let v10584: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 12uy;
                                                    let v10586: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 12uy;
                                                        let v10588: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 12uy;
                                                            let v10590: bool = true;
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
