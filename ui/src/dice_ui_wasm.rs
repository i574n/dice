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
        use fable_library_rust::Array_::tryItem;
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
            US6_1(Option<LrcPtr<Dice_ui::Heap3>>),
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
            US8_1(Option<Option<LrcPtr<Dice_ui::Heap3>>>),
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
            US9_0,
            US9_1(Dice_ui::US4),
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
        pub enum US10 {
            US10_0(wasm_bindgen::JsValue),
            US10_1(Option<web_sys::Storage>),
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
            US12_0,
            US12_1(web_sys::Storage),
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
        pub enum US11 {
            US11_0(wasm_bindgen::JsValue),
            US11_1(Dice_ui::US12),
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
        pub enum US13 {
            US13_0(wasm_bindgen::JsValue),
            US13_1(Option<std::string::String>),
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
            US15_1(std::string::String),
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
        pub enum US14 {
            US14_0(wasm_bindgen::JsValue),
            US14_1(Dice_ui::US15),
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
        pub enum US16 {
            US16_0,
            US16_1(Dice_ui::US15),
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
            US17_0(rexie::Error),
            US17_1,
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
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0,
            US18_1(leptos::RwSignal<bool>),
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
        pub enum US19 {
            US19_0,
            US19_1(bool),
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
        }
        impl core::fmt::Display for Dice_ui::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US21 {
            US21_0,
        }
        impl Dice_ui::US21 {
            pub fn get_IsUS21_0(this_: &MutCell<Dice_ui::US21>, unitArg: ()) -> bool {
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
        pub enum US20 {
            US20_0,
            US20_1(Dice_ui::US21),
            US20_2,
            US20_3,
            US20_4,
        }
        impl Dice_ui::US20 {
            pub fn get_IsUS20_0(this_: &MutCell<Dice_ui::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS20_1(this_: &MutCell<Dice_ui::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS20_2(this_: &MutCell<Dice_ui::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS20_3(this_: &MutCell<Dice_ui::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS20_4(this_: &MutCell<Dice_ui::US20>, unitArg: ()) -> bool {
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
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(std::string::String),
            US22_1(leptos_router::Url),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US23 {
            US23_0,
            US23_1(Dice_ui::US20),
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
        pub struct Mut0 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<Dice_ui::US23>,
        }
        impl core::fmt::Display for Dice_ui::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0,
            US24_1(leptos::Fragment),
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
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(std::string::String),
            US25_1(std::string::String),
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
        #[derive(
            Clone,
            Debug,
            Default,
            serde::Serialize,
            serde::Deserialize,
            borsh::BorshSerialize,
            borsh::BorshDeserialize,
            PartialEq,
            PartialOrd,
            Hash,
            Eq,
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
        pub enum US26 {
            US26_0(std::string::String),
            US26_1(Option<LrcPtr<Dice_ui::Heap4>>),
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
            US28_0(std::string::String),
            US28_1(Option<Option<LrcPtr<Dice_ui::Heap4>>>),
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
            US29_0(std::string::String),
            US29_1(Dice_ui::US27),
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
        pub enum US31 {
            US31_0,
            US31_1(LrcPtr<Dice_ui::Heap4>),
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
        pub enum US30 {
            US30_0(std::string::String),
            US30_1(Array<Dice_ui::US31>),
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
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0,
            US32_1(Dice_ui::US30),
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
        pub enum US33 {
            US33_0,
            US33_1(Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>),
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
        pub enum US34 {
            US34_0(std::string::String),
            US34_1(Vec<Option<LrcPtr<Dice_ui::Heap4>>>),
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
        pub enum US35 {
            US35_0(std::string::String),
            US35_1,
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US36 {
            US36_0,
            US36_1(Result<Array<Option<string>>, std::string::String>),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US38 {
            US38_0,
            US38_1(string),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US37 {
            US37_0,
            US37_1(Result<Array<Dice_ui::US38>, std::string::String>),
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
        pub enum US40 {
            US40_0(std::string::String),
            US40_1(Array<Dice_ui::US38>),
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
        pub enum US39 {
            US39_0,
            US39_1(Dice_ui::US40),
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
        pub enum US43 {
            US43_0(std::string::String),
            US43_1(Dice_ui::US15),
        }
        impl Dice_ui::US43 {
            pub fn get_IsUS43_0(this_: &MutCell<Dice_ui::US43>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS43_1(this_: &MutCell<Dice_ui::US43>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US43 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US42 {
            US42_0(std::string::String),
            US42_1(Array<Dice_ui::US43>),
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
        #[derive(Clone, Debug)]
        pub enum US41 {
            US41_0,
            US41_1(Dice_ui::US42),
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
        pub enum US44 {
            US44_0,
            US44_1(Dice_ui::US38),
        }
        impl Dice_ui::US44 {
            pub fn get_IsUS44_0(this_: &MutCell<Dice_ui::US44>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS44_1(this_: &MutCell<Dice_ui::US44>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US44 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US45 {
            US45_0,
            US45_1(Dice_ui::US31),
        }
        impl Dice_ui::US45 {
            pub fn get_IsUS45_0(this_: &MutCell<Dice_ui::US45>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS45_1(this_: &MutCell<Dice_ui::US45>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US45 {
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
        pub enum US46 {
            US46_0(std::string::String),
            US46_1(
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
        impl Dice_ui::US46 {
            pub fn get_IsUS46_0(this_: &MutCell<Dice_ui::US46>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS46_1(this_: &MutCell<Dice_ui::US46>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US46 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US48 {
            US48_0,
            US48_1(Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>),
        }
        impl Dice_ui::US48 {
            pub fn get_IsUS48_0(this_: &MutCell<Dice_ui::US48>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS48_1(this_: &MutCell<Dice_ui::US48>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US48 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US47 {
            US47_0(std::string::String),
            US47_1(Dice_ui::US48),
        }
        impl Dice_ui::US47 {
            pub fn get_IsUS47_0(this_: &MutCell<Dice_ui::US47>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS47_1(this_: &MutCell<Dice_ui::US47>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US47 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US49 {
            US49_0,
            US49_1(
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
        impl Dice_ui::US49 {
            pub fn get_IsUS49_0(this_: &MutCell<Dice_ui::US49>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS49_1(this_: &MutCell<Dice_ui::US49>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US49 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US50 {
            US50_0(std::string::String),
            US50_1(Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>),
        }
        impl Dice_ui::US50 {
            pub fn get_IsUS50_0(this_: &MutCell<Dice_ui::US50>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS50_1(this_: &MutCell<Dice_ui::US50>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US50 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US51 {
            US51_0(std::string::String),
            US51_1(Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)>),
        }
        impl Dice_ui::US51 {
            pub fn get_IsUS51_0(this_: &MutCell<Dice_ui::US51>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS51_1(this_: &MutCell<Dice_ui::US51>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US51 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<Dice_ui::US51>,
        }
        impl core::fmt::Display for Dice_ui::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US52 {
            US52_0(std::string::String),
            US52_1(Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>),
        }
        impl Dice_ui::US52 {
            pub fn get_IsUS52_0(this_: &MutCell<Dice_ui::US52>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS52_1(this_: &MutCell<Dice_ui::US52>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US52 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US53 {
            US53_0,
            US53_1(chrono::DateTime<chrono::Utc>),
        }
        impl Dice_ui::US53 {
            pub fn get_IsUS53_0(this_: &MutCell<Dice_ui::US53>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS53_1(this_: &MutCell<Dice_ui::US53>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US53 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US54 {
            US54_0(string),
            US54_1(string),
        }
        impl Dice_ui::US54 {
            pub fn get_IsUS54_0(this_: &MutCell<Dice_ui::US54>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS54_1(this_: &MutCell<Dice_ui::US54>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Dice_ui::US54 {
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
        pub fn method31(
            v0_1: Result<rexie::Transaction, rexie::Error>,
        ) -> Result<rexie::Transaction, rexie::Error> {
            v0_1
        }
        pub fn method32() -> string {
            string("store")
        }
        pub fn closure15(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method33() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure15((), v))
        }
        pub fn method34(
            v0_1: Result<rexie::Store, rexie::Error>,
        ) -> Result<rexie::Store, rexie::Error> {
            v0_1
        }
        pub fn method35() -> string {
            string("core-state-heap")
        }
        pub fn closure16(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method36() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure16((), v))
        }
        pub fn method37(
            v0_1: Result<wasm_bindgen::JsValue, rexie::Error>,
        ) -> Result<wasm_bindgen::JsValue, rexie::Error> {
            v0_1
        }
        pub fn method38(v0_1: wasm_bindgen::JsValue) -> wasm_bindgen::JsValue {
            v0_1
        }
        pub fn closure17(unitVar: (), v0_1: serde_wasm_bindgen::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method39() -> Func1<serde_wasm_bindgen::Error, std::string::String> {
            Func1::new(move |v: serde_wasm_bindgen::Error| Dice_ui::closure17((), v))
        }
        pub fn method40(
            v0_1: Result<Option<serde_json::Value>, serde_wasm_bindgen::Error>,
        ) -> Result<Option<serde_json::Value>, serde_wasm_bindgen::Error> {
            v0_1
        }
        pub fn closure18(unitVar: (), v0_1: serde_json::Value) -> Dice_ui::US7 {
            Dice_ui::US7::US7_1(v0_1)
        }
        pub fn method41(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn closure19(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method42() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure19((), v))
        }
        pub fn method43(
            v0_1: Result<Vec<u8>, serde_json::Error>,
        ) -> Result<Vec<u8>, serde_json::Error> {
            v0_1
        }
        pub fn method44(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method45(v0_1: Array<u8>) -> Array<u8> {
            v0_1
        }
        pub fn closure20(unitVar: (), v0_1: borsh::io::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method46() -> Func1<borsh::io::Error, std::string::String> {
            Func1::new(move |v: borsh::io::Error| Dice_ui::closure20((), v))
        }
        pub fn method47(
            v0_1: Result<Option<LrcPtr<Dice_ui::Heap3>>, borsh::io::Error>,
        ) -> Result<Option<LrcPtr<Dice_ui::Heap3>>, borsh::io::Error> {
            v0_1
        }
        pub fn method48(
            v0_1: Result<Option<Option<LrcPtr<Dice_ui::Heap3>>>, std::string::String>,
        ) -> Result<Option<Option<LrcPtr<Dice_ui::Heap3>>>, std::string::String> {
            v0_1
        }
        pub fn closure21(
            unitVar: (),
            v0_1: Option<Option<LrcPtr<Dice_ui::Heap3>>>,
        ) -> Dice_ui::US8 {
            Dice_ui::US8::US8_1(v0_1)
        }
        pub fn closure22(unitVar: (), v0_1: std::string::String) -> Dice_ui::US8 {
            Dice_ui::US8::US8_0(v0_1)
        }
        pub fn closure23(unitVar: (), v0_1: Option<LrcPtr<Dice_ui::Heap3>>) -> Dice_ui::US6 {
            Dice_ui::US6::US6_1(v0_1)
        }
        pub fn closure24(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap3>) -> Dice_ui::US4 {
            Dice_ui::US4::US4_1(v0_1)
        }
        pub fn method49(v0_1: Dice_ui::US4) -> Dice_ui::US4 {
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
                        let v137: Dice_ui::US6 = match &v8 {
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
                                        let v31: Result<rexie::Transaction, rexie::Error> =
                                            Dice_ui::method31(v29);
                                        let v33: Result<rexie::Transaction, std::string::String> =
                                            v31.map_err(|x| v30(x));
                                        let v35: rexie::Transaction = v33?;
                                        let v36: string = Dice_ui::method32();
                                        let v38: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v36);
                                        let v40: Result<rexie::Store, rexie::Error> =
                                            v35.store(v38);
                                        let v41 = Dice_ui::method33();
                                        let v42: Result<rexie::Store, rexie::Error> =
                                            Dice_ui::method34(v40);
                                        let v44: Result<rexie::Store, std::string::String> =
                                            v42.map_err(|x| v41(x));
                                        let v46: rexie::Store = v44?;
                                        let v47: string = Dice_ui::method35();
                                        let v49: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v47);
                                        let v51: wasm_bindgen::JsValue =
                                            wasm_bindgen::JsValue::from_str(v49);
                                        let v53: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        wasm_bindgen::JsValue,
                                                        rexie::Error,
                                                    >,
                                                >,
                                            >,
                                        > = Box::pin(rexie::Store::get(&v46, &v51));
                                        let v55: Result<wasm_bindgen::JsValue, rexie::Error> =
                                            v53.await;
                                        let v56 = Dice_ui::method36();
                                        let v57: Result<wasm_bindgen::JsValue, rexie::Error> =
                                            Dice_ui::method37(v55);
                                        let v59: Result<
                                            wasm_bindgen::JsValue,
                                            std::string::String,
                                        > = v57.map_err(|x| v56(x));
                                        let v62: wasm_bindgen::JsValue = Dice_ui::method38(v59?);
                                        let v64: Result<
                                            Option<serde_json::Value>,
                                            serde_wasm_bindgen::Error,
                                        > = serde_wasm_bindgen::from_value(v62);
                                        let v65 = Dice_ui::method39();
                                        let v66: Result<
                                            Option<serde_json::Value>,
                                            serde_wasm_bindgen::Error,
                                        > = Dice_ui::method40(v64);
                                        let v68: Result<
                                            Option<serde_json::Value>,
                                            std::string::String,
                                        > = v66.map_err(|x| v65(x));
                                        let v73: Dice_ui::US7 = defaultValue(
                                            Dice_ui::US7::US7_0,
                                            map(
                                                Func1::new(move |v_1: serde_json::Value| {
                                                    Dice_ui::closure18((), v_1)
                                                }),
                                                v68?,
                                            ),
                                        );
                                        let v108: Dice_ui::US6 = match &v73 {
                                            Dice_ui::US7::US7_1(v73_1_0) => {
                                                let v75: serde_json::Value =
                                                    Dice_ui::method41(v73_1_0.clone());
                                                let v77: Result<Vec<u8>, serde_json::Error> =
                                                    serde_json::from_value(v75);
                                                let v78 = Dice_ui::method42();
                                                let v79: Result<Vec<u8>, serde_json::Error> =
                                                    Dice_ui::method43(v77);
                                                let v81: Result<Vec<u8>, std::string::String> =
                                                    v79.map_err(|x| v78(x));
                                                let v84: Vec<u8> = Dice_ui::method44(v81?);
                                                let v86: Array<u8> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v84,
                                                    );
                                                let v89: string = Dice_ui::method0(append(
                                                    append(
                                                        string(
                                                            "state_core.get_data () / data_len: ",
                                                        ),
                                                        toString(count(v86.clone())),
                                                    ),
                                                    string(""),
                                                ));
                                                leptos::logging::log!("{}", v89);
                                                {
                                                    let v91: Array<u8> = Dice_ui::method45(v86);
                                                    let v93: Vec<u8> = v91.to_vec();
                                                    let v95: &[u8] = v93.as_slice();
                                                    let mut v95 = v95;
                                                    {
                                                        let v98: Result<
                                                            Option<LrcPtr<Dice_ui::Heap3>>,
                                                            borsh::io::Error,
                                                        > = borsh::BorshDeserialize::deserialize(
                                                            &mut v95,
                                                        );
                                                        let v99 = Dice_ui::method46();
                                                        let v100: Result<
                                                            Option<LrcPtr<Dice_ui::Heap3>>,
                                                            borsh::io::Error,
                                                        > = Dice_ui::method47(v98);
                                                        let v102: Result<
                                                            Option<LrcPtr<Dice_ui::Heap3>>,
                                                            std::string::String,
                                                        > = v100.map_err(|x| v99(x));
                                                        Dice_ui::US6::US6_1(v102?)
                                                    }
                                                }
                                            }
                                            _ => Dice_ui::US6::US6_0,
                                        };
                                        let v115: Result<
                                            Option<Option<LrcPtr<Dice_ui::Heap3>>>,
                                            std::string::String,
                                        > = Dice_ui::method48(Ok::<
                                            Option<Option<LrcPtr<Dice_ui::Heap3>>>,
                                            std::string::String,
                                        >(
                                            match &v108 {
                                            Dice_ui::US6::US6_1(v108_1_0) => Some(v108_1_0.clone()),
                                            _ => None::<Option<LrcPtr<Dice_ui::Heap3>>>,
                                        }
                                        ));
                                        v115
                                    }
                                });
                                {
                                    //;
                                    {
                                        let v118: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        Option<Option<LrcPtr<Dice_ui::Heap3>>>,
                                                        std::string::String,
                                                    >,
                                                >,
                                            >,
                                        > = __future_init;
                                        let v120: Result<
                                            Option<Option<LrcPtr<Dice_ui::Heap3>>>,
                                            std::string::String,
                                        > = v118.await;
                                        let v123: Dice_ui::US8 = match &v120 {
                                            Err(v120_1_0) => {
                                                Dice_ui::closure22((), v120_1_0.clone())
                                            }
                                            Ok(v120_0_0) => {
                                                Dice_ui::closure21((), v120_0_0.clone())
                                            }
                                        };
                                        match &v123 {
                                            Dice_ui::US8::US8_1(v123_1_0) =>
                                            defaultValue(Dice_ui::US6::US6_0,
                                                         map(Func1::new(move
                                                                            |v_4:
                                                                                 Option<LrcPtr<Dice_ui::Heap3>>|
                                                                            Dice_ui::closure23((),
                                                                                               v_4)),
                                                             v123_1_0.clone())),
                                            Dice_ui::US8::US8_0(v123_0_0) => {
                                                let v130: string =
                                                    Dice_ui::method0(append(append(string("state_core.use_core_database (2.1) / error: "),
                                                                                   toString(v123_0_0.clone())),
                                                                            string("")));
                                                leptos::logging::log!("{}", v130);
                                                Dice_ui::US6::US6_0
                                            }
                                        }
                                    }
                                }
                            }
                            _ => Dice_ui::US6::US6_0,
                        };
                        let v145: Dice_ui::US9 = match &v137 {
                            Dice_ui::US6::US6_1(v137_1_0) => Dice_ui::US9::US9_1(defaultValue(
                                Dice_ui::US4::US4_0,
                                map(
                                    Func1::new(move |v_5: LrcPtr<Dice_ui::Heap3>| {
                                        Dice_ui::closure24((), v_5)
                                    }),
                                    v137_1_0.clone(),
                                ),
                            )),
                            _ => Dice_ui::US9::US9_0,
                        };
                        let v153: Dice_ui::US4 =
                            Dice_ui::method49(if let Dice_ui::US9::US9_1(v145_1_0) = &v145 {
                                let v146: Dice_ui::US4 = match &v145 {
                                    Dice_ui::US9::US9_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Dice_ui::US4::US4_1(v146_1_0) = &v146 {
                                    Dice_ui::US4::US4_1(match &v146 {
                                        Dice_ui::US4::US4_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    Dice_ui::US4::US4_0
                                }
                            } else {
                                Dice_ui::US4::US4_0
                            });
                        v153
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
        pub fn method51() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method53(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method52(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Dice_ui::method53(v0_1);
            v1.local_storage()
        }
        pub fn closure26(unitVar: (), v0_1: Option<web_sys::Storage>) -> Dice_ui::US10 {
            Dice_ui::US10::US10_1(v0_1)
        }
        pub fn closure27(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US10 {
            Dice_ui::US10::US10_0(v0_1)
        }
        pub fn closure28(unitVar: (), v0_1: web_sys::Storage) -> Dice_ui::US12 {
            Dice_ui::US12::US12_1(v0_1)
        }
        pub fn method54(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4> {
            v0_1
        }
        pub fn closure29(unitVar: (), v0_1: Dice_ui::US4) -> Dice_ui::US9 {
            Dice_ui::US9::US9_1(v0_1)
        }
        pub fn method55(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn closure30(unitVar: (), v0_1: Option<std::string::String>) -> Dice_ui::US13 {
            Dice_ui::US13::US13_1(v0_1)
        }
        pub fn closure31(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US13 {
            Dice_ui::US13::US13_0(v0_1)
        }
        pub fn method56(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Dice_ui::US15 {
            Dice_ui::US15::US15_1(v0_1)
        }
        pub fn method57(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn method59(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method60(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure34(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method61() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure34((), v))
        }
        pub fn method62(
            v0_1: Result<LrcPtr<Dice_ui::Heap3>, serde_json::Error>,
        ) -> Result<LrcPtr<Dice_ui::Heap3>, serde_json::Error> {
            v0_1
        }
        pub fn closure33(unitVar: (), v0_1: std::string::String) -> Dice_ui::US4 {
            let v2: std::string::String = Dice_ui::method60(Dice_ui::method59(v0_1));
            let v5: string = Dice_ui::method6(fable_library_rust::String_::fromString(v2));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: Result<LrcPtr<Dice_ui::Heap3>, serde_json::Error> = serde_json::from_str(&v7);
            let v10 = Dice_ui::method61();
            let v11: Result<LrcPtr<Dice_ui::Heap3>, serde_json::Error> = Dice_ui::method62(v9);
            let v13: Result<LrcPtr<Dice_ui::Heap3>, std::string::String> = v11.map_err(|x| v10(x));
            defaultValue(
                Dice_ui::US4::US4_0,
                map(
                    Func1::new(move |v: LrcPtr<Dice_ui::Heap3>| Dice_ui::closure24((), v)),
                    v13.ok(),
                ),
            )
        }
        pub fn method58() -> Func1<std::string::String, Dice_ui::US4> {
            Func1::new(move |v: std::string::String| Dice_ui::closure33((), v))
        }
        pub fn method64(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> {
            v0_1
        }
        pub fn closure36(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            let v3: string =
                Dice_ui::method0(string("state_core.use_core_database (5.1) / effect core_state_heap / dark_mode signal_update"));
            leptos::logging::log!("{}", v3);
            v0_1.l0
        }
        pub fn method65(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure36(v0_1.clone(), v)
            })
        }
        pub fn method66(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure37(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            let v3: string = Dice_ui::method0(string(
                "state_core.use_core_database (5.2) / effect core_state_heap / debug signal_update",
            ));
            leptos::logging::log!("{}", v3);
            v0_1.l2
        }
        pub fn method67(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure37(v0_1.clone(), v)
            })
        }
        pub fn closure38(
            v0_1: LrcPtr<Dice_ui::Heap3>,
            v1: std::string::String,
        ) -> std::string::String {
            let v3: string =
                Dice_ui::method0(string("state_core.use_core_database (5.3) / effect core_state_heap / url_hash signal_update"));
            leptos::logging::log!("{}", v3);
            v0_1.l3.clone()
        }
        pub fn method68(
            v0_1: LrcPtr<Dice_ui::Heap3>,
        ) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure38(v0_1.clone(), v)
            })
        }
        pub fn method69(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure39(
            v0_1: LrcPtr<Dice_ui::Heap3>,
            v1: LrcPtr<Dice_ui::Heap0>,
        ) -> LrcPtr<Dice_ui::Heap0> {
            let v3: string = Dice_ui::method0(string(
                "state_core.use_core_database (5.3) / effect core_state_heap / data signal_update",
            ));
            leptos::logging::log!("{}", v3);
            v0_1.l1.clone()
        }
        pub fn method70(
            v0_1: LrcPtr<Dice_ui::Heap3>,
        ) -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure39(v0_1.clone(), v)
            })
        }
        pub fn method71(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure35(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap3>, unitVar: ()) {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v2.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method65(v1.clone());
            let v8: leptos::RwSignal<bool> = Dice_ui::method66(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            {
                let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v2.clone());
                let v12: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v10);
                let v14 = Dice_ui::method67(v1.clone());
                let v15: leptos::RwSignal<bool> = Dice_ui::method66(v12.l2.clone());
                leptos::SignalUpdate::update(&v15, |x| *x = v14(x.clone()));
                {
                    let v17: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                        Dice_ui::method64(v2.clone());
                    let v19: LrcPtr<Dice_ui::Heap1> =
                        leptos::SignalGetUntracked::get_untracked(&v17);
                    let v21 = Dice_ui::method68(v1.clone());
                    let v22: leptos::RwSignal<std::string::String> =
                        Dice_ui::method69(v19.l3.clone());
                    leptos::SignalUpdate::update(&v22, |x| *x = v21(x.clone()));
                    {
                        let v24: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v2);
                        let v26: LrcPtr<Dice_ui::Heap1> =
                            leptos::SignalGetUntracked::get_untracked(&v24);
                        let v28 = Dice_ui::method70(v1);
                        let v29: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                            Dice_ui::method71(v26.l1.clone());
                        leptos::SignalUpdate::update(&v29, |x| *x = v28(x.clone()));
                        ()
                    }
                }
            }
        }
        pub fn method63(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap3>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure35(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method72(v0_1: Func0<()>) -> Func0<()> {
            v0_1
        }
        pub fn closure25(
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
                    Dice_ui::method52(Dice_ui::method51());
                let v9: Dice_ui::US10 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure27((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure26((), v6_0_0.clone()),
                };
                let v18: Dice_ui::US11 = match &v9 {
                    Dice_ui::US10::US10_1(v9_1_0) => Dice_ui::US11::US11_1(defaultValue(
                        Dice_ui::US12::US12_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure28((), v_2)),
                            v9_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US10::US10_0(v9_0_0) => Dice_ui::US11::US11_0(v9_0_0.clone()),
                };
                if let Dice_ui::US11::US11_1(v18_1_0) = &v18 {
                    let v19: Dice_ui::US12 = match &v18 {
                        Dice_ui::US11::US11_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US12::US12_1(v19_1_0) = &v19 {
                        let v20: web_sys::Storage = match &v19 {
                            Dice_ui::US12::US12_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v21: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4> =
                            Dice_ui::method54(v1);
                        fn v24(v_3: Dice_ui::US4) -> Dice_ui::US9 {
                            Dice_ui::closure29((), v_3)
                        }
                        let v26: Dice_ui::US9 = defaultValue(
                            Dice_ui::US9::US9_0,
                            map(Func1::from(v24), leptos::SignalGet::get(&v21)),
                        );
                        let v29: string =
                            Dice_ui::method0(append(append(string("state_core.use_core_database (4) / effect core_state_heap / ##2 / core_state_heap: "),
                                                           sprintf!("{:?}",
                                                                    &v26)),
                                                    string("")));
                        leptos::logging::log!("{}", v29);
                        {
                            let v139: Dice_ui::US4 = if let Dice_ui::US9::US9_1(v26_1_0) = &v26 {
                                let v31: Dice_ui::US4 = match &v26 {
                                    Dice_ui::US9::US9_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Dice_ui::US4::US4_1(v31_1_0) = &v31 {
                                    Dice_ui::US4::US4_1(match &v31 {
                                        Dice_ui::US4::US4_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v34: web_sys::Storage = Dice_ui::method55(v20.clone());
                                    let v35: string = Dice_ui::method35();
                                    let v37: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v35);
                                    let v39: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v34, v37);
                                    let v42: Dice_ui::US13 = match &v39 {
                                        Err(v39_1_0) => Dice_ui::closure31((), v39_1_0.clone()),
                                        Ok(v39_0_0) => Dice_ui::closure30((), v39_0_0.clone()),
                                    };
                                    let v54: Dice_ui::US14 = match &v42 {
                                        Dice_ui::US13::US13_1(v42_1_0) => {
                                            let v44: Option<std::string::String> =
                                                Dice_ui::method56(v42_1_0.clone());
                                            Dice_ui::US14::US14_1(defaultValue(
                                                Dice_ui::US15::US15_0,
                                                map(
                                                    Func1::new(move |v_6: std::string::String| {
                                                        Dice_ui::closure32((), v_6)
                                                    }),
                                                    serde_json::from_value(v44.into()).unwrap(),
                                                ),
                                            ))
                                        }
                                        Dice_ui::US13::US13_0(v42_0_0) => {
                                            Dice_ui::US14::US14_0(v42_0_0.clone())
                                        }
                                    };
                                    let v60: Dice_ui::US16 = match &v54 {
                                        Dice_ui::US14::US14_1(v54_1_0) => {
                                            Dice_ui::US16::US16_1(v54_1_0.clone())
                                        }
                                        _ => Dice_ui::US16::US16_0,
                                    };
                                    let v67: Dice_ui::US15 =
                                        if let Dice_ui::US16::US16_1(v60_1_0) = &v60 {
                                            let v61: Dice_ui::US15 = match &v60 {
                                                Dice_ui::US16::US16_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if let Dice_ui::US15::US15_1(v61_1_0) = &v61 {
                                                Dice_ui::US15::US15_1(match &v61 {
                                                    Dice_ui::US15::US15_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            } else {
                                                Dice_ui::US15::US15_0
                                            }
                                        } else {
                                            Dice_ui::US15::US15_0
                                        };
                                    let v73: Option<std::string::String> =
                                        Dice_ui::method57(match &v67 {
                                            Dice_ui::US15::US15_1(v67_1_0) => Some(v67_1_0.clone()),
                                            _ => None::<std::string::String>,
                                        });
                                    let v74 = Dice_ui::method58();
                                    let v78: Dice_ui::US9 = defaultValue(
                                        Dice_ui::US9::US9_0,
                                        map(Func1::from(v24), v73.map(|x| v74(x))),
                                    );
                                    if let Dice_ui::US9::US9_1(v78_1_0) = &v78 {
                                        let v79: Dice_ui::US4 = match &v78 {
                                            Dice_ui::US9::US9_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US4::US4_1(v79_1_0) = &v79 {
                                            Dice_ui::US4::US4_1(match &v79 {
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
                                let v87: web_sys::Storage = Dice_ui::method55(v20);
                                let v88: string = Dice_ui::method35();
                                let v90: &str = fable_library_rust::String_::LrcStr::as_str(&v88);
                                let v92: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v87, v90);
                                let v95: Dice_ui::US13 = match &v92 {
                                    Err(v92_1_0) => Dice_ui::closure31((), v92_1_0.clone()),
                                    Ok(v92_0_0) => Dice_ui::closure30((), v92_0_0.clone()),
                                };
                                let v107: Dice_ui::US14 = match &v95 {
                                    Dice_ui::US13::US13_1(v95_1_0) => {
                                        let v97: Option<std::string::String> =
                                            Dice_ui::method56(v95_1_0.clone());
                                        Dice_ui::US14::US14_1(defaultValue(
                                            Dice_ui::US15::US15_0,
                                            map(
                                                Func1::new(move |v_9: std::string::String| {
                                                    Dice_ui::closure32((), v_9)
                                                }),
                                                serde_json::from_value(v97.into()).unwrap(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US13::US13_0(v95_0_0) => {
                                        Dice_ui::US14::US14_0(v95_0_0.clone())
                                    }
                                };
                                let v113: Dice_ui::US16 = match &v107 {
                                    Dice_ui::US14::US14_1(v107_1_0) => {
                                        Dice_ui::US16::US16_1(v107_1_0.clone())
                                    }
                                    _ => Dice_ui::US16::US16_0,
                                };
                                let v120: Dice_ui::US15 =
                                    if let Dice_ui::US16::US16_1(v113_1_0) = &v113 {
                                        let v114: Dice_ui::US15 = match &v113 {
                                            Dice_ui::US16::US16_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US15::US15_1(v114_1_0) = &v114 {
                                            Dice_ui::US15::US15_1(match &v114 {
                                                Dice_ui::US15::US15_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Dice_ui::US15::US15_0
                                        }
                                    } else {
                                        Dice_ui::US15::US15_0
                                    };
                                let v126: Option<std::string::String> =
                                    Dice_ui::method57(match &v120 {
                                        Dice_ui::US15::US15_1(v120_1_0) => Some(v120_1_0.clone()),
                                        _ => None::<std::string::String>,
                                    });
                                let v127 = Dice_ui::method58();
                                let v131: Dice_ui::US9 = defaultValue(
                                    Dice_ui::US9::US9_0,
                                    map(Func1::from(v24), v126.map(|x| v127(x))),
                                );
                                if let Dice_ui::US9::US9_1(v131_1_0) = &v131 {
                                    let v132: Dice_ui::US4 = match &v131 {
                                        Dice_ui::US9::US9_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US4::US4_1(v132_1_0) = &v132 {
                                        Dice_ui::US4::US4_1(match &v132 {
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
                            let v142: string =
                                Dice_ui::method0(append(append(string("state_core.use_core_database (5) / effect core_state_heap / ##3 / core_state_heap: "),
                                                               sprintf!("{:?}",
                                                                        &v139)),
                                                        string("")));
                            leptos::logging::log!("{}", v142);
                            if let Dice_ui::US4::US4_1(v139_1_0) = &v139 {
                                let v145 = Dice_ui::method63(
                                    v0_1,
                                    match &v139 {
                                        Dice_ui::US4::US4_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                );
                                let v148: Func0<()> = Dice_ui::method72(Func0::new(move || v145()));
                                leptos::batch(move || v148());
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method50(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US4>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure25(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method74(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::RwSignal<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn closure40(
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
                > = Dice_ui::method74(v0_1.l1.clone());
                leptos::SignalGetUntracked::get_untracked(&v5)
            }
        }
        pub fn method73(
            v0_1: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure40(v0_1.clone(), ())
            })
        }
        pub fn method75() -> bool {
            false
        }
        pub fn method77(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method78(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method79(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> Dice_ui::US17 {
            Dice_ui::US17::US17_1
        }
        pub fn closure43(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US17 {
            Dice_ui::US17::US17_0(v0_1)
        }
        pub fn method80() {
            ();
        }
        pub fn closure41(
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
                                let v19: rexie::Rexie = Dice_ui::method77(v8_1_0.clone());
                                let v20: LrcPtr<Dice_ui::Heap3> = Dice_ui::method78(v1.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v23: rexie::Transaction = v19.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v25: rexie::Store = v23.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v20, &mut data).unwrap();
                                        {
                                            let v29: Vec<u8> = data;
                                            let v31: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v29).unwrap();
                                            let v32: string = Dice_ui::method35();
                                            let v34: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v32);
                                            v25.put(&v31, Some(&v34.into())).await?;
                                            v23.done().await?;
                                            {
                                                let v38: Result<(), rexie::Error> =
                                                    Dice_ui::method79(Ok::<(), rexie::Error>(()));
                                                v38
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v41: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v43: Result<(), rexie::Error> = v41.await;
                                                let v46: Dice_ui::US17 = match &v43 {
                                                    Err(v43_1_0) => {
                                                        Dice_ui::closure43((), v43_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure42((), ()),
                                                };
                                                match &v46 {
                                                Dice_ui::US17::US17_1 => (),
                                                Dice_ui::US17::US17_0(v46_0_0)
                                                =>
                                                panic!("{}",
                                                       sprintf!("resultm.get / Result value was Error: {}", v46_0_0),),
                                            }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _ => {
                        let v50: string =
                        Dice_ui::method0(string("state_core.use_core_database (8) / set_core_state_heap_action / database=None"));
                        leptos::logging::log!("{}", v50);
                        ()
                    }
                }
                Dice_ui::method80();
                ()
            });
            __future_init
        }
        pub fn method76(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func1<LrcPtr<Dice_ui::Heap3>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap3>| Dice_ui::closure41(v0_1.clone(), v)
            })
        }
        pub fn method82(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method83(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method84(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method85(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn method86(
            v0_1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::Memo<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn method87() -> string {
            string("dark_mode_key")
        }
        pub fn method88(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure45(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Dice_ui::US18 {
            Dice_ui::US18::US18_1(v0_1)
        }
        pub fn closure46(unitVar: (), v0_1: bool) -> bool {
            let v2: string =
                Dice_ui::method0(string("state_core.use_core_database (12) / effect new_core_state_heap / set_loaded |> signal_update true"));
            leptos::logging::log!("{}", v2);
            true
        }
        pub fn method89() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure46((), v))
        }
        pub fn method90(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method91(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method92(
            v0_1: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
        ) -> leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> {
            v0_1
        }
        pub fn method93(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method94(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method95(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure44(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            v4: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Dice_ui::method82(v3);
            let v7: bool = leptos::SignalGet::get(&v5);
            let v9: string =
                Dice_ui::method0(append(append(string("state_core.use_core_database (9) / effect new_core_state_heap / ##1 / loaded: "),
                                               ofBoolean(v7)), string("")));
            leptos::logging::log!("{}", v9);
            {
                let v11: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
                let v12: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v11.clone());
                let v16: leptos::RwSignal<bool> =
                    Dice_ui::method83((leptos::SignalGetUntracked::get_untracked(&v12)).l0.clone());
                let v18: bool = leptos::SignalGet::get(&v16);
                let v19: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v11.clone());
                let v23: leptos::RwSignal<bool> =
                    Dice_ui::method83((leptos::SignalGetUntracked::get_untracked(&v19)).l2.clone());
                let v25: bool = leptos::SignalGet::get(&v23);
                let v26: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v11.clone());
                let v30: leptos::RwSignal<std::string::String> =
                    Dice_ui::method84((leptos::SignalGetUntracked::get_untracked(&v26)).l3.clone());
                let v32: std::string::String = leptos::SignalGet::get(&v30);
                let v33: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v11);
                let v37: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method85((leptos::SignalGetUntracked::get_untracked(&v33)).l1.clone());
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
                    > = Dice_ui::method86(v1);
                    let v47: std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<bool>,
                    > = v45();
                    let v49: string = Dice_ui::method6(Dice_ui::method87());
                    let v51: &str = fable_library_rust::String_::LrcStr::as_str(&v49);
                    let v54: std::string::String = Dice_ui::method88(String::from(v51));
                    let v59: Dice_ui::US18 = defaultValue(
                        Dice_ui::US18::US18_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Dice_ui::closure45((), v)),
                            std::collections::HashMap::get(&v47, &v54)
                                .map(|x| x)
                                .cloned(),
                        ),
                    );
                    let v67: Dice_ui::US19 = match &v59 {
                        Dice_ui::US18::US18_1(v59_1_0) => {
                            let v61: leptos::RwSignal<bool> = Dice_ui::method83(v59_1_0.clone());
                            Dice_ui::US19::US19_1(leptos::SignalGet::get(&v61))
                        }
                        _ => Dice_ui::US19::US19_0,
                    };
                    let v70: bool = match &v67 {
                        Dice_ui::US19::US19_1(v67_1_0) => v67_1_0.clone(),
                        _ => false,
                    };
                    let v72: string =
                        Dice_ui::method0(append(append(string("state_core.use_core_database (11) / effect new_core_state_heap / ##3 / dark_mode_loading: "),
                                                       ofBoolean(v70)),
                                                string("")));
                    leptos::logging::log!("{}", v72);
                    if v70 == false {
                        if v7 == false {
                            let v76 = Dice_ui::method89();
                            let v77: leptos::WriteSignal<bool> = Dice_ui::method90(v2);
                            leptos::SignalUpdate::update(&v77, |x| *x = v76(x.clone()));
                            ()
                        } else {
                            let v80: string =
                                Dice_ui::method0(string("state_core.use_core_database (13) / effect new_core_state_heap / ##4"));
                            leptos::logging::log!("{}", v80);
                            {
                                let v83: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Dice_ui::method52(Dice_ui::method51());
                                let v86: Dice_ui::US10 = match &v83 {
                                    Err(v83_1_0) => Dice_ui::closure27((), v83_1_0.clone()),
                                    Ok(v83_0_0) => Dice_ui::closure26((), v83_0_0.clone()),
                                };
                                let v95: Dice_ui::US11 = match &v86 {
                                    Dice_ui::US10::US10_1(v86_1_0) => {
                                        Dice_ui::US11::US11_1(defaultValue(
                                            Dice_ui::US12::US12_0,
                                            map(
                                                Func1::new(move |v_3: web_sys::Storage| {
                                                    Dice_ui::closure28((), v_3)
                                                }),
                                                v86_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US10::US10_0(v86_0_0) => {
                                        Dice_ui::US11::US11_0(v86_0_0.clone())
                                    }
                                };
                                if let Dice_ui::US11::US11_1(v95_1_0) = &v95 {
                                    let v96: Dice_ui::US12 = match &v95 {
                                        Dice_ui::US11::US11_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US12::US12_1(v96_1_0) = &v96 {
                                        let v98: LrcPtr<Dice_ui::Heap3> =
                                            Dice_ui::method91(v40.clone());
                                        let v99: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                                            Dice_ui::method92(v4);
                                        leptos::Action::dispatch(&v99, v98.clone());
                                        {
                                            let v101: web_sys::Storage =
                                                Dice_ui::method93(match &v96 {
                                                    Dice_ui::US12::US12_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                            let v102: string = Dice_ui::method35();
                                            let v104: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v102);
                                            let v105: LrcPtr<Dice_ui::Heap3> =
                                                Dice_ui::method94(v40);
                                            let v108: std::string::String = Dice_ui::method95(
                                                serde_json::json!(v105).to_string(),
                                            );
                                            let v110: &str = v108.as_str();
                                            web_sys::Storage::set(&v101, v104, v110).unwrap();
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
        pub fn method81(
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
                    Dice_ui::closure44(
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
        pub fn closure47(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method83((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method96(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure47(v0_1.clone(), ())
            })
        }
        pub fn method98(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method99(
            v0_1: leptos::Memo<std::string::String>,
        ) -> leptos::Memo<std::string::String> {
            v0_1
        }
        pub fn method100(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method101() -> Dice_ui::US20 {
            Dice_ui::US20::US20_0
        }
        pub fn method103(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method104(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method105() -> bool {
            true
        }
        pub fn method106(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method107(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method108(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure49(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap2>,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v6: leptos::ReadSignal<bool> = Dice_ui::method82(v5);
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos_router::Location = Dice_ui::method103(v0_1);
            let v12: leptos::Memo<std::string::String> = Dice_ui::method99(v9.hash);
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
                let v20: std::string::String = Dice_ui::method104(v14);
                if v20 == "" {
                    let v24: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                        Dice_ui::method64(v3.l0.clone());
                    let v28: leptos::RwSignal<std::string::String> = Dice_ui::method84(
                        (leptos::SignalGetUntracked::get_untracked(&v24)).l3.clone(),
                    );
                    let v31: std::string::String = Dice_ui::method60(leptos::SignalGet::get(&v28));
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
                    let v43: bool = Dice_ui::method105();
                    let v44: leptos::WriteSignal<bool> = Dice_ui::method106(v4);
                    leptos::SignalSet::set(&v44, v43);
                    ()
                }
            } else {
                let v47: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                    Dice_ui::method64(v3.l0.clone());
                let v49: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v47);
                let v52: string = Dice_ui::method6(Dice_ui::method18(v15));
                let v54: &str = fable_library_rust::String_::LrcStr::as_str(&v52);
                let v57: std::string::String = Dice_ui::method107(String::from(v54));
                let v58: leptos::RwSignal<std::string::String> = Dice_ui::method108(v49.l3.clone());
                leptos::SignalSet::set(&v58, v57);
                ()
            }
        }
        pub fn method102(
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
                    Dice_ui::closure49(
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
        pub fn method110(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method111(v0_1: &str) -> &str {
            v0_1
        }
        pub fn closure51(unitVar: (), v0_1: leptos_router::Url) -> Dice_ui::US22 {
            Dice_ui::US22::US22_1(v0_1)
        }
        pub fn closure52(unitVar: (), v0_1: std::string::String) -> Dice_ui::US22 {
            Dice_ui::US22::US22_0(v0_1)
        }
        pub fn method112(v0_1: Array<Dice_ui::US20>) -> Array<Dice_ui::US20> {
            v0_1
        }
        pub fn method113(v0_1: i32, v1: LrcPtr<Dice_ui::Mut0>) -> bool {
            v1.l0.get().clone() < v0_1
        }
        pub fn method114(v0_1: leptos_router::Url) -> leptos_router::Url {
            v0_1
        }
        pub fn method115(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method116(v0_1: Dice_ui::US20) -> Dice_ui::US20 {
            v0_1
        }
        pub fn method117(
            v0_1: leptos::WriteSignal<Dice_ui::US20>,
        ) -> leptos::WriteSignal<Dice_ui::US20> {
            v0_1
        }
        pub fn closure50(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US20>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Dice_ui::method103(v0_1);
            let v5: leptos::Memo<std::string::String> = Dice_ui::method99(v2.hash);
            let v8: std::string::String = Dice_ui::method110(v5());
            let v10: Option<&str> = v8.strip_prefix('#');
            let v12: string = string("r#\"\"#");
            let v13: &str = r#""#;
            let v16: &str = Dice_ui::method111(v10.unwrap_or(v13));
            let v18: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v16);
            let v21: Dice_ui::US22 = match &v18 {
                Err(v18_1_0) => Dice_ui::closure52((), v18_1_0.clone()),
                Ok(v18_0_0) => Dice_ui::closure51((), v18_0_0.clone()),
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
                Dice_ui::US22::US22_1(v21_1_0) => {
                    let v34: Array<Dice_ui::US20> = Dice_ui::method112(new_array(&[
                        Dice_ui::US20::US20_1(Dice_ui::US21::US21_0),
                        Dice_ui::US20::US20_2,
                        Dice_ui::US20::US20_4,
                        Dice_ui::US20::US20_3,
                    ]));
                    let v35: i32 = count(v34.clone());
                    let v37: LrcPtr<Dice_ui::Mut0> = LrcPtr::new(Dice_ui::Mut0 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(Dice_ui::US23::US23_0),
                    });
                    while Dice_ui::method113(v35, v37.clone()) {
                        let v39: i32 = v37.l0.get().clone();
                        let v40: Dice_ui::US23 = v37.l1.get().clone();
                        let v41: Dice_ui::US20 = v34[v39].clone();
                        let v71: Dice_ui::US23 = match &v40 {
                            Dice_ui::US23::US23_1(v40_1_0) => {
                                Dice_ui::US23::US23_1(v40_1_0.clone())
                            }
                            _ => {
                                let v53: string = match &v41 {
                                    Dice_ui::US20::US20_1(v41_1_0) => string("dice"),
                                    Dice_ui::US20::US20_2 => string("lists"),
                                    Dice_ui::US20::US20_3 => string("settings"),
                                    Dice_ui::US20::US20_4 => string("transactions"),
                                    _ => string(""),
                                };
                                let v54: leptos_router::Url = Dice_ui::method114(v21_1_0.clone());
                                let v56: std::string::String = v54.pathname;
                                let v59: string = Dice_ui::method6(Dice_ui::method18(append(
                                    append(string("/"), v53),
                                    string(""),
                                )));
                                let v61: &str = fable_library_rust::String_::LrcStr::as_str(&v59);
                                let v63: std::string::String = String::from(v61);
                                let v64: std::string::String = Dice_ui::method115(v56);
                                if v64.starts_with(&v63) {
                                    Dice_ui::US23::US23_1(v41.clone())
                                } else {
                                    Dice_ui::US23::US23_0
                                }
                            }
                        };
                        let v72: i32 = v39 + 1_i32;
                        v37.l0.set(v72);
                        v37.l1.set(v71);
                        ()
                    }
                    {
                        let v73: Dice_ui::US23 = v37.l1.get().clone();
                        let v74: Dice_ui::US20 = v34[0_i32].clone();
                        let v77: Dice_ui::US20 = match &v73 {
                            Dice_ui::US23::US23_1(v73_1_0) => v73_1_0.clone(),
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
                            let v83: Dice_ui::US20 = Dice_ui::method116(v77);
                            let v84: leptos::WriteSignal<Dice_ui::US20> = Dice_ui::method117(v1);
                            leptos::SignalSet::set(&v84, v83);
                            ()
                        }
                    }
                }
                Dice_ui::US22::US22_0(v21_0_0) => {
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
        pub fn method109(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US20>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure50(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method121(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
        ) -> leptos::ReadSignal<Dice_ui::US20> {
            v0_1
        }
        pub fn method122(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method123(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method126(
            v0_: bool,
            v0__1: std::string::String,
        ) -> LrcPtr<(bool, std::string::String)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn closure58(
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
                Dice_ui::method126(v1.0.clone(), v1.1.clone());
            let patternInput: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ) = leptos::create_signal(v2);
            LrcPtr::new((v0_1, (patternInput.0.clone(), patternInput.1.clone())))
        }
        pub fn closure57(
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
                    Dice_ui::closure58(v0_1, tupledArg.0.clone(), tupledArg.1.clone())
                }
            })
        }
        pub fn method125() -> Func1<
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
            Func1::new(move |v: i32| Dice_ui::closure57((), v))
        }
        pub fn method127(
            v0_1: Vec<LrcPtr<(bool, std::string::String)>>,
        ) -> Vec<LrcPtr<(bool, std::string::String)>> {
            v0_1
        }
        pub fn closure56(
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
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v6: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method85((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            let v8: LrcPtr<Dice_ui::Heap0> = leptos::SignalGet::get(&v6);
            let v10 = Dice_ui::method125();
            let v11: Vec<LrcPtr<(bool, std::string::String)>> = Dice_ui::method127(v8.l0.clone());
            v11.iter()
                .enumerate()
                .map(|(i, x)| v10(i.try_into().unwrap())(x.clone()))
                .collect()
        }
        pub fn method124(
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
                move || Dice_ui::closure56(v0_1.clone(), ())
            })
        }
        pub fn method128() -> i32 {
            0_i32
        }
        pub fn method130(v0_1: leptos::ReadSignal<i32>) -> leptos::ReadSignal<i32> {
            v0_1
        }
        pub fn method131(
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
        pub fn closure60(
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
        pub fn method132() -> Func1<
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
                    Dice_ui::closure60((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
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
        pub fn closure61(
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
        pub fn method134(
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
                )| Dice_ui::closure61(v0_1, arg10_0040)
            })
        }
        pub fn method135(
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
        pub fn closure59(
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
            let v2: leptos::ReadSignal<i32> = Dice_ui::method130(v1);
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
            > = Dice_ui::method131(v0_1);
            let v7: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = v5();
            let v8 = Dice_ui::method132();
            let v9: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = Dice_ui::method133(v7);
            let v11: Vec<(
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            )> = v9.iter().map(|x| v8(x.clone())).collect();
            let v12 = Dice_ui::method134(v4);
            let v13: Vec<(
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            )> = Dice_ui::method135(v11);
            v13.iter().map(|x| v12(x.clone())).collect()
        }
        pub fn method129(
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
                move || Dice_ui::closure59(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method137(
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
        pub fn method138(
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
        pub fn closure62(
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
            > = Dice_ui::method137(v0_1);
            let v4: Vec<(
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            )> = Dice_ui::method138(v1());
            count(fable_library_rust::NativeArray_::array_from(v4))
        }
        pub fn method136(
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
                move || Dice_ui::closure62(v0_1.clone(), ())
            })
        }
        pub fn method142(
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
        pub fn method143(
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
        pub fn method144(
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
        pub fn method146(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        ) -> leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> {
            v0_1
        }
        pub fn closure66(
            unitVar: (),
            v0_: i32,
            v0__1: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> LrcPtr<(bool, std::string::String)> {
            let v4: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> =
                Dice_ui::method146(((LrcPtr::new((v0_, v0__1))).1.clone()).0.clone());
            leptos::SignalGet::get(&v4)
        }
        pub fn method145() -> Func1<
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
                    Dice_ui::closure66((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn closure65(
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
            > = Dice_ui::method131(v0_1);
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
            > = Dice_ui::method142(v6.clone());
            let v10: i32 = count(fable_library_rust::NativeArray_::array_from(v7));
            let v12: string = Dice_ui::method6(Dice_ui::method5());
            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
            let v17: LrcPtr<(bool, std::string::String)> = LrcPtr::new((false, String::from(v14)));
            let v18: LrcPtr<(bool, std::string::String)> =
                Dice_ui::method126(v17.0.clone(), v17.1.clone());
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
            )> = Dice_ui::method143(v22.0.clone(), v22.1.clone());
            let v24: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = Dice_ui::method144(v6);
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
                let v29 = Dice_ui::method145();
                let v30: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                > = Dice_ui::method133(v28);
                LrcPtr::new(Dice_ui::Heap0 {
                    l0: v30.iter().map(|x| v29(x.clone())).collect(),
                    l1: v1.l1.clone(),
                })
            }
        }
        pub fn method141(
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
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure65(v0_1.clone(), v)
            })
        }
        pub fn closure67(unitVar: (), v0_1: i32) -> i32 {
            1_i32 + v0_1
        }
        pub fn method147() -> Func1<i32, i32> {
            Func1::new(move |v: i32| Dice_ui::closure67((), v))
        }
        pub fn method148(v0_1: leptos::WriteSignal<i32>) -> leptos::WriteSignal<i32> {
            v0_1
        }
        pub fn closure64(
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
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v6: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v4);
            let v8 = Dice_ui::method141(v1);
            let v9: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method71(v6.l1.clone());
            leptos::SignalUpdate::update(&v9, |x| *x = v8(x.clone()));
            {
                let v11 = Dice_ui::method147();
                let v12: leptos::WriteSignal<i32> = Dice_ui::method148(v2);
                leptos::SignalUpdate::update(&v12, |x| *x = v11(x.clone()));
                ()
            }
        }
        pub fn method140(
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
                move || Dice_ui::closure64(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn closure63(
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
            let v3 = Dice_ui::method140(v0_1, v1, v2);
            let v6: Func0<()> = Dice_ui::method72(Func0::new(move || v3()));
            leptos::batch(move || v6());
            ()
        }
        pub fn method139(
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
                move || Dice_ui::closure63(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method149() -> string {
            string("h-5 w-5")
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method151() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure69((), ()))
        }
        pub fn method152(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method154(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method155(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure70(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method154(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method155(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method153(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure70(v0_1.clone(), ())
            })
        }
        pub fn method156(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Path>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Path>> {
            v0_1
        }
        pub fn method158(
            v0_1: leptos::HtmlElement<leptos::svg::Path>,
        ) -> leptos::HtmlElement<leptos::svg::Path> {
            v0_1
        }
        pub fn closure71(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::svg::Path>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method158(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method157() -> Func1<leptos::HtmlElement<leptos::svg::Path>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::svg::Path>| Dice_ui::closure71((), v))
        }
        pub fn method159(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Path>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Path>> {
            v0_1
        }
        pub fn method160(v0_1: Vec<leptos::View>) -> Vec<leptos::View> {
            v0_1
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string =
                string(" d=\"M12 6v12m6-6H6\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method156(new_array(
                &[
                    leptos::view! {
                        <path d="M12 6v12m6-6H6" stroke-linejoin="round" stroke-linecap="round">
                            {v9()}
                        </path>
                    },
                ],
            ));
            let v17 = Dice_ui::method157();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method159(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method160(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method150() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure68((), ()))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> &'static str {
            let v1: string = string("r#\" bg-gray-100\"#");
            r#" bg-gray-100"#
        }
        pub fn method161() -> Func0<&'static str> {
            Func0::new(move || Dice_ui::closure72((), ()))
        }
        pub fn method163(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn closure73(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(v0_1);
            let v6: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v1),
            ])));
            let v8: Vec<leptos::View> = v6.to_vec();
            leptos::Fragment::new(v8)
        }
        pub fn method162(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure73(v0_1.clone(), ())
            })
        }
        pub fn method164(
            v0_1: leptos::HtmlElement<leptos::html::Button>,
        ) -> leptos::HtmlElement<leptos::html::Button> {
            v0_1
        }
        pub fn method165() -> string {
            string("Accounts")
        }
        pub fn method166(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method167(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method169(
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
        pub fn closure75(
            unitVar: (),
            _arg: (
                i32,
                i32,
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> (i32, i32) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn method170() -> Func1<
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
                )| Dice_ui::closure75((), arg10_0040),
            )
        }
        pub fn method173(v0_1: i32) -> i32 {
            v0_1
        }
        pub fn method176(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn method178(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn closure81(
            v0_1: i32,
            v1: i32,
            v2_: bool,
            v2__1: std::string::String,
        ) -> LrcPtr<(bool, std::string::String)> {
            let v2: LrcPtr<(bool, std::string::String)> = LrcPtr::new((v2_, v2__1));
            if Dice_ui::method178(v1 == v0_1) {
                v2.clone()
            } else {
                LrcPtr::new((v2.0.clone() == false, v2.1.clone()))
            }
        }
        pub fn closure80(
            v0_1: i32,
            v1: i32,
        ) -> Func1<LrcPtr<(bool, std::string::String)>, LrcPtr<(bool, std::string::String)>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |tupledArg: LrcPtr<(bool, std::string::String)>| {
                    Dice_ui::closure81(v0_1, v1, tupledArg.0.clone(), tupledArg.1.clone())
                }
            })
        }
        pub fn method177(
            v0_1: i32,
        ) -> Func1<
            i32,
            Func1<LrcPtr<(bool, std::string::String)>, LrcPtr<(bool, std::string::String)>>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: i32| Dice_ui::closure80(v0_1, v)
            })
        }
        pub fn method179(v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
            v0_1
        }
        pub fn method180(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure79(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32, v2: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v3.clone());
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method176((leptos::SignalGetUntracked::get_untracked(&v4)).l1.clone());
            let v10: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v8);
            let v13: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v3);
            let v15: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v13);
            let v17 = Dice_ui::method177(v1);
            let v18: Vec<LrcPtr<(bool, std::string::String)>> = Dice_ui::method127(v10.l0.clone());
            let v22: LrcPtr<Dice_ui::Heap0> = Dice_ui::method179(LrcPtr::new(Dice_ui::Heap0 {
                l0: v18
                    .iter()
                    .enumerate()
                    .map(|(i, x)| v17(i.try_into().unwrap())(x.clone()))
                    .collect(),
                l1: v10.l1.clone(),
            }));
            let v23: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method180(v15.l1.clone());
            leptos::SignalSet::set(&v23, v22);
            ()
        }
        pub fn method175(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure79(v0_1.clone(), v1, v)
            })
        }
        pub fn closure82(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            unitVar: (),
        ) -> bool {
            let v1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> =
                Dice_ui::method146(v0_1);
            (leptos::SignalGet::get(&v1)).0.clone()
        }
        pub fn method181(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        ) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure82(v0_1.clone(), ())
            })
        }
        pub fn method182(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method156(new_array(
                &[
                    leptos::view! {
                        <path
                            clip-rule="evenodd"
                            d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z"
                            fill-rule="evenodd"
                        >
                            {v9()}
                        </path>
                    },
                ],
            ));
            let v17 = Dice_ui::method157();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method159(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method160(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method184() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure84((), ()))
        }
        pub fn closure85(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method156(new_array(
                &[
                    leptos::view! {
                        <path
                            clip-rule="evenodd"
                            d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z"
                            fill-rule="evenodd"
                        >
                            {v9()}
                        </path>
                    },
                ],
            ));
            let v17 = Dice_ui::method157();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method159(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method160(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method185() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure85((), ()))
        }
        pub fn method186(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Svg>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Svg>> {
            v0_1
        }
        pub fn closure86(unitVar: (), v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method187() -> Func1<leptos::HtmlElement<leptos::svg::Svg>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::svg::Svg>| Dice_ui::closure86((), v))
        }
        pub fn method188(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Svg>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Svg>> {
            v0_1
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v11: string =
                string(" fill=\"currentColor\" viewBox=\"0 0 20 20\" class=\"h-4 w-4\" xmlns=\"http://www.w3.org/2000/svg\" data-unchecked-icon");
            let v13 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method184()));
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
            let v18: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                <svg
                    fill="currentColor"
                    viewBox="0 0 20 20"
                    class="h-4 w-4"
                    xmlns="http://www.w3.org/2000/svg"
                    data-unchecked-icon
                >
                    {v13()}
                </svg>
            };
            let v29: string =
                string(" fill=\"currentColor\" viewBox=\"0 0 20 20\" class=\"hidden h-4 w-4\" xmlns=\"http://www.w3.org/2000/svg\" data-checked-icon");
            let v31 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method185()));
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
            let v37: Array<leptos::HtmlElement<leptos::svg::Svg>> = Dice_ui::method186(new_array(
                &[
                    v18,
                    leptos::view! {
                        <svg
                            fill="currentColor"
                            viewBox="0 0 20 20"
                            class="hidden h-4 w-4"
                            xmlns="http://www.w3.org/2000/svg"
                            data-checked-icon
                        >
                            {v31()}
                        </svg>
                    },
                ],
            ));
            let v38 = Dice_ui::method187();
            let v39: Array<leptos::HtmlElement<leptos::svg::Svg>> = Dice_ui::method188(v37);
            let v41: Vec<leptos::HtmlElement<leptos::svg::Svg>> = v39.to_vec();
            let v44: Vec<leptos::View> =
                Dice_ui::method160(v41.iter().map(|x| v38(x.clone())).collect());
            let v47: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v44));
            let v49: Vec<leptos::View> = v47.to_vec();
            leptos::Fragment::new(v49)
        }
        pub fn method183() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure83((), ()))
        }
        pub fn method189(
            v0_1: leptos::HtmlElement<leptos::html::Span>,
        ) -> leptos::HtmlElement<leptos::html::Span> {
            v0_1
        }
        pub fn closure87(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method190() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure87((), ()))
        }
        pub fn closure78(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            v1: LrcPtr<Dice_ui::Heap2>,
            v2: i32,
            v3: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4 = Dice_ui::method175(v1, v2);
            let on_change = v4;
            {
                let v6 = Dice_ui::method181(v0_1);
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
                    let v24: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method182(
                        leptos::view! {
                            <input
                                prop:checked=move || get_value()
                                on:change=move |event| on_change(event)
                                id=v3
                                type="checkbox"
                                class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden"
                            />
                        },
                    );
                    let v26: leptos::View = leptos::IntoView::into_view(v24);
                    let v27: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v29: string =
                        append(append(append(string(" "), v27), string("")), string(""));
                    let v31 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method183()));
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
                    let v37: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">
                                {v31()}
                            </span>
                        },
                    );
                    let v39: leptos::View = leptos::IntoView::into_view(v37);
                    let v40: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v42: string =
                        append(append(append(string(" "), v40), string("")), string(""));
                    let v44 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method190()));
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
                    let v49: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">
                                {v44()}
                            </span>
                        },
                    );
                    let v54: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            v26,
                            v39,
                            leptos::IntoView::into_view(v49),
                        ])));
                    let v56: Vec<leptos::View> = v54.to_vec();
                    leptos::Fragment::new(v56)
                }
            }
        }
        pub fn method174(
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
                move || Dice_ui::closure78(v0_1.clone(), v1.clone(), v2, v3.clone(), ())
            })
        }
        pub fn method191(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn closure88(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
            unitVar: (),
        ) -> std::string::String {
            let v1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>> =
                Dice_ui::method146(v0_1);
            (leptos::SignalGet::get(&v1)).1.clone()
        }
        pub fn method192(
            v0_1: leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
        ) -> Func0<std::string::String> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure88(v0_1.clone(), ())
            })
        }
        pub fn method195(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn closure91(
            v0_1: i32,
            v1: std::string::String,
            v2: i32,
            v3_: bool,
            v3__1: std::string::String,
        ) -> LrcPtr<(bool, std::string::String)> {
            let v3: LrcPtr<(bool, std::string::String)> = LrcPtr::new((v3_, v3__1));
            if Dice_ui::method195(v2 == v0_1) {
                v3.clone()
            } else {
                LrcPtr::new((v3.0.clone(), v1))
            }
        }
        pub fn closure90(
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
                    Dice_ui::closure91(
                        v0_1,
                        v1.clone(),
                        v2,
                        tupledArg.0.clone(),
                        tupledArg.1.clone(),
                    )
                }
            })
        }
        pub fn method194(
            v0_1: i32,
            v1: std::string::String,
        ) -> Func1<
            i32,
            Func1<LrcPtr<(bool, std::string::String)>, LrcPtr<(bool, std::string::String)>>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: i32| Dice_ui::closure90(v0_1, v1.clone(), v)
            })
        }
        pub fn closure89(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32, v2: std::string::String) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = v0_1.l0.clone();
            let v4: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v3.clone());
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method176((leptos::SignalGetUntracked::get_untracked(&v4)).l1.clone());
            let v10: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v8);
            let v13: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v3);
            let v15: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v13);
            let v17 = Dice_ui::method194(v1, v2);
            let v18: Vec<LrcPtr<(bool, std::string::String)>> = Dice_ui::method127(v10.l0.clone());
            let v22: LrcPtr<Dice_ui::Heap0> = Dice_ui::method179(LrcPtr::new(Dice_ui::Heap0 {
                l0: v18
                    .iter()
                    .enumerate()
                    .map(|(i, x)| v17(i.try_into().unwrap())(x.clone()))
                    .collect(),
                l1: v10.l1.clone(),
            }));
            let v23: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method180(v15.l1.clone());
            leptos::SignalSet::set(&v23, v22);
            ()
        }
        pub fn method193(v0_1: LrcPtr<Dice_ui::Heap2>, v1: i32) -> Func1<std::string::String, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: std::string::String| Dice_ui::closure89(v0_1.clone(), v1, v)
            })
        }
        pub fn method196(v0_1: leptos::Memo<i32>) -> leptos::Memo<i32> {
            v0_1
        }
        pub fn method200(
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
        pub fn closure96(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method202() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure96((), v))
        }
        pub fn closure95(
            v0_1: i32,
            v1_: i32,
            v1__1: (
                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
            ),
        ) -> bool {
            let v5: bool = (LrcPtr::new((v1_, v1__1))).0.clone() == v0_1;
            (Dice_ui::method202())(v5)
        }
        pub fn method201(
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
                    Dice_ui::closure95(v0_1, tupledArg.0.clone(), tupledArg.1.clone())
                }
            })
        }
        pub fn closure94(
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
            > = Dice_ui::method131(v0_1);
            let v8: Vec<
                LrcPtr<(
                    i32,
                    (
                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                    ),
                )>,
            > = Dice_ui::method200(v5());
            let v9 = Dice_ui::method201(v1);
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
                let v14 = Dice_ui::method145();
                let v15: Vec<
                    LrcPtr<(
                        i32,
                        (
                            leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                        ),
                    )>,
                > = Dice_ui::method133(v13);
                LrcPtr::new(Dice_ui::Heap0 {
                    l0: v15.iter().map(|x| v14(x.clone())).collect(),
                    l1: v2.l1.clone(),
                })
            }
        }
        pub fn method199(
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
                move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure94(v0_1.clone(), v1, v)
            })
        }
        pub fn closure93(
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
            let v5: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v7: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v5);
            let v9 = Dice_ui::method199(v1, v3);
            let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method71(v7.l1.clone());
            leptos::SignalUpdate::update(&v10, |x| *x = v9(x.clone()));
            {
                let v12 = Dice_ui::method147();
                let v13: leptos::WriteSignal<i32> = Dice_ui::method148(v2);
                leptos::SignalUpdate::update(&v13, |x| *x = v12(x.clone()));
                ()
            }
        }
        pub fn method198(
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
                move || Dice_ui::closure93(v0_1.clone(), v1.clone(), v2.clone(), v3, ())
            })
        }
        pub fn closure92(
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
            let v4 = Dice_ui::method198(v0_1, v1, v2, v3);
            let v7: Func0<()> = Dice_ui::method72(Func0::new(move || v4()));
            leptos::batch(move || v7());
            ()
        }
        pub fn method197(
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
                move || Dice_ui::closure92(v0_1.clone(), v1.clone(), v2.clone(), v3, ())
            })
        }
        pub fn closure97(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string = string(
                " d=\"M6 6l12 12m0-12L6 18\" stroke-linejoin=\"round\" stroke-linecap=\"round\"",
            );
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method156(new_array(
                &[
                    leptos::view! {
                        <path
                            d="M6 6l12 12m0-12L6 18"
                            stroke-linejoin="round"
                            stroke-linecap="round"
                        >
                            {v9()}
                        </path>
                    },
                ],
            ));
            let v17 = Dice_ui::method157();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method159(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method160(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method203() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure97((), ()))
        }
        pub fn closure98(unitVar: (), unitVar_1: ()) -> &'static str {
            let v1: string = string("r#\" pr-[7px] pl-[5px]\"#");
            r#" pr-[7px] pl-[5px]"#
        }
        pub fn method204() -> Func0<&'static str> {
            Func0::new(move || Dice_ui::closure98((), ()))
        }
        pub fn closure77(
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
            let v6: i32 = Dice_ui::method173(v5);
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
                let v22 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method174(
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
                let v28: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method191(
                    leptos::view! {
                        <label
                            class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"
                            for=id
                        >
                            {v22()}
                        </label>
                    },
                );
                let v30: leptos::View = leptos::IntoView::into_view(v28);
                let v31 = Dice_ui::method192(v4);
                let v32 = Dice_ui::method193(v0_1.clone(), v6);
                let v33: string = string("r#\"\"#");
                let v34: &str = r#""#;
                let v43: string =
                    string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v32(leptos::event_target_value(&event)) prop:value=move || v31() class=\"bg-gray-50 flex-1 h-[27px]\".to_owned() + v34 /> }");
                let v46: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method182(
                    leptos::view! {
                        <input
                            on:keyup=move |event: web_sys::KeyboardEvent| v32(
                                leptos::event_target_value(&event),
                            )
                            prop:value=move || v31()
                            class="bg-gray-50 flex-1 h-[27px]".to_owned() + v34
                        />
                    },
                );
                let v48: leptos::View = leptos::IntoView::into_view(v46);
                let v49: leptos::Memo<i32> = Dice_ui::method196(v1);
                let v107: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(
                    &[
                        v30,
                        v48,
                        if v49() == 1_i32 {
                            let v56: Array<leptos::View> = Dice_ui::method167(Dice_ui::method166(
                                Dice_ui::method122(new_empty::<leptos::View>()),
                            ));
                            leptos::CollectView::collect_view(v56.to_vec())
                        } else {
                            let v59 = Dice_ui::method197(v0_1, v2, v3, v6);
                            let on_click = v59;
                            {
                                let v61: string = Dice_ui::method149();
                                let v63: &str = fable_library_rust::String_::LrcStr::as_str(&v61);
                                let v64: string = string("r#\"\"#");
                                let v65: &str = r#""#;
                                let v78:
                                                                                      string =
                                                                                  string(" class=\" \".to_owned() + v63 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                                let v80 =
                                    Dice_ui::method153(Dice_ui::method152(Dice_ui::method203()));
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
                                let v85: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                                    <svg
                                        class=" ".to_owned() + v63
                                        stroke="currentColor"
                                        stroke-width="1.5"
                                        viewBox="0 0 24 24"
                                        fill="none"
                                        xmlns="http://www.w3.org/2000/svg"
                                    >
                                        {v80()}
                                    </svg>
                                };
                                let v88 = Dice_ui::method204();
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
                                    Dice_ui::method153(Dice_ui::method152(Dice_ui::method162(v85)));
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
                                    Dice_ui::method164(
                                        leptos::view! {
                                            <button
                                                aria-label="Delete"
                                                on:click=move |_| on_click()
                                                class=move || {
                                                    "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]"
                                                        .to_owned() + v88()
                                                }
                                            >
                                                {v95()}
                                            </button>
                                        },
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
        pub fn method172(
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
                    Dice_ui::closure77(
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
        pub fn method205(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure76(
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
            let v12 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method172(
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
            let v18: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! {
                    <div class="pl-[10px] py-[7px] gap-[7px] pr-[4px] [display:flex] [align-items:center]">
                        {v12()}
                    </div>
                },
            );
            let v23: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v18),
            ])));
            let v25: Vec<leptos::View> = v23.to_vec();
            leptos::Fragment::new(v25)
        }
        pub fn method171(
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
                    Dice_ui::closure76(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), arg10_0040)
                }
            })
        }
        pub fn closure74(
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
            > = Dice_ui::method169(v1);
            let v6 = Dice_ui::method170();
            let v7 = Dice_ui::method171(v0_1, v2, v3, v4);
            let v19: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos::For  children=move |x| v7(x) let:x key=move |x| v6(x.to_owned()) each=v5 /> })");
            let v23: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn method168(
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
                    Dice_ui::closure74(
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
        pub fn closure99(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method154(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method155(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method206(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure99(v0_1.clone(), ())
            })
        }
        pub fn closure101(v0_1: leptos::View, unitVar: ()) -> leptos::Fragment {
            let v3: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_array(&[v0_1])));
            let v5: Vec<leptos::View> = v3.to_vec();
            leptos::Fragment::new(v5)
        }
        pub fn method208(v0_1: leptos::View) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure101(v0_1.clone(), ())
            })
        }
        pub fn method213(v0_1: string) -> string {
            v0_1
        }
        pub fn closure105(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method60(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method212(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure105(v0_1.clone(), ())
            })
        }
        pub fn closure104(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[font-size:14px] [line-height:21px]\"");
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method212(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                leptos::view! { <span class="[font-size:14px] [line-height:21px]">{v6()}</span> },
            );
            let v17: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method211(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure104(v0_1.clone(), ())
            })
        }
        pub fn closure107(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method156(new_array(
                &[
                    leptos::view! {
                        <path
                            clip-rule="evenodd"
                            d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                            fill-rule="evenodd"
                        >
                            {v9()}
                        </path>
                    },
                ],
            ));
            let v17 = Dice_ui::method157();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method159(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method160(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method215() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure107((), ()))
        }
        pub fn closure106(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method6(string("h-5 w-5"));
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: string = string("r#\"\"#");
            let v6: &str = r#""#;
            let v15: string =
                string(" class=\" \".to_owned() + v3 fill=\"currentColor\" viewBox=\"0 0 20 20\" xmlns=\"http://www.w3.org/2000/svg\"");
            let v17 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method215()));
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
            let v23: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(
                leptos::view! {
                    <svg
                        class=" ".to_owned() + v3
                        fill="currentColor"
                        viewBox="0 0 20 20"
                        xmlns="http://www.w3.org/2000/svg"
                    >
                        {v17()}
                    </svg>
                },
            );
            let v28: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method214() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure106((), ()))
        }
        pub fn closure103(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex items-center gap-2\"");
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method211(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="flex items-center gap-2">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string =
                string(" class=\"shrink-0 transition duration-300 group-open:-rotate-180\"");
            let v19 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method214()));
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
            let v25: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                leptos::view! {
                    <span class="shrink-0 transition duration-300 group-open:-rotate-180">
                        {v19()}
                    </span>
                },
            );
            let v30: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method210(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure103(v0_1.clone(), ())
            })
        }
        pub fn method216(
            v0_1: leptos::HtmlElement<leptos::html::Summary>,
        ) -> leptos::HtmlElement<leptos::html::Summary> {
            v0_1
        }
        pub fn closure108(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            v0_1()
        }
        pub fn method217(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure108(v0_1.clone(), ())
            })
        }
        pub fn closure102(
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
            let v14 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method210(v1)));
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
            let v20: leptos::HtmlElement<leptos::html::Summary> = Dice_ui::method216(
                leptos::view! {
                    <summary class="group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"
                        .to_owned() + v8>{v14()}</summary>
                },
            );
            let v22: leptos::View = leptos::IntoView::into_view(v20);
            let v25: string = string(" class=\"flex flex-1 flex-col\"");
            let v27 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method217(v2)));
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
            let v33: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="flex flex-1 flex-col">{v27()}</div> },
            );
            let v38: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v22,
                leptos::IntoView::into_view(v33),
            ])));
            let v40: Vec<leptos::View> = v38.to_vec();
            leptos::Fragment::new(v40)
        }
        pub fn method209(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure102(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method218(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn closure100(
            v0_1: leptos::View,
            v1: std::string::String,
            v2: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"[position:absolute] [right:0] [top:0]\"");
            let v8 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method208(v0_1.clone())));
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
            let v14: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="[position:absolute] [right:0] [top:0]">{v8()}</div> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(
                " open=true class=\"flex flex-1 group [&_summary::-webkit-details-marker]:hidden\"",
            );
            let v23 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method209(v0_1, v1, v2)));
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
            let v29: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method218(
                leptos::view! {
                    <details
                        open=true
                        class="flex flex-1 group [&_summary::-webkit-details-marker]:hidden"
                    >
                        {v23()}
                    </details>
                },
            );
            let v34: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method207(
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
        pub fn method219() -> string {
            string("View")
        }
        pub fn method222() -> string {
            string("Dark Mode")
        }
        pub fn closure110(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method222()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method221() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure110((), ()))
        }
        pub fn method224() -> string {
            string("dark-mode")
        }
        pub fn closure114(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method227() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure114((), v))
        }
        pub fn closure113(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method227();
            let v8: leptos::RwSignal<bool> = Dice_ui::method66(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method226(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure113(v0_1.clone(), v)
            })
        }
        pub fn closure115(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method83((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method228(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure115(v0_1.clone(), ())
            })
        }
        pub fn closure112(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method226(v0_1.clone());
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
                    let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method182(
                        leptos::view! {
                            <input
                                prop:checked=move || get_value()
                                on:change=move |event| on_change(event)
                                id=v1
                                type="checkbox"
                                class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden"
                            />
                        },
                    );
                    let v24: leptos::View = leptos::IntoView::into_view(v22);
                    let v25: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v27: string =
                        append(append(append(string(" "), v25), string("")), string(""));
                    let v29 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method183()));
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
                    let v35: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">
                                {v29()}
                            </span>
                        },
                    );
                    let v37: leptos::View = leptos::IntoView::into_view(v35);
                    let v38: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v40: string =
                        append(append(append(string(" "), v38), string("")), string(""));
                    let v42 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method190()));
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
                    let v47: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">
                                {v42()}
                            </span>
                        },
                    );
                    let v52: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            v24,
                            v37,
                            leptos::IntoView::into_view(v47),
                        ])));
                    let v54: Vec<leptos::View> = v52.to_vec();
                    leptos::Fragment::new(v54)
                }
            }
        }
        pub fn method225(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure112(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure111(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method224());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let id = v6.clone();
            {
                let v13: string =
                    string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=id");
                let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method225(v0_1, v6)));
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
                let v21: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method191(
                    leptos::view! {
                        <label
                            class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"
                            for=id
                        >
                            {v15()}
                        </label>
                    },
                );
                let v26: Array<leptos::View> =
                    Dice_ui::method123(Dice_ui::method122(new_array(&[
                        leptos::IntoView::into_view(v21),
                    ])));
                let v28: Vec<leptos::View> = v26.to_vec();
                leptos::Fragment::new(v28)
            }
        }
        pub fn method223(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure111(v0_1.clone(), ())
            })
        }
        pub fn method230(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method231(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn method232(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn closure116(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"[font-size:12px] text-gray-400\"");
            let v7 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method230(v0_1)));
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
            let v13: leptos::HtmlElement<leptos::html::Dt> = Dice_ui::method231(
                leptos::view! { <dt class="[font-size:12px] text-gray-400">{v7()}</dt> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1\"");
            let v20 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method230(v1)));
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
            let v26: leptos::HtmlElement<leptos::html::Dd> = Dice_ui::method232(
                leptos::view! { <dd class="[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1">{v20()}</dd> },
            );
            let v31: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v15,
                leptos::IntoView::into_view(v26),
            ])));
            let v33: Vec<leptos::View> = v31.to_vec();
            leptos::Fragment::new(v33)
        }
        pub fn method229(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure116(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method234() -> string {
            string("Debug")
        }
        pub fn closure117(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method234()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method233() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure117((), ()))
        }
        pub fn method236() -> string {
            string("debug")
        }
        pub fn closure120(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method227();
            let v8: leptos::RwSignal<bool> = Dice_ui::method66(v5.l2.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method238(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure120(v0_1.clone(), v)
            })
        }
        pub fn closure121(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method83((leptos::SignalGetUntracked::get_untracked(&v2)).l2.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method239(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure121(v0_1.clone(), ())
            })
        }
        pub fn closure119(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method238(v0_1.clone());
            let on_change = v2;
            {
                let v4 = Dice_ui::method239(v0_1);
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
                    let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method182(
                        leptos::view! {
                            <input
                                prop:checked=move || get_value()
                                on:change=move |event| on_change(event)
                                id=v1
                                type="checkbox"
                                class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden"
                            />
                        },
                    );
                    let v24: leptos::View = leptos::IntoView::into_view(v22);
                    let v25: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v27: string =
                        append(append(append(string(" "), v25), string("")), string(""));
                    let v29 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method183()));
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
                    let v35: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">
                                {v29()}
                            </span>
                        },
                    );
                    let v37: leptos::View = leptos::IntoView::into_view(v35);
                    let v38: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v40: string =
                        append(append(append(string(" "), v38), string("")), string(""));
                    let v42 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method190()));
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
                    let v47: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">
                                {v42()}
                            </span>
                        },
                    );
                    let v52: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            v24,
                            v37,
                            leptos::IntoView::into_view(v47),
                        ])));
                    let v54: Vec<leptos::View> = v52.to_vec();
                    leptos::Fragment::new(v54)
                }
            }
        }
        pub fn method237(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure119(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure118(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method236());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let id = v6.clone();
            {
                let v13: string =
                    string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=id");
                let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method237(v0_1, v6)));
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
                let v21: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method191(
                    leptos::view! {
                        <label
                            class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"
                            for=id
                        >
                            {v15()}
                        </label>
                    },
                );
                let v26: Array<leptos::View> =
                    Dice_ui::method123(Dice_ui::method122(new_array(&[
                        leptos::IntoView::into_view(v21),
                    ])));
                let v28: Vec<leptos::View> = v26.to_vec();
                leptos::Fragment::new(v28)
            }
        }
        pub fn method235(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure118(v0_1.clone(), ())
            })
        }
        pub fn method240(
            v0_1: Array<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn method242(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure122(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method241() -> Func1<leptos::HtmlElement<leptos::html::Dl>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Dl>| Dice_ui::closure122((), v))
        }
        pub fn method243(
            v0_1: Array<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn closure109(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v10: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v12 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method221(),
                Dice_ui::method223(v0_1.clone()),
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
            let v26 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method233(),
                Dice_ui::method235(v0_1),
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
            let v32: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method240(new_array(
                &[
                    v17,
                    leptos::view! {
                        <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">
                            {v26()}
                        </dl>
                    },
                ],
            ));
            let v33 = Dice_ui::method241();
            let v34: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method243(v32);
            let v36: Vec<leptos::HtmlElement<leptos::html::Dl>> = v34.to_vec();
            let v39: Vec<leptos::View> =
                Dice_ui::method160(v36.iter().map(|x| v33(x.clone())).collect());
            let v42: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v39));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method220(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure109(v0_1.clone(), ())
            })
        }
        pub fn closure124(
            v0_1: std::string::String,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string("r#\"\"#");
            let v7: &str = r#""#;
            let v8: string =
                string("class=\"group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\".to_owned() + v7");
            let v10: string = append(append(append(string(" "), v8), string("")), string(""));
            let v12 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method210(v0_1)));
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
            let v18: leptos::HtmlElement<leptos::html::Summary> = Dice_ui::method216(
                leptos::view! {
                    <summary class="group flex flex-1 items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"
                        .to_owned() + v7>{v12()}</summary>
                },
            );
            let v20: leptos::View = leptos::IntoView::into_view(v18);
            let v23: string = string(" class=\"flex flex-1 flex-col\"");
            let v25 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method217(v1)));
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
            let v31: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="flex flex-1 flex-col">{v25()}</div> },
            );
            let v36: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v20,
                leptos::IntoView::into_view(v31),
            ])));
            let v38: Vec<leptos::View> = v36.to_vec();
            leptos::Fragment::new(v38)
        }
        pub fn method245(
            v0_1: std::string::String,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure124(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure123(
            v0_1: std::string::String,
            v1: leptos::View,
            v2: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"[position:absolute] [right:0] [top:0]\"");
            let v8 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method208(v1)));
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
            let v14: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="[position:absolute] [right:0] [top:0]">{v8()}</div> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(
                " open=true class=\"flex flex-1 group [&_summary::-webkit-details-marker]:hidden\"",
            );
            let v23 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method245(v0_1, v2)));
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
            let v29: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method218(
                leptos::view! {
                    <details
                        open=true
                        class="flex flex-1 group [&_summary::-webkit-details-marker]:hidden"
                    >
                        {v23()}
                    </details>
                },
            );
            let v34: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method244(
            v0_1: std::string::String,
            v1: leptos::View,
            v2: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure123(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method246() -> string {
            string("Debug")
        }
        pub fn method249() -> string {
            string("Global State")
        }
        pub fn closure126(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method249()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method248() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure126((), ()))
        }
        pub fn method252(v0_1: LrcPtr<Dice_ui::Heap2>) -> LrcPtr<Dice_ui::Heap2> {
            v0_1
        }
        pub fn closure129(unitVar: (), v0_1: std::string::String) -> Dice_ui::US25 {
            Dice_ui::US25::US25_1(v0_1)
        }
        pub fn closure130(unitVar: (), v0_1: std::string::String) -> Dice_ui::US25 {
            Dice_ui::US25::US25_0(v0_1)
        }
        pub fn closure128(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> string {
            let v2: string = Dice_ui::method0(string(
                "settings.global_state_log_render () / global_state_json memo",
            ));
            leptos::logging::log!("{}", v2);
            {
                let v4: LrcPtr<Dice_ui::Heap2> = Dice_ui::method252(v0_1);
                let v6: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v4).map_err(|x| x.to_string());
                let v9: Dice_ui::US25 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure130((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure129((), v6_0_0.clone()),
                };
                match &v9 {
                    Dice_ui::US25::US25_1(v9_1_0) => {
                        let v11: std::string::String = Dice_ui::method60(v9_1_0.clone());
                        fable_library_rust::String_::fromString(v11)
                    }
                    Dice_ui::US25::US25_0(v9_0_0) => append(
                        append(string("Error: "), toString(v9_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method251(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure128(v0_1.clone(), ())
            })
        }
        pub fn method253(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn closure131(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v14: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v9),
            ])));
            let v16: Vec<leptos::View> = v14.to_vec();
            leptos::Fragment::new(v16)
        }
        pub fn method254(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure131(v0_1.clone(), ())
            })
        }
        pub fn method255(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure127(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("settings.global_state_log_render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v7 = Dice_ui::method251(v4.unwrap());
                let v10: leptos::Memo<string> =
                    Dice_ui::method253(leptos::create_memo(move |_| v7()));
                let v16: string =
                    string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \"");
                let v18 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method254(v10())));
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
                let v24: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method255(
                    leptos::view! {
                        <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] ">
                            {v18()}
                        </pre>
                    },
                );
                let v29: Array<leptos::View> =
                    Dice_ui::method123(Dice_ui::method122(new_array(&[
                        leptos::IntoView::into_view(v24),
                    ])));
                let v31: Vec<leptos::View> = v29.to_vec();
                leptos::Fragment::new(v31)
            }
        }
        pub fn method250() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure127((), ()))
        }
        pub fn closure125(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] \"");
            let v10 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method248(),
                Dice_ui::method250(),
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
            let v16: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] ">
                        {v10()}
                    </dl>
                },
            );
            let v21: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method247() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure125((), ()))
        }
        pub fn method257(
            v0_1: Vec<LrcPtr<(bool, std::string::String)>>,
        ) -> Vec<LrcPtr<(bool, std::string::String)>> {
            v0_1
        }
        pub fn closure133(
            unitVar: (),
            v0_: bool,
            v0__1: std::string::String,
        ) -> (bool, std::string::String) {
            let v0_1: LrcPtr<(bool, std::string::String)> = LrcPtr::new((v0_, v0__1));
            (v0_1.0.clone(), v0_1.1.clone())
        }
        pub fn method258() -> Func1<LrcPtr<(bool, std::string::String)>, (bool, std::string::String)>
        {
            Func1::new(move |tupledArg: LrcPtr<(bool, std::string::String)>| {
                Dice_ui::closure133((), tupledArg.0.clone(), tupledArg.1.clone())
            })
        }
        pub fn method259(
            v0_1: Vec<(bool, std::string::String)>,
        ) -> Vec<(bool, std::string::String)> {
            v0_1
        }
        pub fn closure134(unitVar: (), _arg: (bool, std::string::String)) -> bool {
            _arg.0.clone()
        }
        pub fn method260() -> Func1<(bool, std::string::String), bool> {
            Func1::new(move |arg10_0040: (bool, std::string::String)| {
                Dice_ui::closure134((), arg10_0040)
            })
        }
        pub fn method261(
            v0_1: Array<(bool, std::string::String)>,
        ) -> Array<(bool, std::string::String)> {
            v0_1
        }
        pub fn closure135(unitVar: (), _arg: (bool, std::string::String)) -> std::string::String {
            _arg.1.clone()
        }
        pub fn method262() -> Func1<(bool, std::string::String), std::string::String> {
            Func1::new(move |arg10_0040: (bool, std::string::String)| {
                Dice_ui::closure135((), arg10_0040)
            })
        }
        pub fn closure136(unitVar: (), v0_1: std::string::String) -> (string, string) {
            let v1: std::string::String = Dice_ui::method60(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            (
                v3.clone(),
                append(
                    append(string("https://api2.nearblocks.io/v1/account/"), v3),
                    string("/txns?&order=desc&page=1&per_page=25"),
                ),
            )
        }
        pub fn method263() -> Func1<std::string::String, (string, string)> {
            Func1::new(move |v: std::string::String| Dice_ui::closure136((), v))
        }
        pub fn method264(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn method265(v0_1: Vec<(string, string)>) -> Vec<(string, string)> {
            v0_1
        }
        pub fn closure132(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> Array<(string, string)> {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v6: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method176((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            let v10: Vec<LrcPtr<(bool, std::string::String)>> =
                Dice_ui::method257((leptos::SignalGetUntracked::get_untracked(&v6)).l0.clone());
            let v12: Array<LrcPtr<(bool, std::string::String)>> =
                fable_library_rust::NativeArray_::array_from(v10);
            let v13 = Dice_ui::method258();
            let v14: Array<LrcPtr<(bool, std::string::String)>> = Dice_ui::method11(v12);
            let v16: Vec<LrcPtr<(bool, std::string::String)>> = v14.to_vec();
            let v19: Vec<(bool, std::string::String)> =
                Dice_ui::method259(v16.iter().map(|x| v13(x.clone())).collect());
            let v21: Array<(bool, std::string::String)> =
                fable_library_rust::NativeArray_::array_from(v19);
            let v22 = Dice_ui::method260();
            let v23: Array<(bool, std::string::String)> = Dice_ui::method261(v21);
            let v25: Vec<(bool, std::string::String)> = v23.to_vec();
            let v28: Vec<(bool, std::string::String)> =
                Dice_ui::method259(v25.into_iter().filter(|x| v22(x.clone().clone())).collect());
            let v30: Array<(bool, std::string::String)> =
                fable_library_rust::NativeArray_::array_from(v28);
            let v31 = Dice_ui::method262();
            let v32: Array<(bool, std::string::String)> = Dice_ui::method261(v30);
            let v34: Vec<(bool, std::string::String)> = v32.to_vec();
            let v37: Vec<std::string::String> =
                Dice_ui::method28(v34.iter().map(|x| v31(x.clone())).collect());
            let v39: Array<std::string::String> = fable_library_rust::NativeArray_::array_from(v37);
            let v40 = Dice_ui::method263();
            let v41: Array<std::string::String> = Dice_ui::method264(v39);
            let v43: Vec<std::string::String> = v41.to_vec();
            let v46: Vec<(string, string)> =
                Dice_ui::method265(v43.iter().map(|x| v40(x.clone())).collect());
            let v48: Array<(string, string)> = fable_library_rust::NativeArray_::array_from(v46);
            let v51: string = Dice_ui::method0(append(
                append(
                    string("transactions.render () / url create_memo / result: "),
                    sprintf!("{:?}", &v48),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v51);
            v48
        }
        pub fn method256(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<Array<(string, string)>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure132(v0_1.clone(), ())
            })
        }
        pub fn method267(
            v0_1: leptos::Memo<Array<(string, string)>>,
        ) -> leptos::Memo<Array<(string, string)>> {
            v0_1
        }
        pub fn closure138(unitVar: (), _arg: (string, string)) -> string {
            _arg.1.clone()
        }
        pub fn method268() -> Func1<(string, string), string> {
            Func1::new(move |arg10_0040: (string, string)| Dice_ui::closure138((), arg10_0040))
        }
        pub fn method269(v0_1: Array<(string, string)>) -> Array<(string, string)> {
            v0_1
        }
        pub fn method270(v0_1: Vec<string>) -> Vec<string> {
            v0_1
        }
        pub fn closure137(
            v0_1: leptos::Memo<Array<(string, string)>>,
            unitVar: (),
        ) -> Array<string> {
            let v1: leptos::Memo<Array<(string, string)>> = Dice_ui::method267(v0_1);
            let v3: Array<(string, string)> = v1();
            let v4 = Dice_ui::method268();
            let v5: Array<(string, string)> = Dice_ui::method269(v3);
            let v7: Vec<(string, string)> = v5.to_vec();
            let v10: Vec<string> = Dice_ui::method270(v7.iter().map(|x| v4(x.clone())).collect());
            fable_library_rust::NativeArray_::array_from(v10)
        }
        pub fn method266(v0_1: leptos::Memo<Array<(string, string)>>) -> Func0<Array<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure137(v0_1.clone(), ())
            })
        }
        pub fn method272(v0_1: leptos::Memo<Array<string>>) -> leptos::Memo<Array<string>> {
            v0_1
        }
        pub fn closure139(v0_1: leptos::Memo<Array<string>>, unitVar: ()) -> Array<string> {
            let v1: leptos::Memo<Array<string>> = Dice_ui::method272(v0_1);
            v1()
        }
        pub fn method271(v0_1: leptos::Memo<Array<string>>) -> Func0<Array<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure139(v0_1.clone(), ())
            })
        }
        pub fn method274(v0_1: string) -> string {
            v0_1
        }
        pub fn method275(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure142(unitVar: (), v0_1: reqwest_wasm::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method276() -> Func1<reqwest_wasm::Error, std::string::String> {
            Func1::new(move |v: reqwest_wasm::Error| Dice_ui::closure142((), v))
        }
        pub fn method277(
            v0_1: Result<reqwest_wasm::Response, reqwest_wasm::Error>,
        ) -> Result<reqwest_wasm::Response, reqwest_wasm::Error> {
            v0_1
        }
        pub fn method278(
            v0_1: Result<std::string::String, reqwest_wasm::Error>,
        ) -> Result<std::string::String, reqwest_wasm::Error> {
            v0_1
        }
        pub fn method279(
            v0_1: Result<Option<string>, std::string::String>,
        ) -> Result<Option<string>, std::string::String> {
            v0_1
        }
        pub fn closure141(
            unitVar: (),
            v0_1: string,
        ) -> std::pin::Pin<
            Box<dyn std::future::Future<Output = Result<Option<string>, std::string::String>>>,
        > {
            let __future_init = Box::pin(async move {
                //;
                {
                    let v4: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method274(v0_1)));
                    let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
                    let v9: std::string::String = Dice_ui::method275(String::from(v6));
                    let v11: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<reqwest_wasm::Response, reqwest_wasm::Error>,
                            >,
                        >,
                    > = Box::pin(
                        reqwest_wasm::Client::builder()
                            .build()
                            .map_err(|err| err.to_string())?
                            .get(v9)
                            .send(),
                    );
                    let v13: Result<reqwest_wasm::Response, reqwest_wasm::Error> = v11.await;
                    let v14 = Dice_ui::method276();
                    let v15: Result<reqwest_wasm::Response, reqwest_wasm::Error> =
                        Dice_ui::method277(v13);
                    let v17: Result<reqwest_wasm::Response, std::string::String> =
                        v15.map_err(|x| v14(x));
                    let v19: reqwest_wasm::Response = v17?;
                    let v21: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<std::string::String, reqwest_wasm::Error>,
                            >,
                        >,
                    > = Box::pin(reqwest_wasm::Response::text(v19));
                    let v23: Result<std::string::String, reqwest_wasm::Error> = v21.await;
                    let v24 = Dice_ui::method276();
                    let v25: Result<std::string::String, reqwest_wasm::Error> =
                        Dice_ui::method278(v23);
                    let v27: Result<std::string::String, std::string::String> =
                        v25.map_err(|x| v24(x));
                    let v30: std::string::String = Dice_ui::method60(v27?);
                    let v35: Result<Option<string>, std::string::String> =
                        Dice_ui::method279(Ok::<Option<string>, std::string::String>(Some(
                            fable_library_rust::String_::fromString(v30),
                        )));
                    v35
                }
            });
            {
                //;
                __future_init
            }
        }
        pub fn method273() -> Func1<
            string,
            std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<Option<string>, std::string::String>>>,
            >,
        > {
            Func1::new(move |v: string| Dice_ui::closure141((), v))
        }
        pub fn method280(v0_1: Vec<string>) -> Vec<string> {
            v0_1
        }
        pub fn method281(
            v0_1: Vec<
                std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<Option<string>, std::string::String>,
                        >,
                    >,
                >,
            >,
        ) -> Vec<
            std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<Option<string>, std::string::String>>>,
            >,
        > {
            v0_1
        }
        pub fn method282(v0_1: Vec<Option<string>>) -> Vec<Option<string>> {
            v0_1
        }
        pub fn method283(
            v0_1: Result<Array<Option<string>>, std::string::String>,
        ) -> Result<Array<Option<string>>, std::string::String> {
            v0_1
        }
        pub fn closure140(
            unitVar: (),
            v0_1: Array<string>,
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                    Output = Result<Array<Option<string>>, std::string::String>,
                >,
            >,
        > {
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
                    let v6: Array<string> = Dice_ui::method27(v0_1);
                    let v8: Vec<string> = v6.to_vec();
                    let v9 = Dice_ui::method273();
                    let v10: Vec<string> = Dice_ui::method280(v8);
                    let v13: Vec<
                        std::pin::Pin<
                            Box<
                                dyn std::future::Future<
                                    Output = Result<Option<string>, std::string::String>,
                                >,
                            >,
                        >,
                    > = Dice_ui::method281(v10.iter().map(|x| v9(x.clone())).collect());
                    let v15: futures::future::TryJoinAll<
                        std::pin::Pin<
                            Box<
                                dyn std::future::Future<
                                    Output = Result<Option<string>, std::string::String>,
                                >,
                            >,
                        >,
                    > = futures::future::try_join_all(v13);
                    let v17: Result<Vec<Option<string>>, std::string::String> = v15.await;
                    let v20: Vec<Option<string>> = Dice_ui::method282(v17?);
                    let v24: Result<Array<Option<string>>, std::string::String> =
                        Dice_ui::method283(Ok::<Array<Option<string>>, std::string::String>(
                            fable_library_rust::NativeArray_::array_from(v20),
                        ));
                    v24
                }
            });
            {
                //;
                __future_init
            }
        }
        pub fn closure143(
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
        pub fn method284(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure143(v0_1.clone(), ())
            })
        }
        pub fn closure144(
            v0_1: leptos::Memo<Array<string>>,
            v1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            unitVar: (),
        ) -> (Option<rexie::Rexie>, Array<string>) {
            let v2: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method24(v1);
            let v4: Option<rexie::Rexie> = leptos::SignalGet::get(&v2);
            let v5: leptos::Memo<Array<string>> = Dice_ui::method272(v0_1);
            (v4, v5())
        }
        pub fn method285(
            v0_1: leptos::Memo<Array<string>>,
            v1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> Func0<(Option<rexie::Rexie>, Array<string>)> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure144(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method287(
            v0_1: Result<Option<LrcPtr<Dice_ui::Heap4>>, borsh::io::Error>,
        ) -> Result<Option<LrcPtr<Dice_ui::Heap4>>, borsh::io::Error> {
            v0_1
        }
        pub fn method288(
            v0_1: Result<Option<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
        ) -> Result<Option<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String> {
            v0_1
        }
        pub fn closure147(
            unitVar: (),
            v0_1: Option<Option<LrcPtr<Dice_ui::Heap4>>>,
        ) -> Dice_ui::US28 {
            Dice_ui::US28::US28_1(v0_1)
        }
        pub fn closure148(unitVar: (), v0_1: std::string::String) -> Dice_ui::US28 {
            Dice_ui::US28::US28_0(v0_1)
        }
        pub fn closure149(unitVar: (), v0_1: Option<LrcPtr<Dice_ui::Heap4>>) -> Dice_ui::US27 {
            Dice_ui::US27::US27_1(v0_1)
        }
        pub fn method289() -> string {
            string("url error 1")
        }
        pub fn method290() -> string {
            string("url error 2")
        }
        pub fn method291(
            v0_1: Result<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String>,
        ) -> Result<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String> {
            v0_1
        }
        pub fn closure146(
            v0_1: Option<rexie::Rexie>,
            v1: string,
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                    Output = Result<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String>,
                >,
            >,
        > {
            let __future_init = Box::pin(async move {
                //;
                {
                    let v5: Dice_ui::US5 = defaultValue(
                        Dice_ui::US5::US5_0,
                        map(
                            Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                            v0_1,
                        ),
                    );
                    let v155: Dice_ui::US26 = if let Dice_ui::US5::US5_1(v5_1_0) = &v5 {
                        let v7: string = append(append(string("url["), v1), string("]"));
                        let v9: string = Dice_ui::method0(append(
                            append(string("state_core.get_data () / id: "), v7.clone()),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v9);
                        let __future_init = Box::pin(async {
                            //;
                            {
                                let v14: Array<string> =
                                    Dice_ui::method25(new_array(&[string("store")]));
                                let v15 = Dice_ui::method26();
                                let v16: Array<string> = Dice_ui::method27(v14);
                                let v18: Vec<string> = v16.to_vec();
                                let v21: Vec<std::string::String> =
                                    Dice_ui::method28(v18.iter().map(|x| v15(x.clone())).collect());
                                let v23: Array<std::string::String> =
                                    fable_library_rust::NativeArray_::array_from(v21);
                                let v24: rexie::Rexie = Dice_ui::method29(match &v5 {
                                    Dice_ui::US5::US5_1(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                                let v26: Result<rexie::Transaction, rexie::Error> =
                                    v24.transaction(&v23, rexie::TransactionMode::ReadOnly);
                                let v27 = Dice_ui::method30();
                                let v28: Result<rexie::Transaction, rexie::Error> =
                                    Dice_ui::method31(v26);
                                let v30: Result<rexie::Transaction, std::string::String> =
                                    v28.map_err(|x| v27(x));
                                let v32: rexie::Transaction = v30?;
                                let v33: string = Dice_ui::method32();
                                let v35: &str = fable_library_rust::String_::LrcStr::as_str(&v33);
                                let v37: Result<rexie::Store, rexie::Error> = v32.store(v35);
                                let v38 = Dice_ui::method33();
                                let v39: Result<rexie::Store, rexie::Error> =
                                    Dice_ui::method34(v37);
                                let v41: Result<rexie::Store, std::string::String> =
                                    v39.map_err(|x| v38(x));
                                let v43: rexie::Store = v41?;
                                let v44: string = Dice_ui::method6(v7);
                                let v46: &str = fable_library_rust::String_::LrcStr::as_str(&v44);
                                let v48: wasm_bindgen::JsValue =
                                    wasm_bindgen::JsValue::from_str(v46);
                                let v50: std::pin::Pin<
                                    Box<
                                        dyn std::future::Future<
                                            Output = Result<wasm_bindgen::JsValue, rexie::Error>,
                                        >,
                                    >,
                                > = Box::pin(rexie::Store::get(&v43, &v48));
                                let v52: Result<wasm_bindgen::JsValue, rexie::Error> = v50.await;
                                let v53 = Dice_ui::method36();
                                let v54: Result<wasm_bindgen::JsValue, rexie::Error> =
                                    Dice_ui::method37(v52);
                                let v56: Result<wasm_bindgen::JsValue, std::string::String> =
                                    v54.map_err(|x| v53(x));
                                let v59: wasm_bindgen::JsValue = Dice_ui::method38(v56?);
                                let v61: Result<
                                    Option<serde_json::Value>,
                                    serde_wasm_bindgen::Error,
                                > = serde_wasm_bindgen::from_value(v59);
                                let v62 = Dice_ui::method39();
                                let v63: Result<
                                    Option<serde_json::Value>,
                                    serde_wasm_bindgen::Error,
                                > = Dice_ui::method40(v61);
                                let v65: Result<Option<serde_json::Value>, std::string::String> =
                                    v63.map_err(|x| v62(x));
                                let v70: Dice_ui::US7 = defaultValue(
                                    Dice_ui::US7::US7_0,
                                    map(
                                        Func1::new(move |v_1: serde_json::Value| {
                                            Dice_ui::closure18((), v_1)
                                        }),
                                        v65?,
                                    ),
                                );
                                let v105: Dice_ui::US27 = match &v70 {
                                    Dice_ui::US7::US7_1(v70_1_0) => {
                                        let v72: serde_json::Value =
                                            Dice_ui::method41(v70_1_0.clone());
                                        let v74: Result<Vec<u8>, serde_json::Error> =
                                            serde_json::from_value(v72);
                                        let v75 = Dice_ui::method42();
                                        let v76: Result<Vec<u8>, serde_json::Error> =
                                            Dice_ui::method43(v74);
                                        let v78: Result<Vec<u8>, std::string::String> =
                                            v76.map_err(|x| v75(x));
                                        let v81: Vec<u8> = Dice_ui::method44(v78?);
                                        let v83: Array<u8> =
                                            fable_library_rust::NativeArray_::array_from(v81);
                                        let v86: string = Dice_ui::method0(append(
                                            append(
                                                string("state_core.get_data () / data_len: "),
                                                toString(count(v83.clone())),
                                            ),
                                            string(""),
                                        ));
                                        leptos::logging::log!("{}", v86);
                                        {
                                            let v88: Array<u8> = Dice_ui::method45(v83);
                                            let v90: Vec<u8> = v88.to_vec();
                                            let v92: &[u8] = v90.as_slice();
                                            let mut v92 = v92;
                                            {
                                                let v95: Result<
                                                    Option<LrcPtr<Dice_ui::Heap4>>,
                                                    borsh::io::Error,
                                                > = borsh::BorshDeserialize::deserialize(&mut v92);
                                                let v96 = Dice_ui::method46();
                                                let v97: Result<
                                                    Option<LrcPtr<Dice_ui::Heap4>>,
                                                    borsh::io::Error,
                                                > = Dice_ui::method287(v95);
                                                let v99: Result<
                                                    Option<LrcPtr<Dice_ui::Heap4>>,
                                                    std::string::String,
                                                > = v97.map_err(|x| v96(x));
                                                Dice_ui::US27::US27_1(v99?)
                                            }
                                        }
                                    }
                                    _ => Dice_ui::US27::US27_0,
                                };
                                let v112: Result<
                                    Option<Option<LrcPtr<Dice_ui::Heap4>>>,
                                    std::string::String,
                                > = Dice_ui::method288(Ok::<
                                    Option<Option<LrcPtr<Dice_ui::Heap4>>>,
                                    std::string::String,
                                >(
                                    match &v105
                                {
                                    Dice_ui::US27::US27_1(v105_1_0) => Some(v105_1_0.clone()),
                                    _ => None::<Option<LrcPtr<Dice_ui::Heap4>>>,
                                }
                                ));
                                v112
                            }
                        });
                        {
                            //;
                            {
                                let v115: std::pin::Pin<
                                    Box<
                                        dyn std::future::Future<
                                            Output = Result<
                                                Option<Option<LrcPtr<Dice_ui::Heap4>>>,
                                                std::string::String,
                                            >,
                                        >,
                                    >,
                                > = __future_init;
                                let v117: Result<
                                    Option<Option<LrcPtr<Dice_ui::Heap4>>>,
                                    std::string::String,
                                > = v115.await;
                                let v120: Dice_ui::US28 = match &v117 {
                                    Err(v117_1_0) => Dice_ui::closure148((), v117_1_0.clone()),
                                    Ok(v117_0_0) => Dice_ui::closure147((), v117_0_0.clone()),
                                };
                                let v129: Dice_ui::US29 = match &v120 {
                                    Dice_ui::US28::US28_1(v120_1_0) => {
                                        Dice_ui::US29::US29_1(defaultValue(
                                            Dice_ui::US27::US27_0,
                                            map(
                                                Func1::new(
                                                    move |v_4: Option<LrcPtr<Dice_ui::Heap4>>| {
                                                        Dice_ui::closure149((), v_4)
                                                    },
                                                ),
                                                v120_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US28::US28_0(v120_0_0) => {
                                        Dice_ui::US29::US29_0(v120_0_0.clone())
                                    }
                                };
                                match &v129 {
                                    Dice_ui::US29::US29_1(v129_1_0) => {
                                        let v130: Dice_ui::US27 = v129_1_0.clone();
                                        if let Dice_ui::US27::US27_1(v130_1_0) = &v130 {
                                            Dice_ui::US26::US26_1(match &v130 {
                                                Dice_ui::US27::US27_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            let v134: string =
                                                Dice_ui::method6(Dice_ui::method289());
                                            let v136: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v134);
                                            Dice_ui::US26::US26_0(String::from(v136))
                                        }
                                    }
                                    Dice_ui::US29::US29_0(v129_0_0) => {
                                        let v141: std::string::String = v129_0_0.clone();
                                        let v143: string =
                                            Dice_ui::method0(append(append(string("state_core.use_request (4.1) / state_data_resource create_local_resource / error: "),
                                                                           toString(v141.clone())),
                                                                    string("")));
                                        leptos::logging::log!("{}", v143);
                                        Dice_ui::US26::US26_0(v141)
                                    }
                                }
                            }
                        }
                    } else {
                        let v149: string = Dice_ui::method6(Dice_ui::method290());
                        let v151: &str = fable_library_rust::String_::LrcStr::as_str(&v149);
                        Dice_ui::US26::US26_0(String::from(v151))
                    };
                    let v162: Result<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String> =
                        Dice_ui::method291(match &v155 {
                            Dice_ui::US26::US26_1(v155_1_0) => {
                                Ok::<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String>(
                                    v155_1_0.clone(),
                                )
                            }
                            Dice_ui::US26::US26_0(v155_0_0) => {
                                Err::<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String>(
                                    v155_0_0.clone(),
                                )
                            }
                        });
                    v162
                }
            });
            {
                //;
                __future_init
            }
        }
        pub fn method286(
            v0_1: Option<rexie::Rexie>,
        ) -> Func1<
            string,
            std::pin::Pin<
                Box<
                    dyn std::future::Future<
                        Output = Result<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String>,
                    >,
                >,
            >,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: string| Dice_ui::closure146(v0_1.clone(), v)
            })
        }
        pub fn method292(
            v0_1: Vec<
                std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String>,
                        >,
                    >,
                >,
            >,
        ) -> Vec<
            std::pin::Pin<
                Box<
                    dyn std::future::Future<
                        Output = Result<Option<LrcPtr<Dice_ui::Heap4>>, std::string::String>,
                    >,
                >,
            >,
        > {
            v0_1
        }
        pub fn method293(
            v0_1: Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
        ) -> Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String> {
            v0_1
        }
        pub fn closure145(
            unitVar: (),
            _arg: (Option<rexie::Rexie>, Array<string>),
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                    Output = Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
                >,
            >,
        > {
            let v1: Array<string> = _arg.1.clone();
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
                        let v8: Array<string> = Dice_ui::method27(v1);
                        let v10: Vec<string> = v8.to_vec();
                        let v11 = Dice_ui::method286(v0_1);
                        let v12: Vec<string> = Dice_ui::method280(v10);
                        let v15: Vec<
                            std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<
                                            Option<LrcPtr<Dice_ui::Heap4>>,
                                            std::string::String,
                                        >,
                                    >,
                                >,
                            >,
                        > = Dice_ui::method292(v12.iter().map(|x| v11(x.clone())).collect());
                        let v17: futures::future::TryJoinAll<
                            std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<
                                            Option<LrcPtr<Dice_ui::Heap4>>,
                                            std::string::String,
                                        >,
                                    >,
                                >,
                            >,
                        > = futures::future::try_join_all(v15);
                        let v19: Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String> =
                            v17.await;
                        let v23: Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String> =
                            Dice_ui::method293(Ok::<
                                Vec<Option<LrcPtr<Dice_ui::Heap4>>>,
                                std::string::String,
                            >(v19?));
                        v23
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
        pub fn method295(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            >,
        ) -> leptos::Resource<
            (Option<rexie::Rexie>, Array<string>),
            Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
        > {
            v0_1
        }
        pub fn closure151(
            unitVar: (),
            v0_1: Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
        ) -> Dice_ui::US33 {
            Dice_ui::US33::US33_1(v0_1)
        }
        pub fn closure152(unitVar: (), v0_1: Vec<Option<LrcPtr<Dice_ui::Heap4>>>) -> Dice_ui::US34 {
            Dice_ui::US34::US34_1(v0_1)
        }
        pub fn closure153(unitVar: (), v0_1: std::string::String) -> Dice_ui::US34 {
            Dice_ui::US34::US34_0(v0_1)
        }
        pub fn method296(
            v0_1: Vec<Option<LrcPtr<Dice_ui::Heap4>>>,
        ) -> Vec<Option<LrcPtr<Dice_ui::Heap4>>> {
            v0_1
        }
        pub fn closure155(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap4>) -> Dice_ui::US31 {
            Dice_ui::US31::US31_1(v0_1)
        }
        pub fn closure154(unitVar: (), v0_1: Option<LrcPtr<Dice_ui::Heap4>>) -> Dice_ui::US31 {
            defaultValue(
                Dice_ui::US31::US31_0,
                map(
                    Func1::new(move |v: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure155((), v)),
                    v0_1,
                ),
            )
        }
        pub fn method297() -> Func1<Option<LrcPtr<Dice_ui::Heap4>>, Dice_ui::US31> {
            Func1::new(move |v: Option<LrcPtr<Dice_ui::Heap4>>| Dice_ui::closure154((), v))
        }
        pub fn method298(
            v0_1: Array<Option<LrcPtr<Dice_ui::Heap4>>>,
        ) -> Array<Option<LrcPtr<Dice_ui::Heap4>>> {
            v0_1
        }
        pub fn method299(v0_1: Vec<Dice_ui::US31>) -> Vec<Dice_ui::US31> {
            v0_1
        }
        pub fn closure150(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            >,
            unitVar: (),
        ) -> Option<Dice_ui::US30> {
            let v2: string =
                Dice_ui::method0(string("state_core.use_request (5) / state_data_func"));
            leptos::logging::log!("{}", v2);
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method52(Dice_ui::method51());
                let v8: Dice_ui::US10 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure27((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure26((), v5_0_0.clone()),
                };
                let v17: Dice_ui::US11 = match &v8 {
                    Dice_ui::US10::US10_1(v8_1_0) => Dice_ui::US11::US11_1(defaultValue(
                        Dice_ui::US12::US12_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure28((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US10::US10_0(v8_0_0) => Dice_ui::US11::US11_0(v8_0_0.clone()),
                };
                let v64: Dice_ui::US32 = if let Dice_ui::US11::US11_1(v17_1_0) = &v17 {
                    if let Dice_ui::US12::US12_1(_) = &match &v17 {
                        Dice_ui::US11::US11_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<
                            (Option<rexie::Rexie>, Array<string>),
                            Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
                        > = Dice_ui::method295(v0_1);
                        let v25: Dice_ui::US33 = defaultValue(
                            Dice_ui::US33::US33_0,
                            map(
                                Func1::new(
                                    move |v_3: Result<
                                        Vec<Option<LrcPtr<Dice_ui::Heap4>>>,
                                        std::string::String,
                                    >| {
                                        Dice_ui::closure151((), v_3)
                                    },
                                ),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v51: Dice_ui::US32 = match &v25 {
                            Dice_ui::US33::US33_1(v25_1_0) => {
                                let v26: Result<
                                    Vec<Option<LrcPtr<Dice_ui::Heap4>>>,
                                    std::string::String,
                                > = v25_1_0.clone();
                                let v29: Dice_ui::US34 = match &v26 {
                                    Err(v26_1_0) => Dice_ui::closure153((), v26_1_0.clone()),
                                    Ok(v26_0_0) => Dice_ui::closure152((), v26_0_0.clone()),
                                };
                                Dice_ui::US32::US32_1(match &v29 {
                                    Dice_ui::US34::US34_1(v29_1_0) => {
                                        let v31: Vec<Option<LrcPtr<Dice_ui::Heap4>>> =
                                            Dice_ui::method296(v29_1_0.clone());
                                        let v33: Array<Option<LrcPtr<Dice_ui::Heap4>>> =
                                            fable_library_rust::NativeArray_::array_from(v31);
                                        let v34 = Dice_ui::method297();
                                        let v35: Array<Option<LrcPtr<Dice_ui::Heap4>>> =
                                            Dice_ui::method298(v33);
                                        let v37: Vec<Option<LrcPtr<Dice_ui::Heap4>>> = v35.to_vec();
                                        let v40: Vec<Dice_ui::US31> = Dice_ui::method299(
                                            v37.iter().map(|x| v34(x.clone())).collect(),
                                        );
                                        Dice_ui::US30::US30_1(
                                            fable_library_rust::NativeArray_::array_from(v40),
                                        )
                                    }
                                    Dice_ui::US34::US34_0(v29_0_0) => {
                                        Dice_ui::US30::US30_0(v29_0_0.clone())
                                    }
                                })
                            }
                            _ => Dice_ui::US32::US32_0,
                        };
                        let v52: string = sprintf!("{:?}", &v51);
                        let v59: string =
                                Dice_ui::method0(append(append(string("state_core.use_request (7) / new_signal_map memo / state_data: "),
                                                               (if length(v52.clone())
                                                                       <=
                                                                       200_i32
                                                                   {
                                                                    v52.clone()
                                                                } else {
                                                                    append(substring2(v52,
                                                                                      0_i32,
                                                                                      200_i32),
                                                                           string("..."))
                                                                })),
                                                        string("")));
                        leptos::logging::log!("{}", v59);
                        v51
                    } else {
                        Dice_ui::US32::US32_0
                    }
                } else {
                    Dice_ui::US32::US32_0
                };
                match &v64 {
                    Dice_ui::US32::US32_1(v64_1_0) => Some(v64_1_0.clone()),
                    _ => None::<Dice_ui::US30>,
                }
            }
        }
        pub fn method294(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            >,
        ) -> Func0<Option<Dice_ui::US30>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure150(v0_1.clone(), ())
            })
        }
        pub fn method301(
            v0_1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> leptos::Memo<Option<rexie::Rexie>> {
            v0_1
        }
        pub fn method302(v0_1: leptos::Memo<Array<string>>) -> leptos::Memo<Array<string>> {
            v0_1
        }
        pub fn method304(v0_1: LrcPtr<Dice_ui::Heap4>) -> LrcPtr<Dice_ui::Heap4> {
            v0_1
        }
        pub fn closure158(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method305() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure158((), v))
        }
        pub fn method306(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn method307(v0_1: Result<(), std::string::String>) -> Result<(), std::string::String> {
            v0_1
        }
        pub fn closure157(
            v0_1: LrcPtr<Dice_ui::Heap4>,
            v1: Dice_ui::US5,
            v2: string,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), std::string::String>>>>
        {
            let __future_init = Box::pin(async move {
                //;
                {
                    let v49: Dice_ui::US35 = if let Dice_ui::US5::US5_1(v1_1_0) = &v1 {
                        let v6: string =
                            Dice_ui::method0(append(append(string("state_core.use_request (9) / set_state_data_action / database=Some(_) / url: "),
                                                           v2.clone()),
                                                    string("")));
                        leptos::logging::log!("{}", v6);
                        {
                            let v8: string = append(append(string("url["), v2), string("]"));
                            let v12: string = Dice_ui::method0(append(
                                append(
                                    string("state_core.set_data () / data_len: "),
                                    toString(length(sprintf!("{:?}", &v0_1)) as i64),
                                ),
                                string(""),
                            ));
                            leptos::logging::log!("{}", v12);
                            {
                                let v14: rexie::Rexie = Dice_ui::method77(match &v1 {
                                    Dice_ui::US5::US5_1(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                                let v15: LrcPtr<Dice_ui::Heap4> = Dice_ui::method304(v0_1);
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v18: rexie::Transaction = v14.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v20: rexie::Store = v18.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v15, &mut data).unwrap();
                                        {
                                            let v24: Vec<u8> = data;
                                            let v26: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v24).unwrap();
                                            let v27: string = Dice_ui::method6(v8);
                                            let v29: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v27);
                                            v20.put(&v26, Some(&v29.into())).await?;
                                            v18.done().await?;
                                            {
                                                let v33: Result<(), rexie::Error> =
                                                    Dice_ui::method79(Ok::<(), rexie::Error>(()));
                                                v33
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v36: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v38: Result<(), rexie::Error> = v36.await;
                                                let v39 = Dice_ui::method305();
                                                let v40: Result<(), rexie::Error> =
                                                    Dice_ui::method306(v38);
                                                let v42: Result<(), std::string::String> =
                                                    v40.map_err(|x| v39(x));
                                                v42?;
                                                Dice_ui::US35::US35_1
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        let v46: string =
                            Dice_ui::method0(string("state_core.use_request (10) / set_state_data_action / database,url=None"));
                        leptos::logging::log!("{}", v46);
                        Dice_ui::US35::US35_1
                    };
                    let v55: Result<(), std::string::String> = Dice_ui::method307(match &v49 {
                        Dice_ui::US35::US35_1 => Ok::<(), std::string::String>(()),
                        Dice_ui::US35::US35_0(v49_0_0) => {
                            Err::<(), std::string::String>(v49_0_0.clone())
                        }
                    });
                    v55
                }
            });
            {
                //;
                __future_init
            }
        }
        pub fn method303(
            v0_1: LrcPtr<Dice_ui::Heap4>,
            v1: Dice_ui::US5,
        ) -> Func1<
            string,
            std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), std::string::String>>>>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: string| Dice_ui::closure157(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn method308(
            v0_1: Vec<
                std::pin::Pin<
                    Box<dyn std::future::Future<Output = Result<(), std::string::String>>>,
                >,
            >,
        ) -> Vec<
            std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), std::string::String>>>>,
        > {
            v0_1
        }
        pub fn method309(
            v0_1: Result<Vec<()>, std::string::String>,
        ) -> Result<Vec<()>, std::string::String> {
            v0_1
        }
        pub fn closure156(
            v0_1: leptos::Memo<Array<string>>,
            v1: leptos::Memo<Option<rexie::Rexie>>,
            v2: LrcPtr<Dice_ui::Heap4>,
        ) -> std::pin::Pin<
            Box<dyn std::future::Future<Output = Result<Vec<()>, std::string::String>>>,
        > {
            let v6: string = Dice_ui::method0(append(
                append(
                    string("state_core.use_request (8) / set_state_data_action / value_len: "),
                    toString(length(sprintf!("{:?}", &v2)) as i64),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v6);
            let __future_init = Box::pin(async move {
                //;
                {
                    let v9: leptos::Memo<Option<rexie::Rexie>> = Dice_ui::method301(v1);
                    let v14: Dice_ui::US5 = defaultValue(
                        Dice_ui::US5::US5_0,
                        map(
                            Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                            leptos::SignalGetUntracked::get_untracked(&v9),
                        ),
                    );
                    let v15: leptos::Memo<Array<string>> = Dice_ui::method302(v0_1);
                    let v18: Array<string> =
                        Dice_ui::method27(leptos::SignalGetUntracked::get_untracked(&v15));
                    let v20: Vec<string> = v18.to_vec();
                    let v21 = Dice_ui::method303(v2, v14);
                    let v22: Vec<string> = Dice_ui::method280(v20);
                    let v25: Vec<
                        std::pin::Pin<
                            Box<dyn std::future::Future<Output = Result<(), std::string::String>>>,
                        >,
                    > = Dice_ui::method308(v22.iter().map(|x| v21(x.clone())).collect());
                    let v27: futures::future::TryJoinAll<
                        std::pin::Pin<
                            Box<dyn std::future::Future<Output = Result<(), std::string::String>>>,
                        >,
                    > = futures::future::try_join_all(v25);
                    let v29: Result<Vec<()>, std::string::String> = v27.await;
                    let v33: Result<Vec<()>, std::string::String> =
                        Dice_ui::method309(Ok::<Vec<()>, std::string::String>(v29?));
                    v33
                }
            });
            {
                //;
                __future_init
            }
        }
        pub fn method300(
            v0_1: leptos::Memo<Array<string>>,
            v1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> Func1<
            LrcPtr<Dice_ui::Heap4>,
            std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<Vec<()>, std::string::String>>>,
            >,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure156(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn method311(
            v0_1: leptos::Resource<
                Array<string>,
                Result<Array<Option<string>>, std::string::String>,
            >,
        ) -> leptos::Resource<Array<string>, Result<Array<Option<string>>, std::string::String>>
        {
            v0_1
        }
        pub fn closure160(
            unitVar: (),
            v0_1: Result<Array<Option<string>>, std::string::String>,
        ) -> Dice_ui::US36 {
            Dice_ui::US36::US36_1(v0_1)
        }
        pub fn closure163(unitVar: (), v0_1: string) -> Dice_ui::US38 {
            Dice_ui::US38::US38_1(v0_1)
        }
        pub fn closure162(unitVar: (), v0_1: Option<string>) -> Dice_ui::US38 {
            defaultValue(
                Dice_ui::US38::US38_0,
                map(
                    Func1::new(move |v: string| Dice_ui::closure163((), v)),
                    v0_1,
                ),
            )
        }
        pub fn method313() -> Func1<Option<string>, Dice_ui::US38> {
            Func1::new(move |v: Option<string>| Dice_ui::closure162((), v))
        }
        pub fn method314(v0_1: Array<Option<string>>) -> Array<Option<string>> {
            v0_1
        }
        pub fn method315(v0_1: Vec<Dice_ui::US38>) -> Vec<Dice_ui::US38> {
            v0_1
        }
        pub fn closure161(unitVar: (), v0_1: Array<Option<string>>) -> Array<Dice_ui::US38> {
            let v1 = Dice_ui::method313();
            let v2: Array<Option<string>> = Dice_ui::method314(v0_1);
            let v4: Vec<Option<string>> = v2.to_vec();
            let v7: Vec<Dice_ui::US38> =
                Dice_ui::method315(v4.iter().map(|x| v1(x.clone())).collect());
            fable_library_rust::NativeArray_::array_from(v7)
        }
        pub fn method312() -> Func1<Array<Option<string>>, Array<Dice_ui::US38>> {
            Func1::new(move |v: Array<Option<string>>| Dice_ui::closure161((), v))
        }
        pub fn method316(
            v0_1: Result<Array<Option<string>>, std::string::String>,
        ) -> Result<Array<Option<string>>, std::string::String> {
            v0_1
        }
        pub fn closure164(unitVar: (), v0_1: Array<Dice_ui::US38>) -> Dice_ui::US40 {
            Dice_ui::US40::US40_1(v0_1)
        }
        pub fn closure165(unitVar: (), v0_1: std::string::String) -> Dice_ui::US40 {
            Dice_ui::US40::US40_0(v0_1)
        }
        pub fn closure166(unitVar: (), v0_1: Dice_ui::US38) -> Dice_ui::US43 {
            if let Dice_ui::US38::US38_1(v0_1_1_0) = &v0_1 {
                let v3: string = Dice_ui::method6(Dice_ui::method18(match &v0_1 {
                    Dice_ui::US38::US38_1(x) => x.clone(),
                    _ => unreachable!(),
                }));
                let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
                Dice_ui::US43::US43_1(Dice_ui::US15::US15_1(String::from(v5)))
            } else {
                Dice_ui::US43::US43_1(Dice_ui::US15::US15_0)
            }
        }
        pub fn method317() -> Func1<Dice_ui::US38, Dice_ui::US43> {
            Func1::new(move |v: Dice_ui::US38| Dice_ui::closure166((), v))
        }
        pub fn method318(v0_1: Array<Dice_ui::US38>) -> Array<Dice_ui::US38> {
            v0_1
        }
        pub fn method319(v0_1: Vec<Dice_ui::US43>) -> Vec<Dice_ui::US43> {
            v0_1
        }
        pub fn method320(v0_1: Array<Dice_ui::US43>) -> Array<Dice_ui::US43> {
            v0_1
        }
        pub fn method322(v0_1: LrcPtr<Dice_ui::Heap4>) -> LrcPtr<Dice_ui::Heap4> {
            v0_1
        }
        pub fn method323(
            v0_1: leptos::Action<LrcPtr<Dice_ui::Heap4>, Result<Vec<()>, std::string::String>>,
        ) -> leptos::Action<LrcPtr<Dice_ui::Heap4>, Result<Vec<()>, std::string::String>> {
            v0_1
        }
        pub fn closure167(
            v0_1: leptos::Action<LrcPtr<Dice_ui::Heap4>, Result<Vec<()>, std::string::String>>,
            v1: Dice_ui::US43,
        ) {
            if let Dice_ui::US43::US43_1(v1_1_0) = &v1 {
                let v2: Dice_ui::US15 = match &v1 {
                    Dice_ui::US43::US43_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Dice_ui::US15::US15_1(v2_1_0) = &v2 {
                    let v5: LrcPtr<Dice_ui::Heap4> =
                        Dice_ui::method322(LrcPtr::new(Dice_ui::Heap4 {
                            l0: match &v2 {
                                Dice_ui::US15::US15_1(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        }));
                    let v6: leptos::Action<
                        LrcPtr<Dice_ui::Heap4>,
                        Result<Vec<()>, std::string::String>,
                    > = Dice_ui::method323(v0_1);
                    leptos::Action::dispatch(&v6, v5.clone());
                    ()
                }
            };
        }
        pub fn method321(
            v0_1: leptos::Action<LrcPtr<Dice_ui::Heap4>, Result<Vec<()>, std::string::String>>,
        ) -> Func1<Dice_ui::US43, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::US43| Dice_ui::closure167(v0_1.clone(), v)
            })
        }
        pub fn method324(v0_1: Array<Dice_ui::US43>) -> Array<Dice_ui::US43> {
            v0_1
        }
        pub fn method325(v0_1: Vec<()>) -> Vec<()> {
            v0_1
        }
        pub fn closure159(
            v0_1: leptos::Resource<
                Array<string>,
                Result<Array<Option<string>>, std::string::String>,
            >,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap4>, Result<Vec<()>, std::string::String>>,
            unitVar: (),
        ) {
            let v3: string = Dice_ui::method0(string(
                "state_core.use_request (11) / effect new_state_data / ##2",
            ));
            leptos::logging::log!("{}", v3);
            {
                let v6: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method52(Dice_ui::method51());
                let v9: Dice_ui::US10 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure27((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure26((), v6_0_0.clone()),
                };
                let v18: Dice_ui::US11 = match &v9 {
                    Dice_ui::US10::US10_1(v9_1_0) => Dice_ui::US11::US11_1(defaultValue(
                        Dice_ui::US12::US12_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure28((), v_2)),
                            v9_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US10::US10_0(v9_0_0) => Dice_ui::US11::US11_0(v9_0_0.clone()),
                };
                if let Dice_ui::US11::US11_1(v18_1_0) = &v18 {
                    if let Dice_ui::US12::US12_1(_) = &match &v18 {
                        Dice_ui::US11::US11_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v21: leptos::Resource<
                            Array<string>,
                            Result<Array<Option<string>>, std::string::String>,
                        > = Dice_ui::method311(v0_1);
                        let v26: Dice_ui::US36 = defaultValue(
                            Dice_ui::US36::US36_0,
                            map(
                                Func1::new(
                                    move |v_3: Result<
                                        Array<Option<string>>,
                                        std::string::String,
                                    >| {
                                        Dice_ui::closure160((), v_3)
                                    },
                                ),
                                leptos::SignalGet::get(&v21),
                            ),
                        );
                        let v35: Dice_ui::US37 = match &v26 {
                            Dice_ui::US36::US36_1(v26_1_0) => {
                                let v28 = Dice_ui::method312();
                                let v29: Result<Array<Option<string>>, std::string::String> =
                                    Dice_ui::method316(v26_1_0.clone());
                                Dice_ui::US37::US37_1(v29.map(|x| v28(x)))
                            }
                            _ => Dice_ui::US37::US37_0,
                        };
                        let v43: Dice_ui::US39 = match &v35 {
                            Dice_ui::US37::US37_1(v35_1_0) => {
                                let v36: Result<Array<Dice_ui::US38>, std::string::String> =
                                    v35_1_0.clone();
                                Dice_ui::US39::US39_1(match &v36 {
                                    Err(v36_1_0) => Dice_ui::closure165((), v36_1_0.clone()),
                                    Ok(v36_0_0) => Dice_ui::closure164((), v36_0_0.clone()),
                                })
                            }
                            _ => Dice_ui::US39::US39_0,
                        };
                        let v63: Dice_ui::US41 = match &v43 {
                            Dice_ui::US39::US39_1(v43_1_0) => {
                                let v44: Dice_ui::US40 = v43_1_0.clone();
                                Dice_ui::US41::US41_1(match &v44 {
                                    Dice_ui::US40::US40_1(v44_1_0) => {
                                        let v46 = Dice_ui::method317();
                                        let v47: Array<Dice_ui::US38> =
                                            Dice_ui::method318(v44_1_0.clone());
                                        let v49: Vec<Dice_ui::US38> = v47.to_vec();
                                        let v52: Vec<Dice_ui::US43> = Dice_ui::method319(
                                            v49.iter().map(|x| v46(x.clone())).collect(),
                                        );
                                        Dice_ui::US42::US42_1(
                                            fable_library_rust::NativeArray_::array_from(v52),
                                        )
                                    }
                                    Dice_ui::US40::US40_0(v44_0_0) => {
                                        Dice_ui::US42::US42_0(v44_0_0.clone())
                                    }
                                })
                            }
                            _ => Dice_ui::US41::US41_0,
                        };
                        let v65: Array<Dice_ui::US43> =
                            Dice_ui::method320(new_empty::<Dice_ui::US43>());
                        let v69: Dice_ui::US42 = match &v63 {
                            Dice_ui::US41::US41_1(v63_1_0) => v63_1_0.clone(),
                            _ => Dice_ui::US42::US42_1(v65),
                        };
                        let v70: string = sprintf!("{:?}", &v69);
                        let v77: string = Dice_ui::method0(append(
                            append(
                                string("state_core.use_request (12) / effect / json: "),
                                (if length(v70.clone()) <= 200_i32 {
                                    v70.clone()
                                } else {
                                    append(substring2(v70, 0_i32, 200_i32), string("..."))
                                }),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v77);
                        match &v69 {
                            Dice_ui::US42::US42_1(v69_1_0) => {
                                let v80 = Dice_ui::method321(v1);
                                let v81: Array<Dice_ui::US43> = Dice_ui::method324(v69_1_0.clone());
                                let v83: Vec<Dice_ui::US43> = v81.to_vec();
                                let v86: Vec<()> = Dice_ui::method325(
                                    v83.iter().map(|x| v80(x.clone())).collect(),
                                );
                                let v88: Array<()> =
                                    fable_library_rust::NativeArray_::array_from(v86);
                                ()
                            }
                            _ => (),
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
        pub fn method310(
            v0_1: leptos::Resource<
                Array<string>,
                Result<Array<Option<string>>, std::string::String>,
            >,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap4>, Result<Vec<()>, std::string::String>>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure159(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method327(v0_1: Array<Dice_ui::US38>) -> Array<Dice_ui::US38> {
            v0_1
        }
        pub fn method328(
            v0_1: Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            v0_1
        }
        pub fn method330(v0_1: Func0<Option<Dice_ui::US30>>) -> Func0<Option<Dice_ui::US30>> {
            v0_1
        }
        pub fn closure171(unitVar: (), v0_1: Dice_ui::US30) -> Dice_ui::US32 {
            Dice_ui::US32::US32_1(v0_1)
        }
        pub fn closure172(unitVar: (), v0_1: Dice_ui::US38) -> Dice_ui::US44 {
            Dice_ui::US44::US44_1(v0_1)
        }
        pub fn closure173(unitVar: (), v0_1: Dice_ui::US31) -> Dice_ui::US45 {
            Dice_ui::US45::US45_1(v0_1)
        }
        pub fn method331(
            v0_1: Result<crate::model::near::nearblocks::Root, serde_json::Error>,
        ) -> Result<crate::model::near::nearblocks::Root, serde_json::Error> {
            v0_1
        }
        pub fn closure174(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Root,
        ) -> Option<crate::model::near::nearblocks::Root> {
            Some(v0_1)
        }
        pub fn method332(
        ) -> Func1<crate::model::near::nearblocks::Root, Option<crate::model::near::nearblocks::Root>>
        {
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure174((), v))
        }
        pub fn method333(
            v0_1: Result<crate::model::near::nearblocks::Root, std::string::String>,
        ) -> Result<crate::model::near::nearblocks::Root, std::string::String> {
            v0_1
        }
        pub fn closure170(
            v0_1: Func0<Option<Dice_ui::US30>>,
            v1: Array<Dice_ui::US38>,
            v2: i32,
            v3: string,
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            let v5: string = Dice_ui::method0(append(
                append(
                    string("state_core.use_request (15) / result memo / url: "),
                    v3,
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v5);
            {
                let v7: Func0<Option<Dice_ui::US30>> = Dice_ui::method330(v0_1);
                let v12: Dice_ui::US32 = defaultValue(
                    Dice_ui::US32::US32_0,
                    map(
                        Func1::new(move |v: Dice_ui::US30| Dice_ui::closure171((), v)),
                        (move || v7())(),
                    ),
                );
                let v13: string = sprintf!("{:?}", &v12);
                let v20: string = Dice_ui::method0(append(
                    append(
                        string("state_core.use_request (16) / result_memo / state_data: "),
                        (if length(v13.clone()) <= 200_i32 {
                            v13.clone()
                        } else {
                            append(substring2(v13, 0_i32, 200_i32), string("..."))
                        }),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v20);
                {
                    let v25: Dice_ui::US44 = defaultValue(
                        Dice_ui::US44::US44_0,
                        map(
                            Func1::new(move |v_1: Dice_ui::US38| Dice_ui::closure172((), v_1)),
                            tryItem(v2, v1),
                        ),
                    );
                    let v32: Dice_ui::US38 = if let Dice_ui::US44::US44_1(v25_1_0) = &v25 {
                        let v26: Dice_ui::US38 = match &v25 {
                            Dice_ui::US44::US44_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Dice_ui::US38::US38_1(v26_1_0) = &v26 {
                            Dice_ui::US38::US38_1(match &v26 {
                                Dice_ui::US38::US38_1(x) => x.clone(),
                                _ => unreachable!(),
                            })
                        } else {
                            Dice_ui::US38::US38_0
                        }
                    } else {
                        Dice_ui::US38::US38_0
                    };
                    let v62: Dice_ui::US44 = match &v12 {
                        Dice_ui::US32::US32_1(v12_1_0) => {
                            let v33: Dice_ui::US30 = v12_1_0.clone();
                            Dice_ui::US44::US44_1(match &v33 {
                                Dice_ui::US30::US30_1(v33_1_0) => {
                                    let v38: Dice_ui::US45 = defaultValue(
                                        Dice_ui::US45::US45_0,
                                        map(
                                            Func1::new(move |v_2: Dice_ui::US31| {
                                                Dice_ui::closure173((), v_2)
                                            }),
                                            tryItem(v2, v33_1_0.clone()),
                                        ),
                                    );
                                    let v45: Dice_ui::US31 =
                                        if let Dice_ui::US45::US45_1(v38_1_0) = &v38 {
                                            let v39: Dice_ui::US31 = match &v38 {
                                                Dice_ui::US45::US45_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if let Dice_ui::US31::US31_1(v39_1_0) = &v39 {
                                                Dice_ui::US31::US31_1(match &v39 {
                                                    Dice_ui::US31::US31_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            } else {
                                                Dice_ui::US31::US31_0
                                            }
                                        } else {
                                            Dice_ui::US31::US31_0
                                        };
                                    match &v45 {
                                        Dice_ui::US31::US31_1(v45_1_0) => {
                                            let v48: std::string::String =
                                                Dice_ui::method60((v45_1_0).l0.clone());
                                            Dice_ui::US38::US38_1(
                                                fable_library_rust::String_::fromString(v48),
                                            )
                                        }
                                        _ => Dice_ui::US38::US38_0,
                                    }
                                }
                                _ => Dice_ui::US38::US38_0,
                            })
                        }
                        _ => Dice_ui::US44::US44_0,
                    };
                    let v69: Dice_ui::US38 = if let Dice_ui::US44::US44_1(v62_1_0) = &v62 {
                        let v63: Dice_ui::US38 = match &v62 {
                            Dice_ui::US44::US44_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Dice_ui::US38::US38_1(v63_1_0) = &v63 {
                            Dice_ui::US38::US38_1(match &v63 {
                                Dice_ui::US38::US38_1(x) => x.clone(),
                                _ => unreachable!(),
                            })
                        } else {
                            Dice_ui::US38::US38_0
                        }
                    } else {
                        Dice_ui::US38::US38_0
                    };
                    if let Dice_ui::US38::US38_1(v32_1_0) = &v32 {
                        let v71: string = Dice_ui::method6(match &v32 {
                            Dice_ui::US38::US38_1(x) => x.clone(),
                            _ => unreachable!(),
                        });
                        let v73: &str = fable_library_rust::String_::LrcStr::as_str(&v71);
                        let v75: Result<crate::model::near::nearblocks::Root, serde_json::Error> =
                            serde_json::from_str(&v73);
                        let v76 = Dice_ui::method61();
                        let v77: Result<crate::model::near::nearblocks::Root, serde_json::Error> =
                            Dice_ui::method331(v75);
                        let v79: Result<crate::model::near::nearblocks::Root, std::string::String> =
                            v77.map_err(|x| v76(x));
                        let v80 = Dice_ui::method332();
                        let v81: Result<crate::model::near::nearblocks::Root, std::string::String> =
                            Dice_ui::method333(v79);
                        v81.map(|x| v80(x))
                    } else {
                        if let Dice_ui::US38::US38_1(v69_1_0) = &v69 {
                            let v85: string = Dice_ui::method6(match &v69 {
                                Dice_ui::US38::US38_1(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            let v87: &str = fable_library_rust::String_::LrcStr::as_str(&v85);
                            let v89: Result<
                                crate::model::near::nearblocks::Root,
                                serde_json::Error,
                            > = serde_json::from_str(&v87);
                            let v90 = Dice_ui::method61();
                            let v91: Result<
                                crate::model::near::nearblocks::Root,
                                serde_json::Error,
                            > = Dice_ui::method331(v89);
                            let v93: Result<
                                crate::model::near::nearblocks::Root,
                                std::string::String,
                            > = v91.map_err(|x| v90(x));
                            let v94 = Dice_ui::method332();
                            let v95: Result<
                                crate::model::near::nearblocks::Root,
                                std::string::String,
                            > = Dice_ui::method333(v93);
                            v95.map(|x| v94(x))
                        } else {
                            let v100: string = Dice_ui::method0(append(
                                append(
                                    string("state_core.use_request (17) / json Error / value: "),
                                    sprintf!("{:?}", &(v32, v69)),
                                ),
                                string(""),
                            ));
                            leptos::logging::log!("{}", v100);
                            Ok::<Option<crate::model::near::nearblocks::Root>, std::string::String>(
                                None::<crate::model::near::nearblocks::Root>,
                            )
                        }
                    }
                }
            }
        }
        pub fn closure169(
            v0_1: Func0<Option<Dice_ui::US30>>,
            v1: Array<Dice_ui::US38>,
            v2: i32,
        ) -> Func1<string, Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move |v: string| Dice_ui::closure170(v0_1.clone(), v1.clone(), v2, v)
            })
        }
        pub fn method329(
            v0_1: Func0<Option<Dice_ui::US30>>,
            v1: Array<Dice_ui::US38>,
        ) -> Func1<
            i32,
            Func1<
                string,
                Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
            >,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: i32| Dice_ui::closure169(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn method334(
            v0_1: Vec<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Vec<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            v0_1
        }
        pub fn closure168(
            v0_1: leptos::Memo<Array<string>>,
            v1: leptos::Resource<Array<string>, Result<Array<Option<string>>, std::string::String>>,
            v2: Func0<Option<Dice_ui::US30>>,
            unitVar: (),
        ) -> Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            let v3: leptos::Memo<Array<string>> = Dice_ui::method272(v0_1);
            let v5: Array<string> = v3();
            let v8: string = Dice_ui::method0(append(
                append(
                    string("state_core.use_request (14) / result memo / urls: "),
                    sprintf!("{:?}", &v5),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v8);
            {
                let v10: leptos::Resource<
                    Array<string>,
                    Result<Array<Option<string>>, std::string::String>,
                > = Dice_ui::method311(v1);
                let v15: Dice_ui::US36 = defaultValue(
                    Dice_ui::US36::US36_0,
                    map(
                        Func1::new(
                            move |v: Result<Array<Option<string>>, std::string::String>| {
                                Dice_ui::closure160((), v)
                            },
                        ),
                        leptos::SignalGet::get(&v10),
                    ),
                );
                let v24: Dice_ui::US37 = match &v15 {
                    Dice_ui::US36::US36_1(v15_1_0) => {
                        let v17 = Dice_ui::method312();
                        let v18: Result<Array<Option<string>>, std::string::String> =
                            Dice_ui::method316(v15_1_0.clone());
                        Dice_ui::US37::US37_1(v18.map(|x| v17(x)))
                    }
                    _ => Dice_ui::US37::US37_0,
                };
                let v26: Array<Dice_ui::US38> = Dice_ui::method327(new_empty::<Dice_ui::US38>());
                let v30: Result<Array<Dice_ui::US38>, std::string::String> = match &v24 {
                    Dice_ui::US37::US37_1(v24_1_0) => v24_1_0.clone(),
                    _ => Ok::<Array<Dice_ui::US38>, std::string::String>(v26),
                };
                let v31: string = sprintf!("{:?}", &v30);
                let v38: string = Dice_ui::method0(append(
                    append(
                        string("state_core.use_request (16.1) / effect / json: "),
                        (if length(v31.clone()) <= 200_i32 {
                            v31.clone()
                        } else {
                            append(substring2(v31, 0_i32, 200_i32), string("..."))
                        }),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v38);
                {
                    let v42: Dice_ui::US40 = match &v30 {
                        Err(v30_1_0) => Dice_ui::closure165((), v30_1_0.clone()),
                        Ok(v30_0_0) => Dice_ui::closure164((), v30_0_0.clone()),
                    };
                    let v57: Array<
                        Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
                    > = match &v42 {
                        Dice_ui::US40::US40_1(v42_1_0) => {
                            let v44 = Dice_ui::method329(v2, v42_1_0.clone());
                            let v45: Array<string> = Dice_ui::method27(v5);
                            let v47: Vec<string> = v45.to_vec();
                            let v50: Vec<
                                Result<
                                    Option<crate::model::near::nearblocks::Root>,
                                    std::string::String,
                                >,
                            > = Dice_ui::method334(
                                v47.iter()
                                    .enumerate()
                                    .map(|(i, x)| v44(i.try_into().unwrap())(x.clone()))
                                    .collect(),
                            );
                            fable_library_rust::NativeArray_::array_from(v50)
                        }
                        _ => Dice_ui::method328(new_empty::<
                            Result<
                                Option<crate::model::near::nearblocks::Root>,
                                std::string::String,
                            >,
                        >()),
                    };
                    let v58: string = sprintf!("{:?}", &v57);
                    let v65: string =
                        Dice_ui::method0(append(append(string("state_core.use_request (18) / result create_memo / json_cache_obj: "),
                                                       (if length(v58.clone())
                                                               <= 200_i32 {
                                                            v58.clone()
                                                        } else {
                                                            append(substring2(v58,
                                                                              0_i32,
                                                                              200_i32),
                                                                   string("..."))
                                                        })), string("")));
                    leptos::logging::log!("{}", v65);
                    v57
                }
            }
        }
        pub fn method326(
            v0_1: leptos::Memo<Array<string>>,
            v1: leptos::Resource<Array<string>, Result<Array<Option<string>>, std::string::String>>,
            v2: Func0<Option<Dice_ui::US30>>,
        ) -> Func0<Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>>
        {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure168(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method336(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US2, rexie::Rexie> {
            v0_1
        }
        pub fn method337(v0_1: leptos::Signal<bool>) -> leptos::Signal<bool> {
            v0_1
        }
        pub fn method338(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            >,
        ) -> leptos::Resource<
            (Option<rexie::Rexie>, Array<string>),
            Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
        > {
            v0_1
        }
        pub fn method339(
            v0_1: Func0<
                Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
            >,
        ) -> Func0<Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>>
        {
            v0_1
        }
        pub fn method342(
            v0_1: Option<crate::model::near::nearblocks::Root>,
        ) -> Option<crate::model::near::nearblocks::Root> {
            v0_1
        }
        pub fn method344(
            v0_1: crate::model::near::nearblocks::Root,
        ) -> crate::model::near::nearblocks::Root {
            v0_1
        }
        pub fn method346(
            v0_1: crate::model::near::nearblocks::Txn,
        ) -> crate::model::near::nearblocks::Txn {
            v0_1
        }
        pub fn method347(
            v0_1: crate::model::near::nearblocks::Block,
        ) -> crate::model::near::nearblocks::Block {
            v0_1
        }
        pub fn method349(
            v0_1: crate::model::near::nearblocks::Action,
        ) -> crate::model::near::nearblocks::Action {
            v0_1
        }
        pub fn closure180(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Action,
        ) -> (std::string::String, Option<std::string::String>) {
            let v1: crate::model::near::nearblocks::Action = Dice_ui::method349(v0_1);
            (v1.action, v1.method)
        }
        pub fn method348() -> Func1<
            crate::model::near::nearblocks::Action,
            (std::string::String, Option<std::string::String>),
        > {
            Func1::new(move |v: crate::model::near::nearblocks::Action| Dice_ui::closure180((), v))
        }
        pub fn method350(
            v0_1: Vec<(std::string::String, Option<std::string::String>)>,
        ) -> Vec<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method351(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
        ) -> Array<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method352(
            v0_1: crate::model::near::nearblocks::ActionsAgg,
        ) -> crate::model::near::nearblocks::ActionsAgg {
            v0_1
        }
        pub fn method353(
            v0_1: crate::model::near::nearblocks::Outcomes,
        ) -> crate::model::near::nearblocks::Outcomes {
            v0_1
        }
        pub fn method354(
            v0_1: crate::model::near::nearblocks::OutcomesAgg,
        ) -> crate::model::near::nearblocks::OutcomesAgg {
            v0_1
        }
        pub fn method355(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn closure179(
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
            let v1: crate::model::near::nearblocks::Txn = Dice_ui::method346(v0_1);
            let v3: std::string::String = v1.receipt_id;
            let v5: std::string::String = v1.predecessor_account_id;
            let v7: std::string::String = v1.receiver_account_id;
            let v9: std::string::String = v1.transaction_hash;
            let v11: std::string::String = v1.included_in_block_hash;
            let v13: std::string::String = v1.block_timestamp;
            let v16: crate::model::near::nearblocks::Block = Dice_ui::method347(v1.block);
            let v18: u32 = v16.block_height;
            let v19 = Dice_ui::method348();
            let v22: Vec<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method350(v1.actions.into_iter().map(|x| v19(x)).collect());
            let v25: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method351(fable_library_rust::NativeArray_::array_from(v22));
            let v28: crate::model::near::nearblocks::ActionsAgg =
                Dice_ui::method352(v1.actions_agg);
            let v30: f64 = v28.deposit;
            let v33: crate::model::near::nearblocks::Outcomes = Dice_ui::method353(v1.outcomes);
            let v35: bool = v33.status;
            let v38: crate::model::near::nearblocks::OutcomesAgg =
                Dice_ui::method354(v1.outcomes_agg);
            let v40: f64 = v38.transaction_fee;
            let v43: Vec<std::string::String> = Dice_ui::method28(v1.logs);
            (
                v25,
                v30,
                v18,
                v13,
                v11,
                Dice_ui::method355(fable_library_rust::NativeArray_::array_from(v43)),
                v35,
                v40,
                v5,
                v3,
                v7,
                v9,
            )
        }
        pub fn method345() -> Func1<
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
            Func1::new(move |v: crate::model::near::nearblocks::Txn| Dice_ui::closure179((), v))
        }
        pub fn method356(
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
        pub fn method357(
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
        pub fn closure178(
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
            let v1: crate::model::near::nearblocks::Root = Dice_ui::method344(v0_1);
            let v2 = Dice_ui::method345();
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
            )> = Dice_ui::method356(v1.txns.into_iter().map(|x| v2(x)).collect());
            Dice_ui::method357(fable_library_rust::NativeArray_::array_from(v5))
        }
        pub fn method343() -> Func1<
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
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure178((), v))
        }
        pub fn closure177(
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
            let v1: Option<crate::model::near::nearblocks::Root> = Dice_ui::method342(v0_1);
            let v2 = Dice_ui::method343();
            v1.map(|x| v2(x))
        }
        pub fn method341() -> Func1<
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
                Dice_ui::closure177((), v)
            })
        }
        pub fn method358(
            v0_1: Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            v0_1
        }
        pub fn closure176(
            unitVar: (),
            v0_1: Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
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
            let v1 = Dice_ui::method341();
            let v2: Result<Option<crate::model::near::nearblocks::Root>, std::string::String> =
                Dice_ui::method358(v0_1);
            v2.map(|x| v1(x))
        }
        pub fn method340() -> Func1<
            Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
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
            Func1::new(
                move |v: Result<
                    Option<crate::model::near::nearblocks::Root>,
                    std::string::String,
                >| Dice_ui::closure176((), v),
            )
        }
        pub fn method359(
            v0_1: Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            v0_1
        }
        pub fn method360(
            v0_1: Vec<
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
        ) -> Vec<
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
        pub fn closure175(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            v1: leptos::Resource<
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            >,
            v2: Func0<
                Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
            >,
            unitVar: (),
        ) -> Array<
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
            let v3: leptos::Resource<Dice_ui::US2, rexie::Rexie> = Dice_ui::method336(v0_1.clone());
            let v6: leptos::Signal<bool> = Dice_ui::method337(leptos::Resource::loading(&v3));
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos::Resource<
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            > = Dice_ui::method338(v1.clone());
            let v12: leptos::Signal<bool> = Dice_ui::method337(leptos::Resource::loading(&v9));
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
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            > = Dice_ui::method295(v1);
            let v26: Dice_ui::US33 = defaultValue(
                Dice_ui::US33::US33_0,
                map(
                    Func1::new(
                        move |v_1: Result<
                            Vec<Option<LrcPtr<Dice_ui::Heap4>>>,
                            std::string::String,
                        >| Dice_ui::closure151((), v_1),
                    ),
                    leptos::SignalGet::get(&v21),
                ),
            );
            let v52: Dice_ui::US32 = match &v26 {
                Dice_ui::US33::US33_1(v26_1_0) => {
                    let v27: Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String> =
                        v26_1_0.clone();
                    let v30: Dice_ui::US34 = match &v27 {
                        Err(v27_1_0) => Dice_ui::closure153((), v27_1_0.clone()),
                        Ok(v27_0_0) => Dice_ui::closure152((), v27_0_0.clone()),
                    };
                    Dice_ui::US32::US32_1(match &v30 {
                        Dice_ui::US34::US34_1(v30_1_0) => {
                            let v32: Vec<Option<LrcPtr<Dice_ui::Heap4>>> =
                                Dice_ui::method296(v30_1_0.clone());
                            let v34: Array<Option<LrcPtr<Dice_ui::Heap4>>> =
                                fable_library_rust::NativeArray_::array_from(v32);
                            let v35 = Dice_ui::method297();
                            let v36: Array<Option<LrcPtr<Dice_ui::Heap4>>> =
                                Dice_ui::method298(v34);
                            let v38: Vec<Option<LrcPtr<Dice_ui::Heap4>>> = v36.to_vec();
                            let v41: Vec<Dice_ui::US31> =
                                Dice_ui::method299(v38.iter().map(|x| v35(x.clone())).collect());
                            Dice_ui::US30::US30_1(fable_library_rust::NativeArray_::array_from(v41))
                        }
                        Dice_ui::US34::US34_0(v30_0_0) => Dice_ui::US30::US30_0(v30_0_0.clone()),
                    })
                }
                _ => Dice_ui::US32::US32_0,
            };
            let v53: string = sprintf!("{:?}", &v20);
            let v58: string = if length(v53.clone()) <= 200_i32 {
                v53.clone()
            } else {
                append(substring2(v53, 0_i32, 200_i32), string("..."))
            };
            let v59: string = sprintf!("{:?}", &v52);
            let v64: string = if length(v59.clone()) <= 200_i32 {
                v59.clone()
            } else {
                append(substring2(v59, 0_i32, 200_i32), string("..."))
            };
            let v66: string =
                Dice_ui::method0(append(append(append(append(append(append(append(append(string("state_core.use_request (19) / result move / database: "),
                                                                                         v58),
                                                                                  string(" / database_loading: ")),
                                                                           ofBoolean(v8)),
                                                                    string(" / state_data: ")),
                                                             v64),
                                                      string(" / state_data_loading: ")),
                                               ofBoolean(v14)), string("")));
            leptos::logging::log!("{}", v66);
            {
                let v68: Func0<
                    Array<
                        Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
                    >,
                > = Dice_ui::method339(v2);
                let v70: Array<
                    Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
                > = (move || v68())();
                let v71 = Dice_ui::method340();
                let v72: Array<
                    Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
                > = Dice_ui::method359(v70);
                let v74: Vec<
                    Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
                > = v72.to_vec();
                let v77: Vec<
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
                > = Dice_ui::method360(v74.iter().map(|x| v71(x.clone())).collect());
                let v79: Array<
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
                > = fable_library_rust::NativeArray_::array_from(v77);
                let v80: string = sprintf!("{:?}", &v79);
                let v87: string = Dice_ui::method0(append(
                    append(
                        string("state_core.use_request (20) / result move / result: "),
                        (if length(v80.clone()) <= 200_i32 {
                            v80.clone()
                        } else {
                            append(substring2(v80, 0_i32, 200_i32), string("..."))
                        }),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v87);
                v79
            }
        }
        pub fn method335(
            v0_1: leptos::Resource<Dice_ui::US2, rexie::Rexie>,
            v1: leptos::Resource<
                (Option<rexie::Rexie>, Array<string>),
                Result<Vec<Option<LrcPtr<Dice_ui::Heap4>>>, std::string::String>,
            >,
            v2: Func0<
                Array<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
            >,
        ) -> Func0<
            Array<
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
        > {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure175(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method362(
            v0_1: Func0<
                Array<
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
            >,
        ) -> Func0<
            Array<
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
        > {
            v0_1
        }
        pub fn closure183(
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
        ) -> Dice_ui::US46 {
            Dice_ui::US46::US46_1(v0_1)
        }
        pub fn closure184(unitVar: (), v0_1: std::string::String) -> Dice_ui::US46 {
            Dice_ui::US46::US46_0(v0_1)
        }
        pub fn closure182(
            unitVar: (),
            v0_1: Result<
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
        ) -> Dice_ui::US46 {
            match &v0_1 {
                Err(v0_1_1_0) => Dice_ui::closure184((), v0_1_1_0.clone()),
                Ok(v0_1_0_0) => Dice_ui::closure183((), v0_1_0_0.clone()),
            }
        }
        pub fn method363() -> Func1<
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
            Dice_ui::US46,
        > {
            Func1::new(
                move |v: Result<
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
                >| Dice_ui::closure182((), v),
            )
        }
        pub fn method364(
            v0_1: Array<
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
        ) -> Array<
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
        pub fn method365(v0_1: Vec<Dice_ui::US46>) -> Vec<Dice_ui::US46> {
            v0_1
        }
        pub fn closure187(
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
        ) -> Dice_ui::US49 {
            Dice_ui::US49::US49_1(v0_1)
        }
        pub fn method367(
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
        pub fn method368(
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
        pub fn closure188(
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
        pub fn method369() -> Func1<
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
                    Dice_ui::closure188((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn method370(
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
        pub fn method371(
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
        pub fn closure189(
            v0_1: string,
            v1: string,
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
        ) -> (string, usize, LrcPtr<Dice_ui::Heap5>) {
            (
                v0_1,
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
        pub fn method372(
            v0_1: string,
            v1: string,
        ) -> Func1<
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
            (string, usize, LrcPtr<Dice_ui::Heap5>),
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
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
                )| Dice_ui::closure189(v0_1.clone(), v1.clone(), arg10_0040)
            })
        }
        pub fn method373(
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
        pub fn method374(
            v0_1: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure186(
            v0_1: Array<(string, string)>,
            v1: i32,
            v2: Dice_ui::US46,
        ) -> Dice_ui::US47 {
            let patternInput: (string, string) = v0_1[v1].clone();
            match &v2 {
                Dice_ui::US46::US46_1(v2_1_0) => {
                    let v8: Dice_ui::US49 = defaultValue(
                        Dice_ui::US49::US49_0,
                        map(
                            Func1::new(
                                move |v: Array<(
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
                                )>| Dice_ui::closure187((), v),
                            ),
                            v2_1_0.clone(),
                        ),
                    );
                    Dice_ui::US47::US47_1(match &v8 {
                        Dice_ui::US49::US49_1(v8_1_0) => {
                            let v10: Array<(
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
                            )> = Dice_ui::method367(v8_1_0.clone());
                            let v12: Vec<(
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
                            )> = v10.to_vec();
                            let v15: Vec<
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
                            > = Dice_ui::method368(
                                v12.into_iter().enumerate().map(std::rc::Rc::new).collect(),
                            );
                            let v17: Array<
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
                            > = fable_library_rust::NativeArray_::array_from(v15);
                            let v18 = Dice_ui::method369();
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
                            > = Dice_ui::method370(v17);
                            let v21: Vec<
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
                            > = v19.to_vec();
                            let v24: Vec<(
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
                            )> = Dice_ui::method371(v21.iter().map(|x| v18(x.clone())).collect());
                            let v26: Array<(
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
                            )> = fable_library_rust::NativeArray_::array_from(v24);
                            let v27 =
                                Dice_ui::method372(patternInput.0.clone(), patternInput.1.clone());
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
                            )> = Dice_ui::method373(v26);
                            let v30: Vec<(
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
                            )> = v28.to_vec();
                            let v33: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                                Dice_ui::method374(v30.iter().map(|x| v27(x.clone())).collect());
                            Dice_ui::US48::US48_1(fable_library_rust::NativeArray_::array_from(v33))
                        }
                        _ => Dice_ui::US48::US48_0,
                    })
                }
                Dice_ui::US46::US46_0(v2_0_0) => Dice_ui::US47::US47_0(v2_0_0.clone()),
            }
        }
        pub fn closure185(
            v0_1: Array<(string, string)>,
            v1: i32,
        ) -> Func1<Dice_ui::US46, Dice_ui::US47> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: Dice_ui::US46| Dice_ui::closure186(v0_1.clone(), v1, v)
            })
        }
        pub fn method366(
            v0_1: Array<(string, string)>,
        ) -> Func1<i32, Func1<Dice_ui::US46, Dice_ui::US47>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: i32| Dice_ui::closure185(v0_1.clone(), v)
            })
        }
        pub fn method375(v0_1: Array<Dice_ui::US46>) -> Array<Dice_ui::US46> {
            v0_1
        }
        pub fn method376(v0_1: Vec<Dice_ui::US47>) -> Vec<Dice_ui::US47> {
            v0_1
        }
        pub fn closure190(unitVar: (), v0_1: Dice_ui::US47) -> Dice_ui::US50 {
            match &v0_1 {
                Dice_ui::US47::US47_1(v0_1_1_0) => {
                    let v1: Dice_ui::US48 = v0_1_1_0.clone();
                    Dice_ui::US50::US50_1(match &v1 {
                        Dice_ui::US48::US48_1(v1_1_0) => Some(v1_1_0.clone()),
                        _ => None::<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                    })
                }
                Dice_ui::US47::US47_0(v0_1_0_0) => Dice_ui::US50::US50_0(v0_1_0_0.clone()),
            }
        }
        pub fn method377() -> Func1<Dice_ui::US47, Dice_ui::US50> {
            Func1::new(move |v: Dice_ui::US47| Dice_ui::closure190((), v))
        }
        pub fn method378(v0_1: Array<Dice_ui::US47>) -> Array<Dice_ui::US47> {
            v0_1
        }
        pub fn method379(v0_1: Vec<Dice_ui::US50>) -> Vec<Dice_ui::US50> {
            v0_1
        }
        pub fn closure191(
            unitVar: (),
            v0_1: Dice_ui::US50,
        ) -> Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>
        {
            match &v0_1 {
                Dice_ui::US50::US50_1(v0_1_1_0) => Ok::<
                    Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                    std::string::String,
                >(v0_1_1_0.clone()),
                Dice_ui::US50::US50_0(v0_1_0_0) => Err::<
                    Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                    std::string::String,
                >(v0_1_0_0.clone()),
            }
        }
        pub fn method380() -> Func1<
            Dice_ui::US50,
            Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
        > {
            Func1::new(move |v: Dice_ui::US50| Dice_ui::closure191((), v))
        }
        pub fn method381(v0_1: Array<Dice_ui::US50>) -> Array<Dice_ui::US50> {
            v0_1
        }
        pub fn method382(
            v0_1: Vec<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> Vec<Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>>
        {
            v0_1
        }
        pub fn method383(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn method384(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn method385(v0_1: i32, v1: LrcPtr<Dice_ui::Mut1>) -> bool {
            v1.l0.get().clone() < v0_1
        }
        pub fn closure192(
            unitVar: (),
            v0_1: Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
        ) -> Dice_ui::US50 {
            Dice_ui::US50::US50_1(v0_1)
        }
        pub fn closure193(unitVar: (), v0_1: std::string::String) -> Dice_ui::US50 {
            Dice_ui::US50::US50_0(v0_1)
        }
        pub fn closure194(
            unitVar: (),
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Dice_ui::US48 {
            Dice_ui::US48::US48_1(v0_1)
        }
        pub fn method386(
            v0_1: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn method387(
            v0_1: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn method388(
            v0_1: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure195(
            unitVar: (),
            _arg: (string, usize, LrcPtr<Dice_ui::Heap5>),
        ) -> std::string::String {
            (_arg.2.clone()).l3.clone()
        }
        pub fn method389() -> Func1<(string, usize, LrcPtr<Dice_ui::Heap5>), std::string::String> {
            Func1::new(move |arg10_0040: (string, usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure195((), arg10_0040)
            })
        }
        pub fn method390(
            v0_1: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure181(
            v0_1: leptos::Memo<Array<(string, string)>>,
            v1: Func0<
                Array<
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
            >,
            unitVar: (),
        ) -> Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>
        {
            let v2: leptos::Memo<Array<(string, string)>> = Dice_ui::method267(v0_1);
            let v4: Array<(string, string)> = v2();
            let v5: Func0<
                Array<
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
            > = Dice_ui::method362(v1);
            let v7: Array<
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
            > = v5();
            let v8 = Dice_ui::method363();
            let v9: Array<
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
            > = Dice_ui::method364(v7);
            let v11: Vec<
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
            > = v9.to_vec();
            let v14: Vec<Dice_ui::US46> =
                Dice_ui::method365(v11.iter().map(|x| v8(x.clone())).collect());
            let v16: Array<Dice_ui::US46> = fable_library_rust::NativeArray_::array_from(v14);
            let v17 = Dice_ui::method366(v4);
            let v18: Array<Dice_ui::US46> = Dice_ui::method375(v16);
            let v20: Vec<Dice_ui::US46> = v18.to_vec();
            let v23: Vec<Dice_ui::US47> = Dice_ui::method376(
                v20.iter()
                    .enumerate()
                    .map(|(i, x)| v17(i.try_into().unwrap())(x.clone()))
                    .collect(),
            );
            let v25: Array<Dice_ui::US47> = fable_library_rust::NativeArray_::array_from(v23);
            let v28: string = Dice_ui::method0(append(
                append(
                    string("transactions.render () / txns move / result length: "),
                    toString(length(sprintf!("{:?}", &v25))),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v28);
            {
                let v30 = Dice_ui::method377();
                let v31: Array<Dice_ui::US47> = Dice_ui::method378(v25);
                let v33: Vec<Dice_ui::US47> = v31.to_vec();
                let v36: Vec<Dice_ui::US50> =
                    Dice_ui::method379(v33.iter().map(|x| v30(x.clone())).collect());
                let v38: Array<Dice_ui::US50> = fable_library_rust::NativeArray_::array_from(v36);
                let v39 = Dice_ui::method380();
                let v40: Array<Dice_ui::US50> = Dice_ui::method381(v38);
                let v42: Vec<Dice_ui::US50> = v40.to_vec();
                let v45: Vec<
                    Result<
                        Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                        std::string::String,
                    >,
                > = Dice_ui::method382(v42.iter().map(|x| v39(x.clone())).collect());
                let v47: Array<
                    Result<
                        Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                        std::string::String,
                    >,
                > = fable_library_rust::NativeArray_::array_from(v45);
                let v50: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method384(
                    Dice_ui::method383(new_empty::<(string, usize, LrcPtr<Dice_ui::Heap5>)>()),
                );
                let v52: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> = v50.to_vec();
                let v53: i32 = count(v47.clone());
                let v55: LrcPtr<Dice_ui::Mut1> = LrcPtr::new(Dice_ui::Mut1 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(Dice_ui::US51::US51_1(v52)),
                });
                while Dice_ui::method385(v53, v55.clone()) {
                    let v57: i32 = v55.l0.get().clone();
                    let v58: Dice_ui::US51 = v55.l1.get().clone();
                    let v59: Result<
                        Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                        std::string::String,
                    > = v47[v57].clone();
                    let v62: Dice_ui::US50 = match &v59 {
                        Err(v59_1_0) => Dice_ui::closure193((), v59_1_0.clone()),
                        Ok(v59_0_0) => Dice_ui::closure192((), v59_0_0.clone()),
                    };
                    let v71: Dice_ui::US47 = match &v62 {
                        Dice_ui::US50::US50_1(v62_1_0) => Dice_ui::US47::US47_1(defaultValue(
                            Dice_ui::US48::US48_0,
                            map(
                                Func1::new(
                                    move |v_2: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>| {
                                        Dice_ui::closure194((), v_2)
                                    },
                                ),
                                v62_1_0.clone(),
                            ),
                        )),
                        Dice_ui::US50::US50_0(v62_0_0) => Dice_ui::US47::US47_0(v62_0_0.clone()),
                    };
                    let v93: Dice_ui::US51 = if let Dice_ui::US51::US51_1(v58_1_0) = &v58 {
                        match &v71 {
                            Dice_ui::US47::US47_1(v71_1_0) => {
                                let v73: Dice_ui::US48 = v71_1_0.clone();
                                if let Dice_ui::US48::US48_1(v73_1_0) = &v73 {
                                    let v75: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                                        Dice_ui::method384(match &v73 {
                                            Dice_ui::US48::US48_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        });
                                    let v78: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                                        Dice_ui::method386(v75.to_vec());
                                    let v79: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                                        Dice_ui::method387(match &v58 {
                                            Dice_ui::US51::US51_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        });
                                    let mut v79 = v79;
                                    v79.extend(v78);
                                    Dice_ui::US51::US51_1(v79)
                                } else {
                                    v58.clone()
                                }
                            }
                            Dice_ui::US47::US47_0(v71_0_0) => {
                                Dice_ui::US51::US51_0(v71_0_0.clone())
                            }
                        }
                    } else {
                        if let Dice_ui::US47::US47_0(v71_0_0) = &v71 {
                            Dice_ui::US51::US51_0(match &v71 {
                                Dice_ui::US47::US47_0(x) => x.clone(),
                                _ => unreachable!(),
                            })
                        } else {
                            v58.clone()
                        }
                    };
                    let v94: i32 = v57 + 1_i32;
                    v55.l0.set(v94);
                    v55.l1.set(v93);
                    ()
                }
                {
                    let v95: Dice_ui::US51 = v55.l1.get().clone();
                    let v107: Dice_ui::US51 = match &v95 {
                        Dice_ui::US51::US51_1(v95_1_0) => {
                            let v97: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                                Dice_ui::method388(v95_1_0.clone());
                            let v98 = Dice_ui::method389();
                            let mut v97 = v97;
                            v97.sort_by_key(|x| v98(x.clone()));
                            Dice_ui::US51::US51_1(v97)
                        }
                        Dice_ui::US51::US51_0(v95_0_0) => Dice_ui::US51::US51_0(v95_0_0.clone()),
                    };
                    let v121: Dice_ui::US52 = match &v107 {
                        Dice_ui::US51::US51_1(v107_1_0) => {
                            let v109: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                                Dice_ui::method390(v107_1_0.clone());
                            let mut v109 = v109;
                            v109.reverse();
                            {
                                let v114: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                                    Dice_ui::method374(v109);
                                Dice_ui::US52::US52_1(fable_library_rust::NativeArray_::array_from(
                                    v114,
                                ))
                            }
                        }
                        Dice_ui::US51::US51_0(v107_0_0) => Dice_ui::US52::US52_0(v107_0_0.clone()),
                    };
                    let v128: Dice_ui::US50 = match &v121 {
                        Dice_ui::US52::US52_1(v121_1_0) => {
                            Dice_ui::US50::US50_1(Some(v121_1_0.clone()))
                        }
                        Dice_ui::US52::US52_0(v121_0_0) => Dice_ui::US50::US50_0(v121_0_0.clone()),
                    };
                    match &v128 {
                        Dice_ui::US50::US50_1(v128_1_0) => {
                            Ok::<
                                Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                                std::string::String,
                            >(v128_1_0.clone())
                        }
                        Dice_ui::US50::US50_0(v128_0_0) => {
                            Err::<
                                Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                                std::string::String,
                            >(v128_0_0.clone())
                        }
                    }
                }
            }
        }
        pub fn method361(
            v0_1: leptos::Memo<Array<(string, string)>>,
            v1: Func0<
                Array<
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
            >,
        ) -> Func0<
            Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
        > {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure181(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure196(v0_1: leptos::WriteSignal<bool>, unitVar: ()) {
            let v1 = Dice_ui::method227();
            let v2: leptos::WriteSignal<bool> = Dice_ui::method90(v0_1);
            leptos::SignalUpdate::update(&v2, |x| *x = v1(x.clone()));
            ()
        }
        pub fn method391(v0_1: leptos::WriteSignal<bool>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure196(v0_1.clone(), ())
            })
        }
        pub fn closure197(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string =
                string("d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"");
            let v7: string = append(
                append(
                    append(string(" "), v2),
                    string(" stroke-linejoin=\"round\" stroke-linecap=\"round\""),
                ),
                string(""),
            );
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v15: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method158(
                leptos::view! {
                    <path
                        d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"
                        stroke-linejoin="round"
                        stroke-linecap="round"
                    >
                        {v9()}
                    </path>
                },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            let v24: string =
                string(" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v26 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v31: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method158(
                leptos::view! {
                    <path
                        d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"
                        stroke-linejoin="round"
                        stroke-linecap="round"
                    >
                        {v26()}
                    </path>
                },
            );
            let v36: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v17,
                leptos::IntoView::into_view(v31),
            ])));
            let v38: Vec<leptos::View> = v36.to_vec();
            leptos::Fragment::new(v38)
        }
        pub fn method392() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure197((), ()))
        }
        pub fn closure198(v0_1: leptos::ReadSignal<bool>, unitVar: ()) -> &'static str {
            let v1: leptos::ReadSignal<bool> = Dice_ui::method82(v0_1);
            if leptos::SignalGet::get(&v1) {
                let v5: string = string("r#\"\"#");
                r#""#
            } else {
                let v8: string = string("r#\" bg-gray-100\"#");
                r#" bg-gray-100"#
            }
        }
        pub fn method393(v0_1: leptos::ReadSignal<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure198(v0_1.clone(), ())
            })
        }
        pub fn method394() -> string {
            string("Transactions")
        }
        pub fn method398() -> string {
            string("Settings")
        }
        pub fn closure201(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method398()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method397() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure201((), ()))
        }
        pub fn closure202(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method154(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method155(Func0::new(move || v1()));
            let v9: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(move || v4()),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method399(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure202(v0_1.clone(), ())
            })
        }
        pub fn closure204(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            v0_1()
        }
        pub fn method401(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure204(v0_1.clone(), ())
            })
        }
        pub fn closure205(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method402() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure205((), ()))
        }
        pub fn closure203(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"pr-[15px] [font-size:13px]\"");
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method401(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                leptos::view! { <span class="pr-[15px] [font-size:13px]">{v6()}</span> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"h-px flex-1 bg-gray-300\"");
            let v19 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method402()));
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
            let v24: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                leptos::view! { <span class="h-px flex-1 bg-gray-300">{v19()}</span> },
            );
            let v29: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v14,
                leptos::IntoView::into_view(v24),
            ])));
            let v31: Vec<leptos::View> = v29.to_vec();
            leptos::Fragment::new(v31)
        }
        pub fn method400(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure203(v0_1.clone(), ())
            })
        }
        pub fn method404() -> string {
            string("Table View")
        }
        pub fn closure206(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method404()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method403() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure206((), ()))
        }
        pub fn method406() -> string {
            string("table-view")
        }
        pub fn closure210(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
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
        pub fn method409() -> Func1<LrcPtr<Dice_ui::Heap0>, LrcPtr<Dice_ui::Heap0>> {
            Func1::new(move |v: LrcPtr<Dice_ui::Heap0>| Dice_ui::closure210((), v))
        }
        pub fn closure209(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method409();
            let v8: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method71(v5.l1.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method408(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure209(v0_1.clone(), v)
            })
        }
        pub fn closure211(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method64(v0_1.l0.clone());
            let v6: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                Dice_ui::method85((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            if let Dice_ui::US1::US1_1 = &(leptos::SignalGet::get(&v6)).l1 {
                true
            } else {
                false
            }
        }
        pub fn method410(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure211(v0_1.clone(), ())
            })
        }
        pub fn closure208(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2 = Dice_ui::method408(v0_1.clone());
            let on_change = v2;
            {
                let v4 = Dice_ui::method410(v0_1);
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
                    let v22: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method182(
                        leptos::view! {
                            <input
                                prop:checked=move || get_value()
                                on:change=move |event| on_change(event)
                                id=v1
                                type="checkbox"
                                class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden"
                            />
                        },
                    );
                    let v24: leptos::View = leptos::IntoView::into_view(v22);
                    let v25: string =
                        string("class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"");
                    let v27: string =
                        append(append(append(string(" "), v25), string("")), string(""));
                    let v29 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method183()));
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
                    let v35: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400">
                                {v29()}
                            </span>
                        },
                    );
                    let v37: leptos::View = leptos::IntoView::into_view(v35);
                    let v38: string =
                        string("class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"");
                    let v40: string =
                        append(append(append(string(" "), v38), string("")), string(""));
                    let v42 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method190()));
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
                    let v47: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                        leptos::view! {
                            <span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300">
                                {v42()}
                            </span>
                        },
                    );
                    let v52: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            v24,
                            v37,
                            leptos::IntoView::into_view(v47),
                        ])));
                    let v54: Vec<leptos::View> = v52.to_vec();
                    leptos::Fragment::new(v54)
                }
            }
        }
        pub fn method407(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure208(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure207(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method406());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let id = v6.clone();
            {
                let v13: string =
                    string(" class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\" for=id");
                let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method407(v0_1, v6)));
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
                let v21: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method191(
                    leptos::view! {
                        <label
                            class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"
                            for=id
                        >
                            {v15()}
                        </label>
                    },
                );
                let v26: Array<leptos::View> =
                    Dice_ui::method123(Dice_ui::method122(new_array(&[
                        leptos::IntoView::into_view(v21),
                    ])));
                let v28: Vec<leptos::View> = v26.to_vec();
                leptos::Fragment::new(v28)
            }
        }
        pub fn method405(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure207(v0_1.clone(), ())
            })
        }
        pub fn closure200(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v6: string = string(" class=\"flex items-center pb-[6px]\"");
            let v8 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method400(
                Dice_ui::method399(Dice_ui::method397()),
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
            let v14: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                leptos::view! { <span class="flex items-center pb-[6px]">{v8()}</span> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v25: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center\"");
            let v27 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method403(),
                Dice_ui::method405(v0_1),
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
            let v33: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] items-center">
                        {v27()}
                    </dl>
                },
            );
            let v38: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v16,
                leptos::IntoView::into_view(v33),
            ])));
            let v40: Vec<leptos::View> = v38.to_vec();
            leptos::Fragment::new(v40)
        }
        pub fn method396(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure200(v0_1.clone(), ())
            })
        }
        pub fn method411(
            v0_1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> leptos::Memo<
            Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
        > {
            v0_1
        }
        pub fn closure214(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string = string(
                " d=\"M6 18L18 6M6 6l12 12\" stroke-linejoin=\"round\" stroke-linecap=\"round\"",
            );
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method156(new_array(
                &[
                    leptos::view! {
                        <path
                            d="M6 18L18 6M6 6l12 12"
                            stroke-linejoin="round"
                            stroke-linecap="round"
                        >
                            {v9()}
                        </path>
                    },
                ],
            ));
            let v17 = Dice_ui::method157();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method159(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method160(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method414() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure214((), ()))
        }
        pub fn closure213(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v15: string =
                string(" class=\"text-red-700\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" height=\"100%\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
            let v17 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method414()));
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
            let v23: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(
                leptos::view! {
                    <svg
                        class="text-red-700"
                        stroke="currentColor"
                        stroke-width="1.5"
                        viewBox="0 0 24 24"
                        height="100%"
                        fill="none"
                        xmlns="http://www.w3.org/2000/svg"
                    >
                        {v17()}
                    </svg>
                },
            );
            let v28: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method413() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure213((), ()))
        }
        pub fn closure215(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method60(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method415(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure215(v0_1.clone(), ())
            })
        }
        pub fn closure212(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[height:20px]\"");
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method413()));
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
                Dice_ui::method189(leptos::view! { <span class="[height:20px]">{v6()}</span> });
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"[overflow-y:auto]\"");
            let v19 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method415(v0_1)));
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
                Dice_ui::method255(leptos::view! { <pre class="[overflow-y:auto]">{v19()}</pre> });
            let v30: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method412(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure212(v0_1.clone(), ())
            })
        }
        pub fn closure219(v0_1: i64, unitVar: ()) -> leptos::Fragment {
            let v4: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(append(
                append(string("Transaction "), toString(v0_1 + 1_i64)),
                string(""),
            ))));
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: leptos::leptos_dom::Text = leptos::html::text(v8);
            let v15: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v10),
            ])));
            let v17: Vec<leptos::View> = v15.to_vec();
            leptos::Fragment::new(v17)
        }
        pub fn method419(v0_1: i64) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure219(v0_1, ())
            })
        }
        pub fn method422() -> string {
            string("Account")
        }
        pub fn closure221(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method422()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method421() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure221((), ()))
        }
        pub fn closure222(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v14: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v9),
            ])));
            let v16: Vec<leptos::View> = v14.to_vec();
            leptos::Fragment::new(v16)
        }
        pub fn method423(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure222(v0_1.clone(), ())
            })
        }
        pub fn method425() -> string {
            string("Block Timestamp")
        }
        pub fn closure223(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method425()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method424() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure223((), ()))
        }
        pub fn method427(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method428(v0_1: i64) -> i64 {
            v0_1
        }
        pub fn closure225(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> Dice_ui::US53 {
            Dice_ui::US53::US53_1(v0_1)
        }
        pub fn method429(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
            v0_1
        }
        pub fn method430(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn closure224(
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
            let v12: std::string::String = Dice_ui::method427(v3);
            let v15: i64 = Dice_ui::method428(v12.parse().unwrap());
            let v20: Dice_ui::US53 = defaultValue(
                Dice_ui::US53::US53_0,
                map(
                    Func1::new(move |v: chrono::DateTime<chrono::Utc>| Dice_ui::closure225((), v)),
                    chrono::DateTime::from_timestamp_micros(v15 / 1000i64),
                ),
            );
            let v39: Dice_ui::US38 = match &v20 {
                Dice_ui::US53::US53_1(v20_1_0) => {
                    let v22: chrono::DateTime<chrono::Utc> = Dice_ui::method429(v20_1_0.clone());
                    let v24: chrono::NaiveDateTime = v22.naive_utc();
                    let v26: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v24);
                    let v28: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v29: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v30: chrono::DateTime<chrono::Local> = Dice_ui::method430(v26);
                    let v33: std::string::String = Dice_ui::method60(v30.format(v29).to_string());
                    Dice_ui::US38::US38_1(fable_library_rust::String_::fromString(v33))
                }
                _ => Dice_ui::US38::US38_0,
            };
            let v45: Dice_ui::US54 = match &v39 {
                Dice_ui::US38::US38_1(v39_1_0) => Dice_ui::US54::US54_1(v39_1_0.clone()),
                _ => Dice_ui::US54::US54_0(string(
                    "resultm.from_option / Option does not have a value.",
                )),
            };
            let v53: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(match &v45 {
                Dice_ui::US54::US54_1(v45_1_0) => v45_1_0.clone(),
                Dice_ui::US54::US54_0(v45_0_0) => {
                    append(append(string("Error: "), v45_0_0.clone()), string(""))
                }
            })));
            let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
            let v57: std::string::String = String::from(v55);
            let v59: leptos::leptos_dom::Text = leptos::html::text(v57);
            let v64: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v59),
            ])));
            let v66: Vec<leptos::View> = v64.to_vec();
            leptos::Fragment::new(v66)
        }
        pub fn method426(
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
                    Dice_ui::closure224(
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
        pub fn method432() -> string {
            string("Predecessor")
        }
        pub fn closure226(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method432()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method431() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure226((), ()))
        }
        pub fn closure227(
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
            let v12: std::string::String = Dice_ui::method60(v8);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method433(
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
                    Dice_ui::closure227(
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
        pub fn method435() -> string {
            string("Receiver")
        }
        pub fn closure228(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method435()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method434() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure228((), ()))
        }
        pub fn closure229(
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
            let v12: std::string::String = Dice_ui::method60(v10);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method436(
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
                    Dice_ui::closure229(
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
        pub fn method438() -> string {
            string("Actions")
        }
        pub fn closure230(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method438()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method437() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure230((), ()))
        }
        pub fn closure233(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method60(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
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
            let v26: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method441(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure233(v0_1.clone(), ())
            })
        }
        pub fn method445() -> string {
            string("Method")
        }
        pub fn closure236(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method445()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method444() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure236((), ()))
        }
        pub fn method447() -> string {
            string("None")
        }
        pub fn closure237(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v3: Dice_ui::US15 = defaultValue(
                Dice_ui::US15::US15_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure32((), v)),
                    v0_1,
                ),
            );
            match &v3 {
                Dice_ui::US15::US15_1(v3_1_0) => {
                    let v5: std::string::String = Dice_ui::method60(v3_1_0.clone());
                    let v10: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                        fable_library_rust::String_::fromString(v5),
                    )));
                    let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
                    let v14: std::string::String = String::from(v12);
                    let v16: leptos::leptos_dom::Text = leptos::html::text(v14);
                    let v21: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            leptos::IntoView::into_view(v16),
                        ])));
                    let v23: Vec<leptos::View> = v21.to_vec();
                    leptos::Fragment::new(v23)
                }
                _ => {
                    let v28: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method447()));
                    let v30: &str = fable_library_rust::String_::LrcStr::as_str(&v28);
                    let v32: std::string::String = String::from(v30);
                    let v34: leptos::leptos_dom::Text = leptos::html::text(v32);
                    let v39: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            leptos::IntoView::into_view(v34),
                        ])));
                    let v41: Vec<leptos::View> = v39.to_vec();
                    leptos::Fragment::new(v41)
                }
            }
        }
        pub fn method446(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure237(v0_1.clone(), ())
            })
        }
        pub fn closure235(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  \"");
            let v10 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method444(),
                Dice_ui::method446(v0_1),
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
            let v16: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  ">
                        {v10()}
                    </dl>
                },
            );
            let v21: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method443(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure235(v0_1.clone(), ())
            })
        }
        pub fn closure234(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col\"");
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method443(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="flex flex-1 flex-col">{v6()}</div> },
            );
            let v17: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method442(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure234(v0_1.clone(), ())
            })
        }
        pub fn closure232(
            unitVar: (),
            _arg: (std::string::String, Option<std::string::String>),
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center \"");
            let v11 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method441(_arg.0.clone()),
                Dice_ui::method442(_arg.1.clone()),
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
        pub fn method440() -> Func1<
            (std::string::String, Option<std::string::String>),
            leptos::HtmlElement<leptos::html::Dl>,
        > {
            Func1::new(
                move |arg10_0040: (std::string::String, Option<std::string::String>)| {
                    Dice_ui::closure232((), arg10_0040)
                },
            )
        }
        pub fn method448(
            v0_1: Array<(std::string::String, Option<std::string::String>)>,
        ) -> Array<(std::string::String, Option<std::string::String>)> {
            v0_1
        }
        pub fn method449(
            v0_1: Vec<leptos::HtmlElement<leptos::html::Dl>>,
        ) -> Vec<leptos::HtmlElement<leptos::html::Dl>> {
            v0_1
        }
        pub fn closure231(
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
            let v12 = Dice_ui::method440();
            let v13: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method448(v0_1);
            let v15: Vec<(std::string::String, Option<std::string::String>)> = v13.to_vec();
            let v18: Vec<leptos::HtmlElement<leptos::html::Dl>> =
                Dice_ui::method449(v15.iter().map(|x| v12(x.clone())).collect());
            let v20: Array<leptos::HtmlElement<leptos::html::Dl>> =
                fable_library_rust::NativeArray_::array_from(v18);
            let v21 = Dice_ui::method241();
            let v22: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method243(v20);
            let v24: Vec<leptos::HtmlElement<leptos::html::Dl>> = v22.to_vec();
            let v27: Vec<leptos::View> =
                Dice_ui::method160(v24.iter().map(|x| v21(x.clone())).collect());
            let v30: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v27));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method439(
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
                    Dice_ui::closure231(
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
        pub fn method451() -> string {
            string("Deposit")
        }
        pub fn closure238(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method451()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method450() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure238((), ()))
        }
        pub fn closure239(
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
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(toString(v1))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method452(
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
                    Dice_ui::closure239(
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
        pub fn method454() -> string {
            string("Outcome Status")
        }
        pub fn closure240(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method454()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method453() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure240((), ()))
        }
        pub fn closure241(
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
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(ofBoolean(v6))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method455(
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
                    Dice_ui::closure241(
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
        pub fn method457() -> string {
            string("Fee")
        }
        pub fn closure242(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method457()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method456() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure242((), ()))
        }
        pub fn closure243(
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
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(toString(v7))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method458(
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
                    Dice_ui::closure243(
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
        pub fn method460() -> string {
            string("Block Height")
        }
        pub fn closure244(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method460()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method459() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure244((), ()))
        }
        pub fn closure245(
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
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(toString(v2))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v26: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method461(
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
                    Dice_ui::closure245(
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
        pub fn method463() -> string {
            string("Hash")
        }
        pub fn closure246(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method463()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method462() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure246((), ()))
        }
        pub fn closure247(
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
            let v12: std::string::String = Dice_ui::method60(v11);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method464(
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
                    Dice_ui::closure247(
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
        pub fn method466() -> string {
            string("Block Hash")
        }
        pub fn closure248(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method466()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method465() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure248((), ()))
        }
        pub fn closure249(
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
            let v12: std::string::String = Dice_ui::method60(v4);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method467(
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
                    Dice_ui::closure249(
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
        pub fn method469() -> string {
            string("Receipt ID")
        }
        pub fn closure250(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method469()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method468() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure250((), ()))
        }
        pub fn closure251(
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
            let v12: std::string::String = Dice_ui::method60(v9);
            let v17: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v28: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v23),
            ])));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method470(
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
                    Dice_ui::closure251(
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
        pub fn method472() -> string {
            string("Logs")
        }
        pub fn closure252(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method472()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method471() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure252((), ()))
        }
        pub fn closure254(unitVar: (), v0_1: std::string::String) -> string {
            let v1: std::string::String = Dice_ui::method60(v0_1);
            fable_library_rust::String_::fromString(v1)
        }
        pub fn method474() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Dice_ui::closure254((), v))
        }
        pub fn closure253(
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
            let v12 = Dice_ui::method474();
            let v13: Array<std::string::String> = Dice_ui::method264(v5);
            let v15: Vec<std::string::String> = v13.to_vec();
            let v18: Vec<string> = Dice_ui::method270(v15.iter().map(|x| v12(x.clone())).collect());
            let v29: string =
                string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh]\"");
            let v31 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method254(replace(
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
            let v37: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method255(
                leptos::view! {
                    <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh]">
                        {v31()}
                    </pre>
                },
            );
            let v42: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v37),
            ])));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method473(
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
                    Dice_ui::closure253(
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
        pub fn closure220(
            v0_1: string,
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
            let v21: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v23 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method421(),
                Dice_ui::method423(v0_1),
            )));
            let v26: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v21), string(">{v23()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v29: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v23()}
                    </dl>
                },
            );
            let v31: leptos::View = leptos::IntoView::into_view(v29);
            let v37: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v39 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method424(),
                Dice_ui::method426(
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
                ),
            )));
            let v41: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v37), string(">{v39()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v44: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v39()}
                    </dl>
                },
            );
            let v46: leptos::View = leptos::IntoView::into_view(v44);
            let v52: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v54 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method431(),
                Dice_ui::method433(
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
                ),
            )));
            let v56: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v52), string(">{v54()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v59: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v54()}
                    </dl>
                },
            );
            let v61: leptos::View = leptos::IntoView::into_view(v59);
            let v67: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v69 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method434(),
                Dice_ui::method436(
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
            let v74: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v69()}
                    </dl>
                },
            );
            let v76: leptos::View = leptos::IntoView::into_view(v74);
            let v83: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]\"");
            let v85 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method437(),
                Dice_ui::method439(
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
                ),
            )));
            let v87: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v83), string(">{v85()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v90: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]">
                        {v85()}
                    </dl>
                },
            );
            let v92: leptos::View = leptos::IntoView::into_view(v90);
            let v98: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v100 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method450(),
                Dice_ui::method452(
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
                ),
            )));
            let v102: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v98), string(">{v100()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v105: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v100()}
                    </dl>
                },
            );
            let v107: leptos::View = leptos::IntoView::into_view(v105);
            let v113: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v115 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method453(),
                Dice_ui::method455(
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
                ),
            )));
            let v117: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v113), string(">{v115()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v120: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v115()}
                    </dl>
                },
            );
            let v122: leptos::View = leptos::IntoView::into_view(v120);
            let v128: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v130 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method456(),
                Dice_ui::method458(
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
                ),
            )));
            let v132: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v128), string(">{v130()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v135: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v130()}
                    </dl>
                },
            );
            let v137: leptos::View = leptos::IntoView::into_view(v135);
            let v143: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v145 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method459(),
                Dice_ui::method461(
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
                ),
            )));
            let v147: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v143), string(">{v145()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v150: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v145()}
                    </dl>
                },
            );
            let v152: leptos::View = leptos::IntoView::into_view(v150);
            let v158: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v160 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method462(),
                Dice_ui::method464(
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
                ),
            )));
            let v162: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v158), string(">{v160()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v165: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v160()}
                    </dl>
                },
            );
            let v167: leptos::View = leptos::IntoView::into_view(v165);
            let v173: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v175 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method465(),
                Dice_ui::method467(
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
                ),
            )));
            let v177: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v173), string(">{v175()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v180: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v175()}
                    </dl>
                },
            );
            let v182: leptos::View = leptos::IntoView::into_view(v180);
            let v188: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v190 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method468(),
                Dice_ui::method470(
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
                ),
            )));
            let v192: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v188), string(">{v190()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v195: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                leptos::view! {
                    <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                        {v190()}
                    </dl>
                },
            );
            let v224: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v31,
                v46,
                v61,
                v76,
                v92,
                v107,
                v122,
                v137,
                v152,
                v167,
                v182,
                leptos::IntoView::into_view(v195),
                if count(v6.clone()) as u64 == 0_u64 {
                    let v203: Array<leptos::View> =
                        Dice_ui::method167(Dice_ui::method166(Dice_ui::method122(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v203.to_vec())
                } else {
                    let v211:
                                                                              string =
                                                                          string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
                    let v213 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                        Dice_ui::method471(),
                        Dice_ui::method473(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12),
                    )));
                    let v215: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<dl "), v211), string(">{v213()}</")),
                                    string("dl"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v218: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method242(
                        leptos::view! {
                            <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">
                                {v213()}
                            </dl>
                        },
                    );
                    leptos::IntoView::into_view(v218)
                },
            ])));
            let v226: Vec<leptos::View> = v224.to_vec();
            leptos::Fragment::new(v226)
        }
        pub fn method420(
            v0_1: string,
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
                    Dice_ui::closure220(
                        v0_1.clone(),
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
        pub fn closure218(
            v0_1: string,
            v1: i64,
            v2: Array<(std::string::String, Option<std::string::String>)>,
            v3: f64,
            v4: u32,
            v5: std::string::String,
            v6: std::string::String,
            v7: Array<std::string::String>,
            v8: bool,
            v9: f64,
            v10: std::string::String,
            v11: std::string::String,
            v12: std::string::String,
            v13: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v19: string = string(" class=\"flex items-center pb-[6px]\"");
            let v21 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method400(
                Dice_ui::method399(Dice_ui::method419(v1)),
            )));
            let v24: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v19), string(">{v21()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v27: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method189(
                leptos::view! { <span class="flex items-center pb-[6px]">{v21()}</span> },
            );
            let v29: leptos::View = leptos::IntoView::into_view(v27);
            let v32: string = string(" class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\"");
            let v34 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method420(
                v0_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13,
            )));
            let v37: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v32), string(">{v34()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v40: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="grid flex-1 divide-y-[1px] divide-gray-500/[.10]">{v34()}</div> },
            );
            let v45: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v29,
                leptos::IntoView::into_view(v40),
            ])));
            let v47: Vec<leptos::View> = v45.to_vec();
            leptos::Fragment::new(v47)
        }
        pub fn method418(
            v0_1: string,
            v1: i64,
            v2: Array<(std::string::String, Option<std::string::String>)>,
            v3: f64,
            v4: u32,
            v5: std::string::String,
            v6: std::string::String,
            v7: Array<std::string::String>,
            v8: bool,
            v9: f64,
            v10: std::string::String,
            v11: std::string::String,
            v12: std::string::String,
            v13: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v12 = v12.clone();
                let v13 = v13.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure218(
                        v0_1.clone(),
                        v1,
                        v2.clone(),
                        v3,
                        v4,
                        v5.clone(),
                        v6.clone(),
                        v7.clone(),
                        v8,
                        v9,
                        v10.clone(),
                        v11.clone(),
                        v12.clone(),
                        v13.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure217(
            unitVar: (),
            _arg: (string, usize, LrcPtr<Dice_ui::Heap5>),
        ) -> leptos::View {
            let v2: LrcPtr<Dice_ui::Heap5> = _arg.2.clone();
            let v15: i64 = _arg.1.clone() as i64;
            let v17: Option<LrcPtr<Dice_ui::Heap2>> = leptos::use_context::<std::rc::Rc<Heap2>>();
            let v19: LrcPtr<Dice_ui::Heap2> = v17.unwrap();
            let v23: string = string(" class=\"flex flex-1 flex-col overflow-x-auto\"");
            let v25 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method418(
                _arg.0.clone(),
                v15,
                v2.l0.clone(),
                v2.l1,
                v2.l2,
                v2.l3.clone(),
                v2.l4.clone(),
                v2.l5.clone(),
                v2.l6,
                v2.l7,
                v2.l8.clone(),
                v2.l9.clone(),
                v2.l10.clone(),
                v2.l11.clone(),
            )));
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
            let v31: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="flex flex-1 flex-col overflow-x-auto">{v25()}</div> },
            );
            leptos::IntoView::into_view(v31)
        }
        pub fn method417() -> Func1<(string, usize, LrcPtr<Dice_ui::Heap5>), leptos::View> {
            Func1::new(move |arg10_0040: (string, usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure217((), arg10_0040)
            })
        }
        pub fn closure216(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method417();
            let v2: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method384(v0_1);
            let v4: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> = v2.to_vec();
            let v7: Vec<leptos::View> =
                Dice_ui::method160(v4.iter().map(|x| v1(x.clone())).collect());
            let v10: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v7));
            let v12: Vec<leptos::View> = v10.to_vec();
            leptos::Fragment::new(v12)
        }
        pub fn method416(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure216(v0_1.clone(), ())
            })
        }
        pub fn closure258(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method422()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method478() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure258((), ()))
        }
        pub fn method479(
            v0_1: leptos::HtmlElement<leptos::html::Th>,
        ) -> leptos::HtmlElement<leptos::html::Th> {
            v0_1
        }
        pub fn closure259(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method425()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method480() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure259((), ()))
        }
        pub fn closure260(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method432()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method481() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure260((), ()))
        }
        pub fn closure261(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method435()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method482() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure261((), ()))
        }
        pub fn method484() -> string {
            string("Action")
        }
        pub fn closure262(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method484()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method483() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure262((), ()))
        }
        pub fn method486() -> string {
            string("Action Method")
        }
        pub fn closure263(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method486()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method485() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure263((), ()))
        }
        pub fn closure264(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method451()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method487() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure264((), ()))
        }
        pub fn closure265(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method457()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method488() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure265((), ()))
        }
        pub fn closure266(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method460()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method489() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure266((), ()))
        }
        pub fn method492(v0_1: Array<std::string::String>, v1: i32) -> bool {
            let v0_1: MutCell<Array<std::string::String>> = MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method492: loop {
                break '_method492 (if v1.get().clone() < count(v0_1.get().clone()) {
                    let v5: std::string::String = Dice_ui::method60(v0_1[v1.get().clone()].clone());
                    if length(fable_library_rust::String_::fromString(v5)) > 0_i32 {
                        true
                    } else {
                        let v0_1_temp: Array<std::string::String> = v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method492;
                    }
                } else {
                    false
                });
            }
        }
        pub fn method491(v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>, v1: i32) -> bool {
            let v0_1: MutCell<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>> =
                MutCell::new(v0_1.clone());
            let v1: MutCell<i32> = MutCell::new(v1);
            '_method491: loop {
                break '_method491 (if v1.get().clone() < count(v0_1.get().clone()) {
                    if Dice_ui::method492(
                        ((v0_1[v1.get().clone()].clone()).2.clone()).l5.clone(),
                        0_i32,
                    ) {
                        true
                    } else {
                        let v0_1_temp: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> =
                            v0_1.get().clone();
                        let v1_temp: i32 = v1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        continue '_method491;
                    }
                } else {
                    false
                });
            }
        }
        pub fn closure267(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v9: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                if false == Dice_ui::method491(v0_1, 0_i32) {
                    string("")
                } else {
                    string("Logs")
                },
            )));
            let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
            let v13: std::string::String = String::from(v11);
            let v15: leptos::leptos_dom::Text = leptos::html::text(v13);
            let v20: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v15),
            ])));
            let v22: Vec<leptos::View> = v20.to_vec();
            leptos::Fragment::new(v22)
        }
        pub fn method490(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure267(v0_1.clone(), ())
            })
        }
        pub fn closure268(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method454()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method493() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure268((), ()))
        }
        pub fn closure269(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method463()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method494() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure269((), ()))
        }
        pub fn closure270(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method466()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method495() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure270((), ()))
        }
        pub fn closure271(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method469()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method496() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure271((), ()))
        }
        pub fn closure257(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method478()));
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
            let v12: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v19 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method480()));
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
            let v24: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v31 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method481()));
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
            let v36: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v43 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method482()));
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
            let v48: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v55 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method483()));
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
            let v60: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v67 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method485()));
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
            let v72: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v79 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method487()));
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
            let v84: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v91 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method488()));
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
            let v96: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v103 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method489()));
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
            let v108: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v115 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method490(v0_1)));
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
            let v120: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v127 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method493()));
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
            let v132: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v139 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method494()));
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
            let v144: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
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
            let v151 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method495()));
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
            let v156: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v151()}
                    </th>
                },
            );
            let v158: leptos::View = leptos::IntoView::into_view(v156);
            let v161: string = string(
                " class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\"",
            );
            let v163 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method496()));
            let v165: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<th "), v161), string(">{v163()}</")),
                            string("th"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v168: leptos::HtmlElement<leptos::html::Th> = Dice_ui::method479(
                leptos::view! {
                    <th class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white">
                        {v163()}
                    </th>
                },
            );
            let v173: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
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
                v158,
                leptos::IntoView::into_view(v168),
            ])));
            let v175: Vec<leptos::View> = v173.to_vec();
            leptos::Fragment::new(v175)
        }
        pub fn method477(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure257(v0_1.clone(), ())
            })
        }
        pub fn method497(
            v0_1: Array<leptos::HtmlElement<leptos::html::Tr>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Tr>> {
            v0_1
        }
        pub fn method499(
            v0_1: leptos::HtmlElement<leptos::html::Tr>,
        ) -> leptos::HtmlElement<leptos::html::Tr> {
            v0_1
        }
        pub fn closure272(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Tr>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Tr> = Dice_ui::method499(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method498() -> Func1<leptos::HtmlElement<leptos::html::Tr>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Tr>| Dice_ui::closure272((), v))
        }
        pub fn method500(
            v0_1: Array<leptos::HtmlElement<leptos::html::Tr>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Tr>> {
            v0_1
        }
        pub fn closure256(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v3 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method477(v0_1)));
            let v7: string = string("leptos::view! { <tr >{v3()}</tr> }");
            let v11: Array<leptos::HtmlElement<leptos::html::Tr>> =
                Dice_ui::method497(new_array(&[leptos::view! { <tr>{v3()}</tr> }]));
            let v12 = Dice_ui::method498();
            let v13: Array<leptos::HtmlElement<leptos::html::Tr>> = Dice_ui::method500(v11);
            let v15: Vec<leptos::HtmlElement<leptos::html::Tr>> = v13.to_vec();
            let v18: Vec<leptos::View> =
                Dice_ui::method160(v15.iter().map(|x| v12(x.clone())).collect());
            let v21: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v18));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method476(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure256(v0_1.clone(), ())
            })
        }
        pub fn method501(
            v0_1: leptos::HtmlElement<leptos::html::Thead>,
        ) -> leptos::HtmlElement<leptos::html::Thead> {
            v0_1
        }
        pub fn closure276(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v14: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v9),
            ])));
            let v16: Vec<leptos::View> = v14.to_vec();
            leptos::Fragment::new(v16)
        }
        pub fn method505(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure276(v0_1.clone(), ())
            })
        }
        pub fn method506(
            v0_1: leptos::HtmlElement<leptos::html::Td>,
        ) -> leptos::HtmlElement<leptos::html::Td> {
            v0_1
        }
        pub fn closure277(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method427(v0_1.l3.clone());
            let v5: i64 = Dice_ui::method428(v2.parse().unwrap());
            let v10: Dice_ui::US53 = defaultValue(
                Dice_ui::US53::US53_0,
                map(
                    Func1::new(move |v: chrono::DateTime<chrono::Utc>| Dice_ui::closure225((), v)),
                    chrono::DateTime::from_timestamp_micros(v5 / 1000i64),
                ),
            );
            let v29: Dice_ui::US38 = match &v10 {
                Dice_ui::US53::US53_1(v10_1_0) => {
                    let v12: chrono::DateTime<chrono::Utc> = Dice_ui::method429(v10_1_0.clone());
                    let v14: chrono::NaiveDateTime = v12.naive_utc();
                    let v16: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v14);
                    let v18: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v19: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v20: chrono::DateTime<chrono::Local> = Dice_ui::method430(v16);
                    let v23: std::string::String = Dice_ui::method60(v20.format(v19).to_string());
                    Dice_ui::US38::US38_1(fable_library_rust::String_::fromString(v23))
                }
                _ => Dice_ui::US38::US38_0,
            };
            let v35: Dice_ui::US54 = match &v29 {
                Dice_ui::US38::US38_1(v29_1_0) => Dice_ui::US54::US54_1(v29_1_0.clone()),
                _ => Dice_ui::US54::US54_0(string(
                    "resultm.from_option / Option does not have a value.",
                )),
            };
            let v43: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(match &v35 {
                Dice_ui::US54::US54_1(v35_1_0) => v35_1_0.clone(),
                Dice_ui::US54::US54_0(v35_0_0) => {
                    append(append(string("Error: "), v35_0_0.clone()), string(""))
                }
            })));
            let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
            let v47: std::string::String = String::from(v45);
            let v49: leptos::leptos_dom::Text = leptos::html::text(v47);
            let v54: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v49),
            ])));
            let v56: Vec<leptos::View> = v54.to_vec();
            leptos::Fragment::new(v56)
        }
        pub fn method507(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure277(v0_1.clone(), ())
            })
        }
        pub fn closure278(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method60(v0_1.l8.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method508(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure278(v0_1.clone(), ())
            })
        }
        pub fn closure279(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method60(v0_1.l10.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method509(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure279(v0_1.clone(), ())
            })
        }
        pub fn closure281(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method60(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
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
            let v26: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method511(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure281(v0_1.clone(), ())
            })
        }
        pub fn closure282(v0_1: Option<std::string::String>, unitVar: ()) -> leptos::Fragment {
            let v3: Dice_ui::US15 = defaultValue(
                Dice_ui::US15::US15_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure32((), v)),
                    v0_1,
                ),
            );
            let v11: Dice_ui::US38 = match &v3 {
                Dice_ui::US15::US15_1(v3_1_0) => {
                    let v5: std::string::String = Dice_ui::method60(v3_1_0.clone());
                    Dice_ui::US38::US38_1(fable_library_rust::String_::fromString(v5))
                }
                _ => Dice_ui::US38::US38_0,
            };
            let v18: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(match &v11 {
                Dice_ui::US38::US38_1(v11_1_0) => v11_1_0.clone(),
                _ => string("None"),
            })));
            let v20: &str = fable_library_rust::String_::LrcStr::as_str(&v18);
            let v22: std::string::String = String::from(v20);
            let v24: leptos::leptos_dom::Text = leptos::html::text(v22);
            let v29: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v24),
            ])));
            let v31: Vec<leptos::View> = v29.to_vec();
            leptos::Fragment::new(v31)
        }
        pub fn method512(v0_1: Option<std::string::String>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure282(v0_1.clone(), ())
            })
        }
        pub fn closure280(
            unitVar: (),
            _arg: (std::string::String, Option<std::string::String>),
        ) -> leptos::Fragment {
            let v5: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v7 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method511(_arg.0.clone())));
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
            let v13: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v7()}
                    </td>
                },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v20 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method512(_arg.1.clone())));
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
            let v25: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v20()}
                    </td>
                },
            );
            let v30: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v15,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method510(
        ) -> Func1<(std::string::String, Option<std::string::String>), leptos::Fragment> {
            Func1::new(
                move |arg10_0040: (std::string::String, Option<std::string::String>)| {
                    Dice_ui::closure280((), arg10_0040)
                },
            )
        }
        pub fn method513(v0_1: Vec<leptos::Fragment>) -> Vec<leptos::Fragment> {
            v0_1
        }
        pub fn method515(v0_1: leptos::Fragment) -> leptos::Fragment {
            v0_1
        }
        pub fn closure283(unitVar: (), v0_1: leptos::Fragment) -> leptos::View {
            let v1: leptos::Fragment = Dice_ui::method515(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method514() -> Func1<leptos::Fragment, leptos::View> {
            Func1::new(move |v: leptos::Fragment| Dice_ui::closure283((), v))
        }
        pub fn method516(v0_1: Array<leptos::Fragment>) -> Array<leptos::Fragment> {
            v0_1
        }
        pub fn closure284(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(toString(v0_1.l1))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method517(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure284(v0_1.clone(), ())
            })
        }
        pub fn closure285(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(toString(v0_1.l7))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method518(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure285(v0_1.clone(), ())
            })
        }
        pub fn closure286(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(toString(v0_1.l2))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method519(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure286(v0_1.clone(), ())
            })
        }
        pub fn method521() -> string {
            string("")
        }
        pub fn closure287(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v1: Array<std::string::String> = v0_1.l5.clone();
            if count(v1.clone()) as u64 == 0_u64 {
                let v6: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method521()));
                let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
                let v10: std::string::String = String::from(v8);
                let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
                let v17: Array<leptos::View> =
                    Dice_ui::method123(Dice_ui::method122(new_array(&[
                        leptos::IntoView::into_view(v12),
                    ])));
                let v19: Vec<leptos::View> = v17.to_vec();
                leptos::Fragment::new(v19)
            } else {
                let v22 = Dice_ui::method474();
                let v23: Array<std::string::String> = Dice_ui::method264(v1);
                let v25: Vec<std::string::String> = v23.to_vec();
                let v28: Vec<string> =
                    Dice_ui::method270(v25.iter().map(|x| v22(x.clone())).collect());
                let v39: string =
                    string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh] [width:100vw] [max-width:100vw]\"");
                let v41 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method254(replace(
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
                let v47: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method255(
                    leptos::view! {
                        <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:20vh] [width:100vw] [max-width:100vw]">
                            {v41()}
                        </pre>
                    },
                );
                let v52: Array<leptos::View> =
                    Dice_ui::method123(Dice_ui::method122(new_array(&[
                        leptos::IntoView::into_view(v47),
                    ])));
                let v54: Vec<leptos::View> = v52.to_vec();
                leptos::Fragment::new(v54)
            }
        }
        pub fn method520(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure287(v0_1.clone(), ())
            })
        }
        pub fn closure288(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v5: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(ofBoolean(v0_1.l6))));
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v16: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method522(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure288(v0_1.clone(), ())
            })
        }
        pub fn closure289(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method60(v0_1.l11.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method523(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure289(v0_1.clone(), ())
            })
        }
        pub fn closure290(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method60(v0_1.l4.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method524(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure290(v0_1.clone(), ())
            })
        }
        pub fn closure291(v0_1: LrcPtr<Dice_ui::Heap5>, unitVar: ()) -> leptos::Fragment {
            let v2: std::string::String = Dice_ui::method60(v0_1.l9.clone());
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(
                fable_library_rust::String_::fromString(v2),
            )));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method525(v0_1: LrcPtr<Dice_ui::Heap5>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure291(v0_1.clone(), ())
            })
        }
        pub fn closure275(
            v0_1: LrcPtr<Dice_ui::Heap5>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v7 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method505(v1)));
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
            let v13: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v7()}
                    </td>
                },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v20 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method507(v0_1.clone())));
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
            let v25: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v20()}
                    </td>
                },
            );
            let v27: leptos::View = leptos::IntoView::into_view(v25);
            let v30: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v32 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method508(v0_1.clone())));
            let v34: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v30), string(">{v32()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v37: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v32()}
                    </td>
                },
            );
            let v39: leptos::View = leptos::IntoView::into_view(v37);
            let v42: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v44 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method509(v0_1.clone())));
            let v46: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v42), string(">{v44()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v49: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v44()}
                    </td>
                },
            );
            let v51: leptos::View = leptos::IntoView::into_view(v49);
            let v53 = Dice_ui::method510();
            let v54: Array<(std::string::String, Option<std::string::String>)> =
                Dice_ui::method448(v0_1.l0.clone());
            let v56: Vec<(std::string::String, Option<std::string::String>)> = v54.to_vec();
            let v59: Vec<leptos::Fragment> =
                Dice_ui::method513(v56.iter().map(|x| v53(x.clone())).collect());
            let v61: Array<leptos::Fragment> = fable_library_rust::NativeArray_::array_from(v59);
            let v62 = Dice_ui::method514();
            let v63: Array<leptos::Fragment> = Dice_ui::method516(v61);
            let v65: Vec<leptos::Fragment> = v63.to_vec();
            let v68: Vec<leptos::View> =
                Dice_ui::method160(v65.iter().map(|x| v62(x.clone())).collect());
            let v71: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v68));
            let v73: Vec<leptos::View> = v71.to_vec();
            let v76: leptos::Fragment = Dice_ui::method515(leptos::Fragment::new(v73));
            let v78: leptos::View = leptos::IntoView::into_view(v76);
            let v81: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v83 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method517(v0_1.clone())));
            let v85: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v81), string(">{v83()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v88: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v83()}
                    </td>
                },
            );
            let v90: leptos::View = leptos::IntoView::into_view(v88);
            let v93: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v95 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method518(v0_1.clone())));
            let v97: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v93), string(">{v95()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v100: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v95()}
                    </td>
                },
            );
            let v102: leptos::View = leptos::IntoView::into_view(v100);
            let v105: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v107 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method519(v0_1.clone())));
            let v109: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v105), string(">{v107()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v112: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v107()}
                    </td>
                },
            );
            let v114: leptos::View = leptos::IntoView::into_view(v112);
            let v117: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]\"");
            let v119 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method520(v0_1.clone())));
            let v121: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v117), string(">{v119()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v124: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]">
                        {v119()}
                    </td>
                },
            );
            let v126: leptos::View = leptos::IntoView::into_view(v124);
            let v129: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v131 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method522(v0_1.clone())));
            let v133: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v129), string(">{v131()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v136: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v131()}
                    </td>
                },
            );
            let v138: leptos::View = leptos::IntoView::into_view(v136);
            let v141: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v143 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method523(v0_1.clone())));
            let v145: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v141), string(">{v143()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v148: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v143()}
                    </td>
                },
            );
            let v150: leptos::View = leptos::IntoView::into_view(v148);
            let v153: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v155 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method524(v0_1.clone())));
            let v157: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v153), string(">{v155()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v160: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v155()}
                    </td>
                },
            );
            let v162: leptos::View = leptos::IntoView::into_view(v160);
            let v165: string =
                string(" class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\"");
            let v167 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method525(v0_1)));
            let v169: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<td "), v165), string(">{v167()}</")),
                            string("td"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v172: leptos::HtmlElement<leptos::html::Td> = Dice_ui::method506(
                leptos::view! {
                    <td class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500">
                        {v167()}
                    </td>
                },
            );
            let v177: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v15,
                v27,
                v39,
                v51,
                v78,
                v90,
                v102,
                v114,
                v126,
                v138,
                v150,
                v162,
                leptos::IntoView::into_view(v172),
            ])));
            let v179: Vec<leptos::View> = v177.to_vec();
            leptos::Fragment::new(v179)
        }
        pub fn method504(v0_1: LrcPtr<Dice_ui::Heap5>, v1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure275(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure274(
            unitVar: (),
            _arg: (string, usize, LrcPtr<Dice_ui::Heap5>),
        ) -> leptos::View {
            let v6: string = string(" class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\"");
            let v8 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method504(
                _arg.2.clone(),
                _arg.0.clone(),
            )));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<tr "), v6), string(">{v8()}</")),
                            string("tr"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Tr> = Dice_ui::method499(
                leptos::view! { <tr class="odd:bg-gray-50 dark:odd:bg-gray-800/50">{v8()}</tr> },
            );
            leptos::IntoView::into_view(v14)
        }
        pub fn method503() -> Func1<(string, usize, LrcPtr<Dice_ui::Heap5>), leptos::View> {
            Func1::new(move |arg10_0040: (string, usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure274((), arg10_0040)
            })
        }
        pub fn closure273(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method503();
            let v2: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method384(v0_1);
            let v4: Vec<(string, usize, LrcPtr<Dice_ui::Heap5>)> = v2.to_vec();
            let v7: Vec<leptos::View> =
                Dice_ui::method160(v4.iter().map(|x| v1(x.clone())).collect());
            let v10: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v7));
            let v12: Vec<leptos::View> = v10.to_vec();
            leptos::Fragment::new(v12)
        }
        pub fn method502(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure273(v0_1.clone(), ())
            })
        }
        pub fn method526(
            v0_1: leptos::HtmlElement<leptos::html::Tbody>,
        ) -> leptos::HtmlElement<leptos::html::Tbody> {
            v0_1
        }
        pub fn closure255(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"ltr:text-left rtl:text-right\"");
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method476(v0_1.clone())));
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
            let v12: leptos::HtmlElement<leptos::html::Thead> = Dice_ui::method501(
                leptos::view! { <thead class="ltr:text-left rtl:text-right">{v6()}</thead> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"divide-y divide-gray-200 dark:divide-gray-700\"");
            let v19 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method502(v0_1)));
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
            let v25: leptos::HtmlElement<leptos::html::Tbody> = Dice_ui::method526(
                leptos::view! { <tbody class="divide-y divide-gray-200 dark:divide-gray-700">{v19()}</tbody> },
            );
            let v30: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method475(
            v0_1: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure255(v0_1.clone(), ())
            })
        }
        pub fn method527(
            v0_1: leptos::HtmlElement<leptos::html::Table>,
        ) -> leptos::HtmlElement<leptos::html::Table> {
            v0_1
        }
        pub fn closure296(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method532() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure296((), ()))
        }
        pub fn method533(
            v0_1: leptos::HtmlElement<leptos::svg::Animate>,
        ) -> leptos::HtmlElement<leptos::svg::Animate> {
            v0_1
        }
        pub fn closure295(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0s\" values=\"0.2; 1; .2\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v21: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0s"
                        values="0.2; 1; .2"
                        attributeType="XML"
                        attributeName="opacity"
                    >
                        {v15()}
                    </animate>
                },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            let v36: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0s\" values=\"10; 20; 10\" attributeType=\"XML\" attributeName=\"height\"");
            let v38 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v43: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0s"
                        values="10; 20; 10"
                        attributeType="XML"
                        attributeName="height"
                    >
                        {v38()}
                    </animate>
                },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v58: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0s\" values=\"10; 5; 10\" attributeType=\"XML\" attributeName=\"y\"");
            let v60 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v65: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0s"
                        values="10; 5; 10"
                        attributeType="XML"
                        attributeName="y"
                    >
                        {v60()}
                    </animate>
                },
            );
            let v70: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v23,
                v45,
                leptos::IntoView::into_view(v65),
            ])));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method531() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure295((), ()))
        }
        pub fn closure297(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.15s\" values=\"0.2; 1; .2\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v21: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0.15s"
                        values="0.2; 1; .2"
                        attributeType="XML"
                        attributeName="opacity"
                    >
                        {v15()}
                    </animate>
                },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            let v36: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.15s\" values=\"10; 20; 10\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v38 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v43: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0.15s"
                        values="10; 20; 10"
                        attributeType="XML"
                        attributeName="opacity"
                    >
                        {v38()}
                    </animate>
                },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v58: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.15s\" values=\"10; 5; 10\" attributeType=\"XML\" attributeName=\"y\"");
            let v60 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v65: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0.15s"
                        values="10; 5; 10"
                        attributeType="XML"
                        attributeName="y"
                    >
                        {v60()}
                    </animate>
                },
            );
            let v70: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v23,
                v45,
                leptos::IntoView::into_view(v65),
            ])));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method534() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure297((), ()))
        }
        pub fn closure298(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.3s\" values=\"0.2; 1; .2\" attributeType=\"XML\" attributeName=\"opacity\"");
            let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v21: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0.3s"
                        values="0.2; 1; .2"
                        attributeType="XML"
                        attributeName="opacity"
                    >
                        {v15()}
                    </animate>
                },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            let v36: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.3s\" values=\"10; 20; 10\" attributeType=\"XML\" attributeName=\"height\"");
            let v38 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v43: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0.3s"
                        values="10; 20; 10"
                        attributeType="XML"
                        attributeName="height"
                    >
                        {v38()}
                    </animate>
                },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v58: string =
                string(" repeatCount=\"indefinite\" dur=\"0.6s\" begin=\"0.3s\" values=\"10; 5; 10\" attributeType=\"XML\" attributeName=\"y\"");
            let v60 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method532()));
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
            let v65: leptos::HtmlElement<leptos::svg::Animate> = Dice_ui::method533(
                leptos::view! {
                    <animate
                        repeatCount="indefinite"
                        dur="0.6s"
                        begin="0.3s"
                        values="10; 5; 10"
                        attributeType="XML"
                        attributeName="y"
                    >
                        {v60()}
                    </animate>
                },
            );
            let v70: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v23,
                v45,
                leptos::IntoView::into_view(v65),
            ])));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method535() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure298((), ()))
        }
        pub fn method536(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Rect>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Rect>> {
            v0_1
        }
        pub fn method538(
            v0_1: leptos::HtmlElement<leptos::svg::Rect>,
        ) -> leptos::HtmlElement<leptos::svg::Rect> {
            v0_1
        }
        pub fn closure299(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::svg::Rect>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::svg::Rect> = Dice_ui::method538(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method537() -> Func1<leptos::HtmlElement<leptos::svg::Rect>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::svg::Rect>| Dice_ui::closure299((), v))
        }
        pub fn method539(
            v0_1: Array<leptos::HtmlElement<leptos::svg::Rect>>,
        ) -> Array<leptos::HtmlElement<leptos::svg::Rect>> {
            v0_1
        }
        pub fn closure294(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v13: string =
                string(" opacity=\"0.2\" fill=\"#333\" height=\"10\" width=\"4\" y=\"10\" x=\"0\"");
            let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method531()));
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
            let v20: leptos::HtmlElement<leptos::svg::Rect> = leptos::view! {
                <rect opacity="0.2" fill="#333" height="10" width="4" y="10" x="0">
                    {v15()}
                </rect>
            };
            let v33: string =
                string(" opacity=\"0.2\" fill=\"#333\" height=\"10\" width=\"4\" y=\"10\" x=\"8\"");
            let v35 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method534()));
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
            let v39: leptos::HtmlElement<leptos::svg::Rect> = leptos::view! {
                <rect opacity="0.2" fill="#333" height="10" width="4" y="10" x="8">
                    {v35()}
                </rect>
            };
            let v52: string = string(
                " opacity=\"0.2\" fill=\"#333\" height=\"10\" width=\"4\" y=\"10\" x=\"16\"",
            );
            let v54 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method535()));
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
            let v60: Array<leptos::HtmlElement<leptos::svg::Rect>> = Dice_ui::method536(new_array(
                &[
                    v20,
                    v39,
                    leptos::view! {
                        <rect opacity="0.2" fill="#333" height="10" width="4" y="10" x="16">
                            {v54()}
                        </rect>
                    },
                ],
            ));
            let v61 = Dice_ui::method537();
            let v62: Array<leptos::HtmlElement<leptos::svg::Rect>> = Dice_ui::method539(v60);
            let v64: Vec<leptos::HtmlElement<leptos::svg::Rect>> = v62.to_vec();
            let v67: Vec<leptos::View> =
                Dice_ui::method160(v64.iter().map(|x| v61(x.clone())).collect());
            let v70: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v67));
            let v72: Vec<leptos::View> = v70.to_vec();
            leptos::Fragment::new(v72)
        }
        pub fn method530() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure294((), ()))
        }
        pub fn closure293(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v23: string =
                string(" xml:space=\"preserve\" style=\"enable-background:new 0 0 50 50;\" viewBox=\"0 0 24 30\" height=\"30px\" width=\"24px\" y=\"0px\" x=\"0px\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns=\"http://www.w3.org/2000/svg\" id=\"Layer_1\" version=\"1.1\"");
            let v25 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method530()));
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
            let v31: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(
                leptos::view! {
                    <svg
                        xml:space="preserve"
                        style="enable-background:new 0 0 50 50;"
                        viewBox="0 0 24 30"
                        height="30px"
                        width="24px"
                        y="0px"
                        x="0px"
                        xmlns:xlink="http://www.w3.org/1999/xlink"
                        xmlns="http://www.w3.org/2000/svg"
                        id="Layer_1"
                        version="1.1"
                    >
                        {v25()}
                    </svg>
                },
            );
            let v33: leptos::View = leptos::IntoView::into_view(v31);
            let v37: string =
                Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(string("Loading..."))));
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v41: std::string::String = String::from(v39);
            let v43: leptos::leptos_dom::Text = leptos::html::text(v41);
            let v48: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v33,
                leptos::IntoView::into_view(v43),
            ])));
            let v50: Vec<leptos::View> = v48.to_vec();
            leptos::Fragment::new(v50)
        }
        pub fn method529() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure293((), ()))
        }
        pub fn closure292(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [gap:4px] items-center\"");
            let v5 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method529()));
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="flex flex-1 [gap:4px] items-center">{v5()}</div> },
            );
            let v16: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v11),
            ])));
            let v18: Vec<leptos::View> = v16.to_vec();
            leptos::Fragment::new(v18)
        }
        pub fn method528() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure292((), ()))
        }
        pub fn closure199(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            v2: leptos::ReadSignal<bool>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v3: leptos::ReadSignal<bool> = Dice_ui::method82(v2);
            let v26: leptos::View = if leptos::SignalGet::get(&v3) {
                let v9: string = string(" class=\"px-[12px] py-[10px]\"");
                let v11 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method396(v0_1.clone())));
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
                let v17: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                    leptos::view! { <div class="px-[12px] py-[10px]">{v11()}</div> },
                );
                leptos::IntoView::into_view(v17)
            } else {
                let v23: Array<leptos::View> =
                    Dice_ui::method167(Dice_ui::method166(Dice_ui::method122(new_empty::<
                        leptos::View,
                    >(
                    ))));
                leptos::CollectView::collect_view(v23.to_vec())
            };
            let v27: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            > = Dice_ui::method411(v1);
            let v29: Result<
                Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                std::string::String,
            > = v27();
            let v32: Dice_ui::US50 = match &v29 {
                Err(v29_1_0) => Dice_ui::closure193((), v29_1_0.clone()),
                Ok(v29_0_0) => Dice_ui::closure192((), v29_0_0.clone()),
            };
            let v41: Dice_ui::US47 = match &v32 {
                Dice_ui::US50::US50_1(v32_1_0) => Dice_ui::US47::US47_1(defaultValue(
                    Dice_ui::US48::US48_0,
                    map(
                        Func1::new(move |v_2: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>| {
                            Dice_ui::closure194((), v_2)
                        }),
                        v32_1_0.clone(),
                    ),
                )),
                Dice_ui::US50::US50_0(v32_0_0) => Dice_ui::US47::US47_0(v32_0_0.clone()),
            };
            let v118: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v26,
                match &v41 {
                    Dice_ui::US47::US47_1(v41_1_0) => {
                        let v42: Dice_ui::US48 = v41_1_0.clone();
                        if let Dice_ui::US48::US48_1(v42_1_0) = &v42 {
                            let v43: Array<(string, usize, LrcPtr<Dice_ui::Heap5>)> = match &v42 {
                                Dice_ui::US48::US48_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v45: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                Dice_ui::method64(v0_1.l0.clone());
                            let v49: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method85(
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
                                let v60 = Dice_ui::method153(Dice_ui::method152(
                                    Dice_ui::method416(v43.clone()),
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
                                    Dice_ui::method205(
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
                                    Dice_ui::method153(Dice_ui::method152(Dice_ui::method475(v43)));
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
                                    Dice_ui::method527(
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
                            let v89 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method528()));
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
                            let v95: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                                leptos::view! { <div class="grid place-content-center py-[10vh]">{v89()}</div> },
                            );
                            leptos::IntoView::into_view(v95)
                        }
                    }
                    Dice_ui::US47::US47_0(v41_0_0) => {
                        let v103: string =
                            string(" class=\"flex flex-1 items-center [gap:4px] [padding:5px]\"");
                        let v105 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method412(
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
                        let v111: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                            leptos::view! { <div class="flex flex-1 items-center [gap:4px] [padding:5px]">{v105()}</div> },
                        );
                        leptos::IntoView::into_view(v111)
                    }
                },
            ])));
            let v120: Vec<leptos::View> = v118.to_vec();
            leptos::Fragment::new(v120)
        }
        pub fn method395(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            v2: leptos::ReadSignal<bool>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure199(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method542() -> string {
            string("Transactions")
        }
        pub fn closure301(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method542()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method541() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure301((), ()))
        }
        pub fn closure302(
            v0_1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            > = Dice_ui::method411(v0_1);
            let v3: Result<
                Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                std::string::String,
            > = v1();
            let v6: std::string::String = Dice_ui::method60(format!("{:#?}", &v3));
            let v13: string =
                string(" class=\"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:70vh]\"");
            let v15 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method254(
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
            let v21: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method255(
                leptos::view! {
                    <pre class="[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] [max-height:70vh]">
                        {v15()}
                    </pre>
                },
            );
            let v26: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v21),
            ])));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method543(
            v0_1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure302(v0_1.clone(), ())
            })
        }
        pub fn closure300(
            v0_1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
            unitVar: (),
        ) -> leptos::Fragment {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] \"");
            let v11 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method229(
                Dice_ui::method541(),
                Dice_ui::method543(v0_1),
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
            let v18: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method240(new_array(
                &[
                    leptos::view! {
                        <dl class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[11px] pl-[10px] ">
                            {v11()}
                        </dl>
                    },
                ],
            ));
            let v19 = Dice_ui::method241();
            let v20: Array<leptos::HtmlElement<leptos::html::Dl>> = Dice_ui::method243(v18);
            let v22: Vec<leptos::HtmlElement<leptos::html::Dl>> = v20.to_vec();
            let v25: Vec<leptos::View> =
                Dice_ui::method160(v22.iter().map(|x| v19(x.clone())).collect());
            let v28: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v25));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method540(
            v0_1: leptos::Memo<
                Result<Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>, std::string::String>,
            >,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure300(v0_1.clone(), ())
            })
        }
        pub fn closure303(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method544(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure303(v0_1.clone(), ())
            })
        }
        pub fn closure55(v0_1: leptos::ReadSignal<Dice_ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v1: leptos::ReadSignal<Dice_ui::US20> = Dice_ui::method121(v0_1);
            let v3: Dice_ui::US20 = leptos::SignalGet::get(&v1);
            let v385: Dice_ui::US24 = match &v3 {
                Dice_ui::US20::US20_1(v3_1_0) => {
                    let v6: string = Dice_ui::method0(string("dice.render ()"));
                    leptos::logging::log!("{}", v6);
                    {
                        let v9: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v11: LrcPtr<Dice_ui::Heap2> = v9.unwrap();
                        let v14: Array<leptos::View> =
                            Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
                        let v16: Vec<leptos::View> = v14.to_vec();
                        Dice_ui::US24::US24_1(leptos::Fragment::new(v16))
                    }
                }
                Dice_ui::US20::US20_2 => {
                    let v21: string = Dice_ui::method0(string("lists.render ()"));
                    leptos::logging::log!("{}", v21);
                    {
                        let v24: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v26: LrcPtr<Dice_ui::Heap2> = v24.unwrap();
                        let v29: Array<leptos::View> =
                            Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
                        let v31: Vec<leptos::View> = v29.to_vec();
                        Dice_ui::US24::US24_1(leptos::Fragment::new(v31))
                    }
                }
                Dice_ui::US20::US20_3 => {
                    let v214: string = Dice_ui::method0(string("settings.render ()"));
                    leptos::logging::log!("{}", v214);
                    {
                        let v217: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v219: LrcPtr<Dice_ui::Heap2> = v217.unwrap();
                        let v220 = Dice_ui::method124(v219.clone());
                        let v222: leptos::Memo<
                            Vec<
                                LrcPtr<(
                                    i32,
                                    (
                                        leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                                        leptos::WriteSignal<LrcPtr<(bool, std::string::String)>>,
                                    ),
                                )>,
                            >,
                        > = leptos::create_memo(move |_| v220());
                        let v223: i32 = Dice_ui::method128();
                        let patternInput: (leptos::ReadSignal<i32>, leptos::WriteSignal<i32>) =
                            leptos::create_signal(v223);
                        let v226: leptos::WriteSignal<i32> = patternInput.1.clone();
                        let v227 = Dice_ui::method129(v222.clone(), patternInput.0.clone());
                        let v229: leptos::Memo<
                            Vec<(
                                i32,
                                i32,
                                leptos::ReadSignal<LrcPtr<(bool, std::string::String)>>,
                            )>,
                        > = leptos::create_memo(move |_| v227());
                        let v230 = Dice_ui::method136(v229.clone());
                        let v232: leptos::Memo<i32> = leptos::create_memo(move |_| v230());
                        let v233 = Dice_ui::method139(v219.clone(), v222.clone(), v226.clone());
                        let on_click = v233;
                        {
                            let v235: string = Dice_ui::method149();
                            let v237: &str = fable_library_rust::String_::LrcStr::as_str(&v235);
                            let v239: string = string("r#\"\"#");
                            let v240: &str = r#""#;
                            let v253: string =
                                    string(" class=\" \".to_owned() + v237 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                            let v255 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method150()));
                            let v258: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<svg "), v253),
                                                string(">{v255()}</"),
                                            ),
                                            string("svg"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v260: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                                <svg
                                    class=" ".to_owned() + v237
                                    stroke="currentColor"
                                    stroke-width="1.5"
                                    viewBox="0 0 24 24"
                                    fill="none"
                                    xmlns="http://www.w3.org/2000/svg"
                                >
                                    {v255()}
                                </svg>
                            };
                            let v263 = Dice_ui::method161();
                            let v264: string =
                                    string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]\".to_owned() + v263()}");
                            let v268: string = append(
                                append(
                                    string(" aria-label=\"Add\""),
                                    append(
                                        append(
                                            string(" on:click=move |_| on_click()"),
                                            append(
                                                append(append(string(" "), v264), string("")),
                                                string(""),
                                            ),
                                        ),
                                        string(""),
                                    ),
                                ),
                                string(""),
                            );
                            let v270 =
                                Dice_ui::method153(Dice_ui::method152(Dice_ui::method162(v260)));
                            let v273: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<button "), v268),
                                                string(">{v270()}</"),
                                            ),
                                            string("button"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v276: leptos::HtmlElement<leptos::html::Button> =
                                Dice_ui::method164(
                                    leptos::view! {
                                        <button
                                            aria-label="Add"
                                            on:click=move |_| on_click()
                                            class=move || {
                                                "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]"
                                                    .to_owned() + v263()
                                            }
                                        >
                                            {v270()}
                                        </button>
                                    },
                                );
                            let v278: leptos::View = leptos::IntoView::into_view(v276);
                            let v280: string = Dice_ui::method6(Dice_ui::method165());
                            let v282: &str = fable_library_rust::String_::LrcStr::as_str(&v280);
                            let v284: std::string::String = String::from(v282);
                            let v288: Array<leptos::View> = Dice_ui::method167(Dice_ui::method166(
                                Dice_ui::method122(new_empty::<leptos::View>()),
                            ));
                            let v290: leptos::View =
                                leptos::CollectView::collect_view(v288.to_vec());
                            let v295: string =
                                string(" class=\"flex flex-col [position:relative]\"");
                            let v297 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method207(
                                v278,
                                v284,
                                Dice_ui::method206(Dice_ui::method168(
                                    v219.clone(),
                                    v229,
                                    v232,
                                    v222,
                                    v226,
                                )),
                            )));
                            let v300: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<div "), v295),
                                                string(">{v297()}</"),
                                            ),
                                            string("div"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v303: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                                leptos::view! { <div class="flex flex-col [position:relative]">{v297()}</div> },
                            );
                            let v305: leptos::View = leptos::IntoView::into_view(v303);
                            let v307: string = Dice_ui::method6(Dice_ui::method219());
                            let v309: &str = fable_library_rust::String_::LrcStr::as_str(&v307);
                            let v311: std::string::String = String::from(v309);
                            let v315: Array<leptos::View> = Dice_ui::method167(Dice_ui::method166(
                                Dice_ui::method122(new_empty::<leptos::View>()),
                            ));
                            let v322: string =
                                string(" class=\"flex flex-col [position:relative]\"");
                            let v324 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method244(
                                v311,
                                leptos::CollectView::collect_view(v315.to_vec()),
                                Dice_ui::method206(Dice_ui::method220(v219.clone())),
                            )));
                            let v326: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<div "), v322),
                                                string(">{v324()}</"),
                                            ),
                                            string("div"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v329: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                                leptos::view! { <div class="flex flex-col [position:relative]">{v324()}</div> },
                            );
                            let v331: leptos::View = leptos::IntoView::into_view(v329);
                            let v333: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                Dice_ui::method64(v219.l0.clone());
                            let v337: leptos::RwSignal<bool> = Dice_ui::method83(
                                (leptos::SignalGetUntracked::get_untracked(&v333))
                                    .l2
                                    .clone(),
                            );
                            let v375: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(
                                new_array(&[
                                    v305,
                                    v331,
                                    if leptos::SignalGet::get(&v337) {
                                        let v341: string = Dice_ui::method6(Dice_ui::method246());
                                        let v343: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v341);
                                        let v345: std::string::String = String::from(v343);
                                        let v349: Array<leptos::View> =
                                            Dice_ui::method167(Dice_ui::method166(
                                                Dice_ui::method122(new_empty::<leptos::View>()),
                                            ));
                                        let v356: string =
                                            string(" class=\"flex flex-col [position:relative]\"");
                                        let v358 = Dice_ui::method153(Dice_ui::method152(
                                            Dice_ui::method244(
                                                v345,
                                                leptos::CollectView::collect_view(v349.to_vec()),
                                                Dice_ui::method206(Dice_ui::method247()),
                                            ),
                                        ));
                                        let v360: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<div "), v356),
                                                            string(">{v358()}</"),
                                                        ),
                                                        string("div"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v363: leptos::HtmlElement<leptos::html::Div> =
                                            Dice_ui::method205(
                                                leptos::view! { <div class="flex flex-col [position:relative]">{v358()}</div> },
                                            );
                                        leptos::IntoView::into_view(v363)
                                    } else {
                                        let v369: Array<leptos::View> =
                                            Dice_ui::method167(Dice_ui::method166(
                                                Dice_ui::method122(new_empty::<leptos::View>()),
                                            ));
                                        leptos::CollectView::collect_view(v369.to_vec())
                                    },
                                ]),
                            ));
                            let v377: Vec<leptos::View> = v375.to_vec();
                            Dice_ui::US24::US24_1(leptos::Fragment::new(v377))
                        }
                    }
                }
                Dice_ui::US20::US20_4 => {
                    let v36: string = Dice_ui::method0(string("transactions.render ()"));
                    leptos::logging::log!("{}", v36);
                    {
                        let v39: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v41: LrcPtr<Dice_ui::Heap2> = v39.unwrap();
                        let v42 = Dice_ui::method256(v41.clone());
                        let v44: leptos::Memo<Array<(string, string)>> =
                            leptos::create_memo(move |_| v42());
                        let v45 = Dice_ui::method266(v44.clone());
                        let v47: leptos::Memo<Array<string>> = leptos::create_memo(move |_| v45());
                        let v49: string = Dice_ui::method0(string("state_core.use_request (1)"));
                        leptos::logging::log!("{}", v49);
                        {
                            let v51 = Dice_ui::method271(v47.clone());
                            let v54: leptos::Resource<
                                Array<string>,
                                Result<Array<Option<string>>, std::string::String>,
                            > = leptos::create_local_resource(
                                move || v51(),
                                |x| async move {
                                    Func1::new(move |v: Array<string>| Dice_ui::closure140((), v))(
                                        x,
                                    )
                                    .await
                                },
                            );
                            let v56: string =
                                Dice_ui::method0(string("state_core.use_database (1)"));
                            leptos::logging::log!("{}", v56);
                            {
                                let v58 = Dice_ui::method20();
                                let v61: leptos::Resource<Dice_ui::US2, rexie::Rexie> =
                                    leptos::create_local_resource(
                                        move || v58(),
                                        |x| async move {
                                            Func1::new(move |v_1: Dice_ui::US2| {
                                                Dice_ui::closure7((), v_1)
                                            })(x)
                                            .await
                                        },
                                    );
                                let v62 = Dice_ui::method284(v61.clone());
                                let v64: leptos::Memo<Option<rexie::Rexie>> =
                                    leptos::create_memo(move |_| v62());
                                let v65 = Dice_ui::method285(v47.clone(), v61.clone());
                                let v68: leptos::Resource<
                                    (Option<rexie::Rexie>, Array<string>),
                                    Result<
                                        Vec<Option<LrcPtr<Dice_ui::Heap4>>>,
                                        std::string::String,
                                    >,
                                > = leptos::create_resource(
                                    move || v65(),
                                    |x| async move {
                                        Func1::new(
                                            move |arg10_0040: (
                                                Option<rexie::Rexie>,
                                                Array<string>,
                                            )| {
                                                Dice_ui::closure145((), arg10_0040)
                                            },
                                        )(x)
                                        .await
                                    },
                                );
                                let v69 = Dice_ui::method294(v68.clone());
                                let v71: Func0<Option<Dice_ui::US30>> = Func0::new(move || v69());
                                let v72 = Dice_ui::method300(v47.clone(), v64);
                                let v75 = Dice_ui::method310(
                                    v54.clone(),
                                    leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                        v72(value.clone())
                                    }),
                                );
                                leptos::create_effect(move |_| v75());
                                {
                                    let v77 = Dice_ui::method326(v47, v54, v71);
                                    let v80 =
                                        Dice_ui::method335(v61, v68, Func0::new(move || v77()));
                                    let v83 = Dice_ui::method361(v44, Func0::new(move || v80()));
                                    let v85: leptos::Memo<
                                        Result<
                                            Option<Array<(string, usize, LrcPtr<Dice_ui::Heap5>)>>,
                                            std::string::String,
                                        >,
                                    > = leptos::create_memo(move |_| v83());
                                    let v86: bool = Dice_ui::method75();
                                    let patternInput_1: (
                                        leptos::ReadSignal<bool>,
                                        leptos::WriteSignal<bool>,
                                    ) = leptos::create_signal(v86);
                                    let v88: leptos::ReadSignal<bool> = patternInput_1.0.clone();
                                    let v90 = Dice_ui::method391(patternInput_1.1.clone());
                                    let on_click = v90;
                                    {
                                        let v93: string = Dice_ui::method6(string("h-5 w-5"));
                                        let v95: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v93);
                                        let v97: string = string("r#\"\"#");
                                        let v98: &str = r#""#;
                                        let v111: string =
                                                string(" class=\" \".to_owned() + v95 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                                        let v113 = Dice_ui::method153(Dice_ui::method152(
                                            Dice_ui::method392(),
                                        ));
                                        let v116: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<svg "), v111),
                                                            string(">{v113()}</"),
                                                        ),
                                                        string("svg"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v118: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! {
                                            <svg
                                                class=" ".to_owned() + v95
                                                stroke="currentColor"
                                                stroke-width="1.5"
                                                viewBox="0 0 24 24"
                                                fill="none"
                                                xmlns="http://www.w3.org/2000/svg"
                                            >
                                                {v113()}
                                            </svg>
                                        };
                                        let v121 = Dice_ui::method393(v88.clone());
                                        let v122: string =
                                                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]\".to_owned() + v121()}");
                                        let v126: string = append(
                                            append(
                                                string(" aria-label=\"Settings\""),
                                                append(
                                                    append(
                                                        string(" on:click=move |_| on_click()"),
                                                        append(
                                                            append(
                                                                append(string(" "), v122),
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
                                        let v128 = Dice_ui::method153(Dice_ui::method152(
                                            Dice_ui::method162(v118),
                                        ));
                                        let v131: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<button "), v126),
                                                            string(">{v128()}</"),
                                                        ),
                                                        string("button"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v134: leptos::HtmlElement<leptos::html::Button> =
                                            Dice_ui::method164(
                                                leptos::view! {
                                                    <button
                                                        aria-label="Settings"
                                                        on:click=move |_| on_click()
                                                        class=move || {
                                                            "inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[9px] px-[12px]"
                                                                .to_owned() + v121()
                                                        }
                                                    >
                                                        {v128()}
                                                    </button>
                                                },
                                            );
                                        let v136: leptos::View = leptos::IntoView::into_view(v134);
                                        let v138: string = Dice_ui::method6(Dice_ui::method394());
                                        let v140: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v138);
                                        let v142: std::string::String = String::from(v140);
                                        let v146: Array<leptos::View> =
                                            Dice_ui::method167(Dice_ui::method166(
                                                Dice_ui::method122(new_empty::<leptos::View>()),
                                            ));
                                        let v148: leptos::View =
                                            leptos::CollectView::collect_view(v146.to_vec());
                                        let v153: string =
                                            string(" class=\"flex flex-col [position:relative]\"");
                                        let v155 = Dice_ui::method153(Dice_ui::method152(
                                            Dice_ui::method207(
                                                v136,
                                                v142,
                                                Dice_ui::method206(Dice_ui::method395(
                                                    v41.clone(),
                                                    v85.clone(),
                                                    v88,
                                                )),
                                            ),
                                        ));
                                        let v158: string = append(
                                            append(
                                                string("leptos::view! { "),
                                                append(
                                                    append(
                                                        append(
                                                            append(string("<div "), v153),
                                                            string(">{v155()}</"),
                                                        ),
                                                        string("div"),
                                                    ),
                                                    string(">"),
                                                ),
                                            ),
                                            string(" }"),
                                        );
                                        let v161: leptos::HtmlElement<leptos::html::Div> =
                                            Dice_ui::method205(
                                                leptos::view! { <div class="flex flex-col [position:relative]">{v155()}</div> },
                                            );
                                        let v163: leptos::View = leptos::IntoView::into_view(v161);
                                        let v165: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                            Dice_ui::method64(v41.l0.clone());
                                        let v169: leptos::RwSignal<bool> = Dice_ui::method83(
                                            (leptos::SignalGetUntracked::get_untracked(&v165))
                                                .l2
                                                .clone(),
                                        );
                                        let v207: Array<leptos::View> = Dice_ui::method123(
                                            Dice_ui::method122(new_array(&[
                                                v163,
                                                if leptos::SignalGet::get(&v169) {
                                                    let v173: string =
                                                        Dice_ui::method6(Dice_ui::method246());
                                                    let v175: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v173,
                                                        );
                                                    let v177: std::string::String =
                                                        String::from(v175);
                                                    let v181: Array<leptos::View> =
                                                        Dice_ui::method167(Dice_ui::method166(
                                                            Dice_ui::method122(new_empty::<
                                                                leptos::View,
                                                            >(
                                                            )),
                                                        ));
                                                    let v188:
                                                                                                              string =
                                                                                                          string(" class=\"flex flex-col [position:relative]\"");
                                                    let v190 = Dice_ui::method153(
                                                        Dice_ui::method152(Dice_ui::method244(
                                                            v177,
                                                            leptos::CollectView::collect_view(
                                                                v181.to_vec(),
                                                            ),
                                                            Dice_ui::method206(Dice_ui::method540(
                                                                v85,
                                                            )),
                                                        )),
                                                    );
                                                    let v192: string = append(
                                                        append(
                                                            string("leptos::view! { "),
                                                            append(
                                                                append(
                                                                    append(
                                                                        append(
                                                                            string("<div "),
                                                                            v188,
                                                                        ),
                                                                        string(">{v190()}</"),
                                                                    ),
                                                                    string("div"),
                                                                ),
                                                                string(">"),
                                                            ),
                                                        ),
                                                        string(" }"),
                                                    );
                                                    let v195: leptos::HtmlElement<
                                                        leptos::html::Div,
                                                    > = Dice_ui::method205(
                                                        leptos::view! { <div class="flex flex-col [position:relative]">{v190()}</div> },
                                                    );
                                                    leptos::IntoView::into_view(v195)
                                                } else {
                                                    let v201: Array<leptos::View> =
                                                        Dice_ui::method167(Dice_ui::method166(
                                                            Dice_ui::method122(new_empty::<
                                                                leptos::View,
                                                            >(
                                                            )),
                                                        ));
                                                    leptos::CollectView::collect_view(v201.to_vec())
                                                },
                                            ])),
                                        );
                                        let v209: Vec<leptos::View> = v207.to_vec();
                                        Dice_ui::US24::US24_1(leptos::Fragment::new(v209))
                                    }
                                }
                            }
                        }
                    }
                }
                _ => Dice_ui::US24::US24_0,
            };
            let v411: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                match &v385 {
                    Dice_ui::US24::US24_1(v385_1_0) => {
                        let v390: string =
                            string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                        let v392 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method544(
                            v385_1_0.clone(),
                        )));
                        let v395: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(
                                            append(string("<div "), v390),
                                            string(">{v392()}</"),
                                        ),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v398: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                            leptos::view! { <div class="flex flex-1 flex-col [overflow-y:auto]">{v392()}</div> },
                        );
                        leptos::IntoView::into_view(v398)
                    }
                    _ => {
                        let v404: Array<leptos::View> = Dice_ui::method167(Dice_ui::method166(
                            Dice_ui::method122(new_empty::<leptos::View>()),
                        ));
                        leptos::CollectView::collect_view(v404.to_vec())
                    }
                },
            ])));
            let v413: Vec<leptos::View> = v411.to_vec();
            leptos::Fragment::new(v413)
        }
        pub fn method120(v0_1: leptos::ReadSignal<Dice_ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure55(v0_1.clone(), ())
            })
        }
        pub fn method545(
            v0_1: leptos::HtmlElement<leptos::html::Main>,
        ) -> leptos::HtmlElement<leptos::html::Main> {
            v0_1
        }
        pub fn method549() -> string {
            string("Tab")
        }
        pub fn closure306(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method549()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v13: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v8),
            ])));
            let v15: Vec<leptos::View> = v13.to_vec();
            leptos::Fragment::new(v15)
        }
        pub fn method548() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure306((), ()))
        }
        pub fn closure309(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: Dice_ui::US20,
            unitVar: (),
        ) -> bool {
            let v2: leptos::ReadSignal<Dice_ui::US20> = Dice_ui::method121(v0_1);
            let v4: Dice_ui::US20 = leptos::SignalGet::get(&v2);
            {
                let copyOfStruct: Dice_ui::US20 = v4;
                if let Dice_ui::US20::US20_1(copyOfStruct_1_0) = &copyOfStruct {
                    let copyOfStruct_1: Dice_ui::US20 = v1.clone();
                    if let Dice_ui::US20::US20_1(copyOfStruct_1_1_0) = &copyOfStruct_1 {
                        true
                    } else {
                        false
                    }
                } else {
                    if let Dice_ui::US20::US20_2 = &copyOfStruct {
                        if let Dice_ui::US20::US20_2 = &v1 {
                            true
                        } else {
                            false
                        }
                    } else {
                        if let Dice_ui::US20::US20_3 = &copyOfStruct {
                            if let Dice_ui::US20::US20_3 = &v1 {
                                true
                            } else {
                                false
                            }
                        } else {
                            if let Dice_ui::US20::US20_4 = &copyOfStruct {
                                if let Dice_ui::US20::US20_4 = &v1 {
                                    true
                                } else {
                                    false
                                }
                            } else {
                                if let Dice_ui::US20::US20_0 = &v1 {
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
        pub fn method552(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: Dice_ui::US20,
        ) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure309(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure310(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v14: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v9),
            ])));
            let v16: Vec<leptos::View> = v14.to_vec();
            leptos::Fragment::new(v16)
        }
        pub fn method553(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure310(v0_1.clone(), ())
            })
        }
        pub fn method554(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure308(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: Dice_ui::US20,
        ) -> leptos::View {
            let v12: string = match &v1 {
                Dice_ui::US20::US20_1(v1_1_0) => string("Dice"),
                Dice_ui::US20::US20_2 => string("Lists"),
                Dice_ui::US20::US20_3 => string("Settings"),
                Dice_ui::US20::US20_4 => string("Transactions"),
                _ => string(""),
            };
            let v13 = Dice_ui::method552(v0_1, v1.clone());
            let v17: string = string(" select=v13()");
            let v19 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method553(v12)));
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
                Dice_ui::method554(leptos::view! { <option select=v13()>{v19()}</option> });
            leptos::IntoView::into_view(v25)
        }
        pub fn method551(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
        ) -> Func1<Dice_ui::US20, leptos::View> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::US20| Dice_ui::closure308(v0_1.clone(), v)
            })
        }
        pub fn method555(v0_1: Array<Dice_ui::US20>) -> Array<Dice_ui::US20> {
            v0_1
        }
        pub fn closure307(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: Array<Dice_ui::US20> = Dice_ui::method112(new_array(&[
                Dice_ui::US20::US20_1(Dice_ui::US21::US21_0),
                Dice_ui::US20::US20_2,
                Dice_ui::US20::US20_4,
                Dice_ui::US20::US20_3,
            ]));
            let v8 = Dice_ui::method551(v0_1);
            let v9: Array<Dice_ui::US20> = Dice_ui::method555(v7);
            let v11: Vec<Dice_ui::US20> = v9.to_vec();
            let v14: Vec<leptos::View> =
                Dice_ui::method160(v11.iter().map(|x| v8(x.clone())).collect());
            let v17: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v14));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method550(v0_1: leptos::ReadSignal<Dice_ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure307(v0_1.clone(), ())
            })
        }
        pub fn method556(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure305(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v8 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method548()));
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
            let v14: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method191(
                leptos::view! {
                    <label class="sr-only" for="Tab">
                        {v8()}
                    </label>
                },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v23 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method550(v0_1)));
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
            let v29: leptos::HtmlElement<leptos::html::Select> = Dice_ui::method556(
                leptos::view! {
                    <select class="w-full rounded-md border-gray-200" id="Tab">
                        {v23()}
                    </select>
                },
            );
            let v34: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method547(v0_1: leptos::ReadSignal<Dice_ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure305(v0_1.clone(), ())
            })
        }
        pub fn closure316(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method562() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure316((), ()))
        }
        pub fn closure317(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method563() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure317((), ()))
        }
        pub fn method564(
            v0_1: leptos::HtmlElement<leptos::svg::Circle>,
        ) -> leptos::HtmlElement<leptos::svg::Circle> {
            v0_1
        }
        pub fn closure315(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v15: string =
                string(" stroke-linejoin=\"round\" stroke-linecap=\"round\" rx=\"2\" height=\"18\" width=\"18\" y=\"3\" x=\"3\"");
            let v17 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method562()));
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
            let v23: leptos::HtmlElement<leptos::svg::Rect> = Dice_ui::method538(
                leptos::view! {
                    <rect
                        stroke-linejoin="round"
                        stroke-linecap="round"
                        rx="2"
                        height="18"
                        width="18"
                        y="3"
                        x="3"
                    >
                        {v17()}
                    </rect>
                },
            );
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            let v34: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"7.5\" cx=\"7.5\"");
            let v36 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v42: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1.5" cy="7.5" cx="7.5">
                        {v36()}
                    </circle>
                },
            );
            let v44: leptos::View = leptos::IntoView::into_view(v42);
            let v53: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"7.5\" cx=\"16.5\"");
            let v55 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v60: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1.5" cy="7.5" cx="16.5">
                        {v55()}
                    </circle>
                },
            );
            let v62: leptos::View = leptos::IntoView::into_view(v60);
            let v71: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"12\" cx=\"12\"");
            let v73 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v78: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1.5" cy="12" cx="12">
                        {v73()}
                    </circle>
                },
            );
            let v80: leptos::View = leptos::IntoView::into_view(v78);
            let v89: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"16.5\" cx=\"7.5\"");
            let v91 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v96: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1.5" cy="16.5" cx="7.5">
                        {v91()}
                    </circle>
                },
            );
            let v98: leptos::View = leptos::IntoView::into_view(v96);
            let v107: string = string(" fill=\"currentColor\" r=\"1.5\" cy=\"16.5\" cx=\"16.5\"");
            let v109 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v114: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1.5" cy="16.5" cx="16.5">
                        {v109()}
                    </circle>
                },
            );
            let v119: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn method561() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure315((), ()))
        }
        pub fn closure318(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string =
                string(" d=\"M4.75 6.75h14.5M4.75 12h14.5M4.75 17.25h14.5\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v15: leptos::HtmlElement<leptos::svg::Path> = Dice_ui::method158(
                leptos::view! {
                    <path
                        d="M4.75 6.75h14.5M4.75 12h14.5M4.75 17.25h14.5"
                        stroke-linejoin="round"
                        stroke-linecap="round"
                    >
                        {v9()}
                    </path>
                },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            let v26: string = string(" fill=\"currentColor\" r=\"1\" cy=\"6.75\" cx=\"3\"");
            let v28 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v34: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1" cy="6.75" cx="3">
                        {v28()}
                    </circle>
                },
            );
            let v36: leptos::View = leptos::IntoView::into_view(v34);
            let v45: string = string(" fill=\"currentColor\" r=\"1\" cy=\"12\" cx=\"3\"");
            let v47 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v52: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1" cy="12" cx="3">
                        {v47()}
                    </circle>
                },
            );
            let v54: leptos::View = leptos::IntoView::into_view(v52);
            let v63: string = string(" fill=\"currentColor\" r=\"1\" cy=\"17.25\" cx=\"3\"");
            let v65 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method563()));
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
            let v70: leptos::HtmlElement<leptos::svg::Circle> = Dice_ui::method564(
                leptos::view! {
                    <circle fill="currentColor" r="1" cy="17.25" cx="3">
                        {v65()}
                    </circle>
                },
            );
            let v75: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v17,
                v36,
                v54,
                leptos::IntoView::into_view(v70),
            ])));
            let v77: Vec<leptos::View> = v75.to_vec();
            leptos::Fragment::new(v77)
        }
        pub fn method565() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure318((), ()))
        }
        pub fn closure319(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string =
                string(" d=\"M4 12h16m-7-7l7 7-7 7m-2-14l-7 7 7 7\" stroke-linejoin=\"round\" stroke-linecap=\"round\"");
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method151()));
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
            let v16: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method156(new_array(
                &[
                    leptos::view! {
                        <path
                            d="M4 12h16m-7-7l7 7-7 7m-2-14l-7 7 7 7"
                            stroke-linejoin="round"
                            stroke-linecap="round"
                        >
                            {v9()}
                        </path>
                    },
                ],
            ));
            let v17 = Dice_ui::method157();
            let v18: Array<leptos::HtmlElement<leptos::svg::Path>> = Dice_ui::method159(v16);
            let v20: Vec<leptos::HtmlElement<leptos::svg::Path>> = v18.to_vec();
            let v23: Vec<leptos::View> =
                Dice_ui::method160(v20.iter().map(|x| v17(x.clone())).collect());
            let v26: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v23));
            let v28: Vec<leptos::View> = v26.to_vec();
            leptos::Fragment::new(v28)
        }
        pub fn method566() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure319((), ()))
        }
        pub fn closure320(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: Dice_ui::US20,
            unitVar: (),
        ) -> bool {
            let v2: leptos::ReadSignal<Dice_ui::US20> = Dice_ui::method121(v0_1);
            let v4: Dice_ui::US20 = leptos::SignalGet::get(&v2);
            {
                let copyOfStruct: Dice_ui::US20 = v4;
                if let Dice_ui::US20::US20_1(copyOfStruct_1_0) = &copyOfStruct {
                    let copyOfStruct_1: Dice_ui::US20 = v1.clone();
                    if let Dice_ui::US20::US20_1(copyOfStruct_1_1_0) = &copyOfStruct_1 {
                        true
                    } else {
                        false
                    }
                } else {
                    if let Dice_ui::US20::US20_2 = &copyOfStruct {
                        if let Dice_ui::US20::US20_2 = &v1 {
                            true
                        } else {
                            false
                        }
                    } else {
                        if let Dice_ui::US20::US20_3 = &copyOfStruct {
                            if let Dice_ui::US20::US20_3 = &v1 {
                                true
                            } else {
                                false
                            }
                        } else {
                            if let Dice_ui::US20::US20_4 = &copyOfStruct {
                                if let Dice_ui::US20::US20_4 = &v1 {
                                    true
                                } else {
                                    false
                                }
                            } else {
                                if let Dice_ui::US20::US20_0 = &v1 {
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
        pub fn method567(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: Dice_ui::US20,
        ) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure320(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method568(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure321(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method569(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure321(v0_1.clone(), ())
            })
        }
        pub fn closure322(v0_1: leptos::Fragment, v1: string, unitVar: ()) -> leptos::Fragment {
            let v2: leptos::Fragment = Dice_ui::method515(v0_1);
            let v4: leptos::View = leptos::IntoView::into_view(v2);
            let v7: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method213(v1)));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v18: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v4,
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method570(v0_1: leptos::Fragment, v1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure322(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method571(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure314(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: string,
            v2: Dice_ui::US20,
        ) -> leptos::View {
            let v15: string = append(
                append(
                    append(v1, string("#/")),
                    match &v2 {
                        Dice_ui::US20::US20_1(v2_1_0) => string("dice"),
                        Dice_ui::US20::US20_2 => string("lists"),
                        Dice_ui::US20::US20_3 => string("settings"),
                        Dice_ui::US20::US20_4 => string("transactions"),
                        _ => string(""),
                    },
                ),
                string(""),
            );
            let v175: leptos::Fragment = match &v2 {
                Dice_ui::US20::US20_1(v2_1_0) => {
                    let v17: string = Dice_ui::method6(string("h-5 w-5"));
                    let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                    let v21: string = string("r#\"\"#");
                    let v22: &str = r#""#;
                    let v35: string =
                            string(" class=\" \".to_owned() + v19 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v37 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method561()));
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
                    let v43: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(
                        leptos::view! {
                            <svg
                                class=" ".to_owned() + v19
                                stroke="currentColor"
                                stroke-width="1.5"
                                viewBox="0 0 24 24"
                                fill="none"
                                xmlns="http://www.w3.org/2000/svg"
                            >
                                {v37()}
                            </svg>
                        },
                    );
                    let v48: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            leptos::IntoView::into_view(v43),
                        ])));
                    let v50: Vec<leptos::View> = v48.to_vec();
                    leptos::Fragment::new(v50)
                }
                Dice_ui::US20::US20_2 => {
                    let v53: string = Dice_ui::method6(string("h-5 w-5"));
                    let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
                    let v57: string = string("r#\"\"#");
                    let v58: &str = r#""#;
                    let v73: string =
                            string(" class=\"text-gray-700 \".to_owned() + v55 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" height=\"100%\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v75 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method565()));
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
                    let v81: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(
                        leptos::view! {
                            <svg
                                class="text-gray-700 ".to_owned() + v55
                                stroke="currentColor"
                                stroke-width="1.5"
                                viewBox="0 0 24 24"
                                height="100%"
                                fill="none"
                                xmlns="http://www.w3.org/2000/svg"
                            >
                                {v75()}
                            </svg>
                        },
                    );
                    let v86: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            leptos::IntoView::into_view(v81),
                        ])));
                    let v88: Vec<leptos::View> = v86.to_vec();
                    leptos::Fragment::new(v88)
                }
                Dice_ui::US20::US20_3 => {
                    let v129: string = Dice_ui::method6(string("h-5 w-5"));
                    let v131: &str = fable_library_rust::String_::LrcStr::as_str(&v129);
                    let v133: string = string("r#\"\"#");
                    let v134: &str = r#""#;
                    let v147: string =
                            string(" class=\" \".to_owned() + v131 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v149 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method392()));
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
                    let v155: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(
                        leptos::view! {
                            <svg
                                class=" ".to_owned() + v131
                                stroke="currentColor"
                                stroke-width="1.5"
                                viewBox="0 0 24 24"
                                fill="none"
                                xmlns="http://www.w3.org/2000/svg"
                            >
                                {v149()}
                            </svg>
                        },
                    );
                    let v160: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            leptos::IntoView::into_view(v155),
                        ])));
                    let v162: Vec<leptos::View> = v160.to_vec();
                    leptos::Fragment::new(v162)
                }
                Dice_ui::US20::US20_4 => {
                    let v91: string = Dice_ui::method6(string("h-5 w-5"));
                    let v93: &str = fable_library_rust::String_::LrcStr::as_str(&v91);
                    let v95: string = string("r#\"\"#");
                    let v96: &str = r#""#;
                    let v111: string =
                            string(" class=\"text-gray-700 \".to_owned() + v93 stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\" height=\"100%\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"");
                    let v113 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method566()));
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
                    let v119: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method163(
                        leptos::view! {
                            <svg
                                class="text-gray-700 ".to_owned() + v93
                                stroke="currentColor"
                                stroke-width="1.5"
                                viewBox="0 0 24 24"
                                height="100%"
                                fill="none"
                                xmlns="http://www.w3.org/2000/svg"
                            >
                                {v113()}
                            </svg>
                        },
                    );
                    let v124: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_array(&[
                            leptos::IntoView::into_view(v119),
                        ])));
                    let v126: Vec<leptos::View> = v124.to_vec();
                    leptos::Fragment::new(v126)
                }
                _ => {
                    let v167: Array<leptos::View> =
                        Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
                    let v169: Vec<leptos::View> = v167.to_vec();
                    leptos::Fragment::new(v169)
                }
            };
            let v186: string = match &v2 {
                Dice_ui::US20::US20_1(v2_1_0) => string("Dice"),
                Dice_ui::US20::US20_2 => string("Lists"),
                Dice_ui::US20::US20_3 => string("Settings"),
                Dice_ui::US20::US20_4 => string("Transactions"),
                _ => string(""),
            };
            let v188: string = Dice_ui::method6(Dice_ui::method18(v15));
            let v190: &str = fable_library_rust::String_::LrcStr::as_str(&v188);
            let v192: std::string::String = String::from(v190);
            let v193 = Dice_ui::method567(v0_1, v2.clone());
            let v194 = Dice_ui::method568(v193.clone());
            let v195 = Dice_ui::method569(v193);
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
            let v205 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method570(v175, v186)));
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
            let v211: leptos::HtmlElement<leptos::html::A> = Dice_ui::method571(
                leptos::view! {
                    <a
                        aria-current=move || if v194() { "page" } else { "" }
                        class=move || {
                            "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[15px] pl-[15px] text-sm font-medium "
                                .to_owned() + v195()
                        }
                        href=v192
                    >
                        {v205()}
                    </a>
                },
            );
            leptos::IntoView::into_view(v211)
        }
        pub fn method560(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: string,
        ) -> Func1<Dice_ui::US20, leptos::View> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: Dice_ui::US20| Dice_ui::closure314(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn closure313(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v8: Array<Dice_ui::US20> = Dice_ui::method112(new_array(&[
                Dice_ui::US20::US20_1(Dice_ui::US21::US21_0),
                Dice_ui::US20::US20_2,
                Dice_ui::US20::US20_4,
                Dice_ui::US20::US20_3,
            ]));
            let v9 = Dice_ui::method560(v0_1, v1);
            let v10: Array<Dice_ui::US20> = Dice_ui::method555(v8);
            let v12: Vec<Dice_ui::US20> = v10.to_vec();
            let v15: Vec<leptos::View> =
                Dice_ui::method160(v12.iter().map(|x| v9(x.clone())).collect());
            let v18: Array<leptos::View> =
                Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v15));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method559(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure313(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method572(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure312(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
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
            let v9 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method559(v0_1, v1)));
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
            let v15: leptos::HtmlElement<leptos::html::Nav> = Dice_ui::method572(
                leptos::view! {
                    <nav
                        aria-label="Tabs"
                        class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]"
                    >
                        {v9()}
                    </nav>
                },
            );
            let v20: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v15),
            ])));
            let v22: Vec<leptos::View> = v20.to_vec();
            leptos::Fragment::new(v22)
        }
        pub fn method558(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure312(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure311(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v7 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method558(v0_1, v1)));
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
            let v13: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div class="flex flex-1 border-t border-gray-200">{v7()}</div> },
            );
            let v18: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v13),
            ])));
            let v20: Vec<leptos::View> = v18.to_vec();
            leptos::Fragment::new(v20)
        }
        pub fn method557(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure311(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method573(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure323(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method574() -> Func1<leptos::HtmlElement<leptos::html::Div>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Div>| Dice_ui::closure323((), v))
        }
        pub fn method575(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure304(
            v0_1: leptos::ReadSignal<Dice_ui::US20>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = Dice_ui::method0(string("menu_tabs.render ()"));
            leptos::logging::log!("{}", v2);
            {
                let v5: leptos_router::Location = leptos_router::use_location();
                let v6: leptos_router::Location = Dice_ui::method98(v5.clone());
                let v9: leptos::Memo<std::string::String> = Dice_ui::method99(v6.pathname);
                let v12: std::string::String = Dice_ui::method60(v9());
                let v14: string = fable_library_rust::String_::fromString(v12);
                let v15: leptos_router::Location = Dice_ui::method100(v5);
                let v18: leptos::Memo<std::string::String> = Dice_ui::method99(v15.search);
                let v21: std::string::String = Dice_ui::method60(v18());
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
                let v35 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method547(v0_1.clone())));
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
                let v45 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method557(v0_1, v29)));
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
                let v51: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method573(
                    new_array(&[
                        v40,
                        leptos::view! { <div class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v45()}</div> },
                    ]),
                );
                let v52 = Dice_ui::method574();
                let v53: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method575(v51);
                let v55: Vec<leptos::HtmlElement<leptos::html::Div>> = v53.to_vec();
                let v58: Vec<leptos::View> =
                    Dice_ui::method160(v55.iter().map(|x| v52(x.clone())).collect());
                let v61: Array<leptos::View> =
                    Dice_ui::method123(fable_library_rust::NativeArray_::array_from(v58));
                let v63: Vec<leptos::View> = v61.to_vec();
                leptos::Fragment::new(v63)
            }
        }
        pub fn method546(v0_1: leptos::ReadSignal<Dice_ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure304(v0_1.clone(), ())
            })
        }
        pub fn closure54(v0_1: leptos::ReadSignal<Dice_ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col [overflow:hidden]\"");
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method120(v0_1.clone())));
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
            let v12: leptos::HtmlElement<leptos::html::Main> = Dice_ui::method545(
                leptos::view! { <main class="flex flex-1 flex-col [overflow:hidden]">{v6()}</main> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"flex\"");
            let v19 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method546(v0_1)));
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
                Dice_ui::method205(leptos::view! { <div class="flex">{v19()}</div> });
            let v30: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method119(v0_1: leptos::ReadSignal<Dice_ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure54(v0_1.clone(), ())
            })
        }
        pub fn closure53(v0_1: leptos::ReadSignal<Dice_ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v1: string =
                string("class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\"");
            let v4: string = append(append(append(string(" "), v1), string("")), string(""));
            let v6 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method119(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! {
                    <div class="flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm">
                        {v6()}
                    </div>
                },
            );
            let v17: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method118(v0_1: leptos::ReadSignal<Dice_ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure53(v0_1.clone(), ())
            })
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("content.render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: leptos_router::Location = leptos_router::use_location();
                let v6: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)> =
                    std::sync::Arc::new(leptos_router::use_navigate());
                let v8: leptos_router::Location = leptos_router::use_location();
                let v9: leptos_router::Location = Dice_ui::method98(v8.clone());
                let v12: leptos::Memo<std::string::String> = Dice_ui::method99(v9.pathname);
                let v15: std::string::String = Dice_ui::method60(v12());
                let v17: string = fable_library_rust::String_::fromString(v15);
                let v18: leptos_router::Location = Dice_ui::method100(v8);
                let v21: leptos::Memo<std::string::String> = Dice_ui::method99(v18.search);
                let v24: std::string::String = Dice_ui::method60(v21());
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
                let v37: Dice_ui::US20 = Dice_ui::method101();
                let patternInput: (
                    leptos::ReadSignal<Dice_ui::US20>,
                    leptos::WriteSignal<Dice_ui::US20>,
                ) = leptos::create_signal(v37);
                let v41: bool = Dice_ui::method75();
                let patternInput_1: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                    leptos::create_signal(v41);
                let v45 = Dice_ui::method102(
                    v4.clone(),
                    v6,
                    v32,
                    v36,
                    patternInput_1.1.clone(),
                    patternInput_1.0.clone(),
                );
                leptos::create_effect(move |_| v45());
                {
                    let v47 = Dice_ui::method109(v4, patternInput.1.clone());
                    leptos::create_effect(move |_| v47());
                    {
                        let v52: string =
                            string(" class=\"flex flex-1 max-[100px]:[overflow-x:auto]\"");
                        let v54 = Dice_ui::method153(Dice_ui::method152(Dice_ui::method118(
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
                        let v60: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                            leptos::view! { <div class="flex flex-1 max-[100px]:[overflow-x:auto]">{v54()}</div> },
                        );
                        let v65: Array<leptos::View> =
                            Dice_ui::method123(Dice_ui::method122(new_array(&[
                                leptos::IntoView::into_view(v60),
                            ])));
                        let v67: Vec<leptos::View> = v65.to_vec();
                        leptos::Fragment::new(v67)
                    }
                }
            }
        }
        pub fn method97() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure48((), ()))
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
                        let v21 = Dice_ui::method50(
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
                            let v23 = Dice_ui::method73(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method75();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method76(v13);
                            let v33 = Dice_ui::method81(
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
                                let v36 = Dice_ui::method96(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method153(Dice_ui::method152(Dice_ui::method97()));
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
                                    Dice_ui::method205(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn closure324(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method123(Dice_ui::method122(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method576() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure324((), ()))
        }
        pub fn method577() -> string {
            string("/")
        }
        pub fn closure325(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                        let v21 = Dice_ui::method50(
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
                            let v23 = Dice_ui::method73(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method75();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method76(v13);
                            let v33 = Dice_ui::method81(
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
                                let v36 = Dice_ui::method96(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method153(Dice_ui::method152(Dice_ui::method97()));
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
                                    Dice_ui::method205(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn method578() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure325((), ()))
        }
        pub fn method579() -> string {
            string("/*")
        }
        pub fn closure326(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                        let v21 = Dice_ui::method50(
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
                            let v23 = Dice_ui::method73(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method75();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method76(v13);
                            let v33 = Dice_ui::method81(
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
                                let v36 = Dice_ui::method96(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method153(Dice_ui::method152(Dice_ui::method97()));
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
                                    Dice_ui::method205(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn method580() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure326((), ()))
        }
        pub fn method581() -> string {
            string("*")
        }
        pub fn closure327(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                        let v21 = Dice_ui::method50(
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
                            let v23 = Dice_ui::method73(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method75();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method76(v13);
                            let v33 = Dice_ui::method81(
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
                                let v36 = Dice_ui::method96(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method153(Dice_ui::method152(Dice_ui::method97()));
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
                                    Dice_ui::method205(
                                        leptos::view! {
                                            <div class:dark=move || v36() class="flex flex-1">
                                                {v44()}
                                            </div>
                                        },
                                    );
                                let v55: Array<leptos::View> =
                                    Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn method582() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure327((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method17()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method19();
            let v8 = Dice_ui::method576();
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
            let v22: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method577()));
            let v24: &str = fable_library_rust::String_::LrcStr::as_str(&v22);
            let v26: std::string::String = String::from(v24);
            let v27 = Dice_ui::method578();
            let v28 = Dice_ui::method576();
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
            let v40: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method579()));
            let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
            let v44: std::string::String = String::from(v42);
            let v45 = Dice_ui::method580();
            let v46 = Dice_ui::method576();
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
            let v58: string = Dice_ui::method6(Dice_ui::method18(Dice_ui::method581()));
            let v60: &str = fable_library_rust::String_::LrcStr::as_str(&v58);
            let v62: std::string::String = String::from(v60);
            let v63 = Dice_ui::method582();
            let v64 = Dice_ui::method576();
            let v72: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> })");
            let v76: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn method583(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method583(Dice_ui::method16());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v11: Array<leptos::View> = Dice_ui::method123(Dice_ui::method122(new_array(&[
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
        pub fn method584(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
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
                    let v55 = Dice_ui::method584(Dice_ui::method15());
                    let v61: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v55()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router children=Box::new(move || v55())></leptos_router::Router> },
                    )
                }
            }
        }
        pub fn method3() {
            leptos::mount_to_body(|| Func0::new(move || Dice_ui::closure2((), ()))());
            ()
        }
        pub fn closure328(unitVar: (), unitVar_1: ()) {
            Dice_ui::method3();
        }
        pub fn method585() -> Func0<()> {
            Func0::new(move || Dice_ui::closure328((), ()))
        }
        pub fn method586(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
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
                    let v21 = Dice_ui::method585();
                    let v24: Box<dyn Fn()> = Dice_ui::method586(Box::new(move || v21()));
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
