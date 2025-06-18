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
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
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
        use fable_library_rust::TimeSpan_::TimeSpan;
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
            US8_0(
                LrcPtr<Dice::Mut1>,
                LrcPtr<Dice::Mut3>,
                LrcPtr<Dice::Mut4>,
                LrcPtr<Dice::Mut5>,
                LrcPtr<Dice::Mut6>,
                Option<i64>,
            ),
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0(u64, LrcPtr<Dice::UH1>),
            US9_1,
        }
        impl core::fmt::Display for US9 {
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
        pub enum US10 {
            US10_0(u64),
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US11 {
            US11_0(i64, LrcPtr<Dice::UH1>),
            US11_1,
        }
        impl core::fmt::Display for US11 {
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
            let v3_1: string = Dice::method9(v0_1);
            let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v3_1);
            let v7: bool = true;
            let _result_map_ = v5.map(|x| {
                //;
                let v9: std::string::String = x;
                let v11: string = fable_library_rust::String_::fromString(v9);
                let v13: bool = true;
                v11
            });
            let v15: Result<string, std::env::VarError> = _result_map_;
            let v16: string = Dice::method10();
            v15.unwrap_or(v16)
        }
        pub fn method7() -> (Dice::US3, Dice::US4) {
            let v1_1: string = Dice::method8(string("TRACE_LEVEL"));
            let v6: string = toLower(string("Critical"));
            let v13: string = toLower(string("Warning"));
            let v20: string = toLower(string("Info"));
            let v27: string = toLower(string("Debug"));
            let v34: string = toLower(string("Verbose"));
            let v41: Dice::US3 = if string("Verbose") == (v1_1.clone()) {
                Dice::US3::US3_0(Dice::US2::US2_0)
            } else {
                Dice::US3::US3_1
            };
            (
                match &v41 {
                    Dice::US3::US3_0(v41_0_0) => Dice::US3::US3_0(
                        match &v41 {
                            Dice::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v48: Dice::US3 = if string("Debug") == (v1_1.clone()) {
                            Dice::US3::US3_0(Dice::US2::US2_1)
                        } else {
                            Dice::US3::US3_1
                        };
                        match &v48 {
                            Dice::US3::US3_0(v48_0_0) => Dice::US3::US3_0(
                                match &v48 {
                                    Dice::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v55: Dice::US3 = if string("Info") == (v1_1.clone()) {
                                    Dice::US3::US3_0(Dice::US2::US2_2)
                                } else {
                                    Dice::US3::US3_1
                                };
                                match &v55 {
                                    Dice::US3::US3_0(v55_0_0) => Dice::US3::US3_0(
                                        match &v55 {
                                            Dice::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v62: Dice::US3 = if string("Warning") == (v1_1.clone())
                                        {
                                            Dice::US3::US3_0(Dice::US2::US2_3)
                                        } else {
                                            Dice::US3::US3_1
                                        };
                                        match &v62 {
                                            Dice::US3::US3_0(v62_0_0) => Dice::US3::US3_0(
                                                match &v62 {
                                                    Dice::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            ),
                                            _ => {
                                                let v69: Dice::US3 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Dice::US3::US3_0(Dice::US2::US2_4)
                                                    } else {
                                                        Dice::US3::US3_1
                                                    };
                                                match &v69 {
                                                    Dice::US3::US3_0(v69_0_0) => Dice::US3::US3_0(
                                                        match &v69 {
                                                            Dice::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    ),
                                                    _ => {
                                                        let v76: Dice::US3 =
                                                            if (v34.clone()) == (v1_1.clone()) {
                                                                Dice::US3::US3_0(Dice::US2::US2_0)
                                                            } else {
                                                                Dice::US3::US3_1
                                                            };
                                                        match &v76 {
                                                            Dice::US3::US3_0(v76_0_0) => {
                                                                Dice::US3::US3_0(
                                                                    match &v76 {
                                                                        Dice::US3::US3_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                )
                                                            }
                                                            _ => {
                                                                let v83: Dice::US3 = if (v27
                                                                    .clone())
                                                                    == (v1_1.clone())
                                                                {
                                                                    Dice::US3::US3_0(
                                                                        Dice::US2::US2_1,
                                                                    )
                                                                } else {
                                                                    Dice::US3::US3_1
                                                                };
                                                                match &v83 {
                                                                 Dice::US3::US3_0(v83_0_0)
                                                                 =>
                                                                 Dice::US3::US3_0(match &v83
                                                                                      {
                                                                                      Dice::US3::US3_0(x)
                                                                                      =>
                                                                                      x.clone(),
                                                                                      _
                                                                                      =>
                                                                                      unreachable!(),
                                                                                  }.clone()),
                                                                 _ => {
                                                                     let v90:
                                                                             Dice::US3 =
                                                                         if (v20.clone())
                                                                                ==
                                                                                (v1_1.clone())
                                                                            {
                                                                             Dice::US3::US3_0(Dice::US2::US2_2)
                                                                         } else {
                                                                             Dice::US3::US3_1
                                                                         };
                                                                     match &v90
                                                                         {
                                                                         Dice::US3::US3_0(v90_0_0)
                                                                         =>
                                                                         Dice::US3::US3_0(match &v90
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
                                                                             let v97:
                                                                                     Dice::US3 =
                                                                                 if (v13.clone())
                                                                                        ==
                                                                                        (v1_1.clone())
                                                                                    {
                                                                                     Dice::US3::US3_0(Dice::US2::US2_3)
                                                                                 } else {
                                                                                     Dice::US3::US3_1
                                                                                 };
                                                                             match &v97
                                                                                 {
                                                                                 Dice::US3::US3_0(v97_0_0)
                                                                                 =>
                                                                                 Dice::US3::US3_0(match &v97
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
                                                                                     let v104:
                                                                                             Dice::US3 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1_1.clone())
                                                                                            {
                                                                                             Dice::US3::US3_0(Dice::US2::US2_4)
                                                                                         } else {
                                                                                             Dice::US3::US3_1
                                                                                         };
                                                                                     match &v104
                                                                                         {
                                                                                         Dice::US3::US3_0(v104_0_0)
                                                                                         =>
                                                                                         Dice::US3::US3_0(match &v104
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
                    Dice::US4::US4_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                },
            )
        }
        pub fn closure11(unitVar: (), v0_1: string) {
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
            let patternInput: (Dice::US3, Dice::US4) = Dice::method7();
            let _run_target_args__v3: (Dice::US3, Dice::US4) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v185: Dice::US4 = _run_target_args__v3.1.clone();
            let v184: Dice::US3 = _run_target_args__v3.0.clone();
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
                    l0: MutCell::new(match &v184 {
                        Dice::US3::US3_0(v184_0_0) => match &v184 {
                            Dice::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v185 {
                    Dice::US4::US4_0(v185_0_0) => Some(match &v185 {
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
        pub fn closure12(unitVar: (), v0_1: i64) -> Dice::US4 {
            Dice::US4::US4_0(v0_1)
        }
        pub fn method13() -> Func1<i64, Dice::US4> {
            Func1::new(move |v: i64| Dice::closure12((), v))
        }
        pub fn method14() -> string {
            string("hh:mm:ss")
        }
        pub fn method15() -> string {
            string("HH:mm:ss")
        }
        pub fn method12(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
        ) -> string {
            let v241: Dice::US4 = defaultValue(Dice::US4::US4_1, map(Dice::method13(), v5));
            let v395: DateTime = match &v241 {
                Dice::US4::US4_0(v241_0_0) => {
                    let v324: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v241 {
                            Dice::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v324.hours(),
                        v324.minutes(),
                        v324.seconds(),
                        v324.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v396: string = Dice::method14();
            let provider: string = if (v396.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v396
            };
            v395.toString(provider)
        }
        pub fn method18() -> string {
            string("")
        }
        pub fn closure13(v0_1: LrcPtr<Dice::Mut5>, v1_1: string, unitVar: ()) {
            let v4_1: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v4_1);
            ()
        }
        pub fn method17(v0_1: char) -> string {
            let v2_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v17: () = {
                Dice::closure13(v2_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2_1.l0.get().clone()
        }
        pub fn method19() -> string {
            string("\u{001b}[0m")
        }
        pub fn method16() -> string {
            let v8: string = Dice::method17(getCharAt(toLower(string("Debug")), 0_i32));
            let v27: &str = inline_colorization::color_bright_blue;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method21(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: string) -> string {
            let v5: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v19: () = {
                Dice::closure13(v5.clone(), string("{ "), ());
                ()
            };
            let v38: () = {
                Dice::closure13(v5.clone(), string("current_index"), ());
                ()
            };
            let v57: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v77: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v115: () = {
                Dice::closure13(v5.clone(), string("acc"), ());
                ()
            };
            let v132: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v152: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v169: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v188: () = {
                Dice::closure13(v5.clone(), string("len"), ());
                ()
            };
            let v205: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v225: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v242: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v261: () = {
                Dice::closure13(v5.clone(), string("last_item"), ());
                ()
            };
            let v278: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v295: () = {
                Dice::closure13(v5.clone(), v3_1, ());
                ()
            };
            let v314: () = {
                Dice::closure13(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method22(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method20(
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
            let v12: string = Dice::method21(v8, v9, v10, v11);
            Dice::method22(append(
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
        pub fn closure14(v0_1: LrcPtr<Dice::Mut1>, unitVar: ()) {
            let v2_1: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2_1);
            ()
        }
        pub fn closure16(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure15(unitVar: (), v0_1: string) {
            let v4_1: () = {
                Dice::closure16(v0_1, ());
                ()
            };
            ()
        }
        pub fn closure8(v0_1: i64, v1_1: i64, v2_1: i64, v3_1: Option<u8>, unitVar: ()) {
            fn v19() {
                Dice::closure9((), ());
            }
            let v20: () = {
                v19();
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
            let v61: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v305: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v61,
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
                Dice::US8::US8_1
            } else {
                let v84: () = {
                    v19();
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
                let v112: Option<i64> = patternInput_1.5.clone();
                let v111: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v110: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v109: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v108: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v107: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v131: string = Dice::method20(
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    v112.clone(),
                    Dice::method12(v107, v108, v109, v110, v111, v112),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                    sprintf!("{:?}", v3_1),
                );
                let v147: () = {
                    v19();
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
                let v171: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v170: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v192: () = {
                    Dice::closure14(v170.clone(), ());
                    ()
                };
                println!("{}", v131.clone());
                (v171.l0.get().clone())(v131);
                Dice::US8::US8_0(
                    v170,
                    v171,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method23(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> Dice::US1 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1_1.clone());
            '_method23: loop {
                break '_method23 (match v1_1.get().clone().as_ref() {
                    Dice::UH0::UH0_1 => Dice::US1::US1_1,
                    Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i64 {
                            Dice::US1::US1_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = (v0_1.get().clone()) - 1_i64;
                            let v1_1_temp: LrcPtr<Dice::UH0> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method23;
                        }
                    }
                });
            }
        }
        pub fn method25() -> string {
            let v1_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method24(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            let v8: string = Dice::method25();
            Dice::method22(append(
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
        pub fn closure17(unitVar: (), unitVar_1: ()) {
            fn v15() {
                Dice::closure9((), ());
            }
            let v16: () = {
                v15();
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
            let v57: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v297: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v57,
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
                Dice::US8::US8_1
            } else {
                let v80: () = {
                    v15();
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
                let v108: Option<i64> = patternInput_1.5.clone();
                let v107: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v106: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v105: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v104: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v103: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v123: string = Dice::method24(
                    v103.clone(),
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    Dice::method12(v103, v104, v105, v106, v107, v108),
                    Dice::method16(),
                );
                let v139: () = {
                    v15();
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
                let v163: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v162: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v184: () = {
                    Dice::closure14(v162.clone(), ());
                    ()
                };
                println!("{}", v123.clone());
                (v163.l0.get().clone())(v123);
                Dice::US8::US8_0(
                    v162,
                    v163,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
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
                    let v337: () = {
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
                    let v656: LrcPtr<Dice::UH0> = v0_1();
                    let v658: Dice::US1 = Dice::method23(v1_1.l0.get().clone(), v656);
                    match &v658 {
                        Dice::US1::US1_0(v658_0_0) => {
                            let v659: u8 = match &v658 {
                                Dice::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v661: i64 = (v1_1.l0.get().clone()) + 1_i64;
                            v1_1.l0.set(v661);
                            v4_1.l0.set(Dice::US1::US1_0(v659));
                            v659
                        }
                        _ => {
                            let v976: () = {
                                Dice::closure17((), ());
                                ()
                            };
                            if (v3_1.l0.get().clone()) == -1_i64 {
                                let v1293: i64 = v1_1.l0.get().clone();
                                v3_1.l0.set(v1293);
                                ()
                            }
                            {
                                let v1299: i64 =
                                    if (v2_1.l0.get().clone()) >= (v3_1.l0.get().clone()) {
                                        1_i64
                                    } else {
                                        (v2_1.l0.get().clone()) + 1_i64
                                    };
                                v2_1.l0.set(v1299);
                                {
                                    let v1301: i64 = (v2_1.l0.get().clone()) - 1_i64;
                                    v1_1.l0.set(v1301);
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
        pub fn method28(v0_1: u64, v1_1: u64, v2_1: i8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v18: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), string("max"), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Dice::closure13(v4_1.clone(), string("p"), ());
                ()
            };
            let v131: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Dice::closure13(v4_1.clone(), string("n"), ());
                ()
            };
            let v204: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v243: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method27(
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
            let v11: string = Dice::method28(v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure21(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method27(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v2_1,
                    v1_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method26(v0_1: u64, v1_1: i8, v2_1: u64) -> i8 {
            let v0_1: MutCell<u64> = MutCell::new(v0_1);
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method26: loop {
                break '_method26 (if (v2_1.get().clone()) < (v0_1.get().clone()) {
                    let v4_1: u64 = (v2_1.get().clone()) * 6_u64;
                    if (v4_1) > (v2_1.get().clone()) {
                        let v0_1_temp: u64 = v0_1.get().clone();
                        let v1_1_temp: i8 = (v1_1.get().clone()) + 1_i8;
                        let v2_1_temp: u64 = v4_1;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method26;
                    } else {
                        let v321: () = {
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
                    let v950: () = {
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
        pub fn method32(v0_1: i8, v1_1: u64, v2_1: u64) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v18: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v131: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Dice::closure13(v4_1.clone(), string("result"), ());
                ()
            };
            let v204: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v243: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method31(
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
            let v11: string = Dice::method32(v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure22(v0_1: u64, v1_1: i8, v2_1: u64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method31(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v1_1,
                    v0_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
        pub fn method33(v0_1: i8, v1_1: LrcPtr<Dice::UH2>) -> Dice::US10 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH2>> = MutCell::new(v1_1.clone());
            '_method33: loop {
                break '_method33 (match v1_1.get().clone().as_ref() {
                    Dice::UH2::UH2_1 => Dice::US10::US10_1,
                    Dice::UH2::UH2_0(v1_1_0_0, v1_1_0_1) => {
                        if (v0_1.get().clone()) <= 0_i8 {
                            Dice::US10::US10_0(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                            let v1_1_temp: LrcPtr<Dice::UH2> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method33;
                        }
                    }
                });
            }
        }
        pub fn method35(v0_1: i8, v1_1: u64, v2_1: u8, v3_1: u64) -> string {
            let v5: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v19: () = {
                Dice::closure13(v5.clone(), string("{ "), ());
                ()
            };
            let v38: () = {
                Dice::closure13(v5.clone(), string("power"), ());
                ()
            };
            let v57: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v77: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v115: () = {
                Dice::closure13(v5.clone(), string("acc"), ());
                ()
            };
            let v132: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v152: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v169: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v188: () = {
                Dice::closure13(v5.clone(), string("roll"), ());
                ()
            };
            let v205: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v225: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v242: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v261: () = {
                Dice::closure13(v5.clone(), string("value"), ());
                ()
            };
            let v278: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v298: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v3_1), ());
                ()
            };
            let v317: () = {
                Dice::closure13(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method34(
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
            let v12: string = Dice::method35(v8, v9, v10, v11);
            Dice::method22(append(
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
        pub fn closure87(v0_1: u64, v1_1: i8, v2_1: u8, v3_1: u64, unitVar: ()) {
            fn v19() {
                Dice::closure9((), ());
            }
            let v20: () = {
                v19();
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
            let v61: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v301: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v61,
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
                Dice::US8::US8_1
            } else {
                let v84: () = {
                    v19();
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
                let v112: Option<i64> = patternInput_1.5.clone();
                let v111: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v110: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v109: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v108: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v107: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v127: string = Dice::method34(
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    v112.clone(),
                    Dice::method12(v107, v108, v109, v110, v111, v112),
                    Dice::method16(),
                    v1_1,
                    v0_1,
                    v2_1,
                    v3_1,
                );
                let v143: () = {
                    v19();
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
                let v167: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v166: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v188: () = {
                    Dice::closure14(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Dice::US8::US8_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method37(v0_1: i8, v1_1: u64, v2_1: u8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v18: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v131: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Dice::closure13(v4_1.clone(), string("roll"), ());
                ()
            };
            let v204: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v243: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
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
        ) -> string {
            let v11: string = Dice::method37(v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure88(v0_1: u64, v1_1: i8, v2_1: u8, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method36(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v1_1,
                    v0_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method30(v0_1: i8, v1_1: LrcPtr<Dice::UH1>, v2_1: u64) -> Dice::US9 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            let v2_1: MutCell<u64> = MutCell::new(v2_1);
            '_method30: loop {
                break '_method30 (if (v0_1.get().clone()) < 0_i8 {
                    let v4_1: u64 = (v2_1.get().clone()) + 1_u64;
                    let v318: () = {
                        Dice::closure22(v2_1.get().clone(), v0_1.get().clone(), v4_1, ());
                        ()
                    };
                    Dice::US9::US9_0(v4_1, v1_1.get().clone())
                } else {
                    match v1_1.get().clone().as_ref() {
                        Dice::UH1::UH1_0 => Dice::US9::US9_1,
                        Dice::UH1::UH1_1(v1_1_1_0, v1_1_1_1) => {
                            let v636: LrcPtr<Dice::UH1> = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v635: u8 = match v1_1.get().clone().as_ref() {
                                Dice::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if (v635) > 1_u8 {
                                let v641: Dice::US10 = Dice::method33(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Dice::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice::closure23((), ())),
                                    )),
                                );
                                let v648: u64 = (((v635) - 1_u8) as u64)
                                    * (match &v641 {
                                        Dice::US10::US10_0(v641_0_0) => match &v641 {
                                            Dice::US10::US10_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    });
                                let v962: () = {
                                    Dice::closure87(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v635,
                                        v648,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v636;
                                    let v2_1_temp: u64 = (v2_1.get().clone()) + (v648);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method30;
                                }
                            } else {
                                let v1593: () = {
                                    Dice::closure88(
                                        v2_1.get().clone(),
                                        v0_1.get().clone(),
                                        v635,
                                        (),
                                    );
                                    ()
                                };
                                {
                                    let v0_1_temp: i8 = (v0_1.get().clone()) - 1_i8;
                                    let v1_1_temp: LrcPtr<Dice::UH1> = v636.clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    continue '_method30;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method38(v0_1: i8, v1_1: Func0<u8>, v2_1: i8) -> LrcPtr<Dice::UH1> {
            if (v2_1) < (v0_1) {
                LrcPtr::new(Dice::UH1::UH1_1(
                    v1_1(),
                    Dice::method38(v0_1, v1_1, (v2_1) + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice::UH1::UH1_0)
            }
        }
        pub fn method39(
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
            '_method39: loop {
                break '_method39 ({
                    let v5: i8 = (v3_1.get().clone()) + 1_i8;
                    if (v3_1.get().clone()) < (v5) {
                        Dice::method29(
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            LrcPtr::new(Dice::UH1::UH1_1(v0_1(), v4_1.get().clone())),
                            v5,
                        )
                    } else {
                        let v11: Dice::US9 =
                            Dice::method30(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                        if let Dice::US9::US9_0(v11_0_0, v11_0_1) = &v11 {
                            let v12: u64 = v11_0_0.clone();
                            if (v12) <= (v2_1.get().clone()) {
                                v12
                            } else {
                                if v1_1.get().clone() {
                                    let v0_1_temp = v0_1.get().clone();
                                    let v1_1_temp: bool = v1_1.get().clone();
                                    let v2_1_temp: u64 = v2_1.get().clone();
                                    let v3_1_temp: i8 = v3_1.get().clone();
                                    let v4_1_temp: LrcPtr<Dice::UH1> = Dice::method38(
                                        v3_1.get().clone(),
                                        v0_1.get().clone(),
                                        0_i8,
                                    );
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method39;
                                } else {
                                    Dice::method29(
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
                                    Dice::method38(v3_1.get().clone(), v0_1.get().clone(), 0_i8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                continue '_method39;
                            } else {
                                Dice::method29(
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
        pub fn method29(
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
            '_method29: loop {
                break '_method29 (if (v5.get().clone()) < ((v3_1.get().clone()) + 1_i8) {
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
                    continue '_method29;
                } else {
                    let v13: Dice::US9 =
                        Dice::method30(v3_1.get().clone(), v4_1.get().clone(), 0_u64);
                    if let Dice::US9::US9_0(v13_0_0, v13_0_1) = &v13 {
                        let v14: u64 = v13_0_0.clone();
                        if (v14) <= (v2_1.get().clone()) {
                            v14
                        } else {
                            if v1_1.get().clone() {
                                Dice::method39(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    Dice::method38(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
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
                                continue '_method29;
                            }
                        }
                    } else {
                        if v1_1.get().clone() {
                            Dice::method39(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                Dice::method38(v3_1.get().clone(), v0_1.get().clone(), 0_i8),
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
                            continue '_method29;
                        }
                    }
                });
            }
        }
        pub fn closure20(v0_1: Func0<u8>, v1_1: bool, v2_1: u64) -> u64 {
            Dice::method29(
                v0_1,
                v1_1,
                v2_1,
                (if (v2_1) == 1_u64 {
                    1_i8
                } else {
                    Dice::method26(v2_1, 0_i8, 1_u64)
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
        pub fn method40(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method40: loop {
                break '_method40 (match v0_1.get().clone().as_ref() {
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
                        continue '_method40;
                    }
                });
            }
        }
        pub fn closure90(v0_1: u64, v1_1: LrcPtr<Dice::UH1>) -> Option<u64> {
            let v6: Dice::US9 =
                Dice::method30((Dice::method40(v1_1.clone(), 0_i8)) - 1_i8, v1_1, 0_u64);
            let v16: Dice::US10 = if let Dice::US9::US9_0(v6_0_0, v6_0_1) = &v6 {
                let v7: u64 = v6_0_0.clone();
                if if (v7) >= 1_u64 { (v7) <= (v0_1) } else { false } {
                    Dice::US10::US10_0(v7)
                } else {
                    Dice::US10::US10_1
                }
            } else {
                Dice::US10::US10_1
            };
            match &v16 {
                Dice::US10::US10_0(v16_0_0) => Some(match &v16 {
                    Dice::US10::US10_0(x) => x.clone(),
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
        pub fn method42(v0_1: i64, v1_1: i64, v2_1: i8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v18: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), string("max"), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Dice::closure13(v4_1.clone(), string("p"), ());
                ()
            };
            let v131: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Dice::closure13(v4_1.clone(), string("n"), ());
                ()
            };
            let v204: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v243: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
        }
        pub fn method41(
            v0_1: LrcPtr<Dice::Mut1>,
            v1_1: LrcPtr<Dice::Mut3>,
            v2_1: LrcPtr<Dice::Mut4>,
            v3_1: LrcPtr<Dice::Mut5>,
            v4_1: LrcPtr<Dice::Mut6>,
            v5: Option<i64>,
            v6: string,
            v7: string,
        ) -> string {
            let v11: string = Dice::method42(i64::MAX, 4738381338321616896_i64, 24_i8);
            Dice::method22(append(
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
        pub fn closure92(unitVar: (), unitVar_1: ()) {
            fn v15() {
                Dice::closure9((), ());
            }
            let v16: () = {
                v15();
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
            let v57: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v297: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v57,
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
                Dice::US8::US8_1
            } else {
                let v80: () = {
                    v15();
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
                let v108: Option<i64> = patternInput_1.5.clone();
                let v107: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v106: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v105: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v104: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v103: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v123: string = Dice::method41(
                    v103.clone(),
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    Dice::method12(v103, v104, v105, v106, v107, v108),
                    Dice::method16(),
                );
                let v139: () = {
                    v15();
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
                let v163: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v162: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v184: () = {
                    Dice::closure14(v162.clone(), ());
                    ()
                };
                println!("{}", v123.clone());
                (v163.l0.get().clone())(v123);
                Dice::US8::US8_0(
                    v162,
                    v163,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method44() -> u8 {
            rand::Rng::gen_range(&mut rand::thread_rng(), 1_u8..7_u8)
        }
        pub fn method47(v0_1: i8, v1_1: i64, v2_1: u8, v3_1: i64) -> string {
            let v5: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v19: () = {
                Dice::closure13(v5.clone(), string("{ "), ());
                ()
            };
            let v38: () = {
                Dice::closure13(v5.clone(), string("power"), ());
                ()
            };
            let v57: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v77: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v96: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v115: () = {
                Dice::closure13(v5.clone(), string("acc"), ());
                ()
            };
            let v132: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v152: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v169: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v188: () = {
                Dice::closure13(v5.clone(), string("roll"), ());
                ()
            };
            let v205: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v225: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v242: () = {
                Dice::closure13(v5.clone(), string("; "), ());
                ()
            };
            let v261: () = {
                Dice::closure13(v5.clone(), string("value"), ());
                ()
            };
            let v278: () = {
                Dice::closure13(v5.clone(), string(" = "), ());
                ()
            };
            let v298: () = {
                Dice::closure13(v5.clone(), sprintf!("{}", v3_1), ());
                ()
            };
            let v317: () = {
                Dice::closure13(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method46(
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
            let v12: string = Dice::method47(23_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure93(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method46(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            v8: i64,
            v9: u8,
            v10: i64,
        ) -> string {
            let v12: string = Dice::method47(22_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure94(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method49(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(21_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure95(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method51(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(20_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure96(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method53(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(19_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure97(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method55(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(18_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure98(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method57(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(17_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure99(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method59(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(16_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure100(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method61(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(15_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure101(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method63(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(14_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure102(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method65(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(13_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure103(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method67(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(12_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure104(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method69(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(11_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure105(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method71(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(10_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure106(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method73(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(9_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure107(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method75(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(8_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure108(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method77(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(7_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure109(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method79(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(6_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure110(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method81(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(5_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure111(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method83(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(4_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure112(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method85(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(3_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure113(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method87(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(2_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure114(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method89(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(1_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure115(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method91(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
            let v12: string = Dice::method47(0_i8, v8, v9, v10);
            Dice::method22(append(
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
        pub fn closure116(v0_1: i64, v1_1: u8, v2_1: i64, unitVar: ()) {
            fn v18() {
                Dice::closure9((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v300: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Dice::US8::US8_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v109: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v108: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v107: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v106: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v126: string = Dice::method93(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Dice::method12(v106, v107, v108, v109, v110, v111),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                    v2_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v165: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v187: () = {
                    Dice::closure14(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Dice::US8::US8_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method96(v0_1: i8, v1_1: i64, v2_1: i64) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v18: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v131: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Dice::closure13(v4_1.clone(), string("result"), ());
                ()
            };
            let v204: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v243: () = {
                Dice::closure13(v4_1.clone(), string(" }"), ());
                ()
            };
            v4_1.l0.get().clone()
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
            v9: i64,
        ) -> string {
            let v11: string = Dice::method96(-1_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure117(v0_1: i64, v1_1: i64, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method95(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method94(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            let v2_1: i64 = (v1_1) + 1_i64;
            let v316: () = {
                Dice::closure117(v1_1, v2_1, ());
                ()
            };
            Dice::US11::US11_0(v2_1, v0_1)
        }
        pub fn method98(v0_1: i8, v1_1: i64, v2_1: u8) -> string {
            let v4_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v18: () = {
                Dice::closure13(v4_1.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Dice::closure13(v4_1.clone(), string("power"), ());
                ()
            };
            let v56: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Dice::closure13(v4_1.clone(), string("acc"), ());
                ()
            };
            let v131: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Dice::closure13(v4_1.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Dice::closure13(v4_1.clone(), string("roll"), ());
                ()
            };
            let v204: () = {
                Dice::closure13(v4_1.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Dice::closure13(v4_1.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v243: () = {
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
            v9: u8,
        ) -> string {
            let v11: string = Dice::method98(0_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure118(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method97(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method92(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v321: () = {
                            Dice::closure116(v1_1, v3_1, v7, ());
                            ()
                        };
                        Dice::method94(v4_1.clone(), (v1_1) + (v7))
                    } else {
                        let v951: () = {
                            Dice::closure118(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method94(v4_1, v1_1)
                    }
                }
            }
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
            let v11: string = Dice::method98(1_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure119(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method99(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method90(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure115(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method92(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure119(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method92(v4_1, v1_1)
                    }
                }
            }
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
        ) -> string {
            let v11: string = Dice::method98(2_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure120(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method100(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method88(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure114(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method90(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure120(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method90(v4_1, v1_1)
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
            let v11: string = Dice::method98(3_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure121(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method101(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method86(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure113(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method88(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure121(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method88(v4_1, v1_1)
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
            let v11: string = Dice::method98(4_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure122(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method102(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method84(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure112(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method86(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure122(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method86(v4_1, v1_1)
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
            let v11: string = Dice::method98(5_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure123(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method103(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method82(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure111(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method84(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure123(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method84(v4_1, v1_1)
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
            let v11: string = Dice::method98(6_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure124(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method104(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method80(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure110(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method82(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure124(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method82(v4_1, v1_1)
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
            let v11: string = Dice::method98(7_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure125(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method105(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method78(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure109(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method80(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure125(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method80(v4_1, v1_1)
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
            let v11: string = Dice::method98(8_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure126(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method106(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method76(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure108(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method78(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure126(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method78(v4_1, v1_1)
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
            let v11: string = Dice::method98(9_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure127(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method107(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method74(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure107(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method76(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure127(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method76(v4_1, v1_1)
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
            let v11: string = Dice::method98(10_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure128(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method108(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method72(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure106(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method74(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure128(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method74(v4_1, v1_1)
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
            let v11: string = Dice::method98(11_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure129(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method109(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method70(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure105(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method72(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure129(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method72(v4_1, v1_1)
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
            let v11: string = Dice::method98(12_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure130(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method110(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method68(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure104(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method70(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure130(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method70(v4_1, v1_1)
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
            let v11: string = Dice::method98(13_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure131(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method111(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method66(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure103(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method68(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure131(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method68(v4_1, v1_1)
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
            let v11: string = Dice::method98(14_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure132(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method112(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method64(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure102(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method66(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure132(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method66(v4_1, v1_1)
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
            let v11: string = Dice::method98(15_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure133(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method113(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method62(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure101(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method64(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure133(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method64(v4_1, v1_1)
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
            let v11: string = Dice::method98(16_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure134(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method114(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method60(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure100(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method62(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure134(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method62(v4_1, v1_1)
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
            let v11: string = Dice::method98(17_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure135(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method115(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method58(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure99(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method60(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure135(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method60(v4_1, v1_1)
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
            let v11: string = Dice::method98(18_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure136(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method116(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method56(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure98(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method58(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure136(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method58(v4_1, v1_1)
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
            let v11: string = Dice::method98(19_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure137(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method117(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method54(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure97(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method56(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure137(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method56(v4_1, v1_1)
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
            let v11: string = Dice::method98(20_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure138(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method118(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method52(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure96(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method54(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure138(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method54(v4_1, v1_1)
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
            let v11: string = Dice::method98(21_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure139(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method119(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method50(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure95(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method52(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure139(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method52(v4_1, v1_1)
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
            let v11: string = Dice::method98(22_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure140(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method120(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method48(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure94(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method50(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure140(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method50(v4_1, v1_1)
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
            let v11: string = Dice::method98(23_i8, v8, v9);
            Dice::method22(append(
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
        pub fn closure141(v0_1: i64, v1_1: u8, unitVar: ()) {
            fn v17() {
                Dice::closure9((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v299: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v59,
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
                Dice::US8::US8_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v108: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v107: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v106: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v105: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v125: string = Dice::method121(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Dice::method12(v105, v106, v107, v108, v109, v110),
                    Dice::method16(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v164: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v186: () = {
                    Dice::closure14(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Dice::US8::US8_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method45(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US11 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_0 => Dice::US11::US11_1,
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
                        let v322: () = {
                            Dice::closure93(v1_1, v3_1, v8, ());
                            ()
                        };
                        Dice::method48(v4_1.clone(), (v1_1) + (v8))
                    } else {
                        let v952: () = {
                            Dice::closure141(v1_1, v3_1, ());
                            ()
                        };
                        Dice::method48(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method43(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i64 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method43: loop {
                break '_method43 (if (v1_1.get().clone()) < 24_i8 {
                    let v0_1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(), v0_1.get().clone()));
                    let v1_1_temp: i8 = (v1_1.get().clone()) + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method43;
                } else {
                    let v8: Dice::US11 = Dice::method45(v0_1.get().clone(), 0_i64);
                    if let Dice::US11::US11_0(v8_0_0, v8_0_1) = &v8 {
                        let v9: i64 = v8_0_0.clone();
                        if (v9) <= i64::MAX {
                            v9
                        } else {
                            let v0_1_temp: LrcPtr<Dice::UH1> =
                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                            let v1_1_temp: i8 = 23_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method43;
                        }
                    } else {
                        let v0_1_temp: LrcPtr<Dice::UH1> =
                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_1(Dice::method44(),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0)))))))))))))))))))))))))))))))))))))))))))))));
                        let v1_1_temp: i8 = 23_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method43;
                    }
                });
            }
        }
        pub fn method123(v0_1: i64) -> string {
            let v2_1: LrcPtr<Dice::Mut5> = LrcPtr::new(Dice::Mut5 {
                l0: MutCell::new(Dice::method18()),
            });
            let v16: () = {
                Dice::closure13(v2_1.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Dice::closure13(v2_1.clone(), string("result"), ());
                ()
            };
            let v54: () = {
                Dice::closure13(v2_1.clone(), string(" = "), ());
                ()
            };
            let v74: () = {
                Dice::closure13(v2_1.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v93: () = {
                Dice::closure13(v2_1.clone(), string(" }"), ());
                ()
            };
            v2_1.l0.get().clone()
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
        ) -> string {
            let v9: string = Dice::method123(v8);
            Dice::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("dice.main"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure142(v0_1: i64, unitVar: ()) {
            fn v16() {
                Dice::closure9((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Dice::US2 = (patternInput.4.clone()).l0.get().clone();
            let v298: Dice::US8 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v58,
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
                Dice::US8::US8_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Dice::Mut6> = patternInput_1.4.clone();
                let v107: LrcPtr<Dice::Mut5> = patternInput_1.3.clone();
                let v106: LrcPtr<Dice::Mut4> = patternInput_1.2.clone();
                let v105: LrcPtr<Dice::Mut3> = patternInput_1.1.clone();
                let v104: LrcPtr<Dice::Mut1> = patternInput_1.0.clone();
                let v124: string = Dice::method122(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Dice::method12(v104, v105, v106, v107, v108, v109),
                    Dice::method16(),
                    v0_1,
                );
                let v140: () = {
                    v16();
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
                let v164: LrcPtr<Dice::Mut3> = patternInput_2.1.clone();
                let v163: LrcPtr<Dice::Mut1> = patternInput_2.0.clone();
                let v185: () = {
                    Dice::closure14(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Dice::US8::US8_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure91(unitVar: (), v0_1: Array<string>) -> i32 {
            let v314: () = {
                Dice::closure92((), ());
                ()
            };
            let v945: () = {
                Dice::closure142(Dice::method43(LrcPtr::new(Dice::UH1::UH1_0), 0_i8), ());
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
#[path = "../deps/polyglot/deps/spiral/lib/spiral/async_.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/common.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/crypto.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/date_time.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/file_system.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/lib.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/networking.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/platform.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/runtime.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/sm.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/threading.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../deps/polyglot/deps/spiral/lib/spiral/trace.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../deps/polyglot/lib/fsharp/Common.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::main(array_from(args));
}
