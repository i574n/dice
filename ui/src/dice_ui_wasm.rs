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
mod module_eef1bd43 {
    pub mod Dice_ui {
        use super::*;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::NativeArray_::count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofArray;
        use fable_library_rust::Seq_::toArray;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofBoolean;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::substring2;
        use fable_library_rust::String_::toString;
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0,
            US0_1(web_sys::HtmlElement),
        }
        impl Dice_ui::US0 {
            pub fn get_IsUS0_0(this_: &MutCell<Dice_ui::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_1(this_: &MutCell<Dice_ui::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(
            Clone,
            Copy,
            Debug,
            PartialEq,
            PartialOrd,
            Hash,
            Eq,
            serde::Serialize,
            serde::Deserialize,
            borsh::BorshSerialize,
            borsh::BorshDeserialize,
            Default,
        )]
        pub enum US1 {
            #[default]
            US1_0,
            US1_1,
        }
        impl Dice_ui::US1 {
            pub fn get_IsUS1_0(this_: &MutCell<Dice_ui::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_1(this_: &MutCell<Dice_ui::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(
            Clone,
            Debug,
            serde::Serialize,
            serde::Deserialize,
            borsh::BorshSerialize,
            borsh::BorshDeserialize,
            Default,
        )]
        pub struct Heap0 {
            pub l0: Vec<LrcPtr<(bool, std::string::String)>>,
            pub l1: Dice_ui::US1,
        }
        impl core::fmt::Display for Dice_ui::Heap0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap1 {
            pub l0: leptos::RwSignal<bool>,
            pub l1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
            pub l2: leptos::RwSignal<bool>,
            pub l3: leptos::RwSignal<std::string::String>,
        }
        impl core::fmt::Display for Dice_ui::Heap1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap2 {
            pub l0: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>>,
            pub l1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        }
        impl core::fmt::Display for Dice_ui::Heap2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0,
            US2_1,
        }
        impl Dice_ui::US2 {
            pub fn get_IsUS2_0(this_: &MutCell<Dice_ui::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS2_1(this_: &MutCell<Dice_ui::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0(rexie::Error),
            US3_1(rexie::Rexie),
        }
        impl Dice_ui::US3 {
            pub fn get_IsUS3_0(this_: &MutCell<Dice_ui::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS3_1(this_: &MutCell<Dice_ui::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(
            Clone,
            Debug,
            serde::Serialize,
            serde::Deserialize,
            borsh::BorshSerialize,
            borsh::BorshDeserialize,
        )]
        pub struct Heap3 {
            pub l0: bool,
            pub l1: LrcPtr<Dice_ui::Heap0>,
            pub l2: bool,
            pub l3: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0,
            US4_1(LrcPtr<Dice_ui::Heap3>),
        }
        impl Dice_ui::US4 {
            pub fn get_IsUS4_0(this_: &MutCell<Dice_ui::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS4_1(this_: &MutCell<Dice_ui::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0,
            US5_1(rexie::Rexie),
        }
        impl Dice_ui::US5 {
            pub fn get_IsUS5_0(this_: &MutCell<Dice_ui::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS5_1(this_: &MutCell<Dice_ui::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0,
            US6_1(Dice_ui::US4),
        }
        impl Dice_ui::US6 {
            pub fn get_IsUS6_0(this_: &MutCell<Dice_ui::US6>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS6_1(this_: &MutCell<Dice_ui::US6>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0,
            US7_1(serde_json::Value),
        }
        impl Dice_ui::US7 {
            pub fn get_IsUS7_0(this_: &MutCell<Dice_ui::US7>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS7_1(this_: &MutCell<Dice_ui::US7>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(std::string::String),
            US8_1(Dice_ui::US4),
        }
        impl Dice_ui::US8 {
            pub fn get_IsUS8_0(this_: &MutCell<Dice_ui::US8>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS8_1(this_: &MutCell<Dice_ui::US8>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(wasm_bindgen::JsValue),
            US9_1(Option<web_sys::Storage>),
        }
        impl Dice_ui::US9 {
            pub fn get_IsUS9_0(this_: &MutCell<Dice_ui::US9>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS9_1(this_: &MutCell<Dice_ui::US9>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0,
            US11_1(web_sys::Storage),
        }
        impl Dice_ui::US11 {
            pub fn get_IsUS11_0(this_: &MutCell<Dice_ui::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS11_1(this_: &MutCell<Dice_ui::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(wasm_bindgen::JsValue),
            US10_1(Dice_ui::US11),
        }
        impl Dice_ui::US10 {
            pub fn get_IsUS10_0(this_: &MutCell<Dice_ui::US10>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS10_1(this_: &MutCell<Dice_ui::US10>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(wasm_bindgen::JsValue),
            US12_1(Option<std::string::String>),
        }
        impl Dice_ui::US12 {
            pub fn get_IsUS12_0(this_: &MutCell<Dice_ui::US12>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS12_1(this_: &MutCell<Dice_ui::US12>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0,
            US14_1(std::string::String),
        }
        impl Dice_ui::US14 {
            pub fn get_IsUS14_0(this_: &MutCell<Dice_ui::US14>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS14_1(this_: &MutCell<Dice_ui::US14>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(wasm_bindgen::JsValue),
            US13_1(Dice_ui::US14),
        }
        impl Dice_ui::US13 {
            pub fn get_IsUS13_0(this_: &MutCell<Dice_ui::US13>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS13_1(this_: &MutCell<Dice_ui::US13>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0,
            US15_1(Dice_ui::US14),
        }
        impl Dice_ui::US15 {
            pub fn get_IsUS15_0(this_: &MutCell<Dice_ui::US15>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS15_1(this_: &MutCell<Dice_ui::US15>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(rexie::Error),
            US16_1,
        }
        impl Dice_ui::US16 {
            pub fn get_IsUS16_0(this_: &MutCell<Dice_ui::US16>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS16_1(this_: &MutCell<Dice_ui::US16>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0,
            US17_1(leptos::RwSignal<bool>),
        }
        impl Dice_ui::US17 {
            pub fn get_IsUS17_0(this_: &MutCell<Dice_ui::US17>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS17_1(this_: &MutCell<Dice_ui::US17>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US18 {
            US18_0,
            US18_1(bool),
        }
        impl Dice_ui::US18 {
            pub fn get_IsUS18_0(this_: &MutCell<Dice_ui::US18>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS18_1(this_: &MutCell<Dice_ui::US18>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US20 {
            US20_0,
        }
        impl Dice_ui::US20 {
            pub fn get_IsUS20_0(this_: &MutCell<Dice_ui::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US19 {
            US19_0,
            US19_1(Dice_ui::US20),
            US19_2,
            US19_3,
            US19_4,
        }
        impl Dice_ui::US19 {
            pub fn get_IsUS19_0(this_: &MutCell<Dice_ui::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS19_1(this_: &MutCell<Dice_ui::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS19_2(this_: &MutCell<Dice_ui::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS19_3(this_: &MutCell<Dice_ui::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS19_4(this_: &MutCell<Dice_ui::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(std::string::String),
            US21_1(leptos_router::Url),
        }
        impl Dice_ui::US21 {
            pub fn get_IsUS21_0(this_: &MutCell<Dice_ui::US21>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS21_1(this_: &MutCell<Dice_ui::US21>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US22 {
            US22_0,
            US22_1(Dice_ui::US19),
        }
        impl Dice_ui::US22 {
            pub fn get_IsUS22_0(this_: &MutCell<Dice_ui::US22>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS22_1(this_: &MutCell<Dice_ui::US22>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<Dice_ui::US22>,
        }
        impl core::fmt::Display for Dice_ui::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0,
            US23_1(leptos::Fragment),
        }
        impl Dice_ui::US23 {
            pub fn get_IsUS23_0(this_: &MutCell<Dice_ui::US23>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS23_1(this_: &MutCell<Dice_ui::US23>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::string::String),
            US24_1(std::string::String),
        }
        impl Dice_ui::US24 {
            pub fn get_IsUS24_0(this_: &MutCell<Dice_ui::US24>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS24_1(this_: &MutCell<Dice_ui::US24>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US25 {
            US25_0,
            US25_1(string),
        }
        impl Dice_ui::US25 {
            pub fn get_IsUS25_0(this_: &MutCell<Dice_ui::US25>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS25_1(this_: &MutCell<Dice_ui::US25>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US26 {
            US26_0(string),
            US26_1(Option<string>),
        }
        impl Dice_ui::US26 {
            pub fn get_IsUS26_0(this_: &MutCell<Dice_ui::US26>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS26_1(this_: &MutCell<Dice_ui::US26>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(
            Clone,
            Debug,
            Default,
            serde::Serialize,
            serde::Deserialize,
            borsh::BorshSerialize,
            borsh::BorshDeserialize,
            PartialEq,
        )]
        pub struct Heap4 {
            pub l0: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0,
            US27_1(LrcPtr<Dice_ui::Heap4>),
        }
        impl Dice_ui::US27 {
            pub fn get_IsUS27_0(this_: &MutCell<Dice_ui::US27>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS27_1(this_: &MutCell<Dice_ui::US27>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(std::string::String),
            US28_1(Dice_ui::US27),
        }
        impl Dice_ui::US28 {
            pub fn get_IsUS28_0(this_: &MutCell<Dice_ui::US28>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS28_1(this_: &MutCell<Dice_ui::US28>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0,
            US29_1(Option<LrcPtr<Dice_ui::Heap4>>),
        }
        impl Dice_ui::US29 {
            pub fn get_IsUS29_0(this_: &MutCell<Dice_ui::US29>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS29_1(this_: &MutCell<Dice_ui::US29>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0,
            US30_1(Dice_ui::US27),
        }
        impl Dice_ui::US30 {
            pub fn get_IsUS30_0(this_: &MutCell<Dice_ui::US30>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS30_1(this_: &MutCell<Dice_ui::US30>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US31 {
            US31_0,
            US31_1(Result<Option<string>, string>),
        }
        impl Dice_ui::US31 {
            pub fn get_IsUS31_0(this_: &MutCell<Dice_ui::US31>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS31_1(this_: &MutCell<Dice_ui::US31>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US32 {
            US32_0,
            US32_1(Dice_ui::US26),
        }
        impl Dice_ui::US32 {
            pub fn get_IsUS32_0(this_: &MutCell<Dice_ui::US32>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS32_1(this_: &MutCell<Dice_ui::US32>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US34 {
            US34_0(string),
            US34_1(Dice_ui::US25),
        }
        impl Dice_ui::US34 {
            pub fn get_IsUS34_0(this_: &MutCell<Dice_ui::US34>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS34_1(this_: &MutCell<Dice_ui::US34>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US33 {
            US33_0,
            US33_1(Dice_ui::US34),
        }
        impl Dice_ui::US33 {
            pub fn get_IsUS33_0(this_: &MutCell<Dice_ui::US33>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS33_1(this_: &MutCell<Dice_ui::US33>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(std::string::String),
            US35_1(Dice_ui::US14),
        }
        impl Dice_ui::US35 {
            pub fn get_IsUS35_0(this_: &MutCell<Dice_ui::US35>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS35_1(this_: &MutCell<Dice_ui::US35>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq)]
        pub struct Heap5 {
            pub l0: Array<(std::string::String, Option<std::string::String>)>,
            pub l1: f64,
            pub l2: u32,
            pub l3: std::string::String,
            pub l4: std::string::String,
            pub l5: Array<std::string::String>,
            pub l6: bool,
            pub l7: f64,
            pub l8: std::string::String,
            pub l9: std::string::String,
            pub l10: std::string::String,
            pub l11: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0(std::string::String),
            US36_1(
                Option<
                    Array<(
                        Array<(std::string::String, Option<std::string::String>)>,
                        f64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    )>,
                >,
            ),
        }
        impl Dice_ui::US36 {
            pub fn get_IsUS36_0(this_: &MutCell<Dice_ui::US36>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS36_1(this_: &MutCell<Dice_ui::US36>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US38 {
            US38_0,
            US38_1(Array<(usize, LrcPtr<Dice_ui::Heap5>)>),
        }
        impl Dice_ui::US38 {
            pub fn get_IsUS38_0(this_: &MutCell<Dice_ui::US38>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS38_1(this_: &MutCell<Dice_ui::US38>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US38 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0(std::string::String),
            US37_1(Dice_ui::US38),
        }
        impl Dice_ui::US37 {
            pub fn get_IsUS37_0(this_: &MutCell<Dice_ui::US37>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS37_1(this_: &MutCell<Dice_ui::US37>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US39 {
            US39_0,
            US39_1(
                Array<(
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        }
        impl Dice_ui::US39 {
            pub fn get_IsUS39_0(this_: &MutCell<Dice_ui::US39>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS39_1(this_: &MutCell<Dice_ui::US39>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US39 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US40 {
            US40_0(std::string::String),
            US40_1(Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>),
        }
        impl Dice_ui::US40 {
            pub fn get_IsUS40_0(this_: &MutCell<Dice_ui::US40>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS40_1(this_: &MutCell<Dice_ui::US40>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US40 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US41 {
            US41_0,
            US41_1(chrono::DateTime<chrono::Utc>),
        }
        impl Dice_ui::US41 {
            pub fn get_IsUS41_0(this_: &MutCell<Dice_ui::US41>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS41_1(this_: &MutCell<Dice_ui::US41>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US41 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US42 {
            US42_0(string),
            US42_1(string),
        }
        impl Dice_ui::US42 {
            pub fn get_IsUS42_0(this_: &MutCell<Dice_ui::US42>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS42_1(this_: &MutCell<Dice_ui::US42>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US42 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0(v0_1: string) -> string {
            v0_1
        }
        pub fn closure1(unitVar: (), v0_1: web_sys::HtmlElement) -> Dice_ui::US0 {
            Dice_ui::US0::US0_1(v0_1)
        }
        pub fn method1() -> string {
            string("")
        }
        pub fn method2(v0_1: web_sys::HtmlElement) -> web_sys::HtmlElement {
            v0_1
        }
        pub fn method4() -> bool {
            false
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn method7(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method8() -> string {
            string("i574n.near")
        }
        pub fn method9() -> string {
            string("luckier.near")
        }
        pub fn method10(
            v0_1: Array<LrcPtr<(bool, std::string::String)>>,
        ) -> Array<LrcPtr<(bool, std::string::String)>> {
            v0_1
        }
        pub fn method11(
            v0_1: Array<LrcPtr<(bool, std::string::String)>>,
        ) -> Array<LrcPtr<(bool, std::string::String)>> {
            v0_1
        }
        pub fn method12(v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
            v0_1
        }
        pub fn method13(v0_1: LrcPtr<Dice_ui::Heap1>) -> LrcPtr<Dice_ui::Heap1> {
            v0_1
        }
        pub fn method14(
            v0_1: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method17() -> string {
            string("")
        }
        pub fn method18(v0_1: string) -> string {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> Dice_ui::US2 {
            Dice_ui::US2::US2_0
        }
        pub fn method20() -> Func0<Dice_ui::US2> {
            Func0::new(move || Dice_ui::closure6((), ()))
        }
        pub fn closure8(unitVar: (), v0_1: rexie::Rexie) -> Dice_ui::US3 {
            Dice_ui::US3::US3_1(v0_1)
        }
        pub fn closure9(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US3 {
            Dice_ui::US3::US3_0(v0_1)
        }
        pub fn method21(v0_1: Dice_ui::US3) -> Dice_ui::US3 {
            v0_1
        }
        pub fn method22(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure7(
            unitVar: (),
            v0_1: Dice_ui::US2,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = rexie::Rexie>>> {
            let __future_init = Box::pin(async move {
                //;
                {
                    let v3: string = Dice_ui::method0(string(
                        "state_core.use_database (2) / database create_local_resource",
                    ));
                    leptos::logging::log!("{}", v3);
                    {
                        let v6: string = Dice_ui::method0(string("state_core.build_database ()"));
                        leptos::logging::log!("{}", v6);
                        let __future_init = Box::pin(async {
                            //;
                            {
                                let v9: string =
                            string("Box::pin(rexie::Rexie::builder(\"database\").version(1).add_object_store(rexie::ObjectStore::new(\"store\")).build())");
                                let v10: std::pin::Pin<
                                    Box<
                                        dyn std::future::Future<
                                            Output = Result<rexie::Rexie, rexie::Error>,
                                        >,
                                    >,
                                > = Box::pin(
                                    rexie::Rexie::builder("database")
                                        .version(1)
                                        .add_object_store(rexie::ObjectStore::new("store"))
                                        .build(),
                                );
                                let v12: Result<rexie::Rexie, rexie::Error> = v10.await;
                                let v16: Dice_ui::US3 = Dice_ui::method21(match &v12 {
                                    Err(v12_1_0) => Dice_ui::closure9((), v12_1_0.clone()),
                                    Ok(v12_0_0) => Dice_ui::closure8((), v12_0_0.clone()),
                                });
                                v16
                            }
                        });
                        {
                            let v19: std::pin::Pin<
                                Box<dyn std::future::Future<Output = Dice_ui::US3>>,
                            > = __future_init;
                            let v21: Dice_ui::US3 = v19.await;
                            let v27: rexie::Rexie = match &v21 {
                                Dice_ui::US3::US3_1(v21_1_0) => v21_1_0.clone(),
                                Dice_ui::US3::US3_0(v21_0_0) => panic!(
                                    "{}",
                                    sprintf!("resultm.get / Result value was Error: {}", v21_0_0),
                                ),
                            };
                            let v30: string =
                                Dice_ui::method0(append(append(string("state_core.use_database (3) / database create_local_resource / result: "),
                                                               sprintf!("{:?}",
                                                                        &v27)),
                                                        string("")));
                            leptos::logging::log!("{}", v30);
                            {
                                let v32: rexie::Rexie = Dice_ui::method22(v27);
                                v32
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            {
                                //;
                                __future_init
                            }
                        }
                    }
                }
            }
        }
        pub fn method24(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US2, rexie::Rexie> {
            v0_1
        }
        pub fn closure10(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method24(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method23(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure10(v0_1.clone(), ())
            })
        }
        pub fn closure12(unitVar: (), v0_1: rexie::Rexie) -> Dice_ui::US5 {
            Dice_ui::US5::US5_1(v0_1)
        }
        pub fn method25(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: string) -> std::string::String {
            let v2: string = Dice_ui::method6(Dice_ui::method18(v0_1));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            String::from(v4)
        }
        pub fn method26() -> Func1<string, std::string::String> {
            Func1::new(move |v: string| Dice_ui::closure13((), v))
        }
        pub fn method27(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn method28(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method29(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure14(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method30() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure14((), v))
        }
        pub fn method31() -> string {
            string("store")
        }
        pub fn closure15(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method32() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure15((), v))
        }
        pub fn method33() -> string {
            string("core-state-heap")
        }
        pub fn closure16(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method34() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure16((), v))
        }
        pub fn method35(v0_1: wasm_bindgen::JsValue) -> wasm_bindgen::JsValue {
            v0_1
        }
        pub fn closure17(unitVar: (), v0_1: serde_wasm_bindgen::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method36() -> Func1<serde_wasm_bindgen::Error, std::string::String> {
            Func1::new(move |v: serde_wasm_bindgen::Error| Dice_ui::closure17((), v))
        }
        pub fn closure18(unitVar: (), v0_1: serde_json::Value) -> Dice_ui::US7 {
            Dice_ui::US7::US7_1(v0_1)
        }
        pub fn method37(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn closure19(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method38() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure19((), v))
        }
        pub fn method39(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method40(v0_1: Array<u8>) -> Array<u8> {
            v0_1
        }
        pub fn closure20(unitVar: (), v0_1: borsh::io::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method41() -> Func1<borsh::io::Error, std::string::String> {
            Func1::new(move |v: borsh::io::Error| Dice_ui::closure20((), v))
        }
        pub fn method42(
            v0_1: Result<Dice_ui::US4, std::string::String>,
        ) -> Result<Dice_ui::US4, std::string::String> {
            v0_1
        }
        pub fn closure21(unitVar: (), v0_1: Dice_ui::US4) -> Dice_ui::US8 {
            Dice_ui::US8::US8_1(v0_1)
        }
        pub fn closure22(unitVar: (), v0_1: std::string::String) -> Dice_ui::US8 {
            Dice_ui::US8::US8_0(v0_1)
        }
        pub fn method43(v0_1: Dice_ui::US4) -> Dice_ui::US4 {
            v0_1
        }
        pub fn closure11(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Dice_ui::US4>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v4: string =
                    Dice_ui::method0(append(append(string("state_core.use_core_database (2) / core_state_heap create_local_resource / database: "),
                                                   sprintf!("{:?}", &v0_1)),
                                            string("")));
                    leptos::logging::log!("{}", v4);
                    {
                        let v8: Dice_ui::US5 = defaultValue(
                            Dice_ui::US5::US5_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                v0_1,
                            ),
                        );
                        let v124: Dice_ui::US6 = match &v8 {
                            Dice_ui::US5::US5_1(v8_1_0) => {
                                let v12: string = Dice_ui::method0(string(
                                    "state_core.get_data () / id: core-state-heap",
                                ));
                                leptos::logging::log!("{}", v12);
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v17: Array<string> =
                                            Dice_ui::method25(new_array(&[string("store")]));
                                        let v18 = Dice_ui::method26();
                                        let v19: Array<string> = Dice_ui::method27(v17);
                                        let v21: Vec<string> = v19.to_vec();
                                        let v24: Vec<std::string::String> = Dice_ui::method28(
                                            v21.iter().map(|x| v18(x.clone())).collect(),
                                        );
                                        let v26: Array<std::string::String> =
                                            fable_library_rust::NativeArray_::array_from(v24);
                                        let v27: rexie::Rexie = Dice_ui::method29(v8_1_0.clone());
                                        let v29: Result<rexie::Transaction, rexie::Error> =
                                            v27.transaction(&v26, rexie::TransactionMode::ReadOnly);
                                        let v30 = Dice_ui::method30();
                                        let v32: Result<rexie::Transaction, std::string::String> =
                                            v29.map_err(|x| v30(x));
                                        let v34: rexie::Transaction = v32?;
                                        let v35: string = Dice_ui::method31();
                                        let v37: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v35);
                                        let v39: Result<rexie::Store, rexie::Error> =
                                            v34.store(v37);
                                        let v40 = Dice_ui::method32();
                                        let v42: Result<rexie::Store, std::string::String> =
                                            v39.map_err(|x| v40(x));
                                        let v44: rexie::Store = v42?;
                                        let v45: string = Dice_ui::method33();
                                        let v47: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v45);
                                        let v49: wasm_bindgen::JsValue =
                                            wasm_bindgen::JsValue::from_str(v47);
                                        let v51: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        wasm_bindgen::JsValue,
                                                        rexie::Error,
                                                    >,
                                                >,
                                            >,
                                        > = Box::pin(rexie::Store::get(&v44, &v49));
                                        let v53: Result<wasm_bindgen::JsValue, rexie::Error> =
                                            v51.await;
                                        let v54 = Dice_ui::method34();
                                        let v56: Result<
                                            wasm_bindgen::JsValue,
                                            std::string::String,
                                        > = v53.map_err(|x| v54(x));
                                        let v59: wasm_bindgen::JsValue = Dice_ui::method35(v56?);
                                        let v61: Result<
                                            Option<serde_json::Value>,
                                            serde_wasm_bindgen::Error,
                                        > = serde_wasm_bindgen::from_value(v59);
                                        let v62 = Dice_ui::method36();
                                        let v64: Result<
                                            Option<serde_json::Value>,
                                            std::string::String,
                                        > = v61.map_err(|x| v62(x));
                                        let v69: Dice_ui::US7 = defaultValue(
                                            Dice_ui::US7::US7_0,
                                            map(
                                                Func1::new(move |v_1: serde_json::Value| {
                                                    Dice_ui::closure18((), v_1)
                                                }),
                                                v64?,
                                            ),
                                        );
                                        let v104: Result<Dice_ui::US4, std::string::String> =
                                            Dice_ui::method42(Ok::<
                                                Dice_ui::US4,
                                                std::string::String,
                                            >(
                                                match &v69 {
                                                Dice_ui::US7::US7_1(v69_1_0) => {
                                                    let v71: serde_json::Value =
                                                        Dice_ui::method37(v69_1_0.clone());
                                                    let v73: Result<Vec<u8>, serde_json::Error> =
                                                        serde_json::from_value(v71);
                                                    let v74 = Dice_ui::method38();
                                                    let v76: Result<Vec<u8>, std::string::String> =
                                                        v73.map_err(|x| v74(x));
                                                    let v79: Vec<u8> = Dice_ui::method39(v76?);
                                                    let v81:
                                                                                                    Array<u8> =
                                                                                                fable_library_rust::NativeArray_::array_from(v79);
                                                    let v84:
                                                                                                    string =
                                                                                                Dice_ui::method0(append(append(string("state_core.get_data () / data_len: "),
                                                                                                                               toString(count(v81.clone()))),
                                                                                                                        string("")));
                                                    leptos::logging::log!("{}", v84);
                                                    {
                                                        let v86: Array<u8> = Dice_ui::method40(v81);
                                                        let v88: Vec<u8> = v86.to_vec();
                                                        let v90: &[u8] = v88.as_slice();
                                                        let mut v90 = v90;
                                                        {
                                                            let v93:
                                                                                                            Result<LrcPtr<Dice_ui::Heap3>,
                                                                                                                   borsh::io::Error> =
                                                                                                        borsh::BorshDeserialize::deserialize(&mut v90);
                                                            let v94 = Dice_ui::method41();
                                                            let v96: Result<
                                                                LrcPtr<Dice_ui::Heap3>,
                                                                std::string::String,
                                                            > = v93.map_err(|x| v94(x));
                                                            Dice_ui::US4::US4_1(v96?)
                                                        }
                                                    }
                                                }
                                                _ => Dice_ui::US4::US4_0,
                                            }
                                            ));
                                        v104
                                    }
                                });
                                {
                                    //;
                                    {
                                        let v107: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        Dice_ui::US4,
                                                        std::string::String,
                                                    >,
                                                >,
                                            >,
                                        > = __future_init;
                                        let v109: Result<Dice_ui::US4, std::string::String> =
                                            v107.await;
                                        let v112: Dice_ui::US8 = match &v109 {
                                            Err(v109_1_0) => {
                                                Dice_ui::closure22((), v109_1_0.clone())
                                            }
                                            Ok(v109_0_0) => {
                                                Dice_ui::closure21((), v109_0_0.clone())
                                            }
                                        };
                                        match &v112 {
                                            Dice_ui::US8::US8_1(v112_1_0) => {
                                                Dice_ui::US6::US6_1(v112_1_0.clone())
                                            }
                                            Dice_ui::US8::US8_0(v112_0_0) => {
                                                let v117: string =
                                                    Dice_ui::method0(append(append(string("state_core.use_core_database (2.1) / error: "),
                                                                                   toString(v112_0_0.clone())),
                                                                            string("")));
                                                leptos::logging::log!("{}", v117);
                                                Dice_ui::US6::US6_0
                                            }
                                        }
                                    }
                                }
                            }
                            _ => Dice_ui::US6::US6_0,
                        };
                        let v132: Dice_ui::US4 =
                            Dice_ui::method43(if let Dice_ui::US6::US6_1(v124_1_0) = &v124 {
                                let v125: Dice_ui::US4 = match &v124 {
                                    Dice_ui::US6::US6_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Dice_ui::US4::US4_1(v125_1_0) = &v125 {
                                    Dice_ui::US4::US4_1(match &v125 {
                                        Dice_ui::US4::US4_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    Dice_ui::US4::US4_0
                                }
                            } else {
                                Dice_ui::US4::US4_0
                            });
                        v132
                    }
                }
            });
            {
                {
                    //;
                    __future_init
                }
            }
        }
        pub fn method45() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method47(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method46(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Dice_ui::method47(v0_1);
            v1.local_storage()
        }
        pub fn closure24(unitVar: (), v0_1: Option<web_sys::Storage>) -> Dice_ui::US9 {
            Dice_ui::US9::US9_1(v0_1)
        }
        pub fn closure25(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US9 {
            Dice_ui::US9::US9_0(v0_1)
        }
        pub fn closure26(unitVar: (), v0_1: web_sys::Storage) -> Dice_ui::US11 {
            Dice_ui::US11::US11_1(v0_1)
        }
        pub fn method48(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4> {
            v0_1
        }
        pub fn closure27(unitVar: (), v0_1: Dice_ui::US4) -> Dice_ui::US6 {
            Dice_ui::US6::US6_1(v0_1)
        }
        pub fn method49(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn closure28(unitVar: (), v0_1: Option<std::string::String>) -> Dice_ui::US12 {
            Dice_ui::US12::US12_1(v0_1)
        }
        pub fn closure29(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US12 {
            Dice_ui::US12::US12_0(v0_1)
        }
        pub fn method50(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure30(unitVar: (), v0_1: std::string::String) -> Dice_ui::US14 {
            Dice_ui::US14::US14_1(v0_1)
        }
        pub fn method51(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method52(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure31(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method53() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure31((), v))
        }
        pub fn closure32(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap3>) -> Dice_ui::US4 {
            Dice_ui::US4::US4_1(v0_1)
        }
        pub fn method55(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> {
            v0_1
        }
        pub fn closure34(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            let v3: string =
                Dice_ui::method0(string("state_core.use_core_database (5.1) / effect core_state_heap / dark_mode signal_update"));
            leptos::logging::log!("{}", v3);
            v0_1.l0
        }
        pub fn method56(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure34(v0_1.clone(), v)
            })
        }
        pub fn method57(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure35(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            let v3: string = Dice_ui::method0(string(
                "state_core.use_core_database (5.2) / effect core_state_heap / debug signal_update",
            ));
            leptos::logging::log!("{}", v3);
            v0_1.l2
        }
        pub fn method58(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure35(v0_1.clone(), v)
            })
        }
        pub fn closure36(
            v0_1: LrcPtr<Dice_ui::Heap3>,
            v1: std::string::String,
        ) -> std::string::String {
            let v3: string =
                Dice_ui::method0(string("state_core.use_core_database (5.3) / effect core_state_heap / url_hash signal_update"));
            leptos::logging::log!("{}", v3);
            v0_1.l3.clone()
        }
        pub fn method59(
            v0_1: LrcPtr<Dice_ui::Heap3>,
        ) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure36(v0_1.clone(), v)
            })
        }
        pub fn method60(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure37(
            v0_1: LrcPtr<Dice_ui::Heap3>,
            v1: LrcPtr<Dice_ui::Heap0>,
        ) -> LrcPtr<Dice_ui::Heap0> {
            let v3: string = Dice_ui::method0(string(
                "state_core.use_core_database (5.3) / effect core_state_heap / data signal_update",
            ));
            leptos::logging::log!("{}", v3);
            v0_1.l1.clone()
        }
        pub fn method61(
            v0_1: LrcPtr<Dice_ui::Heap3>,
        ) -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure37(v0_1.clone(), v)
            })
        }
        pub fn method62(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure33(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap3>, unitVar: ()) {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v2.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method56(v1.clone());
            let v8: leptos::RwSignal<bool> = Dice_ui::method57(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            {
                let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v2.clone());
                let v12: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v10);
                let v14 = Dice_ui::method58(v1.clone());
                let v15: leptos::RwSignal<bool> = Dice_ui::method57(v12.l2.clone());
                leptos::SignalUpdate::update(&v15, |x| *x = v14(x.clone()));
                {
                    let v17: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                        Dice_ui::method55(v2.clone());
                    let v19: LrcPtr<Dice_ui::Heap1> =
                        leptos::SignalGetUntracked::get_untracked(&v17);
                    let v21 = Dice_ui::method59(v1.clone());
                    let v22: leptos::RwSignal<std::string::String> =
                        Dice_ui::method60(v19.l3.clone());
                    leptos::SignalUpdate::update(&v22, |x| *x = v21(x.clone()));
                    {
                        let v24: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v2);
                        let v26: LrcPtr<Dice_ui::Heap1> =
                            leptos::SignalGetUntracked::get_untracked(&v24);
                        let v28 = Dice_ui::method61(v1);
                        let v29: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                            Dice_ui::method62(v26.l1.clone());
                        leptos::SignalUpdate::update(&v29, |x| *x = v28(x.clone()));
                        ()
                    }
                }
            }
        }
        pub fn method54(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap3>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure33(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method63(v0_1: Func0<()>) -> Func0<()> {
            v0_1
        }
        pub fn closure23(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4>,
            unitVar: (),
        ) {
            let v3: string = Dice_ui::method0(string(
                "state_core.use_core_database (3) / effect core_state_heap / ##1",
            ));
            leptos::logging::log!("{}", v3);
            {
                let v6: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method46(Dice_ui::method45());
                let v9: Dice_ui::US9 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure25((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure24((), v6_0_0.clone()),
                };
                let v18: Dice_ui::US10 = match &v9 {
                    Dice_ui::US9::US9_1(v9_1_0) => Dice_ui::US10::US10_1(defaultValue(
                        Dice_ui::US11::US11_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure26((), v_2)),
                            v9_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US9::US9_0(v9_0_0) => Dice_ui::US10::US10_0(v9_0_0.clone()),
                };
                if let Dice_ui::US10::US10_1(v18_1_0) = &v18 {
                    let v19: Dice_ui::US11 = match &v18 {
                        Dice_ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US11::US11_1(v19_1_0) = &v19 {
                        let v20: web_sys::Storage = match &v19 {
                            Dice_ui::US11::US11_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v21: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4> =
                            Dice_ui::method48(v1);
                        let v26: Dice_ui::US6 = defaultValue(
                            Dice_ui::US6::US6_0,
                            map(
                                Func1::new(move |v_3: Dice_ui::US4| Dice_ui::closure27((), v_3)),
                                leptos::SignalGet::get(&v21),
                            ),
                        );
                        let v29: string =
                            Dice_ui::method0(append(append(string("state_core.use_core_database (4) / effect core_state_heap / ##2 / core_state_heap: "),
                                                           sprintf!("{:?}",
                                                                    &v26)),
                                                    string("")));
                        leptos::logging::log!("{}", v29);
                        {
                            let v161: Dice_ui::US4 = if let Dice_ui::US6::US6_1(v26_1_0) = &v26 {
                                let v31: Dice_ui::US4 = match &v26 {
                                    Dice_ui::US6::US6_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Dice_ui::US4::US4_1(v31_1_0) = &v31 {
                                    Dice_ui::US4::US4_1(match &v31 {
                                        Dice_ui::US4::US4_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v34: web_sys::Storage = Dice_ui::method49(v20.clone());
                                    let v35: string = Dice_ui::method33();
                                    let v37: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v35);
                                    let v39: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v34, v37);
                                    let v42: Dice_ui::US12 = match &v39 {
                                        Err(v39_1_0) => Dice_ui::closure29((), v39_1_0.clone()),
                                        Ok(v39_0_0) => Dice_ui::closure28((), v39_0_0.clone()),
                                    };
                                    let v54: Dice_ui::US13 = match &v42 {
                                        Dice_ui::US12::US12_1(v42_1_0) => {
                                            let v44: Option<std::string::String> =
                                                Dice_ui::method50(v42_1_0.clone());
                                            Dice_ui::US13::US13_1(defaultValue(
                                                Dice_ui::US14::US14_0,
                                                map(
                                                    Func1::new(move |v_6: std::string::String| {
                                                        Dice_ui::closure30((), v_6)
                                                    }),
                                                    serde_json::from_value(v44.into()).unwrap(),
                                                ),
                                            ))
                                        }
                                        Dice_ui::US12::US12_0(v42_0_0) => {
                                            Dice_ui::US13::US13_0(v42_0_0.clone())
                                        }
                                    };
                                    let v60: Dice_ui::US15 = match &v54 {
                                        Dice_ui::US13::US13_1(v54_1_0) => {
                                            Dice_ui::US15::US15_1(v54_1_0.clone())
                                        }
                                        _ => Dice_ui::US15::US15_0,
                                    };
                                    let v67: Dice_ui::US14 =
                                        if let Dice_ui::US15::US15_1(v60_1_0) = &v60 {
                                            let v61: Dice_ui::US14 = match &v60 {
                                                Dice_ui::US15::US15_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if let Dice_ui::US14::US14_1(v61_1_0) = &v61 {
                                                Dice_ui::US14::US14_1(match &v61 {
                                                    Dice_ui::US14::US14_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            } else {
                                                Dice_ui::US14::US14_0
                                            }
                                        } else {
                                            Dice_ui::US14::US14_0
                                        };
                                    let v89: Dice_ui::US6 = match &v67 {
                                        Dice_ui::US14::US14_1(v67_1_0) => {
                                            let v70: std::string::String = Dice_ui::method52(
                                                Dice_ui::method51(v67_1_0.clone()),
                                            );
                                            let v73: string = Dice_ui::method6(
                                                fable_library_rust::String_::fromString(v70),
                                            );
                                            let v75: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v73);
                                            let v77: Result<
                                                LrcPtr<Dice_ui::Heap3>,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v75);
                                            let v78 = Dice_ui::method53();
                                            let v80: Result<
                                                LrcPtr<Dice_ui::Heap3>,
                                                std::string::String,
                                            > = v77.map_err(|x| v78(x));
                                            Dice_ui::US6::US6_1(defaultValue(
                                                Dice_ui::US4::US4_0,
                                                map(
                                                    Func1::new(
                                                        move |v_7: LrcPtr<Dice_ui::Heap3>| {
                                                            Dice_ui::closure32((), v_7)
                                                        },
                                                    ),
                                                    v80.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Dice_ui::US6::US6_0,
                                    };
                                    if let Dice_ui::US6::US6_1(v89_1_0) = &v89 {
                                        let v90: Dice_ui::US4 = match &v89 {
                                            Dice_ui::US6::US6_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US4::US4_1(v90_1_0) = &v90 {
                                            Dice_ui::US4::US4_1(match &v90 {
                                                Dice_ui::US4::US4_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Dice_ui::US4::US4_0
                                        }
                                    } else {
                                        Dice_ui::US4::US4_0
                                    }
                                }
                            } else {
                                let v98: web_sys::Storage = Dice_ui::method49(v20);
                                let v99: string = Dice_ui::method33();
                                let v101: &str = fable_library_rust::String_::LrcStr::as_str(&v99);
                                let v103: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v98, v101);
                                let v106: Dice_ui::US12 = match &v103 {
                                    Err(v103_1_0) => Dice_ui::closure29((), v103_1_0.clone()),
                                    Ok(v103_0_0) => Dice_ui::closure28((), v103_0_0.clone()),
                                };
                                let v118: Dice_ui::US13 = match &v106 {
                                    Dice_ui::US12::US12_1(v106_1_0) => {
                                        let v108: Option<std::string::String> =
                                            Dice_ui::method50(v106_1_0.clone());
                                        Dice_ui::US13::US13_1(defaultValue(
                                            Dice_ui::US14::US14_0,
                                            map(
                                                Func1::new(move |v_10: std::string::String| {
                                                    Dice_ui::closure30((), v_10)
                                                }),
                                                serde_json::from_value(v108.into()).unwrap(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US12::US12_0(v106_0_0) => {
                                        Dice_ui::US13::US13_0(v106_0_0.clone())
                                    }
                                };
                                let v124: Dice_ui::US15 = match &v118 {
                                    Dice_ui::US13::US13_1(v118_1_0) => {
                                        Dice_ui::US15::US15_1(v118_1_0.clone())
                                    }
                                    _ => Dice_ui::US15::US15_0,
                                };
                                let v131: Dice_ui::US14 =
                                    if let Dice_ui::US15::US15_1(v124_1_0) = &v124 {
                                        let v125: Dice_ui::US14 = match &v124 {
                                            Dice_ui::US15::US15_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US14::US14_1(v125_1_0) = &v125 {
                                            Dice_ui::US14::US14_1(match &v125 {
                                                Dice_ui::US14::US14_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Dice_ui::US14::US14_0
                                        }
                                    } else {
                                        Dice_ui::US14::US14_0
                                    };
                                let v153: Dice_ui::US6 = match &v131 {
                                    Dice_ui::US14::US14_1(v131_1_0) => {
                                        let v134: std::string::String =
                                            Dice_ui::method52(Dice_ui::method51(v131_1_0.clone()));
                                        let v137: string = Dice_ui::method6(
                                            fable_library_rust::String_::fromString(v134),
                                        );
                                        let v139: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v137);
                                        let v141: Result<
                                            LrcPtr<Dice_ui::Heap3>,
                                            serde_json::Error,
                                        > = serde_json::from_str(&v139);
                                        let v142 = Dice_ui::method53();
                                        let v144: Result<
                                            LrcPtr<Dice_ui::Heap3>,
                                            std::string::String,
                                        > = v141.map_err(|x| v142(x));
                                        Dice_ui::US6::US6_1(defaultValue(
                                            Dice_ui::US4::US4_0,
                                            map(
                                                Func1::new(move |v_11: LrcPtr<Dice_ui::Heap3>| {
                                                    Dice_ui::closure32((), v_11)
                                                }),
                                                v144.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Dice_ui::US6::US6_0,
                                };
                                if let Dice_ui::US6::US6_1(v153_1_0) = &v153 {
                                    let v154: Dice_ui::US4 = match &v153 {
                                        Dice_ui::US6::US6_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US4::US4_1(v154_1_0) = &v154 {
                                        Dice_ui::US4::US4_1(match &v154 {
                                            Dice_ui::US4::US4_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Dice_ui::US4::US4_0
                                    }
                                } else {
                                    Dice_ui::US4::US4_0
                                }
                            };
                            let v164: string =
                                Dice_ui::method0(append(append(string("state_core.use_core_database (5) / effect core_state_heap / ##3 / core_state_heap: "),
                                                               sprintf!("{:?}",
                                                                        &v161)),
                                                        string("")));
                            leptos::logging::log!("{}", v164);
                            if let Dice_ui::US4::US4_1(v161_1_0) = &v161 {
                                let v167 = Dice_ui::method54(
                                    v0_1,
                                    match &v161 {
                                        Dice_ui::US4::US4_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                );
                                let v170: Func0<()> = Dice_ui::method63(Func0::new(move || v167()));
                                leptos::batch(move || v170());
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method44(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure23(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method65(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::RwSignal<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn closure38(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            unitVar: (),
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            let v2: string = Dice_ui::method0(string(
                "state_core.use_core_database (6) / loading create_memo",
            ));
            leptos::logging::log!("{}", v2);
            {
                let v5: leptos::RwSignal<
                    std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                > = Dice_ui::method65(v0_1.l1.clone());
                leptos::SignalGetUntracked::get_untracked(&v5)
            }
        }
        pub fn method64(
            v0_1: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure38(v0_1.clone(), ())
            })
        }
        pub fn method66() -> bool {
            false
        }
        pub fn method68(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method69(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> Dice_ui::US16 {
            Dice_ui::US16::US16_1
        }
        pub fn closure41(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US16 {
            Dice_ui::US16::US16_0(v0_1)
        }
        pub fn method70() {
            ();
        }
        pub fn closure39(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            v1: LrcPtr<Dice_ui::Heap3>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = sprintf!("{:?}", &v1);
            let v3: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method24(v0_1);
            let v8: Dice_ui::US5 = defaultValue(
                Dice_ui::US5::US5_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                    leptos::SignalGet::get(&v3),
                ),
            );
            let __future_init = Box::pin(async move {
                //;
                match &v8 {
                    Dice_ui::US5::US5_1(v8_1_0) => {
                        let v12: string =
                        Dice_ui::method0(append(append(string("state_core.use_core_database (7) / set_core_state_heap_action / value: "),
                                                       v2), string("")));
                        leptos::logging::log!("{}", v12);
                        {
                            let v17: string = Dice_ui::method0(append(
                                append(
                                    string("state_core.set_data () / data_len: "),
                                    toString(length(sprintf!("{:?}", &v1)) as i64),
                                ),
                                string(""),
                            ));
                            leptos::logging::log!("{}", v17);
                            {
                                let v19: rexie::Rexie = Dice_ui::method68(v8_1_0.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v22: rexie::Transaction = v19.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v24: rexie::Store = v22.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v1, &mut data).unwrap();
                                        {
                                            let v28: Vec<u8> = data;
                                            let v30: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v28).unwrap();
                                            let v31: string = Dice_ui::method33();
                                            let v33: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v31);
                                            v24.put(&v30, Some(&v33.into())).await?;
                                            v22.done().await?;
                                            {
                                                let v37: Result<(), rexie::Error> =
                                                    Dice_ui::method69(Ok::<(), rexie::Error>(()));
                                                v37
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v40: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v42: Result<(), rexie::Error> = v40.await;
                                                let v45: Dice_ui::US16 = match &v42 {
                                                    Err(v42_1_0) => {
                                                        Dice_ui::closure41((), v42_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure40((), ()),
                                                };
                                                match &v45 {
                                                Dice_ui::US16::US16_1 => (),
                                                Dice_ui::US16::US16_0(v45_0_0)
                                                =>
                                                panic!("{}",
                                                       sprintf!("resultm.get / Result value was Error: {}", v45_0_0),),
                                            }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _ => {
                        let v49: string =
                        Dice_ui::method0(string("state_core.use_core_database (8) / set_core_state_heap_action / database=None"));
                        leptos::logging::log!("{}", v49);
                        ()
                    }
                }
                Dice_ui::method70();
                ()
            });
            __future_init
        }
        pub fn method67(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func1<LrcPtr<Dice_ui::Heap3>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap3>| Dice_ui::closure39(v0_1.clone(), v)
            })
        }
        pub fn method72(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method73(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method74(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method75(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn method76(
            v0_1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::Memo<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn method77() -> string {
            string("dark_mode_key")
        }
        pub fn method78(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure43(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Dice_ui::US17 {
            Dice_ui::US17::US17_1(v0_1)
        }
        pub fn closure44(unitVar: (), v0_1: bool) -> bool {
            let v2: string =
                Dice_ui::method0(string("state_core.use_core_database (12) / effect new_core_state_heap / set_loaded |> signal_update true"));
            leptos::logging::log!("{}", v2);
            true
        }
        pub fn method79() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure44((), v))
        }
        pub fn method80(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method81(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method82(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method83(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method84(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure42(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            v4: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Dice_ui::method72(v3);
            let v7: bool = leptos::SignalGet::get(&v5);
            let v9: string =
                Dice_ui::method0(append(append(string("state_core.use_core_database (9) / effect new_core_state_heap / ##1 / loaded: "),
                                               ofBoolean(v7)), string("")));
            leptos::logging::log!("{}", v9);
            {
                let v11: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
                let v12: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v11.clone());
                let v16: leptos::RwSignal<bool> =
                    Dice_ui::method73((leptos::SignalGetUntracked::get_untracked(&v12)).l0.clone());
                let v18: bool = leptos::SignalGet::get(&v16);
                let v19: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v11.clone());
                let v23: leptos::RwSignal<bool> =
                    Dice_ui::method73((leptos::SignalGetUntracked::get_untracked(&v19)).l2.clone());
                let v25: bool = leptos::SignalGet::get(&v23);
                let v26: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v11.clone());
                let v30: leptos::RwSignal<std::string::String> =
                    Dice_ui::method74((leptos::SignalGetUntracked::get_untracked(&v26)).l3.clone());
                let v32: std::string::String = leptos::SignalGet::get(&v30);
                let v33: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v11);
                let v37: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method75((leptos::SignalGetUntracked::get_untracked(&v33)).l1.clone());
                let v40: LrcPtr<Dice_ui::Heap3> = LrcPtr::new(Dice_ui::Heap3 {
                    l0: v18,
                    l1: leptos::SignalGet::get(&v37),
                    l2: v25,
                    l3: v32,
                });
                let v43: string =
                    Dice_ui::method0(append(append(string("state_core.use_core_database (10) / effect new_core_state_heap / ##2 / new_core_state_heap: "),
                                                   sprintf!("{:?}", &v40)),
                                            string("")));
                leptos::logging::log!("{}", v43);
                {
                    let v45: leptos::Memo<
                        std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                    > = Dice_ui::method76(v1);
                    let v47: std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<bool>,
                    > = v45();
                    let v49: string = Dice_ui::method6(Dice_ui::method77());
                    let v51: &str = fable_library_rust::String_::LrcStr::as_str(&v49);
                    let v54: std::string::String = Dice_ui::method78(String::from(v51));
                    let v59: Dice_ui::US17 = defaultValue(
                        Dice_ui::US17::US17_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Dice_ui::closure43((), v)),
                            std::collections::HashMap::get(&v47, &v54)
                                .map(|x| x)
                                .cloned(),
                        ),
                    );
                    let v67: Dice_ui::US18 = match &v59 {
                        Dice_ui::US17::US17_1(v59_1_0) => {
                            let v61: leptos::RwSignal<bool> = Dice_ui::method73(v59_1_0.clone());
                            Dice_ui::US18::US18_1(leptos::SignalGet::get(&v61))
                        }
                        _ => Dice_ui::US18::US18_0,
                    };
                    let v70: bool = match &v67 {
                        Dice_ui::US18::US18_1(v67_1_0) => v67_1_0.clone(),
                        _ => false,
                    };
                    let v72: string =
                        Dice_ui::method0(append(append(string("state_core.use_core_database (11) / effect new_core_state_heap / ##3 / dark_mode_loading: "),
                                                       ofBoolean(v70)),
                                                string("")));
                    leptos::logging::log!("{}", v72);
                    if v70 == false {
                        if v7 == false {
                            let v76 = Dice_ui::method79();
                            let v77: leptos::WriteSignal<bool> = Dice_ui::method80(v2);
                            leptos::SignalUpdate::update(&v77, |x| *x = v76(x.clone()));
                            ()
                        } else {
                            let v80: string =
                                Dice_ui::method0(string("state_core.use_core_database (13) / effect new_core_state_heap / ##4"));
                            leptos::logging::log!("{}", v80);
                            {
                                let v83: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Dice_ui::method46(Dice_ui::method45());
                                let v86: Dice_ui::US9 = match &v83 {
                                    Err(v83_1_0) => Dice_ui::closure25((), v83_1_0.clone()),
                                    Ok(v83_0_0) => Dice_ui::closure24((), v83_0_0.clone()),
                                };
                                let v95: Dice_ui::US10 = match &v86 {
                                    Dice_ui::US9::US9_1(v86_1_0) => {
                                        Dice_ui::US10::US10_1(defaultValue(
                                            Dice_ui::US11::US11_0,
                                            map(
                                                Func1::new(move |v_3: web_sys::Storage| {
                                                    Dice_ui::closure26((), v_3)
                                                }),
                                                v86_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US9::US9_0(v86_0_0) => {
                                        Dice_ui::US10::US10_0(v86_0_0.clone())
                                    }
                                };
                                if let Dice_ui::US10::US10_1(v95_1_0) = &v95 {
                                    let v96: Dice_ui::US11 = match &v95 {
                                        Dice_ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US11::US11_1(v96_1_0) = &v96 {
                                        let v98: LrcPtr<Dice_ui::Heap3> =
                                            Dice_ui::method81(v40.clone());
                                        leptos::Action::dispatch(&v4, v98);
                                        {
                                            let v100: web_sys::Storage =
                                                Dice_ui::method82(match &v96 {
                                                    Dice_ui::US11::US11_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                            let v101: string = Dice_ui::method33();
                                            let v103: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v101);
                                            let v104: LrcPtr<Dice_ui::Heap3> =
                                                Dice_ui::method83(v40);
                                            let v107: std::string::String = Dice_ui::method84(
                                                serde_json::json!(v104).to_string(),
                                            );
                                            let v109: &str = v107.as_str();
                                            web_sys::Storage::set(&v100, v103, v109).unwrap();
                                            ()
                                        }
                                    }
                                }
                            }
                        };
                    }
                }
            }
        }
        pub fn method71(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            v4: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move || {
                    Dice_ui::closure42(
                        v0_1.clone(),
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure45(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method73((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method85(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure45(v0_1.clone(), ())
            })
        }
        pub fn method87(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method88(
            v0_1: leptos::Memo<std::string::String>,
        ) -> leptos::Memo<std::string::String> {
            v0_1
        }
        pub fn method89(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method90() -> Dice_ui::US19 {
            Dice_ui::US19::US19_0
        }
        pub fn method92(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method93(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method94() -> bool {
            true
        }
        pub fn method95(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method96(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method97(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure47(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap2>,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v6: leptos::ReadSignal<bool> = Dice_ui::method72(v5);
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos_router::Location = Dice_ui::method92(v0_1);
            let v12: leptos::Memo<std::string::String> = Dice_ui::method88(v9.hash);
            let v14: std::string::String = v12();
            let v15: string = sprintf!("{}{}", &v2, &v14);
            let v17: string = Dice_ui::method0(append(
                append(
                    append(
                        append(
                            string("content.render () / effect 1 / new_url_hash: "),
                            v15.clone(),
                        ),
                        string(" / loaded: "),
                    ),
                    ofBoolean(v8),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v17);
            if v8 == false {
                let v20: std::string::String = Dice_ui::method93(v14);
                if v20 == "" {
                    let v24: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                        Dice_ui::method55(v3.l0.clone());
                    let v28: leptos::RwSignal<std::string::String> = Dice_ui::method74(
                        (leptos::SignalGetUntracked::get_untracked(&v24)).l3.clone(),
                    );
                    let v31: std::string::String = Dice_ui::method52(leptos::SignalGet::get(&v28));
                    let v33: string = fable_library_rust::String_::fromString(v31);
                    let v35: string = Dice_ui::method0(append(
                        append(
                            string("content.render () / effect 1 / url_hash: "),
                            v33.clone(),
                        ),
                        string(""),
                    ));
                    leptos::logging::log!("{}", v35);
                    if contains(v33.clone(), string("#")) {
                        let v39: string = Dice_ui::method6(v33);
                        let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                        v1(v41, Default::default());
                        ()
                    }
                }
                {
                    let v43: bool = Dice_ui::method94();
                    let v44: leptos::WriteSignal<bool> = Dice_ui::method95(v4);
                    leptos::SignalSet::set(&v44, v43);
                    ()
                }
            } else {
                let v47: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                    Dice_ui::method55(v3.l0.clone());
                let v49: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v47);
                let v52: string = Dice_ui::method6(Dice_ui::method18(v15));
                let v54: &str = fable_library_rust::String_::LrcStr::as_str(&v52);
                let v57: std::string::String = Dice_ui::method96(String::from(v54));
                let v58: leptos::RwSignal<std::string::String> = Dice_ui::method97(v49.l3.clone());
                leptos::SignalSet::set(&v58, v57);
                ()
            }
        }
        pub fn method91(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap2>,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                move || {
                    Dice_ui::closure47(
                        v0_1.clone(),
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method99(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method100(v0_1: &str) -> &str {
            v0_1
        }
        pub fn closure49(unitVar: (), v0_1: leptos_router::Url) -> Dice_ui::US21 {
            Dice_ui::US21::US21_1(v0_1)
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Dice_ui::US21 {
            Dice_ui::US21::US21_0(v0_1)
        }
        pub fn method101(v0_1: Array<Dice_ui::US19>) -> Array<Dice_ui::US19> {
            v0_1
        }
        pub fn method102(v0_1: i32, v1: LrcPtr<Dice_ui::Mut0>) -> bool {
            v1.l0.get().clone() < v0_1
        }
        pub fn method103(v0_1: leptos_router::Url) -> leptos_router::Url {
            v0_1
        }
        pub fn method104(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method105(v0_1: Dice_ui::US19) -> Dice_ui::US19 {
            v0_1
        }
        pub fn method106(
            v0_1: leptos::WriteSignal<Dice_ui::US19>,
        ) -> leptos::WriteSignal<Dice_ui::US19> {
            v0_1
        }
        pub fn closure48(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US19>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Dice_ui::method92(v0_1);
            let v5: leptos::Memo<std::string::String> = Dice_ui::method88(v2.hash);
            let v8: std::string::String = Dice_ui::method99(v5());
            let v10: Option<&str> = v8.strip_prefix('#');
            let v12: string = string("r#\"\"#");
            let v13: &str = r#""#;
            let v16: &str = Dice_ui::method100(v10.unwrap_or(v13));
            let v18: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v16);
            let v21: Dice_ui::US21 = match &v18 {
                Err(v18_1_0) => Dice_ui::closure50((), v18_1_0.clone()),
                Ok(v18_0_0) => Dice_ui::closure49((), v18_0_0.clone()),
            };
            let v25: string = Dice_ui::method0(append(
                append(
                    string("content.render () / effect 2 / hash_url: "),
                    toString(format!("{:#?}", &v21)),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v25);
            match &v21 {
                Dice_ui::US21::US21_1(v21_1_0) => {
                    let v34: Array<Dice_ui::US19> = Dice_ui::method101(new_array(&[
                        Dice_ui::US19::US19_1(Dice_ui::US20::US20_0),
                        Dice_ui::US19::US19_2,
                        Dice_ui::US19::US19_4,
                        Dice_ui::US19::US19_3,
                    ]));
                    let v35: i32 = count(v34.clone());
                    let v37: LrcPtr<Dice_ui::Mut0> = LrcPtr::new(Dice_ui::Mut0 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(Dice_ui::US22::US22_0),
                    });
                    while Dice_ui::method102(v35, v37.clone()) {
                        let v39: i32 = v37.l0.get().clone();
                        let v40: Dice_ui::US22 = v37.l1.get().clone();
                        let v41: Dice_ui::US19 = v34[v39].clone();
                        let v71: Dice_ui::US22 = match &v40 {
                            Dice_ui::US22::US22_1(v40_1_0) => {
                                Dice_ui::US22::US22_1(v40_1_0.clone())
                            }
                            _ => {
                                let v53: string = match &v41 {
                                    Dice_ui::US19::US19_1(v41_1_0) => string("dice"),
                                    Dice_ui::US19::US19_2 => string("lists"),
                                    Dice_ui::US19::US19_3 => string("settings"),
                                    Dice_ui::US19::US19_4 => string("transactions"),
                                    _ => string(""),
                                };
                                let v54: leptos_router::Url = Dice_ui::method103(v21_1_0.clone());
                                let v56: std::string::String = v54.pathname;
                                let v59: string = Dice_ui::method6(Dice_ui::method18(append(
                                    append(string("/"), v53),
                                    string(""),
                                )));
                                let v61: &str = fable_library_rust::String_::LrcStr::as_str(&v59);
                                let v63: std::string::String = String::from(v61);
                                let v64: std::string::String = Dice_ui::method104(v56);
                                if v64.starts_with(&v63) {
                                    Dice_ui::US22::US22_1(v41.clone())
                                } else {
                                    Dice_ui::US22::US22_0
                                }
                            }
                        };
                        let v72: i32 = v39 + 1_i32;
                        v37.l0.set(v72);
                        v37.l1.set(v71);
                        ()
                    }
                    {
                        let v73: Dice_ui::US22 = v37.l1.get().clone();
                        let v74: Dice_ui::US19 = v34[0_i32].clone();
                        let v77: Dice_ui::US19 = match &v73 {
                            Dice_ui::US22::US22_1(v73_1_0) => v73_1_0.clone(),
                            _ => v74,
                        };
                        let v81: string = Dice_ui::method0(append(
                            append(
                                string("content.render () / effect 2 / new_tab: "),
                                toString(format!("{:#?}", &v77)),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v81);
                        {
                            let v83: Dice_ui::US19 = Dice_ui::method105(v77);
                            let v84: leptos::WriteSignal<Dice_ui::US19> = Dice_ui::method106(v1);
                            leptos::SignalSet::set(&v84, v83);
                            ()
                        }
                    }
                }
                Dice_ui::US21::US21_0(v21_0_0) => {
                    let v88: string = Dice_ui::method0(append(
                        append(
                            string("content.render () / effect 2 / hash_url error: "),
                            toString(v21_0_0.clone()),
                        ),
                        string(""),
                    ));
                    leptos::logging::log!("{}", v88);
                    ()
                }
            }
        }
        pub fn method98(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US19>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure48(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method110(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
        ) -> leptos::ReadSignal<Dice_ui::US19> {
            v0_1
        }
        pub fn method111(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method112(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method115(
            v0_: bool,
            v0__1: std::string::String,
        ) -> LrcPtr<(bool, std::string::String)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn closure56(
            v0_1: i32,
            v1_: bool,
            v1__1: std::string::String,
        ) -> LrcPtr<(
            i32,
            (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        )> {
            let v1: LrcPtr<(bool, std::string::String)> = LrcPtr::new((v1_, v1__1));
            let v2: LrcPtr<(bool, std::string::String)> =
                Dice_ui::method115(v1.0.clone(), v1.1.clone());
            let patternInput: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ) = leptos::create_signal(v2);
            LrcPtr::new((v0_1, (patternInput.0.clone(), patternInput.1.clone())))
        }
        pub fn closure55(
            unitVar: (),
            v0_1: i32,
        ) -> Func1<
            LrcPtr<(bool, std::string::String)>,
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |tupledArg: LrcPtr<(bool, std::string::String)>| {
                    Dice_ui::closure56(v0_1, tupledArg.0.clone(), tupledArg.1.clone())
                }
            })
        }
        pub fn method114() -> Func1<
            i32,
            Func1<
                LrcPtr<(bool, std::string::String)>,
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            >,
        > {
            Func1::new(move |v: i32| Dice_ui::closure55((), v))
        }
        pub fn method116(
            v0_1: Vec<LrcPtr<(bool, std::string::String)>>,
        ) -> Vec<LrcPtr<(bool, std::string::String)>> {
            v0_1
        }
        pub fn closure54(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            unitVar: (),
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
        > {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method75((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            let v8: LrcPtr<Dice_ui::Heap0> = leptos::SignalGet::get(&v6);
            let v10 = Dice_ui::method114();
            let v11: Vec<LrcPtr<(bool, std::string::String)>> = Dice_ui::method116(v8.l0.clone());
            v11.iter()
                .enumerate()
                .map(|(i, x)| v10(i.try_into().unwrap())(x.clone()))
                .collect()
        }
        pub fn method113(
            v0_1: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<
            Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            >,
        > {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure54(v0_1.clone(), ())
            })
        }
        pub fn method117() -> i32 {
            0_i32
        }
        pub fn method119(v0_1: leptos::ReadSignal<i32>) -> leptos::ReadSignal<i32> {
            v0_1
        }
        pub fn method120(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
        ) -> leptos::Memo<
            Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            >,
        > {
            v0_1
        }
        pub fn closure58(
            unitVar: (),
            v0_: i32,
            v0__1: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> (
            i32,
            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
        ) {
            let v0_1: LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )> = LrcPtr::new((v0_, v0__1));
            let b: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ) = v0_1.1.clone();
            (v0_1.0.clone(), b.0.clone(), b.1.clone())
        }
        pub fn method121() -> Func1<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
            (
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        > {
            Func1::new(
                move |tupledArg: LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>| {
                    Dice_ui::closure58((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn method122(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn closure59(
            v0_1: i32,
            _arg: (
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> (
            i32,
            i32,
            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        ) {
            (v0_1, _arg.0.clone(), _arg.1.clone())
        }
        pub fn method123(
            v0_1: i32,
        ) -> Func1<
            (
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
            (
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |arg10_0040: (
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                )| Dice_ui::closure59(v0_1, arg10_0040)
            })
        }
        pub fn method124(
            v0_1: Vec<(
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            )>,
        ) -> Vec<(
            i32,
            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
        )> {
            v0_1
        }
        pub fn closure57(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v1: leptos::ReadSignal<i32>,
            unitVar: (),
        ) -> Vec<(
            i32,
            i32,
            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        )> {
            let v2: leptos::ReadSignal<i32> = Dice_ui::method119(v1);
            let v4: i32 = leptos::SignalGet::get(&v2);
            let v5: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            > = Dice_ui::method120(v0_1);
            let v7: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = v5();
            let v8 = Dice_ui::method121();
            let v9: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = Dice_ui::method122(v7);
            let v11: Vec<(
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            )> = v9.iter().map(|x| v8(x.clone())).collect();
            let v12 = Dice_ui::method123(v4);
            let v13: Vec<(
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            )> = Dice_ui::method124(v11);
            v13.iter().map(|x| v12(x.clone())).collect()
        }
        pub fn method118(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v1: leptos::ReadSignal<i32>,
        ) -> Func0<
            Vec<(
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            )>,
        > {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure57(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method126(
            v0_1: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            >,
        ) -> leptos::Memo<
            Vec<(
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            )>,
        > {
            v0_1
        }
        pub fn method127(
            v0_1: Vec<(
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            )>,
        ) -> Vec<(
            i32,
            i32,
            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        )> {
            v0_1
        }
        pub fn closure60(
            v0_1: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            >,
            unitVar: (),
        ) -> i32 {
            let v1: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            > = Dice_ui::method126(v0_1);
            let v4: Vec<(
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            )> = Dice_ui::method127(v1());
            count(fable_library_rust::NativeArray_::array_from(v4))
        }
        pub fn method125(
            v0_1: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            >,
        ) -> Func0<i32> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure60(v0_1.clone(), ())
            })
        }
        pub fn method131(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn method132(
            v0_: i32,
            v0__1: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> LrcPtr<(
            i32,
            (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        )> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method133(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn method135(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        ) -> leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> {
            v0_1
        }
        pub fn closure64(
            unitVar: (),
            v0_: i32,
            v0__1: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> LrcPtr<(bool, std::string::String)> {
            let v4: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> =
                Dice_ui::method135(((LrcPtr::new((v0_, v0__1))).1.clone()).0.clone());
            leptos::SignalGet::get(&v4)
        }
        pub fn method134() -> Func1<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
            LrcPtr<(bool, std::string::String)>,
        > {
            Func1::new(
                move |tupledArg: LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>| {
                    Dice_ui::closure64((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn closure63(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v1: LrcPtr<Dice_ui::Heap0>,
        ) -> LrcPtr<Dice_ui::Heap0> {
            let v4: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            > = Dice_ui::method120(v0_1);
            let v6: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = v4();
            let v7: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = Dice_ui::method131(v6.clone());
            let v10: i32 = count(fable_library_rust::NativeArray_::array_from(v7));
            let v12: string = Dice_ui::method6(Dice_ui::method5());
            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
            let v17: LrcPtr<(bool, std::string::String)> = LrcPtr::new((false, String::from(v14)));
            let v18: LrcPtr<(bool, std::string::String)> =
                Dice_ui::method115(v17.0.clone(), v17.1.clone());
            let patternInput: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ) = leptos::create_signal(v18);
            let v22: LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )> = LrcPtr::new((v10, (patternInput.0.clone(), patternInput.1.clone())));
            let v23: LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )> = Dice_ui::method132(v22.0.clone(), v22.1.clone());
            let v24: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = Dice_ui::method133(v6);
            let mut v24 = v24;
            v24.push(v23);
            {
                let v28: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                > = v24;
                let v29 = Dice_ui::method134();
                let v30: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                > = Dice_ui::method122(v28);
                LrcPtr::new(Dice_ui::Heap0 {
                    l0: v30.iter().map(|x| v29(x.clone())).collect(),
                    l1: v1.l1.clone(),
                })
            }
        }
        pub fn method130(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
        ) -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure63(v0_1.clone(), v)
            })
        }
        pub fn closure65(unitVar: (), v0_1: i32) -> i32 {
            1_i32 + v0_1
        }
        pub fn method136() -> Func1<i32, i32> {
            Func1::new(move |v: i32| Dice_ui::closure65((), v))
        }
        pub fn method137(v0_1: leptos::WriteSignal<i32>) -> leptos::WriteSignal<i32> {
            v0_1
        }
        pub fn closure62(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            unitVar: (),
        ) {
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v4);
            let v8 = Dice_ui::method130(v1);
            let v9: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method62(v6.l1.clone());
            leptos::SignalUpdate::update(&v9, |x| *x = v8(x.clone()));
            {
                let v11 = Dice_ui::method136();
                let v12: leptos::WriteSignal<i32> = Dice_ui::method137(v2);
                leptos::SignalUpdate::update(&v12, |x| *x = v11(x.clone()));
                ()
            }
        }
        pub fn method129(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure62(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn closure61(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            unitVar: (),
        ) {
            let v3 = Dice_ui::method129(v0_1, v1, v2);
            let v6: Func0<()> = Dice_ui::method63(Func0::new(move || v3()));
            leptos::batch(move || v6());
            ()
        }
        pub fn method128(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure61(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method138() -> string {
            string("h-5 w-5")
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method140() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure67((), ()))
        }
        pub fn method141(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method143(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method144(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure68(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method143(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method144(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method142(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure68(v0_1.clone(), ())
            })
        }
        pub fn method145(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Path>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Path>> {
            v0_1
        }
        pub fn method147(
            v0_1: leptos::HtmlElement<leptos::svg::Path>,
        ) -> leptos::HtmlElement<leptos::svg::Path> {
            v0_1
        }
        pub fn closure69(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::svg::Path>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method147(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method146() -> Func1<leptos::HtmlElement<leptos::svg::Path>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::svg::Path>| Dice_ui::closure69((), v))
        }
        pub fn method148(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Path>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Path>> {
            v0_1
        }
        pub fn method149(v0_1: Vec<leptos::View>) -> Vec<leptos::View> {
            v0_1
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string =
                string(" d=\"M12 6v12m6-6H6\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method145(new_array(
                &[
                    leptos::view! { <path  d="M12 6v12m6-6H6" stroke-linejoin="round" stroke-linecap="round">{v9()}</path> },
                ],
            ));
            let v17 = Dice_ui::method146();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method148(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method149(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method139() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure66((), ()))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> &'static str {
            let v1: string = string("r#\" bg-gray-100\"#");
            r#" bg-gray-100"#
        }
        pub fn method150() -> Func0<&'static str> {
            Func0::new(move || Dice_ui::closure70((), ()))
        }
        pub fn method152(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn closure71(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(v0_1);
            let v6: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v1),
            ])));
            let v8: Vec<leptos::View> = v6.to_vec();
            leptos::Fragment::new(v8)
        }
        pub fn method151(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure71(v0_1.clone(), ())
            })
        }
        pub fn method153(
            v0_1: leptos::HtmlElement<leptos::html::Button>,
        ) -> leptos::HtmlElement<leptos::html::Button> {
            v0_1
        }
        pub fn method154() -> string {
            string("Accounts")
        }
        pub fn method155(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method156(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method158(
            v0_1: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            >,
        ) -> leptos::Memo<
            Vec<(
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            )>,
        > {
            v0_1
        }
        pub fn closure73(
            unitVar: (),
            _arg: (
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> (i32, i32) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn method159() -> Func1<
            (
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            ),
            (i32, i32),
        > {
            Func1::new(
                move |arg10_0040: (
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )| Dice_ui::closure73((), arg10_0040),
            )
        }
        pub fn method162(v0_1: i32) -> i32 {
            v0_1
        }
        pub fn method165(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn method167(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn closure79(
            v0_1: i32,
            v1: i32,
            v2_: bool,
            v2__1: std::string::String,
        ) -> LrcPtr<(bool, std::string::String)> {
            let v2: LrcPtr<(bool, std::string::String)> = LrcPtr::new((v2_, v2__1));
            if Dice_ui::method167(v1 == v0_1) {
                v2.clone()
            } else {
                LrcPtr::new((v2.0.clone() == false, v2.1.clone()))
            }
        }
        pub fn closure78(
            v0_1: i32,
            v1: i32,
        ) -> Func1<LrcPtr<(bool, std::string::String)>, LrcPtr<(bool, std::string::String)>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |tupledArg: LrcPtr<(bool, std::string::String)>| {
                    Dice_ui::closure79(v0_1, v1, tupledArg.0.clone(), tupledArg.1.clone())
                }
            })
        }
        pub fn method166(
            v0_1: i32,
        ) -> Func1<
            i32,
            Func1<LrcPtr<(bool, std::string::String)>, LrcPtr<(bool, std::string::String)>>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: i32| Dice_ui::closure78(v0_1, v)
            })
        }
        pub fn method168(v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
            v0_1
        }
        pub fn method169(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure77(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32, v2: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v3.clone());
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method165((leptos::SignalGetUntracked::get_untracked(&v4)).l1.clone());
            let v10: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v8);
            let v13: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v3);
            let v15: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v13);
            let v17 = Dice_ui::method166(v1);
            let v18: Vec<LrcPtr<(bool, std::string::String)>> = Dice_ui::method116(v10.l0.clone());
            let v22: LrcPtr<Dice_ui::Heap0> = Dice_ui::method168(LrcPtr::new(Dice_ui::Heap0 {
                l0: v18
                    .iter()
                    .enumerate()
                    .map(|(i, x)| v17(i.try_into().unwrap())(x.clone()))
                    .collect(),
                l1: v10.l1.clone(),
            }));
            let v23: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method169(v15.l1.clone());
            leptos::SignalSet::set(&v23, v22);
            ()
        }
        pub fn method164(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure77(v0_1.clone(), v1, v)
            })
        }
        pub fn closure80(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            unitVar: (),
        ) -> bool {
            let v1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> =
                Dice_ui::method135(v0_1);
            (leptos::SignalGet::get(&v1)).0.clone()
        }
        pub fn method170(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        ) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure80(v0_1.clone(), ())
            })
        }
        pub fn method171(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string =
                string("d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\"");
            let v7: string = append(
                append(
                    string(" clip-rule=\"evenodd\""),
                    append(
                        append(append(string(" "), v1), string(" fill-rule=\"evenodd\"")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method145(new_array(
                &[
                    leptos::view! { <path  clip-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" fill-rule="evenodd">{v9()}</path> },
                ],
            ));
            let v17 = Dice_ui::method146();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method148(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method149(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method173() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure82((), ()))
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string =
                string("d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\"");
            let v7: string = append(
                append(
                    string(" clip-rule=\"evenodd\""),
                    append(
                        append(append(string(" "), v1), string(" fill-rule=\"evenodd\"")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method145(new_array(
                &[
                    leptos::view! { <path  clip-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" fill-rule="evenodd">{v9()}</path> },
                ],
            ));
            let v17 = Dice_ui::method146();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method148(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method149(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method174() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure83((), ()))
        }
        pub fn method175(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Svg>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Svg>> {
            v0_1
        }
        pub fn closure84(unitVar: (), v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method176() -> Func1<leptos::HtmlElement<leptos::svg::Svg>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::svg::Svg>| Dice_ui::closure84((), v))
        }
        pub fn method177(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Svg>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Svg>> {
            v0_1
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v11: string =
                string(" fill=\"currentColor\" viewBox=\"0 0 20 20\" class=\"h-4 w-4\" xmlns=\"http://www.w3.org/2000/svg\" data-unchecked-icon");
            let v13 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method173()));
            let v16: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<svg "), v11), string(">{v13()}</")),
                            string("svg"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v18: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg  fill="currentColor" viewBox="0 0 20 20" class="h-4 w-4" xmlns="http://www.w3.org/2000/svg" data-unchecked-icon>{v13()}</svg> };
            let v29: string =
                string(" fill=\"currentColor\" viewBox=\"0 0 20 20\" class=\"hidden h-4 w-4\" xmlns=\"http://www.w3.org/2000/svg\" data-checked-icon");
            let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method174()));
            let v33: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<svg "), v29), string(">{v31()}</")),
                            string("svg"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v37: Array<leptos::HtmlElement<leptos::svg::Svg>> = Dice_ui::method175(new_array(
                &[
                    v18,
                    leptos::view! { <svg  fill="currentColor" viewBox="0 0 20 20" class="hidden h-4 w-4" xmlns="http://www.w3.org/2000/svg" data-checked-icon>{v31()}</svg> },
                ],
            ));
            let v38 = Dice_ui::method176();
            let v39: Array<leptos::HtmlElement<leptos::svg::Svg>> = Dice_ui::method177(v37);
            let v41: Vec<leptos::HtmlElement<leptos::svg::Svg>> = v39.to_vec();
            let v44: Vec<leptos::View> =
                Dice_ui::method149(v41.iter().map(|x| v38(x.clone())).collect());
            let v47: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v44));
            let v49: Vec<leptos::View> = v47.to_vec();
            leptos::Fragment::new(v49)
        }
        pub fn method172() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure81((), ()))
        }
        pub fn method178(
            v0_1: leptos::HtmlElement<leptos::html::Span>,
        ) -> leptos::HtmlElement<leptos::html::Span> {
            v0_1
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method179() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure85((), ()))
        }
        pub fn closure76(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            v1: LrcPtr<Dice_ui::Heap2>,
            v2: i32,
            v3: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4 = Dice_ui::method164(v1, v2);
            let on_change = v4;
            {
                let v6 = Dice_ui::method170(v0_1);
                let get_value = v6;
                {
                    let v8: string =
                        string("class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\"");
                    let v21: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    string("<input "),
                                    append(
                                        append(
                                            string(" prop:checked=move || get_value()"),
                                            append(
                                                append(
                                                    string(
                                                        " on:change=move |event| on_change(event)",
                                                    ),
                                                    append(
                                                        append(
                                                            string(" id=v3"),
                                                            append(
                                                                append(
                                                                    string(" type=\"checkbox\""),
                                                                    append(
                                                                        append(
                                                                            append(string(" "), v8),
                                                                            string(""),
                                                                        ),
                                                                        string(""),
                                                                    ),
                                                                ),
                                                                string(""),
                                                            ),
                                                        ),
                                                        string(""),
                                                    ),
                                                ),
                                                string(""),
                                            ),
                                        ),
                                        string(""),
                                    ),
                                ),
                                string(" />"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v24: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method171(
                        leptos::view! { <input  prop:checked=move || get_value() on:change=move |event| on_change(event) id=v3 type="checkbox" class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" /> },
                    );
                    let v26: leptos::View = leptos::IntoView::into_view(v24);
                    let v27: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v29: string =
                        append(append(append(string(" "), v27), string("")), string(""));
                    let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method172()));
                    let v34: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v29), string(">{v31()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v37: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">{v31()}</span> },
                    );
                    let v39: leptos::View = leptos::IntoView::into_view(v37);
                    let v40: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v42: string =
                        append(append(append(string(" "), v40), string("")), string(""));
                    let v44 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method179()));
                    let v46: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v42), string(">{v44()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v49: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">{v44()}</span> },
                    );
                    let v54: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            v26,
                            v39,
                            leptos::IntoView::into_view(v49),
                        ])));
                    let v56: Vec<leptos::View> = v54.to_vec();
                    leptos::Fragment::new(v56)
                }
            }
        }
        pub fn method163(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            v1: LrcPtr<Dice_ui::Heap2>,
            v2: i32,
            v3: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure76(v0_1.clone(), v1.clone(), v2, v3.clone(), ())
            })
        }
        pub fn method180(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn closure86(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            unitVar: (),
        ) -> std::string::String {
            let v1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> =
                Dice_ui::method135(v0_1);
            (leptos::SignalGet::get(&v1)).1.clone()
        }
        pub fn method181(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        ) -> Func0<std::string::String> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure86(v0_1.clone(), ())
            })
        }
        pub fn method184(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn closure89(
            v0_1: i32,
            v1: std::string::String,
            v2: i32,
            v3_: bool,
            v3__1: std::string::String,
        ) -> LrcPtr<(bool, std::string::String)> {
            let v3: LrcPtr<(bool, std::string::String)> = LrcPtr::new((v3_, v3__1));
            if Dice_ui::method184(v2 == v0_1) {
                v3.clone()
            } else {
                LrcPtr::new((v3.0.clone(), v1))
            }
        }
        pub fn closure88(
            v0_1: i32,
            v1: std::string::String,
            v2: i32,
        ) -> Func1<LrcPtr<(bool, std::string::String)>, LrcPtr<(bool, std::string::String)>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move |tupledArg: LrcPtr<(bool, std::string::String)>| {
                    Dice_ui::closure89(
                        v0_1,
                        v1.clone(),
                        v2,
                        tupledArg.0.clone(),
                        tupledArg.1.clone(),
                    )
                }
            })
        }
        pub fn method183(
            v0_1: i32,
            v1: std::string::String,
        ) -> Func1<
            i32,
            Func1<LrcPtr<(bool, std::string::String)>, LrcPtr<(bool, std::string::String)>>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: i32| Dice_ui::closure88(v0_1, v1.clone(), v)
            })
        }
        pub fn closure87(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32, v2: std::string::String) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v3.clone());
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method165((leptos::SignalGetUntracked::get_untracked(&v4)).l1.clone());
            let v10: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v8);
            let v13: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v3);
            let v15: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v13);
            let v17 = Dice_ui::method183(v1, v2);
            let v18: Vec<LrcPtr<(bool, std::string::String)>> = Dice_ui::method116(v10.l0.clone());
            let v22: LrcPtr<Dice_ui::Heap0> = Dice_ui::method168(LrcPtr::new(Dice_ui::Heap0 {
                l0: v18
                    .iter()
                    .enumerate()
                    .map(|(i, x)| v17(i.try_into().unwrap())(x.clone()))
                    .collect(),
                l1: v10.l1.clone(),
            }));
            let v23: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method169(v15.l1.clone());
            leptos::SignalSet::set(&v23, v22);
            ()
        }
        pub fn method182(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32) -> Func1<std::string::String, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: std::string::String| Dice_ui::closure87(v0_1.clone(), v1, v)
            })
        }
        pub fn method185(v0_1: leptos::Memo<i32>) -> leptos::Memo<i32> {
            v0_1
        }
        pub fn method189(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn closure94(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method191() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure94((), v))
        }
        pub fn closure93(
            v0_1: i32,
            v1_: i32,
            v1__1: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> bool {
            let v5: bool = (LrcPtr::new((v1_, v1__1))).0.clone() == v0_1;
            (Dice_ui::method191())(v5)
        }
        pub fn method190(
            v0_1: i32,
        ) -> Func1<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                    leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                ),
            )>,
            bool,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |tupledArg: LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>| {
                    Dice_ui::closure93(v0_1, tupledArg.0.clone(), tupledArg.1.clone())
                }
            })
        }
        pub fn closure92(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v1: i32,
            v2: LrcPtr<Dice_ui::Heap0>,
        ) -> LrcPtr<Dice_ui::Heap0> {
            let v5: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            > = Dice_ui::method120(v0_1);
            let v8: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = Dice_ui::method189(v5());
            let v9 = Dice_ui::method190(v1);
            let mut v8 = v8;
            v8.retain(|x| v9(x.clone()));
            {
                let v13: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                > = v8;
                let v14 = Dice_ui::method134();
                let v15: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                > = Dice_ui::method122(v13);
                LrcPtr::new(Dice_ui::Heap0 {
                    l0: v15.iter().map(|x| v14(x.clone())).collect(),
                    l1: v2.l1.clone(),
                })
            }
        }
        pub fn method188(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v1: i32,
        ) -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure92(v0_1.clone(), v1, v)
            })
        }
        pub fn closure91(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            v3: i32,
            unitVar: (),
        ) {
            let v5: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v7: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v5);
            let v9 = Dice_ui::method188(v1, v3);
            let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method62(v7.l1.clone());
            leptos::SignalUpdate::update(&v10, |x| *x = v9(x.clone()));
            {
                let v12 = Dice_ui::method136();
                let v13: leptos::WriteSignal<i32> = Dice_ui::method137(v2);
                leptos::SignalUpdate::update(&v13, |x| *x = v12(x.clone()));
                ()
            }
        }
        pub fn method187(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            v3: i32,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure91(v0_1.clone(), v1.clone(), v2.clone(), v3, ())
            })
        }
        pub fn closure90(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            v3: i32,
            unitVar: (),
        ) {
            let v4 = Dice_ui::method187(v0_1, v1, v2, v3);
            let v7: Func0<()> = Dice_ui::method63(Func0::new(move || v4()));
            leptos::batch(move || v7());
            ()
        }
        pub fn method186(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            v3: i32,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure90(v0_1.clone(), v1.clone(), v2.clone(), v3, ())
            })
        }
        pub fn closure95(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string = string(
                " d=\"M6 6l12 12m0-12L6 18\" stroke-linejoin=\"round\" stroke-linecap=\"round\"",
            );
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method145(new_array(
                &[
                    leptos::view! { <path  d="M6 6l12 12m0-12L6 18" stroke-linejoin="round" stroke-linecap="round">{v9()}</path> },
                ],
            ));
            let v17 = Dice_ui::method146();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method148(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method149(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method192() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure95((), ()))
        }
        pub fn closure96(unitVar: (), unitVar_1: ()) -> &'static str {
            let v1: string = string("r#\" pr-[7px] pl-[5px]\"#");
            r#" pr-[7px] pl-[5px]"#
        }
        pub fn method193() -> Func0<&'static str> {
            Func0::new(move || Dice_ui::closure96((), ()))
        }
        pub fn closure75(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
            v4: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            v5: i32,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: i32 = Dice_ui::method162(v5);
            let v9: string = Dice_ui::method6(Dice_ui::method18(append(
                append(string("account-"), toString(v6)),
                string(""),
            )));
            let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
            let v13: std::string::String = String::from(v11);
            let id = v13.clone();
            {
                let v20: string =
                    string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=id");
                let v22 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method163(
                    v4.clone(),
                    v0_1.clone(),
                    v6,
                    v13,
                )));
                let v25: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<label "), v20), string(">{v22()}</")),
                                string("label"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v28: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method180(
                    leptos::view! { <label  class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]" for=id>{v22()}</label> },
                );
                let v30: leptos::View = leptos::IntoView::into_view(v28);
                let v31 = Dice_ui::method181(v4);
                let v32 = Dice_ui::method182(v0_1.clone(), v6);
                let v33: string = string("r#\"\"#");
                let v34: &str = r#""#;
                let v43: string =
                    string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v32(leptos::event_target_value(&event)) prop:value=move || v31() class=\"bg-gray-50 flex-1 h-[27px]\".to_owned() + v34 /> }");
                let v46: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method171(
                    leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v32(leptos::event_target_value(&event)) prop:value=move || v31() class="bg-gray-50 flex-1 h-[27px]".to_owned() + v34 /> },
                );
                let v48: leptos::View = leptos::IntoView::into_view(v46);
                let v49: leptos::Memo<i32> = Dice_ui::method185(v1);
                let v107: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(
                    &[
                        v30,
                        v48,
                        if v49() == 1_i32 {
                            let v56: Array<leptos::View> = Dice_ui::method156(Dice_ui::method155(
                                Dice_ui::method111(new_empty::<leptos::View>()),
                            ));
                            leptos::CollectView::collect_view(v56.to_vec())
                        } else {
                            let v59 = Dice_ui::method186(v0_1, v2, v3, v6);
                            let on_click = v59;
                            {
                                let v61: string = Dice_ui::method138();
                                let v63: &str = fable_library_rust::String_::LrcStr::as_str(&v61);
                                let v64: string = string("r#\"\"#");
                                let v65: &str = r#""#;
                                let v78:
                                                                                      string =
                                                                                  string(" class=\" \".to_owned() + v63 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                                let v80 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method192()));
                                let v83: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<svg "), v78),
                                                    string(">{v80()}</"),
                                                ),
                                                string("svg"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v85: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg  class=" ".to_owned() + v63 stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">{v80()}</svg> };
                                let v88 = Dice_ui::method193();
                                let v89:
                                                                                      string =
                                                                                  string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]\".to_owned() + v88()}");
                                let v93: string = append(
                                    append(
                                        string(" aria-label=\"Delete\""),
                                        append(
                                            append(
                                                string(" on:click=move |_| on_click()"),
                                                append(
                                                    append(append(string(" "), v89), string("")),
                                                    string(""),
                                                ),
                                            ),
                                            string(""),
                                        ),
                                    ),
                                    string(""),
                                );
                                let v95 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method151(v85)));
                                let v98: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<button "), v93),
                                                    string(">{v95()}</"),
                                                ),
                                                string("button"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v101: leptos::HtmlElement<leptos::html::Button> =
                                    Dice_ui::method153(
                                        leptos::view! { <button  aria-label="Delete" on:click=move |_| on_click() class={move || "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]".to_owned() + v88()}>{v95()}</button> },
                                    );
                                leptos::IntoView::into_view(v101)
                            }
                        },
                    ],
                )));
                let v109: Vec<leptos::View> = v107.to_vec();
                leptos::Fragment::new(v109)
            }
        }
        pub fn method161(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
            v4: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            v5: i32,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                move || {
                    Dice_ui::closure75(
                        v0_1.clone(),
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5,
                        (),
                    )
                }
            })
        }
        pub fn method194(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure74(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
            _arg: (
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> leptos::Fragment {
            let v10: string =
                string(" class=\"pl-[10px] py-[7px] gap-[7px] pr-[4px] [display:flex] [align-items:center]\"");
            let v12 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method161(
                v0_1,
                v1,
                v2,
                v3,
                _arg.2.clone(),
                _arg.1.clone(),
            )));
            let v15: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v10), string(">{v12()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v18: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="pl-[10px] py-[7px] gap-[7px] pr-[4px] [display:flex] [align-items:center]">{v12()}</div> },
            );
            let v23: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v18),
            ])));
            let v25: Vec<leptos::View> = v23.to_vec();
            leptos::Fragment::new(v25)
        }
        pub fn method160(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
        ) -> Func1<
            (
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            ),
            leptos::Fragment,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |arg10_0040: (
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )| {
                    Dice_ui::closure74(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), arg10_0040)
                }
            })
        }
        pub fn closure72(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            >,
            v2: leptos::Memo<i32>,
            v3: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v4: leptos::WriteSignal<i32>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            > = Dice_ui::method158(v1);
            let v6 = Dice_ui::method159();
            let v7 = Dice_ui::method160(v0_1, v2, v3, v4);
            let v19: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos::For  children=move |x| v7(x) let:x key=move |x| v6(x.to_owned()) each=v5 /> })");
            let v23: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(
                    leptos::view! { <leptos::For  children=move |x| v7(x) let:x key=move |x| v6(x.to_owned()) each=v5 /> },
                ),
            ])));
            let v25: Vec<leptos::View> = v23.to_vec();
            leptos::Fragment::new(v25)
        }
        pub fn method157(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<(
                    i32,
                    i32,
                    leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                )>,
            >,
            v2: leptos::Memo<i32>,
            v3: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                >,
            >,
            v4: leptos::WriteSignal<i32>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move || {
                    Dice_ui::closure72(
                        v0_1.clone(),
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure97(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method143(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method144(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method195(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure97(v0_1.clone(), ())
            })
        }
        pub fn closure99(v0_1: leptos::View, unitVar: ()) -> leptos::Fragment {
            let v3: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_array(&[v0_1])));
            let v5: Vec<leptos::View> = v3.to_vec();
            leptos::Fragment::new(v5)
        }
        pub fn method197(v0_1: leptos::View) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure99(v0_1.clone(), ())
            })
        }
        pub fn method202(v0_1: string) -> string {
            v0_1
        }
        pub fn closure103(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method201(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure103(v0_1.clone(), ())
            })
        }
        pub fn closure102(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[font-size:14px] [line-height:21px]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method201(v0_1)));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v4), string(">{v6()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                leptos::view! { <span  class="[font-size:14px] [line-height:21px]">{v6()}</span> },
            );
            let v17: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method200(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure102(v0_1.clone(), ())
            })
        }
        pub fn closure105(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string =
                string("d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\"");
            let v7: string = append(
                append(
                    string(" clip-rule=\"evenodd\""),
                    append(
                        append(append(string(" "), v1), string(" fill-rule=\"evenodd\"")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method145(new_array(
                &[
                    leptos::view! { <path  clip-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" fill-rule="evenodd">{v9()}</path> },
                ],
            ));
            let v17 = Dice_ui::method146();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method148(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method149(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method204() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure105((), ()))
        }
        pub fn closure104(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method6(string("h-5 w-5"));
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: string = string("r#\"\"#");
            let v6: &str = r#""#;
            let v15: string =
                string(" class=\" \".to_owned() + v3 fill=\"currentColor\" viewBox=\"0 0 20 20\" xmlns=\"http://www.w3.org/2000/svg\"");
            let v17 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method204()));
            let v20: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<svg "), v15), string(">{v17()}</")),
                            string("svg"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v23: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(
                leptos::view! { <svg  class=" ".to_owned() + v3 fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">{v17()}</svg> },
            );
            let v28: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method203() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure104((), ()))
        }
        pub fn closure101(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex items-center gap-2\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method200(v0_1)));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v4), string(">{v6()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex items-center gap-2">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string =
                string(" class=\"shrink-0 transition duration-300 group-open:-rotate-180\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method203()));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v17), string(">{v19()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                leptos::view! { <span  class="shrink-0 transition duration-300 group-open:-rotate-180">{v19()}</span> },
            );
            let v30: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method199(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure101(v0_1.clone(), ())
            })
        }
        pub fn method205(
            v0_1: leptos::HtmlElement<leptos::html::Summary>,
        ) -> leptos::HtmlElement<leptos::html::Summary> {
            v0_1
        }
        pub fn closure106(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            v0_1()
        }
        pub fn method206(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure106(v0_1.clone(), ())
            })
        }
        pub fn closure100(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: string = string("r#\" [margin-right:40px]\"#");
            let v8: &str = r#" [margin-right:40px]"#;
            let v9: string =
                string("class=\"group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\".to_owned() + v8");
            let v12: string = append(append(append(string(" "), v9), string("")), string(""));
            let v14 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(v1)));
            let v17: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<summary "), v12), string(">{v14()}</")),
                            string("summary"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v20: leptos::HtmlElement<leptos::html::Summary> = Dice_ui::method205(
                leptos::view! { <summary  class="group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700".to_owned() + v8>{v14()}</summary> },
            );
            let v22: leptos::View = leptos::IntoView::into_view(v20);
            let v25: string = string(" class=\"flex flex-1 flex-col\"");
            let v27 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method206(v2)));
            let v30: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v25), string(">{v27()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v33: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex flex-1 flex-col">{v27()}</div> },
            );
            let v38: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v22,
                leptos::IntoView::into_view(v33),
            ])));
            let v40: Vec<leptos::View> = v38.to_vec();
            leptos::Fragment::new(v40)
        }
        pub fn method198(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure100(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method207(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn closure98(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"[position:absolute] [right:0] [top:0]\"");
            let v8 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method197(v0_1.clone())));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v6), string(">{v8()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="[position:absolute] [right:0] [top:0]">{v8()}</div> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(
                " open=true class=\"flex flex-1 group [&_summary::-webkit-details-marker]:hidden\"",
            );
            let v23 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method198(v0_1, v1, v2)));
            let v26: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<details "), v21), string(">{v23()}</")),
                            string("details"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v29: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method207(
                leptos::view! { <details  open=true class="flex flex-1 group [&_summary::-webkit-details-marker]:hidden">{v23()}</details> },
            );
            let v34: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method196(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure98(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method208() -> string {
            string("View")
        }
        pub fn method211() -> string {
            string("Dark Mode")
        }
        pub fn closure108(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method211()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method210() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure108((), ()))
        }
        pub fn method213() -> string {
            string("dark-mode")
        }
        pub fn closure112(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method216() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure112((), v))
        }
        pub fn closure111(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method216();
            let v8: leptos::RwSignal<bool> = Dice_ui::method57(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method215(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure111(v0_1.clone(), v)
            })
        }
        pub fn closure113(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method73((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method217(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure113(v0_1.clone(), ())
            })
        }
        pub fn closure110(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method215(v0_1.clone());
            let on_change = v2;
            {
                let v4 = Dice_ui::method217(v0_1);
                let get_value = v4;
                {
                    let v6: string =
                        string("class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\"");
                    let v19: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    string("<input "),
                                    append(
                                        append(
                                            string(" prop:checked=move || get_value()"),
                                            append(
                                                append(
                                                    string(
                                                        " on:change=move |event| on_change(event)",
                                                    ),
                                                    append(
                                                        append(
                                                            string(" id=v1"),
                                                            append(
                                                                append(
                                                                    string(" type=\"checkbox\""),
                                                                    append(
                                                                        append(
                                                                            append(string(" "), v6),
                                                                            string(""),
                                                                        ),
                                                                        string(""),
                                                                    ),
                                                                ),
                                                                string(""),
                                                            ),
                                                        ),
                                                        string(""),
                                                    ),
                                                ),
                                                string(""),
                                            ),
                                        ),
                                        string(""),
                                    ),
                                ),
                                string(" />"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method171(
                        leptos::view! { <input  prop:checked=move || get_value() on:change=move |event| on_change(event) id=v1 type="checkbox" class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" /> },
                    );
                    let v24: leptos::View = leptos::IntoView::into_view(v22);
                    let v25: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v27: string =
                        append(append(append(string(" "), v25), string("")), string(""));
                    let v29 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method172()));
                    let v32: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v27), string(">{v29()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v35: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">{v29()}</span> },
                    );
                    let v37: leptos::View = leptos::IntoView::into_view(v35);
                    let v38: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v40: string =
                        append(append(append(string(" "), v38), string("")), string(""));
                    let v42 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method179()));
                    let v44: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v40), string(">{v42()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v47: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">{v42()}</span> },
                    );
                    let v52: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            v24,
                            v37,
                            leptos::IntoView::into_view(v47),
                        ])));
                    let v54: Vec<leptos::View> = v52.to_vec();
                    leptos::Fragment::new(v54)
                }
            }
        }
        pub fn method214(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure110(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure109(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method213());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let id = v6.clone();
            {
                let v13: string =
                    string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=id");
                let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method214(v0_1, v6)));
                let v18: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<label "), v13), string(">{v15()}</")),
                                string("label"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v21: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method180(
                    leptos::view! { <label  class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]" for=id>{v15()}</label> },
                );
                let v26: Array<leptos::View> =
                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                        leptos::IntoView::into_view(v21),
                    ])));
                let v28: Vec<leptos::View> = v26.to_vec();
                leptos::Fragment::new(v28)
            }
        }
        pub fn method212(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure109(v0_1.clone(), ())
            })
        }
        pub fn method219(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method220(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn method221(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn closure114(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"[font-size:12px] text-gray-400\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method219(v0_1)));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dt "), v5), string(">{v7()}</")),
                            string("dt"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Dt> = Dice_ui::method220(
                leptos::view! { <dt  class="[font-size:12px] text-gray-400">{v7()}</dt> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1\"");
            let v20 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method219(v1)));
            let v23: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dd "), v18), string(">{v20()}</")),
                            string("dd"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v26: leptos::HtmlElement<leptos::html::Dd> = Dice_ui::method221(
                leptos::view! { <dd  class="[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1">{v20()}</dd> },
            );
            let v31: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v15,
                leptos::IntoView::into_view(v26),
            ])));
            let v33: Vec<leptos::View> = v31.to_vec();
            leptos::Fragment::new(v33)
        }
        pub fn method218(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure114(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method223() -> string {
            string("Debug")
        }
        pub fn closure115(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method223()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method222() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure115((), ()))
        }
        pub fn method225() -> string {
            string("debug")
        }
        pub fn closure118(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method216();
            let v8: leptos::RwSignal<bool> = Dice_ui::method57(v5.l2.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method227(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure118(v0_1.clone(), v)
            })
        }
        pub fn closure119(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method73((leptos::SignalGetUntracked::get_untracked(&v2)).l2.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method228(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure119(v0_1.clone(), ())
            })
        }
        pub fn closure117(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method227(v0_1.clone());
            let on_change = v2;
            {
                let v4 = Dice_ui::method228(v0_1);
                let get_value = v4;
                {
                    let v6: string =
                        string("class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\"");
                    let v19: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    string("<input "),
                                    append(
                                        append(
                                            string(" prop:checked=move || get_value()"),
                                            append(
                                                append(
                                                    string(
                                                        " on:change=move |event| on_change(event)",
                                                    ),
                                                    append(
                                                        append(
                                                            string(" id=v1"),
                                                            append(
                                                                append(
                                                                    string(" type=\"checkbox\""),
                                                                    append(
                                                                        append(
                                                                            append(string(" "), v6),
                                                                            string(""),
                                                                        ),
                                                                        string(""),
                                                                    ),
                                                                ),
                                                                string(""),
                                                            ),
                                                        ),
                                                        string(""),
                                                    ),
                                                ),
                                                string(""),
                                            ),
                                        ),
                                        string(""),
                                    ),
                                ),
                                string(" />"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method171(
                        leptos::view! { <input  prop:checked=move || get_value() on:change=move |event| on_change(event) id=v1 type="checkbox" class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" /> },
                    );
                    let v24: leptos::View = leptos::IntoView::into_view(v22);
                    let v25: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v27: string =
                        append(append(append(string(" "), v25), string("")), string(""));
                    let v29 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method172()));
                    let v32: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v27), string(">{v29()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v35: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">{v29()}</span> },
                    );
                    let v37: leptos::View = leptos::IntoView::into_view(v35);
                    let v38: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v40: string =
                        append(append(append(string(" "), v38), string("")), string(""));
                    let v42 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method179()));
                    let v44: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v40), string(">{v42()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v47: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">{v42()}</span> },
                    );
                    let v52: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            v24,
                            v37,
                            leptos::IntoView::into_view(v47),
                        ])));
                    let v54: Vec<leptos::View> = v52.to_vec();
                    leptos::Fragment::new(v54)
                }
            }
        }
        pub fn method226(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure117(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure116(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method225());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let id = v6.clone();
            {
                let v13: string =
                    string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=id");
                let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method226(v0_1, v6)));
                let v18: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<label "), v13), string(">{v15()}</")),
                                string("label"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v21: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method180(
                    leptos::view! { <label  class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]" for=id>{v15()}</label> },
                );
                let v26: Array<leptos::View> =
                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                        leptos::IntoView::into_view(v21),
                    ])));
                let v28: Vec<leptos::View> = v26.to_vec();
                leptos::Fragment::new(v28)
            }
        }
        pub fn method224(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure116(v0_1.clone(), ())
            })
        }
        pub fn method229(
            v0_1: Array<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn method231(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure120(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method230() -> Func1<leptos::HtmlElement<leptos::html::Dl>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Dl>| Dice_ui::closure120((), v))
        }
        pub fn method232(
            v0_1: Array<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn closure107(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v10: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v12 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method210(),
                Dice_ui::method212(v0_1.clone()),
            )));
            let v15: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v10), string(">{v12()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v17: leptos::HtmlElement<leptos::html::Dl> = leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">{v12()}</dl> };
            let v24: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v26 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method222(),
                Dice_ui::method224(v0_1),
            )));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v24), string(">{v26()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method229(new_array(
                &[
                    v17,
                    leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">{v26()}</dl> },
                ],
            ));
            let v33 = Dice_ui::method230();
            let v34: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method232(v32);
            let v36: Vec<leptos::HtmlElement<leptos::html::Dl>> = v34.to_vec();
            let v39: Vec<leptos::View> =
                Dice_ui::method149(v36.iter().map(|x| v33(x.clone())).collect());
            let v42: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v39));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method209(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure107(v0_1.clone(), ())
            })
        }
        pub fn closure122(
            v0_1: std::string::String,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string("r#\"\"#");
            let v7: &str = r#""#;
            let v8: string =
                string("class=\"group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\".to_owned() + v7");
            let v10: string = append(append(append(string(" "), v8), string("")), string(""));
            let v12 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(v0_1)));
            let v15: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<summary "), v10), string(">{v12()}</")),
                            string("summary"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v18: leptos::HtmlElement<leptos::html::Summary> = Dice_ui::method205(
                leptos::view! { <summary  class="group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700".to_owned() + v7>{v12()}</summary> },
            );
            let v20: leptos::View = leptos::IntoView::into_view(v18);
            let v23: string = string(" class=\"flex flex-1 flex-col\"");
            let v25 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method206(v1)));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v23), string(">{v25()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v31: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex flex-1 flex-col">{v25()}</div> },
            );
            let v36: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v20,
                leptos::IntoView::into_view(v31),
            ])));
            let v38: Vec<leptos::View> = v36.to_vec();
            leptos::Fragment::new(v38)
        }
        pub fn method234(
            v0_1: std::string::String,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure122(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure121(
            v0_1: std::string::String,
            v1: leptos::View,
            v2: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"[position:absolute] [right:0] [top:0]\"");
            let v8 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method197(v1)));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v6), string(">{v8()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="[position:absolute] [right:0] [top:0]">{v8()}</div> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(
                " open=true class=\"flex flex-1 group [&_summary::-webkit-details-marker]:hidden\"",
            );
            let v23 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method234(v0_1, v2)));
            let v26: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<details "), v21), string(">{v23()}</")),
                            string("details"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v29: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method207(
                leptos::view! { <details  open=true class="flex flex-1 group [&_summary::-webkit-details-marker]:hidden">{v23()}</details> },
            );
            let v34: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method233(
            v0_1: std::string::String,
            v1: leptos::View,
            v2: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure121(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method235() -> string {
            string("Debug")
        }
        pub fn method238() -> string {
            string("Global State")
        }
        pub fn closure124(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method238()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method237() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure124((), ()))
        }
        pub fn method241(v0_1: LrcPtr<Dice_ui::Heap2>) -> LrcPtr<Dice_ui::Heap2> {
            v0_1
        }
        pub fn closure127(unitVar: (), v0_1: std::string::String) -> Dice_ui::US24 {
            Dice_ui::US24::US24_1(v0_1)
        }
        pub fn closure128(unitVar: (), v0_1: std::string::String) -> Dice_ui::US24 {
            Dice_ui::US24::US24_0(v0_1)
        }
        pub fn closure126(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> string {
            let v2: string = Dice_ui::method0(string(
                "settings.global_state_log_render () / global_state_json memo",
            ));
            leptos::logging::log!("{}", v2);
            {
                let v4: LrcPtr<Dice_ui::Heap2> = Dice_ui::method241(v0_1);
                let v6: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v4).map_err(|x| x.to_string());
                let v9: Dice_ui::US24 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure128((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure127((), v6_0_0.clone()),
                };
                match &v9 {
                    Dice_ui::US24::US24_1(v9_1_0) => {
                        let v11: std::string::String = Dice_ui::method52(v9_1_0.clone());
                        fable_library_rust::String_::fromString(v11)
                    }
                    Dice_ui::US24::US24_0(v9_0_0) => append(
                        append(string("Error: "), toString(v9_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method240(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure126(v0_1.clone(), ())
            })
        }
        pub fn method242(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn closure129(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v14: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v9),
            ])));
            let v16: Vec<leptos::View> = v14.to_vec();
            leptos::Fragment::new(v16)
        }
        pub fn method243(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure129(v0_1.clone(), ())
            })
        }
        pub fn method244(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure125(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("settings.global_state_log_render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v7 = Dice_ui::method240(v4.unwrap());
                let v10: leptos::Memo<string> =
                    Dice_ui::method242(leptos::create_memo(move |_| v7()));
                let v16: string =
                    string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \"");
                let v18 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method243(v10())));
                let v21: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<pre "), v16), string(">{v18()}</")),
                                string("pre"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v24: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method244(
                    leptos::view! { <pre  class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] ">{v18()}</pre> },
                );
                let v29: Array<leptos::View> =
                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                        leptos::IntoView::into_view(v24),
                    ])));
                let v31: Vec<leptos::View> = v29.to_vec();
                leptos::Fragment::new(v31)
            }
        }
        pub fn method239() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure125((), ()))
        }
        pub fn closure123(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] \"");
            let v10 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method237(),
                Dice_ui::method239(),
            )));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v8), string(">{v10()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] ">{v10()}</dl> },
            );
            let v21: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method236() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure123((), ()))
        }
        pub fn closure130(unitVar: (), unitVar_1: ()) -> Option<string> {
            let v2: Option<string> =
                Some(string("https://api2.nearblocks.io/v1/account/i574n.near/txns?&order=desc&page=1&per_page=25"));
            let v5: string = Dice_ui::method0(append(
                append(
                    string("transactions.render () / url create_memo / result: "),
                    sprintf!("{:?}", &v2),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v5);
            v2
        }
        pub fn method245() -> Func0<Option<string>> {
            Func0::new(move || Dice_ui::closure130((), ()))
        }
        pub fn method247(v0_1: leptos::Memo<Option<string>>) -> leptos::Memo<Option<string>> {
            v0_1
        }
        pub fn closure131(v0_1: leptos::Memo<Option<string>>, unitVar: ()) -> Option<string> {
            let v1: leptos::Memo<Option<string>> = Dice_ui::method247(v0_1);
            v1()
        }
        pub fn method246(v0_1: leptos::Memo<Option<string>>) -> Func0<Option<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure131(v0_1.clone(), ())
            })
        }
        pub fn closure133(unitVar: (), v0_1: string) -> Dice_ui::US25 {
            Dice_ui::US25::US25_1(v0_1)
        }
        pub fn method248(v0_1: string) -> string {
            v0_1
        }
        pub fn method249(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure134(unitVar: (), v0_1: reqwest_wasm::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method250() -> Func1<reqwest_wasm::Error, std::string::String> {
            Func1::new(move |v: reqwest_wasm::Error| Dice_ui::closure134((), v))
        }
        pub fn method251(v0_1: Result<Option<string>, string>) -> Result<Option<string>, string> {
            v0_1
        }
        pub fn closure132(
            unitVar: (),
            v0_1: Option<string>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<Option<string>, string>>>>
        {
            let v3: string = Dice_ui::method0(append(
                append(
                    string("state_core.use_request (2) / json create_local_resource / url: "),
                    sprintf!("{:?}", &v0_1),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v3);
            let __future_init = Box::pin(async move {
                //;
                {
                    let v8: Dice_ui::US25 = defaultValue(
                        Dice_ui::US25::US25_0,
                        map(
                            Func1::new(move |v: string| Dice_ui::closure133((), v)),
                            v0_1,
                        ),
                    );
                    let v44: Dice_ui::US26 = match &v8 {
                        Dice_ui::US25::US25_1(v8_1_0) => {
                            let v12: string = Dice_ui::method6(Dice_ui::method18(
                                Dice_ui::method248(v8_1_0.clone()),
                            ));
                            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
                            let v17: std::string::String = Dice_ui::method249(String::from(v14));
                            let v19: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<
                                            reqwest_wasm::Response,
                                            reqwest_wasm::Error,
                                        >,
                                    >,
                                >,
                            > = Box::pin(
                                reqwest_wasm::Client::builder()
                                    .build()
                                    .map_err(|err| err.to_string())?
                                    .get(v17)
                                    .send(),
                            );
                            let v21: Result<reqwest_wasm::Response, reqwest_wasm::Error> =
                                v19.await;
                            let v22 = Dice_ui::method250();
                            let v24: Result<reqwest_wasm::Response, std::string::String> =
                                v21.map_err(|x| v22(x));
                            let v26: reqwest_wasm::Response = v24?;
                            let v28: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<std::string::String, reqwest_wasm::Error>,
                                    >,
                                >,
                            > = Box::pin(reqwest_wasm::Response::text(v26));
                            let v30: Result<std::string::String, reqwest_wasm::Error> = v28.await;
                            let v31 = Dice_ui::method250();
                            let v33: Result<std::string::String, std::string::String> =
                                v30.map_err(|x| v31(x));
                            let v36: std::string::String = Dice_ui::method52(v33?);
                            Dice_ui::US26::US26_1(Some(fable_library_rust::String_::fromString(
                                v36,
                            )))
                        }
                        _ => Dice_ui::US26::US26_0(string("Invalid url")),
                    };
                    let v51: Result<Option<string>, string> = Dice_ui::method251(match &v44 {
                        Dice_ui::US26::US26_1(v44_1_0) => {
                            Ok::<Option<string>, string>(v44_1_0.clone())
                        }
                        Dice_ui::US26::US26_0(v44_0_0) => {
                            Err::<Option<string>, string>(v44_0_0.clone())
                        }
                    });
                    v51
                }
            });
            {
                //;
                __future_init
            }
        }
        pub fn closure135(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v2: string = Dice_ui::method0(string("state_core.use_request (3) / database_memo"));
            leptos::logging::log!("{}", v2);
            {
                let v4: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method24(v0_1);
                leptos::SignalGet::get(&v4)
            }
        }
        pub fn method252(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure135(v0_1.clone(), ())
            })
        }
        pub fn closure136(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            unitVar: (),
        ) -> (Option<rexie::Rexie>, Option<string>) {
            let v2: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method24(v1);
            let v4: Option<rexie::Rexie> = leptos::SignalGet::get(&v2);
            let v5: leptos::Memo<Option<string>> = Dice_ui::method247(v0_1);
            (v4, v5())
        }
        pub fn method253(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func0<(Option<rexie::Rexie>, Option<string>)> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure136(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method254(
            v0_1: Result<Dice_ui::US27, std::string::String>,
        ) -> Result<Dice_ui::US27, std::string::String> {
            v0_1
        }
        pub fn closure138(unitVar: (), v0_1: Dice_ui::US27) -> Dice_ui::US28 {
            Dice_ui::US28::US28_1(v0_1)
        }
        pub fn closure139(unitVar: (), v0_1: std::string::String) -> Dice_ui::US28 {
            Dice_ui::US28::US28_0(v0_1)
        }
        pub fn method255(v0_1: Option<LrcPtr<Dice_ui::Heap4>>) -> Option<LrcPtr<Dice_ui::Heap4>> {
            v0_1
        }
        pub fn closure137(
            unitVar: (),
            _arg: (Option<rexie::Rexie>, Option<string>),
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Option<LrcPtr<Dice_ui::Heap4>>>>>
        {
            let v1: Option<string> = _arg.1.clone();
            let v0_1: Option<rexie::Rexie> = _arg.0.clone();
            let __future_init = Box::pin(async move {
                //;
                {
                    let v6: string =
                    Dice_ui::method0(append(append(append(append(string("state_core.use_request (4) / state_data_resource create_local_resource / url : "),
                                                                 sprintf!("{:?}",
                                                                          &v1)),
                                                          string(" / database: ")),
                                                   sprintf!("{:?}", &v0_1)),
                                            string("")));
                    leptos::logging::log!("{}", v6);
                    {
                        let v10: Dice_ui::US5 = defaultValue(
                            Dice_ui::US5::US5_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                v0_1,
                            ),
                        );
                        let v13: Dice_ui::US25 = defaultValue(
                            Dice_ui::US25::US25_0,
                            map(
                                Func1::new(move |v_1: string| Dice_ui::closure133((), v_1)),
                                v1,
                            ),
                        );
                        let v130: Dice_ui::US27 = if let Dice_ui::US5::US5_1(v10_1_0) = &v10 {
                            if let Dice_ui::US25::US25_1(v13_1_0) = &v13 {
                                let v16: string = append(
                                    append(
                                        string("url["),
                                        match &v13 {
                                            Dice_ui::US25::US25_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    ),
                                    string("]"),
                                );
                                let v18: string = Dice_ui::method0(append(
                                    append(string("state_core.get_data () / id: "), v16.clone()),
                                    string(""),
                                ));
                                leptos::logging::log!("{}", v18);
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v23: Array<string> =
                                            Dice_ui::method25(new_array(&[string("store")]));
                                        let v24 = Dice_ui::method26();
                                        let v25: Array<string> = Dice_ui::method27(v23);
                                        let v27: Vec<string> = v25.to_vec();
                                        let v30: Vec<std::string::String> = Dice_ui::method28(
                                            v27.iter().map(|x| v24(x.clone())).collect(),
                                        );
                                        let v32: Array<std::string::String> =
                                            fable_library_rust::NativeArray_::array_from(v30);
                                        let v33: rexie::Rexie = Dice_ui::method29(match &v10 {
                                            Dice_ui::US5::US5_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        });
                                        let v35: Result<rexie::Transaction, rexie::Error> =
                                            v33.transaction(&v32, rexie::TransactionMode::ReadOnly);
                                        let v36 = Dice_ui::method30();
                                        let v38: Result<rexie::Transaction, std::string::String> =
                                            v35.map_err(|x| v36(x));
                                        let v40: rexie::Transaction = v38?;
                                        let v41: string = Dice_ui::method31();
                                        let v43: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v41);
                                        let v45: Result<rexie::Store, rexie::Error> =
                                            v40.store(v43);
                                        let v46 = Dice_ui::method32();
                                        let v48: Result<rexie::Store, std::string::String> =
                                            v45.map_err(|x| v46(x));
                                        let v50: rexie::Store = v48?;
                                        let v51: string = Dice_ui::method6(v16);
                                        let v53: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v51);
                                        let v55: wasm_bindgen::JsValue =
                                            wasm_bindgen::JsValue::from_str(v53);
                                        let v57: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        wasm_bindgen::JsValue,
                                                        rexie::Error,
                                                    >,
                                                >,
                                            >,
                                        > = Box::pin(rexie::Store::get(&v50, &v55));
                                        let v59: Result<wasm_bindgen::JsValue, rexie::Error> =
                                            v57.await;
                                        let v60 = Dice_ui::method34();
                                        let v62: Result<
                                            wasm_bindgen::JsValue,
                                            std::string::String,
                                        > = v59.map_err(|x| v60(x));
                                        let v65: wasm_bindgen::JsValue = Dice_ui::method35(v62?);
                                        let v67: Result<
                                            Option<serde_json::Value>,
                                            serde_wasm_bindgen::Error,
                                        > = serde_wasm_bindgen::from_value(v65);
                                        let v68 = Dice_ui::method36();
                                        let v70: Result<
                                            Option<serde_json::Value>,
                                            std::string::String,
                                        > = v67.map_err(|x| v68(x));
                                        let v75: Dice_ui::US7 = defaultValue(
                                            Dice_ui::US7::US7_0,
                                            map(
                                                Func1::new(move |v_2: serde_json::Value| {
                                                    Dice_ui::closure18((), v_2)
                                                }),
                                                v70?,
                                            ),
                                        );
                                        let v110: Result<Dice_ui::US27, std::string::String> =
                                            Dice_ui::method254(Ok::<
                                                Dice_ui::US27,
                                                std::string::String,
                                            >(
                                                match &v75 {
                                                Dice_ui::US7::US7_1(v75_1_0) => {
                                                    let v77: serde_json::Value =
                                                        Dice_ui::method37(v75_1_0.clone());
                                                    let v79: Result<Vec<u8>, serde_json::Error> =
                                                        serde_json::from_value(v77);
                                                    let v80 = Dice_ui::method38();
                                                    let v82: Result<Vec<u8>, std::string::String> =
                                                        v79.map_err(|x| v80(x));
                                                    let v85: Vec<u8> = Dice_ui::method39(v82?);
                                                    let v87:
                                                                                                     Array<u8> =
                                                                                                 fable_library_rust::NativeArray_::array_from(v85);
                                                    let v90:
                                                                                                     string =
                                                                                                 Dice_ui::method0(append(append(string("state_core.get_data () / data_len: "),
                                                                                                                                toString(count(v87.clone()))),
                                                                                                                         string("")));
                                                    leptos::logging::log!("{}", v90);
                                                    {
                                                        let v92: Array<u8> = Dice_ui::method40(v87);
                                                        let v94: Vec<u8> = v92.to_vec();
                                                        let v96: &[u8] = v94.as_slice();
                                                        let mut v96 = v96;
                                                        {
                                                            let v99:
                                                                                                             Result<LrcPtr<Dice_ui::Heap4>,
                                                                                                                    borsh::io::Error> =
                                                                                                         borsh::BorshDeserialize::deserialize(&mut v96);
                                                            let v100 = Dice_ui::method41();
                                                            let v102: Result<
                                                                LrcPtr<Dice_ui::Heap4>,
                                                                std::string::String,
                                                            > = v99.map_err(|x| v100(x));
                                                            Dice_ui::US27::US27_1(v102?)
                                                        }
                                                    }
                                                }
                                                _ => Dice_ui::US27::US27_0,
                                            }
                                            ));
                                        v110
                                    }
                                });
                                {
                                    //;
                                    {
                                        let v113: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        Dice_ui::US27,
                                                        std::string::String,
                                                    >,
                                                >,
                                            >,
                                        > = __future_init;
                                        let v115: Result<Dice_ui::US27, std::string::String> =
                                            v113.await;
                                        let v118: Dice_ui::US28 = match &v115 {
                                            Err(v115_1_0) => {
                                                Dice_ui::closure139((), v115_1_0.clone())
                                            }
                                            Ok(v115_0_0) => {
                                                Dice_ui::closure138((), v115_0_0.clone())
                                            }
                                        };
                                        match &v118 {
                                            Dice_ui::US28::US28_1(v118_1_0) => v118_1_0.clone(),
                                            Dice_ui::US28::US28_0(v118_0_0) => {
                                                let v122: string =
                                                    Dice_ui::method0(append(append(string("state_core.use_request (4.1) / state_data_resource create_local_resource / error: "),
                                                                                   toString(v118_0_0.clone())),
                                                                            string("")));
                                                leptos::logging::log!("{}", v122);
                                                Dice_ui::US27::US27_0
                                            }
                                        }
                                    }
                                }
                            } else {
                                Dice_ui::US27::US27_0
                            }
                        } else {
                            Dice_ui::US27::US27_0
                        };
                        let v136: Option<LrcPtr<Dice_ui::Heap4>> =
                            Dice_ui::method255(match &v130 {
                                Dice_ui::US27::US27_1(v130_1_0) => Some(v130_1_0.clone()),
                                _ => None::<LrcPtr<Dice_ui::Heap4>>,
                            });
                        v136
                    }
                }
            });
            {
                {
                    //;
                    __future_init
                }
            }
        }
        pub fn method257(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
        ) -> leptos::Resource<(Option<rexie::Rexie>, Option<string>), Option<LrcPtr<Dice_ui::Heap4>>>
        {
            v0_1
        }
        pub fn closure141(unitVar: (), v0_1: Option<LrcPtr<Dice_ui::Heap4>>) -> Dice_ui::US29 {
            Dice_ui::US29::US29_1(v0_1)
        }
        pub fn closure142(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap4>) -> Dice_ui::US27 {
            Dice_ui::US27::US27_1(v0_1)
        }
        pub fn closure140(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
            unitVar: (),
        ) -> Option<LrcPtr<Dice_ui::Heap4>> {
            let v2: string =
                Dice_ui::method0(string("state_core.use_request (5) / state_data_func"));
            leptos::logging::log!("{}", v2);
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method46(Dice_ui::method45());
                let v8: Dice_ui::US9 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure25((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure24((), v5_0_0.clone()),
                };
                let v17: Dice_ui::US10 = match &v8 {
                    Dice_ui::US9::US9_1(v8_1_0) => Dice_ui::US10::US10_1(defaultValue(
                        Dice_ui::US11::US11_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure26((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US9::US9_0(v8_0_0) => Dice_ui::US10::US10_0(v8_0_0.clone()),
                };
                let v53: Dice_ui::US27 = if let Dice_ui::US10::US10_1(v17_1_0) = &v17 {
                    if let Dice_ui::US11::US11_1(_) = &match &v17 {
                        Dice_ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<
                            (Option<rexie::Rexie>, Option<string>),
                            Option<LrcPtr<Dice_ui::Heap4>>,
                        > = Dice_ui::method257(v0_1);
                        let v25: Dice_ui::US29 = defaultValue(
                            Dice_ui::US29::US29_0,
                            map(
                                Func1::new(move |v_3: Option<LrcPtr<Dice_ui::Heap4>>| {
                                    Dice_ui::closure141((), v_3)
                                }),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v33: Dice_ui::US30 = match &v25 {
                            Dice_ui::US29::US29_1(v25_1_0) => Dice_ui::US30::US30_1(defaultValue(
                                Dice_ui::US27::US27_0,
                                map(
                                    Func1::new(move |v_4: LrcPtr<Dice_ui::Heap4>| {
                                        Dice_ui::closure142((), v_4)
                                    }),
                                    v25_1_0.clone(),
                                ),
                            )),
                            _ => Dice_ui::US30::US30_0,
                        };
                        let v40: Dice_ui::US27 = if let Dice_ui::US30::US30_1(v33_1_0) = &v33 {
                            let v34: Dice_ui::US27 = match &v33 {
                                Dice_ui::US30::US30_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US27::US27_1(v34_1_0) = &v34 {
                                Dice_ui::US27::US27_1(match &v34 {
                                    Dice_ui::US27::US27_1(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Dice_ui::US27::US27_0
                            }
                        } else {
                            Dice_ui::US27::US27_0
                        };
                        let v41: string = sprintf!("{:?}", &v40);
                        let v48: string =
                                Dice_ui::method0(append(append(string("state_core.use_request (7) / new_signal_map memo / state_data: "),
                                                               (if length(v41.clone())
                                                                       <=
                                                                       200_i32
                                                                   {
                                                                    v41.clone()
                                                                } else {
                                                                    append(substring2(v41,
                                                                                      0_i32,
                                                                                      200_i32),
                                                                           string("..."))
                                                                })),
                                                        string("")));
                        leptos::logging::log!("{}", v48);
                        v40
                    } else {
                        Dice_ui::US27::US27_0
                    }
                } else {
                    Dice_ui::US27::US27_0
                };
                match &v53 {
                    Dice_ui::US27::US27_1(v53_1_0) => Some(v53_1_0.clone()),
                    _ => None::<LrcPtr<Dice_ui::Heap4>>,
                }
            }
        }
        pub fn method256(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
        ) -> Func0<Option<LrcPtr<Dice_ui::Heap4>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure140(v0_1.clone(), ())
            })
        }
        pub fn method259(
            v0_1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> leptos::Memo<Option<rexie::Rexie>> {
            v0_1
        }
        pub fn method260(v0_1: leptos::Memo<Option<string>>) -> leptos::Memo<Option<string>> {
            v0_1
        }
        pub fn closure143(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Memo<Option<rexie::Rexie>>,
            v2: LrcPtr<Dice_ui::Heap4>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v4: i64 = length(sprintf!("{:?}", &v2)) as i64;
            let __future_init = Box::pin(async move {
                //;
                {
                    let v7: string = Dice_ui::method0(append(
                        append(
                            string(
                                "state_core.use_request (8) / set_state_data_action / value_len: ",
                            ),
                            toString(v4),
                        ),
                        string(""),
                    ));
                    leptos::logging::log!("{}", v7);
                    {
                        let v9: leptos::Memo<Option<rexie::Rexie>> = Dice_ui::method259(v1);
                        let v14: Dice_ui::US5 = defaultValue(
                            Dice_ui::US5::US5_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                leptos::SignalGetUntracked::get_untracked(&v9),
                            ),
                        );
                        let v15: leptos::Memo<Option<string>> = Dice_ui::method260(v0_1);
                        let v20: Dice_ui::US25 = defaultValue(
                            Dice_ui::US25::US25_0,
                            map(
                                Func1::new(move |v_1: string| Dice_ui::closure133((), v_1)),
                                leptos::SignalGetUntracked::get_untracked(&v15),
                            ),
                        );
                        if let Dice_ui::US5::US5_1(v14_1_0) = &v14 {
                            if let Dice_ui::US25::US25_1(v20_1_0) = &v20 {
                                let v22: string = match &v20 {
                                    Dice_ui::US25::US25_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v24: string =
                                Dice_ui::method0(append(append(string("state_core.use_request (9) / set_state_data_action / database=Some(_) / url: "),
                                                               v22.clone()),
                                                        string("")));
                                leptos::logging::log!("{}", v24);
                                {
                                    let v26: string =
                                        append(append(string("url["), v22), string("]"));
                                    let v30: string = Dice_ui::method0(append(
                                        append(
                                            string("state_core.set_data () / data_len: "),
                                            toString(length(sprintf!("{:?}", &v2)) as i64),
                                        ),
                                        string(""),
                                    ));
                                    leptos::logging::log!("{}", v30);
                                    {
                                        let v32: rexie::Rexie = Dice_ui::method68(match &v14 {
                                            Dice_ui::US5::US5_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        });
                                        let __future_init = Box::pin(async {
                                            //;
                                            {
                                                let v35: rexie::Transaction = v32.transaction(
                                                    &["store"],
                                                    rexie::TransactionMode::ReadWrite,
                                                )?;
                                                let v37: rexie::Store = v35.store("store")?;
                                                let mut data = Vec::new();
                                                borsh::BorshSerialize::serialize(&v2, &mut data)
                                                    .unwrap();
                                                {
                                                    let v41: Vec<u8> = data;
                                                    let v43: wasm_bindgen::JsValue =
                                                        serde_wasm_bindgen::to_value(&v41).unwrap();
                                                    let v44: string = Dice_ui::method6(v26);
                                                    let v46: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v44,
                                                        );
                                                    v37.put(&v43, Some(&v46.into())).await?;
                                                    v35.done().await?;
                                                    {
                                                        let v50: Result<(), rexie::Error> =
                                                            Dice_ui::method69(
                                                                Ok::<(), rexie::Error>(()),
                                                            );
                                                        v50
                                                    }
                                                }
                                            }
                                        });
                                        {
                                            {
                                                {
                                                    //;
                                                    {
                                                        let v53: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = Result<
                                                                        (),
                                                                        rexie::Error,
                                                                    >,
                                                                >,
                                                            >,
                                                        > = __future_init;
                                                        let v55: Result<(), rexie::Error> =
                                                            v53.await;
                                                        let v58: Dice_ui::US16 = match &v55 {
                                                            Err(v55_1_0) => Dice_ui::closure41(
                                                                (),
                                                                v55_1_0.clone(),
                                                            ),
                                                            _ => Dice_ui::closure40((), ()),
                                                        };
                                                        match &v58 {
                                                        Dice_ui::US16::US16_1
                                                        => (),
                                                        Dice_ui::US16::US16_0(v58_0_0)
                                                        =>
                                                        panic!("{}",
                                                               sprintf!("resultm.get / Result value was Error: {}", v58_0_0),),
                                                    }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            } else {
                                let v62: string =
                                Dice_ui::method0(string("state_core.use_request (10) / set_state_data_action / database,url=None"));
                                leptos::logging::log!("{}", v62);
                                ()
                            }
                        } else {
                            let v65: string =
                            Dice_ui::method0(string("state_core.use_request (10) / set_state_data_action / database,url=None"));
                            leptos::logging::log!("{}", v65);
                            ()
                        }
                        Dice_ui::method70();
                        ()
                    }
                }
            });
            {
                {
                    //;
                    __future_init
                }
            }
        }
        pub fn method258(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> Func1<LrcPtr<Dice_ui::Heap4>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure143(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn method262(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
        ) -> leptos::Resource<Option<string>, Result<Option<string>, string>> {
            v0_1
        }
        pub fn closure145(unitVar: (), v0_1: Result<Option<string>, string>) -> Dice_ui::US31 {
            Dice_ui::US31::US31_1(v0_1)
        }
        pub fn closure146(unitVar: (), v0_1: Option<string>) -> Dice_ui::US26 {
            Dice_ui::US26::US26_1(v0_1)
        }
        pub fn closure147(unitVar: (), v0_1: string) -> Dice_ui::US26 {
            Dice_ui::US26::US26_0(v0_1)
        }
        pub fn method263(v0_1: LrcPtr<Dice_ui::Heap4>) -> LrcPtr<Dice_ui::Heap4> {
            v0_1
        }
        pub fn closure144(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()>,
            unitVar: (),
        ) {
            let v3: string = Dice_ui::method0(string(
                "state_core.use_request (11) / effect new_state_data / ##2",
            ));
            leptos::logging::log!("{}", v3);
            {
                let v6: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method46(Dice_ui::method45());
                let v9: Dice_ui::US9 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure25((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure24((), v6_0_0.clone()),
                };
                let v18: Dice_ui::US10 = match &v9 {
                    Dice_ui::US9::US9_1(v9_1_0) => Dice_ui::US10::US10_1(defaultValue(
                        Dice_ui::US11::US11_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure26((), v_2)),
                            v9_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US9::US9_0(v9_0_0) => Dice_ui::US10::US10_0(v9_0_0.clone()),
                };
                if let Dice_ui::US10::US10_1(v18_1_0) = &v18 {
                    if let Dice_ui::US11::US11_1(_) = &match &v18 {
                        Dice_ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v21: leptos::Resource<Option<string>, Result<Option<string>, string>> =
                            Dice_ui::method262(v0_1);
                        let v26: Dice_ui::US31 = defaultValue(
                            Dice_ui::US31::US31_0,
                            map(
                                Func1::new(move |v_3: Result<Option<string>, string>| {
                                    Dice_ui::closure145((), v_3)
                                }),
                                leptos::SignalGet::get(&v21),
                            ),
                        );
                        let v34: Dice_ui::US32 = match &v26 {
                            Dice_ui::US31::US31_1(v26_1_0) => {
                                let v27: Result<Option<string>, string> = v26_1_0.clone();
                                Dice_ui::US32::US32_1(match &v27 {
                                    Err(v27_1_0) => Dice_ui::closure147((), v27_1_0.clone()),
                                    Ok(v27_0_0) => Dice_ui::closure146((), v27_0_0.clone()),
                                })
                            }
                            _ => Dice_ui::US32::US32_0,
                        };
                        let v48: Dice_ui::US33 = match &v34 {
                            Dice_ui::US32::US32_1(v34_1_0) => {
                                let v35: Dice_ui::US26 = v34_1_0.clone();
                                Dice_ui::US33::US33_1(match &v35 {
                                    Dice_ui::US26::US26_1(v35_1_0) => {
                                        Dice_ui::US34::US34_1(defaultValue(
                                            Dice_ui::US25::US25_0,
                                            map(
                                                Func1::new(move |v_6: string| {
                                                    Dice_ui::closure133((), v_6)
                                                }),
                                                v35_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US26::US26_0(v35_0_0) => {
                                        Dice_ui::US34::US34_0(v35_0_0.clone())
                                    }
                                })
                            }
                            _ => Dice_ui::US33::US33_0,
                        };
                        let v75: Dice_ui::US35 = if let Dice_ui::US33::US33_1(v48_1_0) = &v48 {
                            let v49: Dice_ui::US34 = match &v48 {
                                Dice_ui::US33::US33_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            match &v49 {
                                Dice_ui::US34::US34_1(v49_1_0) => {
                                    let v50: Dice_ui::US25 = v49_1_0.clone();
                                    if let Dice_ui::US25::US25_1(v50_1_0) = &v50 {
                                        let v53: string =
                                            Dice_ui::method6(Dice_ui::method18(match &v50 {
                                                Dice_ui::US25::US25_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            }));
                                        let v55: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v53);
                                        Dice_ui::US35::US35_1(Dice_ui::US14::US14_1(String::from(
                                            v55,
                                        )))
                                    } else {
                                        Dice_ui::US35::US35_1(Dice_ui::US14::US14_0)
                                    }
                                }
                                Dice_ui::US34::US34_0(v49_0_0) => {
                                    let v65: string =
                                        Dice_ui::method6(Dice_ui::method18(v49_0_0.clone()));
                                    let v67: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v65);
                                    Dice_ui::US35::US35_0(String::from(v67))
                                }
                            }
                        } else {
                            Dice_ui::US35::US35_1(Dice_ui::US14::US14_0)
                        };
                        let v76: string = sprintf!("{:?}", &v75);
                        let v83: string = Dice_ui::method0(append(
                            append(
                                string("state_core.use_request (12) / effect / json: "),
                                (if length(v76.clone()) <= 200_i32 {
                                    v76.clone()
                                } else {
                                    append(substring2(v76, 0_i32, 200_i32), string("..."))
                                }),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v83);
                        if let Dice_ui::US35::US35_1(v75_1_0) = &v75 {
                            let v85: Dice_ui::US14 = match &v75 {
                                Dice_ui::US35::US35_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US14::US14_1(v85_1_0) = &v85 {
                                let v88: LrcPtr<Dice_ui::Heap4> =
                                    Dice_ui::method263(LrcPtr::new(Dice_ui::Heap4 {
                                        l0: match &v85 {
                                            Dice_ui::US14::US14_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    }));
                                leptos::Action::dispatch(&v1, v88);
                                ()
                            }
                        }
                    };
                }
                {
                    let v91: string = Dice_ui::method0(string(
                        "state_core.use_request (13) / effect new_state_data / ##5",
                    ));
                    leptos::logging::log!("{}", v91);
                    ()
                }
            }
        }
        pub fn method261(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure144(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method265() -> string {
            string("Invalid url")
        }
        pub fn method266(
            v0_1: Func0<Option<LrcPtr<Dice_ui::Heap4>>>,
        ) -> Func0<Option<LrcPtr<Dice_ui::Heap4>>> {
            v0_1
        }
        pub fn closure149(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Root,
        ) -> Option<crate::model::near::nearblocks::Root> {
            Some(v0_1)
        }
        pub fn method267(
        ) -> Func1<crate::model::near::nearblocks::Root, Option<crate::model::near::nearblocks::Root>>
        {
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure149((), v))
        }
        pub fn method268(
            v0_1: Result<crate::model::near::nearblocks::Root, std::string::String>,
        ) -> Result<crate::model::near::nearblocks::Root, std::string::String> {
            v0_1
        }
        pub fn closure148(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v2: Func0<Option<LrcPtr<Dice_ui::Heap4>>>,
            unitVar: (),
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            let v3: leptos::Memo<Option<string>> = Dice_ui::method247(v0_1);
            let v5: Option<string> = v3();
            let v8: string = Dice_ui::method0(append(
                append(
                    string("state_core.use_request (14) / result memo / url: "),
                    sprintf!("{:?}", &v5),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v8);
            {
                fn v10(v: string) -> Dice_ui::US25 {
                    Dice_ui::closure133((), v)
                }
                let v12: Dice_ui::US25 =
                    defaultValue(Dice_ui::US25::US25_0, map(Func1::from(v10), v5));
                let v159: Result<
                    Option<crate::model::near::nearblocks::Root>,
                    std::string::String,
                > = match &v12 {
                    Dice_ui::US25::US25_1(v12_1_0) => {
                        let v15: string = Dice_ui::method0(append(
                            append(
                                string("state_core.use_request (15) / result memo / url: "),
                                v12_1_0.clone(),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v15);
                        {
                            let v17: Func0<Option<LrcPtr<Dice_ui::Heap4>>> = Dice_ui::method266(v2);
                            let v22: Dice_ui::US27 = defaultValue(
                                Dice_ui::US27::US27_0,
                                map(
                                    Func1::new(move |v_1: LrcPtr<Dice_ui::Heap4>| {
                                        Dice_ui::closure142((), v_1)
                                    }),
                                    (move || v17())(),
                                ),
                            );
                            let v23: string = sprintf!("{:?}", &v22);
                            let v30: string = Dice_ui::method0(append(
                                append(
                                    string(
                                        "state_core.use_request (16) / result_memo / state_data: ",
                                    ),
                                    (if length(v23.clone()) <= 200_i32 {
                                        v23.clone()
                                    } else {
                                        append(substring2(v23, 0_i32, 200_i32), string("..."))
                                    }),
                                ),
                                string(""),
                            ));
                            leptos::logging::log!("{}", v30);
                            {
                                let v32: leptos::Resource<
                                    Option<string>,
                                    Result<Option<string>, string>,
                                > = Dice_ui::method262(v1);
                                let v37: Dice_ui::US31 = defaultValue(
                                    Dice_ui::US31::US31_0,
                                    map(
                                        Func1::new(move |v_2: Result<Option<string>, string>| {
                                            Dice_ui::closure145((), v_2)
                                        }),
                                        leptos::SignalGet::get(&v32),
                                    ),
                                );
                                let v45: Dice_ui::US32 = match &v37 {
                                    Dice_ui::US31::US31_1(v37_1_0) => {
                                        let v38: Result<Option<string>, string> = v37_1_0.clone();
                                        Dice_ui::US32::US32_1(match &v38 {
                                            Err(v38_1_0) => {
                                                Dice_ui::closure147((), v38_1_0.clone())
                                            }
                                            Ok(v38_0_0) => Dice_ui::closure146((), v38_0_0.clone()),
                                        })
                                    }
                                    _ => Dice_ui::US32::US32_0,
                                };
                                let v58: Dice_ui::US33 = match &v45 {
                                    Dice_ui::US32::US32_1(v45_1_0) => {
                                        let v46: Dice_ui::US26 = v45_1_0.clone();
                                        Dice_ui::US33::US33_1(match &v46 {
                                            Dice_ui::US26::US26_1(v46_1_0) => {
                                                Dice_ui::US34::US34_1(defaultValue(
                                                    Dice_ui::US25::US25_0,
                                                    map(Func1::from(v10), v46_1_0.clone()),
                                                ))
                                            }
                                            Dice_ui::US26::US26_0(v46_0_0) => {
                                                Dice_ui::US34::US34_0(v46_0_0.clone())
                                            }
                                        })
                                    }
                                    _ => Dice_ui::US33::US33_0,
                                };
                                let v73: Dice_ui::US34 =
                                    if let Dice_ui::US33::US33_1(v58_1_0) = &v58 {
                                        let v59: Dice_ui::US34 = match &v58 {
                                            Dice_ui::US33::US33_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        match &v59 {
                                            Dice_ui::US34::US34_1(v59_1_0) => {
                                                let v62: Dice_ui::US25 = v59_1_0.clone();
                                                if let Dice_ui::US25::US25_1(v62_1_0) = &v62 {
                                                    Dice_ui::US34::US34_1(Dice_ui::US25::US25_1(
                                                        match &v62 {
                                                            Dice_ui::US25::US25_1(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    ))
                                                } else {
                                                    Dice_ui::US34::US34_1(Dice_ui::US25::US25_0)
                                                }
                                            }
                                            Dice_ui::US34::US34_0(v59_0_0) => {
                                                Dice_ui::US34::US34_0(v59_0_0.clone())
                                            }
                                        }
                                    } else {
                                        Dice_ui::US34::US34_1(Dice_ui::US25::US25_0)
                                    };
                                let v74: string = sprintf!("{:?}", &v73);
                                let v81: string = Dice_ui::method0(append(
                                    append(
                                        string("state_core.use_request (16.1) / effect / json: "),
                                        (if length(v74.clone()) <= 200_i32 {
                                            v74.clone()
                                        } else {
                                            append(substring2(v74, 0_i32, 200_i32), string("..."))
                                        }),
                                    ),
                                    string(""),
                                ));
                                leptos::logging::log!("{}", v81);
                                {
                                    let v91: Dice_ui::US25 = match &v22 {
                                        Dice_ui::US27::US27_1(v22_1_0) => {
                                            let v85: std::string::String =
                                                Dice_ui::method52((v22_1_0).l0.clone());
                                            Dice_ui::US25::US25_1(
                                                fable_library_rust::String_::fromString(v85),
                                            )
                                        }
                                        _ => Dice_ui::US25::US25_0,
                                    };
                                    if let Dice_ui::US34::US34_1(v73_1_0) = &v73 {
                                        let v92: Dice_ui::US25 = match &v73 {
                                            Dice_ui::US34::US34_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US25::US25_1(v92_1_0) = &v92 {
                                            let v94: string = Dice_ui::method6(match &v92 {
                                                Dice_ui::US25::US25_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v96: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v94);
                                            let v98: Result<
                                                crate::model::near::nearblocks::Root,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v96);
                                            let v99 = Dice_ui::method53();
                                            let v101: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = v98.map_err(|x| v99(x));
                                            let v102 = Dice_ui::method267();
                                            let v103: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = Dice_ui::method268(v101);
                                            v103.map(|x| v102(x))
                                        } else {
                                            if let Dice_ui::US25::US25_1(v91_1_0) = &v91 {
                                                let v107: string = Dice_ui::method6(match &v91 {
                                                    Dice_ui::US25::US25_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                                let v109: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v107,
                                                    );
                                                let v111: Result<
                                                    crate::model::near::nearblocks::Root,
                                                    serde_json::Error,
                                                > = serde_json::from_str(&v109);
                                                let v112 = Dice_ui::method53();
                                                let v114: Result<
                                                    crate::model::near::nearblocks::Root,
                                                    std::string::String,
                                                > = v111.map_err(|x| v112(x));
                                                let v115 = Dice_ui::method267();
                                                let v116: Result<
                                                    crate::model::near::nearblocks::Root,
                                                    std::string::String,
                                                > = Dice_ui::method268(v114);
                                                v116.map(|x| v115(x))
                                            } else {
                                                let v121: string =
                                                        Dice_ui::method0(append(append(string("state_core.use_request (17) / json Error / value: "),
                                                                                       sprintf!("{:?}",
                                                                                                &(v73.clone(),
                                                                                                  v91.clone()))),
                                                                                string("")));
                                                leptos::logging::log!("{}", v121);
                                                Ok::<
                                                    Option<crate::model::near::nearblocks::Root>,
                                                    std::string::String,
                                                >(
                                                    None::<crate::model::near::nearblocks::Root>
                                                )
                                            }
                                        }
                                    } else {
                                        if let Dice_ui::US25::US25_1(v91_1_0) = &v91 {
                                            let v128: string = Dice_ui::method6(match &v91 {
                                                Dice_ui::US25::US25_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v130: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v128);
                                            let v132: Result<
                                                crate::model::near::nearblocks::Root,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v130);
                                            let v133 = Dice_ui::method53();
                                            let v135: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = v132.map_err(|x| v133(x));
                                            let v136 = Dice_ui::method267();
                                            let v137: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = Dice_ui::method268(v135);
                                            v137.map(|x| v136(x))
                                        } else {
                                            if let Dice_ui::US34::US34_0(v73_0_0) = &v73 {
                                                let v142: string = Dice_ui::method6(
                                                    Dice_ui::method18(match &v73 {
                                                        Dice_ui::US34::US34_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }),
                                                );
                                                let v144: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v142,
                                                    );
                                                Err::<
                                                    Option<crate::model::near::nearblocks::Root>,
                                                    std::string::String,
                                                >(
                                                    String::from(v144)
                                                )
                                            } else {
                                                panic!("{}", string("Match failure"),)
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _ => {
                        let v152: string = Dice_ui::method6(Dice_ui::method265());
                        let v154: &str = fable_library_rust::String_::LrcStr::as_str(&v152);
                        Err::<Option<crate::model::near::nearblocks::Root>, std::string::String>(
                            String::from(v154),
                        )
                    }
                };
                let v160: string = sprintf!("{:?}", &v159);
                let v167: string = Dice_ui::method0(append(
                    append(
                        string(
                            "state_core.use_request (18) / result create_memo / json_cache_obj: ",
                        ),
                        (if length(v160.clone()) <= 200_i32 {
                            v160.clone()
                        } else {
                            append(substring2(v160, 0_i32, 200_i32), string("..."))
                        }),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v167);
                v159
            }
        }
        pub fn method264(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v2: Func0<Option<LrcPtr<Dice_ui::Heap4>>>,
        ) -> Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure148(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method270(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US2, rexie::Rexie> {
            v0_1
        }
        pub fn method271(v0_1: leptos::Signal<bool>) -> leptos::Signal<bool> {
            v0_1
        }
        pub fn method272(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
        ) -> leptos::Resource<(Option<rexie::Rexie>, Option<string>), Option<LrcPtr<Dice_ui::Heap4>>>
        {
            v0_1
        }
        pub fn method273(
            v0_1: Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            v0_1
        }
        pub fn method275(
            v0_1: Option<crate::model::near::nearblocks::Root>,
        ) -> Option<crate::model::near::nearblocks::Root> {
            v0_1
        }
        pub fn method277(
            v0_1: crate::model::near::nearblocks::Root,
        ) -> crate::model::near::nearblocks::Root {
            v0_1
        }
        pub fn method279(
            v0_1: crate::model::near::nearblocks::Txn,
        ) -> crate::model::near::nearblocks::Txn {
            v0_1
        }
        pub fn method280(
            v0_1: crate::model::near::nearblocks::Block,
        ) -> crate::model::near::nearblocks::Block {
            v0_1
        }
        pub fn method282(
            v0_1: crate::model::near::nearblocks::Action,
        ) -> crate::model::near::nearblocks::Action {
            v0_1
        }
        pub fn closure154(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Action,
        ) -> (std::string::String, Option<std::string::String>) {
            let v1: crate::model::near::nearblocks::Action = Dice_ui::method282(v0_1);
            (v1.action, v1.method)
        }
        pub fn method281() -> Func1<
            crate::model::near::nearblocks::Action,
            (std::string::String, Option<std::string::String>),
        > {
            Func1::new(move |v: crate::model::near::nearblocks::Action| Dice_ui::closure154((), v))
        }
        pub fn method283(
            v0_1: Vec<(std::string::String, Option<std::string::String>)>,
        ) -> Vec<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method284(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
        ) -> Array<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method285(
            v0_1: crate::model::near::nearblocks::ActionsAgg,
        ) -> crate::model::near::nearblocks::ActionsAgg {
            v0_1
        }
        pub fn method286(
            v0_1: crate::model::near::nearblocks::Outcomes,
        ) -> crate::model::near::nearblocks::Outcomes {
            v0_1
        }
        pub fn method287(
            v0_1: crate::model::near::nearblocks::OutcomesAgg,
        ) -> crate::model::near::nearblocks::OutcomesAgg {
            v0_1
        }
        pub fn method288(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn closure153(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Txn,
        ) -> (
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        ) {
            let v1: crate::model::near::nearblocks::Txn = Dice_ui::method279(v0_1);
            let v3: std::string::String = v1.receipt_id;
            let v5: std::string::String = v1.predecessor_account_id;
            let v7: std::string::String = v1.receiver_account_id;
            let v9: std::string::String = v1.transaction_hash;
            let v11: std::string::String = v1.included_in_block_hash;
            let v13: std::string::String = v1.block_timestamp;
            let v16: crate::model::near::nearblocks::Block = Dice_ui::method280(v1.block);
            let v18: u32 = v16.block_height;
            let v19 = Dice_ui::method281();
            let v22: Vec<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method283(v1.actions.into_iter().map(|x| v19(x)).collect());
            let v25: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method284(fable_library_rust::NativeArray_::array_from(v22));
            let v28: crate::model::near::nearblocks::ActionsAgg =
                Dice_ui::method285(v1.actions_agg);
            let v30: f64 = v28.deposit;
            let v33: crate::model::near::nearblocks::Outcomes = Dice_ui::method286(v1.outcomes);
            let v35: bool = v33.status;
            let v38: crate::model::near::nearblocks::OutcomesAgg =
                Dice_ui::method287(v1.outcomes_agg);
            let v40: f64 = v38.transaction_fee;
            let v43: Vec<std::string::String> = Dice_ui::method28(v1.logs);
            (
                v25,
                v30,
                v18,
                v13,
                v11,
                Dice_ui::method288(fable_library_rust::NativeArray_::array_from(v43)),
                v35,
                v40,
                v5,
                v3,
                v7,
                v9,
            )
        }
        pub fn method278() -> Func1<
            crate::model::near::nearblocks::Txn,
            (
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(move |v: crate::model::near::nearblocks::Txn| Dice_ui::closure153((), v))
        }
        pub fn method289(
            v0_1: Vec<(
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Vec<(
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn method290(
            v0_1: Array<(
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn closure152(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Root,
        ) -> Array<(
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            let v1: crate::model::near::nearblocks::Root = Dice_ui::method277(v0_1);
            let v2 = Dice_ui::method278();
            let v5: Vec<(
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )> = Dice_ui::method289(v1.txns.into_iter().map(|x| v2(x)).collect());
            Dice_ui::method290(fable_library_rust::NativeArray_::array_from(v5))
        }
        pub fn method276() -> Func1<
            crate::model::near::nearblocks::Root,
            Array<(
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        > {
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure152((), v))
        }
        pub fn closure151(
            unitVar: (),
            v0_1: Option<crate::model::near::nearblocks::Root>,
        ) -> Option<
            Array<(
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        > {
            let v1: Option<crate::model::near::nearblocks::Root> = Dice_ui::method275(v0_1);
            let v2 = Dice_ui::method276();
            v1.map(|x| v2(x))
        }
        pub fn method274() -> Func1<
            Option<crate::model::near::nearblocks::Root>,
            Option<
                Array<(
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            >,
        > {
            Func1::new(move |v: Option<crate::model::near::nearblocks::Root>| {
                Dice_ui::closure151((), v)
            })
        }
        pub fn method291(
            v0_1: Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            v0_1
        }
        pub fn closure150(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            v1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
            v2: Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
            unitVar: (),
        ) -> Result<
            Option<
                Array<(
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            >,
            std::string::String,
        > {
            let v3: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method270(v0_1.clone());
            let v6: leptos::Signal<bool> = Dice_ui::method271(leptos::Resource::loading(&v3));
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            > = Dice_ui::method272(v1.clone());
            let v12: leptos::Signal<bool> = Dice_ui::method271(leptos::Resource::loading(&v9));
            let v14: bool = leptos::SignalGet::get(&v12);
            let v15: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method24(v0_1);
            let v20: Dice_ui::US5 = defaultValue(
                Dice_ui::US5::US5_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                    leptos::SignalGet::get(&v15),
                ),
            );
            let v21: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            > = Dice_ui::method257(v1);
            let v26: Dice_ui::US29 = defaultValue(
                Dice_ui::US29::US29_0,
                map(
                    Func1::new(move |v_1: Option<LrcPtr<Dice_ui::Heap4>>| {
                        Dice_ui::closure141((), v_1)
                    }),
                    leptos::SignalGet::get(&v21),
                ),
            );
            let v34: Dice_ui::US30 = match &v26 {
                Dice_ui::US29::US29_1(v26_1_0) => Dice_ui::US30::US30_1(defaultValue(
                    Dice_ui::US27::US27_0,
                    map(
                        Func1::new(move |v_2: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure142((), v_2)),
                        v26_1_0.clone(),
                    ),
                )),
                _ => Dice_ui::US30::US30_0,
            };
            let v41: Dice_ui::US27 = if let Dice_ui::US30::US30_1(v34_1_0) = &v34 {
                let v35: Dice_ui::US27 = match &v34 {
                    Dice_ui::US30::US30_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Dice_ui::US27::US27_1(v35_1_0) = &v35 {
                    Dice_ui::US27::US27_1(match &v35 {
                        Dice_ui::US27::US27_1(x) => x.clone(),
                        _ => unreachable!(),
                    })
                } else {
                    Dice_ui::US27::US27_0
                }
            } else {
                Dice_ui::US27::US27_0
            };
            let v42: string = sprintf!("{:?}", &v20);
            let v47: string = if length(v42.clone()) <= 200_i32 {
                v42.clone()
            } else {
                append(substring2(v42, 0_i32, 200_i32), string("..."))
            };
            let v48: string = sprintf!("{:?}", &v41);
            let v53: string = if length(v48.clone()) <= 200_i32 {
                v48.clone()
            } else {
                append(substring2(v48, 0_i32, 200_i32), string("..."))
            };
            let v55: string =
                Dice_ui::method0(append(append(append(append(append(append(append(append(string("state_core.use_request (19) / result move / database: "),
                                                                                         v47),
                                                                                  string(" / database_loading: ")),
                                                                           ofBoolean(v8)),
                                                                    string(" / state_data: ")),
                                                             v53),
                                                      string(" / state_data_loading: ")),
                                               ofBoolean(v14)), string("")));
            leptos::logging::log!("{}", v55);
            {
                let v57: Func0<
                    Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
                > = Dice_ui::method273(v2);
                let v59: Result<Option<crate::model::near::nearblocks::Root>, std::string::String> =
                    (move || v57())();
                let v60 = Dice_ui::method274();
                let v61: Result<Option<crate::model::near::nearblocks::Root>, std::string::String> =
                    Dice_ui::method291(v59);
                let v63: Result<
                    Option<
                        Array<(
                            Array<(std::string::String, Option<std::string::String>)>,
                            f64,
                            u32,
                            std::string::String,
                            std::string::String,
                            Array<std::string::String>,
                            bool,
                            f64,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                        )>,
                    >,
                    std::string::String,
                > = v61.map(|x| v60(x));
                let v64: string = sprintf!("{:?}", &v63);
                let v71: string = Dice_ui::method0(append(
                    append(
                        string("state_core.use_request (20) / result move / result: "),
                        (if length(v64.clone()) <= 200_i32 {
                            v64.clone()
                        } else {
                            append(substring2(v64, 0_i32, 200_i32), string("..."))
                        }),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v71);
                v63
            }
        }
        pub fn method269(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            v1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
            v2: Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Func0<
            Result<
                Option<
                    Array<(
                        Array<(std::string::String, Option<std::string::String>)>,
                        f64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    )>,
                >,
                std::string::String,
            >,
        > {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure150(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method293(
            v0_1: Func0<
                Result<
                    Option<
                        Array<(
                            Array<(std::string::String, Option<std::string::String>)>,
                            f64,
                            u32,
                            std::string::String,
                            std::string::String,
                            Array<std::string::String>,
                            bool,
                            f64,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                        )>,
                    >,
                    std::string::String,
                >,
            >,
        ) -> Func0<
            Result<
                Option<
                    Array<(
                        Array<(std::string::String, Option<std::string::String>)>,
                        f64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    )>,
                >,
                std::string::String,
            >,
        > {
            v0_1
        }
        pub fn closure156(
            unitVar: (),
            v0_1: Option<
                Array<(
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            >,
        ) -> Dice_ui::US36 {
            Dice_ui::US36::US36_1(v0_1)
        }
        pub fn closure157(unitVar: (), v0_1: std::string::String) -> Dice_ui::US36 {
            Dice_ui::US36::US36_0(v0_1)
        }
        pub fn closure158(
            unitVar: (),
            v0_1: Array<(
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Dice_ui::US39 {
            Dice_ui::US39::US39_1(v0_1)
        }
        pub fn method294(
            v0_1: Array<(
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn method295(
            v0_1: Vec<
                LrcPtr<(
                    usize,
                    (
                        Array<(std::string::String, Option<std::string::String>)>,
                        f64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )>,
        > {
            v0_1
        }
        pub fn closure159(
            unitVar: (),
            v0_: usize,
            v0__1: (
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        ) -> (
            usize,
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        ) {
            let v0_1: LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )> = LrcPtr::new((v0_, v0__1));
            let b: (
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ) = v0_1.1.clone();
            (
                v0_1.0.clone(),
                b.0.clone(),
                b.1.clone(),
                b.2.clone(),
                b.3.clone(),
                b.4.clone(),
                b.5.clone(),
                b.6.clone(),
                b.7.clone(),
                b.8.clone(),
                b.9.clone(),
                b.10.clone(),
                b.11.clone(),
            )
        }
        pub fn method296() -> Func1<
            LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )>,
            (
                usize,
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(
                move |tupledArg: LrcPtr<(
                    usize,
                    (
                        Array<(std::string::String, Option<std::string::String>)>,
                        f64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    ),
                )>| {
                    Dice_ui::closure159((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn method297(
            v0_1: Array<
                LrcPtr<(
                    usize,
                    (
                        Array<(std::string::String, Option<std::string::String>)>,
                        f64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    ),
                )>,
            >,
        ) -> Array<
            LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )>,
        > {
            v0_1
        }
        pub fn method298(
            v0_1: Vec<(
                usize,
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Vec<(
            usize,
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn closure160(
            unitVar: (),
            _arg: (
                usize,
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        ) -> (usize, LrcPtr<Dice_ui::Heap5>) {
            (
                _arg.0.clone(),
                LrcPtr::new(Dice_ui::Heap5 {
                    l0: _arg.1.clone(),
                    l1: _arg.2.clone(),
                    l2: _arg.3.clone(),
                    l3: _arg.4.clone(),
                    l4: _arg.5.clone(),
                    l5: _arg.6.clone(),
                    l6: _arg.7.clone(),
                    l7: _arg.8.clone(),
                    l8: _arg.9.clone(),
                    l9: _arg.10.clone(),
                    l10: _arg.11.clone(),
                    l11: _arg.12.clone(),
                }),
            )
        }
        pub fn method299() -> Func1<
            (
                usize,
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
            (usize, LrcPtr<Dice_ui::Heap5>),
        > {
            Func1::new(
                move |arg10_0040: (
                    usize,
                    Array<(std::string::String, Option<std::string::String>)>,
                    f64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )| Dice_ui::closure160((), arg10_0040),
            )
        }
        pub fn method300(
            v0_1: Array<(
                usize,
                Array<(std::string::String, Option<std::string::String>)>,
                f64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            usize,
            Array<(std::string::String, Option<std::string::String>)>,
            f64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn method301(
            v0_1: Vec<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure155(
            v0_1: Func0<
                Result<
                    Option<
                        Array<(
                            Array<(std::string::String, Option<std::string::String>)>,
                            f64,
                            u32,
                            std::string::String,
                            std::string::String,
                            Array<std::string::String>,
                            bool,
                            f64,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                        )>,
                    >,
                    std::string::String,
                >,
            >,
            unitVar: (),
        ) -> Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String> {
            let v1: Func0<
                Result<
                    Option<
                        Array<(
                            Array<(std::string::String, Option<std::string::String>)>,
                            f64,
                            u32,
                            std::string::String,
                            std::string::String,
                            Array<std::string::String>,
                            bool,
                            f64,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                        )>,
                    >,
                    std::string::String,
                >,
            > = Dice_ui::method293(v0_1);
            let v3: Result<
                Option<
                    Array<(
                        Array<(std::string::String, Option<std::string::String>)>,
                        f64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    )>,
                >,
                std::string::String,
            > = v1();
            let v6: Dice_ui::US36 = match &v3 {
                Err(v3_1_0) => Dice_ui::closure157((), v3_1_0.clone()),
                Ok(v3_0_0) => Dice_ui::closure156((), v3_0_0.clone()),
            };
            let v46: Dice_ui::US37 = match &v6 {
                Dice_ui::US36::US36_1(v6_1_0) => {
                    let v10: Dice_ui::US39 = defaultValue(
                        Dice_ui::US39::US39_0,
                        map(
                            Func1::new(
                                move |v_2: Array<(
                                    Array<(std::string::String, Option<std::string::String>)>,
                                    f64,
                                    u32,
                                    std::string::String,
                                    std::string::String,
                                    Array<std::string::String>,
                                    bool,
                                    f64,
                                    std::string::String,
                                    std::string::String,
                                    std::string::String,
                                    std::string::String,
                                )>| Dice_ui::closure158((), v_2),
                            ),
                            v6_1_0.clone(),
                        ),
                    );
                    Dice_ui::US37::US37_1(match &v10 {
                        Dice_ui::US39::US39_1(v10_1_0) => {
                            let v12: Array<(
                                Array<(std::string::String, Option<std::string::String>)>,
                                f64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = Dice_ui::method294(v10_1_0.clone());
                            let v14: Vec<(
                                Array<(std::string::String, Option<std::string::String>)>,
                                f64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = v12.to_vec();
                            let v17: Vec<
                                LrcPtr<(
                                    usize,
                                    (
                                        Array<(std::string::String, Option<std::string::String>)>,
                                        f64,
                                        u32,
                                        std::string::String,
                                        std::string::String,
                                        Array<std::string::String>,
                                        bool,
                                        f64,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                    ),
                                )>,
                            > = Dice_ui::method295(
                                v14.into_iter().enumerate().map(std::rc::Rc::new).collect(),
                            );
                            let v19: Array<
                                LrcPtr<(
                                    usize,
                                    (
                                        Array<(std::string::String, Option<std::string::String>)>,
                                        f64,
                                        u32,
                                        std::string::String,
                                        std::string::String,
                                        Array<std::string::String>,
                                        bool,
                                        f64,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                    ),
                                )>,
                            > = fable_library_rust::NativeArray_::array_from(v17);
                            let v20 = Dice_ui::method296();
                            let v21: Array<
                                LrcPtr<(
                                    usize,
                                    (
                                        Array<(std::string::String, Option<std::string::String>)>,
                                        f64,
                                        u32,
                                        std::string::String,
                                        std::string::String,
                                        Array<std::string::String>,
                                        bool,
                                        f64,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                    ),
                                )>,
                            > = Dice_ui::method297(v19);
                            let v23: Vec<
                                LrcPtr<(
                                    usize,
                                    (
                                        Array<(std::string::String, Option<std::string::String>)>,
                                        f64,
                                        u32,
                                        std::string::String,
                                        std::string::String,
                                        Array<std::string::String>,
                                        bool,
                                        f64,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                    ),
                                )>,
                            > = v21.to_vec();
                            let v26: Vec<(
                                usize,
                                Array<(std::string::String, Option<std::string::String>)>,
                                f64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = Dice_ui::method298(v23.iter().map(|x| v20(x.clone())).collect());
                            let v28: Array<(
                                usize,
                                Array<(std::string::String, Option<std::string::String>)>,
                                f64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = fable_library_rust::NativeArray_::array_from(v26);
                            let v29 = Dice_ui::method299();
                            let v30: Array<(
                                usize,
                                Array<(std::string::String, Option<std::string::String>)>,
                                f64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = Dice_ui::method300(v28);
                            let v32: Vec<(
                                usize,
                                Array<(std::string::String, Option<std::string::String>)>,
                                f64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = v30.to_vec();
                            let v35: Vec<(usize, LrcPtr<Dice_ui::Heap5>)> =
                                Dice_ui::method301(v32.iter().map(|x| v29(x.clone())).collect());
                            Dice_ui::US38::US38_1(fable_library_rust::NativeArray_::array_from(v35))
                        }
                        _ => Dice_ui::US38::US38_0,
                    })
                }
                Dice_ui::US36::US36_0(v6_0_0) => Dice_ui::US37::US37_0(v6_0_0.clone()),
            };
            let v49: string = Dice_ui::method0(append(
                append(
                    string("transactions.render () / txns move / result length: "),
                    toString(length(sprintf!("{:?}", &v46))),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v49);
            {
                let v61: Dice_ui::US40 = match &v46 {
                    Dice_ui::US37::US37_1(v46_1_0) => {
                        let v51: Dice_ui::US38 = v46_1_0.clone();
                        Dice_ui::US40::US40_1(match &v51 {
                            Dice_ui::US38::US38_1(v51_1_0) => Some(v51_1_0.clone()),
                            _ => None::<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                        })
                    }
                    Dice_ui::US37::US37_0(v46_0_0) => Dice_ui::US40::US40_0(v46_0_0.clone()),
                };
                match &v61 {
                    Dice_ui::US40::US40_1(v61_1_0) => Ok::<
                        Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                        std::string::String,
                    >(v61_1_0.clone()),
                    Dice_ui::US40::US40_0(v61_0_0) => Err::<
                        Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                        std::string::String,
                    >(v61_0_0.clone()),
                }
            }
        }
        pub fn method292(
            v0_1: Func0<
                Result<
                    Option<
                        Array<(
                            Array<(std::string::String, Option<std::string::String>)>,
                            f64,
                            u32,
                            std::string::String,
                            std::string::String,
                            Array<std::string::String>,
                            bool,
                            f64,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                            std::string::String,
                        )>,
                    >,
                    std::string::String,
                >,
            >,
        ) -> Func0<Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>>
        {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure155(v0_1.clone(), ())
            })
        }
        pub fn closure161(v0_1: leptos::WriteSignal<bool>, unitVar: ()) {
            let v1 = Dice_ui::method216();
            let v2: leptos::WriteSignal<bool> = Dice_ui::method80(v0_1);
            leptos::SignalUpdate::update(&v2, |x| *x = v1(x.clone()));
            ()
        }
        pub fn method302(v0_1: leptos::WriteSignal<bool>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure161(v0_1.clone(), ())
            })
        }
        pub fn closure162(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string =
                string("d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"");
            let v7: string = append(
                append(
                    append(string(" "), v2),
                    string(" stroke-linejoin=\"round\" stroke-linecap=\"round\""),
                ),
                string(""),
            );
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v15: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method147(
                leptos::view! { <path  d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z" stroke-linejoin="round" stroke-linecap="round">{v9()}</path> },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            let v24: string =
                string(" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v26 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v24), string(">{v26()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v31: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method147(
                leptos::view! { <path  d="M15 12a3 3 0 11-6 0 3 3 0 016 0z" stroke-linejoin="round" stroke-linecap="round">{v26()}</path> },
            );
            let v36: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v17,
                leptos::IntoView::into_view(v31),
            ])));
            let v38: Vec<leptos::View> = v36.to_vec();
            leptos::Fragment::new(v38)
        }
        pub fn method303() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure162((), ()))
        }
        pub fn closure163(v0_1: leptos::ReadSignal<bool>, unitVar: ()) -> &'static str {
            let v1: leptos::ReadSignal<bool> = Dice_ui::method72(v0_1);
            if leptos::SignalGet::get(&v1) {
                let v5: string = string("r#\"\"#");
                r#""#
            } else {
                let v8: string = string("r#\" bg-gray-100\"#");
                r#" bg-gray-100"#
            }
        }
        pub fn method304(v0_1: leptos::ReadSignal<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure163(v0_1.clone(), ())
            })
        }
        pub fn method305() -> string {
            string("Transactions")
        }
        pub fn method309() -> string {
            string("Settings")
        }
        pub fn closure166(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method309()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method308() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure166((), ()))
        }
        pub fn closure167(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method143(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method144(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method310(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure167(v0_1.clone(), ())
            })
        }
        pub fn closure169(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            v0_1()
        }
        pub fn method312(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure169(v0_1.clone(), ())
            })
        }
        pub fn closure170(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method313() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure170((), ()))
        }
        pub fn closure168(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"pr-[15px] [font-size:13px]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method312(v0_1)));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v4), string(">{v6()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                leptos::view! { <span  class="pr-[15px] [font-size:13px]">{v6()}</span> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"h-px flex-1 bg-gray-300\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method313()));
            let v21: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v17), string(">{v19()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                leptos::view! { <span  class="h-px flex-1 bg-gray-300">{v19()}</span> },
            );
            let v29: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v14,
                leptos::IntoView::into_view(v24),
            ])));
            let v31: Vec<leptos::View> = v29.to_vec();
            leptos::Fragment::new(v31)
        }
        pub fn method311(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure168(v0_1.clone(), ())
            })
        }
        pub fn method315() -> string {
            string("Table View")
        }
        pub fn closure171(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method315()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method314() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure171((), ()))
        }
        pub fn method317() -> string {
            string("table-view")
        }
        pub fn closure175(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
            LrcPtr::new(Dice_ui::Heap0 {
                l0: v0_1.l0.clone(),
                l1: if if let Dice_ui::US1::US1_1 = &v0_1.l1 {
                    true
                } else {
                    false
                } {
                    Dice_ui::US1::US1_0
                } else {
                    Dice_ui::US1::US1_1
                },
            })
        }
        pub fn method320() -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new(move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure175((), v))
        }
        pub fn closure174(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method320();
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method62(v5.l1.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method319(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure174(v0_1.clone(), v)
            })
        }
        pub fn closure176(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method75((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            if let Dice_ui::US1::US1_1 = &(leptos::SignalGet::get(&v6)).l1 {
                true
            } else {
                false
            }
        }
        pub fn method321(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure176(v0_1.clone(), ())
            })
        }
        pub fn closure173(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method319(v0_1.clone());
            let on_change = v2;
            {
                let v4 = Dice_ui::method321(v0_1);
                let get_value = v4;
                {
                    let v6: string =
                        string("class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\"");
                    let v19: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    string("<input "),
                                    append(
                                        append(
                                            string(" prop:checked=move || get_value()"),
                                            append(
                                                append(
                                                    string(
                                                        " on:change=move |event| on_change(event)",
                                                    ),
                                                    append(
                                                        append(
                                                            string(" id=v1"),
                                                            append(
                                                                append(
                                                                    string(" type=\"checkbox\""),
                                                                    append(
                                                                        append(
                                                                            append(string(" "), v6),
                                                                            string(""),
                                                                        ),
                                                                        string(""),
                                                                    ),
                                                                ),
                                                                string(""),
                                                            ),
                                                        ),
                                                        string(""),
                                                    ),
                                                ),
                                                string(""),
                                            ),
                                        ),
                                        string(""),
                                    ),
                                ),
                                string(" />"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method171(
                        leptos::view! { <input  prop:checked=move || get_value() on:change=move |event| on_change(event) id=v1 type="checkbox" class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" /> },
                    );
                    let v24: leptos::View = leptos::IntoView::into_view(v22);
                    let v25: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v27: string =
                        append(append(append(string(" "), v25), string("")), string(""));
                    let v29 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method172()));
                    let v32: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v27), string(">{v29()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v35: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">{v29()}</span> },
                    );
                    let v37: leptos::View = leptos::IntoView::into_view(v35);
                    let v38: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v40: string =
                        append(append(append(string(" "), v38), string("")), string(""));
                    let v42 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method179()));
                    let v44: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<span "), v40), string(">{v42()}</")),
                                    string("span"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v47: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                        leptos::view! { <span  class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">{v42()}</span> },
                    );
                    let v52: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            v24,
                            v37,
                            leptos::IntoView::into_view(v47),
                        ])));
                    let v54: Vec<leptos::View> = v52.to_vec();
                    leptos::Fragment::new(v54)
                }
            }
        }
        pub fn method318(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure173(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure172(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method317());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let id = v6.clone();
            {
                let v13: string =
                    string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=id");
                let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method318(v0_1, v6)));
                let v18: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<label "), v13), string(">{v15()}</")),
                                string("label"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v21: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method180(
                    leptos::view! { <label  class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]" for=id>{v15()}</label> },
                );
                let v26: Array<leptos::View> =
                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                        leptos::IntoView::into_view(v21),
                    ])));
                let v28: Vec<leptos::View> = v26.to_vec();
                leptos::Fragment::new(v28)
            }
        }
        pub fn method316(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure172(v0_1.clone(), ())
            })
        }
        pub fn closure165(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v6: string = string(" class=\"flex items-center pb-[6px]\"");
            let v8 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method311(
                Dice_ui::method310(Dice_ui::method308()),
            )));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v6), string(">{v8()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                leptos::view! { <span  class="flex items-center pb-[6px]">{v8()}</span> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v25: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v27 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method314(),
                Dice_ui::method316(v0_1),
            )));
            let v30: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v25), string(">{v27()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v33: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">{v27()}</dl> },
            );
            let v38: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v16,
                leptos::IntoView::into_view(v33),
            ])));
            let v40: Vec<leptos::View> = v38.to_vec();
            leptos::Fragment::new(v40)
        }
        pub fn method307(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure165(v0_1.clone(), ())
            })
        }
        pub fn method322(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> leptos::Memo<Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>>
        {
            v0_1
        }
        pub fn closure177(
            unitVar: (),
            v0_1: Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
        ) -> Dice_ui::US40 {
            Dice_ui::US40::US40_1(v0_1)
        }
        pub fn closure178(unitVar: (), v0_1: std::string::String) -> Dice_ui::US40 {
            Dice_ui::US40::US40_0(v0_1)
        }
        pub fn closure179(
            unitVar: (),
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Dice_ui::US38 {
            Dice_ui::US38::US38_1(v0_1)
        }
        pub fn closure182(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string = string(
                " d=\"M6 18L18 6M6 6l12 12\" stroke-linejoin=\"round\" stroke-linecap=\"round\"",
            );
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method145(new_array(
                &[
                    leptos::view! { <path  d="M6 18L18 6M6 6l12 12" stroke-linejoin="round" stroke-linecap="round">{v9()}</path> },
                ],
            ));
            let v17 = Dice_ui::method146();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method148(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method149(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method325() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure182((), ()))
        }
        pub fn closure181(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v15: string =
                string(" class=\"text-red-700\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" height=\"100%\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
            let v17 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method325()));
            let v20: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<svg "), v15), string(">{v17()}</")),
                            string("svg"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v23: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(
                leptos::view! { <svg  class="text-red-700" stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" height="100%" fill="none" xmlns="http://www.w3.org/2000/svg">{v17()}</svg> },
            );
            let v28: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method324() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure181((), ()))
        }
        pub fn closure183(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method326(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure183(v0_1.clone(), ())
            })
        }
        pub fn closure180(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[height:20px]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method324()));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v4), string(">{v6()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Span> =
                Dice_ui::method178(leptos::view! { <span  class="[height:20px]">{v6()}</span> });
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"[overflow-y:auto]\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method326(v0_1)));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v17), string(">{v19()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Pre> =
                Dice_ui::method244(leptos::view! { <pre  class="[overflow-y:auto]">{v19()}</pre> });
            let v30: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method323(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure180(v0_1.clone(), ())
            })
        }
        pub fn closure187(v0_1: i64, unitVar: ()) -> leptos::Fragment {
            let v4: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(append(
                append(string("Transaction "), toString(v0_1 + 1_i64)),
                string(""),
            ))));
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: leptos::leptos_dom::Text = leptos::html::text(v8);
            let v15: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v10),
            ])));
            let v17: Vec<leptos::View> = v15.to_vec();
            leptos::Fragment::new(v17)
        }
        pub fn method330(v0_1: i64) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure187(v0_1, ())
            })
        }
        pub fn method333() -> string {
            string("Block Timestamp")
        }
        pub fn closure189(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method333()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method332() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure189((), ()))
        }
        pub fn method335(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method336(v0_1: i64) -> i64 {
            v0_1
        }
        pub fn closure191(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> Dice_ui::US41 {
            Dice_ui::US41::US41_1(v0_1)
        }
        pub fn method337(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
            v0_1
        }
        pub fn method338(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn closure190(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method335(v3);
            let v15: i64 = Dice_ui::method336(v12.parse().unwrap());
            let v20: Dice_ui::US41 = defaultValue(
                Dice_ui::US41::US41_0,
                map(
                    Func1::new(move |v: chrono::DateTime<chrono::Utc>| Dice_ui::closure191((), v)),
                    chrono::DateTime::from_timestamp_micros(v15 / 1000i64),
                ),
            );
            let v39: Dice_ui::US25 = match &v20 {
                Dice_ui::US41::US41_1(v20_1_0) => {
                    let v22: chrono::DateTime<chrono::Utc> = Dice_ui::method337(v20_1_0.clone());
                    let v24: chrono::NaiveDateTime = v22.naive_utc();
                    let v26: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v24);
                    let v28: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v29: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v30: chrono::DateTime<chrono::Local> = Dice_ui::method338(v26);
                    let v33: std::string::String = Dice_ui::method52(v30.format(v29).to_string());
                    Dice_ui::US25::US25_1(fable_library_rust::String_::fromString(v33))
                }
                _ => Dice_ui::US25::US25_0,
            };
            let v45: Dice_ui::US42 = match &v39 {
                Dice_ui::US25::US25_1(v39_1_0) => Dice_ui::US42::US42_1(v39_1_0.clone()),
                _ => Dice_ui::US42::US42_0(string(
                    "resultm.from_option / Option does not have a value.",
                )),
            };
            let v53: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(match &v45 {
                Dice_ui::US42::US42_1(v45_1_0) => v45_1_0.clone(),
                Dice_ui::US42::US42_0(v45_0_0) => {
                    append(append(string("Error: "), v45_0_0.clone()), string(""))
                }
            })));
            let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
            let v57: std::string::String = String::from(v55);
            let v59: leptos::leptos_dom::Text = leptos::html::text(v57);
            let v64: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v59),
            ])));
            let v66: Vec<leptos::View> = v64.to_vec();
            leptos::Fragment::new(v66)
        }
        pub fn method334(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure190(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method340() -> string {
            string("Predecessor")
        }
        pub fn closure192(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method340()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method339() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure192((), ()))
        }
        pub fn closure193(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method52(v8);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method341(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure193(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method343() -> string {
            string("Receiver")
        }
        pub fn closure194(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method343()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method342() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure194((), ()))
        }
        pub fn closure195(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method52(v10);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method344(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure195(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method346() -> string {
            string("Actions")
        }
        pub fn closure196(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method346()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method345() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure196((), ()))
        }
        pub fn closure199(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                if string("FUNCTION_CALL") == v3.clone() {
                    string("Function Call:")
                } else {
                    if string("DEPLOY_CONTRACT") == v3.clone() {
                        string("Contract Deploy:")
                    } else {
                        if string("TRANSFER") == v3.clone() {
                            string("Transfer:")
                        } else {
                            v3
                        }
                    }
                },
            )));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method349(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure199(v0_1.clone(), ())
            })
        }
        pub fn method353() -> string {
            string("Method")
        }
        pub fn closure202(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method353()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method352() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure202((), ()))
        }
        pub fn method355() -> string {
            string("None")
        }
        pub fn closure203(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v3: Dice_ui::US14 = defaultValue(
                Dice_ui::US14::US14_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure30((), v)),
                    v0_1,
                ),
            );
            match &v3 {
                Dice_ui::US14::US14_1(v3_1_0) => {
                    let v5: std::string::String = Dice_ui::method52(v3_1_0.clone());
                    let v10: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                        fable_library_rust::String_::fromString(v5),
                    )));
                    let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
                    let v14: std::string::String = String::from(v12);
                    let v16: leptos::leptos_dom::Text = leptos::html::text(v14);
                    let v21: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            leptos::IntoView::into_view(v16),
                        ])));
                    let v23: Vec<leptos::View> = v21.to_vec();
                    leptos::Fragment::new(v23)
                }
                _ => {
                    let v28: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method355()));
                    let v30: &str = fable_library_rust::String_::LrcStr::as_str(&v28);
                    let v32: std::string::String = String::from(v30);
                    let v34: leptos::leptos_dom::Text = leptos::html::text(v32);
                    let v39: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            leptos::IntoView::into_view(v34),
                        ])));
                    let v41: Vec<leptos::View> = v39.to_vec();
                    leptos::Fragment::new(v41)
                }
            }
        }
        pub fn method354(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure203(v0_1.clone(), ())
            })
        }
        pub fn closure201(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  \"");
            let v10 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method352(),
                Dice_ui::method354(v0_1),
            )));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v8), string(">{v10()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  ">{v10()}</dl> },
            );
            let v21: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method351(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure201(v0_1.clone(), ())
            })
        }
        pub fn closure200(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method351(v0_1)));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v4), string(">{v6()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex flex-1 flex-col">{v6()}</div> },
            );
            let v17: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method350(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure200(v0_1.clone(), ())
            })
        }
        pub fn closure198(
            unitVar: (),
            _arg: (std::string::String, Option<std::string::String>),
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center \"");
            let v11 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method349(_arg.0.clone()),
                Dice_ui::method350(_arg.1.clone()),
            )));
            let v14: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v9), string(">{v11()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center ">{v11()}</dl> }
        }
        pub fn method348() -> Func1<
            (std::string::String, Option<std::string::String>),
            leptos::HtmlElement<leptos::html::Dl>,
        > {
            Func1::new(
                move |arg10_0040: (std::string::String, Option<std::string::String>)| {
                    Dice_ui::closure198((), arg10_0040)
                },
            )
        }
        pub fn method356(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
        ) -> Array<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method357(
            v0_1: Vec<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Vec<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn closure197(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12 = Dice_ui::method348();
            let v13: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method356(v0_1);
            let v15: Vec<(std::string::String, Option<std::string::String>)> = v13.to_vec();
            let v18: Vec<leptos::HtmlElement<leptos::html::Dl>> =
                Dice_ui::method357(v15.iter().map(|x| v12(x.clone())).collect());
            let v20: Array<leptos::HtmlElement<leptos::html::Dl>> =
                fable_library_rust::NativeArray_::array_from(v18);
            let v21 = Dice_ui::method230();
            let v22: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method232(v20);
            let v24: Vec<leptos::HtmlElement<leptos::html::Dl>> = v22.to_vec();
            let v27: Vec<leptos::View> =
                Dice_ui::method149(v24.iter().map(|x| v21(x.clone())).collect());
            let v30: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v27));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method347(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure197(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method359() -> string {
            string("Deposit")
        }
        pub fn closure204(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method359()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method358() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure204((), ()))
        }
        pub fn closure205(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(toString(v1))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method360(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure205(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method362() -> string {
            string("Outcome Status")
        }
        pub fn closure206(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method362()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method361() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure206((), ()))
        }
        pub fn closure207(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(ofBoolean(v6))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method363(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure207(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method365() -> string {
            string("Fee")
        }
        pub fn closure208(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method365()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method364() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure208((), ()))
        }
        pub fn closure209(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(toString(v7))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method366(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure209(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method368() -> string {
            string("Block Height")
        }
        pub fn closure210(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method368()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method367() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure210((), ()))
        }
        pub fn closure211(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(toString(v2))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method369(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure211(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method371() -> string {
            string("Hash")
        }
        pub fn closure212(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method371()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method370() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure212((), ()))
        }
        pub fn closure213(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method52(v11);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method372(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure213(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method374() -> string {
            string("Block Hash")
        }
        pub fn closure214(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method374()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method373() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure214((), ()))
        }
        pub fn closure215(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method52(v4);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method375(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure215(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method377() -> string {
            string("Receipt ID")
        }
        pub fn closure216(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method377()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method376() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure216((), ()))
        }
        pub fn closure217(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method52(v9);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method378(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure217(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method380() -> string {
            string("Logs")
        }
        pub fn closure218(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method380()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method379() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure218((), ()))
        }
        pub fn closure220(unitVar: (), v0_1: std::string::String) -> string {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            fable_library_rust::String_::fromString(v1)
        }
        pub fn method382() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Dice_ui::closure220((), v))
        }
        pub fn method383(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn method384(v0_1: Vec<string>) -> Vec<string> {
            v0_1
        }
        pub fn closure219(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12 = Dice_ui::method382();
            let v13: Array<std::string::String> = Dice_ui::method383(v5);
            let v15: Vec<std::string::String> = v13.to_vec();
            let v18: Vec<string> = Dice_ui::method384(v15.iter().map(|x| v12(x.clone())).collect());
            let v29: string =
                string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh]\"");
            let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method243(replace(
                join(
                    string("\n"),
                    toArray(ofArray(fable_library_rust::NativeArray_::array_from(v18))),
                ),
                string("\\n"),
                string("\n"),
            ))));
            let v34: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v29), string(">{v31()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v37: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method244(
                leptos::view! { <pre  class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh]">{v31()}</pre> },
            );
            let v42: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v37),
            ])));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method381(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure219(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure188(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v20: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v22 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method332(),
                Dice_ui::method334(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v25: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v20), string(">{v22()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v28: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v22()}</dl> },
            );
            let v30: leptos::View = leptos::IntoView::into_view(v28);
            let v36: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v38 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method339(),
                Dice_ui::method341(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v40: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v36), string(">{v38()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v43: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v38()}</dl> },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v51: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v53 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method342(),
                Dice_ui::method344(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v55: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v51), string(">{v53()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v58: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v53()}</dl> },
            );
            let v60: leptos::View = leptos::IntoView::into_view(v58);
            let v67: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]\"");
            let v69 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method345(),
                Dice_ui::method347(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v71: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v67), string(">{v69()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v74: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]">{v69()}</dl> },
            );
            let v76: leptos::View = leptos::IntoView::into_view(v74);
            let v82: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v84 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method358(),
                Dice_ui::method360(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v86: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v82), string(">{v84()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v89: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v84()}</dl> },
            );
            let v91: leptos::View = leptos::IntoView::into_view(v89);
            let v97: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v99 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method361(),
                Dice_ui::method363(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v101: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v97), string(">{v99()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v104: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v99()}</dl> },
            );
            let v106: leptos::View = leptos::IntoView::into_view(v104);
            let v112: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v114 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method364(),
                Dice_ui::method366(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v116: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v112), string(">{v114()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v119: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v114()}</dl> },
            );
            let v121: leptos::View = leptos::IntoView::into_view(v119);
            let v127: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v129 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method367(),
                Dice_ui::method369(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v131: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v127), string(">{v129()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v134: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v129()}</dl> },
            );
            let v136: leptos::View = leptos::IntoView::into_view(v134);
            let v142: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v144 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method370(),
                Dice_ui::method372(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v146: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v142), string(">{v144()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v149: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v144()}</dl> },
            );
            let v151: leptos::View = leptos::IntoView::into_view(v149);
            let v157: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v159 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method373(),
                Dice_ui::method375(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v161: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v157), string(">{v159()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v164: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v159()}</dl> },
            );
            let v166: leptos::View = leptos::IntoView::into_view(v164);
            let v172: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v174 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method376(),
                Dice_ui::method378(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v176: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v172), string(">{v174()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v179: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v174()}</dl> },
            );
            let v208: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v30,
                v45,
                v60,
                v76,
                v91,
                v106,
                v121,
                v136,
                v151,
                v166,
                leptos::IntoView::into_view(v179),
                if count(v5.clone()) as u64 == 0_u64 {
                    let v187: Array<leptos::View> =
                        Dice_ui::method156(Dice_ui::method155(Dice_ui::method111(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v187.to_vec())
                } else {
                    let v195:
                                                                              string =
                                                                          string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
                    let v197 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                        Dice_ui::method379(),
                        Dice_ui::method381(v0_1, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11),
                    )));
                    let v199: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<dl "), v195), string(">{v197()}</")),
                                    string("dl"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v202: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method231(
                        leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v197()}</dl> },
                    );
                    leptos::IntoView::into_view(v202)
                },
            ])));
            let v210: Vec<leptos::View> = v208.to_vec();
            leptos::Fragment::new(v210)
        }
        pub fn method331(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
            v1: f64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure188(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure186(
            v0_1: i64,
            v1: Array<(std::string::String, Option<std::string::String>)>,
            v2: f64,
            v3: u32,
            v4: std::string::String,
            v5: std::string::String,
            v6: Array<std::string::String>,
            v7: bool,
            v8: f64,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            v12: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v18: string = string(" class=\"flex items-center pb-[6px]\"");
            let v20 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method311(
                Dice_ui::method310(Dice_ui::method330(v0_1)),
            )));
            let v23: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v18), string(">{v20()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v26: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method178(
                leptos::view! { <span  class="flex items-center pb-[6px]">{v20()}</span> },
            );
            let v28: leptos::View = leptos::IntoView::into_view(v26);
            let v31: string = string(" class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\"");
            let v33 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method331(
                v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12,
            )));
            let v36: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v31), string(">{v33()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v39: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="grid flex-1 divide-y-[1px] divide-gray-500/[.10]">{v33()}</div> },
            );
            let v44: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v28,
                leptos::IntoView::into_view(v39),
            ])));
            let v46: Vec<leptos::View> = v44.to_vec();
            leptos::Fragment::new(v46)
        }
        pub fn method329(
            v0_1: i64,
            v1: Array<(std::string::String, Option<std::string::String>)>,
            v2: f64,
            v3: u32,
            v4: std::string::String,
            v5: std::string::String,
            v6: Array<std::string::String>,
            v7: bool,
            v8: f64,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            v12: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v12 = v12.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure186(
                        v0_1,
                        v1.clone(),
                        v2,
                        v3,
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        v7,
                        v8,
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        v12.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure185(unitVar: (), _arg: (usize, LrcPtr<Dice_ui::Heap5>)) -> leptos::View {
            let v1: LrcPtr<Dice_ui::Heap5> = _arg.1.clone();
            let v14: i64 = _arg.0.clone() as i64;
            let v16: Option<LrcPtr<Dice_ui::Heap2>> = leptos::use_context::<std::rc::Rc<Heap2>>();
            let v18: LrcPtr<Dice_ui::Heap2> = v16.unwrap();
            let v22: string = string(" class=\"flex flex-1 flex-col overflow-x-auto\"");
            let v24 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method329(
                v14,
                v1.l0.clone(),
                v1.l1,
                v1.l2,
                v1.l3.clone(),
                v1.l4.clone(),
                v1.l5.clone(),
                v1.l6,
                v1.l7,
                v1.l8.clone(),
                v1.l9.clone(),
                v1.l10.clone(),
                v1.l11.clone(),
            )));
            let v27: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v22), string(">{v24()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v30: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex flex-1 flex-col overflow-x-auto">{v24()}</div> },
            );
            leptos::IntoView::into_view(v30)
        }
        pub fn method328() -> Func1<(usize, LrcPtr<Dice_ui::Heap5>), leptos::View> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure185((), arg10_0040)
            })
        }
        pub fn method385(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Array<(usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure184(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method328();
            let v2: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method385(v0_1);
            let v4: Vec<(usize, LrcPtr<Dice_ui::Heap5>)> = v2.to_vec();
            let v7: Vec<leptos::View> =
                Dice_ui::method149(v4.iter().map(|x| v1(x.clone())).collect());
            let v10: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v7));
            let v12: Vec<leptos::View> = v10.to_vec();
            leptos::Fragment::new(v12)
        }
        pub fn method327(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure184(v0_1.clone(), ())
            })
        }
        pub fn closure224(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method333()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method389() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure224((), ()))
        }
        pub fn method390(
            v0_1: leptos::HtmlElement<leptos::html::Th>,
        ) -> leptos::HtmlElement<leptos::html::Th> {
            v0_1
        }
        pub fn closure225(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method340()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method391() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure225((), ()))
        }
        pub fn closure226(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method343()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method392() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure226((), ()))
        }
        pub fn method394() -> string {
            string("Action")
        }
        pub fn closure227(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method394()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method393() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure227((), ()))
        }
        pub fn method396() -> string {
            string("Action Method")
        }
        pub fn closure228(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method396()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method395() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure228((), ()))
        }
        pub fn closure229(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method359()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method397() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure229((), ()))
        }
        pub fn closure230(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method365()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method398() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure230((), ()))
        }
        pub fn closure231(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method368()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method399() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure231((), ()))
        }
        pub fn method402(v0_1: Array<std::string::String>, v1: i32) -> bool {
            let v0_1: MutCell<Array<std::string::String>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method402: loop {
                break '_method402 (if v1.get().clone() < count(v0_1.get().clone()) {
                    let v5: std::string::String = Dice_ui::method52(v0_1[v1.get().clone()].clone());
                    if length(fable_library_rust::String_::fromString(v5)) > 0_i32 {
                        true
                    } else {
                        let v0_1_temp: Array<std::string::String> = v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method402;
                    }
                } else {
                    false
                });
            }
        }
        pub fn method401(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>, v1: i32) -> bool {
            let v0_1: MutCell<Array<(usize, LrcPtr<Dice_ui::Heap5>)>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method401: loop {
                break '_method401 (if v1.get().clone() < count(v0_1.get().clone()) {
                    if Dice_ui::method402(
                        ((v0_1[v1.get().clone()].clone()).1.clone()).l5.clone(),
                        0_i32,
                    ) {
                        true
                    } else {
                        let v0_1_temp: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method401;
                    }
                } else {
                    false
                });
            }
        }
        pub fn closure232(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v9: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                if false == Dice_ui::method401(v0_1, 0_i32) {
                    string("")
                } else {
                    string("Logs")
                },
            )));
            let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
            let v13: std::string::String = String::from(v11);
            let v15: leptos::leptos_dom::Text = leptos::html::text(v13);
            let v20: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v15),
            ])));
            let v22: Vec<leptos::View> = v20.to_vec();
            leptos::Fragment::new(v22)
        }
        pub fn method400(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure232(v0_1.clone(), ())
            })
        }
        pub fn closure233(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method362()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method403() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure233((), ()))
        }
        pub fn closure234(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method371()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method404() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure234((), ()))
        }
        pub fn closure235(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method374()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method405() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure235((), ()))
        }
        pub fn closure236(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method377()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method406() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure236((), ()))
        }
        pub fn closure223(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method389()));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v4), string(">{v6()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v6()}</th> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method391()));
            let v21: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v17), string(">{v19()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v19()}</th> },
            );
            let v26: leptos::View = leptos::IntoView::into_view(v24);
            let v29: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method392()));
            let v33: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v29), string(">{v31()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v36: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v31()}</th> },
            );
            let v38: leptos::View = leptos::IntoView::into_view(v36);
            let v41: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v43 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method393()));
            let v45: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v41), string(">{v43()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v48: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v43()}</th> },
            );
            let v50: leptos::View = leptos::IntoView::into_view(v48);
            let v53: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v55 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method395()));
            let v57: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v53), string(">{v55()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v60: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v55()}</th> },
            );
            let v62: leptos::View = leptos::IntoView::into_view(v60);
            let v65: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v67 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method397()));
            let v69: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v65), string(">{v67()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v72: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v67()}</th> },
            );
            let v74: leptos::View = leptos::IntoView::into_view(v72);
            let v77: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v79 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method398()));
            let v81: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v77), string(">{v79()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v84: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v79()}</th> },
            );
            let v86: leptos::View = leptos::IntoView::into_view(v84);
            let v89: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v91 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method399()));
            let v93: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v89), string(">{v91()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v96: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v91()}</th> },
            );
            let v98: leptos::View = leptos::IntoView::into_view(v96);
            let v101: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v103 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method400(v0_1)));
            let v105: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v101), string(">{v103()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v108: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v103()}</th> },
            );
            let v110: leptos::View = leptos::IntoView::into_view(v108);
            let v113: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v115 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method403()));
            let v117: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v113), string(">{v115()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v120: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v115()}</th> },
            );
            let v122: leptos::View = leptos::IntoView::into_view(v120);
            let v125: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v127 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method404()));
            let v129: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v125), string(">{v127()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v132: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v127()}</th> },
            );
            let v134: leptos::View = leptos::IntoView::into_view(v132);
            let v137: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v139 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method405()));
            let v141: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v137), string(">{v139()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v144: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v139()}</th> },
            );
            let v146: leptos::View = leptos::IntoView::into_view(v144);
            let v149: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v151 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method406()));
            let v153: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v149), string(">{v151()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v156: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method390(
                leptos::view! { <th  class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">{v151()}</th> },
            );
            let v161: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v14,
                v26,
                v38,
                v50,
                v62,
                v74,
                v86,
                v98,
                v110,
                v122,
                v134,
                v146,
                leptos::IntoView::into_view(v156),
            ])));
            let v163: Vec<leptos::View> = v161.to_vec();
            leptos::Fragment::new(v163)
        }
        pub fn method388(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure223(v0_1.clone(), ())
            })
        }
        pub fn method407(
            v0_1: Array<leptos::HtmlElement<leptos::html::Tr>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Tr>> {
            v0_1
        }
        pub fn method409(
            v0_1: leptos::HtmlElement<leptos::html::Tr>,
        ) -> leptos::HtmlElement<leptos::html::Tr> {
            v0_1
        }
        pub fn closure237(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Tr>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Tr> = Dice_ui::method409(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method408() -> Func1<leptos::HtmlElement<leptos::html::Tr>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Tr>| Dice_ui::closure237((), v))
        }
        pub fn method410(
            v0_1: Array<leptos::HtmlElement<leptos::html::Tr>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Tr>> {
            v0_1
        }
        pub fn closure222(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v3 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method388(v0_1)));
            let v7: string = string("leptos::view! { <tr >{v3()}</tr> }");
            let v11: Array<leptos::HtmlElement<leptos::html::Tr>> =
                Dice_ui::method407(new_array(&[leptos::view! { <tr >{v3()}</tr> }]));
            let v12 = Dice_ui::method408();
            let v13: Array<leptos::HtmlElement<leptos::html::Tr>> = Dice_ui::method410(v11);
            let v15: Vec<leptos::HtmlElement<leptos::html::Tr>> = v13.to_vec();
            let v18: Vec<leptos::View> =
                Dice_ui::method149(v15.iter().map(|x| v12(x.clone())).collect());
            let v21: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v18));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method387(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure222(v0_1.clone(), ())
            })
        }
        pub fn method411(
            v0_1: leptos::HtmlElement<leptos::html::Thead>,
        ) -> leptos::HtmlElement<leptos::html::Thead> {
            v0_1
        }
        pub fn closure241(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method335(v0_1.l3.clone());
            let v5: i64 = Dice_ui::method336(v2.parse().unwrap());
            let v10: Dice_ui::US41 = defaultValue(
                Dice_ui::US41::US41_0,
                map(
                    Func1::new(move |v: chrono::DateTime<chrono::Utc>| Dice_ui::closure191((), v)),
                    chrono::DateTime::from_timestamp_micros(v5 / 1000i64),
                ),
            );
            let v29: Dice_ui::US25 = match &v10 {
                Dice_ui::US41::US41_1(v10_1_0) => {
                    let v12: chrono::DateTime<chrono::Utc> = Dice_ui::method337(v10_1_0.clone());
                    let v14: chrono::NaiveDateTime = v12.naive_utc();
                    let v16: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v14);
                    let v18: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v19: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v20: chrono::DateTime<chrono::Local> = Dice_ui::method338(v16);
                    let v23: std::string::String = Dice_ui::method52(v20.format(v19).to_string());
                    Dice_ui::US25::US25_1(fable_library_rust::String_::fromString(v23))
                }
                _ => Dice_ui::US25::US25_0,
            };
            let v35: Dice_ui::US42 = match &v29 {
                Dice_ui::US25::US25_1(v29_1_0) => Dice_ui::US42::US42_1(v29_1_0.clone()),
                _ => Dice_ui::US42::US42_0(string(
                    "resultm.from_option / Option does not have a value.",
                )),
            };
            let v43: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(match &v35 {
                Dice_ui::US42::US42_1(v35_1_0) => v35_1_0.clone(),
                Dice_ui::US42::US42_0(v35_0_0) => {
                    append(append(string("Error: "), v35_0_0.clone()), string(""))
                }
            })));
            let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
            let v47: std::string::String = String::from(v45);
            let v49: leptos::leptos_dom::Text = leptos::html::text(v47);
            let v54: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v49),
            ])));
            let v56: Vec<leptos::View> = v54.to_vec();
            leptos::Fragment::new(v56)
        }
        pub fn method415(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure241(v0_1.clone(), ())
            })
        }
        pub fn method416(
            v0_1: leptos::HtmlElement<leptos::html::Td>,
        ) -> leptos::HtmlElement<leptos::html::Td> {
            v0_1
        }
        pub fn closure242(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l8.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method417(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure242(v0_1.clone(), ())
            })
        }
        pub fn closure243(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l10.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method418(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure243(v0_1.clone(), ())
            })
        }
        pub fn closure245(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                if string("FUNCTION_CALL") == v3.clone() {
                    string("Function Call")
                } else {
                    if string("DEPLOY_CONTRACT") == v3.clone() {
                        string("Contract Deploy")
                    } else {
                        if string("TRANSFER") == v3.clone() {
                            string("Transfer")
                        } else {
                            v3
                        }
                    }
                },
            )));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method420(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure245(v0_1.clone(), ())
            })
        }
        pub fn closure246(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v3: Dice_ui::US14 = defaultValue(
                Dice_ui::US14::US14_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure30((), v)),
                    v0_1,
                ),
            );
            let v11: Dice_ui::US25 = match &v3 {
                Dice_ui::US14::US14_1(v3_1_0) => {
                    let v5: std::string::String = Dice_ui::method52(v3_1_0.clone());
                    Dice_ui::US25::US25_1(fable_library_rust::String_::fromString(v5))
                }
                _ => Dice_ui::US25::US25_0,
            };
            let v18: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(match &v11 {
                Dice_ui::US25::US25_1(v11_1_0) => v11_1_0.clone(),
                _ => string("None"),
            })));
            let v20: &str = fable_library_rust::String_::LrcStr::as_str(&v18);
            let v22: std::string::String = String::from(v20);
            let v24: leptos::leptos_dom::Text = leptos::html::text(v22);
            let v29: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v24),
            ])));
            let v31: Vec<leptos::View> = v29.to_vec();
            leptos::Fragment::new(v31)
        }
        pub fn method421(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure246(v0_1.clone(), ())
            })
        }
        pub fn closure244(
            unitVar: (),
            _arg: (std::string::String, Option<std::string::String>),
        ) -> leptos::Fragment {
            let v5: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method420(_arg.0.clone())));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v5), string(">{v7()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v7()}</td> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v20 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method421(_arg.1.clone())));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v18), string(">{v20()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v20()}</td> },
            );
            let v30: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v15,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method419(
        ) -> Func1<(std::string::String, Option<std::string::String>), leptos::Fragment> {
            Func1::new(
                move |arg10_0040: (std::string::String, Option<std::string::String>)| {
                    Dice_ui::closure244((), arg10_0040)
                },
            )
        }
        pub fn method422(v0_1: Vec<leptos::Fragment>) -> Vec<leptos::Fragment> {
            v0_1
        }
        pub fn method424(v0_1: leptos::Fragment) -> leptos::Fragment {
            v0_1
        }
        pub fn closure247(unitVar: (), v0_1: leptos::Fragment) -> leptos::View {
            let v1: leptos::Fragment = Dice_ui::method424(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method423() -> Func1<leptos::Fragment, leptos::View> {
            Func1::new(move |v: leptos::Fragment| Dice_ui::closure247((), v))
        }
        pub fn method425(v0_1: Array<leptos::Fragment>) -> Array<leptos::Fragment> {
            v0_1
        }
        pub fn closure248(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(toString(v0_1.l1))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method426(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure248(v0_1.clone(), ())
            })
        }
        pub fn closure249(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(toString(v0_1.l7))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method427(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure249(v0_1.clone(), ())
            })
        }
        pub fn closure250(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(toString(v0_1.l2))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method428(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure250(v0_1.clone(), ())
            })
        }
        pub fn method430() -> string {
            string("")
        }
        pub fn closure251(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v1: Array<std::string::String> = v0_1.l5.clone();
            if count(v1.clone()) as u64 == 0_u64 {
                let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method430()));
                let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
                let v10: std::string::String = String::from(v8);
                let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
                let v17: Array<leptos::View> =
                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                        leptos::IntoView::into_view(v12),
                    ])));
                let v19: Vec<leptos::View> = v17.to_vec();
                leptos::Fragment::new(v19)
            } else {
                let v22 = Dice_ui::method382();
                let v23: Array<std::string::String> = Dice_ui::method383(v1);
                let v25: Vec<std::string::String> = v23.to_vec();
                let v28: Vec<string> =
                    Dice_ui::method384(v25.iter().map(|x| v22(x.clone())).collect());
                let v39: string =
                    string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh] [width:100vw] [max-width:100vw]\"");
                let v41 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method243(replace(
                    join(
                        string("\n"),
                        toArray(ofArray(fable_library_rust::NativeArray_::array_from(v28))),
                    ),
                    string("\\n"),
                    string("\n"),
                ))));
                let v44: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<pre "), v39), string(">{v41()}</")),
                                string("pre"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v47: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method244(
                    leptos::view! { <pre  class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh] [width:100vw] [max-width:100vw]">{v41()}</pre> },
                );
                let v52: Array<leptos::View> =
                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                        leptos::IntoView::into_view(v47),
                    ])));
                let v54: Vec<leptos::View> = v52.to_vec();
                leptos::Fragment::new(v54)
            }
        }
        pub fn method429(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure251(v0_1.clone(), ())
            })
        }
        pub fn closure252(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(ofBoolean(v0_1.l6))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method431(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure252(v0_1.clone(), ())
            })
        }
        pub fn closure253(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l11.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method432(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure253(v0_1.clone(), ())
            })
        }
        pub fn closure254(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l4.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method433(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure254(v0_1.clone(), ())
            })
        }
        pub fn closure255(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l9.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method434(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure255(v0_1.clone(), ())
            })
        }
        pub fn closure240(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v4: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method415(v0_1.clone())));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v4), string(">{v6()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v6()}</td> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method417(v0_1.clone())));
            let v21: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v17), string(">{v19()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v19()}</td> },
            );
            let v26: leptos::View = leptos::IntoView::into_view(v24);
            let v29: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method418(v0_1.clone())));
            let v33: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v29), string(">{v31()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v36: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v31()}</td> },
            );
            let v38: leptos::View = leptos::IntoView::into_view(v36);
            let v40 = Dice_ui::method419();
            let v41: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method356(v0_1.l0.clone());
            let v43: Vec<(std::string::String, Option<std::string::String>)> = v41.to_vec();
            let v46: Vec<leptos::Fragment> =
                Dice_ui::method422(v43.iter().map(|x| v40(x.clone())).collect());
            let v48: Array<leptos::Fragment> = fable_library_rust::NativeArray_::array_from(v46);
            let v49 = Dice_ui::method423();
            let v50: Array<leptos::Fragment> = Dice_ui::method425(v48);
            let v52: Vec<leptos::Fragment> = v50.to_vec();
            let v55: Vec<leptos::View> =
                Dice_ui::method149(v52.iter().map(|x| v49(x.clone())).collect());
            let v58: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v55));
            let v60: Vec<leptos::View> = v58.to_vec();
            let v63: leptos::Fragment = Dice_ui::method424(leptos::Fragment::new(v60));
            let v65: leptos::View = leptos::IntoView::into_view(v63);
            let v68: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v70 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method426(v0_1.clone())));
            let v72: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v68), string(">{v70()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v75: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v70()}</td> },
            );
            let v77: leptos::View = leptos::IntoView::into_view(v75);
            let v80: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v82 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method427(v0_1.clone())));
            let v84: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v80), string(">{v82()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v87: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v82()}</td> },
            );
            let v89: leptos::View = leptos::IntoView::into_view(v87);
            let v92: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v94 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method428(v0_1.clone())));
            let v96: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v92), string(">{v94()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v99: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v94()}</td> },
            );
            let v101: leptos::View = leptos::IntoView::into_view(v99);
            let v104: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]\"");
            let v106 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method429(v0_1.clone())));
            let v108: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v104), string(">{v106()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v111: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]">{v106()}</td> },
            );
            let v113: leptos::View = leptos::IntoView::into_view(v111);
            let v116: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v118 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method431(v0_1.clone())));
            let v120: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v116), string(">{v118()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v123: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v118()}</td> },
            );
            let v125: leptos::View = leptos::IntoView::into_view(v123);
            let v128: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v130 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method432(v0_1.clone())));
            let v132: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v128), string(">{v130()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v135: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v130()}</td> },
            );
            let v137: leptos::View = leptos::IntoView::into_view(v135);
            let v140: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v142 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method433(v0_1.clone())));
            let v144: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v140), string(">{v142()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v147: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v142()}</td> },
            );
            let v149: leptos::View = leptos::IntoView::into_view(v147);
            let v152: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v154 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method434(v0_1)));
            let v156: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v152), string(">{v154()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v159: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method416(
                leptos::view! { <td  class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">{v154()}</td> },
            );
            let v164: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v14,
                v26,
                v38,
                v65,
                v77,
                v89,
                v101,
                v113,
                v125,
                v137,
                v149,
                leptos::IntoView::into_view(v159),
            ])));
            let v166: Vec<leptos::View> = v164.to_vec();
            leptos::Fragment::new(v166)
        }
        pub fn method414(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure240(v0_1.clone(), ())
            })
        }
        pub fn closure239(unitVar: (), _arg: (usize, LrcPtr<Dice_ui::Heap5>)) -> leptos::View {
            let v5: string = string(" class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method414(_arg.1.clone())));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<tr "), v5), string(">{v7()}</")),
                            string("tr"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Tr> = Dice_ui::method409(
                leptos::view! { <tr  class="odd:bg-gray-50 dark:odd:bg-gray-800/50">{v7()}</tr> },
            );
            leptos::IntoView::into_view(v13)
        }
        pub fn method413() -> Func1<(usize, LrcPtr<Dice_ui::Heap5>), leptos::View> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure239((), arg10_0040)
            })
        }
        pub fn closure238(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method413();
            let v2: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method385(v0_1);
            let v4: Vec<(usize, LrcPtr<Dice_ui::Heap5>)> = v2.to_vec();
            let v7: Vec<leptos::View> =
                Dice_ui::method149(v4.iter().map(|x| v1(x.clone())).collect());
            let v10: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v7));
            let v12: Vec<leptos::View> = v10.to_vec();
            leptos::Fragment::new(v12)
        }
        pub fn method412(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure238(v0_1.clone(), ())
            })
        }
        pub fn method435(
            v0_1: leptos::HtmlElement<leptos::html::Tbody>,
        ) -> leptos::HtmlElement<leptos::html::Tbody> {
            v0_1
        }
        pub fn closure221(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"ltr:text-left rtl:text-right\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method387(v0_1.clone())));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<thead "), v4), string(">{v6()}</")),
                            string("thead"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Thead> = Dice_ui::method411(
                leptos::view! { <thead  class="ltr:text-left rtl:text-right">{v6()}</thead> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"divide-y divide-gray-200 dark:divide-gray-700\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method412(v0_1)));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<tbody "), v17), string(">{v19()}</")),
                            string("tbody"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Tbody> = Dice_ui::method435(
                leptos::view! { <tbody  class="divide-y divide-gray-200 dark:divide-gray-700">{v19()}</tbody> },
            );
            let v30: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method386(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure221(v0_1.clone(), ())
            })
        }
        pub fn method436(
            v0_1: leptos::HtmlElement<leptos::html::Table>,
        ) -> leptos::HtmlElement<leptos::html::Table> {
            v0_1
        }
        pub fn closure260(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method441() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure260((), ()))
        }
        pub fn method442(
            v0_1: leptos::HtmlElement<leptos::svg::Animate>,
        ) -> leptos::HtmlElement<leptos::svg::Animate> {
            v0_1
        }
        pub fn closure259(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0s\" values=\"0.2; 1; .2\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v18: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v13), string(">{v15()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v21: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0s" values="0.2; 1; .2" attributeType="XML" attributeName="opacity">{v15()}</animate> },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            let v36: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0s\" values=\"10; 20; 10\" attributeType=\"XML\" attributeName=\"height\"");
            let v38 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v40: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v36), string(">{v38()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v43: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0s" values="10; 20; 10" attributeType="XML" attributeName="height">{v38()}</animate> },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v58: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0s\" values=\"10; 5; 10\" attributeType=\"XML\" attributeName=\"y\"");
            let v60 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v62: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v58), string(">{v60()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v65: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0s" values="10; 5; 10" attributeType="XML" attributeName="y">{v60()}</animate> },
            );
            let v70: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v23,
                v45,
                leptos::IntoView::into_view(v65),
            ])));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method440() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure259((), ()))
        }
        pub fn closure261(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.15s\" values=\"0.2; 1; .2\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v18: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v13), string(">{v15()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v21: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0.15s" values="0.2; 1; .2" attributeType="XML" attributeName="opacity">{v15()}</animate> },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            let v36: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.15s\" values=\"10; 20; 10\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v38 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v40: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v36), string(">{v38()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v43: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0.15s" values="10; 20; 10" attributeType="XML" attributeName="opacity">{v38()}</animate> },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v58: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.15s\" values=\"10; 5; 10\" attributeType=\"XML\" attributeName=\"y\"");
            let v60 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v62: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v58), string(">{v60()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v65: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0.15s" values="10; 5; 10" attributeType="XML" attributeName="y">{v60()}</animate> },
            );
            let v70: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v23,
                v45,
                leptos::IntoView::into_view(v65),
            ])));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method443() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure261((), ()))
        }
        pub fn closure262(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.3s\" values=\"0.2; 1; .2\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v18: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v13), string(">{v15()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v21: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0.3s" values="0.2; 1; .2" attributeType="XML" attributeName="opacity">{v15()}</animate> },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            let v36: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.3s\" values=\"10; 20; 10\" attributeType=\"XML\" attributeName=\"height\"");
            let v38 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v40: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v36), string(">{v38()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v43: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0.3s" values="10; 20; 10" attributeType="XML" attributeName="height">{v38()}</animate> },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v58: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.3s\" values=\"10; 5; 10\" attributeType=\"XML\" attributeName=\"y\"");
            let v60 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441()));
            let v62: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<animate "), v58), string(">{v60()}</")),
                            string("animate"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v65: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method442(
                leptos::view! { <animate  repeatCount="indefinite" dur="0.6s" begin="0.3s" values="10; 5; 10" attributeType="XML" attributeName="y">{v60()}</animate> },
            );
            let v70: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v23,
                v45,
                leptos::IntoView::into_view(v65),
            ])));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method444() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure262((), ()))
        }
        pub fn method445(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Rect>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Rect>> {
            v0_1
        }
        pub fn method447(
            v0_1: leptos::HtmlElement<leptos::svg::Rect>,
        ) -> leptos::HtmlElement<leptos::svg::Rect> {
            v0_1
        }
        pub fn closure263(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::svg::Rect>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::svg::Rect> = Dice_ui::method447(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method446() -> Func1<leptos::HtmlElement<leptos::svg::Rect>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::svg::Rect>| Dice_ui::closure263((), v))
        }
        pub fn method448(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Rect>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Rect>> {
            v0_1
        }
        pub fn closure258(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" opacity=\"0.2\" fill=\"#333\" height=\"10\" width=\"4\" y=\"10\" x=\"0\"");
            let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method440()));
            let v18: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<rect "), v13), string(">{v15()}</")),
                            string("rect"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v20: leptos::HtmlElement<leptos::svg::Rect> = leptos::view! { <rect  opacity="0.2" fill="#333" height="10" width="4" y="10" x="0">{v15()}</rect> };
            let v33: string =
                string(" opacity=\"0.2\" fill=\"#333\" height=\"10\" width=\"4\" y=\"10\" x=\"8\"");
            let v35 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method443()));
            let v37: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<rect "), v33), string(">{v35()}</")),
                            string("rect"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v39: leptos::HtmlElement<leptos::svg::Rect> = leptos::view! { <rect  opacity="0.2" fill="#333" height="10" width="4" y="10" x="8">{v35()}</rect> };
            let v52: string = string(
                " opacity=\"0.2\" fill=\"#333\" height=\"10\" width=\"4\" y=\"10\" x=\"16\"",
            );
            let v54 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method444()));
            let v56: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<rect "), v52), string(">{v54()}</")),
                            string("rect"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v60: Array<leptos::HtmlElement<leptos::svg::Rect>> = Dice_ui::method445(new_array(
                &[
                    v20,
                    v39,
                    leptos::view! { <rect  opacity="0.2" fill="#333" height="10" width="4" y="10" x="16">{v54()}</rect> },
                ],
            ));
            let v61 = Dice_ui::method446();
            let v62: Array<leptos::HtmlElement<leptos::svg::Rect>> = Dice_ui::method448(v60);
            let v64: Vec<leptos::HtmlElement<leptos::svg::Rect>> = v62.to_vec();
            let v67: Vec<leptos::View> =
                Dice_ui::method149(v64.iter().map(|x| v61(x.clone())).collect());
            let v70: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v67));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method439() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure258((), ()))
        }
        pub fn closure257(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v23: string =
                string(" xml:space=\"preserve\" style=\"enable-background:new 0 0 50 50;\" viewBox=\"0 0 24 30\" height=\"30px\" width=\"24px\" y=\"0px\" x=\"0px\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns=\"http://www.w3.org/2000/svg\" id=\"Layer_1\" version=\"1.1\"");
            let v25 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method439()));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<svg "), v23), string(">{v25()}</")),
                            string("svg"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v31: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(
                leptos::view! { <svg  xml:space="preserve" style="enable-background:new 0 0 50 50;" viewBox="0 0 24 30" height="30px" width="24px" y="0px" x="0px" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns="http://www.w3.org/2000/svg" id="Layer_1" version="1.1">{v25()}</svg> },
            );
            let v33: leptos::View = leptos::IntoView::into_view(v31);
            let v37: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(string("Loading..."))));
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v41: std::string::String = String::from(v39);
            let v43: leptos::leptos_dom::Text = leptos::html::text(v41);
            let v48: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v33,
                leptos::IntoView::into_view(v43),
            ])));
            let v50: Vec<leptos::View> = v48.to_vec();
            leptos::Fragment::new(v50)
        }
        pub fn method438() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure257((), ()))
        }
        pub fn closure256(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [gap:4px] items-center\"");
            let v5 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method438()));
            let v8: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v3), string(">{v5()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex flex-1 [gap:4px] items-center">{v5()}</div> },
            );
            let v16: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method437() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure256((), ()))
        }
        pub fn closure164(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            v2: leptos::ReadSignal<bool>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v3: leptos::ReadSignal<bool> = Dice_ui::method72(v2);
            let v26: leptos::View = if leptos::SignalGet::get(&v3) {
                let v9: string = string(" class=\"px-[12px] py-[10px]\"");
                let v11 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method307(v0_1.clone())));
                let v14: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v9), string(">{v11()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v17: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                    leptos::view! { <div  class="px-[12px] py-[10px]">{v11()}</div> },
                );
                leptos::IntoView::into_view(v17)
            } else {
                let v23: Array<leptos::View> =
                    Dice_ui::method156(Dice_ui::method155(Dice_ui::method111(new_empty::<
                        leptos::View,
                    >(
                    ))));
                leptos::CollectView::collect_view(v23.to_vec())
            };
            let v27: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            > = Dice_ui::method322(v1);
            let v29: Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String> =
                v27();
            let v32: Dice_ui::US40 = match &v29 {
                Err(v29_1_0) => Dice_ui::closure178((), v29_1_0.clone()),
                Ok(v29_0_0) => Dice_ui::closure177((), v29_0_0.clone()),
            };
            let v41: Dice_ui::US37 = match &v32 {
                Dice_ui::US40::US40_1(v32_1_0) => Dice_ui::US37::US37_1(defaultValue(
                    Dice_ui::US38::US38_0,
                    map(
                        Func1::new(move |v_2: Array<(usize, LrcPtr<Dice_ui::Heap5>)>| {
                            Dice_ui::closure179((), v_2)
                        }),
                        v32_1_0.clone(),
                    ),
                )),
                Dice_ui::US40::US40_0(v32_0_0) => Dice_ui::US37::US37_0(v32_0_0.clone()),
            };
            let v118: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v26,
                match &v41 {
                    Dice_ui::US37::US37_1(v41_1_0) => {
                        let v42: Dice_ui::US38 = v41_1_0.clone();
                        if let Dice_ui::US38::US38_1(v42_1_0) = &v42 {
                            let v43: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = match &v42 {
                                Dice_ui::US38::US38_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v45: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                Dice_ui::method55(v0_1.l0.clone());
                            let v49: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method75(
                                (leptos::SignalGetUntracked::get_untracked(&v45)).l1.clone(),
                            );
                            if if let Dice_ui::US1::US1_0 = &(leptos::SignalGet::get(&v49)).l1 {
                                true
                            } else {
                                false
                            } {
                                let v55:
                                                                                          string =
                                                                                      string("class=\"grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]\"");
                                let v58: string = append(
                                    append(append(string(" "), v55), string("")),
                                    string(""),
                                );
                                let v60 = Dice_ui::method142(Dice_ui::method141(
                                    Dice_ui::method327(v43.clone()),
                                ));
                                let v63: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v58),
                                                    string(">{v60()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v66: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method194(
                                        leptos::view! { <div  class="grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]">{v60()}</div> },
                                    );
                                leptos::IntoView::into_view(v66)
                            } else {
                                let v72:
                                                                                          string =
                                                                                      string(" class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\"");
                                let v74 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method386(v43)));
                                let v77: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<table "), v72),
                                                    string(">{v74()}</"),
                                                ),
                                                string("table"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v80: leptos::HtmlElement<leptos::html::Table> =
                                    Dice_ui::method436(
                                        leptos::view! { <table  class="flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700">{v74()}</table> },
                                    );
                                leptos::IntoView::into_view(v80)
                            }
                        } else {
                            let v87: string =
                                string(" class=\"grid place-content-center py-[10vh]\"");
                            let v89 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method437()));
                            let v92: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<div "), v87),
                                                string(">{v89()}</"),
                                            ),
                                            string("div"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v95: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                                leptos::view! { <div  class="grid place-content-center py-[10vh]">{v89()}</div> },
                            );
                            leptos::IntoView::into_view(v95)
                        }
                    }
                    Dice_ui::US37::US37_0(v41_0_0) => {
                        let v103: string = string(" class=\"flex flex-1 [gap:4px] [padding:5px]\"");
                        let v105 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method323(
                            v41_0_0.clone(),
                        )));
                        let v108: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(
                                            append(string("<div "), v103),
                                            string(">{v105()}</"),
                                        ),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v111: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                            leptos::view! { <div  class="flex flex-1 [gap:4px] [padding:5px]">{v105()}</div> },
                        );
                        leptos::IntoView::into_view(v111)
                    }
                },
            ])));
            let v120: Vec<leptos::View> = v118.to_vec();
            leptos::Fragment::new(v120)
        }
        pub fn method306(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            v2: leptos::ReadSignal<bool>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure164(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method451() -> string {
            string("Transactions")
        }
        pub fn closure265(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method451()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method450() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure265((), ()))
        }
        pub fn closure266(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            > = Dice_ui::method322(v0_1);
            let v3: Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String> =
                v1();
            let v6: std::string::String = Dice_ui::method52(format!("{:#?}", &v3));
            let v13: string =
                string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:70vh]\"");
            let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method243(
                fable_library_rust::String_::fromString(v6),
            )));
            let v18: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v13), string(">{v15()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v21: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method244(
                leptos::view! { <pre  class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:70vh]">{v15()}</pre> },
            );
            let v26: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method452(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure266(v0_1.clone(), ())
            })
        }
        pub fn closure264(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            unitVar: (),
        ) -> leptos::Fragment {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] \"");
            let v11 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method218(
                Dice_ui::method450(),
                Dice_ui::method452(v0_1),
            )));
            let v14: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v9), string(">{v11()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v18: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method229(new_array(
                &[
                    leptos::view! { <dl  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] ">{v11()}</dl> },
                ],
            ));
            let v19 = Dice_ui::method230();
            let v20: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method232(v18);
            let v22: Vec<leptos::HtmlElement<leptos::html::Dl>> = v20.to_vec();
            let v25: Vec<leptos::View> =
                Dice_ui::method149(v22.iter().map(|x| v19(x.clone())).collect());
            let v28: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v25));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method449(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure264(v0_1.clone(), ())
            })
        }
        pub fn closure267(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method453(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure267(v0_1.clone(), ())
            })
        }
        pub fn closure53(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> leptos::Fragment {
            let v1: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method110(v0_1);
            let v3: Dice_ui::US19 = leptos::SignalGet::get(&v1);
            let v382: Dice_ui::US23 = match &v3 {
                Dice_ui::US19::US19_1(v3_1_0) => {
                    let v6: string = Dice_ui::method0(string("dice.render ()"));
                    leptos::logging::log!("{}", v6);
                    {
                        let v9: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v11: LrcPtr<Dice_ui::Heap2> = v9.unwrap();
                        let v14: Array<leptos::View> =
                            Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
                        let v16: Vec<leptos::View> = v14.to_vec();
                        Dice_ui::US23::US23_1(leptos::Fragment::new(v16))
                    }
                }
                Dice_ui::US19::US19_2 => {
                    let v21: string = Dice_ui::method0(string("lists.render ()"));
                    leptos::logging::log!("{}", v21);
                    {
                        let v24: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v26: LrcPtr<Dice_ui::Heap2> = v24.unwrap();
                        let v29: Array<leptos::View> =
                            Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
                        let v31: Vec<leptos::View> = v29.to_vec();
                        Dice_ui::US23::US23_1(leptos::Fragment::new(v31))
                    }
                }
                Dice_ui::US19::US19_3 => {
                    let v211: string = Dice_ui::method0(string("settings.render ()"));
                    leptos::logging::log!("{}", v211);
                    {
                        let v214: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v216: LrcPtr<Dice_ui::Heap2> = v214.unwrap();
                        let v217 = Dice_ui::method113(v216.clone());
                        let v219: leptos::Memo<
                            Vec<
                                LrcPtr<(
                                    i32,
                                    (
                                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                                    ),
                                )>,
                            >,
                        > = leptos::create_memo(move |_| v217());
                        let v220: i32 = Dice_ui::method117();
                        let patternInput: (leptos::ReadSignal<i32>, leptos::WriteSignal<i32>) =
                            leptos::create_signal(v220);
                        let v223: leptos::WriteSignal<i32> = patternInput.1.clone();
                        let v224 = Dice_ui::method118(v219.clone(), patternInput.0.clone());
                        let v226: leptos::Memo<
                            Vec<(
                                i32,
                                i32,
                                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            )>,
                        > = leptos::create_memo(move |_| v224());
                        let v227 = Dice_ui::method125(v226.clone());
                        let v229: leptos::Memo<i32> = leptos::create_memo(move |_| v227());
                        let v230 = Dice_ui::method128(v216.clone(), v219.clone(), v223.clone());
                        let on_click = v230;
                        {
                            let v232: string = Dice_ui::method138();
                            let v234: &str = fable_library_rust::String_::LrcStr::as_str(&v232);
                            let v236: string = string("r#\"\"#");
                            let v237: &str = r#""#;
                            let v250: string =
                                    string(" class=\" \".to_owned() + v234 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                            let v252 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method139()));
                            let v255: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<svg "), v250),
                                                string(">{v252()}</"),
                                            ),
                                            string("svg"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v257: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg  class=" ".to_owned() + v234 stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">{v252()}</svg> };
                            let v260 = Dice_ui::method150();
                            let v261: string =
                                    string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]\".to_owned() + v260()}");
                            let v265: string = append(
                                append(
                                    string(" aria-label=\"Add\""),
                                    append(
                                        append(
                                            string(" on:click=move |_| on_click()"),
                                            append(
                                                append(append(string(" "), v261), string("")),
                                                string(""),
                                            ),
                                        ),
                                        string(""),
                                    ),
                                ),
                                string(""),
                            );
                            let v267 =
                                Dice_ui::method142(Dice_ui::method141(Dice_ui::method151(v257)));
                            let v270: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<button "), v265),
                                                string(">{v267()}</"),
                                            ),
                                            string("button"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v273: leptos::HtmlElement<leptos::html::Button> =
                                Dice_ui::method153(
                                    leptos::view! { <button  aria-label="Add" on:click=move |_| on_click() class={move || "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]".to_owned() + v260()}>{v267()}</button> },
                                );
                            let v275: leptos::View = leptos::IntoView::into_view(v273);
                            let v277: string = Dice_ui::method6(Dice_ui::method154());
                            let v279: &str = fable_library_rust::String_::LrcStr::as_str(&v277);
                            let v281: std::string::String = String::from(v279);
                            let v285: Array<leptos::View> = Dice_ui::method156(Dice_ui::method155(
                                Dice_ui::method111(new_empty::<leptos::View>()),
                            ));
                            let v287: leptos::View =
                                leptos::CollectView::collect_view(v285.to_vec());
                            let v292: string =
                                string(" class=\"flex flex-col [position:relative]\"");
                            let v294 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method196(
                                v275,
                                v281,
                                Dice_ui::method195(Dice_ui::method157(
                                    v216.clone(),
                                    v226,
                                    v229,
                                    v219,
                                    v223,
                                )),
                            )));
                            let v297: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<div "), v292),
                                                string(">{v294()}</"),
                                            ),
                                            string("div"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v300: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                                leptos::view! { <div  class="flex flex-col [position:relative]">{v294()}</div> },
                            );
                            let v302: leptos::View = leptos::IntoView::into_view(v300);
                            let v304: string = Dice_ui::method6(Dice_ui::method208());
                            let v306: &str = fable_library_rust::String_::LrcStr::as_str(&v304);
                            let v308: std::string::String = String::from(v306);
                            let v312: Array<leptos::View> = Dice_ui::method156(Dice_ui::method155(
                                Dice_ui::method111(new_empty::<leptos::View>()),
                            ));
                            let v319: string =
                                string(" class=\"flex flex-col [position:relative]\"");
                            let v321 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method233(
                                v308,
                                leptos::CollectView::collect_view(v312.to_vec()),
                                Dice_ui::method195(Dice_ui::method209(v216.clone())),
                            )));
                            let v323: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<div "), v319),
                                                string(">{v321()}</"),
                                            ),
                                            string("div"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v326: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                                leptos::view! { <div  class="flex flex-col [position:relative]">{v321()}</div> },
                            );
                            let v328: leptos::View = leptos::IntoView::into_view(v326);
                            let v330: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                Dice_ui::method55(v216.l0.clone());
                            let v334: leptos::RwSignal<bool> = Dice_ui::method73(
                                (leptos::SignalGetUntracked::get_untracked(&v330))
                                    .l2
                                    .clone(),
                            );
                            let v372: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(
                                new_array(&[
                                    v302,
                                    v328,
                                    if leptos::SignalGet::get(&v334) {
                                        let v338: string = Dice_ui::method6(Dice_ui::method235());
                                        let v340: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v338);
                                        let v342: std::string::String = String::from(v340);
                                        let v346: Array<leptos::View> =
                                            Dice_ui::method156(Dice_ui::method155(
                                                Dice_ui::method111(new_empty::<leptos::View>()),
                                            ));
                                        let v353: string =
                                            string(" class=\"flex flex-col [position:relative]\"");
                                        let v355 = Dice_ui::method142(Dice_ui::method141(
                                            Dice_ui::method233(
                                                v342,
                                                leptos::CollectView::collect_view(v346.to_vec()),
                                                Dice_ui::method195(Dice_ui::method236()),
                                            ),
                                        ));
                                        let v357: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<div "), v353),
                                                            string(">{v355()}</"),
                                                        ),
                                                        string("div"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v360: leptos::HtmlElement<leptos::html::Div> =
                                            Dice_ui::method194(
                                                leptos::view! { <div  class="flex flex-col [position:relative]">{v355()}</div> },
                                            );
                                        leptos::IntoView::into_view(v360)
                                    } else {
                                        let v366: Array<leptos::View> =
                                            Dice_ui::method156(Dice_ui::method155(
                                                Dice_ui::method111(new_empty::<leptos::View>()),
                                            ));
                                        leptos::CollectView::collect_view(v366.to_vec())
                                    },
                                ]),
                            ));
                            let v374: Vec<leptos::View> = v372.to_vec();
                            Dice_ui::US23::US23_1(leptos::Fragment::new(v374))
                        }
                    }
                }
                Dice_ui::US19::US19_4 => {
                    let v36: string = Dice_ui::method0(string("transactions.render ()"));
                    leptos::logging::log!("{}", v36);
                    {
                        let v39: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v41: LrcPtr<Dice_ui::Heap2> = v39.unwrap();
                        let v42 = Dice_ui::method245();
                        let v44: leptos::Memo<Option<string>> = leptos::create_memo(move |_| v42());
                        let v46: string = Dice_ui::method0(string("state_core.use_request (1)"));
                        leptos::logging::log!("{}", v46);
                        {
                            let v48 = Dice_ui::method246(v44.clone());
                            let v51: leptos::Resource<
                                Option<string>,
                                Result<Option<string>, string>,
                            > = leptos::create_local_resource(
                                move || v48(),
                                |x| async move {
                                    Func1::new(move |v: Option<string>| Dice_ui::closure132((), v))(
                                        x,
                                    )
                                    .await
                                },
                            );
                            let v53: string =
                                Dice_ui::method0(string("state_core.use_database (1)"));
                            leptos::logging::log!("{}", v53);
                            {
                                let v55 = Dice_ui::method20();
                                let v58: leptos::Resource<Dice_ui::US2, rexie::Rexie> =
                                    leptos::create_local_resource(
                                        move || v55(),
                                        |x| async move {
                                            Func1::new(move |v_1: Dice_ui::US2| {
                                                Dice_ui::closure7((), v_1)
                                            })(x)
                                            .await
                                        },
                                    );
                                let v59 = Dice_ui::method252(v58.clone());
                                let v61: leptos::Memo<Option<rexie::Rexie>> =
                                    leptos::create_memo(move |_| v59());
                                let v62 = Dice_ui::method253(v44.clone(), v58.clone());
                                let v65: leptos::Resource<
                                    (Option<rexie::Rexie>, Option<string>),
                                    Option<LrcPtr<Dice_ui::Heap4>>,
                                > = leptos::create_resource(
                                    move || v62(),
                                    |x| async move {
                                        Func1::new(
                                            move |arg10_0040: (
                                                Option<rexie::Rexie>,
                                                Option<string>,
                                            )| {
                                                Dice_ui::closure137((), arg10_0040)
                                            },
                                        )(x)
                                        .await
                                    },
                                );
                                let v66 = Dice_ui::method256(v65.clone());
                                let v68: Func0<Option<LrcPtr<Dice_ui::Heap4>>> =
                                    Func0::new(move || v66());
                                let v69 = Dice_ui::method258(v44.clone(), v61);
                                let v72 = Dice_ui::method261(
                                    v51.clone(),
                                    leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                        v69(value.clone())
                                    }),
                                );
                                leptos::create_effect(move |_| v72());
                                {
                                    let v74 = Dice_ui::method264(v44, v51, v68);
                                    let v77 =
                                        Dice_ui::method269(v58, v65, Func0::new(move || v74()));
                                    let v80 = Dice_ui::method292(Func0::new(move || v77()));
                                    let v82: leptos::Memo<
                                        Result<
                                            Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                                            std::string::String,
                                        >,
                                    > = leptos::create_memo(move |_| v80());
                                    let v83: bool = Dice_ui::method66();
                                    let patternInput_1: (
                                        leptos::ReadSignal<bool>,
                                        leptos::WriteSignal<bool>,
                                    ) = leptos::create_signal(v83);
                                    let v85: leptos::ReadSignal<bool> = patternInput_1.0.clone();
                                    let v87 = Dice_ui::method302(patternInput_1.1.clone());
                                    let on_click = v87;
                                    {
                                        let v90: string = Dice_ui::method6(string("h-5 w-5"));
                                        let v92: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v90);
                                        let v94: string = string("r#\"\"#");
                                        let v95: &str = r#""#;
                                        let v108: string =
                                                string(" class=\" \".to_owned() + v92 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                                        let v110 = Dice_ui::method142(Dice_ui::method141(
                                            Dice_ui::method303(),
                                        ));
                                        let v113: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<svg "), v108),
                                                            string(">{v110()}</"),
                                                        ),
                                                        string("svg"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v115: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg  class=" ".to_owned() + v92 stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">{v110()}</svg> };
                                        let v118 = Dice_ui::method304(v85.clone());
                                        let v119: string =
                                                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]\".to_owned() + v118()}");
                                        let v123: string = append(
                                            append(
                                                string(" aria-label=\"Settings\""),
                                                append(
                                                    append(
                                                        string(" on:click=move |_| on_click()"),
                                                        append(
                                                            append(
                                                                append(string(" "), v119),
                                                                string(""),
                                                            ),
                                                            string(""),
                                                        ),
                                                    ),
                                                    string(""),
                                                ),
                                            ),
                                            string(""),
                                        );
                                        let v125 = Dice_ui::method142(Dice_ui::method141(
                                            Dice_ui::method151(v115),
                                        ));
                                        let v128: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<button "), v123),
                                                            string(">{v125()}</"),
                                                        ),
                                                        string("button"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v131: leptos::HtmlElement<leptos::html::Button> =
                                            Dice_ui::method153(
                                                leptos::view! { <button  aria-label="Settings" on:click=move |_| on_click() class={move || "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]".to_owned() + v118()}>{v125()}</button> },
                                            );
                                        let v133: leptos::View = leptos::IntoView::into_view(v131);
                                        let v135: string = Dice_ui::method6(Dice_ui::method305());
                                        let v137: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v135);
                                        let v139: std::string::String = String::from(v137);
                                        let v143: Array<leptos::View> =
                                            Dice_ui::method156(Dice_ui::method155(
                                                Dice_ui::method111(new_empty::<leptos::View>()),
                                            ));
                                        let v145: leptos::View =
                                            leptos::CollectView::collect_view(v143.to_vec());
                                        let v150: string =
                                            string(" class=\"flex flex-col [position:relative]\"");
                                        let v152 = Dice_ui::method142(Dice_ui::method141(
                                            Dice_ui::method196(
                                                v133,
                                                v139,
                                                Dice_ui::method195(Dice_ui::method306(
                                                    v41.clone(),
                                                    v82.clone(),
                                                    v85,
                                                )),
                                            ),
                                        ));
                                        let v155: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<div "), v150),
                                                            string(">{v152()}</"),
                                                        ),
                                                        string("div"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v158: leptos::HtmlElement<leptos::html::Div> =
                                            Dice_ui::method194(
                                                leptos::view! { <div  class="flex flex-col [position:relative]">{v152()}</div> },
                                            );
                                        let v160: leptos::View = leptos::IntoView::into_view(v158);
                                        let v162: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                            Dice_ui::method55(v41.l0.clone());
                                        let v166: leptos::RwSignal<bool> = Dice_ui::method73(
                                            (leptos::SignalGetUntracked::get_untracked(&v162))
                                                .l2
                                                .clone(),
                                        );
                                        let v204: Array<leptos::View> = Dice_ui::method112(
                                            Dice_ui::method111(new_array(&[
                                                v160,
                                                if leptos::SignalGet::get(&v166) {
                                                    let v170: string =
                                                        Dice_ui::method6(Dice_ui::method235());
                                                    let v172: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v170,
                                                        );
                                                    let v174: std::string::String =
                                                        String::from(v172);
                                                    let v178: Array<leptos::View> =
                                                        Dice_ui::method156(Dice_ui::method155(
                                                            Dice_ui::method111(new_empty::<
                                                                leptos::View,
                                                            >(
                                                            )),
                                                        ));
                                                    let v185:
                                                                                                              string =
                                                                                                          string(" class=\"flex flex-col [position:relative]\"");
                                                    let v187 = Dice_ui::method142(
                                                        Dice_ui::method141(Dice_ui::method233(
                                                            v174,
                                                            leptos::CollectView::collect_view(
                                                                v178.to_vec(),
                                                            ),
                                                            Dice_ui::method195(Dice_ui::method449(
                                                                v82,
                                                            )),
                                                        )),
                                                    );
                                                    let v189: string = append(
                                                        append(
                                                            string("leptos::view! { "),
                                                            append(
                                                                append(
                                                                    append(
                                                                        append(
                                                                            string("<div "),
                                                                            v185,
                                                                        ),
                                                                        string(">{v187()}</"),
                                                                    ),
                                                                    string("div"),
                                                                ),
                                                                string(">"),
                                                            ),
                                                        ),
                                                        string(" }"),
                                                    );
                                                    let v192: leptos::HtmlElement<
                                                        leptos::html::Div,
                                                    > = Dice_ui::method194(
                                                        leptos::view! { <div  class="flex flex-col [position:relative]">{v187()}</div> },
                                                    );
                                                    leptos::IntoView::into_view(v192)
                                                } else {
                                                    let v198: Array<leptos::View> =
                                                        Dice_ui::method156(Dice_ui::method155(
                                                            Dice_ui::method111(new_empty::<
                                                                leptos::View,
                                                            >(
                                                            )),
                                                        ));
                                                    leptos::CollectView::collect_view(v198.to_vec())
                                                },
                                            ])),
                                        );
                                        let v206: Vec<leptos::View> = v204.to_vec();
                                        Dice_ui::US23::US23_1(leptos::Fragment::new(v206))
                                    }
                                }
                            }
                        }
                    }
                }
                _ => Dice_ui::US23::US23_0,
            };
            let v408: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                match &v382 {
                    Dice_ui::US23::US23_1(v382_1_0) => {
                        let v387: string =
                            string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                        let v389 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method453(
                            v382_1_0.clone(),
                        )));
                        let v392: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(
                                            append(string("<div "), v387),
                                            string(">{v389()}</"),
                                        ),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v395: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                            leptos::view! { <div  class="flex flex-1 flex-col [overflow-y:auto]">{v389()}</div> },
                        );
                        leptos::IntoView::into_view(v395)
                    }
                    _ => {
                        let v401: Array<leptos::View> = Dice_ui::method156(Dice_ui::method155(
                            Dice_ui::method111(new_empty::<leptos::View>()),
                        ));
                        leptos::CollectView::collect_view(v401.to_vec())
                    }
                },
            ])));
            let v410: Vec<leptos::View> = v408.to_vec();
            leptos::Fragment::new(v410)
        }
        pub fn method109(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure53(v0_1.clone(), ())
            })
        }
        pub fn method454(
            v0_1: leptos::HtmlElement<leptos::html::Main>,
        ) -> leptos::HtmlElement<leptos::html::Main> {
            v0_1
        }
        pub fn method458() -> string {
            string("Tab")
        }
        pub fn closure270(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method458()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method457() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure270((), ()))
        }
        pub fn closure273(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: Dice_ui::US19,
            unitVar: (),
        ) -> bool {
            let v2: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method110(v0_1);
            let v4: Dice_ui::US19 = leptos::SignalGet::get(&v2);
            {
                let copyOfStruct: Dice_ui::US19 = v4;
                if let Dice_ui::US19::US19_1(copyOfStruct_1_0) = &copyOfStruct {
                    let copyOfStruct_1: Dice_ui::US19 = v1.clone();
                    if let Dice_ui::US19::US19_1(copyOfStruct_1_1_0) = &copyOfStruct_1 {
                        true
                    } else {
                        false
                    }
                } else {
                    if let Dice_ui::US19::US19_2 = &copyOfStruct {
                        if let Dice_ui::US19::US19_2 = &v1 {
                            true
                        } else {
                            false
                        }
                    } else {
                        if let Dice_ui::US19::US19_3 = &copyOfStruct {
                            if let Dice_ui::US19::US19_3 = &v1 {
                                true
                            } else {
                                false
                            }
                        } else {
                            if let Dice_ui::US19::US19_4 = &copyOfStruct {
                                if let Dice_ui::US19::US19_4 = &v1 {
                                    true
                                } else {
                                    false
                                }
                            } else {
                                if let Dice_ui::US19::US19_0 = &v1 {
                                    true
                                } else {
                                    false
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method461(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: Dice_ui::US19,
        ) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure273(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure274(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v14: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v9),
            ])));
            let v16: Vec<leptos::View> = v14.to_vec();
            leptos::Fragment::new(v16)
        }
        pub fn method462(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure274(v0_1.clone(), ())
            })
        }
        pub fn method463(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure272(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: Dice_ui::US19,
        ) -> leptos::View {
            let v12: string = match &v1 {
                Dice_ui::US19::US19_1(v1_1_0) => string("Dice"),
                Dice_ui::US19::US19_2 => string("Lists"),
                Dice_ui::US19::US19_3 => string("Settings"),
                Dice_ui::US19::US19_4 => string("Transactions"),
                _ => string(""),
            };
            let v13 = Dice_ui::method461(v0_1, v1.clone());
            let v17: string = string(" select=v13()");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method462(v12)));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v17), string(">{v19()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Option_> =
                Dice_ui::method463(leptos::view! { <option  select=v13()>{v19()}</option> });
            leptos::IntoView::into_view(v25)
        }
        pub fn method460(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
        ) -> Func1<Dice_ui::US19, leptos::View> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::US19| Dice_ui::closure272(v0_1.clone(), v)
            })
        }
        pub fn method464(v0_1: Array<Dice_ui::US19>) -> Array<Dice_ui::US19> {
            v0_1
        }
        pub fn closure271(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: Array<Dice_ui::US19> = Dice_ui::method101(new_array(&[
                Dice_ui::US19::US19_1(Dice_ui::US20::US20_0),
                Dice_ui::US19::US19_2,
                Dice_ui::US19::US19_4,
                Dice_ui::US19::US19_3,
            ]));
            let v8 = Dice_ui::method460(v0_1);
            let v9: Array<Dice_ui::US19> = Dice_ui::method464(v7);
            let v11: Vec<Dice_ui::US19> = v9.to_vec();
            let v14: Vec<leptos::View> =
                Dice_ui::method149(v11.iter().map(|x| v8(x.clone())).collect());
            let v17: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v14));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method459(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure271(v0_1.clone(), ())
            })
        }
        pub fn method465(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure269(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v8 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method457()));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<label "), v6), string(">{v8()}</")),
                            string("label"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method180(
                leptos::view! { <label  class="sr-only" for="Tab">{v8()}</label> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v23 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method459(v0_1)));
            let v26: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<select "), v21), string(">{v23()}</")),
                            string("select"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v29: leptos::HtmlElement<leptos::html::Select> = Dice_ui::method465(
                leptos::view! { <select  class="w-full rounded-md border-gray-200" id="Tab">{v23()}</select> },
            );
            let v34: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method456(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure269(v0_1.clone(), ())
            })
        }
        pub fn closure280(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method471() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure280((), ()))
        }
        pub fn closure281(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method472() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure281((), ()))
        }
        pub fn method473(
            v0_1: leptos::HtmlElement<leptos::svg::Circle>,
        ) -> leptos::HtmlElement<leptos::svg::Circle> {
            v0_1
        }
        pub fn closure279(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v15: string =
                string(" stroke-linejoin=\"round\" stroke-linecap=\"round\" rx=\"2\" height=\"18\" width=\"18\" y=\"3\" x=\"3\"");
            let v17 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method471()));
            let v20: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<rect "), v15), string(">{v17()}</")),
                            string("rect"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v23: leptos::HtmlElement<leptos::svg::Rect> = Dice_ui::method447(
                leptos::view! { <rect  stroke-linejoin="round" stroke-linecap="round" rx="2" height="18" width="18" y="3" x="3">{v17()}</rect> },
            );
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            let v34: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"7.5\" cx=\"7.5\"");
            let v36 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v39: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v34), string(">{v36()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v42: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1.5" cy="7.5" cx="7.5">{v36()}</circle> },
            );
            let v44: leptos::View = leptos::IntoView::into_view(v42);
            let v53: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"7.5\" cx=\"16.5\"");
            let v55 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v57: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v53), string(">{v55()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v60: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1.5" cy="7.5" cx="16.5">{v55()}</circle> },
            );
            let v62: leptos::View = leptos::IntoView::into_view(v60);
            let v71: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"12\" cx=\"12\"");
            let v73 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v75: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v71), string(">{v73()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v78: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1.5" cy="12" cx="12">{v73()}</circle> },
            );
            let v80: leptos::View = leptos::IntoView::into_view(v78);
            let v89: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"16.5\" cx=\"7.5\"");
            let v91 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v93: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v89), string(">{v91()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v96: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1.5" cy="16.5" cx="7.5">{v91()}</circle> },
            );
            let v98: leptos::View = leptos::IntoView::into_view(v96);
            let v107: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"16.5\" cx=\"16.5\"");
            let v109 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v111: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v107), string(">{v109()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v114: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1.5" cy="16.5" cx="16.5">{v109()}</circle> },
            );
            let v119: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v25,
                v44,
                v62,
                v80,
                v98,
                leptos::IntoView::into_view(v114),
            ])));
            let v121: Vec<leptos::View> = v119.to_vec();
            leptos::Fragment::new(v121)
        }
        pub fn method470() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure279((), ()))
        }
        pub fn closure282(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string =
                string(" d=\"M4.75 6.75h14.5M4.75 12h14.5M4.75 17.25h14.5\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v15: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method147(
                leptos::view! { <path  d="M4.75 6.75h14.5M4.75 12h14.5M4.75 17.25h14.5" stroke-linejoin="round" stroke-linecap="round">{v9()}</path> },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            let v26: string = string(" fill=\"currentColor\" r=\"1\" cy=\"6.75\" cx=\"3\"");
            let v28 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v31: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v26), string(">{v28()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v34: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1" cy="6.75" cx="3">{v28()}</circle> },
            );
            let v36: leptos::View = leptos::IntoView::into_view(v34);
            let v45: string = string(" fill=\"currentColor\" r=\"1\" cy=\"12\" cx=\"3\"");
            let v47 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v49: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v45), string(">{v47()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v52: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1" cy="12" cx="3">{v47()}</circle> },
            );
            let v54: leptos::View = leptos::IntoView::into_view(v52);
            let v63: string = string(" fill=\"currentColor\" r=\"1\" cy=\"17.25\" cx=\"3\"");
            let v65 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method472()));
            let v67: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<circle "), v63), string(">{v65()}</")),
                            string("circle"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v70: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method473(
                leptos::view! { <circle  fill="currentColor" r="1" cy="17.25" cx="3">{v65()}</circle> },
            );
            let v75: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v17,
                v36,
                v54,
                leptos::IntoView::into_view(v70),
            ])));
            let v77: Vec<leptos::View> = v75.to_vec();
            leptos::Fragment::new(v77)
        }
        pub fn method474() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure282((), ()))
        }
        pub fn closure283(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string =
                string(" d=\"M4 12h16m-7-7l7 7-7 7m-2-14l-7 7 7 7\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method140()));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<path "), v7), string(">{v9()}</")),
                            string("path"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method145(new_array(
                &[
                    leptos::view! { <path  d="M4 12h16m-7-7l7 7-7 7m-2-14l-7 7 7 7" stroke-linejoin="round" stroke-linecap="round">{v9()}</path> },
                ],
            ));
            let v17 = Dice_ui::method146();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method148(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method149(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method475() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure283((), ()))
        }
        pub fn closure284(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: Dice_ui::US19,
            unitVar: (),
        ) -> bool {
            let v2: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method110(v0_1);
            let v4: Dice_ui::US19 = leptos::SignalGet::get(&v2);
            {
                let copyOfStruct: Dice_ui::US19 = v4;
                if let Dice_ui::US19::US19_1(copyOfStruct_1_0) = &copyOfStruct {
                    let copyOfStruct_1: Dice_ui::US19 = v1.clone();
                    if let Dice_ui::US19::US19_1(copyOfStruct_1_1_0) = &copyOfStruct_1 {
                        true
                    } else {
                        false
                    }
                } else {
                    if let Dice_ui::US19::US19_2 = &copyOfStruct {
                        if let Dice_ui::US19::US19_2 = &v1 {
                            true
                        } else {
                            false
                        }
                    } else {
                        if let Dice_ui::US19::US19_3 = &copyOfStruct {
                            if let Dice_ui::US19::US19_3 = &v1 {
                                true
                            } else {
                                false
                            }
                        } else {
                            if let Dice_ui::US19::US19_4 = &copyOfStruct {
                                if let Dice_ui::US19::US19_4 = &v1 {
                                    true
                                } else {
                                    false
                                }
                            } else {
                                if let Dice_ui::US19::US19_0 = &v1 {
                                    true
                                } else {
                                    false
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method476(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: Dice_ui::US19,
        ) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure284(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method477(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure285(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method478(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure285(v0_1.clone(), ())
            })
        }
        pub fn closure286(v0_1: leptos::Fragment, v1: string, unitVar: ()) -> leptos::Fragment {
            let v2: leptos::Fragment = Dice_ui::method424(v0_1);
            let v4: leptos::View = leptos::IntoView::into_view(v2);
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method202(v1)));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v4,
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method479(v0_1: leptos::Fragment, v1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure286(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method480(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure278(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
            v2: Dice_ui::US19,
        ) -> leptos::View {
            let v15: string = append(
                append(
                    append(v1, string("#/")),
                    match &v2 {
                        Dice_ui::US19::US19_1(v2_1_0) => string("dice"),
                        Dice_ui::US19::US19_2 => string("lists"),
                        Dice_ui::US19::US19_3 => string("settings"),
                        Dice_ui::US19::US19_4 => string("transactions"),
                        _ => string(""),
                    },
                ),
                string(""),
            );
            let v175: leptos::Fragment = match &v2 {
                Dice_ui::US19::US19_1(v2_1_0) => {
                    let v17: string = Dice_ui::method6(string("h-5 w-5"));
                    let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                    let v21: string = string("r#\"\"#");
                    let v22: &str = r#""#;
                    let v35: string =
                            string(" class=\" \".to_owned() + v19 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v37 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method470()));
                    let v40: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<svg "), v35), string(">{v37()}</")),
                                    string("svg"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v43: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(
                        leptos::view! { <svg  class=" ".to_owned() + v19 stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">{v37()}</svg> },
                    );
                    let v48: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            leptos::IntoView::into_view(v43),
                        ])));
                    let v50: Vec<leptos::View> = v48.to_vec();
                    leptos::Fragment::new(v50)
                }
                Dice_ui::US19::US19_2 => {
                    let v53: string = Dice_ui::method6(string("h-5 w-5"));
                    let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
                    let v57: string = string("r#\"\"#");
                    let v58: &str = r#""#;
                    let v73: string =
                            string(" class=\"text-gray-700 \".to_owned() + v55 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" height=\"100%\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v75 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method474()));
                    let v78: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<svg "), v73), string(">{v75()}</")),
                                    string("svg"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v81: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(
                        leptos::view! { <svg  class="text-gray-700 ".to_owned() + v55 stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" height="100%" fill="none" xmlns="http://www.w3.org/2000/svg">{v75()}</svg> },
                    );
                    let v86: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            leptos::IntoView::into_view(v81),
                        ])));
                    let v88: Vec<leptos::View> = v86.to_vec();
                    leptos::Fragment::new(v88)
                }
                Dice_ui::US19::US19_3 => {
                    let v129: string = Dice_ui::method6(string("h-5 w-5"));
                    let v131: &str = fable_library_rust::String_::LrcStr::as_str(&v129);
                    let v133: string = string("r#\"\"#");
                    let v134: &str = r#""#;
                    let v147: string =
                            string(" class=\" \".to_owned() + v131 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v149 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method303()));
                    let v152: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<svg "), v147), string(">{v149()}</")),
                                    string("svg"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v155: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(
                        leptos::view! { <svg  class=" ".to_owned() + v131 stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">{v149()}</svg> },
                    );
                    let v160: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            leptos::IntoView::into_view(v155),
                        ])));
                    let v162: Vec<leptos::View> = v160.to_vec();
                    leptos::Fragment::new(v162)
                }
                Dice_ui::US19::US19_4 => {
                    let v91: string = Dice_ui::method6(string("h-5 w-5"));
                    let v93: &str = fable_library_rust::String_::LrcStr::as_str(&v91);
                    let v95: string = string("r#\"\"#");
                    let v96: &str = r#""#;
                    let v111: string =
                            string(" class=\"text-gray-700 \".to_owned() + v93 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" height=\"100%\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v113 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method475()));
                    let v116: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<svg "), v111), string(">{v113()}</")),
                                    string("svg"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v119: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method152(
                        leptos::view! { <svg  class="text-gray-700 ".to_owned() + v93 stroke="currentColor" stroke-width="1.5" viewBox="0 0 24 24" height="100%" fill="none" xmlns="http://www.w3.org/2000/svg">{v113()}</svg> },
                    );
                    let v124: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_array(&[
                            leptos::IntoView::into_view(v119),
                        ])));
                    let v126: Vec<leptos::View> = v124.to_vec();
                    leptos::Fragment::new(v126)
                }
                _ => {
                    let v167: Array<leptos::View> =
                        Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
                    let v169: Vec<leptos::View> = v167.to_vec();
                    leptos::Fragment::new(v169)
                }
            };
            let v186: string = match &v2 {
                Dice_ui::US19::US19_1(v2_1_0) => string("Dice"),
                Dice_ui::US19::US19_2 => string("Lists"),
                Dice_ui::US19::US19_3 => string("Settings"),
                Dice_ui::US19::US19_4 => string("Transactions"),
                _ => string(""),
            };
            let v188: string = Dice_ui::method6(Dice_ui::method18(v15));
            let v190: &str = fable_library_rust::String_::LrcStr::as_str(&v188);
            let v192: std::string::String = String::from(v190);
            let v193 = Dice_ui::method476(v0_1, v2.clone());
            let v194 = Dice_ui::method477(v193.clone());
            let v195 = Dice_ui::method478(v193);
            let v197: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[15px] pl-[15px] text-sm font-medium \".to_owned() + v195()}");
            let v203: string = append(
                append(
                    string(" aria-current={move || if v194() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v197), string(" href=v192")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v205 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method479(v175, v186)));
            let v208: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v203), string(">{v205()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v211: leptos::HtmlElement<leptos::html::A> = Dice_ui::method480(
                leptos::view! { <a  aria-current={move || if v194() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[15px] pl-[15px] text-sm font-medium ".to_owned() + v195()} href=v192>{v205()}</a> },
            );
            leptos::IntoView::into_view(v211)
        }
        pub fn method469(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
        ) -> Func1<Dice_ui::US19, leptos::View> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: Dice_ui::US19| Dice_ui::closure278(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn closure277(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v8: Array<Dice_ui::US19> = Dice_ui::method101(new_array(&[
                Dice_ui::US19::US19_1(Dice_ui::US20::US20_0),
                Dice_ui::US19::US19_2,
                Dice_ui::US19::US19_4,
                Dice_ui::US19::US19_3,
            ]));
            let v9 = Dice_ui::method469(v0_1, v1);
            let v10: Array<Dice_ui::US19> = Dice_ui::method464(v8);
            let v12: Vec<Dice_ui::US19> = v10.to_vec();
            let v15: Vec<leptos::View> =
                Dice_ui::method149(v12.iter().map(|x| v9(x.clone())).collect());
            let v18: Array<leptos::View> =
                Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v15));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method468(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure277(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method481(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure276(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string =
                string("class=\"-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]\"");
            let v7: string = append(
                append(
                    string(" aria-label=\"Tabs\""),
                    append(append(append(string(" "), v2), string("")), string("")),
                ),
                string(""),
            );
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method468(v0_1, v1)));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<nav "), v7), string(">{v9()}</")),
                            string("nav"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v15: leptos::HtmlElement<leptos::html::Nav> = Dice_ui::method481(
                leptos::view! { <nav  aria-label="Tabs" class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]">{v9()}</nav> },
            );
            let v20: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v15),
            ])));
            let v22: Vec<leptos::View> = v20.to_vec();
            leptos::Fragment::new(v22)
        }
        pub fn method467(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure276(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure275(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method467(v0_1, v1)));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v5), string(">{v7()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex flex-1 border-t border-gray-200">{v7()}</div> },
            );
            let v18: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method466(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure275(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method482(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure287(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method483() -> Func1<leptos::HtmlElement<leptos::html::Div>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Div>| Dice_ui::closure287((), v))
        }
        pub fn method484(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure268(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = Dice_ui::method0(string("menu_tabs.render ()"));
            leptos::logging::log!("{}", v2);
            {
                let v5: leptos_router::Location = leptos_router::use_location();
                let v6: leptos_router::Location = Dice_ui::method87(v5.clone());
                let v9: leptos::Memo<std::string::String> = Dice_ui::method88(v6.pathname);
                let v12: std::string::String = Dice_ui::method52(v9());
                let v14: string = fable_library_rust::String_::fromString(v12);
                let v15: leptos_router::Location = Dice_ui::method89(v5);
                let v18: leptos::Memo<std::string::String> = Dice_ui::method88(v15.search);
                let v21: std::string::String = Dice_ui::method52(v18());
                let v23: string = fable_library_rust::String_::fromString(v21);
                let v29: string = append(
                    v14,
                    (if v23.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v23)
                    }),
                );
                let v33: string = string(" class=\"hidden\"");
                let v35 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method456(v0_1.clone())));
                let v38: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v33), string(">{v35()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v40: leptos::HtmlElement<leptos::html::Div> =
                    leptos::view! { <div  class="hidden">{v35()}</div> };
                let v43: string =
                    string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
                let v45 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method466(v0_1, v29)));
                let v47: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v43), string(">{v45()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v51: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method482(
                    new_array(&[
                        v40,
                        leptos::view! { <div  class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v45()}</div> },
                    ]),
                );
                let v52 = Dice_ui::method483();
                let v53: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method484(v51);
                let v55: Vec<leptos::HtmlElement<leptos::html::Div>> = v53.to_vec();
                let v58: Vec<leptos::View> =
                    Dice_ui::method149(v55.iter().map(|x| v52(x.clone())).collect());
                let v61: Array<leptos::View> =
                    Dice_ui::method112(fable_library_rust::NativeArray_::array_from(v58));
                let v63: Vec<leptos::View> = v61.to_vec();
                leptos::Fragment::new(v63)
            }
        }
        pub fn method455(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure268(v0_1.clone(), ())
            })
        }
        pub fn closure52(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col [overflow:hidden]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method109(v0_1.clone())));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<main "), v4), string(">{v6()}</")),
                            string("main"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Main> = Dice_ui::method454(
                leptos::view! { <main  class="flex flex-1 flex-col [overflow:hidden]">{v6()}</main> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"flex\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method455(v0_1)));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v17), string(">{v19()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method194(leptos::view! { <div  class="flex">{v19()}</div> });
            let v30: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method108(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure52(v0_1.clone(), ())
            })
        }
        pub fn closure51(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> leptos::Fragment {
            let v1: string =
                string("class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\"");
            let v4: string = append(append(append(string(" "), v1), string("")), string(""));
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method108(v0_1)));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v4), string(">{v6()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                leptos::view! { <div  class="flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm">{v6()}</div> },
            );
            let v17: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method107(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure51(v0_1.clone(), ())
            })
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("content.render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: leptos_router::Location = leptos_router::use_location();
                let v6: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)> =
                    std::sync::Arc::new(leptos_router::use_navigate());
                let v8: leptos_router::Location = leptos_router::use_location();
                let v9: leptos_router::Location = Dice_ui::method87(v8.clone());
                let v12: leptos::Memo<std::string::String> = Dice_ui::method88(v9.pathname);
                let v15: std::string::String = Dice_ui::method52(v12());
                let v17: string = fable_library_rust::String_::fromString(v15);
                let v18: leptos_router::Location = Dice_ui::method89(v8);
                let v21: leptos::Memo<std::string::String> = Dice_ui::method88(v18.search);
                let v24: std::string::String = Dice_ui::method52(v21());
                let v26: string = fable_library_rust::String_::fromString(v24);
                let v32: string = append(
                    v17,
                    (if v26.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v26)
                    }),
                );
                let v34: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v36: LrcPtr<Dice_ui::Heap2> = v34.unwrap();
                let v37: Dice_ui::US19 = Dice_ui::method90();
                let patternInput: (
                    leptos::ReadSignal<Dice_ui::US19>,
                    leptos::WriteSignal<Dice_ui::US19>,
                ) = leptos::create_signal(v37);
                let v41: bool = Dice_ui::method66();
                let patternInput_1: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                    leptos::create_signal(v41);
                let v45 = Dice_ui::method91(
                    v4.clone(),
                    v6,
                    v32,
                    v36,
                    patternInput_1.1.clone(),
                    patternInput_1.0.clone(),
                );
                leptos::create_effect(move |_| v45());
                {
                    let v47 = Dice_ui::method98(v4, patternInput.1.clone());
                    leptos::create_effect(move |_| v47());
                    {
                        let v52: string =
                            string(" class=\"flex flex-1 max-[100px]:[overflow-x:auto]\"");
                        let v54 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method107(
                            patternInput.0.clone(),
                        )));
                        let v57: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v52), string(">{v54()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v60: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method194(
                            leptos::view! { <div  class="flex flex-1 max-[100px]:[overflow-x:auto]">{v54()}</div> },
                        );
                        let v65: Array<leptos::View> =
                            Dice_ui::method112(Dice_ui::method111(new_array(&[
                                leptos::IntoView::into_view(v60),
                            ])));
                        let v67: Vec<leptos::View> = v65.to_vec();
                        leptos::Fragment::new(v67)
                    }
                }
            }
        }
        pub fn method86() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure46((), ()))
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(1_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6: LrcPtr<Dice_ui::Heap2> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state_core.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method20();
                    let v13: leptos::Resource<Dice_ui::US2, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US2| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state_core.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method23(v13.clone());
                        let v21 = Dice_ui::method44(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method64(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method66();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method67(v13);
                            let v33 = Dice_ui::method71(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method85(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method86()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method194(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                                        leptos::IntoView::into_view(v50),
                                    ])));
                                let v57: Vec<leptos::View> = v55.to_vec();
                                leptos::Fragment::new(v57)
                            }
                        }
                    }
                }
            }
        }
        pub fn method19() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure5((), ()))
        }
        pub fn closure288(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method112(Dice_ui::method111(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method485() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure288((), ()))
        }
        pub fn method486() -> string {
            string("/")
        }
        pub fn closure289(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(2_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6: LrcPtr<Dice_ui::Heap2> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state_core.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method20();
                    let v13: leptos::Resource<Dice_ui::US2, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US2| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state_core.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method23(v13.clone());
                        let v21 = Dice_ui::method44(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method64(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method66();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method67(v13);
                            let v33 = Dice_ui::method71(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method85(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method86()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method194(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                                        leptos::IntoView::into_view(v50),
                                    ])));
                                let v57: Vec<leptos::View> = v55.to_vec();
                                leptos::Fragment::new(v57)
                            }
                        }
                    }
                }
            }
        }
        pub fn method487() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure289((), ()))
        }
        pub fn method488() -> string {
            string("/*")
        }
        pub fn closure290(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(3_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6: LrcPtr<Dice_ui::Heap2> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state_core.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method20();
                    let v13: leptos::Resource<Dice_ui::US2, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US2| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state_core.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method23(v13.clone());
                        let v21 = Dice_ui::method44(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method64(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method66();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method67(v13);
                            let v33 = Dice_ui::method71(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method85(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method86()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method194(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                                        leptos::IntoView::into_view(v50),
                                    ])));
                                let v57: Vec<leptos::View> = v55.to_vec();
                                leptos::Fragment::new(v57)
                            }
                        }
                    }
                }
            }
        }
        pub fn method489() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure290((), ()))
        }
        pub fn method490() -> string {
            string("*")
        }
        pub fn closure291(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(4_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6: LrcPtr<Dice_ui::Heap2> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state_core.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method20();
                    let v13: leptos::Resource<Dice_ui::US2, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US2| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state_core.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method23(v13.clone());
                        let v21 = Dice_ui::method44(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method64(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method66();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method67(v13);
                            let v33 = Dice_ui::method71(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method85(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method86()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method194(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method112(Dice_ui::method111(new_array(&[
                                        leptos::IntoView::into_view(v50),
                                    ])));
                                let v57: Vec<leptos::View> = v55.to_vec();
                                leptos::Fragment::new(v57)
                            }
                        }
                    }
                }
            }
        }
        pub fn method491() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure291((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method17()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method19();
            let v8 = Dice_ui::method485();
            let v18: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v8()) view=move || v7() path=v6 /> })");
            let v19: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v8()) view=move || v7() path=v6 /> },
            );
            let v22: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method486()));
            let v24: &str = fable_library_rust::String_::LrcStr::as_str(&v22);
            let v26: std::string::String = String::from(v24);
            let v27 = Dice_ui::method487();
            let v28 = Dice_ui::method485();
            let v36: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v28()) view=move || v27() path=v26 /> })");
            let v37: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v28()) view=move || v27() path=v26 /> },
            );
            let v40: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method488()));
            let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
            let v44: std::string::String = String::from(v42);
            let v45 = Dice_ui::method489();
            let v46 = Dice_ui::method485();
            let v54: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v46()) view=move || v45() path=v44 /> })");
            let v55: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v46()) view=move || v45() path=v44 /> },
            );
            let v58: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method490()));
            let v60: &str = fable_library_rust::String_::LrcStr::as_str(&v58);
            let v62: std::string::String = String::from(v60);
            let v63 = Dice_ui::method491();
            let v64 = Dice_ui::method485();
            let v72: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> })");
            let v76: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                v19,
                v37,
                v55,
                leptos::IntoView::into_view(
                    leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> },
                ),
            ])));
            let v78: Vec<leptos::View> = v76.to_vec();
            leptos::Fragment::new(v78)
        }
        pub fn method16() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure4((), ()))
        }
        pub fn method492(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method492(Dice_ui::method16());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v11: Array<leptos::View> = Dice_ui::method112(Dice_ui::method111(new_array(&[
                leptos::IntoView::into_view(
                    leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> },
                ),
            ])));
            let v13: Vec<leptos::View> = v11.to_vec();
            leptos::Fragment::new(v13)
        }
        pub fn method15() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure3((), ()))
        }
        pub fn method493(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            let v1: string = Dice_ui::method0(string("app.render ()"));
            leptos::logging::log!("{}", v1);
            leptos_meta::provide_meta_context();
            {
                let v4: bool = Dice_ui::method4();
                let v6: leptos::RwSignal<bool> = leptos::create_rw_signal(v4);
                let v7: bool = Dice_ui::method4();
                let v9: leptos::RwSignal<bool> = leptos::create_rw_signal(v7);
                let v11: string = Dice_ui::method6(Dice_ui::method5());
                let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
                let v16: std::string::String = Dice_ui::method7(String::from(v13));
                let v18: leptos::RwSignal<std::string::String> = leptos::create_rw_signal(v16);
                let v20: string = Dice_ui::method6(Dice_ui::method8());
                let v22: &str = fable_library_rust::String_::LrcStr::as_str(&v20);
                let v24: std::string::String = String::from(v22);
                let v27: string = Dice_ui::method6(Dice_ui::method9());
                let v29: &str = fable_library_rust::String_::LrcStr::as_str(&v27);
                let v35: Array<LrcPtr<(bool, std::string::String)>> =
                    Dice_ui::method11(Dice_ui::method10(new_array(&[
                        LrcPtr::new((true, v24)),
                        LrcPtr::new((true, String::from(v29))),
                    ])));
                let v40: LrcPtr<Dice_ui::Heap0> = Dice_ui::method12(LrcPtr::new(Dice_ui::Heap0 {
                    l0: v35.to_vec(),
                    l1: Dice_ui::US1::US1_0,
                }));
                let v44: LrcPtr<Dice_ui::Heap1> = Dice_ui::method13(LrcPtr::new(Dice_ui::Heap1 {
                    l0: v6,
                    l1: leptos::create_rw_signal(v40),
                    l2: v9,
                    l3: v18,
                }));
                let v46: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = leptos::create_rw_signal(v44);
                let v49: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> =
                    Dice_ui::method14(std::collections::HashMap::new());
                let v52: LrcPtr<Dice_ui::Heap2> = LrcPtr::new(Dice_ui::Heap2 {
                    l0: v46,
                    l1: leptos::create_rw_signal(v49),
                });
                leptos::provide_context::<std::rc::Rc<Heap2>>(v52);
                {
                    let v55 = Dice_ui::method493(Dice_ui::method15());
                    let v61: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v55()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router  children=Box::new(move || v55()) /> },
                    )
                }
            }
        }
        pub fn method3() {
            leptos::mount_to_body(|| Func0::new(move || Dice_ui::closure2((), ()))());
            ()
        }
        pub fn closure292(unitVar: (), unitVar_1: ()) {
            Dice_ui::method3();
        }
        pub fn method494() -> Func0<()> {
            Func0::new(move || Dice_ui::closure292((), ()))
        }
        pub fn method495(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
            v0_1
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v2: string = Dice_ui::method0(append(
                append(string("main / args: "), toString(v0_1)),
                string(""),
            ));
            leptos::logging::log!("{}", v2);
            let _ = console_log::init_with_level(log::Level::Debug);
            console_error_panic_hook::set_once();
            {
                let v10: Dice_ui::US0 = defaultValue(
                    Dice_ui::US0::US0_0,
                    map(
                        Func1::new(move |v: web_sys::HtmlElement| Dice_ui::closure1((), v)),
                        leptos::document().body(),
                    ),
                );
                let v13: string = Dice_ui::method0(append(
                    append(
                        string("main / mount_to_body / body: "),
                        sprintf!("{:?}", &v10),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v13);
                if let Dice_ui::US0::US0_1(v10_1_0) = &v10 {
                    let v16: string = Dice_ui::method1();
                    let v18: &str = fable_library_rust::String_::LrcStr::as_str(&v16);
                    let v19: web_sys::HtmlElement = Dice_ui::method2(match &v10 {
                        Dice_ui::US0::US0_1(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    v19.set_inner_html(v18);
                    Dice_ui::method3()
                } else {
                    let v21 = Dice_ui::method494();
                    let v24: Box<dyn Fn()> = Dice_ui::method495(Box::new(move || v21()));
                    let v26: wasm_bindgen::closure::Closure<dyn Fn()> =
                        wasm_bindgen::closure::Closure::wrap(v24);
                    let v28: &wasm_bindgen::JsValue = wasm_bindgen::closure::Closure::as_ref(&v26);
                    let v30: &js_sys::Function = wasm_bindgen::JsCast::unchecked_ref(v28);
                    leptos::document()
                        .add_event_listener_with_callback("DOMContentLoaded", v30)
                        .unwrap();
                    v26.forget();
                    ()
                }
                0_i32
            }
        }
        pub fn v0() -> Func1<Array<string>, i32> {
            static v0: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v0.get_or_insert_with(|| Func1::new(move |v: Array<string>| Dice_ui::closure0((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Dice_ui::v0())(args)
        }
    }
}
pub use module_eef1bd43::*;
#[path = "../../../polyglot/lib/fsharp/CommonWasm.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
pub mod Polyglot {
    // pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice_ui::main(array_from(args));
}
