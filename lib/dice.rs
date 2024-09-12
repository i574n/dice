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
mod module_a51efde0 {
    pub mod Dice {
        use super::*;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
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
        pub fn closure6(
            v0_1: LrcPtr<MutCell<Option<Dice::US1>>>,
            v1_1: Option<Dice::US1>,
        ) -> LrcPtr<MutCell<Option<Dice::US1>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure7(
            v0_1: Option<string>,
            v1_1: Func1<Option<Dice::US1>, LrcPtr<MutCell<Option<Dice::US1>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Dice::US1>>> = v1_1(match &v0_1 {
                    None => None::<Dice::US1>,
                    Some(v0_1_0_0) => {
                        let x: string = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Dice::US1::US1_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method3(v0_1: string) -> string {
            let v3_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v5: bool = true;
            let _result_map_ = v3_1.map(|x| {
                //;
                let v7: std::string::String = x;
                let v9: string = fable_library_rust::String_::fromString(v7);
                let v11: bool = true;
                v9
            });
            let v13: Result<string, std::env::VarError> = _result_map_;
            let v14: string = Dice::method4();
            v13.unwrap_or(v14)
        }
        pub fn method5() -> string {
            string("AUTOMATION")
        }
        pub fn closure8(unitVar: (), v0_1: string) {
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
            let v3_1: string = Dice::method3(Dice::method2());
            let v8: Dice::US2 = if string("Verbose") == v3_1.clone() {
                Dice::US2::US2_0(Dice::US0::US0_0)
            } else {
                Dice::US2::US2_1
            };
            let _v1: (Dice::US2, Dice::US3) = (
                match &v8 {
                    Dice::US2::US2_0(v8_0_0) => Dice::US2::US2_0(match &v8 {
                        Dice::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v15: Dice::US2 = if string("Debug") == v3_1.clone() {
                            Dice::US2::US2_0(Dice::US0::US0_1)
                        } else {
                            Dice::US2::US2_1
                        };
                        match &v15 {
                            Dice::US2::US2_0(v15_0_0) => Dice::US2::US2_0(match &v15 {
                                Dice::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v22: Dice::US2 = if string("Info") == v3_1.clone() {
                                    Dice::US2::US2_0(Dice::US0::US0_2)
                                } else {
                                    Dice::US2::US2_1
                                };
                                match &v22 {
                                    Dice::US2::US2_0(v22_0_0) => Dice::US2::US2_0(match &v22 {
                                        Dice::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                    _ => {
                                        let v29: Dice::US2 = if string("Warning") == v3_1.clone() {
                                            Dice::US2::US2_0(Dice::US0::US0_3)
                                        } else {
                                            Dice::US2::US2_1
                                        };
                                        match &v29 {
                                            Dice::US2::US2_0(v29_0_0) => {
                                                Dice::US2::US2_0(match &v29 {
                                                    Dice::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v36: Dice::US2 =
                                                    if string("Critical") == v3_1.clone() {
                                                        Dice::US2::US2_0(Dice::US0::US0_4)
                                                    } else {
                                                        Dice::US2::US2_1
                                                    };
                                                match &v36 {
                                                    Dice::US2::US2_0(v36_0_0) => {
                                                        Dice::US2::US2_0(match &v36 {
                                                            Dice::US2::US2_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => Dice::US2::US2_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if Dice::method3(Dice::method5()) == string("True") {
                    Dice::US3::US3_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Dice::US3::US3_1
                },
            );
            let v295: Dice::US3 = _v1.1.clone();
            let v294: Dice::US2 = _v1.0.clone();
            (
                LrcPtr::new(Dice::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Dice::closure8((), v))),
                }),
                LrcPtr::new(Dice::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Dice::Mut4 {
                    l0: MutCell::new(match &v294 {
                        Dice::US2::US2_0(v294_0_0) => match &v294 {
                            Dice::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v295 {
                    Dice::US3::US3_0(v295_0_0) => Some(match &v295 {
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
        pub fn closure9(v0_1: LrcPtr<Dice::Mut0>, unitVar: ()) {
            let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2_1);
            ()
        }
        pub fn closure10(
            v0_1: LrcPtr<MutCell<Option<Dice::US3>>>,
            v1_1: Option<Dice::US3>,
        ) -> LrcPtr<MutCell<Option<Dice::US3>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure11(
            v0_1: Option<i64>,
            v1_1: Func1<Option<Dice::US3>, LrcPtr<MutCell<Option<Dice::US3>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Dice::US3>>> = v1_1(match &v0_1 {
                    None => None::<Dice::US3>,
                    Some(v0_1_0_0) => {
                        let x: i64 = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Dice::US3::US3_0(x)
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method6() -> string {
            string("hh:mm:ss")
        }
        pub fn method7() -> string {
            string("HH:mm:ss")
        }
        pub fn method8() -> string {
            string("\u{001b}[0m")
        }
        pub fn method9() -> string {
            string("")
        }
        pub fn closure13(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure12(unitVar: (), v0_1: string) {
            let v3_1: () = {
                Dice::closure13(v0_1, ());
                ()
            };
            ()
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
            let v35: () = {
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
            let v67: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v79: () = {
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
                let _v112: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v117: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v112 = _v112.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v112.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v132: Dice::US3 = defaultValue(Dice::US3::US3_1, _v112.get().clone());
                let v172: DateTime = match &v132 {
                    Dice::US3::US3_0(v132_0_0) => {
                        let v146: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v132 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v146.hours(),
                            v146.minutes(),
                            v146.seconds(),
                            v146.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v177: string = {
                    let provider: string = Dice::method6();
                    v172.toString(provider)
                };
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v585: &str = inline_colorization::color_bright_blue;
                let v587: &str = &*v569;
                let v589: &str = inline_colorization::color_reset;
                let v591: string = string("format!(\"{v585}{v587}{v589}\")");
                let v592: std::string::String = format!("{v585}{v587}{v589}");
                let v594: string = fable_library_rust::String_::fromString(v592);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v697: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v177,
                            v594,
                            v635,
                            string("dice.create_sequential_roller ()"),
                            v637.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v697.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v697)
            }
        }
        pub fn method10(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            '_method10: loop {
                break '_method10 (match v0_1.get().clone().as_ref() {
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
                        continue '_method10;
                    }
                });
            }
        }
        pub fn method11(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => LrcPtr::new(Dice::UH1::UH1_1(
                    match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice::method11(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn closure14(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn method12(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH0> = Dice::method12(
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
                            move || Dice::closure14(v4_1.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure15(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn closure16(
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
                            Dice::method13(v0_1, v5_0_1.clone()),
                        )),
                    };
                    v1_1.l0.set(Dice::US4::US4_1(v12.clone()));
                    v12
                }
                Dice::US4::US4_1(v2_1_1_0) => v2_1_1_0.clone(),
            }
        }
        pub fn method13(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
        ) -> Func0<LrcPtr<Dice::UH0>> {
            let v3_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::US4::US4_0(v1_1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3_1 = v3_1.clone();
                move || Dice::closure16(v0_1.clone(), v3_1.clone(), ())
            })
        }
        pub fn closure19(v0_1: LrcPtr<Dice::Mut3>, v1_1: string, unitVar: ()) {
            let v3_1: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3_1);
            ()
        }
        pub fn closure18(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: Option<u8>, unitVar: ()) {
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
            let v39: () = {
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
            let v71: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v71,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v79: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v83: () = {
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
                let _v116: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v121: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v116 = _v116.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v116.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v136: Dice::US3 = defaultValue(Dice::US3::US3_1, _v116.get().clone());
                let v176: DateTime = match &v136 {
                    Dice::US3::US3_0(v136_0_0) => {
                        let v150: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v136 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v150.hours(),
                            v150.minutes(),
                            v150.seconds(),
                            v150.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v181: string = {
                    let provider: string = Dice::method6();
                    v176.toString(provider)
                };
                let v573: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v589: &str = inline_colorization::color_bright_blue;
                let v591: &str = &*v573;
                let v593: &str = inline_colorization::color_reset;
                let v595: string = string("format!(\"{v589}{v591}{v593}\")");
                let v596: std::string::String = format!("{v589}{v591}{v593}");
                let v598: string = fable_library_rust::String_::fromString(v596);
                let v639: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v641: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v648: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("current_index")), ());
                    ()
                };
                let v666: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v683: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v692: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v700: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v708: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v716: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v725: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("len")), ());
                    ()
                };
                let v733: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v741: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v749: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v758: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("last_item")), ());
                    ()
                };
                let v766: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v771: std::string::String = format!("{:#?}", v3_1);
                let v801: () = {
                    Dice::closure19(
                        v641.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v771)),
                        (),
                    );
                    ()
                };
                let v810: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v872: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v181,
                            v598,
                            v639,
                            string("dice.create_sequential_roller / roll"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v872.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v872)
            }
        }
        pub fn method15(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> Dice::US5 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1_1.clone());
            '_method15: loop {
                break '_method15 (match v1_1.get().clone().as_ref() {
                    Dice::UH0::UH0_1 => Dice::US5::US5_1,
                    Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get().clone() <= 0_i64 {
                            Dice::US5::US5_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = v0_1.get().clone() - 1_i64;
                            let v1_1_temp: LrcPtr<Dice::UH0> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method15;
                        }
                    }
                });
            }
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) {
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
            let v35: () = {
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
            let v67: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v79: () = {
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
                let _v112: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v117: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v112 = _v112.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v112.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v132: Dice::US3 = defaultValue(Dice::US3::US3_1, _v112.get().clone());
                let v172: DateTime = match &v132 {
                    Dice::US3::US3_0(v132_0_0) => {
                        let v146: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v132 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v146.hours(),
                            v146.minutes(),
                            v146.seconds(),
                            v146.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v177: string = {
                    let provider: string = Dice::method6();
                    v172.toString(provider)
                };
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v585: &str = inline_colorization::color_bright_blue;
                let v587: &str = &*v569;
                let v589: &str = inline_colorization::color_reset;
                let v591: string = string("format!(\"{v585}{v587}{v589}\")");
                let v592: std::string::String = format!("{v585}{v587}{v589}");
                let v594: string = fable_library_rust::String_::fromString(v592);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v697: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v177,
                            v594,
                            v635,
                            string("dice.create_sequential_roller / roll / None"),
                            v637.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v697.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v697)
            }
        }
        pub fn method14(
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
            '_method14: loop {
                break '_method14 ({
                    let v5: i64 = v1_1.l0.get().clone();
                    let v6: i64 = v2_1.l0.get().clone();
                    let v7: i64 = v3_1.l0.get().clone();
                    let v8: Dice::US5 = v4_1.l0.get().clone();
                    let v18: () = {
                        Dice::closure18(
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
                    let v942: LrcPtr<Dice::UH0> = v0_1();
                    let v944: Dice::US5 = Dice::method15(v1_1.l0.get().clone(), v942);
                    match &v944 {
                        Dice::US5::US5_0(v944_0_0) => {
                            let v945: u8 = match &v944 {
                                Dice::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v947: i64 = v1_1.l0.get().clone() + 1_i64;
                            v1_1.l0.set(v947);
                            v4_1.l0.set(Dice::US5::US5_0(v945));
                            v945
                        }
                        _ => {
                            let v951: () = {
                                Dice::closure20((), ());
                                ()
                            };
                            if v3_1.l0.get().clone() == -1_i64 {
                                let v1706: i64 = v1_1.l0.get().clone();
                                v3_1.l0.set(v1706);
                                ()
                            }
                            {
                                let v1712: i64 = if v2_1.l0.get().clone() >= v3_1.l0.get().clone() {
                                    1_i64
                                } else {
                                    v2_1.l0.get().clone() + 1_i64
                                };
                                v2_1.l0.set(v1712);
                                {
                                    let v1714: i64 = v2_1.l0.get().clone() - 1_i64;
                                    v1_1.l0.set(v1714);
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
                                        continue '_method14;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure17(
            v0_1: Func0<LrcPtr<Dice::UH0>>,
            v1_1: LrcPtr<Dice::Mut0>,
            v2_1: LrcPtr<Dice::Mut0>,
            v3_1: LrcPtr<Dice::Mut0>,
            v4_1: LrcPtr<Dice::Mut6>,
            unitVar: (),
        ) -> u8 {
            Dice::method14(v0_1, v1_1, v2_1, v3_1, v4_1)
        }
        pub fn closure3(unitVar: (), v0_1: LrcPtr<Dice::UH1>) -> Func0<u8> {
            let v3_1: () = {
                Dice::closure4((), ());
                ()
            };
            let v760: LrcPtr<Dice::UH0> = Dice::method12(
                Dice::method11(
                    v0_1.clone(),
                    Dice::method10(v0_1, LrcPtr::new(Dice::UH1::UH1_0)),
                ),
                LrcPtr::new(Dice::UH0::UH0_1),
            );
            let v762 = Dice::method13(
                v760.clone(),
                Func0::new({
                    let v760 = v760.clone();
                    move || Dice::closure15(v760.clone(), ())
                }),
            );
            let v763: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(0_i64),
            });
            let v764: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(1_i64),
            });
            let v765: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(-1_i64),
            });
            let v767: LrcPtr<Dice::Mut6> = LrcPtr::new(Dice::Mut6 {
                l0: MutCell::new(Dice::US5::US5_1),
            });
            Func0::new({
                let v762 = v762.clone();
                let v763 = v763.clone();
                let v764 = v764.clone();
                let v765 = v765.clone();
                let v767 = v767.clone();
                move || {
                    Dice::closure17(
                        v762.clone(),
                        v763.clone(),
                        v764.clone(),
                        v765.clone(),
                        v767.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure24(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("max")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("n")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("p")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v749: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v811: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.calculate_dice_count"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v811.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v811)
            }
        }
        pub fn method16(v0_1: u64, v1_1: i8, v2_1: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method16: loop {
                break '_method16 (if v2_1.get().clone() < v0_1.get().clone() {
                    let v4_1: u64 = v2_1.get().clone() * 6_u64;
                    if v4_1 > v2_1.get().clone() {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                        let v2_1_temp: u64 = v4_1;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method16;
                    } else {
                        let v10: () = {
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
                    let v877: () = {
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
        pub fn closure25(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v749: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v811: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v811.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v811)
            }
        }
        pub fn closure89(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                0_u64,
                Func0::new(move || Dice::closure89((), ())),
            ))
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
        pub fn method19(v0_1: i8, v1_1: LrcPtr<Dice::UH2>) -> Dice::US7 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH2>> = MutCell::new(v1_1.clone());
            '_method19: loop {
                break '_method19 (match v1_1.get().clone().as_ref() {
                    Dice::UH2::UH2_1 => Dice::US7::US7_1,
                    Dice::UH2::UH2_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get().clone() <= 0_i8 {
                            Dice::US7::US7_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                            let v1_1_temp: LrcPtr<Dice::UH2> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method19;
                        }
                    }
                });
            }
        }
        pub fn closure90(v0_1: u64, v1_1: i8, v2_1: u8, v3_1: u64, unitVar: ()) {
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
            let v39: () = {
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
            let v71: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v71,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v79: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v83: () = {
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
                let _v116: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v121: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v116 = _v116.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v116.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v136: Dice::US3 = defaultValue(Dice::US3::US3_1, _v116.get().clone());
                let v176: DateTime = match &v136 {
                    Dice::US3::US3_0(v136_0_0) => {
                        let v150: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v136 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v150.hours(),
                            v150.minutes(),
                            v150.seconds(),
                            v150.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v181: string = {
                    let provider: string = Dice::method6();
                    v176.toString(provider)
                };
                let v573: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v589: &str = inline_colorization::color_bright_blue;
                let v591: &str = &*v573;
                let v593: &str = inline_colorization::color_reset;
                let v595: string = string("format!(\"{v589}{v591}{v593}\")");
                let v596: std::string::String = format!("{v589}{v591}{v593}");
                let v598: string = fable_library_rust::String_::fromString(v596);
                let v639: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v641: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v648: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v666: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v683: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v692: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v700: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v708: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v716: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v725: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v733: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v741: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v749: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v758: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v766: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v774: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", v3_1), ());
                    ()
                };
                let v783: () = {
                    Dice::closure19(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v845: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v181,
                            v598,
                            v639,
                            string("dice.accumulate_dice_rolls"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v845.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v845)
            }
        }
        pub fn closure91(v0_1: u64, v1_1: i8, v2_1: u8, unitVar: ()) {
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v749: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v811: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v811.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v811)
            }
        }
        pub fn method18(v0_1: i8, v1_1: LrcPtr<Dice::UH1>, v2_1: u64) -> Dice::US6 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method18: loop {
                break '_method18 (if v0_1.get().clone() < 0_i8 {
                    let v4_1: u64 = v2_1.get().clone() + 1_u64;
                    let v7: () = {
                        Dice::closure25(v2_1.get().clone(), v0_1.get().clone(), v4_1, ());
                        ()
                    };
                    Dice::US6::US6_0(v4_1, v1_1.get().clone())
                } else {
                    match v1_1.get().clone().as_ref() {
                        Dice::UH1::UH1_0 => Dice::US6::US6_1,
                        Dice::UH1::UH1_1(v1_1_1_0, v1_1_1_1) => {
                            let v874: LrcPtr<Dice::UH1> = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v873: u8 = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v873 > 1_u8 {
                                let v879: Dice::US7 = Dice::method19(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice::closure26((), ())),
                                    )),
                                );
                                let v886: u64 = (v873 - 1_u8) as u64
                                    * match &v879 {
                                        Dice::US7::US7_0(v879_0_0) => match &v879 {
                                            Dice::US7::US7_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                let v889: () = {
                                    Dice::closure90(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v873,
                                        v886,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v874;
                                    let v2_1_temp: u64 = v2_1.get().clone() + v886;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method18;
                                }
                            } else {
                                let v1791: () = {
                                    Dice::closure91(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v873,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v874.clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method18;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method20(v0_1: i8, v1_1: Func0<u8>, v2_1: i8) -> LrcPtr<Dice::UH1> {
            if v2_1 < v0_1 {
                LrcPtr::new(Dice::UH1::UH1_1(
                    v1_1(),
                    Dice::method20(v0_1, v1_1, v2_1 + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice::UH1::UH1_0)
            }
        }
        pub fn method21(
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
            '_method21: loop {
                break '_method21 ({
                    let v5: i8 = v3_1.get().clone() + 1_i8;
                    if v3_1.get().clone() < v5 {
                        Dice::method17(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone())),
                            v5,
                        )
                    } else {
                        let v11: Dice::US6 =
                            Dice::method18(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
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
                                    let v4_1_temp: LrcPtr<Dice::UH1> = Dice::method20(
                                        v3_1.get().clone(),
                                        v0_1.get().clone(),
                                        0_i8,
                                    );
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method21;
                                } else {
                                    Dice::method17(
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
                                    Dice::method20(v3_1.get().clone(), v0_1.get().clone(), 0_i8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                continue '_method21;
                            } else {
                                Dice::method17(
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
        pub fn method17(
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
            '_method17: loop {
                break '_method17 (if v5.get().clone() < v3_1.get().clone() + 1_i8 {
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
                    continue '_method17;
                } else {
                    let v13: Dice::US6 =
                        Dice::method18(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                    if let Dice::US6::US6_0(v13_0_0, v13_0_1) = &v13 {
                        let v14: u64 = match &v13 {
                            Dice::US6::US6_0(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v14 <= v2_1.get().clone() {
                            v14
                        } else {
                            if v1_1.get().clone() {
                                Dice::method21(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    Dice::method20(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
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
                                continue '_method17;
                            }
                        }
                    } else {
                        if v1_1.get().clone() {
                            Dice::method21(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                Dice::method20(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
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
                            continue '_method17;
                        }
                    }
                });
            }
        }
        pub fn closure23(v0_1: Func0<u8>, v1_1: bool, v2_1: u64) -> u64 {
            Dice::method17(
                v0_1,
                v1_1,
                v2_1,
                (if v2_1 == 1_u64 {
                    1_i8
                } else {
                    Dice::method16(v2_1, 0_i8, 1_u64)
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
        pub fn method22(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method22: loop {
                break '_method22 (match v0_1.get().clone().as_ref() {
                    Dice::UH1::UH1_0 => v1_1.get().clone(),
                    Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = match v0_1.get().clone().as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method22;
                    }
                });
            }
        }
        pub fn closure93(v0_1: u64, v1_1: LrcPtr<Dice::UH1>) -> Option<u64> {
            let v6: Dice::US6 =
                Dice::method18(Dice::method22(v1_1.clone(), 0_i8) - 1_i8, v1_1, 0_u64);
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
        pub fn closure92(unitVar: (), v0_1: u64) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice::UH1>| Dice::closure93(v0_1, v)
            })
        }
        pub fn closure95(unitVar: (), unitVar_1: ()) {
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
            let v35: () = {
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
            let v67: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v79: () = {
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
                let _v112: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v117: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v112 = _v112.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v112.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v132: Dice::US3 = defaultValue(Dice::US3::US3_1, _v112.get().clone());
                let v172: DateTime = match &v132 {
                    Dice::US3::US3_0(v132_0_0) => {
                        let v146: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v132 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v146.hours(),
                            v146.minutes(),
                            v146.seconds(),
                            v146.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v177: string = {
                    let provider: string = Dice::method6();
                    v172.toString(provider)
                };
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v585: &str = inline_colorization::color_bright_blue;
                let v587: &str = &*v569;
                let v589: &str = inline_colorization::color_reset;
                let v591: string = string("format!(\"{v585}{v587}{v589}\")");
                let v592: std::string::String = format!("{v585}{v587}{v589}");
                let v594: string = fable_library_rust::String_::fromString(v592);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v644: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v653: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string("max")), ());
                    ()
                };
                let v662: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v670: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", i64::MAX), ());
                    ()
                };
                let v679: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v688: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string("n")), ());
                    ()
                };
                let v696: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v704: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", 24_i8), ());
                    ()
                };
                let v712: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v721: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string("p")), ());
                    ()
                };
                let v729: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v737: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", 4738381338321616896_i64), ());
                    ()
                };
                let v746: () = {
                    Dice::closure19(v637.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v808: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v177,
                            v594,
                            v635,
                            string("dice.calculate_dice_count"),
                            v637.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v808.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v808)
            }
        }
        pub fn method24() -> u8 {
            rand::Rng::gen_range(&mut rand::thread_rng(), 1_u8..7_u8)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 23_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 22_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 21_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 20_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 19_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 18_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 17_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 16_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 15_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 14_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 13_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 12_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 11_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 10_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 9_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 8_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 7_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 6_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 5_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 4_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 3_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 2_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
            }
        }
        pub fn closure118(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 1_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
            }
        }
        pub fn closure119(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
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
            let v38: () = {
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
            let v70: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let _v115: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v120: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v115 = _v115.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v115.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v135: Dice::US3 = defaultValue(Dice::US3::US3_1, _v115.get().clone());
                let v175: DateTime = match &v135 {
                    Dice::US3::US3_0(v135_0_0) => {
                        let v149: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v135 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v149.hours(),
                            v149.minutes(),
                            v149.seconds(),
                            v149.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v180: string = {
                    let provider: string = Dice::method6();
                    v175.toString(provider)
                };
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v588: &str = inline_colorization::color_bright_blue;
                let v590: &str = &*v572;
                let v592: &str = inline_colorization::color_reset;
                let v594: string = string("format!(\"{v588}{v590}{v592}\")");
                let v595: std::string::String = format!("{v588}{v590}{v592}");
                let v597: string = fable_library_rust::String_::fromString(v595);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v647: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", 0_i8), ());
                    ()
                };
                let v682: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v757: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v765: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v773: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", v2_1), ());
                    ()
                };
                let v782: () = {
                    Dice::closure19(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v844: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v180,
                            v597,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v844.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v844)
            }
        }
        pub fn closure120(v0_1: i64, v1_1: i64, unitVar: ()) {
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", -1_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method49(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
            let v2_1: i64 = v1_1 + 1_i64;
            let v5: () = {
                Dice::closure120(v1_1, v2_1, ());
                ()
            };
            Dice::US8::US8_0(v2_1, v0_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 0_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v7: i64 = (v3_1 - 1_u8) as i64;
                        let v10: () = {
                            Dice::closure119(v1_1, v3_1, v7, ());
                            ()
                        };
                        Dice::method49(v4_1.clone(), v1_1 + v7)
                    } else {
                        let v911: () = {
                            Dice::closure121(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method49(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 1_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 6_i64;
                        let v11: () = {
                            Dice::closure118(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method48(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure122(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method48(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 2_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 36_i64;
                        let v11: () = {
                            Dice::closure117(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method47(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure123(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method47(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 3_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 216_i64;
                        let v11: () = {
                            Dice::closure116(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method46(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure124(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method46(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 4_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 1296_i64;
                        let v11: () = {
                            Dice::closure115(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method45(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure125(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method45(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 5_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 7776_i64;
                        let v11: () = {
                            Dice::closure114(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method44(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure126(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method44(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 6_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 46656_i64;
                        let v11: () = {
                            Dice::closure113(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method43(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure127(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method43(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 7_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 279936_i64;
                        let v11: () = {
                            Dice::closure112(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method42(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure128(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method42(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 8_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 1679616_i64;
                        let v11: () = {
                            Dice::closure111(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method41(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure129(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method41(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 9_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method39(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure110(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method40(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure130(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method40(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 10_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
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
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 60466176_i64;
                        let v11: () = {
                            Dice::closure109(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method39(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure131(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method39(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 11_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method37(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure108(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method38(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure132(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method38(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 12_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method36(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure107(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method37(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure133(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method37(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 13_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method35(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure106(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method36(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure134(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method36(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 14_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method34(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure105(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method35(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure135(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method35(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 15_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method33(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure104(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method34(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure136(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method34(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 16_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method32(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure103(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method33(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure137(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method33(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 17_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method31(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure102(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method32(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure138(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method32(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 18_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method30(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure101(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method31(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure139(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method31(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 19_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method29(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure100(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method30(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure140(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method30(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 20_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method28(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure99(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method29(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure141(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method29(v4_1, v1_1)
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 21_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method27(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure98(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method28(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure142(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method28(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure143(v0_1: i64, v1_1: u8, unitVar: ()) {
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 22_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method26(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure97(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method27(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure143(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method27(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn closure144(v0_1: i64, v1_1: u8, unitVar: ()) {
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
            let v37: () = {
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
            let v69: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
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
                let _v114: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v119: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v114 = _v114.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v114.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v134: Dice::US3 = defaultValue(Dice::US3::US3_1, _v114.get().clone());
                let v174: DateTime = match &v134 {
                    Dice::US3::US3_0(v134_0_0) => {
                        let v148: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v134 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v148.hours(),
                            v148.minutes(),
                            v148.seconds(),
                            v148.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v179: string = {
                    let provider: string = Dice::method6();
                    v174.toString(provider)
                };
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v587: &str = inline_colorization::color_bright_blue;
                let v589: &str = &*v571;
                let v591: &str = inline_colorization::color_reset;
                let v593: string = string("format!(\"{v587}{v589}{v591}\")");
                let v594: std::string::String = format!("{v587}{v589}{v591}");
                let v596: string = fable_library_rust::String_::fromString(v594);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v646: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v655: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v664: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v672: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", 23_i8), ());
                    ()
                };
                let v681: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v690: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v698: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v706: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v714: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v723: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v731: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v739: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v748: () = {
                    Dice::closure19(v639.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v810: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v179,
                            v596,
                            v637,
                            string("dice.accumulate_dice_rolls"),
                            v639.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v810.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v810)
            }
        }
        pub fn method25(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US8 {
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
                            Dice::closure96(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method26(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v912: () = {
                            Dice::closure144(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method26(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method23(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i64 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method23: loop {
                break '_method23 (if v1_1.get().clone() < 24_i8 {
                    let v0_1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(), v0_1.get().clone()));
                    let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method23;
                } else {
                    let v8: Dice::US8 = Dice::method25(v0_1.get().clone(), 0_i64);
                    if let Dice::US8::US8_0(v8_0_0, v8_0_1) = &v8 {
                        let v9: i64 = match &v8 {
                            Dice::US8::US8_0(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v9 <= i64::MAX {
                            v9
                        } else {
                            let v0_1_temp: LrcPtr<Dice::UH1> =
                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                            let v1_1_temp: i8 = 23_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method23;
                        }
                    } else {
                        let v0_1_temp: LrcPtr<Dice::UH1> =
                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method24(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                        let v1_1_temp: i8 = 23_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method23;
                    }
                });
            }
        }
        pub fn closure145(v0_1: i64, unitVar: ()) {
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
            let v36: () = {
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
            let v68: Dice::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Dice::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
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
                let _v113: LrcPtr<MutCell<Option<Dice::US3>>> = refCell(None::<Dice::US3>);
                let v118: () = {
                    Dice::closure11(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v113 = _v113.clone();
                            move |v: Option<Dice::US3>| Dice::closure10(_v113.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v133: Dice::US3 = defaultValue(Dice::US3::US3_1, _v113.get().clone());
                let v173: DateTime = match &v133 {
                    Dice::US3::US3_0(v133_0_0) => {
                        let v147: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v133 {
                                Dice::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v147.hours(),
                            v147.minutes(),
                            v147.seconds(),
                            v147.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v178: string = {
                    let provider: string = Dice::method6();
                    v173.toString(provider)
                };
                let v570: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v586: &str = inline_colorization::color_bright_blue;
                let v588: &str = &*v570;
                let v590: &str = inline_colorization::color_reset;
                let v592: string = string("format!(\"{v586}{v588}{v590}\")");
                let v593: std::string::String = format!("{v586}{v588}{v590}");
                let v595: string = fable_library_rust::String_::fromString(v593);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Dice::Mut3> = LrcPtr::new(Dice::Mut3 {
                    l0: MutCell::new(Dice::method9()),
                });
                let v645: () = {
                    Dice::closure19(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Dice::closure19(v638.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v663: () = {
                    Dice::closure19(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v671: () = {
                    Dice::closure19(v638.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v680: () = {
                    Dice::closure19(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v742: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v178,
                            v595,
                            v636,
                            string("dice.main"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v742.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v742)
            }
        }
        pub fn closure94(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3_1: () = {
                Dice::closure95((), ());
                ()
            };
            let v872: () = {
                Dice::closure145(Dice::method23(LrcPtr::new(Dice::UH1::UH1_0), 0_i8), ());
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
pub use module_a51efde0::*;
#[path = "../../polyglot/lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../polyglot/lib/spiral/async_.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../polyglot/lib/spiral/common.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../polyglot/lib/spiral/crypto.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../polyglot/lib/spiral/date_time.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../polyglot/lib/spiral/file_system.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../polyglot/lib/spiral/lib.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../polyglot/lib/spiral/networking.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../polyglot/lib/spiral/platform.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../polyglot/lib/spiral/runtime.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../polyglot/lib/spiral/sm.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../polyglot/lib/spiral/threading.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../polyglot/lib/spiral/trace.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::main(array_from(args));
}
