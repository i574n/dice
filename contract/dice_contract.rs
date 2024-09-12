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
mod module_491a246d {
    pub mod Dice_contract {
        use super::*;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
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
        pub fn closure14(v0_1: u64, v1: Vec<u8>, unitVar: ()) {
            fn v3() {
                Dice_contract::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v21: LrcPtr<Dice_contract::Mut3> = patternInput.3.clone();
            let v37: () = {
                v3();
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
            let v69: Dice_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v69,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v77: () = {
                    Dice_contract::closure6(patternInput.0.clone(), ());
                    ()
                };
                let v81: () = {
                    v3();
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
                let v251: u64 = near_sdk::env::block_timestamp();
                let _v252: LrcPtr<MutCell<Option<Dice_contract::US3>>> =
                    refCell(None::<Dice_contract::US3>);
                let v257: () = {
                    Dice_contract::closure8(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v252 = _v252.clone();
                            move |v: Option<Dice_contract::US3>| {
                                Dice_contract::closure7(_v252.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v272: Dice_contract::US3 =
                    defaultValue(Dice_contract::US3::US3_1, _v252.get().clone());
                let v282: u64 = match &v272 {
                    Dice_contract::US3::US3_0(v272_0_0) => {
                        v251 - match &v272 {
                            Dice_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v251,
                } / 1000000000_u64;
                let v283: u64 = v282 % 60_u64;
                let v285: u64 = v282 / 60_u64 % 60_u64;
                let v287: u64 = v282 / 3600_u64 % 24_u64;
                let v289: std::string::String = format!("{:02}:{:02}:{:02}", v287, v285, v283);
                let v291: string = fable_library_rust::String_::fromString(v289);
                let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v609: &str = inline_colorization::color_bright_blue;
                let v611: &str = &*v571;
                let v613: &str = inline_colorization::color_reset;
                let v615: string = string("format!(\"{v609}{v611}{v613}\")");
                let v616: std::string::String = format!("{v609}{v611}{v613}");
                let v618: string = fable_library_rust::String_::fromString(v616);
                let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: string = sprintf!("{:?}", v1);
                let v642: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                    l0: MutCell::new(Dice_contract::method8()),
                });
                let v649: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v658: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", string("max")), ());
                    ()
                };
                let v667: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v675: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v684: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v693: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", string("rolls")), ());
                    ()
                };
                let v701: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v709: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", v638), ());
                    ()
                };
                let v718: () = {
                    Dice_contract::closure9(v642.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v780: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v291,
                            v618,
                            v637,
                            string("dice_contract.roll_within_bounds"),
                            v642.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v794: string = if v21.l0.get().clone() == string("") {
                    v780.clone()
                } else {
                    if v780.clone() == string("") {
                        v21.l0.get().clone()
                    } else {
                        append(append(v21.l0.get().clone(), string("\n")), v780.clone())
                    }
                };
                let v796: &str = &*v794.clone();
                let v798 = v796.chars();
                let v800 = v798;
                let v802: Vec<char> = v800.collect::<Vec<_>>();
                let v804: Vec<Vec<char>> = v802
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v806: bool = true;
                let _vec_map: Vec<_> = v804
                    .into_iter()
                    .map(|x| {
                        //;
                        let v808: Vec<char> = x;
                        let v810: std::string::String = String::from_iter(v808);
                        let v812: bool = true;
                        v810
                    })
                    .collect::<Vec<_>>();
                let v814: Vec<std::string::String> = _vec_map;
                if if v780.clone() != string("") {
                    v814.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v21.l0.set(v794);
                    ()
                } else {
                    v21.l0.set(string(""));
                    {
                        let v826: bool = true;
                        v814.into_iter().for_each(|x| {
                            //;
                            let v828: std::string::String = x;
                            near_sdk::log!("{}", v828);
                            {
                                let v831: bool = true;
                                let v833: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v780)
            }
        }
        pub fn closure15(unitVar: (), unitVar_1: ()) {
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
                        dice_contract_lib::Dice::UH1::UH1_1(*n, Self::stream_u8_to_list(f()).into())
                        //;
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
                let v60: */
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
                    let v74: bool = true; /*;
                                          let v75: */
                    () /* = defaultOf();
                    let v79: bool = true; */;
                    let v81: string = string("b\"seeds\"");
                    let v82: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (1_u32, near_sdk::store::vec::Vector::new(v82));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v89: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v91: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed(&mut self, seed: Vec<u8>) {
                //;
                {
                    let v96: &mut near_sdk::store::vec::Vector<u8> = &mut self.0 .1;
                    let v98: Vec<u8> = seed;
                    v96.extend(v98); //;
                    {
                        let v100: usize = 100_i32 as usize;
                        let v104: i32 = (v96.len() as i32) - v100 as i32;
                        if v104 > 0_i32 {
                            let v110: () = {
                                Dice_contract::closure1(v96.drain(0..v104 as u32).collect(), ());
                                ()
                            };
                            ()
                        }
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v915: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
              let v917: bool =
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
              let v925: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
              let v927: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v932: std::string::String = key;
                    let v934: std::string::String = proof;
                    let v936: u64 = max;
                    let v938: &near_sdk::store::vec::Vector<u8> = &self.0 .1;
                    let v940: Vec<u8> = v938.iter().map(|x| *x).collect::<Vec<u8>>();
                    let v942: Vec<u8> = near_sdk::env::random_seed();
                    let v944: u64 = near_sdk::env::block_timestamp();
                    let v946: u64 = near_sdk::env::block_height();
                    let v948: u64 = near_sdk::env::epoch_height();
                    let v950: near_token::NearToken = near_sdk::env::account_balance();
                    let v952: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v954: _ = v948.to_le_bytes();
                    let v956: Vec<u8> = v954.to_vec();
                    let v958: _ = v946.to_le_bytes();
                    let v960: Vec<u8> = v958.to_vec();
                    let v962: _ = v944.to_le_bytes();
                    let v964: Vec<u8> = v962.to_vec();
                    let v966: u128 = v950.clone().as_yoctonear();
                    let v968: _ = v966.to_le_bytes();
                    let v970: Vec<u8> = v968.to_vec();
                    let v972: &[u8] = v952.as_bytes();
                    let v979: Array<Vec<u8>> = new_array(&[
                        v942.clone(),
                        v940.clone(),
                        v956,
                        v960,
                        v964,
                        v970,
                        v972.to_vec(),
                        v934.clone().into_bytes(),
                        v932.clone().into_bytes(),
                    ]);
                    let v981: Vec<Vec<u8>> = v979.to_vec();
                    let v983: Vec<u8> = v981.concat();
                    let v985: usize = v983.clone().len();
                    let v987: Vec<u8> = near_sdk::env::keccak512(&v983);
                    self.contribute_seed(v987.clone()); //;
                    let hash_stream = Util::vec_u8_to_stream(v987.clone()); //;
                    let rolls_list =
                        Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)(
                            //;
                            hash_stream.into(), //;
                        )); //;
                    {
                        let v997: () = {
                            Dice_contract::closure12(
                                v940,
                                v932,
                                v934,
                                v936,
                                v942,
                                v944,
                                v946,
                                v948,
                                v950,
                                v952,
                                v983,
                                v985,
                                v987,
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
                            let v2357: () = {
                                Dice_contract::closure13((), ());
                                ()
                            };
                            let v3052: u64 = result as u64;
                            v3052 //;
                        } //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v3060: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 4uy;
              let v3062: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 4uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v3067: u64 = max;
                    let v3069: Vec<u8> = rolls;
                    let v3072: () = {
                        Dice_contract::closure14(v3067, v3069.clone(), ());
                        ()
                    };
                    let rolls = Util::vec_u8_to_list(v3069); //;
                    let result = //;
                                                                    dice_contract_lib::Dice::roll_within_bounds(max)(rolls.into()); //;
                    {
                        let v3911: () = {
                            Dice_contract::closure15((), ());
                            ()
                        };
                        let v4606: Option<u64> = result;
                        v4606 //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v4613:
                      bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 10uy / n: 3uy;
              let v4615:
                      bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 10uy / n: 3uy;
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
              let v4628:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 13uy / n: 1uy;
              let v4630:
                      bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 13uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v4634: bool = true;
            {
                (); // ?? / i': 1uy / n: 14uy;
                let v4636: bool = true;
                {
                    (); // ?? / i': 2uy / n: 14uy;
                    let v4638: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 14uy;
                        let v4640: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 14uy;
                            let v4642: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 14uy;
                                let v4644: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 14uy;
                                    let v4646: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 14uy;
                                        let v4648: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 14uy;
                                            let v4650: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 14uy;
                                                let v4652: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 14uy;
                                                    let v4654: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 14uy;
                                                        let v4656: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 14uy;
                                                            let v4658: bool = true;
                                                            {
                                                                (); // ?? / i': 13uy / n: 14uy;
                                                                let v4660: bool = true;
                                                                {
                                                                    (); // ?? / i': 14uy / n: 14uy;
                                                                    let v4662: bool = true;
                                                                    {
                                                                        {
                                                                            (); // ? / i': 15uy / n: 14uy;
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
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Dice_contract::closure0((), ())))
                .clone()
        }
        on_startup!(());
    }
}
pub use module_491a246d::*;
#[path = "../../polyglot/lib/fsharp/Common_contract.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../polyglot/lib/spiral/async__contract.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../polyglot/lib/spiral/common_contract.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../polyglot/lib/spiral/crypto_contract.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../polyglot/lib/spiral/date_time_contract.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../polyglot/lib/spiral/file_system_contract.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../polyglot/lib/spiral/lib_contract.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../polyglot/lib/spiral/networking_contract.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../polyglot/lib/spiral/platform_contract.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../polyglot/lib/spiral/runtime_contract.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../polyglot/lib/spiral/sm_contract.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../polyglot/lib/spiral/threading_contract.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../polyglot/lib/spiral/trace_contract.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
