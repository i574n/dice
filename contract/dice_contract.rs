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
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(u64, LrcPtr<Dice_contract::UH0>),
            US4_1,
        }
        impl core::fmt::Display for Dice_contract::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0(u64, Func0<LrcPtr<Dice_contract::UH1>>),
            UH1_1,
        }
        impl core::fmt::Display for Dice_contract::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(u64),
            US5_1,
        }
        impl core::fmt::Display for Dice_contract::US5 {
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
        pub fn closure3(
            v0_1: LrcPtr<MutCell<Option<Dice_contract::US1>>>,
            v1: Option<Dice_contract::US1>,
        ) -> LrcPtr<MutCell<Option<Dice_contract::US1>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure4(
            v0_1: Option<string>,
            v1: Func1<Option<Dice_contract::US1>, LrcPtr<MutCell<Option<Dice_contract::US1>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Dice_contract::US1>>> = v1(match &v0_1 {
                    None => None::<Dice_contract::US1>,
                    Some(v0_1_0_0) => {
                        let x: string = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Dice_contract::US1::US1_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
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
        pub fn method4() -> string {
            string("AUTOMATION")
        }
        pub fn closure5(unitVar: (), v0_1: string) {
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
            let v79: string = string("env!(\"AUTOMATION\")");
            let v80: &str = env!("AUTOMATION");
            let v82: std::string::String = String::from(v80);
            let _v1: (Dice_contract::US2, Dice_contract::US3) = (
                Dice_contract::US2::US2_1,
                if fable_library_rust::String_::fromString(v82) != string("True") {
                    Dice_contract::US3::US3_1
                } else {
                    Dice_contract::US3::US3_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v295: Dice_contract::US3 = _v1.1.clone();
            let v294: Dice_contract::US2 = _v1.0.clone();
            (
                LrcPtr::new(Dice_contract::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Dice_contract::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Dice_contract::closure5((), v))),
                }),
                LrcPtr::new(Dice_contract::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Dice_contract::Mut4 {
                    l0: MutCell::new(match &v294 {
                        Dice_contract::US2::US2_0(v294_0_0) => match &v294 {
                            Dice_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v295 {
                    Dice_contract::US3::US3_0(v295_0_0) => Some(match &v295 {
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
        pub fn closure6(v0_1: LrcPtr<Dice_contract::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure7(
            v0_1: LrcPtr<MutCell<Option<Dice_contract::US3>>>,
            v1: Option<Dice_contract::US3>,
        ) -> LrcPtr<MutCell<Option<Dice_contract::US3>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure8(
            v0_1: Option<i64>,
            v1: Func1<Option<Dice_contract::US3>, LrcPtr<MutCell<Option<Dice_contract::US3>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Dice_contract::US3>>> = v1(match &v0_1 {
                    None => None::<Dice_contract::US3>,
                    Some(v0_1_0_0) => {
                        let x: i64 = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Dice_contract::US3::US3_0(x)
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method5() -> string {
            string("hh:mm:ss")
        }
        pub fn method6() -> string {
            string("HH:mm:ss")
        }
        pub fn method7() -> string {
            string("\u{001b}[0m")
        }
        pub fn method8() -> string {
            string("")
        }
        pub fn closure9(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn closure11(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure10(unitVar: (), v0_1: string) {
            let v3: () = {
                Dice_contract::closure11(v0_1, ());
                ()
            };
            ()
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
            let v20: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
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
            let v68: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
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
                let v250: u64 = near_sdk::env::block_timestamp();
                let _v251: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v256: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v251 = _v251.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v251.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v271: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v251.get().clone());
                let v281: u64 = match &v271 {
                    Dice_contract::US3::US3_0(v271_0_0) => {
                        v250 - match &v271 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v250,
                } / 1000000000_u64;
                let v282: u64 = v281 % 60_u64;
                let v284: u64 = v281 / 60_u64 % 60_u64;
                let v286: u64 = v281 / 3600_u64 % 24_u64;
                let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
                let v290: string = fable_library_rust::String_::fromString(v288);
                let v570: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v608: &str = inline_colorization::color_bright_blue;
                let v610: &str = &*v570;
                let v612: &str = inline_colorization::color_reset;
                let v614: string = string("format!(\"{v608}{v610}{v612}\")");
                let v615: std::string::String = format!("{v608}{v610}{v612}");
                let v617: string = fable_library_rust::String_::fromString(v615);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: string = sprintf!("{:?}", v0_1);
                let v641: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v648: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Dice_contract::closure9(
                        v641.clone(),
                        sprintf!("{}", string("seed_excess")),
                        (),
                    );
                    ()
                };
                let v666: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", v637), ());
                    ()
                };
                let v683: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v745: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v290,
                            v617,
                            v636,
                            string("dice_contract.contribute_seed"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v759: string = if v20.l0.get().clone() == string("") {
                    v745.clone()
                } else {
                    if v745.clone() == string("") {
                        v20.l0.get().clone()
                    } else {
                        append(append(v20.l0.get().clone(), string("\n")), v745.clone())
                    }
                };
                let v761: &str = &*v759.clone();
                let v763 = v761.chars();
                let v765 = v763;
                let v767: Vec<char> = v765.collect::<Vec<_>>();
                let v769: Vec<Vec<char>> = v767
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v771: bool = true;
                let _vec_map: Vec<_> = v769
                    .into_iter()
                    .map(|x| {
                        //;
                        let v773: Vec<char> = x;
                        let v775: std::string::String = String::from_iter(v773);
                        let v777: bool = true;
                        v775
                    })
                    .collect::<Vec<_>>();
                let v779: Vec<std::string::String> = _vec_map;
                if if v745.clone() != string("") {
                    v779.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v20.l0.set(v759);
                    ()
                } else {
                    v20.l0.set(string(""));
                    {
                        let v791: bool = true;
                        v779.into_iter().for_each(|x| {
                            //;
                            let v793: std::string::String = x;
                            near_sdk::log!("{}", v793);
                            {
                                let v796: bool = true;
                                let v798: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v745)
            }
        }
        pub fn closure12(
            v0_1: Vec<u8>,
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
            v11: usize,
            v12: Vec<u8>,
            v13: Vec<u8>,
            unitVar: (),
        ) {
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
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v33: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v49: () = {
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
            ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
            let v81: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v81,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v89: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
                let v93: () = {
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
                ) = getValue(Dice_contract::TraceState::trace_state().get().clone());
                let v263: u64 = near_sdk::env::block_timestamp();
                let _v264: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v269: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v264 = _v264.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v264.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v284: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v264.get().clone());
                let v294: u64 = match &v284 {
                    Dice_contract::US3::US3_0(v284_0_0) => {
                        v263 - match &v284 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v263,
                } / 1000000000_u64;
                let v295: u64 = v294 % 60_u64;
                let v297: u64 = v294 / 60_u64 % 60_u64;
                let v299: u64 = v294 / 3600_u64 % 24_u64;
                let v301: std::string::String = format!("{:02}:{:02}:{:02}", v299, v297, v295);
                let v303: string = fable_library_rust::String_::fromString(v301);
                let v583: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v621: &str = inline_colorization::color_bright_blue;
                let v623: &str = &*v583;
                let v625: &str = inline_colorization::color_reset;
                let v627: string = string("format!(\"{v621}{v623}{v625}\")");
                let v628: std::string::String = format!("{v621}{v623}{v625}");
                let v630: string = fable_library_rust::String_::fromString(v628);
                let v649: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v650: string = sprintf!("{:?}", v8);
                let v654: std::string::String = v9.to_string();
                let v655: string = sprintf!("{:?}", v4);
                let v658: string = sprintf!("{:?}", v0_1);
                let v661: string = sprintf!("{:?}", v10);
                let v664: string = sprintf!("{:?}", v12);
                let v667: string = sprintf!("{:?}", v13);
                let v671: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v678: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v687: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("max")), ());
                    ()
                };
                let v696: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v704: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v713: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v722: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("key")), ());
                    ()
                };
                let v730: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v743: std::string::String = format!("{:#?}", v1);
                let v765: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v743)),
                        (),
                    );
                    ()
                };
                let v773: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v782: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("proof")), ());
                    ()
                };
                let v790: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v803: std::string::String = format!("{:#?}", v2);
                let v825: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v803)),
                        (),
                    );
                    ()
                };
                let v833: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v842: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", string("block_timestamp")),
                        (),
                    );
                    ()
                };
                let v850: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v858: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v5), ());
                    ()
                };
                let v866: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v875: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", string("block_height")),
                        (),
                    );
                    ()
                };
                let v883: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v891: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v6), ());
                    ()
                };
                let v899: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v908: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", string("epoch_height")),
                        (),
                    );
                    ()
                };
                let v916: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v924: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v932: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v941: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", string("account_balance")),
                        (),
                    );
                    ()
                };
                let v949: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v957: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v650), ());
                    ()
                };
                let v965: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v974: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", string("signer_account_id")),
                        (),
                    );
                    ()
                };
                let v982: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v995: std::string::String = format!("{:#?}", v654);
                let v1017: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v995)),
                        (),
                    );
                    ()
                };
                let v1025: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1034: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("seed")), ());
                    ()
                };
                let v1042: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1050: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v655), ());
                    ()
                };
                let v1058: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1067: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("seeds")), ());
                    ()
                };
                let v1075: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1083: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v658), ());
                    ()
                };
                let v1091: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1100: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", string("entropy_len")),
                        (),
                    );
                    ()
                };
                let v1108: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1121: std::string::String = format!("{:#?}", v11);
                let v1143: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v1121)),
                        (),
                    );
                    ()
                };
                let v1151: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1160: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("entropy")), ());
                    ()
                };
                let v1168: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1176: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v661), ());
                    ()
                };
                let v1184: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1193: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("hash_u8")), ());
                    ()
                };
                let v1201: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1209: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v664), ());
                    ()
                };
                let v1217: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1226: () = {
                    Dice_contract::closure9(
                        v671.clone(),
                        sprintf!("{}", string("rolls_list_log")),
                        (),
                    );
                    ()
                };
                let v1234: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1242: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", v667), ());
                    ()
                };
                let v1251: () = {
                    Dice_contract::closure9(v671.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1313: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v303,
                            v630,
                            v649,
                            string("dice_contract.generate_random_number"),
                            v671.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v1327: string = if v33.l0.get().clone() == string("") {
                    v1313.clone()
                } else {
                    if v1313.clone() == string("") {
                        v33.l0.get().clone()
                    } else {
                        append(append(v33.l0.get().clone(), string("\n")), v1313.clone())
                    }
                };
                let v1329: &str = &*v1327.clone();
                let v1331 = v1329.chars();
                let v1333 = v1331;
                let v1335: Vec<char> = v1333.collect::<Vec<_>>();
                let v1337: Vec<Vec<char>> = v1335
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v1339: bool = true;
                let _vec_map: Vec<_> = v1337
                    .into_iter()
                    .map(|x| {
                        //;
                        let v1341: Vec<char> = x;
                        let v1343: std::string::String = String::from_iter(v1341);
                        let v1345: bool = true;
                        v1343
                    })
                    .collect::<Vec<_>>();
                let v1347: Vec<std::string::String> = _vec_map;
                if if v1313.clone() != string("") {
                    v1347.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v33.l0.set(v1327);
                    ()
                } else {
                    v33.l0.set(string(""));
                    {
                        let v1359: bool = true;
                        v1347.into_iter().for_each(|x| {
                            //;
                            let v1361: std::string::String = x;
                            near_sdk::log!("{}", v1361);
                            {
                                let v1364: bool = true;
                                let v1366: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1313)
            }
        }
        pub fn closure13(unitVar: (), unitVar_1: ()) {
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
            let v19: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v35: () = {
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
            let v67: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
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
                let v249: u64 = near_sdk::env::block_timestamp();
                let _v250: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v255: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v250 = _v250.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v250.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v270: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v250.get().clone());
                let v280: u64 = match &v270 {
                    Dice_contract::US3::US3_0(v270_0_0) => {
                        v249 - match &v270 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v249,
                } / 1000000000_u64;
                let v281: u64 = v280 % 60_u64;
                let v283: u64 = v280 / 60_u64 % 60_u64;
                let v285: u64 = v280 / 3600_u64 % 24_u64;
                let v287: std::string::String = format!("{:02}:{:02}:{:02}", v285, v283, v281);
                let v289: string = fable_library_rust::String_::fromString(v287);
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v607: &str = inline_colorization::color_bright_blue;
                let v609: &str = &*v569;
                let v611: &str = inline_colorization::color_reset;
                let v613: string = string("format!(\"{v607}{v609}{v611}\")");
                let v614: std::string::String = format!("{v607}{v609}{v611}");
                let v616: string = fable_library_rust::String_::fromString(v614);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v638: string = v637.l0.get().clone();
                let v653: string = if v19.l0.get().clone() == string("") {
                    string("")
                } else {
                    v19.l0.get().clone()
                };
                let v655: &str = &*v653;
                let v657 = v655.chars();
                let v659 = v657;
                let v661: Vec<char> = v659.collect::<Vec<_>>();
                let v663: Vec<Vec<char>> = v661
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v665: bool = true;
                let _vec_map: Vec<_> = v663
                    .into_iter()
                    .map(|x| {
                        //;
                        let v667: Vec<char> = x;
                        let v669: std::string::String = String::from_iter(v667);
                        let v671: bool = true;
                        v669
                    })
                    .collect::<Vec<_>>();
                let v673: Vec<std::string::String> = _vec_map;
                v19.l0.set(string(""));
                {
                    let v684: bool = true;
                    v673.into_iter().for_each(|x| {
                        //;
                        let v686: std::string::String = x;
                        near_sdk::log!("{}", v686);
                        {
                            let v689: bool = true;
                            let v691: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(string(""))
            }
        }
        pub fn closure15(v0_1: u8, v1: LrcPtr<Dice_contract::UH0>) -> LrcPtr<Dice_contract::UH0> {
            LrcPtr::new(Dice_contract::UH0::UH0_1(v0_1, v1))
        }
        pub fn closure14(
            unitVar: (),
            v0_1: u8,
        ) -> Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_contract::UH0>| Dice_contract::closure15(v0_1, v)
            })
        }
        pub fn method9() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure14((), v))
        }
        pub fn method10(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method10: loop {
                break '_method10 (match v0_1.get().clone().as_ref() {
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
                        continue '_method10;
                    }
                });
            }
        }
        pub fn closure16(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
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
            let v22: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v38: () = {
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
            let v70: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
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
                let v252: u64 = near_sdk::env::block_timestamp();
                let _v253: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v258: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v253 = _v253.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v253.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v273: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v253.get().clone());
                let v283: u64 = match &v273 {
                    Dice_contract::US3::US3_0(v273_0_0) => {
                        v252 - match &v273 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v252,
                } / 1000000000_u64;
                let v284: u64 = v283 % 60_u64;
                let v286: u64 = v283 / 60_u64 % 60_u64;
                let v288: u64 = v283 / 3600_u64 % 24_u64;
                let v290: std::string::String = format!("{:02}:{:02}:{:02}", v288, v286, v284);
                let v292: string = fable_library_rust::String_::fromString(v290);
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v610: &str = inline_colorization::color_bright_blue;
                let v612: &str = &*v572;
                let v614: &str = inline_colorization::color_reset;
                let v616: string = string("format!(\"{v610}{v612}{v614}\")");
                let v617: std::string::String = format!("{v610}{v612}{v614}");
                let v619: string = fable_library_rust::String_::fromString(v617);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v647: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v682: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v732: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v749: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v811: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v292,
                            v619,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v825: string = if v22.l0.get().clone() == string("") {
                    v811.clone()
                } else {
                    if v811.clone() == string("") {
                        v22.l0.get().clone()
                    } else {
                        append(append(v22.l0.get().clone(), string("\n")), v811.clone())
                    }
                };
                let v827: &str = &*v825.clone();
                let v829 = v827.chars();
                let v831 = v829;
                let v833: Vec<char> = v831.collect::<Vec<_>>();
                let v835: Vec<Vec<char>> = v833
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v837: bool = true;
                let _vec_map: Vec<_> = v835
                    .into_iter()
                    .map(|x| {
                        //;
                        let v839: Vec<char> = x;
                        let v841: std::string::String = String::from_iter(v839);
                        let v843: bool = true;
                        v841
                    })
                    .collect::<Vec<_>>();
                let v845: Vec<std::string::String> = _vec_map;
                if if v811.clone() != string("") {
                    v845.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v22.l0.set(v825);
                    ()
                } else {
                    v22.l0.set(string(""));
                    {
                        let v857: bool = true;
                        v845.into_iter().for_each(|x| {
                            //;
                            let v859: std::string::String = x;
                            near_sdk::log!("{}", v859);
                            {
                                let v862: bool = true;
                                let v864: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v811)
            }
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_1)
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                9223372036854775808_u64,
                Func0::new(move || Dice_contract::closure80((), ())),
            ))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4611686018427387904_u64,
                Func0::new(move || Dice_contract::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6917529027641081856_u64,
                Func0::new(move || Dice_contract::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                1152921504606846976_u64,
                Func0::new(move || Dice_contract::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                15564440312192434176_u64,
                Func0::new(move || Dice_contract::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                11817445422220181504_u64,
                Func0::new(move || Dice_contract::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                5044031582654955520_u64,
                Func0::new(move || Dice_contract::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6989586621679009792_u64,
                Func0::new(move || Dice_contract::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16537217831704461312_u64,
                Func0::new(move || Dice_contract::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                11979575008805519360_u64,
                Func0::new(move || Dice_contract::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                14294425217273954304_u64,
                Func0::new(move || Dice_contract::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2382404202878992384_u64,
                Func0::new(move || Dice_contract::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6545982058383015936_u64,
                Func0::new(move || Dice_contract::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                10314369046585278464_u64,
                Func0::new(move || Dice_contract::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4793518853382471680_u64,
                Func0::new(move || Dice_contract::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3873377154515337216_u64,
                Func0::new(move || Dice_contract::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                645562859085889536_u64,
                Func0::new(move || Dice_contract::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                107593809847648256_u64,
                Func0::new(move || Dice_contract::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3092389647259533312_u64,
                Func0::new(move || Dice_contract::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                9738770311398031360_u64,
                Func0::new(move || Dice_contract::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16995415113324298240_u64,
                Func0::new(move || Dice_contract::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                8981483876790566912_u64,
                Func0::new(move || Dice_contract::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                13794743361938128896_u64,
                Func0::new(move || Dice_contract::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2299123893656354816_u64,
                Func0::new(move || Dice_contract::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3457644661227651072_u64,
                Func0::new(move || Dice_contract::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                576274110204608512_u64,
                Func0::new(move || Dice_contract::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6244960376270618624_u64,
                Func0::new(move || Dice_contract::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                13338656111851470848_u64,
                Func0::new(move || Dice_contract::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                14520938734448279552_u64,
                Func0::new(move || Dice_contract::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                14717985838214414336_u64,
                Func0::new(move || Dice_contract::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                5527454985320660992_u64,
                Func0::new(move || Dice_contract::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16293529225644736512_u64,
                Func0::new(move || Dice_contract::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                11938960241128898560_u64,
                Func0::new(move || Dice_contract::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                8138741398091333632_u64,
                Func0::new(move || Dice_contract::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                7505371590918406144_u64,
                Func0::new(move || Dice_contract::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16623181993244360704_u64,
                Func0::new(move || Dice_contract::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                8919445023443910656_u64,
                Func0::new(move || Dice_contract::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4561031516192243712_u64,
                Func0::new(move || Dice_contract::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                9983543956220149760_u64,
                Func0::new(move || Dice_contract::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4738381338321616896_u64,
                Func0::new(move || Dice_contract::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                789730223053602816_u64,
                Func0::new(move || Dice_contract::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                131621703842267136_u64,
                Func0::new(move || Dice_contract::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                21936950640377856_u64,
                Func0::new(move || Dice_contract::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3656158440062976_u64,
                Func0::new(move || Dice_contract::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                609359740010496_u64,
                Func0::new(move || Dice_contract::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                101559956668416_u64,
                Func0::new(move || Dice_contract::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16926659444736_u64,
                Func0::new(move || Dice_contract::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2821109907456_u64,
                Func0::new(move || Dice_contract::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                470184984576_u64,
                Func0::new(move || Dice_contract::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                78364164096_u64,
                Func0::new(move || Dice_contract::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                13060694016_u64,
                Func0::new(move || Dice_contract::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2176782336_u64,
                Func0::new(move || Dice_contract::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                362797056_u64,
                Func0::new(move || Dice_contract::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                60466176_u64,
                Func0::new(move || Dice_contract::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                10077696_u64,
                Func0::new(move || Dice_contract::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                1679616_u64,
                Func0::new(move || Dice_contract::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                279936_u64,
                Func0::new(move || Dice_contract::closure24((), ())),
            ))
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                46656_u64,
                Func0::new(move || Dice_contract::closure23((), ())),
            ))
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                7776_u64,
                Func0::new(move || Dice_contract::closure22((), ())),
            ))
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                1296_u64,
                Func0::new(move || Dice_contract::closure21((), ())),
            ))
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                216_u64,
                Func0::new(move || Dice_contract::closure20((), ())),
            ))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                36_u64,
                Func0::new(move || Dice_contract::closure19((), ())),
            ))
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6_u64,
                Func0::new(move || Dice_contract::closure18((), ())),
            ))
        }
        pub fn method12(v0_1: i8, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US5 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method12: loop {
                break '_method12 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US5::US5_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if v0_1.get().clone() <= 0_i8 {
                            Dice_contract::US5::US5_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method12;
                        }
                    }
                });
            }
        }
        pub fn closure81(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
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
            let v23: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v39: () = {
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
            let v71: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v71,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v79: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
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
                let v253: u64 = near_sdk::env::block_timestamp();
                let _v254: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v259: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v254 = _v254.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v254.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v274: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v254.get().clone());
                let v284: u64 = match &v274 {
                    Dice_contract::US3::US3_0(v274_0_0) => {
                        v253 - match &v274 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v253,
                } / 1000000000_u64;
                let v285: u64 = v284 % 60_u64;
                let v287: u64 = v284 / 60_u64 % 60_u64;
                let v289: u64 = v284 / 3600_u64 % 24_u64;
                let v291: std::string::String = format!("{:02}:{:02}:{:02}", v289, v287, v285);
                let v293: string = fable_library_rust::String_::fromString(v291);
                let v573: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v611: &str = inline_colorization::color_bright_blue;
                let v613: &str = &*v573;
                let v615: &str = inline_colorization::color_reset;
                let v617: string = string("format!(\"{v611}{v613}{v615}\")");
                let v618: std::string::String = format!("{v611}{v613}{v615}");
                let v620: string = fable_library_rust::String_::fromString(v618);
                let v639: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v641: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v648: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v666: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v683: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v692: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v700: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v708: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v716: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v725: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v733: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v741: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v749: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v758: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string("value")), ());
                    ()
                };
                let v766: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v774: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v783: () = {
                    Dice_contract::closure9(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v845: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v293,
                            v620,
                            v639,
                            string("dice.accumulate_dice_rolls"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v859: string = if v23.l0.get().clone() == string("") {
                    v845.clone()
                } else {
                    if v845.clone() == string("") {
                        v23.l0.get().clone()
                    } else {
                        append(append(v23.l0.get().clone(), string("\n")), v845.clone())
                    }
                };
                let v861: &str = &*v859.clone();
                let v863 = v861.chars();
                let v865 = v863;
                let v867: Vec<char> = v865.collect::<Vec<_>>();
                let v869: Vec<Vec<char>> = v867
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v871: bool = true;
                let _vec_map: Vec<_> = v869
                    .into_iter()
                    .map(|x| {
                        //;
                        let v873: Vec<char> = x;
                        let v875: std::string::String = String::from_iter(v873);
                        let v877: bool = true;
                        v875
                    })
                    .collect::<Vec<_>>();
                let v879: Vec<std::string::String> = _vec_map;
                if if v845.clone() != string("") {
                    v879.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v23.l0.set(v859);
                    ()
                } else {
                    v23.l0.set(string(""));
                    {
                        let v891: bool = true;
                        v879.into_iter().for_each(|x| {
                            //;
                            let v893: std::string::String = x;
                            near_sdk::log!("{}", v893);
                            {
                                let v896: bool = true;
                                let v898: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v845)
            }
        }
        pub fn closure82(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
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
            let v22: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v38: () = {
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
            let v70: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
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
                let v252: u64 = near_sdk::env::block_timestamp();
                let _v253: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v258: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v253 = _v253.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v253.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v273: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v253.get().clone());
                let v283: u64 = match &v273 {
                    Dice_contract::US3::US3_0(v273_0_0) => {
                        v252 - match &v273 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v252,
                } / 1000000000_u64;
                let v284: u64 = v283 % 60_u64;
                let v286: u64 = v283 / 60_u64 % 60_u64;
                let v288: u64 = v283 / 3600_u64 % 24_u64;
                let v290: std::string::String = format!("{:02}:{:02}:{:02}", v288, v286, v284);
                let v292: string = fable_library_rust::String_::fromString(v290);
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v610: &str = inline_colorization::color_bright_blue;
                let v612: &str = &*v572;
                let v614: &str = inline_colorization::color_reset;
                let v616: string = string("format!(\"{v610}{v612}{v614}\")");
                let v617: std::string::String = format!("{v610}{v612}{v614}");
                let v619: string = fable_library_rust::String_::fromString(v617);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v647: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v656: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("power")), ());
                    ()
                };
                let v665: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v673: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v682: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v691: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("acc")), ());
                    ()
                };
                let v699: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v707: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v715: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v724: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string("roll")), ());
                    ()
                };
                let v732: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v740: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v749: () = {
                    Dice_contract::closure9(v640.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v811: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v292,
                            v619,
                            v638,
                            string("dice.accumulate_dice_rolls"),
                            v640.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v825: string = if v22.l0.get().clone() == string("") {
                    v811.clone()
                } else {
                    if v811.clone() == string("") {
                        v22.l0.get().clone()
                    } else {
                        append(append(v22.l0.get().clone(), string("\n")), v811.clone())
                    }
                };
                let v827: &str = &*v825.clone();
                let v829 = v827.chars();
                let v831 = v829;
                let v833: Vec<char> = v831.collect::<Vec<_>>();
                let v835: Vec<Vec<char>> = v833
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v837: bool = true;
                let _vec_map: Vec<_> = v835
                    .into_iter()
                    .map(|x| {
                        //;
                        let v839: Vec<char> = x;
                        let v841: std::string::String = String::from_iter(v839);
                        let v843: bool = true;
                        v841
                    })
                    .collect::<Vec<_>>();
                let v845: Vec<std::string::String> = _vec_map;
                if if v811.clone() != string("") {
                    v845.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v22.l0.set(v825);
                    ()
                } else {
                    v22.l0.set(string(""));
                    {
                        let v857: bool = true;
                        v845.into_iter().for_each(|x| {
                            //;
                            let v859: std::string::String = x;
                            near_sdk::log!("{}", v859);
                            {
                                let v862: bool = true;
                                let v864: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v811)
            }
        }
        pub fn method11(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US4 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method11: loop {
                break '_method11 (if v0_1.get().clone() < 0_i8 {
                    let v4: u64 = v2.get().clone() + 1_u64;
                    let v7: () = {
                        Dice_contract::closure16(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US4::US4_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US4::US4_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v874: LrcPtr<Dice_contract::UH0> = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v873: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v873 > 1_u8 {
                                let v879: Dice_contract::US5 = Dice_contract::method12(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure17((), ())),
                                    )),
                                );
                                let v886: u64 = (v873 - 1_u8) as u64
                                    * match &v879 {
                                        Dice_contract::US5::US5_0(v879_0_0) => match &v879 {
                                            Dice_contract::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                let v889: () = {
                                    Dice_contract::closure81(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v873,
                                        v886,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v874;
                                    let v2_temp: u64 = v2.get().clone() + v886;
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method11;
                                }
                            } else {
                                let v1791: () = {
                                    Dice_contract::closure82(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v873,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v874.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method11;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure83(v0_1: u64, v1: LrcPtr<Dice_contract::UH0>, v2: Option<u64>, unitVar: ()) {
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
            let v22: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v38: () = {
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
            let v70: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
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
                let v252: u64 = near_sdk::env::block_timestamp();
                let _v253: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v258: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v253 = _v253.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v253.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v273: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v253.get().clone());
                let v283: u64 = match &v273 {
                    Dice_contract::US3::US3_0(v273_0_0) => {
                        v252 - match &v273 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v252,
                } / 1000000000_u64;
                let v284: u64 = v283 % 60_u64;
                let v286: u64 = v283 / 60_u64 % 60_u64;
                let v288: u64 = v283 / 3600_u64 % 24_u64;
                let v290: std::string::String = format!("{:02}:{:02}:{:02}", v288, v286, v284);
                let v292: string = fable_library_rust::String_::fromString(v290);
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v610: &str = inline_colorization::color_bright_blue;
                let v612: &str = &*v572;
                let v614: &str = inline_colorization::color_reset;
                let v616: string = string("format!(\"{v610}{v612}{v614}\")");
                let v617: std::string::String = format!("{v610}{v612}{v614}");
                let v619: string = fable_library_rust::String_::fromString(v617);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v639: string = sprintf!("{:?}", v1);
                let v643: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v650: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v659: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string("max")), ());
                    ()
                };
                let v668: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v676: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v685: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v694: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string("rolls")), ());
                    ()
                };
                let v702: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v710: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", v639), ());
                    ()
                };
                let v718: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v727: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v735: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v748: std::string::String = format!("{:#?}", v2);
                let v770: () = {
                    Dice_contract::closure9(
                        v643.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v748)),
                        (),
                    );
                    ()
                };
                let v779: () = {
                    Dice_contract::closure9(v643.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v821: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v292,
                            v619,
                            v638,
                            string("dice_contract.roll_within_bounds"),
                            v643.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v852: string = if v22.l0.get().clone() == string("") {
                    v821.clone()
                } else {
                    if v821.clone() == string("") {
                        v22.l0.get().clone()
                    } else {
                        append(append(v22.l0.get().clone(), string("\n")), v821.clone())
                    }
                };
                let v854: &str = &*v852.clone();
                let v856 = v854.chars();
                let v858 = v856;
                let v860: Vec<char> = v858.collect::<Vec<_>>();
                let v862: Vec<Vec<char>> = v860
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v864: bool = true;
                let _vec_map: Vec<_> = v862
                    .into_iter()
                    .map(|x| {
                        //;
                        let v866: Vec<char> = x;
                        let v868: std::string::String = String::from_iter(v866);
                        let v870: bool = true;
                        v868
                    })
                    .collect::<Vec<_>>();
                let v872: Vec<std::string::String> = _vec_map;
                if if v821.clone() != string("") {
                    v872.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v22.l0.set(v852);
                    ()
                } else {
                    v22.l0.set(string(""));
                    {
                        let v884: bool = true;
                        v872.into_iter().for_each(|x| {
                            //;
                            let v886: std::string::String = x;
                            near_sdk::log!("{}", v886);
                            {
                                let v889: bool = true;
                                let v891: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v821)
            }
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) {
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
            let v19: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v35: () = {
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
            let v67: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
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
                let v249: u64 = near_sdk::env::block_timestamp();
                let _v250: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v255: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v250 = _v250.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v250.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v270: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v250.get().clone());
                let v280: u64 = match &v270 {
                    Dice_contract::US3::US3_0(v270_0_0) => {
                        v249 - match &v270 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v249,
                } / 1000000000_u64;
                let v281: u64 = v280 % 60_u64;
                let v283: u64 = v280 / 60_u64 % 60_u64;
                let v285: u64 = v280 / 3600_u64 % 24_u64;
                let v287: std::string::String = format!("{:02}:{:02}:{:02}", v285, v283, v281);
                let v289: string = fable_library_rust::String_::fromString(v287);
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v607: &str = inline_colorization::color_bright_blue;
                let v609: &str = &*v569;
                let v611: &str = inline_colorization::color_reset;
                let v613: string = string("format!(\"{v607}{v609}{v611}\")");
                let v614: std::string::String = format!("{v607}{v609}{v611}");
                let v616: string = fable_library_rust::String_::fromString(v614);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v638: string = v637.l0.get().clone();
                let v653: string = if v19.l0.get().clone() == string("") {
                    string("")
                } else {
                    v19.l0.get().clone()
                };
                let v655: &str = &*v653;
                let v657 = v655.chars();
                let v659 = v657;
                let v661: Vec<char> = v659.collect::<Vec<_>>();
                let v663: Vec<Vec<char>> = v661
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v665: bool = true;
                let _vec_map: Vec<_> = v663
                    .into_iter()
                    .map(|x| {
                        //;
                        let v667: Vec<char> = x;
                        let v669: std::string::String = String::from_iter(v667);
                        let v671: bool = true;
                        v669
                    })
                    .collect::<Vec<_>>();
                let v673: Vec<std::string::String> = _vec_map;
                v19.l0.set(string(""));
                {
                    let v684: bool = true;
                    v673.into_iter().for_each(|x| {
                        //;
                        let v686: std::string::String = x;
                        near_sdk::log!("{}", v686);
                        {
                            let v689: bool = true;
                            let v691: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(string(""))
            }
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        pub struct Util {} //;
        impl Util {
            //;
            fn stream_u8_to_list(
                //;
                s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH0>, //;
            ) -> dice_contract_lib::Dice::UH1 {
                //;
                match s.as_ref() {
                    //;
                    dice_contract_lib::Dice::UH0::UH0_0(n, f) => {
                        //;
                        dice_contract_lib::Dice::UH1::UH1_1(
                            //;
                            *n,                                  //;
                            Self::stream_u8_to_list(f()).into(), //;
                        ) //;
                    } //;
                    dice_contract_lib::Dice::UH0::UH0_1 => dice_contract_lib::Dice::UH1::UH1_0, //;
                } //;
            } //;
            fn list_u8_to_vec(
                //;
                s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH1>, //;
            ) -> Vec<u8> {
                //;
                match s.as_ref() {
                    //;
                    dice_contract_lib::Dice::UH1::UH1_1(n, f) => {
                        //;
                        let mut v = Self::list_u8_to_vec(f.clone()); //;
                        v.insert(0, *n); //;
                        v //;
                    } //;
                    dice_contract_lib::Dice::UH1::UH1_0 => vec![], //;
                } //;
            } //;
            fn vec_u8_to_list(v: Vec<u8>) -> dice_contract_lib::Dice::UH1 {
                //;
                v.iter() //;
                    .rev() //;
                    .fold(dice_contract_lib::Dice::UH1::UH1_0, |acc, x| {
                        //;
                        dice_contract_lib::Dice::UH1::UH1_1(*x, acc.into()) //;
                    }) //;
            } //;
            fn vec_u8_to_stream(v: Vec<u8>) -> dice_contract_lib::Dice::UH0 {
                //;
                v.iter() //;
                    .rev() //;
                    .fold(dice_contract_lib::Dice::UH0::UH0_1, |acc, x| {
                        //;
                        dice_contract_lib::Dice::UH0::UH0_0(
                            //;
                            *x, //;
                            fable_library_rust::Native_::Func0::new(move || acc.clone().into()), //;
                        ) //;
                    }) //;
            } //;
        } //;
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
                let v63: */
            (u32, near_sdk::store::vec::Vector<u8>), /* =
                                                        defaultOf::<()>();
                                                     */
        );
        impl From<OldState> for State {
            //;
            fn from(old_state: OldState) -> Self {
                //;
                Self((old_state.version, old_state.seeds)) //;
            } //;
        } //;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[init] //;
            pub fn new() -> Self {
                // 1;
                {
                    let v77: bool = true; /*;
                                          let v78: */
                    () /* = defaultOf();
                    let v82: bool = true; */;
                    let v84: string = string("b\"seeds\"");
                    let v85: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (1_u32, near_sdk::store::vec::Vector::new(v85));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v92: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v94: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed(&mut self, seed: Vec<u8>) {
                //;
                {
                    let v99: &mut near_sdk::store::vec::Vector<u8> = &mut self.0 .1;
                    let v101: Vec<u8> = seed;
                    v99.extend(v101); //;
                    {
                        let v103: usize = 100_i32 as usize;
                        let v107: i32 = (v99.len() as i32) - v103 as i32;
                        if v107 > 0_i32 {
                            let v113: () = {
                                Dice_contract::closure1(v99.drain(0..v107 as u32).collect(), ());
                                ()
                            };
                            ()
                        }
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v918: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
              let v920: bool =
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
              let v928: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
              let v930: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v935: std::string::String = key;
                    let v937: std::string::String = proof;
                    let v939: u64 = max;
                    let v941: &near_sdk::store::vec::Vector<u8> = &self.0 .1;
                    let v943: Vec<u8> = v941.iter().map(|x| *x).collect::<Vec<u8>>();
                    let v945: Vec<u8> = near_sdk::env::random_seed();
                    let v947: u64 = near_sdk::env::block_timestamp();
                    let v949: u64 = near_sdk::env::block_height();
                    let v951: u64 = near_sdk::env::epoch_height();
                    let v953: near_token::NearToken = near_sdk::env::account_balance();
                    let v955: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v957: _ = v951.to_le_bytes();
                    let v959: Vec<u8> = v957.to_vec();
                    let v961: _ = v949.to_le_bytes();
                    let v963: Vec<u8> = v961.to_vec();
                    let v965: _ = v947.to_le_bytes();
                    let v967: Vec<u8> = v965.to_vec();
                    let v969: u128 = v953.clone().as_yoctonear();
                    let v971: _ = v969.to_le_bytes();
                    let v973: Vec<u8> = v971.to_vec();
                    let v975: &[u8] = v955.as_bytes();
                    let v982: Array<Vec<u8>> = new_array(&[
                        v945.clone(),
                        v943.clone(),
                        v959,
                        v963,
                        v967,
                        v973,
                        v975.to_vec(),
                        v937.clone().into_bytes(),
                        v935.clone().into_bytes(),
                    ]);
                    let v984: Vec<Vec<u8>> = v982.to_vec();
                    let v986: Vec<u8> = v984.concat();
                    let v988: usize = v986.clone().len();
                    let v990: Vec<u8> = near_sdk::env::keccak512(&v986);
                    self.contribute_seed(v990.clone()); //;
                    let hash_stream = Util::vec_u8_to_stream(v990.clone()); //;
                    let rolls_list =
                        Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)(
                            //;
                            hash_stream.into(), //;
                        )); //;
                    {
                        let v1000: () = {
                            Dice_contract::closure12(
                                v943,
                                v935,
                                v937,
                                v939,
                                v945,
                                v947,
                                v949,
                                v951,
                                v953,
                                v955,
                                v986,
                                v988,
                                v990,
                                Util::list_u8_to_vec(rolls_list.clone().into()),
                                (),
                            );
                            ()
                        };
                        let sequential_roll = //;
                                                    dice_contract_lib::Dice::create_sequential_roller(rolls_list.into()); //;
                        let result = dice_contract_lib::Dice::roll_progressively //;
                                                    (sequential_roll)(
                            true
                        )(max); //;
                        {
                            let v2360: () = {
                                Dice_contract::closure13((), ());
                                ()
                            };
                            let v3055: u64 = result as u64;
                            v3055 //;
                        } //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v3063: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 4uy;
              let v3065: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 4uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v3070: u64 = max;
                    let v3072: Vec<u8> = rolls;
                    let v3075: List<u8> =
                        ofArray(fable_library_rust::NativeArray_::array_from(v3072));
                    let v3081: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method9())(b0)(b1)
                        }),
                        v3075,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v3090: Dice_contract::US4 = Dice_contract::method11(
                        Dice_contract::method10(v3081.clone(), 0_i8) - 1_i8,
                        v3081.clone(),
                        0_u64,
                    );
                    let v3100: Dice_contract::US5 =
                        if let Dice_contract::US4::US4_0(v3090_0_0, v3090_0_1) = &v3090 {
                            let v3091: u64 = match &v3090 {
                                Dice_contract::US4::US4_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if if v3091 >= 1_u64 {
                                v3091 <= v3070
                            } else {
                                false
                            } {
                                Dice_contract::US5::US5_0(v3091)
                            } else {
                                Dice_contract::US5::US5_1
                            }
                        } else {
                            Dice_contract::US5::US5_1
                        };
                    let v3107: Option<u64> = match &v3100 {
                        Dice_contract::US5::US5_0(v3100_0_0) => Some(match &v3100 {
                            Dice_contract::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v3110: () = {
                        Dice_contract::closure83(v3070, v3081, v3107.clone(), ());
                        ()
                    };
                    let v4003: () = {
                        Dice_contract::closure84((), ());
                        ()
                    };
                    v3107 //;
                } //;
            } //;
        } /* c;
          {
              let v4702:
                      bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 10uy / n: 2uy;
              let v4704:
                      bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 10uy / n: 2uy;
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
              let v4717:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 12uy / n: 1uy;
              let v4719:
                      bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 12uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v4723: bool = true;
            {
                (); // ?? / i': 1uy / n: 13uy;
                let v4725: bool = true;
                {
                    (); // ?? / i': 2uy / n: 13uy;
                    let v4727: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 13uy;
                        let v4729: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 13uy;
                            let v4731: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 13uy;
                                let v4733: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 13uy;
                                    let v4735: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 13uy;
                                        let v4737: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 13uy;
                                            let v4739: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 13uy;
                                                let v4741: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 13uy;
                                                    let v4743: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 13uy;
                                                        let v4745: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 13uy;
                                                            let v4747: bool = true;
                                                            {
                                                                (); // ?? / i': 13uy / n: 13uy;
                                                                let v4749: bool = true;
                                                                {
                                                                    {
                                                                        (); // ? / i': 14uy / n: 13uy;
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
