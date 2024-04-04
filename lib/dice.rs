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
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        #[derive(Clone, Debug)]
        pub enum UH0 {
            UH0_0(u8, Func0<LrcPtr<Dice::UH0>>),
            UH0_1,
        }
        impl Dice::UH0 {
            pub fn get_IsUH0_0(this_: LrcPtr<Dice::UH0>, unitArg: ()) -> bool {
                if let Dice::UH0::UH0_0(this__0_0, this__0_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH0_1(this_: LrcPtr<Dice::UH0>, unitArg: ()) -> bool {
                if let Dice::UH0::UH0_1 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
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
        impl Dice::UH1 {
            pub fn get_IsUH1_0(this_: LrcPtr<Dice::UH1>, unitArg: ()) -> bool {
                if let Dice::UH1::UH1_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH1_1(this_: LrcPtr<Dice::UH1>, unitArg: ()) -> bool {
                if let Dice::UH1::UH1_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(Func1<string, ()>),
            US0_1,
        }
        impl Dice::US0 {
            pub fn get_IsUS0_0(this_: &MutCell<Dice::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_1(this_: &MutCell<Dice::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US1 {
            US1_0(Func0<LrcPtr<Dice::UH0>>),
            US1_1(LrcPtr<Dice::UH0>),
        }
        impl Dice::US1 {
            pub fn get_IsUS1_0(this_: &MutCell<Dice::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_1(this_: &MutCell<Dice::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut0 {
            pub l0: MutCell<Dice::US1>,
        }
        impl core::fmt::Display for Dice::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut1 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Dice::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(u8),
            US2_1,
        }
        impl Dice::US2 {
            pub fn get_IsUS2_0(this_: &MutCell<Dice::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS2_1(this_: &MutCell<Dice::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<Dice::US2>,
        }
        impl core::fmt::Display for Dice::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(u64, LrcPtr<Dice::UH1>),
            US3_1,
        }
        impl Dice::US3 {
            pub fn get_IsUS3_0(this_: &MutCell<Dice::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS3_1(this_: &MutCell<Dice::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH2 {
            UH2_0(u64, Func0<LrcPtr<Dice::UH2>>),
            UH2_1,
        }
        impl Dice::UH2 {
            pub fn get_IsUH2_0(this_: LrcPtr<Dice::UH2>, unitArg: ()) -> bool {
                if let Dice::UH2::UH2_0(this__0_0, this__0_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH2_1(this_: LrcPtr<Dice::UH2>, unitArg: ()) -> bool {
                if let Dice::UH2::UH2_1 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(u64),
            US4_1,
        }
        impl Dice::US4 {
            pub fn get_IsUS4_0(this_: &MutCell<Dice::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS4_1(this_: &MutCell<Dice::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(i64, LrcPtr<Dice::UH1>),
            US5_1,
        }
        impl Dice::US5 {
            pub fn get_IsUS5_0(this_: &MutCell<Dice::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS5_1(this_: &MutCell<Dice::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice::US5 {
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
        pub fn closure4(unitVar: (), v0_1: Func1<string, ()>) -> Dice::US0 {
            Dice::US0::US0_0(v0_1)
        }
        pub fn method1() -> Func1<Func1<string, ()>, Dice::US0> {
            Func1::new(move |v: Func1<string, ()>| Dice::closure4((), v))
        }
        pub fn method2(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            '_method2: loop {
                break '_method2 (match v0_1.get().clone().as_ref() {
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
                        continue '_method2;
                    }
                });
            }
        }
        pub fn method3(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => LrcPtr::new(Dice::UH1::UH1_1(
                    match v0_1.as_ref() {
                        Dice::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Dice::method3(
                        match v0_1.as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn closure6(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn method4(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => v1_1.clone(),
                Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: LrcPtr<Dice::UH0> = Dice::method4(
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
                            move || Dice::closure6(v4_1.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure7(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn closure8(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: LrcPtr<Dice::Mut0>,
            unitVar: (),
        ) -> LrcPtr<Dice::UH0> {
            let v2_1: Dice::US1 = v1_1.l0.get().clone();
            match &v2_1 {
                Dice::US1::US1_0(v2_1_0_0) => {
                    let v5: LrcPtr<Dice::UH0> = (v2_1_0_0)();
                    let v12: LrcPtr<Dice::UH0> = match v5.as_ref() {
                        Dice::UH0::UH0_1 => LrcPtr::new(Dice::UH0::UH0_1),
                        Dice::UH0::UH0_0(v5_0_0, v5_0_1) => LrcPtr::new(Dice::UH0::UH0_0(
                            v5_0_0.clone(),
                            Dice::method5(v0_1, v5_0_1.clone()),
                        )),
                    };
                    v1_1.l0.set(Dice::US1::US1_1(v12.clone()));
                    v12
                }
                Dice::US1::US1_1(v2_1_1_0) => v2_1_1_0.clone(),
            }
        }
        pub fn method5(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
        ) -> Func0<LrcPtr<Dice::UH0>> {
            let v3_1: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(Dice::US1::US1_0(v1_1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3_1 = v3_1.clone();
                move || Dice::closure8(v0_1.clone(), v3_1.clone(), ())
            })
        }
        pub fn method7(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> Dice::US2 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1_1.clone());
            '_method7: loop {
                break '_method7 (match v1_1.get().clone().as_ref() {
                    Dice::UH0::UH0_1 => Dice::US2::US2_1,
                    Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get().clone() <= 0_i64 {
                            Dice::US2::US2_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = v0_1.get().clone() - 1_i64;
                            let v1_1_temp: LrcPtr<Dice::UH0> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method7;
                        }
                    }
                });
            }
        }
        pub fn method6(
            v0_1: Dice::US0,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
            v2_1: LrcPtr<Dice::Mut1>,
            v3_1: LrcPtr<Dice::Mut1>,
            v4_1: LrcPtr<Dice::Mut1>,
            v5: LrcPtr<Dice::Mut2>,
        ) -> u8 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1 = MutCell::new(v1_1.clone());
            let v2_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v2_1.clone());
            let v3_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v3_1.clone());
            let v4_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v4_1.clone());
            let v5: MutCell<LrcPtr<Dice::Mut2>> = MutCell::new(v5.clone());
            '_method6: loop {
                break '_method6 ({
                    let v10: string =
                                 sprintf!("create_sequential_roller / roll / current_index: {} / acc: {} / len: {} / last_item: {:?}",
                                          v2_1.l0.get().clone(),
                                          v3_1.l0.get().clone(),
                                          v4_1.l0.get().clone(),
                                          v5.l0.get().clone());
                    match &v0_1.get().clone() {
                        Dice::US0::US0_0(v0_1_0_0) => (match &v0_1.get().clone() {
                            Dice::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        })(v10),
                        _ => (),
                    }
                    {
                        let v12: LrcPtr<Dice::UH0> = v1_1();
                        let v14: Dice::US2 = Dice::method7(v2_1.l0.get().clone(), v12);
                        match &v14 {
                            Dice::US2::US2_0(v14_0_0) => {
                                let v15: u8 = match &v14 {
                                    Dice::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v17: i64 = v2_1.l0.get().clone() + 1_i64;
                                v2_1.l0.set(v17);
                                v5.l0.set(Dice::US2::US2_0(v15));
                                v15
                            }
                            _ => {
                                match &v0_1.get().clone() {
                                    Dice::US0::US0_0(v0_1_0_0) => (match &v0_1.get().clone() {
                                        Dice::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })(
                                        string("create_sequential_roller / roll / None"),
                                    ),
                                    _ => (),
                                }
                                if v4_1.l0.get().clone() == -1_i64 {
                                    let v23: i64 = v2_1.l0.get().clone();
                                    v4_1.l0.set(v23);
                                    ()
                                }
                                {
                                    let v29: i64 = if v3_1.l0.get().clone() >= v4_1.l0.get().clone()
                                    {
                                        1_i64
                                    } else {
                                        v3_1.l0.get().clone() + 1_i64
                                    };
                                    v3_1.l0.set(v29);
                                    {
                                        let v31: i64 = v3_1.l0.get().clone() - 1_i64;
                                        v2_1.l0.set(v31);
                                        v5.l0.set(Dice::US2::US2_1);
                                        {
                                            let v0_1_temp: Dice::US0 = v0_1.get().clone();
                                            let v1_1_temp = v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Dice::Mut1> = v2_1.get().clone();
                                            let v3_1_temp: LrcPtr<Dice::Mut1> = v3_1.get().clone();
                                            let v4_1_temp: LrcPtr<Dice::Mut1> = v4_1.get().clone();
                                            let v5_temp: LrcPtr<Dice::Mut2> = v5.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            v5.set(v5_temp);
                                            continue '_method6;
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure9(
            v0_1: Dice::US0,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
            v2_1: LrcPtr<Dice::Mut1>,
            v3_1: LrcPtr<Dice::Mut1>,
            v4_1: LrcPtr<Dice::Mut1>,
            v5: LrcPtr<Dice::Mut2>,
            unitVar: (),
        ) -> u8 {
            Dice::method6(v0_1, v1_1, v2_1, v3_1, v4_1, v5)
        }
        pub fn closure5(v0_1: Dice::US0, v1_1: LrcPtr<Dice::UH1>) -> Func0<u8> {
            match &v0_1 {
                Dice::US0::US0_0(v0_1_0_0) => {
                    (match &v0_1 {
                        Dice::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    })(string("create_sequential_roller ()"))
                }
                _ => (),
            }
            {
                let v8: LrcPtr<Dice::UH0> = Dice::method4(
                    Dice::method3(
                        v1_1.clone(),
                        Dice::method2(v1_1, LrcPtr::new(Dice::UH1::UH1_0)),
                    ),
                    LrcPtr::new(Dice::UH0::UH0_1),
                );
                let v10 = Dice::method5(
                    v8.clone(),
                    Func0::new({
                        let v8 = v8.clone();
                        move || Dice::closure7(v8.clone(), ())
                    }),
                );
                let v11: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(0_i64),
                });
                let v12: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(1_i64),
                });
                let v13: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(-1_i64),
                });
                let v15: LrcPtr<Dice::Mut2> = LrcPtr::new(Dice::Mut2 {
                    l0: MutCell::new(Dice::US2::US2_1),
                });
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v10 = v10.clone();
                    let v11 = v11.clone();
                    let v12 = v12.clone();
                    let v13 = v13.clone();
                    let v15 = v15.clone();
                    move || {
                        Dice::closure9(
                            v0_1.clone(),
                            v10.clone(),
                            v11.clone(),
                            v12.clone(),
                            v13.clone(),
                            v15.clone(),
                            (),
                        )
                    }
                })
            }
        }
        pub fn closure3(
            unitVar: (),
            v0_1: Option<Func1<string, ()>>,
        ) -> Func1<LrcPtr<Dice::UH1>, Func0<u8>> {
            let v3_1: Dice::US0 = defaultValue(Dice::US0::US0_1, map(Dice::method1(), v0_1));
            Func1::new({
                let v3_1 = v3_1.clone();
                move |v: LrcPtr<Dice::UH1>| Dice::closure5(v3_1.clone(), v)
            })
        }
        pub fn method8(v0_1: Dice::US0, v1_1: u64, v2_1: i8, v3_1: u64) -> i8 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u64> = MutCell::new(v1_1);
            let v2_1: MutCell<i8> = MutCell::new(v2_1);
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            '_method8: loop {
                break '_method8 (if v3_1.get().clone() < v1_1.get().clone() {
                    let v5: u64 = v3_1.get().clone() * 6_u64;
                    if v5 > v3_1.get().clone() {
                        let v0_1_temp: Dice::US0 = v0_1.get().clone();
                        let v1_1_temp: u64 = v1_1.get().clone();
                        let v2_1_temp: i8 = v2_1.get().clone() + 1_i8;
                        let v3_1_temp: u64 = v5;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        continue '_method8;
                    } else {
                        let v9: string = sprintf!(
                            "calculate_dice_count / max: {} / n: {} / p: {}",
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            v3_1.get().clone()
                        );
                        match &v0_1.get().clone() {
                            Dice::US0::US0_0(v0_1_0_0) => (match &v0_1.get().clone() {
                                Dice::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            })(v9),
                            _ => (),
                        }
                        v2_1.get().clone()
                    }
                } else {
                    let v12: string = sprintf!(
                        "calculate_dice_count / max: {} / n: {} / p: {}",
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone()
                    );
                    match &v0_1.get().clone() {
                        Dice::US0::US0_0(v0_1_0_0) => (match &v0_1.get().clone() {
                            Dice::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        })(v12),
                        _ => (),
                    }
                    v2_1.get().clone()
                });
            }
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                0_u64,
                Func0::new(move || Dice::closure77((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice::closure24((), ())),
            ))
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice::closure23((), ())),
            ))
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice::closure22((), ())),
            ))
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice::closure21((), ())),
            ))
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice::closure20((), ())),
            ))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice::closure19((), ())),
            ))
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice::closure18((), ())),
            ))
        }
        pub fn closure16(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice::closure17((), ())),
            ))
        }
        pub fn closure15(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice::closure16((), ())),
            ))
        }
        pub fn closure14(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice::closure15((), ())),
            ))
        }
        pub fn method11(v0_1: i8, v1_1: LrcPtr<Dice::UH2>) -> Dice::US4 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH2>> = MutCell::new(v1_1.clone());
            '_method11: loop {
                break '_method11 (match v1_1.get().clone().as_ref() {
                    Dice::UH2::UH2_1 => Dice::US4::US4_1,
                    Dice::UH2::UH2_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get().clone() <= 0_i8 {
                            Dice::US4::US4_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = v0_1.get().clone() - 1_i8;
                            let v1_1_temp: LrcPtr<Dice::UH2> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method11;
                        }
                    }
                });
            }
        }
        pub fn method10(
            v0_1: Dice::US0,
            v1_1: i8,
            v2_1: LrcPtr<Dice::UH1>,
            v3_1: u64,
        ) -> Dice::US3 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            let v2_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v2_1.clone());
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            '_method10: loop {
                break '_method10 (if v1_1.get().clone() < 0_i8 {
                    let v5: u64 = v3_1.get().clone() + 1_u64;
                    let v6: string = sprintf!(
                        "accumulate_dice_rolls / power: {} / acc: {} / result: {}",
                        v1_1.get().clone(),
                        v3_1.get().clone(),
                        v5
                    );
                    match &v0_1.get().clone() {
                        Dice::US0::US0_0(v0_1_0_0) => (match &v0_1.get().clone() {
                            Dice::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        })(v6),
                        _ => (),
                    }
                    Dice::US3::US3_0(v5, v2_1.get().clone())
                } else {
                    match v2_1.get().clone().as_ref() {
                        Dice::UH1::UH1_0 => Dice::US3::US3_1,
                        Dice::UH1::UH1_1(v2_1_1_0, v2_1_1_1) => {
                            let v11: LrcPtr<Dice::UH1> = match v2_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v10: u8 = match v2_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v10 > 1_u8 {
                                let v16: Dice::US4 = Dice::method11(
                                    v1_1.get().clone(),
                                    LrcPtr::new(Dice::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice::closure14((), ())),
                                    )),
                                );
                                let v23: u64 = (v10 - 1_u8) as u64
                                    * match &v16 {
                                        Dice::US4::US4_0(v16_0_0) => match &v16 {
                                            Dice::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                let v24: string =
                                             sprintf!("accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                                                      v1_1.get().clone(),
                                                      v3_1.get().clone(), v10,
                                                      v23);
                                match &v0_1.get().clone() {
                                    Dice::US0::US0_0(v0_1_0_0) => {
                                        (match &v0_1.get().clone() {
                                            Dice::US0::US0_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })(v24)
                                    }
                                    _ => (),
                                }
                                {
                                    let v0_1_temp: Dice::US0 = v0_1.get().clone();
                                    let v1_1_temp: i8 = v1_1.get().clone() - 1_i8;
                                    let v2_1_temp: LrcPtr<Dice::UH1> = v11;
                                    let v3_1_temp: u64 = v3_1.get().clone() + v23;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method10;
                                }
                            } else {
                                let v29: string = sprintf!(
                                    "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                                    v1_1.get().clone(),
                                    v3_1.get().clone(),
                                    v10
                                );
                                match &v0_1.get().clone() {
                                    Dice::US0::US0_0(v0_1_0_0) => {
                                        (match &v0_1.get().clone() {
                                            Dice::US0::US0_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })(v29)
                                    }
                                    _ => (),
                                }
                                {
                                    let v0_1_temp: Dice::US0 = v0_1.get().clone();
                                    let v1_1_temp: i8 = v1_1.get().clone() - 1_i8;
                                    let v2_1_temp: LrcPtr<Dice::UH1> = v11.clone();
                                    let v3_1_temp: u64 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method10;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method12(v0_1: i8, v1_1: Func0<u8>, v2_1: i8) -> LrcPtr<Dice::UH1> {
            if v2_1 < v0_1 {
                LrcPtr::new(Dice::UH1::UH1_1(
                    v1_1(),
                    Dice::method12(v0_1, v1_1, v2_1 + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice::UH1::UH1_0)
            }
        }
        pub fn method13(
            v0_1: Dice::US0,
            v1_1: Func0<u8>,
            v2_1: bool,
            v3_1: u64,
            v4_1: i8,
            v5: LrcPtr<Dice::UH1>,
        ) -> u64 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1 = MutCell::new(v1_1.clone());
            let v2_1: MutCell<bool> = MutCell::new(v2_1);
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            let v4_1: MutCell<i8> = MutCell::new(v4_1);
            let v5: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v5.clone());
            '_method13: loop {
                break '_method13 ({
                    let v6: i8 = v4_1.get().clone() + 1_i8;
                    if v4_1.get().clone() < v6 {
                        Dice::method9(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            v4_1.get().clone(),
                            LrcPtr::new(Dice::UH1::UH1_1(v1_1(), v5.get().clone())),
                            v6,
                        )
                    } else {
                        let v12: Dice::US3 = Dice::method10(
                            v0_1.get().clone(),
                            v4_1.get().clone(),
                            v5.get().clone(),
                            0_u64,
                        );
                        if let Dice::US3::US3_0(v12_0_0, v12_0_1) = &v12 {
                            let v13: u64 = match &v12 {
                                Dice::US3::US3_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v13 <= v3_1.get().clone() {
                                v13
                            } else {
                                if v2_1.get().clone() {
                                    let v0_1_temp: Dice::US0 = v0_1.get().clone();
                                    let v1_1_temp = v1_1.get().clone();
                                    let v2_1_temp: bool = v2_1.get().clone();
                                    let v3_1_temp: u64 = v3_1.get().clone();
                                    let v4_1_temp: i8 = v4_1.get().clone();
                                    let v5_temp: LrcPtr<Dice::UH1> = Dice::method12(
                                        v4_1.get().clone(),
                                        v1_1.get().clone(),
                                        0_i8,
                                    );
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    v5.set(v5_temp);
                                    continue '_method13;
                                } else {
                                    Dice::method9(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v2_1.get().clone(),
                                        v3_1.get().clone(),
                                        v4_1.get().clone(),
                                        LrcPtr::new(Dice::UH1::UH1_1(v1_1(), v5.get().clone())),
                                        v6,
                                    )
                                }
                            }
                        } else {
                            if v2_1.get().clone() {
                                let v0_1_temp: Dice::US0 = v0_1.get().clone();
                                let v1_1_temp = v1_1.get().clone();
                                let v2_1_temp: bool = v2_1.get().clone();
                                let v3_1_temp: u64 = v3_1.get().clone();
                                let v4_1_temp: i8 = v4_1.get().clone();
                                let v5_temp: LrcPtr<Dice::UH1> =
                                    Dice::method12(v4_1.get().clone(), v1_1.get().clone(), 0_i8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                v5.set(v5_temp);
                                continue '_method13;
                            } else {
                                Dice::method9(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    v4_1.get().clone(),
                                    LrcPtr::new(Dice::UH1::UH1_1(v1_1(), v5.get().clone())),
                                    v6,
                                )
                            }
                        }
                    }
                });
            }
        }
        pub fn method9(
            v0_1: Dice::US0,
            v1_1: Func0<u8>,
            v2_1: bool,
            v3_1: u64,
            v4_1: i8,
            v5: LrcPtr<Dice::UH1>,
            v6: i8,
        ) -> u64 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1 = MutCell::new(v1_1.clone());
            let v2_1: MutCell<bool> = MutCell::new(v2_1);
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            let v4_1: MutCell<i8> = MutCell::new(v4_1);
            let v5: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v5.clone());
            let v6: MutCell<i8> = MutCell::new(v6);
            '_method9: loop {
                break '_method9 (if v6.get().clone() < v4_1.get().clone() + 1_i8 {
                    let v0_1_temp: Dice::US0 = v0_1.get().clone();
                    let v1_1_temp = v1_1.get().clone();
                    let v2_1_temp: bool = v2_1.get().clone();
                    let v3_1_temp: u64 = v3_1.get().clone();
                    let v4_1_temp: i8 = v4_1.get().clone();
                    let v5_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(v1_1(), v5.get().clone()));
                    let v6_temp: i8 = v6.get().clone() + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    v2_1.set(v2_1_temp);
                    v3_1.set(v3_1_temp);
                    v4_1.set(v4_1_temp);
                    v5.set(v5_temp);
                    v6.set(v6_temp);
                    continue '_method9;
                } else {
                    let v14: Dice::US3 = Dice::method10(
                        v0_1.get().clone(),
                        v4_1.get().clone(),
                        v5.get().clone(),
                        0_u64,
                    );
                    if let Dice::US3::US3_0(v14_0_0, v14_0_1) = &v14 {
                        let v15: u64 = match &v14 {
                            Dice::US3::US3_0(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v15 <= v3_1.get().clone() {
                            v15
                        } else {
                            if v2_1.get().clone() {
                                Dice::method13(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    v4_1.get().clone(),
                                    Dice::method12(v4_1.get().clone(), v1_1.get().clone(), 0_i8),
                                )
                            } else {
                                let v0_1_temp: Dice::US0 = v0_1.get().clone();
                                let v1_1_temp = v1_1.get().clone();
                                let v2_1_temp: bool = v2_1.get().clone();
                                let v3_1_temp: u64 = v3_1.get().clone();
                                let v4_1_temp: i8 = v4_1.get().clone();
                                let v5_temp: LrcPtr<Dice::UH1> =
                                    LrcPtr::new(Dice::UH1::UH1_1(v1_1(), v5.get().clone()));
                                let v6_temp: i8 = v6.get().clone() + 1_i8;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method9;
                            }
                        }
                    } else {
                        if v2_1.get().clone() {
                            Dice::method13(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                                Dice::method12(v4_1.get().clone(), v1_1.get().clone(), 0_i8),
                            )
                        } else {
                            let v0_1_temp: Dice::US0 = v0_1.get().clone();
                            let v1_1_temp = v1_1.get().clone();
                            let v2_1_temp: bool = v2_1.get().clone();
                            let v3_1_temp: u64 = v3_1.get().clone();
                            let v4_1_temp: i8 = v4_1.get().clone();
                            let v5_temp: LrcPtr<Dice::UH1> =
                                LrcPtr::new(Dice::UH1::UH1_1(v1_1(), v5.get().clone()));
                            let v6_temp: i8 = v6.get().clone() + 1_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            v5.set(v5_temp);
                            v6.set(v6_temp);
                            continue '_method9;
                        }
                    }
                });
            }
        }
        pub fn closure13(v0_1: Dice::US0, v1_1: Func0<u8>, v2_1: bool, v3_1: u64) -> u64 {
            Dice::method9(
                v0_1.clone(),
                v1_1,
                v2_1,
                v3_1,
                (if v3_1 == 1_u64 {
                    1_i8
                } else {
                    Dice::method8(v0_1, v3_1, 0_i8, 1_u64)
                }) - 1_i8,
                LrcPtr::new(Dice::UH1::UH1_0),
                0_i8,
            )
        }
        pub fn closure12(v0_1: Dice::US0, v1_1: Func0<u8>, v2_1: bool) -> Func1<u64, u64> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move |v: u64| Dice::closure13(v0_1.clone(), v1_1.clone(), v2_1, v)
            })
        }
        pub fn closure11(v0_1: Dice::US0, v1_1: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: bool| Dice::closure12(v0_1.clone(), v1_1.clone(), v)
            })
        }
        pub fn closure10(
            unitVar: (),
            v0_1: Option<Func1<string, ()>>,
        ) -> Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>> {
            let v3_1: Dice::US0 = defaultValue(Dice::US0::US0_1, map(Dice::method1(), v0_1));
            Func1::new({
                let v3_1 = v3_1.clone();
                move |v: Func0<u8>| Dice::closure11(v3_1.clone(), v)
            })
        }
        pub fn method14(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method14: loop {
                break '_method14 (match v0_1.get().clone().as_ref() {
                    Dice::UH1::UH1_0 => v1_1.get().clone(),
                    Dice::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = match v0_1.get().clone().as_ref() {
                            Dice::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method14;
                    }
                });
            }
        }
        pub fn closure80(
            v0_1: Option<Func1<string, ()>>,
            v1_1: u64,
            v2_1: LrcPtr<Dice::UH1>,
        ) -> Option<u64> {
            let v10: Dice::US3 = Dice::method10(
                defaultValue(Dice::US0::US0_1, map(Dice::method1(), v0_1)),
                Dice::method14(v2_1.clone(), 0_i8) - 1_i8,
                v2_1,
                0_u64,
            );
            let v20: Dice::US4 = if let Dice::US3::US3_0(v10_0_0, v10_0_1) = &v10 {
                let v11: u64 = match &v10 {
                    Dice::US3::US3_0(x, _) => x.clone(),
                    _ => unreachable!(),
                };
                if if v11 >= 1_u64 { v11 <= v1_1 } else { false } {
                    Dice::US4::US4_0(v11)
                } else {
                    Dice::US4::US4_1
                }
            } else {
                Dice::US4::US4_1
            };
            match &v20 {
                Dice::US4::US4_0(v20_0_0) => Some(match &v20 {
                    Dice::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<u64>,
            }
        }
        pub fn closure79(
            v0_1: Option<Func1<string, ()>>,
            v1_1: u64,
        ) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: LrcPtr<Dice::UH1>| Dice::closure80(v0_1.clone(), v1_1, v)
            })
        }
        pub fn closure78(
            unitVar: (),
            v0_1: Option<Func1<string, ()>>,
        ) -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: u64| Dice::closure79(v0_1.clone(), v)
            })
        }
        pub fn method40(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            let v2_1: i64 = v1_1 + 1_i64;
            let v3_1: string = sprintf!(
                "accumulate_dice_rolls / power: {} / acc: {} / result: {}",
                -1_i8,
                v1_1,
                v2_1
            );
            printfn!("{0}", v3_1);
            Dice::US5::US5_0(v2_1, v0_1)
        }
        pub fn method39(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v8: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            0_i8,
                            v1_1,
                            v3_1,
                            v7
                        );
                        printfn!("{0}", v8);
                        Dice::method40(v4_1.clone(), v1_1 + v7)
                    } else {
                        let v11: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            0_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v11);
                        Dice::method40(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method38(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            1_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method39(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            1_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method39(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method37(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            2_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method38(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            2_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method38(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method36(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            3_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method37(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            3_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method37(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method35(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            4_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method36(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            4_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method36(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method34(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            5_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method35(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            5_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method35(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method33(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            6_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method34(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            6_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method34(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method32(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            7_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method33(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            7_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method33(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method31(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            8_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method32(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            8_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method32(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method30(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            9_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method31(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            9_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method31(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method29(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            10_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method30(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            10_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method30(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method28(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            11_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method29(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            11_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method29(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method27(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            12_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method28(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            12_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method28(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method26(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            13_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method27(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            13_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method27(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method25(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            14_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method26(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            14_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method26(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method24(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            15_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method25(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            15_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method25(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method23(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            16_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method24(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            16_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method24(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method22(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            17_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method23(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            17_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method23(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method21(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            18_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method22(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            18_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method22(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method20(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            19_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method21(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            19_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method21(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method19(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            20_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method20(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            20_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method20(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method18(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            21_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method19(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            21_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method19(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method17(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            22_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method18(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            22_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method18(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method16(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US5::US5_1,
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
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            23_i8,
                            v1_1,
                            v3_1,
                            v8
                        );
                        printfn!("{0}", v9);
                        Dice::method17(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            23_i8,
                            v1_1,
                            v3_1
                        );
                        printfn!("{0}", v12);
                        Dice::method17(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method15(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i64 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method15: loop {
                break '_method15 (if v1_1.get().clone() < 24_i8 {
                    let _v3: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                    {
                        let x: u8 = rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                        _v3.set(Some(x))
                    }
                    {
                        let v0_1_temp: LrcPtr<Dice::UH1> = LrcPtr::new(Dice::UH1::UH1_1(
                            getValue(_v3.get().clone()),
                            v0_1.get().clone(),
                        ));
                        let v1_1_temp: i8 = v1_1.get().clone() + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method15;
                    }
                } else {
                    let v17: Dice::US5 = Dice::method16(v0_1.get().clone(), 0_i64);
                    if let Dice::US5::US5_0(v17_0_0, v17_0_1) = &v17 {
                        let v18: i64 = match &v17 {
                            Dice::US5::US5_0(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v18 <= i64::MAX {
                            v18
                        } else {
                            let _v21: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                            {
                                let x_1: u8 = rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                _v21.set(Some(x_1))
                            }
                            {
                                let v30: u8 = getValue(_v21.get().clone());
                                let _v31: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                {
                                    let x_2: u8 =
                                        rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                    _v31.set(Some(x_2))
                                }
                                {
                                    let v38: u8 = getValue(_v31.get().clone());
                                    let _v39: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                    {
                                        let x_3: u8 =
                                            rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                        _v39.set(Some(x_3))
                                    }
                                    {
                                        let v46: u8 = getValue(_v39.get().clone());
                                        let _v47: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                        {
                                            let x_4: u8 =
                                                rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                            _v47.set(Some(x_4))
                                        }
                                        {
                                            let v54: u8 = getValue(_v47.get().clone());
                                            let _v55: MutCell<Option<u8>> =
                                                MutCell::new(None::<u8>);
                                            {
                                                let x_5: u8 = rand::Rng::gen_range(
                                                    &mut rand::thread_rng(),
                                                    1..7,
                                                );
                                                _v55.set(Some(x_5))
                                            }
                                            {
                                                let v62: u8 = getValue(_v55.get().clone());
                                                let _v63: MutCell<Option<u8>> =
                                                    MutCell::new(None::<u8>);
                                                {
                                                    let x_6: u8 = rand::Rng::gen_range(
                                                        &mut rand::thread_rng(),
                                                        1..7,
                                                    );
                                                    _v63.set(Some(x_6))
                                                }
                                                {
                                                    let v70: u8 = getValue(_v63.get().clone());
                                                    let _v71: MutCell<Option<u8>> =
                                                        MutCell::new(None::<u8>);
                                                    {
                                                        let x_7: u8 = rand::Rng::gen_range(
                                                            &mut rand::thread_rng(),
                                                            1..7,
                                                        );
                                                        _v71.set(Some(x_7))
                                                    }
                                                    {
                                                        let v78: u8 = getValue(_v71.get().clone());
                                                        let _v79: MutCell<Option<u8>> =
                                                            MutCell::new(None::<u8>);
                                                        {
                                                            let x_8: u8 = rand::Rng::gen_range(
                                                                &mut rand::thread_rng(),
                                                                1..7,
                                                            );
                                                            _v79.set(Some(x_8))
                                                        }
                                                        {
                                                            let v86: u8 =
                                                                getValue(_v79.get().clone());
                                                            let _v87: MutCell<Option<u8>> =
                                                                MutCell::new(None::<u8>);
                                                            {
                                                                let x_9: u8 = rand::Rng::gen_range(
                                                                    &mut rand::thread_rng(),
                                                                    1..7,
                                                                );
                                                                _v87.set(Some(x_9))
                                                            }
                                                            {
                                                                let v94: u8 =
                                                                    getValue(_v87.get().clone());
                                                                let _v95: MutCell<Option<u8>> =
                                                                    MutCell::new(None::<u8>);
                                                                {
                                                                    let x_10: u8 =
                                                                        rand::Rng::gen_range(
                                                                            &mut rand::thread_rng(),
                                                                            1..7,
                                                                        );
                                                                    _v95.set(Some(x_10))
                                                                }
                                                                {
                                                                    let v102: u8 = getValue(
                                                                        _v95.get().clone(),
                                                                    );
                                                                    let _v103: MutCell<Option<u8>> =
                                                                        MutCell::new(None::<u8>);
                                                                    {
                                                                        let x_11:
                                                                                         u8 =
                                                                                     rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                        _v103.set(Some(x_11))
                                                                    }
                                                                    {
                                                                        let v110: u8 = getValue(
                                                                            _v103.get().clone(),
                                                                        );
                                                                        let _v111: MutCell<
                                                                            Option<u8>,
                                                                        > = MutCell::new(
                                                                            None::<u8>,
                                                                        );
                                                                        {
                                                                            let x_12:
                                                                                             u8 =
                                                                                         rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                            _v111.set(Some(x_12))
                                                                        }
                                                                        {
                                                                            let v118: u8 = getValue(
                                                                                _v111.get().clone(),
                                                                            );
                                                                            let _v119: MutCell<
                                                                                Option<u8>,
                                                                            > = MutCell::new(
                                                                                None::<u8>,
                                                                            );
                                                                            {
                                                                                let x_13:
                                                                                                 u8 =
                                                                                             rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                _v119
                                                                                    .set(Some(x_13))
                                                                            }
                                                                            {
                                                                                let v126: u8 =
                                                                                    getValue(
                                                                                        _v119
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                    );
                                                                                let _v127: MutCell<
                                                                                    Option<u8>,
                                                                                > = MutCell::new(
                                                                                    None::<u8>,
                                                                                );
                                                                                {
                                                                                    let x_14:
                                                                                                     u8 =
                                                                                                 rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                    _v127.set(Some(
                                                                                        x_14,
                                                                                    ))
                                                                                }
                                                                                {
                                                                                    let v134:
                                                                                                     u8 =
                                                                                                 getValue(_v127.get().clone());
                                                                                    let _v135:
                                                                                                     MutCell<Option<u8>> =
                                                                                                 MutCell::new(None::<u8>);
                                                                                    {
                                                                                        let x_15:
                                                                                                         u8 =
                                                                                                     rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                        _v135.set(Some(x_15))
                                                                                    }
                                                                                    {
                                                                                        let v142:
                                                                                                         u8 =
                                                                                                     getValue(_v135.get().clone());
                                                                                        let _v143:
                                                                                                         MutCell<Option<u8>> =
                                                                                                     MutCell::new(None::<u8>);
                                                                                        {
                                                                                            let x_16:
                                                                                                             u8 =
                                                                                                         rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                            _v143.set(Some(x_16))
                                                                                        }
                                                                                        {
                                                                                            let v150:
                                                                                                             u8 =
                                                                                                         getValue(_v143.get().clone());
                                                                                            let _v151:
                                                                                                             MutCell<Option<u8>> =
                                                                                                         MutCell::new(None::<u8>);
                                                                                            {
                                                                                                let x_17:
                                                                                                                 u8 =
                                                                                                             rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                _v151.set(Some(x_17))
                                                                                            }
                                                                                            {
                                                                                                let v158:
                                                                                                                 u8 =
                                                                                                             getValue(_v151.get().clone());
                                                                                                let _v159:
                                                                                                                 MutCell<Option<u8>> =
                                                                                                             MutCell::new(None::<u8>);
                                                                                                {
                                                                                                    let x_18:
                                                                                                                     u8 =
                                                                                                                 rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                    _v159.set(Some(x_18))
                                                                                                }
                                                                                                {
                                                                                                    let v166:
                                                                                                                     u8 =
                                                                                                                 getValue(_v159.get().clone());
                                                                                                    let _v167:
                                                                                                                     MutCell<Option<u8>> =
                                                                                                                 MutCell::new(None::<u8>);
                                                                                                    {
                                                                                                        let x_19:
                                                                                                                         u8 =
                                                                                                                     rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                        _v167.set(Some(x_19))
                                                                                                    }
                                                                                                    {
                                                                                                        let v174:
                                                                                                                         u8 =
                                                                                                                     getValue(_v167.get().clone());
                                                                                                        let _v175:
                                                                                                                         MutCell<Option<u8>> =
                                                                                                                     MutCell::new(None::<u8>);
                                                                                                        {
                                                                                                            let x_20:
                                                                                                                             u8 =
                                                                                                                         rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                            _v175.set(Some(x_20))
                                                                                                        }
                                                                                                        {
                                                                                                            let v182:
                                                                                                                             u8 =
                                                                                                                         getValue(_v175.get().clone());
                                                                                                            let _v183:
                                                                                                                             MutCell<Option<u8>> =
                                                                                                                         MutCell::new(None::<u8>);
                                                                                                            {
                                                                                                                let x_21:
                                                                                                                                 u8 =
                                                                                                                             rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                                _v183.set(Some(x_21))
                                                                                                            }
                                                                                                            {
                                                                                                                let v190:
                                                                                                                                 u8 =
                                                                                                                             getValue(_v183.get().clone());
                                                                                                                let _v191:
                                                                                                                                 MutCell<Option<u8>> =
                                                                                                                             MutCell::new(None::<u8>);
                                                                                                                {
                                                                                                                    let x_22:
                                                                                                                                     u8 =
                                                                                                                                 rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                                    _v191.set(Some(x_22))
                                                                                                                }
                                                                                                                {
                                                                                                                    let v198:
                                                                                                                                     u8 =
                                                                                                                                 getValue(_v191.get().clone());
                                                                                                                    let _v199:
                                                                                                                                     MutCell<Option<u8>> =
                                                                                                                                 MutCell::new(None::<u8>);
                                                                                                                    {
                                                                                                                        let x_23:
                                                                                                                                         u8 =
                                                                                                                                     rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                                        _v199.set(Some(x_23))
                                                                                                                    }
                                                                                                                    {
                                                                                                                        let v0_1_temp:
                                                                                                                                         LrcPtr<Dice::UH1> =
                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(v30,
                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(v38,
                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(v46,
                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(v54,
                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(v62,
                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(v70,
                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(v78,
                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(v86,
                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(v94,
                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(v102,
                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(v110,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(v118,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(v126,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(v134,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(v142,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(v150,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(v158,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(v166,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(v174,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(v182,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(v190,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(v198,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(getValue(_v199.get().clone()),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                                                                                                                        let v1_1_temp:
                                                                                                                                         i8 =
                                                                                                                                     23_i8;
                                                                                                                        v0_1.set(v0_1_temp);
                                                                                                                        v1_1.set(v1_1_temp);
                                                                                                                        continue
                                                                                                                                     '_method15;
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
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        let _v234: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                        {
                            let x_24: u8 = rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                            _v234.set(Some(x_24))
                        }
                        {
                            let v243: u8 = getValue(_v234.get().clone());
                            let _v244: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                            {
                                let x_25: u8 = rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                _v244.set(Some(x_25))
                            }
                            {
                                let v251: u8 = getValue(_v244.get().clone());
                                let _v252: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                {
                                    let x_26: u8 =
                                        rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                    _v252.set(Some(x_26))
                                }
                                {
                                    let v259: u8 = getValue(_v252.get().clone());
                                    let _v260: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                    {
                                        let x_27: u8 =
                                            rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                        _v260.set(Some(x_27))
                                    }
                                    {
                                        let v267: u8 = getValue(_v260.get().clone());
                                        let _v268: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                        {
                                            let x_28: u8 =
                                                rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                            _v268.set(Some(x_28))
                                        }
                                        {
                                            let v275: u8 = getValue(_v268.get().clone());
                                            let _v276: MutCell<Option<u8>> =
                                                MutCell::new(None::<u8>);
                                            {
                                                let x_29: u8 = rand::Rng::gen_range(
                                                    &mut rand::thread_rng(),
                                                    1..7,
                                                );
                                                _v276.set(Some(x_29))
                                            }
                                            {
                                                let v283: u8 = getValue(_v276.get().clone());
                                                let _v284: MutCell<Option<u8>> =
                                                    MutCell::new(None::<u8>);
                                                {
                                                    let x_30: u8 = rand::Rng::gen_range(
                                                        &mut rand::thread_rng(),
                                                        1..7,
                                                    );
                                                    _v284.set(Some(x_30))
                                                }
                                                {
                                                    let v291: u8 = getValue(_v284.get().clone());
                                                    let _v292: MutCell<Option<u8>> =
                                                        MutCell::new(None::<u8>);
                                                    {
                                                        let x_31: u8 = rand::Rng::gen_range(
                                                            &mut rand::thread_rng(),
                                                            1..7,
                                                        );
                                                        _v292.set(Some(x_31))
                                                    }
                                                    {
                                                        let v299: u8 =
                                                            getValue(_v292.get().clone());
                                                        let _v300: MutCell<Option<u8>> =
                                                            MutCell::new(None::<u8>);
                                                        {
                                                            let x_32: u8 = rand::Rng::gen_range(
                                                                &mut rand::thread_rng(),
                                                                1..7,
                                                            );
                                                            _v300.set(Some(x_32))
                                                        }
                                                        {
                                                            let v307: u8 =
                                                                getValue(_v300.get().clone());
                                                            let _v308: MutCell<Option<u8>> =
                                                                MutCell::new(None::<u8>);
                                                            {
                                                                let x_33: u8 = rand::Rng::gen_range(
                                                                    &mut rand::thread_rng(),
                                                                    1..7,
                                                                );
                                                                _v308.set(Some(x_33))
                                                            }
                                                            {
                                                                let v315: u8 =
                                                                    getValue(_v308.get().clone());
                                                                let _v316: MutCell<Option<u8>> =
                                                                    MutCell::new(None::<u8>);
                                                                {
                                                                    let x_34: u8 =
                                                                        rand::Rng::gen_range(
                                                                            &mut rand::thread_rng(),
                                                                            1..7,
                                                                        );
                                                                    _v316.set(Some(x_34))
                                                                }
                                                                {
                                                                    let v323: u8 = getValue(
                                                                        _v316.get().clone(),
                                                                    );
                                                                    let _v324: MutCell<Option<u8>> =
                                                                        MutCell::new(None::<u8>);
                                                                    {
                                                                        let x_35:
                                                                                         u8 =
                                                                                     rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                        _v324.set(Some(x_35))
                                                                    }
                                                                    {
                                                                        let v331: u8 = getValue(
                                                                            _v324.get().clone(),
                                                                        );
                                                                        let _v332: MutCell<
                                                                            Option<u8>,
                                                                        > = MutCell::new(
                                                                            None::<u8>,
                                                                        );
                                                                        {
                                                                            let x_36:
                                                                                             u8 =
                                                                                         rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                            _v332.set(Some(x_36))
                                                                        }
                                                                        {
                                                                            let v339: u8 = getValue(
                                                                                _v332.get().clone(),
                                                                            );
                                                                            let _v340: MutCell<
                                                                                Option<u8>,
                                                                            > = MutCell::new(
                                                                                None::<u8>,
                                                                            );
                                                                            {
                                                                                let x_37:
                                                                                                 u8 =
                                                                                             rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                _v340
                                                                                    .set(Some(x_37))
                                                                            }
                                                                            {
                                                                                let v347: u8 =
                                                                                    getValue(
                                                                                        _v340
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                    );
                                                                                let _v348: MutCell<
                                                                                    Option<u8>,
                                                                                > = MutCell::new(
                                                                                    None::<u8>,
                                                                                );
                                                                                {
                                                                                    let x_38:
                                                                                                     u8 =
                                                                                                 rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                    _v348.set(Some(
                                                                                        x_38,
                                                                                    ))
                                                                                }
                                                                                {
                                                                                    let v355:
                                                                                                     u8 =
                                                                                                 getValue(_v348.get().clone());
                                                                                    let _v356:
                                                                                                     MutCell<Option<u8>> =
                                                                                                 MutCell::new(None::<u8>);
                                                                                    {
                                                                                        let x_39:
                                                                                                         u8 =
                                                                                                     rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                        _v356.set(Some(x_39))
                                                                                    }
                                                                                    {
                                                                                        let v363:
                                                                                                         u8 =
                                                                                                     getValue(_v356.get().clone());
                                                                                        let _v364:
                                                                                                         MutCell<Option<u8>> =
                                                                                                     MutCell::new(None::<u8>);
                                                                                        {
                                                                                            let x_40:
                                                                                                             u8 =
                                                                                                         rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                            _v364.set(Some(x_40))
                                                                                        }
                                                                                        {
                                                                                            let v371:
                                                                                                             u8 =
                                                                                                         getValue(_v364.get().clone());
                                                                                            let _v372:
                                                                                                             MutCell<Option<u8>> =
                                                                                                         MutCell::new(None::<u8>);
                                                                                            {
                                                                                                let x_41:
                                                                                                                 u8 =
                                                                                                             rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                _v372.set(Some(x_41))
                                                                                            }
                                                                                            {
                                                                                                let v379:
                                                                                                                 u8 =
                                                                                                             getValue(_v372.get().clone());
                                                                                                let _v380:
                                                                                                                 MutCell<Option<u8>> =
                                                                                                             MutCell::new(None::<u8>);
                                                                                                {
                                                                                                    let x_42:
                                                                                                                     u8 =
                                                                                                                 rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                    _v380.set(Some(x_42))
                                                                                                }
                                                                                                {
                                                                                                    let v387:
                                                                                                                     u8 =
                                                                                                                 getValue(_v380.get().clone());
                                                                                                    let _v388:
                                                                                                                     MutCell<Option<u8>> =
                                                                                                                 MutCell::new(None::<u8>);
                                                                                                    {
                                                                                                        let x_43:
                                                                                                                         u8 =
                                                                                                                     rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                        _v388.set(Some(x_43))
                                                                                                    }
                                                                                                    {
                                                                                                        let v395:
                                                                                                                         u8 =
                                                                                                                     getValue(_v388.get().clone());
                                                                                                        let _v396:
                                                                                                                         MutCell<Option<u8>> =
                                                                                                                     MutCell::new(None::<u8>);
                                                                                                        {
                                                                                                            let x_44:
                                                                                                                             u8 =
                                                                                                                         rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                            _v396.set(Some(x_44))
                                                                                                        }
                                                                                                        {
                                                                                                            let v403:
                                                                                                                             u8 =
                                                                                                                         getValue(_v396.get().clone());
                                                                                                            let _v404:
                                                                                                                             MutCell<Option<u8>> =
                                                                                                                         MutCell::new(None::<u8>);
                                                                                                            {
                                                                                                                let x_45:
                                                                                                                                 u8 =
                                                                                                                             rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                                _v404.set(Some(x_45))
                                                                                                            }
                                                                                                            {
                                                                                                                let v411:
                                                                                                                                 u8 =
                                                                                                                             getValue(_v404.get().clone());
                                                                                                                let _v412:
                                                                                                                                 MutCell<Option<u8>> =
                                                                                                                             MutCell::new(None::<u8>);
                                                                                                                {
                                                                                                                    let x_46:
                                                                                                                                     u8 =
                                                                                                                                 rand::Rng::gen_range(&mut rand::thread_rng(), 1..7);
                                                                                                                    _v412.set(Some(x_46))
                                                                                                                }
                                                                                                                {
                                                                                                                    let v0_1_temp:
                                                                                                                                     LrcPtr<Dice::UH1> =
                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(v243,
                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(v251,
                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(v259,
                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(v267,
                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(v275,
                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(v283,
                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(v291,
                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(v299,
                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(v307,
                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(v315,
                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(v323,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(v331,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(v339,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(v347,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(v355,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(v363,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(v371,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(v379,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(v387,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(v395,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(v403,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(v411,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(getValue(_v412.get().clone()),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                                                                                                                    let v1_1_temp:
                                                                                                                                     i8 =
                                                                                                                                 23_i8;
                                                                                                                    v0_1.set(v0_1_temp);
                                                                                                                    v1_1.set(v1_1_temp);
                                                                                                                    continue
                                                                                                                                 '_method15;
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
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure81(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1_1: string = sprintf!(
                "calculate_dice_count / max: {} / n: {} / p: {}",
                i64::MAX,
                24_i8,
                4738381338321616896_i64
            );
            printfn!("{0}", v1_1);
            {
                let v5: string = sprintf!(
                    "result: {}",
                    Dice::method15(LrcPtr::new(Dice::UH1::UH1_0), 0_i8)
                );
                printfn!("{0}", v5);
                0_i32
            }
        }
        pub fn v0() -> Func1<i64, Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>>> {
            static v0: OnceInit<Func1<i64, Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>>>> =
                OnceInit::new();
            v0.get_or_insert_with(|| Func1::new(move |v: i64| Dice::closure0((), v)))
                .clone()
        }
        pub fn rotate_numbers(x: i64) -> Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>> {
            (Dice::v0())(x)
        }
        pub fn v1() -> Func1<Option<Func1<string, ()>>, Func1<LrcPtr<Dice::UH1>, Func0<u8>>> {
            static v1: OnceInit<
                Func1<Option<Func1<string, ()>>, Func1<LrcPtr<Dice::UH1>, Func0<u8>>>,
            > = OnceInit::new();
            v1.get_or_insert_with(|| {
                Func1::new(move |v: Option<Func1<string, ()>>| Dice::closure3((), v))
            })
            .clone()
        }
        pub fn create_sequential_roller(
            x: Option<Func1<string, ()>>,
        ) -> Func1<LrcPtr<Dice::UH1>, Func0<u8>> {
            (Dice::v1())(x)
        }
        pub fn v2(
        ) -> Func1<Option<Func1<string, ()>>, Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>>>
        {
            static v2: OnceInit<
                Func1<Option<Func1<string, ()>>, Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>>>,
            > = OnceInit::new();
            v2.get_or_insert_with(|| {
                Func1::new(move |v: Option<Func1<string, ()>>| Dice::closure10((), v))
            })
            .clone()
        }
        pub fn roll_progressively(
            x: Option<Func1<string, ()>>,
        ) -> Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>> {
            (Dice::v2())(x)
        }
        pub fn v3(
        ) -> Func1<Option<Func1<string, ()>>, Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>>>
        {
            static v3: OnceInit<
                Func1<Option<Func1<string, ()>>, Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>>>,
            > = OnceInit::new();
            v3.get_or_insert_with(|| {
                Func1::new(move |v: Option<Func1<string, ()>>| Dice::closure78((), v))
            })
            .clone()
        }
        pub fn roll_within_bounds(
            x: Option<Func1<string, ()>>,
        ) -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>> {
            (Dice::v3())(x)
        }
        pub fn v4() -> Func1<Array<string>, i32> {
            static v4: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v4.get_or_insert_with(|| Func1::new(move |v: Array<string>| Dice::closure81((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Dice::v4())(args)
        }
    }
}
pub use module_a51efde0::*;
#[path = "../../polyglot/lib/fsharp/Common.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
#[path = "../../polyglot/lib/spiral/common.rs"]
mod module_e7e93d99;
pub use module_e7e93d99::*;
#[path = "../../polyglot/lib/spiral/date_time.rs"]
mod module_d18105aa;
pub use module_d18105aa::*;
#[path = "../../polyglot/lib/spiral/file_system.rs"]
mod module_c5eb79e8;
pub use module_c5eb79e8::*;
#[path = "../../polyglot/lib/spiral/lib.rs"]
mod module_8d8b0653;
pub use module_8d8b0653::*;
#[path = "../../polyglot/lib/spiral/sm.rs"]
mod module_2aeb754a;
pub use module_2aeb754a::*;
pub mod Polyglot {
    pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::main(array_from(args));
}
