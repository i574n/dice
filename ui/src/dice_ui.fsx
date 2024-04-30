#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>]
#endif
type Func0<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>]
#endif
type Func0<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>]
#endif
type Fn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>]
#endif
type FnUnit = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>]
#endif
type FnOnce<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>]
#endif
type ActionFn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>]
#endif
type ActionFn2<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>]
#endif
type Impl<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>]
#endif
type StaticRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>]
#endif
type std_cell_RefCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>]
#endif
type std_rc_Rc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>]
#endif
type std_rc_Weak<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::Function")>]
#endif
type js_sys_Function = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Error")>]
#endif
type rexie_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Rexie")>]
#endif
type rexie_Rexie = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Store")>]
#endif
type rexie_Store = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Transaction")>]
#endif
type rexie_Transaction = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("wasm_bindgen::JsValue")>]
#endif
type wasm_bindgen_JsValue = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("wasm_bindgen::closure::Closure<$0>")>]
#endif
type wasm_bindgen_closure_Closure<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Document")>]
#endif
type web_sys_Document = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::HtmlElement")>]
#endif
type web_sys_HtmlElement = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Storage")>]
#endif
type web_sys_Storage = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Window")>]
#endif
type web_sys_Window = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0; $1]")>]
#endif
type Slice'<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>]
#endif
type base64_DecodeError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>]
#endif
type borsh_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>]
#endif
type js_sys_JsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>]
#endif
type serde_json_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>]
#endif
type serde_json_Value = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>]
#endif
type serde_wasm_bindgen_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fmt::Display<$0>")>]
#endif
type std_fmt_Display<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::slice::Windows<$0>")>]
#endif
type std_slice_Windows<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::DateTime<$0>")>]
#endif
type chrono_DateTime<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Local")>]
#endif
type chrono_Local = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::NaiveDateTime")>]
#endif
type chrono_NaiveDateTime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Utc")>]
#endif
type chrono_Utc = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::time::Duration")>]
#endif
type std_time_Duration = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures_lite::stream::StreamExt")>]
#endif
type futures_lite_stream_StreamExt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::Error")>]
#endif
type reqwest_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::RequestBuilder")>]
#endif
type reqwest_RequestBuilder = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::Response")>]
#endif
type reqwest_Response = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::MutexGuard<$0>")>]
#endif
type std_sync_MutexGuard<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Action<$0, $1>")>]
#endif
type leptos_Action<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::For")>]
#endif
type leptos_For = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Show")>]
#endif
type leptos_Show = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Fragment")>]
#endif
type leptos_Fragment = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::HtmlElement<$0>")>]
#endif
type leptos_HtmlElement<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::IntoView")>]
#endif
type leptos_IntoView = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Memo<$0>")>]
#endif
type leptos_Memo<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::ReadSignal<$0>")>]
#endif
type leptos_ReadSignal<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Resource<$0, $1>")>]
#endif
type leptos_Resource<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::RwSignal<$0>")>]
#endif
type leptos_RwSignal<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Signal<$0>")>]
#endif
type leptos_Signal<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::View")>]
#endif
type leptos_View = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::WriteSignal<$0>")>]
#endif
type leptos_WriteSignal<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::ev::Event")>]
#endif
type leptos_ev_Event = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::ev::MouseEvent")>]
#endif
type leptos_ev_MouseEvent = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::A")>]
#endif
type leptos_html_A = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::AnyElement")>]
#endif
type leptos_html_AnyElement = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Button")>]
#endif
type leptos_html_Button = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Details")>]
#endif
type leptos_html_Details = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Dd")>]
#endif
type leptos_html_Dd = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Div")>]
#endif
type leptos_html_Div = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Dl")>]
#endif
type leptos_html_Dl = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Dt")>]
#endif
type leptos_html_Dt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Footer")>]
#endif
type leptos_html_Footer = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Header")>]
#endif
type leptos_html_Header = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Input")>]
#endif
type leptos_html_Input = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Label")>]
#endif
type leptos_html_Label = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Main")>]
#endif
type leptos_html_Main = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Nav")>]
#endif
type leptos_html_Nav = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Option_")>]
#endif
type leptos_html_Option = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Pre")>]
#endif
type leptos_html_Pre = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Select")>]
#endif
type leptos_html_Select = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Span")>]
#endif
type leptos_html_Span = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Summary")>]
#endif
type leptos_html_Summary = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Table")>]
#endif
type leptos_html_Table = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Thead")>]
#endif
type leptos_html_Thead = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Tbody")>]
#endif
type leptos_html_Tbody = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Tr")>]
#endif
type leptos_html_Tr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Th")>]
#endif
type leptos_html_Th = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Td")>]
#endif
type leptos_html_Td = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::leptos_dom::helpers::IntervalHandle")>]
#endif
type leptos_dom_IntervalHandle = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::leptos_dom::Text")>]
#endif
type leptos_dom_Text = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::leptos_dom::Transparent")>]
#endif
type leptos_dom_Transparent = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::svg::Svg")>]
#endif
type leptos_svg_Svg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::svg::Path")>]
#endif
type leptos_svg_Path = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::svg::Circle")>]
#endif
type leptos_svg_Circle = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::svg::Rect")>]
#endif
type leptos_svg_Rect = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos::svg::Animate")>]
#endif
type leptos_svg_Animate = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos_router::Route")>]
#endif
type leptos_router_Route = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos_router::RouteDefinition")>]
#endif
type leptos_router_RouteDefinition = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos_router::Router")>]
#endif
type leptos_router_Router = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos_router::Routes")>]
#endif
type leptos_router_Routes = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos_router::Location")>]
#endif
type leptos_router_Location = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos_router::NavigateOptions")>]
#endif
type leptos_router_NavigateOptions = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("leptos_router::Url")>]
#endif
type leptos_router_Url = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::RpcInput")>] type crate_model_near_rpc_RpcInput = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::ErrorCauseInfo")>] type crate_model_near_rpc_ErrorCauseInfo = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::ErrorCause")>] type crate_model_near_rpc_ErrorCause = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::RpcError")>] type crate_model_near_rpc_RpcError = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::TransferDetail")>] type crate_model_near_rpc_TransferDetail = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::GasProfile")>] type crate_model_near_rpc_GasProfile = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::Metadata")>] type crate_model_near_rpc_Metadata = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::OutcomeDetail")>] type crate_model_near_rpc_OutcomeDetail = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::Proof")>] type crate_model_near_rpc_Proof = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::ReceiptsOutcome")>] type crate_model_near_rpc_ReceiptsOutcome = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::ActionDetail")>] type crate_model_near_rpc_ActionDetail = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::ReceiptDetail")>] type crate_model_near_rpc_ReceiptDetail = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::Receipt")>] type crate_model_near_rpc_Receipt = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::TransactionStatus")>] type crate_model_near_rpc_TransactionStatus = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::rpc::RpcResponse")>] type crate_model_near_rpc_RpcResponse = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::nearblocks::Block")>] type crate_model_near_nearblocks_Block = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::nearblocks::Action")>] type crate_model_near_nearblocks_Action = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::nearblocks::ActionsAgg")>] type crate_model_near_nearblocks_ActionsAgg = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::nearblocks::Outcomes")>] type crate_model_near_nearblocks_Outcomes = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::nearblocks::OutcomesAgg")>] type crate_model_near_nearblocks_OutcomesAgg = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::nearblocks::Txn")>] type crate_model_near_nearblocks_Txn = class end
[<Fable.Core.Erase; Fable.Core.Emit("crate::model::near::nearblocks::Root")>] type crate_model_near_nearblocks_Root = class end
type [<Struct>] US0 =
    | US0_0 of f0_0 : web_sys_HtmlElement
    | US0_1
and [<Struct>] US1 =
    | US1_0
    | US1_1
and Heap0 = {l0 : std_string_String option; l1 : Vec<(bool * std_string_String)>; l2 : int32; l3 : int32; l4 : US1}
and Heap1 = {l0 : leptos_RwSignal<bool>; l1 : leptos_RwSignal<Heap0>; l2 : leptos_RwSignal<bool>; l3 : leptos_RwSignal<std_string_String>}
and  Heap2 = {l0 : leptos_RwSignal<Heap1>; l1 : leptos_RwSignal<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>>}
and [<Struct>] US2 =
    | US2_0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : rexie_Rexie
    | US3_1 of f1_0 : rexie_Error
and Heap3 = {l0 : bool; l1 : Heap0; l2 : bool; l3 : std_string_String}
and [<Struct>] US4 =
    | US4_0 of f0_0 : Heap3
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : rexie_Rexie
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : Heap3 option
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : serde_json_Value
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : Heap3 option option
    | US8_1 of f1_0 : std_string_String
and [<Struct>] US9 =
    | US9_0 of f0_0 : US4
    | US9_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : web_sys_Storage option
    | US10_1 of f1_0 : wasm_bindgen_JsValue
and [<Struct>] US12 =
    | US12_0 of f0_0 : web_sys_Storage
    | US12_1
and [<Struct>] US11 =
    | US11_0 of f0_0 : US12
    | US11_1 of f1_0 : wasm_bindgen_JsValue
and [<Struct>] US13 =
    | US13_0 of f0_0 : std_string_String option
    | US13_1 of f1_0 : wasm_bindgen_JsValue
and [<Struct>] US15 =
    | US15_0 of f0_0 : std_string_String
    | US15_1
and [<Struct>] US14 =
    | US14_0 of f0_0 : US15
    | US14_1 of f1_0 : wasm_bindgen_JsValue
and [<Struct>] US16 =
    | US16_0 of f0_0 : US15
    | US16_1
and [<Struct>] US17 =
    | US17_0
    | US17_1 of f1_0 : rexie_Error
and [<Struct>] US18 =
    | US18_0 of f0_0 : leptos_RwSignal<bool>
    | US18_1
and [<Struct>] US19 =
    | US19_0 of f0_0 : bool
    | US19_1
and [<Struct>] US21 =
    | US21_0
and [<Struct>] US20 =
    | US20_0
    | US20_1 of f1_0 : US21
    | US20_2
    | US20_3
    | US20_4
and [<Struct>] US22 =
    | US22_0 of f0_0 : leptos_router_Url
    | US22_1 of f1_0 : std_string_String
and [<Struct>] US23 =
    | US23_0 of f0_0 : US20
    | US23_1
and Mut0 = {mutable l0 : int32; mutable l1 : US23}
and [<Struct>] US24 =
    | US24_0 of f0_0 : leptos_Fragment
    | US24_1
and [<Struct>] US25 =
    | US25_0
    | US25_1
and Mut1 = {mutable l0 : int32}
and Mut2 = {mutable l0 : int32; mutable l1 : Vec<struct (bool * string * bool * US25 * string)>}
and Mut3 = {mutable l0 : int32; mutable l1 : Vec<string>}
and Heap4 = {l0 : std_string_String}
and [<Struct>] US26 =
    | US26_0 of f0_0 : Heap4 option
    | US26_1 of f1_0 : std_string_String
and [<Struct>] US27 =
    | US27_0 of f0_0 : Heap4
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : Result<(Heap4 option []), std_string_String>
    | US28_1
and [<Struct>] US30 =
    | US30_0 of f0_0 : (US27 [])
    | US30_1 of f1_0 : std_string_String
and [<Struct>] US29 =
    | US29_0 of f0_0 : US30
    | US29_1
and [<Struct>] US31 =
    | US31_0 of f0_0 : (Heap4 option [])
    | US31_1 of f1_0 : std_string_String
and [<Struct>] US34 =
    | US34_0 of f0_0 : string
    | US34_1
and [<Struct>] US33 =
    | US33_0 of f0_0 : US34
    | US33_1 of f1_0 : std_string_String
and [<Struct>] US32 =
    | US32_0 of f0_0 : US33
    | US32_1
and [<Struct>] US35 =
    | US35_0 of f0_0 : US27
    | US35_1
and [<Struct>] US36 =
    | US36_0 of f0_0 : string option
    | US36_1 of f1_0 : std_string_String
and [<Struct>] US37 =
    | US37_0
    | US37_1 of f1_0 : std_string_String
and [<Struct>] US38 =
    | US38_0 of f0_0 : Result<(string option []), std_string_String>
    | US38_1
and [<Struct>] US40 =
    | US40_0 of f0_0 : (string option [])
    | US40_1 of f1_0 : std_string_String
and [<Struct>] US39 =
    | US39_0 of f0_0 : US40
    | US39_1
and [<Struct>] US42 =
    | US42_0 of f0_0 : (US34 [])
    | US42_1 of f1_0 : std_string_String
and [<Struct>] US41 =
    | US41_0 of f0_0 : US42
    | US41_1
and [<Struct>] US43 =
    | US43_0 of f0_0 : US34
    | US43_1
and [<Struct>] US44 =
    | US44_0 of f0_0 : Result<Vec<Heap4 option>, std_string_String>
    | US44_1
and [<Struct>] US45 =
    | US45_0 of f0_0 : Vec<Heap4 option>
    | US45_1 of f1_0 : std_string_String
and Heap5 = {l0 : (struct (std_string_String * std_string_String option) []); l1 : float; l2 : uint32; l3 : std_string_String; l4 : std_string_String; l5 : (std_string_String []); l6 : bool; l7 : float; l8 : std_string_String; l9 : std_string_String; l10 : std_string_String; l11 : std_string_String}
and [<Struct>] US46 =
    | US46_0 of f0_0 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option
    | US46_1 of f1_0 : std_string_String
and [<Struct>] US48 =
    | US48_0 of f0_0 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])
    | US48_1
and [<Struct>] US47 =
    | US47_0 of f0_0 : US48
    | US47_1 of f1_0 : std_string_String
and [<Struct>] US50 =
    | US50_0 of f0_0 : (struct (string * unativeint * Heap5) [])
    | US50_1
and [<Struct>] US49 =
    | US49_0 of f0_0 : US50
    | US49_1 of f1_0 : std_string_String
and [<Struct>] US52 =
    | US52_0 of f0_0 : Vec<struct (string * unativeint * Heap5)>
    | US52_1
and [<Struct>] US51 =
    | US51_0 of f0_0 : US52
    | US51_1 of f1_0 : std_string_String
and [<Struct>] US53 =
    | US53_0 of f0_0 : Vec<struct (string * unativeint * Heap5)> option
    | US53_1 of f1_0 : std_string_String
and [<Struct>] US54 =
    | US54_0 of f0_0 : Vec<struct (string * unativeint * Heap5)>
    | US54_1 of f1_0 : std_string_String
and Mut4 = {mutable l0 : int32; mutable l1 : US54}
and [<Struct>] US55 =
    | US55_0 of f0_0 : (struct (string * unativeint * Heap5) [])
    | US55_1 of f1_0 : std_string_String
and [<Struct>] US56 =
    | US56_0 of f0_0 : (struct (string * unativeint * Heap5) []) option
    | US56_1 of f1_0 : std_string_String
and [<Struct>] US58 =
    | US58_0 of f0_0 : (struct (bool * string * bool * US25 * string) [])
    | US58_1
and [<Struct>] US57 =
    | US57_0 of f0_0 : US58
    | US57_1 of f1_0 : std_string_String
and [<Struct>] US59 =
    | US59_0 of f0_0 : (struct (bool * string * bool * US25 * string) []) option
    | US59_1 of f1_0 : std_string_String
and Heap6 = {l0 : int32}
and [<Struct>] US60 =
    | US60_0 of f0_0 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * f0_1 : std_string_String option * f0_2 : std_string_String * f0_3 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option
    | US60_1
and [<Struct>] US61 =
    | US61_0 of f0_0 : US15
    | US61_1 of f1_0 : std_string_String
and [<Struct>] US62 =
    | US62_0 of f0_0 : US60
    | US62_1 of f1_0 : std_string_String
and [<Struct>] US63 =
    | US63_0 of f0_0 : crate_model_near_rpc_RpcResponse
    | US63_1 of f1_0 : std_string_String
and [<Struct>] US64 =
    | US64_0 of f0_0 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * f0_1 : std_string_String option * f0_2 : std_string_String * f0_3 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option
    | US64_1 of f1_0 : std_string_String
and [<Struct>] US65 =
    | US65_0 of f0_0 : US62
    | US65_1
and [<Struct>] US66 =
    | US66_0 of f0_0 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option
    | US66_1 of f1_0 : std_string_String
and [<Struct>] US67 =
    | US67_0 of f0_0 : struct (std_string_String option * std_string_String option) option * f0_1 : std_string_String * f0_2 : int32 * f0_3 : std_string_String * f0_4 : std_string_String * f0_5 : std_string_String
    | US67_1
and [<Struct>] US68 =
    | US68_0 of f0_0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>
    | US68_1
and [<Struct>] US69 =
    | US69_0 of f0_0 : (struct (int32 * leptos_ReadSignal<std_string_String>) [])
    | US69_1
and [<Struct>] US70 =
    | US70_0 of f0_0 : leptos_Memo<US34>
    | US70_1
and [<Struct>] US71 =
    | US71_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US71_1
and [<Struct>] US72 =
    | US72_0 of f0_0 : string
    | US72_1 of f1_0 : string
and Mut5 = {mutable l0 : int32; mutable l1 : US34}
and [<Struct>] US73 =
    | US73_0 of f0_0 : std_string_String
    | US73_1 of f1_0 : std_string_String
let rec closure1 () (v0 : web_sys_HtmlElement) : US0 =
    US0_0(v0)
and method0 () : (web_sys_HtmlElement -> US0) =
    closure1()
and method1 () : string =
    let v0 : string = ""
    v0
and method2 (v0 : web_sys_HtmlElement) : web_sys_HtmlElement =
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and method5 () : string =
    let v0 : string = "i574n.near"
    v0
and method6 () : string =
    let v0 : string = "luckier.near"
    v0
and closure6 () () : US2 =
    US2_1
and closure7 () (v0 : rexie_Rexie) : US3 =
    US3_0(v0)
and closure8 () (v0 : rexie_Error) : US3 =
    US3_1(v0)
and method12 (v0 : US3) : US3 =
    v0
and method11 () : std_pin_Pin<Box<Dyn<std_future_Future<US3>>>> =
    let v0 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "Box::pin(rexie::Rexie::builder(\"database\").version(1).add_object_store(rexie::ObjectStore::new(\"store\")).build())"
    let v2 : std_pin_Pin<Box<Dyn<std_future_Future<Result<rexie_Rexie, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = "v2.await"
    let v4 : Result<rexie_Rexie, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : (rexie_Rexie -> US3) = closure7()
    let v6 : (rexie_Error -> US3) = closure8()
    let v7 : US3 = match v4 with Ok x -> v5 x | Error x -> v6 x
    let v8 : US3 = method12(v7)
    let v9 : string = "v8 }})"
    Fable.Core.RustInterop.emitRustExpr () v9
    let v10 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v10
    let v11 : string = "__result"
    let v12 : std_pin_Pin<Box<Dyn<std_future_Future<US3>>>> = Fable.Core.RustInterop.emitRustExpr () v11
    v12
and method13 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and method10 () : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> =
    let v0 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "state_core.use_database (2) / database create_local_resource"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "state_core.build_database ()"
    let v5 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : std_pin_Pin<Box<Dyn<std_future_Future<US3>>>> = method11()
    let v8 : string = "v7.await"
    let v9 : US3 = Fable.Core.RustInterop.emitRustExpr () v8
    let v15 : rexie_Rexie =
        match v9 with
        | US3_1(v11) -> (* Error *)
            let v12 : string = $"resultm.get / Result value was Error: {v11}"
            failwith<rexie_Rexie> v12
        | US3_0(v10) -> (* Ok *)
            v10
    let v16 : string = $"%A{v15}"
    let v17 : string = "state_core.use_database (3) / database create_local_resource / result: " + string v16 + ""
    let v18 : int32 = v17.Length
    let v19 : bool = v18 <= 200
    let v22 : string =
        if v19 then
            v17
        else
            let v20 : string = v17.[int 0..int 199]
            let v21 : string = v20 + "..."
            v21
    let v23 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : rexie_Rexie = method13(v15)
    let v26 : string = "v25 }})"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v27
    let v28 : string = "__result"
    let v29 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = Fable.Core.RustInterop.emitRustExpr () v28
    v29
and method14 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> =
    v0
and method9 () : leptos_Resource<US2, rexie_Rexie> =
    let v0 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v1 : (unit -> US2) = closure6()
    Fable.Core.RustInterop.emitRustExpr v1 v0
    let v2 : string = "x"
    let v3 : US2 = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = method10()
    let v5 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = method14(v4)
    let v6 : string = "v5.await"
    let v7 : rexie_Rexie = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "v7 }})"
    Fable.Core.RustInterop.emitRustExpr () v8
    let v9 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v9
    let v10 : string = "__result"
    let v11 : leptos_Resource<US2, rexie_Rexie> = Fable.Core.RustInterop.emitRustExpr () v10
    v11
and closure9 (v0 : leptos_Resource<US2, rexie_Rexie>) () : rexie_Rexie option =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure10 () (v0 : rexie_Rexie) : US5 =
    US5_0(v0)
and method17 () : (rexie_Rexie -> US5) =
    closure10()
and method19 (v0 : string) : string =
    v0
and closure11 () (v0 : string) : std_string_String =
    let v1 : string = method19(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and method20 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and closure12 () (v0 : rexie_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method21 () : (rexie_Error -> std_string_String) =
    closure12()
and method22 () : string =
    let v0 : string = "store"
    v0
and closure13 () (v0 : rexie_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method23 () : (rexie_Error -> std_string_String) =
    closure13()
and method24 () : string =
    let v0 : string = "core-state-heap"
    v0
and closure14 () (v0 : rexie_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method25 () : (rexie_Error -> std_string_String) =
    closure14()
and method26 (v0 : wasm_bindgen_JsValue) : wasm_bindgen_JsValue =
    v0
and closure15 () (v0 : serde_wasm_bindgen_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method27 () : (serde_wasm_bindgen_Error -> std_string_String) =
    closure15()
and closure16 () (v0 : serde_json_Value) : US7 =
    US7_0(v0)
and method28 () : (serde_json_Value -> US7) =
    closure16()
and method29 (v0 : serde_json_Value) : serde_json_Value =
    v0
and closure17 () (v0 : serde_json_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method30 () : (serde_json_Error -> std_string_String) =
    closure17()
and closure18 () (v0 : borsh_io_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method31 () : (borsh_io_Error -> std_string_String) =
    closure18()
and method32 (v0 : Result<Heap3 option option, std_string_String>) : Result<Heap3 option option, std_string_String> =
    v0
and method18 (v0 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "store"
    let v3 : (string []) = [|v2|]
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v7 : (string -> std_string_String) = closure11()
    let v8 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : rexie_Rexie = method20(v0)
    let v10 : string = "v9.transaction(&v8, rexie::TransactionMode::ReadOnly)"
    let v11 : Result<rexie_Transaction, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : (rexie_Error -> std_string_String) = method21()
    let v13 : string = "$0.map_err(|x| $1(x))"
    let v14 : Result<rexie_Transaction, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v11, v12) v13
    let v15 : string = "$0?"
    let v16 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = method22()
    let v18 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "v16.store(v19)"
    let v21 : Result<rexie_Store, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : (rexie_Error -> std_string_String) = method23()
    let v23 : string = "$0.map_err(|x| $1(x))"
    let v24 : Result<rexie_Store, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v21, v22) v23
    let v25 : string = "$0?"
    let v26 : rexie_Store = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = method24()
    let v28 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v29 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : string = "wasm_bindgen::JsValue::from_str(v29)"
    let v31 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = $"Box::pin(rexie::Store::get(&v26, &v31))"
    let v33 : std_pin_Pin<Box<Dyn<std_future_Future<Result<wasm_bindgen_JsValue, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : string = "v33.await"
    let v35 : Result<wasm_bindgen_JsValue, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : (rexie_Error -> std_string_String) = method25()
    let v37 : string = "$0.map_err(|x| $1(x))"
    let v38 : Result<wasm_bindgen_JsValue, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v35, v36) v37
    let v39 : string = "$0?"
    let v40 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : wasm_bindgen_JsValue = method26(v40)
    let v42 : string = "serde_wasm_bindgen::from_value(v41)"
    let v43 : Result<serde_json_Value option, serde_wasm_bindgen_Error> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : (serde_wasm_bindgen_Error -> std_string_String) = method27()
    let v45 : string = "$0.map_err(|x| $1(x))"
    let v46 : Result<serde_json_Value option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45
    let v47 : string = "$0?"
    let v48 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : (serde_json_Value -> US7) = method28()
    let v50 : US7 = US7_1
    let v51 : US7 = v48 |> Option.map v49 |> Option.defaultValue v50 
    let v82 : US6 =
        match v51 with
        | US7_1 -> (* None *)
            US6_1
        | US7_0(v52) -> (* Some *)
            let v53 : serde_json_Value = method29(v52)
            let v54 : string = "serde_json::from_value(v53)"
            let v55 : Result<Vec<uint8>, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v54
            let v56 : (serde_json_Error -> std_string_String) = method30()
            let v57 : string = "$0.map_err(|x| $1(x))"
            let v58 : Result<Vec<uint8>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v55, v56) v57
            let v59 : string = "$0?"
            let v60 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v58 v59
            let v61 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v62 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v60 v61
            let v63 : int32 = v62.Length
            let v64 : string = "state_core.get_data () / data_len: " + string v63 + ""
            let v65 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v66 : bool = Fable.Core.RustInterop.emitRustExpr v64 v65
            let v67 : string = "$0.to_vec()"
            let v68 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v62 v67
            let v69 : string = "v68.as_slice()"
            let v70 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v69
            let v71 : string = "let mut v70 = v70"
            Fable.Core.RustInterop.emitRustExpr () v71
            let v72 : string = "borsh::BorshDeserialize::deserialize(&mut v70)"
            let v73 : Result<Heap3 option, borsh_io_Error> = Fable.Core.RustInterop.emitRustExpr () v72
            let v74 : (borsh_io_Error -> std_string_String) = method31()
            let v75 : string = "$0.map_err(|x| $1(x))"
            let v76 : Result<Heap3 option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v73, v74) v75
            let v77 : string = "$0?"
            let v78 : Heap3 option = Fable.Core.RustInterop.emitRustExpr v76 v77
            US6_0(v78)
    let v87 : Heap3 option option =
        match v82 with
        | US6_1 -> (* None *)
            let v85 : Heap3 option option = None
            v85
        | US6_0(v83) -> (* Some *)
            let v84 : Heap3 option option = Some v83 
            v84
    let v88 : Result<Heap3 option option, std_string_String> = Ok v87
    let v89 : Result<Heap3 option option, std_string_String> = method32(v88)
    let v90 : string = "v89 }})"
    Fable.Core.RustInterop.emitRustExpr () v90
    let v91 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v91
    let v92 : string = "__result"
    let v93 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v92
    v93
and closure19 () (v0 : Heap3 option option) : US8 =
    US8_0(v0)
and closure20 () (v0 : std_string_String) : US8 =
    US8_1(v0)
and closure21 () (v0 : Heap3 option) : US6 =
    US6_0(v0)
and method33 () : (Heap3 option -> US6) =
    closure21()
and closure22 () (v0 : Heap3) : US4 =
    US4_0(v0)
and method34 () : (Heap3 -> US4) =
    closure22()
and method35 (v0 : US4) : US4 =
    v0
and method16 (v0 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = $"%A{v0}"
    let v3 : string = "state_core.use_core_database (2) / core_state_heap create_local_resource / database: " + v2 + ""
    let v4 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : (rexie_Rexie -> US5) = method17()
    let v7 : US5 = US5_1
    let v8 : US5 = v0 |> Option.map v6 |> Option.defaultValue v7 
    let v33 : US6 =
        match v8 with
        | US5_1 -> (* None *)
            US6_1
        | US5_0(v9) -> (* Some *)
            let v10 : string = "core-state-heap"
            let v11 : string = "state_core.get_data () / id: " + v10 + ""
            let v12 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12
            let v14 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> = method18(v9)
            let v15 : string = "v14.await"
            let v16 : Result<Heap3 option option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v15
            let v17 : (Heap3 option option -> US8) = closure19()
            let v18 : (std_string_String -> US8) = closure20()
            let v19 : US8 = match v16 with Ok x -> v17 x | Error x -> v18 x
            match v19 with
            | US8_1(v24) -> (* Error *)
                let v25 : string = "state_core.use_core_database (3) / error: " + string v24 + ""
                let v26 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v27 : bool = Fable.Core.RustInterop.emitRustExpr v25 v26
                US6_1
            | US8_0(v20) -> (* Ok *)
                let v21 : (Heap3 option -> US6) = method33()
                let v22 : US6 = US6_1
                let v23 : US6 = v20 |> Option.map v21 |> Option.defaultValue v22 
                v23
    let v41 : US9 =
        match v33 with
        | US6_1 -> (* None *)
            US9_1
        | US6_0(v34) -> (* Some *)
            let v35 : (Heap3 -> US4) = method34()
            let v36 : US4 = US4_1
            let v37 : US4 = v34 |> Option.map v35 |> Option.defaultValue v36 
            US9_0(v37)
    let v48 : US4 =
        match v41 with
        | US9_0(v42) -> (* Some *)
            match v42 with
            | US4_0(v43) -> (* Some *)
                US4_0(v43)
            | _ ->
                US4_1
        | _ ->
            US4_1
    let v49 : US4 = method35(v48)
    let v50 : string = "v49 }})"
    Fable.Core.RustInterop.emitRustExpr () v50
    let v51 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v51
    let v52 : string = "__result"
    let v53 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = Fable.Core.RustInterop.emitRustExpr () v52
    v53
and method36 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> =
    v0
and method15 (v0 : leptos_Resource<US2, rexie_Rexie>) : leptos_Resource<rexie_Rexie option, US4> =
    let v1 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v2 : (unit -> rexie_Rexie option) = closure9(v0)
    Fable.Core.RustInterop.emitRustExpr v2 v1
    let v3 : string = "x"
    let v4 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = method16(v4)
    let v6 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = method36(v5)
    let v7 : string = "v6.await"
    let v8 : US4 = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = "v8 }})"
    Fable.Core.RustInterop.emitRustExpr () v9
    let v10 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v10
    let v11 : string = "__result"
    let v12 : leptos_Resource<rexie_Rexie option, US4> = Fable.Core.RustInterop.emitRustExpr () v11
    v12
and method37 () : web_sys_Window =
    let v0 : string = "leptos::leptos_dom::window()"
    let v1 : web_sys_Window = Fable.Core.RustInterop.emitRustExpr () v0
    v1
and method38 (v0 : web_sys_Window) : Result<web_sys_Storage option, wasm_bindgen_JsValue> =
    let v1 : string = "$0.local_storage()"
    let v2 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure24 () (v0 : web_sys_Storage option) : US10 =
    US10_0(v0)
and closure25 () (v0 : wasm_bindgen_JsValue) : US10 =
    US10_1(v0)
and closure26 () (v0 : web_sys_Storage) : US12 =
    US12_0(v0)
and method39 () : (web_sys_Storage -> US12) =
    closure26()
and closure27 () (v0 : US4) : US9 =
    US9_0(v0)
and method40 () : (US4 -> US9) =
    closure27()
and method41 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and method42 () : string =
    let v0 : string = "core-state-heap"
    v0
and closure28 () (v0 : std_string_String option) : US13 =
    US13_0(v0)
and closure29 () (v0 : wasm_bindgen_JsValue) : US13 =
    US13_1(v0)
and method43 (v0 : std_string_String option) : std_string_String option =
    v0
and closure30 () (v0 : std_string_String) : US15 =
    US15_0(v0)
and method44 () : (std_string_String -> US15) =
    closure30()
and method45 (v0 : string) : string =
    v0
and closure32 () (v0 : serde_json_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method46 () : (serde_json_Error -> std_string_String) =
    closure32()
and closure31 () (v0 : std_string_String) : US4 =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = method45(v2)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "serde_json::from_str(&v5)"
    let v7 : Result<Heap3, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : (serde_json_Error -> std_string_String) = method46()
    let v9 : string = "$0.map_err(|x| $1(x))"
    let v10 : Result<Heap3, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7, v8) v9
    let v11 : string = "v10.ok()"
    let v12 : Heap3 option = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : (Heap3 -> US4) = method34()
    let v14 : US4 = US4_1
    let v15 : US4 = v12 |> Option.map v13 |> Option.defaultValue v14 
    v15
and closure34 (v0 : Heap3) (v1 : bool) : bool =
    let v2 : string = "state_core.use_core_database (7) / effect core_state_heap / dark_mode signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : bool = v0.l0
    v5
and closure35 (v0 : Heap3) (v1 : bool) : bool =
    let v2 : string = "state_core.use_core_database (8) / effect core_state_heap / debug signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : bool = v0.l2
    v5
and closure36 (v0 : Heap3) (v1 : std_string_String) : std_string_String =
    let v2 : string = "state_core.use_core_database (9) / effect core_state_heap / url_hash signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : std_string_String = v0.l3
    v5
and closure37 (v0 : Heap3) (v1 : Heap0) : Heap0 =
    let v2 : string = "state_core.use_core_database (10) / effect core_state_heap / data signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : Heap0 = v0.l1
    v5
and closure33 (v0 : Heap2, v1 : Heap3) () : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<bool> = v4.l0
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure34(v1)
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v10 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v9
    let v11 : leptos_RwSignal<bool> = v10.l2
    let v12 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v13 : (bool -> bool) = closure35(v1)
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v12
    let v15 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v16 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v15
    let v17 : leptos_RwSignal<std_string_String> = v16.l3
    let v18 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v19 : (std_string_String -> std_string_String) = closure36(v1)
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v22 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v21
    let v23 : leptos_RwSignal<Heap0> = v22.l1
    let v24 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v25 : (Heap0 -> Heap0) = closure37(v1)
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr struct (v23, v25) v24
    ()
and closure23 (v0 : Heap2, v1 : leptos_Resource<rexie_Rexie option, US4>) () : unit =
    let v2 : string = "state_core.use_core_database (4) / effect core_state_heap / ##1"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : web_sys_Window = method37()
    let v6 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method38(v5)
    let v7 : (web_sys_Storage option -> US10) = closure24()
    let v8 : (wasm_bindgen_JsValue -> US10) = closure25()
    let v9 : US10 = match v6 with Ok x -> v7 x | Error x -> v8 x
    let v18 : US11 =
        match v9 with
        | US10_1(v15) -> (* Error *)
            US11_1(v15)
        | US10_0(v10) -> (* Ok *)
            let v11 : (web_sys_Storage -> US12) = method39()
            let v12 : US12 = US12_1
            let v13 : US12 = v10 |> Option.map v11 |> Option.defaultValue v12 
            US11_0(v13)
    match v18 with
    | US11_0(v19) -> (* Ok *)
        match v19 with
        | US12_0(v20) -> (* Some *)
            let v21 : string = $"leptos::SignalGet::get(&$0)"
            let v22 : US4 option = Fable.Core.RustInterop.emitRustExpr v1 v21
            let v23 : (US4 -> US9) = method40()
            let v24 : US9 = US9_1
            let v25 : US9 = v22 |> Option.map v23 |> Option.defaultValue v24 
            let v26 : string = $"%A{v25}"
            let v27 : string = "state_core.use_core_database (5) / effect core_state_heap / ##2 / core_state_heap: " + v26 + ""
            let v28 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v29 : bool = Fable.Core.RustInterop.emitRustExpr v27 v28
            let v136 : US4 =
                match v25 with
                | US9_0(v30) -> (* Some *)
                    match v30 with
                    | US4_0(v31) -> (* Some *)
                        US4_0(v31)
                    | _ ->
                        let v33 : web_sys_Storage = method41(v20)
                        let v34 : string = method42()
                        let v35 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v34 v35
                        let v37 : string = $"web_sys::Storage::get_item(&v33, v36)"
                        let v38 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v37
                        let v39 : (std_string_String option -> US13) = closure28()
                        let v40 : (wasm_bindgen_JsValue -> US13) = closure29()
                        let v41 : US13 = match v38 with Ok x -> v39 x | Error x -> v40 x
                        let v53 : US14 =
                            match v41 with
                            | US13_1(v50) -> (* Error *)
                                US14_1(v50)
                            | US13_0(v42) -> (* Ok *)
                                let v43 : std_string_String option = method43(v42)
                                let v44 : string = "serde_json::from_value(v43.into()).unwrap()"
                                let v45 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v44
                                let v46 : (std_string_String -> US15) = method44()
                                let v47 : US15 = US15_1
                                let v48 : US15 = v45 |> Option.map v46 |> Option.defaultValue v47 
                                US14_0(v48)
                        let v59 : US16 =
                            match v53 with
                            | US14_1(v56) -> (* Error *)
                                US16_1
                            | US14_0(v54) -> (* Ok *)
                                US16_0(v54)
                        let v66 : US15 =
                            match v59 with
                            | US16_0(v60) -> (* Some *)
                                match v60 with
                                | US15_0(v61) -> (* Some *)
                                    US15_0(v61)
                                | _ ->
                                    US15_1
                            | _ ->
                                US15_1
                        let v71 : std_string_String option =
                            match v66 with
                            | US15_1 -> (* None *)
                                let v69 : std_string_String option = None
                                v69
                            | US15_0(v67) -> (* Some *)
                                let v68 : std_string_String option = Some v67 
                                v68
                        let v72 : (std_string_String -> US4) = closure31()
                        let v73 : US4 option = v71 |> Option.map v72 
                        let v74 : (US4 -> US9) = method40()
                        let v75 : US9 = US9_1
                        let v76 : US9 = v73 |> Option.map v74 |> Option.defaultValue v75 
                        match v76 with
                        | US9_0(v77) -> (* Some *)
                            match v77 with
                            | US4_0(v78) -> (* Some *)
                                US4_0(v78)
                            | _ ->
                                US4_1
                        | _ ->
                            US4_1
                | _ ->
                    let v85 : web_sys_Storage = method41(v20)
                    let v86 : string = method42()
                    let v87 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v86 v87
                    let v89 : string = $"web_sys::Storage::get_item(&v85, v88)"
                    let v90 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v89
                    let v91 : (std_string_String option -> US13) = closure28()
                    let v92 : (wasm_bindgen_JsValue -> US13) = closure29()
                    let v93 : US13 = match v90 with Ok x -> v91 x | Error x -> v92 x
                    let v105 : US14 =
                        match v93 with
                        | US13_1(v102) -> (* Error *)
                            US14_1(v102)
                        | US13_0(v94) -> (* Ok *)
                            let v95 : std_string_String option = method43(v94)
                            let v96 : string = "serde_json::from_value(v95.into()).unwrap()"
                            let v97 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v96
                            let v98 : (std_string_String -> US15) = method44()
                            let v99 : US15 = US15_1
                            let v100 : US15 = v97 |> Option.map v98 |> Option.defaultValue v99 
                            US14_0(v100)
                    let v111 : US16 =
                        match v105 with
                        | US14_1(v108) -> (* Error *)
                            US16_1
                        | US14_0(v106) -> (* Ok *)
                            US16_0(v106)
                    let v118 : US15 =
                        match v111 with
                        | US16_0(v112) -> (* Some *)
                            match v112 with
                            | US15_0(v113) -> (* Some *)
                                US15_0(v113)
                            | _ ->
                                US15_1
                        | _ ->
                            US15_1
                    let v123 : std_string_String option =
                        match v118 with
                        | US15_1 -> (* None *)
                            let v121 : std_string_String option = None
                            v121
                        | US15_0(v119) -> (* Some *)
                            let v120 : std_string_String option = Some v119 
                            v120
                    let v124 : (std_string_String -> US4) = closure31()
                    let v125 : US4 option = v123 |> Option.map v124 
                    let v126 : (US4 -> US9) = method40()
                    let v127 : US9 = US9_1
                    let v128 : US9 = v125 |> Option.map v126 |> Option.defaultValue v127 
                    match v128 with
                    | US9_0(v129) -> (* Some *)
                        match v129 with
                        | US4_0(v130) -> (* Some *)
                            US4_0(v130)
                        | _ ->
                            US4_1
                    | _ ->
                        US4_1
            let v137 : string = $"%A{v136}"
            let v138 : string = "state_core.use_core_database (6) / effect core_state_heap / ##3 / core_state_heap: " + v137 + ""
            let v139 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v140 : bool = Fable.Core.RustInterop.emitRustExpr v138 v139
            match v136 with
            | US4_0(v141) -> (* Some *)
                let v142 : string = "true; leptos::batch(move || $0());"
                let v143 : (unit -> unit) = closure33(v0, v141)
                let v144 : bool = Fable.Core.RustInterop.emitRustExpr v143 v142
                ()
            | _ ->
                ()
        | _ ->
            ()
    | _ ->
        ()
and closure38 (v0 : Heap2) () : std_collections_HashMap<std_string_String, leptos_RwSignal<bool>> =
    let v1 : string = "state_core.use_core_database (11) / loading create_memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>> = v0.l1
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : std_collections_HashMap<std_string_String, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method49 () : string =
    let v0 : string = "core-state-heap"
    v0
and method50 (v0 : Result<unit, rexie_Error>) : Result<unit, rexie_Error> =
    v0
and method48 (v0 : Heap3, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = "$0.transaction(&[\"store\"], rexie::TransactionMode::ReadWrite)?"
    let v4 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v1 v3
    let v5 : string = "v4.store(\"store\")?"
    let v6 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : string = "true; let mut data = Vec::new()"
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = "true; borsh::BorshSerialize::serialize(&$0, &mut data).unwrap()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v0 v9
    let v11 : string = "data"
    let v12 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : string = "serde_wasm_bindgen::to_value(&v12).unwrap()"
    let v14 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = method49()
    let v16 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "true; v6.put(&v14, Some(&v17.into())).await?"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "true; v4.done().await?"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : Result<unit, rexie_Error> = Ok ()
    let v23 : Result<unit, rexie_Error> = method50(v22)
    let v24 : string = "v23 }})"
    Fable.Core.RustInterop.emitRustExpr () v24
    let v25 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v25
    let v26 : string = "__result"
    let v27 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v26
    v27
and closure40 () () : US17 =
    US17_0
and closure41 () (v0 : rexie_Error) : US17 =
    US17_1(v0)
and method51 () : unit =
    ()
and method47 (v0 : Heap3, v1 : string, v2 : US5) : std_pin_Pin<Box<Dyn<std_future_Future<unit>>>> =
    let v3 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    match v2 with
    | US5_1 -> (* None *)
        let v21 : string = "state_core.use_core_database (13) / set_core_state_heap_action / database=None"
        let v22 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v23 : bool = Fable.Core.RustInterop.emitRustExpr v21 v22
        ()
    | US5_0(v4) -> (* Some *)
        let v5 : string = "state_core.use_core_database (12) / set_core_state_heap_action / value: " + string v1 + ""
        let v6 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
        let v8 : string = $"%A{v0}"
        let v9 : int64 = System.Convert.ToInt64 v8.Length
        let v10 : string = "state_core.set_data () / data_len: " + string v9 + ""
        let v11 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11
        let v13 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = method48(v0, v4)
        let v14 : string = "v13.await"
        let v15 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v14
        let v16 : (unit -> US17) = closure40()
        let v17 : (rexie_Error -> US17) = closure41()
        let v18 : US17 = match v15 with Ok () -> v16 () | Error x -> v17 x
        match v18 with
        | US17_1(v19) -> (* Error *)
            let v20 : string = $"resultm.get / Result value was Error: {v19}"
            failwith<unit> v20
        | US17_0 -> (* Ok *)
            ()
    method51()
    let v24 : string = "() })"
    Fable.Core.RustInterop.emitRustExpr () v24
    let v25 : string = "__result"
    let v26 : std_pin_Pin<Box<Dyn<std_future_Future<unit>>>> = Fable.Core.RustInterop.emitRustExpr () v25
    v26
and closure39 (v0 : leptos_Resource<US2, rexie_Rexie>) (v1 : Heap3) : std_pin_Pin<Box<Dyn<std_future_Future<unit>>>> =
    let v2 : string = $"%A{v1}"
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : (rexie_Rexie -> US5) = method17()
    let v6 : US5 = US5_1
    let v7 : US5 = v4 |> Option.map v5 |> Option.defaultValue v6 
    method47(v1, v2, v7)
and method52 () : string =
    let v0 : string = "dark_mode_key"
    v0
and method53 (v0 : std_string_String) : std_string_String =
    v0
and closure43 () (v0 : leptos_RwSignal<bool>) : US18 =
    US18_0(v0)
and method54 () : (leptos_RwSignal<bool> -> US18) =
    closure43()
and closure44 () (v0 : bool) : bool =
    let v1 : string = "state_core.use_core_database (17) / effect new_core_state_heap / set_loaded |> signal_update true"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    true
and method55 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and method56 () : string =
    let v0 : string = "core-state-heap"
    v0
and method57 (v0 : Heap3) : Heap3 =
    v0
and method58 (v0 : std_string_String) : std_string_String =
    v0
and closure42 (v0 : Heap2, v1 : leptos_Memo<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>>, v2 : leptos_WriteSignal<bool>, v3 : leptos_ReadSignal<bool>, v4 : leptos_Action<Heap3, unit>) () : unit =
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v3 v5
    let v7 : string = "state_core.use_core_database (14) / effect new_core_state_heap / ##1 / loaded: " + string v6 + ""
    let v8 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : leptos_RwSignal<Heap1> = v0.l0
    let v11 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v12 : Heap1 = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : leptos_RwSignal<bool> = v12.l0
    let v14 : string = $"leptos::SignalGet::get(&$0)"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v17 : Heap1 = Fable.Core.RustInterop.emitRustExpr v10 v16
    let v18 : leptos_RwSignal<bool> = v17.l2
    let v19 : string = $"leptos::SignalGet::get(&$0)"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v22 : Heap1 = Fable.Core.RustInterop.emitRustExpr v10 v21
    let v23 : leptos_RwSignal<std_string_String> = v22.l3
    let v24 : string = $"leptos::SignalGet::get(&$0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v27 : Heap1 = Fable.Core.RustInterop.emitRustExpr v10 v26
    let v28 : leptos_RwSignal<Heap0> = v27.l1
    let v29 : string = $"leptos::SignalGet::get(&$0)"
    let v30 : Heap0 = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : Heap3 = {l0 = v15; l1 = v30; l2 = v20; l3 = v25} : Heap3
    let v32 : string = $"%A{v31}"
    let v33 : string = "state_core.use_core_database (15) / effect new_core_state_heap / ##2 / new_core_state_heap: " + string v32 + ""
    let v34 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : string = $"$0()"
    let v37 : std_collections_HashMap<std_string_String, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr v1 v36
    let v38 : string = method52()
    let v39 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v40 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : std_string_String = method53(v42)
    let v44 : string = "std::collections::HashMap::get(&v37, &v43).map(|x| x).cloned()"
    let v45 : leptos_RwSignal<bool> option = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : (leptos_RwSignal<bool> -> US18) = method54()
    let v47 : US18 = US18_1
    let v48 : US18 = v45 |> Option.map v46 |> Option.defaultValue v47 
    let v55 : US19 =
        match v48 with
        | US18_1 -> (* None *)
            US19_1
        | US18_0(v49) -> (* Some *)
            let v50 : string = $"leptos::SignalGet::get(&$0)"
            let v51 : bool = Fable.Core.RustInterop.emitRustExpr v49 v50
            US19_0(v51)
    let v58 : bool =
        match v55 with
        | US19_1 -> (* None *)
            false
        | US19_0(v56) -> (* Some *)
            v56
    let v59 : string = "state_core.use_core_database (16) / effect new_core_state_heap / ##3 / dark_mode_loading: " + string v58 + ""
    let v60 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v61 : bool = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : bool = v58 = false
    if v62 then
        let v63 : bool = v6 = false
        if v63 then
            let v64 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
            let v65 : (bool -> bool) = closure44()
            let v66 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v65) v64
            ()
        else
            let v67 : string = "state_core.use_core_database (18) / effect new_core_state_heap / ##4"
            let v68 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v69 : bool = Fable.Core.RustInterop.emitRustExpr v67 v68
            let v70 : web_sys_Window = method37()
            let v71 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method38(v70)
            let v72 : (web_sys_Storage option -> US10) = closure24()
            let v73 : (wasm_bindgen_JsValue -> US10) = closure25()
            let v74 : US10 = match v71 with Ok x -> v72 x | Error x -> v73 x
            let v83 : US11 =
                match v74 with
                | US10_1(v80) -> (* Error *)
                    US11_1(v80)
                | US10_0(v75) -> (* Ok *)
                    let v76 : (web_sys_Storage -> US12) = method39()
                    let v77 : US12 = US12_1
                    let v78 : US12 = v75 |> Option.map v76 |> Option.defaultValue v77 
                    US11_0(v78)
            match v83 with
            | US11_0(v84) -> (* Ok *)
                match v84 with
                | US12_0(v85) -> (* Some *)
                    let v86 : string = "true; leptos::Action::dispatch(&$0, $1.clone())"
                    let v87 : bool = Fable.Core.RustInterop.emitRustExpr struct (v4, v31) v86
                    let v88 : web_sys_Storage = method55(v85)
                    let v89 : string = method56()
                    let v90 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v89 v90
                    let v92 : Heap3 = method57(v31)
                    let v93 : string = "serde_json::json!(v92).to_string()"
                    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v93
                    let v95 : std_string_String = method58(v94)
                    let v96 : string = "v95.as_str()"
                    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96
                    let v98 : string = $"web_sys::Storage::set(&v88, v91, v97).unwrap()"
                    Fable.Core.RustInterop.emitRustExpr () v98
                    ()
                | _ ->
                    ()
            | _ ->
                ()
and closure45 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<bool> = v3.l0
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method59 (v0 : Heap2) : (unit -> bool) =
    closure45(v0)
and closure47 (v0 : leptos_router_Location) () : string =
    let v1 : string = "$0.pathname"
    let v2 : leptos_Memo<std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = $"$0()"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "fable_library_rust::String_::fromString($0)"
    let v6 : string = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0.search"
    let v8 : leptos_Memo<std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v7
    let v9 : string = $"$0()"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "fable_library_rust::String_::fromString($0)"
    let v12 : string = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v14 : bool = v12 = ""
    let v17 : string =
        if v14 then
            let v15 : string = ""
            v15
        else
            let v16 : string = $"?{v12}"
            v16
    let v18 : string = v6 + v17
    v18
and method61 (v0 : std_string_String) : std_string_String =
    v0
and closure48 (v0 : leptos_router_Location, v1 : std_sync_Arc<Dyn<ActionFn2<Ref<Str>, leptos_router_NavigateOptions>>>, v2 : leptos_Memo<string>, v3 : Heap2, v4 : leptos_WriteSignal<bool>, v5 : leptos_ReadSignal<bool>) () : unit =
    let v6 : string = $"leptos::SignalGet::get(&$0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "$0.hash"
    let v9 : leptos_Memo<std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v8
    let v10 : string = $"$0()"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = $"$0()"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v2 v12
    let v14 : string = $"{v13}{v11}"
    let v15 : string = "content.render () / effect 1 / new_url_hash: " + v14 + " / loaded: " + string v7 + ""
    let v16 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : bool = v7 = false
    if v18 then
        let v19 : std_string_String = method61(v11)
        let v20 : string = "v19 == \"\""
        let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20
        if v21 then
            let v22 : leptos_RwSignal<Heap1> = v3.l0
            let v23 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v24 : Heap1 = Fable.Core.RustInterop.emitRustExpr v22 v23
            let v25 : leptos_RwSignal<std_string_String> = v24.l3
            let v26 : string = $"leptos::SignalGet::get(&$0)"
            let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26
            let v28 : string = "fable_library_rust::String_::fromString($0)"
            let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
            let v30 : string = "content.render () / effect 1 / url_hash: " + v29 + ""
            let v31 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v32 : bool = Fable.Core.RustInterop.emitRustExpr v30 v31
            let v33 : string = "#"
            let v34 : bool = v29.Contains v33
            if v34 then
                let v35 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v29 v35
                let v37 : string = "$0(v36, Default::default())"
                Fable.Core.RustInterop.emitRustExpr v1 v37
                ()
        let v38 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v39 : bool = Fable.Core.RustInterop.emitRustExpr struct (v4, true) v38
        ()
    else
        let v40 : leptos_RwSignal<Heap1> = v3.l0
        let v41 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
        let v42 : Heap1 = Fable.Core.RustInterop.emitRustExpr v40 v41
        let v43 : leptos_RwSignal<std_string_String> = v42.l3
        let v44 : string = method19(v14)
        let v45 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v44 v45
        let v47 : string = "String::from($0)"
        let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v46 v47
        let v49 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v50 : bool = Fable.Core.RustInterop.emitRustExpr struct (v43, v48) v49
        ()
and method62 (v0 : std_string_String) : std_string_String =
    v0
and closure50 () (v0 : leptos_router_Url) : US22 =
    US22_0(v0)
and closure51 () (v0 : std_string_String) : US22 =
    US22_1(v0)
and method63 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure49 (v0 : leptos_router_Location, v1 : leptos_WriteSignal<US20>) () : unit =
    let v2 : string = "$0.hash"
    let v3 : leptos_Memo<std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = $"$0()"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : std_string_String = method62(v5)
    let v7 : string = "v6.strip_prefix('#')"
    let v8 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = ""
    let v10 : string = "r#\"" + v9 + "\"#"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "v8.unwrap_or(v11)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "leptos_router::Url::try_from($0)"
    let v15 : Result<leptos_router_Url, std_string_String> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : (leptos_router_Url -> US22) = closure50()
    let v17 : (std_string_String -> US22) = closure51()
    let v18 : US22 = match v15 with Ok x -> v16 x | Error x -> v17 x
    let v19 : string = @$"format!(""{{:#?}}"", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "content.render () / effect 2 / hash_url: " + string v20 + ""
    let v22 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v21 v22
    match v18 with
    | US22_1(v74) -> (* Error *)
        let v75 : string = "content.render () / effect 2 / hash_url error: " + string v74 + ""
        let v76 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76
        ()
    | US22_0(v24) -> (* Ok *)
        let v25 : US21 = US21_0
        let v26 : US20 = US20_1(v25)
        let v27 : US20 = US20_2
        let v28 : US20 = US20_3
        let v29 : US20 = US20_4
        let v30 : (US20 []) = [|v26; v27; v28; v29|]
        let v31 : int32 = v30.Length
        let v32 : US23 = US23_1
        let v33 : Mut0 = {l0 = 0; l1 = v32} : Mut0
        while method63(v31, v33) do
            let v35 : int32 = v33.l0
            let v36 : US23 = v33.l1
            let v37 : US20 = v30.[int v35]
            let v60 : US23 =
                match v36 with
                | US23_1 -> (* None *)
                    let v49 : string =
                        match v37 with
                        | US20_0 -> (* Blank *)
                            v9
                        | US20_1(v40) -> (* Dice *)
                            let v41 : string = "dice"
                            v41
                        | US20_2 -> (* Lists *)
                            let v42 : string = "lists"
                            v42
                        | US20_4 -> (* Settings *)
                            let v44 : string = "settings"
                            v44
                        | US20_3 -> (* Transactions *)
                            let v43 : string = "transactions"
                            v43
                    let v50 : string = "$0.pathname"
                    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v50
                    let v52 : string = "fable_library_rust::String_::fromString($0)"
                    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52
                    let v54 : string = "/" + v49 + ""
                    let v55 : bool = v53.StartsWith v54
                    if v55 then
                        US23_0(v37)
                    else
                        US23_1
                | US23_0(v38) -> (* Some *)
                    US23_0(v38)
            let v61 : int32 = v35 + 1
            v33.l0 <- v61
            v33.l1 <- v60
            ()
        let v62 : US23 = v33.l1
        let v63 : US20 = v30.[int 0]
        let v66 : US20 =
            match v62 with
            | US23_1 -> (* None *)
                v63
            | US23_0(v64) -> (* Some *)
                v64
        let v67 : string = @$"format!(""{{:#?}}"", $0)"
        let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v66 v67
        let v69 : string = "content.render () / effect 2 / new_tab: " + string v68 + ""
        let v70 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v71 : bool = Fable.Core.RustInterop.emitRustExpr v69 v70
        let v72 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v73 : bool = Fable.Core.RustInterop.emitRustExpr struct (v1, v66) v72
        ()
and closure56 () (v0 : (bool * std_string_String)) : struct (bool * std_string_String) =
    let (a, b) = v0
    let v1 : bool = a
    let v2 : std_string_String = b
    struct (v1, v2)
and closure57 () struct (v0 : bool, v1 : std_string_String) : bool =
    v0
and method67 () : (struct (bool * std_string_String) -> bool) =
    closure57()
and method68 (v0 : Vec<struct (bool * std_string_String)>) : Vec<struct (bool * std_string_String)> =
    v0
and closure58 () struct (v0 : bool, v1 : std_string_String) : std_string_String =
    v1
and closure59 () (v0 : std_string_String) : string =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure55 (v0 : Heap2) () : Vec<string> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : Vec<(bool * std_string_String)> = v6.l1
    let v8 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v9 : ((bool * std_string_String) -> struct (bool * std_string_String)) = closure56()
    let v10 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : (struct (bool * std_string_String) -> bool) = method67()
    let v12 : Vec<struct (bool * std_string_String)> = method68(v10)
    let v13 : string = "v12.into_iter().filter(|x| v11(x.clone().clone())).collect()"
    let v14 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v16 : (struct (bool * std_string_String) -> std_string_String) = closure58()
    let v17 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (std_string_String -> string) = closure59()
    let v20 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = $"%A{v20}"
    let v22 : string = "use_transactions.render (2) / accounts create_memo / result: " + string v21 + ""
    let v23 : int32 = v22.Length
    let v24 : bool = v23 <= 200
    let v27 : string =
        if v24 then
            v22
        else
            let v25 : string = v22.[int 0..int 199]
            let v26 : string = v25 + "..."
            v26
    let v28 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v27 v28
    v20
and closure61 () (v0 : string) : struct (bool * string * bool * US25 * string) =
    let v1 : string = "https://api2.nearblocks.io/v1/account/" + v0 + ""
    let v2 : string = ""
    let v3 : US25 = US25_0
    struct (true, v2, false, v3, v1)
and closure60 (v0 : leptos_Memo<Vec<string>>) () : (struct (bool * string * bool * US25 * string) []) =
    let v1 : string = $"$0()"
    let v2 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v4 : (string -> struct (bool * string * bool * US25 * string)) = closure61()
    let v5 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = $"%A{v7}"
    let v9 : string = "use_transactions.render (3) / accounts_metadata create_memo / result: " + string v8 + ""
    let v10 : int32 = v9.Length
    let v11 : bool = v10 <= 200
    let v14 : string =
        if v11 then
            v9
        else
            let v12 : string = v9.[int 0..int 199]
            let v13 : string = v12 + "..."
            v13
    let v15 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v14 v15
    v7
and method69 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure64 (v0 : string) (v1 : int32) : struct (bool * string * bool * US25 * string) =
    let v2 : int32 = v1 + 1
    let v3 : string = "https://api2.nearblocks.io/v1/account/" + v0 + "/txns?&order=desc&page=" + string v2 + "&per_page=" + string 25 + ""
    let v4 : string = ""
    let v5 : US25 = US25_0
    struct (true, v4, false, v5, v3)
and closure63 (v0 : Heap0) (v1 : string) : struct (string * Vec<struct (bool * string * bool * US25 * string)>) =
    let v2 : int32 = v0.l3
    let v3 : (int32 []) = Array.zeroCreate<int32> (v2)
    let v4 : Mut1 = {l0 = 0} : Mut1
    while method69(v2, v4) do
        let v6 : int32 = v4.l0
        v3.[int v6] <- v6
        let v7 : int32 = v6 + 1
        v4.l0 <- v7
        ()
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<int32> = Fable.Core.RustInterop.emitRustExpr v3 v8
    let v10 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v11 : (int32 -> struct (bool * string * bool * US25 * string)) = closure64(v1)
    let v12 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    struct (v1, v12)
and closure62 (v0 : Heap2, v1 : leptos_Memo<Vec<string>>) () : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<Heap0> = v4.l1
    let v6 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v7 : Heap0 = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = $"$0()"
    let v9 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1 v8
    let v10 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v11 : (string -> struct (string * Vec<struct (bool * string * bool * US25 * string)>)) = closure63(v7)
    let v12 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    let v13 : string = $"%A{v12}"
    let v14 : string = "use_transactions.render (4) / accounts_requests create_memo / result: " + string v13 + ""
    let v15 : int32 = v14.Length
    let v16 : bool = v15 <= 200
    let v19 : string =
        if v16 then
            v14
        else
            let v17 : string = v14.[int 0..int 199]
            let v18 : string = v17 + "..."
            v18
    let v20 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v19 v20
    v12
and closure66 () struct (v0 : string, v1 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v1
and method70 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method71 (v0 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v0
and method72 (v0 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v0
and closure65 (v0 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) () : (struct (bool * string * bool * US25 * string) []) =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v4 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) -> Vec<struct (bool * string * bool * US25 * string)>) = closure66()
    let v5 : Vec<Vec<struct (bool * string * bool * US25 * string)>> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : (struct (bool * string * bool * US25 * string) []) = [||]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v10 : (Vec<struct (bool * string * bool * US25 * string)> []) = Fable.Core.RustInterop.emitRustExpr v5 v9
    let v11 : int32 = v10.Length
    let v12 : Mut2 = {l0 = 0; l1 = v8} : Mut2
    while method70(v11, v12) do
        let v14 : int32 = v12.l0
        let v15 : Vec<struct (bool * string * bool * US25 * string)> = v12.l1
        let v16 : Vec<struct (bool * string * bool * US25 * string)> = v10.[int v14]
        let v17 : Vec<struct (bool * string * bool * US25 * string)> = method71(v16)
        let v18 : Vec<struct (bool * string * bool * US25 * string)> = method72(v15)
        let v19 : string = "let mut v18 = v18"
        Fable.Core.RustInterop.emitRustExpr () v19
        let v20 : string = "v18.extend(v17)"
        Fable.Core.RustInterop.emitRustExpr () v20
        let v21 : string = "v18"
        let v22 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : int32 = v14 + 1
        v12.l0 <- v23
        v12.l1 <- v22
        ()
    let v24 : Vec<struct (bool * string * bool * US25 * string)> = v12.l1
    let v25 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v26 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = $"%A{v26}"
    let v28 : string = "use_transactions.render (5) / txns_requests create_memo / result: " + string v27 + ""
    let v29 : int32 = v28.Length
    let v30 : bool = v29 <= 200
    let v33 : string =
        if v30 then
            v28
        else
            let v31 : string = v28.[int 0..int 199]
            let v32 : string = v31 + "..."
            v32
    let v34 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34
    v26
and closure69 (v0 : string) struct (v1 : bool, v2 : string, v3 : bool, v4 : US25, v5 : string) : string =
    v0
and closure68 () struct (v0 : string, v1 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<string> =
    let v2 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v3 : (struct (bool * string * bool * US25 * string) -> string) = closure69(v0)
    let v4 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v1, v3) v2
    v4
and method73 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method74 (v0 : Vec<string>) : Vec<string> =
    v0
and method75 (v0 : Vec<string>) : Vec<string> =
    v0
and closure67 (v0 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) () : (string []) =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v4 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) -> Vec<string>) = closure68()
    let v5 : Vec<Vec<string>> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : (string []) = [||]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v10 : (Vec<string> []) = Fable.Core.RustInterop.emitRustExpr v5 v9
    let v11 : int32 = v10.Length
    let v12 : Mut3 = {l0 = 0; l1 = v8} : Mut3
    while method73(v11, v12) do
        let v14 : int32 = v12.l0
        let v15 : Vec<string> = v12.l1
        let v16 : Vec<string> = v10.[int v14]
        let v17 : Vec<string> = method74(v16)
        let v18 : Vec<string> = method75(v15)
        let v19 : string = "let mut v18 = v18"
        Fable.Core.RustInterop.emitRustExpr () v19
        let v20 : string = "v18.extend(v17)"
        Fable.Core.RustInterop.emitRustExpr () v20
        let v21 : string = "v18"
        let v22 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : int32 = v14 + 1
        v12.l0 <- v23
        v12.l1 <- v22
        ()
    let v24 : Vec<string> = v12.l1
    let v25 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v26 : (string []) = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = $"%A{v26}"
    let v28 : string = "use_transactions.render (6) / urls_accounts create_memo / result: " + string v27 + ""
    let v29 : int32 = v28.Length
    let v30 : bool = v29 <= 200
    let v33 : string =
        if v30 then
            v28
        else
            let v31 : string = v28.[int 0..int 199]
            let v32 : string = v31 + "..."
            v32
    let v34 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34
    v26
and closure70 (v0 : leptos_Resource<US2, rexie_Rexie>) () : rexie_Rexie option =
    let v1 : string = "state_core.use_requests (2) / database_memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5
and closure71 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Resource<US2, rexie_Rexie>) () : struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])) =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = $"$0()"
    let v5 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v4
    struct (v3, v5)
and method78 () : string =
    let v0 : string = ""
    v0
and method81 (v0 : string) : string =
    v0
and method82 (v0 : Result<Heap4 option, std_string_String>) : Result<Heap4 option, std_string_String> =
    v0
and method80 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    let v2 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = "store"
    let v4 : (string []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v8 : (string -> std_string_String) = closure11()
    let v9 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v8) v7
    let v10 : rexie_Rexie = method20(v1)
    let v11 : string = "v10.transaction(&v9, rexie::TransactionMode::ReadOnly)"
    let v12 : Result<rexie_Transaction, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : (rexie_Error -> std_string_String) = method21()
    let v14 : string = "$0.map_err(|x| $1(x))"
    let v15 : Result<rexie_Transaction, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v12, v13) v14
    let v16 : string = "$0?"
    let v17 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = method22()
    let v19 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "v17.store(v20)"
    let v22 : Result<rexie_Store, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : (rexie_Error -> std_string_String) = method23()
    let v24 : string = "$0.map_err(|x| $1(x))"
    let v25 : Result<rexie_Store, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v22, v23) v24
    let v26 : string = "$0?"
    let v27 : rexie_Store = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = method81(v0)
    let v29 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "wasm_bindgen::JsValue::from_str(v30)"
    let v32 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : string = $"Box::pin(rexie::Store::get(&v27, &v32))"
    let v34 : std_pin_Pin<Box<Dyn<std_future_Future<Result<wasm_bindgen_JsValue, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : string = "v34.await"
    let v36 : Result<wasm_bindgen_JsValue, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : (rexie_Error -> std_string_String) = method25()
    let v38 : string = "$0.map_err(|x| $1(x))"
    let v39 : Result<wasm_bindgen_JsValue, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v36, v37) v38
    let v40 : string = "$0?"
    let v41 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : wasm_bindgen_JsValue = method26(v41)
    let v43 : string = "serde_wasm_bindgen::from_value(v42)"
    let v44 : Result<serde_json_Value option, serde_wasm_bindgen_Error> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : (serde_wasm_bindgen_Error -> std_string_String) = method27()
    let v46 : string = "$0.map_err(|x| $1(x))"
    let v47 : Result<serde_json_Value option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v46
    let v48 : string = "$0?"
    let v49 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : (serde_json_Value -> US7) = method28()
    let v51 : US7 = US7_1
    let v52 : US7 = v49 |> Option.map v50 |> Option.defaultValue v51 
    let v83 : US27 =
        match v52 with
        | US7_1 -> (* None *)
            US27_1
        | US7_0(v53) -> (* Some *)
            let v54 : serde_json_Value = method29(v53)
            let v55 : string = "serde_json::from_value(v54)"
            let v56 : Result<Vec<uint8>, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v55
            let v57 : (serde_json_Error -> std_string_String) = method30()
            let v58 : string = "$0.map_err(|x| $1(x))"
            let v59 : Result<Vec<uint8>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v56, v57) v58
            let v60 : string = "$0?"
            let v61 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v59 v60
            let v62 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v63 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v61 v62
            let v64 : int32 = v63.Length
            let v65 : string = "state_core.get_data () / data_len: " + string v64 + ""
            let v66 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v67 : bool = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "$0.to_vec()"
            let v69 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v63 v68
            let v70 : string = "v69.as_slice()"
            let v71 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v70
            let v72 : string = "let mut v71 = v71"
            Fable.Core.RustInterop.emitRustExpr () v72
            let v73 : string = "borsh::BorshDeserialize::deserialize(&mut v71)"
            let v74 : Result<Heap4, borsh_io_Error> = Fable.Core.RustInterop.emitRustExpr () v73
            let v75 : (borsh_io_Error -> std_string_String) = method31()
            let v76 : string = "$0.map_err(|x| $1(x))"
            let v77 : Result<Heap4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v74, v75) v76
            let v78 : string = "$0?"
            let v79 : Heap4 = Fable.Core.RustInterop.emitRustExpr v77 v78
            US27_0(v79)
    let v88 : Heap4 option =
        match v83 with
        | US27_1 -> (* None *)
            let v86 : Heap4 option = None
            v86
        | US27_0(v84) -> (* Some *)
            let v85 : Heap4 option = Some v84 
            v85
    let v89 : Result<Heap4 option, std_string_String> = Ok v88
    let v90 : Result<Heap4 option, std_string_String> = method82(v89)
    let v91 : string = "v90 }})"
    Fable.Core.RustInterop.emitRustExpr () v91
    let v92 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v92
    let v93 : string = "__result"
    let v94 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v93
    v94
and closure73 () (v0 : Heap4 option) : US26 =
    US26_0(v0)
and closure74 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and method83 () : string =
    let v0 : string = "database=None"
    v0
and method79 (v0 : rexie_Rexie option, v1 : bool, v2 : string, v3 : bool, v4 : US25, v5 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    let v6 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : (rexie_Rexie -> US5) = method17()
    let v8 : US5 = US5_1
    let v9 : US5 = v0 |> Option.map v7 |> Option.defaultValue v8 
    let v27 : US26 =
        match v9 with
        | US5_0(v10) -> (* Some *)
            let v11 : string = "url[" + v5 + "](" + $"%A{v2}" + ")"
            let v12 : string = "state_core.get_data () / id: " + v11 + ""
            let v13 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
            let v15 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = method80(v11, v10)
            let v16 : string = "v15.await"
            let v17 : Result<Heap4 option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v16
            let v18 : (Heap4 option -> US26) = closure73()
            let v19 : (std_string_String -> US26) = closure74()
            let v20 : US26 = match v17 with Ok x -> v18 x | Error x -> v19 x
            v20
        | _ ->
            let v21 : string = method83()
            let v22 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
            let v24 : string = "String::from($0)"
            let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
            US26_1(v25)
    let v33 : Result<Heap4 option, std_string_String> =
        match v27 with
        | US26_1(v30) -> (* Error *)
            let v31 : Result<Heap4 option, std_string_String> = Error v30
            v31
        | US26_0(v28) -> (* Ok *)
            let v29 : Result<Heap4 option, std_string_String> = Ok v28
            v29
    let v34 : Result<Heap4 option, std_string_String> = method82(v33)
    let v35 : string = "v34 }})"
    Fable.Core.RustInterop.emitRustExpr () v35
    let v36 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v36
    let v37 : string = "__result"
    let v38 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v37
    v38
and closure72 (v0 : rexie_Rexie option) struct (v1 : bool, v2 : string, v3 : bool, v4 : US25, v5 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    method79(v0, v1, v2, v3, v4, v5)
and method84 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> =
    v0
and method85 (v0 : Result<Vec<Heap4 option>, std_string_String>) : Result<Vec<Heap4 option>, std_string_String> =
    v0
and method77 (v0 : (struct (bool * string * bool * US25 * string) []), v1 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = $"%A{v1}"
    let v4 : string = $"%A{v0}"
    let v5 : int64 = System.Convert.ToInt64 v4.Length
    let v6 : bool = v5 <= 400L
    let v28 : string =
        if v6 then
            v4
        else
            let v7 : float = float 400L
            let v8 : float = v7 / 2.0
            let v9 : (float -> float) = ceil
            let v10 : float = v9 v8
            let v11 : int64 = int64 v10
            let v12 : (float -> float) = floor
            let v13 : float = v12 v8
            let v14 : int64 = int64 v13
            let v15 : int64 = v11 - 1L
            let v16 : string = v4.[int 0L..int v15]
            let v17 : int64 = v5 - v14
            let v18 : int64 = v5 - 1L
            let v19 : string = v4.[int v17..int v18]
            let v20 : string = "..."
            let v21 : (string []) = [|v16; v20; v19|]
            let v22 : ((string []) -> string seq) = Seq.ofArray
            let v23 : string seq = v22 v21
            let v24 : string = method78()
            let v25 : (string -> (string seq -> string)) = String.concat
            let v26 : (string seq -> string) = v25 v24
            v26 v23
    let v29 : string = "state_core.use_requests (3) / state_data_resource create_local_resource / request : " + string v28 + " / database: " + string v3 + ""
    let v30 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "$0.to_vec()"
    let v33 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v0 v32
    let v34 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v35 : (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>) = closure72(v1)
    let v36 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr struct (v33, v35) v34
    let v37 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = method84(v36)
    let v38 : string = "futures::future::try_join_all(v37)"
    let v39 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : string = "v39.await"
    let v41 : Result<Vec<Heap4 option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : string = "$0?"
    let v43 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : Result<Vec<Heap4 option>, std_string_String> = Ok v43
    let v45 : string = $"%A{v44}"
    let v46 : string = "state_core.use_requests (4) / state_data_resource create_local_resource / result: " + string v45 + ""
    let v47 : int32 = v46.Length
    let v48 : bool = v47 <= 200
    let v51 : string =
        if v48 then
            v46
        else
            let v49 : string = v46.[int 0..int 199]
            let v50 : string = v49 + "..."
            v50
    let v52 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v53 : bool = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : Result<Vec<Heap4 option>, std_string_String> = method85(v44)
    let v55 : string = "v54 }})"
    Fable.Core.RustInterop.emitRustExpr () v55
    let v56 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v56
    let v57 : string = "__result"
    let v58 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v57
    v58
and method86 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> =
    v0
and method76 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Resource<US2, rexie_Rexie>) : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> =
    let v2 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v3 : (unit -> struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) []))) = closure71(v0, v1)
    Fable.Core.RustInterop.emitRustExpr v3 v2
    let v4 : string = "x"
    let struct (v5 : rexie_Rexie option, v6 : (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr () v4
    let v7 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = method77(v6, v5)
    let v8 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = method86(v7)
    let v9 : string = "v8.await"
    let v10 : Result<Vec<Heap4 option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "v10 }})"
    Fable.Core.RustInterop.emitRustExpr () v11
    let v12 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v13
    v14
and closure77 () (v0 : Vec<Heap4 option>) : (Heap4 option []) =
    let v1 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v2 : (Heap4 option []) = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and method87 () : (Vec<Heap4 option> -> (Heap4 option [])) =
    closure77()
and method88 (v0 : Result<Vec<Heap4 option>, std_string_String>) : Result<Vec<Heap4 option>, std_string_String> =
    v0
and closure76 () (v0 : Result<Vec<Heap4 option>, std_string_String>) : Result<(Heap4 option []), std_string_String> =
    let v1 : (Vec<Heap4 option> -> (Heap4 option [])) = method87()
    let v2 : Result<Vec<Heap4 option>, std_string_String> = method88(v0)
    let v3 : string = "v2.map(|x| v1(x))"
    let v4 : Result<(Heap4 option []), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3
    v4
and closure75 (v0 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>>) () : Result<(Heap4 option []), std_string_String> option =
    let v1 : string = "state_core.use_requests (5) / state_data_func"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : web_sys_Window = method37()
    let v5 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method38(v4)
    let v6 : (web_sys_Storage option -> US10) = closure24()
    let v7 : (wasm_bindgen_JsValue -> US10) = closure25()
    let v8 : US10 = match v5 with Ok x -> v6 x | Error x -> v7 x
    let v17 : US11 =
        match v8 with
        | US10_1(v14) -> (* Error *)
            US11_1(v14)
        | US10_0(v9) -> (* Ok *)
            let v10 : (web_sys_Storage -> US12) = method39()
            let v11 : US12 = US12_1
            let v12 : US12 = v9 |> Option.map v10 |> Option.defaultValue v11 
            US11_0(v12)
    let v27 : Result<(Heap4 option []), std_string_String> option =
        match v17 with
        | US11_0(v18) -> (* Ok *)
            match v18 with
            | US12_0(v19) -> (* Some *)
                let v20 : string = $"leptos::SignalGet::get(&$0)"
                let v21 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v0 v20
                let v22 : (Result<Vec<Heap4 option>, std_string_String> -> Result<(Heap4 option []), std_string_String>) = closure76()
                let v23 : Result<(Heap4 option []), std_string_String> option = v21 |> Option.map v22 
                v23
            | _ ->
                let v24 : Result<(Heap4 option []), std_string_String> option = None
                v24
        | _ ->
            let v26 : Result<(Heap4 option []), std_string_String> option = None
            v26
    let v28 : string = $"%A{v27}"
    let v29 : string = "state_core.use_requests (6) / state_data_func func0 / result: " + string v28 + ""
    let v30 : int32 = v29.Length
    let v31 : bool = v30 <= 200
    let v34 : string =
        if v31 then
            v29
        else
            let v32 : string = v29.[int 0..int 199]
            let v33 : string = v32 + "..."
            v33
    let v35 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr v34 v35
    v27
and closure78 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>) () : struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option) =
    let v2 : string = $"$0()"
    let v3 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = $"$0()"
    let v5 : Result<(Heap4 option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v4
    struct (v3, v5)
and closure79 () (v0 : Result<(Heap4 option []), std_string_String>) : US28 =
    US28_0(v0)
and method91 () : (Result<(Heap4 option []), std_string_String> -> US28) =
    closure79()
and closure80 () (v0 : (Heap4 option [])) : US31 =
    US31_0(v0)
and closure81 () (v0 : std_string_String) : US31 =
    US31_1(v0)
and closure83 () (v0 : Heap4) : US27 =
    US27_0(v0)
and method92 () : (Heap4 -> US27) =
    closure83()
and closure82 () (v0 : Heap4 option) : US27 =
    let v1 : (Heap4 -> US27) = method92()
    let v2 : US27 = US27_1
    let v3 : US27 = v0 |> Option.map v1 |> Option.defaultValue v2 
    v3
and closure86 () (v0 : US27) : US35 =
    US35_0(v0)
and method95 () : (US27 -> US35) =
    closure86()
and method96 (v0 : US25) : US25 =
    v0
and method97 (v0 : string) : string =
    v0
and method98 (v0 : std_string_String) : std_string_String =
    v0
and method99 (v0 : string) : string =
    v0
and method100 (v0 : std_string_String) : std_string_String =
    v0
and method101 (v0 : reqwest_RequestBuilder) : reqwest_RequestBuilder =
    v0
and method102 () : string =
    let v0 : string = "application/json"
    v0
and method103 (v0 : reqwest_RequestBuilder) : reqwest_RequestBuilder =
    v0
and closure87 () (v0 : reqwest_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method104 () : (reqwest_Error -> std_string_String) =
    closure87()
and method105 (v0 : Result<string option, std_string_String>) : Result<string option, std_string_String> =
    v0
and method94 (v0 : US29, v1 : int32, v2 : bool, v3 : bool, v4 : string, v5 : US25, v6 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>> =
    let v7 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v39 : US32 =
        match v0 with
        | US29_1 -> (* None *)
            US32_1
        | US29_0(v8) -> (* Some *)
            let v35 : US33 =
                match v8 with
                | US30_1(v32) -> (* Error *)
                    US33_1(v32)
                | US30_0(v9) -> (* Ok *)
                    let v10 : (int32 -> ((US27 []) -> US27 option)) = Array.tryItem
                    let v11 : ((US27 []) -> US27 option) = v10 v1
                    let v12 : US27 option = v11 v9
                    let v13 : (US27 -> US35) = method95()
                    let v14 : US35 = US35_1
                    let v15 : US35 = v12 |> Option.map v13 |> Option.defaultValue v14 
                    let v22 : US27 =
                        match v15 with
                        | US35_0(v16) -> (* Some *)
                            match v16 with
                            | US27_0(v17) -> (* Some *)
                                US27_0(v17)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v30 : US34 =
                        match v22 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v23) -> (* Some *)
                            let v24 : std_string_String = v23.l0
                            let v25 : string = "fable_library_rust::String_::fromString($0)"
                            let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25
                            US34_0(v26)
                    US33_0(v30)
            US32_0(v35)
    let v40 : string = $"%A{struct (v2, v3, v5)}"
    let v41 : int64 = System.Convert.ToInt64 v40.Length
    let v42 : bool = v41 <= 400L
    let v64 : string =
        if v42 then
            v40
        else
            let v43 : float = float 400L
            let v44 : float = v43 / 2.0
            let v45 : (float -> float) = ceil
            let v46 : float = v45 v44
            let v47 : int64 = int64 v46
            let v48 : (float -> float) = floor
            let v49 : float = v48 v44
            let v50 : int64 = int64 v49
            let v51 : int64 = v47 - 1L
            let v52 : string = v40.[int 0L..int v51]
            let v53 : int64 = v41 - v50
            let v54 : int64 = v41 - 1L
            let v55 : string = v40.[int v53..int v54]
            let v56 : string = "..."
            let v57 : (string []) = [|v52; v56; v55|]
            let v58 : ((string []) -> string seq) = Seq.ofArray
            let v59 : string seq = v58 v57
            let v60 : string = method78()
            let v61 : (string -> (string seq -> string)) = String.concat
            let v62 : (string seq -> string) = v61 v60
            v62 v59
    let v65 : string = $"%A{v0}"
    let v66 : int64 = System.Convert.ToInt64 v65.Length
    let v67 : bool = v66 <= 400L
    let v89 : string =
        if v67 then
            v65
        else
            let v68 : float = float 400L
            let v69 : float = v68 / 2.0
            let v70 : (float -> float) = ceil
            let v71 : float = v70 v69
            let v72 : int64 = int64 v71
            let v73 : (float -> float) = floor
            let v74 : float = v73 v69
            let v75 : int64 = int64 v74
            let v76 : int64 = v72 - 1L
            let v77 : string = v65.[int 0L..int v76]
            let v78 : int64 = v66 - v75
            let v79 : int64 = v66 - 1L
            let v80 : string = v65.[int v78..int v79]
            let v81 : string = "..."
            let v82 : (string []) = [|v77; v81; v80|]
            let v83 : ((string []) -> string seq) = Seq.ofArray
            let v84 : string seq = v83 v82
            let v85 : string = method78()
            let v86 : (string -> (string seq -> string)) = String.concat
            let v87 : (string seq -> string) = v86 v85
            v87 v84
    let v90 : string = $"%A{v39}"
    let v91 : int64 = System.Convert.ToInt64 v90.Length
    let v92 : bool = v91 <= 400L
    let v114 : string =
        if v92 then
            v90
        else
            let v93 : float = float 400L
            let v94 : float = v93 / 2.0
            let v95 : (float -> float) = ceil
            let v96 : float = v95 v94
            let v97 : int64 = int64 v96
            let v98 : (float -> float) = floor
            let v99 : float = v98 v94
            let v100 : int64 = int64 v99
            let v101 : int64 = v97 - 1L
            let v102 : string = v90.[int 0L..int v101]
            let v103 : int64 = v91 - v100
            let v104 : int64 = v91 - 1L
            let v105 : string = v90.[int v103..int v104]
            let v106 : string = "..."
            let v107 : (string []) = [|v102; v106; v105|]
            let v108 : ((string []) -> string seq) = Seq.ofArray
            let v109 : string seq = v108 v107
            let v110 : string = method78()
            let v111 : (string -> (string seq -> string)) = String.concat
            let v112 : (string seq -> string) = v111 v110
            v112 v109
    let v137 : bool =
        if v2 then
            true
        else
            match v0 with
            | US29_0(v115) -> (* Some *)
                match v115 with
                | US30_0(v116) -> (* Ok *)
                    let v117 : uint64 = System.Convert.ToUInt64 v116.Length
                    let v118 : bool = v117 = 0UL
                    if v118 then
                        false
                    else
                        match v39 with
                        | US32_0(v119) -> (* Some *)
                            match v119 with
                            | US33_0(v120) -> (* Ok *)
                                match v120 with
                                | US34_1 -> (* None *)
                                    true
                                | _ ->
                                    false
                            | _ ->
                                false
                        | _ ->
                            false
                | _ ->
                    match v39 with
                    | US32_0(v125) -> (* Some *)
                        match v125 with
                        | US33_0(v126) -> (* Ok *)
                            match v126 with
                            | US34_1 -> (* None *)
                                true
                            | _ ->
                                false
                        | _ ->
                            false
                    | _ ->
                        false
            | _ ->
                match v39 with
                | US32_0(v131) -> (* Some *)
                    match v131 with
                    | US33_0(v132) -> (* Ok *)
                        match v132 with
                        | US34_1 -> (* None *)
                            true
                        | _ ->
                            false
                    | _ ->
                        false
                | _ ->
                    false
    let v138 : string = "state_core.use_requests (9) / result memo / state_data: " + string v89 + " / state_data': " + string v114 + " / request: " + string v64 + " / should_fetch: " + string v137 + ""
    let v139 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v140 : bool = Fable.Core.RustInterop.emitRustExpr v138 v139
    let v141 : bool = v137 = false
    let v216 : US36 =
        if v141 then
            let v142 : string option = None
            US36_0(v142)
        else
            let v144 : US25 = method96(v5)
            let v164 : reqwest_RequestBuilder =
                match v144 with
                | US25_0 -> (* Get *)
                    let v145 : string = method97(v6)
                    let v146 : string = method19(v145)
                    let v147 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v146 v147
                    let v149 : string = "String::from($0)"
                    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v148 v149
                    let v151 : std_string_String = method98(v150)
                    let v152 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.get(v151)"
                    let v153 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v152
                    v153
                | US25_1 -> (* Post *)
                    let v154 : string = method99(v6)
                    let v155 : string = method19(v154)
                    let v156 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v155 v156
                    let v158 : string = "String::from($0)"
                    let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v158
                    let v160 : std_string_String = method100(v159)
                    let v161 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.post(v160)"
                    let v162 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v161
                    v162
            let v165 : string = method19(v4)
            let v166 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v165 v166
            let v168 : string = "String::from($0)"
            let v169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v167 v168
            let v170 : string = "reqwest_wasm::RequestBuilder::body(v164, v169)"
            let v171 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v170
            let v172 : bool = v3 = false
            let v192 : reqwest_RequestBuilder =
                if v172 then
                    let v173 : string = "v171"
                    let v174 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v173
                    v174
                else
                    let v175 : string = "reqwest_wasm::header::CONTENT_TYPE.to_string()"
                    let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v175
                    let v177 : string = "fable_library_rust::String_::fromString($0)"
                    let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177
                    let v179 : reqwest_RequestBuilder = method101(v171)
                    let v180 : string = method19(v178)
                    let v181 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v182 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v180 v181
                    let v183 : string = "String::from($0)"
                    let v184 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v183
                    let v185 : string = method102()
                    let v186 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v187 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v185 v186
                    let v188 : string = "String::from($0)"
                    let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v187 v188
                    let v190 : string = "reqwest_wasm::RequestBuilder::header(v179, v184, v189)"
                    let v191 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v190
                    v191
            let v193 : reqwest_RequestBuilder = method103(v192)
            let v194 : string = "Box::pin(reqwest_wasm::RequestBuilder::send(v193))"
            let v195 : std_pin_Pin<Box<Dyn<std_future_Future<Result<reqwest_Response, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v194
            let v196 : string = "v195.await"
            let v197 : Result<reqwest_Response, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v196
            let v198 : (reqwest_Error -> std_string_String) = method104()
            let v199 : string = "$0.map_err(|x| $1(x))"
            let v200 : Result<reqwest_Response, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v197, v198) v199
            let v201 : string = "$0?"
            let v202 : reqwest_Response = Fable.Core.RustInterop.emitRustExpr v200 v201
            let v203 : string = "Box::pin(reqwest_wasm::Response::text(v202))"
            let v204 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_string_String, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v203
            let v205 : string = "v204.await"
            let v206 : Result<std_string_String, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v205
            let v207 : (reqwest_Error -> std_string_String) = method104()
            let v208 : string = "$0.map_err(|x| $1(x))"
            let v209 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v206, v207) v208
            let v210 : string = "$0?"
            let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v210
            let v212 : string = "fable_library_rust::String_::fromString($0)"
            let v213 : string = Fable.Core.RustInterop.emitRustExpr v211 v212
            let v214 : string option = Some v213 
            US36_0(v214)
    let v222 : Result<string option, std_string_String> =
        match v216 with
        | US36_1(v219) -> (* Error *)
            let v220 : Result<string option, std_string_String> = Error v219
            v220
        | US36_0(v217) -> (* Ok *)
            let v218 : Result<string option, std_string_String> = Ok v217
            v218
    let v223 : Result<string option, std_string_String> = method105(v222)
    let v224 : string = "v223 }})"
    Fable.Core.RustInterop.emitRustExpr () v224
    let v225 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v225
    let v226 : string = "__result"
    let v227 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v226
    v227
and closure85 (v0 : US29, v1 : int32) struct (v2 : bool, v3 : string, v4 : bool, v5 : US25, v6 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>> =
    method94(v0, v1, v2, v4, v3, v5, v6)
and closure84 (v0 : US29) (v1 : int32) : (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>) =
    closure85(v0, v1)
and method93 (v0 : US29) : (int32 -> (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>)) =
    closure84(v0)
and method106 (v0 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v0
and method107 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> =
    v0
and method108 (v0 : Result<(string option []), std_string_String>) : Result<(string option []), std_string_String> =
    v0
and method90 (v0 : Result<(Heap4 option []), std_string_String> option, v1 : (struct (bool * string * bool * US25 * string) [])) : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : (Result<(Heap4 option []), std_string_String> -> US28) = method91()
    let v4 : US28 = US28_1
    let v5 : US28 = v0 |> Option.map v3 |> Option.defaultValue v4 
    let v26 : US29 =
        match v5 with
        | US28_1 -> (* None *)
            US29_1
        | US28_0(v6) -> (* Some *)
            let v7 : ((Heap4 option []) -> US31) = closure80()
            let v8 : (std_string_String -> US31) = closure81()
            let v9 : US31 = match v6 with Ok x -> v7 x | Error x -> v8 x
            let v22 : US30 =
                match v9 with
                | US31_1(v19) -> (* Error *)
                    US30_1(v19)
                | US31_0(v10) -> (* Ok *)
                    let v11 : string = "$0.to_vec()"
                    let v12 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v10 v11
                    let v13 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v14 : (Heap4 option -> US27) = closure82()
                    let v15 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v12, v14) v13
                    let v16 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v17 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v15 v16
                    US30_0(v17)
            US29_0(v22)
    let v27 : string = $"%A{v26}"
    let v28 : int64 = System.Convert.ToInt64 v27.Length
    let v29 : bool = v28 <= 400L
    let v51 : string =
        if v29 then
            v27
        else
            let v30 : float = float 400L
            let v31 : float = v30 / 2.0
            let v32 : (float -> float) = ceil
            let v33 : float = v32 v31
            let v34 : int64 = int64 v33
            let v35 : (float -> float) = floor
            let v36 : float = v35 v31
            let v37 : int64 = int64 v36
            let v38 : int64 = v34 - 1L
            let v39 : string = v27.[int 0L..int v38]
            let v40 : int64 = v28 - v37
            let v41 : int64 = v28 - 1L
            let v42 : string = v27.[int v40..int v41]
            let v43 : string = "..."
            let v44 : (string []) = [|v39; v43; v42|]
            let v45 : ((string []) -> string seq) = Seq.ofArray
            let v46 : string seq = v45 v44
            let v47 : string = method78()
            let v48 : (string -> (string seq -> string)) = String.concat
            let v49 : (string seq -> string) = v48 v47
            v49 v46
    let v52 : string = "state_core.use_requests (8) / result_memo / state_data: " + string v51 + ""
    let v53 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v54 : bool = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "$0.to_vec()"
    let v56 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v1 v55
    let v57 : (int32 -> (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>)) = method93(v26)
    let v58 : Vec<struct (bool * string * bool * US25 * string)> = method106(v56)
    let v59 : string = "v58.iter().enumerate().map(|(i, x)| v57(i.try_into().unwrap())(x.clone())).collect()"
    let v60 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = method107(v60)
    let v62 : string = "futures::future::try_join_all(v61)"
    let v63 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v62
    let v64 : string = "v63.await"
    let v65 : Result<Vec<string option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : string = "$0?"
    let v67 : Vec<string option> = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v69 : (string option []) = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : Result<(string option []), std_string_String> = Ok v69
    let v71 : Result<(string option []), std_string_String> = method108(v70)
    let v72 : string = "v71 }})"
    Fable.Core.RustInterop.emitRustExpr () v72
    let v73 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v73
    let v74 : string = "__result"
    let v75 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v74
    v75
and method109 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> =
    v0
and method89 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>) : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> =
    let v2 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v3 : (unit -> struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option)) = closure78(v0, v1)
    Fable.Core.RustInterop.emitRustExpr v3 v2
    let v4 : string = "x"
    let struct (v5 : (struct (bool * string * bool * US25 * string) []), v6 : Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr () v4
    let v7 : string = $"%A{v5}"
    let v8 : int64 = System.Convert.ToInt64 v7.Length
    let v9 : bool = v8 <= 400L
    let v31 : string =
        if v9 then
            v7
        else
            let v10 : float = float 400L
            let v11 : float = v10 / 2.0
            let v12 : (float -> float) = ceil
            let v13 : float = v12 v11
            let v14 : int64 = int64 v13
            let v15 : (float -> float) = floor
            let v16 : float = v15 v11
            let v17 : int64 = int64 v16
            let v18 : int64 = v14 - 1L
            let v19 : string = v7.[int 0L..int v18]
            let v20 : int64 = v8 - v17
            let v21 : int64 = v8 - 1L
            let v22 : string = v7.[int v20..int v21]
            let v23 : string = "..."
            let v24 : (string []) = [|v19; v23; v22|]
            let v25 : ((string []) -> string seq) = Seq.ofArray
            let v26 : string seq = v25 v24
            let v27 : string = method78()
            let v28 : (string -> (string seq -> string)) = String.concat
            let v29 : (string seq -> string) = v28 v27
            v29 v26
    let v32 : string = "state_core.use_requests (7) / json create_local_resource / requests: " + string v31 + ""
    let v33 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v34 : bool = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> = method90(v6, v5)
    let v36 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> = method109(v35)
    let v37 : string = "v36.await"
    let v38 : Result<(string option []), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v37
    let v39 : string = "v38 }})"
    Fable.Core.RustInterop.emitRustExpr () v39
    let v40 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v40
    let v41 : string = "__result"
    let v42 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v41
    v42
and method113 (v0 : string) : string =
    v0
and method112 (v0 : string, v1 : Heap4, v2 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> =
    let v3 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : string = "$0.transaction(&[\"store\"], rexie::TransactionMode::ReadWrite)?"
    let v5 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v2 v4
    let v6 : string = "v5.store(\"store\")?"
    let v7 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "true; let mut data = Vec::new()"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "true; borsh::BorshSerialize::serialize(&$0, &mut data).unwrap()"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v1 v10
    let v12 : string = "data"
    let v13 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "serde_wasm_bindgen::to_value(&v13).unwrap()"
    let v15 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = method113(v0)
    let v17 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "true; v7.put(&v15, Some(&v18.into())).await?"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "true; v5.done().await?"
    let v22 : bool = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : Result<unit, rexie_Error> = Ok ()
    let v24 : Result<unit, rexie_Error> = method50(v23)
    let v25 : string = "v24 }})"
    Fable.Core.RustInterop.emitRustExpr () v25
    let v26 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "__result"
    let v28 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v27
    v28
and closure90 () (v0 : rexie_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method114 () : (rexie_Error -> std_string_String) =
    closure90()
and method115 (v0 : Result<unit, std_string_String>) : Result<unit, std_string_String> =
    v0
and method111 (v0 : Heap4, v1 : US5, v2 : bool, v3 : string, v4 : bool, v5 : US25, v6 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> =
    let v7 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v30 : US37 =
        match v1 with
        | US5_0(v8) -> (* Some *)
            let v9 : string = "state_core.use_requests (11) / set_state_data_action / database=Some(_) / url: " + v6 + ""
            let v10 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10
            let v12 : string = "url[" + v6 + "](" + $"%A{v3}" + ")"
            let v13 : string = $"%A{v0}"
            let v14 : int64 = System.Convert.ToInt64 v13.Length
            let v15 : string = "state_core.set_data () / data_len: " + string v14 + ""
            let v16 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16
            let v18 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = method112(v12, v0, v8)
            let v19 : string = "v18.await"
            let v20 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : (rexie_Error -> std_string_String) = method114()
            let v22 : string = "$0.map_err(|x| $1(x))"
            let v23 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v20, v21) v22
            let v24 : string = "$0?"
            Fable.Core.RustInterop.emitRustExpr v23 v24
            US37_0
        | _ ->
            let v26 : string = "state_core.use_requests (12) / set_state_data_action / database,request=None"
            let v27 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v28 : bool = Fable.Core.RustInterop.emitRustExpr v26 v27
            US37_0
    let v35 : Result<unit, std_string_String> =
        match v30 with
        | US37_1(v32) -> (* Error *)
            let v33 : Result<unit, std_string_String> = Error v32
            v33
        | US37_0 -> (* Ok *)
            let v31 : Result<unit, std_string_String> = Ok ()
            v31
    let v36 : Result<unit, std_string_String> = method115(v35)
    let v37 : string = "v36 }})"
    Fable.Core.RustInterop.emitRustExpr () v37
    let v38 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v38
    let v39 : string = "__result"
    let v40 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v39
    v40
and closure89 (v0 : Heap4, v1 : US5) struct (v2 : bool, v3 : string, v4 : bool, v5 : US25, v6 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> =
    method111(v0, v1, v2, v3, v4, v5, v6)
and method116 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> =
    v0
and method117 (v0 : Result<Vec<unit>, std_string_String>) : Result<Vec<unit>, std_string_String> =
    v0
and method110 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<rexie_Rexie option>, v2 : Heap4) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>> =
    let v3 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : (rexie_Rexie -> US5) = method17()
    let v7 : US5 = US5_1
    let v8 : US5 = v5 |> Option.map v6 |> Option.defaultValue v7 
    let v9 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v10 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v9
    let v11 : string = "$0.to_vec()"
    let v12 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v14 : (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>) = closure89(v2, v8)
    let v15 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr struct (v12, v14) v13
    let v16 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = method116(v15)
    let v17 : string = "futures::future::try_join_all(v16)"
    let v18 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = "v18.await"
    let v20 : Result<Vec<unit>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "$0?"
    let v22 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : Result<Vec<unit>, std_string_String> = Ok v22
    let v24 : Result<Vec<unit>, std_string_String> = method117(v23)
    let v25 : string = "v24 }})"
    Fable.Core.RustInterop.emitRustExpr () v25
    let v26 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "__result"
    let v28 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v27
    v28
and closure88 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<rexie_Rexie option>) (v2 : Heap4) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>> =
    let v3 : string = $"%A{v2}"
    let v4 : int64 = System.Convert.ToInt64 v3.Length
    let v5 : string = "state_core.use_requests (10) / set_state_data_action / value_len: " + string v4 + ""
    let v6 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    method110(v0, v1, v2)
and closure92 () (v0 : Result<(string option []), std_string_String>) : US38 =
    US38_0(v0)
and method118 () : (Result<(string option []), std_string_String> -> US38) =
    closure92()
and closure93 () (v0 : (string option [])) : US40 =
    US40_0(v0)
and closure94 () (v0 : std_string_String) : US40 =
    US40_1(v0)
and closure96 () (v0 : string) : US34 =
    US34_0(v0)
and method119 () : (string -> US34) =
    closure96()
and closure95 () (v0 : string option) : US34 =
    let v1 : (string -> US34) = method119()
    let v2 : US34 = US34_1
    let v3 : US34 = v0 |> Option.map v1 |> Option.defaultValue v2 
    v3
and closure97 (v0 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) (v1 : US34) : unit =
    match v1 with
    | US34_0(v2) -> (* Some *)
        let v3 : string = method19(v2)
        let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
        let v6 : string = "String::from($0)"
        let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
        let v8 : Heap4 = {l0 = v7} : Heap4
        let v9 : string = "true; leptos::Action::dispatch(&$0, $1.clone())"
        let v10 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v8) v9
        ()
    | _ ->
        ()
and closure100 () (v0 : US34) : US43 =
    US43_0(v0)
and method121 () : (US34 -> US43) =
    closure100()
and closure101 () (v0 : crate_model_near_nearblocks_Root) : crate_model_near_nearblocks_Root option =
    let v1 : crate_model_near_nearblocks_Root option = Some v0 
    v1
and method122 () : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) =
    closure101()
and method123 (v0 : Result<crate_model_near_nearblocks_Root, std_string_String>) : Result<crate_model_near_nearblocks_Root, std_string_String> =
    v0
and closure99 (v0 : US29, v1 : US42, v2 : int32) struct (v3 : bool, v4 : string, v5 : bool, v6 : US25, v7 : string) : Result<crate_model_near_nearblocks_Root option, std_string_String> =
    let v39 : US32 =
        match v0 with
        | US29_1 -> (* None *)
            US32_1
        | US29_0(v8) -> (* Some *)
            let v35 : US33 =
                match v8 with
                | US30_1(v32) -> (* Error *)
                    US33_1(v32)
                | US30_0(v9) -> (* Ok *)
                    let v10 : (int32 -> ((US27 []) -> US27 option)) = Array.tryItem
                    let v11 : ((US27 []) -> US27 option) = v10 v2
                    let v12 : US27 option = v11 v9
                    let v13 : (US27 -> US35) = method95()
                    let v14 : US35 = US35_1
                    let v15 : US35 = v12 |> Option.map v13 |> Option.defaultValue v14 
                    let v22 : US27 =
                        match v15 with
                        | US35_0(v16) -> (* Some *)
                            match v16 with
                            | US27_0(v17) -> (* Some *)
                                US27_0(v17)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v30 : US34 =
                        match v22 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v23) -> (* Some *)
                            let v24 : std_string_String = v23.l0
                            let v25 : string = "fable_library_rust::String_::fromString($0)"
                            let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25
                            US34_0(v26)
                    US33_0(v30)
            US32_0(v35)
    let v40 : string = $"%A{struct (v3, v4, v5, v6, v7)}"
    let v41 : int64 = System.Convert.ToInt64 v40.Length
    let v42 : bool = v41 <= 400L
    let v64 : string =
        if v42 then
            v40
        else
            let v43 : float = float 400L
            let v44 : float = v43 / 2.0
            let v45 : (float -> float) = ceil
            let v46 : float = v45 v44
            let v47 : int64 = int64 v46
            let v48 : (float -> float) = floor
            let v49 : float = v48 v44
            let v50 : int64 = int64 v49
            let v51 : int64 = v47 - 1L
            let v52 : string = v40.[int 0L..int v51]
            let v53 : int64 = v41 - v50
            let v54 : int64 = v41 - 1L
            let v55 : string = v40.[int v53..int v54]
            let v56 : string = "..."
            let v57 : (string []) = [|v52; v56; v55|]
            let v58 : ((string []) -> string seq) = Seq.ofArray
            let v59 : string seq = v58 v57
            let v60 : string = method78()
            let v61 : (string -> (string seq -> string)) = String.concat
            let v62 : (string seq -> string) = v61 v60
            v62 v59
    let v65 : string = $"%A{v39}"
    let v66 : int64 = System.Convert.ToInt64 v65.Length
    let v67 : bool = v66 <= 400L
    let v89 : string =
        if v67 then
            v65
        else
            let v68 : float = float 400L
            let v69 : float = v68 / 2.0
            let v70 : (float -> float) = ceil
            let v71 : float = v70 v69
            let v72 : int64 = int64 v71
            let v73 : (float -> float) = floor
            let v74 : float = v73 v69
            let v75 : int64 = int64 v74
            let v76 : int64 = v72 - 1L
            let v77 : string = v65.[int 0L..int v76]
            let v78 : int64 = v66 - v75
            let v79 : int64 = v66 - 1L
            let v80 : string = v65.[int v78..int v79]
            let v81 : string = "..."
            let v82 : (string []) = [|v77; v81; v80|]
            let v83 : ((string []) -> string seq) = Seq.ofArray
            let v84 : string seq = v83 v82
            let v85 : string = method78()
            let v86 : (string -> (string seq -> string)) = String.concat
            let v87 : (string seq -> string) = v86 v85
            v87 v84
    let v90 : string = "state_core.use_request (15) / result memo / request: " + string v64 + " / state_data: " + string v89 + ""
    let v91 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr v90 v91
    let v93 : string = $"%A{v1}"
    let v94 : int64 = System.Convert.ToInt64 v93.Length
    let v95 : bool = v94 <= 400L
    let v117 : string =
        if v95 then
            v93
        else
            let v96 : float = float 400L
            let v97 : float = v96 / 2.0
            let v98 : (float -> float) = ceil
            let v99 : float = v98 v97
            let v100 : int64 = int64 v99
            let v101 : (float -> float) = floor
            let v102 : float = v101 v97
            let v103 : int64 = int64 v102
            let v104 : int64 = v100 - 1L
            let v105 : string = v93.[int 0L..int v104]
            let v106 : int64 = v94 - v103
            let v107 : int64 = v94 - 1L
            let v108 : string = v93.[int v106..int v107]
            let v109 : string = "..."
            let v110 : (string []) = [|v105; v109; v108|]
            let v111 : ((string []) -> string seq) = Seq.ofArray
            let v112 : string seq = v111 v110
            let v113 : string = method78()
            let v114 : (string -> (string seq -> string)) = String.concat
            let v115 : (string seq -> string) = v114 v113
            v115 v112
    let v118 : string = "state_core.use_request (16) / effect / json: " + string v117 + ""
    let v119 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v120 : bool = Fable.Core.RustInterop.emitRustExpr v118 v119
    let v138 : US34 =
        match v1 with
        | US42_1(v135) -> (* Error *)
            US34_1
        | US42_0(v121) -> (* Ok *)
            let v122 : (int32 -> ((US34 []) -> US34 option)) = Array.tryItem
            let v123 : ((US34 []) -> US34 option) = v122 v2
            let v124 : US34 option = v123 v121
            let v125 : (US34 -> US43) = method121()
            let v126 : US43 = US43_1
            let v127 : US43 = v124 |> Option.map v125 |> Option.defaultValue v126 
            match v127 with
            | US43_0(v128) -> (* Some *)
                match v128 with
                | US34_0(v129) -> (* Some *)
                    US34_0(v129)
                | _ ->
                    US34_1
            | _ ->
                US34_1
    match v138 with
    | US34_0(v139) -> (* Some *)
        let v140 : string = method45(v139)
        let v141 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v140 v141
        let v143 : string = "serde_json::from_str(&v142)"
        let v144 : Result<crate_model_near_nearblocks_Root, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v143
        let v145 : (serde_json_Error -> std_string_String) = method46()
        let v146 : string = "$0.map_err(|x| $1(x))"
        let v147 : Result<crate_model_near_nearblocks_Root, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v144, v145) v146
        let v148 : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) = method122()
        let v149 : Result<crate_model_near_nearblocks_Root, std_string_String> = method123(v147)
        let v150 : string = "v149.map(|x| v148(x))"
        let v151 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v150
        v151
    | _ ->
        match v39 with
        | US32_0(v152) -> (* Some *)
            match v152 with
            | US33_0(v153) -> (* Ok *)
                match v153 with
                | US34_0(v154) -> (* Some *)
                    let v155 : string = method45(v154)
                    let v156 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v155 v156
                    let v158 : string = "serde_json::from_str(&v157)"
                    let v159 : Result<crate_model_near_nearblocks_Root, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v158
                    let v160 : (serde_json_Error -> std_string_String) = method46()
                    let v161 : string = "$0.map_err(|x| $1(x))"
                    let v162 : Result<crate_model_near_nearblocks_Root, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v159, v160) v161
                    let v163 : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) = method122()
                    let v164 : Result<crate_model_near_nearblocks_Root, std_string_String> = method123(v162)
                    let v165 : string = "v164.map(|x| v163(x))"
                    let v166 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v165
                    v166
                | _ ->
                    let v167 : string = $"%A{struct (v138, v39)}"
                    let v168 : string = "state_core.use_request (17) / json Error / value: " + string v167 + ""
                    let v169 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                    let v170 : bool = Fable.Core.RustInterop.emitRustExpr v168 v169
                    let v171 : crate_model_near_nearblocks_Root option = None
                    let v172 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v171
                    v172
            | _ ->
                let v174 : string = $"%A{struct (v138, v39)}"
                let v175 : string = "state_core.use_request (17) / json Error / value: " + string v174 + ""
                let v176 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v177 : bool = Fable.Core.RustInterop.emitRustExpr v175 v176
                let v178 : crate_model_near_nearblocks_Root option = None
                let v179 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v178
                v179
        | _ ->
            let v181 : string = $"%A{struct (v138, v39)}"
            let v182 : string = "state_core.use_request (17) / json Error / value: " + string v181 + ""
            let v183 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v184 : bool = Fable.Core.RustInterop.emitRustExpr v182 v183
            let v185 : crate_model_near_nearblocks_Root option = None
            let v186 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v185
            v186
and closure98 (v0 : US29, v1 : US42) (v2 : int32) : (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_nearblocks_Root option, std_string_String>) =
    closure99(v0, v1, v2)
and method120 (v0 : US29, v1 : US42) : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_nearblocks_Root option, std_string_String>)) =
    closure98(v0, v1)
and closure91 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>, v2 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>>, v3 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) () : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) =
    let v4 : string = $"$0()"
    let v5 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v4
    let v6 : string = $"%A{v5}"
    let v7 : string = "state_core.use_requests (13) / result memo / requests: " + string v6 + ""
    let v8 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = $"$0()"
    let v11 : Result<(Heap4 option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v10
    let v12 : (Result<(Heap4 option []), std_string_String> -> US28) = method91()
    let v13 : US28 = US28_1
    let v14 : US28 = v11 |> Option.map v12 |> Option.defaultValue v13 
    let v35 : US29 =
        match v14 with
        | US28_1 -> (* None *)
            US29_1
        | US28_0(v15) -> (* Some *)
            let v16 : ((Heap4 option []) -> US31) = closure80()
            let v17 : (std_string_String -> US31) = closure81()
            let v18 : US31 = match v15 with Ok x -> v16 x | Error x -> v17 x
            let v31 : US30 =
                match v18 with
                | US31_1(v28) -> (* Error *)
                    US30_1(v28)
                | US31_0(v19) -> (* Ok *)
                    let v20 : string = "$0.to_vec()"
                    let v21 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v19 v20
                    let v22 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v23 : (Heap4 option -> US27) = closure82()
                    let v24 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v22
                    let v25 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v26 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v24 v25
                    US30_0(v26)
            US29_0(v31)
    let v36 : string = $"%A{v35}"
    let v37 : int64 = System.Convert.ToInt64 v36.Length
    let v38 : bool = v37 <= 400L
    let v60 : string =
        if v38 then
            v36
        else
            let v39 : float = float 400L
            let v40 : float = v39 / 2.0
            let v41 : (float -> float) = ceil
            let v42 : float = v41 v40
            let v43 : int64 = int64 v42
            let v44 : (float -> float) = floor
            let v45 : float = v44 v40
            let v46 : int64 = int64 v45
            let v47 : int64 = v43 - 1L
            let v48 : string = v36.[int 0L..int v47]
            let v49 : int64 = v37 - v46
            let v50 : int64 = v37 - 1L
            let v51 : string = v36.[int v49..int v50]
            let v52 : string = "..."
            let v53 : (string []) = [|v48; v52; v51|]
            let v54 : ((string []) -> string seq) = Seq.ofArray
            let v55 : string seq = v54 v53
            let v56 : string = method78()
            let v57 : (string -> (string seq -> string)) = String.concat
            let v58 : (string seq -> string) = v57 v56
            v58 v55
    let v61 : string = "state_core.use_request (14) / result_memo / state_data: " + string v60 + ""
    let v62 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v63 : bool = Fable.Core.RustInterop.emitRustExpr v61 v62
    let v64 : string = $"leptos::SignalGet::get(&$0)"
    let v65 : Result<(string option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v64
    let v66 : (Result<(string option []), std_string_String> -> US38) = method118()
    let v67 : US38 = US38_1
    let v68 : US38 = v65 |> Option.map v66 |> Option.defaultValue v67 
    let v76 : US39 =
        match v68 with
        | US38_1 -> (* None *)
            US39_1
        | US38_0(v69) -> (* Some *)
            let v70 : ((string option []) -> US40) = closure93()
            let v71 : (std_string_String -> US40) = closure94()
            let v72 : US40 = match v69 with Ok x -> v70 x | Error x -> v71 x
            US39_0(v72)
    let v94 : US41 =
        match v76 with
        | US39_1 -> (* None *)
            US41_1
        | US39_0(v77) -> (* Some *)
            let v90 : US42 =
                match v77 with
                | US40_1(v87) -> (* Error *)
                    US42_1(v87)
                | US40_0(v78) -> (* Ok *)
                    let v79 : string = "$0.to_vec()"
                    let v80 : Vec<string option> = Fable.Core.RustInterop.emitRustExpr v78 v79
                    let v81 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v82 : (string option -> US34) = closure95()
                    let v83 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr struct (v80, v82) v81
                    let v84 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v85 : (US34 []) = Fable.Core.RustInterop.emitRustExpr v83 v84
                    US42_0(v85)
            US41_0(v90)
    let v95 : (US34 []) = [||]
    let v99 : US42 =
        match v94 with
        | US41_1 -> (* None *)
            US42_0(v95)
        | US41_0(v96) -> (* Some *)
            v96
    match v99 with
    | US42_1(v106) -> (* Error *)
        ()
    | US42_0(v100) -> (* Ok *)
        let v101 : string = "$0.to_vec()"
        let v102 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr v100 v101
        let v103 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v104 : (US34 -> unit) = closure97(v3)
        let v105 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr struct (v102, v104) v103
        ()
    let v107 : string = "$0.to_vec()"
    let v108 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v5 v107
    let v109 : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_nearblocks_Root option, std_string_String>)) = method120(v35, v99)
    let v110 : Vec<struct (bool * string * bool * US25 * string)> = method106(v108)
    let v111 : string = "v110.iter().enumerate().map(|(i, x)| v109(i.try_into().unwrap())(x.clone())).collect()"
    let v112 : Vec<Result<crate_model_near_nearblocks_Root option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v111
    let v113 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v114 : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v112 v113
    let v115 : string = $"%A{v114}"
    let v116 : string = "state_core.use_requests (18) / result_func func0 / result: " + string v115 + ""
    let v117 : int32 = v116.Length
    let v118 : bool = v117 <= 200
    let v121 : string =
        if v118 then
            v116
        else
            let v119 : string = v116.[int 0..int 199]
            let v120 : string = v119 + "..."
            v120
    let v122 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v123 : bool = Fable.Core.RustInterop.emitRustExpr v121 v122
    v114
and closure103 () (v0 : Result<Vec<Heap4 option>, std_string_String>) : US44 =
    US44_0(v0)
and method124 () : (Result<Vec<Heap4 option>, std_string_String> -> US44) =
    closure103()
and closure104 () (v0 : Vec<Heap4 option>) : US45 =
    US45_0(v0)
and closure105 () (v0 : std_string_String) : US45 =
    US45_1(v0)
and closure110 () (v0 : crate_model_near_nearblocks_Action) : struct (std_string_String * std_string_String option) =
    let v1 : string = "$0.action"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.method"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3
    struct (v2, v4)
and method126 (v0 : (struct (std_string_String * std_string_String option) [])) : (struct (std_string_String * std_string_String option) []) =
    v0
and method127 (v0 : (std_string_String [])) : (std_string_String []) =
    v0
and closure109 () (v0 : crate_model_near_nearblocks_Txn) : struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.receipt_id"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.predecessor_account_id"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.receiver_account_id"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    let v7 : string = "$0.transaction_hash"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    let v9 : string = "$0.included_in_block_hash"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v9
    let v11 : string = "$0.block_timestamp"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v11
    let v13 : string = "$0.block"
    let v14 : crate_model_near_nearblocks_Block = Fable.Core.RustInterop.emitRustExpr v0 v13
    let v15 : string = "$0.block_height"
    let v16 : uint32 = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.actions"
    let v18 : Vec<crate_model_near_nearblocks_Action> = Fable.Core.RustInterop.emitRustExpr v0 v17
    let v19 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v20 : (crate_model_near_nearblocks_Action -> struct (std_string_String * std_string_String option)) = closure110()
    let v21 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (struct (std_string_String * std_string_String option) []) = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (struct (std_string_String * std_string_String option) []) = method126(v23)
    let v25 : string = "$0.actions_agg"
    let v26 : crate_model_near_nearblocks_ActionsAgg = Fable.Core.RustInterop.emitRustExpr v0 v25
    let v27 : string = "$0.deposit"
    let v28 : float = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "$0.outcomes"
    let v30 : crate_model_near_nearblocks_Outcomes = Fable.Core.RustInterop.emitRustExpr v0 v29
    let v31 : string = "$0.status"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "$0.outcomes_agg"
    let v34 : crate_model_near_nearblocks_OutcomesAgg = Fable.Core.RustInterop.emitRustExpr v0 v33
    let v35 : string = "$0.transaction_fee"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "$0.logs"
    let v38 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v37
    let v39 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v40 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : (std_string_String []) = method127(v40)
    struct (v24, v28, v16, v12, v10, v41, v32, v36, v4, v2, v6, v8)
and method128 (v0 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])) : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) =
    v0
and closure108 () (v0 : crate_model_near_nearblocks_Root) : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) =
    let v1 : string = "$0.txns"
    let v2 : Vec<crate_model_near_nearblocks_Txn> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v4 : (crate_model_near_nearblocks_Txn -> struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)) = closure109()
    let v5 : Vec<struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = method128(v7)
    v8
and closure107 () (v0 : crate_model_near_nearblocks_Root option) : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option =
    let v1 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])) = closure108()
    let v2 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option = v0 |> Option.map v1 
    v2
and method125 () : (crate_model_near_nearblocks_Root option -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option) =
    closure107()
and method129 (v0 : Result<crate_model_near_nearblocks_Root option, std_string_String>) : Result<crate_model_near_nearblocks_Root option, std_string_String> =
    v0
and closure106 () (v0 : Result<crate_model_near_nearblocks_Root option, std_string_String>) : Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> =
    let v1 : (crate_model_near_nearblocks_Root option -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option) = method125()
    let v2 : Result<crate_model_near_nearblocks_Root option, std_string_String> = method129(v0)
    let v3 : string = "v2.map(|x| v1(x))"
    let v4 : Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3
    v4
and closure102 (v0 : leptos_Resource<US2, rexie_Rexie>, v1 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>>, v2 : leptos_Memo<(Result<crate_model_near_nearblocks_Root option, std_string_String> [])>) () : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> []) =
    let v3 : string = $"leptos::Resource::loading(&$0)"
    let v4 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = $"leptos::Resource::loading(&$0)"
    let v8 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v1 v7
    let v9 : string = $"leptos::SignalGet::get(&$0)"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = $"leptos::SignalGet::get(&$0)"
    let v12 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v11
    let v13 : (rexie_Rexie -> US5) = method17()
    let v14 : US5 = US5_1
    let v15 : US5 = v12 |> Option.map v13 |> Option.defaultValue v14 
    let v16 : string = $"leptos::SignalGet::get(&$0)"
    let v17 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v16
    let v18 : (Result<Vec<Heap4 option>, std_string_String> -> US44) = method124()
    let v19 : US44 = US44_1
    let v20 : US44 = v17 |> Option.map v18 |> Option.defaultValue v19 
    let v39 : US29 =
        match v20 with
        | US44_1 -> (* None *)
            US29_1
        | US44_0(v21) -> (* Some *)
            let v22 : (Vec<Heap4 option> -> US45) = closure104()
            let v23 : (std_string_String -> US45) = closure105()
            let v24 : US45 = match v21 with Ok x -> v22 x | Error x -> v23 x
            let v35 : US30 =
                match v24 with
                | US45_1(v32) -> (* Error *)
                    US30_1(v32)
                | US45_0(v25) -> (* Ok *)
                    let v26 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v27 : (Heap4 option -> US27) = closure82()
                    let v28 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v25, v27) v26
                    let v29 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v30 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v28 v29
                    US30_0(v30)
            US29_0(v35)
    let v40 : string = $"%A{v15}"
    let v41 : int64 = System.Convert.ToInt64 v40.Length
    let v42 : bool = v41 <= 400L
    let v64 : string =
        if v42 then
            v40
        else
            let v43 : float = float 400L
            let v44 : float = v43 / 2.0
            let v45 : (float -> float) = ceil
            let v46 : float = v45 v44
            let v47 : int64 = int64 v46
            let v48 : (float -> float) = floor
            let v49 : float = v48 v44
            let v50 : int64 = int64 v49
            let v51 : int64 = v47 - 1L
            let v52 : string = v40.[int 0L..int v51]
            let v53 : int64 = v41 - v50
            let v54 : int64 = v41 - 1L
            let v55 : string = v40.[int v53..int v54]
            let v56 : string = "..."
            let v57 : (string []) = [|v52; v56; v55|]
            let v58 : ((string []) -> string seq) = Seq.ofArray
            let v59 : string seq = v58 v57
            let v60 : string = method78()
            let v61 : (string -> (string seq -> string)) = String.concat
            let v62 : (string seq -> string) = v61 v60
            v62 v59
    let v65 : string = $"%A{v39}"
    let v66 : int64 = System.Convert.ToInt64 v65.Length
    let v67 : bool = v66 <= 400L
    let v89 : string =
        if v67 then
            v65
        else
            let v68 : float = float 400L
            let v69 : float = v68 / 2.0
            let v70 : (float -> float) = ceil
            let v71 : float = v70 v69
            let v72 : int64 = int64 v71
            let v73 : (float -> float) = floor
            let v74 : float = v73 v69
            let v75 : int64 = int64 v74
            let v76 : int64 = v72 - 1L
            let v77 : string = v65.[int 0L..int v76]
            let v78 : int64 = v66 - v75
            let v79 : int64 = v66 - 1L
            let v80 : string = v65.[int v78..int v79]
            let v81 : string = "..."
            let v82 : (string []) = [|v77; v81; v80|]
            let v83 : ((string []) -> string seq) = Seq.ofArray
            let v84 : string seq = v83 v82
            let v85 : string = method78()
            let v86 : (string -> (string seq -> string)) = String.concat
            let v87 : (string seq -> string) = v86 v85
            v87 v84
    let v90 : string = "state_core.use_request (19) / result move / database: " + string v64 + " / database_loading: " + string v6 + " / state_data: " + string v89 + " / state_data_loading: " + string v10 + ""
    let v91 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr v90 v91
    let v93 : string = $"$0()"
    let v94 : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v2 v93
    let v95 : string = "$0.to_vec()"
    let v96 : Vec<Result<crate_model_near_nearblocks_Root option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v94 v95
    let v97 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v98 : (Result<crate_model_near_nearblocks_Root option, std_string_String> -> Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>) = closure106()
    let v99 : Vec<Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v96, v98) v97
    let v100 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v101 : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v99 v100
    let v102 : string = $"%A{v101}"
    let v103 : string = "state_core.use_requests (20) / result func0 / result: " + string v102 + ""
    let v104 : int32 = v103.Length
    let v105 : bool = v104 <= 200
    let v108 : string =
        if v105 then
            v103
        else
            let v106 : string = v103.[int 0..int 199]
            let v107 : string = v106 + "..."
            v107
    let v109 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109
    v101
and closure113 () (v0 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option) : US46 =
    US46_0(v0)
and closure114 () (v0 : std_string_String) : US46 =
    US46_1(v0)
and closure112 () (v0 : Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>) : US46 =
    let v1 : ((struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option -> US46) = closure113()
    let v2 : (std_string_String -> US46) = closure114()
    let v3 : US46 = match v0 with Ok x -> v1 x | Error x -> v2 x
    v3
and closure116 () (v0 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])) : US48 =
    US48_0(v0)
and method130 () : ((struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) -> US48) =
    closure116()
and closure115 () (v0 : US46) : US47 =
    match v0 with
    | US46_1(v6) -> (* Error *)
        US47_1(v6)
    | US46_0(v1) -> (* Ok *)
        let v2 : ((struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) -> US48) = method130()
        let v3 : US48 = US48_1
        let v4 : US48 = v1 |> Option.map v2 |> Option.defaultValue v3 
        US47_0(v4)
and closure117 () (v0 : US47) : bool =
    match v0 with
    | US47_0(v1) -> (* Ok *)
        match v1 with
        | US48_1 -> (* None *)
            true
        | _ ->
            false
    | _ ->
        false
and method131 () : (US47 -> bool) =
    closure117()
and method132 (v0 : Vec<US47>) : Vec<US47> =
    v0
and closure120 () (v0 : (unativeint * struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String))) : struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) =
    let (a, b) = v0
    let v1 : unativeint = a
    let struct (v2 : (struct (std_string_String * std_string_String option) []), v3 : float, v4 : uint32, v5 : std_string_String, v6 : std_string_String, v7 : (std_string_String []), v8 : bool, v9 : float, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String) = b
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
and closure121 (v0 : string) struct (v1 : unativeint, v2 : (struct (std_string_String * std_string_String option) []), v3 : float, v4 : uint32, v5 : std_string_String, v6 : std_string_String, v7 : (std_string_String []), v8 : bool, v9 : float, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String) : struct (string * unativeint * Heap5) =
    let v14 : Heap5 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13} : Heap5
    struct (v0, v1, v14)
and closure119 (v0 : (string []), v1 : int32) (v2 : US47) : US51 =
    let v3 : string = v0.[int v1]
    match v2 with
    | US47_1(v25) -> (* Error *)
        US51_1(v25)
    | US47_0(v4) -> (* Ok *)
        let v23 : US52 =
            match v4 with
            | US48_1 -> (* None *)
                US52_1
            | US48_0(v5) -> (* Some *)
                let v6 : string = "$0.to_vec()"
                let v7 : Vec<struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr v5 v6
                let v8 : string = "v7.into_iter().enumerate().map(std::rc::Rc::new).collect()"
                let v9 : Vec<(unativeint * struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String))> = Fable.Core.RustInterop.emitRustExpr () v8
                let v10 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                let v11 : ((unativeint * struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)) -> struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)) = closure120()
                let v12 : Vec<struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
                let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
                let v14 : (struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v12 v13
                let v15 : string = "$0.to_vec()"
                let v16 : Vec<struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr v14 v15
                let v17 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                let v18 : (struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) -> struct (string * unativeint * Heap5)) = closure121(v3)
                let v19 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr struct (v16, v18) v17
                US52_0(v19)
        US51_0(v23)
and closure118 (v0 : (string [])) (v1 : int32) : (US47 -> US51) =
    closure119(v0, v1)
and method133 (v0 : (string [])) : (int32 -> (US47 -> US51)) =
    closure118(v0)
and method134 (v0 : Vec<US47>) : Vec<US47> =
    v0
and closure122 () (v0 : US51) : US53 =
    match v0 with
    | US51_1(v8) -> (* Error *)
        US53_1(v8)
    | US51_0(v1) -> (* Ok *)
        let v6 : Vec<struct (string * unativeint * Heap5)> option =
            match v1 with
            | US52_1 -> (* None *)
                let v4 : Vec<struct (string * unativeint * Heap5)> option = None
                v4
            | US52_0(v2) -> (* Some *)
                let v3 : Vec<struct (string * unativeint * Heap5)> option = Some v2 
                v3
        US53_0(v6)
and closure123 () (v0 : US53) : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> =
    match v0 with
    | US53_1(v3) -> (* Error *)
        let v4 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = Error v3
        v4
    | US53_0(v1) -> (* Ok *)
        let v2 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = Ok v1
        v2
and method135 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure124 () (v0 : Vec<struct (string * unativeint * Heap5)> option) : US53 =
    US53_0(v0)
and closure125 () (v0 : std_string_String) : US53 =
    US53_1(v0)
and closure126 () (v0 : Vec<struct (string * unativeint * Heap5)>) : US52 =
    US52_0(v0)
and method136 () : (Vec<struct (string * unativeint * Heap5)> -> US52) =
    closure126()
and method137 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and method138 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and method139 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure127 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : std_string_String =
    let v3 : std_string_String = v2.l3
    v3
and method140 () : (struct (string * unativeint * Heap5) -> std_string_String) =
    closure127()
and method141 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure111 (v0 : leptos_Memo<(string [])>, v1 : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])>) () : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> =
    let v2 : string = $"$0()"
    let v3 : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v7 : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> -> US46) = closure112()
    let v8 : Vec<US46> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v10 : (US46 -> US47) = closure115()
    let v11 : Vec<US47> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9
    let v12 : string = $"%A{v11}"
    let v13 : int64 = System.Convert.ToInt64 v12.Length
    let v14 : bool = v13 <= 400L
    let v36 : string =
        if v14 then
            v12
        else
            let v15 : float = float 400L
            let v16 : float = v15 / 2.0
            let v17 : (float -> float) = ceil
            let v18 : float = v17 v16
            let v19 : int64 = int64 v18
            let v20 : (float -> float) = floor
            let v21 : float = v20 v16
            let v22 : int64 = int64 v21
            let v23 : int64 = v19 - 1L
            let v24 : string = v12.[int 0L..int v23]
            let v25 : int64 = v13 - v22
            let v26 : int64 = v13 - 1L
            let v27 : string = v12.[int v25..int v26]
            let v28 : string = "..."
            let v29 : (string []) = [|v24; v28; v27|]
            let v30 : ((string []) -> string seq) = Seq.ofArray
            let v31 : string seq = v30 v29
            let v32 : string = method78()
            let v33 : (string -> (string seq -> string)) = String.concat
            let v34 : (string seq -> string) = v33 v32
            v34 v31
    let v37 : string = "transactions.render (8) / txns move / root: " + string v36 + ""
    let v38 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : (US47 -> bool) = method131()
    let v41 : Vec<US47> = method132(v11)
    let v42 : string = "v41.into_iter().filter(|x| v40(x.clone().clone())).collect()"
    let v43 : Vec<US47> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v45 : (US47 []) = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : int32 = v45.Length
    let v47 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v48 : (US47 []) = Fable.Core.RustInterop.emitRustExpr v11 v47
    let v49 : int32 = v48.Length
    let v50 : bool = v46 = v49
    let v142 : US49 =
        if v50 then
            let v51 : US50 = US50_1
            US49_0(v51)
        else
            let v53 : string = $"$0()"
            let v54 : (string []) = Fable.Core.RustInterop.emitRustExpr v0 v53
            let v55 : (int32 -> (US47 -> US51)) = method133(v54)
            let v56 : Vec<US47> = method134(v11)
            let v57 : string = "v56.iter().enumerate().map(|(i, x)| v55(i.try_into().unwrap())(x.clone())).collect()"
            let v58 : Vec<US51> = Fable.Core.RustInterop.emitRustExpr () v57
            let v59 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v60 : (US51 -> US53) = closure122()
            let v61 : Vec<US53> = Fable.Core.RustInterop.emitRustExpr struct (v58, v60) v59
            let v62 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v63 : (US53 -> Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String>) = closure123()
            let v64 : Vec<Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v61, v63) v62
            let v65 : (struct (string * unativeint * Heap5) []) = [||]
            let v66 : string = "$0.to_vec()"
            let v67 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v69 : (Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v64 v68
            let v70 : int32 = v69.Length
            let v71 : US54 = US54_0(v67)
            let v72 : Mut4 = {l0 = 0; l1 = v71} : Mut4
            while method135(v70, v72) do
                let v74 : int32 = v72.l0
                let v75 : US54 = v72.l1
                let v76 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = v69.[int v74]
                let v77 : (Vec<struct (string * unativeint * Heap5)> option -> US53) = closure124()
                let v78 : (std_string_String -> US53) = closure125()
                let v79 : US53 = match v76 with Ok x -> v77 x | Error x -> v78 x
                let v88 : US51 =
                    match v79 with
                    | US53_1(v85) -> (* Error *)
                        US51_1(v85)
                    | US53_0(v80) -> (* Ok *)
                        let v81 : (Vec<struct (string * unativeint * Heap5)> -> US52) = method136()
                        let v82 : US52 = US52_1
                        let v83 : US52 = v80 |> Option.map v81 |> Option.defaultValue v82 
                        US51_0(v83)
                let v107 : US54 =
                    match v75 with
                    | US54_0(v89) -> (* Ok *)
                        match v88 with
                        | US51_1(v100) -> (* Error *)
                            US54_1(v100)
                        | US51_0(v90) -> (* Ok *)
                            match v90 with
                            | US52_0(v91) -> (* Some *)
                                let v92 : Vec<struct (string * unativeint * Heap5)> = method137(v91)
                                let v93 : Vec<struct (string * unativeint * Heap5)> = method138(v89)
                                let v94 : string = "let mut v93 = v93"
                                Fable.Core.RustInterop.emitRustExpr () v94
                                let v95 : string = "v93.extend(v92)"
                                Fable.Core.RustInterop.emitRustExpr () v95
                                let v96 : string = "v93"
                                let v97 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v96
                                US54_0(v97)
                            | _ ->
                                v75
                    | _ ->
                        match v88 with
                        | US51_1(v104) -> (* Error *)
                            US54_1(v104)
                        | _ ->
                            v75
                let v108 : int32 = v74 + 1
                v72.l0 <- v108
                v72.l1 <- v107
                ()
            let v109 : US54 = v72.l1
            let v121 : US54 =
                match v109 with
                | US54_1(v118) -> (* Error *)
                    US54_1(v118)
                | US54_0(v110) -> (* Ok *)
                    let v111 : Vec<struct (string * unativeint * Heap5)> = method139(v110)
                    let v112 : (struct (string * unativeint * Heap5) -> std_string_String) = method140()
                    let v113 : string = "let mut v111 = v111"
                    Fable.Core.RustInterop.emitRustExpr () v113
                    let v114 : string = "v111.sort_by_key(|x| v112(x.clone()))"
                    Fable.Core.RustInterop.emitRustExpr () v114
                    let v115 : string = "v111"
                    let v116 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v115
                    US54_0(v116)
            let v134 : US55 =
                match v121 with
                | US54_1(v131) -> (* Error *)
                    US55_1(v131)
                | US54_0(v122) -> (* Ok *)
                    let v123 : Vec<struct (string * unativeint * Heap5)> = method141(v122)
                    let v124 : string = "let mut v123 = v123"
                    Fable.Core.RustInterop.emitRustExpr () v124
                    let v125 : string = "v123.reverse()"
                    Fable.Core.RustInterop.emitRustExpr () v125
                    let v126 : string = "v123"
                    let v127 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v126
                    let v128 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v129 : (struct (string * unativeint * Heap5) []) = Fable.Core.RustInterop.emitRustExpr v127 v128
                    US55_0(v129)
            match v134 with
            | US55_1(v138) -> (* Error *)
                US49_1(v138)
            | US55_0(v135) -> (* Ok *)
                let v136 : US50 = US50_0(v135)
                US49_0(v136)
    let v153 : US56 =
        match v142 with
        | US49_1(v150) -> (* Error *)
            US56_1(v150)
        | US49_0(v143) -> (* Ok *)
            let v148 : (struct (string * unativeint * Heap5) []) option =
                match v143 with
                | US50_1 -> (* None *)
                    let v146 : (struct (string * unativeint * Heap5) []) option = None
                    v146
                | US50_0(v144) -> (* Some *)
                    let v145 : (struct (string * unativeint * Heap5) []) option = Some v144 
                    v145
            US56_0(v148)
    let v159 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> =
        match v153 with
        | US56_1(v156) -> (* Error *)
            let v157 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Error v156
            v157
        | US56_0(v154) -> (* Ok *)
            let v155 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Ok v154
            v155
    let v160 : string = $"%A{v159}"
    let v161 : string = "use_transactions.render (9) / txns create_memo / result: " + string v160 + " / loading: " + string v50 + ""
    let v162 : int32 = v161.Length
    let v163 : bool = v162 <= 200
    let v166 : string =
        if v163 then
            v161
        else
            let v164 : string = v161.[int 0..int 199]
            let v165 : string = v164 + "..."
            v165
    let v167 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v168 : bool = Fable.Core.RustInterop.emitRustExpr v166 v167
    v159
and closure129 () (v0 : (struct (string * unativeint * Heap5) []) option) : US56 =
    US56_0(v0)
and closure130 () (v0 : std_string_String) : US56 =
    US56_1(v0)
and closure131 () (v0 : (struct (string * unativeint * Heap5) [])) : US50 =
    US50_0(v0)
and method142 () : ((struct (string * unativeint * Heap5) []) -> US50) =
    closure131()
and method143 () : string =
    let v0 : string = "2.0"
    v0
and method144 () : string =
    let v0 : string = "dontcare"
    v0
and method145 () : string =
    let v0 : string = "EXPERIMENTAL_tx_status"
    v0
and method146 () : string =
    let v0 : string = "bowen"
    v0
and closure133 () (v0 : serde_json_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method147 () : (serde_json_Error -> std_string_String) =
    closure133()
and method148 () : (std_string_String -> string) =
    closure59()
and method149 (v0 : Result<std_string_String, std_string_String>) : Result<std_string_String, std_string_String> =
    v0
and closure134 () (v0 : string) : struct (bool * string * bool * US25 * string) =
    let v1 : US25 = US25_1
    let v2 : string = "https://rpc.mainnet.near.org"
    struct (false, v0, true, v1, v2)
and method150 () : (string -> struct (bool * string * bool * US25 * string)) =
    closure134()
and method151 (v0 : Result<string, std_string_String>) : Result<string, std_string_String> =
    v0
and closure132 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : Result<struct (bool * string * bool * US25 * string), std_string_String> =
    let v3 : string = method143()
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = method144()
    let v9 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = method145()
    let v14 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : std_string_String = v2.l11
    let v19 : string = method146()
    let v20 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (std_string_String []) = [|v18; v23|]
    let v25 : string = "$0.to_vec()"
    let v26 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "crate::model::near::rpc::RpcInput { jsonrpc: v7, id: v12, method: v17, params: v26 }"
    let v28 : crate_model_near_rpc_RpcInput = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "serde_json::to_string(&v28)"
    let v30 : Result<std_string_String, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : (serde_json_Error -> std_string_String) = method147()
    let v32 : string = "$0.map_err(|x| $1(x))"
    let v33 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v30, v31) v32
    let v34 : (std_string_String -> string) = method148()
    let v35 : Result<std_string_String, std_string_String> = method149(v33)
    let v36 : string = "v35.map(|x| v34(x))"
    let v37 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : (string -> struct (bool * string * bool * US25 * string)) = method150()
    let v39 : Result<string, std_string_String> = method151(v37)
    let v40 : string = "v39.map(|x| v38(x))"
    let v41 : Result<struct (bool * string * bool * US25 * string), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v40
    v41
and closure128 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure129()
    let v4 : (std_string_String -> US56) = closure130()
    let v5 : US56 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v14 : US49 =
        match v5 with
        | US56_1(v11) -> (* Error *)
            US49_1(v11)
        | US56_0(v6) -> (* Ok *)
            let v7 : ((struct (string * unativeint * Heap5) []) -> US50) = method142()
            let v8 : US50 = US50_1
            let v9 : US50 = v6 |> Option.map v7 |> Option.defaultValue v8 
            US49_0(v9)
    let v36 : US57 =
        match v14 with
        | US49_1(v33) -> (* Error *)
            US57_1(v33)
        | US49_0(v15) -> (* Ok *)
            match v15 with
            | US50_0(v16) -> (* Some *)
                let v17 : string = "$0.to_vec()"
                let v18 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v16 v17
                let v19 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                let v20 : (struct (string * unativeint * Heap5) -> Result<struct (bool * string * bool * US25 * string), std_string_String>) = closure132()
                let v21 : Vec<Result<struct (bool * string * bool * US25 * string), std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19
                let v22 : string = "v21.into_iter().collect()"
                let v23 : Result<Vec<struct (bool * string * bool * US25 * string)>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v22
                let v24 : string = "$0?"
                let v25 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v23 v24
                let v26 : string = "fable_library_rust::NativeArray_::array_from($0)"
                let v27 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v25 v26
                let v28 : US58 = US58_0(v27)
                US57_0(v28)
            | _ ->
                let v30 : US58 = US58_1
                US57_0(v30)
    let v47 : US59 =
        match v36 with
        | US57_1(v44) -> (* Error *)
            US59_1(v44)
        | US57_0(v37) -> (* Ok *)
            let v42 : (struct (bool * string * bool * US25 * string) []) option =
                match v37 with
                | US58_1 -> (* None *)
                    let v40 : (struct (bool * string * bool * US25 * string) []) option = None
                    v40
                | US58_0(v38) -> (* Some *)
                    let v39 : (struct (bool * string * bool * US25 * string) []) option = Some v38 
                    v39
            US59_0(v42)
    let v53 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> =
        match v47 with
        | US59_1(v50) -> (* Error *)
            let v51 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> = Error v50
            v51
        | US59_0(v48) -> (* Ok *)
            let v49 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> = Ok v48
            v49
    let v54 : string = $"%A{v53}"
    let v55 : string = "use_transactions.render (10) / rpc_requests create_memo / result: " + string v54 + ""
    let v56 : int32 = v55.Length
    let v57 : bool = v56 <= 200
    let v60 : string =
        if v57 then
            v55
        else
            let v58 : string = v55.[int 0..int 199]
            let v59 : string = v58 + "..."
            v59
    let v61 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v62 : bool = Fable.Core.RustInterop.emitRustExpr v60 v61
    v53
and closure136 () (v0 : (struct (bool * string * bool * US25 * string) []) option) : US59 =
    US59_0(v0)
and closure137 () (v0 : std_string_String) : US59 =
    US59_1(v0)
and closure138 () (v0 : (struct (bool * string * bool * US25 * string) [])) : US58 =
    US58_0(v0)
and method152 () : ((struct (bool * string * bool * US25 * string) []) -> US58) =
    closure138()
and closure135 (v0 : leptos_Memo<Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>>) () : (struct (bool * string * bool * US25 * string) []) =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : ((struct (bool * string * bool * US25 * string) []) option -> US59) = closure136()
    let v4 : (std_string_String -> US59) = closure137()
    let v5 : US59 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v14 : US57 =
        match v5 with
        | US59_1(v11) -> (* Error *)
            US57_1(v11)
        | US59_0(v6) -> (* Ok *)
            let v7 : ((struct (bool * string * bool * US25 * string) []) -> US58) = method152()
            let v8 : US58 = US58_1
            let v9 : US58 = v6 |> Option.map v7 |> Option.defaultValue v8 
            US57_0(v9)
    let v20 : (struct (bool * string * bool * US25 * string) []) =
        match v14 with
        | US57_0(v15) -> (* Ok *)
            match v15 with
            | US58_0(v16) -> (* Some *)
                v16
            | _ ->
                [||]
        | _ ->
            [||]
    let v21 : string = $"%A{v20}"
    let v22 : string = "use_transactions.render (11) / rpc_requests' create_memo / result: " + string v21 + ""
    let v23 : int32 = v22.Length
    let v24 : bool = v23 <= 200
    let v27 : string =
        if v24 then
            v22
        else
            let v25 : string = v22.[int 0..int 199]
            let v26 : string = v25 + "..."
            v26
    let v28 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v27 v28
    v20
and closure142 () (v0 : crate_model_near_rpc_RpcResponse) : crate_model_near_rpc_RpcResponse option =
    let v1 : crate_model_near_rpc_RpcResponse option = Some v0 
    v1
and method154 () : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) =
    closure142()
and method155 (v0 : Result<crate_model_near_rpc_RpcResponse, std_string_String>) : Result<crate_model_near_rpc_RpcResponse, std_string_String> =
    v0
and closure141 (v0 : US29, v1 : US42, v2 : int32) struct (v3 : bool, v4 : string, v5 : bool, v6 : US25, v7 : string) : Result<crate_model_near_rpc_RpcResponse option, std_string_String> =
    let v39 : US32 =
        match v0 with
        | US29_1 -> (* None *)
            US32_1
        | US29_0(v8) -> (* Some *)
            let v35 : US33 =
                match v8 with
                | US30_1(v32) -> (* Error *)
                    US33_1(v32)
                | US30_0(v9) -> (* Ok *)
                    let v10 : (int32 -> ((US27 []) -> US27 option)) = Array.tryItem
                    let v11 : ((US27 []) -> US27 option) = v10 v2
                    let v12 : US27 option = v11 v9
                    let v13 : (US27 -> US35) = method95()
                    let v14 : US35 = US35_1
                    let v15 : US35 = v12 |> Option.map v13 |> Option.defaultValue v14 
                    let v22 : US27 =
                        match v15 with
                        | US35_0(v16) -> (* Some *)
                            match v16 with
                            | US27_0(v17) -> (* Some *)
                                US27_0(v17)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v30 : US34 =
                        match v22 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v23) -> (* Some *)
                            let v24 : std_string_String = v23.l0
                            let v25 : string = "fable_library_rust::String_::fromString($0)"
                            let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25
                            US34_0(v26)
                    US33_0(v30)
            US32_0(v35)
    let v40 : string = $"%A{struct (v3, v4, v5, v6, v7)}"
    let v41 : int64 = System.Convert.ToInt64 v40.Length
    let v42 : bool = v41 <= 400L
    let v64 : string =
        if v42 then
            v40
        else
            let v43 : float = float 400L
            let v44 : float = v43 / 2.0
            let v45 : (float -> float) = ceil
            let v46 : float = v45 v44
            let v47 : int64 = int64 v46
            let v48 : (float -> float) = floor
            let v49 : float = v48 v44
            let v50 : int64 = int64 v49
            let v51 : int64 = v47 - 1L
            let v52 : string = v40.[int 0L..int v51]
            let v53 : int64 = v41 - v50
            let v54 : int64 = v41 - 1L
            let v55 : string = v40.[int v53..int v54]
            let v56 : string = "..."
            let v57 : (string []) = [|v52; v56; v55|]
            let v58 : ((string []) -> string seq) = Seq.ofArray
            let v59 : string seq = v58 v57
            let v60 : string = method78()
            let v61 : (string -> (string seq -> string)) = String.concat
            let v62 : (string seq -> string) = v61 v60
            v62 v59
    let v65 : string = $"%A{v39}"
    let v66 : int64 = System.Convert.ToInt64 v65.Length
    let v67 : bool = v66 <= 400L
    let v89 : string =
        if v67 then
            v65
        else
            let v68 : float = float 400L
            let v69 : float = v68 / 2.0
            let v70 : (float -> float) = ceil
            let v71 : float = v70 v69
            let v72 : int64 = int64 v71
            let v73 : (float -> float) = floor
            let v74 : float = v73 v69
            let v75 : int64 = int64 v74
            let v76 : int64 = v72 - 1L
            let v77 : string = v65.[int 0L..int v76]
            let v78 : int64 = v66 - v75
            let v79 : int64 = v66 - 1L
            let v80 : string = v65.[int v78..int v79]
            let v81 : string = "..."
            let v82 : (string []) = [|v77; v81; v80|]
            let v83 : ((string []) -> string seq) = Seq.ofArray
            let v84 : string seq = v83 v82
            let v85 : string = method78()
            let v86 : (string -> (string seq -> string)) = String.concat
            let v87 : (string seq -> string) = v86 v85
            v87 v84
    let v90 : string = "state_core.use_request (15) / result memo / request: " + string v64 + " / state_data: " + string v89 + ""
    let v91 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr v90 v91
    let v93 : string = $"%A{v1}"
    let v94 : int64 = System.Convert.ToInt64 v93.Length
    let v95 : bool = v94 <= 400L
    let v117 : string =
        if v95 then
            v93
        else
            let v96 : float = float 400L
            let v97 : float = v96 / 2.0
            let v98 : (float -> float) = ceil
            let v99 : float = v98 v97
            let v100 : int64 = int64 v99
            let v101 : (float -> float) = floor
            let v102 : float = v101 v97
            let v103 : int64 = int64 v102
            let v104 : int64 = v100 - 1L
            let v105 : string = v93.[int 0L..int v104]
            let v106 : int64 = v94 - v103
            let v107 : int64 = v94 - 1L
            let v108 : string = v93.[int v106..int v107]
            let v109 : string = "..."
            let v110 : (string []) = [|v105; v109; v108|]
            let v111 : ((string []) -> string seq) = Seq.ofArray
            let v112 : string seq = v111 v110
            let v113 : string = method78()
            let v114 : (string -> (string seq -> string)) = String.concat
            let v115 : (string seq -> string) = v114 v113
            v115 v112
    let v118 : string = "state_core.use_request (16) / effect / json: " + string v117 + ""
    let v119 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v120 : bool = Fable.Core.RustInterop.emitRustExpr v118 v119
    let v138 : US34 =
        match v1 with
        | US42_1(v135) -> (* Error *)
            US34_1
        | US42_0(v121) -> (* Ok *)
            let v122 : (int32 -> ((US34 []) -> US34 option)) = Array.tryItem
            let v123 : ((US34 []) -> US34 option) = v122 v2
            let v124 : US34 option = v123 v121
            let v125 : (US34 -> US43) = method121()
            let v126 : US43 = US43_1
            let v127 : US43 = v124 |> Option.map v125 |> Option.defaultValue v126 
            match v127 with
            | US43_0(v128) -> (* Some *)
                match v128 with
                | US34_0(v129) -> (* Some *)
                    US34_0(v129)
                | _ ->
                    US34_1
            | _ ->
                US34_1
    match v138 with
    | US34_0(v139) -> (* Some *)
        let v140 : string = method45(v139)
        let v141 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v140 v141
        let v143 : string = "serde_json::from_str(&v142)"
        let v144 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v143
        let v145 : (serde_json_Error -> std_string_String) = method46()
        let v146 : string = "$0.map_err(|x| $1(x))"
        let v147 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v144, v145) v146
        let v148 : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) = method154()
        let v149 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = method155(v147)
        let v150 : string = "v149.map(|x| v148(x))"
        let v151 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v150
        v151
    | _ ->
        match v39 with
        | US32_0(v152) -> (* Some *)
            match v152 with
            | US33_0(v153) -> (* Ok *)
                match v153 with
                | US34_0(v154) -> (* Some *)
                    let v155 : string = method45(v154)
                    let v156 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v155 v156
                    let v158 : string = "serde_json::from_str(&v157)"
                    let v159 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v158
                    let v160 : (serde_json_Error -> std_string_String) = method46()
                    let v161 : string = "$0.map_err(|x| $1(x))"
                    let v162 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v159, v160) v161
                    let v163 : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) = method154()
                    let v164 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = method155(v162)
                    let v165 : string = "v164.map(|x| v163(x))"
                    let v166 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v165
                    v166
                | _ ->
                    let v167 : string = $"%A{struct (v138, v39)}"
                    let v168 : string = "state_core.use_request (17) / json Error / value: " + string v167 + ""
                    let v169 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                    let v170 : bool = Fable.Core.RustInterop.emitRustExpr v168 v169
                    let v171 : crate_model_near_rpc_RpcResponse option = None
                    let v172 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v171
                    v172
            | _ ->
                let v174 : string = $"%A{struct (v138, v39)}"
                let v175 : string = "state_core.use_request (17) / json Error / value: " + string v174 + ""
                let v176 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v177 : bool = Fable.Core.RustInterop.emitRustExpr v175 v176
                let v178 : crate_model_near_rpc_RpcResponse option = None
                let v179 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v178
                v179
        | _ ->
            let v181 : string = $"%A{struct (v138, v39)}"
            let v182 : string = "state_core.use_request (17) / json Error / value: " + string v181 + ""
            let v183 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v184 : bool = Fable.Core.RustInterop.emitRustExpr v182 v183
            let v185 : crate_model_near_rpc_RpcResponse option = None
            let v186 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v185
            v186
and closure140 (v0 : US29, v1 : US42) (v2 : int32) : (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>) =
    closure141(v0, v1, v2)
and method153 (v0 : US29, v1 : US42) : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>)) =
    closure140(v0, v1)
and closure139 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>, v2 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>>, v3 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) () : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) =
    let v4 : string = $"$0()"
    let v5 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v4
    let v6 : string = $"%A{v5}"
    let v7 : string = "state_core.use_requests (13) / result memo / requests: " + string v6 + ""
    let v8 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = $"$0()"
    let v11 : Result<(Heap4 option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v10
    let v12 : (Result<(Heap4 option []), std_string_String> -> US28) = method91()
    let v13 : US28 = US28_1
    let v14 : US28 = v11 |> Option.map v12 |> Option.defaultValue v13 
    let v35 : US29 =
        match v14 with
        | US28_1 -> (* None *)
            US29_1
        | US28_0(v15) -> (* Some *)
            let v16 : ((Heap4 option []) -> US31) = closure80()
            let v17 : (std_string_String -> US31) = closure81()
            let v18 : US31 = match v15 with Ok x -> v16 x | Error x -> v17 x
            let v31 : US30 =
                match v18 with
                | US31_1(v28) -> (* Error *)
                    US30_1(v28)
                | US31_0(v19) -> (* Ok *)
                    let v20 : string = "$0.to_vec()"
                    let v21 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v19 v20
                    let v22 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v23 : (Heap4 option -> US27) = closure82()
                    let v24 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v22
                    let v25 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v26 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v24 v25
                    US30_0(v26)
            US29_0(v31)
    let v36 : string = $"%A{v35}"
    let v37 : int64 = System.Convert.ToInt64 v36.Length
    let v38 : bool = v37 <= 400L
    let v60 : string =
        if v38 then
            v36
        else
            let v39 : float = float 400L
            let v40 : float = v39 / 2.0
            let v41 : (float -> float) = ceil
            let v42 : float = v41 v40
            let v43 : int64 = int64 v42
            let v44 : (float -> float) = floor
            let v45 : float = v44 v40
            let v46 : int64 = int64 v45
            let v47 : int64 = v43 - 1L
            let v48 : string = v36.[int 0L..int v47]
            let v49 : int64 = v37 - v46
            let v50 : int64 = v37 - 1L
            let v51 : string = v36.[int v49..int v50]
            let v52 : string = "..."
            let v53 : (string []) = [|v48; v52; v51|]
            let v54 : ((string []) -> string seq) = Seq.ofArray
            let v55 : string seq = v54 v53
            let v56 : string = method78()
            let v57 : (string -> (string seq -> string)) = String.concat
            let v58 : (string seq -> string) = v57 v56
            v58 v55
    let v61 : string = "state_core.use_request (14) / result_memo / state_data: " + string v60 + ""
    let v62 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v63 : bool = Fable.Core.RustInterop.emitRustExpr v61 v62
    let v64 : string = $"leptos::SignalGet::get(&$0)"
    let v65 : Result<(string option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v64
    let v66 : (Result<(string option []), std_string_String> -> US38) = method118()
    let v67 : US38 = US38_1
    let v68 : US38 = v65 |> Option.map v66 |> Option.defaultValue v67 
    let v76 : US39 =
        match v68 with
        | US38_1 -> (* None *)
            US39_1
        | US38_0(v69) -> (* Some *)
            let v70 : ((string option []) -> US40) = closure93()
            let v71 : (std_string_String -> US40) = closure94()
            let v72 : US40 = match v69 with Ok x -> v70 x | Error x -> v71 x
            US39_0(v72)
    let v94 : US41 =
        match v76 with
        | US39_1 -> (* None *)
            US41_1
        | US39_0(v77) -> (* Some *)
            let v90 : US42 =
                match v77 with
                | US40_1(v87) -> (* Error *)
                    US42_1(v87)
                | US40_0(v78) -> (* Ok *)
                    let v79 : string = "$0.to_vec()"
                    let v80 : Vec<string option> = Fable.Core.RustInterop.emitRustExpr v78 v79
                    let v81 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v82 : (string option -> US34) = closure95()
                    let v83 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr struct (v80, v82) v81
                    let v84 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v85 : (US34 []) = Fable.Core.RustInterop.emitRustExpr v83 v84
                    US42_0(v85)
            US41_0(v90)
    let v95 : (US34 []) = [||]
    let v99 : US42 =
        match v94 with
        | US41_1 -> (* None *)
            US42_0(v95)
        | US41_0(v96) -> (* Some *)
            v96
    match v99 with
    | US42_1(v106) -> (* Error *)
        ()
    | US42_0(v100) -> (* Ok *)
        let v101 : string = "$0.to_vec()"
        let v102 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr v100 v101
        let v103 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v104 : (US34 -> unit) = closure97(v3)
        let v105 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr struct (v102, v104) v103
        ()
    let v107 : string = "$0.to_vec()"
    let v108 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v5 v107
    let v109 : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>)) = method153(v35, v99)
    let v110 : Vec<struct (bool * string * bool * US25 * string)> = method106(v108)
    let v111 : string = "v110.iter().enumerate().map(|(i, x)| v109(i.try_into().unwrap())(x.clone())).collect()"
    let v112 : Vec<Result<crate_model_near_rpc_RpcResponse option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v111
    let v113 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v114 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v112 v113
    let v115 : string = $"%A{v114}"
    let v116 : string = "state_core.use_requests (18) / result_func func0 / result: " + string v115 + ""
    let v117 : int32 = v116.Length
    let v118 : bool = v117 <= 200
    let v121 : string =
        if v118 then
            v116
        else
            let v119 : string = v116.[int 0..int 199]
            let v120 : string = v119 + "..."
            v120
    let v122 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v123 : bool = Fable.Core.RustInterop.emitRustExpr v121 v122
    v114
and closure150 () (v0 : crate_model_near_rpc_TransferDetail) : struct (std_string_String option * std_string_String * float option * std_string_String option) =
    let v1 : string = "$0.deposit"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.args"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.gas"
    let v6 : float option = Fable.Core.RustInterop.emitRustExpr v0 v5
    let v7 : string = "$0.method_name"
    let v8 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v7
    struct (v4, v2, v6, v8)
and closure149 () (v0 : std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail>) : std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> =
    let v1 : string = "$0.into_iter().map(|(k, v)| (k, $1(v))).collect()"
    let v2 : (crate_model_near_rpc_TransferDetail -> struct (std_string_String option * std_string_String * float option * std_string_String option)) = closure150()
    let v3 : std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1
    v3
and closure148 () (v0 : crate_model_near_rpc_Receipt) : struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.predecessor_id"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.receipt"
    let v4 : crate_model_near_rpc_ReceiptDetail = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.action"
    let v6 : crate_model_near_rpc_ActionDetail = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0.actions"
    let v8 : Vec<std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail>> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v10 : (std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail> -> std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)>) = closure149()
    let v11 : Vec<std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)>> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9
    let v12 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v13 : (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.gas_price"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v14
    let v16 : string = "$0.input_data_ids"
    let v17 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v6 v16
    let v18 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v19 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "$0.output_data_receivers"
    let v21 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v6 v20
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "$0.signer_id"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v24
    let v26 : string = "$0.signer_public_key"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v26
    let v28 : string = "$0.receipt_id"
    let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v28
    let v30 : string = "$0.receiver_id"
    let v31 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v30
    struct (v2, v13, v15, v19, v23, v25, v27, v29, v31)
and closure152 () (v0 : crate_model_near_rpc_GasProfile) : struct (std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.cost"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.cost_category"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.gas_used"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    struct (v2, v4, v6)
and closure154 () (v0 : crate_model_near_rpc_Proof) : struct (std_string_String * std_string_String) =
    let v1 : string = "$0.direction"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.hash"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    struct (v2, v4)
and closure153 () (v0 : Vec<crate_model_near_rpc_Proof>) : (struct (std_string_String * std_string_String) []) =
    let v1 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v2 : (crate_model_near_rpc_Proof -> struct (std_string_String * std_string_String)) = closure154()
    let v3 : Vec<struct (std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1
    let v4 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v5 : (struct (std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure151 () (v0 : crate_model_near_rpc_ReceiptsOutcome) : struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) =
    let v1 : string = "$0.block_hash"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.id"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.outcome"
    let v6 : crate_model_near_rpc_OutcomeDetail = Fable.Core.RustInterop.emitRustExpr v0 v5
    let v7 : string = "$0.executor_id"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.gas_burnt"
    let v10 : uint64 = Fable.Core.RustInterop.emitRustExpr v6 v9
    let v11 : string = "$0.logs"
    let v12 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v6 v11
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.metadata"
    let v16 : crate_model_near_rpc_Metadata = Fable.Core.RustInterop.emitRustExpr v6 v15
    let v17 : string = "$0.gas_profile"
    let v18 : Vec<crate_model_near_rpc_GasProfile> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v20 : (crate_model_near_rpc_GasProfile -> struct (std_string_String * std_string_String * std_string_String)) = closure152()
    let v21 : Vec<struct (std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (struct (std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "$0.version"
    let v25 : uint8 = Fable.Core.RustInterop.emitRustExpr v16 v24
    let v26 : string = "$0.receipt_ids"
    let v27 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v6 v26
    let v28 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v29 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : string = "$0.status"
    let v31 : std_collections_HashMap<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr v6 v30
    let v32 : string = "$0.tokens_burnt"
    let v33 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v6 v32
    let v34 : string = "$0.proof"
    let v35 : Vec<crate_model_near_rpc_Proof> option = Fable.Core.RustInterop.emitRustExpr v0 v34
    let v36 : (Vec<crate_model_near_rpc_Proof> -> (struct (std_string_String * std_string_String) [])) = closure153()
    let v37 : (struct (std_string_String * std_string_String) []) option = v35 |> Option.map v36 
    struct (v2, v4, v8, v10, v14, v23, v25, v29, v31, v33, v37)
and closure147 () (v0 : crate_model_near_rpc_TransactionStatus) : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) =
    let v1 : string = "$0.receipts"
    let v2 : Vec<crate_model_near_rpc_Receipt> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v4 : (crate_model_near_rpc_Receipt -> struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String)) = closure148()
    let v5 : Vec<struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "$0.receipts_outcome"
    let v9 : Vec<crate_model_near_rpc_ReceiptsOutcome> = Fable.Core.RustInterop.emitRustExpr v0 v8
    let v10 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v11 : (crate_model_near_rpc_ReceiptsOutcome -> struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option)) = closure151()
    let v12 : Vec<struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option)> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) []) = Fable.Core.RustInterop.emitRustExpr v12 v13
    struct (v7, v14)
and closure156 () (v0 : crate_model_near_rpc_ErrorCauseInfo) : struct (std_string_String option * std_string_String option) =
    let v1 : string = "$0.error_message"
    let v2 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.requested_transaction_hash"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3
    struct (v2, v4)
and closure155 () (v0 : crate_model_near_rpc_RpcError) : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.name"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.cause"
    let v4 : crate_model_near_rpc_ErrorCause = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.name"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0.info"
    let v8 : crate_model_near_rpc_ErrorCauseInfo option = Fable.Core.RustInterop.emitRustExpr v4 v7
    let v9 : (crate_model_near_rpc_ErrorCauseInfo -> struct (std_string_String option * std_string_String option)) = closure156()
    let v10 : struct (std_string_String option * std_string_String option) option = v8 |> Option.map v9 
    let v11 : string = "$0.code"
    let v12 : int32 = Fable.Core.RustInterop.emitRustExpr v0 v11
    let v13 : string = "$0.message"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v13
    let v15 : string = "$0.data"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v15
    struct (v10, v6, v12, v16, v14, v2)
and closure146 () (v0 : crate_model_near_rpc_RpcResponse) : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) =
    let v1 : string = "$0.jsonrpc"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.result"
    let v4 : crate_model_near_rpc_TransactionStatus option = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : (crate_model_near_rpc_TransactionStatus -> struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) []))) = closure147()
    let v6 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option = v4 |> Option.map v5 
    let v7 : string = "$0.error"
    let v8 : crate_model_near_rpc_RpcError option = Fable.Core.RustInterop.emitRustExpr v0 v7
    let v9 : (crate_model_near_rpc_RpcError -> struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String)) = closure155()
    let v10 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option = v8 |> Option.map v9 
    let v11 : string = "$0.id"
    let v12 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v11
    struct (v10, v12, v2, v6)
and closure145 () (v0 : crate_model_near_rpc_RpcResponse option) : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option =
    let v1 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option)) = closure146()
    let v2 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option = v0 |> Option.map v1 
    v2
and method156 () : (crate_model_near_rpc_RpcResponse option -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option) =
    closure145()
and method157 (v0 : Result<crate_model_near_rpc_RpcResponse option, std_string_String>) : Result<crate_model_near_rpc_RpcResponse option, std_string_String> =
    v0
and closure144 () (v0 : Result<crate_model_near_rpc_RpcResponse option, std_string_String>) : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> =
    let v1 : (crate_model_near_rpc_RpcResponse option -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option) = method156()
    let v2 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = method157(v0)
    let v3 : string = "v2.map(|x| v1(x))"
    let v4 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3
    v4
and closure143 (v0 : leptos_Resource<US2, rexie_Rexie>, v1 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>>, v2 : leptos_Memo<(Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])>) () : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> []) =
    let v3 : string = $"leptos::Resource::loading(&$0)"
    let v4 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = $"leptos::Resource::loading(&$0)"
    let v8 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v1 v7
    let v9 : string = $"leptos::SignalGet::get(&$0)"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = $"leptos::SignalGet::get(&$0)"
    let v12 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v11
    let v13 : (rexie_Rexie -> US5) = method17()
    let v14 : US5 = US5_1
    let v15 : US5 = v12 |> Option.map v13 |> Option.defaultValue v14 
    let v16 : string = $"leptos::SignalGet::get(&$0)"
    let v17 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v16
    let v18 : (Result<Vec<Heap4 option>, std_string_String> -> US44) = method124()
    let v19 : US44 = US44_1
    let v20 : US44 = v17 |> Option.map v18 |> Option.defaultValue v19 
    let v39 : US29 =
        match v20 with
        | US44_1 -> (* None *)
            US29_1
        | US44_0(v21) -> (* Some *)
            let v22 : (Vec<Heap4 option> -> US45) = closure104()
            let v23 : (std_string_String -> US45) = closure105()
            let v24 : US45 = match v21 with Ok x -> v22 x | Error x -> v23 x
            let v35 : US30 =
                match v24 with
                | US45_1(v32) -> (* Error *)
                    US30_1(v32)
                | US45_0(v25) -> (* Ok *)
                    let v26 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v27 : (Heap4 option -> US27) = closure82()
                    let v28 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v25, v27) v26
                    let v29 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v30 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v28 v29
                    US30_0(v30)
            US29_0(v35)
    let v40 : string = $"%A{v15}"
    let v41 : int64 = System.Convert.ToInt64 v40.Length
    let v42 : bool = v41 <= 400L
    let v64 : string =
        if v42 then
            v40
        else
            let v43 : float = float 400L
            let v44 : float = v43 / 2.0
            let v45 : (float -> float) = ceil
            let v46 : float = v45 v44
            let v47 : int64 = int64 v46
            let v48 : (float -> float) = floor
            let v49 : float = v48 v44
            let v50 : int64 = int64 v49
            let v51 : int64 = v47 - 1L
            let v52 : string = v40.[int 0L..int v51]
            let v53 : int64 = v41 - v50
            let v54 : int64 = v41 - 1L
            let v55 : string = v40.[int v53..int v54]
            let v56 : string = "..."
            let v57 : (string []) = [|v52; v56; v55|]
            let v58 : ((string []) -> string seq) = Seq.ofArray
            let v59 : string seq = v58 v57
            let v60 : string = method78()
            let v61 : (string -> (string seq -> string)) = String.concat
            let v62 : (string seq -> string) = v61 v60
            v62 v59
    let v65 : string = $"%A{v39}"
    let v66 : int64 = System.Convert.ToInt64 v65.Length
    let v67 : bool = v66 <= 400L
    let v89 : string =
        if v67 then
            v65
        else
            let v68 : float = float 400L
            let v69 : float = v68 / 2.0
            let v70 : (float -> float) = ceil
            let v71 : float = v70 v69
            let v72 : int64 = int64 v71
            let v73 : (float -> float) = floor
            let v74 : float = v73 v69
            let v75 : int64 = int64 v74
            let v76 : int64 = v72 - 1L
            let v77 : string = v65.[int 0L..int v76]
            let v78 : int64 = v66 - v75
            let v79 : int64 = v66 - 1L
            let v80 : string = v65.[int v78..int v79]
            let v81 : string = "..."
            let v82 : (string []) = [|v77; v81; v80|]
            let v83 : ((string []) -> string seq) = Seq.ofArray
            let v84 : string seq = v83 v82
            let v85 : string = method78()
            let v86 : (string -> (string seq -> string)) = String.concat
            let v87 : (string seq -> string) = v86 v85
            v87 v84
    let v90 : string = "state_core.use_request (19) / result move / database: " + string v64 + " / database_loading: " + string v6 + " / state_data: " + string v89 + " / state_data_loading: " + string v10 + ""
    let v91 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr v90 v91
    let v93 : string = $"$0()"
    let v94 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v2 v93
    let v95 : string = "$0.to_vec()"
    let v96 : Vec<Result<crate_model_near_rpc_RpcResponse option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v94 v95
    let v97 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v98 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> -> Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>) = closure144()
    let v99 : Vec<Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v96, v98) v97
    let v100 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v101 : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v99 v100
    let v102 : string = $"%A{v101}"
    let v103 : string = "state_core.use_requests (20) / result func0 / result: " + string v102 + ""
    let v104 : int32 = v103.Length
    let v105 : bool = v104 <= 200
    let v108 : string =
        if v105 then
            v103
        else
            let v106 : string = v103.[int 0..int 199]
            let v107 : string = v106 + "..."
            v107
    let v109 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109
    v101
and method159 () : string =
    let v0 : string = "9JgptZpFQGtUvusnoF9ysVqHXD8fXCri8mFxPTMnt3kS"
    v0
and method160 () : string =
    let v0 : string = "https://rpc.mainnet.near.org"
    v0
and closure158 () (v0 : US15) : US61 =
    US61_0(v0)
and closure159 () (v0 : std_string_String) : US61 =
    US61_1(v0)
and closure160 () (v0 : crate_model_near_rpc_RpcResponse) : US63 =
    US63_0(v0)
and closure161 () (v0 : std_string_String) : US63 =
    US63_1(v0)
and method161 (v0 : Result<US60, std_string_String>) : Result<US60, std_string_String> =
    v0
and method158 () : std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>> =
    let v0 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = method143()
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = method144()
    let v7 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method145()
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = method159()
    let v17 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "String::from($0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = method146()
    let v22 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "String::from($0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : (std_string_String []) = [|v20; v25|]
    let v27 : string = "$0.to_vec()"
    let v28 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "crate::model::near::rpc::RpcInput { jsonrpc: v5, id: v10, method: v15, params: v28 }"
    let v30 : crate_model_near_rpc_RpcInput = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : string = method160()
    let v32 : string = method19(v31)
    let v33 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "String::from($0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : std_string_String = method100(v36)
    let v38 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.post(v37)"
    let v39 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : string = "reqwest_wasm::RequestBuilder::json(v39, &v30)"
    let v41 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : reqwest_RequestBuilder = method103(v41)
    let v43 : string = "Box::pin(reqwest_wasm::RequestBuilder::send(v42))"
    let v44 : std_pin_Pin<Box<Dyn<std_future_Future<Result<reqwest_Response, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : string = "v44.await"
    let v46 : Result<reqwest_Response, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : (reqwest_Error -> std_string_String) = method104()
    let v48 : string = "$0.map_err(|x| $1(x))"
    let v49 : Result<reqwest_Response, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v46, v47) v48
    let v50 : string = "$0?"
    let v51 : reqwest_Response = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "Box::pin(reqwest_wasm::Response::text(v51))"
    let v53 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_string_String, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v52
    let v54 : string = "v53.await"
    let v55 : Result<std_string_String, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : (reqwest_Error -> std_string_String) = method104()
    let v57 : string = "$0.map_err(|x| $1(x))"
    let v58 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v55, v56) v57
    let v59 : string = "$0?"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : US15 = US15_0(v60)
    let v62 : Result<US15, std_string_String> = Ok v61
    let v63 : string = $"%A{v62}"
    let v64 : string = "dice_view.render (x) / roll_action create_action / result1 / result: " + string v63 + ""
    let v65 : int32 = v64.Length
    let v66 : bool = v65 <= 200
    let v69 : string =
        if v66 then
            v64
        else
            let v67 : string = v64.[int 0..int 199]
            let v68 : string = v67 + "..."
            v68
    let v70 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v71 : bool = Fable.Core.RustInterop.emitRustExpr v69 v70
    let v72 : (US15 -> US61) = closure158()
    let v73 : (std_string_String -> US61) = closure159()
    let v74 : US61 = match v62 with Ok x -> v72 x | Error x -> v73 x
    let v123 : US62 =
        match v74 with
        | US61_0(v75) -> (* Ok *)
            match v75 with
            | US15_0(v76) -> (* Some *)
                let v77 : string = "fable_library_rust::String_::fromString($0)"
                let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77
                let v79 : string = method45(v78)
                let v80 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v80
                let v82 : string = "serde_json::from_str(&v81)"
                let v83 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v82
                let v84 : (serde_json_Error -> std_string_String) = method46()
                let v85 : string = "$0.map_err(|x| $1(x))"
                let v86 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v83, v84) v85
                let v87 : (crate_model_near_rpc_RpcResponse -> US63) = closure160()
                let v88 : (std_string_String -> US63) = closure161()
                let v89 : US63 = match v86 with Ok x -> v87 x | Error x -> v88 x
                let v107 : US64 =
                    match v89 with
                    | US63_1(v104) -> (* Error *)
                        US64_1(v104)
                    | US63_0(v90) -> (* Ok *)
                        let v91 : string = "$0.jsonrpc"
                        let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v90 v91
                        let v93 : string = "$0.result"
                        let v94 : crate_model_near_rpc_TransactionStatus option = Fable.Core.RustInterop.emitRustExpr v90 v93
                        let v95 : (crate_model_near_rpc_TransactionStatus -> struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) []))) = closure147()
                        let v96 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option = v94 |> Option.map v95 
                        let v97 : string = "$0.error"
                        let v98 : crate_model_near_rpc_RpcError option = Fable.Core.RustInterop.emitRustExpr v90 v97
                        let v99 : (crate_model_near_rpc_RpcError -> struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String)) = closure155()
                        let v100 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option = v98 |> Option.map v99 
                        let v101 : string = "$0.id"
                        let v102 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v90 v101
                        US64_0(v100, v102, v92, v96)
                match v107 with
                | US64_1(v114) -> (* Error *)
                    US62_1(v114)
                | US64_0(v108, v109, v110, v111) -> (* Ok *)
                    let v112 : US60 = US60_0(v108, v109, v110, v111)
                    US62_0(v112)
            | _ ->
                let v118 : US60 = US60_1
                US62_0(v118)
        | _ ->
            let v121 : US60 = US60_1
            US62_0(v121)
    let v129 : Result<US60, std_string_String> =
        match v123 with
        | US62_1(v126) -> (* Error *)
            let v127 : Result<US60, std_string_String> = Error v126
            v127
        | US62_0(v124) -> (* Ok *)
            let v125 : Result<US60, std_string_String> = Ok v124
            v125
    let v130 : string = $"%A{v129}"
    let v131 : string = "dice_view.render (x) / roll_action create_action / result2 / result: " + string v130 + ""
    let v132 : int32 = v131.Length
    let v133 : bool = v132 <= 200
    let v136 : string =
        if v133 then
            v131
        else
            let v134 : string = v131.[int 0..int 199]
            let v135 : string = v134 + "..."
            v135
    let v137 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v138 : bool = Fable.Core.RustInterop.emitRustExpr v136 v137
    let v139 : Result<US60, std_string_String> = method161(v129)
    let v140 : string = "v139 }})"
    Fable.Core.RustInterop.emitRustExpr () v140
    let v141 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v141
    let v142 : string = "__result"
    let v143 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v142
    v143
and closure157 () (v0 : Heap6) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>> =
    let v1 : string = $"%A{v0}"
    let v2 : string = "dice_view.render (2) / set_max_action / value: " + string v1 + ""
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    method158()
and closure164 () (v0 : US60) : US62 =
    US62_0(v0)
and closure165 () (v0 : std_string_String) : US62 =
    US62_1(v0)
and closure163 () (v0 : Result<US60, std_string_String>) : US62 =
    let v1 : (US60 -> US62) = closure164()
    let v2 : (std_string_String -> US62) = closure165()
    let v3 : US62 = match v0 with Ok x -> v1 x | Error x -> v2 x
    v3
and closure166 () (v0 : US62) : US65 =
    US65_0(v0)
and method162 () : (US62 -> US65) =
    closure166()
and closure162 (v0 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> =
    let v1 : string = "leptos::Action::value(&$0)"
    let v2 : leptos_RwSignal<Result<US60, std_string_String> option> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : Result<US60, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : (Result<US60, std_string_String> -> US62) = closure163()
    let v6 : US62 option = v4 |> Option.map v5 
    let v7 : (US62 -> US65) = method162()
    let v8 : US65 = US65_1
    let v9 : US65 = v6 |> Option.map v7 |> Option.defaultValue v8 
    let v27 : US62 =
        match v9 with
        | US65_0(v10) -> (* Some *)
            match v10 with
            | US62_1(v11) -> (* Error *)
                US62_1(v11)
            | US62_0(v13) -> (* Ok *)
                match v13 with
                | US60_0(v14, v15, v16, v17) -> (* Some *)
                    let v18 : US60 = US60_0(v14, v15, v16, v17)
                    US62_0(v18)
                | _ ->
                    let v20 : US60 = US60_1
                    US62_0(v20)
        | _ ->
            let v25 : US60 = US60_1
            US62_0(v25)
    let v41 : US66 =
        match v27 with
        | US62_1(v38) -> (* Error *)
            US66_1(v38)
        | US62_0(v28) -> (* Ok *)
            let v36 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option =
                match v28 with
                | US60_1 -> (* None *)
                    let v34 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option = None
                    v34
                | US60_0(v29, v30, v31, v32) -> (* Some *)
                    let v33 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option = Some struct (v29, v30, v31, v32) 
                    v33
            US66_0(v36)
    let v47 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> =
        match v41 with
        | US66_1(v44) -> (* Error *)
            let v45 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> = Error v44
            v45
        | US66_0(v42) -> (* Ok *)
            let v43 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> = Ok v42
            v43
    let v48 : string = $"%A{v47}"
    let v49 : string = "dice_view.render (x) / roll create_memo / result: " + string v48 + ""
    let v50 : int32 = v49.Length
    let v51 : bool = v50 <= 200
    let v54 : string =
        if v51 then
            v49
        else
            let v52 : string = v49.[int 0..int 199]
            let v53 : string = v52 + "..."
            v53
    let v55 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55
    v47
and closure168 () (v0 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option) : US66 =
    US66_0(v0)
and closure169 () (v0 : std_string_String) : US66 =
    US66_1(v0)
and closure170 () struct (v0 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option, v1 : std_string_String option, v2 : std_string_String, v3 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) : US60 =
    US60_0(v0, v1, v2, v3)
and method163 () : (struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) -> US60) =
    closure170()
and closure171 () struct (v0 : struct (std_string_String option * std_string_String option) option, v1 : std_string_String, v2 : int32, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String) : US67 =
    US67_0(v0, v1, v2, v3, v4, v5)
and method164 () : (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) -> US67) =
    closure171()
and closure167 (v0 : leptos_Memo<Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>>) () : string option =
    let v1 : string = $"$0()"
    let v2 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option -> US66) = closure168()
    let v4 : (std_string_String -> US66) = closure169()
    let v5 : US66 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v14 : US62 =
        match v5 with
        | US66_1(v11) -> (* Error *)
            US62_1(v11)
        | US66_0(v6) -> (* Ok *)
            let v7 : (struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) -> US60) = method163()
            let v8 : US60 = US60_1
            let v9 : US60 = v6 |> Option.map v7 |> Option.defaultValue v8 
            US62_0(v9)
    let v36 : US34 =
        match v14 with
        | US62_0(v15) -> (* Ok *)
            match v15 with
            | US60_0(v16, v17, v18, v19) -> (* Some *)
                let v20 : (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) -> US67) = method164()
                let v21 : US67 = US67_1
                let v22 : US67 = v16 |> Option.map v20 |> Option.defaultValue v21 
                match v22 with
                | US67_0(v23, v24, v25, v26, v27, v28) -> (* Some *)
                    let v29 : string = string v28 + ": " + string v27 + " - " + string v26 + " (" + string v24 + ")"
                    US34_0(v29)
                | _ ->
                    US34_1
            | _ ->
                US34_1
        | _ ->
            US34_1
    let v41 : string option =
        match v36 with
        | US34_1 -> (* None *)
            let v39 : string option = None
            v39
        | US34_0(v37) -> (* Some *)
            let v38 : string option = Some v37 
            v38
    let v42 : string = $"%A{v41}"
    let v43 : string = "dice_view.render (x) / error_message create_memo / result: " + string v42 + ""
    let v44 : int32 = v43.Length
    let v45 : bool = v44 <= 200
    let v48 : string =
        if v45 then
            v43
        else
            let v46 : string = v43.[int 0..int 199]
            let v47 : string = v46 + "..."
            v47
    let v49 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v50 : bool = Fable.Core.RustInterop.emitRustExpr v48 v49
    v41
and closure172 (v0 : Heap2) () : US34 =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : std_string_String option = v6.l0
    let v8 : (std_string_String -> US15) = method44()
    let v9 : US15 = US15_1
    let v10 : US15 = v7 |> Option.map v8 |> Option.defaultValue v9 
    match v10 with
    | US15_1 -> (* None *)
        US34_1
    | US15_0(v11) -> (* Some *)
        let v12 : string = "fable_library_rust::String_::fromString($0)"
        let v13 : string = Fable.Core.RustInterop.emitRustExpr v11 v12
        US34_0(v13)
and closure175 (v0 : int32) (v1 : std_string_String) : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) =
    let v2 : string = $"leptos::create_signal($0)"
    let struct (v3 : leptos_ReadSignal<std_string_String>, v4 : leptos_WriteSignal<std_string_String>) = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v5 : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) = v0, struct (v3, v4)
    v5
and closure174 () (v0 : int32) : (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))) =
    closure175(v0)
and method165 () : (int32 -> (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)))) =
    closure174()
and method166 (v0 : Vec<std_string_String>) : Vec<std_string_String> =
    v0
and closure173 (v0 : Heap2) () : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : Vec<(bool * std_string_String)> = v6.l1
    let v8 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v9 : ((bool * std_string_String) -> struct (bool * std_string_String)) = closure56()
    let v10 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : (struct (bool * std_string_String) -> bool) = method67()
    let v12 : Vec<struct (bool * std_string_String)> = method68(v10)
    let v13 : string = "v12.into_iter().filter(|x| v11(x.clone().clone())).collect()"
    let v14 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v16 : (struct (bool * std_string_String) -> std_string_String) = closure58()
    let v17 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15
    let v18 : (int32 -> (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)))) = method165()
    let v19 : Vec<std_string_String> = method166(v17)
    let v20 : string = "v19.iter().enumerate().map(|(i, x)| v18(i.try_into().unwrap())(x.clone())).collect()"
    let v21 : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> = Fable.Core.RustInterop.emitRustExpr () v20
    v21
and closure177 () (v0 : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))) : struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>) =
    let (a, b) = v0
    let v1 : int32 = a
    let struct (v2 : leptos_ReadSignal<std_string_String>, v3 : leptos_WriteSignal<std_string_String>) = b
    struct (v1, v2, v3)
and closure178 () struct (v0 : int32, v1 : leptos_ReadSignal<std_string_String>, v2 : leptos_WriteSignal<std_string_String>) : struct (int32 * leptos_ReadSignal<std_string_String>) =
    struct (v0, v1)
and closure176 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>>) () : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> =
    let v1 : string = $"$0()"
    let v2 : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v4 : ((int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) -> struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) = closure177()
    let v5 : Vec<struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v7 : (struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>) -> struct (int32 * leptos_ReadSignal<std_string_String>)) = closure178()
    let v8 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    v8
and method167 (v0 : (leptos_View [])) : (leptos_View []) =
    v0
and method171 () : string =
    let v0 : string = "Account"
    v0
and closure184 () (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : US68 =
    US68_0(v0)
and method174 () : (leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> -> US68) =
    closure184()
and closure188 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method178 () : (unit -> leptos_Fragment) =
    closure188()
and method179 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    v0
and closure189 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "Func0::new(move || $0())"
    let v2 : Func0<leptos_Fragment> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::IntoView::into_view(move || $0())"
    let v4 : leptos_View = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : (leptos_View []) = [|v4|]
    let v6 : string = "$0.to_vec()"
    let v7 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::Fragment::new($0)"
    let v9 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v7 v8
    v9
and method180 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure189(v0)
and closure190 () (v0 : leptos_HtmlElement<leptos_svg_Path>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure187 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M6 18L18 6M6 6l12 12\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure190()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method177 () : (unit -> leptos_Fragment) =
    closure187()
and closure186 () () : leptos_Fragment =
    let v0 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v1 : string = "fill=\"none\""
    let v2 : string = "height=\"100%\""
    let v3 : string = "viewBox=\"0 0 24 24\""
    let v4 : string = "stroke-width=\"1.5\""
    let v5 : string = "stroke=\"currentColor\""
    let v6 : string = "class=\"text-red-700\""
    let v7 : (unit -> leptos_Fragment) = method177()
    let v8 : string = ""
    let v9 : string = " " + v0 + v8 + ""
    let v10 : string = " " + v1 + v9 + ""
    let v11 : string = " " + v2 + v10 + ""
    let v12 : string = " " + v3 + v11 + ""
    let v13 : string = " " + v4 + v12 + ""
    let v14 : string = " " + v5 + v13 + ""
    let v15 : string = " " + v6 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v7)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "svg"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_svg_Svg> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method176 () : (unit -> leptos_Fragment) =
    closure186()
and method182 () : string =
    let v0 : string = "No data"
    v0
and closure191 () () : leptos_Fragment =
    let v0 : string = method182()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method181 () : (unit -> leptos_Fragment) =
    closure191()
and closure185 () () : leptos_Fragment =
    let v0 : string = "class=\"[height:17px]\""
    let v1 : (unit -> leptos_Fragment) = method176()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "span"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Span> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v14 : (unit -> leptos_Fragment) = method181()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "pre"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Pre> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v12; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method175 () : (unit -> leptos_Fragment) =
    closure185()
and method183 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> =
    v0
and closure192 () struct (v0 : int32, v1 : leptos_ReadSignal<std_string_String>) : int32 =
    v0
and method184 () : (struct (int32 * leptos_ReadSignal<std_string_String>) -> int32) =
    closure192()
and method186 (v0 : std_string_String) : std_string_String =
    v0
and closure194 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : int32, v4 : std_string_String) () : unit =
    let v5 : string = "fable_library_rust::String_::fromString($0)"
    let v6 : string = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : leptos_RwSignal<Heap1> = v2.l0
    let v8 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v9 : Heap1 = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : leptos_RwSignal<Heap0> = v9.l1
    let v11 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v12 : Heap0 = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : std_string_String option = v12.l0
    let v14 : Vec<(bool * std_string_String)> = v12.l1
    let v15 : int32 = v12.l2
    let v16 : int32 = v12.l3
    let v17 : US1 = v12.l4
    let v18 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v19 : Heap1 = Fable.Core.RustInterop.emitRustExpr v7 v18
    let v20 : leptos_RwSignal<Heap0> = v19.l1
    let v21 : string = method19(v6)
    let v22 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "String::from($0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : std_string_String option = Some v25 
    let v27 : Heap0 = {l0 = v26; l1 = v14; l2 = v15; l3 = v16; l4 = v17} : Heap0
    let v28 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr struct (v20, v27) v28
    ()
and closure196 () (v0 : leptos_Memo<US34>) : US70 =
    US70_0(v0)
and method188 () : (leptos_Memo<US34> -> US70) =
    closure196()
and closure197 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure199 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method190 () : (unit -> leptos_Fragment) =
    closure199()
and closure198 () () : leptos_Fragment =
    let v0 : string = "cx=\"12\""
    let v1 : string = "cy=\"12\""
    let v2 : string = "r=\"9\""
    let v3 : string = "stroke-linecap=\"round\""
    let v4 : string = "stroke-linejoin=\"round\""
    let v5 : (unit -> leptos_Fragment) = method190()
    let v6 : string = ""
    let v7 : string = " " + v0 + v6 + ""
    let v8 : string = " " + v1 + v7 + ""
    let v9 : string = " " + v2 + v8 + ""
    let v10 : string = " " + v3 + v9 + ""
    let v11 : string = " " + v4 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v5)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "circle"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_svg_Circle> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "stroke-linecap=\"round\""
    let v22 : string = "stroke-linejoin=\"round\""
    let v23 : string = "d=\"M9 12l2 2l4 -4\""
    let v24 : (unit -> leptos_Fragment) = method178()
    let v25 : string = " " + v21 + v6 + ""
    let v26 : string = " " + v22 + v25 + ""
    let v27 : string = " " + v23 + v26 + ""
    let v28 : (unit -> leptos_Fragment) = method179(v24)
    let v29 : (unit -> leptos_Fragment) = method180(v28)
    let v30 : string = "path"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_svg_Path> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : (leptos_View []) = [|v20; v36|]
    let v38 : string = "$0.to_vec()"
    let v39 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "leptos::Fragment::new($0)"
    let v41 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v39 v40
    v41
and method189 () : (unit -> leptos_Fragment) =
    closure198()
and closure195 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : std_string_String) () : leptos_Fragment =
    let v4 : string = "fable_library_rust::String_::fromString($0)"
    let v5 : string = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : (leptos_Memo<US34> -> US70) = method188()
    let v7 : US70 = US70_1
    let v8 : US70 = v1 |> Option.map v6 |> Option.defaultValue v7 
    let v15 : US43 =
        match v8 with
        | US70_1 -> (* None *)
            US43_1
        | US70_0(v9) -> (* Some *)
            let v10 : string = $"$0()"
            let v11 : US34 = Fable.Core.RustInterop.emitRustExpr v9 v10
            US43_0(v11)
    let v22 : US34 =
        match v15 with
        | US43_0(v16) -> (* Some *)
            match v16 with
            | US34_0(v17) -> (* Some *)
                US34_0(v17)
            | _ ->
                US34_1
        | _ ->
            US34_1
    let v60 : leptos_View =
        match v22 with
        | US34_0(v23) -> (* Some *)
            let v24 : bool = v5 = v23
            if v24 then
                let v25 : string = "$0"
                let v26 : (unit -> string) = closure197()
                let v27 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v26 v25
                let v28 : string = "xmlns=\"http://www.w3.org/2000/svg\""
                let v29 : string = "fill=\"none\""
                let v30 : string = "viewBox=\"0 0 24 24\""
                let v31 : string = "stroke-width=\"1.5\""
                let v32 : string = "stroke=\"currentColor\""
                let v33 : string = "class=move || \" \".to_owned() + &v27(())"
                let v34 : (unit -> leptos_Fragment) = method189()
                let v35 : string = ""
                let v36 : string = " " + v28 + v35 + ""
                let v37 : string = " " + v29 + v36 + ""
                let v38 : string = " " + v30 + v37 + ""
                let v39 : string = " " + v31 + v38 + ""
                let v40 : string = " " + v32 + v39 + ""
                let v41 : string = " " + v33 + v40 + ""
                let v42 : (unit -> leptos_Fragment) = method179(v34)
                let v43 : (unit -> leptos_Fragment) = method180(v42)
                let v44 : string = "svg"
                let v45 : string = "<" + v44 + " " + v41 + ">{v43()}</" + v44 + ">"
                let v46 : string = "leptos::view! { " + v45 + " }"
                let v47 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v46
                let v48 : leptos_HtmlElement<leptos_svg_Svg> = v47 |> unbox
                let v49 : string = "leptos::IntoView::into_view($0)"
                let v50 : leptos_View = Fable.Core.RustInterop.emitRustExpr v48 v49
                v50
            else
                let v51 : (leptos_View []) = [||]
                let v52 : (leptos_View []) = method167(v51)
                let v53 : string = "leptos::CollectView::collect_view($0.to_vec())"
                let v54 : leptos_View = Fable.Core.RustInterop.emitRustExpr v52 v53
                v54
        | _ ->
            let v56 : (leptos_View []) = [||]
            let v57 : (leptos_View []) = method167(v56)
            let v58 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v59 : leptos_View = Fable.Core.RustInterop.emitRustExpr v57 v58
            v59
    let v61 : string = method19(v5)
    let v62 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v61 v62
    let v64 : string = "String::from($0)"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : string = "leptos::html::text($0)"
    let v67 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "leptos::IntoView::into_view($0)"
    let v69 : leptos_View = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : (leptos_View []) = [|v60; v69|]
    let v71 : string = "$0.to_vec()"
    let v72 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v70 v71
    let v73 : string = "leptos::Fragment::new($0)"
    let v74 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v72 v73
    v74
and method187 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : std_string_String) : (unit -> leptos_Fragment) =
    closure195(v0, v1, v2, v3)
and closure200 () (v0 : leptos_HtmlElement<leptos_html_Button>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure193 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) struct (v3 : int32, v4 : leptos_ReadSignal<std_string_String>) : leptos_Fragment =
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : std_string_String = method186(v6)
    let v8 : (unit -> unit) = closure194(v0, v1, v2, v3, v6)
    let v9 : string = "let v8 = $0"
    Fable.Core.RustInterop.emitRustExpr v8 v9
    let v10 : string = "class=\"flex flex-1 gap-[10px] [align-items:center] [justify-content:center] inline-block rounded border border-gray-400 hover:bg-gray-100 px-[22px] py-1 text-sm text-gray-900 bg-gray-200 hover:text-gray-600 focus:outline-none focus:ring active:text-gray-500\""
    let v11 : string = "on:click=move |_| v8()"
    let v12 : string = "aria-label=v7"
    let v13 : (unit -> leptos_Fragment) = method187(v0, v1, v2, v6)
    let v14 : string = ""
    let v15 : string = " " + v10 + v14 + ""
    let v16 : string = " " + v11 + v15 + ""
    let v17 : string = " " + v12 + v16 + ""
    let v18 : (unit -> leptos_Fragment) = method179(v13)
    let v19 : (unit -> leptos_Fragment) = method180(v18)
    let v20 : string = "button"
    let v21 : string = "<" + v20 + " " + v17 + ">{v19()}</" + v20 + ">"
    let v22 : string = "leptos::view! { " + v21 + " }"
    let v23 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : leptos_HtmlElement<leptos_html_Button> = v23 |> unbox
    let v25 : (leptos_HtmlElement<leptos_html_Button> []) = [|v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_HtmlElement<leptos_html_Button>> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v29 : (leptos_HtmlElement<leptos_html_Button> -> leptos_View) = closure200()
    let v30 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v28
    let v31 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v32 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method185 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (struct (int32 * leptos_ReadSignal<std_string_String>) -> leptos_Fragment) =
    closure193(v0, v1, v2)
and closure183 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : (leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> -> US68) = method174()
    let v4 : US68 = US68_1
    let v5 : US68 = v0 |> Option.map v3 |> Option.defaultValue v4 
    let v14 : US69 =
        match v5 with
        | US68_1 -> (* None *)
            US69_1
        | US68_0(v6) -> (* Some *)
            let v7 : string = $"$0()"
            let v8 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr v6 v7
            let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v10 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) = Fable.Core.RustInterop.emitRustExpr v8 v9
            US69_0(v10)
    let v15 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) = [||]
    let v18 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) =
        match v14 with
        | US69_1 -> (* None *)
            v15
        | US69_0(v16) -> (* Some *)
            v16
    let v19 : uint64 = System.Convert.ToUInt64 v18.Length
    let v20 : bool = v19 = 0UL
    if v20 then
        let v21 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
        let v22 : (unit -> leptos_Fragment) = method175()
        let v23 : string = ""
        let v24 : string = " " + v21 + v23 + ""
        let v25 : (unit -> leptos_Fragment) = method179(v22)
        let v26 : (unit -> leptos_Fragment) = method180(v25)
        let v27 : string = "div"
        let v28 : string = "<" + v27 + " " + v24 + ">{v26()}</" + v27 + ">"
        let v29 : string = "leptos::view! { " + v28 + " }"
        let v30 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : leptos_HtmlElement<leptos_html_Div> = v30 |> unbox
        let v32 : string = "leptos::IntoView::into_view($0)"
        let v33 : leptos_View = Fable.Core.RustInterop.emitRustExpr v31 v32
        let v34 : (leptos_View []) = [|v33|]
        let v35 : string = "$0.to_vec()"
        let v36 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v34 v35
        let v37 : string = "leptos::Fragment::new($0)"
        let v38 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v36 v37
        v38
    else
        let v39 : (leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> -> US68) = method174()
        let v40 : US68 = US68_1
        let v41 : US68 = v0 |> Option.map v39 |> Option.defaultValue v40 
        match v41 with
        | US68_1 -> (* None *)
            let v64 : (leptos_View []) = [||]
            let v65 : string = "$0.to_vec()"
            let v66 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v64 v65
            let v67 : string = "leptos::Fragment::new($0)"
            let v68 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v66 v67
            v68
        | US68_0(v42) -> (* Some *)
            let v43 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = method183(v42)
            let v44 : (struct (int32 * leptos_ReadSignal<std_string_String>) -> int32) = method184()
            let v45 : (struct (int32 * leptos_ReadSignal<std_string_String>) -> leptos_Fragment) = method185(v0, v1, v2)
            let v46 : string = "each=v43"
            let v47 : string = "key=move |x| v44(x.to_owned())"
            let v48 : string = "let:x"
            let v49 : string = "children=move |x| v45(x)"
            let v50 : string = ""
            let v51 : string = " " + v46 + v50 + ""
            let v52 : string = " " + v47 + v51 + ""
            let v53 : string = " " + v48 + v52 + ""
            let v54 : string = " " + v49 + v53 + ""
            let v55 : string = "leptos::For"
            let v56 : string = "<" + v55 + " " + v54 + " />"
            let v57 : string = "leptos::IntoView::into_view(leptos::view! { " + v56 + " })"
            let v58 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v57
            let v59 : (leptos_View []) = [|v58|]
            let v60 : string = "$0.to_vec()"
            let v61 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v59 v60
            let v62 : string = "leptos::Fragment::new($0)"
            let v63 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v61 v62
            v63
and method173 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure183(v0, v1, v2)
and closure182 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : string = "class=\"flex flex-1 flex-col p-[10px] gap-[7px] [border-left-width:1px] [border-bottom-width:1px] border-gray-200 bg-gray-100\""
    let v4 : (unit -> leptos_Fragment) = method173(v0, v1, v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method179(v4)
    let v8 : (unit -> leptos_Fragment) = method180(v7)
    let v9 : string = "div"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : leptos_HtmlElement<leptos_html_Div> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : (leptos_View []) = [|v15|]
    let v17 : string = "$0.to_vec()"
    let v18 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::Fragment::new($0)"
    let v20 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v18 v19
    v20
and method172 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure182(v0, v1, v2)
and closure201 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "Func0::new(move || $0())"
    let v2 : Func0<leptos_Fragment> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::IntoView::into_view(move || $0())"
    let v4 : leptos_View = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : (leptos_View []) = [|v4|]
    let v6 : string = "$0.to_vec()"
    let v7 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::Fragment::new($0)"
    let v9 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v7 v8
    v9
and method191 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure201(v0)
and closure203 () () : string =
    let v0 : string = "[align-self:flex-start]"
    v0
and closure204 () () : bool =
    false
and closure205 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (leptos_View []) = [|v0|]
    let v2 : string = "$0.to_vec()"
    let v3 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "leptos::Fragment::new($0)"
    let v5 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and method193 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure205(v0)
and closure207 () () : string =
    let v0 : string = "py-[4px]"
    v0
and closure208 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : StaticRef<Str> =
    let v6 : string = ""
    let v7 : string = "r#\"" + v6 + "\"#"
    let v8 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v7
    v8
and closure211 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : string =
    let v3 : (leptos_Memo<US34> -> US70) = method188()
    let v4 : US70 = US70_1
    let v5 : US70 = v1 |> Option.map v3 |> Option.defaultValue v4 
    let v12 : US43 =
        match v5 with
        | US70_1 -> (* None *)
            US43_1
        | US70_0(v6) -> (* Some *)
            let v7 : string = $"$0()"
            let v8 : US34 = Fable.Core.RustInterop.emitRustExpr v6 v7
            US43_0(v8)
    let v19 : US34 =
        match v12 with
        | US43_0(v13) -> (* Some *)
            match v13 with
            | US34_0(v14) -> (* Some *)
                US34_0(v14)
            | _ ->
                US34_1
        | _ ->
            US34_1
    match v19 with
    | US34_1 -> (* None *)
        let v21 : string = "Select..."
        v21
    | US34_0(v20) -> (* Some *)
        v20
and method197 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> string) =
    closure211(v0, v1, v2)
and closure212 (v0 : (unit -> string)) () : leptos_Fragment =
    let v1 : string = v0 ()
    let v2 : string = method19(v1)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::html::text($0)"
    let v8 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::IntoView::into_view($0)"
    let v10 : leptos_View = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : (leptos_View []) = [|v10|]
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "leptos::Fragment::new($0)"
    let v15 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v13 v14
    v15
and method198 (v0 : (unit -> string)) : (unit -> leptos_Fragment) =
    closure212(v0)
and closure210 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : (unit -> string) = method197(v0, v1, v2)
    let v4 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v5 : (unit -> leptos_Fragment) = method198(v3)
    let v6 : string = ""
    let v7 : string = " " + v4 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v5)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "span"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_html_Span> = v13 |> unbox
    let v15 : string = "leptos::IntoView::into_view($0)"
    let v16 : leptos_View = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : (leptos_View []) = [|v16|]
    let v18 : string = "$0.to_vec()"
    let v19 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::Fragment::new($0)"
    let v21 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v19 v20
    v21
and method196 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure210(v0, v1, v2)
and closure214 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure215 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure190()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method200 () : (unit -> leptos_Fragment) =
    closure215()
and closure213 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure214()
    let v2 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v4 : string = "viewBox=\"0 0 20 20\""
    let v5 : string = "fill=\"currentColor\""
    let v6 : string = "class=move || \" \".to_owned() + &v2(())"
    let v7 : (unit -> leptos_Fragment) = method200()
    let v8 : string = ""
    let v9 : string = " " + v3 + v8 + ""
    let v10 : string = " " + v4 + v9 + ""
    let v11 : string = " " + v5 + v10 + ""
    let v12 : string = " " + v6 + v11 + ""
    let v13 : (unit -> leptos_Fragment) = method179(v7)
    let v14 : (unit -> leptos_Fragment) = method180(v13)
    let v15 : string = "svg"
    let v16 : string = "<" + v15 + " " + v12 + ">{v14()}</" + v15 + ">"
    let v17 : string = "leptos::view! { " + v16 + " }"
    let v18 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : leptos_HtmlElement<leptos_svg_Svg> = v18 |> unbox
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method199 () : (unit -> leptos_Fragment) =
    closure213()
and closure209 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : string = "class=\"flex items-center gap-2\""
    let v4 : (unit -> leptos_Fragment) = method196(v0, v1, v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method179(v4)
    let v8 : (unit -> leptos_Fragment) = method180(v7)
    let v9 : string = "div"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : leptos_HtmlElement<leptos_html_Div> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v17 : (unit -> leptos_Fragment) = method199()
    let v18 : string = " " + v16 + v5 + ""
    let v19 : (unit -> leptos_Fragment) = method179(v17)
    let v20 : (unit -> leptos_Fragment) = method180(v19)
    let v21 : string = "span"
    let v22 : string = "<" + v21 + " " + v18 + ">{v20()}</" + v21 + ">"
    let v23 : string = "leptos::view! { " + v22 + " }"
    let v24 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : leptos_HtmlElement<leptos_html_Span> = v24 |> unbox
    let v26 : string = "leptos::IntoView::into_view($0)"
    let v27 : leptos_View = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : (leptos_View []) = [|v15; v27|]
    let v29 : string = "$0.to_vec()"
    let v30 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "leptos::Fragment::new($0)"
    let v32 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v30 v31
    v32
and method195 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure209(v0, v1, v2)
and closure216 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    v0 ()
and method201 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure216(v0)
and closure206 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure207()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> StaticRef<Str>) = closure208(v0, v1, v2)
    let v9 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v9(()) + \" \" + &v6(())"
    let v11 : (unit -> leptos_Fragment) = method195(v0, v1, v2)
    let v12 : string = ""
    let v13 : string = " " + v10 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method179(v11)
    let v15 : (unit -> leptos_Fragment) = method180(v14)
    let v16 : string = "summary"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_html_Summary> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "class=\"flex flex-1 flex-col\""
    let v24 : (unit -> leptos_Fragment) = method201(v3)
    let v25 : string = " " + v23 + v12 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v24)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "div"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Div> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v22; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method194 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure206(v0, v1, v2, v3)
and closure202 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : leptos_View, v4 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure203()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "$0"
    let v9 : (unit -> bool) = closure204()
    let v10 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v12 : (unit -> leptos_Fragment) = method193(v3)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method179(v12)
    let v16 : (unit -> leptos_Fragment) = method180(v15)
    let v17 : string = "div"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Div> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v7(())"
    let v25 : string = "open=move || v10(())"
    let v26 : (unit -> leptos_Fragment) = method194(v0, v1, v2, v4)
    let v27 : string = " " + v24 + v13 + ""
    let v28 : string = " " + v25 + v27 + ""
    let v29 : (unit -> leptos_Fragment) = method179(v26)
    let v30 : (unit -> leptos_Fragment) = method180(v29)
    let v31 : string = "details"
    let v32 : string = "<" + v31 + " " + v28 + ">{v30()}</" + v31 + ">"
    let v33 : string = "leptos::view! { " + v32 + " }"
    let v34 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : leptos_HtmlElement<leptos_html_Details> = v34 |> unbox
    let v36 : string = "leptos::IntoView::into_view($0)"
    let v37 : leptos_View = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : (leptos_View []) = [|v23; v37|]
    let v39 : string = "$0.to_vec()"
    let v40 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "leptos::Fragment::new($0)"
    let v42 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v40 v41
    v42
and method192 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : leptos_View, v4 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure202(v0, v1, v2, v3, v4)
and closure181 (v0 : Heap2, v1 : leptos_Memo<US34>, v2 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v3 : string = method171()
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option = None
    let v13 : leptos_Memo<US34> option = None
    let v14 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option = Some v2 
    let v15 : leptos_Memo<US34> option = Some v1 
    let v16 : (leptos_View []) = [||]
    let v17 : (leptos_View []) = method167(v16)
    let v18 : string = "leptos::CollectView::collect_view($0.to_vec())"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : (unit -> leptos_Fragment) = method172(v14, v15, v0)
    let v21 : (unit -> leptos_Fragment) = method191(v20)
    let v22 : string = "class=\"flex flex-col [position:relative]\""
    let v23 : (unit -> leptos_Fragment) = method192(v14, v15, v0, v19, v21)
    let v24 : string = ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "div"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Div> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v11; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method170 (v0 : Heap2, v1 : leptos_Memo<US34>, v2 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure181(v0, v1, v2)
and method203 () : string =
    let v0 : string = "Max"
    v0
and closure218 (v0 : Heap2) () : int32 =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : int32 = v6.l2
    v7
and method204 (v0 : Heap2) : (unit -> int32) =
    closure218(v0)
and closure219 (v0 : Heap2) (v1 : std_string_String) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<Heap0> = v4.l1
    let v6 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v7 : Heap0 = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : std_string_String option = v7.l0
    let v9 : Vec<(bool * std_string_String)> = v7.l1
    let v10 : int32 = v7.l2
    let v11 : int32 = v7.l3
    let v12 : US1 = v7.l4
    let v13 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v14 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v13
    let v15 : leptos_RwSignal<Heap0> = v14.l1
    let v16 : string = v1 |> string
    let v17 : bool = "" = v16
    let v19 : int32 =
        if v17 then
            1
        else
            let v18 : int32 = v16 |> int32
            v18
    let v20 : Heap0 = {l0 = v8; l1 = v9; l2 = v19; l3 = v11; l4 = v12} : Heap0
    let v21 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v22 : bool = Fable.Core.RustInterop.emitRustExpr struct (v15, v20) v21
    ()
and method205 (v0 : Heap2) : (std_string_String -> unit) =
    closure219(v0)
and closure220 () () : string =
    let v0 : string = ""
    v0
and closure217 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = method203()
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : (unit -> int32) = method204(v0)
    let v11 : (std_string_String -> unit) = method205(v0)
    let v12 : string = "$0"
    let v13 : (unit -> string) = closure220()
    let v14 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v13 v12
    let v15 : string = "class=move || \"bg-gray-50 h-[31px] [font-size:.875rem] \".to_owned() + &v14(())"
    let v16 : string = "prop:value=move || v10()"
    let v17 : string = "on:keyup=move |event: web_sys::KeyboardEvent| v11(leptos::event_target_value(&event))"
    let v18 : string = ""
    let v19 : string = " " + v15 + v18 + ""
    let v20 : string = " " + v16 + v19 + ""
    let v21 : string = " " + v17 + v20 + ""
    let v22 : string = "input"
    let v23 : string = "<" + v22 + " " + v21 + " />"
    let v24 : string = "leptos::view! { " + v23 + " }"
    let v25 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : leptos_HtmlElement<leptos_html_Input> = v25 |> unbox
    let v27 : string = "leptos::IntoView::into_view($0)"
    let v28 : leptos_View = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : (leptos_View []) = [|v9; v28|]
    let v30 : string = "$0.to_vec()"
    let v31 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "leptos::Fragment::new($0)"
    let v33 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v31 v32
    v33
and method202 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure217(v0)
and closure222 (v0 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : bool =
    let v1 : string = "leptos::Action::pending(&$0)"
    let v2 : leptos_ReadSignal<bool> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method207 (v0 : Func0<bool>) : Func0<bool> =
    v0
and closure223 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<Heap0> = v4.l1
    let v6 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v7 : Heap0 = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : int32 = v7.l2
    let v9 : Heap6 = {l0 = v8} : Heap6
    let v10 : string = "true; leptos::Action::dispatch(&$0, $1.clone())"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr struct (v1, v9) v10
    ()
and method209 () : string =
    let v0 : string = "Roll"
    v0
and method210 (v0 : Func0<bool>) : Func0<bool> =
    v0
and closure225 () () : string =
    let v0 : string = "[width:15px] [height:14px]"
    v0
and closure228 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method213 () : (unit -> leptos_Fragment) =
    closure228()
and closure227 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method213()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method179(v6)
    let v15 : (unit -> leptos_Fragment) = method180(v14)
    let v16 : string = "animate"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_svg_Animate> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "attributeName=\"height\""
    let v24 : string = "attributeType=\"XML\""
    let v25 : string = "values=\"10; 20; 10\""
    let v26 : string = "begin=\"0s\""
    let v27 : string = "dur=\"0.6s\""
    let v28 : string = "repeatCount=\"indefinite\""
    let v29 : (unit -> leptos_Fragment) = method213()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method179(v29)
    let v37 : (unit -> leptos_Fragment) = method180(v36)
    let v38 : string = "<" + v16 + " " + v35 + ">{v37()}</" + v16 + ">"
    let v39 : string = "leptos::view! { " + v38 + " }"
    let v40 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : leptos_HtmlElement<leptos_svg_Animate> = v40 |> unbox
    let v42 : string = "leptos::IntoView::into_view($0)"
    let v43 : leptos_View = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "attributeName=\"y\""
    let v45 : string = "attributeType=\"XML\""
    let v46 : string = "values=\"10; 5; 10\""
    let v47 : string = "begin=\"0s\""
    let v48 : string = "dur=\"0.6s\""
    let v49 : string = "repeatCount=\"indefinite\""
    let v50 : (unit -> leptos_Fragment) = method213()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method179(v50)
    let v58 : (unit -> leptos_Fragment) = method180(v57)
    let v59 : string = "<" + v16 + " " + v56 + ">{v58()}</" + v16 + ">"
    let v60 : string = "leptos::view! { " + v59 + " }"
    let v61 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : leptos_HtmlElement<leptos_svg_Animate> = v61 |> unbox
    let v63 : string = "leptos::IntoView::into_view($0)"
    let v64 : leptos_View = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : (leptos_View []) = [|v22; v43; v64|]
    let v66 : string = "$0.to_vec()"
    let v67 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "leptos::Fragment::new($0)"
    let v69 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v67 v68
    v69
and method212 () : (unit -> leptos_Fragment) =
    closure227()
and closure229 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0.15s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method213()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method179(v6)
    let v15 : (unit -> leptos_Fragment) = method180(v14)
    let v16 : string = "animate"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_svg_Animate> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "attributeName=\"opacity\""
    let v24 : string = "attributeType=\"XML\""
    let v25 : string = "values=\"10; 20; 10\""
    let v26 : string = "begin=\"0.15s\""
    let v27 : string = "dur=\"0.6s\""
    let v28 : string = "repeatCount=\"indefinite\""
    let v29 : (unit -> leptos_Fragment) = method213()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method179(v29)
    let v37 : (unit -> leptos_Fragment) = method180(v36)
    let v38 : string = "<" + v16 + " " + v35 + ">{v37()}</" + v16 + ">"
    let v39 : string = "leptos::view! { " + v38 + " }"
    let v40 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : leptos_HtmlElement<leptos_svg_Animate> = v40 |> unbox
    let v42 : string = "leptos::IntoView::into_view($0)"
    let v43 : leptos_View = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "attributeName=\"y\""
    let v45 : string = "attributeType=\"XML\""
    let v46 : string = "values=\"10; 5; 10\""
    let v47 : string = "begin=\"0.15s\""
    let v48 : string = "dur=\"0.6s\""
    let v49 : string = "repeatCount=\"indefinite\""
    let v50 : (unit -> leptos_Fragment) = method213()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method179(v50)
    let v58 : (unit -> leptos_Fragment) = method180(v57)
    let v59 : string = "<" + v16 + " " + v56 + ">{v58()}</" + v16 + ">"
    let v60 : string = "leptos::view! { " + v59 + " }"
    let v61 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : leptos_HtmlElement<leptos_svg_Animate> = v61 |> unbox
    let v63 : string = "leptos::IntoView::into_view($0)"
    let v64 : leptos_View = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : (leptos_View []) = [|v22; v43; v64|]
    let v66 : string = "$0.to_vec()"
    let v67 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "leptos::Fragment::new($0)"
    let v69 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v67 v68
    v69
and method214 () : (unit -> leptos_Fragment) =
    closure229()
and closure230 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0.3s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method213()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method179(v6)
    let v15 : (unit -> leptos_Fragment) = method180(v14)
    let v16 : string = "animate"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_svg_Animate> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "attributeName=\"height\""
    let v24 : string = "attributeType=\"XML\""
    let v25 : string = "values=\"10; 20; 10\""
    let v26 : string = "begin=\"0.3s\""
    let v27 : string = "dur=\"0.6s\""
    let v28 : string = "repeatCount=\"indefinite\""
    let v29 : (unit -> leptos_Fragment) = method213()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method179(v29)
    let v37 : (unit -> leptos_Fragment) = method180(v36)
    let v38 : string = "<" + v16 + " " + v35 + ">{v37()}</" + v16 + ">"
    let v39 : string = "leptos::view! { " + v38 + " }"
    let v40 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : leptos_HtmlElement<leptos_svg_Animate> = v40 |> unbox
    let v42 : string = "leptos::IntoView::into_view($0)"
    let v43 : leptos_View = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "attributeName=\"y\""
    let v45 : string = "attributeType=\"XML\""
    let v46 : string = "values=\"10; 5; 10\""
    let v47 : string = "begin=\"0.3s\""
    let v48 : string = "dur=\"0.6s\""
    let v49 : string = "repeatCount=\"indefinite\""
    let v50 : (unit -> leptos_Fragment) = method213()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method179(v50)
    let v58 : (unit -> leptos_Fragment) = method180(v57)
    let v59 : string = "<" + v16 + " " + v56 + ">{v58()}</" + v16 + ">"
    let v60 : string = "leptos::view! { " + v59 + " }"
    let v61 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : leptos_HtmlElement<leptos_svg_Animate> = v61 |> unbox
    let v63 : string = "leptos::IntoView::into_view($0)"
    let v64 : leptos_View = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : (leptos_View []) = [|v22; v43; v64|]
    let v66 : string = "$0.to_vec()"
    let v67 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "leptos::Fragment::new($0)"
    let v69 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v67 v68
    v69
and method215 () : (unit -> leptos_Fragment) =
    closure230()
and closure231 () (v0 : leptos_HtmlElement<leptos_svg_Rect>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure226 () () : leptos_Fragment =
    let v0 : string = "x=\"0\""
    let v1 : string = "y=\"10\""
    let v2 : string = "width=\"4\""
    let v3 : string = "height=\"10\""
    let v4 : string = "fill=\"#333\""
    let v5 : string = "opacity=\"0.2\""
    let v6 : (unit -> leptos_Fragment) = method212()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method179(v6)
    let v15 : (unit -> leptos_Fragment) = method180(v14)
    let v16 : string = "rect"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_svg_Rect> = v19 |> unbox
    let v21 : string = "x=\"8\""
    let v22 : string = "y=\"10\""
    let v23 : string = "width=\"4\""
    let v24 : string = "height=\"10\""
    let v25 : string = "fill=\"#333\""
    let v26 : string = "opacity=\"0.2\""
    let v27 : (unit -> leptos_Fragment) = method214()
    let v28 : string = " " + v21 + v7 + ""
    let v29 : string = " " + v22 + v28 + ""
    let v30 : string = " " + v23 + v29 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : (unit -> leptos_Fragment) = method179(v27)
    let v35 : (unit -> leptos_Fragment) = method180(v34)
    let v36 : string = "<" + v16 + " " + v33 + ">{v35()}</" + v16 + ">"
    let v37 : string = "leptos::view! { " + v36 + " }"
    let v38 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v37
    let v39 : leptos_HtmlElement<leptos_svg_Rect> = v38 |> unbox
    let v40 : string = "x=\"16\""
    let v41 : string = "y=\"10\""
    let v42 : string = "width=\"4\""
    let v43 : string = "height=\"10\""
    let v44 : string = "fill=\"#333\""
    let v45 : string = "opacity=\"0.2\""
    let v46 : (unit -> leptos_Fragment) = method215()
    let v47 : string = " " + v40 + v7 + ""
    let v48 : string = " " + v41 + v47 + ""
    let v49 : string = " " + v42 + v48 + ""
    let v50 : string = " " + v43 + v49 + ""
    let v51 : string = " " + v44 + v50 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : (unit -> leptos_Fragment) = method179(v46)
    let v54 : (unit -> leptos_Fragment) = method180(v53)
    let v55 : string = "<" + v16 + " " + v52 + ">{v54()}</" + v16 + ">"
    let v56 : string = "leptos::view! { " + v55 + " }"
    let v57 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : leptos_HtmlElement<leptos_svg_Rect> = v57 |> unbox
    let v59 : (leptos_HtmlElement<leptos_svg_Rect> []) = [|v20; v39; v58|]
    let v60 : string = "$0.to_vec()"
    let v61 : Vec<leptos_HtmlElement<leptos_svg_Rect>> = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v63 : (leptos_HtmlElement<leptos_svg_Rect> -> leptos_View) = closure231()
    let v64 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v61, v63) v62
    let v65 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v66 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v64 v65
    let v67 : string = "$0.to_vec()"
    let v68 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v66 v67
    let v69 : string = "leptos::Fragment::new($0)"
    let v70 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v68 v69
    v70
and method211 () : (unit -> leptos_Fragment) =
    closure226()
and closure224 (v0 : Func0<bool>) () : leptos_Fragment =
    let v1 : string = method209()
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : Func0<bool> = method210(v0)
    let v11 : string = "v10()"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11
    let v49 : leptos_View =
        if v12 then
            let v13 : string = "$0"
            let v14 : (unit -> string) = closure225()
            let v15 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v14 v13
            let v16 : string = "version=\"1.1\""
            let v17 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v18 : string = "xmlns:xlink=\"http://www.w3.org/1999/xlink\""
            let v19 : string = "x=\"0px\""
            let v20 : string = "y=\"0px\""
            let v21 : string = "viewBox=\"0 0 24 30\""
            let v22 : string = "style=\"enable-background:new 0 0 50 50;\""
            let v23 : string = "xml:space=\"preserve\""
            let v24 : string = "class=move || \" \".to_owned() + &v15(())"
            let v25 : (unit -> leptos_Fragment) = method211()
            let v26 : string = ""
            let v27 : string = " " + v16 + v26 + ""
            let v28 : string = " " + v17 + v27 + ""
            let v29 : string = " " + v18 + v28 + ""
            let v30 : string = " " + v19 + v29 + ""
            let v31 : string = " " + v20 + v30 + ""
            let v32 : string = " " + v21 + v31 + ""
            let v33 : string = " " + v22 + v32 + ""
            let v34 : string = " " + v23 + v33 + ""
            let v35 : string = " " + v24 + v34 + ""
            let v36 : (unit -> leptos_Fragment) = method179(v25)
            let v37 : (unit -> leptos_Fragment) = method180(v36)
            let v38 : string = "svg"
            let v39 : string = "<" + v38 + " " + v35 + ">{v37()}</" + v38 + ">"
            let v40 : string = "leptos::view! { " + v39 + " }"
            let v41 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v40
            let v42 : leptos_HtmlElement<leptos_svg_Svg> = v41 |> unbox
            let v43 : string = "leptos::IntoView::into_view($0)"
            let v44 : leptos_View = Fable.Core.RustInterop.emitRustExpr v42 v43
            v44
        else
            let v45 : (leptos_View []) = [||]
            let v46 : (leptos_View []) = method167(v45)
            let v47 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v48 : leptos_View = Fable.Core.RustInterop.emitRustExpr v46 v47
            v48
    let v50 : (leptos_View []) = [|v9; v49|]
    let v51 : string = "$0.to_vec()"
    let v52 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "leptos::Fragment::new($0)"
    let v54 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v52 v53
    v54
and method208 (v0 : Func0<bool>) : (unit -> leptos_Fragment) =
    closure224(v0)
and closure233 (v0 : string) () : leptos_Fragment =
    let v1 : string = method19(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : (leptos_View []) = [|v9|]
    let v11 : string = "$0.to_vec()"
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "leptos::Fragment::new($0)"
    let v14 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v12 v13
    v14
and method217 (v0 : string) : (unit -> leptos_Fragment) =
    closure233(v0)
and closure232 (v0 : string) () : leptos_Fragment =
    let v1 : string = "class=\"[height:17px]\""
    let v2 : (unit -> leptos_Fragment) = method176()
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v15 : (unit -> leptos_Fragment) = method217(v0)
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v15)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "pre"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Pre> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : (leptos_View []) = [|v13; v25|]
    let v27 : string = "$0.to_vec()"
    let v28 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "leptos::Fragment::new($0)"
    let v30 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v28 v29
    v30
and method216 (v0 : string) : (unit -> leptos_Fragment) =
    closure232(v0)
and closure221 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>) () : leptos_Fragment =
    let v3 : string = "Func0::new(move || $0())"
    let v4 : (unit -> bool) = closure222(v1)
    let v5 : Func0<bool> = Fable.Core.RustInterop.emitRustExpr v4 v3
    let v6 : Func0<bool> = method207(v5)
    let v7 : (unit -> unit) = closure223(v0, v1)
    let v8 : string = "let v7 = $0"
    Fable.Core.RustInterop.emitRustExpr v7 v8
    let v9 : string = "class=\"flex gap-[10px] [align-items:center] inline-block rounded border border-gray-400 hover:bg-gray-400 px-4 py-1 text-sm font-medium text-gray-900 bg-transparent hover:text-gray-600 focus:outline-none focus:ring active:text-gray-500\""
    let v10 : string = "prop:disabled=move || v6()"
    let v11 : string = "on:click=move |_| v7()"
    let v12 : (unit -> leptos_Fragment) = method208(v5)
    let v13 : string = ""
    let v14 : string = " " + v9 + v13 + ""
    let v15 : string = " " + v10 + v14 + ""
    let v16 : string = " " + v11 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v12)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "button"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Button> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = $"$0()"
    let v27 : string option = Fable.Core.RustInterop.emitRustExpr v2 v26
    let v28 : (string -> US34) = method119()
    let v29 : US34 = US34_1
    let v30 : US34 = v27 |> Option.map v28 |> Option.defaultValue v29 
    let v48 : leptos_View =
        match v30 with
        | US34_0(v31) -> (* Some *)
            let v32 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v33 : (unit -> leptos_Fragment) = method216(v31)
            let v34 : string = " " + v32 + v13 + ""
            let v35 : (unit -> leptos_Fragment) = method179(v33)
            let v36 : (unit -> leptos_Fragment) = method180(v35)
            let v37 : string = "div"
            let v38 : string = "<" + v37 + " " + v34 + ">{v36()}</" + v37 + ">"
            let v39 : string = "leptos::view! { " + v38 + " }"
            let v40 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v39
            let v41 : leptos_HtmlElement<leptos_html_Div> = v40 |> unbox
            let v42 : string = "leptos::IntoView::into_view($0)"
            let v43 : leptos_View = Fable.Core.RustInterop.emitRustExpr v41 v42
            v43
        | _ ->
            let v44 : (leptos_View []) = [||]
            let v45 : (leptos_View []) = method167(v44)
            let v46 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
            v47
    let v49 : (leptos_View []) = [|v25; v48|]
    let v50 : string = "$0.to_vec()"
    let v51 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "leptos::Fragment::new($0)"
    let v53 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v51 v52
    v53
and method206 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>) : (unit -> leptos_Fragment) =
    closure221(v0, v1, v2)
and closure180 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v5 : string = "class=\"flex [flex-direction:column] [gap:2px] [align-items:flex-start]\""
    let v6 : (unit -> leptos_Fragment) = method170(v0, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "div"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Div> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=\"flex [flex-direction:column] [gap:2px] [align-items:flex-start]\""
    let v19 : (unit -> leptos_Fragment) = method202(v0)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "<" + v11 + " " + v20 + ">{v22()}</" + v11 + ">"
    let v24 : string = "leptos::view! { " + v23 + " }"
    let v25 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : leptos_HtmlElement<leptos_html_Div> = v25 |> unbox
    let v27 : string = "leptos::IntoView::into_view($0)"
    let v28 : leptos_View = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "class=\"flex\""
    let v30 : (unit -> leptos_Fragment) = method206(v0, v1, v2)
    let v31 : string = " " + v29 + v7 + ""
    let v32 : (unit -> leptos_Fragment) = method179(v30)
    let v33 : (unit -> leptos_Fragment) = method180(v32)
    let v34 : string = "<" + v11 + " " + v31 + ">{v33()}</" + v11 + ">"
    let v35 : string = "leptos::view! { " + v34 + " }"
    let v36 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : leptos_HtmlElement<leptos_html_Div> = v36 |> unbox
    let v38 : string = "leptos::IntoView::into_view($0)"
    let v39 : leptos_View = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : (leptos_View []) = [|v17; v28; v39|]
    let v41 : string = "$0.to_vec()"
    let v42 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = "leptos::Fragment::new($0)"
    let v44 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v42 v43
    v44
and method169 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure180(v0, v1, v2, v3, v4)
and closure234 () (v0 : leptos_HtmlElement<leptos_html_Div>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure179 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v5 : string = "class=\"flex flex-col p-[10px] gap-[11px]\""
    let v6 : (unit -> leptos_Fragment) = method169(v0, v1, v2, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "div"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Div> = v14 |> unbox
    let v16 : (leptos_HtmlElement<leptos_html_Div> []) = [|v15|]
    let v17 : string = "$0.to_vec()"
    let v18 : Vec<leptos_HtmlElement<leptos_html_Div>> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v20 : (leptos_HtmlElement<leptos_html_Div> -> leptos_View) = closure234()
    let v21 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method168 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure179(v0, v1, v2, v3, v4)
and closure236 () () : string =
    let v0 : string = ""
    v0
and closure237 () () : bool =
    true
and closure239 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure240 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure243 () () : string =
    let v0 : string = "Roll"
    v0
and method222 () : (unit -> string) =
    closure243()
and closure242 () () : leptos_Fragment =
    let v0 : (unit -> string) = method222()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method198(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method221 () : (unit -> leptos_Fragment) =
    closure242()
and closure241 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method221()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method199()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "span"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Span> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v12; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method220 () : (unit -> leptos_Fragment) =
    closure241()
and closure238 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure239()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure240()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method220()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method179(v8)
    let v12 : (unit -> leptos_Fragment) = method180(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method201(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method179(v21)
    let v24 : (unit -> leptos_Fragment) = method180(v23)
    let v25 : string = "div"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_html_Div> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : (leptos_View []) = [|v19; v31|]
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method219 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure238(v0)
and closure235 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure236()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure237()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method193(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method219(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "details"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Details> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v20; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method218 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure235(v0, v1)
and method226 () : string =
    let v0 : string = "No account selected"
    v0
and closure246 () () : leptos_Fragment =
    let v0 : string = method226()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method225 () : (unit -> leptos_Fragment) =
    closure246()
and closure245 () () : leptos_Fragment =
    let v0 : string = "class=\"[height:17px]\""
    let v1 : (unit -> leptos_Fragment) = method176()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "span"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Span> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v14 : (unit -> leptos_Fragment) = method225()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "pre"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Pre> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v12; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method224 () : (unit -> leptos_Fragment) =
    closure245()
and closure248 () struct (v0 : std_string_String, v1 : std_string_String option) : struct (string * US34) =
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : (std_string_String -> US15) = method44()
    let v5 : US15 = US15_1
    let v6 : US15 = v1 |> Option.map v4 |> Option.defaultValue v5 
    let v13 : US34 =
        match v6 with
        | US15_1 -> (* None *)
            US34_1
        | US15_0(v7) -> (* Some *)
            let v8 : string = "fable_library_rust::String_::fromString($0)"
            let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8
            US34_0(v9)
    struct (v3, v13)
and closure249 () struct (v0 : string, v1 : US34) : bool =
    let v5 : bool = "FUNCTION_CALL" = v0
    if v5 then
        match v1 with
        | US34_0(v8) -> (* Some *)
            let v9 : bool = "generate_random_number" = v8
            v9
        | _ ->
            false
    else
        false
and method228 () : (struct (string * US34) -> bool) =
    closure249()
and method229 (v0 : Vec<struct (string * US34)>) : Vec<struct (string * US34)> =
    v0
and closure247 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : bool =
    let v3 : (struct (std_string_String * std_string_String option) []) = v2.l0
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v7 : (struct (std_string_String * std_string_String option) -> struct (string * US34)) = closure248()
    let v8 : Vec<struct (string * US34)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : (struct (string * US34) -> bool) = method228()
    let v10 : Vec<struct (string * US34)> = method229(v8)
    let v11 : string = "v10.into_iter().filter(|x| v9(x.clone().clone())).collect()"
    let v12 : Vec<struct (string * US34)> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (struct (string * US34) []) = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : int32 = v14.Length
    let v16 : bool = v15 > 0
    let v17 : std_string_String = v2.l10
    let v18 : string = "fable_library_rust::String_::fromString($0)"
    let v19 : string = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : bool = v0 = v19
    let v21 : bool = v16 && v20
    v21
and method227 () : (struct (string * unativeint * Heap5) -> bool) =
    closure247()
and method230 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and method233 () : string =
    let v0 : string = "Block Timestamp"
    v0
and closure251 () () : leptos_Fragment =
    let v0 : string = method233()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method232 () : (unit -> leptos_Fragment) =
    closure251()
and method235 () : string =
    let v0 : string = "Predecessor"
    v0
and closure252 () () : leptos_Fragment =
    let v0 : string = method235()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method234 () : (unit -> leptos_Fragment) =
    closure252()
and method237 () : string =
    let v0 : string = "Receiver"
    v0
and closure253 () () : leptos_Fragment =
    let v0 : string = method237()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method236 () : (unit -> leptos_Fragment) =
    closure253()
and method239 () : string =
    let v0 : string = "Fee"
    v0
and closure254 () () : leptos_Fragment =
    let v0 : string = method239()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method238 () : (unit -> leptos_Fragment) =
    closure254()
and method241 () : string =
    let v0 : string = "Result"
    v0
and closure255 () () : leptos_Fragment =
    let v0 : string = method241()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method240 () : (unit -> leptos_Fragment) =
    closure255()
and method243 () : string =
    let v0 : string = "Status"
    v0
and closure256 () () : leptos_Fragment =
    let v0 : string = method243()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method242 () : (unit -> leptos_Fragment) =
    closure256()
and closure250 () () : leptos_Fragment =
    let v0 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v1 : (unit -> leptos_Fragment) = method232()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "th"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Th> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v14 : (unit -> leptos_Fragment) = method234()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "<" + v6 + " " + v15 + ">{v17()}</" + v6 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Th> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v25 : (unit -> leptos_Fragment) = method236()
    let v26 : string = " " + v24 + v2 + ""
    let v27 : (unit -> leptos_Fragment) = method179(v25)
    let v28 : (unit -> leptos_Fragment) = method180(v27)
    let v29 : string = "<" + v6 + " " + v26 + ">{v28()}</" + v6 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Th> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v36 : (unit -> leptos_Fragment) = method238()
    let v37 : string = " " + v35 + v2 + ""
    let v38 : (unit -> leptos_Fragment) = method179(v36)
    let v39 : (unit -> leptos_Fragment) = method180(v38)
    let v40 : string = "<" + v6 + " " + v37 + ">{v39()}</" + v6 + ">"
    let v41 : string = "leptos::view! { " + v40 + " }"
    let v42 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : leptos_HtmlElement<leptos_html_Th> = v42 |> unbox
    let v44 : string = "leptos::IntoView::into_view($0)"
    let v45 : leptos_View = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v47 : (unit -> leptos_Fragment) = method240()
    let v48 : string = " " + v46 + v2 + ""
    let v49 : (unit -> leptos_Fragment) = method179(v47)
    let v50 : (unit -> leptos_Fragment) = method180(v49)
    let v51 : string = "<" + v6 + " " + v48 + ">{v50()}</" + v6 + ">"
    let v52 : string = "leptos::view! { " + v51 + " }"
    let v53 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v52
    let v54 : leptos_HtmlElement<leptos_html_Th> = v53 |> unbox
    let v55 : string = "leptos::IntoView::into_view($0)"
    let v56 : leptos_View = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v58 : (unit -> leptos_Fragment) = method242()
    let v59 : string = " " + v57 + v2 + ""
    let v60 : (unit -> leptos_Fragment) = method179(v58)
    let v61 : (unit -> leptos_Fragment) = method180(v60)
    let v62 : string = "<" + v6 + " " + v59 + ">{v61()}</" + v6 + ">"
    let v63 : string = "leptos::view! { " + v62 + " }"
    let v64 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : leptos_HtmlElement<leptos_html_Th> = v64 |> unbox
    let v66 : string = "leptos::IntoView::into_view($0)"
    let v67 : leptos_View = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : (leptos_View []) = [|v12; v23; v34; v45; v56; v67|]
    let v69 : string = "$0.to_vec()"
    let v70 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v68 v69
    let v71 : string = "leptos::Fragment::new($0)"
    let v72 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v70 v71
    v72
and method231 () : (unit -> leptos_Fragment) =
    closure250()
and method246 (v0 : int64) : int64 =
    v0
and closure260 () (v0 : chrono_DateTime<chrono_Utc>) : US71 =
    US71_0(v0)
and method247 () : (chrono_DateTime<chrono_Utc> -> US71) =
    closure260()
and method248 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method249 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and closure259 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l3
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : int64 = int64 v3
    let v5 : int64 = method246(v4)
    let v6 : int64 = v5 / 1000L
    let v7 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v8 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (chrono_DateTime<chrono_Utc> -> US71) = method247()
    let v10 : US71 = US71_1
    let v11 : US71 = v8 |> Option.map v9 |> Option.defaultValue v10 
    let v29 : US34 =
        match v11 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v12) -> (* Some *)
            let v13 : chrono_DateTime<chrono_Utc> = method248(v12)
            let v14 : string = "v13.naive_utc()"
            let v15 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v14
            let v16 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v15)"
            let v17 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v16
            let v18 : string = "%Y-%m-%d %H:%M:%S"
            let v19 : string = "r#\"" + v18 + "\"#"
            let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : chrono_DateTime<chrono_Local> = method249(v17)
            let v22 : string = "v21.format(v20).to_string()"
            let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v22
            let v24 : string = "fable_library_rust::String_::fromString($0)"
            let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24
            US34_0(v25)
    let v35 : US72 =
        match v29 with
        | US34_1 -> (* None *)
            let v32 : string = "resultm.from_option / Option does not have a value."
            US72_1(v32)
        | US34_0(v30) -> (* Some *)
            US72_0(v30)
    let v40 : string =
        match v35 with
        | US72_1(v37) -> (* Error *)
            let v38 : string = "sm'.to_string result / Error: " + v37 + ""
            v38
        | US72_0(v36) -> (* Ok *)
            v36
    let v41 : string = method19(v40)
    let v42 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "leptos::html::text($0)"
    let v47 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "leptos::IntoView::into_view($0)"
    let v49 : leptos_View = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : (leptos_View []) = [|v49|]
    let v51 : string = "$0.to_vec()"
    let v52 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "leptos::Fragment::new($0)"
    let v54 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v52 v53
    v54
and method245 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure259(v0)
and closure261 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l8
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method250 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure261(v0)
and closure262 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l10
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method251 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure262(v0)
and closure263 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l7
    let v2 : (float -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method252 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure263(v0)
and method254 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure264 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (std_string_String []) = v0.l5
    let v2 : uint64 = System.Convert.ToUInt64 v1.Length
    let v3 : bool = v2 = 0UL
    if v3 then
        let v4 : string = method4()
        let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
        let v7 : string = "String::from($0)"
        let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
        let v9 : string = "leptos::html::text($0)"
        let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
        let v11 : string = "leptos::IntoView::into_view($0)"
        let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
        let v13 : (leptos_View []) = [|v12|]
        let v14 : string = "$0.to_vec()"
        let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
        let v16 : string = "leptos::Fragment::new($0)"
        let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
        v17
    else
        let v18 : int32 = v1.Length
        let v19 : US34 = US34_1
        let v20 : Mut5 = {l0 = 0; l1 = v19} : Mut5
        while method254(v18, v20) do
            let v22 : int32 = v20.l0
            let v23 : int32 =  -v22
            let v24 : int32 = v23 + v18
            let v25 : int32 = v24 - 1
            let v26 : US34 = v20.l1
            let v27 : std_string_String = v1.[int v25]
            let v28 : string = "fable_library_rust::String_::fromString($0)"
            let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
            let v30 : string = " / result: "
            let v31 : (string []) = v29.Split v30
            let v38 : US34 =
                match v26 with
                | US34_1 -> (* None *)
                    let v32 : uint64 = System.Convert.ToUInt64 v31.Length
                    let v33 : bool = v32 = 2UL
                    if v33 then
                        let v34 : string = v31.[int 0]
                        let v35 : string = v31.[int 1]
                        US34_0(v35)
                    else
                        v26
                | _ ->
                    v26
            let v39 : int32 = v22 + 1
            v20.l0 <- v39
            v20.l1 <- v38
            ()
        let v40 : US34 = v20.l1
        let v44 : string =
            match v40 with
            | US34_1 -> (* None *)
                let v42 : string = "?"
                v42
            | US34_0(v41) -> (* Some *)
                v41
        let v45 : string = method19(v44)
        let v46 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v45 v46
        let v48 : string = "String::from($0)"
        let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v47 v48
        let v50 : string = "leptos::html::text($0)"
        let v51 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v49 v50
        let v52 : string = "leptos::IntoView::into_view($0)"
        let v53 : leptos_View = Fable.Core.RustInterop.emitRustExpr v51 v52
        let v54 : (leptos_View []) = [|v53|]
        let v55 : string = "$0.to_vec()"
        let v56 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v54 v55
        let v57 : string = "leptos::Fragment::new($0)"
        let v58 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v56 v57
        v58
and method253 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure264(v0)
and closure265 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>) () : leptos_Fragment =
    let v2 : bool = v0.l6
    let v5 : string =
        if v2 then
            let v3 : string = "Ok"
            v3
        else
            let v4 : string = "Outcome Error"
            v4
    let v6 : (struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option -> US66) = closure168()
    let v7 : (std_string_String -> US66) = closure169()
    let v8 : US66 = match v1 with Ok x -> v6 x | Error x -> v7 x
    let v17 : US62 =
        match v8 with
        | US66_1(v14) -> (* Error *)
            US62_1(v14)
        | US66_0(v9) -> (* Ok *)
            let v10 : (struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) -> US60) = method163()
            let v11 : US60 = US60_1
            let v12 : US60 = v9 |> Option.map v10 |> Option.defaultValue v11 
            US62_0(v12)
    let v135 : US72 =
        match v17 with
        | US62_1(v130) -> (* Error *)
            let v131 : string = "fable_library_rust::String_::fromString($0)"
            let v132 : string = Fable.Core.RustInterop.emitRustExpr v130 v131
            US72_1(v132)
        | US62_0(v18) -> (* Ok *)
            match v18 with
            | US60_0(v19, v20, v21, v22) -> (* Some *)
                let v23 : (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) -> US67) = method164()
                let v24 : US67 = US67_1
                let v25 : US67 = v19 |> Option.map v23 |> Option.defaultValue v24 
                match v25 with
                | US67_1 -> (* None *)
                    let v74 : string = $"%A{struct (v19, v20, v21, v22)}"
                    let v75 : int64 = System.Convert.ToInt64 v74.Length
                    let v76 : bool = v75 <= 400L
                    let v98 : string =
                        if v76 then
                            v74
                        else
                            let v77 : float = float 400L
                            let v78 : float = v77 / 2.0
                            let v79 : (float -> float) = ceil
                            let v80 : float = v79 v78
                            let v81 : int64 = int64 v80
                            let v82 : (float -> float) = floor
                            let v83 : float = v82 v78
                            let v84 : int64 = int64 v83
                            let v85 : int64 = v81 - 1L
                            let v86 : string = v74.[int 0L..int v85]
                            let v87 : int64 = v75 - v84
                            let v88 : int64 = v75 - 1L
                            let v89 : string = v74.[int v87..int v88]
                            let v90 : string = "..."
                            let v91 : (string []) = [|v86; v90; v89|]
                            let v92 : ((string []) -> string seq) = Seq.ofArray
                            let v93 : string seq = v92 v91
                            let v94 : string = method78()
                            let v95 : (string -> (string seq -> string)) = String.concat
                            let v96 : (string seq -> string) = v95 v94
                            v96 v93
                    US72_0(v98)
                | US67_0(v26, v27, v28, v29, v30, v31) -> (* Some *)
                    let v32 : (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) -> US67) = method164()
                    let v33 : US67 = US67_1
                    let v34 : US67 = v19 |> Option.map v32 |> Option.defaultValue v33 
                    let v44 : US34 =
                        match v34 with
                        | US67_0(v35, v36, v37, v38, v39, v40) -> (* Some *)
                            let v41 : string = string v40 + ": " + string v39 + " - " + string v38 + " (" + string v36 + ")"
                            US34_0(v41)
                        | _ ->
                            US34_1
                    let v72 : string =
                        match v44 with
                        | US34_1 -> (* None *)
                            let v46 : string = $"%A{()}"
                            let v47 : int64 = System.Convert.ToInt64 v46.Length
                            let v48 : bool = v47 <= 400L
                            if v48 then
                                v46
                            else
                                let v49 : float = float 400L
                                let v50 : float = v49 / 2.0
                                let v51 : (float -> float) = ceil
                                let v52 : float = v51 v50
                                let v53 : int64 = int64 v52
                                let v54 : (float -> float) = floor
                                let v55 : float = v54 v50
                                let v56 : int64 = int64 v55
                                let v57 : int64 = v53 - 1L
                                let v58 : string = v46.[int 0L..int v57]
                                let v59 : int64 = v47 - v56
                                let v60 : int64 = v47 - 1L
                                let v61 : string = v46.[int v59..int v60]
                                let v62 : string = "..."
                                let v63 : (string []) = [|v58; v62; v61|]
                                let v64 : ((string []) -> string seq) = Seq.ofArray
                                let v65 : string seq = v64 v63
                                let v66 : string = method78()
                                let v67 : (string -> (string seq -> string)) = String.concat
                                let v68 : (string seq -> string) = v67 v66
                                v68 v65
                        | US34_0(v45) -> (* Some *)
                            v45
                    US72_1(v72)
            | _ ->
                let v102 : string = $"%A{v17}"
                let v103 : int64 = System.Convert.ToInt64 v102.Length
                let v104 : bool = v103 <= 400L
                let v126 : string =
                    if v104 then
                        v102
                    else
                        let v105 : float = float 400L
                        let v106 : float = v105 / 2.0
                        let v107 : (float -> float) = ceil
                        let v108 : float = v107 v106
                        let v109 : int64 = int64 v108
                        let v110 : (float -> float) = floor
                        let v111 : float = v110 v106
                        let v112 : int64 = int64 v111
                        let v113 : int64 = v109 - 1L
                        let v114 : string = v102.[int 0L..int v113]
                        let v115 : int64 = v103 - v112
                        let v116 : int64 = v103 - 1L
                        let v117 : string = v102.[int v115..int v116]
                        let v118 : string = "..."
                        let v119 : (string []) = [|v114; v118; v117|]
                        let v120 : ((string []) -> string seq) = Seq.ofArray
                        let v121 : string seq = v120 v119
                        let v122 : string = method78()
                        let v123 : (string -> (string seq -> string)) = String.concat
                        let v124 : (string seq -> string) = v123 v122
                        v124 v121
                let v127 : string = $"RPC Response: {v126}"
                US72_1(v127)
    let v166 : string =
        match v135 with
        | US72_1(v163) -> (* Error *)
            let v164 : string = $"Error: {v163}"
            v164
        | US72_0(v136) -> (* Ok *)
            let v137 : string = $"%A{v136}"
            let v138 : int64 = System.Convert.ToInt64 v137.Length
            let v139 : bool = v138 <= 400L
            let v161 : string =
                if v139 then
                    v137
                else
                    let v140 : float = float 400L
                    let v141 : float = v140 / 2.0
                    let v142 : (float -> float) = ceil
                    let v143 : float = v142 v141
                    let v144 : int64 = int64 v143
                    let v145 : (float -> float) = floor
                    let v146 : float = v145 v141
                    let v147 : int64 = int64 v146
                    let v148 : int64 = v144 - 1L
                    let v149 : string = v137.[int 0L..int v148]
                    let v150 : int64 = v138 - v147
                    let v151 : int64 = v138 - 1L
                    let v152 : string = v137.[int v150..int v151]
                    let v153 : string = "..."
                    let v154 : (string []) = [|v149; v153; v152|]
                    let v155 : ((string []) -> string seq) = Seq.ofArray
                    let v156 : string seq = v155 v154
                    let v157 : string = method78()
                    let v158 : (string -> (string seq -> string)) = String.concat
                    let v159 : (string seq -> string) = v158 v157
                    v159 v156
            let v162 : string = $"RPC Response: {v161}"
            v162
    let v167 : string = $"{v5} / {v166}"
    let v168 : string = method19(v167)
    let v169 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v170 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v168 v169
    let v171 : string = "String::from($0)"
    let v172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v170 v171
    let v173 : string = "leptos::html::text($0)"
    let v174 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v172 v173
    let v175 : string = "leptos::IntoView::into_view($0)"
    let v176 : leptos_View = Fable.Core.RustInterop.emitRustExpr v174 v175
    let v177 : (leptos_View []) = [|v176|]
    let v178 : string = "$0.to_vec()"
    let v179 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v177 v178
    let v180 : string = "leptos::Fragment::new($0)"
    let v181 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v179 v180
    v181
and method255 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>) : (unit -> leptos_Fragment) =
    closure265(v0, v1)
and closure258 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>) () : leptos_Fragment =
    let v2 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v3 : (unit -> leptos_Fragment) = method245(v0)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method179(v3)
    let v7 : (unit -> leptos_Fragment) = method180(v6)
    let v8 : string = "td"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Td> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v16 : (unit -> leptos_Fragment) = method250(v0)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method179(v16)
    let v19 : (unit -> leptos_Fragment) = method180(v18)
    let v20 : string = "<" + v8 + " " + v17 + ">{v19()}</" + v8 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Td> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v27 : (unit -> leptos_Fragment) = method251(v0)
    let v28 : string = " " + v26 + v4 + ""
    let v29 : (unit -> leptos_Fragment) = method179(v27)
    let v30 : (unit -> leptos_Fragment) = method180(v29)
    let v31 : string = "<" + v8 + " " + v28 + ">{v30()}</" + v8 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Td> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v38 : (unit -> leptos_Fragment) = method252(v0)
    let v39 : string = " " + v37 + v4 + ""
    let v40 : (unit -> leptos_Fragment) = method179(v38)
    let v41 : (unit -> leptos_Fragment) = method180(v40)
    let v42 : string = "<" + v8 + " " + v39 + ">{v41()}</" + v8 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : leptos_HtmlElement<leptos_html_Td> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v49 : (unit -> leptos_Fragment) = method253(v0)
    let v50 : string = " " + v48 + v4 + ""
    let v51 : (unit -> leptos_Fragment) = method179(v49)
    let v52 : (unit -> leptos_Fragment) = method180(v51)
    let v53 : string = "<" + v8 + " " + v50 + ">{v52()}</" + v8 + ">"
    let v54 : string = "leptos::view! { " + v53 + " }"
    let v55 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : leptos_HtmlElement<leptos_html_Td> = v55 |> unbox
    let v57 : string = "leptos::IntoView::into_view($0)"
    let v58 : leptos_View = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v60 : (unit -> leptos_Fragment) = method255(v0, v1)
    let v61 : string = " " + v59 + v4 + ""
    let v62 : (unit -> leptos_Fragment) = method179(v60)
    let v63 : (unit -> leptos_Fragment) = method180(v62)
    let v64 : string = "<" + v8 + " " + v61 + ">{v63()}</" + v8 + ">"
    let v65 : string = "leptos::view! { " + v64 + " }"
    let v66 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v65
    let v67 : leptos_HtmlElement<leptos_html_Td> = v66 |> unbox
    let v68 : string = "leptos::IntoView::into_view($0)"
    let v69 : leptos_View = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : (leptos_View []) = [|v14; v25; v36; v47; v58; v69|]
    let v71 : string = "$0.to_vec()"
    let v72 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v70 v71
    let v73 : string = "leptos::Fragment::new($0)"
    let v74 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v72 v73
    v74
and method244 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>) : (unit -> leptos_Fragment) =
    closure258(v0, v1)
and closure257 (v0 : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])) struct (v1 : string, v2 : unativeint, v3 : Heap5) : leptos_View =
    let v4 : int32 = int32 v2
    let v5 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> = v0.[int v4]
    let v6 : string = "class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\""
    let v7 : (unit -> leptos_Fragment) = method244(v3, v5)
    let v8 : string = ""
    let v9 : string = " " + v6 + v8 + ""
    let v10 : (unit -> leptos_Fragment) = method179(v7)
    let v11 : (unit -> leptos_Fragment) = method180(v10)
    let v12 : string = "tr"
    let v13 : string = "<" + v12 + " " + v9 + ">{v11()}</" + v12 + ">"
    let v14 : string = "leptos::view! { " + v13 + " }"
    let v15 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : leptos_HtmlElement<leptos_html_Tr> = v15 |> unbox
    let v17 : string = "leptos::IntoView::into_view($0)"
    let v18 : leptos_View = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and closure267 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method257 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure267(v0)
and closure268 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method258 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure268(v0)
and closure266 (v0 : leptos_Fragment, v1 : leptos_Fragment) () : leptos_Fragment =
    let v2 : string = "class=\"ltr:text-left rtl:text-right\""
    let v3 : (unit -> leptos_Fragment) = method257(v0)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method179(v3)
    let v7 : (unit -> leptos_Fragment) = method180(v6)
    let v8 : string = "thead"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Thead> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "class=\"divide-y divide-gray-200 dark:divide-gray-700\""
    let v16 : (unit -> leptos_Fragment) = method258(v1)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method179(v16)
    let v19 : (unit -> leptos_Fragment) = method180(v18)
    let v20 : string = "tbody"
    let v21 : string = "<" + v20 + " " + v17 + ">{v19()}</" + v20 + ">"
    let v22 : string = "leptos::view! { " + v21 + " }"
    let v23 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : leptos_HtmlElement<leptos_html_Tbody> = v23 |> unbox
    let v25 : string = "leptos::IntoView::into_view($0)"
    let v26 : leptos_View = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : (leptos_View []) = [|v14; v26|]
    let v28 : string = "$0.to_vec()"
    let v29 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : string = "leptos::Fragment::new($0)"
    let v31 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v29 v30
    v31
and method256 (v0 : leptos_Fragment, v1 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure266(v0, v1)
and closure271 () () : string =
    let v0 : string = "[width:24px] [height:30px]"
    v0
and closure270 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure271()
    let v2 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "version=\"1.1\""
    let v4 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v5 : string = "xmlns:xlink=\"http://www.w3.org/1999/xlink\""
    let v6 : string = "x=\"0px\""
    let v7 : string = "y=\"0px\""
    let v8 : string = "viewBox=\"0 0 24 30\""
    let v9 : string = "style=\"enable-background:new 0 0 50 50;\""
    let v10 : string = "xml:space=\"preserve\""
    let v11 : string = "class=move || \" \".to_owned() + &v2(())"
    let v12 : (unit -> leptos_Fragment) = method211()
    let v13 : string = ""
    let v14 : string = " " + v3 + v13 + ""
    let v15 : string = " " + v4 + v14 + ""
    let v16 : string = " " + v5 + v15 + ""
    let v17 : string = " " + v6 + v16 + ""
    let v18 : string = " " + v7 + v17 + ""
    let v19 : string = " " + v8 + v18 + ""
    let v20 : string = " " + v9 + v19 + ""
    let v21 : string = " " + v10 + v20 + ""
    let v22 : string = " " + v11 + v21 + ""
    let v23 : (unit -> leptos_Fragment) = method179(v12)
    let v24 : (unit -> leptos_Fragment) = method180(v23)
    let v25 : string = "svg"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_svg_Svg> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "Loading..."
    let v33 : string = method19(v32)
    let v34 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : string = "String::from($0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::html::text($0)"
    let v39 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "leptos::IntoView::into_view($0)"
    let v41 : leptos_View = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : (leptos_View []) = [|v31; v41|]
    let v43 : string = "$0.to_vec()"
    let v44 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = "leptos::Fragment::new($0)"
    let v46 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v44 v45
    v46
and method260 () : (unit -> leptos_Fragment) =
    closure270()
and closure269 () () : leptos_Fragment =
    let v0 : string = "class=\"flex flex-1 [gap:4px] items-center\""
    let v1 : (unit -> leptos_Fragment) = method260()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method259 () : (unit -> leptos_Fragment) =
    closure269()
and closure244 (v0 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])>, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) () : leptos_Fragment =
    let v3 : string = $"$0()"
    let v4 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v6 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) []) = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : uint64 = System.Convert.ToUInt64 v6.Length
    let v8 : bool = v7 = 0UL
    let v115 : leptos_View =
        if v8 then
            let v9 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v10 : (unit -> leptos_Fragment) = method224()
            let v11 : string = ""
            let v12 : string = " " + v9 + v11 + ""
            let v13 : (unit -> leptos_Fragment) = method179(v10)
            let v14 : (unit -> leptos_Fragment) = method180(v13)
            let v15 : string = "div"
            let v16 : string = "<" + v15 + " " + v12 + ">{v14()}</" + v15 + ">"
            let v17 : string = "leptos::view! { " + v16 + " }"
            let v18 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v17
            let v19 : leptos_HtmlElement<leptos_html_Div> = v18 |> unbox
            let v20 : string = "leptos::IntoView::into_view($0)"
            let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
            v21
        else
            let v22 : string = $"$0()"
            let v23 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v1 v22
            let v24 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure129()
            let v25 : (std_string_String -> US56) = closure130()
            let v26 : US56 = match v23 with Ok x -> v24 x | Error x -> v25 x
            let v35 : US49 =
                match v26 with
                | US56_1(v32) -> (* Error *)
                    US49_1(v32)
                | US56_0(v27) -> (* Ok *)
                    let v28 : ((struct (string * unativeint * Heap5) []) -> US50) = method142()
                    let v29 : US50 = US50_1
                    let v30 : US50 = v27 |> Option.map v28 |> Option.defaultValue v29 
                    US49_0(v30)
            match v35 with
            | US49_1(v97) -> (* Error *)
                let v98 : string = "fable_library_rust::String_::fromString($0)"
                let v99 : string = Fable.Core.RustInterop.emitRustExpr v97 v98
                let v100 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
                let v101 : (unit -> leptos_Fragment) = method216(v99)
                let v102 : string = ""
                let v103 : string = " " + v100 + v102 + ""
                let v104 : (unit -> leptos_Fragment) = method179(v101)
                let v105 : (unit -> leptos_Fragment) = method180(v104)
                let v106 : string = "div"
                let v107 : string = "<" + v106 + " " + v103 + ">{v105()}</" + v106 + ">"
                let v108 : string = "leptos::view! { " + v107 + " }"
                let v109 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v108
                let v110 : leptos_HtmlElement<leptos_html_Div> = v109 |> unbox
                let v111 : string = "leptos::IntoView::into_view($0)"
                let v112 : leptos_View = Fable.Core.RustInterop.emitRustExpr v110 v111
                v112
            | US49_0(v36) -> (* Ok *)
                match v36 with
                | US50_0(v37) -> (* Some *)
                    let v38 : string = "$0.to_vec()"
                    let v39 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v37 v38
                    let v40 : (struct (string * unativeint * Heap5) -> bool) = method227()
                    let v41 : Vec<struct (string * unativeint * Heap5)> = method230(v39)
                    let v42 : string = "v41.into_iter().filter(|x| v40(x.clone().clone())).collect()"
                    let v43 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v42
                    let v44 : (unit -> leptos_Fragment) = method231()
                    let v45 : (unit -> leptos_Fragment) = method179(v44)
                    let v46 : (unit -> leptos_Fragment) = method180(v45)
                    let v47 : string = "tr"
                    let v48 : string = ""
                    let v49 : string = "<" + v47 + " " + v48 + ">{v46()}</" + v47 + ">"
                    let v50 : string = "leptos::view! { " + v49 + " }"
                    let v51 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v50
                    let v52 : leptos_HtmlElement<leptos_html_Tr> = v51 |> unbox
                    let v53 : string = "leptos::IntoView::into_view($0)"
                    let v54 : leptos_View = Fable.Core.RustInterop.emitRustExpr v52 v53
                    let v55 : (leptos_View []) = [|v54|]
                    let v56 : string = "$0.to_vec()"
                    let v57 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v55 v56
                    let v58 : string = "leptos::Fragment::new($0)"
                    let v59 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v57 v58
                    let v60 : string = $"$0()"
                    let v61 : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v0 v60
                    let v62 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v63 : (struct (string * unativeint * Heap5) -> leptos_View) = closure257(v61)
                    let v64 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v43, v63) v62
                    let v65 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v66 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v64 v65
                    let v67 : string = "$0.to_vec()"
                    let v68 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v66 v67
                    let v69 : string = "leptos::Fragment::new($0)"
                    let v70 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v68 v69
                    let v71 : string = "class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\""
                    let v72 : (unit -> leptos_Fragment) = method256(v59, v70)
                    let v73 : string = " " + v71 + v48 + ""
                    let v74 : (unit -> leptos_Fragment) = method179(v72)
                    let v75 : (unit -> leptos_Fragment) = method180(v74)
                    let v76 : string = "table"
                    let v77 : string = "<" + v76 + " " + v73 + ">{v75()}</" + v76 + ">"
                    let v78 : string = "leptos::view! { " + v77 + " }"
                    let v79 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v78
                    let v80 : leptos_HtmlElement<leptos_html_Table> = v79 |> unbox
                    let v81 : string = "leptos::IntoView::into_view($0)"
                    let v82 : leptos_View = Fable.Core.RustInterop.emitRustExpr v80 v81
                    v82
                | _ ->
                    let v83 : string = "class=\"grid place-content-center py-[10vh]\""
                    let v84 : (unit -> leptos_Fragment) = method259()
                    let v85 : string = ""
                    let v86 : string = " " + v83 + v85 + ""
                    let v87 : (unit -> leptos_Fragment) = method179(v84)
                    let v88 : (unit -> leptos_Fragment) = method180(v87)
                    let v89 : string = "div"
                    let v90 : string = "<" + v89 + " " + v86 + ">{v88()}</" + v89 + ">"
                    let v91 : string = "leptos::view! { " + v90 + " }"
                    let v92 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v91
                    let v93 : leptos_HtmlElement<leptos_html_Div> = v92 |> unbox
                    let v94 : string = "leptos::IntoView::into_view($0)"
                    let v95 : leptos_View = Fable.Core.RustInterop.emitRustExpr v93 v94
                    v95
    let v116 : (leptos_View []) = [|v115|]
    let v117 : string = "$0.to_vec()"
    let v118 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v116 v117
    let v119 : string = "leptos::Fragment::new($0)"
    let v120 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v118 v119
    v120
and method223 (v0 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])>, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) : (unit -> leptos_Fragment) =
    closure244(v0, v1, v2)
and closure274 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure275 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure278 () () : string =
    let v0 : string = "History"
    v0
and method265 () : (unit -> string) =
    closure278()
and closure277 () () : leptos_Fragment =
    let v0 : (unit -> string) = method265()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method198(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method264 () : (unit -> leptos_Fragment) =
    closure277()
and closure276 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method264()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method199()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "span"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Span> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v12; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method263 () : (unit -> leptos_Fragment) =
    closure276()
and closure273 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure274()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure275()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method263()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method179(v8)
    let v12 : (unit -> leptos_Fragment) = method180(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method201(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method179(v21)
    let v24 : (unit -> leptos_Fragment) = method180(v23)
    let v25 : string = "div"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_html_Div> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : (leptos_View []) = [|v19; v31|]
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method262 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure273(v0)
and closure272 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure236()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure237()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method193(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method262(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "details"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Details> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v20; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method261 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure272(v0, v1)
and method266 () : string =
    let v0 : string = "???"
    v0
and closure281 (v0 : int32) (v1 : (bool * std_string_String)) : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) =
    let v2 : string = $"leptos::create_signal($0)"
    let struct (v3 : leptos_ReadSignal<(bool * std_string_String)>, v4 : leptos_WriteSignal<(bool * std_string_String)>) = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v5 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = v0, struct (v3, v4)
    v5
and closure280 () (v0 : int32) : ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) =
    closure281(v0)
and method267 () : (int32 -> ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)))) =
    closure280()
and method268 (v0 : Vec<(bool * std_string_String)>) : Vec<(bool * std_string_String)> =
    v0
and closure279 (v0 : Heap2) () : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : Vec<(bool * std_string_String)> = v6.l1
    let v8 : (int32 -> ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)))) = method267()
    let v9 : Vec<(bool * std_string_String)> = method268(v7)
    let v10 : string = "v9.iter().enumerate().map(|(i, x)| v8(i.try_into().unwrap())(x.clone())).collect()"
    let v11 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v10
    v11
and closure283 () (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>) =
    let (a, b) = v0
    let v1 : int32 = a
    let struct (v2 : leptos_ReadSignal<(bool * std_string_String)>, v3 : leptos_WriteSignal<(bool * std_string_String)>) = b
    struct (v1, v2, v3)
and closure284 (v0 : int32) struct (v1 : int32, v2 : leptos_ReadSignal<(bool * std_string_String)>, v3 : leptos_WriteSignal<(bool * std_string_String)>) : struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) =
    struct (v0, v1, v2)
and closure282 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v1 : leptos_ReadSignal<int32>) () : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = $"$0()"
    let v5 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr v0 v4
    let v6 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v7 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = closure283()
    let v8 : Vec<struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v10 : (struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>) -> struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)) = closure284(v3)
    let v11 : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9
    v11
and closure285 (v0 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>) () : int32 =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v4 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) []) = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : int32 = v4.Length
    v5
and method269 (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) =
    v0
and method270 (v0 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    v0
and closure289 () (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : (bool * std_string_String) =
    let (a, b) = v0
    let v1 : int32 = a
    let struct (v2 : leptos_ReadSignal<(bool * std_string_String)>, v3 : leptos_WriteSignal<(bool * std_string_String)>) = b
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v2 v4
    v5
and closure288 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>) (v1 : Heap0) : Heap0 =
    let v2 : std_string_String option = v1.l0
    let v3 : Vec<(bool * std_string_String)> = v1.l1
    let v4 : int32 = v1.l2
    let v5 : int32 = v1.l3
    let v6 : US1 = v1.l4
    let v7 : string = $"$0()"
    let v8 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr v0 v7
    let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v10 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) []) = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : int32 = v10.Length
    let v12 : string = method4()
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : (bool * std_string_String) = false, v16
    let v18 : string = $"leptos::create_signal($0)"
    let struct (v19 : leptos_ReadSignal<(bool * std_string_String)>, v20 : leptos_WriteSignal<(bool * std_string_String)>) = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v21 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = v11, struct (v19, v20)
    let v22 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = method269(v21)
    let v23 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = method270(v8)
    let v24 : string = "let mut v23 = v23"
    Fable.Core.RustInterop.emitRustExpr () v24
    let v25 : string = "v23.push(v22)"
    Fable.Core.RustInterop.emitRustExpr () v25
    let v26 : string = "v23"
    let v27 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v29 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> (bool * std_string_String)) = closure289()
    let v30 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v28
    {l0 = v2; l1 = v30; l2 = v4; l3 = v5; l4 = v6} : Heap0
and closure290 () (v0 : int32) : int32 =
    let v1 : int32 = 1 + v0
    v1
and closure287 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>) () : unit =
    let v3 : leptos_RwSignal<Heap1> = v0.l0
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : leptos_RwSignal<Heap0> = v5.l1
    let v7 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v8 : (Heap0 -> Heap0) = closure288(v1)
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr struct (v6, v8) v7
    let v10 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v11 : (int32 -> int32) = closure290()
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v11) v10
    ()
and closure286 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>) () : unit =
    let v3 : string = "true; leptos::batch(move || $0());"
    let v4 : (unit -> unit) = closure287(v0, v1, v2)
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v4 v3
    ()
and closure291 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure292 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M12 6v12m6-6H6\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure190()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method271 () : (unit -> leptos_Fragment) =
    closure292()
and method272 () : string =
    let v0 : string = " bg-gray-300 hover:bg-gray-200"
    v0
and closure293 () () : std_string_String =
    let v0 : string = method272()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure294 (v0 : leptos_HtmlElement<leptos_svg_Svg>) () : leptos_Fragment =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (leptos_View []) = [|v2|]
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::Fragment::new($0)"
    let v7 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v5 v6
    v7
and method273 (v0 : leptos_HtmlElement<leptos_svg_Svg>) : (unit -> leptos_Fragment) =
    closure294(v0)
and method276 (v0 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>) : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> =
    v0
and closure297 () struct (v0 : int32, v1 : int32, v2 : leptos_ReadSignal<(bool * std_string_String)>) : struct (int32 * int32) =
    struct (v0, v1)
and method277 () : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> struct (int32 * int32)) =
    closure297()
and method280 (v0 : int32) : int32 =
    v0
and closure300 (v0 : int32) () : std_string_String =
    let v1 : string = "account-" + string v0 + ""
    let v2 : string = method19(v1)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method283 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure304 (v0 : int32, v1 : int32) (v2 : (bool * std_string_String)) : (bool * std_string_String) =
    let v3 : bool = v1 = v0
    let v4 : bool = method283(v3)
    if v4 then
        v2
    else
        let (a, b) = v2
        let v5 : bool = a
        let v6 : std_string_String = b
        let v7 : bool = v5 = false
        let v8 : (bool * std_string_String) = v7, v6
        v8
and closure303 (v0 : int32) (v1 : int32) : ((bool * std_string_String) -> (bool * std_string_String)) =
    closure304(v0, v1)
and method282 (v0 : int32) : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) =
    closure303(v0)
and closure302 (v0 : Heap2, v1 : int32) (v2 : leptos_ev_Event) : unit =
    let v3 : leptos_RwSignal<Heap1> = v0.l0
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : leptos_RwSignal<Heap0> = v5.l1
    let v7 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v8 : Heap0 = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : std_string_String option = v8.l0
    let v10 : Vec<(bool * std_string_String)> = v8.l1
    let v11 : int32 = v8.l2
    let v12 : int32 = v8.l3
    let v13 : US1 = v8.l4
    let v14 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v15 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v14
    let v16 : leptos_RwSignal<Heap0> = v15.l1
    let v17 : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) = method282(v1)
    let v18 : Vec<(bool * std_string_String)> = method268(v10)
    let v19 : string = "v18.iter().enumerate().map(|(i, x)| v17(i.try_into().unwrap())(x.clone())).collect()"
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : Heap0 = {l0 = v9; l1 = v20; l2 = v11; l3 = v12; l4 = v13} : Heap0
    let v22 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr struct (v16, v21) v22
    ()
and closure305 (v0 : leptos_ReadSignal<(bool * std_string_String)>) () : bool =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v0 v1
    let (a, b) = v2
    let v3 : bool = a
    let v4 : std_string_String = b
    v3
and method284 (v0 : leptos_ReadSignal<(bool * std_string_String)>) : (unit -> bool) =
    closure305(v0)
and method285 (v0 : int32) : (unit -> std_string_String) =
    closure300(v0)
and closure307 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure190()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method287 () : (unit -> leptos_Fragment) =
    closure307()
and closure308 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure190()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method288 () : (unit -> leptos_Fragment) =
    closure308()
and closure309 () (v0 : leptos_HtmlElement<leptos_svg_Svg>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure306 () () : leptos_Fragment =
    let v0 : string = "data-unchecked-icon"
    let v1 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v2 : string = "class=\"h-4 w-4\""
    let v3 : string = "viewBox=\"0 0 20 20\""
    let v4 : string = "fill=\"currentColor\""
    let v5 : (unit -> leptos_Fragment) = method287()
    let v6 : string = ""
    let v7 : string = " " + v0 + v6 + ""
    let v8 : string = " " + v1 + v7 + ""
    let v9 : string = " " + v2 + v8 + ""
    let v10 : string = " " + v3 + v9 + ""
    let v11 : string = " " + v4 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v5)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "svg"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_svg_Svg> = v17 |> unbox
    let v19 : string = "data-checked-icon"
    let v20 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v21 : string = "class=\"hidden h-4 w-4\""
    let v22 : string = "viewBox=\"0 0 20 20\""
    let v23 : string = "fill=\"currentColor\""
    let v24 : (unit -> leptos_Fragment) = method288()
    let v25 : string = " " + v19 + v6 + ""
    let v26 : string = " " + v20 + v25 + ""
    let v27 : string = " " + v21 + v26 + ""
    let v28 : string = " " + v22 + v27 + ""
    let v29 : string = " " + v23 + v28 + ""
    let v30 : (unit -> leptos_Fragment) = method179(v24)
    let v31 : (unit -> leptos_Fragment) = method180(v30)
    let v32 : string = "<" + v14 + " " + v29 + ">{v31()}</" + v14 + ">"
    let v33 : string = "leptos::view! { " + v32 + " }"
    let v34 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : leptos_HtmlElement<leptos_svg_Svg> = v34 |> unbox
    let v36 : (leptos_HtmlElement<leptos_svg_Svg> []) = [|v18; v35|]
    let v37 : string = "$0.to_vec()"
    let v38 : Vec<leptos_HtmlElement<leptos_svg_Svg>> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v40 : (leptos_HtmlElement<leptos_svg_Svg> -> leptos_View) = closure309()
    let v41 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v38, v40) v39
    let v42 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v43 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "$0.to_vec()"
    let v45 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "leptos::Fragment::new($0)"
    let v47 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v45 v46
    v47
and method286 () : (unit -> leptos_Fragment) =
    closure306()
and closure310 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method289 () : (unit -> leptos_Fragment) =
    closure310()
and closure301 (v0 : int32, v1 : leptos_ReadSignal<(bool * std_string_String)>, v2 : Heap2) () : leptos_Fragment =
    let v3 : (leptos_ev_Event -> unit) = closure302(v2, v0)
    let v4 : string = "let v3 = $0"
    Fable.Core.RustInterop.emitRustExpr v3 v4
    let v5 : (unit -> bool) = method284(v1)
    let v6 : (unit -> std_string_String) = method285(v0)
    let v7 : string = "class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\""
    let v8 : string = "type=\"checkbox\""
    let v9 : string = "id=move || v6()"
    let v10 : string = "on:change=move |event| v3(event)"
    let v11 : string = "prop:checked=move || v5()"
    let v12 : string = ""
    let v13 : string = " " + v7 + v12 + ""
    let v14 : string = " " + v8 + v13 + ""
    let v15 : string = " " + v9 + v14 + ""
    let v16 : string = " " + v10 + v15 + ""
    let v17 : string = " " + v11 + v16 + ""
    let v18 : string = "input"
    let v19 : string = "<" + v18 + " " + v17 + " />"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Input> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\""
    let v26 : (unit -> leptos_Fragment) = method286()
    let v27 : string = " " + v25 + v12 + ""
    let v28 : (unit -> leptos_Fragment) = method179(v26)
    let v29 : (unit -> leptos_Fragment) = method180(v28)
    let v30 : string = "span"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Span> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v38 : (unit -> leptos_Fragment) = method289()
    let v39 : string = " " + v37 + v12 + ""
    let v40 : (unit -> leptos_Fragment) = method179(v38)
    let v41 : (unit -> leptos_Fragment) = method180(v40)
    let v42 : string = "<" + v30 + " " + v39 + ">{v41()}</" + v30 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : leptos_HtmlElement<leptos_html_Span> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : (leptos_View []) = [|v24; v36; v47|]
    let v49 : string = "$0.to_vec()"
    let v50 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "leptos::Fragment::new($0)"
    let v52 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v50 v51
    v52
and method281 (v0 : int32, v1 : leptos_ReadSignal<(bool * std_string_String)>, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure301(v0, v1, v2)
and closure311 (v0 : leptos_ReadSignal<(bool * std_string_String)>) () : std_string_String =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v0 v1
    let (a, b) = v2
    let v3 : bool = a
    let v4 : std_string_String = b
    v4
and method290 (v0 : leptos_ReadSignal<(bool * std_string_String)>) : (unit -> std_string_String) =
    closure311(v0)
and method293 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure314 (v0 : int32, v1 : std_string_String, v2 : int32) (v3 : (bool * std_string_String)) : (bool * std_string_String) =
    let v4 : bool = v2 = v0
    let v5 : bool = method293(v4)
    if v5 then
        v3
    else
        let (a, b) = v3
        let v6 : bool = a
        let v7 : std_string_String = b
        let v8 : (bool * std_string_String) = v6, v1
        v8
and closure313 (v0 : int32, v1 : std_string_String) (v2 : int32) : ((bool * std_string_String) -> (bool * std_string_String)) =
    closure314(v0, v1, v2)
and method292 (v0 : int32, v1 : std_string_String) : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) =
    closure313(v0, v1)
and closure312 (v0 : Heap2, v1 : int32) (v2 : std_string_String) : unit =
    let v3 : leptos_RwSignal<Heap1> = v0.l0
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : leptos_RwSignal<Heap0> = v5.l1
    let v7 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v8 : Heap0 = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : std_string_String option = v8.l0
    let v10 : Vec<(bool * std_string_String)> = v8.l1
    let v11 : int32 = v8.l2
    let v12 : int32 = v8.l3
    let v13 : US1 = v8.l4
    let v14 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v15 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v14
    let v16 : leptos_RwSignal<Heap0> = v15.l1
    let v17 : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) = method292(v1, v2)
    let v18 : Vec<(bool * std_string_String)> = method268(v10)
    let v19 : string = "v18.iter().enumerate().map(|(i, x)| v17(i.try_into().unwrap())(x.clone())).collect()"
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : Heap0 = {l0 = v9; l1 = v20; l2 = v11; l3 = v12; l4 = v13} : Heap0
    let v22 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr struct (v16, v21) v22
    ()
and method291 (v0 : Heap2, v1 : int32) : (std_string_String -> unit) =
    closure312(v0, v1)
and closure315 () () : string =
    let v0 : string = "flex-1"
    v0
and method294 (v0 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    v0
and closure320 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method296 () : (bool -> bool) =
    closure320()
and closure319 (v0 : int32) (v1 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : bool =
    let (a, b) = v1
    let v2 : int32 = a
    let struct (v3 : leptos_ReadSignal<(bool * std_string_String)>, v4 : leptos_WriteSignal<(bool * std_string_String)>) = b
    let v5 : bool = v2 = v0
    let v6 : (bool -> bool) = method296()
    v6 v5
and method295 (v0 : int32) : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> bool) =
    closure319(v0)
and closure318 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v1 : int32) (v2 : Heap0) : Heap0 =
    let v3 : std_string_String option = v2.l0
    let v4 : Vec<(bool * std_string_String)> = v2.l1
    let v5 : int32 = v2.l2
    let v6 : int32 = v2.l3
    let v7 : US1 = v2.l4
    let v8 : string = $"$0()"
    let v9 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr v0 v8
    let v10 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = method294(v9)
    let v11 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> bool) = method295(v1)
    let v12 : string = "let mut v10 = v10"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "v10.retain(|x| v11(x.clone()))"
    Fable.Core.RustInterop.emitRustExpr () v13
    let v14 : string = "v10"
    let v15 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v17 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> (bool * std_string_String)) = closure289()
    let v18 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v15, v17) v16
    {l0 = v3; l1 = v18; l2 = v5; l3 = v6; l4 = v7} : Heap0
and closure317 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>, v3 : int32) () : unit =
    let v4 : leptos_RwSignal<Heap1> = v0.l0
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap1 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : leptos_RwSignal<Heap0> = v6.l1
    let v8 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v9 : (Heap0 -> Heap0) = closure318(v1, v3)
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v12 : (int32 -> int32) = closure290()
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v12) v11
    ()
and closure316 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>, v3 : int32) () : unit =
    let v4 : string = "true; leptos::batch(move || $0());"
    let v5 : (unit -> unit) = closure317(v0, v1, v2, v3)
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v5 v4
    ()
and closure321 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure322 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M6 6l12 12m0-12L6 18\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure190()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method297 () : (unit -> leptos_Fragment) =
    closure322()
and method298 () : string =
    let v0 : string = " pr-[7px] pl-[5px]"
    v0
and closure323 () () : std_string_String =
    let v0 : string = method298()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure299 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>, v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : int32) () : leptos_Fragment =
    let v6 : int32 = method280(v5)
    let v7 : (unit -> std_string_String) = closure300(v6)
    let v8 : string = "let v7 = $0"
    Fable.Core.RustInterop.emitRustExpr v7 v8
    let v9 : string = "for=move || v7()"
    let v10 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v11 : (unit -> leptos_Fragment) = method281(v6, v4, v0)
    let v12 : string = ""
    let v13 : string = " " + v9 + v12 + ""
    let v14 : string = " " + v10 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method179(v11)
    let v16 : (unit -> leptos_Fragment) = method180(v15)
    let v17 : string = "label"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Label> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (unit -> std_string_String) = method290(v4)
    let v25 : (std_string_String -> unit) = method291(v0, v6)
    let v26 : string = "$0"
    let v27 : (unit -> string) = closure315()
    let v28 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v27 v26
    let v29 : string = "class=move || \"bg-gray-50 h-[31px] [font-size:.875rem] \".to_owned() + &v28(())"
    let v30 : string = "prop:value=move || v24()"
    let v31 : string = "on:keyup=move |event: web_sys::KeyboardEvent| v25(leptos::event_target_value(&event))"
    let v32 : string = " " + v29 + v12 + ""
    let v33 : string = " " + v30 + v32 + ""
    let v34 : string = " " + v31 + v33 + ""
    let v35 : string = "input"
    let v36 : string = "<" + v35 + " " + v34 + " />"
    let v37 : string = "leptos::view! { " + v36 + " }"
    let v38 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v37
    let v39 : leptos_HtmlElement<leptos_html_Input> = v38 |> unbox
    let v40 : string = "leptos::IntoView::into_view($0)"
    let v41 : leptos_View = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = $"$0()"
    let v43 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v42
    let v44 : bool = v43 = 1
    let v93 : leptos_View =
        if v44 then
            let v45 : (leptos_View []) = [||]
            let v46 : (leptos_View []) = method167(v45)
            let v47 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v48 : leptos_View = Fable.Core.RustInterop.emitRustExpr v46 v47
            v48
        else
            let v49 : (unit -> unit) = closure316(v0, v2, v3, v6)
            let v50 : string = "let v49 = $0"
            Fable.Core.RustInterop.emitRustExpr v49 v50
            let v51 : string = "$0"
            let v52 : (unit -> string) = closure321()
            let v53 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v52 v51
            let v54 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v55 : string = "fill=\"none\""
            let v56 : string = "viewBox=\"0 0 24 24\""
            let v57 : string = "stroke-width=\"1.5\""
            let v58 : string = "stroke=\"currentColor\""
            let v59 : string = "class=move || \" \".to_owned() + &v53(())"
            let v60 : (unit -> leptos_Fragment) = method297()
            let v61 : string = " " + v54 + v12 + ""
            let v62 : string = " " + v55 + v61 + ""
            let v63 : string = " " + v56 + v62 + ""
            let v64 : string = " " + v57 + v63 + ""
            let v65 : string = " " + v58 + v64 + ""
            let v66 : string = " " + v59 + v65 + ""
            let v67 : (unit -> leptos_Fragment) = method179(v60)
            let v68 : (unit -> leptos_Fragment) = method180(v67)
            let v69 : string = "svg"
            let v70 : string = "<" + v69 + " " + v66 + ">{v68()}</" + v69 + ">"
            let v71 : string = "leptos::view! { " + v70 + " }"
            let v72 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v71
            let v73 : leptos_HtmlElement<leptos_svg_Svg> = v72 |> unbox
            let v74 : string = "on:click=move |_| v49()"
            let v75 : string = "aria-label=\"Delete\""
            let v76 : string = "$0"
            let v77 : (unit -> std_string_String) = closure323()
            let v78 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v77 v76
            let v79 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v78(())"
            let v80 : (unit -> leptos_Fragment) = method273(v73)
            let v81 : string = " " + v79 + v12 + ""
            let v82 : string = " " + v74 + v81 + ""
            let v83 : string = " " + v75 + v82 + ""
            let v84 : (unit -> leptos_Fragment) = method179(v80)
            let v85 : (unit -> leptos_Fragment) = method180(v84)
            let v86 : string = "button"
            let v87 : string = "<" + v86 + " " + v83 + ">{v85()}</" + v86 + ">"
            let v88 : string = "leptos::view! { " + v87 + " }"
            let v89 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v88
            let v90 : leptos_HtmlElement<leptos_html_Button> = v89 |> unbox
            let v91 : string = "leptos::IntoView::into_view($0)"
            let v92 : leptos_View = Fable.Core.RustInterop.emitRustExpr v90 v91
            v92
    let v94 : (leptos_View []) = [|v23; v41; v93|]
    let v95 : string = "$0.to_vec()"
    let v96 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v94 v95
    let v97 : string = "leptos::Fragment::new($0)"
    let v98 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v96 v97
    v98
and method279 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>, v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : int32) : (unit -> leptos_Fragment) =
    closure299(v0, v1, v2, v3, v4, v5)
and closure298 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>) struct (v4 : int32, v5 : int32, v6 : leptos_ReadSignal<(bool * std_string_String)>) : leptos_Fragment =
    let v7 : string = "class=\"flex gap-[8px] [align-items:center]\""
    let v8 : (unit -> leptos_Fragment) = method279(v0, v1, v2, v3, v6, v5)
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method179(v8)
    let v12 : (unit -> leptos_Fragment) = method180(v11)
    let v13 : string = "div"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Div> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : (leptos_View []) = [|v19|]
    let v21 : string = "$0.to_vec()"
    let v22 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "leptos::Fragment::new($0)"
    let v24 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v22 v23
    v24
and method278 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>) : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> leptos_Fragment) =
    closure298(v0, v1, v2, v3)
and closure296 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) () : leptos_Fragment =
    let v5 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> = method276(v1)
    let v6 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> struct (int32 * int32)) = method277()
    let v7 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> leptos_Fragment) = method278(v0, v2, v3, v4)
    let v8 : string = "each=v5"
    let v9 : string = "key=move |x| v6(x.to_owned())"
    let v10 : string = "let:x"
    let v11 : string = "children=move |x| v7(x)"
    let v12 : string = ""
    let v13 : string = " " + v8 + v12 + ""
    let v14 : string = " " + v9 + v13 + ""
    let v15 : string = " " + v10 + v14 + ""
    let v16 : string = " " + v11 + v15 + ""
    let v17 : string = "leptos::For"
    let v18 : string = "<" + v17 + " " + v16 + " />"
    let v19 : string = "leptos::IntoView::into_view(leptos::view! { " + v18 + " })"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : (leptos_View []) = [|v20|]
    let v22 : string = "$0.to_vec()"
    let v23 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "leptos::Fragment::new($0)"
    let v25 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v23 v24
    v25
and method275 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) : (unit -> leptos_Fragment) =
    closure296(v0, v1, v2, v3, v4)
and closure295 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) () : leptos_Fragment =
    let v5 : string = "class=\"flex flex-1 flex-col p-[8px] gap-[8px]\""
    let v6 : (unit -> leptos_Fragment) = method275(v0, v1, v2, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "div"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Div> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : (leptos_View []) = [|v17|]
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::Fragment::new($0)"
    let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
and method274 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) : (unit -> leptos_Fragment) =
    closure295(v0, v1, v2, v3, v4)
and closure326 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure327 (v0 : leptos_View) () : StaticRef<Str> =
    let v4 : string = "[margin-right:40px]"
    let v5 : string = "r#\"" + v4 + "\"#"
    let v6 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and closure330 () () : string =
    let v0 : string = "Accounts"
    v0
and method303 (v0 : leptos_View) : (unit -> string) =
    closure330()
and closure329 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (unit -> string) = method303(v0)
    let v2 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v3 : (unit -> leptos_Fragment) = method198(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method179(v3)
    let v7 : (unit -> leptos_Fragment) = method180(v6)
    let v8 : string = "span"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Span> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : (leptos_View []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::Fragment::new($0)"
    let v19 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v17 v18
    v19
and method302 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure329(v0)
and closure328 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : string = "class=\"flex items-center gap-2\""
    let v2 : (unit -> leptos_Fragment) = method302(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v15 : (unit -> leptos_Fragment) = method199()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v15)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "span"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Span> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : (leptos_View []) = [|v13; v25|]
    let v27 : string = "$0.to_vec()"
    let v28 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "leptos::Fragment::new($0)"
    let v30 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v28 v29
    v30
and method301 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure328(v0)
and closure325 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure326()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> StaticRef<Str>) = closure327(v0)
    let v7 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v7(()) + \" \" + &v4(())"
    let v9 : (unit -> leptos_Fragment) = method301(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "summary"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Summary> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=\"flex flex-1 flex-col\""
    let v22 : (unit -> leptos_Fragment) = method201(v1)
    let v23 : string = " " + v21 + v10 + ""
    let v24 : (unit -> leptos_Fragment) = method179(v22)
    let v25 : (unit -> leptos_Fragment) = method180(v24)
    let v26 : string = "div"
    let v27 : string = "<" + v26 + " " + v23 + ">{v25()}</" + v26 + ">"
    let v28 : string = "leptos::view! { " + v27 + " }"
    let v29 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : leptos_HtmlElement<leptos_html_Div> = v29 |> unbox
    let v31 : string = "leptos::IntoView::into_view($0)"
    let v32 : leptos_View = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : (leptos_View []) = [|v20; v32|]
    let v34 : string = "$0.to_vec()"
    let v35 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : string = "leptos::Fragment::new($0)"
    let v37 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v35 v36
    v37
and method300 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure325(v0, v1)
and closure324 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure236()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure237()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method193(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method300(v0, v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "details"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Details> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v20; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method299 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure324(v0, v1)
and closure333 () () : string =
    let v0 : string = "items-center p-0"
    v0
and closure334 () () : string =
    let v0 : string = "pt-[9px] pr-[10px] pb-[11px] pl-[10px]"
    v0
and closure335 () () : string =
    let v0 : string = "sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]"
    v0
and method307 () : string =
    let v0 : string = "Dark Mode"
    v0
and closure336 () () : leptos_Fragment =
    let v0 : string = method307()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method306 () : (unit -> leptos_Fragment) =
    closure336()
and method309 () : string =
    let v0 : string = "dark-mode"
    v0
and closure338 () () : std_string_String =
    let v0 : string = method309()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure341 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure340 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<bool> = v4.l0
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure341()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    ()
and closure342 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<bool> = v3.l0
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method311 (v0 : Heap2) : (unit -> bool) =
    closure342(v0)
and method312 () : (unit -> std_string_String) =
    closure338()
and closure339 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure340(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : (unit -> bool) = method311(v0)
    let v4 : (unit -> std_string_String) = method312()
    let v5 : string = "class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\""
    let v6 : string = "type=\"checkbox\""
    let v7 : string = "id=move || v4()"
    let v8 : string = "on:change=move |event| v1(event)"
    let v9 : string = "prop:checked=move || v3()"
    let v10 : string = ""
    let v11 : string = " " + v5 + v10 + ""
    let v12 : string = " " + v6 + v11 + ""
    let v13 : string = " " + v7 + v12 + ""
    let v14 : string = " " + v8 + v13 + ""
    let v15 : string = " " + v9 + v14 + ""
    let v16 : string = "input"
    let v17 : string = "<" + v16 + " " + v15 + " />"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_html_Input> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\""
    let v24 : (unit -> leptos_Fragment) = method286()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v24)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method289()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method179(v36)
    let v39 : (unit -> leptos_Fragment) = method180(v38)
    let v40 : string = "<" + v28 + " " + v37 + ">{v39()}</" + v28 + ">"
    let v41 : string = "leptos::view! { " + v40 + " }"
    let v42 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : leptos_HtmlElement<leptos_html_Span> = v42 |> unbox
    let v44 : string = "leptos::IntoView::into_view($0)"
    let v45 : leptos_View = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : (leptos_View []) = [|v22; v34; v45|]
    let v47 : string = "$0.to_vec()"
    let v48 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "leptos::Fragment::new($0)"
    let v50 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v48 v49
    v50
and method310 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure339(v0)
and closure337 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure338()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method310(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v5)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "label"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Label> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : (leptos_View []) = [|v17|]
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::Fragment::new($0)"
    let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
and method308 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure337(v0)
and closure344 () () : string =
    let v0 : string = "[overflow:auto]"
    v0
and method314 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    v0
and closure343 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method313 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure343(v0, v1)
and closure345 () () : string =
    let v0 : string = "items-center p-0"
    v0
and method316 () : string =
    let v0 : string = "Debug"
    v0
and closure346 () () : leptos_Fragment =
    let v0 : string = method316()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method315 () : (unit -> leptos_Fragment) =
    closure346()
and method318 () : string =
    let v0 : string = "debug"
    v0
and closure348 () () : std_string_String =
    let v0 : string = method318()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure350 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<bool> = v4.l2
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure341()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    ()
and closure351 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<bool> = v3.l2
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method320 (v0 : Heap2) : (unit -> bool) =
    closure351(v0)
and method321 () : (unit -> std_string_String) =
    closure348()
and closure349 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure350(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : (unit -> bool) = method320(v0)
    let v4 : (unit -> std_string_String) = method321()
    let v5 : string = "class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\""
    let v6 : string = "type=\"checkbox\""
    let v7 : string = "id=move || v4()"
    let v8 : string = "on:change=move |event| v1(event)"
    let v9 : string = "prop:checked=move || v3()"
    let v10 : string = ""
    let v11 : string = " " + v5 + v10 + ""
    let v12 : string = " " + v6 + v11 + ""
    let v13 : string = " " + v7 + v12 + ""
    let v14 : string = " " + v8 + v13 + ""
    let v15 : string = " " + v9 + v14 + ""
    let v16 : string = "input"
    let v17 : string = "<" + v16 + " " + v15 + " />"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_html_Input> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\""
    let v24 : (unit -> leptos_Fragment) = method286()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v24)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method289()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method179(v36)
    let v39 : (unit -> leptos_Fragment) = method180(v38)
    let v40 : string = "<" + v28 + " " + v37 + ">{v39()}</" + v28 + ">"
    let v41 : string = "leptos::view! { " + v40 + " }"
    let v42 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : leptos_HtmlElement<leptos_html_Span> = v42 |> unbox
    let v44 : string = "leptos::IntoView::into_view($0)"
    let v45 : leptos_View = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : (leptos_View []) = [|v22; v34; v45|]
    let v47 : string = "$0.to_vec()"
    let v48 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "leptos::Fragment::new($0)"
    let v50 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v48 v49
    v50
and method319 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure349(v0)
and closure347 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure348()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method319(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v5)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "label"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Label> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : (leptos_View []) = [|v17|]
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::Fragment::new($0)"
    let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
and method317 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure347(v0)
and closure352 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method322 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure352(v0, v1)
and closure353 () (v0 : leptos_HtmlElement<leptos_html_Dl>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure332 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure333()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure334()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure335()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : (unit -> leptos_Fragment) = method306()
    let v11 : (unit -> leptos_Fragment) = method308(v0)
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v9(()) + \" \" + &v6(()) + \" \" + &v3(())"
    let v13 : (unit -> leptos_Fragment) = method313(v10, v11)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v13)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "dl"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Dl> = v21 |> unbox
    let v23 : string = "$0"
    let v24 : (unit -> string) = closure345()
    let v25 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v24 v23
    let v26 : string = "$0"
    let v27 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v26
    let v28 : string = "$0"
    let v29 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v28
    let v30 : (unit -> leptos_Fragment) = method315()
    let v31 : (unit -> leptos_Fragment) = method317(v0)
    let v32 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v29(()) + \" \" + &v27(()) + \" \" + &v25(())"
    let v33 : (unit -> leptos_Fragment) = method322(v30, v31)
    let v34 : string = " " + v32 + v14 + ""
    let v35 : (unit -> leptos_Fragment) = method179(v33)
    let v36 : (unit -> leptos_Fragment) = method180(v35)
    let v37 : string = "<" + v18 + " " + v34 + ">{v36()}</" + v18 + ">"
    let v38 : string = "leptos::view! { " + v37 + " }"
    let v39 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : leptos_HtmlElement<leptos_html_Dl> = v39 |> unbox
    let v41 : (leptos_HtmlElement<leptos_html_Dl> []) = [|v22; v40|]
    let v42 : string = "$0.to_vec()"
    let v43 : Vec<leptos_HtmlElement<leptos_html_Dl>> = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v45 : (leptos_HtmlElement<leptos_html_Dl> -> leptos_View) = closure353()
    let v46 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v43, v45) v44
    let v47 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v48 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "$0.to_vec()"
    let v50 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "leptos::Fragment::new($0)"
    let v52 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v50 v51
    v52
and method305 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure332(v0)
and closure331 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col p-[11px] gap-[11px]\""
    let v2 : (unit -> leptos_Fragment) = method305(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method304 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure331(v0)
and closure356 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure357 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure360 () () : string =
    let v0 : string = "View"
    v0
and method327 () : (unit -> string) =
    closure360()
and closure359 () () : leptos_Fragment =
    let v0 : (unit -> string) = method327()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method198(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method326 () : (unit -> leptos_Fragment) =
    closure359()
and closure358 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method326()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method199()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "span"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Span> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v12; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method325 () : (unit -> leptos_Fragment) =
    closure358()
and closure355 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure356()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure357()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method325()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method179(v8)
    let v12 : (unit -> leptos_Fragment) = method180(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method201(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method179(v21)
    let v24 : (unit -> leptos_Fragment) = method180(v23)
    let v25 : string = "div"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_html_Div> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : (leptos_View []) = [|v19; v31|]
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method324 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure355(v0)
and closure354 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure236()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure237()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method193(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method324(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "details"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Details> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v20; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method323 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure354(v0, v1)
and closure362 () () : string =
    let v0 : string = ""
    v0
and method330 () : string =
    let v0 : string = "Global State"
    v0
and closure363 () () : leptos_Fragment =
    let v0 : string = method330()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method329 () : (unit -> leptos_Fragment) =
    closure363()
and method332 (v0 : Heap2) : Heap2 =
    v0
and closure366 () (v0 : std_string_String) : US73 =
    US73_0(v0)
and closure367 () (v0 : std_string_String) : US73 =
    US73_1(v0)
and closure365 (v0 : Heap2) () : string =
    let v1 : string = "settings_view.global_state_log_render () / global_state_json memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : Heap2 = method332(v0)
    let v5 : string = "serde_json::to_string_pretty(&v4).map_err(|x| x.to_string())"
    let v6 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_string_String -> US73) = closure366()
    let v8 : (std_string_String -> US73) = closure367()
    let v9 : US73 = match v6 with Ok x -> v7 x | Error x -> v8 x
    match v9 with
    | US73_1(v13) -> (* Error *)
        let v14 : string = "Error: " + string v13 + ""
        v14
    | US73_0(v10) -> (* Ok *)
        let v11 : string = "fable_library_rust::String_::fromString($0)"
        let v12 : string = Fable.Core.RustInterop.emitRustExpr v10 v11
        v12
and closure368 () () : string =
    let v0 : string = ""
    v0
and closure369 (v0 : string) () : leptos_Fragment =
    let v1 : string = method19(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : (leptos_View []) = [|v9|]
    let v11 : string = "$0.to_vec()"
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "leptos::Fragment::new($0)"
    let v14 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v12 v13
    v14
and method333 (v0 : string) : (unit -> leptos_Fragment) =
    closure369(v0)
and closure364 () () : leptos_Fragment =
    let v0 : string = "settings_view.global_state_log_render ()"
    let v1 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
    let v4 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "$0.unwrap()"
    let v6 : Heap2 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure365(v6)
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : string = "leptos::create_memo(move |_| { v9(()) })"
    let v11 : leptos_Memo<string> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = $"$0()"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0"
    let v15 : (unit -> string) = closure368()
    let v16 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v15 v14
    let v17 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v16(())"
    let v18 : (unit -> leptos_Fragment) = method333(v13)
    let v19 : string = ""
    let v20 : string = " " + v17 + v19 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v18)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "pre"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Pre> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method331 () : (unit -> leptos_Fragment) =
    closure364()
and closure370 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method334 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure370(v0, v1)
and closure361 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure362()
    let v2 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "$0"
    let v4 : (unit -> string) = closure334()
    let v5 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v4 v3
    let v6 : string = "$0"
    let v7 : (unit -> string) = closure335()
    let v8 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v6
    let v9 : (unit -> leptos_Fragment) = method329()
    let v10 : (unit -> leptos_Fragment) = method331()
    let v11 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v8(()) + \" \" + &v5(()) + \" \" + &v2(())"
    let v12 : (unit -> leptos_Fragment) = method334(v9, v10)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method179(v12)
    let v16 : (unit -> leptos_Fragment) = method180(v15)
    let v17 : string = "dl"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Dl> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (leptos_View []) = [|v23|]
    let v25 : string = "$0.to_vec()"
    let v26 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "leptos::Fragment::new($0)"
    let v28 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v26 v27
    v28
and method328 () : (unit -> leptos_Fragment) =
    closure361()
and closure373 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure374 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure377 () () : string =
    let v0 : string = "Debug"
    v0
and method339 () : (unit -> string) =
    closure377()
and closure376 () () : leptos_Fragment =
    let v0 : (unit -> string) = method339()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method198(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method338 () : (unit -> leptos_Fragment) =
    closure376()
and closure375 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method338()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method199()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "span"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Span> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v12; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method337 () : (unit -> leptos_Fragment) =
    closure375()
and closure372 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure373()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure374()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method337()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method179(v8)
    let v12 : (unit -> leptos_Fragment) = method180(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method201(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method179(v21)
    let v24 : (unit -> leptos_Fragment) = method180(v23)
    let v25 : string = "div"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_html_Div> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : (leptos_View []) = [|v19; v31|]
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method336 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure372(v0)
and closure371 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure236()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure237()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method193(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method336(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "details"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Details> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v20; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method335 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure371(v0, v1)
and closure378 (v0 : leptos_WriteSignal<bool>) () : unit =
    let v1 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v2 : (bool -> bool) = closure341()
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1
    ()
and closure379 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure380 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : string = "leptos::IntoView::into_view($0)"
    let v16 : leptos_View = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "stroke-linecap=\"round\""
    let v18 : string = "stroke-linejoin=\"round\""
    let v19 : string = "d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\""
    let v20 : (unit -> leptos_Fragment) = method178()
    let v21 : string = " " + v17 + v4 + ""
    let v22 : string = " " + v18 + v21 + ""
    let v23 : string = " " + v19 + v22 + ""
    let v24 : (unit -> leptos_Fragment) = method179(v20)
    let v25 : (unit -> leptos_Fragment) = method180(v24)
    let v26 : string = "<" + v10 + " " + v23 + ">{v25()}</" + v10 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_svg_Path> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : (leptos_View []) = [|v16; v31|]
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method340 () : (unit -> leptos_Fragment) =
    closure380()
and method341 (v0 : StaticRef<Str>) : StaticRef<Str> =
    v0
and closure381 (v0 : leptos_ReadSignal<bool>) () : std_string_String =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v9 : StaticRef<Str> =
        if v2 then
            let v3 : string = ""
            let v4 : string = "r#\"" + v3 + "\"#"
            let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
            v5
        else
            let v6 : string = "bg-gray-300 hover:bg-gray-200"
            let v7 : string = "r#\"" + v6 + "\"#"
            let v8 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v7
            v8
    let v10 : StaticRef<Str> = method341(v9)
    let v11 : string = "v10.to_owned() + \" hover:bg-gray-200\""
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11
    v12
and method345 () : string =
    let v0 : string = "Settings"
    v0
and closure384 () () : leptos_Fragment =
    let v0 : string = method345()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method344 () : (unit -> leptos_Fragment) =
    closure384()
and closure385 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "Func0::new(move || $0())"
    let v2 : Func0<leptos_Fragment> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::IntoView::into_view(move || $0())"
    let v4 : leptos_View = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : (leptos_View []) = [|v4|]
    let v6 : string = "$0.to_vec()"
    let v7 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::Fragment::new($0)"
    let v9 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v7 v8
    v9
and method346 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure385(v0)
and closure387 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    v0 ()
and method348 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure387(v0)
and closure388 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method349 () : (unit -> leptos_Fragment) =
    closure388()
and closure386 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "class=\"pr-[15px] [font-size:13px]\""
    let v2 : (unit -> leptos_Fragment) = method348(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"h-px flex-1 bg-gray-300\""
    let v15 : (unit -> leptos_Fragment) = method349()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v15)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "<" + v7 + " " + v16 + ">{v18()}</" + v7 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Span> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v13; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method347 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure386(v0)
and closure389 () () : string =
    let v0 : string = "items-center"
    v0
and method351 () : string =
    let v0 : string = "Table View"
    v0
and closure390 () () : leptos_Fragment =
    let v0 : string = method351()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method350 () : (unit -> leptos_Fragment) =
    closure390()
and method353 () : string =
    let v0 : string = "table-view"
    v0
and closure392 () () : std_string_String =
    let v0 : string = method353()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure395 () (v0 : Heap0) : Heap0 =
    let v1 : std_string_String option = v0.l0
    let v2 : Vec<(bool * std_string_String)> = v0.l1
    let v3 : int32 = v0.l2
    let v4 : int32 = v0.l3
    let v5 : US1 = v0.l4
    let v7 : bool =
        match v5 with
        | US1_1 -> (* Table *)
            true
        | _ ->
            false
    let v10 : US1 =
        if v7 then
            US1_0
        else
            US1_1
    {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v10} : Heap0
and closure394 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<Heap0> = v4.l1
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (Heap0 -> Heap0) = closure395()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    ()
and closure396 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : US1 = v6.l4
    match v7 with
    | US1_1 -> (* Table *)
        true
    | _ ->
        false
and method355 (v0 : Heap2) : (unit -> bool) =
    closure396(v0)
and method356 () : (unit -> std_string_String) =
    closure392()
and closure393 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure394(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : (unit -> bool) = method355(v0)
    let v4 : (unit -> std_string_String) = method356()
    let v5 : string = "class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\""
    let v6 : string = "type=\"checkbox\""
    let v7 : string = "id=move || v4()"
    let v8 : string = "on:change=move |event| v1(event)"
    let v9 : string = "prop:checked=move || v3()"
    let v10 : string = ""
    let v11 : string = " " + v5 + v10 + ""
    let v12 : string = " " + v6 + v11 + ""
    let v13 : string = " " + v7 + v12 + ""
    let v14 : string = " " + v8 + v13 + ""
    let v15 : string = " " + v9 + v14 + ""
    let v16 : string = "input"
    let v17 : string = "<" + v16 + " " + v15 + " />"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_html_Input> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\""
    let v24 : (unit -> leptos_Fragment) = method286()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v24)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method289()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method179(v36)
    let v39 : (unit -> leptos_Fragment) = method180(v38)
    let v40 : string = "<" + v28 + " " + v37 + ">{v39()}</" + v28 + ">"
    let v41 : string = "leptos::view! { " + v40 + " }"
    let v42 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : leptos_HtmlElement<leptos_html_Span> = v42 |> unbox
    let v44 : string = "leptos::IntoView::into_view($0)"
    let v45 : leptos_View = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : (leptos_View []) = [|v22; v34; v45|]
    let v47 : string = "$0.to_vec()"
    let v48 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "leptos::Fragment::new($0)"
    let v50 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v48 v49
    v50
and method354 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure393(v0)
and closure391 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure392()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method354(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v5)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "label"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Label> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : (leptos_View []) = [|v17|]
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::Fragment::new($0)"
    let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
and method352 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure391(v0)
and closure397 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method357 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure397(v0, v1)
and closure383 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> leptos_Fragment) = method344()
    let v2 : (unit -> leptos_Fragment) = method346(v1)
    let v3 : string = "class=\"flex items-center pb-[6px]\""
    let v4 : (unit -> leptos_Fragment) = method347(v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method179(v4)
    let v8 : (unit -> leptos_Fragment) = method180(v7)
    let v9 : string = "span"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : leptos_HtmlElement<leptos_html_Span> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0"
    let v17 : (unit -> string) = closure389()
    let v18 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "$0"
    let v20 : (unit -> string) = closure334()
    let v21 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v19
    let v22 : string = "$0"
    let v23 : (unit -> string) = closure335()
    let v24 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v23 v22
    let v25 : (unit -> leptos_Fragment) = method350()
    let v26 : (unit -> leptos_Fragment) = method352(v0)
    let v27 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v24(()) + \" \" + &v21(()) + \" \" + &v18(())"
    let v28 : (unit -> leptos_Fragment) = method357(v25, v26)
    let v29 : string = " " + v27 + v5 + ""
    let v30 : (unit -> leptos_Fragment) = method179(v28)
    let v31 : (unit -> leptos_Fragment) = method180(v30)
    let v32 : string = "dl"
    let v33 : string = "<" + v32 + " " + v29 + ">{v31()}</" + v32 + ">"
    let v34 : string = "leptos::view! { " + v33 + " }"
    let v35 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : leptos_HtmlElement<leptos_html_Dl> = v35 |> unbox
    let v37 : string = "leptos::IntoView::into_view($0)"
    let v38 : leptos_View = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : (leptos_View []) = [|v15; v38|]
    let v40 : string = "$0.to_vec()"
    let v41 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "leptos::Fragment::new($0)"
    let v43 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v41 v42
    v43
and method343 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure383(v0)
and closure401 (v0 : int64) () : leptos_Fragment =
    let v1 : string = "Transaction " + string (v0 + 1L) + ""
    let v2 : string = method19(v1)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::html::text($0)"
    let v8 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::IntoView::into_view($0)"
    let v10 : leptos_View = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : (leptos_View []) = [|v10|]
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "leptos::Fragment::new($0)"
    let v15 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v13 v14
    v15
and method360 (v0 : int64) : (unit -> leptos_Fragment) =
    closure401(v0)
and closure403 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure404 () () : string =
    let v0 : string = ""
    v0
and closure405 () () : leptos_Fragment =
    let v0 : string = method171()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method362 () : (unit -> leptos_Fragment) =
    closure405()
and closure406 (v0 : string) () : leptos_Fragment =
    let v1 : string = method19(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : (leptos_View []) = [|v9|]
    let v11 : string = "$0.to_vec()"
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "leptos::Fragment::new($0)"
    let v14 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v12 v13
    v14
and method363 (v0 : string) : (unit -> leptos_Fragment) =
    closure406(v0)
and closure407 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method364 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure407(v0, v1)
and closure408 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure409 () () : string =
    let v0 : string = ""
    v0
and closure410 () () : leptos_Fragment =
    let v0 : string = method233()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method365 () : (unit -> leptos_Fragment) =
    closure410()
and closure411 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v3 v12
    let v14 : int64 = int64 v13
    let v15 : int64 = method246(v14)
    let v16 : int64 = v15 / 1000L
    let v17 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v18 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : (chrono_DateTime<chrono_Utc> -> US71) = method247()
    let v20 : US71 = US71_1
    let v21 : US71 = v18 |> Option.map v19 |> Option.defaultValue v20 
    let v39 : US34 =
        match v21 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v22) -> (* Some *)
            let v23 : chrono_DateTime<chrono_Utc> = method248(v22)
            let v24 : string = "v23.naive_utc()"
            let v25 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v24
            let v26 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v25)"
            let v27 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v26
            let v28 : string = "%Y-%m-%d %H:%M:%S"
            let v29 : string = "r#\"" + v28 + "\"#"
            let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v29
            let v31 : chrono_DateTime<chrono_Local> = method249(v27)
            let v32 : string = "v31.format(v30).to_string()"
            let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v32
            let v34 : string = "fable_library_rust::String_::fromString($0)"
            let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34
            US34_0(v35)
    let v45 : US72 =
        match v39 with
        | US34_1 -> (* None *)
            let v42 : string = "resultm.from_option / Option does not have a value."
            US72_1(v42)
        | US34_0(v40) -> (* Some *)
            US72_0(v40)
    let v50 : string =
        match v45 with
        | US72_1(v47) -> (* Error *)
            let v48 : string = "sm'.to_string result / Error: " + v47 + ""
            v48
        | US72_0(v46) -> (* Ok *)
            v46
    let v51 : string = method19(v50)
    let v52 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "String::from($0)"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = "leptos::html::text($0)"
    let v57 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "leptos::IntoView::into_view($0)"
    let v59 : leptos_View = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : (leptos_View []) = [|v59|]
    let v61 : string = "$0.to_vec()"
    let v62 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = "leptos::Fragment::new($0)"
    let v64 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v62 v63
    v64
and method366 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure411(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure412 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method367 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure412(v0, v1)
and closure413 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure414 () () : string =
    let v0 : string = ""
    v0
and closure415 () () : leptos_Fragment =
    let v0 : string = method235()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method368 () : (unit -> leptos_Fragment) =
    closure415()
and closure416 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v8 v12
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method369 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure416(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure417 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method370 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure417(v0, v1)
and closure418 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure419 () () : string =
    let v0 : string = ""
    v0
and closure420 () () : leptos_Fragment =
    let v0 : string = method237()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method371 () : (unit -> leptos_Fragment) =
    closure420()
and closure421 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v10 v12
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method372 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure421(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure422 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method373 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure422(v0, v1)
and closure423 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure424 () () : string =
    let v0 : string = "sm:pr-[10px]"
    v0
and method375 () : string =
    let v0 : string = "Actions"
    v0
and closure425 () () : leptos_Fragment =
    let v0 : string = method375()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method374 () : (unit -> leptos_Fragment) =
    closure425()
and closure428 () () : string =
    let v0 : string = ""
    v0
and closure429 () () : string =
    let v0 : string = "items-center"
    v0
and closure430 () () : string =
    let v0 : string = ""
    v0
and closure431 (v0 : std_string_String) () : leptos_Fragment =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : bool = "FUNCTION_CALL" = v2
    let v11 : string =
        if v3 then
            let v4 : string = "Function Call:"
            v4
        else
            let v5 : bool = "DEPLOY_CONTRACT" = v2
            if v5 then
                let v6 : string = "Contract Deploy:"
                v6
            else
                let v7 : bool = "TRANSFER" = v2
                if v7 then
                    let v8 : string = "Transfer:"
                    v8
                else
                    v2
    let v12 : string = method19(v11)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::html::text($0)"
    let v18 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : (leptos_View []) = [|v20|]
    let v22 : string = "$0.to_vec()"
    let v23 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "leptos::Fragment::new($0)"
    let v25 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v23 v24
    v25
and method377 (v0 : std_string_String) : (unit -> leptos_Fragment) =
    closure431(v0)
and closure434 () () : string =
    let v0 : string = ""
    v0
and closure435 () () : string =
    let v0 : string = ""
    v0
and method381 () : string =
    let v0 : string = "Method"
    v0
and closure436 () () : leptos_Fragment =
    let v0 : string = method381()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method380 () : (unit -> leptos_Fragment) =
    closure436()
and method383 () : string =
    let v0 : string = "None"
    v0
and closure437 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : (std_string_String -> US15) = method44()
    let v2 : US15 = US15_1
    let v3 : US15 = v0 |> Option.map v1 |> Option.defaultValue v2 
    match v3 with
    | US15_1 -> (* None *)
        let v21 : string = method383()
        let v22 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
        let v24 : string = "String::from($0)"
        let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
        let v26 : string = "leptos::html::text($0)"
        let v27 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v25 v26
        let v28 : string = "leptos::IntoView::into_view($0)"
        let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
        let v30 : (leptos_View []) = [|v29|]
        let v31 : string = "$0.to_vec()"
        let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
        let v33 : string = "leptos::Fragment::new($0)"
        let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
        v34
    | US15_0(v4) -> (* Some *)
        let v5 : string = "fable_library_rust::String_::fromString($0)"
        let v6 : string = Fable.Core.RustInterop.emitRustExpr v4 v5
        let v7 : string = method19(v6)
        let v8 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v8
        let v10 : string = "String::from($0)"
        let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
        let v12 : string = "leptos::html::text($0)"
        let v13 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v11 v12
        let v14 : string = "leptos::IntoView::into_view($0)"
        let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
        let v16 : (leptos_View []) = [|v15|]
        let v17 : string = "$0.to_vec()"
        let v18 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v16 v17
        let v19 : string = "leptos::Fragment::new($0)"
        let v20 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v18 v19
        v20
and method382 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure437(v0)
and closure439 () () : string =
    let v0 : string = ""
    v0
and closure438 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure439()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method384 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure438(v0, v1)
and closure433 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure434()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure435()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure335()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : (unit -> leptos_Fragment) = method380()
    let v11 : (unit -> leptos_Fragment) = method382(v0)
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v9(()) + \" \" + &v6(()) + \" \" + &v3(())"
    let v13 : (unit -> leptos_Fragment) = method384(v10, v11)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v13)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "dl"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Dl> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method379 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure433(v0)
and closure432 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col\""
    let v2 : (unit -> leptos_Fragment) = method379(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method378 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure432(v0)
and closure441 () () : string =
    let v0 : string = ""
    v0
and closure440 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure441()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method385 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure440(v0, v1)
and closure427 () struct (v0 : std_string_String, v1 : std_string_String option) : leptos_View =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure428()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure429()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "$0"
    let v9 : (unit -> string) = closure430()
    let v10 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : (unit -> leptos_Fragment) = method377(v0)
    let v12 : (unit -> leptos_Fragment) = method378(v1)
    let v13 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v10(()) + \" \" + &v7(()) + \" \" + &v4(())"
    let v14 : (unit -> leptos_Fragment) = method385(v11, v12)
    let v15 : string = ""
    let v16 : string = " " + v13 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v14)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "dl"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Dl> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    v25
and closure426 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v0 v12
    let v14 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v15 : (struct (std_string_String * std_string_String option) -> leptos_View) = closure427()
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14
    let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v18 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::Fragment::new($0)"
    let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
and method376 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure426(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure443 () () : string =
    let v0 : string = "[flex-direction:column]"
    v0
and closure442 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure443()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method386 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure442(v0, v1)
and closure444 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure445 () () : string =
    let v0 : string = ""
    v0
and method388 () : string =
    let v0 : string = "Deposit"
    v0
and closure446 () () : leptos_Fragment =
    let v0 : string = method388()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method387 () : (unit -> leptos_Fragment) =
    closure446()
and closure447 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (float -> string) = _.ToString()
    let v13 : string = v12 v1
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method389 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure447(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure448 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method390 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure448(v0, v1)
and closure449 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure450 () () : string =
    let v0 : string = ""
    v0
and method392 () : string =
    let v0 : string = "Outcome Status"
    v0
and closure451 () () : leptos_Fragment =
    let v0 : string = method392()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method391 () : (unit -> leptos_Fragment) =
    closure451()
and closure452 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (bool -> string) = _.ToString()
    let v13 : string = v12 v6
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method393 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure452(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure453 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method394 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure453(v0, v1)
and closure454 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure455 () () : string =
    let v0 : string = ""
    v0
and closure456 () () : leptos_Fragment =
    let v0 : string = method239()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method395 () : (unit -> leptos_Fragment) =
    closure456()
and closure457 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (float -> string) = _.ToString()
    let v13 : string = v12 v7
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method396 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure457(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure458 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method397 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure458(v0, v1)
and closure459 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure460 () () : string =
    let v0 : string = ""
    v0
and method399 () : string =
    let v0 : string = "Block Height"
    v0
and closure461 () () : leptos_Fragment =
    let v0 : string = method399()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method398 () : (unit -> leptos_Fragment) =
    closure461()
and closure462 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (uint32 -> string) = _.ToString()
    let v13 : string = v12 v2
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method400 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure462(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure463 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method401 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure463(v0, v1)
and closure464 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure465 () () : string =
    let v0 : string = ""
    v0
and method403 () : string =
    let v0 : string = "Hash"
    v0
and closure466 () () : leptos_Fragment =
    let v0 : string = method403()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method402 () : (unit -> leptos_Fragment) =
    closure466()
and closure467 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method404 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure467(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure468 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method405 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure468(v0, v1)
and closure469 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure470 () () : string =
    let v0 : string = ""
    v0
and method407 () : string =
    let v0 : string = "Block Hash"
    v0
and closure471 () () : leptos_Fragment =
    let v0 : string = method407()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method406 () : (unit -> leptos_Fragment) =
    closure471()
and closure472 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v4 v12
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method408 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure472(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure473 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method409 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure473(v0, v1)
and closure474 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure475 () () : string =
    let v0 : string = ""
    v0
and method411 () : string =
    let v0 : string = "Receipt ID"
    v0
and closure476 () () : leptos_Fragment =
    let v0 : string = method411()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method410 () : (unit -> leptos_Fragment) =
    closure476()
and closure477 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v9 v12
    let v14 : string = method19(v13)
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::html::text($0)"
    let v20 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method412 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure477(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure478 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method413 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure478(v0, v1)
and closure479 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure480 () () : string =
    let v0 : string = ""
    v0
and method415 () : string =
    let v0 : string = "Logs"
    v0
and closure481 () () : leptos_Fragment =
    let v0 : string = method415()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method414 () : (unit -> leptos_Fragment) =
    closure481()
and method417 () : string =
    let v0 : string = "\n"
    v0
and closure483 () () : string =
    let v0 : string = "[max-height:20vh]"
    v0
and closure482 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v5 v12
    let v14 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v15 : (std_string_String -> string) = closure59()
    let v16 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14
    let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v18 : (string []) = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : ((string []) -> string seq) = Seq.ofArray
    let v20 : string seq = v19 v18
    let v21 : string = method417()
    let v22 : (string -> (string seq -> string)) = String.concat
    let v23 : (string seq -> string) = v22 v21
    let v24 : string = v23 v20
    let v25 : string = "\\n"
    let v26 : string = "\n"
    let v27 : string = v24.Replace (v25, v26)
    let v28 : string = "$0"
    let v29 : (unit -> string) = closure483()
    let v30 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v29 v28
    let v31 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v30(())"
    let v32 : (unit -> leptos_Fragment) = method333(v27)
    let v33 : string = ""
    let v34 : string = " " + v31 + v33 + ""
    let v35 : (unit -> leptos_Fragment) = method179(v32)
    let v36 : (unit -> leptos_Fragment) = method180(v35)
    let v37 : string = "pre"
    let v38 : string = "<" + v37 + " " + v34 + ">{v36()}</" + v37 + ">"
    let v39 : string = "leptos::view! { " + v38 + " }"
    let v40 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : leptos_HtmlElement<leptos_html_Pre> = v40 |> unbox
    let v42 : string = "leptos::IntoView::into_view($0)"
    let v43 : leptos_View = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : (leptos_View []) = [|v43|]
    let v45 : string = "$0.to_vec()"
    let v46 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "leptos::Fragment::new($0)"
    let v48 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v46 v47
    v48
and method416 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure482(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure484 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure344()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method314(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method179(v6)
    let v10 : (unit -> leptos_Fragment) = method180(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method314(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v19)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "dd"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Dd> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v17; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method418 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure484(v0, v1)
and closure402 (v0 : string, v1 : (struct (std_string_String * std_string_String option) []), v2 : float, v3 : uint32, v4 : std_string_String, v5 : std_string_String, v6 : (std_string_String []), v7 : bool, v8 : float, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String) () : leptos_Fragment =
    let v13 : string = "$0"
    let v14 : (unit -> string) = closure403()
    let v15 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v14 v13
    let v16 : string = "$0"
    let v17 : (unit -> string) = closure404()
    let v18 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "$0"
    let v20 : (unit -> string) = closure335()
    let v21 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v19
    let v22 : (unit -> leptos_Fragment) = method362()
    let v23 : (unit -> leptos_Fragment) = method363(v0)
    let v24 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v21(()) + \" \" + &v18(()) + \" \" + &v15(())"
    let v25 : (unit -> leptos_Fragment) = method364(v22, v23)
    let v26 : string = ""
    let v27 : string = " " + v24 + v26 + ""
    let v28 : (unit -> leptos_Fragment) = method179(v25)
    let v29 : (unit -> leptos_Fragment) = method180(v28)
    let v30 : string = "dl"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Dl> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "$0"
    let v38 : (unit -> string) = closure408()
    let v39 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v38 v37
    let v40 : string = "$0"
    let v41 : (unit -> string) = closure409()
    let v42 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v41 v40
    let v43 : string = "$0"
    let v44 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v43
    let v45 : (unit -> leptos_Fragment) = method365()
    let v46 : (unit -> leptos_Fragment) = method366(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v47 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v44(()) + \" \" + &v42(()) + \" \" + &v39(())"
    let v48 : (unit -> leptos_Fragment) = method367(v45, v46)
    let v49 : string = " " + v47 + v26 + ""
    let v50 : (unit -> leptos_Fragment) = method179(v48)
    let v51 : (unit -> leptos_Fragment) = method180(v50)
    let v52 : string = "<" + v30 + " " + v49 + ">{v51()}</" + v30 + ">"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : leptos_HtmlElement<leptos_html_Dl> = v54 |> unbox
    let v56 : string = "leptos::IntoView::into_view($0)"
    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "$0"
    let v59 : (unit -> string) = closure413()
    let v60 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v59 v58
    let v61 : string = "$0"
    let v62 : (unit -> string) = closure414()
    let v63 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v62 v61
    let v64 : string = "$0"
    let v65 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v64
    let v66 : (unit -> leptos_Fragment) = method368()
    let v67 : (unit -> leptos_Fragment) = method369(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v68 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v65(()) + \" \" + &v63(()) + \" \" + &v60(())"
    let v69 : (unit -> leptos_Fragment) = method370(v66, v67)
    let v70 : string = " " + v68 + v26 + ""
    let v71 : (unit -> leptos_Fragment) = method179(v69)
    let v72 : (unit -> leptos_Fragment) = method180(v71)
    let v73 : string = "<" + v30 + " " + v70 + ">{v72()}</" + v30 + ">"
    let v74 : string = "leptos::view! { " + v73 + " }"
    let v75 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v74
    let v76 : leptos_HtmlElement<leptos_html_Dl> = v75 |> unbox
    let v77 : string = "leptos::IntoView::into_view($0)"
    let v78 : leptos_View = Fable.Core.RustInterop.emitRustExpr v76 v77
    let v79 : string = "$0"
    let v80 : (unit -> string) = closure418()
    let v81 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v80 v79
    let v82 : string = "$0"
    let v83 : (unit -> string) = closure419()
    let v84 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v83 v82
    let v85 : string = "$0"
    let v86 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v85
    let v87 : (unit -> leptos_Fragment) = method371()
    let v88 : (unit -> leptos_Fragment) = method372(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v89 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v86(()) + \" \" + &v84(()) + \" \" + &v81(())"
    let v90 : (unit -> leptos_Fragment) = method373(v87, v88)
    let v91 : string = " " + v89 + v26 + ""
    let v92 : (unit -> leptos_Fragment) = method179(v90)
    let v93 : (unit -> leptos_Fragment) = method180(v92)
    let v94 : string = "<" + v30 + " " + v91 + ">{v93()}</" + v30 + ">"
    let v95 : string = "leptos::view! { " + v94 + " }"
    let v96 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v95
    let v97 : leptos_HtmlElement<leptos_html_Dl> = v96 |> unbox
    let v98 : string = "leptos::IntoView::into_view($0)"
    let v99 : leptos_View = Fable.Core.RustInterop.emitRustExpr v97 v98
    let v100 : string = "$0"
    let v101 : (unit -> string) = closure423()
    let v102 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v101 v100
    let v103 : string = "$0"
    let v104 : (unit -> string) = closure424()
    let v105 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v104 v103
    let v106 : string = "$0"
    let v107 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v106
    let v108 : (unit -> leptos_Fragment) = method374()
    let v109 : (unit -> leptos_Fragment) = method376(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v110 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v107(()) + \" \" + &v105(()) + \" \" + &v102(())"
    let v111 : (unit -> leptos_Fragment) = method386(v108, v109)
    let v112 : string = " " + v110 + v26 + ""
    let v113 : (unit -> leptos_Fragment) = method179(v111)
    let v114 : (unit -> leptos_Fragment) = method180(v113)
    let v115 : string = "<" + v30 + " " + v112 + ">{v114()}</" + v30 + ">"
    let v116 : string = "leptos::view! { " + v115 + " }"
    let v117 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v116
    let v118 : leptos_HtmlElement<leptos_html_Dl> = v117 |> unbox
    let v119 : string = "leptos::IntoView::into_view($0)"
    let v120 : leptos_View = Fable.Core.RustInterop.emitRustExpr v118 v119
    let v121 : string = "$0"
    let v122 : (unit -> string) = closure444()
    let v123 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v122 v121
    let v124 : string = "$0"
    let v125 : (unit -> string) = closure445()
    let v126 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v125 v124
    let v127 : string = "$0"
    let v128 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v127
    let v129 : (unit -> leptos_Fragment) = method387()
    let v130 : (unit -> leptos_Fragment) = method389(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v131 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v128(()) + \" \" + &v126(()) + \" \" + &v123(())"
    let v132 : (unit -> leptos_Fragment) = method390(v129, v130)
    let v133 : string = " " + v131 + v26 + ""
    let v134 : (unit -> leptos_Fragment) = method179(v132)
    let v135 : (unit -> leptos_Fragment) = method180(v134)
    let v136 : string = "<" + v30 + " " + v133 + ">{v135()}</" + v30 + ">"
    let v137 : string = "leptos::view! { " + v136 + " }"
    let v138 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v137
    let v139 : leptos_HtmlElement<leptos_html_Dl> = v138 |> unbox
    let v140 : string = "leptos::IntoView::into_view($0)"
    let v141 : leptos_View = Fable.Core.RustInterop.emitRustExpr v139 v140
    let v142 : string = "$0"
    let v143 : (unit -> string) = closure449()
    let v144 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v143 v142
    let v145 : string = "$0"
    let v146 : (unit -> string) = closure450()
    let v147 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v146 v145
    let v148 : string = "$0"
    let v149 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v148
    let v150 : (unit -> leptos_Fragment) = method391()
    let v151 : (unit -> leptos_Fragment) = method393(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v152 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v149(()) + \" \" + &v147(()) + \" \" + &v144(())"
    let v153 : (unit -> leptos_Fragment) = method394(v150, v151)
    let v154 : string = " " + v152 + v26 + ""
    let v155 : (unit -> leptos_Fragment) = method179(v153)
    let v156 : (unit -> leptos_Fragment) = method180(v155)
    let v157 : string = "<" + v30 + " " + v154 + ">{v156()}</" + v30 + ">"
    let v158 : string = "leptos::view! { " + v157 + " }"
    let v159 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v158
    let v160 : leptos_HtmlElement<leptos_html_Dl> = v159 |> unbox
    let v161 : string = "leptos::IntoView::into_view($0)"
    let v162 : leptos_View = Fable.Core.RustInterop.emitRustExpr v160 v161
    let v163 : string = "$0"
    let v164 : (unit -> string) = closure454()
    let v165 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v164 v163
    let v166 : string = "$0"
    let v167 : (unit -> string) = closure455()
    let v168 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v167 v166
    let v169 : string = "$0"
    let v170 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v169
    let v171 : (unit -> leptos_Fragment) = method395()
    let v172 : (unit -> leptos_Fragment) = method396(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v173 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v170(()) + \" \" + &v168(()) + \" \" + &v165(())"
    let v174 : (unit -> leptos_Fragment) = method397(v171, v172)
    let v175 : string = " " + v173 + v26 + ""
    let v176 : (unit -> leptos_Fragment) = method179(v174)
    let v177 : (unit -> leptos_Fragment) = method180(v176)
    let v178 : string = "<" + v30 + " " + v175 + ">{v177()}</" + v30 + ">"
    let v179 : string = "leptos::view! { " + v178 + " }"
    let v180 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v179
    let v181 : leptos_HtmlElement<leptos_html_Dl> = v180 |> unbox
    let v182 : string = "leptos::IntoView::into_view($0)"
    let v183 : leptos_View = Fable.Core.RustInterop.emitRustExpr v181 v182
    let v184 : string = "$0"
    let v185 : (unit -> string) = closure459()
    let v186 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v185 v184
    let v187 : string = "$0"
    let v188 : (unit -> string) = closure460()
    let v189 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v188 v187
    let v190 : string = "$0"
    let v191 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v190
    let v192 : (unit -> leptos_Fragment) = method398()
    let v193 : (unit -> leptos_Fragment) = method400(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v194 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v191(()) + \" \" + &v189(()) + \" \" + &v186(())"
    let v195 : (unit -> leptos_Fragment) = method401(v192, v193)
    let v196 : string = " " + v194 + v26 + ""
    let v197 : (unit -> leptos_Fragment) = method179(v195)
    let v198 : (unit -> leptos_Fragment) = method180(v197)
    let v199 : string = "<" + v30 + " " + v196 + ">{v198()}</" + v30 + ">"
    let v200 : string = "leptos::view! { " + v199 + " }"
    let v201 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v200
    let v202 : leptos_HtmlElement<leptos_html_Dl> = v201 |> unbox
    let v203 : string = "leptos::IntoView::into_view($0)"
    let v204 : leptos_View = Fable.Core.RustInterop.emitRustExpr v202 v203
    let v205 : string = "$0"
    let v206 : (unit -> string) = closure464()
    let v207 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v206 v205
    let v208 : string = "$0"
    let v209 : (unit -> string) = closure465()
    let v210 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v209 v208
    let v211 : string = "$0"
    let v212 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v211
    let v213 : (unit -> leptos_Fragment) = method402()
    let v214 : (unit -> leptos_Fragment) = method404(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v215 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v212(()) + \" \" + &v210(()) + \" \" + &v207(())"
    let v216 : (unit -> leptos_Fragment) = method405(v213, v214)
    let v217 : string = " " + v215 + v26 + ""
    let v218 : (unit -> leptos_Fragment) = method179(v216)
    let v219 : (unit -> leptos_Fragment) = method180(v218)
    let v220 : string = "<" + v30 + " " + v217 + ">{v219()}</" + v30 + ">"
    let v221 : string = "leptos::view! { " + v220 + " }"
    let v222 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v221
    let v223 : leptos_HtmlElement<leptos_html_Dl> = v222 |> unbox
    let v224 : string = "leptos::IntoView::into_view($0)"
    let v225 : leptos_View = Fable.Core.RustInterop.emitRustExpr v223 v224
    let v226 : string = "$0"
    let v227 : (unit -> string) = closure469()
    let v228 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v227 v226
    let v229 : string = "$0"
    let v230 : (unit -> string) = closure470()
    let v231 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v230 v229
    let v232 : string = "$0"
    let v233 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v232
    let v234 : (unit -> leptos_Fragment) = method406()
    let v235 : (unit -> leptos_Fragment) = method408(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v236 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v233(()) + \" \" + &v231(()) + \" \" + &v228(())"
    let v237 : (unit -> leptos_Fragment) = method409(v234, v235)
    let v238 : string = " " + v236 + v26 + ""
    let v239 : (unit -> leptos_Fragment) = method179(v237)
    let v240 : (unit -> leptos_Fragment) = method180(v239)
    let v241 : string = "<" + v30 + " " + v238 + ">{v240()}</" + v30 + ">"
    let v242 : string = "leptos::view! { " + v241 + " }"
    let v243 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v242
    let v244 : leptos_HtmlElement<leptos_html_Dl> = v243 |> unbox
    let v245 : string = "leptos::IntoView::into_view($0)"
    let v246 : leptos_View = Fable.Core.RustInterop.emitRustExpr v244 v245
    let v247 : string = "$0"
    let v248 : (unit -> string) = closure474()
    let v249 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v248 v247
    let v250 : string = "$0"
    let v251 : (unit -> string) = closure475()
    let v252 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v251 v250
    let v253 : string = "$0"
    let v254 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v253
    let v255 : (unit -> leptos_Fragment) = method410()
    let v256 : (unit -> leptos_Fragment) = method412(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v257 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v254(()) + \" \" + &v252(()) + \" \" + &v249(())"
    let v258 : (unit -> leptos_Fragment) = method413(v255, v256)
    let v259 : string = " " + v257 + v26 + ""
    let v260 : (unit -> leptos_Fragment) = method179(v258)
    let v261 : (unit -> leptos_Fragment) = method180(v260)
    let v262 : string = "<" + v30 + " " + v259 + ">{v261()}</" + v30 + ">"
    let v263 : string = "leptos::view! { " + v262 + " }"
    let v264 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v263
    let v265 : leptos_HtmlElement<leptos_html_Dl> = v264 |> unbox
    let v266 : string = "leptos::IntoView::into_view($0)"
    let v267 : leptos_View = Fable.Core.RustInterop.emitRustExpr v265 v266
    let v268 : uint64 = System.Convert.ToUInt64 v6.Length
    let v269 : bool = v268 = 0UL
    let v295 : leptos_View =
        if v269 then
            let v270 : (leptos_View []) = [||]
            let v271 : (leptos_View []) = method167(v270)
            let v272 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v273 : leptos_View = Fable.Core.RustInterop.emitRustExpr v271 v272
            v273
        else
            let v274 : string = "$0"
            let v275 : (unit -> string) = closure479()
            let v276 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v275 v274
            let v277 : string = "$0"
            let v278 : (unit -> string) = closure480()
            let v279 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v278 v277
            let v280 : string = "$0"
            let v281 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v280
            let v282 : (unit -> leptos_Fragment) = method414()
            let v283 : (unit -> leptos_Fragment) = method416(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
            let v284 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v281(()) + \" \" + &v279(()) + \" \" + &v276(())"
            let v285 : (unit -> leptos_Fragment) = method418(v282, v283)
            let v286 : string = " " + v284 + v26 + ""
            let v287 : (unit -> leptos_Fragment) = method179(v285)
            let v288 : (unit -> leptos_Fragment) = method180(v287)
            let v289 : string = "<" + v30 + " " + v286 + ">{v288()}</" + v30 + ">"
            let v290 : string = "leptos::view! { " + v289 + " }"
            let v291 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v290
            let v292 : leptos_HtmlElement<leptos_html_Dl> = v291 |> unbox
            let v293 : string = "leptos::IntoView::into_view($0)"
            let v294 : leptos_View = Fable.Core.RustInterop.emitRustExpr v292 v293
            v294
    let v296 : (leptos_View []) = [|v36; v57; v78; v99; v120; v141; v162; v183; v204; v225; v246; v267; v295|]
    let v297 : string = "$0.to_vec()"
    let v298 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v296 v297
    let v299 : string = "leptos::Fragment::new($0)"
    let v300 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v298 v299
    v300
and method361 (v0 : string, v1 : (struct (std_string_String * std_string_String option) []), v2 : float, v3 : uint32, v4 : std_string_String, v5 : std_string_String, v6 : (std_string_String []), v7 : bool, v8 : float, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String) : (unit -> leptos_Fragment) =
    closure402(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
and closure400 (v0 : string, v1 : int64, v2 : (struct (std_string_String * std_string_String option) []), v3 : float, v4 : uint32, v5 : std_string_String, v6 : std_string_String, v7 : (std_string_String []), v8 : bool, v9 : float, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String) () : leptos_Fragment =
    let v14 : (unit -> leptos_Fragment) = method360(v1)
    let v15 : (unit -> leptos_Fragment) = method346(v14)
    let v16 : string = "class=\"flex items-center pb-[6px]\""
    let v17 : (unit -> leptos_Fragment) = method347(v15)
    let v18 : string = ""
    let v19 : string = " " + v16 + v18 + ""
    let v20 : (unit -> leptos_Fragment) = method179(v17)
    let v21 : (unit -> leptos_Fragment) = method180(v20)
    let v22 : string = "span"
    let v23 : string = "<" + v22 + " " + v19 + ">{v21()}</" + v22 + ">"
    let v24 : string = "leptos::view! { " + v23 + " }"
    let v25 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : leptos_HtmlElement<leptos_html_Span> = v25 |> unbox
    let v27 : string = "leptos::IntoView::into_view($0)"
    let v28 : leptos_View = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\""
    let v30 : (unit -> leptos_Fragment) = method361(v0, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
    let v31 : string = " " + v29 + v18 + ""
    let v32 : (unit -> leptos_Fragment) = method179(v30)
    let v33 : (unit -> leptos_Fragment) = method180(v32)
    let v34 : string = "div"
    let v35 : string = "<" + v34 + " " + v31 + ">{v33()}</" + v34 + ">"
    let v36 : string = "leptos::view! { " + v35 + " }"
    let v37 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : leptos_HtmlElement<leptos_html_Div> = v37 |> unbox
    let v39 : string = "leptos::IntoView::into_view($0)"
    let v40 : leptos_View = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : (leptos_View []) = [|v28; v40|]
    let v42 : string = "$0.to_vec()"
    let v43 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "leptos::Fragment::new($0)"
    let v45 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v43 v44
    v45
and method359 (v0 : string, v1 : int64, v2 : (struct (std_string_String * std_string_String option) []), v3 : float, v4 : uint32, v5 : std_string_String, v6 : std_string_String, v7 : (std_string_String []), v8 : bool, v9 : float, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String) : (unit -> leptos_Fragment) =
    closure400(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
and closure399 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : leptos_View =
    let v3 : (struct (std_string_String * std_string_String option) []) = v2.l0
    let v4 : float = v2.l1
    let v5 : uint32 = v2.l2
    let v6 : std_string_String = v2.l3
    let v7 : std_string_String = v2.l4
    let v8 : (std_string_String []) = v2.l5
    let v9 : bool = v2.l6
    let v10 : float = v2.l7
    let v11 : std_string_String = v2.l8
    let v12 : std_string_String = v2.l9
    let v13 : std_string_String = v2.l10
    let v14 : std_string_String = v2.l11
    let v15 : int64 = int64 v1
    let v16 : string = "transaction.render (1)"
    let v17 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
    let v20 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "$0.unwrap()"
    let v22 : Heap2 = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "class=\"flex flex-1 flex-col overflow-x-auto\""
    let v24 : (unit -> leptos_Fragment) = method359(v0, v15, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14)
    let v25 : string = ""
    let v26 : string = " " + v23 + v25 + ""
    let v27 : (unit -> leptos_Fragment) = method179(v24)
    let v28 : (unit -> leptos_Fragment) = method180(v27)
    let v29 : string = "div"
    let v30 : string = "<" + v29 + " " + v26 + ">{v28()}</" + v29 + ">"
    let v31 : string = "leptos::view! { " + v30 + " }"
    let v32 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : leptos_HtmlElement<leptos_html_Div> = v32 |> unbox
    let v34 : string = "leptos::IntoView::into_view($0)"
    let v35 : leptos_View = Fable.Core.RustInterop.emitRustExpr v33 v34
    v35
and closure398 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v4 : (struct (string * unativeint * Heap5) -> leptos_View) = closure399()
    let v5 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::Fragment::new($0)"
    let v11 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v9 v10
    v11
and method358 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure398(v0)
and closure487 (v0 : string) () : leptos_Fragment =
    let v1 : string = method19(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : (leptos_View []) = [|v9|]
    let v11 : string = "$0.to_vec()"
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "leptos::Fragment::new($0)"
    let v14 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v12 v13
    v14
and method420 (v0 : string) : (unit -> leptos_Fragment) =
    closure487(v0)
and closure488 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l3
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : int64 = int64 v3
    let v5 : int64 = method246(v4)
    let v6 : int64 = v5 / 1000L
    let v7 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v8 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (chrono_DateTime<chrono_Utc> -> US71) = method247()
    let v10 : US71 = US71_1
    let v11 : US71 = v8 |> Option.map v9 |> Option.defaultValue v10 
    let v29 : US34 =
        match v11 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v12) -> (* Some *)
            let v13 : chrono_DateTime<chrono_Utc> = method248(v12)
            let v14 : string = "v13.naive_utc()"
            let v15 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v14
            let v16 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v15)"
            let v17 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v16
            let v18 : string = "%Y-%m-%d %H:%M:%S"
            let v19 : string = "r#\"" + v18 + "\"#"
            let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : chrono_DateTime<chrono_Local> = method249(v17)
            let v22 : string = "v21.format(v20).to_string()"
            let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v22
            let v24 : string = "fable_library_rust::String_::fromString($0)"
            let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24
            US34_0(v25)
    let v35 : US72 =
        match v29 with
        | US34_1 -> (* None *)
            let v32 : string = "resultm.from_option / Option does not have a value."
            US72_1(v32)
        | US34_0(v30) -> (* Some *)
            US72_0(v30)
    let v40 : string =
        match v35 with
        | US72_1(v37) -> (* Error *)
            let v38 : string = "sm'.to_string result / Error: " + v37 + ""
            v38
        | US72_0(v36) -> (* Ok *)
            v36
    let v41 : string = method19(v40)
    let v42 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "leptos::html::text($0)"
    let v47 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "leptos::IntoView::into_view($0)"
    let v49 : leptos_View = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : (leptos_View []) = [|v49|]
    let v51 : string = "$0.to_vec()"
    let v52 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "leptos::Fragment::new($0)"
    let v54 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v52 v53
    v54
and method421 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure488(v0)
and closure489 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l8
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method422 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure489(v0)
and closure490 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l10
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method423 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure490(v0)
and closure492 () struct (v0 : std_string_String, v1 : std_string_String option) : leptos_View =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure428()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure429()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "$0"
    let v9 : (unit -> string) = closure430()
    let v10 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : (unit -> leptos_Fragment) = method377(v0)
    let v12 : (unit -> leptos_Fragment) = method378(v1)
    let v13 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v10(()) + \" \" + &v7(()) + \" \" + &v4(())"
    let v14 : (unit -> leptos_Fragment) = method385(v11, v12)
    let v15 : string = ""
    let v16 : string = " " + v13 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v14)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "dl"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Dl> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    v25
and closure491 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (struct (std_string_String * std_string_String option) []) = v0.l0
    let v2 : string = "$0.to_vec()"
    let v3 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v5 : (struct (std_string_String * std_string_String option) -> leptos_View) = closure492()
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v3, v5) v4
    let v7 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v8 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.to_vec()"
    let v10 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::Fragment::new($0)"
    let v12 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v10 v11
    v12
and method424 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure491(v0)
and closure493 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l1
    let v2 : (float -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method425 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure493(v0)
and closure494 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l7
    let v2 : (float -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method426 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure494(v0)
and closure495 (v0 : Heap5) () : leptos_Fragment =
    let v1 : uint32 = v0.l2
    let v2 : (uint32 -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method427 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure495(v0)
and closure497 () () : string =
    let v0 : string = "[max-height:20vh] [width:100vw] [max-width:100vw]"
    v0
and closure496 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (std_string_String []) = v0.l5
    let v2 : uint64 = System.Convert.ToUInt64 v1.Length
    let v3 : bool = v2 = 0UL
    if v3 then
        let v4 : string = method4()
        let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
        let v7 : string = "String::from($0)"
        let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
        let v9 : string = "leptos::html::text($0)"
        let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
        let v11 : string = "leptos::IntoView::into_view($0)"
        let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
        let v13 : (leptos_View []) = [|v12|]
        let v14 : string = "$0.to_vec()"
        let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
        let v16 : string = "leptos::Fragment::new($0)"
        let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
        v17
    else
        let v18 : string = "$0.to_vec()"
        let v19 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1 v18
        let v20 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v21 : (std_string_String -> string) = closure59()
        let v22 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v19, v21) v20
        let v23 : string = "fable_library_rust::NativeArray_::array_from($0)"
        let v24 : (string []) = Fable.Core.RustInterop.emitRustExpr v22 v23
        let v25 : ((string []) -> string seq) = Seq.ofArray
        let v26 : string seq = v25 v24
        let v27 : string = method417()
        let v28 : (string -> (string seq -> string)) = String.concat
        let v29 : (string seq -> string) = v28 v27
        let v30 : string = v29 v26
        let v31 : string = "\\n"
        let v32 : string = "\n"
        let v33 : string = v30.Replace (v31, v32)
        let v34 : string = "$0"
        let v35 : (unit -> string) = closure497()
        let v36 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v35 v34
        let v37 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v36(())"
        let v38 : (unit -> leptos_Fragment) = method333(v33)
        let v39 : string = ""
        let v40 : string = " " + v37 + v39 + ""
        let v41 : (unit -> leptos_Fragment) = method179(v38)
        let v42 : (unit -> leptos_Fragment) = method180(v41)
        let v43 : string = "pre"
        let v44 : string = "<" + v43 + " " + v40 + ">{v42()}</" + v43 + ">"
        let v45 : string = "leptos::view! { " + v44 + " }"
        let v46 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : leptos_HtmlElement<leptos_html_Pre> = v46 |> unbox
        let v48 : string = "leptos::IntoView::into_view($0)"
        let v49 : leptos_View = Fable.Core.RustInterop.emitRustExpr v47 v48
        let v50 : (leptos_View []) = [|v49|]
        let v51 : string = "$0.to_vec()"
        let v52 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v50 v51
        let v53 : string = "leptos::Fragment::new($0)"
        let v54 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v52 v53
        v54
and method428 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure496(v0)
and closure498 (v0 : Heap5) () : leptos_Fragment =
    let v1 : bool = v0.l6
    let v2 : (bool -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method429 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure498(v0)
and closure499 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l11
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method430 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure499(v0)
and closure500 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l4
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method431 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure500(v0)
and closure501 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l9
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = method19(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method432 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure501(v0)
and closure486 (v0 : Heap5, v1 : string) () : leptos_Fragment =
    let v2 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v3 : (unit -> leptos_Fragment) = method420(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method179(v3)
    let v7 : (unit -> leptos_Fragment) = method180(v6)
    let v8 : string = "td"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Td> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v16 : (unit -> leptos_Fragment) = method421(v0)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method179(v16)
    let v19 : (unit -> leptos_Fragment) = method180(v18)
    let v20 : string = "<" + v8 + " " + v17 + ">{v19()}</" + v8 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Td> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v27 : (unit -> leptos_Fragment) = method422(v0)
    let v28 : string = " " + v26 + v4 + ""
    let v29 : (unit -> leptos_Fragment) = method179(v27)
    let v30 : (unit -> leptos_Fragment) = method180(v29)
    let v31 : string = "<" + v8 + " " + v28 + ">{v30()}</" + v8 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Td> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v38 : (unit -> leptos_Fragment) = method423(v0)
    let v39 : string = " " + v37 + v4 + ""
    let v40 : (unit -> leptos_Fragment) = method179(v38)
    let v41 : (unit -> leptos_Fragment) = method180(v40)
    let v42 : string = "<" + v8 + " " + v39 + ">{v41()}</" + v8 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : leptos_HtmlElement<leptos_html_Td> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v49 : (unit -> leptos_Fragment) = method424(v0)
    let v50 : string = " " + v48 + v4 + ""
    let v51 : (unit -> leptos_Fragment) = method179(v49)
    let v52 : (unit -> leptos_Fragment) = method180(v51)
    let v53 : string = "<" + v8 + " " + v50 + ">{v52()}</" + v8 + ">"
    let v54 : string = "leptos::view! { " + v53 + " }"
    let v55 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : leptos_HtmlElement<leptos_html_Td> = v55 |> unbox
    let v57 : string = "leptos::IntoView::into_view($0)"
    let v58 : leptos_View = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v60 : (unit -> leptos_Fragment) = method425(v0)
    let v61 : string = " " + v59 + v4 + ""
    let v62 : (unit -> leptos_Fragment) = method179(v60)
    let v63 : (unit -> leptos_Fragment) = method180(v62)
    let v64 : string = "<" + v8 + " " + v61 + ">{v63()}</" + v8 + ">"
    let v65 : string = "leptos::view! { " + v64 + " }"
    let v66 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v65
    let v67 : leptos_HtmlElement<leptos_html_Td> = v66 |> unbox
    let v68 : string = "leptos::IntoView::into_view($0)"
    let v69 : leptos_View = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v71 : (unit -> leptos_Fragment) = method426(v0)
    let v72 : string = " " + v70 + v4 + ""
    let v73 : (unit -> leptos_Fragment) = method179(v71)
    let v74 : (unit -> leptos_Fragment) = method180(v73)
    let v75 : string = "<" + v8 + " " + v72 + ">{v74()}</" + v8 + ">"
    let v76 : string = "leptos::view! { " + v75 + " }"
    let v77 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : leptos_HtmlElement<leptos_html_Td> = v77 |> unbox
    let v79 : string = "leptos::IntoView::into_view($0)"
    let v80 : leptos_View = Fable.Core.RustInterop.emitRustExpr v78 v79
    let v81 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v82 : (unit -> leptos_Fragment) = method427(v0)
    let v83 : string = " " + v81 + v4 + ""
    let v84 : (unit -> leptos_Fragment) = method179(v82)
    let v85 : (unit -> leptos_Fragment) = method180(v84)
    let v86 : string = "<" + v8 + " " + v83 + ">{v85()}</" + v8 + ">"
    let v87 : string = "leptos::view! { " + v86 + " }"
    let v88 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : leptos_HtmlElement<leptos_html_Td> = v88 |> unbox
    let v90 : string = "leptos::IntoView::into_view($0)"
    let v91 : leptos_View = Fable.Core.RustInterop.emitRustExpr v89 v90
    let v92 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]\""
    let v93 : (unit -> leptos_Fragment) = method428(v0)
    let v94 : string = " " + v92 + v4 + ""
    let v95 : (unit -> leptos_Fragment) = method179(v93)
    let v96 : (unit -> leptos_Fragment) = method180(v95)
    let v97 : string = "<" + v8 + " " + v94 + ">{v96()}</" + v8 + ">"
    let v98 : string = "leptos::view! { " + v97 + " }"
    let v99 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v98
    let v100 : leptos_HtmlElement<leptos_html_Td> = v99 |> unbox
    let v101 : string = "leptos::IntoView::into_view($0)"
    let v102 : leptos_View = Fable.Core.RustInterop.emitRustExpr v100 v101
    let v103 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v104 : (unit -> leptos_Fragment) = method429(v0)
    let v105 : string = " " + v103 + v4 + ""
    let v106 : (unit -> leptos_Fragment) = method179(v104)
    let v107 : (unit -> leptos_Fragment) = method180(v106)
    let v108 : string = "<" + v8 + " " + v105 + ">{v107()}</" + v8 + ">"
    let v109 : string = "leptos::view! { " + v108 + " }"
    let v110 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v109
    let v111 : leptos_HtmlElement<leptos_html_Td> = v110 |> unbox
    let v112 : string = "leptos::IntoView::into_view($0)"
    let v113 : leptos_View = Fable.Core.RustInterop.emitRustExpr v111 v112
    let v114 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v115 : (unit -> leptos_Fragment) = method430(v0)
    let v116 : string = " " + v114 + v4 + ""
    let v117 : (unit -> leptos_Fragment) = method179(v115)
    let v118 : (unit -> leptos_Fragment) = method180(v117)
    let v119 : string = "<" + v8 + " " + v116 + ">{v118()}</" + v8 + ">"
    let v120 : string = "leptos::view! { " + v119 + " }"
    let v121 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v120
    let v122 : leptos_HtmlElement<leptos_html_Td> = v121 |> unbox
    let v123 : string = "leptos::IntoView::into_view($0)"
    let v124 : leptos_View = Fable.Core.RustInterop.emitRustExpr v122 v123
    let v125 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v126 : (unit -> leptos_Fragment) = method431(v0)
    let v127 : string = " " + v125 + v4 + ""
    let v128 : (unit -> leptos_Fragment) = method179(v126)
    let v129 : (unit -> leptos_Fragment) = method180(v128)
    let v130 : string = "<" + v8 + " " + v127 + ">{v129()}</" + v8 + ">"
    let v131 : string = "leptos::view! { " + v130 + " }"
    let v132 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v131
    let v133 : leptos_HtmlElement<leptos_html_Td> = v132 |> unbox
    let v134 : string = "leptos::IntoView::into_view($0)"
    let v135 : leptos_View = Fable.Core.RustInterop.emitRustExpr v133 v134
    let v136 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v137 : (unit -> leptos_Fragment) = method432(v0)
    let v138 : string = " " + v136 + v4 + ""
    let v139 : (unit -> leptos_Fragment) = method179(v137)
    let v140 : (unit -> leptos_Fragment) = method180(v139)
    let v141 : string = "<" + v8 + " " + v138 + ">{v140()}</" + v8 + ">"
    let v142 : string = "leptos::view! { " + v141 + " }"
    let v143 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v142
    let v144 : leptos_HtmlElement<leptos_html_Td> = v143 |> unbox
    let v145 : string = "leptos::IntoView::into_view($0)"
    let v146 : leptos_View = Fable.Core.RustInterop.emitRustExpr v144 v145
    let v147 : (leptos_View []) = [|v14; v25; v36; v47; v58; v69; v80; v91; v102; v113; v124; v135; v146|]
    let v148 : string = "$0.to_vec()"
    let v149 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v147 v148
    let v150 : string = "leptos::Fragment::new($0)"
    let v151 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v149 v150
    v151
and method419 (v0 : Heap5, v1 : string) : (unit -> leptos_Fragment) =
    closure486(v0, v1)
and closure485 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : leptos_HtmlElement<leptos_html_Tr> =
    let v3 : string = "transaction.tr_render (1)"
    let v4 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\""
    let v7 : (unit -> leptos_Fragment) = method419(v2, v0)
    let v8 : string = ""
    let v9 : string = " " + v6 + v8 + ""
    let v10 : (unit -> leptos_Fragment) = method179(v7)
    let v11 : (unit -> leptos_Fragment) = method180(v10)
    let v12 : string = "tr"
    let v13 : string = "<" + v12 + " " + v9 + ">{v11()}</" + v12 + ">"
    let v14 : string = "leptos::view! { " + v13 + " }"
    let v15 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : leptos_HtmlElement<leptos_html_Tr> = v15 |> unbox
    v16
and closure502 () (v0 : leptos_HtmlElement<leptos_html_Tr>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure504 () () : leptos_Fragment =
    let v0 : string = method171()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method434 () : (unit -> leptos_Fragment) =
    closure504()
and closure505 () () : leptos_Fragment =
    let v0 : string = method233()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method435 () : (unit -> leptos_Fragment) =
    closure505()
and closure506 () () : leptos_Fragment =
    let v0 : string = method235()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method436 () : (unit -> leptos_Fragment) =
    closure506()
and closure507 () () : leptos_Fragment =
    let v0 : string = method237()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method437 () : (unit -> leptos_Fragment) =
    closure507()
and method439 () : string =
    let v0 : string = "Action"
    v0
and closure508 () () : leptos_Fragment =
    let v0 : string = method439()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method438 () : (unit -> leptos_Fragment) =
    closure508()
and closure509 () () : leptos_Fragment =
    let v0 : string = method388()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method440 () : (unit -> leptos_Fragment) =
    closure509()
and closure510 () () : leptos_Fragment =
    let v0 : string = method239()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method441 () : (unit -> leptos_Fragment) =
    closure510()
and closure511 () () : leptos_Fragment =
    let v0 : string = method399()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method442 () : (unit -> leptos_Fragment) =
    closure511()
and method445 (v0 : (std_string_String []), v1 : int32) : bool =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 < v2
    if v3 then
        let v4 : std_string_String = v0.[int v1]
        let v5 : string = "fable_library_rust::String_::fromString($0)"
        let v6 : string = Fable.Core.RustInterop.emitRustExpr v4 v5
        let v7 : int32 = v6.Length
        let v8 : bool = v7 > 0
        if v8 then
            true
        else
            let v9 : int32 = v1 + 1
            method445(v0, v9)
    else
        false
and method444 (v0 : (struct (string * unativeint * Heap5) []), v1 : int32) : bool =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 < v2
    if v3 then
        let struct (v4 : string, v5 : unativeint, v6 : Heap5) = v0.[int v1]
        let v7 : (std_string_String []) = v6.l5
        let v8 : int32 = 0
        let v9 : bool = method445(v7, v8)
        if v9 then
            true
        else
            let v10 : int32 = v1 + 1
            method444(v0, v10)
    else
        false
and closure512 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : int32 = 0
    let v2 : bool = method444(v0, v1)
    let v3 : bool = false = v2
    let v6 : string =
        if v3 then
            let v4 : string = ""
            v4
        else
            let v5 : string = "Logs"
            v5
    let v7 : string = method19(v6)
    let v8 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "String::from($0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::html::text($0)"
    let v13 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : (leptos_View []) = [|v15|]
    let v17 : string = "$0.to_vec()"
    let v18 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "leptos::Fragment::new($0)"
    let v20 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v18 v19
    v20
and method443 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure512(v0)
and closure513 () () : leptos_Fragment =
    let v0 : string = method392()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method446 () : (unit -> leptos_Fragment) =
    closure513()
and closure514 () () : leptos_Fragment =
    let v0 : string = method403()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method447 () : (unit -> leptos_Fragment) =
    closure514()
and closure515 () () : leptos_Fragment =
    let v0 : string = method407()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method448 () : (unit -> leptos_Fragment) =
    closure515()
and closure516 () () : leptos_Fragment =
    let v0 : string = method411()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method449 () : (unit -> leptos_Fragment) =
    closure516()
and closure503 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v2 : (unit -> leptos_Fragment) = method434()
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "th"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Th> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v15 : (unit -> leptos_Fragment) = method435()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v15)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "<" + v7 + " " + v16 + ">{v18()}</" + v7 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Th> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v26 : (unit -> leptos_Fragment) = method436()
    let v27 : string = " " + v25 + v3 + ""
    let v28 : (unit -> leptos_Fragment) = method179(v26)
    let v29 : (unit -> leptos_Fragment) = method180(v28)
    let v30 : string = "<" + v7 + " " + v27 + ">{v29()}</" + v7 + ">"
    let v31 : string = "leptos::view! { " + v30 + " }"
    let v32 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : leptos_HtmlElement<leptos_html_Th> = v32 |> unbox
    let v34 : string = "leptos::IntoView::into_view($0)"
    let v35 : leptos_View = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v37 : (unit -> leptos_Fragment) = method437()
    let v38 : string = " " + v36 + v3 + ""
    let v39 : (unit -> leptos_Fragment) = method179(v37)
    let v40 : (unit -> leptos_Fragment) = method180(v39)
    let v41 : string = "<" + v7 + " " + v38 + ">{v40()}</" + v7 + ">"
    let v42 : string = "leptos::view! { " + v41 + " }"
    let v43 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : leptos_HtmlElement<leptos_html_Th> = v43 |> unbox
    let v45 : string = "leptos::IntoView::into_view($0)"
    let v46 : leptos_View = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v48 : (unit -> leptos_Fragment) = method438()
    let v49 : string = " " + v47 + v3 + ""
    let v50 : (unit -> leptos_Fragment) = method179(v48)
    let v51 : (unit -> leptos_Fragment) = method180(v50)
    let v52 : string = "<" + v7 + " " + v49 + ">{v51()}</" + v7 + ">"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : leptos_HtmlElement<leptos_html_Th> = v54 |> unbox
    let v56 : string = "leptos::IntoView::into_view($0)"
    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v59 : (unit -> leptos_Fragment) = method440()
    let v60 : string = " " + v58 + v3 + ""
    let v61 : (unit -> leptos_Fragment) = method179(v59)
    let v62 : (unit -> leptos_Fragment) = method180(v61)
    let v63 : string = "<" + v7 + " " + v60 + ">{v62()}</" + v7 + ">"
    let v64 : string = "leptos::view! { " + v63 + " }"
    let v65 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : leptos_HtmlElement<leptos_html_Th> = v65 |> unbox
    let v67 : string = "leptos::IntoView::into_view($0)"
    let v68 : leptos_View = Fable.Core.RustInterop.emitRustExpr v66 v67
    let v69 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v70 : (unit -> leptos_Fragment) = method441()
    let v71 : string = " " + v69 + v3 + ""
    let v72 : (unit -> leptos_Fragment) = method179(v70)
    let v73 : (unit -> leptos_Fragment) = method180(v72)
    let v74 : string = "<" + v7 + " " + v71 + ">{v73()}</" + v7 + ">"
    let v75 : string = "leptos::view! { " + v74 + " }"
    let v76 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : leptos_HtmlElement<leptos_html_Th> = v76 |> unbox
    let v78 : string = "leptos::IntoView::into_view($0)"
    let v79 : leptos_View = Fable.Core.RustInterop.emitRustExpr v77 v78
    let v80 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v81 : (unit -> leptos_Fragment) = method442()
    let v82 : string = " " + v80 + v3 + ""
    let v83 : (unit -> leptos_Fragment) = method179(v81)
    let v84 : (unit -> leptos_Fragment) = method180(v83)
    let v85 : string = "<" + v7 + " " + v82 + ">{v84()}</" + v7 + ">"
    let v86 : string = "leptos::view! { " + v85 + " }"
    let v87 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v86
    let v88 : leptos_HtmlElement<leptos_html_Th> = v87 |> unbox
    let v89 : string = "leptos::IntoView::into_view($0)"
    let v90 : leptos_View = Fable.Core.RustInterop.emitRustExpr v88 v89
    let v91 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v92 : (unit -> leptos_Fragment) = method443(v0)
    let v93 : string = " " + v91 + v3 + ""
    let v94 : (unit -> leptos_Fragment) = method179(v92)
    let v95 : (unit -> leptos_Fragment) = method180(v94)
    let v96 : string = "<" + v7 + " " + v93 + ">{v95()}</" + v7 + ">"
    let v97 : string = "leptos::view! { " + v96 + " }"
    let v98 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v97
    let v99 : leptos_HtmlElement<leptos_html_Th> = v98 |> unbox
    let v100 : string = "leptos::IntoView::into_view($0)"
    let v101 : leptos_View = Fable.Core.RustInterop.emitRustExpr v99 v100
    let v102 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v103 : (unit -> leptos_Fragment) = method446()
    let v104 : string = " " + v102 + v3 + ""
    let v105 : (unit -> leptos_Fragment) = method179(v103)
    let v106 : (unit -> leptos_Fragment) = method180(v105)
    let v107 : string = "<" + v7 + " " + v104 + ">{v106()}</" + v7 + ">"
    let v108 : string = "leptos::view! { " + v107 + " }"
    let v109 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v108
    let v110 : leptos_HtmlElement<leptos_html_Th> = v109 |> unbox
    let v111 : string = "leptos::IntoView::into_view($0)"
    let v112 : leptos_View = Fable.Core.RustInterop.emitRustExpr v110 v111
    let v113 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v114 : (unit -> leptos_Fragment) = method447()
    let v115 : string = " " + v113 + v3 + ""
    let v116 : (unit -> leptos_Fragment) = method179(v114)
    let v117 : (unit -> leptos_Fragment) = method180(v116)
    let v118 : string = "<" + v7 + " " + v115 + ">{v117()}</" + v7 + ">"
    let v119 : string = "leptos::view! { " + v118 + " }"
    let v120 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v119
    let v121 : leptos_HtmlElement<leptos_html_Th> = v120 |> unbox
    let v122 : string = "leptos::IntoView::into_view($0)"
    let v123 : leptos_View = Fable.Core.RustInterop.emitRustExpr v121 v122
    let v124 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v125 : (unit -> leptos_Fragment) = method448()
    let v126 : string = " " + v124 + v3 + ""
    let v127 : (unit -> leptos_Fragment) = method179(v125)
    let v128 : (unit -> leptos_Fragment) = method180(v127)
    let v129 : string = "<" + v7 + " " + v126 + ">{v128()}</" + v7 + ">"
    let v130 : string = "leptos::view! { " + v129 + " }"
    let v131 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v130
    let v132 : leptos_HtmlElement<leptos_html_Th> = v131 |> unbox
    let v133 : string = "leptos::IntoView::into_view($0)"
    let v134 : leptos_View = Fable.Core.RustInterop.emitRustExpr v132 v133
    let v135 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v136 : (unit -> leptos_Fragment) = method449()
    let v137 : string = " " + v135 + v3 + ""
    let v138 : (unit -> leptos_Fragment) = method179(v136)
    let v139 : (unit -> leptos_Fragment) = method180(v138)
    let v140 : string = "<" + v7 + " " + v137 + ">{v139()}</" + v7 + ">"
    let v141 : string = "leptos::view! { " + v140 + " }"
    let v142 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v141
    let v143 : leptos_HtmlElement<leptos_html_Th> = v142 |> unbox
    let v144 : string = "leptos::IntoView::into_view($0)"
    let v145 : leptos_View = Fable.Core.RustInterop.emitRustExpr v143 v144
    let v146 : (leptos_View []) = [|v13; v24; v35; v46; v57; v68; v79; v90; v101; v112; v123; v134; v145|]
    let v147 : string = "$0.to_vec()"
    let v148 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v146 v147
    let v149 : string = "leptos::Fragment::new($0)"
    let v150 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v148 v149
    v150
and method433 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure503(v0)
and closure382 (v0 : Heap2, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>, v3 : leptos_ReadSignal<bool>) () : leptos_Fragment =
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v23 : leptos_View =
        if v5 then
            let v6 : string = "class=\"px-[12px] py-[10px]\""
            let v7 : (unit -> leptos_Fragment) = method343(v0)
            let v8 : string = ""
            let v9 : string = " " + v6 + v8 + ""
            let v10 : (unit -> leptos_Fragment) = method179(v7)
            let v11 : (unit -> leptos_Fragment) = method180(v10)
            let v12 : string = "div"
            let v13 : string = "<" + v12 + " " + v9 + ">{v11()}</" + v12 + ">"
            let v14 : string = "leptos::view! { " + v13 + " }"
            let v15 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v14
            let v16 : leptos_HtmlElement<leptos_html_Div> = v15 |> unbox
            let v17 : string = "leptos::IntoView::into_view($0)"
            let v18 : leptos_View = Fable.Core.RustInterop.emitRustExpr v16 v17
            v18
        else
            let v19 : (leptos_View []) = [||]
            let v20 : (leptos_View []) = method167(v19)
            let v21 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
            v22
    let v24 : string = $"$0()"
    let v25 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v2 v24
    let v26 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v27 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) []) = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : uint64 = System.Convert.ToUInt64 v27.Length
    let v29 : bool = v28 = 0UL
    let v159 : leptos_View =
        if v29 then
            let v30 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v31 : (unit -> leptos_Fragment) = method224()
            let v32 : string = ""
            let v33 : string = " " + v30 + v32 + ""
            let v34 : (unit -> leptos_Fragment) = method179(v31)
            let v35 : (unit -> leptos_Fragment) = method180(v34)
            let v36 : string = "div"
            let v37 : string = "<" + v36 + " " + v33 + ">{v35()}</" + v36 + ">"
            let v38 : string = "leptos::view! { " + v37 + " }"
            let v39 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v38
            let v40 : leptos_HtmlElement<leptos_html_Div> = v39 |> unbox
            let v41 : string = "leptos::IntoView::into_view($0)"
            let v42 : leptos_View = Fable.Core.RustInterop.emitRustExpr v40 v41
            v42
        else
            let v43 : string = $"$0()"
            let v44 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v1 v43
            let v45 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure129()
            let v46 : (std_string_String -> US56) = closure130()
            let v47 : US56 = match v44 with Ok x -> v45 x | Error x -> v46 x
            let v56 : US49 =
                match v47 with
                | US56_1(v53) -> (* Error *)
                    US49_1(v53)
                | US56_0(v48) -> (* Ok *)
                    let v49 : ((struct (string * unativeint * Heap5) []) -> US50) = method142()
                    let v50 : US50 = US50_1
                    let v51 : US50 = v48 |> Option.map v49 |> Option.defaultValue v50 
                    US49_0(v51)
            match v56 with
            | US49_1(v141) -> (* Error *)
                let v142 : string = "fable_library_rust::String_::fromString($0)"
                let v143 : string = Fable.Core.RustInterop.emitRustExpr v141 v142
                let v144 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
                let v145 : (unit -> leptos_Fragment) = method216(v143)
                let v146 : string = ""
                let v147 : string = " " + v144 + v146 + ""
                let v148 : (unit -> leptos_Fragment) = method179(v145)
                let v149 : (unit -> leptos_Fragment) = method180(v148)
                let v150 : string = "div"
                let v151 : string = "<" + v150 + " " + v147 + ">{v149()}</" + v150 + ">"
                let v152 : string = "leptos::view! { " + v151 + " }"
                let v153 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v152
                let v154 : leptos_HtmlElement<leptos_html_Div> = v153 |> unbox
                let v155 : string = "leptos::IntoView::into_view($0)"
                let v156 : leptos_View = Fable.Core.RustInterop.emitRustExpr v154 v155
                v156
            | US49_0(v57) -> (* Ok *)
                match v57 with
                | US50_0(v58) -> (* Some *)
                    let v59 : leptos_RwSignal<Heap1> = v0.l0
                    let v60 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
                    let v61 : Heap1 = Fable.Core.RustInterop.emitRustExpr v59 v60
                    let v62 : leptos_RwSignal<Heap0> = v61.l1
                    let v63 : string = $"leptos::SignalGet::get(&$0)"
                    let v64 : Heap0 = Fable.Core.RustInterop.emitRustExpr v62 v63
                    let v65 : US1 = v64.l4
                    let v67 : bool =
                        match v65 with
                        | US1_0 -> (* Details *)
                            true
                        | _ ->
                            false
                    if v67 then
                        let v68 : string = "class=\"grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]\""
                        let v69 : (unit -> leptos_Fragment) = method358(v58)
                        let v70 : string = ""
                        let v71 : string = " " + v68 + v70 + ""
                        let v72 : (unit -> leptos_Fragment) = method179(v69)
                        let v73 : (unit -> leptos_Fragment) = method180(v72)
                        let v74 : string = "div"
                        let v75 : string = "<" + v74 + " " + v71 + ">{v73()}</" + v74 + ">"
                        let v76 : string = "leptos::view! { " + v75 + " }"
                        let v77 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v76
                        let v78 : leptos_HtmlElement<leptos_html_Div> = v77 |> unbox
                        let v79 : string = "leptos::IntoView::into_view($0)"
                        let v80 : leptos_View = Fable.Core.RustInterop.emitRustExpr v78 v79
                        v80
                    else
                        let v81 : string = "$0.to_vec()"
                        let v82 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v58 v81
                        let v83 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v84 : (struct (string * unativeint * Heap5) -> leptos_HtmlElement<leptos_html_Tr>) = closure485()
                        let v85 : Vec<leptos_HtmlElement<leptos_html_Tr>> = Fable.Core.RustInterop.emitRustExpr struct (v82, v84) v83
                        let v86 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v87 : (leptos_HtmlElement<leptos_html_Tr> -> leptos_View) = closure502()
                        let v88 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v85, v87) v86
                        let v89 : string = "fable_library_rust::NativeArray_::array_from($0)"
                        let v90 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v88 v89
                        let v91 : string = "$0.to_vec()"
                        let v92 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v90 v91
                        let v93 : string = "leptos::Fragment::new($0)"
                        let v94 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v92 v93
                        let v95 : string = "transaction.tr_head_render (1)"
                        let v96 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                        let v97 : bool = Fable.Core.RustInterop.emitRustExpr v95 v96
                        let v98 : (unit -> leptos_Fragment) = method433(v58)
                        let v99 : (unit -> leptos_Fragment) = method179(v98)
                        let v100 : (unit -> leptos_Fragment) = method180(v99)
                        let v101 : string = "tr"
                        let v102 : string = ""
                        let v103 : string = "<" + v101 + " " + v102 + ">{v100()}</" + v101 + ">"
                        let v104 : string = "leptos::view! { " + v103 + " }"
                        let v105 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v104
                        let v106 : leptos_HtmlElement<leptos_html_Tr> = v105 |> unbox
                        let v107 : string = "leptos::IntoView::into_view($0)"
                        let v108 : leptos_View = Fable.Core.RustInterop.emitRustExpr v106 v107
                        let v109 : (leptos_View []) = [|v108|]
                        let v110 : string = "$0.to_vec()"
                        let v111 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v109 v110
                        let v112 : string = "leptos::Fragment::new($0)"
                        let v113 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v111 v112
                        let v114 : string = "class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\""
                        let v115 : (unit -> leptos_Fragment) = method256(v113, v94)
                        let v116 : string = " " + v114 + v102 + ""
                        let v117 : (unit -> leptos_Fragment) = method179(v115)
                        let v118 : (unit -> leptos_Fragment) = method180(v117)
                        let v119 : string = "table"
                        let v120 : string = "<" + v119 + " " + v116 + ">{v118()}</" + v119 + ">"
                        let v121 : string = "leptos::view! { " + v120 + " }"
                        let v122 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v121
                        let v123 : leptos_HtmlElement<leptos_html_Table> = v122 |> unbox
                        let v124 : string = "leptos::IntoView::into_view($0)"
                        let v125 : leptos_View = Fable.Core.RustInterop.emitRustExpr v123 v124
                        v125
                | _ ->
                    let v127 : string = "class=\"grid place-content-center py-[10vh]\""
                    let v128 : (unit -> leptos_Fragment) = method259()
                    let v129 : string = ""
                    let v130 : string = " " + v127 + v129 + ""
                    let v131 : (unit -> leptos_Fragment) = method179(v128)
                    let v132 : (unit -> leptos_Fragment) = method180(v131)
                    let v133 : string = "div"
                    let v134 : string = "<" + v133 + " " + v130 + ">{v132()}</" + v133 + ">"
                    let v135 : string = "leptos::view! { " + v134 + " }"
                    let v136 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v135
                    let v137 : leptos_HtmlElement<leptos_html_Div> = v136 |> unbox
                    let v138 : string = "leptos::IntoView::into_view($0)"
                    let v139 : leptos_View = Fable.Core.RustInterop.emitRustExpr v137 v138
                    v139
    let v160 : (leptos_View []) = [|v23; v159|]
    let v161 : string = "$0.to_vec()"
    let v162 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v160 v161
    let v163 : string = "leptos::Fragment::new($0)"
    let v164 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v162 v163
    v164
and method342 (v0 : Heap2, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>, v3 : leptos_ReadSignal<bool>) : (unit -> leptos_Fragment) =
    closure382(v0, v1, v2, v3)
and closure519 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure520 (v0 : leptos_View) () : StaticRef<Str> =
    let v4 : string = "[margin-right:40px]"
    let v5 : string = "r#\"" + v4 + "\"#"
    let v6 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and closure523 () () : string =
    let v0 : string = "Transactions"
    v0
and method454 (v0 : leptos_View) : (unit -> string) =
    closure523()
and closure522 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (unit -> string) = method454(v0)
    let v2 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v3 : (unit -> leptos_Fragment) = method198(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method179(v3)
    let v7 : (unit -> leptos_Fragment) = method180(v6)
    let v8 : string = "span"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Span> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : (leptos_View []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::Fragment::new($0)"
    let v19 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v17 v18
    v19
and method453 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure522(v0)
and closure521 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : string = "class=\"flex items-center gap-2\""
    let v2 : (unit -> leptos_Fragment) = method453(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v15 : (unit -> leptos_Fragment) = method199()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v15)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "span"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Span> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : (leptos_View []) = [|v13; v25|]
    let v27 : string = "$0.to_vec()"
    let v28 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "leptos::Fragment::new($0)"
    let v30 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v28 v29
    v30
and method452 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure521(v0)
and closure518 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure519()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> StaticRef<Str>) = closure520(v0)
    let v7 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v7(()) + \" \" + &v4(())"
    let v9 : (unit -> leptos_Fragment) = method452(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "summary"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Summary> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=\"flex flex-1 flex-col\""
    let v22 : (unit -> leptos_Fragment) = method201(v1)
    let v23 : string = " " + v21 + v10 + ""
    let v24 : (unit -> leptos_Fragment) = method179(v22)
    let v25 : (unit -> leptos_Fragment) = method180(v24)
    let v26 : string = "div"
    let v27 : string = "<" + v26 + " " + v23 + ">{v25()}</" + v26 + ">"
    let v28 : string = "leptos::view! { " + v27 + " }"
    let v29 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : leptos_HtmlElement<leptos_html_Div> = v29 |> unbox
    let v31 : string = "leptos::IntoView::into_view($0)"
    let v32 : leptos_View = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : (leptos_View []) = [|v20; v32|]
    let v34 : string = "$0.to_vec()"
    let v35 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : string = "leptos::Fragment::new($0)"
    let v37 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v35 v36
    v37
and method451 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure518(v0, v1)
and closure517 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure236()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure237()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method193(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method451(v0, v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "details"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Details> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v20; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method450 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure517(v0, v1)
and method457 () : string =
    let v0 : string = "Transactions"
    v0
and closure525 () () : leptos_Fragment =
    let v0 : string = method457()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method456 () : (unit -> leptos_Fragment) =
    closure525()
and closure527 () () : string =
    let v0 : string = "[max-height:70vh]"
    v0
and closure526 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : leptos_Fragment =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = @$"format!(""{{:#?}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "fable_library_rust::String_::fromString($0)"
    let v6 : string = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure527()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v9(())"
    let v11 : (unit -> leptos_Fragment) = method333(v6)
    let v12 : string = ""
    let v13 : string = " " + v10 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method179(v11)
    let v15 : (unit -> leptos_Fragment) = method180(v14)
    let v16 : string = "pre"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_html_Pre> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : (leptos_View []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method458 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) : (unit -> leptos_Fragment) =
    closure526(v0)
and closure524 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure362()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure334()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure335()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : (unit -> leptos_Fragment) = method456()
    let v11 : (unit -> leptos_Fragment) = method458(v0)
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v9(()) + \" \" + &v6(()) + \" \" + &v3(())"
    let v13 : (unit -> leptos_Fragment) = method334(v10, v11)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v13)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "dl"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Dl> = v21 |> unbox
    let v23 : (leptos_HtmlElement<leptos_html_Dl> []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_HtmlElement<leptos_html_Dl>> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v27 : (leptos_HtmlElement<leptos_html_Dl> -> leptos_View) = closure353()
    let v28 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v25, v27) v26
    let v29 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v30 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method455 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) : (unit -> leptos_Fragment) =
    closure524(v0)
and closure530 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure531 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure534 () () : string =
    let v0 : string = "Debug"
    v0
and method463 () : (unit -> string) =
    closure534()
and closure533 () () : leptos_Fragment =
    let v0 : (unit -> string) = method463()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method198(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method462 () : (unit -> leptos_Fragment) =
    closure533()
and closure532 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method462()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method179(v1)
    let v5 : (unit -> leptos_Fragment) = method180(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method199()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v14)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "span"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Span> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : (leptos_View []) = [|v12; v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "leptos::Fragment::new($0)"
    let v29 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29
and method461 () : (unit -> leptos_Fragment) =
    closure532()
and closure529 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure530()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure531()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method461()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method179(v8)
    let v12 : (unit -> leptos_Fragment) = method180(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method201(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method179(v21)
    let v24 : (unit -> leptos_Fragment) = method180(v23)
    let v25 : string = "div"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_html_Div> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : (leptos_View []) = [|v19; v31|]
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method460 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure529(v0)
and closure528 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure236()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure237()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method193(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method179(v9)
    let v13 : (unit -> leptos_Fragment) = method180(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method460(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v23)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "details"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Details> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : (leptos_View []) = [|v20; v34|]
    let v36 : string = "$0.to_vec()"
    let v37 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "leptos::Fragment::new($0)"
    let v39 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
and method459 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure528(v0, v1)
and closure535 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method464 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure535(v0)
and closure54 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : US20 = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v603 : US24 =
        match v2 with
        | US20_1(v3) -> (* Dice *)
            let v4 : string = "dice_view.render (1)"
            let v5 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
            let v7 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
            let v8 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v7
            let v9 : string = "$0.unwrap()"
            let v10 : Heap2 = Fable.Core.RustInterop.emitRustExpr v8 v9
            let v11 : string = "use_transactions.render (1)"
            let v12 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12
            let v14 : string = "$0"
            let v15 : (unit -> Vec<string>) = closure55(v10)
            let v16 : (unit -> Vec<string>) = Fable.Core.RustInterop.emitRustExpr v15 v14
            let v17 : string = "leptos::create_memo(move |_| { v16(()) })"
            let v18 : leptos_Memo<Vec<string>> = Fable.Core.RustInterop.emitRustExpr () v17
            let v19 : string = "$0"
            let v20 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure60(v18)
            let v21 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v20 v19
            let v22 : string = "leptos::create_memo(move |_| { v21(()) })"
            let v23 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v22
            let v24 : string = "$0"
            let v25 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = closure62(v10, v18)
            let v26 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = Fable.Core.RustInterop.emitRustExpr v25 v24
            let v27 : string = "leptos::create_memo(move |_| { v26(()) })"
            let v28 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>> = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : string = "$0"
            let v30 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure65(v28)
            let v31 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v30 v29
            let v32 : string = "leptos::create_memo(move |_| { v31(()) })"
            let v33 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v32
            let v34 : string = "$0"
            let v35 : (unit -> (string [])) = closure67(v28)
            let v36 : (unit -> (string [])) = Fable.Core.RustInterop.emitRustExpr v35 v34
            let v37 : string = "leptos::create_memo(move |_| { v36(()) })"
            let v38 : leptos_Memo<(string [])> = Fable.Core.RustInterop.emitRustExpr () v37
            let v39 : string = "state_core.use_requests (1)"
            let v40 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40
            let v42 : string = "state_core.use_database (1)"
            let v43 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v44 : bool = Fable.Core.RustInterop.emitRustExpr v42 v43
            let v45 : leptos_Resource<US2, rexie_Rexie> = method9()
            let v46 : string = "$0"
            let v47 : (unit -> rexie_Rexie option) = closure70(v45)
            let v48 : (unit -> rexie_Rexie option) = Fable.Core.RustInterop.emitRustExpr v47 v46
            let v49 : string = "leptos::create_memo(move |_| { v48(()) })"
            let v50 : leptos_Memo<rexie_Rexie option> = Fable.Core.RustInterop.emitRustExpr () v49
            let v51 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = method76(v33, v45)
            let v52 : string = "$0"
            let v53 : (unit -> Result<(Heap4 option []), std_string_String> option) = closure75(v51)
            let v54 : (unit -> Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v53 v52
            let v55 : string = "leptos::create_memo(move |_| { v54(()) })"
            let v56 : leptos_Memo<Result<(Heap4 option []), std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v55
            let v57 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = method89(v33, v56)
            let v58 : string = "leptos::create_action(move |value: &std::rc::Rc<Heap4>| $0(value.clone()))"
            let v59 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure88(v33, v50)
            let v60 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v59 v58
            let v61 : string = "$0"
            let v62 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = closure91(v33, v56, v57, v60)
            let v63 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v62 v61
            let v64 : string = "leptos::create_memo(move |_| { v63(()) })"
            let v65 : leptos_Memo<(Result<crate_model_near_nearblocks_Root option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v64
            let v66 : string = "$0"
            let v67 : (unit -> (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])) = closure102(v45, v51, v65)
            let v68 : (unit -> (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v67 v66
            let v69 : string = "leptos::create_memo(move |_| { v68(()) })"
            let v70 : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v69
            let v71 : string = $"%A{v70}"
            let v72 : string = "use_transactions.render (7) / root func0 / result: " + string v71 + ""
            let v73 : int32 = v72.Length
            let v74 : bool = v73 <= 200
            let v77 : string =
                if v74 then
                    v72
                else
                    let v75 : string = v72.[int 0..int 199]
                    let v76 : string = v75 + "..."
                    v76
            let v78 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78
            let v80 : string = "$0"
            let v81 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = closure111(v38, v70)
            let v82 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v81 v80
            let v83 : string = "leptos::create_memo(move |_| { v82(()) })"
            let v84 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v83
            let v85 : string = "$0"
            let v86 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = closure128(v84)
            let v87 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v86 v85
            let v88 : string = "leptos::create_memo(move |_| { v87(()) })"
            let v89 : leptos_Memo<Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v88
            let v90 : string = "$0"
            let v91 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure135(v89)
            let v92 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v91 v90
            let v93 : string = "leptos::create_memo(move |_| { v92(()) })"
            let v94 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v93
            let v95 : string = "state_core.use_requests (1)"
            let v96 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v97 : bool = Fable.Core.RustInterop.emitRustExpr v95 v96
            let v98 : string = "state_core.use_database (1)"
            let v99 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99
            let v101 : leptos_Resource<US2, rexie_Rexie> = method9()
            let v102 : string = "$0"
            let v103 : (unit -> rexie_Rexie option) = closure70(v101)
            let v104 : (unit -> rexie_Rexie option) = Fable.Core.RustInterop.emitRustExpr v103 v102
            let v105 : string = "leptos::create_memo(move |_| { v104(()) })"
            let v106 : leptos_Memo<rexie_Rexie option> = Fable.Core.RustInterop.emitRustExpr () v105
            let v107 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = method76(v94, v101)
            let v108 : string = "$0"
            let v109 : (unit -> Result<(Heap4 option []), std_string_String> option) = closure75(v107)
            let v110 : (unit -> Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v109 v108
            let v111 : string = "leptos::create_memo(move |_| { v110(()) })"
            let v112 : leptos_Memo<Result<(Heap4 option []), std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v111
            let v113 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = method89(v94, v112)
            let v114 : string = "leptos::create_action(move |value: &std::rc::Rc<Heap4>| $0(value.clone()))"
            let v115 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure88(v94, v106)
            let v116 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v115 v114
            let v117 : string = "$0"
            let v118 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = closure139(v94, v112, v113, v116)
            let v119 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v118 v117
            let v120 : string = "leptos::create_memo(move |_| { v119(()) })"
            let v121 : leptos_Memo<(Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v120
            let v122 : string = "$0"
            let v123 : (unit -> (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])) = closure143(v101, v107, v121)
            let v124 : (unit -> (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v123 v122
            let v125 : string = "leptos::create_memo(move |_| { v124(()) })"
            let v126 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v125
            let v127 : string = $"%A{v126}"
            let v128 : string = "use_transactions.render (12) / rpc_response func0 / result: " + string v127 + ""
            let v129 : int32 = v128.Length
            let v130 : bool = v129 <= 200
            let v133 : string =
                if v130 then
                    v128
                else
                    let v131 : string = v128.[int 0..int 199]
                    let v132 : string = v131 + "..."
                    v132
            let v134 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v135 : bool = Fable.Core.RustInterop.emitRustExpr v133 v134
            let v136 : string = "leptos::create_action(move |value: &std::rc::Rc<Heap6>| $0(value.clone()))"
            let v137 : (Heap6 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>>) = closure157()
            let v138 : leptos_Action<Heap6, Result<US60, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v137 v136
            let v139 : string = "$0"
            let v140 : (unit -> Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>) = closure162(v138)
            let v141 : (unit -> Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v140 v139
            let v142 : string = "leptos::create_memo(move |_| { v141(()) })"
            let v143 : leptos_Memo<Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v142
            let v144 : string = "$0"
            let v145 : (unit -> string option) = closure167(v143)
            let v146 : (unit -> string option) = Fable.Core.RustInterop.emitRustExpr v145 v144
            let v147 : string = "leptos::create_memo(move |_| { v146(()) })"
            let v148 : leptos_Memo<string option> = Fable.Core.RustInterop.emitRustExpr () v147
            let v149 : string = "$0"
            let v150 : (unit -> US34) = closure172(v10)
            let v151 : (unit -> US34) = Fable.Core.RustInterop.emitRustExpr v150 v149
            let v152 : string = "leptos::create_memo(move |_| { v151(()) })"
            let v153 : leptos_Memo<US34> = Fable.Core.RustInterop.emitRustExpr () v152
            let v154 : string = "$0"
            let v155 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>) = closure173(v10)
            let v156 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>) = Fable.Core.RustInterop.emitRustExpr v155 v154
            let v157 : string = "leptos::create_memo(move |_| { v156(()) })"
            let v158 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>> = Fable.Core.RustInterop.emitRustExpr () v157
            let v159 : string = "$0"
            let v160 : (unit -> Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>) = closure176(v158)
            let v161 : (unit -> Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>) = Fable.Core.RustInterop.emitRustExpr v160 v159
            let v162 : string = "leptos::create_memo(move |_| { v161(()) })"
            let v163 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = Fable.Core.RustInterop.emitRustExpr () v162
            let v164 : (leptos_View []) = [||]
            let v165 : (leptos_View []) = method167(v164)
            let v166 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v167 : leptos_View = Fable.Core.RustInterop.emitRustExpr v165 v166
            let v168 : (unit -> leptos_Fragment) = method168(v10, v138, v148, v153, v163)
            let v169 : (unit -> leptos_Fragment) = method191(v168)
            let v170 : string = "class=\"flex flex-col [position:relative]\""
            let v171 : (unit -> leptos_Fragment) = method218(v167, v169)
            let v172 : string = ""
            let v173 : string = " " + v170 + v172 + ""
            let v174 : (unit -> leptos_Fragment) = method179(v171)
            let v175 : (unit -> leptos_Fragment) = method180(v174)
            let v176 : string = "div"
            let v177 : string = "<" + v176 + " " + v173 + ">{v175()}</" + v176 + ">"
            let v178 : string = "leptos::view! { " + v177 + " }"
            let v179 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v178
            let v180 : leptos_HtmlElement<leptos_html_Div> = v179 |> unbox
            let v181 : string = "leptos::IntoView::into_view($0)"
            let v182 : leptos_View = Fable.Core.RustInterop.emitRustExpr v180 v181
            let v183 : (leptos_View []) = [||]
            let v184 : (leptos_View []) = method167(v183)
            let v185 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v186 : leptos_View = Fable.Core.RustInterop.emitRustExpr v184 v185
            let v187 : (unit -> leptos_Fragment) = method223(v126, v84, v28)
            let v188 : (unit -> leptos_Fragment) = method191(v187)
            let v189 : string = "class=\"flex flex-col [position:relative]\""
            let v190 : (unit -> leptos_Fragment) = method261(v186, v188)
            let v191 : string = " " + v189 + v172 + ""
            let v192 : (unit -> leptos_Fragment) = method179(v190)
            let v193 : (unit -> leptos_Fragment) = method180(v192)
            let v194 : string = "<" + v176 + " " + v191 + ">{v193()}</" + v176 + ">"
            let v195 : string = "leptos::view! { " + v194 + " }"
            let v196 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v195
            let v197 : leptos_HtmlElement<leptos_html_Div> = v196 |> unbox
            let v198 : string = "leptos::IntoView::into_view($0)"
            let v199 : leptos_View = Fable.Core.RustInterop.emitRustExpr v197 v198
            let v200 : (leptos_View []) = [|v182; v199|]
            let v201 : string = "$0.to_vec()"
            let v202 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v200 v201
            let v203 : string = "leptos::Fragment::new($0)"
            let v204 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v202 v203
            US24_0(v204)
        | US20_2 -> (* Lists *)
            let v206 : string = "lists_view.render ()"
            let v207 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v208 : bool = Fable.Core.RustInterop.emitRustExpr v206 v207
            let v209 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
            let v210 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v209
            let v211 : string = "$0.unwrap()"
            let v212 : Heap2 = Fable.Core.RustInterop.emitRustExpr v210 v211
            let v213 : string = method266()
            let v214 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v213 v214
            let v216 : string = "String::from($0)"
            let v217 : std_string_String = Fable.Core.RustInterop.emitRustExpr v215 v216
            let v218 : string = "leptos::html::text($0)"
            let v219 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v217 v218
            let v220 : string = "leptos::IntoView::into_view($0)"
            let v221 : leptos_View = Fable.Core.RustInterop.emitRustExpr v219 v220
            let v222 : (leptos_View []) = [|v221|]
            let v223 : string = "$0.to_vec()"
            let v224 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v222 v223
            let v225 : string = "leptos::Fragment::new($0)"
            let v226 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v224 v225
            US24_0(v226)
        | US20_4 -> (* Settings *)
            let v460 : string = "settings_view.render ()"
            let v461 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v462 : bool = Fable.Core.RustInterop.emitRustExpr v460 v461
            let v463 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
            let v464 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v463
            let v465 : string = "$0.unwrap()"
            let v466 : Heap2 = Fable.Core.RustInterop.emitRustExpr v464 v465
            let v467 : string = "$0"
            let v468 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) = closure279(v466)
            let v469 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) = Fable.Core.RustInterop.emitRustExpr v468 v467
            let v470 : string = "leptos::create_memo(move |_| { v469(()) })"
            let v471 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>> = Fable.Core.RustInterop.emitRustExpr () v470
            let v472 : string = $"leptos::create_signal($0)"
            let struct (v473 : leptos_ReadSignal<int32>, v474 : leptos_WriteSignal<int32>) = Fable.Core.RustInterop.emitRustExpr 0 v472
            let v475 : string = "$0"
            let v476 : (unit -> Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>) = closure282(v471, v473)
            let v477 : (unit -> Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>) = Fable.Core.RustInterop.emitRustExpr v476 v475
            let v478 : string = "leptos::create_memo(move |_| { v477(()) })"
            let v479 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> = Fable.Core.RustInterop.emitRustExpr () v478
            let v480 : string = "$0"
            let v481 : (unit -> int32) = closure285(v479)
            let v482 : (unit -> int32) = Fable.Core.RustInterop.emitRustExpr v481 v480
            let v483 : string = "leptos::create_memo(move |_| { v482(()) })"
            let v484 : leptos_Memo<int32> = Fable.Core.RustInterop.emitRustExpr () v483
            let v485 : (unit -> unit) = closure286(v466, v471, v474)
            let v486 : string = "let v485 = $0"
            Fable.Core.RustInterop.emitRustExpr v485 v486
            let v487 : string = "$0"
            let v488 : (unit -> string) = closure291()
            let v489 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v488 v487
            let v490 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v491 : string = "fill=\"none\""
            let v492 : string = "viewBox=\"0 0 24 24\""
            let v493 : string = "stroke-width=\"1.5\""
            let v494 : string = "stroke=\"currentColor\""
            let v495 : string = "class=move || \" \".to_owned() + &v489(())"
            let v496 : (unit -> leptos_Fragment) = method271()
            let v497 : string = ""
            let v498 : string = " " + v490 + v497 + ""
            let v499 : string = " " + v491 + v498 + ""
            let v500 : string = " " + v492 + v499 + ""
            let v501 : string = " " + v493 + v500 + ""
            let v502 : string = " " + v494 + v501 + ""
            let v503 : string = " " + v495 + v502 + ""
            let v504 : (unit -> leptos_Fragment) = method179(v496)
            let v505 : (unit -> leptos_Fragment) = method180(v504)
            let v506 : string = "svg"
            let v507 : string = "<" + v506 + " " + v503 + ">{v505()}</" + v506 + ">"
            let v508 : string = "leptos::view! { " + v507 + " }"
            let v509 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v508
            let v510 : leptos_HtmlElement<leptos_svg_Svg> = v509 |> unbox
            let v511 : string = "on:click=move |_| v485()"
            let v512 : string = "aria-label=\"Add\""
            let v513 : string = "$0"
            let v514 : (unit -> std_string_String) = closure293()
            let v515 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v514 v513
            let v516 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v515(())"
            let v517 : (unit -> leptos_Fragment) = method273(v510)
            let v518 : string = " " + v516 + v497 + ""
            let v519 : string = " " + v511 + v518 + ""
            let v520 : string = " " + v512 + v519 + ""
            let v521 : (unit -> leptos_Fragment) = method179(v517)
            let v522 : (unit -> leptos_Fragment) = method180(v521)
            let v523 : string = "button"
            let v524 : string = "<" + v523 + " " + v520 + ">{v522()}</" + v523 + ">"
            let v525 : string = "leptos::view! { " + v524 + " }"
            let v526 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v525
            let v527 : leptos_HtmlElement<leptos_html_Button> = v526 |> unbox
            let v528 : string = "leptos::IntoView::into_view($0)"
            let v529 : leptos_View = Fable.Core.RustInterop.emitRustExpr v527 v528
            let v530 : (leptos_View []) = [||]
            let v531 : (leptos_View []) = method167(v530)
            let v532 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v533 : leptos_View = Fable.Core.RustInterop.emitRustExpr v531 v532
            let v534 : (unit -> leptos_Fragment) = method274(v466, v479, v484, v471, v474)
            let v535 : (unit -> leptos_Fragment) = method191(v534)
            let v536 : string = "class=\"flex flex-col [position:relative]\""
            let v537 : (unit -> leptos_Fragment) = method299(v529, v535)
            let v538 : string = " " + v536 + v497 + ""
            let v539 : (unit -> leptos_Fragment) = method179(v537)
            let v540 : (unit -> leptos_Fragment) = method180(v539)
            let v541 : string = "div"
            let v542 : string = "<" + v541 + " " + v538 + ">{v540()}</" + v541 + ">"
            let v543 : string = "leptos::view! { " + v542 + " }"
            let v544 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v543
            let v545 : leptos_HtmlElement<leptos_html_Div> = v544 |> unbox
            let v546 : string = "leptos::IntoView::into_view($0)"
            let v547 : leptos_View = Fable.Core.RustInterop.emitRustExpr v545 v546
            let v548 : (leptos_View []) = [||]
            let v549 : (leptos_View []) = method167(v548)
            let v550 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v551 : leptos_View = Fable.Core.RustInterop.emitRustExpr v549 v550
            let v552 : (unit -> leptos_Fragment) = method304(v466)
            let v553 : (unit -> leptos_Fragment) = method191(v552)
            let v554 : string = "class=\"flex flex-col [position:relative]\""
            let v555 : (unit -> leptos_Fragment) = method323(v551, v553)
            let v556 : string = " " + v554 + v497 + ""
            let v557 : (unit -> leptos_Fragment) = method179(v555)
            let v558 : (unit -> leptos_Fragment) = method180(v557)
            let v559 : string = "<" + v541 + " " + v556 + ">{v558()}</" + v541 + ">"
            let v560 : string = "leptos::view! { " + v559 + " }"
            let v561 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v560
            let v562 : leptos_HtmlElement<leptos_html_Div> = v561 |> unbox
            let v563 : string = "leptos::IntoView::into_view($0)"
            let v564 : leptos_View = Fable.Core.RustInterop.emitRustExpr v562 v563
            let v565 : leptos_RwSignal<Heap1> = v466.l0
            let v566 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v567 : Heap1 = Fable.Core.RustInterop.emitRustExpr v565 v566
            let v568 : leptos_RwSignal<bool> = v567.l2
            let v569 : string = $"leptos::SignalGet::get(&$0)"
            let v570 : bool = Fable.Core.RustInterop.emitRustExpr v568 v569
            let v592 : leptos_View =
                if v570 then
                    let v571 : (leptos_View []) = [||]
                    let v572 : (leptos_View []) = method167(v571)
                    let v573 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v574 : leptos_View = Fable.Core.RustInterop.emitRustExpr v572 v573
                    let v575 : (unit -> leptos_Fragment) = method328()
                    let v576 : (unit -> leptos_Fragment) = method191(v575)
                    let v577 : string = "class=\"flex flex-col [position:relative]\""
                    let v578 : (unit -> leptos_Fragment) = method335(v574, v576)
                    let v579 : string = " " + v577 + v497 + ""
                    let v580 : (unit -> leptos_Fragment) = method179(v578)
                    let v581 : (unit -> leptos_Fragment) = method180(v580)
                    let v582 : string = "<" + v541 + " " + v579 + ">{v581()}</" + v541 + ">"
                    let v583 : string = "leptos::view! { " + v582 + " }"
                    let v584 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v583
                    let v585 : leptos_HtmlElement<leptos_html_Div> = v584 |> unbox
                    let v586 : string = "leptos::IntoView::into_view($0)"
                    let v587 : leptos_View = Fable.Core.RustInterop.emitRustExpr v585 v586
                    v587
                else
                    let v588 : (leptos_View []) = [||]
                    let v589 : (leptos_View []) = method167(v588)
                    let v590 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v591 : leptos_View = Fable.Core.RustInterop.emitRustExpr v589 v590
                    v591
            let v593 : (leptos_View []) = [|v547; v564; v592|]
            let v594 : string = "$0.to_vec()"
            let v595 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v593 v594
            let v596 : string = "leptos::Fragment::new($0)"
            let v597 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v595 v596
            US24_0(v597)
        | US20_3 -> (* Transactions *)
            let v228 : string = "transactions_view.render (1)"
            let v229 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v230 : bool = Fable.Core.RustInterop.emitRustExpr v228 v229
            let v231 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
            let v232 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v231
            let v233 : string = "$0.unwrap()"
            let v234 : Heap2 = Fable.Core.RustInterop.emitRustExpr v232 v233
            let v235 : string = "use_transactions.render (1)"
            let v236 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v237 : bool = Fable.Core.RustInterop.emitRustExpr v235 v236
            let v238 : string = "$0"
            let v239 : (unit -> Vec<string>) = closure55(v234)
            let v240 : (unit -> Vec<string>) = Fable.Core.RustInterop.emitRustExpr v239 v238
            let v241 : string = "leptos::create_memo(move |_| { v240(()) })"
            let v242 : leptos_Memo<Vec<string>> = Fable.Core.RustInterop.emitRustExpr () v241
            let v243 : string = "$0"
            let v244 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure60(v242)
            let v245 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v244 v243
            let v246 : string = "leptos::create_memo(move |_| { v245(()) })"
            let v247 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v246
            let v248 : string = "$0"
            let v249 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = closure62(v234, v242)
            let v250 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = Fable.Core.RustInterop.emitRustExpr v249 v248
            let v251 : string = "leptos::create_memo(move |_| { v250(()) })"
            let v252 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>> = Fable.Core.RustInterop.emitRustExpr () v251
            let v253 : string = "$0"
            let v254 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure65(v252)
            let v255 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v254 v253
            let v256 : string = "leptos::create_memo(move |_| { v255(()) })"
            let v257 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v256
            let v258 : string = "$0"
            let v259 : (unit -> (string [])) = closure67(v252)
            let v260 : (unit -> (string [])) = Fable.Core.RustInterop.emitRustExpr v259 v258
            let v261 : string = "leptos::create_memo(move |_| { v260(()) })"
            let v262 : leptos_Memo<(string [])> = Fable.Core.RustInterop.emitRustExpr () v261
            let v263 : string = "state_core.use_requests (1)"
            let v264 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr v263 v264
            let v266 : string = "state_core.use_database (1)"
            let v267 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v268 : bool = Fable.Core.RustInterop.emitRustExpr v266 v267
            let v269 : leptos_Resource<US2, rexie_Rexie> = method9()
            let v270 : string = "$0"
            let v271 : (unit -> rexie_Rexie option) = closure70(v269)
            let v272 : (unit -> rexie_Rexie option) = Fable.Core.RustInterop.emitRustExpr v271 v270
            let v273 : string = "leptos::create_memo(move |_| { v272(()) })"
            let v274 : leptos_Memo<rexie_Rexie option> = Fable.Core.RustInterop.emitRustExpr () v273
            let v275 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = method76(v257, v269)
            let v276 : string = "$0"
            let v277 : (unit -> Result<(Heap4 option []), std_string_String> option) = closure75(v275)
            let v278 : (unit -> Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v277 v276
            let v279 : string = "leptos::create_memo(move |_| { v278(()) })"
            let v280 : leptos_Memo<Result<(Heap4 option []), std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v279
            let v281 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = method89(v257, v280)
            let v282 : string = "leptos::create_action(move |value: &std::rc::Rc<Heap4>| $0(value.clone()))"
            let v283 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure88(v257, v274)
            let v284 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v283 v282
            let v285 : string = "$0"
            let v286 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = closure91(v257, v280, v281, v284)
            let v287 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v286 v285
            let v288 : string = "leptos::create_memo(move |_| { v287(()) })"
            let v289 : leptos_Memo<(Result<crate_model_near_nearblocks_Root option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v288
            let v290 : string = "$0"
            let v291 : (unit -> (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])) = closure102(v269, v275, v289)
            let v292 : (unit -> (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v291 v290
            let v293 : string = "leptos::create_memo(move |_| { v292(()) })"
            let v294 : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v293
            let v295 : string = $"%A{v294}"
            let v296 : string = "use_transactions.render (7) / root func0 / result: " + string v295 + ""
            let v297 : int32 = v296.Length
            let v298 : bool = v297 <= 200
            let v301 : string =
                if v298 then
                    v296
                else
                    let v299 : string = v296.[int 0..int 199]
                    let v300 : string = v299 + "..."
                    v300
            let v302 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v303 : bool = Fable.Core.RustInterop.emitRustExpr v301 v302
            let v304 : string = "$0"
            let v305 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = closure111(v262, v294)
            let v306 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v305 v304
            let v307 : string = "leptos::create_memo(move |_| { v306(()) })"
            let v308 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v307
            let v309 : string = "$0"
            let v310 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = closure128(v308)
            let v311 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v310 v309
            let v312 : string = "leptos::create_memo(move |_| { v311(()) })"
            let v313 : leptos_Memo<Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v312
            let v314 : string = "$0"
            let v315 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure135(v313)
            let v316 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v315 v314
            let v317 : string = "leptos::create_memo(move |_| { v316(()) })"
            let v318 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v317
            let v319 : string = "state_core.use_requests (1)"
            let v320 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v321 : bool = Fable.Core.RustInterop.emitRustExpr v319 v320
            let v322 : string = "state_core.use_database (1)"
            let v323 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v324 : bool = Fable.Core.RustInterop.emitRustExpr v322 v323
            let v325 : leptos_Resource<US2, rexie_Rexie> = method9()
            let v326 : string = "$0"
            let v327 : (unit -> rexie_Rexie option) = closure70(v325)
            let v328 : (unit -> rexie_Rexie option) = Fable.Core.RustInterop.emitRustExpr v327 v326
            let v329 : string = "leptos::create_memo(move |_| { v328(()) })"
            let v330 : leptos_Memo<rexie_Rexie option> = Fable.Core.RustInterop.emitRustExpr () v329
            let v331 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = method76(v318, v325)
            let v332 : string = "$0"
            let v333 : (unit -> Result<(Heap4 option []), std_string_String> option) = closure75(v331)
            let v334 : (unit -> Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v333 v332
            let v335 : string = "leptos::create_memo(move |_| { v334(()) })"
            let v336 : leptos_Memo<Result<(Heap4 option []), std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v335
            let v337 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = method89(v318, v336)
            let v338 : string = "leptos::create_action(move |value: &std::rc::Rc<Heap4>| $0(value.clone()))"
            let v339 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure88(v318, v330)
            let v340 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v339 v338
            let v341 : string = "$0"
            let v342 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = closure139(v318, v336, v337, v340)
            let v343 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v342 v341
            let v344 : string = "leptos::create_memo(move |_| { v343(()) })"
            let v345 : leptos_Memo<(Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v344
            let v346 : string = "$0"
            let v347 : (unit -> (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])) = closure143(v325, v331, v345)
            let v348 : (unit -> (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v347 v346
            let v349 : string = "leptos::create_memo(move |_| { v348(()) })"
            let v350 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []) option) [])) option) option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v349
            let v351 : string = $"%A{v350}"
            let v352 : string = "use_transactions.render (12) / rpc_response func0 / result: " + string v351 + ""
            let v353 : int32 = v352.Length
            let v354 : bool = v353 <= 200
            let v357 : string =
                if v354 then
                    v352
                else
                    let v355 : string = v352.[int 0..int 199]
                    let v356 : string = v355 + "..."
                    v356
            let v358 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v359 : bool = Fable.Core.RustInterop.emitRustExpr v357 v358
            let v360 : string = $"leptos::create_signal($0)"
            let struct (v361 : leptos_ReadSignal<bool>, v362 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr false v360
            let v363 : (unit -> unit) = closure378(v362)
            let v364 : string = "let v363 = $0"
            Fable.Core.RustInterop.emitRustExpr v363 v364
            let v365 : string = "$0"
            let v366 : (unit -> string) = closure379()
            let v367 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v366 v365
            let v368 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v369 : string = "fill=\"none\""
            let v370 : string = "viewBox=\"0 0 24 24\""
            let v371 : string = "stroke-width=\"1.5\""
            let v372 : string = "stroke=\"currentColor\""
            let v373 : string = "class=move || \" \".to_owned() + &v367(())"
            let v374 : (unit -> leptos_Fragment) = method340()
            let v375 : string = ""
            let v376 : string = " " + v368 + v375 + ""
            let v377 : string = " " + v369 + v376 + ""
            let v378 : string = " " + v370 + v377 + ""
            let v379 : string = " " + v371 + v378 + ""
            let v380 : string = " " + v372 + v379 + ""
            let v381 : string = " " + v373 + v380 + ""
            let v382 : (unit -> leptos_Fragment) = method179(v374)
            let v383 : (unit -> leptos_Fragment) = method180(v382)
            let v384 : string = "svg"
            let v385 : string = "<" + v384 + " " + v381 + ">{v383()}</" + v384 + ">"
            let v386 : string = "leptos::view! { " + v385 + " }"
            let v387 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v386
            let v388 : leptos_HtmlElement<leptos_svg_Svg> = v387 |> unbox
            let v389 : string = "on:click=move |_| v363()"
            let v390 : string = "aria-label=\"Settings\""
            let v391 : string = "$0"
            let v392 : (unit -> std_string_String) = closure381(v361)
            let v393 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v392 v391
            let v394 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v393(())"
            let v395 : (unit -> leptos_Fragment) = method273(v388)
            let v396 : string = " " + v394 + v375 + ""
            let v397 : string = " " + v389 + v396 + ""
            let v398 : string = " " + v390 + v397 + ""
            let v399 : (unit -> leptos_Fragment) = method179(v395)
            let v400 : (unit -> leptos_Fragment) = method180(v399)
            let v401 : string = "button"
            let v402 : string = "<" + v401 + " " + v398 + ">{v400()}</" + v401 + ">"
            let v403 : string = "leptos::view! { " + v402 + " }"
            let v404 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v403
            let v405 : leptos_HtmlElement<leptos_html_Button> = v404 |> unbox
            let v406 : string = "leptos::IntoView::into_view($0)"
            let v407 : leptos_View = Fable.Core.RustInterop.emitRustExpr v405 v406
            let v408 : (leptos_View []) = [||]
            let v409 : (leptos_View []) = method167(v408)
            let v410 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v411 : leptos_View = Fable.Core.RustInterop.emitRustExpr v409 v410
            let v412 : (unit -> leptos_Fragment) = method342(v234, v308, v252, v361)
            let v413 : (unit -> leptos_Fragment) = method191(v412)
            let v414 : string = "class=\"flex flex-col [position:relative]\""
            let v415 : (unit -> leptos_Fragment) = method450(v407, v413)
            let v416 : string = " " + v414 + v375 + ""
            let v417 : (unit -> leptos_Fragment) = method179(v415)
            let v418 : (unit -> leptos_Fragment) = method180(v417)
            let v419 : string = "div"
            let v420 : string = "<" + v419 + " " + v416 + ">{v418()}</" + v419 + ">"
            let v421 : string = "leptos::view! { " + v420 + " }"
            let v422 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v421
            let v423 : leptos_HtmlElement<leptos_html_Div> = v422 |> unbox
            let v424 : string = "leptos::IntoView::into_view($0)"
            let v425 : leptos_View = Fable.Core.RustInterop.emitRustExpr v423 v424
            let v426 : leptos_RwSignal<Heap1> = v234.l0
            let v427 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v428 : Heap1 = Fable.Core.RustInterop.emitRustExpr v426 v427
            let v429 : leptos_RwSignal<bool> = v428.l2
            let v430 : string = $"leptos::SignalGet::get(&$0)"
            let v431 : bool = Fable.Core.RustInterop.emitRustExpr v429 v430
            let v453 : leptos_View =
                if v431 then
                    let v432 : (leptos_View []) = [||]
                    let v433 : (leptos_View []) = method167(v432)
                    let v434 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v435 : leptos_View = Fable.Core.RustInterop.emitRustExpr v433 v434
                    let v436 : (unit -> leptos_Fragment) = method455(v308)
                    let v437 : (unit -> leptos_Fragment) = method191(v436)
                    let v438 : string = "class=\"flex flex-col [position:relative]\""
                    let v439 : (unit -> leptos_Fragment) = method459(v435, v437)
                    let v440 : string = " " + v438 + v375 + ""
                    let v441 : (unit -> leptos_Fragment) = method179(v439)
                    let v442 : (unit -> leptos_Fragment) = method180(v441)
                    let v443 : string = "<" + v419 + " " + v440 + ">{v442()}</" + v419 + ">"
                    let v444 : string = "leptos::view! { " + v443 + " }"
                    let v445 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v444
                    let v446 : leptos_HtmlElement<leptos_html_Div> = v445 |> unbox
                    let v447 : string = "leptos::IntoView::into_view($0)"
                    let v448 : leptos_View = Fable.Core.RustInterop.emitRustExpr v446 v447
                    v448
                else
                    let v449 : (leptos_View []) = [||]
                    let v450 : (leptos_View []) = method167(v449)
                    let v451 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v452 : leptos_View = Fable.Core.RustInterop.emitRustExpr v450 v451
                    v452
            let v454 : (leptos_View []) = [|v425; v453|]
            let v455 : string = "$0.to_vec()"
            let v456 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v454 v455
            let v457 : string = "leptos::Fragment::new($0)"
            let v458 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v456 v457
            US24_0(v458)
        | _ ->
            US24_1
    let v623 : leptos_View =
        match v603 with
        | US24_1 -> (* None *)
            let v618 : (leptos_View []) = [||]
            let v619 : (leptos_View []) = method167(v618)
            let v620 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v621 : leptos_View = Fable.Core.RustInterop.emitRustExpr v619 v620
            v621
        | US24_0(v604) -> (* Some *)
            let v605 : string = "class=\"flex flex-1 flex-col [overflow-y:auto]\""
            let v606 : (unit -> leptos_Fragment) = method464(v604)
            let v607 : string = ""
            let v608 : string = " " + v605 + v607 + ""
            let v609 : (unit -> leptos_Fragment) = method179(v606)
            let v610 : (unit -> leptos_Fragment) = method180(v609)
            let v611 : string = "div"
            let v612 : string = "<" + v611 + " " + v608 + ">{v610()}</" + v611 + ">"
            let v613 : string = "leptos::view! { " + v612 + " }"
            let v614 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v613
            let v615 : leptos_HtmlElement<leptos_html_Div> = v614 |> unbox
            let v616 : string = "leptos::IntoView::into_view($0)"
            let v617 : leptos_View = Fable.Core.RustInterop.emitRustExpr v615 v616
            v617
    let v624 : (leptos_View []) = [|v623|]
    let v625 : string = "$0.to_vec()"
    let v626 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v624 v625
    let v627 : string = "leptos::Fragment::new($0)"
    let v628 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v626 v627
    v628
and method66 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure54(v0)
and method468 () : string =
    let v0 : string = "Tab"
    v0
and closure538 () () : leptos_Fragment =
    let v0 : string = method468()
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "leptos::html::text($0)"
    let v6 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::IntoView::into_view($0)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : (leptos_View []) = [|v8|]
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "leptos::Fragment::new($0)"
    let v13 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v11 v12
    v13
and method467 () : (unit -> leptos_Fragment) =
    closure538()
and closure541 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : bool =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : US20 = Fable.Core.RustInterop.emitRustExpr v0 v2
    match v3, v1 with
    | US20_0, US20_0 -> (* Blank *)
        true
    | US20_1(v4), US20_1(v5) -> (* Dice *)
        match v4, v5 with
        | US21_0, US21_0 -> (* Dice' *)
            true
        | _ ->
            false
    | US20_2, US20_2 -> (* Lists *)
        true
    | US20_4, US20_4 -> (* Settings *)
        true
    | US20_3, US20_3 -> (* Transactions *)
        true
    | _ ->
        false
and method470 (v0 : leptos_ReadSignal<US20>, v1 : US20) : (unit -> bool) =
    closure541(v0, v1)
and closure542 (v0 : string) () : leptos_Fragment =
    let v1 : string = method19(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : (leptos_View []) = [|v9|]
    let v11 : string = "$0.to_vec()"
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "leptos::Fragment::new($0)"
    let v14 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v12 v13
    v14
and method471 (v0 : string) : (unit -> leptos_Fragment) =
    closure542(v0)
and closure540 (v0 : leptos_ReadSignal<US20>) (v1 : US20) : leptos_View =
    let v12 : string =
        match v1 with
        | US20_0 -> (* Blank *)
            let v2 : string = ""
            v2
        | US20_1(v3) -> (* Dice *)
            let v4 : string = "Dice"
            v4
        | US20_2 -> (* Lists *)
            let v5 : string = "Lists"
            v5
        | US20_4 -> (* Settings *)
            let v7 : string = "Settings"
            v7
        | US20_3 -> (* Transactions *)
            let v6 : string = "Transactions"
            v6
    let v13 : (unit -> bool) = method470(v0, v1)
    let v14 : string = "select=v13()"
    let v15 : (unit -> leptos_Fragment) = method471(v12)
    let v16 : string = ""
    let v17 : string = " " + v14 + v16 + ""
    let v18 : (unit -> leptos_Fragment) = method179(v15)
    let v19 : (unit -> leptos_Fragment) = method180(v18)
    let v20 : string = "option"
    let v21 : string = "<" + v20 + " " + v17 + ">{v19()}</" + v20 + ">"
    let v22 : string = "leptos::view! { " + v21 + " }"
    let v23 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : leptos_HtmlElement<leptos_html_Option> = v23 |> unbox
    let v25 : string = "leptos::IntoView::into_view($0)"
    let v26 : leptos_View = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and closure539 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : US21 = US21_0
    let v2 : US20 = US20_1(v1)
    let v3 : US20 = US20_2
    let v4 : US20 = US20_3
    let v5 : US20 = US20_4
    let v6 : (US20 []) = [|v2; v3; v4; v5|]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<US20> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v10 : (US20 -> leptos_View) = closure540(v0)
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9
    let v12 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v13 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method469 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure539(v0)
and closure537 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "for=\"Tab\""
    let v2 : string = "class=\"sr-only\""
    let v3 : (unit -> leptos_Fragment) = method467()
    let v4 : string = ""
    let v5 : string = " " + v1 + v4 + ""
    let v6 : string = " " + v2 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method179(v3)
    let v8 : (unit -> leptos_Fragment) = method180(v7)
    let v9 : string = "label"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : leptos_HtmlElement<leptos_html_Label> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "id=\"Tab\""
    let v17 : string = "class=\"w-full rounded-md border-gray-200\""
    let v18 : (unit -> leptos_Fragment) = method469(v0)
    let v19 : string = " " + v16 + v4 + ""
    let v20 : string = " " + v17 + v19 + ""
    let v21 : (unit -> leptos_Fragment) = method179(v18)
    let v22 : (unit -> leptos_Fragment) = method180(v21)
    let v23 : string = "select"
    let v24 : string = "<" + v23 + " " + v20 + ">{v22()}</" + v23 + ">"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : leptos_HtmlElement<leptos_html_Select> = v26 |> unbox
    let v28 : string = "leptos::IntoView::into_view($0)"
    let v29 : leptos_View = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : (leptos_View []) = [|v15; v29|]
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method466 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure537(v0)
and closure547 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure549 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method476 () : (unit -> leptos_Fragment) =
    closure549()
and closure548 () () : leptos_Fragment =
    let v0 : string = "x=\"3\""
    let v1 : string = "y=\"3\""
    let v2 : string = "width=\"18\""
    let v3 : string = "height=\"18\""
    let v4 : string = "rx=\"2\""
    let v5 : string = "stroke-linecap=\"round\""
    let v6 : string = "stroke-linejoin=\"round\""
    let v7 : (unit -> leptos_Fragment) = method476()
    let v8 : string = ""
    let v9 : string = " " + v0 + v8 + ""
    let v10 : string = " " + v1 + v9 + ""
    let v11 : string = " " + v2 + v10 + ""
    let v12 : string = " " + v3 + v11 + ""
    let v13 : string = " " + v4 + v12 + ""
    let v14 : string = " " + v5 + v13 + ""
    let v15 : string = " " + v6 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method179(v7)
    let v17 : (unit -> leptos_Fragment) = method180(v16)
    let v18 : string = "rect"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_svg_Rect> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "cx=\"7.5\""
    let v26 : string = "cy=\"7.5\""
    let v27 : string = "r=\"1.5\""
    let v28 : string = "fill=\"currentColor\""
    let v29 : (unit -> leptos_Fragment) = method190()
    let v30 : string = " " + v25 + v8 + ""
    let v31 : string = " " + v26 + v30 + ""
    let v32 : string = " " + v27 + v31 + ""
    let v33 : string = " " + v28 + v32 + ""
    let v34 : (unit -> leptos_Fragment) = method179(v29)
    let v35 : (unit -> leptos_Fragment) = method180(v34)
    let v36 : string = "circle"
    let v37 : string = "<" + v36 + " " + v33 + ">{v35()}</" + v36 + ">"
    let v38 : string = "leptos::view! { " + v37 + " }"
    let v39 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : leptos_HtmlElement<leptos_svg_Circle> = v39 |> unbox
    let v41 : string = "leptos::IntoView::into_view($0)"
    let v42 : leptos_View = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = "cx=\"16.5\""
    let v44 : string = "cy=\"7.5\""
    let v45 : string = "r=\"1.5\""
    let v46 : string = "fill=\"currentColor\""
    let v47 : (unit -> leptos_Fragment) = method190()
    let v48 : string = " " + v43 + v8 + ""
    let v49 : string = " " + v44 + v48 + ""
    let v50 : string = " " + v45 + v49 + ""
    let v51 : string = " " + v46 + v50 + ""
    let v52 : (unit -> leptos_Fragment) = method179(v47)
    let v53 : (unit -> leptos_Fragment) = method180(v52)
    let v54 : string = "<" + v36 + " " + v51 + ">{v53()}</" + v36 + ">"
    let v55 : string = "leptos::view! { " + v54 + " }"
    let v56 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : leptos_HtmlElement<leptos_svg_Circle> = v56 |> unbox
    let v58 : string = "leptos::IntoView::into_view($0)"
    let v59 : leptos_View = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "cx=\"12\""
    let v61 : string = "cy=\"12\""
    let v62 : string = "r=\"1.5\""
    let v63 : string = "fill=\"currentColor\""
    let v64 : (unit -> leptos_Fragment) = method190()
    let v65 : string = " " + v60 + v8 + ""
    let v66 : string = " " + v61 + v65 + ""
    let v67 : string = " " + v62 + v66 + ""
    let v68 : string = " " + v63 + v67 + ""
    let v69 : (unit -> leptos_Fragment) = method179(v64)
    let v70 : (unit -> leptos_Fragment) = method180(v69)
    let v71 : string = "<" + v36 + " " + v68 + ">{v70()}</" + v36 + ">"
    let v72 : string = "leptos::view! { " + v71 + " }"
    let v73 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : leptos_HtmlElement<leptos_svg_Circle> = v73 |> unbox
    let v75 : string = "leptos::IntoView::into_view($0)"
    let v76 : leptos_View = Fable.Core.RustInterop.emitRustExpr v74 v75
    let v77 : string = "cx=\"7.5\""
    let v78 : string = "cy=\"16.5\""
    let v79 : string = "r=\"1.5\""
    let v80 : string = "fill=\"currentColor\""
    let v81 : (unit -> leptos_Fragment) = method190()
    let v82 : string = " " + v77 + v8 + ""
    let v83 : string = " " + v78 + v82 + ""
    let v84 : string = " " + v79 + v83 + ""
    let v85 : string = " " + v80 + v84 + ""
    let v86 : (unit -> leptos_Fragment) = method179(v81)
    let v87 : (unit -> leptos_Fragment) = method180(v86)
    let v88 : string = "<" + v36 + " " + v85 + ">{v87()}</" + v36 + ">"
    let v89 : string = "leptos::view! { " + v88 + " }"
    let v90 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v89
    let v91 : leptos_HtmlElement<leptos_svg_Circle> = v90 |> unbox
    let v92 : string = "leptos::IntoView::into_view($0)"
    let v93 : leptos_View = Fable.Core.RustInterop.emitRustExpr v91 v92
    let v94 : string = "cx=\"16.5\""
    let v95 : string = "cy=\"16.5\""
    let v96 : string = "r=\"1.5\""
    let v97 : string = "fill=\"currentColor\""
    let v98 : (unit -> leptos_Fragment) = method190()
    let v99 : string = " " + v94 + v8 + ""
    let v100 : string = " " + v95 + v99 + ""
    let v101 : string = " " + v96 + v100 + ""
    let v102 : string = " " + v97 + v101 + ""
    let v103 : (unit -> leptos_Fragment) = method179(v98)
    let v104 : (unit -> leptos_Fragment) = method180(v103)
    let v105 : string = "<" + v36 + " " + v102 + ">{v104()}</" + v36 + ">"
    let v106 : string = "leptos::view! { " + v105 + " }"
    let v107 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v106
    let v108 : leptos_HtmlElement<leptos_svg_Circle> = v107 |> unbox
    let v109 : string = "leptos::IntoView::into_view($0)"
    let v110 : leptos_View = Fable.Core.RustInterop.emitRustExpr v108 v109
    let v111 : (leptos_View []) = [|v24; v42; v59; v76; v93; v110|]
    let v112 : string = "$0.to_vec()"
    let v113 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v111 v112
    let v114 : string = "leptos::Fragment::new($0)"
    let v115 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v113 v114
    v115
and method475 () : (unit -> leptos_Fragment) =
    closure548()
and closure550 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M4.75 6.75h14.5M4.75 12h14.5M4.75 17.25h14.5\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : string = "leptos::IntoView::into_view($0)"
    let v16 : leptos_View = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "cx=\"3\""
    let v18 : string = "cy=\"6.75\""
    let v19 : string = "r=\"1\""
    let v20 : string = "fill=\"currentColor\""
    let v21 : (unit -> leptos_Fragment) = method190()
    let v22 : string = " " + v17 + v4 + ""
    let v23 : string = " " + v18 + v22 + ""
    let v24 : string = " " + v19 + v23 + ""
    let v25 : string = " " + v20 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method179(v21)
    let v27 : (unit -> leptos_Fragment) = method180(v26)
    let v28 : string = "circle"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_svg_Circle> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "cx=\"3\""
    let v36 : string = "cy=\"12\""
    let v37 : string = "r=\"1\""
    let v38 : string = "fill=\"currentColor\""
    let v39 : (unit -> leptos_Fragment) = method190()
    let v40 : string = " " + v35 + v4 + ""
    let v41 : string = " " + v36 + v40 + ""
    let v42 : string = " " + v37 + v41 + ""
    let v43 : string = " " + v38 + v42 + ""
    let v44 : (unit -> leptos_Fragment) = method179(v39)
    let v45 : (unit -> leptos_Fragment) = method180(v44)
    let v46 : string = "<" + v28 + " " + v43 + ">{v45()}</" + v28 + ">"
    let v47 : string = "leptos::view! { " + v46 + " }"
    let v48 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : leptos_HtmlElement<leptos_svg_Circle> = v48 |> unbox
    let v50 : string = "leptos::IntoView::into_view($0)"
    let v51 : leptos_View = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "cx=\"3\""
    let v53 : string = "cy=\"17.25\""
    let v54 : string = "r=\"1\""
    let v55 : string = "fill=\"currentColor\""
    let v56 : (unit -> leptos_Fragment) = method190()
    let v57 : string = " " + v52 + v4 + ""
    let v58 : string = " " + v53 + v57 + ""
    let v59 : string = " " + v54 + v58 + ""
    let v60 : string = " " + v55 + v59 + ""
    let v61 : (unit -> leptos_Fragment) = method179(v56)
    let v62 : (unit -> leptos_Fragment) = method180(v61)
    let v63 : string = "<" + v28 + " " + v60 + ">{v62()}</" + v28 + ">"
    let v64 : string = "leptos::view! { " + v63 + " }"
    let v65 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : leptos_HtmlElement<leptos_svg_Circle> = v65 |> unbox
    let v67 : string = "leptos::IntoView::into_view($0)"
    let v68 : leptos_View = Fable.Core.RustInterop.emitRustExpr v66 v67
    let v69 : (leptos_View []) = [|v16; v34; v51; v68|]
    let v70 : string = "$0.to_vec()"
    let v71 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v69 v70
    let v72 : string = "leptos::Fragment::new($0)"
    let v73 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v71 v72
    v73
and method477 () : (unit -> leptos_Fragment) =
    closure550()
and closure551 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M4 12h16m-7-7l7 7-7 7m-2-14l-7 7 7 7\""
    let v3 : (unit -> leptos_Fragment) = method178()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v3)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure190()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method478 () : (unit -> leptos_Fragment) =
    closure551()
and closure552 (v0 : leptos_Memo<string>, v1 : string) () : std_string_String =
    let v2 : string = $"$0()"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = v3 + "#/" + v1 + ""
    let v5 : string = method19(v4)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    v9
and closure553 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : bool =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : US20 = Fable.Core.RustInterop.emitRustExpr v0 v2
    match v3, v1 with
    | US20_0, US20_0 -> (* Blank *)
        true
    | US20_1(v4), US20_1(v5) -> (* Dice *)
        match v4, v5 with
        | US21_0, US21_0 -> (* Dice' *)
            true
        | _ ->
            false
    | US20_2, US20_2 -> (* Lists *)
        true
    | US20_4, US20_4 -> (* Settings *)
        true
    | US20_3, US20_3 -> (* Transactions *)
        true
    | _ ->
        false
and closure554 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : StaticRef<Str> =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : US20 = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v7 : bool =
        match v3, v1 with
        | US20_0, US20_0 -> (* Blank *)
            true
        | US20_1(v4), US20_1(v5) -> (* Dice *)
            match v4, v5 with
            | US21_0, US21_0 -> (* Dice' *)
                true
            | _ ->
                false
        | US20_2, US20_2 -> (* Lists *)
            true
        | US20_4, US20_4 -> (* Settings *)
            true
        | US20_3, US20_3 -> (* Transactions *)
            true
        | _ ->
            false
    if v7 then
        let v8 : string = "border-grey-200 text-grey-900"
        let v9 : string = "r#\"" + v8 + "\"#"
        let v10 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v9
        v10
    else
        let v11 : string = "border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"
        let v12 : string = "r#\"" + v11 + "\"#"
        let v13 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v12
        v13
and closure555 (v0 : leptos_Fragment, v1 : string) () : leptos_Fragment =
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = method19(v1)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "leptos::html::text($0)"
    let v10 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : (leptos_View []) = [|v3; v12|]
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method479 (v0 : leptos_Fragment, v1 : string) : (unit -> leptos_Fragment) =
    closure555(v0, v1)
and closure546 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) (v2 : US20) : leptos_View =
    let v13 : string =
        match v2 with
        | US20_0 -> (* Blank *)
            let v3 : string = ""
            v3
        | US20_1(v4) -> (* Dice *)
            let v5 : string = "dice"
            v5
        | US20_2 -> (* Lists *)
            let v6 : string = "lists"
            v6
        | US20_4 -> (* Settings *)
            let v8 : string = "settings"
            v8
        | US20_3 -> (* Transactions *)
            let v7 : string = "transactions"
            v7
    let v151 : leptos_Fragment =
        match v2 with
        | US20_1(v14) -> (* Dice *)
            let v15 : string = "$0"
            let v16 : (unit -> string) = closure547()
            let v17 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v16 v15
            let v18 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v19 : string = "fill=\"none\""
            let v20 : string = "viewBox=\"0 0 24 24\""
            let v21 : string = "stroke-width=\"1.5\""
            let v22 : string = "stroke=\"currentColor\""
            let v23 : string = "class=move || \" \".to_owned() + &v17(())"
            let v24 : (unit -> leptos_Fragment) = method475()
            let v25 : string = ""
            let v26 : string = " " + v18 + v25 + ""
            let v27 : string = " " + v19 + v26 + ""
            let v28 : string = " " + v20 + v27 + ""
            let v29 : string = " " + v21 + v28 + ""
            let v30 : string = " " + v22 + v29 + ""
            let v31 : string = " " + v23 + v30 + ""
            let v32 : (unit -> leptos_Fragment) = method179(v24)
            let v33 : (unit -> leptos_Fragment) = method180(v32)
            let v34 : string = "svg"
            let v35 : string = "<" + v34 + " " + v31 + ">{v33()}</" + v34 + ">"
            let v36 : string = "leptos::view! { " + v35 + " }"
            let v37 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v36
            let v38 : leptos_HtmlElement<leptos_svg_Svg> = v37 |> unbox
            let v39 : string = "leptos::IntoView::into_view($0)"
            let v40 : leptos_View = Fable.Core.RustInterop.emitRustExpr v38 v39
            let v41 : (leptos_View []) = [|v40|]
            let v42 : string = "$0.to_vec()"
            let v43 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v41 v42
            let v44 : string = "leptos::Fragment::new($0)"
            let v45 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v43 v44
            v45
        | US20_2 -> (* Lists *)
            let v46 : string = "$0"
            let v47 : (unit -> string) = closure547()
            let v48 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v47 v46
            let v49 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v50 : string = "fill=\"none\""
            let v51 : string = "height=\"100%\""
            let v52 : string = "viewBox=\"0 0 24 24\""
            let v53 : string = "stroke-width=\"1.5\""
            let v54 : string = "stroke=\"currentColor\""
            let v55 : string = "class=move || \"text-gray-700 \".to_owned() + &v48(())"
            let v56 : (unit -> leptos_Fragment) = method477()
            let v57 : string = ""
            let v58 : string = " " + v49 + v57 + ""
            let v59 : string = " " + v50 + v58 + ""
            let v60 : string = " " + v51 + v59 + ""
            let v61 : string = " " + v52 + v60 + ""
            let v62 : string = " " + v53 + v61 + ""
            let v63 : string = " " + v54 + v62 + ""
            let v64 : string = " " + v55 + v63 + ""
            let v65 : (unit -> leptos_Fragment) = method179(v56)
            let v66 : (unit -> leptos_Fragment) = method180(v65)
            let v67 : string = "svg"
            let v68 : string = "<" + v67 + " " + v64 + ">{v66()}</" + v67 + ">"
            let v69 : string = "leptos::view! { " + v68 + " }"
            let v70 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v69
            let v71 : leptos_HtmlElement<leptos_svg_Svg> = v70 |> unbox
            let v72 : string = "leptos::IntoView::into_view($0)"
            let v73 : leptos_View = Fable.Core.RustInterop.emitRustExpr v71 v72
            let v74 : (leptos_View []) = [|v73|]
            let v75 : string = "$0.to_vec()"
            let v76 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v74 v75
            let v77 : string = "leptos::Fragment::new($0)"
            let v78 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v76 v77
            v78
        | US20_4 -> (* Settings *)
            let v112 : string = "$0"
            let v113 : (unit -> string) = closure547()
            let v114 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v113 v112
            let v115 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v116 : string = "fill=\"none\""
            let v117 : string = "viewBox=\"0 0 24 24\""
            let v118 : string = "stroke-width=\"1.5\""
            let v119 : string = "stroke=\"currentColor\""
            let v120 : string = "class=move || \" \".to_owned() + &v114(())"
            let v121 : (unit -> leptos_Fragment) = method340()
            let v122 : string = ""
            let v123 : string = " " + v115 + v122 + ""
            let v124 : string = " " + v116 + v123 + ""
            let v125 : string = " " + v117 + v124 + ""
            let v126 : string = " " + v118 + v125 + ""
            let v127 : string = " " + v119 + v126 + ""
            let v128 : string = " " + v120 + v127 + ""
            let v129 : (unit -> leptos_Fragment) = method179(v121)
            let v130 : (unit -> leptos_Fragment) = method180(v129)
            let v131 : string = "svg"
            let v132 : string = "<" + v131 + " " + v128 + ">{v130()}</" + v131 + ">"
            let v133 : string = "leptos::view! { " + v132 + " }"
            let v134 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v133
            let v135 : leptos_HtmlElement<leptos_svg_Svg> = v134 |> unbox
            let v136 : string = "leptos::IntoView::into_view($0)"
            let v137 : leptos_View = Fable.Core.RustInterop.emitRustExpr v135 v136
            let v138 : (leptos_View []) = [|v137|]
            let v139 : string = "$0.to_vec()"
            let v140 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v138 v139
            let v141 : string = "leptos::Fragment::new($0)"
            let v142 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v140 v141
            v142
        | US20_3 -> (* Transactions *)
            let v79 : string = "$0"
            let v80 : (unit -> string) = closure547()
            let v81 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v80 v79
            let v82 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v83 : string = "fill=\"none\""
            let v84 : string = "height=\"100%\""
            let v85 : string = "viewBox=\"0 0 24 24\""
            let v86 : string = "stroke-width=\"1.5\""
            let v87 : string = "stroke=\"currentColor\""
            let v88 : string = "class=move || \"text-gray-700 \".to_owned() + &v81(())"
            let v89 : (unit -> leptos_Fragment) = method478()
            let v90 : string = ""
            let v91 : string = " " + v82 + v90 + ""
            let v92 : string = " " + v83 + v91 + ""
            let v93 : string = " " + v84 + v92 + ""
            let v94 : string = " " + v85 + v93 + ""
            let v95 : string = " " + v86 + v94 + ""
            let v96 : string = " " + v87 + v95 + ""
            let v97 : string = " " + v88 + v96 + ""
            let v98 : (unit -> leptos_Fragment) = method179(v89)
            let v99 : (unit -> leptos_Fragment) = method180(v98)
            let v100 : string = "svg"
            let v101 : string = "<" + v100 + " " + v97 + ">{v99()}</" + v100 + ">"
            let v102 : string = "leptos::view! { " + v101 + " }"
            let v103 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v102
            let v104 : leptos_HtmlElement<leptos_svg_Svg> = v103 |> unbox
            let v105 : string = "leptos::IntoView::into_view($0)"
            let v106 : leptos_View = Fable.Core.RustInterop.emitRustExpr v104 v105
            let v107 : (leptos_View []) = [|v106|]
            let v108 : string = "$0.to_vec()"
            let v109 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v107 v108
            let v110 : string = "leptos::Fragment::new($0)"
            let v111 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v109 v110
            v111
        | _ ->
            let v143 : (leptos_View []) = [||]
            let v144 : string = "$0.to_vec()"
            let v145 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v143 v144
            let v146 : string = "leptos::Fragment::new($0)"
            let v147 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v145 v146
            v147
    let v162 : string =
        match v2 with
        | US20_0 -> (* Blank *)
            let v152 : string = ""
            v152
        | US20_1(v153) -> (* Dice *)
            let v154 : string = "Dice"
            v154
        | US20_2 -> (* Lists *)
            let v155 : string = "Lists"
            v155
        | US20_4 -> (* Settings *)
            let v157 : string = "Settings"
            v157
        | US20_3 -> (* Transactions *)
            let v156 : string = "Transactions"
            v156
    let v163 : (unit -> std_string_String) = closure552(v1, v13)
    let v164 : string = "let v163 = $0"
    Fable.Core.RustInterop.emitRustExpr v163 v164
    let v165 : string = "$0"
    let v166 : (unit -> bool) = closure553(v0, v2)
    let v167 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v166 v165
    let v168 : string = "$0"
    let v169 : (unit -> StaticRef<Str>) = closure554(v0, v2)
    let v170 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v169 v168
    let v171 : string = "href=move || v163()"
    let v172 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[15px] pl-[15px] text-sm font-medium \".to_owned() + v170(())"
    let v173 : string = "aria-current=move || if v167(()) { \"page\" } else { \"\" }"
    let v174 : (unit -> leptos_Fragment) = method479(v151, v162)
    let v175 : string = ""
    let v176 : string = " " + v171 + v175 + ""
    let v177 : string = " " + v172 + v176 + ""
    let v178 : string = " " + v173 + v177 + ""
    let v179 : (unit -> leptos_Fragment) = method179(v174)
    let v180 : (unit -> leptos_Fragment) = method180(v179)
    let v181 : string = "a"
    let v182 : string = "<" + v181 + " " + v178 + ">{v180()}</" + v181 + ">"
    let v183 : string = "leptos::view! { " + v182 + " }"
    let v184 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v183
    let v185 : leptos_HtmlElement<leptos_html_A> = v184 |> unbox
    let v186 : string = "leptos::IntoView::into_view($0)"
    let v187 : leptos_View = Fable.Core.RustInterop.emitRustExpr v185 v186
    v187
and closure545 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : US21 = US21_0
    let v3 : US20 = US20_1(v2)
    let v4 : US20 = US20_2
    let v5 : US20 = US20_3
    let v6 : US20 = US20_4
    let v7 : (US20 []) = [|v3; v4; v5; v6|]
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<US20> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v11 : (US20 -> leptos_View) = closure546(v0, v1)
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method474 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure545(v0, v1)
and closure544 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : string = "class=\"-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]\""
    let v3 : string = "aria-label=\"Tabs\""
    let v4 : (unit -> leptos_Fragment) = method474(v0, v1)
    let v5 : string = ""
    let v6 : string = " " + v2 + v5 + ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method179(v4)
    let v9 : (unit -> leptos_Fragment) = method180(v8)
    let v10 : string = "nav"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_html_Nav> = v13 |> unbox
    let v15 : string = "leptos::IntoView::into_view($0)"
    let v16 : leptos_View = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : (leptos_View []) = [|v16|]
    let v18 : string = "$0.to_vec()"
    let v19 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::Fragment::new($0)"
    let v21 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v19 v20
    v21
and method473 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure544(v0, v1)
and closure543 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : string = "class=\"flex flex-1 border-t border-gray-200\""
    let v3 : (unit -> leptos_Fragment) = method473(v0, v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method179(v3)
    let v7 : (unit -> leptos_Fragment) = method180(v6)
    let v8 : string = "div"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Div> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : (leptos_View []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::Fragment::new($0)"
    let v19 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v17 v18
    v19
and method472 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure543(v0, v1)
and closure536 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "menu_tabs.render ()"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "leptos_router::use_location()"
    let v5 : leptos_router_Location = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "$0"
    let v7 : (unit -> string) = closure47(v5)
    let v8 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v6
    let v9 : string = "leptos::create_memo(move |_| { v8(()) })"
    let v10 : leptos_Memo<string> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "class=\"hidden\""
    let v12 : (unit -> leptos_Fragment) = method466(v0)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method179(v12)
    let v16 : (unit -> leptos_Fragment) = method180(v15)
    let v17 : string = "div"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Div> = v20 |> unbox
    let v22 : string = "class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\""
    let v23 : (unit -> leptos_Fragment) = method472(v0, v10)
    let v24 : string = " " + v22 + v13 + ""
    let v25 : (unit -> leptos_Fragment) = method179(v23)
    let v26 : (unit -> leptos_Fragment) = method180(v25)
    let v27 : string = "<" + v17 + " " + v24 + ">{v26()}</" + v17 + ">"
    let v28 : string = "leptos::view! { " + v27 + " }"
    let v29 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : leptos_HtmlElement<leptos_html_Div> = v29 |> unbox
    let v31 : (leptos_HtmlElement<leptos_html_Div> []) = [|v21; v30|]
    let v32 : string = "$0.to_vec()"
    let v33 : Vec<leptos_HtmlElement<leptos_html_Div>> = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v35 : (leptos_HtmlElement<leptos_html_Div> -> leptos_View) = closure234()
    let v36 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v33, v35) v34
    let v37 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v38 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "$0.to_vec()"
    let v40 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "leptos::Fragment::new($0)"
    let v42 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v40 v41
    v42
and method465 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure536(v0)
and closure53 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col [overflow:hidden]\""
    let v2 : (unit -> leptos_Fragment) = method66(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "main"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Main> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"flex\""
    let v15 : (unit -> leptos_Fragment) = method465(v0)
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method179(v15)
    let v18 : (unit -> leptos_Fragment) = method180(v17)
    let v19 : string = "div"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Div> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : (leptos_View []) = [|v13; v25|]
    let v27 : string = "$0.to_vec()"
    let v28 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "leptos::Fragment::new($0)"
    let v30 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v28 v29
    v30
and method65 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure53(v0)
and closure52 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\""
    let v2 : (unit -> leptos_Fragment) = method65(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method179(v2)
    let v6 : (unit -> leptos_Fragment) = method180(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : (leptos_View []) = [|v13|]
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method64 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure52(v0)
and closure46 () () : leptos_Fragment =
    let v0 : string = "content.render ()"
    let v1 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos_router::use_location()"
    let v4 : leptos_router_Location = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "std::sync::Arc::new(leptos_router::use_navigate())"
    let v6 : std_sync_Arc<Dyn<ActionFn2<Ref<Str>, leptos_router_NavigateOptions>>> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : string = "leptos_router::use_location()"
    let v8 : leptos_router_Location = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = "$0"
    let v10 : (unit -> string) = closure47(v8)
    let v11 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v10 v9
    let v12 : string = "leptos::create_memo(move |_| { v11(()) })"
    let v13 : leptos_Memo<string> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
    let v15 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "$0.unwrap()"
    let v17 : Heap2 = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = $"leptos::create_signal($0)"
    let v19 : US20 = US20_0
    let struct (v20 : leptos_ReadSignal<US20>, v21 : leptos_WriteSignal<US20>) = Fable.Core.RustInterop.emitRustExpr v19 v18
    let v22 : string = $"leptos::create_signal($0)"
    let struct (v23 : leptos_ReadSignal<bool>, v24 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr false v22
    let v25 : string = "$0"
    let v26 : (unit -> unit) = closure48(v4, v6, v13, v17, v24, v23)
    let v27 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v26 v25
    let v28 : string = "true; leptos::create_effect(move |_| { v27(()) })"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : string = "$0"
    let v31 : (unit -> unit) = closure49(v4, v21)
    let v32 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v31 v30
    let v33 : string = "true; leptos::create_effect(move |_| { v32(()) })"
    let v34 : bool = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : string = "class=\"flex flex-1 max-[100px]:[overflow-x:auto]\""
    let v36 : (unit -> leptos_Fragment) = method64(v20)
    let v37 : string = ""
    let v38 : string = " " + v35 + v37 + ""
    let v39 : (unit -> leptos_Fragment) = method179(v36)
    let v40 : (unit -> leptos_Fragment) = method180(v39)
    let v41 : string = "div"
    let v42 : string = "<" + v41 + " " + v38 + ">{v40()}</" + v41 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : leptos_HtmlElement<leptos_html_Div> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : (leptos_View []) = [|v47|]
    let v49 : string = "$0.to_vec()"
    let v50 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "leptos::Fragment::new($0)"
    let v52 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v50 v51
    v52
and method60 () : (unit -> leptos_Fragment) =
    closure46()
and closure5 () (v0 : int32) : leptos_HtmlElement<leptos_html_Div> =
    let v1 : string = "home.render () / router: " + string v0 + ""
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "leptos::use_context::<std::rc::Rc<Heap2>>()"
    let v5 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "$0.unwrap()"
    let v7 : Heap2 = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "state_core.use_database (1)"
    let v9 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : leptos_Resource<US2, rexie_Rexie> = method9()
    let v12 : string = "state_core.use_core_database (1)"
    let v13 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : leptos_Resource<rexie_Rexie option, US4> = method15(v11)
    let v16 : string = "$0"
    let v17 : (unit -> unit) = closure23(v7, v15)
    let v18 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "true; leptos::create_effect(move |_| { v18(()) })"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "$0"
    let v22 : (unit -> std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>) = closure38(v7)
    let v23 : (unit -> std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>) = Fable.Core.RustInterop.emitRustExpr v22 v21
    let v24 : string = "leptos::create_memo(move |_| { v23(()) })"
    let v25 : leptos_Memo<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : string = $"leptos::create_signal($0)"
    let struct (v27 : leptos_ReadSignal<bool>, v28 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr false v26
    let v29 : string = "leptos::create_action(move |value: &std::rc::Rc<Heap3>| $0(value.clone()))"
    let v30 : (Heap3 -> std_pin_Pin<Box<Dyn<std_future_Future<unit>>>>) = closure39(v11)
    let v31 : leptos_Action<Heap3, unit> = Fable.Core.RustInterop.emitRustExpr v30 v29
    let v32 : string = "$0"
    let v33 : (unit -> unit) = closure42(v7, v25, v28, v27, v31)
    let v34 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v33 v32
    let v35 : string = "true; leptos::create_effect(move |_| { v34(()) })"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = "class=\"flex flex-1\""
    let v38 : (unit -> bool) = method59(v7)
    let v39 : string = "class:dark"
    let v40 : string = "" + v39 + "={move || v38()}"
    let v41 : (unit -> leptos_Fragment) = method60()
    let v42 : string = ""
    let v43 : string = " " + v37 + v42 + ""
    let v44 : string = " " + v40 + v43 + ""
    let v45 : (unit -> leptos_Fragment) = method179(v41)
    let v46 : (unit -> leptos_Fragment) = method180(v45)
    let v47 : string = "div"
    let v48 : string = "<" + v47 + " " + v44 + ">{v46()}</" + v47 + ">"
    let v49 : string = "leptos::view! { " + v48 + " }"
    let v50 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : leptos_HtmlElement<leptos_html_Div> = v50 |> unbox
    v51
and method8 () : (int32 -> leptos_HtmlElement<leptos_html_Div>) =
    closure5()
and method480 () : string =
    let v0 : string = ""
    v0
and closure556 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 1
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method481 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure556(v0)
and closure557 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method482 () : (unit -> leptos_Fragment) =
    closure557()
and method483 () : string =
    let v0 : string = "/"
    v0
and closure558 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 2
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method484 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure558(v0)
and method485 () : string =
    let v0 : string = "/*"
    v0
and closure559 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 3
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method486 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure559(v0)
and method487 () : string =
    let v0 : string = "*"
    v0
and closure560 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 4
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method488 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure560(v0)
and closure4 () () : leptos_Fragment =
    let v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>) = method8()
    let v1 : string = method480()
    let v2 : string = method19(v1)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : (unit -> leptos_Fragment) = method481(v0)
    let v8 : (unit -> leptos_Fragment) = method482()
    let v9 : string = "path=v6"
    let v10 : string = "view=move || v7()"
    let v11 : string = "children=Box::new(move || v8())"
    let v12 : string = ""
    let v13 : string = " " + v9 + v12 + ""
    let v14 : string = " " + v10 + v13 + ""
    let v15 : string = " " + v11 + v14 + ""
    let v16 : string = "leptos_router::Route"
    let v17 : string = "<" + v16 + " " + v15 + " />"
    let v18 : string = "leptos::IntoView::into_view(leptos::view! { " + v17 + " })"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = method483()
    let v21 : string = method19(v20)
    let v22 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "String::from($0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : (unit -> leptos_Fragment) = method484(v0)
    let v27 : (unit -> leptos_Fragment) = method482()
    let v28 : string = "path=v25"
    let v29 : string = "view=move || v26()"
    let v30 : string = "children=Box::new(move || v27())"
    let v31 : string = " " + v28 + v12 + ""
    let v32 : string = " " + v29 + v31 + ""
    let v33 : string = " " + v30 + v32 + ""
    let v34 : string = "<" + v16 + " " + v33 + " />"
    let v35 : string = "leptos::IntoView::into_view(leptos::view! { " + v34 + " })"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = method485()
    let v38 : string = method19(v37)
    let v39 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v40 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : (unit -> leptos_Fragment) = method486(v0)
    let v44 : (unit -> leptos_Fragment) = method482()
    let v45 : string = "path=v42"
    let v46 : string = "view=move || v43()"
    let v47 : string = "children=Box::new(move || v44())"
    let v48 : string = " " + v45 + v12 + ""
    let v49 : string = " " + v46 + v48 + ""
    let v50 : string = " " + v47 + v49 + ""
    let v51 : string = "<" + v16 + " " + v50 + " />"
    let v52 : string = "leptos::IntoView::into_view(leptos::view! { " + v51 + " })"
    let v53 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v52
    let v54 : string = method487()
    let v55 : string = method19(v54)
    let v56 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "String::from($0)"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : (unit -> leptos_Fragment) = method488(v0)
    let v61 : (unit -> leptos_Fragment) = method482()
    let v62 : string = "path=v59"
    let v63 : string = "view=move || v60()"
    let v64 : string = "children=Box::new(move || v61())"
    let v65 : string = " " + v62 + v12 + ""
    let v66 : string = " " + v63 + v65 + ""
    let v67 : string = " " + v64 + v66 + ""
    let v68 : string = "<" + v16 + " " + v67 + " />"
    let v69 : string = "leptos::IntoView::into_view(leptos::view! { " + v68 + " })"
    let v70 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v69
    let v71 : (leptos_View []) = [|v19; v36; v53; v70|]
    let v72 : string = "$0.to_vec()"
    let v73 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v71 v72
    let v74 : string = "leptos::Fragment::new($0)"
    let v75 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v73 v74
    v75
and closure3 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> leptos_Fragment) = closure4()
    let v2 : (unit -> leptos_Fragment) = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "children=Box::new(move || v2(()))"
    let v4 : string = ""
    let v5 : string = " " + v3 + v4 + ""
    let v6 : string = "leptos_router::Routes"
    let v7 : string = "<" + v6 + " " + v5 + " />"
    let v8 : string = "leptos::IntoView::into_view(leptos::view! { " + v7 + " })"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : (leptos_View []) = [|v9|]
    let v11 : string = "$0.to_vec()"
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "leptos::Fragment::new($0)"
    let v14 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v12 v13
    v14
and method7 () : (unit -> leptos_Fragment) =
    closure3()
and closure2 () () : Impl<leptos_IntoView> =
    let v0 : string = "app.render ()"
    let v1 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "true; leptos_meta::provide_meta_context()"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = $"leptos::create_rw_signal($0)"
    let v6 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr false v5
    let v7 : string = $"leptos::create_rw_signal($0)"
    let v8 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr false v7
    let v9 : string = method4()
    let v10 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = $"leptos::create_rw_signal($0)"
    let v15 : leptos_RwSignal<std_string_String> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = method5()
    let v17 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "String::from($0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : (bool * std_string_String) = true, v20
    let v22 : string = method6()
    let v23 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : (bool * std_string_String) = true, v26
    let v28 : ((bool * std_string_String) []) = [|v21; v27|]
    let v29 : string = "$0.to_vec()"
    let v30 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : std_string_String option = None
    let v32 : US1 = US1_0
    let v33 : Heap0 = {l0 = v31; l1 = v30; l2 = 1; l3 = 1; l4 = v32} : Heap0
    let v34 : string = $"leptos::create_rw_signal($0)"
    let v35 : leptos_RwSignal<Heap0> = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : Heap1 = {l0 = v6; l1 = v35; l2 = v8; l3 = v15} : Heap1
    let v37 : string = $"leptos::create_rw_signal($0)"
    let v38 : leptos_RwSignal<Heap1> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "std::collections::HashMap::new()"
    let v40 : std_collections_HashMap<std_string_String, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : string = $"leptos::create_rw_signal($0)"
    let v42 : leptos_RwSignal<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>> = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : Heap2 = {l0 = v38; l1 = v42} : Heap2
    let v44 : string = $"true; leptos::provide_context::<std::rc::Rc<Heap2>>($0)"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : (unit -> leptos_Fragment) = method7()
    let v47 : string = "children=Box::new(move || v46())"
    let v48 : string = ""
    let v49 : string = " " + v47 + v48 + ""
    let v50 : string = "leptos_router::Router"
    let v51 : string = "<" + v50 + " " + v49 + " />"
    let v52 : string = "leptos::IntoView::into_view(leptos::view! { " + v51 + " })"
    let v53 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v52
    let v54 : Impl<leptos_IntoView> = v53 |> unbox
    v54
and method3 () : unit =
    let v0 : string = "true; leptos::mount_to_body(|| $0());"
    let v1 : (unit -> Impl<leptos_IntoView>) = closure2()
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v1 v0
    ()
and closure561 () () : unit =
    method3()
and method489 () : (unit -> unit) =
    closure561()
and method490 (v0 : Box<Dyn<FnUnit>>) : Box<Dyn<FnUnit>> =
    v0
and closure0 () (v0 : (string [])) : int32 =
    let v1 : string = "main / args: " + string v0 + ""
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "let _ = console_log::init_with_level(log::Level::Debug)"
    Fable.Core.RustInterop.emitRustExpr () v4
    let v5 : string = "console_error_panic_hook::set_once()"
    Fable.Core.RustInterop.emitRustExpr () v5
    let v6 : string = "leptos::document().body()"
    let v7 : web_sys_HtmlElement option = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : (web_sys_HtmlElement -> US0) = method0()
    let v9 : US0 = US0_1
    let v10 : US0 = v7 |> Option.map v8 |> Option.defaultValue v9 
    let v11 : string = $"%A{v10}"
    let v12 : string = "main / mount_to_body / body: " + string v11 + ""
    let v13 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    match v10 with
    | US0_0(v15) -> (* Some *)
        let v16 : string = method1()
        let v17 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v16 v17
        let v19 : web_sys_HtmlElement = method2(v15)
        let v20 : string = "v19.set_inner_html(v18)"
        Fable.Core.RustInterop.emitRustExpr () v20
        method3()
    | _ ->
        let v21 : (unit -> unit) = method489()
        let v22 : string = "Box::new(move || v21())"
        let v23 : Box<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v22
        let v24 : Box<Dyn<FnUnit>> = method490(v23)
        let v25 : string = "wasm_bindgen::closure::Closure::wrap(v24)"
        let v26 : wasm_bindgen_closure_Closure<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v25
        let v27 : string = "wasm_bindgen::closure::Closure::as_ref(&v26)"
        let v28 : Ref<wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v27
        let v29 : string = "wasm_bindgen::JsCast::unchecked_ref(v28)"
        let v30 : Ref<js_sys_Function> = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : string = "leptos::document().add_event_listener_with_callback(\"DOMContentLoaded\", v30).unwrap()"
        Fable.Core.RustInterop.emitRustExpr () v31
        let v32 : string = "v26.forget()"
        Fable.Core.RustInterop.emitRustExpr () v32
        ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
