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
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
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
        pub fn closure3(unitVar: (), v0_1: string) -> Dice_contract::US1 {
            Dice_contract::US1::US1_0(v0_1)
        }
        pub fn method4() -> Func1<string, Dice_contract::US1> {
            Func1::new(move |v: string| Dice_contract::closure3((), v))
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
        pub fn method5() -> string {
            string("AUTOMATION")
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
        pub fn closure5(unitVar: (), v0_1: i64) -> Dice_contract::US3 {
            Dice_contract::US3::US3_0(v0_1)
        }
        pub fn method7() -> Func1<i64, Dice_contract::US3> {
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
            let v130: u64 = near_sdk::env::block_timestamp();
            let v144: Dice_contract::US3 =
                defaultValue(Dice_contract::US3::US3_1, map(Dice_contract::method7(), v5));
            let v154: u64 = match &v144 {
                Dice_contract::US3::US3_0(v144_0_0) => {
                    v130 - match &v144 {
                        Dice_contract::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v130,
            } / 1000000000_u64;
            let v155: u64 = v154 % 60_u64;
            let v157: u64 = v154 / 60_u64 % 60_u64;
            let v159: u64 = v154 / 3600_u64 % 24_u64;
            let v161: std::string::String = format!("{:02}:{:02}:{:02}", v159, v157, v155);
            fable_library_rust::String_::fromString(v161)
        }
        pub fn method11() -> string {
            string("\u{001b}[0m")
        }
        pub fn method10() -> string {
            let v5: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v41: &str = inline_colorization::color_bright_blue;
            let v43: &str = &*v5;
            let v45: &str = inline_colorization::color_reset;
            let v47: std::string::String = format!("{}{}{}", v41, v43, v45);
            fable_library_rust::String_::fromString(v47)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure6(v0_1: LrcPtr<Dice_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method12(v0_1: string) -> string {
            let v2: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v9: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string("seed_excess")), ());
                ()
            };
            let v27: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Dice_contract::closure6(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14(v0_1: string, v1: string, v2: string, v3: i64, v4: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!("{} {} #{} {} / {}", v0_1, v1, v3, v2, v4),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure7(v0_1: LrcPtr<Dice_contract::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
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
        pub fn method15(
            v0_1: string,
            v1: LrcPtr<Dice_contract::Mut0>,
            v2: LrcPtr<Dice_contract::Mut1>,
            v3: LrcPtr<Dice_contract::Mut2>,
            v4: LrcPtr<Dice_contract::Mut3>,
            v5: LrcPtr<Dice_contract::Mut4>,
            v6: Option<i64>,
        ) {
            let v9: () = {
                Dice_contract::closure7(v1, ());
                ()
            };
            let v25: string = if v4.l0.get().clone() == string("") {
                v0_1.clone()
            } else {
                if v0_1.clone() == string("") {
                    v4.l0.get().clone()
                } else {
                    append(append(v4.l0.get().clone(), string("\n")), v0_1.clone())
                }
            };
            let v27: &str = &*v25.clone();
            let v29 = v27.chars();
            let v31 = v29;
            let v33: Vec<char> = v31.collect::<Vec<_>>();
            let v35: Vec<Vec<char>> = v33
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v37: bool = true;
            let _vec_map: Vec<_> = v35
                .into_iter()
                .map(|x| {
                    //;
                    let v39: Vec<char> = x;
                    let v41: std::string::String = String::from_iter(v39);
                    let v43: bool = true;
                    v41
                })
                .collect::<Vec<_>>();
            let v45: Vec<std::string::String> = _vec_map;
            if if v0_1.clone() != string("") {
                v45.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v4.l0.set(v25);
                ()
            } else {
                v4.l0.set(string(""));
                {
                    let v57: bool = true;
                    v45.into_iter().for_each(|x| {
                        //;
                        let v59: std::string::String = x;
                        let v61: bool = true;
                        near_sdk::log!("{}", v59);
                        let v63: bool = true;
                        let v65: bool = true;
                    }); //;
                    ()
                }
            }
            ();
            (v2.l0.get().clone())(v0_1)
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
            let v35: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
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
                let v56: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice_contract::method14(
                    Dice_contract::method6(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    string("dice_contract.contribute_seed"),
                    v56.l0.get().clone(),
                    Dice_contract::method12(sprintf!("{:?}", v0_1)),
                );
                let v87: () = {
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
                Dice_contract::method15(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method16(
            v0_1: u64,
            v1: std::string::String,
            v2: std::string::String,
            v3: u64,
            v4: u64,
            v5: u64,
            v6: string,
            v7: std::string::String,
            v8: string,
            v9: string,
            v10: usize,
            v11: string,
            v12: string,
            v13: string,
        ) -> string {
            let v15: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v22: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v31: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("max")), ());
                ()
            };
            let v40: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v48: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v57: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v66: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("key")), ());
                ()
            };
            let v74: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v87: std::string::String = format!("{:#?}", v1);
            let v109: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v87)),
                    (),
                );
                ()
            };
            let v117: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v126: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("proof")), ());
                ()
            };
            let v134: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v147: std::string::String = format!("{:#?}", v2);
            let v169: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v147)),
                    (),
                );
                ()
            };
            let v177: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v186: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("block_timestamp")), ());
                ()
            };
            let v194: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v202: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v210: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v219: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("block_height")), ());
                ()
            };
            let v227: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v235: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v4), ());
                ()
            };
            let v243: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v252: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("epoch_height")), ());
                ()
            };
            let v260: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v268: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v276: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v285: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("account_balance")), ());
                ()
            };
            let v293: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v301: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v6), ());
                ()
            };
            let v309: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v318: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", string("signer_account_id")),
                    (),
                );
                ()
            };
            let v326: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v339: std::string::String = format!("{:#?}", v7);
            let v361: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v339)),
                    (),
                );
                ()
            };
            let v369: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v378: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("seed")), ());
                ()
            };
            let v386: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v394: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v402: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v411: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("seeds")), ());
                ()
            };
            let v419: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v427: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v435: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v444: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("entropy_len")), ());
                ()
            };
            let v452: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v465: std::string::String = format!("{:#?}", v10);
            let v487: () = {
                Dice_contract::closure6(
                    v15.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v465)),
                    (),
                );
                ()
            };
            let v495: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v504: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("entropy")), ());
                ()
            };
            let v512: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v520: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v11), ());
                ()
            };
            let v528: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v537: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("hash_u8")), ());
                ()
            };
            let v545: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v553: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v12), ());
                ()
            };
            let v561: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v570: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string("rolls_list_log")), ());
                ()
            };
            let v578: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v586: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", v13), ());
                ()
            };
            let v595: () = {
                Dice_contract::closure6(v15.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v15.l0.get().clone()
        }
        pub fn closure10(
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
            let v48: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v48,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v55: () = {
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
                let v69: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v115: string = Dice_contract::method14(
                    Dice_contract::method6(
                        v69.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    string("dice_contract.generate_random_number"),
                    v69.l0.get().clone(),
                    Dice_contract::method16(
                        v3,
                        v1,
                        v2,
                        v5,
                        v6,
                        v7,
                        sprintf!("{:?}", v8),
                        v9.to_string(),
                        sprintf!("{:?}", v4),
                        sprintf!("{:?}", v0_1),
                        v11,
                        sprintf!("{:?}", v10),
                        sprintf!("{:?}", v12),
                        sprintf!("{:?}", v13),
                    ),
                );
                let v117: () = {
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
                Dice_contract::method15(
                    v115,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure11(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method17() -> Func0<()> {
            Func0::new(move || Dice_contract::closure11((), ()))
        }
        pub fn method18(
            v0_1: LrcPtr<Dice_contract::Mut0>,
            v1: LrcPtr<Dice_contract::Mut1>,
            v2: LrcPtr<Dice_contract::Mut2>,
            v3: LrcPtr<Dice_contract::Mut3>,
            v4: LrcPtr<Dice_contract::Mut4>,
            v5: Option<i64>,
        ) {
            let v8: () = {
                Dice_contract::closure7(v0_1, ());
                ()
            };
            let v25: string = if v3.l0.get().clone() == string("") {
                string("")
            } else {
                v3.l0.get().clone()
            };
            let v27: &str = &*v25;
            let v29 = v27.chars();
            let v31 = v29;
            let v33: Vec<char> = v31.collect::<Vec<_>>();
            let v35: Vec<Vec<char>> = v33
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v37: bool = true;
            let _vec_map: Vec<_> = v35
                .into_iter()
                .map(|x| {
                    //;
                    let v39: Vec<char> = x;
                    let v41: std::string::String = String::from_iter(v39);
                    let v43: bool = true;
                    v41
                })
                .collect::<Vec<_>>();
            let v45: Vec<std::string::String> = _vec_map;
            v3.l0.set(string(""));
            {
                let v56: bool = true;
                v45.into_iter().for_each(|x| {
                    //;
                    let v58: std::string::String = x;
                    let v60: bool = true;
                    near_sdk::log!("{}", v58);
                    let v62: bool = true;
                    let v64: bool = true;
                }); //;
                ()
            }
            ();
            (v1.l0.get().clone())(string(""))
        }
        pub fn closure12(v0_1: Func0<()>, unitVar: ()) {
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
            let v35: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
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
                let v74: string = Dice_contract::method6(
                    patternInput_1.0.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v75: string = Dice_contract::method10();
                let v77: () = {
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
                Dice_contract::method18(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure14(v0_1: u8, v1: LrcPtr<Dice_contract::UH0>) -> LrcPtr<Dice_contract::UH0> {
            LrcPtr::new(Dice_contract::UH0::UH0_1(v0_1, v1))
        }
        pub fn closure13(
            unitVar: (),
            v0_1: u8,
        ) -> Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_contract::UH0>| Dice_contract::closure14(v0_1, v)
            })
        }
        pub fn method19() -> Func1<u8, Func1<LrcPtr<Dice_contract::UH0>, LrcPtr<Dice_contract::UH0>>>
        {
            Func1::new(move |v: u8| Dice_contract::closure13((), v))
        }
        pub fn method20(v0_1: LrcPtr<Dice_contract::UH0>, v1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i8> = MutCell::new(v1);
            '_method20: loop {
                break '_method20 (match v0_1.get().clone().as_ref() {
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
                        continue '_method20;
                    }
                });
            }
        }
        pub fn method22(v0_1: i8, v1: u64, v2: u64) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn closure15(v0_1: u64, v1: i8, v2: u64, unitVar: ()) {
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
            let v37: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
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
                let v58: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice_contract::method14(
                    Dice_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice_contract::method22(v1, v0_1, v2),
                );
                let v86: () = {
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
                Dice_contract::method15(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_1)
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                9223372036854775808_u64,
                Func0::new(move || Dice_contract::closure79((), ())),
            ))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4611686018427387904_u64,
                Func0::new(move || Dice_contract::closure78((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6917529027641081856_u64,
                Func0::new(move || Dice_contract::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                1152921504606846976_u64,
                Func0::new(move || Dice_contract::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                15564440312192434176_u64,
                Func0::new(move || Dice_contract::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                11817445422220181504_u64,
                Func0::new(move || Dice_contract::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                5044031582654955520_u64,
                Func0::new(move || Dice_contract::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6989586621679009792_u64,
                Func0::new(move || Dice_contract::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16537217831704461312_u64,
                Func0::new(move || Dice_contract::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                11979575008805519360_u64,
                Func0::new(move || Dice_contract::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                14294425217273954304_u64,
                Func0::new(move || Dice_contract::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2382404202878992384_u64,
                Func0::new(move || Dice_contract::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6545982058383015936_u64,
                Func0::new(move || Dice_contract::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                10314369046585278464_u64,
                Func0::new(move || Dice_contract::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4793518853382471680_u64,
                Func0::new(move || Dice_contract::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3873377154515337216_u64,
                Func0::new(move || Dice_contract::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                645562859085889536_u64,
                Func0::new(move || Dice_contract::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                107593809847648256_u64,
                Func0::new(move || Dice_contract::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3092389647259533312_u64,
                Func0::new(move || Dice_contract::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                9738770311398031360_u64,
                Func0::new(move || Dice_contract::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16995415113324298240_u64,
                Func0::new(move || Dice_contract::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                8981483876790566912_u64,
                Func0::new(move || Dice_contract::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                13794743361938128896_u64,
                Func0::new(move || Dice_contract::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2299123893656354816_u64,
                Func0::new(move || Dice_contract::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3457644661227651072_u64,
                Func0::new(move || Dice_contract::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                576274110204608512_u64,
                Func0::new(move || Dice_contract::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6244960376270618624_u64,
                Func0::new(move || Dice_contract::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                13338656111851470848_u64,
                Func0::new(move || Dice_contract::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                14520938734448279552_u64,
                Func0::new(move || Dice_contract::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                14717985838214414336_u64,
                Func0::new(move || Dice_contract::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                5527454985320660992_u64,
                Func0::new(move || Dice_contract::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16293529225644736512_u64,
                Func0::new(move || Dice_contract::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                11938960241128898560_u64,
                Func0::new(move || Dice_contract::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                8138741398091333632_u64,
                Func0::new(move || Dice_contract::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                7505371590918406144_u64,
                Func0::new(move || Dice_contract::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16623181993244360704_u64,
                Func0::new(move || Dice_contract::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                8919445023443910656_u64,
                Func0::new(move || Dice_contract::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4561031516192243712_u64,
                Func0::new(move || Dice_contract::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                9983543956220149760_u64,
                Func0::new(move || Dice_contract::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                4738381338321616896_u64,
                Func0::new(move || Dice_contract::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                789730223053602816_u64,
                Func0::new(move || Dice_contract::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                131621703842267136_u64,
                Func0::new(move || Dice_contract::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                21936950640377856_u64,
                Func0::new(move || Dice_contract::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                3656158440062976_u64,
                Func0::new(move || Dice_contract::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                609359740010496_u64,
                Func0::new(move || Dice_contract::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                101559956668416_u64,
                Func0::new(move || Dice_contract::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                16926659444736_u64,
                Func0::new(move || Dice_contract::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2821109907456_u64,
                Func0::new(move || Dice_contract::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                470184984576_u64,
                Func0::new(move || Dice_contract::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                78364164096_u64,
                Func0::new(move || Dice_contract::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                13060694016_u64,
                Func0::new(move || Dice_contract::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                2176782336_u64,
                Func0::new(move || Dice_contract::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                362797056_u64,
                Func0::new(move || Dice_contract::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                60466176_u64,
                Func0::new(move || Dice_contract::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                10077696_u64,
                Func0::new(move || Dice_contract::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                1679616_u64,
                Func0::new(move || Dice_contract::closure24((), ())),
            ))
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                279936_u64,
                Func0::new(move || Dice_contract::closure23((), ())),
            ))
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                46656_u64,
                Func0::new(move || Dice_contract::closure22((), ())),
            ))
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                7776_u64,
                Func0::new(move || Dice_contract::closure21((), ())),
            ))
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                1296_u64,
                Func0::new(move || Dice_contract::closure20((), ())),
            ))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                216_u64,
                Func0::new(move || Dice_contract::closure19((), ())),
            ))
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                36_u64,
                Func0::new(move || Dice_contract::closure18((), ())),
            ))
        }
        pub fn closure16(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice_contract::UH1> {
            LrcPtr::new(Dice_contract::UH1::UH1_0(
                6_u64,
                Func0::new(move || Dice_contract::closure17((), ())),
            ))
        }
        pub fn method23(v0_1: i8, v1: LrcPtr<Dice_contract::UH1>) -> Dice_contract::US5 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH1>> = MutCell::new(v1.clone());
            '_method23: loop {
                break '_method23 (match v1.get().clone().as_ref() {
                    Dice_contract::UH1::UH1_1 => Dice_contract::US5::US5_1,
                    Dice_contract::UH1::UH1_0(v1_0_0, v1_0_1) => {
                        if v0_1.get().clone() <= 0_i8 {
                            Dice_contract::US5::US5_0(v1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                            let v1_temp: LrcPtr<Dice_contract::UH1> = (v1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            continue '_method23;
                        }
                    }
                });
            }
        }
        pub fn method24(v0_1: i8, v1: u64, v2: u8, v3: u64) -> string {
            let v5: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v12: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v30: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v64: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v80: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v97: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string("value")), ());
                ()
            };
            let v130: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v147: () = {
                Dice_contract::closure6(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn closure80(v0_1: u64, v1: i8, v2: u8, v3: u64, unitVar: ()) {
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
            let v38: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
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
                let v59: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v85: string = Dice_contract::method14(
                    Dice_contract::method6(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    string("dice.accumulate_dice_rolls"),
                    v59.l0.get().clone(),
                    Dice_contract::method24(v1, v0_1, v2, v3),
                );
                let v87: () = {
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
                Dice_contract::method15(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method25(v0_1: i8, v1: u64, v2: u8) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("power")), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("acc")), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("roll")), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn closure81(v0_1: u64, v1: i8, v2: u8, unitVar: ()) {
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
            let v37: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
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
                let v58: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v84: string = Dice_contract::method14(
                    Dice_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    string("dice.accumulate_dice_rolls"),
                    v58.l0.get().clone(),
                    Dice_contract::method25(v1, v0_1, v2),
                );
                let v86: () = {
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
                Dice_contract::method15(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method21(v0_1: i8, v1: LrcPtr<Dice_contract::UH0>, v2: u64) -> Dice_contract::US4 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1: MutCell<LrcPtr<Dice_contract::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<u64> = MutCell::new(v2);
            '_method21: loop {
                break '_method21 (if v0_1.get().clone() < 0_i8 {
                    let v4: u64 = v2.get().clone() + 1_u64;
                    let v7: () = {
                        Dice_contract::closure15(v2.get().clone(), v0_1.get().clone(), v4, ());
                        ()
                    };
                    Dice_contract::US4::US4_0(v4, v1.get().clone())
                } else {
                    match v1.get().clone().as_ref() {
                        Dice_contract::UH0::UH0_0 => Dice_contract::US4::US4_1,
                        Dice_contract::UH0::UH0_1(v1_1_0, v1_1_1) => {
                            let v126: LrcPtr<Dice_contract::UH0> = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v125: u8 = match v1.get().clone().as_ref() {
                                Dice_contract::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v125 > 1_u8 {
                                let v131: Dice_contract::US5 = Dice_contract::method23(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice_contract::UH1::UH1_0(
                                        1_u64,
                                        Func0::new(move || Dice_contract::closure16((), ())),
                                    )),
                                );
                                let v138: u64 = (v125 - 1_u8) as u64
                                    * match &v131 {
                                        Dice_contract::US5::US5_0(v131_0_0) => match &v131 {
                                            Dice_contract::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                let v141: () = {
                                    Dice_contract::closure80(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v125,
                                        v138,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v126;
                                    let v2_temp: u64 = v2.get().clone() + v138;
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method21;
                                }
                            } else {
                                let v262: () = {
                                    Dice_contract::closure81(
                                        v2.get().clone(),
                                        v0_1.get().clone(),
                                        v125,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                                    let v1_temp: LrcPtr<Dice_contract::UH0> = v126.clone();
                                    let v2_temp: u64 = v2.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    continue '_method21;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method26(v0_1: u64, v1: string, v2: Option<u64>) -> string {
            let v4: LrcPtr<Dice_contract::Mut3> = LrcPtr::new(Dice_contract::Mut3 {
                l0: MutCell::new(Dice_contract::method13()),
            });
            let v11: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("max")), ());
                ()
            };
            let v29: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("rolls")), ());
                ()
            };
            let v63: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v109: std::string::String = format!("{:#?}", v2);
            let v131: () = {
                Dice_contract::closure6(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v109)),
                    (),
                );
                ()
            };
            let v140: () = {
                Dice_contract::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method27(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("dice_contract.roll_within_bounds"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure82(v0_1: u64, v1: Vec<u8>, v2: Option<u64>, unitVar: ()) {
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
            let v37: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
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
                let v58: LrcPtr<Dice_contract::Mut0> = patternInput_1.0.clone();
                let v83: string = Dice_contract::method27(
                    Dice_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Dice_contract::method10(),
                    v58.l0.get().clone(),
                    Dice_contract::method26(v0_1, sprintf!("{:?}", v1), v2),
                );
                let v85: () = {
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
                Dice_contract::method15(
                    v83,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method28() -> Func0<()> {
            Func0::new(move || Dice_contract::closure11((), ()))
        }
        pub fn closure83(v0_1: Func0<()>, unitVar: ()) {
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
            let v35: Dice_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Dice_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Dice_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
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
                let v74: string = Dice_contract::method6(
                    patternInput_1.0.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v75: string = Dice_contract::method10();
                let v77: () = {
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
                Dice_contract::method18(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
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
                    let v77: bool = true; /*;
                                          let v78: */
                    () /* = defaultOf();
                    let v82: bool = true; */;
                    let v84: string = string("b\"seeds\"");
                    let v85: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (2_u32, near_sdk::store::vec::Vector::new(v85));
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
              let v237: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
              let v239: bool =
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
              let v247: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
              let v249: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v254: std::string::String = key;
                    let v256: std::string::String = proof;
                    let v258: u64 = max;
                    let v260: &near_sdk::store::vec::Vector<u8> = &self.0 .1;
                    let v262: Vec<u8> = v260.iter().map(|x| *x).collect::<Vec<u8>>();
                    let v264: Vec<u8> = near_sdk::env::random_seed();
                    let v266: u64 = near_sdk::env::block_timestamp();
                    let v268: u64 = near_sdk::env::block_height();
                    let v270: u64 = near_sdk::env::epoch_height();
                    let v272: near_token::NearToken = near_sdk::env::account_balance();
                    let v274: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v276: _ = v270.to_le_bytes();
                    let v278: Vec<u8> = v276.to_vec();
                    let v280: _ = v268.to_le_bytes();
                    let v282: Vec<u8> = v280.to_vec();
                    let v284: _ = v266.to_le_bytes();
                    let v286: Vec<u8> = v284.to_vec();
                    let v288: u128 = v272.clone().as_yoctonear();
                    let v290: _ = v288.to_le_bytes();
                    let v292: Vec<u8> = v290.to_vec();
                    let v294: &[u8] = v274.as_bytes();
                    let v301: Array<Vec<u8>> = new_array(&[
                        v264.clone(),
                        v262.clone(),
                        v278,
                        v282,
                        v286,
                        v292,
                        v294.to_vec(),
                        v256.clone().into_bytes(),
                        v254.clone().into_bytes(),
                    ]);
                    let v303: Vec<Vec<u8>> = v301.to_vec();
                    let v305: Vec<u8> = v303.concat();
                    let v307: usize = v305.clone().len();
                    let v309: Vec<u8> = near_sdk::env::keccak512(&v305);
                    self.contribute_seed(v309.clone()); //;
                    let hash_stream = Util::vec_u8_to_stream(v309.clone()); //;
                    let rolls_list =
                        Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)(
                            //;
                            hash_stream.into(), //;
                        )); //;
                    {
                        let v319: () = {
                            Dice_contract::closure10(
                                v262,
                                v254,
                                v256,
                                v258,
                                v264,
                                v266,
                                v268,
                                v270,
                                v272,
                                v274,
                                v305,
                                v307,
                                v309,
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
                            let v462: () = {
                                Dice_contract::closure12(Dice_contract::method17(), ());
                                ()
                            };
                            let v572: u64 = result as u64;
                            v572 //;
                        } //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v580: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 4uy;
              let v582: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 4uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                {
                    let v587: u64 = max;
                    let v589: Vec<u8> = rolls;
                    let v592: List<u8> =
                        ofArray(fable_library_rust::NativeArray_::array_from(v589.clone()));
                    let v598: LrcPtr<Dice_contract::UH0> = foldBack(
                        Func2::new(move |b0: u8, b1: LrcPtr<Dice_contract::UH0>| {
                            (Dice_contract::method19())(b0)(b1)
                        }),
                        v592,
                        LrcPtr::new(Dice_contract::UH0::UH0_0),
                    );
                    let v607: Dice_contract::US4 = Dice_contract::method21(
                        Dice_contract::method20(v598.clone(), 0_i8) - 1_i8,
                        v598,
                        0_u64,
                    );
                    let v617: Dice_contract::US5 =
                        if let Dice_contract::US4::US4_0(v607_0_0, v607_0_1) = &v607 {
                            let v608: u64 = match &v607 {
                                Dice_contract::US4::US4_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if if v608 >= 1_u64 { v608 <= v587 } else { false } {
                                Dice_contract::US5::US5_0(v608)
                            } else {
                                Dice_contract::US5::US5_1
                            }
                        } else {
                            Dice_contract::US5::US5_1
                        };
                    let v624: Option<u64> = match &v617 {
                        Dice_contract::US5::US5_0(v617_0_0) => Some(match &v617 {
                            Dice_contract::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<u64>,
                    };
                    let v627: () = {
                        Dice_contract::closure82(v587, v589, v624.clone(), ());
                        ()
                    };
                    let v745: () = {
                        Dice_contract::closure83(Dice_contract::method28(), ());
                        ()
                    };
                    v624 //;
                } //;
            } //;
        } /* c;
          {
              let v859:
                      bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 10uy / n: 2uy;
              let v861:
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
              let v874:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 12uy / n: 1uy;
              let v876:
                      bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 12uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v880: bool = true;
            {
                (); // ?? / i': 1uy / n: 13uy;
                let v882: bool = true;
                {
                    (); // ?? / i': 2uy / n: 13uy;
                    let v884: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 13uy;
                        let v886: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 13uy;
                            let v888: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 13uy;
                                let v890: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 13uy;
                                    let v892: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 13uy;
                                        let v894: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 13uy;
                                            let v896: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 13uy;
                                                let v898: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 13uy;
                                                    let v900: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 13uy;
                                                        let v902: bool = true;
                                                        {
                                                            (); // ?? / i': 12uy / n: 13uy;
                                                            let v904: bool = true;
                                                            {
                                                                (); // ?? / i': 13uy / n: 13uy;
                                                                let v906: bool = true;
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
