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
            pub l0: Vec<std::string::String>,
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
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(std::string::String),
            US22_1(std::string::String),
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
        pub enum US23 {
            US23_0,
            US23_1(string),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US24 {
            US24_0(string),
            US24_1(Option<string>),
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
        pub enum US25 {
            US25_0,
            US25_1(LrcPtr<Dice_ui::Heap4>),
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
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(std::string::String),
            US26_1(Dice_ui::US25),
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
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0,
            US27_1(Option<LrcPtr<Dice_ui::Heap4>>),
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
            US28_0,
            US28_1(Dice_ui::US25),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US29 {
            US29_0,
            US29_1(Result<Option<string>, string>),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US30 {
            US30_0,
            US30_1(Dice_ui::US24),
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
        pub enum US32 {
            US32_0(string),
            US32_1(Dice_ui::US23),
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
        pub enum US31 {
            US31_0,
            US31_1(Dice_ui::US32),
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
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0(std::string::String),
            US33_1(Dice_ui::US14),
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
        pub enum US34 {
            US34_0(std::string::String),
            US34_1(
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
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0,
            US36_1(Array<(usize, LrcPtr<Dice_ui::Heap5>)>),
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
        pub enum US35 {
            US35_0(std::string::String),
            US35_1(Dice_ui::US36),
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
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0,
            US37_1(
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
        pub enum US38 {
            US38_0(std::string::String),
            US38_1(Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>),
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
        pub enum US39 {
            US39_0,
            US39_1(chrono::DateTime<chrono::Utc>),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US40 {
            US40_0(string),
            US40_1(string),
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
        pub fn method10(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn method11(v0_1: Array<std::string::String>) -> Array<std::string::String> {
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
        pub fn method101(v0_1: leptos_router::Url) -> leptos_router::Url {
            v0_1
        }
        pub fn method102() -> string {
            string("/settings")
        }
        pub fn method103(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method104(v0_1: Dice_ui::US19) -> Dice_ui::US19 {
            v0_1
        }
        pub fn method105(
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
                    let v28: leptos_router::Url = Dice_ui::method101(v21_1_0.clone());
                    let v30: std::string::String = v28.pathname;
                    let v32: string = Dice_ui::method6(Dice_ui::method102());
                    let v34: &str = fable_library_rust::String_::LrcStr::as_str(&v32);
                    let v36: std::string::String = String::from(v34);
                    let v37: std::string::String = Dice_ui::method103(v30);
                    let v42: Dice_ui::US19 = if v37.starts_with(&v36) {
                        Dice_ui::US19::US19_2
                    } else {
                        Dice_ui::US19::US19_3
                    };
                    let v46: string = Dice_ui::method0(append(
                        append(
                            string("content.render () / effect 2 / new_tab: "),
                            toString(format!("{:#?}", &v42)),
                        ),
                        string(""),
                    ));
                    leptos::logging::log!("{}", v46);
                    {
                        let v48: Dice_ui::US19 = Dice_ui::method104(v42);
                        let v49: leptos::WriteSignal<Dice_ui::US19> = Dice_ui::method105(v1);
                        leptos::SignalSet::set(&v49, v48);
                        ()
                    }
                }
                Dice_ui::US21::US21_0(v21_0_0) => {
                    let v53: string = Dice_ui::method0(append(
                        append(
                            string("content.render () / effect 2 / hash_url error: "),
                            toString(v21_0_0.clone()),
                        ),
                        string(""),
                    ));
                    leptos::logging::log!("{}", v53);
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
        pub fn method109(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
        ) -> leptos::ReadSignal<Dice_ui::US19> {
            v0_1
        }
        pub fn method113(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure57(
            v0_1: i32,
            v1: std::string::String,
        ) -> LrcPtr<(
            i32,
            (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        )> {
            let v2: std::string::String = Dice_ui::method113(v1);
            let patternInput: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ) = leptos::create_signal(v2);
            LrcPtr::new((v0_1, (patternInput.0.clone(), patternInput.1.clone())))
        }
        pub fn closure56(
            unitVar: (),
            v0_1: i32,
        ) -> Func1<
            std::string::String,
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure57(v0_1, v)
            })
        }
        pub fn method112() -> Func1<
            i32,
            Func1<
                std::string::String,
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            >,
        > {
            Func1::new(move |v: i32| Dice_ui::closure56((), v))
        }
        pub fn method114(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn closure55(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            unitVar: (),
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
        > {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method75((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            let v8: LrcPtr<Dice_ui::Heap0> = leptos::SignalGet::get(&v6);
            let v10 = Dice_ui::method112();
            let v11: Vec<std::string::String> = Dice_ui::method114(v8.l0.clone());
            v11.iter()
                .enumerate()
                .map(|(i, x)| v10(i.try_into().unwrap())(x.clone()))
                .collect()
        }
        pub fn method111(
            v0_1: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<
            Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            >,
        > {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure55(v0_1.clone(), ())
            })
        }
        pub fn method115() -> i32 {
            0_i32
        }
        pub fn method117(v0_1: leptos::ReadSignal<i32>) -> leptos::ReadSignal<i32> {
            v0_1
        }
        pub fn method118(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
        ) -> leptos::Memo<
            Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            >,
        > {
            v0_1
        }
        pub fn closure59(
            unitVar: (),
            v0_: i32,
            v0__1: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        ) -> (
            i32,
            leptos::ReadSignal<std::string::String>,
            leptos::WriteSignal<std::string::String>,
        ) {
            let v0_1: LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )> = LrcPtr::new((v0_, v0__1));
            let b: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ) = v0_1.1.clone();
            (v0_1.0.clone(), b.0.clone(), b.1.clone())
        }
        pub fn method119() -> Func1<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
            (
                i32,
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        > {
            Func1::new(
                move |tupledArg: LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>| {
                    Dice_ui::closure59((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn method120(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn closure60(
            v0_1: i32,
            _arg: (
                i32,
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        ) -> (i32, i32, leptos::ReadSignal<std::string::String>) {
            (v0_1, _arg.0.clone(), _arg.1.clone())
        }
        pub fn method121(
            v0_1: i32,
        ) -> Func1<
            (
                i32,
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
            (i32, i32, leptos::ReadSignal<std::string::String>),
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |arg10_0040: (
                    i32,
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                )| Dice_ui::closure60(v0_1, arg10_0040)
            })
        }
        pub fn method122(
            v0_1: Vec<(
                i32,
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            )>,
        ) -> Vec<(
            i32,
            leptos::ReadSignal<std::string::String>,
            leptos::WriteSignal<std::string::String>,
        )> {
            v0_1
        }
        pub fn closure58(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v1: leptos::ReadSignal<i32>,
            unitVar: (),
        ) -> Vec<(i32, i32, leptos::ReadSignal<std::string::String>)> {
            let v2: leptos::ReadSignal<i32> = Dice_ui::method117(v1);
            let v4: i32 = leptos::SignalGet::get(&v2);
            let v5: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            > = Dice_ui::method118(v0_1);
            let v7: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            > = v5();
            let v8 = Dice_ui::method119();
            let v9: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            > = Dice_ui::method120(v7);
            let v11: Vec<(
                i32,
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            )> = v9.iter().map(|x| v8(x.clone())).collect();
            let v12 = Dice_ui::method121(v4);
            let v13: Vec<(
                i32,
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            )> = Dice_ui::method122(v11);
            v13.iter().map(|x| v12(x.clone())).collect()
        }
        pub fn method116(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v1: leptos::ReadSignal<i32>,
        ) -> Func0<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure58(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method124(
            v0_1: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>>,
        ) -> leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>> {
            v0_1
        }
        pub fn method125(
            v0_1: Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>,
        ) -> Vec<(i32, i32, leptos::ReadSignal<std::string::String>)> {
            v0_1
        }
        pub fn closure61(
            v0_1: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>>,
            unitVar: (),
        ) -> i32 {
            let v1: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>> =
                Dice_ui::method124(v0_1);
            let v4: Vec<(i32, i32, leptos::ReadSignal<std::string::String>)> =
                Dice_ui::method125(v1());
            count(fable_library_rust::NativeArray_::array_from(v4))
        }
        pub fn method123(
            v0_1: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>>,
        ) -> Func0<i32> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure61(v0_1.clone(), ())
            })
        }
        pub fn method129(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn method130(
            v0_: i32,
            v0__1: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        ) -> LrcPtr<(
            i32,
            (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        )> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method131(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn method133(
            v0_1: leptos::ReadSignal<std::string::String>,
        ) -> leptos::ReadSignal<std::string::String> {
            v0_1
        }
        pub fn closure65(
            unitVar: (),
            v0_: i32,
            v0__1: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        ) -> std::string::String {
            let v4: leptos::ReadSignal<std::string::String> =
                Dice_ui::method133(((LrcPtr::new((v0_, v0__1))).1.clone()).0.clone());
            leptos::SignalGet::get(&v4)
        }
        pub fn method132() -> Func1<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
            std::string::String,
        > {
            Func1::new(
                move |tupledArg: LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>| {
                    Dice_ui::closure65((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn closure64(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            > = Dice_ui::method118(v0_1);
            let v6: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            > = v4();
            let v7: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            > = Dice_ui::method129(v6.clone());
            let v10: i32 = count(fable_library_rust::NativeArray_::array_from(v7));
            let v12: string = Dice_ui::method6(Dice_ui::method5());
            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
            let v17: std::string::String = Dice_ui::method113(String::from(v14));
            let patternInput: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ) = leptos::create_signal(v17);
            let v21: LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )> = LrcPtr::new((v10, (patternInput.0.clone(), patternInput.1.clone())));
            let v22: LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )> = Dice_ui::method130(v21.0.clone(), v21.1.clone());
            let v23: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            > = Dice_ui::method131(v6);
            let mut v23 = v23;
            v23.push(v22);
            {
                let v27: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                > = v23;
                let v28 = Dice_ui::method132();
                let v29: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                > = Dice_ui::method120(v27);
                LrcPtr::new(Dice_ui::Heap0 {
                    l0: v29.iter().map(|x| v28(x.clone())).collect(),
                    l1: v1.l1.clone(),
                })
            }
        }
        pub fn method128(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
        ) -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure64(v0_1.clone(), v)
            })
        }
        pub fn closure66(unitVar: (), v0_1: i32) -> i32 {
            1_i32 + v0_1
        }
        pub fn method134() -> Func1<i32, i32> {
            Func1::new(move |v: i32| Dice_ui::closure66((), v))
        }
        pub fn method135(v0_1: leptos::WriteSignal<i32>) -> leptos::WriteSignal<i32> {
            v0_1
        }
        pub fn closure63(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            unitVar: (),
        ) {
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v4);
            let v8 = Dice_ui::method128(v1);
            let v9: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method62(v6.l1.clone());
            leptos::SignalUpdate::update(&v9, |x| *x = v8(x.clone()));
            {
                let v11 = Dice_ui::method134();
                let v12: leptos::WriteSignal<i32> = Dice_ui::method135(v2);
                leptos::SignalUpdate::update(&v12, |x| *x = v11(x.clone()));
                ()
            }
        }
        pub fn method127(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
                move || Dice_ui::closure63(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn closure62(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            unitVar: (),
        ) {
            let v3 = Dice_ui::method127(v0_1, v1, v2);
            let v6: Func0<()> = Dice_ui::method63(Func0::new(move || v3()));
            leptos::batch(move || v6());
            ()
        }
        pub fn method126(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
        pub fn closure67(unitVar: (), unitVar_1: ()) -> &'static str {
            let v1: string = string("r#\" bg-gray-100\"#");
            r#" bg-gray-100"#
        }
        pub fn method136() -> Func0<&'static str> {
            Func0::new(move || Dice_ui::closure67((), ()))
        }
        pub fn method138(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn method139(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method140(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure68(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method138(v0_1);
            let v6: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v1),
            ])));
            let v8: Vec<leptos::View> = v6.to_vec();
            leptos::Fragment::new(v8)
        }
        pub fn method137(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure68(v0_1.clone(), ())
            })
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
        pub fn closure69(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method143(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method144(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method142(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure69(v0_1.clone(), ())
            })
        }
        pub fn method145(
            v0_1: leptos::HtmlElement<leptos::html::Button>,
        ) -> leptos::HtmlElement<leptos::html::Button> {
            v0_1
        }
        pub fn method146() -> string {
            string("Accounts")
        }
        pub fn method147(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method148(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method150(
            v0_1: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>>,
        ) -> leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>> {
            v0_1
        }
        pub fn closure71(
            unitVar: (),
            _arg: (i32, i32, leptos::ReadSignal<std::string::String>),
        ) -> (i32, i32) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn method151() -> Func1<(i32, i32, leptos::ReadSignal<std::string::String>), (i32, i32)>
        {
            Func1::new(
                move |arg10_0040: (i32, i32, leptos::ReadSignal<std::string::String>)| {
                    Dice_ui::closure71((), arg10_0040)
                },
            )
        }
        pub fn closure74(
            v0_1: leptos::ReadSignal<std::string::String>,
            unitVar: (),
        ) -> std::string::String {
            let v1: leptos::ReadSignal<std::string::String> = Dice_ui::method133(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method154(
            v0_1: leptos::ReadSignal<std::string::String>,
        ) -> Func0<std::string::String> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure74(v0_1.clone(), ())
            })
        }
        pub fn method156(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure77(
            v0_1: i32,
            v1: std::string::String,
            v2: i32,
            v3: std::string::String,
        ) -> std::string::String {
            if v2 == v0_1 {
                v1
            } else {
                v3
            }
        }
        pub fn closure76(
            v0_1: i32,
            v1: std::string::String,
            v2: i32,
        ) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move |v: std::string::String| Dice_ui::closure77(v0_1, v1.clone(), v2, v)
            })
        }
        pub fn method157(
            v0_1: i32,
            v1: std::string::String,
        ) -> Func1<i32, Func1<std::string::String, std::string::String>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: i32| Dice_ui::closure76(v0_1, v1.clone(), v)
            })
        }
        pub fn method158(v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
            v0_1
        }
        pub fn method159(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure75(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32, v2: std::string::String) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v3.clone());
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method156((leptos::SignalGetUntracked::get_untracked(&v4)).l1.clone());
            let v10: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v8);
            let v13: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v3);
            let v15: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v13);
            let v17 = Dice_ui::method157(v1, v2);
            let v18: Vec<std::string::String> = Dice_ui::method114(v10.l0.clone());
            let v22: LrcPtr<Dice_ui::Heap0> = Dice_ui::method158(LrcPtr::new(Dice_ui::Heap0 {
                l0: v18
                    .iter()
                    .enumerate()
                    .map(|(i, x)| v17(i.try_into().unwrap())(x.clone()))
                    .collect(),
                l1: v10.l1.clone(),
            }));
            let v23: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method159(v15.l1.clone());
            leptos::SignalSet::set(&v23, v22);
            ()
        }
        pub fn method155(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32) -> Func1<std::string::String, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: std::string::String| Dice_ui::closure75(v0_1.clone(), v1, v)
            })
        }
        pub fn method160(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn method161(v0_1: leptos::Memo<i32>) -> leptos::Memo<i32> {
            v0_1
        }
        pub fn method165(
            v0_1: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
        > {
            v0_1
        }
        pub fn closure82(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method167() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure82((), v))
        }
        pub fn closure81(
            v0_1: i32,
            v1_: i32,
            v1__1: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ),
        ) -> bool {
            let v5: bool = (LrcPtr::new((v1_, v1__1))).0.clone() == v0_1;
            (Dice_ui::method167())(v5)
        }
        pub fn method166(
            v0_1: i32,
        ) -> Func1<
            LrcPtr<(
                i32,
                (
                    leptos::ReadSignal<std::string::String>,
                    leptos::WriteSignal<std::string::String>,
                ),
            )>,
            bool,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |tupledArg: LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>| {
                    Dice_ui::closure81(v0_1, tupledArg.0.clone(), tupledArg.1.clone())
                }
            })
        }
        pub fn closure80(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            > = Dice_ui::method118(v0_1);
            let v8: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ),
                )>,
            > = Dice_ui::method165(v5());
            let v9 = Dice_ui::method166(v1);
            let mut v8 = v8;
            v8.retain(|x| v9(x.clone()));
            {
                let v13: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                > = v8;
                let v14 = Dice_ui::method132();
                let v15: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                > = Dice_ui::method120(v13);
                LrcPtr::new(Dice_ui::Heap0 {
                    l0: v15.iter().map(|x| v14(x.clone())).collect(),
                    l1: v2.l1.clone(),
                })
            }
        }
        pub fn method164(
            v0_1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v1: i32,
        ) -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure80(v0_1.clone(), v1, v)
            })
        }
        pub fn closure79(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
            let v9 = Dice_ui::method164(v1, v3);
            let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method62(v7.l1.clone());
            leptos::SignalUpdate::update(&v10, |x| *x = v9(x.clone()));
            {
                let v12 = Dice_ui::method134();
                let v13: leptos::WriteSignal<i32> = Dice_ui::method135(v2);
                leptos::SignalUpdate::update(&v13, |x| *x = v12(x.clone()));
                ()
            }
        }
        pub fn method163(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
                move || Dice_ui::closure79(v0_1.clone(), v1.clone(), v2.clone(), v3, ())
            })
        }
        pub fn closure78(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v2: leptos::WriteSignal<i32>,
            v3: i32,
            unitVar: (),
        ) {
            let v4 = Dice_ui::method163(v0_1, v1, v2, v3);
            let v7: Func0<()> = Dice_ui::method63(Func0::new(move || v4()));
            leptos::batch(move || v7());
            ()
        }
        pub fn method162(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
                move || Dice_ui::closure78(v0_1.clone(), v1.clone(), v2.clone(), v3, ())
            })
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> &'static str {
            let v1: string = string("r#\"\"#");
            r#""#
        }
        pub fn method168() -> Func0<&'static str> {
            Func0::new(move || Dice_ui::closure83((), ()))
        }
        pub fn closure73(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
            v4: leptos::ReadSignal<std::string::String>,
            v5: i32,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6 = Dice_ui::method154(v4);
            let v7 = Dice_ui::method155(v0_1.clone(), v5);
            let v9: string = string("r#\"\"#");
            let v10: &str = r#""#;
            let v19: string =
                string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v7(leptos::event_target_value(&event)) prop:value=move || v6() class=\"bg-gray-50 flex-1 h-[27px]\".to_owned() + v10 /> }");
            let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method160(
                leptos::view! {
                    <input
                        on:keyup=move |event: web_sys::KeyboardEvent| v7(
                            leptos::event_target_value(&event),
                        )
                        prop:value=move || v6()
                        class="bg-gray-50 flex-1 h-[27px]".to_owned() + v10
                    />
                },
            );
            let v24: leptos::View = leptos::IntoView::into_view(v22);
            let v25: leptos::Memo<i32> = Dice_ui::method161(v1);
            let v62: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v24,
                if v25() == 1_i32 {
                    let v32: Array<leptos::View> =
                        Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v32.to_vec())
                } else {
                    let v35 = Dice_ui::method162(v0_1, v2, v3, v5);
                    let on_click = v35;
                    {
                        let v37:
                                                                                  string =
                                                                              string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M6 6l12 12m0-12L6 18\" /></svg>");
                        let v38: string =
                            append(append(string("leptos::view! { "), v37), string(" }"));
                        let v40: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                            <svg
                                xmlns="http://www.w3.org/2000/svg"
                                fill="none"
                                viewBox="0 0 24 24"
                                stroke-width="1.5"
                                stroke="currentColor"
                                class="h-5 w-5"
                            >
                                <path
                                    stroke-linecap="round"
                                    stroke-linejoin="round"
                                    d="M6 6l12 12m0-12L6 18"
                                ></path>
                            </svg>
                        };
                        let v43 = Dice_ui::method168();
                        let v44:
                                                                                  string =
                                                                              string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] pr-[11px] pl-[11px]\".to_owned() + v43()}");
                        let v48: string = append(
                            append(
                                string(" aria-label=\"Delete\""),
                                append(
                                    append(
                                        string(" on:click=move |_| on_click()"),
                                        append(
                                            append(append(string(" "), v44), string("")),
                                            string(""),
                                        ),
                                    ),
                                    string(""),
                                ),
                            ),
                            string(""),
                        );
                        let v50 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method137(v40)));
                        let v53: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(
                                            append(string("<button "), v48),
                                            string(">{v50()}</"),
                                        ),
                                        string("button"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v56: leptos::HtmlElement<leptos::html::Button> = Dice_ui::method145(
                            leptos::view! {
                                <button
                                    aria-label="Delete"
                                    on:click=move |_| on_click()
                                    class=move || {
                                        "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] pr-[11px] pl-[11px]"
                                            .to_owned() + v43()
                                    }
                                >
                                    {v50()}
                                </button>
                            },
                        );
                        leptos::IntoView::into_view(v56)
                    }
                },
            ])));
            let v64: Vec<leptos::View> = v62.to_vec();
            leptos::Fragment::new(v64)
        }
        pub fn method153(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
            v4: leptos::ReadSignal<std::string::String>,
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
                    Dice_ui::closure73(
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
        pub fn method169(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure72(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
            _arg: (i32, i32, leptos::ReadSignal<std::string::String>),
        ) -> leptos::Fragment {
            let v10: string = string(
                " class=\"pl-[10px] py-[7px] pr-[4px] [display:flex] [align-items:center]\"",
            );
            let v12 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method153(
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
            let v18: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! {
                    <div class="pl-[10px] py-[7px] pr-[4px] [display:flex] [align-items:center]">
                        {v12()}
                    </div>
                },
            );
            let v23: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v18),
            ])));
            let v25: Vec<leptos::View> = v23.to_vec();
            leptos::Fragment::new(v25)
        }
        pub fn method152(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<i32>,
            v2: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v3: leptos::WriteSignal<i32>,
        ) -> Func1<(i32, i32, leptos::ReadSignal<std::string::String>), leptos::Fragment> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |arg10_0040: (i32, i32, leptos::ReadSignal<std::string::String>)| {
                    Dice_ui::closure72(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), arg10_0040)
                }
            })
        }
        pub fn closure70(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>>,
            v2: leptos::Memo<i32>,
            v3: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
                        ),
                    )>,
                >,
            >,
            v4: leptos::WriteSignal<i32>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>> =
                Dice_ui::method150(v1);
            let v6 = Dice_ui::method151();
            let v7 = Dice_ui::method152(v0_1, v2, v3, v4);
            let v19: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos::For  children=move |x| v7(x) let:x key=move |x| v6(x.to_owned()) each=v5 /> })");
            let v23: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(
                    leptos::view! {
                        <leptos::For
                            children=move |x| v7(x)
                            let:x
                            key=move |x| v6(x.to_owned())
                            each=v5
                        ></leptos::For>
                    },
                ),
            ])));
            let v25: Vec<leptos::View> = v23.to_vec();
            leptos::Fragment::new(v25)
        }
        pub fn method149(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>>,
            v2: leptos::Memo<i32>,
            v3: leptos::Memo<
                Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<std::string::String>,
                            leptos::WriteSignal<std::string::String>,
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
                    Dice_ui::closure70(
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
        pub fn closure84(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method143(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method144(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method170(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure84(v0_1.clone(), ())
            })
        }
        pub fn closure86(v0_1: leptos::View, unitVar: ()) -> leptos::Fragment {
            let v3: Array<leptos::View> =
                Dice_ui::method140(Dice_ui::method139(new_array(&[v0_1])));
            let v5: Vec<leptos::View> = v3.to_vec();
            leptos::Fragment::new(v5)
        }
        pub fn method172(v0_1: leptos::View) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure86(v0_1.clone(), ())
            })
        }
        pub fn method177(v0_1: string) -> string {
            v0_1
        }
        pub fn closure90(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method176(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure90(v0_1.clone(), ())
            })
        }
        pub fn method178(
            v0_1: leptos::HtmlElement<leptos::html::Span>,
        ) -> leptos::HtmlElement<leptos::html::Span> {
            v0_1
        }
        pub fn closure89(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[font-size:14px] [line-height:21px]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method176(v0_1)));
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
                leptos::view! { <span class="[font-size:14px] [line-height:21px]">{v6()}</span> },
            );
            let v17: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method175(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure89(v0_1.clone(), ())
            })
        }
        pub fn closure91(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method138(v0_1);
            let v6: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v1),
            ])));
            let v8: Vec<leptos::View> = v6.to_vec();
            leptos::Fragment::new(v8)
        }
        pub fn method179(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure91(v0_1.clone(), ())
            })
        }
        pub fn closure88(
            v0_1: std::string::String,
            v1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"flex items-center gap-2\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method175(v0_1)));
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
            let v13: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="flex items-center gap-2">{v7()}</div> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"shrink-0 transition duration-300 group-open:-rotate-180\"");
            let v20 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method179(v1)));
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
                leptos::view! {
                    <span class="shrink-0 transition duration-300 group-open:-rotate-180">
                        {v20()}
                    </span>
                },
            );
            let v31: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v15,
                leptos::IntoView::into_view(v26),
            ])));
            let v33: Vec<leptos::View> = v31.to_vec();
            leptos::Fragment::new(v33)
        }
        pub fn method174(
            v0_1: std::string::String,
            v1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure88(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method180(
            v0_1: leptos::HtmlElement<leptos::html::Summary>,
        ) -> leptos::HtmlElement<leptos::html::Summary> {
            v0_1
        }
        pub fn closure92(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            v0_1()
        }
        pub fn method181(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure92(v0_1.clone(), ())
            })
        }
        pub fn closure87(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
            v3: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v8: string = string("r#\" [margin-right:40px]\"#");
            let v9: &str = r#" [margin-right:40px]"#;
            let v10: string =
                string("class=\"group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\".to_owned() + v9");
            let v13: string = append(append(append(string(" "), v10), string("")), string(""));
            let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method174(v1, v3)));
            let v18: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<summary "), v13), string(">{v15()}</")),
                            string("summary"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v21: leptos::HtmlElement<leptos::html::Summary> = Dice_ui::method180(
                leptos::view! {
                    <summary class="group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"
                        .to_owned() + v9>{v15()}</summary>
                },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            let v26: string = string(" class=\"flex flex-1 flex-col\"");
            let v28 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method181(v2)));
            let v31: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v26), string(">{v28()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v34: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="flex flex-1 flex-col">{v28()}</div> },
            );
            let v39: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v23,
                leptos::IntoView::into_view(v34),
            ])));
            let v41: Vec<leptos::View> = v39.to_vec();
            leptos::Fragment::new(v41)
        }
        pub fn method173(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
            v3: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure87(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), ())
            })
        }
        pub fn method182(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn closure85(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
            v3: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: string = string(" class=\"[position:absolute] [right:0] [top:0]\"");
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method172(v0_1.clone())));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v7), string(">{v9()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v15: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="[position:absolute] [right:0] [top:0]">{v9()}</div> },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            let v22: string = string(
                " open=true class=\"flex flex-1 group [&_summary::-webkit-details-marker]:hidden\"",
            );
            let v24 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method173(v0_1, v1, v2, v3)));
            let v27: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<details "), v22), string(">{v24()}</")),
                            string("details"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v30: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method182(
                leptos::view! {
                    <details
                        open=true
                        class="flex flex-1 group [&_summary::-webkit-details-marker]:hidden"
                    >
                        {v24()}
                    </details>
                },
            );
            let v35: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v17,
                leptos::IntoView::into_view(v30),
            ])));
            let v37: Vec<leptos::View> = v35.to_vec();
            leptos::Fragment::new(v37)
        }
        pub fn method171(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
            v3: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure85(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), ())
            })
        }
        pub fn method183() -> string {
            string("View")
        }
        pub fn method186() -> string {
            string("Dark Mode")
        }
        pub fn closure94(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method186()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method185() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure94((), ()))
        }
        pub fn closure96(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method73((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method188(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure96(v0_1.clone(), ())
            })
        }
        pub fn closure99(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method191() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure99((), v))
        }
        pub fn closure98(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method191();
            let v8: leptos::RwSignal<bool> = Dice_ui::method57(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method190(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure98(v0_1.clone(), v)
            })
        }
        pub fn method193(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Svg>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Svg>> {
            v0_1
        }
        pub fn closure101(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method138(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method194() -> Func1<leptos::HtmlElement<leptos::svg::Svg>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::svg::Svg>| Dice_ui::closure101((), v))
        }
        pub fn method195(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Svg>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Svg>> {
            v0_1
        }
        pub fn method196(v0_1: Vec<leptos::View>) -> Vec<leptos::View> {
            v0_1
        }
        pub fn closure100(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string =
                string("<svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
            let v1: string = append(append(string("leptos::view! { "), v0_1), string(" }"));
            let v4: string =
                string("<svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg>");
            let v5: string = append(append(string("leptos::view! { "), v4), string(" }"));
            let v9: Array<leptos::HtmlElement<leptos::svg::Svg>> = Dice_ui::method193(new_array(
                &[
                    leptos::view! {
                        <svg
                            data-unchecked-icon
                            xmlns="http://www.w3.org/2000/svg"
                            class="h-4 w-4"
                            viewBox="0 0 20 20"
                            fill="currentColor"
                        >
                            <path
                                fill-rule="evenodd"
                                d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z"
                                clip-rule="evenodd"
                            ></path>
                        </svg>
                    },
                    leptos::view! {
                        <svg
                            data-checked-icon
                            xmlns="http://www.w3.org/2000/svg"
                            class="hidden h-4 w-4"
                            viewBox="0 0 20 20"
                            fill="currentColor"
                        >
                            <path
                                fill-rule="evenodd"
                                d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z"
                                clip-rule="evenodd"
                            ></path>
                        </svg>
                    },
                ],
            ));
            let v10 = Dice_ui::method194();
            let v11: Array<leptos::HtmlElement<leptos::svg::Svg>> = Dice_ui::method195(v9);
            let v13: Vec<leptos::HtmlElement<leptos::svg::Svg>> = v11.to_vec();
            let v16: Vec<leptos::View> =
                Dice_ui::method196(v13.iter().map(|x| v10(x.clone())).collect());
            let v19: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v16));
            let v21: Vec<leptos::View> = v19.to_vec();
            leptos::Fragment::new(v21)
        }
        pub fn method192() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure100((), ()))
        }
        pub fn closure102(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method140(Dice_ui::method139(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method197() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure102((), ()))
        }
        pub fn closure97(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: Func0<bool>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method190(v0_1);
            let on_change = v2;
            let get_value = v1;
            {
                let v5: string =
                    string("class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\"");
                let v19: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                string("<input "),
                                append(
                                    append(
                                        string(" prop:checked={move || get_value()}"),
                                        append(
                                            append(
                                                string(" on:change=move |event| on_change(event)"),
                                                append(
                                                    append(
                                                        string(" id=\"dark-mode\""),
                                                        append(
                                                            append(
                                                                string(" type=\"checkbox\""),
                                                                append(
                                                                    append(
                                                                        append(string(" "), v5),
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
                let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method160(
                    leptos::view! {
                        <input
                            prop:checked=move || get_value()
                            on:change=move |event| on_change(event)
                            id="dark-mode"
                            type="checkbox"
                            class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden"
                        />
                    },
                );
                let v24: leptos::View = leptos::IntoView::into_view(v22);
                let v25: string =
                    string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                let v27: string = append(append(append(string(" "), v25), string("")), string(""));
                let v29 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method192()));
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
                    leptos::view! {
                        <span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">
                            {v29()}
                        </span>
                    },
                );
                let v37: leptos::View = leptos::IntoView::into_view(v35);
                let v38: string =
                    string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                let v40: string = append(append(append(string(" "), v38), string("")), string(""));
                let v42 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method197()));
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
                    leptos::view! {
                        <span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">
                            {v42()}
                        </span>
                    },
                );
                let v52: Array<leptos::View> =
                    Dice_ui::method140(Dice_ui::method139(new_array(&[
                        v24,
                        v37,
                        leptos::IntoView::into_view(v47),
                    ])));
                let v54: Vec<leptos::View> = v52.to_vec();
                leptos::Fragment::new(v54)
            }
        }
        pub fn method189(v0_1: LrcPtr<Dice_ui::Heap2>, v1: Func0<bool>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure97(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method198(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn closure95(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=\"dark-mode\"");
            let v10 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method189(
                v0_1.clone(),
                Dice_ui::method188(v0_1),
            )));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<label "), v8), string(">{v10()}</")),
                            string("label"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method198(
                leptos::view! {
                    <label
                        class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"
                        for="dark-mode"
                    >
                        {v10()}
                    </label>
                },
            );
            let v21: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method187(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure95(v0_1.clone(), ())
            })
        }
        pub fn method200(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method201(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn method202(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn closure103(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"[font-size:12px] text-gray-400\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method200(v0_1)));
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
            let v13: leptos::HtmlElement<leptos::html::Dt> = Dice_ui::method201(
                leptos::view! { <dt class="[font-size:12px] text-gray-400">{v7()}</dt> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1\"");
            let v20 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method200(v1)));
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
            let v26: leptos::HtmlElement<leptos::html::Dd> = Dice_ui::method202(
                leptos::view! { <dd class="[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1">{v20()}</dd> },
            );
            let v31: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v15,
                leptos::IntoView::into_view(v26),
            ])));
            let v33: Vec<leptos::View> = v31.to_vec();
            leptos::Fragment::new(v33)
        }
        pub fn method199(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure103(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method204() -> string {
            string("Debug")
        }
        pub fn closure104(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method204()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method203() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure104((), ()))
        }
        pub fn closure106(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method73((leptos::SignalGetUntracked::get_untracked(&v2)).l2.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method206(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure106(v0_1.clone(), ())
            })
        }
        pub fn closure108(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method191();
            let v8: leptos::RwSignal<bool> = Dice_ui::method57(v5.l2.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method208(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure108(v0_1.clone(), v)
            })
        }
        pub fn closure107(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: Func0<bool>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method208(v0_1);
            let on_change = v2;
            let get_value = v1;
            {
                let v5: string =
                    string("class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\"");
                let v19: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                string("<input "),
                                append(
                                    append(
                                        string(" prop:checked={move || get_value()}"),
                                        append(
                                            append(
                                                string(" on:change=move |event| on_change(event)"),
                                                append(
                                                    append(
                                                        string(" id=\"debug\""),
                                                        append(
                                                            append(
                                                                string(" type=\"checkbox\""),
                                                                append(
                                                                    append(
                                                                        append(string(" "), v5),
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
                let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method160(
                    leptos::view! {
                        <input
                            prop:checked=move || get_value()
                            on:change=move |event| on_change(event)
                            id="debug"
                            type="checkbox"
                            class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden"
                        />
                    },
                );
                let v24: leptos::View = leptos::IntoView::into_view(v22);
                let v25: string =
                    string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                let v27: string = append(append(append(string(" "), v25), string("")), string(""));
                let v29 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method192()));
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
                    leptos::view! {
                        <span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">
                            {v29()}
                        </span>
                    },
                );
                let v37: leptos::View = leptos::IntoView::into_view(v35);
                let v38: string =
                    string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                let v40: string = append(append(append(string(" "), v38), string("")), string(""));
                let v42 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method197()));
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
                    leptos::view! {
                        <span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">
                            {v42()}
                        </span>
                    },
                );
                let v52: Array<leptos::View> =
                    Dice_ui::method140(Dice_ui::method139(new_array(&[
                        v24,
                        v37,
                        leptos::IntoView::into_view(v47),
                    ])));
                let v54: Vec<leptos::View> = v52.to_vec();
                leptos::Fragment::new(v54)
            }
        }
        pub fn method207(v0_1: LrcPtr<Dice_ui::Heap2>, v1: Func0<bool>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure107(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure105(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=\"debug\"");
            let v10 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method207(
                v0_1.clone(),
                Dice_ui::method206(v0_1),
            )));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<label "), v8), string(">{v10()}</")),
                            string("label"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method198(
                leptos::view! {
                    <label
                        class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"
                        for="debug"
                    >
                        {v10()}
                    </label>
                },
            );
            let v21: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method205(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure105(v0_1.clone(), ())
            })
        }
        pub fn method209(
            v0_1: Array<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn method211(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure109(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method210() -> Func1<leptos::HtmlElement<leptos::html::Dl>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Dl>| Dice_ui::closure109((), v))
        }
        pub fn method212(
            v0_1: Array<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn closure93(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v10: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v12 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method185(),
                Dice_ui::method187(v0_1.clone()),
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
            let v17: leptos::HtmlElement<leptos::html::Dl> = leptos::view! {
                <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">
                    {v12()}
                </dl>
            };
            let v24: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v26 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method203(),
                Dice_ui::method205(v0_1),
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
            let v32: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method209(new_array(
                &[
                    v17,
                    leptos::view! {
                        <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">
                            {v26()}
                        </dl>
                    },
                ],
            ));
            let v33 = Dice_ui::method210();
            let v34: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method212(v32);
            let v36: Vec<leptos::HtmlElement<leptos::html::Dl>> = v34.to_vec();
            let v39: Vec<leptos::View> =
                Dice_ui::method196(v36.iter().map(|x| v33(x.clone())).collect());
            let v42: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v39));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method184(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure93(v0_1.clone(), ())
            })
        }
        pub fn closure111(
            v0_1: std::string::String,
            v1: Func0<leptos::Fragment>,
            v2: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: string = string("r#\"\"#");
            let v8: &str = r#""#;
            let v9: string =
                string("class=\"group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\".to_owned() + v8");
            let v11: string = append(append(append(string(" "), v9), string("")), string(""));
            let v13 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method174(v0_1, v2)));
            let v16: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<summary "), v11), string(">{v13()}</")),
                            string("summary"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v19: leptos::HtmlElement<leptos::html::Summary> = Dice_ui::method180(
                leptos::view! {
                    <summary class="group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"
                        .to_owned() + v8>{v13()}</summary>
                },
            );
            let v21: leptos::View = leptos::IntoView::into_view(v19);
            let v24: string = string(" class=\"flex flex-1 flex-col\"");
            let v26 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method181(v1)));
            let v29: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v24), string(">{v26()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="flex flex-1 flex-col">{v26()}</div> },
            );
            let v37: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v21,
                leptos::IntoView::into_view(v32),
            ])));
            let v39: Vec<leptos::View> = v37.to_vec();
            leptos::Fragment::new(v39)
        }
        pub fn method214(
            v0_1: std::string::String,
            v1: Func0<leptos::Fragment>,
            v2: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure111(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn closure110(
            v0_1: std::string::String,
            v1: leptos::View,
            v2: Func0<leptos::Fragment>,
            v3: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: string = string(" class=\"[position:absolute] [right:0] [top:0]\"");
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method172(v1)));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v7), string(">{v9()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v15: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="[position:absolute] [right:0] [top:0]">{v9()}</div> },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            let v22: string = string(
                " open=true class=\"flex flex-1 group [&_summary::-webkit-details-marker]:hidden\"",
            );
            let v24 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method214(v0_1, v2, v3)));
            let v27: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<details "), v22), string(">{v24()}</")),
                            string("details"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v30: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method182(
                leptos::view! {
                    <details
                        open=true
                        class="flex flex-1 group [&_summary::-webkit-details-marker]:hidden"
                    >
                        {v24()}
                    </details>
                },
            );
            let v35: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v17,
                leptos::IntoView::into_view(v30),
            ])));
            let v37: Vec<leptos::View> = v35.to_vec();
            leptos::Fragment::new(v37)
        }
        pub fn method213(
            v0_1: std::string::String,
            v1: leptos::View,
            v2: Func0<leptos::Fragment>,
            v3: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure110(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), ())
            })
        }
        pub fn method215() -> string {
            string("Debug")
        }
        pub fn method218() -> string {
            string("Global State")
        }
        pub fn closure113(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method218()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method217() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure113((), ()))
        }
        pub fn method221(v0_1: LrcPtr<Dice_ui::Heap2>) -> LrcPtr<Dice_ui::Heap2> {
            v0_1
        }
        pub fn closure116(unitVar: (), v0_1: std::string::String) -> Dice_ui::US22 {
            Dice_ui::US22::US22_1(v0_1)
        }
        pub fn closure117(unitVar: (), v0_1: std::string::String) -> Dice_ui::US22 {
            Dice_ui::US22::US22_0(v0_1)
        }
        pub fn closure115(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> string {
            let v2: string = Dice_ui::method0(string(
                "settings.global_state_log_render () / global_state_json memo",
            ));
            leptos::logging::log!("{}", v2);
            {
                let v4: LrcPtr<Dice_ui::Heap2> = Dice_ui::method221(v0_1);
                let v6: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v4).map_err(|x| x.to_string());
                let v9: Dice_ui::US22 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure117((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure116((), v6_0_0.clone()),
                };
                match &v9 {
                    Dice_ui::US22::US22_1(v9_1_0) => {
                        let v11: std::string::String = Dice_ui::method52(v9_1_0.clone());
                        fable_library_rust::String_::fromString(v11)
                    }
                    Dice_ui::US22::US22_0(v9_0_0) => append(
                        append(string("Error: "), toString(v9_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method220(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure115(v0_1.clone(), ())
            })
        }
        pub fn method222(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn closure118(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v14: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v9),
            ])));
            let v16: Vec<leptos::View> = v14.to_vec();
            leptos::Fragment::new(v16)
        }
        pub fn method223(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure118(v0_1.clone(), ())
            })
        }
        pub fn method224(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure114(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("settings.global_state_log_render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v7 = Dice_ui::method220(v4.unwrap());
                let v10: leptos::Memo<string> =
                    Dice_ui::method222(leptos::create_memo(move |_| v7()));
                let v16: string =
                    string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \"");
                let v18 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method223(v10())));
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
                let v24: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method224(
                    leptos::view! {
                        <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] ">
                            {v18()}
                        </pre>
                    },
                );
                let v29: Array<leptos::View> =
                    Dice_ui::method140(Dice_ui::method139(new_array(&[
                        leptos::IntoView::into_view(v24),
                    ])));
                let v31: Vec<leptos::View> = v29.to_vec();
                leptos::Fragment::new(v31)
            }
        }
        pub fn method219() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure114((), ()))
        }
        pub fn closure112(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] \"");
            let v10 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method217(),
                Dice_ui::method219(),
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
            let v16: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] ">
                        {v10()}
                    </dl>
                },
            );
            let v21: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method216() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure112((), ()))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("settings.render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6: LrcPtr<Dice_ui::Heap2> = v4.unwrap();
                let v7 = Dice_ui::method111(v6.clone());
                let v9: leptos::Memo<
                    Vec<
                        LrcPtr<(
                            i32,
                            (
                                leptos::ReadSignal<std::string::String>,
                                leptos::WriteSignal<std::string::String>,
                            ),
                        )>,
                    >,
                > = leptos::create_memo(move |_| v7());
                let v10: i32 = Dice_ui::method115();
                let patternInput: (leptos::ReadSignal<i32>, leptos::WriteSignal<i32>) =
                    leptos::create_signal(v10);
                let v13: leptos::WriteSignal<i32> = patternInput.1.clone();
                let v14 = Dice_ui::method116(v9.clone(), patternInput.0.clone());
                let v16: leptos::Memo<Vec<(i32, i32, leptos::ReadSignal<std::string::String>)>> =
                    leptos::create_memo(move |_| v14());
                let v17 = Dice_ui::method123(v16.clone());
                let v19: leptos::Memo<i32> = leptos::create_memo(move |_| v17());
                let v20 = Dice_ui::method126(v6.clone(), v9.clone(), v13.clone());
                let on_click = v20;
                {
                    let v22: string =
                        string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M12 6v12m6-6H6\"/></svg>");
                    let v23: string = append(append(string("leptos::view! { "), v22), string(" }"));
                    let v25: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                        <svg
                            xmlns="http://www.w3.org/2000/svg"
                            fill="none"
                            viewBox="0 0 24 24"
                            stroke-width="1.5"
                            stroke="currentColor"
                            class="h-5 w-5"
                        >
                            <path
                                stroke-linecap="round"
                                stroke-linejoin="round"
                                d="M12 6v12m6-6H6"
                            ></path>
                        </svg>
                    };
                    let v28 = Dice_ui::method136();
                    let v29: string =
                        string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] pr-[11px] pl-[11px]\".to_owned() + v28()}");
                    let v34: string = append(
                        append(
                            string(" aria-label=\"Add\""),
                            append(
                                append(
                                    string(" on:click=move |_| on_click()"),
                                    append(
                                        append(append(string(" "), v29), string("")),
                                        string(""),
                                    ),
                                ),
                                string(""),
                            ),
                        ),
                        string(""),
                    );
                    let v36 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method137(v25)));
                    let v39: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<button "), v34), string(">{v36()}</")),
                                    string("button"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v42: leptos::HtmlElement<leptos::html::Button> = Dice_ui::method145(
                        leptos::view! {
                            <button
                                aria-label="Add"
                                on:click=move |_| on_click()
                                class=move || {
                                    "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] pr-[11px] pl-[11px]"
                                        .to_owned() + v28()
                                }
                            >
                                {v36()}
                            </button>
                        },
                    );
                    let v44: leptos::View = leptos::IntoView::into_view(v42);
                    let v46: string = Dice_ui::method6(Dice_ui::method146());
                    let v48: &str = fable_library_rust::String_::LrcStr::as_str(&v46);
                    let v50: std::string::String = String::from(v48);
                    let v54: Array<leptos::View> =
                        Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    let v56: leptos::View = leptos::CollectView::collect_view(v54.to_vec());
                    let v59: string =
                        string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                    let v60: string = append(append(string("leptos::view! { "), v59), string(" }"));
                    let v65: string = string(" class=\"flex flex-col [position:relative]\"");
                    let v67 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method171(
                        v44,
                        v50,
                        Dice_ui::method170(Dice_ui::method149(v6.clone(), v16, v19, v9, v13)),
                        leptos::view! {
                            <svg
                                xmlns="http://www.w3.org/2000/svg"
                                class="h-5 w-5"
                                viewBox="0 0 20 20"
                                fill="currentColor"
                            >
                                <path
                                    fill-rule="evenodd"
                                    d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                                    clip-rule="evenodd"
                                ></path>
                            </svg>
                        },
                    )));
                    let v70: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v65), string(">{v67()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v73: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                        leptos::view! { <div class="flex flex-col [position:relative]">{v67()}</div> },
                    );
                    let v75: leptos::View = leptos::IntoView::into_view(v73);
                    let v77: string = Dice_ui::method6(Dice_ui::method183());
                    let v79: &str = fable_library_rust::String_::LrcStr::as_str(&v77);
                    let v81: std::string::String = String::from(v79);
                    let v85: Array<leptos::View> =
                        Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    let v90: string =
                        string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                    let v91: string = append(append(string("leptos::view! { "), v90), string(" }"));
                    let v96: string = string(" class=\"flex flex-col [position:relative]\"");
                    let v98 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method213(
                        v81,
                        leptos::CollectView::collect_view(v85.to_vec()),
                        Dice_ui::method170(Dice_ui::method184(v6.clone())),
                        leptos::view! {
                            <svg
                                xmlns="http://www.w3.org/2000/svg"
                                class="h-5 w-5"
                                viewBox="0 0 20 20"
                                fill="currentColor"
                            >
                                <path
                                    fill-rule="evenodd"
                                    d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                                    clip-rule="evenodd"
                                ></path>
                            </svg>
                        },
                    )));
                    let v100: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v96), string(">{v98()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v103: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                        leptos::view! { <div class="flex flex-col [position:relative]">{v98()}</div> },
                    );
                    let v105: leptos::View = leptos::IntoView::into_view(v103);
                    let v107: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                        Dice_ui::method55(v6.l0.clone());
                    let v111: leptos::RwSignal<bool> = Dice_ui::method73(
                        (leptos::SignalGetUntracked::get_untracked(&v107))
                            .l2
                            .clone(),
                    );
                    let v153: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(
                        new_array(&[
                            v75,
                            v105,
                            if leptos::SignalGet::get(&v111) {
                                let v115: string = Dice_ui::method6(Dice_ui::method215());
                                let v117: &str = fable_library_rust::String_::LrcStr::as_str(&v115);
                                let v119: std::string::String = String::from(v117);
                                let v123: Array<leptos::View> =
                                    Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(
                                        new_empty::<leptos::View>(),
                                    )));
                                let v128:
                                                                                      string =
                                                                                  string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                                let v129: string =
                                    append(append(string("leptos::view! { "), v128), string(" }"));
                                let v134: string =
                                    string(" class=\"flex flex-col [position:relative]\"");
                                let v136 = Dice_ui::method142(Dice_ui::method141(
                                    Dice_ui::method213(
                                        v119,
                                        leptos::CollectView::collect_view(v123.to_vec()),
                                        Dice_ui::method170(Dice_ui::method216()),
                                        leptos::view! {
                                            <svg
                                                xmlns="http://www.w3.org/2000/svg"
                                                class="h-5 w-5"
                                                viewBox="0 0 20 20"
                                                fill="currentColor"
                                            >
                                                <path
                                                    fill-rule="evenodd"
                                                    d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                                                    clip-rule="evenodd"
                                                ></path>
                                            </svg>
                                        },
                                    ),
                                ));
                                let v138: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v134),
                                                    string(">{v136()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v141: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method169(
                                        leptos::view! { <div class="flex flex-col [position:relative]">{v136()}</div> },
                                    );
                                leptos::IntoView::into_view(v141)
                            } else {
                                let v147: Array<leptos::View> =
                                    Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(
                                        new_empty::<leptos::View>(),
                                    )));
                                leptos::CollectView::collect_view(v147.to_vec())
                            },
                        ]),
                    ));
                    let v155: Vec<leptos::View> = v153.to_vec();
                    leptos::Fragment::new(v155)
                }
            }
        }
        pub fn method110() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure54((), ()))
        }
        pub fn closure120(unitVar: (), unitVar_1: ()) -> Option<string> {
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
        pub fn method226() -> Func0<Option<string>> {
            Func0::new(move || Dice_ui::closure120((), ()))
        }
        pub fn method228(v0_1: leptos::Memo<Option<string>>) -> leptos::Memo<Option<string>> {
            v0_1
        }
        pub fn closure121(v0_1: leptos::Memo<Option<string>>, unitVar: ()) -> Option<string> {
            let v1: leptos::Memo<Option<string>> = Dice_ui::method228(v0_1);
            v1()
        }
        pub fn method227(v0_1: leptos::Memo<Option<string>>) -> Func0<Option<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure121(v0_1.clone(), ())
            })
        }
        pub fn closure123(unitVar: (), v0_1: string) -> Dice_ui::US23 {
            Dice_ui::US23::US23_1(v0_1)
        }
        pub fn method229(v0_1: string) -> string {
            v0_1
        }
        pub fn method230(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure124(unitVar: (), v0_1: reqwest_wasm::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method231() -> Func1<reqwest_wasm::Error, std::string::String> {
            Func1::new(move |v: reqwest_wasm::Error| Dice_ui::closure124((), v))
        }
        pub fn method232(v0_1: Result<Option<string>, string>) -> Result<Option<string>, string> {
            v0_1
        }
        pub fn closure122(
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
                    let v8: Dice_ui::US23 = defaultValue(
                        Dice_ui::US23::US23_0,
                        map(
                            Func1::new(move |v: string| Dice_ui::closure123((), v)),
                            v0_1,
                        ),
                    );
                    let v44: Dice_ui::US24 = match &v8 {
                        Dice_ui::US23::US23_1(v8_1_0) => {
                            let v12: string = Dice_ui::method6(Dice_ui::method18(
                                Dice_ui::method229(v8_1_0.clone()),
                            ));
                            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
                            let v17: std::string::String = Dice_ui::method230(String::from(v14));
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
                            let v22 = Dice_ui::method231();
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
                            let v31 = Dice_ui::method231();
                            let v33: Result<std::string::String, std::string::String> =
                                v30.map_err(|x| v31(x));
                            let v36: std::string::String = Dice_ui::method52(v33?);
                            Dice_ui::US24::US24_1(Some(fable_library_rust::String_::fromString(
                                v36,
                            )))
                        }
                        _ => Dice_ui::US24::US24_0(string("Invalid url")),
                    };
                    let v51: Result<Option<string>, string> = Dice_ui::method232(match &v44 {
                        Dice_ui::US24::US24_1(v44_1_0) => {
                            Ok::<Option<string>, string>(v44_1_0.clone())
                        }
                        Dice_ui::US24::US24_0(v44_0_0) => {
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
        pub fn closure125(
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
        pub fn method233(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure125(v0_1.clone(), ())
            })
        }
        pub fn closure126(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            unitVar: (),
        ) -> (Option<rexie::Rexie>, Option<string>) {
            let v2: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method24(v1);
            let v4: Option<rexie::Rexie> = leptos::SignalGet::get(&v2);
            let v5: leptos::Memo<Option<string>> = Dice_ui::method228(v0_1);
            (v4, v5())
        }
        pub fn method234(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func0<(Option<rexie::Rexie>, Option<string>)> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure126(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method235(
            v0_1: Result<Dice_ui::US25, std::string::String>,
        ) -> Result<Dice_ui::US25, std::string::String> {
            v0_1
        }
        pub fn closure128(unitVar: (), v0_1: Dice_ui::US25) -> Dice_ui::US26 {
            Dice_ui::US26::US26_1(v0_1)
        }
        pub fn closure129(unitVar: (), v0_1: std::string::String) -> Dice_ui::US26 {
            Dice_ui::US26::US26_0(v0_1)
        }
        pub fn method236(v0_1: Option<LrcPtr<Dice_ui::Heap4>>) -> Option<LrcPtr<Dice_ui::Heap4>> {
            v0_1
        }
        pub fn closure127(
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
                        let v13: Dice_ui::US23 = defaultValue(
                            Dice_ui::US23::US23_0,
                            map(
                                Func1::new(move |v_1: string| Dice_ui::closure123((), v_1)),
                                v1,
                            ),
                        );
                        let v130: Dice_ui::US25 = if let Dice_ui::US5::US5_1(v10_1_0) = &v10 {
                            if let Dice_ui::US23::US23_1(v13_1_0) = &v13 {
                                let v16: string = append(
                                    append(
                                        string("url["),
                                        match &v13 {
                                            Dice_ui::US23::US23_1(x) => x.clone(),
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
                                        let v110: Result<Dice_ui::US25, std::string::String> =
                                            Dice_ui::method235(Ok::<
                                                Dice_ui::US25,
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
                                                            Dice_ui::US25::US25_1(v102?)
                                                        }
                                                    }
                                                }
                                                _ => Dice_ui::US25::US25_0,
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
                                                        Dice_ui::US25,
                                                        std::string::String,
                                                    >,
                                                >,
                                            >,
                                        > = __future_init;
                                        let v115: Result<Dice_ui::US25, std::string::String> =
                                            v113.await;
                                        let v118: Dice_ui::US26 = match &v115 {
                                            Err(v115_1_0) => {
                                                Dice_ui::closure129((), v115_1_0.clone())
                                            }
                                            Ok(v115_0_0) => {
                                                Dice_ui::closure128((), v115_0_0.clone())
                                            }
                                        };
                                        match &v118 {
                                            Dice_ui::US26::US26_1(v118_1_0) => v118_1_0.clone(),
                                            Dice_ui::US26::US26_0(v118_0_0) => {
                                                let v122: string =
                                                    Dice_ui::method0(append(append(string("state_core.use_request (4.1) / state_data_resource create_local_resource / error: "),
                                                                                   toString(v118_0_0.clone())),
                                                                            string("")));
                                                leptos::logging::log!("{}", v122);
                                                Dice_ui::US25::US25_0
                                            }
                                        }
                                    }
                                }
                            } else {
                                Dice_ui::US25::US25_0
                            }
                        } else {
                            Dice_ui::US25::US25_0
                        };
                        let v136: Option<LrcPtr<Dice_ui::Heap4>> =
                            Dice_ui::method236(match &v130 {
                                Dice_ui::US25::US25_1(v130_1_0) => Some(v130_1_0.clone()),
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
        pub fn method238(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
        ) -> leptos::Resource<(Option<rexie::Rexie>, Option<string>), Option<LrcPtr<Dice_ui::Heap4>>>
        {
            v0_1
        }
        pub fn closure131(unitVar: (), v0_1: Option<LrcPtr<Dice_ui::Heap4>>) -> Dice_ui::US27 {
            Dice_ui::US27::US27_1(v0_1)
        }
        pub fn closure132(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap4>) -> Dice_ui::US25 {
            Dice_ui::US25::US25_1(v0_1)
        }
        pub fn closure130(
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
                let v53: Dice_ui::US25 = if let Dice_ui::US10::US10_1(v17_1_0) = &v17 {
                    if let Dice_ui::US11::US11_1(_) = &match &v17 {
                        Dice_ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<
                            (Option<rexie::Rexie>, Option<string>),
                            Option<LrcPtr<Dice_ui::Heap4>>,
                        > = Dice_ui::method238(v0_1);
                        let v25: Dice_ui::US27 = defaultValue(
                            Dice_ui::US27::US27_0,
                            map(
                                Func1::new(move |v_3: Option<LrcPtr<Dice_ui::Heap4>>| {
                                    Dice_ui::closure131((), v_3)
                                }),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v33: Dice_ui::US28 = match &v25 {
                            Dice_ui::US27::US27_1(v25_1_0) => Dice_ui::US28::US28_1(defaultValue(
                                Dice_ui::US25::US25_0,
                                map(
                                    Func1::new(move |v_4: LrcPtr<Dice_ui::Heap4>| {
                                        Dice_ui::closure132((), v_4)
                                    }),
                                    v25_1_0.clone(),
                                ),
                            )),
                            _ => Dice_ui::US28::US28_0,
                        };
                        let v40: Dice_ui::US25 = if let Dice_ui::US28::US28_1(v33_1_0) = &v33 {
                            let v34: Dice_ui::US25 = match &v33 {
                                Dice_ui::US28::US28_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US25::US25_1(v34_1_0) = &v34 {
                                Dice_ui::US25::US25_1(match &v34 {
                                    Dice_ui::US25::US25_1(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Dice_ui::US25::US25_0
                            }
                        } else {
                            Dice_ui::US25::US25_0
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
                        Dice_ui::US25::US25_0
                    }
                } else {
                    Dice_ui::US25::US25_0
                };
                match &v53 {
                    Dice_ui::US25::US25_1(v53_1_0) => Some(v53_1_0.clone()),
                    _ => None::<LrcPtr<Dice_ui::Heap4>>,
                }
            }
        }
        pub fn method237(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
        ) -> Func0<Option<LrcPtr<Dice_ui::Heap4>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure130(v0_1.clone(), ())
            })
        }
        pub fn method240(
            v0_1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> leptos::Memo<Option<rexie::Rexie>> {
            v0_1
        }
        pub fn method241(v0_1: leptos::Memo<Option<string>>) -> leptos::Memo<Option<string>> {
            v0_1
        }
        pub fn closure133(
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
                        let v9: leptos::Memo<Option<rexie::Rexie>> = Dice_ui::method240(v1);
                        let v14: Dice_ui::US5 = defaultValue(
                            Dice_ui::US5::US5_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                leptos::SignalGetUntracked::get_untracked(&v9),
                            ),
                        );
                        let v15: leptos::Memo<Option<string>> = Dice_ui::method241(v0_1);
                        let v20: Dice_ui::US23 = defaultValue(
                            Dice_ui::US23::US23_0,
                            map(
                                Func1::new(move |v_1: string| Dice_ui::closure123((), v_1)),
                                leptos::SignalGetUntracked::get_untracked(&v15),
                            ),
                        );
                        if let Dice_ui::US5::US5_1(v14_1_0) = &v14 {
                            if let Dice_ui::US23::US23_1(v20_1_0) = &v20 {
                                let v22: string = match &v20 {
                                    Dice_ui::US23::US23_1(x) => x.clone(),
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
        pub fn method239(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> Func1<LrcPtr<Dice_ui::Heap4>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure133(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn method243(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
        ) -> leptos::Resource<Option<string>, Result<Option<string>, string>> {
            v0_1
        }
        pub fn closure135(unitVar: (), v0_1: Result<Option<string>, string>) -> Dice_ui::US29 {
            Dice_ui::US29::US29_1(v0_1)
        }
        pub fn closure136(unitVar: (), v0_1: Option<string>) -> Dice_ui::US24 {
            Dice_ui::US24::US24_1(v0_1)
        }
        pub fn closure137(unitVar: (), v0_1: string) -> Dice_ui::US24 {
            Dice_ui::US24::US24_0(v0_1)
        }
        pub fn method244(v0_1: LrcPtr<Dice_ui::Heap4>) -> LrcPtr<Dice_ui::Heap4> {
            v0_1
        }
        pub fn closure134(
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
                            Dice_ui::method243(v0_1);
                        let v26: Dice_ui::US29 = defaultValue(
                            Dice_ui::US29::US29_0,
                            map(
                                Func1::new(move |v_3: Result<Option<string>, string>| {
                                    Dice_ui::closure135((), v_3)
                                }),
                                leptos::SignalGet::get(&v21),
                            ),
                        );
                        let v34: Dice_ui::US30 = match &v26 {
                            Dice_ui::US29::US29_1(v26_1_0) => {
                                let v27: Result<Option<string>, string> = v26_1_0.clone();
                                Dice_ui::US30::US30_1(match &v27 {
                                    Err(v27_1_0) => Dice_ui::closure137((), v27_1_0.clone()),
                                    Ok(v27_0_0) => Dice_ui::closure136((), v27_0_0.clone()),
                                })
                            }
                            _ => Dice_ui::US30::US30_0,
                        };
                        let v48: Dice_ui::US31 = match &v34 {
                            Dice_ui::US30::US30_1(v34_1_0) => {
                                let v35: Dice_ui::US24 = v34_1_0.clone();
                                Dice_ui::US31::US31_1(match &v35 {
                                    Dice_ui::US24::US24_1(v35_1_0) => {
                                        Dice_ui::US32::US32_1(defaultValue(
                                            Dice_ui::US23::US23_0,
                                            map(
                                                Func1::new(move |v_6: string| {
                                                    Dice_ui::closure123((), v_6)
                                                }),
                                                v35_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US24::US24_0(v35_0_0) => {
                                        Dice_ui::US32::US32_0(v35_0_0.clone())
                                    }
                                })
                            }
                            _ => Dice_ui::US31::US31_0,
                        };
                        let v75: Dice_ui::US33 = if let Dice_ui::US31::US31_1(v48_1_0) = &v48 {
                            let v49: Dice_ui::US32 = match &v48 {
                                Dice_ui::US31::US31_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            match &v49 {
                                Dice_ui::US32::US32_1(v49_1_0) => {
                                    let v50: Dice_ui::US23 = v49_1_0.clone();
                                    if let Dice_ui::US23::US23_1(v50_1_0) = &v50 {
                                        let v53: string =
                                            Dice_ui::method6(Dice_ui::method18(match &v50 {
                                                Dice_ui::US23::US23_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            }));
                                        let v55: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v53);
                                        Dice_ui::US33::US33_1(Dice_ui::US14::US14_1(String::from(
                                            v55,
                                        )))
                                    } else {
                                        Dice_ui::US33::US33_1(Dice_ui::US14::US14_0)
                                    }
                                }
                                Dice_ui::US32::US32_0(v49_0_0) => {
                                    let v65: string =
                                        Dice_ui::method6(Dice_ui::method18(v49_0_0.clone()));
                                    let v67: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v65);
                                    Dice_ui::US33::US33_0(String::from(v67))
                                }
                            }
                        } else {
                            Dice_ui::US33::US33_1(Dice_ui::US14::US14_0)
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
                        if let Dice_ui::US33::US33_1(v75_1_0) = &v75 {
                            let v85: Dice_ui::US14 = match &v75 {
                                Dice_ui::US33::US33_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US14::US14_1(v85_1_0) = &v85 {
                                let v88: LrcPtr<Dice_ui::Heap4> =
                                    Dice_ui::method244(LrcPtr::new(Dice_ui::Heap4 {
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
        pub fn method242(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure134(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method246() -> string {
            string("Invalid url")
        }
        pub fn method247(
            v0_1: Func0<Option<LrcPtr<Dice_ui::Heap4>>>,
        ) -> Func0<Option<LrcPtr<Dice_ui::Heap4>>> {
            v0_1
        }
        pub fn closure139(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Root,
        ) -> Option<crate::model::near::nearblocks::Root> {
            Some(v0_1)
        }
        pub fn method248(
        ) -> Func1<crate::model::near::nearblocks::Root, Option<crate::model::near::nearblocks::Root>>
        {
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure139((), v))
        }
        pub fn method249(
            v0_1: Result<crate::model::near::nearblocks::Root, std::string::String>,
        ) -> Result<crate::model::near::nearblocks::Root, std::string::String> {
            v0_1
        }
        pub fn closure138(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v2: Func0<Option<LrcPtr<Dice_ui::Heap4>>>,
            unitVar: (),
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            let v3: leptos::Memo<Option<string>> = Dice_ui::method228(v0_1);
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
                fn v10(v: string) -> Dice_ui::US23 {
                    Dice_ui::closure123((), v)
                }
                let v12: Dice_ui::US23 =
                    defaultValue(Dice_ui::US23::US23_0, map(Func1::from(v10), v5));
                let v159: Result<
                    Option<crate::model::near::nearblocks::Root>,
                    std::string::String,
                > = match &v12 {
                    Dice_ui::US23::US23_1(v12_1_0) => {
                        let v15: string = Dice_ui::method0(append(
                            append(
                                string("state_core.use_request (15) / result memo / url: "),
                                v12_1_0.clone(),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v15);
                        {
                            let v17: Func0<Option<LrcPtr<Dice_ui::Heap4>>> = Dice_ui::method247(v2);
                            let v22: Dice_ui::US25 = defaultValue(
                                Dice_ui::US25::US25_0,
                                map(
                                    Func1::new(move |v_1: LrcPtr<Dice_ui::Heap4>| {
                                        Dice_ui::closure132((), v_1)
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
                                > = Dice_ui::method243(v1);
                                let v37: Dice_ui::US29 = defaultValue(
                                    Dice_ui::US29::US29_0,
                                    map(
                                        Func1::new(move |v_2: Result<Option<string>, string>| {
                                            Dice_ui::closure135((), v_2)
                                        }),
                                        leptos::SignalGet::get(&v32),
                                    ),
                                );
                                let v45: Dice_ui::US30 = match &v37 {
                                    Dice_ui::US29::US29_1(v37_1_0) => {
                                        let v38: Result<Option<string>, string> = v37_1_0.clone();
                                        Dice_ui::US30::US30_1(match &v38 {
                                            Err(v38_1_0) => {
                                                Dice_ui::closure137((), v38_1_0.clone())
                                            }
                                            Ok(v38_0_0) => Dice_ui::closure136((), v38_0_0.clone()),
                                        })
                                    }
                                    _ => Dice_ui::US30::US30_0,
                                };
                                let v58: Dice_ui::US31 = match &v45 {
                                    Dice_ui::US30::US30_1(v45_1_0) => {
                                        let v46: Dice_ui::US24 = v45_1_0.clone();
                                        Dice_ui::US31::US31_1(match &v46 {
                                            Dice_ui::US24::US24_1(v46_1_0) => {
                                                Dice_ui::US32::US32_1(defaultValue(
                                                    Dice_ui::US23::US23_0,
                                                    map(Func1::from(v10), v46_1_0.clone()),
                                                ))
                                            }
                                            Dice_ui::US24::US24_0(v46_0_0) => {
                                                Dice_ui::US32::US32_0(v46_0_0.clone())
                                            }
                                        })
                                    }
                                    _ => Dice_ui::US31::US31_0,
                                };
                                let v73: Dice_ui::US32 =
                                    if let Dice_ui::US31::US31_1(v58_1_0) = &v58 {
                                        let v59: Dice_ui::US32 = match &v58 {
                                            Dice_ui::US31::US31_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        match &v59 {
                                            Dice_ui::US32::US32_1(v59_1_0) => {
                                                let v62: Dice_ui::US23 = v59_1_0.clone();
                                                if let Dice_ui::US23::US23_1(v62_1_0) = &v62 {
                                                    Dice_ui::US32::US32_1(Dice_ui::US23::US23_1(
                                                        match &v62 {
                                                            Dice_ui::US23::US23_1(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    ))
                                                } else {
                                                    Dice_ui::US32::US32_1(Dice_ui::US23::US23_0)
                                                }
                                            }
                                            Dice_ui::US32::US32_0(v59_0_0) => {
                                                Dice_ui::US32::US32_0(v59_0_0.clone())
                                            }
                                        }
                                    } else {
                                        Dice_ui::US32::US32_1(Dice_ui::US23::US23_0)
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
                                    let v91: Dice_ui::US23 = match &v22 {
                                        Dice_ui::US25::US25_1(v22_1_0) => {
                                            let v85: std::string::String =
                                                Dice_ui::method52((v22_1_0).l0.clone());
                                            Dice_ui::US23::US23_1(
                                                fable_library_rust::String_::fromString(v85),
                                            )
                                        }
                                        _ => Dice_ui::US23::US23_0,
                                    };
                                    if let Dice_ui::US32::US32_1(v73_1_0) = &v73 {
                                        let v92: Dice_ui::US23 = match &v73 {
                                            Dice_ui::US32::US32_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US23::US23_1(v92_1_0) = &v92 {
                                            let v94: string = Dice_ui::method6(match &v92 {
                                                Dice_ui::US23::US23_1(x) => x.clone(),
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
                                            let v102 = Dice_ui::method248();
                                            let v103: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = Dice_ui::method249(v101);
                                            v103.map(|x| v102(x))
                                        } else {
                                            if let Dice_ui::US23::US23_1(v91_1_0) = &v91 {
                                                let v107: string = Dice_ui::method6(match &v91 {
                                                    Dice_ui::US23::US23_1(x) => x.clone(),
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
                                                let v115 = Dice_ui::method248();
                                                let v116: Result<
                                                    crate::model::near::nearblocks::Root,
                                                    std::string::String,
                                                > = Dice_ui::method249(v114);
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
                                        if let Dice_ui::US23::US23_1(v91_1_0) = &v91 {
                                            let v128: string = Dice_ui::method6(match &v91 {
                                                Dice_ui::US23::US23_1(x) => x.clone(),
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
                                            let v136 = Dice_ui::method248();
                                            let v137: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = Dice_ui::method249(v135);
                                            v137.map(|x| v136(x))
                                        } else {
                                            if let Dice_ui::US32::US32_0(v73_0_0) = &v73 {
                                                let v142: string = Dice_ui::method6(
                                                    Dice_ui::method18(match &v73 {
                                                        Dice_ui::US32::US32_0(x) => x.clone(),
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
                        let v152: string = Dice_ui::method6(Dice_ui::method246());
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
        pub fn method245(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v2: Func0<Option<LrcPtr<Dice_ui::Heap4>>>,
        ) -> Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure138(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method251(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US2, rexie::Rexie> {
            v0_1
        }
        pub fn method252(v0_1: leptos::Signal<bool>) -> leptos::Signal<bool> {
            v0_1
        }
        pub fn method253(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            >,
        ) -> leptos::Resource<(Option<rexie::Rexie>, Option<string>), Option<LrcPtr<Dice_ui::Heap4>>>
        {
            v0_1
        }
        pub fn method254(
            v0_1: Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            v0_1
        }
        pub fn method256(
            v0_1: Option<crate::model::near::nearblocks::Root>,
        ) -> Option<crate::model::near::nearblocks::Root> {
            v0_1
        }
        pub fn method258(
            v0_1: crate::model::near::nearblocks::Root,
        ) -> crate::model::near::nearblocks::Root {
            v0_1
        }
        pub fn method260(
            v0_1: crate::model::near::nearblocks::Txn,
        ) -> crate::model::near::nearblocks::Txn {
            v0_1
        }
        pub fn method261(
            v0_1: crate::model::near::nearblocks::Block,
        ) -> crate::model::near::nearblocks::Block {
            v0_1
        }
        pub fn method263(
            v0_1: crate::model::near::nearblocks::Action,
        ) -> crate::model::near::nearblocks::Action {
            v0_1
        }
        pub fn closure144(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Action,
        ) -> (std::string::String, Option<std::string::String>) {
            let v1: crate::model::near::nearblocks::Action = Dice_ui::method263(v0_1);
            (v1.action, v1.method)
        }
        pub fn method262() -> Func1<
            crate::model::near::nearblocks::Action,
            (std::string::String, Option<std::string::String>),
        > {
            Func1::new(move |v: crate::model::near::nearblocks::Action| Dice_ui::closure144((), v))
        }
        pub fn method264(
            v0_1: Vec<(std::string::String, Option<std::string::String>)>,
        ) -> Vec<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method265(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
        ) -> Array<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method266(
            v0_1: crate::model::near::nearblocks::ActionsAgg,
        ) -> crate::model::near::nearblocks::ActionsAgg {
            v0_1
        }
        pub fn method267(
            v0_1: crate::model::near::nearblocks::Outcomes,
        ) -> crate::model::near::nearblocks::Outcomes {
            v0_1
        }
        pub fn method268(
            v0_1: crate::model::near::nearblocks::OutcomesAgg,
        ) -> crate::model::near::nearblocks::OutcomesAgg {
            v0_1
        }
        pub fn method269(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn closure143(
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
            let v1: crate::model::near::nearblocks::Txn = Dice_ui::method260(v0_1);
            let v3: std::string::String = v1.receipt_id;
            let v5: std::string::String = v1.predecessor_account_id;
            let v7: std::string::String = v1.receiver_account_id;
            let v9: std::string::String = v1.transaction_hash;
            let v11: std::string::String = v1.included_in_block_hash;
            let v13: std::string::String = v1.block_timestamp;
            let v16: crate::model::near::nearblocks::Block = Dice_ui::method261(v1.block);
            let v18: u32 = v16.block_height;
            let v19 = Dice_ui::method262();
            let v22: Vec<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method264(v1.actions.into_iter().map(|x| v19(x)).collect());
            let v25: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method265(fable_library_rust::NativeArray_::array_from(v22));
            let v28: crate::model::near::nearblocks::ActionsAgg =
                Dice_ui::method266(v1.actions_agg);
            let v30: f64 = v28.deposit;
            let v33: crate::model::near::nearblocks::Outcomes = Dice_ui::method267(v1.outcomes);
            let v35: bool = v33.status;
            let v38: crate::model::near::nearblocks::OutcomesAgg =
                Dice_ui::method268(v1.outcomes_agg);
            let v40: f64 = v38.transaction_fee;
            let v43: Vec<std::string::String> = Dice_ui::method28(v1.logs);
            (
                v25,
                v30,
                v18,
                v13,
                v11,
                Dice_ui::method269(fable_library_rust::NativeArray_::array_from(v43)),
                v35,
                v40,
                v5,
                v3,
                v7,
                v9,
            )
        }
        pub fn method259() -> Func1<
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
            Func1::new(move |v: crate::model::near::nearblocks::Txn| Dice_ui::closure143((), v))
        }
        pub fn method270(
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
        pub fn method271(
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
        pub fn closure142(
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
            let v1: crate::model::near::nearblocks::Root = Dice_ui::method258(v0_1);
            let v2 = Dice_ui::method259();
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
            )> = Dice_ui::method270(v1.txns.into_iter().map(|x| v2(x)).collect());
            Dice_ui::method271(fable_library_rust::NativeArray_::array_from(v5))
        }
        pub fn method257() -> Func1<
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
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure142((), v))
        }
        pub fn closure141(
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
            let v1: Option<crate::model::near::nearblocks::Root> = Dice_ui::method256(v0_1);
            let v2 = Dice_ui::method257();
            v1.map(|x| v2(x))
        }
        pub fn method255() -> Func1<
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
                Dice_ui::closure141((), v)
            })
        }
        pub fn method272(
            v0_1: Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            v0_1
        }
        pub fn closure140(
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
            let v3: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method251(v0_1.clone());
            let v6: leptos::Signal<bool> = Dice_ui::method252(leptos::Resource::loading(&v3));
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap4>>,
            > = Dice_ui::method253(v1.clone());
            let v12: leptos::Signal<bool> = Dice_ui::method252(leptos::Resource::loading(&v9));
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
            > = Dice_ui::method238(v1);
            let v26: Dice_ui::US27 = defaultValue(
                Dice_ui::US27::US27_0,
                map(
                    Func1::new(move |v_1: Option<LrcPtr<Dice_ui::Heap4>>| {
                        Dice_ui::closure131((), v_1)
                    }),
                    leptos::SignalGet::get(&v21),
                ),
            );
            let v34: Dice_ui::US28 = match &v26 {
                Dice_ui::US27::US27_1(v26_1_0) => Dice_ui::US28::US28_1(defaultValue(
                    Dice_ui::US25::US25_0,
                    map(
                        Func1::new(move |v_2: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure132((), v_2)),
                        v26_1_0.clone(),
                    ),
                )),
                _ => Dice_ui::US28::US28_0,
            };
            let v41: Dice_ui::US25 = if let Dice_ui::US28::US28_1(v34_1_0) = &v34 {
                let v35: Dice_ui::US25 = match &v34 {
                    Dice_ui::US28::US28_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Dice_ui::US25::US25_1(v35_1_0) = &v35 {
                    Dice_ui::US25::US25_1(match &v35 {
                        Dice_ui::US25::US25_1(x) => x.clone(),
                        _ => unreachable!(),
                    })
                } else {
                    Dice_ui::US25::US25_0
                }
            } else {
                Dice_ui::US25::US25_0
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
                > = Dice_ui::method254(v2);
                let v59: Result<Option<crate::model::near::nearblocks::Root>, std::string::String> =
                    (move || v57())();
                let v60 = Dice_ui::method255();
                let v61: Result<Option<crate::model::near::nearblocks::Root>, std::string::String> =
                    Dice_ui::method272(v59);
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
        pub fn method250(
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
                move || Dice_ui::closure140(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method274(
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
        pub fn closure146(
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
        ) -> Dice_ui::US34 {
            Dice_ui::US34::US34_1(v0_1)
        }
        pub fn closure147(unitVar: (), v0_1: std::string::String) -> Dice_ui::US34 {
            Dice_ui::US34::US34_0(v0_1)
        }
        pub fn closure148(
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
        ) -> Dice_ui::US37 {
            Dice_ui::US37::US37_1(v0_1)
        }
        pub fn method275(
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
        pub fn method276(
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
        pub fn closure149(
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
        pub fn method277() -> Func1<
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
                    Dice_ui::closure149((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn method278(
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
        pub fn method279(
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
        pub fn closure150(
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
        pub fn method280() -> Func1<
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
                )| Dice_ui::closure150((), arg10_0040),
            )
        }
        pub fn method281(
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
        pub fn method282(
            v0_1: Vec<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure145(
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
            > = Dice_ui::method274(v0_1);
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
            let v6: Dice_ui::US34 = match &v3 {
                Err(v3_1_0) => Dice_ui::closure147((), v3_1_0.clone()),
                Ok(v3_0_0) => Dice_ui::closure146((), v3_0_0.clone()),
            };
            let v46: Dice_ui::US35 = match &v6 {
                Dice_ui::US34::US34_1(v6_1_0) => {
                    let v10: Dice_ui::US37 = defaultValue(
                        Dice_ui::US37::US37_0,
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
                                )>| Dice_ui::closure148((), v_2),
                            ),
                            v6_1_0.clone(),
                        ),
                    );
                    Dice_ui::US35::US35_1(match &v10 {
                        Dice_ui::US37::US37_1(v10_1_0) => {
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
                            )> = Dice_ui::method275(v10_1_0.clone());
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
                            > = Dice_ui::method276(
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
                            let v20 = Dice_ui::method277();
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
                            > = Dice_ui::method278(v19);
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
                            )> = Dice_ui::method279(v23.iter().map(|x| v20(x.clone())).collect());
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
                            let v29 = Dice_ui::method280();
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
                            )> = Dice_ui::method281(v28);
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
                                Dice_ui::method282(v32.iter().map(|x| v29(x.clone())).collect());
                            Dice_ui::US36::US36_1(fable_library_rust::NativeArray_::array_from(v35))
                        }
                        _ => Dice_ui::US36::US36_0,
                    })
                }
                Dice_ui::US34::US34_0(v6_0_0) => Dice_ui::US35::US35_0(v6_0_0.clone()),
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
                let v61: Dice_ui::US38 = match &v46 {
                    Dice_ui::US35::US35_1(v46_1_0) => {
                        let v51: Dice_ui::US36 = v46_1_0.clone();
                        Dice_ui::US38::US38_1(match &v51 {
                            Dice_ui::US36::US36_1(v51_1_0) => Some(v51_1_0.clone()),
                            _ => None::<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                        })
                    }
                    Dice_ui::US35::US35_0(v46_0_0) => Dice_ui::US38::US38_0(v46_0_0.clone()),
                };
                match &v61 {
                    Dice_ui::US38::US38_1(v61_1_0) => Ok::<
                        Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                        std::string::String,
                    >(v61_1_0.clone()),
                    Dice_ui::US38::US38_0(v61_0_0) => Err::<
                        Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                        std::string::String,
                    >(v61_0_0.clone()),
                }
            }
        }
        pub fn method273(
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
                move || Dice_ui::closure145(v0_1.clone(), ())
            })
        }
        pub fn closure151(v0_1: leptos::WriteSignal<bool>, unitVar: ()) {
            let v1 = Dice_ui::method191();
            let v2: leptos::WriteSignal<bool> = Dice_ui::method80(v0_1);
            leptos::SignalUpdate::update(&v2, |x| *x = v1(x.clone()));
            ()
        }
        pub fn method283(v0_1: leptos::WriteSignal<bool>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure151(v0_1.clone(), ())
            })
        }
        pub fn closure152(v0_1: leptos::ReadSignal<bool>, unitVar: ()) -> &'static str {
            let v1: leptos::ReadSignal<bool> = Dice_ui::method72(v0_1);
            if leptos::SignalGet::get(&v1) {
                let v5: string = string("r#\"\"#");
                r#""#
            } else {
                let v8: string = string("r#\" bg-gray-100\"#");
                r#" bg-gray-100"#
            }
        }
        pub fn method284(v0_1: leptos::ReadSignal<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure152(v0_1.clone(), ())
            })
        }
        pub fn method285() -> string {
            string("Transactions")
        }
        pub fn method289() -> string {
            string("Settings")
        }
        pub fn closure155(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method289()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method288() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure155((), ()))
        }
        pub fn closure156(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method143(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method144(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method290(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure156(v0_1.clone(), ())
            })
        }
        pub fn closure158(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            v0_1()
        }
        pub fn method292(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure158(v0_1.clone(), ())
            })
        }
        pub fn closure159(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method140(Dice_ui::method139(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method293() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure159((), ()))
        }
        pub fn closure157(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"pr-[15px] [font-size:13px]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method292(v0_1)));
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
                leptos::view! { <span class="pr-[15px] [font-size:13px]">{v6()}</span> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"h-px flex-1 bg-gray-300\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method293()));
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
                leptos::view! { <span class="h-px flex-1 bg-gray-300">{v19()}</span> },
            );
            let v29: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v14,
                leptos::IntoView::into_view(v24),
            ])));
            let v31: Vec<leptos::View> = v29.to_vec();
            leptos::Fragment::new(v31)
        }
        pub fn method291(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure157(v0_1.clone(), ())
            })
        }
        pub fn method295() -> string {
            string("Table View")
        }
        pub fn closure160(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method295()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method294() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure160((), ()))
        }
        pub fn closure162(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v6: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method75((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            if let Dice_ui::US1::US1_1 = &(leptos::SignalGet::get(&v6)).l1 {
                true
            } else {
                false
            }
        }
        pub fn method297(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure162(v0_1.clone(), ())
            })
        }
        pub fn closure165(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
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
        pub fn method300() -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new(move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure165((), v))
        }
        pub fn closure164(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method55(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method300();
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method62(v5.l1.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method299(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure164(v0_1.clone(), v)
            })
        }
        pub fn closure163(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: Func0<bool>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method299(v0_1);
            let on_change = v2;
            let get_value = v1;
            {
                let v5: string =
                    string("class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\"");
                let v19: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                string("<input "),
                                append(
                                    append(
                                        string(" prop:checked={move || get_value()}"),
                                        append(
                                            append(
                                                string(" on:change=move |event| on_change(event)"),
                                                append(
                                                    append(
                                                        string(" id=\"table-view\""),
                                                        append(
                                                            append(
                                                                string(" type=\"checkbox\""),
                                                                append(
                                                                    append(
                                                                        append(string(" "), v5),
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
                let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method160(
                    leptos::view! {
                        <input
                            prop:checked=move || get_value()
                            on:change=move |event| on_change(event)
                            id="table-view"
                            type="checkbox"
                            class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden"
                        />
                    },
                );
                let v24: leptos::View = leptos::IntoView::into_view(v22);
                let v25: string =
                    string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                let v27: string = append(append(append(string(" "), v25), string("")), string(""));
                let v29 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method192()));
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
                    leptos::view! {
                        <span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">
                            {v29()}
                        </span>
                    },
                );
                let v37: leptos::View = leptos::IntoView::into_view(v35);
                let v38: string =
                    string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                let v40: string = append(append(append(string(" "), v38), string("")), string(""));
                let v42 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method197()));
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
                    leptos::view! {
                        <span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">
                            {v42()}
                        </span>
                    },
                );
                let v52: Array<leptos::View> =
                    Dice_ui::method140(Dice_ui::method139(new_array(&[
                        v24,
                        v37,
                        leptos::IntoView::into_view(v47),
                    ])));
                let v54: Vec<leptos::View> = v52.to_vec();
                leptos::Fragment::new(v54)
            }
        }
        pub fn method298(v0_1: LrcPtr<Dice_ui::Heap2>, v1: Func0<bool>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure163(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure161(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=\"table-view\"");
            let v10 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method298(
                v0_1.clone(),
                Dice_ui::method297(v0_1),
            )));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<label "), v8), string(">{v10()}</")),
                            string("label"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method198(
                leptos::view! {
                    <label
                        class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"
                        for="table-view"
                    >
                        {v10()}
                    </label>
                },
            );
            let v21: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method296(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure161(v0_1.clone(), ())
            })
        }
        pub fn closure154(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v6: string = string(" class=\"flex items-center pb-[6px]\"");
            let v8 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method291(
                Dice_ui::method290(Dice_ui::method288()),
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
                leptos::view! { <span class="flex items-center pb-[6px]">{v8()}</span> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v25: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v27 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method294(),
                Dice_ui::method296(v0_1),
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
            let v33: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">
                        {v27()}
                    </dl>
                },
            );
            let v38: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v16,
                leptos::IntoView::into_view(v33),
            ])));
            let v40: Vec<leptos::View> = v38.to_vec();
            leptos::Fragment::new(v40)
        }
        pub fn method287(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure154(v0_1.clone(), ())
            })
        }
        pub fn method301(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> leptos::Memo<Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>>
        {
            v0_1
        }
        pub fn closure166(
            unitVar: (),
            v0_1: Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
        ) -> Dice_ui::US38 {
            Dice_ui::US38::US38_1(v0_1)
        }
        pub fn closure167(unitVar: (), v0_1: std::string::String) -> Dice_ui::US38 {
            Dice_ui::US38::US38_0(v0_1)
        }
        pub fn closure168(
            unitVar: (),
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Dice_ui::US36 {
            Dice_ui::US36::US36_1(v0_1)
        }
        pub fn closure170(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" height=\"100%\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"text-red-700\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M6 18L18 6M6 6l12 12\" /></svg>");
            let v1: string = append(append(string("leptos::view! { "), v0_1), string(" }"));
            let v4: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method138(
                leptos::view! {
                    <svg
                        xmlns="http://www.w3.org/2000/svg"
                        fill="none"
                        height="100%"
                        viewBox="0 0 24 24"
                        stroke-width="1.5"
                        stroke="currentColor"
                        class="text-red-700"
                    >
                        <path
                            stroke-linecap="round"
                            stroke-linejoin="round"
                            d="M6 18L18 6M6 6l12 12"
                        ></path>
                    </svg>
                },
            );
            let v9: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v4),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method303() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure170((), ()))
        }
        pub fn closure171(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method304(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure171(v0_1.clone(), ())
            })
        }
        pub fn closure169(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[height:20px]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method303()));
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
                Dice_ui::method178(leptos::view! { <span class="[height:20px]">{v6()}</span> });
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"[overflow-y:auto]\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method304(v0_1)));
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
                Dice_ui::method224(leptos::view! { <pre class="[overflow-y:auto]">{v19()}</pre> });
            let v30: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method302(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure169(v0_1.clone(), ())
            })
        }
        pub fn closure175(v0_1: i64, unitVar: ()) -> leptos::Fragment {
            let v4: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(append(
                append(string("Transaction "), toString(v0_1 + 1_i64)),
                string(""),
            ))));
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: leptos::leptos_dom::Text = leptos::html::text(v8);
            let v15: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v10),
            ])));
            let v17: Vec<leptos::View> = v15.to_vec();
            leptos::Fragment::new(v17)
        }
        pub fn method308(v0_1: i64) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure175(v0_1, ())
            })
        }
        pub fn method311() -> string {
            string("Block Timestamp")
        }
        pub fn closure177(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method311()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method310() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure177((), ()))
        }
        pub fn method313(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method314(v0_1: i64) -> i64 {
            v0_1
        }
        pub fn closure179(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> Dice_ui::US39 {
            Dice_ui::US39::US39_1(v0_1)
        }
        pub fn method315(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
            v0_1
        }
        pub fn method316(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn closure178(
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
            let v12: std::string::String = Dice_ui::method313(v3);
            let v15: i64 = Dice_ui::method314(v12.parse().unwrap());
            let v20: Dice_ui::US39 = defaultValue(
                Dice_ui::US39::US39_0,
                map(
                    Func1::new(move |v: chrono::DateTime<chrono::Utc>| Dice_ui::closure179((), v)),
                    chrono::DateTime::from_timestamp_micros(v15 / 1000i64),
                ),
            );
            let v39: Dice_ui::US23 = match &v20 {
                Dice_ui::US39::US39_1(v20_1_0) => {
                    let v22: chrono::DateTime<chrono::Utc> = Dice_ui::method315(v20_1_0.clone());
                    let v24: chrono::NaiveDateTime = v22.naive_utc();
                    let v26: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v24);
                    let v28: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v29: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v30: chrono::DateTime<chrono::Local> = Dice_ui::method316(v26);
                    let v33: std::string::String = Dice_ui::method52(v30.format(v29).to_string());
                    Dice_ui::US23::US23_1(fable_library_rust::String_::fromString(v33))
                }
                _ => Dice_ui::US23::US23_0,
            };
            let v45: Dice_ui::US40 = match &v39 {
                Dice_ui::US23::US23_1(v39_1_0) => Dice_ui::US40::US40_1(v39_1_0.clone()),
                _ => Dice_ui::US40::US40_0(string(
                    "resultm.from_option / Option does not have a value.",
                )),
            };
            let v53: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(match &v45 {
                Dice_ui::US40::US40_1(v45_1_0) => v45_1_0.clone(),
                Dice_ui::US40::US40_0(v45_0_0) => {
                    append(append(string("Error: "), v45_0_0.clone()), string(""))
                }
            })));
            let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
            let v57: std::string::String = String::from(v55);
            let v59: leptos::leptos_dom::Text = leptos::html::text(v57);
            let v64: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v59),
            ])));
            let v66: Vec<leptos::View> = v64.to_vec();
            leptos::Fragment::new(v66)
        }
        pub fn method312(
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
                    Dice_ui::closure178(
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
        pub fn method318() -> string {
            string("Predecessor")
        }
        pub fn closure180(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method318()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method317() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure180((), ()))
        }
        pub fn closure181(
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
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method319(
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
                    Dice_ui::closure181(
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
        pub fn method321() -> string {
            string("Receiver")
        }
        pub fn closure182(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method321()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method320() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure182((), ()))
        }
        pub fn closure183(
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
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method322(
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
                    Dice_ui::closure183(
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
        pub fn method324() -> string {
            string("Actions")
        }
        pub fn closure184(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method324()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method323() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure184((), ()))
        }
        pub fn closure187(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
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
            let v26: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method327(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure187(v0_1.clone(), ())
            })
        }
        pub fn method331() -> string {
            string("Method")
        }
        pub fn closure190(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method331()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method330() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure190((), ()))
        }
        pub fn method333() -> string {
            string("None")
        }
        pub fn closure191(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
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
                    let v10: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                        fable_library_rust::String_::fromString(v5),
                    )));
                    let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
                    let v14: std::string::String = String::from(v12);
                    let v16: leptos::leptos_dom::Text = leptos::html::text(v14);
                    let v21: Array<leptos::View> =
                        Dice_ui::method140(Dice_ui::method139(new_array(&[
                            leptos::IntoView::into_view(v16),
                        ])));
                    let v23: Vec<leptos::View> = v21.to_vec();
                    leptos::Fragment::new(v23)
                }
                _ => {
                    let v28: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method333()));
                    let v30: &str = fable_library_rust::String_::LrcStr::as_str(&v28);
                    let v32: std::string::String = String::from(v30);
                    let v34: leptos::leptos_dom::Text = leptos::html::text(v32);
                    let v39: Array<leptos::View> =
                        Dice_ui::method140(Dice_ui::method139(new_array(&[
                            leptos::IntoView::into_view(v34),
                        ])));
                    let v41: Vec<leptos::View> = v39.to_vec();
                    leptos::Fragment::new(v41)
                }
            }
        }
        pub fn method332(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure191(v0_1.clone(), ())
            })
        }
        pub fn closure189(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  \"");
            let v10 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method330(),
                Dice_ui::method332(v0_1),
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
            let v16: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  ">
                        {v10()}
                    </dl>
                },
            );
            let v21: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method329(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure189(v0_1.clone(), ())
            })
        }
        pub fn closure188(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method329(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="flex flex-1 flex-col">{v6()}</div> },
            );
            let v17: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method328(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure188(v0_1.clone(), ())
            })
        }
        pub fn closure186(
            unitVar: (),
            _arg: (std::string::String, Option<std::string::String>),
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center \"");
            let v11 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method327(_arg.0.clone()),
                Dice_ui::method328(_arg.1.clone()),
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
            leptos::view! {
                <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center ">
                    {v11()}
                </dl>
            }
        }
        pub fn method326() -> Func1<
            (std::string::String, Option<std::string::String>),
            leptos::HtmlElement<leptos::html::Dl>,
        > {
            Func1::new(
                move |arg10_0040: (std::string::String, Option<std::string::String>)| {
                    Dice_ui::closure186((), arg10_0040)
                },
            )
        }
        pub fn method334(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
        ) -> Array<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method335(
            v0_1: Vec<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Vec<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn closure185(
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
            let v12 = Dice_ui::method326();
            let v13: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method334(v0_1);
            let v15: Vec<(std::string::String, Option<std::string::String>)> = v13.to_vec();
            let v18: Vec<leptos::HtmlElement<leptos::html::Dl>> =
                Dice_ui::method335(v15.iter().map(|x| v12(x.clone())).collect());
            let v20: Array<leptos::HtmlElement<leptos::html::Dl>> =
                fable_library_rust::NativeArray_::array_from(v18);
            let v21 = Dice_ui::method210();
            let v22: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method212(v20);
            let v24: Vec<leptos::HtmlElement<leptos::html::Dl>> = v22.to_vec();
            let v27: Vec<leptos::View> =
                Dice_ui::method196(v24.iter().map(|x| v21(x.clone())).collect());
            let v30: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v27));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method325(
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
                    Dice_ui::closure185(
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
        pub fn method337() -> string {
            string("Deposit")
        }
        pub fn closure192(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method337()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method336() -> Func0<leptos::Fragment> {
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
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(toString(v1))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method338(
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
        pub fn method340() -> string {
            string("Outcome Status")
        }
        pub fn closure194(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method340()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method339() -> Func0<leptos::Fragment> {
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
            let v15: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(ofBoolean(v6))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
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
        pub fn method343() -> string {
            string("Fee")
        }
        pub fn closure196(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method343()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method342() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure196((), ()))
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
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(toString(v7))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
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
        pub fn method346() -> string {
            string("Block Height")
        }
        pub fn closure198(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method346()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method345() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure198((), ()))
        }
        pub fn closure199(
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
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(toString(v2))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
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
                    Dice_ui::closure199(
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
        pub fn method349() -> string {
            string("Hash")
        }
        pub fn closure200(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method349()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method348() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure200((), ()))
        }
        pub fn closure201(
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
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method350(
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
                    Dice_ui::closure201(
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
        pub fn method352() -> string {
            string("Block Hash")
        }
        pub fn closure202(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method352()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method351() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure202((), ()))
        }
        pub fn closure203(
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
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method353(
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
                    Dice_ui::closure203(
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
        pub fn method355() -> string {
            string("Receipt ID")
        }
        pub fn closure204(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method355()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method354() -> Func0<leptos::Fragment> {
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
            let v12: std::string::String = Dice_ui::method52(v9);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method356(
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
        pub fn method358() -> string {
            string("Logs")
        }
        pub fn closure206(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method358()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method357() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure206((), ()))
        }
        pub fn closure208(unitVar: (), v0_1: std::string::String) -> string {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            fable_library_rust::String_::fromString(v1)
        }
        pub fn method360() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Dice_ui::closure208((), v))
        }
        pub fn method361(v0_1: Vec<string>) -> Vec<string> {
            v0_1
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
            let v12 = Dice_ui::method360();
            let v13: Array<std::string::String> = Dice_ui::method11(v5);
            let v15: Vec<std::string::String> = v13.to_vec();
            let v18: Vec<string> = Dice_ui::method361(v15.iter().map(|x| v12(x.clone())).collect());
            let v29: string =
                string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh]\"");
            let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method223(replace(
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
            let v37: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method224(
                leptos::view! {
                    <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh]">
                        {v31()}
                    </pre>
                },
            );
            let v42: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v37),
            ])));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method359(
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
        pub fn closure176(
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
            let v22 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method310(),
                Dice_ui::method312(
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
            let v28: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v22()}
                    </dl>
                },
            );
            let v30: leptos::View = leptos::IntoView::into_view(v28);
            let v36: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v38 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method317(),
                Dice_ui::method319(
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
            let v43: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v38()}
                    </dl>
                },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v51: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v53 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method320(),
                Dice_ui::method322(
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
            let v58: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v53()}
                    </dl>
                },
            );
            let v60: leptos::View = leptos::IntoView::into_view(v58);
            let v67: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]\"");
            let v69 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method323(),
                Dice_ui::method325(
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
            let v74: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]">
                        {v69()}
                    </dl>
                },
            );
            let v76: leptos::View = leptos::IntoView::into_view(v74);
            let v82: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v84 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method336(),
                Dice_ui::method338(
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
            let v89: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v84()}
                    </dl>
                },
            );
            let v91: leptos::View = leptos::IntoView::into_view(v89);
            let v97: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v99 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
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
            let v104: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v99()}
                    </dl>
                },
            );
            let v106: leptos::View = leptos::IntoView::into_view(v104);
            let v112: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v114 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
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
            let v119: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v114()}
                    </dl>
                },
            );
            let v121: leptos::View = leptos::IntoView::into_view(v119);
            let v127: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v129 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
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
            let v134: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v129()}
                    </dl>
                },
            );
            let v136: leptos::View = leptos::IntoView::into_view(v134);
            let v142: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v144 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method348(),
                Dice_ui::method350(
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
            let v149: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v144()}
                    </dl>
                },
            );
            let v151: leptos::View = leptos::IntoView::into_view(v149);
            let v157: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v159 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method351(),
                Dice_ui::method353(
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
            let v164: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v159()}
                    </dl>
                },
            );
            let v166: leptos::View = leptos::IntoView::into_view(v164);
            let v172: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v174 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method354(),
                Dice_ui::method356(
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
            let v179: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v174()}
                    </dl>
                },
            );
            let v208: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
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
                        Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v187.to_vec())
                } else {
                    let v195:
                                                                              string =
                                                                          string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
                    let v197 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                        Dice_ui::method357(),
                        Dice_ui::method359(v0_1, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11),
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
                    let v202: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method211(
                        leptos::view! {
                            <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                                {v197()}
                            </dl>
                        },
                    );
                    leptos::IntoView::into_view(v202)
                },
            ])));
            let v210: Vec<leptos::View> = v208.to_vec();
            leptos::Fragment::new(v210)
        }
        pub fn method309(
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
                    Dice_ui::closure176(
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
        pub fn closure174(
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
            let v20 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method291(
                Dice_ui::method290(Dice_ui::method308(v0_1)),
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
                leptos::view! { <span class="flex items-center pb-[6px]">{v20()}</span> },
            );
            let v28: leptos::View = leptos::IntoView::into_view(v26);
            let v31: string = string(" class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\"");
            let v33 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method309(
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
            let v39: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="grid flex-1 divide-y-[1px] divide-gray-500/[.10]">{v33()}</div> },
            );
            let v44: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v28,
                leptos::IntoView::into_view(v39),
            ])));
            let v46: Vec<leptos::View> = v44.to_vec();
            leptos::Fragment::new(v46)
        }
        pub fn method307(
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
                    Dice_ui::closure174(
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
        pub fn closure173(unitVar: (), _arg: (usize, LrcPtr<Dice_ui::Heap5>)) -> leptos::View {
            let v1: LrcPtr<Dice_ui::Heap5> = _arg.1.clone();
            let v14: i64 = _arg.0.clone() as i64;
            let v16: Option<LrcPtr<Dice_ui::Heap2>> = leptos::use_context::<std::rc::Rc<Heap2>>();
            let v18: LrcPtr<Dice_ui::Heap2> = v16.unwrap();
            let v22: string = string(" class=\"flex flex-1 flex-col overflow-x-auto\"");
            let v24 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method307(
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
            let v30: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="flex flex-1 flex-col overflow-x-auto">{v24()}</div> },
            );
            leptos::IntoView::into_view(v30)
        }
        pub fn method306() -> Func1<(usize, LrcPtr<Dice_ui::Heap5>), leptos::View> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure173((), arg10_0040)
            })
        }
        pub fn method362(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Array<(usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure172(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method306();
            let v2: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method362(v0_1);
            let v4: Vec<(usize, LrcPtr<Dice_ui::Heap5>)> = v2.to_vec();
            let v7: Vec<leptos::View> =
                Dice_ui::method196(v4.iter().map(|x| v1(x.clone())).collect());
            let v10: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v7));
            let v12: Vec<leptos::View> = v10.to_vec();
            leptos::Fragment::new(v12)
        }
        pub fn method305(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure172(v0_1.clone(), ())
            })
        }
        pub fn closure212(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method311()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method366() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure212((), ()))
        }
        pub fn method367(
            v0_1: leptos::HtmlElement<leptos::html::Th>,
        ) -> leptos::HtmlElement<leptos::html::Th> {
            v0_1
        }
        pub fn closure213(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method318()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method368() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure213((), ()))
        }
        pub fn closure214(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method321()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method369() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure214((), ()))
        }
        pub fn method371() -> string {
            string("Action")
        }
        pub fn closure215(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method371()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method370() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure215((), ()))
        }
        pub fn method373() -> string {
            string("Action Method")
        }
        pub fn closure216(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method373()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method372() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure216((), ()))
        }
        pub fn closure217(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method337()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method374() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure217((), ()))
        }
        pub fn closure218(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method343()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method375() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure218((), ()))
        }
        pub fn closure219(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method346()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method376() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure219((), ()))
        }
        pub fn method379(v0_1: Array<std::string::String>, v1: i32) -> bool {
            let v0_1: MutCell<Array<std::string::String>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method379: loop {
                break '_method379 (if v1.get().clone() < count(v0_1.get().clone()) {
                    let v5: std::string::String = Dice_ui::method52(v0_1[v1.get().clone()].clone());
                    if length(fable_library_rust::String_::fromString(v5)) > 0_i32 {
                        true
                    } else {
                        let v0_1_temp: Array<std::string::String> = v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method379;
                    }
                } else {
                    false
                });
            }
        }
        pub fn method378(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>, v1: i32) -> bool {
            let v0_1: MutCell<Array<(usize, LrcPtr<Dice_ui::Heap5>)>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method378: loop {
                break '_method378 (if v1.get().clone() < count(v0_1.get().clone()) {
                    if Dice_ui::method379(
                        ((v0_1[v1.get().clone()].clone()).1.clone()).l5.clone(),
                        0_i32,
                    ) {
                        true
                    } else {
                        let v0_1_temp: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method378;
                    }
                } else {
                    false
                });
            }
        }
        pub fn closure220(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v9: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                if false == Dice_ui::method378(v0_1, 0_i32) {
                    string("")
                } else {
                    string("Logs")
                },
            )));
            let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
            let v13: std::string::String = String::from(v11);
            let v15: leptos::leptos_dom::Text = leptos::html::text(v13);
            let v20: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v15),
            ])));
            let v22: Vec<leptos::View> = v20.to_vec();
            leptos::Fragment::new(v22)
        }
        pub fn method377(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure220(v0_1.clone(), ())
            })
        }
        pub fn closure221(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method340()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method380() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure221((), ()))
        }
        pub fn closure222(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method349()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method381() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure222((), ()))
        }
        pub fn closure223(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method352()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method382() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure223((), ()))
        }
        pub fn closure224(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method355()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method383() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure224((), ()))
        }
        pub fn closure211(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method366()));
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
            let v12: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v6()}
                    </th>
                },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method368()));
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
            let v24: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v19()}
                    </th>
                },
            );
            let v26: leptos::View = leptos::IntoView::into_view(v24);
            let v29: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method369()));
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
            let v36: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v31()}
                    </th>
                },
            );
            let v38: leptos::View = leptos::IntoView::into_view(v36);
            let v41: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v43 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method370()));
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
            let v48: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v43()}
                    </th>
                },
            );
            let v50: leptos::View = leptos::IntoView::into_view(v48);
            let v53: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v55 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method372()));
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
            let v60: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v55()}
                    </th>
                },
            );
            let v62: leptos::View = leptos::IntoView::into_view(v60);
            let v65: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v67 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method374()));
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
            let v72: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v67()}
                    </th>
                },
            );
            let v74: leptos::View = leptos::IntoView::into_view(v72);
            let v77: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v79 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method375()));
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
            let v84: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v79()}
                    </th>
                },
            );
            let v86: leptos::View = leptos::IntoView::into_view(v84);
            let v89: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v91 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method376()));
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
            let v96: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v91()}
                    </th>
                },
            );
            let v98: leptos::View = leptos::IntoView::into_view(v96);
            let v101: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v103 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method377(v0_1)));
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
            let v108: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v103()}
                    </th>
                },
            );
            let v110: leptos::View = leptos::IntoView::into_view(v108);
            let v113: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v115 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method380()));
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
            let v120: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v115()}
                    </th>
                },
            );
            let v122: leptos::View = leptos::IntoView::into_view(v120);
            let v125: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v127 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method381()));
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
            let v132: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v127()}
                    </th>
                },
            );
            let v134: leptos::View = leptos::IntoView::into_view(v132);
            let v137: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v139 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method382()));
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
            let v144: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v139()}
                    </th>
                },
            );
            let v146: leptos::View = leptos::IntoView::into_view(v144);
            let v149: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v151 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method383()));
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
            let v156: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method367(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v151()}
                    </th>
                },
            );
            let v161: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
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
        pub fn method365(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure211(v0_1.clone(), ())
            })
        }
        pub fn method384(
            v0_1: Array<leptos::HtmlElement<leptos::html::Tr>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Tr>> {
            v0_1
        }
        pub fn method386(
            v0_1: leptos::HtmlElement<leptos::html::Tr>,
        ) -> leptos::HtmlElement<leptos::html::Tr> {
            v0_1
        }
        pub fn closure225(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Tr>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Tr> = Dice_ui::method386(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method385() -> Func1<leptos::HtmlElement<leptos::html::Tr>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Tr>| Dice_ui::closure225((), v))
        }
        pub fn method387(
            v0_1: Array<leptos::HtmlElement<leptos::html::Tr>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Tr>> {
            v0_1
        }
        pub fn closure210(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v3 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method365(v0_1)));
            let v7: string = string("leptos::view! { <tr >{v3()}</tr> }");
            let v11: Array<leptos::HtmlElement<leptos::html::Tr>> =
                Dice_ui::method384(new_array(&[leptos::view! { <tr>{v3()}</tr> }]));
            let v12 = Dice_ui::method385();
            let v13: Array<leptos::HtmlElement<leptos::html::Tr>> = Dice_ui::method387(v11);
            let v15: Vec<leptos::HtmlElement<leptos::html::Tr>> = v13.to_vec();
            let v18: Vec<leptos::View> =
                Dice_ui::method196(v15.iter().map(|x| v12(x.clone())).collect());
            let v21: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v18));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method364(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure210(v0_1.clone(), ())
            })
        }
        pub fn method388(
            v0_1: leptos::HtmlElement<leptos::html::Thead>,
        ) -> leptos::HtmlElement<leptos::html::Thead> {
            v0_1
        }
        pub fn closure229(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method313(v0_1.l3.clone());
            let v5: i64 = Dice_ui::method314(v2.parse().unwrap());
            let v10: Dice_ui::US39 = defaultValue(
                Dice_ui::US39::US39_0,
                map(
                    Func1::new(move |v: chrono::DateTime<chrono::Utc>| Dice_ui::closure179((), v)),
                    chrono::DateTime::from_timestamp_micros(v5 / 1000i64),
                ),
            );
            let v29: Dice_ui::US23 = match &v10 {
                Dice_ui::US39::US39_1(v10_1_0) => {
                    let v12: chrono::DateTime<chrono::Utc> = Dice_ui::method315(v10_1_0.clone());
                    let v14: chrono::NaiveDateTime = v12.naive_utc();
                    let v16: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v14);
                    let v18: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v19: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v20: chrono::DateTime<chrono::Local> = Dice_ui::method316(v16);
                    let v23: std::string::String = Dice_ui::method52(v20.format(v19).to_string());
                    Dice_ui::US23::US23_1(fable_library_rust::String_::fromString(v23))
                }
                _ => Dice_ui::US23::US23_0,
            };
            let v35: Dice_ui::US40 = match &v29 {
                Dice_ui::US23::US23_1(v29_1_0) => Dice_ui::US40::US40_1(v29_1_0.clone()),
                _ => Dice_ui::US40::US40_0(string(
                    "resultm.from_option / Option does not have a value.",
                )),
            };
            let v43: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(match &v35 {
                Dice_ui::US40::US40_1(v35_1_0) => v35_1_0.clone(),
                Dice_ui::US40::US40_0(v35_0_0) => {
                    append(append(string("Error: "), v35_0_0.clone()), string(""))
                }
            })));
            let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
            let v47: std::string::String = String::from(v45);
            let v49: leptos::leptos_dom::Text = leptos::html::text(v47);
            let v54: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v49),
            ])));
            let v56: Vec<leptos::View> = v54.to_vec();
            leptos::Fragment::new(v56)
        }
        pub fn method392(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure229(v0_1.clone(), ())
            })
        }
        pub fn method393(
            v0_1: leptos::HtmlElement<leptos::html::Td>,
        ) -> leptos::HtmlElement<leptos::html::Td> {
            v0_1
        }
        pub fn closure230(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l8.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method394(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure230(v0_1.clone(), ())
            })
        }
        pub fn closure231(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l10.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method395(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure231(v0_1.clone(), ())
            })
        }
        pub fn closure233(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method52(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
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
            let v26: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method397(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure233(v0_1.clone(), ())
            })
        }
        pub fn closure234(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v3: Dice_ui::US14 = defaultValue(
                Dice_ui::US14::US14_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure30((), v)),
                    v0_1,
                ),
            );
            let v11: Dice_ui::US23 = match &v3 {
                Dice_ui::US14::US14_1(v3_1_0) => {
                    let v5: std::string::String = Dice_ui::method52(v3_1_0.clone());
                    Dice_ui::US23::US23_1(fable_library_rust::String_::fromString(v5))
                }
                _ => Dice_ui::US23::US23_0,
            };
            let v18: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(match &v11 {
                Dice_ui::US23::US23_1(v11_1_0) => v11_1_0.clone(),
                _ => string("None"),
            })));
            let v20: &str = fable_library_rust::String_::LrcStr::as_str(&v18);
            let v22: std::string::String = String::from(v20);
            let v24: leptos::leptos_dom::Text = leptos::html::text(v22);
            let v29: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v24),
            ])));
            let v31: Vec<leptos::View> = v29.to_vec();
            leptos::Fragment::new(v31)
        }
        pub fn method398(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure234(v0_1.clone(), ())
            })
        }
        pub fn closure232(
            unitVar: (),
            _arg: (std::string::String, Option<std::string::String>),
        ) -> leptos::Fragment {
            let v5: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method397(_arg.0.clone())));
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
            let v13: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v7()}
                    </td>
                },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v20 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method398(_arg.1.clone())));
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
            let v25: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v20()}
                    </td>
                },
            );
            let v30: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v15,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method396(
        ) -> Func1<(std::string::String, Option<std::string::String>), leptos::Fragment> {
            Func1::new(
                move |arg10_0040: (std::string::String, Option<std::string::String>)| {
                    Dice_ui::closure232((), arg10_0040)
                },
            )
        }
        pub fn method399(v0_1: Vec<leptos::Fragment>) -> Vec<leptos::Fragment> {
            v0_1
        }
        pub fn method401(v0_1: leptos::Fragment) -> leptos::Fragment {
            v0_1
        }
        pub fn closure235(unitVar: (), v0_1: leptos::Fragment) -> leptos::View {
            let v1: leptos::Fragment = Dice_ui::method401(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method400() -> Func1<leptos::Fragment, leptos::View> {
            Func1::new(move |v: leptos::Fragment| Dice_ui::closure235((), v))
        }
        pub fn method402(v0_1: Array<leptos::Fragment>) -> Array<leptos::Fragment> {
            v0_1
        }
        pub fn closure236(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(toString(v0_1.l1))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method403(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure236(v0_1.clone(), ())
            })
        }
        pub fn closure237(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(toString(v0_1.l7))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method404(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure237(v0_1.clone(), ())
            })
        }
        pub fn closure238(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(toString(v0_1.l2))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method405(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure238(v0_1.clone(), ())
            })
        }
        pub fn method407() -> string {
            string("")
        }
        pub fn closure239(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v1: Array<std::string::String> = v0_1.l5.clone();
            if count(v1.clone()) as u64 == 0_u64 {
                let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method407()));
                let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
                let v10: std::string::String = String::from(v8);
                let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
                let v17: Array<leptos::View> =
                    Dice_ui::method140(Dice_ui::method139(new_array(&[
                        leptos::IntoView::into_view(v12),
                    ])));
                let v19: Vec<leptos::View> = v17.to_vec();
                leptos::Fragment::new(v19)
            } else {
                let v22 = Dice_ui::method360();
                let v23: Array<std::string::String> = Dice_ui::method11(v1);
                let v25: Vec<std::string::String> = v23.to_vec();
                let v28: Vec<string> =
                    Dice_ui::method361(v25.iter().map(|x| v22(x.clone())).collect());
                let v39: string =
                    string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh] [max-width:100vw]\"");
                let v41 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method223(replace(
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
                let v47: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method224(
                    leptos::view! {
                        <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh] [max-width:100vw]">
                            {v41()}
                        </pre>
                    },
                );
                let v52: Array<leptos::View> =
                    Dice_ui::method140(Dice_ui::method139(new_array(&[
                        leptos::IntoView::into_view(v47),
                    ])));
                let v54: Vec<leptos::View> = v52.to_vec();
                leptos::Fragment::new(v54)
            }
        }
        pub fn method406(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure239(v0_1.clone(), ())
            })
        }
        pub fn closure240(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(ofBoolean(v0_1.l6))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method408(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure240(v0_1.clone(), ())
            })
        }
        pub fn closure241(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l11.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method409(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure241(v0_1.clone(), ())
            })
        }
        pub fn closure242(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l4.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method410(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure242(v0_1.clone(), ())
            })
        }
        pub fn closure243(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method52(v0_1.l9.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method411(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure243(v0_1.clone(), ())
            })
        }
        pub fn closure228(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v4: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method392(v0_1.clone())));
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
            let v12: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v6()}
                    </td>
                },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method394(v0_1.clone())));
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
            let v24: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v19()}
                    </td>
                },
            );
            let v26: leptos::View = leptos::IntoView::into_view(v24);
            let v29: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v31 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method395(v0_1.clone())));
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
            let v36: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v31()}
                    </td>
                },
            );
            let v38: leptos::View = leptos::IntoView::into_view(v36);
            let v40 = Dice_ui::method396();
            let v41: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method334(v0_1.l0.clone());
            let v43: Vec<(std::string::String, Option<std::string::String>)> = v41.to_vec();
            let v46: Vec<leptos::Fragment> =
                Dice_ui::method399(v43.iter().map(|x| v40(x.clone())).collect());
            let v48: Array<leptos::Fragment> = fable_library_rust::NativeArray_::array_from(v46);
            let v49 = Dice_ui::method400();
            let v50: Array<leptos::Fragment> = Dice_ui::method402(v48);
            let v52: Vec<leptos::Fragment> = v50.to_vec();
            let v55: Vec<leptos::View> =
                Dice_ui::method196(v52.iter().map(|x| v49(x.clone())).collect());
            let v58: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v55));
            let v60: Vec<leptos::View> = v58.to_vec();
            let v63: leptos::Fragment = Dice_ui::method401(leptos::Fragment::new(v60));
            let v65: leptos::View = leptos::IntoView::into_view(v63);
            let v68: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v70 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method403(v0_1.clone())));
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
            let v75: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v70()}
                    </td>
                },
            );
            let v77: leptos::View = leptos::IntoView::into_view(v75);
            let v80: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v82 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method404(v0_1.clone())));
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
            let v87: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v82()}
                    </td>
                },
            );
            let v89: leptos::View = leptos::IntoView::into_view(v87);
            let v92: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v94 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method405(v0_1.clone())));
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
            let v99: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v94()}
                    </td>
                },
            );
            let v101: leptos::View = leptos::IntoView::into_view(v99);
            let v104: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]\"");
            let v106 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method406(v0_1.clone())));
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
            let v111: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]">
                        {v106()}
                    </td>
                },
            );
            let v113: leptos::View = leptos::IntoView::into_view(v111);
            let v116: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v118 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method408(v0_1.clone())));
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
            let v123: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v118()}
                    </td>
                },
            );
            let v125: leptos::View = leptos::IntoView::into_view(v123);
            let v128: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v130 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method409(v0_1.clone())));
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
            let v135: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v130()}
                    </td>
                },
            );
            let v137: leptos::View = leptos::IntoView::into_view(v135);
            let v140: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v142 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method410(v0_1.clone())));
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
            let v147: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v142()}
                    </td>
                },
            );
            let v149: leptos::View = leptos::IntoView::into_view(v147);
            let v152: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v154 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method411(v0_1)));
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
            let v159: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method393(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v154()}
                    </td>
                },
            );
            let v164: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
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
        pub fn method391(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure228(v0_1.clone(), ())
            })
        }
        pub fn closure227(unitVar: (), _arg: (usize, LrcPtr<Dice_ui::Heap5>)) -> leptos::View {
            let v5: string = string(" class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method391(_arg.1.clone())));
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
            let v13: leptos::HtmlElement<leptos::html::Tr> = Dice_ui::method386(
                leptos::view! { <tr class="odd:bg-gray-50 dark:odd:bg-gray-800/50">{v7()}</tr> },
            );
            leptos::IntoView::into_view(v13)
        }
        pub fn method390() -> Func1<(usize, LrcPtr<Dice_ui::Heap5>), leptos::View> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure227((), arg10_0040)
            })
        }
        pub fn closure226(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method390();
            let v2: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method362(v0_1);
            let v4: Vec<(usize, LrcPtr<Dice_ui::Heap5>)> = v2.to_vec();
            let v7: Vec<leptos::View> =
                Dice_ui::method196(v4.iter().map(|x| v1(x.clone())).collect());
            let v10: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v7));
            let v12: Vec<leptos::View> = v10.to_vec();
            leptos::Fragment::new(v12)
        }
        pub fn method389(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure226(v0_1.clone(), ())
            })
        }
        pub fn method412(
            v0_1: leptos::HtmlElement<leptos::html::Tbody>,
        ) -> leptos::HtmlElement<leptos::html::Tbody> {
            v0_1
        }
        pub fn closure209(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"ltr:text-left rtl:text-right\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method364(v0_1.clone())));
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
            let v12: leptos::HtmlElement<leptos::html::Thead> = Dice_ui::method388(
                leptos::view! { <thead class="ltr:text-left rtl:text-right">{v6()}</thead> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"divide-y divide-gray-200 dark:divide-gray-700\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method389(v0_1)));
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
            let v25: leptos::HtmlElement<leptos::html::Tbody> = Dice_ui::method412(
                leptos::view! { <tbody class="divide-y divide-gray-200 dark:divide-gray-700">{v19()}</tbody> },
            );
            let v30: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method363(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure209(v0_1.clone(), ())
            })
        }
        pub fn method413(
            v0_1: leptos::HtmlElement<leptos::html::Table>,
        ) -> leptos::HtmlElement<leptos::html::Table> {
            v0_1
        }
        pub fn closure245(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string =
                string("<svg version=\"1.1\" id=\"Layer_1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" x=\"0px\" y=\"0px\" width=\"24px\" height=\"30px\" viewBox=\"0 0 24 30\" style=\"enable-background:new 0 0 50 50;\" xml:space=\"preserve\"><rect x=\"0\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\" opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"8\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"16\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect></svg>");
            let v1: string = append(append(string("leptos::view! { "), v0_1), string(" }"));
            let v4: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method138(
                leptos::view! {
                    <svg
                        version="1.1"
                        id="Layer_1"
                        xmlns="http://www.w3.org/2000/svg"
                        xmlns:xlink="http://www.w3.org/1999/xlink"
                        x="0px"
                        y="0px"
                        width="24px"
                        height="30px"
                        viewBox="0 0 24 30"
                        style="enable-background:new 0 0 50 50;"
                        xml:space="preserve"
                    >
                        <rect x="0" y="10" width="4" height="10" fill="#333" opacity="0.2">
                            <animate
                                attributeName="opacity"
                                attributeType="XML"
                                values="0.2; 1; .2"
                                begin="0s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                            <animate
                                attributeName="height"
                                attributeType="XML"
                                values="10; 20; 10"
                                begin="0s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                            <animate
                                attributeName="y"
                                attributeType="XML"
                                values="10; 5; 10"
                                begin="0s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                        </rect>
                        <rect x="8" y="10" width="4" height="10" fill="#333" opacity="0.2">
                            <animate
                                attributeName="opacity"
                                attributeType="XML"
                                values="0.2; 1; .2"
                                begin="0.15s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                            <animate
                                attributeName="height"
                                attributeType="XML"
                                values="10; 20; 10"
                                begin="0.15s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                            <animate
                                attributeName="y"
                                attributeType="XML"
                                values="10; 5; 10"
                                begin="0.15s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                        </rect>
                        <rect x="16" y="10" width="4" height="10" fill="#333" opacity="0.2">
                            <animate
                                attributeName="opacity"
                                attributeType="XML"
                                values="0.2; 1; .2"
                                begin="0.3s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                            <animate
                                attributeName="height"
                                attributeType="XML"
                                values="10; 20; 10"
                                begin="0.3s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                            <animate
                                attributeName="y"
                                attributeType="XML"
                                values="10; 5; 10"
                                begin="0.3s"
                                dur="0.6s"
                                repeatCount="indefinite"
                            ></animate>
                        </rect>
                    </svg>
                },
            );
            let v6: leptos::View = leptos::IntoView::into_view(v4);
            let v10: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method177(string("Loading..."))));
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v14: std::string::String = String::from(v12);
            let v16: leptos::leptos_dom::Text = leptos::html::text(v14);
            let v21: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v6,
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method415() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure245((), ()))
        }
        pub fn closure244(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [gap:4px] items-center\"");
            let v5 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method415()));
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="flex flex-1 [gap:4px] items-center">{v5()}</div> },
            );
            let v16: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method414() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure244((), ()))
        }
        pub fn closure153(
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
                let v11 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method287(v0_1.clone())));
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
                let v17: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                    leptos::view! { <div class="px-[12px] py-[10px]">{v11()}</div> },
                );
                leptos::IntoView::into_view(v17)
            } else {
                let v23: Array<leptos::View> =
                    Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(new_empty::<
                        leptos::View,
                    >(
                    ))));
                leptos::CollectView::collect_view(v23.to_vec())
            };
            let v27: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            > = Dice_ui::method301(v1);
            let v29: Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String> =
                v27();
            let v32: Dice_ui::US38 = match &v29 {
                Err(v29_1_0) => Dice_ui::closure167((), v29_1_0.clone()),
                Ok(v29_0_0) => Dice_ui::closure166((), v29_0_0.clone()),
            };
            let v41: Dice_ui::US35 = match &v32 {
                Dice_ui::US38::US38_1(v32_1_0) => Dice_ui::US35::US35_1(defaultValue(
                    Dice_ui::US36::US36_0,
                    map(
                        Func1::new(move |v_2: Array<(usize, LrcPtr<Dice_ui::Heap5>)>| {
                            Dice_ui::closure168((), v_2)
                        }),
                        v32_1_0.clone(),
                    ),
                )),
                Dice_ui::US38::US38_0(v32_0_0) => Dice_ui::US35::US35_0(v32_0_0.clone()),
            };
            let v118: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v26,
                match &v41 {
                    Dice_ui::US35::US35_1(v41_1_0) => {
                        let v42: Dice_ui::US36 = v41_1_0.clone();
                        if let Dice_ui::US36::US36_1(v42_1_0) = &v42 {
                            let v43: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = match &v42 {
                                Dice_ui::US36::US36_1(x) => x.clone(),
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
                                    Dice_ui::method305(v43.clone()),
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
                                    Dice_ui::method169(
                                        leptos::view! {
                                            <div class="grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]">
                                                {v60()}
                                            </div>
                                        },
                                    );
                                leptos::IntoView::into_view(v66)
                            } else {
                                let v72:
                                                                                          string =
                                                                                      string(" class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\"");
                                let v74 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method363(v43)));
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
                                    Dice_ui::method413(
                                        leptos::view! {
                                            <table class="flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700">
                                                {v74()}
                                            </table>
                                        },
                                    );
                                leptos::IntoView::into_view(v80)
                            }
                        } else {
                            let v87: string =
                                string(" class=\"grid place-content-center py-[10vh]\"");
                            let v89 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method414()));
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
                            let v95: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                                leptos::view! { <div class="grid place-content-center py-[10vh]">{v89()}</div> },
                            );
                            leptos::IntoView::into_view(v95)
                        }
                    }
                    Dice_ui::US35::US35_0(v41_0_0) => {
                        let v103: string = string(" class=\"flex flex-1 [gap:4px] [padding:5px]\"");
                        let v105 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method302(
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
                        let v111: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                            leptos::view! { <div class="flex flex-1 [gap:4px] [padding:5px]">{v105()}</div> },
                        );
                        leptos::IntoView::into_view(v111)
                    }
                },
            ])));
            let v120: Vec<leptos::View> = v118.to_vec();
            leptos::Fragment::new(v120)
        }
        pub fn method286(
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
                move || Dice_ui::closure153(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method418() -> string {
            string("Transactions")
        }
        pub fn closure247(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method418()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method417() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure247((), ()))
        }
        pub fn closure248(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            > = Dice_ui::method301(v0_1);
            let v3: Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String> =
                v1();
            let v6: std::string::String = Dice_ui::method52(format!("{:#?}", &v3));
            let v13: string =
                string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:70vh]\"");
            let v15 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method223(
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
            let v21: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method224(
                leptos::view! {
                    <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:70vh]">
                        {v15()}
                    </pre>
                },
            );
            let v26: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method419(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure248(v0_1.clone(), ())
            })
        }
        pub fn closure246(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            unitVar: (),
        ) -> leptos::Fragment {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] \"");
            let v11 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method199(
                Dice_ui::method417(),
                Dice_ui::method419(v0_1),
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
            let v18: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method209(new_array(
                &[
                    leptos::view! {
                        <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] ">
                            {v11()}
                        </dl>
                    },
                ],
            ));
            let v19 = Dice_ui::method210();
            let v20: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method212(v18);
            let v22: Vec<leptos::HtmlElement<leptos::html::Dl>> = v20.to_vec();
            let v25: Vec<leptos::View> =
                Dice_ui::method196(v22.iter().map(|x| v19(x.clone())).collect());
            let v28: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v25));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method416(
            v0_1: leptos::Memo<
                Result<Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure246(v0_1.clone(), ())
            })
        }
        pub fn closure119(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("transactions.render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6: LrcPtr<Dice_ui::Heap2> = v4.unwrap();
                let v7 = Dice_ui::method226();
                let v9: leptos::Memo<Option<string>> = leptos::create_memo(move |_| v7());
                let v11: string = Dice_ui::method0(string("state_core.use_request (1)"));
                leptos::logging::log!("{}", v11);
                {
                    let v13 = Dice_ui::method227(v9.clone());
                    let v16: leptos::Resource<Option<string>, Result<Option<string>, string>> =
                        leptos::create_local_resource(
                            move || v13(),
                            |x| async move {
                                Func1::new(move |v: Option<string>| Dice_ui::closure122((), v))(x)
                                    .await
                            },
                        );
                    let v18: string = Dice_ui::method0(string("state_core.use_database (1)"));
                    leptos::logging::log!("{}", v18);
                    {
                        let v20 = Dice_ui::method20();
                        let v23: leptos::Resource<Dice_ui::US2, rexie::Rexie> =
                            leptos::create_local_resource(
                                move || v20(),
                                |x| async move {
                                    Func1::new(move |v_1: Dice_ui::US2| Dice_ui::closure7((), v_1))(
                                        x,
                                    )
                                    .await
                                },
                            );
                        let v24 = Dice_ui::method233(v23.clone());
                        let v26: leptos::Memo<Option<rexie::Rexie>> =
                            leptos::create_memo(move |_| v24());
                        let v27 = Dice_ui::method234(v9.clone(), v23.clone());
                        let v30: leptos::Resource<
                            (Option<rexie::Rexie>, Option<string>),
                            Option<LrcPtr<Dice_ui::Heap4>>,
                        > = leptos::create_resource(
                            move || v27(),
                            |x| async move {
                                Func1::new(
                                    move |arg10_0040: (Option<rexie::Rexie>, Option<string>)| {
                                        Dice_ui::closure127((), arg10_0040)
                                    },
                                )(x)
                                .await
                            },
                        );
                        let v31 = Dice_ui::method237(v30.clone());
                        let v33: Func0<Option<LrcPtr<Dice_ui::Heap4>>> = Func0::new(move || v31());
                        let v34 = Dice_ui::method239(v9.clone(), v26);
                        let v37 = Dice_ui::method242(
                            v16.clone(),
                            leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                v34(value.clone())
                            }),
                        );
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method245(v9, v16, v33);
                            let v42 = Dice_ui::method250(v23, v30, Func0::new(move || v39()));
                            let v45 = Dice_ui::method273(Func0::new(move || v42()));
                            let v47: leptos::Memo<
                                Result<
                                    Option<Array<(usize, LrcPtr<Dice_ui::Heap5>)>>,
                                    std::string::String,
                                >,
                            > = leptos::create_memo(move |_| v45());
                            let v48: bool = Dice_ui::method66();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v48);
                            let v50: leptos::ReadSignal<bool> = patternInput.0.clone();
                            let v52 = Dice_ui::method283(patternInput.1.clone());
                            let on_click = v52;
                            {
                                let v54: string =
                                    string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"/><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\"/></svg>");
                                let v55: string =
                                    append(append(string("leptos::view! { "), v54), string(" }"));
                                let v57: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                                    <svg
                                        xmlns="http://www.w3.org/2000/svg"
                                        fill="none"
                                        viewBox="0 0 24 24"
                                        stroke-width="1.5"
                                        stroke="currentColor"
                                        class="h-5 w-5"
                                    >
                                        <path
                                            stroke-linecap="round"
                                            stroke-linejoin="round"
                                            d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"
                                        ></path>
                                        <path
                                            stroke-linecap="round"
                                            stroke-linejoin="round"
                                            d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"
                                        ></path>
                                    </svg>
                                };
                                let v60 = Dice_ui::method284(v50.clone());
                                let v61: string =
                                    string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] pr-[11px] pl-[11px]\".to_owned() + v60()}");
                                let v66: string = append(
                                    append(
                                        string(" aria-label=\"Settings\""),
                                        append(
                                            append(
                                                string(" on:click=move |_| on_click()"),
                                                append(
                                                    append(append(string(" "), v61), string("")),
                                                    string(""),
                                                ),
                                            ),
                                            string(""),
                                        ),
                                    ),
                                    string(""),
                                );
                                let v68 =
                                    Dice_ui::method142(Dice_ui::method141(Dice_ui::method137(v57)));
                                let v71: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<button "), v66),
                                                    string(">{v68()}</"),
                                                ),
                                                string("button"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v74: leptos::HtmlElement<leptos::html::Button> =
                                    Dice_ui::method145(
                                        leptos::view! {
                                            <button
                                                aria-label="Settings"
                                                on:click=move |_| on_click()
                                                class=move || {
                                                    "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] pr-[11px] pl-[11px]"
                                                        .to_owned() + v60()
                                                }
                                            >
                                                {v68()}
                                            </button>
                                        },
                                    );
                                let v76: leptos::View = leptos::IntoView::into_view(v74);
                                let v78: string = Dice_ui::method6(Dice_ui::method285());
                                let v80: &str = fable_library_rust::String_::LrcStr::as_str(&v78);
                                let v82: std::string::String = String::from(v80);
                                let v86: Array<leptos::View> =
                                    Dice_ui::method148(Dice_ui::method147(Dice_ui::method139(
                                        new_empty::<leptos::View>(),
                                    )));
                                let v88: leptos::View =
                                    leptos::CollectView::collect_view(v86.to_vec());
                                let v91: string =
                                    string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                                let v92: string =
                                    append(append(string("leptos::view! { "), v91), string(" }"));
                                let v97: string =
                                    string(" class=\"flex flex-col [position:relative]\"");
                                let v99 = Dice_ui::method142(Dice_ui::method141(
                                    Dice_ui::method171(
                                        v76,
                                        v82,
                                        Dice_ui::method170(Dice_ui::method286(
                                            v6.clone(),
                                            v47.clone(),
                                            v50,
                                        )),
                                        leptos::view! {
                                            <svg
                                                xmlns="http://www.w3.org/2000/svg"
                                                class="h-5 w-5"
                                                viewBox="0 0 20 20"
                                                fill="currentColor"
                                            >
                                                <path
                                                    fill-rule="evenodd"
                                                    d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                                                    clip-rule="evenodd"
                                                ></path>
                                            </svg>
                                        },
                                    ),
                                ));
                                let v102: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v97),
                                                    string(">{v99()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v105: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method169(
                                        leptos::view! { <div class="flex flex-col [position:relative]">{v99()}</div> },
                                    );
                                let v107: leptos::View = leptos::IntoView::into_view(v105);
                                let v109: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                    Dice_ui::method55(v6.l0.clone());
                                let v113: leptos::RwSignal<bool> = Dice_ui::method73(
                                    (leptos::SignalGetUntracked::get_untracked(&v109))
                                        .l2
                                        .clone(),
                                );
                                let v155: Array<leptos::View> = Dice_ui::method140(
                                    Dice_ui::method139(new_array(&[
                                        v107,
                                        if leptos::SignalGet::get(&v113) {
                                            let v117: string =
                                                Dice_ui::method6(Dice_ui::method215());
                                            let v119: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v117);
                                            let v121: std::string::String = String::from(v119);
                                            let v125: Array<leptos::View> =
                                                Dice_ui::method148(Dice_ui::method147(
                                                    Dice_ui::method139(new_empty::<leptos::View>()),
                                                ));
                                            let v130:
                                                                                                  string =
                                                                                              string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                                            let v131: string = append(
                                                append(string("leptos::view! { "), v130),
                                                string(" }"),
                                            );
                                            let v136: string = string(
                                                " class=\"flex flex-col [position:relative]\"",
                                            );
                                            let v138 = Dice_ui::method142(Dice_ui::method141(
                                                Dice_ui::method213(
                                                    v121,
                                                    leptos::CollectView::collect_view(
                                                        v125.to_vec(),
                                                    ),
                                                    Dice_ui::method170(Dice_ui::method416(v47)),
                                                    leptos::view! {
                                                        <svg
                                                            xmlns="http://www.w3.org/2000/svg"
                                                            class="h-5 w-5"
                                                            viewBox="0 0 20 20"
                                                            fill="currentColor"
                                                        >
                                                            <path
                                                                fill-rule="evenodd"
                                                                d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                                                                clip-rule="evenodd"
                                                            ></path>
                                                        </svg>
                                                    },
                                                ),
                                            ));
                                            let v140: string = append(
                                                append(
                                                    string("leptos::view! { "),
                                                    append(
                                                        append(
                                                            append(
                                                                append(string("<div "), v136),
                                                                string(">{v138()}</"),
                                                            ),
                                                            string("div"),
                                                        ),
                                                        string(">"),
                                                    ),
                                                ),
                                                string(" }"),
                                            );
                                            let v143: leptos::HtmlElement<leptos::html::Div> =
                                                Dice_ui::method169(
                                                    leptos::view! { <div class="flex flex-col [position:relative]">{v138()}</div> },
                                                );
                                            leptos::IntoView::into_view(v143)
                                        } else {
                                            let v149: Array<leptos::View> =
                                                Dice_ui::method148(Dice_ui::method147(
                                                    Dice_ui::method139(new_empty::<leptos::View>()),
                                                ));
                                            leptos::CollectView::collect_view(v149.to_vec())
                                        },
                                    ])),
                                );
                                let v157: Vec<leptos::View> = v155.to_vec();
                                leptos::Fragment::new(v157)
                            }
                        }
                    }
                }
            }
        }
        pub fn method225() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure119((), ()))
        }
        pub fn closure53(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> leptos::Fragment {
            let v1: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method109(v0_1);
            let v3: Dice_ui::US19 = leptos::SignalGet::get(&v1);
            let v42: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                match &v3 {
                    Dice_ui::US19::US19_2 => {
                        let v21: string =
                            string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                        let v23 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method110()));
                        let v26: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v21), string(">{v23()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v29: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                            leptos::view! { <div class="flex flex-1 flex-col [overflow-y:auto]">{v23()}</div> },
                        );
                        leptos::IntoView::into_view(v29)
                    }
                    Dice_ui::US19::US19_3 => {
                        let v7: string =
                            string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                        let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method225()));
                        let v12: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v7), string(">{v9()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v15: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                            leptos::view! { <div class="flex flex-1 flex-col [overflow-y:auto]">{v9()}</div> },
                        );
                        leptos::IntoView::into_view(v15)
                    }
                    _ => {
                        let v35: Array<leptos::View> = Dice_ui::method148(Dice_ui::method147(
                            Dice_ui::method139(new_empty::<leptos::View>()),
                        ));
                        leptos::CollectView::collect_view(v35.to_vec())
                    }
                },
            ])));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method108(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure53(v0_1.clone(), ())
            })
        }
        pub fn method420(
            v0_1: leptos::HtmlElement<leptos::html::Main>,
        ) -> leptos::HtmlElement<leptos::html::Main> {
            v0_1
        }
        pub fn method424() -> string {
            string("Tab")
        }
        pub fn closure251(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method424()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method423() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure251((), ()))
        }
        pub fn closure253(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method109(v0_1);
            if let Dice_ui::US19::US19_3 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method426(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure253(v0_1.clone(), ())
            })
        }
        pub fn closure254(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method418()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method427() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure254((), ()))
        }
        pub fn closure255(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method109(v0_1);
            if let Dice_ui::US19::US19_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method428(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure255(v0_1.clone(), ())
            })
        }
        pub fn closure256(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method289()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method429() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure256((), ()))
        }
        pub fn method430(
            v0_1: Array<leptos::HtmlElement<leptos::html::Option_>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Option_>> {
            v0_1
        }
        pub fn method432(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure257(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Option_> = Dice_ui::method432(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method431() -> Func1<leptos::HtmlElement<leptos::html::Option_>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Option_>| {
                Dice_ui::closure257((), v)
            })
        }
        pub fn method433(
            v0_1: Array<leptos::HtmlElement<leptos::html::Option_>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Option_>> {
            v0_1
        }
        pub fn closure252(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method426(v0_1.clone());
            let v5: string = string(" select=v1()");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method427()));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v5), string(">{v7()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Option_> =
                leptos::view! { <option select=v1()>{v7()}</option> };
            let v13 = Dice_ui::method428(v0_1);
            let v16: string = string(" select=v13()");
            let v18 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method429()));
            let v20: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v16), string(">{v18()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: Array<leptos::HtmlElement<leptos::html::Option_>> =
                Dice_ui::method430(new_array(&[
                    v12,
                    leptos::view! { <option select=v13()>{v18()}</option> },
                ]));
            let v25 = Dice_ui::method431();
            let v26: Array<leptos::HtmlElement<leptos::html::Option_>> = Dice_ui::method433(v24);
            let v28: Vec<leptos::HtmlElement<leptos::html::Option_>> = v26.to_vec();
            let v31: Vec<leptos::View> =
                Dice_ui::method196(v28.iter().map(|x| v25(x.clone())).collect());
            let v34: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v31));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method425(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure252(v0_1.clone(), ())
            })
        }
        pub fn method434(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure250(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v8 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method423()));
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
            let v14: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method198(
                leptos::view! {
                    <label class="sr-only" for="Tab">
                        {v8()}
                    </label>
                },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v23 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method425(v0_1)));
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
            let v29: leptos::HtmlElement<leptos::html::Select> = Dice_ui::method434(
                leptos::view! {
                    <select class="w-full rounded-md border-gray-200" id="Tab">
                        {v23()}
                    </select>
                },
            );
            let v34: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method422(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure250(v0_1.clone(), ())
            })
        }
        pub fn closure261(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method109(v0_1);
            if let Dice_ui::US19::US19_3 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method438(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure261(v0_1.clone(), ())
            })
        }
        pub fn method439(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure262(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method440(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure262(v0_1.clone(), ())
            })
        }
        pub fn closure263(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method138(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method418()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v3,
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method441(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure263(v0_1.clone(), ())
            })
        }
        pub fn closure264(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US19> = Dice_ui::method109(v0_1);
            if let Dice_ui::US19::US19_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method442(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure264(v0_1.clone(), ())
            })
        }
        pub fn closure265(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method138(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method289()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v3,
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method443(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure265(v0_1.clone(), ())
            })
        }
        pub fn method444(
            v0_1: Array<leptos::HtmlElement<leptos::html::A>>,
        ) -> Array<leptos::HtmlElement<leptos::html::A>> {
            v0_1
        }
        pub fn method446(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure266(unitVar: (), v0_1: leptos::HtmlElement<leptos::html::A>) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::A> = Dice_ui::method446(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method445() -> Func1<leptos::HtmlElement<leptos::html::A>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::A>| Dice_ui::closure266((), v))
        }
        pub fn method447(
            v0_1: Array<leptos::HtmlElement<leptos::html::A>>,
        ) -> Array<leptos::HtmlElement<leptos::html::A>> {
            v0_1
        }
        pub fn closure260(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = append(v1.clone(), string("#/transactions"));
            let v3: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z\"/></svg>");
            let v4: string = append(append(string("leptos::view! { "), v3), string(" }"));
            let v6: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                <svg
                    xmlns="http://www.w3.org/2000/svg"
                    fill="none"
                    viewBox="0 0 24 24"
                    stroke-width="1.5"
                    stroke="currentColor"
                    class="h-5 w-5"
                >
                    <path
                        stroke-linecap="round"
                        stroke-linejoin="round"
                        d="M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z"
                    ></path>
                </svg>
            };
            let v8: string = Dice_ui::method6(Dice_ui::method18(v2));
            let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
            let v12: std::string::String = String::from(v10);
            let v13 = Dice_ui::method438(v0_1.clone());
            let v14 = Dice_ui::method439(v13.clone());
            let v15 = Dice_ui::method440(v13);
            let v17: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium \".to_owned() + v15()}");
            let v23: string = append(
                append(
                    string(" aria-current={move || if v14() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v17), string(" href=v12")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v25 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method441(v6)));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v23), string(">{v25()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v30: leptos::HtmlElement<leptos::html::A> = leptos::view! {
                <a
                    aria-current=move || if v14() { "page" } else { "" }
                    class=move || {
                        "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium "
                            .to_owned() + v15()
                    }
                    href=v12
                >
                    {v25()}
                </a>
            };
            let v31: string = append(v1, string("#/settings"));
            let v32: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"/><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\"/></svg>");
            let v33: string = append(append(string("leptos::view! { "), v32), string(" }"));
            let v35: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                <svg
                    xmlns="http://www.w3.org/2000/svg"
                    fill="none"
                    viewBox="0 0 24 24"
                    stroke-width="1.5"
                    stroke="currentColor"
                    class="h-5 w-5"
                >
                    <path
                        stroke-linecap="round"
                        stroke-linejoin="round"
                        d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"
                    ></path>
                    <path
                        stroke-linecap="round"
                        stroke-linejoin="round"
                        d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"
                    ></path>
                </svg>
            };
            let v37: string = Dice_ui::method6(Dice_ui::method18(v31));
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v41: std::string::String = String::from(v39);
            let v42 = Dice_ui::method442(v0_1);
            let v43 = Dice_ui::method439(v42.clone());
            let v44 = Dice_ui::method440(v42);
            let v46: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium \".to_owned() + v44()}");
            let v51: string = append(
                append(
                    string(" aria-current={move || if v43() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v46), string(" href=v41")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v53 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method443(v35)));
            let v55: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v51), string(">{v53()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v59: Array<leptos::HtmlElement<leptos::html::A>> = Dice_ui::method444(new_array(
                &[
                    v30,
                    leptos::view! {
                        <a
                            aria-current=move || if v43() { "page" } else { "" }
                            class=move || {
                                "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium "
                                    .to_owned() + v44()
                            }
                            href=v41
                        >
                            {v53()}
                        </a>
                    },
                ],
            ));
            let v60 = Dice_ui::method445();
            let v61: Array<leptos::HtmlElement<leptos::html::A>> = Dice_ui::method447(v59);
            let v63: Vec<leptos::HtmlElement<leptos::html::A>> = v61.to_vec();
            let v66: Vec<leptos::View> =
                Dice_ui::method196(v63.iter().map(|x| v60(x.clone())).collect());
            let v69: Array<leptos::View> =
                Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v66));
            let v71: Vec<leptos::View> = v69.to_vec();
            leptos::Fragment::new(v71)
        }
        pub fn method437(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure260(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method448(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure259(
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
            let v9 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method437(v0_1, v1)));
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
            let v15: leptos::HtmlElement<leptos::html::Nav> = Dice_ui::method448(
                leptos::view! {
                    <nav
                        aria-label="Tabs"
                        class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]"
                    >
                        {v9()}
                    </nav>
                },
            );
            let v20: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v15),
            ])));
            let v22: Vec<leptos::View> = v20.to_vec();
            leptos::Fragment::new(v22)
        }
        pub fn method436(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure259(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure258(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v7 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method436(v0_1, v1)));
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
            let v13: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! { <div class="flex flex-1 border-t border-gray-200">{v7()}</div> },
            );
            let v18: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method435(
            v0_1: leptos::ReadSignal<Dice_ui::US19>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure258(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method449(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure267(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method450() -> Func1<leptos::HtmlElement<leptos::html::Div>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Div>| Dice_ui::closure267((), v))
        }
        pub fn method451(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure249(
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
                let v35 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method422(v0_1.clone())));
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
                    leptos::view! { <div class="hidden">{v35()}</div> };
                let v43: string =
                    string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
                let v45 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method435(v0_1, v29)));
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
                let v51: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method449(
                    new_array(&[
                        v40,
                        leptos::view! { <div class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v45()}</div> },
                    ]),
                );
                let v52 = Dice_ui::method450();
                let v53: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method451(v51);
                let v55: Vec<leptos::HtmlElement<leptos::html::Div>> = v53.to_vec();
                let v58: Vec<leptos::View> =
                    Dice_ui::method196(v55.iter().map(|x| v52(x.clone())).collect());
                let v61: Array<leptos::View> =
                    Dice_ui::method140(fable_library_rust::NativeArray_::array_from(v58));
                let v63: Vec<leptos::View> = v61.to_vec();
                leptos::Fragment::new(v63)
            }
        }
        pub fn method421(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure249(v0_1.clone(), ())
            })
        }
        pub fn closure52(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col [overflow:hidden]\"");
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method108(v0_1.clone())));
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
            let v12: leptos::HtmlElement<leptos::html::Main> = Dice_ui::method420(
                leptos::view! { <main class="flex flex-1 flex-col [overflow:hidden]">{v6()}</main> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"flex\"");
            let v19 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method421(v0_1)));
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
                Dice_ui::method169(leptos::view! { <div class="flex">{v19()}</div> });
            let v30: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method107(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure52(v0_1.clone(), ())
            })
        }
        pub fn closure51(v0_1: leptos::ReadSignal<Dice_ui::US19>, unitVar: ()) -> leptos::Fragment {
            let v1: string =
                string("class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\"");
            let v4: string = append(append(append(string(" "), v1), string("")), string(""));
            let v6 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method107(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                leptos::view! {
                    <div class="flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm">
                        {v6()}
                    </div>
                },
            );
            let v17: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method106(v0_1: leptos::ReadSignal<Dice_ui::US19>) -> Func0<leptos::Fragment> {
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
                        let v54 = Dice_ui::method142(Dice_ui::method141(Dice_ui::method106(
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
                        let v60: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method169(
                            leptos::view! { <div class="flex flex-1 max-[100px]:[overflow-x:auto]">{v54()}</div> },
                        );
                        let v65: Array<leptos::View> =
                            Dice_ui::method140(Dice_ui::method139(new_array(&[
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
                                    Dice_ui::method169(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method140(Dice_ui::method139(new_array(&[
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
        pub fn closure268(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method140(Dice_ui::method139(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method452() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure268((), ()))
        }
        pub fn method453() -> string {
            string("/")
        }
        pub fn closure269(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                                    Dice_ui::method169(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method140(Dice_ui::method139(new_array(&[
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
        pub fn method454() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure269((), ()))
        }
        pub fn method455() -> string {
            string("/*")
        }
        pub fn closure270(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                                    Dice_ui::method169(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method140(Dice_ui::method139(new_array(&[
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
        pub fn method456() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure270((), ()))
        }
        pub fn method457() -> string {
            string("*")
        }
        pub fn closure271(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                                    Dice_ui::method169(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method140(Dice_ui::method139(new_array(&[
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
        pub fn method458() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure271((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method17()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method19();
            let v8 = Dice_ui::method452();
            let v18: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v8()) view=move || v7() path=v6 /> })");
            let v19: leptos::View = leptos::IntoView::into_view(
                leptos::view! {
                    <leptos_router::Route
                        children=Box::new(move || v8())
                        view=move || v7()
                        path=v6
                    ></leptos_router::Route>
                },
            );
            let v22: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method453()));
            let v24: &str = fable_library_rust::String_::LrcStr::as_str(&v22);
            let v26: std::string::String = String::from(v24);
            let v27 = Dice_ui::method454();
            let v28 = Dice_ui::method452();
            let v36: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v28()) view=move || v27() path=v26 /> })");
            let v37: leptos::View = leptos::IntoView::into_view(
                leptos::view! {
                    <leptos_router::Route
                        children=Box::new(move || v28())
                        view=move || v27()
                        path=v26
                    ></leptos_router::Route>
                },
            );
            let v40: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method455()));
            let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
            let v44: std::string::String = String::from(v42);
            let v45 = Dice_ui::method456();
            let v46 = Dice_ui::method452();
            let v54: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v46()) view=move || v45() path=v44 /> })");
            let v55: leptos::View = leptos::IntoView::into_view(
                leptos::view! {
                    <leptos_router::Route
                        children=Box::new(move || v46())
                        view=move || v45()
                        path=v44
                    ></leptos_router::Route>
                },
            );
            let v58: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method457()));
            let v60: &str = fable_library_rust::String_::LrcStr::as_str(&v58);
            let v62: std::string::String = String::from(v60);
            let v63 = Dice_ui::method458();
            let v64 = Dice_ui::method452();
            let v72: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> })");
            let v76: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                v19,
                v37,
                v55,
                leptos::IntoView::into_view(
                    leptos::view! {
                        <leptos_router::Route
                            children=Box::new(move || v64())
                            view=move || v63()
                            path=v62
                        ></leptos_router::Route>
                    },
                ),
            ])));
            let v78: Vec<leptos::View> = v76.to_vec();
            leptos::Fragment::new(v78)
        }
        pub fn method16() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure4((), ()))
        }
        pub fn method459(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method459(Dice_ui::method16());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v11: Array<leptos::View> = Dice_ui::method140(Dice_ui::method139(new_array(&[
                leptos::IntoView::into_view(
                    leptos::view! { <leptos_router::Routes children=Box::new(move || v1())></leptos_router::Routes> },
                ),
            ])));
            let v13: Vec<leptos::View> = v11.to_vec();
            leptos::Fragment::new(v13)
        }
        pub fn method15() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure3((), ()))
        }
        pub fn method460(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
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
                let v26: string = Dice_ui::method6(Dice_ui::method9());
                let v28: &str = fable_library_rust::String_::LrcStr::as_str(&v26);
                let v33: Array<std::string::String> =
                    Dice_ui::method11(Dice_ui::method10(new_array(&[v24, String::from(v28)])));
                let v38: LrcPtr<Dice_ui::Heap0> = Dice_ui::method12(LrcPtr::new(Dice_ui::Heap0 {
                    l0: v33.to_vec(),
                    l1: Dice_ui::US1::US1_0,
                }));
                let v42: LrcPtr<Dice_ui::Heap1> = Dice_ui::method13(LrcPtr::new(Dice_ui::Heap1 {
                    l0: v6,
                    l1: leptos::create_rw_signal(v38),
                    l2: v9,
                    l3: v18,
                }));
                let v44: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = leptos::create_rw_signal(v42);
                let v47: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> =
                    Dice_ui::method14(std::collections::HashMap::new());
                let v50: LrcPtr<Dice_ui::Heap2> = LrcPtr::new(Dice_ui::Heap2 {
                    l0: v44,
                    l1: leptos::create_rw_signal(v47),
                });
                leptos::provide_context::<std::rc::Rc<Heap2>>(v50);
                {
                    let v53 = Dice_ui::method460(Dice_ui::method15());
                    let v59: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v53()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router children=Box::new(move || v53())></leptos_router::Router> },
                    )
                }
            }
        }
        pub fn method3() {
            leptos::mount_to_body(|| Func0::new(move || Dice_ui::closure2((), ()))());
            ()
        }
        pub fn closure272(unitVar: (), unitVar_1: ()) {
            Dice_ui::method3();
        }
        pub fn method461() -> Func0<()> {
            Func0::new(move || Dice_ui::closure272((), ()))
        }
        pub fn method462(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
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
                    let v21 = Dice_ui::method461();
                    let v24: Box<dyn Fn()> = Dice_ui::method462(Box::new(move || v21()));
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
