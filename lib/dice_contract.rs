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
        use fable_library_rust::Exception_::try_catch;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::getNull;
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
            US6_5(Dice::US5),
            US6_6(Dice::US5),
            US6_7(Dice::US5),
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
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(i64),
            US8_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                LrcPtr<Dice::Mut5>,
                LrcPtr<Dice::Mut6>,
                Option<i64>,
            ),
            US9_1,
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US10 {
            US10_0(char),
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut7 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US11 {
            US11_0(u64, LrcPtr<Dice::UH1>),
            US11_1,
        }
        impl core::fmt::Display for US11 {
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
        pub enum US12 {
            US12_0(u64),
            US12_1,
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(i32),
            US13_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US14 {
            US14_0(i32),
            US14_1,
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(u8),
            US15_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US16 {
            US16_0(i64, LrcPtr<Dice::UH1>),
            US16_1,
        }
        impl core::fmt::Display for US16 {
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
        pub fn method9(v0_1: string) -> string {
            v0_1
        }
        pub fn method10() -> string {
            string("")
        }
        pub fn closure10(unitVar: (), v0_1: string) -> Dice::US7 {
            Dice::US7::US7_0(v0_1)
        }
        pub fn method11() -> Func1<string, Dice::US7> {
            Func1::new(move |v: string| Dice::closure10((), v))
        }
        pub fn method8(v0_1: string) -> string {
            panic!(
                "{}",
                sprintf!(
                    "env.get_environment_variable / target: {} / var: {}",
                    Dice::US6::US6_5(Dice::US5::US5_2),
                    v0_1
                ),
            )
        }
        pub fn closure11(v0_1: i64, unitVar: ()) -> i64 {
            v0_1
        }
        pub fn closure12(unitVar: (), v0_1: i64) -> Dice::US8 {
            Dice::US8::US8_0(v0_1)
        }
        pub fn closure13(unitVar: (), v0_1: Func0<LrcPtr<Exception>>) -> LrcPtr<Exception> {
            v0_1()
        }
        pub fn closure14(unitVar: (), v0_1: LrcPtr<Exception>) -> Dice::US8 {
            Dice::US8::US8_1(v0_1)
        }
        pub fn method12(v0_1: i64) -> Dice::US8 {
            try_catch(
                || Dice::closure12((), Dice::closure11(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Dice::closure14(
                        (),
                        Dice::closure13(
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
        pub fn method7() -> (Dice::US3, Dice::US4) {
            let v1_1: string = Dice::method8(string("TRACE_LEVEL"));
            let v13: string = toLower(string("Critical"));
            let v36: string = toLower(string("Warning"));
            let v59: string = toLower(string("Info"));
            let v82: string = toLower(string("Debug"));
            let v105: string = toLower(string("Verbose"));
            let v121: Dice::US3 = if string("Verbose") == (v1_1.clone()) {
                Dice::US3::US3_0(Dice::US2::US2_0)
            } else {
                Dice::US3::US3_1
            };
            (
                match &v121 {
                    Dice::US3::US3_0(v121_0_0) => Dice::US3::US3_0(
                        match &v121 {
                            Dice::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v128: Dice::US3 = if string("Debug") == (v1_1.clone()) {
                            Dice::US3::US3_0(Dice::US2::US2_1)
                        } else {
                            Dice::US3::US3_1
                        };
                        match &v128 {
                            Dice::US3::US3_0(v128_0_0) => Dice::US3::US3_0(
                                match &v128 {
                                    Dice::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v135: Dice::US3 = if string("Info") == (v1_1.clone()) {
                                    Dice::US3::US3_0(Dice::US2::US2_2)
                                } else {
                                    Dice::US3::US3_1
                                };
                                match &v135 {
                                    Dice::US3::US3_0(v135_0_0) => Dice::US3::US3_0(
                                        match &v135 {
                                            Dice::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v142: Dice::US3 = if string("Warning") == (v1_1.clone())
                                        {
                                            Dice::US3::US3_0(Dice::US2::US2_3)
                                        } else {
                                            Dice::US3::US3_1
                                        };
                                        match &v142 {
                                            Dice::US3::US3_0(v142_0_0) => Dice::US3::US3_0(
                                                match &v142 {
                                                    Dice::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            ),
                                            _ => {
                                                let v149: Dice::US3 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Dice::US3::US3_0(Dice::US2::US2_4)
                                                    } else {
                                                        Dice::US3::US3_1
                                                    };
                                                match &v149 {
                                                    Dice::US3::US3_0(v149_0_0) => Dice::US3::US3_0(
                                                        match &v149 {
                                                            Dice::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    ),
                                                    _ => {
                                                        let v156: Dice::US3 =
                                                            if (v105.clone()) == (v1_1.clone()) {
                                                                Dice::US3::US3_0(Dice::US2::US2_0)
                                                            } else {
                                                                Dice::US3::US3_1
                                                            };
                                                        match &v156 {
                                                            Dice::US3::US3_0(v156_0_0) => {
                                                                Dice::US3::US3_0(
                                                                    match &v156 {
                                                                        Dice::US3::US3_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                )
                                                            }
                                                            _ => {
                                                                let v163: Dice::US3 = if (v82
                                                                    .clone())
                                                                    == (v1_1.clone())
                                                                {
                                                                    Dice::US3::US3_0(
                                                                        Dice::US2::US2_1,
                                                                    )
                                                                } else {
                                                                    Dice::US3::US3_1
                                                                };
                                                                match &v163 {
                                                                 Dice::US3::US3_0(v163_0_0)
                                                                 =>
                                                                 Dice::US3::US3_0(match &v163
                                                                                      {
                                                                                      Dice::US3::US3_0(x)
                                                                                      =>
                                                                                      x.clone(),
                                                                                      _
                                                                                      =>
                                                                                      unreachable!(),
                                                                                  }.clone()),
                                                                 _ => {
                                                                     let v170:
                                                                             Dice::US3 =
                                                                         if (v59.clone())
                                                                                ==
                                                                                (v1_1.clone())
                                                                            {
                                                                             Dice::US3::US3_0(Dice::US2::US2_2)
                                                                         } else {
                                                                             Dice::US3::US3_1
                                                                         };
                                                                     match &v170
                                                                         {
                                                                         Dice::US3::US3_0(v170_0_0)
                                                                         =>
                                                                         Dice::US3::US3_0(match &v170
                                                                                              {
                                                                                              Dice::US3::US3_0(x)
                                                                                              =>
                                                                                              x.clone(),
                                                                                              _
                                                                                              =>
                                                                                              unreachable!(),
                                                                                          }.clone()),
                                                                         _ =>
                                                                         {
                                                                             let v177:
                                                                                     Dice::US3 =
                                                                                 if (v36.clone())
                                                                                        ==
                                                                                        (v1_1.clone())
                                                                                    {
                                                                                     Dice::US3::US3_0(Dice::US2::US2_3)
                                                                                 } else {
                                                                                     Dice::US3::US3_1
                                                                                 };
                                                                             match &v177
                                                                                 {
                                                                                 Dice::US3::US3_0(v177_0_0)
                                                                                 =>
                                                                                 Dice::US3::US3_0(match &v177
                                                                                                      {
                                                                                                      Dice::US3::US3_0(x)
                                                                                                      =>
                                                                                                      x.clone(),
                                                                                                      _
                                                                                                      =>
                                                                                                      unreachable!(),
                                                                                                  }.clone()),
                                                                                 _
                                                                                 =>
                                                                                 {
                                                                                     let v184:
                                                                                             Dice::US3 =
                                                                                         if (v13.clone())
                                                                                                ==
                                                                                                (v1_1.clone())
                                                                                            {
                                                                                             Dice::US3::US3_0(Dice::US2::US2_4)
                                                                                         } else {
                                                                                             Dice::US3::US3_1
                                                                                         };
                                                                                     match &v184
                                                                                         {
                                                                                         Dice::US3::US3_0(v184_0_0)
                                                                                         =>
                                                                                         Dice::US3::US3_0(match &v184
                                                                                                              {
                                                                                                              Dice::US3::US3_0(x)
                                                                                                              =>
                                                                                                              x.clone(),
                                                                                                              _
                                                                                                              =>
                                                                                                              unreachable!(),
                                                                                                          }.clone()),
                                                                                         _
                                                                                         =>
                                                                                         Dice::US3::US3_1,
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
                if (Dice::method8(string("AUTOMATION"))) != string("True") {
                    Dice::US4::US4_1
                } else {
                    let v272: DateTime = unbox::<DateTime>(fable_library_rust::Native_::getZero());
                    let v526: Dice::US8 =
                        Dice::method12(unbox::<i64>(fable_library_rust::Native_::getZero()));
                    let v547: Dice::US4 = match &v526 {
                        Dice::US8::US8_0(v526_0_0) => Dice::US4::US4_0(v526_0_0.clone()),
                        _ => Dice::US4::US4_1,
                    };
                    Dice::US4::US4_0(match &v547 {
                        Dice::US4::US4_0(v547_0_0) => match &v547 {
                            Dice::US4::US4_0(x) => x.clone(),
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
        pub fn method6(
            v0_1: Dice::US2,
        ) -> (
            LrcPtr<Dice::Mut1>,
            LrcPtr<Dice::Mut3>,
            LrcPtr<Dice::Mut4>,
            LrcPtr<Dice::Mut5>,
            LrcPtr<Dice::Mut6>,
            Option<i64>,
        ) {
            let v396: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v397: &str = option_env!("AUTOMATION").unwrap_or("");
            let v444: std::string::String = String::from(v397);
            let _run_target_args__v5: (Dice::US3, Dice::US4) = (
                Dice::US3::US3_1,
                if (fable_library_rust::String_::fromString(v444)) != string("True") {
                    Dice::US4::US4_1
                } else {
                    Dice::US4::US4_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v747: Dice::US4 = _run_target_args__v5.1.clone();
            let v746: Dice::US3 = _run_target_args__v5.0.clone();
            (
                LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Func1::new(move |v: string| Dice::closure15((), v))),
                }),
                LrcPtr::new(Dice::Mut4 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Dice::Mut5 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Dice::Mut6 {
                    l0: MutCell::new(match &v746 {
                        Dice::US3::US3_0(v746_0_0) => match &v746 {
                            Dice::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v747 {
                    Dice::US4::US4_0(v747_0_0) => Some(match &v747 {
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
                ) = Dice::method6(Dice::US2::US2_0);
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
        pub fn closure16(unitVar: (), v0_1: i64) -> Dice::US4 {
            Dice::US4::US4_0(v0_1)
        }
        pub fn method14() -> Func1<i64, Dice::US4> {
            Func1::new(move |v: i64| Dice::closure16((), v))
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
            let v3607: u64 = near_sdk::env::block_timestamp();
            let v3717: Dice::US4 = defaultValue(Dice::US4::US4_1, map(Dice::method14(), v5));
            let v3755: u64 = (match &v3717 {
                Dice::US4::US4_0(v3717_0_0) => {
                    (v3607)
                        - (match &v3717 {
                            Dice::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v3607,
            }) / 1000000000_u64;
            let v3756: u64 = (v3755) % 60_u64;
            let v3758: u64 = ((v3755) / 60_u64) % 60_u64;
            let v3760: u64 = ((v3755) / 3600_u64) % 24_u64;
            let v3762: std::string::String = format!("{:02}:{:02}:{:02}", v3760, v3758, v3756);
            fable_library_rust::String_::fromString(v3762)
        }
        pub fn method19() -> string {
            string("")
        }
        pub fn method20(v0_1: LrcPtr<Dice::Mut5>, v1_1: string) {
            let v5: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method18(v0_1: char) -> string {
            let v12: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method20(v12.clone(), sprintf!("{}", v0_1));
            v12.l0.get().clone()
        }
        pub fn method17() -> string {
            let v348: &str = inline_colorization::color_bright_blue;
            let v395: std::string::String = String::from(v348);
            let v553: string = append(
                (fable_library_rust::String_::fromString(v395)),
                (Dice::method18(getCharAt(toLower(string("Debug")), 0_i32))),
            );
            let v913: &str = inline_colorization::color_reset;
            let v960: std::string::String = String::from(v913);
            append((v553), (fable_library_rust::String_::fromString(v960)))
        }
        pub fn method22(v0_1: i64) -> string {
            let v12: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method20(v12.clone(), sprintf!("{}", v0_1));
            v12.l0.get().clone()
        }
        pub fn method24(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("{ "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method25(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("current_index"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method26(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" = "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method27(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("; "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method28(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("acc"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method29(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("len"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method30(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("last_item"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method31(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" }"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method23(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: string) -> string {
            let v15: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v15.clone());
            Dice::method25(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v0_1));
            Dice::method27(v15.clone());
            Dice::method28(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v1_1));
            Dice::method27(v15.clone());
            Dice::method29(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v2_1));
            Dice::method27(v15.clone());
            Dice::method30(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), v3_1);
            Dice::method31(v15.clone());
            v15.l0.get().clone()
        }
        pub fn method34(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method34: loop {
                break '_method34 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Dice::US10 = if (v1_1.get().clone()) == 0_i64 {
                        Dice::US10::US10_0(' ')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Dice::US10::US10_0('\t')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Dice::US10::US10_0('\r')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Dice::US10::US10_0('\n')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Dice::US10::US10_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Dice::US10::US10_0(v19_0_0) => match &v19 {
                                Dice::US10::US10_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method34;
                    }
                });
            }
        }
        pub fn method33(v0_1: string, v1_1: i32, v2_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2_1: MutCell<i32> = MutCell::new(v2_1);
            '_method33: loop {
                break '_method33 (if (v2_1.get().clone()) >= (v1_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if Dice::method34(getCharAt(v0_1.get().clone(), v2_1.get().clone()), 0_i64) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone();
                        let v2_1_temp: i32 = (v2_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method33;
                    } else {
                        v2_1.get().clone()
                    }
                });
            }
        }
        pub fn method36(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method36: loop {
                break '_method36 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Dice::US10 = if (v1_1.get().clone()) == 0_i64 {
                        Dice::US10::US10_0(' ')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Dice::US10::US10_0('/')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Dice::US10::US10_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Dice::US10::US10_0(v11_0_0) => match &v11 {
                                Dice::US10::US10_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method36;
                    }
                });
            }
        }
        pub fn method35(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method35: loop {
                break '_method35 (if (v1_1.get().clone()) <= 0_i32 {
                    0_i32
                } else {
                    let v3_1: i32 = (v1_1.get().clone()) - 1_i32;
                    if Dice::method36(getCharAt(v0_1.get().clone(), v3_1), 0_i64) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v3_1;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method35;
                    } else {
                        v3_1
                    }
                });
            }
        }
        pub fn method32(v0_1: string) -> string {
            let v1_1: i32 = length(v0_1.clone());
            let v716: string = getSlice(
                v0_1.clone(),
                Some(Dice::method33(v0_1, v1_1, 0_i32)),
                Some(v1_1),
            );
            getSlice(
                v716.clone(),
                Some(0_i32),
                Some(Dice::method35(v716.clone(), length(v716))),
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.create_sequential_roller / roll"),
                    )),
                    string(" / "),
                )),
                (Dice::method23(v8, v9, v10, v11)),
            ))
        }
        pub fn closure17(v0_1: LrcPtr<Dice::Mut1>, unitVar: ()) {
            let v2_1: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2_1);
            ()
        }
        pub fn closure19(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure18(unitVar: (), v0_1: string) {
            let v33: () = {
                Dice::closure19(v0_1, ());
                ()
            };
            ()
        }
        pub fn method37(v0_1: i32, v1_1: LrcPtr<Dice::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn closure8(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: Option<u8>, unitVar: ()) {
            fn v77() {
                Dice::closure9((), ());
            }
            let v78: () = {
                v77();
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
            let v206: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v911: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v206,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v287: () = {
                    v77();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v373: Option<i64> = patternInput_1.5.clone();
                let v372: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v371: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v370: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v369: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v368: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v431: string = Dice::method21(
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    v373.clone(),
                    Dice::method13(v368, v369, v370, v371, v372, v373),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                    sprintf!("{:?}", v3_1),
                );
                let v505: () = {
                    v77();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v589: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v587: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v586: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v639: () = {
                    Dice::closure17(v586.clone(), ());
                    ()
                };
                let v688: string = if (v589.l0.get().clone()) == string("") {
                    v431.clone()
                } else {
                    if (v431.clone()) == string("") {
                        v589.l0.get().clone()
                    } else {
                        append(
                            (append((v589.l0.get().clone()), string("\n"))),
                            (v431.clone()),
                        )
                    }
                };
                let v735: &str = &*v688.clone();
                let v858 = v735.chars();
                let v860 = v858;
                let v862: Vec<char> = v860.collect::<Vec<_>>();
                let v864: Vec<Vec<char>> = v862
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v866: bool = true;
                let _vec_map: Vec<_> = v864
                    .into_iter()
                    .map(|x| {
                        //;
                        let v868: Vec<char> = x;
                        let v870: std::string::String = String::from_iter(v868);
                        let v872: bool = true;
                        v870
                    })
                    .collect::<Vec<_>>();
                let v874: Vec<std::string::String> = _vec_map;
                let v876: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v874.clone());
                let v877: i32 = get_Count(v876.clone());
                if if (v431.clone()) != string("") {
                    (v877) <= 1_i32
                } else {
                    false
                } {
                    v589.l0.set(v688);
                    ()
                } else {
                    v589.l0.set(string(""));
                    {
                        let v902: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v877, v902.clone()) {
                            let v904: i32 = v902.l0.get().clone();
                            let v905: std::string::String = v876[v904].clone();
                            let v907: bool = true;
                            near_sdk::log!("{}", v905);
                            let v908: i32 = (v904) + 1_i32;
                            v902.l0.set(v908);
                            ()
                        }
                        ()
                    }
                }
                (v587.l0.get().clone())(v431);
                Dice::US9::US9_0(
                    v586,
                    v587,
                    patternInput_2.2.clone(),
                    v589,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method38(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> Dice::US1 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1_1.clone());
            '_method38: loop {
                break '_method38 (match v1_1.get().clone().as_ref() {
                    Dice::UH0::UH0_1 => Dice::US1::US1_1,
                    Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice::US1::US1_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_1_temp: LrcPtr<Dice::UH0> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method38;
                        }
                    }
                });
            }
        }
        pub fn method40() -> string {
            let v11: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            v11.l0.get().clone()
        }
        pub fn method39(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.create_sequential_roller / roll / None"),
                    )),
                    string(" / "),
                )),
                (Dice::method40()),
            ))
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) {
            fn v73() {
                Dice::closure9((), ());
            }
            let v74: () = {
                v73();
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
            let v202: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v893: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v202,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v283: () = {
                    v73();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v369: Option<i64> = patternInput_1.5.clone();
                let v368: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v367: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v366: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v365: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v364: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v413: string = Dice::method39(
                    v364.clone(),
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    Dice::method13(v364, v365, v366, v367, v368, v369),
                    Dice::method17(),
                );
                let v487: () = {
                    v73();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v571: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v569: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v568: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v621: () = {
                    Dice::closure17(v568.clone(), ());
                    ()
                };
                let v670: string = if (v571.l0.get().clone()) == string("") {
                    v413.clone()
                } else {
                    if (v413.clone()) == string("") {
                        v571.l0.get().clone()
                    } else {
                        append(
                            (append((v571.l0.get().clone()), string("\n"))),
                            (v413.clone()),
                        )
                    }
                };
                let v717: &str = &*v670.clone();
                let v840 = v717.chars();
                let v842 = v840;
                let v844: Vec<char> = v842.collect::<Vec<_>>();
                let v846: Vec<Vec<char>> = v844
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v848: bool = true;
                let _vec_map: Vec<_> = v846
                    .into_iter()
                    .map(|x| {
                        //;
                        let v850: Vec<char> = x;
                        let v852: std::string::String = String::from_iter(v850);
                        let v854: bool = true;
                        v852
                    })
                    .collect::<Vec<_>>();
                let v856: Vec<std::string::String> = _vec_map;
                let v858: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v856.clone());
                let v859: i32 = get_Count(v858.clone());
                if if (v413.clone()) != string("") {
                    (v859) <= 1_i32
                } else {
                    false
                } {
                    v571.l0.set(v670);
                    ()
                } else {
                    v571.l0.set(string(""));
                    {
                        let v884: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v859, v884.clone()) {
                            let v886: i32 = v884.l0.get().clone();
                            let v887: std::string::String = v858[v886].clone();
                            let v889: bool = true;
                            near_sdk::log!("{}", v887);
                            let v890: i32 = (v886) + 1_i32;
                            v884.l0.set(v890);
                            ()
                        }
                        ()
                    }
                }
                (v569.l0.get().clone())(v413);
                Dice::US9::US9_0(
                    v568,
                    v569,
                    patternInput_2.2.clone(),
                    v571,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
                    let v1935: () = {
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
                    let v2911: LrcPtr<Dice::UH0> = v0_1();
                    let v2913: Dice::US1 = Dice::method38(v1_1.l0.get().clone(), v2911);
                    match &v2913 {
                        Dice::US1::US1_0(v2913_0_0) => {
                            let v2914: u8 = match &v2913 {
                                Dice::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v2916: i64 = (v1_1.l0.get().clone()) + 1_i64;
                            v1_1.l0.set(v2916);
                            v4_1.l0.set(Dice::US1::US1_0(v2914));
                            v2914
                        }
                        _ => {
                            let v4773: () = {
                                Dice::closure20((), ());
                                ()
                            };
                            if (v3_1.l0.get().clone()) == -1_i64 {
                                let v5737: i64 = v1_1.l0.get().clone();
                                v3_1.l0.set(v5737);
                                ()
                            }
                            {
                                let v5743: i64 =
                                    if (v2_1.l0.get().clone()) >= (v3_1.l0.get().clone()) {
                                        1_i64
                                    } else {
                                        (v2_1.l0.get().clone()) + 1_i64
                                    };
                                v2_1.l0.set(v5743);
                                {
                                    let v5745: i64 = (v2_1.l0.get().clone()) - 1_i64;
                                    v1_1.l0.set(v5745);
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
        pub fn method44(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("max"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method45(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("p"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method46(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("n"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method43(v0_1: u64, v1_1: u64, v2_1: i8) -> string {
            let v14: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v14.clone());
            Dice::method44(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v0_1));
            Dice::method27(v14.clone());
            Dice::method45(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v1_1));
            Dice::method27(v14.clone());
            Dice::method46(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v2_1));
            Dice::method31(v14.clone());
            v14.l0.get().clone()
        }
        pub fn method42(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.calculate_dice_count"),
                    )),
                    string(" / "),
                )),
                (Dice::method43(v8, v9, v10)),
            ))
        }
        pub fn closure24(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method42(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v2_1,
                    v1_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method41(v0_1: u64, v1_1: i8, v2_1: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method41: loop {
                break '_method41 (if (v2_1.get().clone()) < (v0_1.get().clone()) {
                    let v4_1: u64 = (v2_1.get().clone()) * 6_u64;
                    if (v4_1) > (v2_1.get().clone()) {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_1_temp: i8 = (v1_1.get().clone()) + 1_i8;
                        let v2_1_temp: u64 = v4_1;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method41;
                    } else {
                        let v1863: () = {
                            Dice::closure24(
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
                    let v4681: () = {
                        Dice::closure24(
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
        pub fn method51(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("power"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method52(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("result"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method50(v0_1: i8, v1_1: u64, v2_1: u64) -> string {
            let v14: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v14.clone());
            Dice::method51(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v0_1));
            Dice::method27(v14.clone());
            Dice::method28(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v1_1));
            Dice::method27(v14.clone());
            Dice::method52(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v2_1));
            Dice::method31(v14.clone());
            v14.l0.get().clone()
        }
        pub fn method49(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method50(v8, v9, v10)),
            ))
        }
        pub fn closure25(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method49(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v1_1,
                    v0_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure89(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_1)
        }
        pub fn closure88(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice::closure89((), ())),
            ))
        }
        pub fn closure87(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice::closure88((), ())),
            ))
        }
        pub fn closure86(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice::closure87((), ())),
            ))
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice::closure86((), ())),
            ))
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice::closure85((), ())),
            ))
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice::closure84((), ())),
            ))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice::closure83((), ())),
            ))
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice::closure82((), ())),
            ))
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice::closure81((), ())),
            ))
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice::closure27((), ())),
            ))
        }
        pub fn method53(v0_1: i8, v1_1: LrcPtr<Dice::UH2>) -> Dice::US12 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH2>> = MutCell::new(v1_1.clone());
            '_method53: loop {
                break '_method53 (match v1_1.get().clone().as_ref() {
                    Dice::UH2::UH2_1 => Dice::US12::US12_1,
                    Dice::UH2::UH2_0(v1_1_0_0, v1_1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice::US12::US12_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_1_temp: LrcPtr<Dice::UH2> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method53;
                        }
                    }
                });
            }
        }
        pub fn method56(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("roll"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method57(v0_1: LrcPtr<Dice::Mut5>) {
            let v7: string = append((v0_1.l0.get().clone()), string("value"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method55(v0_1: i8, v1_1: u64, v2_1: u8, v3_1: u64) -> string {
            let v15: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v15.clone());
            Dice::method51(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v0_1));
            Dice::method27(v15.clone());
            Dice::method28(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v1_1));
            Dice::method27(v15.clone());
            Dice::method56(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v2_1));
            Dice::method27(v15.clone());
            Dice::method57(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v3_1));
            Dice::method31(v15.clone());
            v15.l0.get().clone()
        }
        pub fn method54(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method55(v8, v9, v10, v11)),
            ))
        }
        pub fn closure90(v0_1: u64, v1_1: i8, v2_1: u8, v3_1: u64, unitVar: ()) {
            fn v77() {
                Dice::closure9((), ());
            }
            let v78: () = {
                v77();
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
            let v206: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v897: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v206,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v287: () = {
                    v77();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v373: Option<i64> = patternInput_1.5.clone();
                let v372: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v371: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v370: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v369: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v368: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v417: string = Dice::method54(
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    v373.clone(),
                    Dice::method13(v368, v369, v370, v371, v372, v373),
                    Dice::method17(),
                    v1_1,
                    v0_1,
                    v2_1,
                    v3_1,
                );
                let v491: () = {
                    v77();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v575: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v573: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v572: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v625: () = {
                    Dice::closure17(v572.clone(), ());
                    ()
                };
                let v674: string = if (v575.l0.get().clone()) == string("") {
                    v417.clone()
                } else {
                    if (v417.clone()) == string("") {
                        v575.l0.get().clone()
                    } else {
                        append(
                            (append((v575.l0.get().clone()), string("\n"))),
                            (v417.clone()),
                        )
                    }
                };
                let v721: &str = &*v674.clone();
                let v844 = v721.chars();
                let v846 = v844;
                let v848: Vec<char> = v846.collect::<Vec<_>>();
                let v850: Vec<Vec<char>> = v848
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v852: bool = true;
                let _vec_map: Vec<_> = v850
                    .into_iter()
                    .map(|x| {
                        //;
                        let v854: Vec<char> = x;
                        let v856: std::string::String = String::from_iter(v854);
                        let v858: bool = true;
                        v856
                    })
                    .collect::<Vec<_>>();
                let v860: Vec<std::string::String> = _vec_map;
                let v862: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v860.clone());
                let v863: i32 = get_Count(v862.clone());
                if if (v417.clone()) != string("") {
                    (v863) <= 1_i32
                } else {
                    false
                } {
                    v575.l0.set(v674);
                    ()
                } else {
                    v575.l0.set(string(""));
                    {
                        let v888: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v863, v888.clone()) {
                            let v890: i32 = v888.l0.get().clone();
                            let v891: std::string::String = v862[v890].clone();
                            let v893: bool = true;
                            near_sdk::log!("{}", v891);
                            let v894: i32 = (v890) + 1_i32;
                            v888.l0.set(v894);
                            ()
                        }
                        ()
                    }
                }
                (v573.l0.get().clone())(v417);
                Dice::US9::US9_0(
                    v572,
                    v573,
                    patternInput_2.2.clone(),
                    v575,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method59(v0_1: i8, v1_1: u64, v2_1: u8) -> string {
            let v14: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v14.clone());
            Dice::method51(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v0_1));
            Dice::method27(v14.clone());
            Dice::method28(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v1_1));
            Dice::method27(v14.clone());
            Dice::method56(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v2_1));
            Dice::method31(v14.clone());
            v14.l0.get().clone()
        }
        pub fn method58(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method59(v8, v9, v10)),
            ))
        }
        pub fn closure91(v0_1: u64, v1_1: i8, v2_1: u8, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method58(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v1_1,
                    v0_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method48(v0_1: i8, v1_1: LrcPtr<Dice::UH1>, v2_1: u64) -> Dice::US11 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method48: loop {
                break '_method48 (if (v0_1.get().clone()) < 0_i8 {
                    let v4_1: u64 = (v2_1.get().clone()) + 1_u64;
                    let v1860: () = {
                        Dice::closure25(v2_1.get().clone(), v0_1.get().clone(), v4_1, ());
                        ()
                    };
                    Dice::US11::US11_0(v4_1, v1_1.get().clone())
                } else {
                    match v1_1.get().clone().as_ref() {
                        Dice::UH1::UH1_0 => Dice::US11::US11_1,
                        Dice::UH1::UH1_1(v1_1_1_0, v1_1_1_1) => {
                            let v2825: LrcPtr<Dice::UH1> = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v2824: u8 = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v2824) > 1_u8 {
                                let v2830: Dice::US12 = Dice::method53(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice::closure26((), ())),
                                    )),
                                );
                                let v2837: u64 = (((v2824) - 1_u8) as u64)
                                    * (match &v2830 {
                                        Dice::US12::US12_0(v2830_0_0) => match &v2830 {
                                            Dice::US12::US12_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v4693: () = {
                                    Dice::closure90(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v2824,
                                        v2837,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v2825;
                                    let v2_1_temp: u64 = (v2_1.get().clone()) + (v2837);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method48;
                                }
                            } else {
                                let v7513: () = {
                                    Dice::closure91(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v2824,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v2825.clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method48;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method60(v0_1: i8, v1_1: Func0<u8>, v2_1: i8) -> LrcPtr<Dice::UH1> {
            if (v2_1) < (v0_1) {
                LrcPtr::new(Dice::UH1::UH1_1(
                    v1_1(),
                    Dice::method60(v0_1, v1_1, (v2_1) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice::UH1::UH1_0)
            }
        }
        pub fn method61(
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
            '_method61: loop {
                break '_method61 ({
                    let v5: i8 = (v3_1.get().clone()) + 1_i8;
                    if (v3_1.get().clone()) < (v5) {
                        Dice::method47(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone())),
                            v5,
                        )
                    } else {
                        let v11: Dice::US11 =
                            Dice::method48(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                        if let Dice::US11::US11_0(v11_0_0, v11_0_1) = &v11 {
                            let v12: u64 = v11_0_0.clone();
                            if (v12) <= (v2_1.get().clone()) {
                                v12
                            } else {
                                if v1_1.get().clone() {
                                    let v0_1_temp = v0_1.get().clone();
                                    let v1_1_temp: bool = v1_1.get().clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    let v3_1_temp: i8 = v3_1.get().clone();
                                    let v4_1_temp: LrcPtr<Dice::UH1> = Dice::method60(
                                        v3_1.get().clone(),
                                        v0_1.get().clone(),
                                        0_i8,
                                    );
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method61;
                                } else {
                                    Dice::method47(
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
                                    Dice::method60(v3_1.get().clone(), v0_1.get().clone(), 0_i8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                continue '_method61;
                            } else {
                                Dice::method47(
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
        pub fn method47(
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
            '_method47: loop {
                break '_method47 (if (v5.get().clone()) < ((v3_1.get().clone()) + 1_i8) {
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
                    continue '_method47;
                } else {
                    let v13: Dice::US11 =
                        Dice::method48(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                    if let Dice::US11::US11_0(v13_0_0, v13_0_1) = &v13 {
                        let v14: u64 = v13_0_0.clone();
                        if (v14) <= (v2_1.get().clone()) {
                            v14
                        } else {
                            if v1_1.get().clone() {
                                Dice::method61(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    Dice::method60(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
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
                                continue '_method47;
                            }
                        }
                    } else {
                        if v1_1.get().clone() {
                            Dice::method61(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                Dice::method60(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
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
                            continue '_method47;
                        }
                    }
                });
            }
        }
        pub fn closure23(v0_1: Func0<u8>, v1_1: bool, v2_1: u64) -> u64 {
            Dice::method47(
                v0_1,
                v1_1,
                v2_1,
                (if (v2_1) == 1_u64 {
                    1_i8
                } else {
                    Dice::method41(v2_1, 0_i8, 1_u64)
                }) - 1_i8,
                LrcPtr::new(Dice::UH1::UH1_0),
                0_i8,
            )
        }
        pub fn closure22(v0_1: Func0<u8>, v1_1: bool) -> Func1<u64, u64> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: u64| Dice::closure23(v0_1.clone(), v1_1, v)
            })
        }
        pub fn closure21(unitVar: (), v0_1: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice::closure22(v0_1.clone(), v)
            })
        }
        pub fn method62(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method62: loop {
                break '_method62 (match v0_1.get().clone().as_ref() {
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
                        continue '_method62;
                    }
                });
            }
        }
        pub fn closure93(v0_1: u64, v1_1: LrcPtr<Dice::UH1>) -> Option<u64> {
            let v6: Dice::US11 =
                Dice::method48((Dice::method62(v1_1.clone(), 0_i8)) - 1_i8, v1_1, 0_u64);
            let v16: Dice::US12 = if let Dice::US11::US11_0(v6_0_0, v6_0_1) = &v6 {
                let v7: u64 = v6_0_0.clone();
                if if (v7) >= 1_u64 { (v7) <= (v0_1) } else { false } {
                    Dice::US12::US12_0(v7)
                } else {
                    Dice::US12::US12_1
                }
            } else {
                Dice::US12::US12_1
            };
            match &v16 {
                Dice::US12::US12_0(v16_0_0) => Some(match &v16 {
                    Dice::US12::US12_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<u64>,
            }
        }
        pub fn closure92(unitVar: (), v0_1: u64) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice::UH1>| Dice::closure93(v0_1, v)
            })
        }
        pub fn method64(v0_1: i64, v1_1: i64, v2_1: i8) -> string {
            let v14: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v14.clone());
            Dice::method44(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v0_1));
            Dice::method27(v14.clone());
            Dice::method45(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v1_1));
            Dice::method27(v14.clone());
            Dice::method46(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v2_1));
            Dice::method31(v14.clone());
            v14.l0.get().clone()
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
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.calculate_dice_count"),
                    )),
                    string(" / "),
                )),
                (Dice::method64(i64::MAX, 4738381338321616896_i64, 24_i8)),
            ))
        }
        pub fn closure95(unitVar: (), unitVar_1: ()) {
            fn v73() {
                Dice::closure9((), ());
            }
            let v74: () = {
                v73();
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
            let v202: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v893: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v202,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v283: () = {
                    v73();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v369: Option<i64> = patternInput_1.5.clone();
                let v368: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v367: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v366: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v365: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v364: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v413: string = Dice::method63(
                    v364.clone(),
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    Dice::method13(v364, v365, v366, v367, v368, v369),
                    Dice::method17(),
                );
                let v487: () = {
                    v73();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v571: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v569: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v568: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v621: () = {
                    Dice::closure17(v568.clone(), ());
                    ()
                };
                let v670: string = if (v571.l0.get().clone()) == string("") {
                    v413.clone()
                } else {
                    if (v413.clone()) == string("") {
                        v571.l0.get().clone()
                    } else {
                        append(
                            (append((v571.l0.get().clone()), string("\n"))),
                            (v413.clone()),
                        )
                    }
                };
                let v717: &str = &*v670.clone();
                let v840 = v717.chars();
                let v842 = v840;
                let v844: Vec<char> = v842.collect::<Vec<_>>();
                let v846: Vec<Vec<char>> = v844
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v848: bool = true;
                let _vec_map: Vec<_> = v846
                    .into_iter()
                    .map(|x| {
                        //;
                        let v850: Vec<char> = x;
                        let v852: std::string::String = String::from_iter(v850);
                        let v854: bool = true;
                        v852
                    })
                    .collect::<Vec<_>>();
                let v856: Vec<std::string::String> = _vec_map;
                let v858: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v856.clone());
                let v859: i32 = get_Count(v858.clone());
                if if (v413.clone()) != string("") {
                    (v859) <= 1_i32
                } else {
                    false
                } {
                    v571.l0.set(v670);
                    ()
                } else {
                    v571.l0.set(string(""));
                    {
                        let v884: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v859, v884.clone()) {
                            let v886: i32 = v884.l0.get().clone();
                            let v887: std::string::String = v858[v886].clone();
                            let v889: bool = true;
                            near_sdk::log!("{}", v887);
                            let v890: i32 = (v886) + 1_i32;
                            v884.l0.set(v890);
                            ()
                        }
                        ()
                    }
                }
                (v569.l0.get().clone())(v413);
                Dice::US9::US9_0(
                    v568,
                    v569,
                    patternInput_2.2.clone(),
                    v571,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure96(unitVar: (), unitVar_1: ()) -> i32 {
            1_u8 as i32
        }
        pub fn closure97(unitVar: (), v0_1: i32) -> Dice::US13 {
            Dice::US13::US13_0(v0_1)
        }
        pub fn closure98(unitVar: (), v0_1: LrcPtr<Exception>) -> Dice::US13 {
            Dice::US13::US13_1(v0_1)
        }
        pub fn method67() -> Dice::US13 {
            try_catch(
                || Dice::closure97((), Dice::closure96((), ())),
                |ex: LrcPtr<Exception>| {
                    Dice::closure98(
                        (),
                        Dice::closure13(
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
        pub fn closure99(unitVar: (), unitVar_1: ()) -> i32 {
            7_u8 as i32
        }
        pub fn method68() -> Dice::US13 {
            try_catch(
                || Dice::closure97((), Dice::closure99((), ())),
                |ex: LrcPtr<Exception>| {
                    Dice::closure98(
                        (),
                        Dice::closure13(
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
        pub fn closure100(v0_1: i32, unitVar: ()) -> u8 {
            v0_1 as u8
        }
        pub fn closure101(unitVar: (), v0_1: u8) -> Dice::US15 {
            Dice::US15::US15_0(v0_1)
        }
        pub fn closure102(unitVar: (), v0_1: LrcPtr<Exception>) -> Dice::US15 {
            Dice::US15::US15_1(v0_1)
        }
        pub fn method69(v0_1: i32) -> Dice::US15 {
            try_catch(
                || Dice::closure101((), Dice::closure100(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Dice::closure102(
                        (),
                        Dice::closure13(
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
        pub fn method66() -> u8 {
            panic!("{}", string("common.random\' / target=Rust(Contract)"),)
        }
        pub fn method72(v0_1: i8, v1_1: i64, v2_1: u8, v3_1: i64) -> string {
            let v15: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v15.clone());
            Dice::method51(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v0_1));
            Dice::method27(v15.clone());
            Dice::method28(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v1_1));
            Dice::method27(v15.clone());
            Dice::method56(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v2_1));
            Dice::method27(v15.clone());
            Dice::method57(v15.clone());
            Dice::method26(v15.clone());
            Dice::method20(v15.clone(), sprintf!("{}", v3_1));
            Dice::method31(v15.clone());
            v15.l0.get().clone()
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(23_i8, v8, v9, v10)),
            ))
        }
        pub fn closure103(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method71(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method74(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(22_i8, v8, v9, v10)),
            ))
        }
        pub fn closure104(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method74(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method76(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(21_i8, v8, v9, v10)),
            ))
        }
        pub fn closure105(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method76(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method78(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(20_i8, v8, v9, v10)),
            ))
        }
        pub fn closure106(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method78(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method80(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(19_i8, v8, v9, v10)),
            ))
        }
        pub fn closure107(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method80(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method82(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(18_i8, v8, v9, v10)),
            ))
        }
        pub fn closure108(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method82(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method84(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(17_i8, v8, v9, v10)),
            ))
        }
        pub fn closure109(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method84(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method86(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(16_i8, v8, v9, v10)),
            ))
        }
        pub fn closure110(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method86(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method88(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(15_i8, v8, v9, v10)),
            ))
        }
        pub fn closure111(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method88(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method90(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(14_i8, v8, v9, v10)),
            ))
        }
        pub fn closure112(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method90(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method92(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(13_i8, v8, v9, v10)),
            ))
        }
        pub fn closure113(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method92(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method94(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(12_i8, v8, v9, v10)),
            ))
        }
        pub fn closure114(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method94(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method96(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(11_i8, v8, v9, v10)),
            ))
        }
        pub fn closure115(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method96(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method98(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(10_i8, v8, v9, v10)),
            ))
        }
        pub fn closure116(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method98(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method100(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(9_i8, v8, v9, v10)),
            ))
        }
        pub fn closure117(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method100(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(8_i8, v8, v9, v10)),
            ))
        }
        pub fn closure118(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method102(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(7_i8, v8, v9, v10)),
            ))
        }
        pub fn closure119(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method104(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(6_i8, v8, v9, v10)),
            ))
        }
        pub fn closure120(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method106(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(5_i8, v8, v9, v10)),
            ))
        }
        pub fn closure121(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method108(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(4_i8, v8, v9, v10)),
            ))
        }
        pub fn closure122(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method110(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(3_i8, v8, v9, v10)),
            ))
        }
        pub fn closure123(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method112(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(2_i8, v8, v9, v10)),
            ))
        }
        pub fn closure124(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method114(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(1_i8, v8, v9, v10)),
            ))
        }
        pub fn closure125(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method116(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v10: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method72(0_i8, v8, v9, v10)),
            ))
        }
        pub fn closure126(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v76() {
                Dice::closure9((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v896: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v286: () = {
                    v76();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v370: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v369: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v368: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v367: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v416: string = Dice::method118(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Dice::method13(v367, v368, v369, v370, v371, v372),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v490: () = {
                    v76();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v574: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v572: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v571: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v624: () = {
                    Dice::closure17(v571.clone(), ());
                    ()
                };
                let v673: string = if (v574.l0.get().clone()) == string("") {
                    v416.clone()
                } else {
                    if (v416.clone()) == string("") {
                        v574.l0.get().clone()
                    } else {
                        append(
                            (append((v574.l0.get().clone()), string("\n"))),
                            (v416.clone()),
                        )
                    }
                };
                let v720: &str = &*v673.clone();
                let v843 = v720.chars();
                let v845 = v843;
                let v847: Vec<char> = v845.collect::<Vec<_>>();
                let v849: Vec<Vec<char>> = v847
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v851: bool = true;
                let _vec_map: Vec<_> = v849
                    .into_iter()
                    .map(|x| {
                        //;
                        let v853: Vec<char> = x;
                        let v855: std::string::String = String::from_iter(v853);
                        let v857: bool = true;
                        v855
                    })
                    .collect::<Vec<_>>();
                let v859: Vec<std::string::String> = _vec_map;
                let v861: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v859.clone());
                let v862: i32 = get_Count(v861.clone());
                if if (v416.clone()) != string("") {
                    (v862) <= 1_i32
                } else {
                    false
                } {
                    v574.l0.set(v673);
                    ()
                } else {
                    v574.l0.set(string(""));
                    {
                        let v887: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v862, v887.clone()) {
                            let v889: i32 = v887.l0.get().clone();
                            let v890: std::string::String = v861[v889].clone();
                            let v892: bool = true;
                            near_sdk::log!("{}", v890);
                            let v893: i32 = (v889) + 1_i32;
                            v887.l0.set(v893);
                            ()
                        }
                        ()
                    }
                }
                (v572.l0.get().clone())(v416);
                Dice::US9::US9_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    v574,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method121(v0_1: i8, v1_1: i64, v2_1: i64) -> string {
            let v14: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v14.clone());
            Dice::method51(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v0_1));
            Dice::method27(v14.clone());
            Dice::method28(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v1_1));
            Dice::method27(v14.clone());
            Dice::method52(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v2_1));
            Dice::method31(v14.clone());
            v14.l0.get().clone()
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
            v9: i64,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method121(-1_i8, v8, v9)),
            ))
        }
        pub fn closure127(v0_1: i64, v1_1: i64, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method120(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method119(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            let v2_1: i64 = (v1_1) + 1_i64;
            let v1858: () = {
                Dice::closure127(v1_1, v2_1, ());
                ()
            };
            Dice::US16::US16_0(v2_1, v0_1)
        }
        pub fn method123(v0_1: i8, v1_1: i64, v2_1: u8) -> string {
            let v14: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v14.clone());
            Dice::method51(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v0_1));
            Dice::method27(v14.clone());
            Dice::method28(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v1_1));
            Dice::method27(v14.clone());
            Dice::method56(v14.clone());
            Dice::method26(v14.clone());
            Dice::method20(v14.clone(), sprintf!("{}", v2_1));
            Dice::method31(v14.clone());
            v14.l0.get().clone()
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(0_i8, v8, v9)),
            ))
        }
        pub fn closure128(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method122(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method117(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1863: () = {
                            Dice::closure126(v1_1, v3_1, v7, ());
                            ()
                        };
                        Dice::method119(v4_1.clone(), (v1_1) + (v7))
                    } else {
                        let v4682: () = {
                            Dice::closure128(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method119(v4_1, v1_1)
                    }
                }
            }
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
            v9: u8,
        ) -> string {
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(1_i8, v8, v9)),
            ))
        }
        pub fn closure129(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method124(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method115(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure125(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method117(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure129(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method117(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method125(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(2_i8, v8, v9)),
            ))
        }
        pub fn closure130(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method125(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method113(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure124(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method115(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure130(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method115(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method126(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(3_i8, v8, v9)),
            ))
        }
        pub fn closure131(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method126(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method111(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure123(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method113(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure131(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method113(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method127(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(4_i8, v8, v9)),
            ))
        }
        pub fn closure132(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method127(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method109(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure122(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method111(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure132(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method111(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method128(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(5_i8, v8, v9)),
            ))
        }
        pub fn closure133(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method128(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method107(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure121(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method109(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure133(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method109(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method129(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(6_i8, v8, v9)),
            ))
        }
        pub fn closure134(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method129(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method105(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure120(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method107(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure134(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method107(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method130(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(7_i8, v8, v9)),
            ))
        }
        pub fn closure135(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method130(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method103(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure119(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method105(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure135(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method105(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method131(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(8_i8, v8, v9)),
            ))
        }
        pub fn closure136(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method131(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method101(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure118(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method103(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure136(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method103(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method132(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(9_i8, v8, v9)),
            ))
        }
        pub fn closure137(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method132(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method99(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure117(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method101(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure137(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method101(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method133(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(10_i8, v8, v9)),
            ))
        }
        pub fn closure138(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method133(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method97(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure116(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method99(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure138(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method99(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method134(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(11_i8, v8, v9)),
            ))
        }
        pub fn closure139(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method134(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method95(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure115(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method97(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure139(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method97(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method135(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(12_i8, v8, v9)),
            ))
        }
        pub fn closure140(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method135(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method93(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure114(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method95(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure140(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method95(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method136(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(13_i8, v8, v9)),
            ))
        }
        pub fn closure141(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method136(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method91(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure113(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method93(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure141(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method93(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method137(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(14_i8, v8, v9)),
            ))
        }
        pub fn closure142(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method137(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method89(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure112(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method91(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure142(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method91(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method138(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(15_i8, v8, v9)),
            ))
        }
        pub fn closure143(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method138(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method87(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure111(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method89(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure143(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method89(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method139(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(16_i8, v8, v9)),
            ))
        }
        pub fn closure144(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method139(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method85(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure110(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method87(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure144(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method87(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method140(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(17_i8, v8, v9)),
            ))
        }
        pub fn closure145(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method140(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method83(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure109(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method85(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure145(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method85(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method141(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(18_i8, v8, v9)),
            ))
        }
        pub fn closure146(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method141(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method81(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure108(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method83(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure146(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method83(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method142(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(19_i8, v8, v9)),
            ))
        }
        pub fn closure147(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method142(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method79(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure107(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method81(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure147(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method81(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method143(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(20_i8, v8, v9)),
            ))
        }
        pub fn closure148(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method143(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method77(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure106(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method79(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure148(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method79(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method144(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(21_i8, v8, v9)),
            ))
        }
        pub fn closure149(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method144(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method75(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure105(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method77(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure149(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method77(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method145(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(22_i8, v8, v9)),
            ))
        }
        pub fn closure150(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method145(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method73(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure104(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method75(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure150(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method75(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method146(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.accumulate_dice_rolls"),
                    )),
                    string(" / "),
                )),
                (Dice::method123(23_i8, v8, v9)),
            ))
        }
        pub fn closure151(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v75() {
                Dice::closure9((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v895: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v204,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v285: () = {
                    v75();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v369: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v368: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v367: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v366: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v415: string = Dice::method146(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Dice::method13(v366, v367, v368, v369, v370, v371),
                    Dice::method17(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v573: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v571: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v570: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v623: () = {
                    Dice::closure17(v570.clone(), ());
                    ()
                };
                let v672: string = if (v573.l0.get().clone()) == string("") {
                    v415.clone()
                } else {
                    if (v415.clone()) == string("") {
                        v573.l0.get().clone()
                    } else {
                        append(
                            (append((v573.l0.get().clone()), string("\n"))),
                            (v415.clone()),
                        )
                    }
                };
                let v719: &str = &*v672.clone();
                let v842 = v719.chars();
                let v844 = v842;
                let v846: Vec<char> = v844.collect::<Vec<_>>();
                let v848: Vec<Vec<char>> = v846
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: Vec<char> = x;
                        let v854: std::string::String = String::from_iter(v852);
                        let v856: bool = true;
                        v854
                    })
                    .collect::<Vec<_>>();
                let v858: Vec<std::string::String> = _vec_map;
                let v860: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v858.clone());
                let v861: i32 = get_Count(v860.clone());
                if if (v415.clone()) != string("") {
                    (v861) <= 1_i32
                } else {
                    false
                } {
                    v573.l0.set(v672);
                    ()
                } else {
                    v573.l0.set(string(""));
                    {
                        let v886: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v861, v886.clone()) {
                            let v888: i32 = v886.l0.get().clone();
                            let v889: std::string::String = v860[v888].clone();
                            let v891: bool = true;
                            near_sdk::log!("{}", v889);
                            let v892: i32 = (v888) + 1_i32;
                            v886.l0.set(v892);
                            ()
                        }
                        ()
                    }
                }
                (v571.l0.get().clone())(v415);
                Dice::US9::US9_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    v573,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method70(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US16 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US16::US16_1,
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
                        let v1864: () = {
                            Dice::closure103(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method73(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v4683: () = {
                            Dice::closure151(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method73(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method65(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i64 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method65: loop {
                break '_method65 (if (v1_1.get().clone()) < 24_i8 {
                    let v0_1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(), v0_1.get().clone()));
                    let v1_1_temp: i8 = (v1_1.get().clone()) + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method65;
                } else {
                    let v8: Dice::US16 = Dice::method70(v0_1.get().clone(), 0_i64);
                    if let Dice::US16::US16_0(v8_0_0, v8_0_1) = &v8 {
                        let v9: i64 = v8_0_0.clone();
                        if (v9) <= i64::MAX {
                            v9
                        } else {
                            let v0_1_temp: LrcPtr<Dice::UH1> =
                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                            let v1_1_temp: i8 = 23_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method65;
                        }
                    } else {
                        let v0_1_temp: LrcPtr<Dice::UH1> =
                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method66(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                        let v1_1_temp: i8 = 23_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method65;
                    }
                });
            }
        }
        pub fn method148(v0_1: i64) -> string {
            let v12: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method19()),
            });
            Dice::method24(v12.clone());
            Dice::method52(v12.clone());
            Dice::method26(v12.clone());
            Dice::method20(v12.clone(), sprintf!("{}", v0_1));
            Dice::method31(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method147(
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
            Dice::method32(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    (append((v6), string(" "))),
                                    (Dice::method22(v0_1.l0.get().clone())),
                                )),
                                (v7),
                            )),
                            string(" "),
                        )),
                        string("dice.main"),
                    )),
                    string(" / "),
                )),
                (Dice::method148(v8)),
            ))
        }
        pub fn closure152(v0_1: i64, unitVar: ()) {
            fn v74() {
                Dice::closure9((), ());
            }
            let v75: () = {
                v74();
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
            let v203: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v894: Dice::US9 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v203,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US2::US2_0, 0_i32)),
                            LrcPtr::new((Dice::US2::US2_1, 1_i32)),
                            LrcPtr::new((Dice::US2::US2_2, 2_i32)),
                            LrcPtr::new((Dice::US2::US2_3, 3_i32)),
                            LrcPtr::new((Dice::US2::US2_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Dice::US9::US9_1
            } else {
                let v284: () = {
                    v74();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v370: Option<i64> = patternInput_1.5.clone();
                let v369: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v368: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v367: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v366: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v365: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v414: string = Dice::method147(
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    Dice::method13(v365, v366, v367, v368, v369, v370),
                    Dice::method17(),
                    v0_1,
                );
                let v488: () = {
                    v74();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Dice::Mut1>,
                    LrcPtr<Dice::Mut3>,
                    LrcPtr<Dice::Mut4>,
                    LrcPtr<Dice::Mut5>,
                    LrcPtr<Dice::Mut6>,
                    Option<i64>,
                ) = Dice::TraceState::trace_state().get().clone().unwrap();
                let v572: LrcPtr<Dice::Mut5> = patternInput_2.3.clone();
                let v570: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v569: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v622: () = {
                    Dice::closure17(v569.clone(), ());
                    ()
                };
                let v671: string = if (v572.l0.get().clone()) == string("") {
                    v414.clone()
                } else {
                    if (v414.clone()) == string("") {
                        v572.l0.get().clone()
                    } else {
                        append(
                            (append((v572.l0.get().clone()), string("\n"))),
                            (v414.clone()),
                        )
                    }
                };
                let v718: &str = &*v671.clone();
                let v841 = v718.chars();
                let v843 = v841;
                let v845: Vec<char> = v843.collect::<Vec<_>>();
                let v847: Vec<Vec<char>> = v845
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v849: bool = true;
                let _vec_map: Vec<_> = v847
                    .into_iter()
                    .map(|x| {
                        //;
                        let v851: Vec<char> = x;
                        let v853: std::string::String = String::from_iter(v851);
                        let v855: bool = true;
                        v853
                    })
                    .collect::<Vec<_>>();
                let v857: Vec<std::string::String> = _vec_map;
                let v859: Array<std::string::String> =
                    fable_library_rust::NativeArray_::array_from(v857.clone());
                let v860: i32 = get_Count(v859.clone());
                if if (v414.clone()) != string("") {
                    (v860) <= 1_i32
                } else {
                    false
                } {
                    v572.l0.set(v671);
                    ()
                } else {
                    v572.l0.set(string(""));
                    {
                        let v885: LrcPtr<Dice::Mut7> = LrcPtr::new(Dice::Mut7 {
                            l0: MutCell::new(0_i32),
                        });
                        while Dice::method37(v860, v885.clone()) {
                            let v887: i32 = v885.l0.get().clone();
                            let v888: std::string::String = v859[v887].clone();
                            let v890: bool = true;
                            near_sdk::log!("{}", v888);
                            let v891: i32 = (v887) + 1_i32;
                            v885.l0.set(v891);
                            ()
                        }
                        ()
                    }
                }
                (v570.l0.get().clone())(v414);
                Dice::US9::US9_0(
                    v569,
                    v570,
                    patternInput_2.2.clone(),
                    v572,
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure94(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1856: () = {
                Dice::closure95((), ());
                ()
            };
            let v4676: () = {
                Dice::closure152(Dice::method65(LrcPtr::new(Dice::UH1::UH1_0), 0_i8), ());
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
            v2.get_or_init(|| Func1::new(move |v: Func0<u8>| Dice::closure21((), v)))
                .clone()
        }
        pub fn roll_progressively(x: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            (Dice::v2())(x)
        }
        pub fn v3() -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>> {
            static v3: OnceInit<Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>>> =
                OnceInit::new();
            v3.get_or_init(|| Func1::new(move |v: u64| Dice::closure92((), v)))
                .clone()
        }
        pub fn roll_within_bounds(x: u64) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            (Dice::v3())(x)
        }
        pub fn v4() -> Func1<Array<string>, i32> {
            static v4: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v4.get_or_init(|| Func1::new(move |v: Array<string>| Dice::closure94((), v)))
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
