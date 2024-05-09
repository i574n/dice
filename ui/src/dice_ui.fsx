#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Any = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::BTreeMap<$0, $1>")>]
#endif
type std_collections_BTreeMap<'K, 'V> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures")>]
#endif
type regex_Captures = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::PoisonError<$0>")>]
#endif
type std_sync_PoisonError<'T> = class end
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
    | US60_0 of f0_0 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * f0_1 : std_string_String option * f0_2 : std_string_String * f0_3 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option
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
    | US64_0 of f0_0 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * f0_1 : std_string_String option * f0_2 : std_string_String * f0_3 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option
    | US64_1 of f1_0 : std_string_String
and [<Struct>] US65 =
    | US65_0 of f0_0 : US62
    | US65_1
and [<Struct>] US66 =
    | US66_0 of f0_0 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option
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
let rec method0 () : string =
    let v0 : string = ""
    v0
and method1 (v0 : web_sys_HtmlElement) : web_sys_HtmlElement =
    v0
and closure5 () () : US2 =
    US2_1
and closure6 () (v0 : rexie_Rexie) : US3 =
    US3_0(v0)
and closure7 () (v0 : rexie_Error) : US3 =
    US3_1(v0)
and method7 (v0 : US3) : US3 =
    v0
and method8 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and method6 () : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> =
    let v0 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "state_core.use_database (2) / database create_local_resource"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "state_core.build_database ()"
    let v5 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "Box::pin(rexie::Rexie::builder(\"database\").version(1).add_object_store(rexie::ObjectStore::new(\"store\")).build())"
    let v9 : std_pin_Pin<Box<Dyn<std_future_Future<Result<rexie_Rexie, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "v9.await"
    let v11 : Result<rexie_Rexie, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : (rexie_Rexie -> US3) = closure6()
    let v13 : (rexie_Error -> US3) = closure7()
    let v14 : US3 = match v11 with Ok x -> v12 x | Error x -> v13 x
    let v15 : US3 = method7(v14)
    let v16 : string = "v15 }})"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v17
    let v18 : string = "__result"
    let v19 : std_pin_Pin<Box<Dyn<std_future_Future<US3>>>> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "v19.await"
    let v21 : US3 = Fable.Core.RustInterop.emitRustExpr () v20
    let v27 : rexie_Rexie =
        match v21 with
        | US3_1(v23) -> (* Error *)
            let v24 : string = $"resultm.get / Result value was Error: {v23}"
            failwith<rexie_Rexie> v24
        | US3_0(v22) -> (* Ok *)
            v22
    let v28 : string = $"%A{v27}"
    let v29 : string = "state_core.use_database (3) / database create_local_resource / result: " + string v28 + ""
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
    let v37 : rexie_Rexie = method8(v27)
    let v38 : string = "v37 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v38
    let v39 : string = "{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v39
    let v40 : string = "__result"
    let v41 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = Fable.Core.RustInterop.emitRustExpr () v40
    v41
and method9 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> =
    v0
and method5 () : leptos_Resource<US2, rexie_Rexie> =
    let v0 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v1 : (unit -> US2) = closure5()
    Fable.Core.RustInterop.emitRustExpr v1 v0
    let v2 : string = "x"
    let v3 : US2 = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = method6()
    let v5 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = method9(v4)
    let v6 : string = "v5.await"
    let v7 : rexie_Rexie = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "v7 }})"
    Fable.Core.RustInterop.emitRustExpr () v8
    let v9 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v9
    let v10 : string = "__result"
    let v11 : leptos_Resource<US2, rexie_Rexie> = Fable.Core.RustInterop.emitRustExpr () v10
    v11
and closure8 (v0 : leptos_Resource<US2, rexie_Rexie>) () : rexie_Rexie option =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure9 () (v0 : string) : std_string_String =
    let v1 : string = "&*$0"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method14 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and closure10 () (v0 : rexie_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method15 () : (rexie_Error -> std_string_String) =
    closure10()
and method16 () : string =
    let v0 : string = "store"
    v0
and closure11 () (v0 : rexie_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method17 () : (rexie_Error -> std_string_String) =
    closure11()
and method18 (v0 : string) : string =
    v0
and closure12 () (v0 : rexie_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method19 () : (rexie_Error -> std_string_String) =
    closure12()
and method20 (v0 : wasm_bindgen_JsValue) : wasm_bindgen_JsValue =
    v0
and closure13 () (v0 : serde_wasm_bindgen_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method21 () : (serde_wasm_bindgen_Error -> std_string_String) =
    closure13()
and method22 (v0 : serde_json_Value) : serde_json_Value =
    v0
and closure14 () (v0 : serde_json_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method23 () : (serde_json_Error -> std_string_String) =
    closure14()
and closure15 () (v0 : borsh_io_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method24 () : (borsh_io_Error -> std_string_String) =
    closure15()
and method25 (v0 : Result<Heap3 option option, std_string_String>) : Result<Heap3 option option, std_string_String> =
    v0
and method13 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> =
    let v2 : string = "state_core.get_data () / id: " + v0 + ""
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    let v6 : string = "store"
    let v7 : (string []) = [|v6|]
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v11 : (string -> std_string_String) = closure9()
    let v12 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    let v13 : rexie_Rexie = method14(v1)
    let v14 : string = "v13.transaction(&v12, rexie::TransactionMode::ReadOnly)"
    let v15 : Result<rexie_Transaction, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : (rexie_Error -> std_string_String) = method15()
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<rexie_Transaction, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17
    let v19 : string = "$0?"
    let v20 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = method16()
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "v20.store(v23)"
    let v25 : Result<rexie_Store, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (rexie_Error -> std_string_String) = method17()
    let v27 : string = "$0.map_err(|x| $1(x))"
    let v28 : Result<rexie_Store, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v25, v26) v27
    let v29 : string = "$0?"
    let v30 : rexie_Store = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = method18(v0)
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "wasm_bindgen::JsValue::from_str(v33)"
    let v35 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : string = $"Box::pin(rexie::Store::get(&v30, &v35))"
    let v37 : std_pin_Pin<Box<Dyn<std_future_Future<Result<wasm_bindgen_JsValue, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "v37.await"
    let v39 : Result<wasm_bindgen_JsValue, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : (rexie_Error -> std_string_String) = method19()
    let v41 : string = "$0.map_err(|x| $1(x))"
    let v42 : Result<wasm_bindgen_JsValue, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v39, v40) v41
    let v43 : string = "$0?"
    let v44 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : wasm_bindgen_JsValue = method20(v44)
    let v46 : string = "serde_wasm_bindgen::from_value(v45)"
    let v47 : Result<serde_json_Value option, serde_wasm_bindgen_Error> = Fable.Core.RustInterop.emitRustExpr () v46
    let v48 : (serde_wasm_bindgen_Error -> std_string_String) = method21()
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<serde_json_Value option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v47, v48) v49
    let v51 : string = "$0?"
    let v52 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : US7 option = None
    let _v53 = ref v53 
    match v52 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v54 : serde_json_Value = x
    let v55 : US7 = US7_0(v54)
    v55 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v53.Value <- x
    let v56 : US7 option = _v53.Value 
    let v57 : US7 = US7_1
    let v58 : US7 = v56 |> Option.defaultValue v57 
    let v90 : US6 =
        match v58 with
        | US7_1 -> (* None *)
            US6_1
        | US7_0(v59) -> (* Some *)
            let v60 : serde_json_Value = method22(v59)
            let v61 : string = "serde_json::from_value(v60)"
            let v62 : Result<Vec<uint8>, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v61
            let v63 : (serde_json_Error -> std_string_String) = method23()
            let v64 : string = "$0.map_err(|x| $1(x))"
            let v65 : Result<Vec<uint8>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v62, v63) v64
            let v66 : string = "$0?"
            let v67 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v69 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v67 v68
            let v70 : int32 = v69.Length
            let v71 : string = "state_core.get_data () / data_len: " + string v70 + ""
            let v72 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v73 : bool = Fable.Core.RustInterop.emitRustExpr v71 v72
            let v74 : string = "$0.to_vec()"
            let v75 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v69 v74
            let v76 : string = "v75.as_slice()"
            let v77 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v76
            let v78 : string = "true; let mut v77 = v77"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78
            let v80 : string = "borsh::BorshDeserialize::deserialize(&mut v77)"
            let v81 : Result<Heap3 option, borsh_io_Error> = Fable.Core.RustInterop.emitRustExpr () v80
            let v82 : (borsh_io_Error -> std_string_String) = method24()
            let v83 : string = "$0.map_err(|x| $1(x))"
            let v84 : Result<Heap3 option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v81, v82) v83
            let v85 : string = "$0?"
            let v86 : Heap3 option = Fable.Core.RustInterop.emitRustExpr v84 v85
            US6_0(v86)
    let v95 : Heap3 option option =
        match v90 with
        | US6_1 -> (* None *)
            let v93 : Heap3 option option = None
            v93
        | US6_0(v91) -> (* Some *)
            let v92 : Heap3 option option = Some v91 
            v92
    let v96 : Result<Heap3 option option, std_string_String> = Ok v95
    let v97 : Result<Heap3 option option, std_string_String> = method25(v96)
    let v98 : string = "v97 }}})"
    Fable.Core.RustInterop.emitRustExpr () v98
    let v99 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v99
    let v100 : string = "__result"
    let v101 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v100
    v101
and method12 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> =
    method13(v0, v1)
and closure16 () (v0 : Heap3 option option) : US8 =
    US8_0(v0)
and closure17 () (v0 : std_string_String) : US8 =
    US8_1(v0)
and method26 (v0 : US4) : US4 =
    v0
and method11 (v0 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = $"%A{v0}"
    let v3 : string = "state_core.use_core_database (2) / core_state_heap create_local_resource / database: " + v2 + ""
    let v4 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : US5 option = None
    let _v6 = ref v6 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v7 : rexie_Rexie = x
    let v8 : US5 = US5_0(v7)
    v8 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v6.Value <- x
    let v9 : US5 option = _v6.Value 
    let v10 : US5 = US5_1
    let v11 : US5 = v9 |> Option.defaultValue v10 
    let v36 : US6 =
        match v11 with
        | US5_1 -> (* None *)
            US6_1
        | US5_0(v12) -> (* Some *)
            let v13 : string = "core-state-heap"
            let v14 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> = method12(v13, v12)
            let v15 : string = "v14.await"
            let v16 : Result<Heap3 option option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v15
            let v17 : (Heap3 option option -> US8) = closure16()
            let v18 : (std_string_String -> US8) = closure17()
            let v19 : US8 = match v16 with Ok x -> v17 x | Error x -> v18 x
            match v19 with
            | US8_1(v27) -> (* Error *)
                let v28 : string = "state_core.use_core_database (3) / error: " + string v27 + ""
                let v29 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v30 : bool = Fable.Core.RustInterop.emitRustExpr v28 v29
                US6_1
            | US8_0(v20) -> (* Ok *)
                let v21 : US6 option = None
                let _v21 = ref v21 
                match v20 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v22 : Heap3 option = x
                let v23 : US6 = US6_0(v22)
                v23 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v21.Value <- x
                let v24 : US6 option = _v21.Value 
                let v25 : US6 = US6_1
                let v26 : US6 = v24 |> Option.defaultValue v25 
                v26
    let v47 : US9 =
        match v36 with
        | US6_1 -> (* None *)
            US9_1
        | US6_0(v37) -> (* Some *)
            let v38 : US4 option = None
            let _v38 = ref v38 
            match v37 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v39 : Heap3 = x
            let v40 : US4 = US4_0(v39)
            v40 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v38.Value <- x
            let v41 : US4 option = _v38.Value 
            let v42 : US4 = US4_1
            let v43 : US4 = v41 |> Option.defaultValue v42 
            US9_0(v43)
    let v54 : US4 =
        match v47 with
        | US9_0(v48) -> (* Some *)
            match v48 with
            | US4_0(v49) -> (* Some *)
                US4_0(v49)
            | _ ->
                US4_1
        | _ ->
            US4_1
    let v55 : US4 = method26(v54)
    let v56 : string = "v55 }}})"
    Fable.Core.RustInterop.emitRustExpr () v56
    let v57 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v57
    let v58 : string = "__result"
    let v59 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = Fable.Core.RustInterop.emitRustExpr () v58
    v59
and method27 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> =
    v0
and method10 (v0 : leptos_Resource<US2, rexie_Rexie>) : leptos_Resource<rexie_Rexie option, US4> =
    let v1 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v2 : (unit -> rexie_Rexie option) = closure8(v0)
    Fable.Core.RustInterop.emitRustExpr v2 v1
    let v3 : string = "x"
    let v4 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = method11(v4)
    let v6 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = method27(v5)
    let v7 : string = "v6.await"
    let v8 : US4 = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = "v8 }})"
    Fable.Core.RustInterop.emitRustExpr () v9
    let v10 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v10
    let v11 : string = "__result"
    let v12 : leptos_Resource<rexie_Rexie option, US4> = Fable.Core.RustInterop.emitRustExpr () v11
    v12
and method28 () : web_sys_Window =
    let v0 : string = "leptos::leptos_dom::window()"
    let v1 : web_sys_Window = Fable.Core.RustInterop.emitRustExpr () v0
    v1
and method29 (v0 : web_sys_Window) : Result<web_sys_Storage option, wasm_bindgen_JsValue> =
    let v1 : string = "$0.local_storage()"
    let v2 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure19 () (v0 : web_sys_Storage option) : US10 =
    US10_0(v0)
and closure20 () (v0 : wasm_bindgen_JsValue) : US10 =
    US10_1(v0)
and method30 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and method31 () : string =
    let v0 : string = "core-state-heap"
    v0
and closure21 () (v0 : std_string_String option) : US13 =
    US13_0(v0)
and closure22 () (v0 : wasm_bindgen_JsValue) : US13 =
    US13_1(v0)
and method32 (v0 : std_string_String option) : std_string_String option =
    v0
and method33 (v0 : string) : string =
    v0
and closure23 () (v0 : serde_json_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method34 () : (serde_json_Error -> std_string_String) =
    closure23()
and closure25 (v0 : Heap3) (v1 : bool) : bool =
    let v2 : string = "state_core.use_core_database (7) / effect core_state_heap / dark_mode signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : bool = v0.l0
    v5
and closure26 (v0 : Heap3) (v1 : bool) : bool =
    let v2 : string = "state_core.use_core_database (8) / effect core_state_heap / debug signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : bool = v0.l2
    v5
and closure27 (v0 : Heap3) (v1 : std_string_String) : std_string_String =
    let v2 : string = "state_core.use_core_database (9) / effect core_state_heap / url_hash signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : std_string_String = v0.l3
    v5
and closure28 (v0 : Heap3) (v1 : Heap0) : Heap0 =
    let v2 : string = "state_core.use_core_database (10) / effect core_state_heap / data signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : Heap0 = v0.l1
    v5
and closure24 (v0 : Heap2, v1 : Heap3) () : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<bool> = v4.l0
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure25(v1)
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v10 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v9
    let v11 : leptos_RwSignal<bool> = v10.l2
    let v12 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v13 : (bool -> bool) = closure26(v1)
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v12
    let v15 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v16 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v15
    let v17 : leptos_RwSignal<std_string_String> = v16.l3
    let v18 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v19 : (std_string_String -> std_string_String) = closure27(v1)
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v22 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v21
    let v23 : leptos_RwSignal<Heap0> = v22.l1
    let v24 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v25 : (Heap0 -> Heap0) = closure28(v1)
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr struct (v23, v25) v24
    ()
and closure18 (v0 : Heap2, v1 : leptos_Resource<rexie_Rexie option, US4>) () : unit =
    let v2 : string = "state_core.use_core_database (4) / effect core_state_heap / ##1"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : web_sys_Window = method28()
    let v6 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method29(v5)
    let v7 : (web_sys_Storage option -> US10) = closure19()
    let v8 : (wasm_bindgen_JsValue -> US10) = closure20()
    let v9 : US10 = match v6 with Ok x -> v7 x | Error x -> v8 x
    let v21 : US11 =
        match v9 with
        | US10_1(v18) -> (* Error *)
            US11_1(v18)
        | US10_0(v10) -> (* Ok *)
            let v11 : US12 option = None
            let _v11 = ref v11 
            match v10 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v12 : web_sys_Storage = x
            let v13 : US12 = US12_0(v12)
            v13 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v11.Value <- x
            let v14 : US12 option = _v11.Value 
            let v15 : US12 = US12_1
            let v16 : US12 = v14 |> Option.defaultValue v15 
            US11_0(v16)
    match v21 with
    | US11_0(v22) -> (* Ok *)
        match v22 with
        | US12_0(v23) -> (* Some *)
            let v24 : string = $"leptos::SignalGet::get(&$0)"
            let v25 : US4 option = Fable.Core.RustInterop.emitRustExpr v1 v24
            let v26 : US9 option = None
            let _v26 = ref v26 
            match v25 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v27 : US4 = x
            let v28 : US9 = US9_0(v27)
            v28 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v26.Value <- x
            let v29 : US9 option = _v26.Value 
            let v30 : US9 = US9_1
            let v31 : US9 = v29 |> Option.defaultValue v30 
            let v32 : string = $"%A{v31}"
            let v33 : string = "state_core.use_core_database (5) / effect core_state_heap / ##2 / core_state_heap: " + v32 + ""
            let v34 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34
            let v192 : US4 =
                match v31 with
                | US9_0(v36) -> (* Some *)
                    match v36 with
                    | US4_0(v37) -> (* Some *)
                        US4_0(v37)
                    | _ ->
                        let v39 : web_sys_Storage = method30(v23)
                        let v40 : string = method31()
                        let v41 : string = "&*$0"
                        let v42 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v40 v41
                        let v43 : string = $"web_sys::Storage::get_item(&v39, v42)"
                        let v44 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v43
                        let v45 : (std_string_String option -> US13) = closure21()
                        let v46 : (wasm_bindgen_JsValue -> US13) = closure22()
                        let v47 : US13 = match v44 with Ok x -> v45 x | Error x -> v46 x
                        let v62 : US14 =
                            match v47 with
                            | US13_1(v59) -> (* Error *)
                                US14_1(v59)
                            | US13_0(v48) -> (* Ok *)
                                let v49 : std_string_String option = method32(v48)
                                let v50 : string = "serde_json::from_value(v49.into()).unwrap()"
                                let v51 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v50
                                let v52 : US15 option = None
                                let _v52 = ref v52 
                                match v51 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v53 : std_string_String = x
                                let v54 : US15 = US15_0(v53)
                                v54 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v52.Value <- x
                                let v55 : US15 option = _v52.Value 
                                let v56 : US15 = US15_1
                                let v57 : US15 = v55 |> Option.defaultValue v56 
                                US14_0(v57)
                        let v68 : US16 =
                            match v62 with
                            | US14_1(v65) -> (* Error *)
                                US16_1
                            | US14_0(v63) -> (* Ok *)
                                US16_0(v63)
                        let v75 : US15 =
                            match v68 with
                            | US16_0(v69) -> (* Some *)
                                match v69 with
                                | US15_0(v70) -> (* Some *)
                                    US15_0(v70)
                                | _ ->
                                    US15_1
                            | _ ->
                                US15_1
                        let v80 : std_string_String option =
                            match v75 with
                            | US15_1 -> (* None *)
                                let v78 : std_string_String option = None
                                v78
                            | US15_0(v76) -> (* Some *)
                                let v77 : std_string_String option = Some v76 
                                v77
                        let v81 : US4 option = None
                        let _v81 = ref v81 
                        match v80 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v82 : std_string_String = x
                        let v83 : string = "fable_library_rust::String_::fromString($0)"
                        let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83
                        let v85 : string = method33(v84)
                        let v86 : string = "&*$0"
                        let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v85 v86
                        let v88 : string = "serde_json::from_str(&v87)"
                        let v89 : Result<Heap3, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v88
                        let v90 : (serde_json_Error -> std_string_String) = method34()
                        let v91 : string = "$0.map_err(|x| $1(x))"
                        let v92 : Result<Heap3, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v91
                        let v93 : string = "v92.ok()"
                        let v94 : Heap3 option = Fable.Core.RustInterop.emitRustExpr () v93
                        let v95 : US4 option = None
                        let _v95 = ref v95 
                        match v94 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v96 : Heap3 = x
                        let v97 : US4 = US4_0(v96)
                        v97 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v95.Value <- x
                        let v98 : US4 option = _v95.Value 
                        let v99 : US4 = US4_1
                        let v100 : US4 = v98 |> Option.defaultValue v99 
                        v100 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v81.Value <- x
                        let v101 : US4 option = _v81.Value 
                        let v102 : US9 option = None
                        let _v102 = ref v102 
                        match v101 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v103 : US4 = x
                        let v104 : US9 = US9_0(v103)
                        v104 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v102.Value <- x
                        let v105 : US9 option = _v102.Value 
                        let v106 : US9 = US9_1
                        let v107 : US9 = v105 |> Option.defaultValue v106 
                        match v107 with
                        | US9_0(v108) -> (* Some *)
                            match v108 with
                            | US4_0(v109) -> (* Some *)
                                US4_0(v109)
                            | _ ->
                                US4_1
                        | _ ->
                            US4_1
                | _ ->
                    let v116 : web_sys_Storage = method30(v23)
                    let v117 : string = method31()
                    let v118 : string = "&*$0"
                    let v119 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v117 v118
                    let v120 : string = $"web_sys::Storage::get_item(&v116, v119)"
                    let v121 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v120
                    let v122 : (std_string_String option -> US13) = closure21()
                    let v123 : (wasm_bindgen_JsValue -> US13) = closure22()
                    let v124 : US13 = match v121 with Ok x -> v122 x | Error x -> v123 x
                    let v139 : US14 =
                        match v124 with
                        | US13_1(v136) -> (* Error *)
                            US14_1(v136)
                        | US13_0(v125) -> (* Ok *)
                            let v126 : std_string_String option = method32(v125)
                            let v127 : string = "serde_json::from_value(v126.into()).unwrap()"
                            let v128 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v127
                            let v129 : US15 option = None
                            let _v129 = ref v129 
                            match v128 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v130 : std_string_String = x
                            let v131 : US15 = US15_0(v130)
                            v131 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v129.Value <- x
                            let v132 : US15 option = _v129.Value 
                            let v133 : US15 = US15_1
                            let v134 : US15 = v132 |> Option.defaultValue v133 
                            US14_0(v134)
                    let v145 : US16 =
                        match v139 with
                        | US14_1(v142) -> (* Error *)
                            US16_1
                        | US14_0(v140) -> (* Ok *)
                            US16_0(v140)
                    let v152 : US15 =
                        match v145 with
                        | US16_0(v146) -> (* Some *)
                            match v146 with
                            | US15_0(v147) -> (* Some *)
                                US15_0(v147)
                            | _ ->
                                US15_1
                        | _ ->
                            US15_1
                    let v157 : std_string_String option =
                        match v152 with
                        | US15_1 -> (* None *)
                            let v155 : std_string_String option = None
                            v155
                        | US15_0(v153) -> (* Some *)
                            let v154 : std_string_String option = Some v153 
                            v154
                    let v158 : US4 option = None
                    let _v158 = ref v158 
                    match v157 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v159 : std_string_String = x
                    let v160 : string = "fable_library_rust::String_::fromString($0)"
                    let v161 : string = Fable.Core.RustInterop.emitRustExpr v159 v160
                    let v162 : string = method33(v161)
                    let v163 : string = "&*$0"
                    let v164 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v162 v163
                    let v165 : string = "serde_json::from_str(&v164)"
                    let v166 : Result<Heap3, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v165
                    let v167 : (serde_json_Error -> std_string_String) = method34()
                    let v168 : string = "$0.map_err(|x| $1(x))"
                    let v169 : Result<Heap3, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v166, v167) v168
                    let v170 : string = "v169.ok()"
                    let v171 : Heap3 option = Fable.Core.RustInterop.emitRustExpr () v170
                    let v172 : US4 option = None
                    let _v172 = ref v172 
                    match v171 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v173 : Heap3 = x
                    let v174 : US4 = US4_0(v173)
                    v174 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v172.Value <- x
                    let v175 : US4 option = _v172.Value 
                    let v176 : US4 = US4_1
                    let v177 : US4 = v175 |> Option.defaultValue v176 
                    v177 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v158.Value <- x
                    let v178 : US4 option = _v158.Value 
                    let v179 : US9 option = None
                    let _v179 = ref v179 
                    match v178 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v180 : US4 = x
                    let v181 : US9 = US9_0(v180)
                    v181 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v179.Value <- x
                    let v182 : US9 option = _v179.Value 
                    let v183 : US9 = US9_1
                    let v184 : US9 = v182 |> Option.defaultValue v183 
                    match v184 with
                    | US9_0(v185) -> (* Some *)
                        match v185 with
                        | US4_0(v186) -> (* Some *)
                            US4_0(v186)
                        | _ ->
                            US4_1
                    | _ ->
                        US4_1
            let v193 : string = $"%A{v192}"
            let v194 : string = "state_core.use_core_database (6) / effect core_state_heap / ##3 / core_state_heap: " + v193 + ""
            let v195 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v196 : bool = Fable.Core.RustInterop.emitRustExpr v194 v195
            match v192 with
            | US4_0(v197) -> (* Some *)
                let v198 : string = "true; leptos::batch(move || $0());"
                let v199 : (unit -> unit) = closure24(v0, v197)
                let v200 : bool = Fable.Core.RustInterop.emitRustExpr v199 v198
                ()
            | _ ->
                ()
        | _ ->
            ()
    | _ ->
        ()
and closure29 (v0 : Heap2) () : std_collections_HashMap<std_string_String, leptos_RwSignal<bool>> =
    let v1 : string = "state_core.use_core_database (11) / loading create_memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>> = v0.l1
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : std_collections_HashMap<std_string_String, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method35 () : string =
    let v0 : string = "core-state-heap"
    v0
and method36 (v0 : Result<unit, rexie_Error>) : Result<unit, rexie_Error> =
    v0
and closure31 () () : US17 =
    US17_0
and closure32 () (v0 : rexie_Error) : US17 =
    US17_1(v0)
and method37 () : unit =
    ()
and closure30 (v0 : leptos_Resource<US2, rexie_Rexie>) (v1 : Heap3) : std_pin_Pin<Box<Dyn<std_future_Future<unit>>>> =
    let v2 : string = $"%A{v1}"
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : US5 option = None
    let _v5 = ref v5 
    match v4 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v6 : rexie_Rexie = x
    let v7 : US5 = US5_0(v6)
    v7 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v5.Value <- x
    let v8 : US5 option = _v5.Value 
    let v9 : US5 = US5_1
    let v10 : US5 = v8 |> Option.defaultValue v9 
    let v11 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v11
    match v10 with
    | US5_1 -> (* None *)
        let v54 : string = "state_core.use_core_database (13) / set_core_state_heap_action / database=None"
        let v55 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55
        ()
    | US5_0(v12) -> (* Some *)
        let v13 : string = "state_core.use_core_database (12) / set_core_state_heap_action / value: " + string v2 + ""
        let v14 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14
        let v16 : string = $"%A{v1}"
        let v17 : int64 = System.Convert.ToInt64 v16.Length
        let v18 : string = "state_core.set_data () / data_len: " + string v17 + ""
        let v19 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19
        let v21 : string = "let __result = Box::pin(async move { //"
        Fable.Core.RustInterop.emitRustExpr () v21
        let v22 : string = "$0.transaction(&[\"store\"], rexie::TransactionMode::ReadWrite)?"
        let v23 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v12 v22
        let v24 : string = "v23.store(\"store\")?"
        let v25 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v24
        let v26 : string = "true; let mut data = Vec::new()"
        let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26
        let v28 : string = "true; borsh::BorshSerialize::serialize(&$0, &mut data).unwrap()"
        let v29 : bool = Fable.Core.RustInterop.emitRustExpr v1 v28
        let v30 : string = "data"
        let v31 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : string = "serde_wasm_bindgen::to_value(&v31).unwrap()"
        let v33 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : string = method35()
        let v35 : string = "&*$0"
        let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v34 v35
        let v37 : string = "true; v25.put(&v33, Some(&v36.into())).await?"
        let v38 : bool = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : string = "true; v23.done().await?"
        let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : Result<unit, rexie_Error> = Ok ()
        let v42 : Result<unit, rexie_Error> = method36(v41)
        let v43 : string = "v42 }})"
        Fable.Core.RustInterop.emitRustExpr () v43
        let v44 : string = "{ //"
        Fable.Core.RustInterop.emitRustExpr () v44
        let v45 : string = "__result"
        let v46 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : string = "v46.await"
        let v48 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : (unit -> US17) = closure31()
        let v50 : (rexie_Error -> US17) = closure32()
        let v51 : US17 = match v48 with Ok () -> v49 () | Error x -> v50 x
        match v51 with
        | US17_1(v52) -> (* Error *)
            let v53 : string = $"resultm.get / Result value was Error: {v52}"
            failwith<unit> v53
        | US17_0 -> (* Ok *)
            ()
    method37()
    let v57 : string = "() })"
    Fable.Core.RustInterop.emitRustExpr () v57
    let v58 : string = "__result"
    let v59 : std_pin_Pin<Box<Dyn<std_future_Future<unit>>>> = Fable.Core.RustInterop.emitRustExpr () v58
    v59
and method38 (v0 : std_string_String) : std_string_String =
    v0
and closure34 () (v0 : bool) : bool =
    let v1 : string = "state_core.use_core_database (17) / effect new_core_state_heap / set_loaded |> signal_update true"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    true
and method39 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and method40 () : string =
    let v0 : string = "core-state-heap"
    v0
and method41 (v0 : Heap3) : Heap3 =
    v0
and closure33 (v0 : Heap2, v1 : leptos_Memo<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>>, v2 : leptos_WriteSignal<bool>, v3 : leptos_ReadSignal<bool>, v4 : leptos_Action<Heap3, unit>) () : unit =
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
    let v38 : string = "&*$0"
    let v39 : string = "dark_mode_key"
    let v40 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v39 v38
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : std_string_String = method38(v42)
    let v44 : string = "std::collections::HashMap::get(&v37, &v43).map(|x| x).cloned()"
    let v45 : leptos_RwSignal<bool> option = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : US18 option = None
    let _v46 = ref v46 
    match v45 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v47 : leptos_RwSignal<bool> = x
    let v48 : US18 = US18_0(v47)
    v48 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v46.Value <- x
    let v49 : US18 option = _v46.Value 
    let v50 : US18 = US18_1
    let v51 : US18 = v49 |> Option.defaultValue v50 
    let v58 : US19 =
        match v51 with
        | US18_1 -> (* None *)
            US19_1
        | US18_0(v52) -> (* Some *)
            let v53 : string = $"leptos::SignalGet::get(&$0)"
            let v54 : bool = Fable.Core.RustInterop.emitRustExpr v52 v53
            US19_0(v54)
    let v61 : bool =
        match v58 with
        | US19_1 -> (* None *)
            false
        | US19_0(v59) -> (* Some *)
            v59
    let v62 : string = "state_core.use_core_database (16) / effect new_core_state_heap / ##3 / dark_mode_loading: " + string v61 + ""
    let v63 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v64 : bool = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : bool = v61 = false
    if v65 then
        let v66 : bool = v6 = false
        if v66 then
            let v67 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
            let v68 : (bool -> bool) = closure34()
            let v69 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v68) v67
            ()
        else
            let v70 : string = "state_core.use_core_database (18) / effect new_core_state_heap / ##4"
            let v71 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v72 : bool = Fable.Core.RustInterop.emitRustExpr v70 v71
            let v73 : web_sys_Window = method28()
            let v74 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method29(v73)
            let v75 : (web_sys_Storage option -> US10) = closure19()
            let v76 : (wasm_bindgen_JsValue -> US10) = closure20()
            let v77 : US10 = match v74 with Ok x -> v75 x | Error x -> v76 x
            let v89 : US11 =
                match v77 with
                | US10_1(v86) -> (* Error *)
                    US11_1(v86)
                | US10_0(v78) -> (* Ok *)
                    let v79 : US12 option = None
                    let _v79 = ref v79 
                    match v78 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v80 : web_sys_Storage = x
                    let v81 : US12 = US12_0(v80)
                    v81 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v79.Value <- x
                    let v82 : US12 option = _v79.Value 
                    let v83 : US12 = US12_1
                    let v84 : US12 = v82 |> Option.defaultValue v83 
                    US11_0(v84)
            match v89 with
            | US11_0(v90) -> (* Ok *)
                match v90 with
                | US12_0(v91) -> (* Some *)
                    let v92 : string = "true; leptos::Action::dispatch(&$0, $1.clone())"
                    let v93 : bool = Fable.Core.RustInterop.emitRustExpr struct (v4, v31) v92
                    let v94 : web_sys_Storage = method39(v91)
                    let v95 : string = method40()
                    let v96 : string = "&*$0"
                    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v95 v96
                    let v98 : Heap3 = method41(v31)
                    let v99 : string = "serde_json::json!(v98).to_string()"
                    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v99
                    let v101 : string = "$0.as_str()"
                    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v100 v101
                    let v103 : string = $"web_sys::Storage::set(&v94, v97, v102).unwrap()"
                    Fable.Core.RustInterop.emitRustExpr () v103
                    ()
                | _ ->
                    ()
            | _ ->
                ()
and closure35 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<bool> = v3.l0
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method42 (v0 : Heap2) : (unit -> bool) =
    closure35(v0)
and closure37 (v0 : leptos_router_Location) () : string =
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
and method44 (v0 : std_string_String) : std_string_String =
    v0
and closure38 (v0 : leptos_router_Location, v1 : std_sync_Arc<Dyn<ActionFn2<Ref<Str>, leptos_router_NavigateOptions>>>, v2 : leptos_Memo<string>, v3 : Heap2, v4 : leptos_WriteSignal<bool>, v5 : leptos_ReadSignal<bool>) () : unit =
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
        let v19 : std_string_String = method44(v11)
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
                let v35 : string = "&*$0"
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
        let v44 : string = "&*$0"
        let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v44
        let v46 : string = "String::from($0)"
        let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v45 v46
        let v48 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v49 : bool = Fable.Core.RustInterop.emitRustExpr struct (v43, v47) v48
        ()
and method45 (v0 : std_string_String) : std_string_String =
    v0
and closure40 () (v0 : leptos_router_Url) : US22 =
    US22_0(v0)
and closure41 () (v0 : std_string_String) : US22 =
    US22_1(v0)
and method46 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure39 (v0 : leptos_router_Location, v1 : leptos_WriteSignal<US20>) () : unit =
    let v2 : string = "$0.hash"
    let v3 : leptos_Memo<std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = $"$0()"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : std_string_String = method45(v5)
    let v7 : string = "v6.strip_prefix('#')"
    let v8 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = ""
    let v10 : string = "r#\"" + v9 + "\"#"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "v8.unwrap_or(v11)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "leptos_router::Url::try_from($0)"
    let v15 : Result<leptos_router_Url, std_string_String> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : (leptos_router_Url -> US22) = closure40()
    let v17 : (std_string_String -> US22) = closure41()
    let v18 : US22 = match v15 with Ok x -> v16 x | Error x -> v17 x
    let v19 : bool = true
    let mutable _v19 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "format!(\"{:#?}\", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v20
    v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "format!(\"{:#?}\", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v22
    v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "format!(\"{:#?}\", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v24
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : std_string_String = null |> unbox<std_string_String>
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27 
    #endif
#else
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28 
    #endif
    |> fun x -> _v19 <- Some x
    let v29 : std_string_String = _v19.Value
    let v30 : string = "content.render () / effect 2 / hash_url: " + string v29 + ""
    let v31 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v30 v31
    match v18 with
    | US22_1(v92) -> (* Error *)
        let v93 : string = "content.render () / effect 2 / hash_url error: " + string v92 + ""
        let v94 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v95 : bool = Fable.Core.RustInterop.emitRustExpr v93 v94
        ()
    | US22_0(v33) -> (* Ok *)
        let v34 : US21 = US21_0
        let v35 : US20 = US20_1(v34)
        let v36 : US20 = US20_2
        let v37 : US20 = US20_3
        let v38 : US20 = US20_4
        let v39 : (US20 []) = [|v35; v36; v37; v38|]
        let v40 : int32 = v39.Length
        let v41 : US23 = US23_1
        let v42 : Mut0 = {l0 = 0; l1 = v41} : Mut0
        while method46(v40, v42) do
            let v44 : int32 = v42.l0
            let v45 : US23 = v42.l1
            let v46 : US20 = v39.[int v44]
            let v69 : US23 =
                match v45 with
                | US23_1 -> (* None *)
                    let v58 : string =
                        match v46 with
                        | US20_0 -> (* Blank *)
                            v9
                        | US20_1(v49) -> (* Dice *)
                            let v50 : string = "dice"
                            v50
                        | US20_2 -> (* Lists *)
                            let v51 : string = "lists"
                            v51
                        | US20_4 -> (* Settings *)
                            let v53 : string = "settings"
                            v53
                        | US20_3 -> (* Transactions *)
                            let v52 : string = "transactions"
                            v52
                    let v59 : string = "$0.pathname"
                    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v59
                    let v61 : string = "fable_library_rust::String_::fromString($0)"
                    let v62 : string = Fable.Core.RustInterop.emitRustExpr v60 v61
                    let v63 : string = "/" + v58 + ""
                    let v64 : bool = v62.StartsWith v63
                    if v64 then
                        US23_0(v46)
                    else
                        US23_1
                | US23_0(v47) -> (* Some *)
                    US23_0(v47)
            let v70 : int32 = v44 + 1
            v42.l0 <- v70
            v42.l1 <- v69
            ()
        let v71 : US23 = v42.l1
        let v72 : US20 = v39.[int 0]
        let v75 : US20 =
            match v71 with
            | US23_1 -> (* None *)
                v72
            | US23_0(v73) -> (* Some *)
                v73
        let v76 : bool = true
        let mutable _v76 : std_string_String option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v77 : string = "format!(\"{:#?}\", $0)"
        let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v75 v77
        v78 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v79 : string = "format!(\"{:#?}\", $0)"
        let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr v75 v79
        v80 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v81 : string = "format!(\"{:#?}\", $0)"
        let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v75 v81
        v82 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v83 : std_string_String = null |> unbox<std_string_String>
        v83 
        #endif
#if FABLE_COMPILER_PYTHON
        let v84 : std_string_String = null |> unbox<std_string_String>
        v84 
        #endif
#else
        let v85 : std_string_String = null |> unbox<std_string_String>
        v85 
        #endif
        |> fun x -> _v76 <- Some x
        let v86 : std_string_String = _v76.Value
        let v87 : string = "content.render () / effect 2 / new_tab: " + string v86 + ""
        let v88 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v89 : bool = Fable.Core.RustInterop.emitRustExpr v87 v88
        let v90 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v91 : bool = Fable.Core.RustInterop.emitRustExpr struct (v1, v75) v90
        ()
and closure46 () (v0 : (bool * std_string_String)) : struct (bool * std_string_String) =
    let (a, b) = v0
    let v1 : bool = a
    let v2 : std_string_String = b
    struct (v1, v2)
and closure47 () struct (v0 : bool, v1 : std_string_String) : bool =
    v0
and method50 () : (struct (bool * std_string_String) -> bool) =
    closure47()
and method51 (v0 : Vec<struct (bool * std_string_String)>) : Vec<struct (bool * std_string_String)> =
    v0
and closure48 () struct (v0 : bool, v1 : std_string_String) : std_string_String =
    v1
and closure49 () (v0 : std_string_String) : string =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure45 (v0 : Heap2) () : Vec<string> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : Vec<(bool * std_string_String)> = v6.l1
    let v8 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v9 : ((bool * std_string_String) -> struct (bool * std_string_String)) = closure46()
    let v10 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : (struct (bool * std_string_String) -> bool) = method50()
    let v12 : Vec<struct (bool * std_string_String)> = method51(v10)
    let v13 : string = "v12.into_iter().filter(|x| v11(x.clone().clone())).collect()"
    let v14 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v16 : (struct (bool * std_string_String) -> std_string_String) = closure48()
    let v17 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (std_string_String -> string) = closure49()
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
and closure51 () (v0 : string) : struct (bool * string * bool * US25 * string) =
    let v1 : string = "https://api3.nearblocks.io/v1/account/" + v0 + ""
    let v2 : string = ""
    let v3 : US25 = US25_0
    struct (true, v2, false, v3, v1)
and closure50 (v0 : leptos_Memo<Vec<string>>) () : (struct (bool * string * bool * US25 * string) []) =
    let v1 : string = $"$0()"
    let v2 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v4 : (string -> struct (bool * string * bool * US25 * string)) = closure51()
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
and method52 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure54 (v0 : string) (v1 : int32) : struct (bool * string * bool * US25 * string) =
    let v2 : int32 = v1 + 1
    let v3 : string = "https://api3.nearblocks.io/v1/account/" + v0 + "/txns?&order=desc&page=" + string v2 + "&per_page=" + string 25 + ""
    let v4 : string = ""
    let v5 : US25 = US25_0
    struct (true, v4, false, v5, v3)
and closure53 (v0 : Heap0) (v1 : string) : struct (string * Vec<struct (bool * string * bool * US25 * string)>) =
    let v2 : int32 = v0.l3
    let v3 : (int32 []) = Array.zeroCreate<int32> (v2)
    let v4 : Mut1 = {l0 = 0} : Mut1
    while method52(v2, v4) do
        let v6 : int32 = v4.l0
        v3.[int v6] <- v6
        let v7 : int32 = v6 + 1
        v4.l0 <- v7
        ()
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<int32> = Fable.Core.RustInterop.emitRustExpr v3 v8
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v11 : (int32 -> struct (bool * string * bool * US25 * string)) = closure54(v1)
    let v12 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    struct (v1, v12)
and closure52 (v0 : Heap2, v1 : leptos_Memo<Vec<string>>) () : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<Heap0> = v4.l1
    let v6 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v7 : Heap0 = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = $"$0()"
    let v9 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1 v8
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v11 : (string -> struct (string * Vec<struct (bool * string * bool * US25 * string)>)) = closure53(v7)
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
and closure56 () struct (v0 : string, v1 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v1
and method53 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method54 (v0 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v0
and method55 (v0 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v0
and closure55 (v0 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) () : (struct (bool * string * bool * US25 * string) []) =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v4 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) -> Vec<struct (bool * string * bool * US25 * string)>) = closure56()
    let v5 : Vec<Vec<struct (bool * string * bool * US25 * string)>> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : (struct (bool * string * bool * US25 * string) []) = [||]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v10 : (Vec<struct (bool * string * bool * US25 * string)> []) = Fable.Core.RustInterop.emitRustExpr v5 v9
    let v11 : int32 = v10.Length
    let v12 : Mut2 = {l0 = 0; l1 = v8} : Mut2
    while method53(v11, v12) do
        let v14 : int32 = v12.l0
        let v15 : Vec<struct (bool * string * bool * US25 * string)> = v12.l1
        let v16 : Vec<struct (bool * string * bool * US25 * string)> = v10.[int v14]
        let v17 : Vec<struct (bool * string * bool * US25 * string)> = method54(v16)
        let v18 : Vec<struct (bool * string * bool * US25 * string)> = method55(v15)
        let v19 : string = "true; let mut v18 = v18"
        let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19
        let v21 : string = "true; v18.extend(v17)"
        let v22 : bool = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : string = "v18"
        let v24 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : int32 = v14 + 1
        v12.l0 <- v25
        v12.l1 <- v24
        ()
    let v26 : Vec<struct (bool * string * bool * US25 * string)> = v12.l1
    let v27 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v28 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = $"%A{v28}"
    let v30 : string = "use_transactions.render (5) / txns_requests create_memo / result: " + string v29 + ""
    let v31 : int32 = v30.Length
    let v32 : bool = v31 <= 200
    let v35 : string =
        if v32 then
            v30
        else
            let v33 : string = v30.[int 0..int 199]
            let v34 : string = v33 + "..."
            v34
    let v36 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36
    v28
and closure59 (v0 : string) struct (v1 : bool, v2 : string, v3 : bool, v4 : US25, v5 : string) : string =
    v0
and closure58 () struct (v0 : string, v1 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<string> =
    let v2 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v3 : (struct (bool * string * bool * US25 * string) -> string) = closure59(v0)
    let v4 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v1, v3) v2
    v4
and method56 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method57 (v0 : Vec<string>) : Vec<string> =
    v0
and method58 (v0 : Vec<string>) : Vec<string> =
    v0
and closure57 (v0 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) () : (string []) =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v4 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) -> Vec<string>) = closure58()
    let v5 : Vec<Vec<string>> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : (string []) = [||]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v10 : (Vec<string> []) = Fable.Core.RustInterop.emitRustExpr v5 v9
    let v11 : int32 = v10.Length
    let v12 : Mut3 = {l0 = 0; l1 = v8} : Mut3
    while method56(v11, v12) do
        let v14 : int32 = v12.l0
        let v15 : Vec<string> = v12.l1
        let v16 : Vec<string> = v10.[int v14]
        let v17 : Vec<string> = method57(v16)
        let v18 : Vec<string> = method58(v15)
        let v19 : string = "true; let mut v18 = v18"
        let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19
        let v21 : string = "true; v18.extend(v17)"
        let v22 : bool = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : string = "v18"
        let v24 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : int32 = v14 + 1
        v12.l0 <- v25
        v12.l1 <- v24
        ()
    let v26 : Vec<string> = v12.l1
    let v27 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v28 : (string []) = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = $"%A{v28}"
    let v30 : string = "use_transactions.render (6) / urls_accounts create_memo / result: " + string v29 + ""
    let v31 : int32 = v30.Length
    let v32 : bool = v31 <= 200
    let v35 : string =
        if v32 then
            v30
        else
            let v33 : string = v30.[int 0..int 199]
            let v34 : string = v33 + "..."
            v34
    let v36 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36
    v28
and closure62 () (v0 : crate_model_near_nearblocks_Action) : struct (std_string_String * std_string_String option) =
    let v1 : string = "$0.action"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.method"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3
    struct (v2, v4)
and method59 (v0 : (struct (std_string_String * std_string_String option) [])) : (struct (std_string_String * std_string_String option) []) =
    v0
and closure61 () (v0 : crate_model_near_nearblocks_Txn) : struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) =
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
    let v19 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v20 : (crate_model_near_nearblocks_Action -> struct (std_string_String * std_string_String option)) = closure62()
    let v21 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (struct (std_string_String * std_string_String option) []) = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (struct (std_string_String * std_string_String option) []) = method59(v23)
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
    let v38 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v0 v37
    let v39 : (std_string_String []) option = None
    let _v39 = ref v39 
    match v38 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v40 : Vec<std_string_String> = x
    let v41 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v42 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v40 v41
    v42 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v39.Value <- x
    let v43 : (std_string_String []) option = _v39.Value 
    let v44 : (std_string_String []) = [||]
    let v45 : (std_string_String []) = v43 |> Option.defaultValue v44 
    struct (v24, v28, v16, v12, v10, v45, v32, v36, v4, v2, v6, v8)
and method60 (v0 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])) : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) =
    v0
and closure60 () (v0 : crate_model_near_nearblocks_Root) : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) =
    let v1 : string = "$0.txns"
    let v2 : Vec<crate_model_near_nearblocks_Txn> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v4 : (crate_model_near_nearblocks_Txn -> struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)) = closure61()
    let v5 : Vec<struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = method60(v7)
    v8
and closure63 (v0 : leptos_Resource<US2, rexie_Rexie>) () : rexie_Rexie option =
    let v1 : string = "state_core.use_requests (2) / database_memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5
and closure64 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Resource<US2, rexie_Rexie>) () : struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])) =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = $"$0()"
    let v5 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v4
    struct (v3, v5)
and method65 () : string =
    let v0 : string = ""
    v0
and method64 (v0 : int64, v1 : string) : string =
    let v2 : int64 = System.Convert.ToInt64 v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : float = float v0
        let v5 : float = v4 / 2.0
        let v6 : (float -> float) = ceil
        let v7 : float = v6 v5
        let v8 : int64 = int64 v7
        let v9 : (float -> float) = floor
        let v10 : float = v9 v5
        let v11 : int64 = int64 v10
        let v12 : int64 = v8 - 1L
        let v13 : string = v1.[int 0L..int v12]
        let v14 : int64 = v2 - v11
        let v15 : int64 = v2 - 1L
        let v16 : string = v1.[int v14..int v15]
        let v17 : string = "..."
        let v18 : (string []) = [|v13; v17; v16|]
        let v19 : ((string []) -> string seq) = Seq.ofArray
        let v20 : string seq = v19 v18
        let v21 : string = method65()
        let v22 : (string -> (string seq -> string)) = String.concat
        let v23 : (string seq -> string) = v22 v21
        v23 v20
and method68 (v0 : Result<Heap4 option, std_string_String>) : Result<Heap4 option, std_string_String> =
    v0
and method67 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    let v2 : string = "state_core.get_data () / id: " + v0 + ""
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    let v6 : string = "store"
    let v7 : (string []) = [|v6|]
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v11 : (string -> std_string_String) = closure9()
    let v12 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    let v13 : rexie_Rexie = method14(v1)
    let v14 : string = "v13.transaction(&v12, rexie::TransactionMode::ReadOnly)"
    let v15 : Result<rexie_Transaction, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : (rexie_Error -> std_string_String) = method15()
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<rexie_Transaction, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17
    let v19 : string = "$0?"
    let v20 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = method16()
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "v20.store(v23)"
    let v25 : Result<rexie_Store, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (rexie_Error -> std_string_String) = method17()
    let v27 : string = "$0.map_err(|x| $1(x))"
    let v28 : Result<rexie_Store, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v25, v26) v27
    let v29 : string = "$0?"
    let v30 : rexie_Store = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = method18(v0)
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "wasm_bindgen::JsValue::from_str(v33)"
    let v35 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : string = $"Box::pin(rexie::Store::get(&v30, &v35))"
    let v37 : std_pin_Pin<Box<Dyn<std_future_Future<Result<wasm_bindgen_JsValue, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "v37.await"
    let v39 : Result<wasm_bindgen_JsValue, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : (rexie_Error -> std_string_String) = method19()
    let v41 : string = "$0.map_err(|x| $1(x))"
    let v42 : Result<wasm_bindgen_JsValue, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v39, v40) v41
    let v43 : string = "$0?"
    let v44 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : wasm_bindgen_JsValue = method20(v44)
    let v46 : string = "serde_wasm_bindgen::from_value(v45)"
    let v47 : Result<serde_json_Value option, serde_wasm_bindgen_Error> = Fable.Core.RustInterop.emitRustExpr () v46
    let v48 : (serde_wasm_bindgen_Error -> std_string_String) = method21()
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<serde_json_Value option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v47, v48) v49
    let v51 : string = "$0?"
    let v52 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : US7 option = None
    let _v53 = ref v53 
    match v52 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v54 : serde_json_Value = x
    let v55 : US7 = US7_0(v54)
    v55 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v53.Value <- x
    let v56 : US7 option = _v53.Value 
    let v57 : US7 = US7_1
    let v58 : US7 = v56 |> Option.defaultValue v57 
    let v90 : US27 =
        match v58 with
        | US7_1 -> (* None *)
            US27_1
        | US7_0(v59) -> (* Some *)
            let v60 : serde_json_Value = method22(v59)
            let v61 : string = "serde_json::from_value(v60)"
            let v62 : Result<Vec<uint8>, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v61
            let v63 : (serde_json_Error -> std_string_String) = method23()
            let v64 : string = "$0.map_err(|x| $1(x))"
            let v65 : Result<Vec<uint8>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v62, v63) v64
            let v66 : string = "$0?"
            let v67 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v69 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v67 v68
            let v70 : int32 = v69.Length
            let v71 : string = "state_core.get_data () / data_len: " + string v70 + ""
            let v72 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v73 : bool = Fable.Core.RustInterop.emitRustExpr v71 v72
            let v74 : string = "$0.to_vec()"
            let v75 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v69 v74
            let v76 : string = "v75.as_slice()"
            let v77 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v76
            let v78 : string = "true; let mut v77 = v77"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78
            let v80 : string = "borsh::BorshDeserialize::deserialize(&mut v77)"
            let v81 : Result<Heap4, borsh_io_Error> = Fable.Core.RustInterop.emitRustExpr () v80
            let v82 : (borsh_io_Error -> std_string_String) = method24()
            let v83 : string = "$0.map_err(|x| $1(x))"
            let v84 : Result<Heap4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v81, v82) v83
            let v85 : string = "$0?"
            let v86 : Heap4 = Fable.Core.RustInterop.emitRustExpr v84 v85
            US27_0(v86)
    let v95 : Heap4 option =
        match v90 with
        | US27_1 -> (* None *)
            let v93 : Heap4 option = None
            v93
        | US27_0(v91) -> (* Some *)
            let v92 : Heap4 option = Some v91 
            v92
    let v96 : Result<Heap4 option, std_string_String> = Ok v95
    let v97 : Result<Heap4 option, std_string_String> = method68(v96)
    let v98 : string = "v97 }}})"
    Fable.Core.RustInterop.emitRustExpr () v98
    let v99 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v99
    let v100 : string = "__result"
    let v101 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v100
    v101
and method66 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    method67(v0, v1)
and closure66 () (v0 : Heap4 option) : US26 =
    US26_0(v0)
and closure67 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and closure65 (v0 : rexie_Rexie option) struct (v1 : bool, v2 : string, v3 : bool, v4 : US25, v5 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    let v6 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : US5 option = None
    let _v7 = ref v7 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v8 : rexie_Rexie = x
    let v9 : US5 = US5_0(v8)
    v9 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v7.Value <- x
    let v10 : US5 option = _v7.Value 
    let v11 : US5 = US5_1
    let v12 : US5 = v10 |> Option.defaultValue v11 
    let v27 : US26 =
        match v12 with
        | US5_0(v13) -> (* Some *)
            let v14 : string = "url[" + v5 + "](" + $"%A{v2}" + ")"
            let v15 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = method66(v14, v13)
            let v16 : string = "v15.await"
            let v17 : Result<Heap4 option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v16
            let v18 : (Heap4 option -> US26) = closure66()
            let v19 : (std_string_String -> US26) = closure67()
            let v20 : US26 = match v17 with Ok x -> v18 x | Error x -> v19 x
            v20
        | _ ->
            let v21 : string = "&*$0"
            let v22 : string = "database=None"
            let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v22 v21
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
    let v34 : Result<Heap4 option, std_string_String> = method68(v33)
    let v35 : string = "v34 }}})"
    Fable.Core.RustInterop.emitRustExpr () v35
    let v36 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v36
    let v37 : string = "__result"
    let v38 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v37
    v38
and method69 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> =
    v0
and method70 (v0 : Result<Vec<Heap4 option>, std_string_String>) : Result<Vec<Heap4 option>, std_string_String> =
    v0
and method63 (v0 : (struct (bool * string * bool * US25 * string) []), v1 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = $"%A{v1}"
    let v4 : string = $"%A{v0}"
    let v5 : int64 = 400L
    let v6 : string = method64(v5, v4)
    let v7 : string = "state_core.use_requests (3) / state_data_resource create_local_resource / request : " + string v6 + " / database: " + string v3 + ""
    let v8 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.to_vec()"
    let v11 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v0 v10
    let v12 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v13 : (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>) = closure65(v1)
    let v14 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v12
    let v15 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = method69(v14)
    let v16 : string = "futures::future::try_join_all(v15)"
    let v17 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : string = "v17.await"
    let v19 : Result<Vec<Heap4 option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "$0?"
    let v21 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : Result<Vec<Heap4 option>, std_string_String> = Ok v21
    let v23 : string = $"%A{v22}"
    let v24 : string = "state_core.use_requests (4) / state_data_resource create_local_resource / result: " + string v23 + ""
    let v25 : int32 = v24.Length
    let v26 : bool = v25 <= 200
    let v29 : string =
        if v26 then
            v24
        else
            let v27 : string = v24.[int 0..int 199]
            let v28 : string = v27 + "..."
            v28
    let v30 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : Result<Vec<Heap4 option>, std_string_String> = method70(v22)
    let v33 : string = "v32 }})"
    Fable.Core.RustInterop.emitRustExpr () v33
    let v34 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v34
    let v35 : string = "__result"
    let v36 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v35
    v36
and method71 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> =
    v0
and method62 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Resource<US2, rexie_Rexie>) : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> =
    let v2 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v3 : (unit -> struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) []))) = closure64(v0, v1)
    Fable.Core.RustInterop.emitRustExpr v3 v2
    let v4 : string = "x"
    let struct (v5 : rexie_Rexie option, v6 : (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr () v4
    let v7 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = method63(v6, v5)
    let v8 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = method71(v7)
    let v9 : string = "v8.await"
    let v10 : Result<Vec<Heap4 option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "v10 }})"
    Fable.Core.RustInterop.emitRustExpr () v11
    let v12 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v13
    v14
and closure69 () (v0 : Vec<Heap4 option>) : (Heap4 option []) =
    let v1 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v2 : (Heap4 option []) = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and method72 () : (Vec<Heap4 option> -> (Heap4 option [])) =
    closure69()
and method73 (v0 : Result<Vec<Heap4 option>, std_string_String>) : Result<Vec<Heap4 option>, std_string_String> =
    v0
and closure68 (v0 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>>) () : Result<(Heap4 option []), std_string_String> option =
    let v1 : string = "state_core.use_requests (5) / state_data_func"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : web_sys_Window = method28()
    let v5 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method29(v4)
    let v6 : (web_sys_Storage option -> US10) = closure19()
    let v7 : (wasm_bindgen_JsValue -> US10) = closure20()
    let v8 : US10 = match v5 with Ok x -> v6 x | Error x -> v7 x
    let v20 : US11 =
        match v8 with
        | US10_1(v17) -> (* Error *)
            US11_1(v17)
        | US10_0(v9) -> (* Ok *)
            let v10 : US12 option = None
            let _v10 = ref v10 
            match v9 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v11 : web_sys_Storage = x
            let v12 : US12 = US12_0(v11)
            v12 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v10.Value <- x
            let v13 : US12 option = _v10.Value 
            let v14 : US12 = US12_1
            let v15 : US12 = v13 |> Option.defaultValue v14 
            US11_0(v15)
    let v35 : Result<(Heap4 option []), std_string_String> option =
        match v20 with
        | US11_0(v21) -> (* Ok *)
            match v21 with
            | US12_0(v22) -> (* Some *)
                let v23 : string = $"leptos::SignalGet::get(&$0)"
                let v24 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v0 v23
                let v25 : Result<(Heap4 option []), std_string_String> option = None
                let _v25 = ref v25 
                match v24 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v26 : Result<Vec<Heap4 option>, std_string_String> = x
                let v27 : (Vec<Heap4 option> -> (Heap4 option [])) = method72()
                let v28 : Result<Vec<Heap4 option>, std_string_String> = method73(v26)
                let v29 : string = "v28.map(|x| v27(x))"
                let v30 : Result<(Heap4 option []), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v29
                v30 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v25.Value <- x
                let v31 : Result<(Heap4 option []), std_string_String> option = _v25.Value 
                v31
            | _ ->
                let v32 : Result<(Heap4 option []), std_string_String> option = None
                v32
        | _ ->
            let v34 : Result<(Heap4 option []), std_string_String> option = None
            v34
    let v36 : string = $"%A{v35}"
    let v37 : string = "state_core.use_requests (6) / state_data_func func0 / result: " + string v36 + ""
    let v38 : int32 = v37.Length
    let v39 : bool = v38 <= 200
    let v42 : string =
        if v39 then
            v37
        else
            let v40 : string = v37.[int 0..int 199]
            let v41 : string = v40 + "..."
            v41
    let v43 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v44 : bool = Fable.Core.RustInterop.emitRustExpr v42 v43
    v35
and closure70 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>) () : struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option) =
    let v2 : string = $"$0()"
    let v3 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = $"$0()"
    let v5 : Result<(Heap4 option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v4
    struct (v3, v5)
and closure71 () (v0 : (Heap4 option [])) : US31 =
    US31_0(v0)
and closure72 () (v0 : std_string_String) : US31 =
    US31_1(v0)
and closure73 () (v0 : Heap4 option) : US27 =
    let v1 : US27 option = None
    let _v1 = ref v1 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : Heap4 = x
    let v3 : US27 = US27_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v1.Value <- x
    let v4 : US27 option = _v1.Value 
    let v5 : US27 = US27_1
    let v6 : US27 = v4 |> Option.defaultValue v5 
    v6
and method77 (v0 : US25) : US25 =
    v0
and method78 (v0 : string) : string =
    v0
and method79 (v0 : std_string_String) : std_string_String =
    v0
and method80 (v0 : string) : string =
    v0
and method81 (v0 : std_string_String) : std_string_String =
    v0
and method82 (v0 : reqwest_RequestBuilder) : reqwest_RequestBuilder =
    v0
and method83 (v0 : reqwest_RequestBuilder) : reqwest_RequestBuilder =
    v0
and closure76 () (v0 : reqwest_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method84 () : (reqwest_Error -> std_string_String) =
    closure76()
and method85 (v0 : Result<string option, std_string_String>) : Result<string option, std_string_String> =
    v0
and closure75 (v0 : US29, v1 : int32) struct (v2 : bool, v3 : string, v4 : bool, v5 : US25, v6 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>> =
    let v7 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v42 : US32 =
        match v0 with
        | US29_1 -> (* None *)
            US32_1
        | US29_0(v8) -> (* Some *)
            let v38 : US33 =
                match v8 with
                | US30_1(v35) -> (* Error *)
                    US33_1(v35)
                | US30_0(v9) -> (* Ok *)
                    let v10 : (int32 -> ((US27 []) -> US27 option)) = Array.tryItem
                    let v11 : ((US27 []) -> US27 option) = v10 v1
                    let v12 : US27 option = v11 v9
                    let v13 : US35 option = None
                    let _v13 = ref v13 
                    match v12 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v14 : US27 = x
                    let v15 : US35 = US35_0(v14)
                    v15 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v13.Value <- x
                    let v16 : US35 option = _v13.Value 
                    let v17 : US35 = US35_1
                    let v18 : US35 = v16 |> Option.defaultValue v17 
                    let v25 : US27 =
                        match v18 with
                        | US35_0(v19) -> (* Some *)
                            match v19 with
                            | US27_0(v20) -> (* Some *)
                                US27_0(v20)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v33 : US34 =
                        match v25 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v26) -> (* Some *)
                            let v27 : std_string_String = v26.l0
                            let v28 : string = "fable_library_rust::String_::fromString($0)"
                            let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
                            US34_0(v29)
                    US33_0(v33)
            US32_0(v38)
    let v43 : string = $"%A{struct (v2, v4, v5)}"
    let v44 : int64 = 400L
    let v45 : string = method64(v44, v43)
    let v46 : string = $"%A{v0}"
    let v47 : int64 = 400L
    let v48 : string = method64(v47, v46)
    let v49 : string = $"%A{v42}"
    let v50 : int64 = 400L
    let v51 : string = method64(v50, v49)
    let v74 : bool =
        if v2 then
            true
        else
            match v0 with
            | US29_0(v52) -> (* Some *)
                match v52 with
                | US30_0(v53) -> (* Ok *)
                    let v54 : uint64 = System.Convert.ToUInt64 v53.Length
                    let v55 : bool = v54 = 0UL
                    if v55 then
                        false
                    else
                        match v42 with
                        | US32_0(v56) -> (* Some *)
                            match v56 with
                            | US33_0(v57) -> (* Ok *)
                                match v57 with
                                | US34_1 -> (* None *)
                                    true
                                | _ ->
                                    false
                            | _ ->
                                false
                        | _ ->
                            false
                | _ ->
                    match v42 with
                    | US32_0(v62) -> (* Some *)
                        match v62 with
                        | US33_0(v63) -> (* Ok *)
                            match v63 with
                            | US34_1 -> (* None *)
                                true
                            | _ ->
                                false
                        | _ ->
                            false
                    | _ ->
                        false
            | _ ->
                match v42 with
                | US32_0(v68) -> (* Some *)
                    match v68 with
                    | US33_0(v69) -> (* Ok *)
                        match v69 with
                        | US34_1 -> (* None *)
                            true
                        | _ ->
                            false
                    | _ ->
                        false
                | _ ->
                    false
    let v75 : string = "state_core.use_requests (9) / result memo / state_data: " + string v48 + " / state_data': " + string v51 + " / request: " + string v45 + " / should_fetch: " + string v74 + ""
    let v76 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76
    let v78 : bool = v74 = false
    let v149 : US36 =
        if v78 then
            let v79 : string option = None
            US36_0(v79)
        else
            let v81 : US25 = method77(v5)
            let v99 : reqwest_RequestBuilder =
                match v81 with
                | US25_0 -> (* Get *)
                    let v82 : string = method78(v6)
                    let v83 : string = "&*$0"
                    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v82 v83
                    let v85 : string = "String::from($0)"
                    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr v84 v85
                    let v87 : std_string_String = method79(v86)
                    let v88 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.get(v87)"
                    let v89 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v88
                    v89
                | US25_1 -> (* Post *)
                    let v90 : string = method80(v6)
                    let v91 : string = "&*$0"
                    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v90 v91
                    let v93 : string = "String::from($0)"
                    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v92 v93
                    let v95 : std_string_String = method81(v94)
                    let v96 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.post(v95)"
                    let v97 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v96
                    v97
            let v100 : string = "&*$0"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v100
            let v102 : string = "String::from($0)"
            let v103 : std_string_String = Fable.Core.RustInterop.emitRustExpr v101 v102
            let v104 : string = "reqwest_wasm::RequestBuilder::body(v99, v103)"
            let v105 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v104
            let v106 : bool = v4 = false
            let v125 : reqwest_RequestBuilder =
                if v106 then
                    let v107 : string = "v105"
                    let v108 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v107
                    v108
                else
                    let v109 : string = "reqwest_wasm::header::CONTENT_TYPE.to_string()"
                    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v109
                    let v111 : string = "fable_library_rust::String_::fromString($0)"
                    let v112 : string = Fable.Core.RustInterop.emitRustExpr v110 v111
                    let v113 : reqwest_RequestBuilder = method82(v105)
                    let v114 : string = "&*$0"
                    let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v112 v114
                    let v116 : string = "String::from($0)"
                    let v117 : std_string_String = Fable.Core.RustInterop.emitRustExpr v115 v116
                    let v118 : string = "&*$0"
                    let v119 : string = "application/json"
                    let v120 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v118
                    let v121 : string = "String::from($0)"
                    let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr v120 v121
                    let v123 : string = "reqwest_wasm::RequestBuilder::header(v113, v117, v122)"
                    let v124 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v123
                    v124
            let v126 : reqwest_RequestBuilder = method83(v125)
            let v127 : string = "Box::pin(reqwest_wasm::RequestBuilder::send(v126))"
            let v128 : std_pin_Pin<Box<Dyn<std_future_Future<Result<reqwest_Response, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v127
            let v129 : string = "v128.await"
            let v130 : Result<reqwest_Response, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v129
            let v131 : (reqwest_Error -> std_string_String) = method84()
            let v132 : string = "$0.map_err(|x| $1(x))"
            let v133 : Result<reqwest_Response, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v130, v131) v132
            let v134 : string = "$0?"
            let v135 : reqwest_Response = Fable.Core.RustInterop.emitRustExpr v133 v134
            let v136 : string = "Box::pin(reqwest_wasm::Response::text(v135))"
            let v137 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_string_String, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v136
            let v138 : string = "v137.await"
            let v139 : Result<std_string_String, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v138
            let v140 : (reqwest_Error -> std_string_String) = method84()
            let v141 : string = "$0.map_err(|x| $1(x))"
            let v142 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v139, v140) v141
            let v143 : string = "$0?"
            let v144 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v143
            let v145 : string = "fable_library_rust::String_::fromString($0)"
            let v146 : string = Fable.Core.RustInterop.emitRustExpr v144 v145
            let v147 : string option = Some v146 
            US36_0(v147)
    let v155 : Result<string option, std_string_String> =
        match v149 with
        | US36_1(v152) -> (* Error *)
            let v153 : Result<string option, std_string_String> = Error v152
            v153
        | US36_0(v150) -> (* Ok *)
            let v151 : Result<string option, std_string_String> = Ok v150
            v151
    let v156 : Result<string option, std_string_String> = method85(v155)
    let v157 : string = "v156 }})"
    Fable.Core.RustInterop.emitRustExpr () v157
    let v158 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v158
    let v159 : string = "__result"
    let v160 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v159
    v160
and closure74 (v0 : US29) (v1 : int32) : (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>) =
    closure75(v0, v1)
and method76 (v0 : US29) : (int32 -> (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>)) =
    closure74(v0)
and method86 (v0 : Vec<struct (bool * string * bool * US25 * string)>) : Vec<struct (bool * string * bool * US25 * string)> =
    v0
and method87 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> =
    v0
and method88 (v0 : Result<(string option []), std_string_String>) : Result<(string option []), std_string_String> =
    v0
and method75 (v0 : Result<(Heap4 option []), std_string_String> option, v1 : (struct (bool * string * bool * US25 * string) [])) : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> =
    let v2 : string = $"%A{v1}"
    let v3 : int64 = 400L
    let v4 : string = method64(v3, v2)
    let v5 : string = "state_core.use_requests (7) / json create_local_resource / requests: " + string v4 + ""
    let v6 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    let v9 : US28 option = None
    let _v9 = ref v9 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : Result<(Heap4 option []), std_string_String> = x
    let v11 : US28 = US28_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US28 option = _v9.Value 
    let v13 : US28 = US28_1
    let v14 : US28 = v12 |> Option.defaultValue v13 
    let v35 : US29 =
        match v14 with
        | US28_1 -> (* None *)
            US29_1
        | US28_0(v15) -> (* Some *)
            let v16 : ((Heap4 option []) -> US31) = closure71()
            let v17 : (std_string_String -> US31) = closure72()
            let v18 : US31 = match v15 with Ok x -> v16 x | Error x -> v17 x
            let v31 : US30 =
                match v18 with
                | US31_1(v28) -> (* Error *)
                    US30_1(v28)
                | US31_0(v19) -> (* Ok *)
                    let v20 : string = "$0.to_vec()"
                    let v21 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v19 v20
                    let v22 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v23 : (Heap4 option -> US27) = closure73()
                    let v24 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v22
                    let v25 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v26 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v24 v25
                    US30_0(v26)
            US29_0(v31)
    let v36 : string = $"%A{v35}"
    let v37 : int64 = 400L
    let v38 : string = method64(v37, v36)
    let v39 : string = "state_core.use_requests (8) / result_memo / state_data: " + string v38 + ""
    let v40 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "$0.to_vec()"
    let v43 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v1 v42
    let v44 : (int32 -> (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>)) = method76(v35)
    let v45 : Vec<struct (bool * string * bool * US25 * string)> = method86(v43)
    let v46 : string = "v45.iter().enumerate().map(|(i, x)| v44(i.try_into().unwrap())(x.clone())).collect()"
    let v47 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v46
    let v48 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = method87(v47)
    let v49 : string = "futures::future::try_join_all(v48)"
    let v50 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : string = "v50.await"
    let v52 : Result<Vec<string option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : string = "$0?"
    let v54 : Vec<string option> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v56 : (string option []) = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : Result<(string option []), std_string_String> = Ok v56
    let v58 : Result<(string option []), std_string_String> = method88(v57)
    let v59 : string = "v58 }}})"
    Fable.Core.RustInterop.emitRustExpr () v59
    let v60 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v60
    let v61 : string = "__result"
    let v62 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v61
    v62
and method89 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> =
    v0
and method74 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>) : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> =
    let v2 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v3 : (unit -> struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option)) = closure70(v0, v1)
    Fable.Core.RustInterop.emitRustExpr v3 v2
    let v4 : string = "x"
    let struct (v5 : (struct (bool * string * bool * US25 * string) []), v6 : Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr () v4
    let v7 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> = method75(v6, v5)
    let v8 : std_pin_Pin<Box<Dyn<std_future_Future<Result<(string option []), std_string_String>>>>> = method89(v7)
    let v9 : string = "v8.await"
    let v10 : Result<(string option []), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "v10 }})"
    Fable.Core.RustInterop.emitRustExpr () v11
    let v12 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v13
    v14
and method90 (v0 : string) : string =
    v0
and closure79 () (v0 : rexie_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method91 () : (rexie_Error -> std_string_String) =
    closure79()
and method92 (v0 : Result<unit, std_string_String>) : Result<unit, std_string_String> =
    v0
and closure78 (v0 : Heap4, v1 : US5) struct (v2 : bool, v3 : string, v4 : bool, v5 : US25, v6 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> =
    let v7 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v55 : US37 =
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
            let v18 : string = "let __result = Box::pin(async move { //"
            Fable.Core.RustInterop.emitRustExpr () v18
            let v19 : string = "$0.transaction(&[\"store\"], rexie::TransactionMode::ReadWrite)?"
            let v20 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v8 v19
            let v21 : string = "v20.store(\"store\")?"
            let v22 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v21
            let v23 : string = "true; let mut data = Vec::new()"
            let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23
            let v25 : string = "true; borsh::BorshSerialize::serialize(&$0, &mut data).unwrap()"
            let v26 : bool = Fable.Core.RustInterop.emitRustExpr v0 v25
            let v27 : string = "data"
            let v28 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : string = "serde_wasm_bindgen::to_value(&v28).unwrap()"
            let v30 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v29
            let v31 : string = method90(v12)
            let v32 : string = "&*$0"
            let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v31 v32
            let v34 : string = "true; v22.put(&v30, Some(&v33.into())).await?"
            let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34
            let v36 : string = "true; v20.done().await?"
            let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36
            let v38 : Result<unit, rexie_Error> = Ok ()
            let v39 : Result<unit, rexie_Error> = method36(v38)
            let v40 : string = "v39 }})"
            Fable.Core.RustInterop.emitRustExpr () v40
            let v41 : string = "{ //"
            Fable.Core.RustInterop.emitRustExpr () v41
            let v42 : string = "__result"
            let v43 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v42
            let v44 : string = "v43.await"
            let v45 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v44
            let v46 : (rexie_Error -> std_string_String) = method91()
            let v47 : string = "$0.map_err(|x| $1(x))"
            let v48 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v47
            let v49 : string = "$0?"
            Fable.Core.RustInterop.emitRustExpr v48 v49
            US37_0
        | _ ->
            let v51 : string = "state_core.use_requests (12) / set_state_data_action / database,request=None"
            let v52 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v53 : bool = Fable.Core.RustInterop.emitRustExpr v51 v52
            US37_0
    let v60 : Result<unit, std_string_String> =
        match v55 with
        | US37_1(v57) -> (* Error *)
            let v58 : Result<unit, std_string_String> = Error v57
            v58
        | US37_0 -> (* Ok *)
            let v56 : Result<unit, std_string_String> = Ok ()
            v56
    let v61 : Result<unit, std_string_String> = method92(v60)
    let v62 : string = "v61 }})"
    Fable.Core.RustInterop.emitRustExpr () v62
    let v63 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v63
    let v64 : string = "__result"
    let v65 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v64
    v65
and method93 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> =
    v0
and method94 (v0 : Result<Vec<unit>, std_string_String>) : Result<Vec<unit>, std_string_String> =
    v0
and closure77 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<rexie_Rexie option>) (v2 : Heap4) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>> =
    let v3 : string = $"%A{v2}"
    let v4 : int64 = System.Convert.ToInt64 v3.Length
    let v5 : string = "state_core.use_requests (10) / set_state_data_action / value_len: " + string v4 + ""
    let v6 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    let v9 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v10 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v9
    let v11 : US5 option = None
    let _v11 = ref v11 
    match v10 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : rexie_Rexie = x
    let v13 : US5 = US5_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US5 option = _v11.Value 
    let v15 : US5 = US5_1
    let v16 : US5 = v14 |> Option.defaultValue v15 
    let v17 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v18 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v17
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v22 : (struct (bool * string * bool * US25 * string) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>) = closure78(v2, v16)
    let v23 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr struct (v20, v22) v21
    let v24 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = method93(v23)
    let v25 : string = "futures::future::try_join_all(v24)"
    let v26 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : string = "v26.await"
    let v28 : Result<Vec<unit>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "$0?"
    let v30 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : Result<Vec<unit>, std_string_String> = Ok v30
    let v32 : Result<Vec<unit>, std_string_String> = method94(v31)
    let v33 : string = "v32 }}})"
    Fable.Core.RustInterop.emitRustExpr () v33
    let v34 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v34
    let v35 : string = "__result"
    let v36 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v35
    v36
and closure81 () (v0 : (string option [])) : US40 =
    US40_0(v0)
and closure82 () (v0 : std_string_String) : US40 =
    US40_1(v0)
and closure83 () (v0 : string option) : US34 =
    let v1 : US34 option = None
    let _v1 = ref v1 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : string = x
    let v3 : US34 = US34_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v1.Value <- x
    let v4 : US34 option = _v1.Value 
    let v5 : US34 = US34_1
    let v6 : US34 = v4 |> Option.defaultValue v5 
    v6
and closure84 (v0 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) (v1 : US34) : unit =
    match v1 with
    | US34_0(v2) -> (* Some *)
        let v3 : string = "&*$0"
        let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
        let v5 : string = "String::from($0)"
        let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
        let v7 : Heap4 = {l0 = v6} : Heap4
        let v8 : string = "true; leptos::Action::dispatch(&$0, $1.clone())"
        let v9 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v7) v8
        ()
    | _ ->
        ()
and closure87 () (v0 : crate_model_near_nearblocks_Root) : crate_model_near_nearblocks_Root option =
    let v1 : crate_model_near_nearblocks_Root option = Some v0 
    v1
and method96 () : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) =
    closure87()
and method97 (v0 : Result<crate_model_near_nearblocks_Root, std_string_String>) : Result<crate_model_near_nearblocks_Root, std_string_String> =
    v0
and closure86 (v0 : US29, v1 : US42, v2 : int32) struct (v3 : bool, v4 : string, v5 : bool, v6 : US25, v7 : string) : Result<crate_model_near_nearblocks_Root option, std_string_String> =
    let v42 : US32 =
        match v0 with
        | US29_1 -> (* None *)
            US32_1
        | US29_0(v8) -> (* Some *)
            let v38 : US33 =
                match v8 with
                | US30_1(v35) -> (* Error *)
                    US33_1(v35)
                | US30_0(v9) -> (* Ok *)
                    let v10 : (int32 -> ((US27 []) -> US27 option)) = Array.tryItem
                    let v11 : ((US27 []) -> US27 option) = v10 v2
                    let v12 : US27 option = v11 v9
                    let v13 : US35 option = None
                    let _v13 = ref v13 
                    match v12 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v14 : US27 = x
                    let v15 : US35 = US35_0(v14)
                    v15 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v13.Value <- x
                    let v16 : US35 option = _v13.Value 
                    let v17 : US35 = US35_1
                    let v18 : US35 = v16 |> Option.defaultValue v17 
                    let v25 : US27 =
                        match v18 with
                        | US35_0(v19) -> (* Some *)
                            match v19 with
                            | US27_0(v20) -> (* Some *)
                                US27_0(v20)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v33 : US34 =
                        match v25 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v26) -> (* Some *)
                            let v27 : std_string_String = v26.l0
                            let v28 : string = "fable_library_rust::String_::fromString($0)"
                            let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
                            US34_0(v29)
                    US33_0(v33)
            US32_0(v38)
    let v43 : string = $"%A{struct (v3, v4, v5, v6, v7)}"
    let v44 : int64 = 400L
    let v45 : string = method64(v44, v43)
    let v46 : string = $"%A{v42}"
    let v47 : int64 = 400L
    let v48 : string = method64(v47, v46)
    let v49 : string = "state_core.use_request (15) / result memo / request: " + string v45 + " / state_data: " + string v48 + ""
    let v50 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v51 : bool = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = $"%A{v1}"
    let v53 : int64 = 400L
    let v54 : string = method64(v53, v52)
    let v55 : string = "state_core.use_request (16) / effect / json: " + string v54 + ""
    let v56 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v57 : bool = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v78 : US34 =
        match v1 with
        | US42_1(v75) -> (* Error *)
            US34_1
        | US42_0(v58) -> (* Ok *)
            let v59 : (int32 -> ((US34 []) -> US34 option)) = Array.tryItem
            let v60 : ((US34 []) -> US34 option) = v59 v2
            let v61 : US34 option = v60 v58
            let v62 : US43 option = None
            let _v62 = ref v62 
            match v61 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v63 : US34 = x
            let v64 : US43 = US43_0(v63)
            v64 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v62.Value <- x
            let v65 : US43 option = _v62.Value 
            let v66 : US43 = US43_1
            let v67 : US43 = v65 |> Option.defaultValue v66 
            match v67 with
            | US43_0(v68) -> (* Some *)
                match v68 with
                | US34_0(v69) -> (* Some *)
                    US34_0(v69)
                | _ ->
                    US34_1
            | _ ->
                US34_1
    match v78 with
    | US34_0(v79) -> (* Some *)
        let v80 : string = method33(v79)
        let v81 : string = "&*$0"
        let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v81
        let v83 : string = "serde_json::from_str(&v82)"
        let v84 : Result<crate_model_near_nearblocks_Root, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : (serde_json_Error -> std_string_String) = method34()
        let v86 : string = "$0.map_err(|x| $1(x))"
        let v87 : Result<crate_model_near_nearblocks_Root, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v86
        let v88 : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) = method96()
        let v89 : Result<crate_model_near_nearblocks_Root, std_string_String> = method97(v87)
        let v90 : string = "v89.map(|x| v88(x))"
        let v91 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v90
        v91
    | _ ->
        match v42 with
        | US32_0(v92) -> (* Some *)
            match v92 with
            | US33_0(v93) -> (* Ok *)
                match v93 with
                | US34_0(v94) -> (* Some *)
                    let v95 : string = method33(v94)
                    let v96 : string = "&*$0"
                    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v95 v96
                    let v98 : string = "serde_json::from_str(&v97)"
                    let v99 : Result<crate_model_near_nearblocks_Root, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v98
                    let v100 : (serde_json_Error -> std_string_String) = method34()
                    let v101 : string = "$0.map_err(|x| $1(x))"
                    let v102 : Result<crate_model_near_nearblocks_Root, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v101
                    let v103 : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) = method96()
                    let v104 : Result<crate_model_near_nearblocks_Root, std_string_String> = method97(v102)
                    let v105 : string = "v104.map(|x| v103(x))"
                    let v106 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v105
                    v106
                | _ ->
                    let v107 : string = $"%A{struct (v78, v42)}"
                    let v108 : string = "state_core.use_request (17) / json Error / value: " + string v107 + ""
                    let v109 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                    let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109
                    let v111 : crate_model_near_nearblocks_Root option = None
                    let v112 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v111
                    v112
            | _ ->
                let v114 : string = $"%A{struct (v78, v42)}"
                let v115 : string = "state_core.use_request (17) / json Error / value: " + string v114 + ""
                let v116 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v117 : bool = Fable.Core.RustInterop.emitRustExpr v115 v116
                let v118 : crate_model_near_nearblocks_Root option = None
                let v119 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v118
                v119
        | _ ->
            let v121 : string = $"%A{struct (v78, v42)}"
            let v122 : string = "state_core.use_request (17) / json Error / value: " + string v121 + ""
            let v123 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v124 : bool = Fable.Core.RustInterop.emitRustExpr v122 v123
            let v125 : crate_model_near_nearblocks_Root option = None
            let v126 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v125
            v126
and closure85 (v0 : US29, v1 : US42) (v2 : int32) : (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_nearblocks_Root option, std_string_String>) =
    closure86(v0, v1, v2)
and method95 (v0 : US29, v1 : US42) : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_nearblocks_Root option, std_string_String>)) =
    closure85(v0, v1)
and closure80 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>, v2 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>>, v3 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) () : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) =
    let v4 : string = $"$0()"
    let v5 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v4
    let v6 : string = $"%A{v5}"
    let v7 : string = "state_core.use_requests (13) / result memo / requests: " + string v6 + ""
    let v8 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = $"$0()"
    let v11 : Result<(Heap4 option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v10
    let v12 : US28 option = None
    let _v12 = ref v12 
    match v11 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v13 : Result<(Heap4 option []), std_string_String> = x
    let v14 : US28 = US28_0(v13)
    v14 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v12.Value <- x
    let v15 : US28 option = _v12.Value 
    let v16 : US28 = US28_1
    let v17 : US28 = v15 |> Option.defaultValue v16 
    let v38 : US29 =
        match v17 with
        | US28_1 -> (* None *)
            US29_1
        | US28_0(v18) -> (* Some *)
            let v19 : ((Heap4 option []) -> US31) = closure71()
            let v20 : (std_string_String -> US31) = closure72()
            let v21 : US31 = match v18 with Ok x -> v19 x | Error x -> v20 x
            let v34 : US30 =
                match v21 with
                | US31_1(v31) -> (* Error *)
                    US30_1(v31)
                | US31_0(v22) -> (* Ok *)
                    let v23 : string = "$0.to_vec()"
                    let v24 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v22 v23
                    let v25 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v26 : (Heap4 option -> US27) = closure73()
                    let v27 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v24, v26) v25
                    let v28 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v29 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v27 v28
                    US30_0(v29)
            US29_0(v34)
    let v39 : string = $"%A{v38}"
    let v40 : int64 = 400L
    let v41 : string = method64(v40, v39)
    let v42 : string = "state_core.use_request (14) / result_memo / state_data: " + string v41 + ""
    let v43 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v44 : bool = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = $"leptos::SignalGet::get(&$0)"
    let v46 : Result<(string option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v45
    let v47 : US38 option = None
    let _v47 = ref v47 
    match v46 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v48 : Result<(string option []), std_string_String> = x
    let v49 : US38 = US38_0(v48)
    v49 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v47.Value <- x
    let v50 : US38 option = _v47.Value 
    let v51 : US38 = US38_1
    let v52 : US38 = v50 |> Option.defaultValue v51 
    let v60 : US39 =
        match v52 with
        | US38_1 -> (* None *)
            US39_1
        | US38_0(v53) -> (* Some *)
            let v54 : ((string option []) -> US40) = closure81()
            let v55 : (std_string_String -> US40) = closure82()
            let v56 : US40 = match v53 with Ok x -> v54 x | Error x -> v55 x
            US39_0(v56)
    let v78 : US41 =
        match v60 with
        | US39_1 -> (* None *)
            US41_1
        | US39_0(v61) -> (* Some *)
            let v74 : US42 =
                match v61 with
                | US40_1(v71) -> (* Error *)
                    US42_1(v71)
                | US40_0(v62) -> (* Ok *)
                    let v63 : string = "$0.to_vec()"
                    let v64 : Vec<string option> = Fable.Core.RustInterop.emitRustExpr v62 v63
                    let v65 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v66 : (string option -> US34) = closure83()
                    let v67 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr struct (v64, v66) v65
                    let v68 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v69 : (US34 []) = Fable.Core.RustInterop.emitRustExpr v67 v68
                    US42_0(v69)
            US41_0(v74)
    let v79 : (US34 []) = [||]
    let v83 : US42 =
        match v78 with
        | US41_1 -> (* None *)
            US42_0(v79)
        | US41_0(v80) -> (* Some *)
            v80
    match v83 with
    | US42_1(v90) -> (* Error *)
        ()
    | US42_0(v84) -> (* Ok *)
        let v85 : string = "$0.to_vec()"
        let v86 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr v84 v85
        let v87 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
        let v88 : (US34 -> unit) = closure84(v3)
        let v89 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr struct (v86, v88) v87
        ()
    let v91 : string = "$0.to_vec()"
    let v92 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v5 v91
    let v93 : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_nearblocks_Root option, std_string_String>)) = method95(v38, v83)
    let v94 : Vec<struct (bool * string * bool * US25 * string)> = method86(v92)
    let v95 : string = "v94.iter().enumerate().map(|(i, x)| v93(i.try_into().unwrap())(x.clone())).collect()"
    let v96 : Vec<Result<crate_model_near_nearblocks_Root option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v95
    let v97 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v98 : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v96 v97
    let v99 : string = $"%A{v98}"
    let v100 : string = "state_core.use_requests (18) / result_func func0 / result: " + string v99 + ""
    let v101 : int32 = v100.Length
    let v102 : bool = v101 <= 200
    let v105 : string =
        if v102 then
            v100
        else
            let v103 : string = v100.[int 0..int 199]
            let v104 : string = v103 + "..."
            v104
    let v106 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v107 : bool = Fable.Core.RustInterop.emitRustExpr v105 v106
    v98
and closure89 () (v0 : Vec<Heap4 option>) : US45 =
    US45_0(v0)
and closure90 () (v0 : std_string_String) : US45 =
    US45_1(v0)
and closure92 (v0 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []))) (v1 : crate_model_near_nearblocks_Root option) : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option =
    let v2 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option = None
    let _v2 = ref v2 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v3 : crate_model_near_nearblocks_Root = x
    let v4 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = v0 v3
    v4 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v2.Value <- x
    let v5 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option = _v2.Value 
    v5
and method98 (v0 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []))) : (crate_model_near_nearblocks_Root option -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option) =
    closure92(v0)
and method99 (v0 : Result<crate_model_near_nearblocks_Root option, std_string_String>) : Result<crate_model_near_nearblocks_Root option, std_string_String> =
    v0
and closure91 (v0 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []))) (v1 : Result<crate_model_near_nearblocks_Root option, std_string_String>) : Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> =
    let v2 : (crate_model_near_nearblocks_Root option -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option) = method98(v0)
    let v3 : Result<crate_model_near_nearblocks_Root option, std_string_String> = method99(v1)
    let v4 : string = "v3.map(|x| v2(x))"
    let v5 : Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure88 (v0 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])), v1 : leptos_Resource<US2, rexie_Rexie>, v2 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>>, v3 : leptos_Memo<(Result<crate_model_near_nearblocks_Root option, std_string_String> [])>) () : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> []) =
    let v4 : string = $"leptos::Resource::loading(&$0)"
    let v5 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : string = $"leptos::SignalGet::get(&$0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = $"leptos::Resource::loading(&$0)"
    let v9 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v2 v8
    let v10 : string = $"leptos::SignalGet::get(&$0)"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = $"leptos::SignalGet::get(&$0)"
    let v13 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v12
    let v14 : US5 option = None
    let _v14 = ref v14 
    match v13 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v15 : rexie_Rexie = x
    let v16 : US5 = US5_0(v15)
    v16 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v14.Value <- x
    let v17 : US5 option = _v14.Value 
    let v18 : US5 = US5_1
    let v19 : US5 = v17 |> Option.defaultValue v18 
    let v20 : string = $"leptos::SignalGet::get(&$0)"
    let v21 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v20
    let v22 : US44 option = None
    let _v22 = ref v22 
    match v21 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : Result<Vec<Heap4 option>, std_string_String> = x
    let v24 : US44 = US44_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US44 option = _v22.Value 
    let v26 : US44 = US44_1
    let v27 : US44 = v25 |> Option.defaultValue v26 
    let v46 : US29 =
        match v27 with
        | US44_1 -> (* None *)
            US29_1
        | US44_0(v28) -> (* Some *)
            let v29 : (Vec<Heap4 option> -> US45) = closure89()
            let v30 : (std_string_String -> US45) = closure90()
            let v31 : US45 = match v28 with Ok x -> v29 x | Error x -> v30 x
            let v42 : US30 =
                match v31 with
                | US45_1(v39) -> (* Error *)
                    US30_1(v39)
                | US45_0(v32) -> (* Ok *)
                    let v33 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v34 : (Heap4 option -> US27) = closure73()
                    let v35 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v32, v34) v33
                    let v36 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v37 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v35 v36
                    US30_0(v37)
            US29_0(v42)
    let v47 : string = $"%A{v19}"
    let v48 : int64 = 400L
    let v49 : string = method64(v48, v47)
    let v50 : string = $"%A{v46}"
    let v51 : int64 = 400L
    let v52 : string = method64(v51, v50)
    let v53 : string = "state_core.use_request (19) / result move / database: " + string v49 + " / database_loading: " + string v7 + " / state_data: " + string v52 + " / state_data_loading: " + string v11 + ""
    let v54 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v55 : bool = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = $"$0()"
    let v57 : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v3 v56
    let v58 : string = "$0.to_vec()"
    let v59 : Vec<Result<crate_model_near_nearblocks_Root option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v61 : (Result<crate_model_near_nearblocks_Root option, std_string_String> -> Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>) = closure91(v0)
    let v62 : Vec<Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v59, v61) v60
    let v63 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v64 : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : string = $"%A{v64}"
    let v66 : string = "state_core.use_requests (20) / result func0 / result: " + string v65 + ""
    let v67 : int32 = v66.Length
    let v68 : bool = v67 <= 200
    let v71 : string =
        if v68 then
            v66
        else
            let v69 : string = v66.[int 0..int 199]
            let v70 : string = v69 + "..."
            v70
    let v72 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v73 : bool = Fable.Core.RustInterop.emitRustExpr v71 v72
    v64
and method61 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []))) : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])> =
    let v2 : string = "state_core.use_requests (1)"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "state_core.use_database (1)"
    let v6 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : leptos_Resource<US2, rexie_Rexie> = method5()
    let v9 : string = "$0"
    let v10 : (unit -> rexie_Rexie option) = closure63(v8)
    let v11 : (unit -> rexie_Rexie option) = Fable.Core.RustInterop.emitRustExpr v10 v9
    let v12 : string = "leptos::create_memo(move |_| { v11(()) })"
    let v13 : leptos_Memo<rexie_Rexie option> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = method62(v0, v8)
    let v15 : string = "$0"
    let v16 : (unit -> Result<(Heap4 option []), std_string_String> option) = closure68(v14)
    let v17 : (unit -> Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v16 v15
    let v18 : string = "leptos::create_memo(move |_| { v17(()) })"
    let v19 : leptos_Memo<Result<(Heap4 option []), std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = method74(v0, v19)
    let v21 : string = "leptos::create_action(move |value: &std::sync::Arc<Heap4>| $0(value.clone()))"
    let v22 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure77(v0, v13)
    let v23 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v22 v21
    let v24 : string = "$0"
    let v25 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = closure80(v0, v19, v20, v23)
    let v26 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v25 v24
    let v27 : string = "leptos::create_memo(move |_| { v26(()) })"
    let v28 : leptos_Memo<(Result<crate_model_near_nearblocks_Root option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "$0"
    let v30 : (unit -> (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])) = closure88(v1, v8, v14, v28)
    let v31 : (unit -> (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v30 v29
    let v32 : string = "leptos::create_memo(move |_| { v31(()) })"
    let v33 : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v32
    v33
and closure95 () (v0 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option) : US46 =
    US46_0(v0)
and closure96 () (v0 : std_string_String) : US46 =
    US46_1(v0)
and closure94 () (v0 : Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>) : US46 =
    let v1 : ((struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option -> US46) = closure95()
    let v2 : (std_string_String -> US46) = closure96()
    let v3 : US46 = match v0 with Ok x -> v1 x | Error x -> v2 x
    v3
and closure97 () (v0 : US46) : US47 =
    match v0 with
    | US46_1(v9) -> (* Error *)
        US47_1(v9)
    | US46_0(v1) -> (* Ok *)
        let v2 : US48 option = None
        let _v2 = ref v2 
        match v1 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3 : (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = x
        let v4 : US48 = US48_0(v3)
        v4 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2.Value <- x
        let v5 : US48 option = _v2.Value 
        let v6 : US48 = US48_1
        let v7 : US48 = v5 |> Option.defaultValue v6 
        US47_0(v7)
and closure98 () (v0 : US47) : bool =
    match v0 with
    | US47_0(v1) -> (* Ok *)
        match v1 with
        | US48_1 -> (* None *)
            true
        | _ ->
            false
    | _ ->
        false
and method100 () : (US47 -> bool) =
    closure98()
and method101 (v0 : Vec<US47>) : Vec<US47> =
    v0
and closure101 () (v0 : (unativeint * struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String))) : struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) =
    let (a, b) = v0
    let v1 : unativeint = a
    let struct (v2 : (struct (std_string_String * std_string_String option) []), v3 : float, v4 : uint32, v5 : std_string_String, v6 : std_string_String, v7 : (std_string_String []), v8 : bool, v9 : float, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String) = b
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
and closure102 (v0 : int32, v1 : string) struct (v2 : unativeint, v3 : (struct (std_string_String * std_string_String option) []), v4 : float, v5 : uint32, v6 : std_string_String, v7 : std_string_String, v8 : (std_string_String []), v9 : bool, v10 : float, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String, v14 : std_string_String) : struct (string * unativeint * Heap5) =
    let v15 : unativeint = unativeint v0
    let v16 : Heap5 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v14} : Heap5
    struct (v1, v15, v16)
and closure100 (v0 : (string []), v1 : int32) (v2 : US47) : US51 =
    let v3 : string = v0.[int v1]
    match v2 with
    | US47_1(v29) -> (* Error *)
        US51_1(v29)
    | US47_0(v4) -> (* Ok *)
        let v27 : US52 =
            match v4 with
            | US48_1 -> (* None *)
                US52_1
            | US48_0(v5) -> (* Some *)
                let v6 : string = "$0.to_vec()"
                let v7 : Vec<struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr v5 v6
                let v8 : string = "v7.into_iter()"
                let v9 : _ = Fable.Core.RustInterop.emitRustExpr () v8
                let v10 : string = "v9.enumerate().map(std::sync::Arc::new)"
                let v11 : _ = Fable.Core.RustInterop.emitRustExpr () v10
                let v12 : string = "v11.collect()"
                let v13 : Vec<(unativeint * struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String))> = Fable.Core.RustInterop.emitRustExpr () v12
                let v14 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                let v15 : ((unativeint * struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)) -> struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)) = closure101()
                let v16 : Vec<struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14
                let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
                let v18 : (struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v16 v17
                let v19 : string = "$0.to_vec()"
                let v20 : Vec<struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr v18 v19
                let v21 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                let v22 : (struct (unativeint * (struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) -> struct (string * unativeint * Heap5)) = closure102(v1, v3)
                let v23 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr struct (v20, v22) v21
                US52_0(v23)
        US51_0(v27)
and closure99 (v0 : (string [])) (v1 : int32) : (US47 -> US51) =
    closure100(v0, v1)
and method102 (v0 : (string [])) : (int32 -> (US47 -> US51)) =
    closure99(v0)
and method103 (v0 : Vec<US47>) : Vec<US47> =
    v0
and closure103 () (v0 : US51) : US53 =
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
and closure104 () (v0 : US53) : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> =
    match v0 with
    | US53_1(v3) -> (* Error *)
        let v4 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = Error v3
        v4
    | US53_0(v1) -> (* Ok *)
        let v2 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = Ok v1
        v2
and method104 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure105 () (v0 : Vec<struct (string * unativeint * Heap5)> option) : US53 =
    US53_0(v0)
and closure106 () (v0 : std_string_String) : US53 =
    US53_1(v0)
and method105 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and method106 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and method107 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure107 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : std_string_String =
    let v3 : std_string_String = v2.l3
    v3
and method108 () : (struct (string * unativeint * Heap5) -> std_string_String) =
    closure107()
and method109 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure93 (v0 : leptos_Memo<(string [])>, v1 : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])>) () : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> =
    let v2 : string = $"$0()"
    let v3 : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v7 : (Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> -> US46) = closure94()
    let v8 : Vec<US46> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v10 : (US46 -> US47) = closure97()
    let v11 : Vec<US47> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9
    let v12 : string = $"%A{v11}"
    let v13 : int64 = 400L
    let v14 : string = method64(v13, v12)
    let v15 : string = "transactions.render (8) / txns move / root: " + string v14 + ""
    let v16 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : (US47 -> bool) = method100()
    let v19 : Vec<US47> = method101(v11)
    let v20 : string = "v19.into_iter().filter(|x| v18(x.clone().clone())).collect()"
    let v21 : Vec<US47> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (US47 []) = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : int32 = v23.Length
    let v25 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v26 : (US47 []) = Fable.Core.RustInterop.emitRustExpr v11 v25
    let v27 : int32 = v26.Length
    let v28 : bool = v24 = v27
    let v129 : US49 =
        if v28 then
            let v29 : US50 = US50_1
            US49_0(v29)
        else
            let v31 : string = $"$0()"
            let v32 : (string []) = Fable.Core.RustInterop.emitRustExpr v0 v31
            let v33 : (int32 -> (US47 -> US51)) = method102(v32)
            let v34 : Vec<US47> = method103(v11)
            let v35 : string = "v34.iter().enumerate().map(|(i, x)| v33(i.try_into().unwrap())(x.clone())).collect()"
            let v36 : Vec<US51> = Fable.Core.RustInterop.emitRustExpr () v35
            let v37 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
            let v38 : (US51 -> US53) = closure103()
            let v39 : Vec<US53> = Fable.Core.RustInterop.emitRustExpr struct (v36, v38) v37
            let v40 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
            let v41 : (US53 -> Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String>) = closure104()
            let v42 : Vec<Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v39, v41) v40
            let v43 : (struct (string * unativeint * Heap5) []) = [||]
            let v44 : string = "$0.to_vec()"
            let v45 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v43 v44
            let v46 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v47 : (Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v42 v46
            let v48 : int32 = v47.Length
            let v49 : US54 = US54_0(v45)
            let v50 : Mut4 = {l0 = 0; l1 = v49} : Mut4
            while method104(v48, v50) do
                let v52 : int32 = v50.l0
                let v53 : US54 = v50.l1
                let v54 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = v47.[int v52]
                let v55 : (Vec<struct (string * unativeint * Heap5)> option -> US53) = closure105()
                let v56 : (std_string_String -> US53) = closure106()
                let v57 : US53 = match v54 with Ok x -> v55 x | Error x -> v56 x
                let v69 : US51 =
                    match v57 with
                    | US53_1(v66) -> (* Error *)
                        US51_1(v66)
                    | US53_0(v58) -> (* Ok *)
                        let v59 : US52 option = None
                        let _v59 = ref v59 
                        match v58 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v60 : Vec<struct (string * unativeint * Heap5)> = x
                        let v61 : US52 = US52_0(v60)
                        v61 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v59.Value <- x
                        let v62 : US52 option = _v59.Value 
                        let v63 : US52 = US52_1
                        let v64 : US52 = v62 |> Option.defaultValue v63 
                        US51_0(v64)
                let v90 : US54 =
                    match v53 with
                    | US54_0(v70) -> (* Ok *)
                        match v69 with
                        | US51_1(v83) -> (* Error *)
                            US54_1(v83)
                        | US51_0(v71) -> (* Ok *)
                            match v71 with
                            | US52_0(v72) -> (* Some *)
                                let v73 : Vec<struct (string * unativeint * Heap5)> = method105(v72)
                                let v74 : Vec<struct (string * unativeint * Heap5)> = method106(v70)
                                let v75 : string = "true; let mut v74 = v74"
                                let v76 : bool = Fable.Core.RustInterop.emitRustExpr () v75
                                let v77 : string = "true; v74.extend(v73)"
                                let v78 : bool = Fable.Core.RustInterop.emitRustExpr () v77
                                let v79 : string = "v74"
                                let v80 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v79
                                US54_0(v80)
                            | _ ->
                                v53
                    | _ ->
                        match v69 with
                        | US51_1(v87) -> (* Error *)
                            US54_1(v87)
                        | _ ->
                            v53
                let v91 : int32 = v52 + 1
                v50.l0 <- v91
                v50.l1 <- v90
                ()
            let v92 : US54 = v50.l1
            let v106 : US54 =
                match v92 with
                | US54_1(v103) -> (* Error *)
                    US54_1(v103)
                | US54_0(v93) -> (* Ok *)
                    let v94 : Vec<struct (string * unativeint * Heap5)> = method107(v93)
                    let v95 : (struct (string * unativeint * Heap5) -> std_string_String) = method108()
                    let v96 : string = "true; let mut v94 = v94"
                    let v97 : bool = Fable.Core.RustInterop.emitRustExpr () v96
                    let v98 : string = "true; v94.sort_by_key(|x| v95(x.clone()))"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr () v98
                    let v100 : string = "v94"
                    let v101 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v100
                    US54_0(v101)
            let v121 : US55 =
                match v106 with
                | US54_1(v118) -> (* Error *)
                    US55_1(v118)
                | US54_0(v107) -> (* Ok *)
                    let v108 : Vec<struct (string * unativeint * Heap5)> = method109(v107)
                    let v109 : string = "true; let mut v108 = v108"
                    let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109
                    let v111 : string = "true; v108.reverse()"
                    let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111
                    let v113 : string = "v108"
                    let v114 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v113
                    let v115 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v116 : (struct (string * unativeint * Heap5) []) = Fable.Core.RustInterop.emitRustExpr v114 v115
                    US55_0(v116)
            match v121 with
            | US55_1(v125) -> (* Error *)
                US49_1(v125)
            | US55_0(v122) -> (* Ok *)
                let v123 : US50 = US50_0(v122)
                US49_0(v123)
    let v140 : US56 =
        match v129 with
        | US49_1(v137) -> (* Error *)
            US56_1(v137)
        | US49_0(v130) -> (* Ok *)
            let v135 : (struct (string * unativeint * Heap5) []) option =
                match v130 with
                | US50_1 -> (* None *)
                    let v133 : (struct (string * unativeint * Heap5) []) option = None
                    v133
                | US50_0(v131) -> (* Some *)
                    let v132 : (struct (string * unativeint * Heap5) []) option = Some v131 
                    v132
            US56_0(v135)
    let v146 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> =
        match v140 with
        | US56_1(v143) -> (* Error *)
            let v144 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Error v143
            v144
        | US56_0(v141) -> (* Ok *)
            let v142 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Ok v141
            v142
    let v147 : string = $"%A{v146}"
    let v148 : string = "use_transactions.render (9) / txns create_memo / result: " + string v147 + " / loading: " + string v28 + ""
    let v149 : int32 = v148.Length
    let v150 : bool = v149 <= 200
    let v153 : string =
        if v150 then
            v148
        else
            let v151 : string = v148.[int 0..int 199]
            let v152 : string = v151 + "..."
            v152
    let v154 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v155 : bool = Fable.Core.RustInterop.emitRustExpr v153 v154
    v146
and closure109 () (v0 : (struct (string * unativeint * Heap5) []) option) : US56 =
    US56_0(v0)
and closure110 () (v0 : std_string_String) : US56 =
    US56_1(v0)
and closure112 () (v0 : serde_json_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method110 () : (serde_json_Error -> std_string_String) =
    closure112()
and method111 () : (std_string_String -> string) =
    closure49()
and method112 (v0 : Result<std_string_String, std_string_String>) : Result<std_string_String, std_string_String> =
    v0
and closure113 () (v0 : string) : struct (bool * string * bool * US25 * string) =
    let v1 : US25 = US25_1
    let v2 : string = "https://rpc.mainnet.near.org"
    struct (false, v0, true, v1, v2)
and method113 () : (string -> struct (bool * string * bool * US25 * string)) =
    closure113()
and method114 (v0 : Result<string, std_string_String>) : Result<string, std_string_String> =
    v0
and closure111 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : Result<struct (bool * string * bool * US25 * string), std_string_String> =
    let v3 : string = "&*$0"
    let v4 : string = "2.0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v3
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "&*$0"
    let v9 : string = "dontcare"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "&*$0"
    let v14 : string = "EXPERIMENTAL_tx_status"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v13
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : std_string_String = v2.l11
    let v19 : string = "&*$0"
    let v20 : string = "bowen"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v20 v19
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (std_string_String []) = [|v18; v23|]
    let v25 : string = "$0.to_vec()"
    let v26 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "crate::model::near::rpc::RpcInput { jsonrpc: v7, id: v12, method: v17, params: v26 }"
    let v28 : crate_model_near_rpc_RpcInput = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "serde_json::to_string(&v28)"
    let v30 : Result<std_string_String, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : (serde_json_Error -> std_string_String) = method110()
    let v32 : string = "$0.map_err(|x| $1(x))"
    let v33 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v30, v31) v32
    let v34 : (std_string_String -> string) = method111()
    let v35 : Result<std_string_String, std_string_String> = method112(v33)
    let v36 : string = "v35.map(|x| v34(x))"
    let v37 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : (string -> struct (bool * string * bool * US25 * string)) = method113()
    let v39 : Result<string, std_string_String> = method114(v37)
    let v40 : string = "v39.map(|x| v38(x))"
    let v41 : Result<struct (bool * string * bool * US25 * string), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v40
    v41
and closure108 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure109()
    let v4 : (std_string_String -> US56) = closure110()
    let v5 : US56 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v17 : US49 =
        match v5 with
        | US56_1(v14) -> (* Error *)
            US49_1(v14)
        | US56_0(v6) -> (* Ok *)
            let v7 : US50 option = None
            let _v7 = ref v7 
            match v6 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v8 : (struct (string * unativeint * Heap5) []) = x
            let v9 : US50 = US50_0(v8)
            v9 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v7.Value <- x
            let v10 : US50 option = _v7.Value 
            let v11 : US50 = US50_1
            let v12 : US50 = v10 |> Option.defaultValue v11 
            US49_0(v12)
    let v39 : US57 =
        match v17 with
        | US49_1(v36) -> (* Error *)
            US57_1(v36)
        | US49_0(v18) -> (* Ok *)
            match v18 with
            | US50_0(v19) -> (* Some *)
                let v20 : string = "$0.to_vec()"
                let v21 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v19 v20
                let v22 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                let v23 : (struct (string * unativeint * Heap5) -> Result<struct (bool * string * bool * US25 * string), std_string_String>) = closure111()
                let v24 : Vec<Result<struct (bool * string * bool * US25 * string), std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v22
                let v25 : string = "v24.into_iter().collect()"
                let v26 : Result<Vec<struct (bool * string * bool * US25 * string)>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v25
                let v27 : string = "$0?"
                let v28 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v26 v27
                let v29 : string = "fable_library_rust::NativeArray_::array_from($0)"
                let v30 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v28 v29
                let v31 : US58 = US58_0(v30)
                US57_0(v31)
            | _ ->
                let v33 : US58 = US58_1
                US57_0(v33)
    let v50 : US59 =
        match v39 with
        | US57_1(v47) -> (* Error *)
            US59_1(v47)
        | US57_0(v40) -> (* Ok *)
            let v45 : (struct (bool * string * bool * US25 * string) []) option =
                match v40 with
                | US58_1 -> (* None *)
                    let v43 : (struct (bool * string * bool * US25 * string) []) option = None
                    v43
                | US58_0(v41) -> (* Some *)
                    let v42 : (struct (bool * string * bool * US25 * string) []) option = Some v41 
                    v42
            US59_0(v45)
    let v56 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> =
        match v50 with
        | US59_1(v53) -> (* Error *)
            let v54 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> = Error v53
            v54
        | US59_0(v51) -> (* Ok *)
            let v52 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> = Ok v51
            v52
    let v57 : string = $"%A{v56}"
    let v58 : string = "use_transactions.render (10) / rpc_requests create_memo / result: " + string v57 + ""
    let v59 : int32 = v58.Length
    let v60 : bool = v59 <= 200
    let v63 : string =
        if v60 then
            v58
        else
            let v61 : string = v58.[int 0..int 199]
            let v62 : string = v61 + "..."
            v62
    let v64 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v65 : bool = Fable.Core.RustInterop.emitRustExpr v63 v64
    v56
and closure115 () (v0 : (struct (bool * string * bool * US25 * string) []) option) : US59 =
    US59_0(v0)
and closure116 () (v0 : std_string_String) : US59 =
    US59_1(v0)
and closure114 (v0 : leptos_Memo<Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>>) () : (struct (bool * string * bool * US25 * string) []) =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : ((struct (bool * string * bool * US25 * string) []) option -> US59) = closure115()
    let v4 : (std_string_String -> US59) = closure116()
    let v5 : US59 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v17 : US57 =
        match v5 with
        | US59_1(v14) -> (* Error *)
            US57_1(v14)
        | US59_0(v6) -> (* Ok *)
            let v7 : US58 option = None
            let _v7 = ref v7 
            match v6 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v8 : (struct (bool * string * bool * US25 * string) []) = x
            let v9 : US58 = US58_0(v8)
            v9 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v7.Value <- x
            let v10 : US58 option = _v7.Value 
            let v11 : US58 = US58_1
            let v12 : US58 = v10 |> Option.defaultValue v11 
            US57_0(v12)
    let v23 : (struct (bool * string * bool * US25 * string) []) =
        match v17 with
        | US57_0(v18) -> (* Ok *)
            match v18 with
            | US58_0(v19) -> (* Some *)
                v19
            | _ ->
                [||]
        | _ ->
            [||]
    let v24 : string = $"%A{v23}"
    let v25 : string = "use_transactions.render (11) / rpc_requests' create_memo / result: " + string v24 + ""
    let v26 : int32 = v25.Length
    let v27 : bool = v26 <= 200
    let v30 : string =
        if v27 then
            v25
        else
            let v28 : string = v25.[int 0..int 199]
            let v29 : string = v28 + "..."
            v29
    let v31 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v30 v31
    v23
and closure121 () (v0 : crate_model_near_rpc_TransferDetail) : struct (std_string_String option * std_string_String * float option * std_string_String option) =
    let v1 : string = "$0.deposit"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.args"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.gas"
    let v6 : float option = Fable.Core.RustInterop.emitRustExpr v0 v5
    let v7 : string = "$0.method_name"
    let v8 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v7
    struct (v4, v2, v6, v8)
and closure120 () (v0 : std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail>) : std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> =
    let v1 : string = "$0.into_iter().map(|(k, v)| (k, $1(v))).collect()"
    let v2 : (crate_model_near_rpc_TransferDetail -> struct (std_string_String option * std_string_String * float option * std_string_String option)) = closure121()
    let v3 : std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1
    v3
and closure119 () (v0 : crate_model_near_rpc_Receipt) : struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.predecessor_id"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.receipt"
    let v4 : crate_model_near_rpc_ReceiptDetail = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.action"
    let v6 : crate_model_near_rpc_ActionDetail = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0.actions"
    let v8 : Vec<std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail>> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v10 : (std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail> -> std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)>) = closure120()
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
and closure123 () (v0 : crate_model_near_rpc_GasProfile) : struct (std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.cost"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.cost_category"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.gas_used"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    struct (v2, v4, v6)
and closure125 () (v0 : crate_model_near_rpc_Proof) : struct (std_string_String * std_string_String) =
    let v1 : string = "$0.direction"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.hash"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    struct (v2, v4)
and closure124 () (v0 : Vec<crate_model_near_rpc_Proof>) : (struct (std_string_String * std_string_String) []) =
    let v1 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v2 : (crate_model_near_rpc_Proof -> struct (std_string_String * std_string_String)) = closure125()
    let v3 : Vec<struct (std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1
    let v4 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v5 : (struct (std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure122 () (v0 : crate_model_near_rpc_ReceiptsOutcome) : struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) =
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
    let v19 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v20 : (crate_model_near_rpc_GasProfile -> struct (std_string_String * std_string_String * std_string_String)) = closure123()
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
    let v36 : (Vec<crate_model_near_rpc_Proof> -> (struct (std_string_String * std_string_String) [])) = closure124()
    let v37 : (struct (std_string_String * std_string_String) []) option = v35 |> Option.map v36 
    let v38 : (struct (std_string_String * std_string_String) []) = [||]
    let v39 : (struct (std_string_String * std_string_String) []) = v37 |> Option.defaultValue v38 
    struct (v2, v4, v8, v10, v14, v23, v25, v29, v31, v33, v39)
and closure118 () (v0 : crate_model_near_rpc_TransactionStatus) : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) =
    let v1 : string = "$0.receipts"
    let v2 : Vec<crate_model_near_rpc_Receipt> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v4 : (crate_model_near_rpc_Receipt -> struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String)) = closure119()
    let v5 : Vec<struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "$0.receipts_outcome"
    let v9 : Vec<crate_model_near_rpc_ReceiptsOutcome> = Fable.Core.RustInterop.emitRustExpr v0 v8
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v11 : (crate_model_near_rpc_ReceiptsOutcome -> struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []))) = closure122()
    let v12 : Vec<struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []))> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) []) = Fable.Core.RustInterop.emitRustExpr v12 v13
    struct (v7, v14)
and closure127 () (v0 : crate_model_near_rpc_ErrorCauseInfo) : struct (std_string_String option * std_string_String option) =
    let v1 : string = "$0.error_message"
    let v2 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.requested_transaction_hash"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3
    struct (v2, v4)
and closure126 () (v0 : crate_model_near_rpc_RpcError) : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.name"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.cause"
    let v4 : crate_model_near_rpc_ErrorCause = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "$0.name"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0.info"
    let v8 : crate_model_near_rpc_ErrorCauseInfo option = Fable.Core.RustInterop.emitRustExpr v4 v7
    let v9 : (crate_model_near_rpc_ErrorCauseInfo -> struct (std_string_String option * std_string_String option)) = closure127()
    let v10 : struct (std_string_String option * std_string_String option) option = v8 |> Option.map v9 
    let v11 : string = "$0.code"
    let v12 : int32 = Fable.Core.RustInterop.emitRustExpr v0 v11
    let v13 : string = "$0.message"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v13
    let v15 : string = "$0.data"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v15
    struct (v10, v6, v12, v16, v14, v2)
and closure117 () (v0 : crate_model_near_rpc_RpcResponse) : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) =
    let v1 : string = "$0.jsonrpc"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.result"
    let v4 : crate_model_near_rpc_TransactionStatus option = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : (crate_model_near_rpc_TransactionStatus -> struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) []))) = closure118()
    let v6 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option = v4 |> Option.map v5 
    let v7 : string = "$0.error"
    let v8 : crate_model_near_rpc_RpcError option = Fable.Core.RustInterop.emitRustExpr v0 v7
    let v9 : (crate_model_near_rpc_RpcError -> struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String)) = closure126()
    let v10 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option = v8 |> Option.map v9 
    let v11 : string = "$0.id"
    let v12 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v11
    struct (v10, v12, v2, v6)
and closure131 () (v0 : crate_model_near_rpc_RpcResponse) : crate_model_near_rpc_RpcResponse option =
    let v1 : crate_model_near_rpc_RpcResponse option = Some v0 
    v1
and method117 () : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) =
    closure131()
and method118 (v0 : Result<crate_model_near_rpc_RpcResponse, std_string_String>) : Result<crate_model_near_rpc_RpcResponse, std_string_String> =
    v0
and closure130 (v0 : US29, v1 : US42, v2 : int32) struct (v3 : bool, v4 : string, v5 : bool, v6 : US25, v7 : string) : Result<crate_model_near_rpc_RpcResponse option, std_string_String> =
    let v42 : US32 =
        match v0 with
        | US29_1 -> (* None *)
            US32_1
        | US29_0(v8) -> (* Some *)
            let v38 : US33 =
                match v8 with
                | US30_1(v35) -> (* Error *)
                    US33_1(v35)
                | US30_0(v9) -> (* Ok *)
                    let v10 : (int32 -> ((US27 []) -> US27 option)) = Array.tryItem
                    let v11 : ((US27 []) -> US27 option) = v10 v2
                    let v12 : US27 option = v11 v9
                    let v13 : US35 option = None
                    let _v13 = ref v13 
                    match v12 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v14 : US27 = x
                    let v15 : US35 = US35_0(v14)
                    v15 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v13.Value <- x
                    let v16 : US35 option = _v13.Value 
                    let v17 : US35 = US35_1
                    let v18 : US35 = v16 |> Option.defaultValue v17 
                    let v25 : US27 =
                        match v18 with
                        | US35_0(v19) -> (* Some *)
                            match v19 with
                            | US27_0(v20) -> (* Some *)
                                US27_0(v20)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v33 : US34 =
                        match v25 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v26) -> (* Some *)
                            let v27 : std_string_String = v26.l0
                            let v28 : string = "fable_library_rust::String_::fromString($0)"
                            let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
                            US34_0(v29)
                    US33_0(v33)
            US32_0(v38)
    let v43 : string = $"%A{struct (v3, v4, v5, v6, v7)}"
    let v44 : int64 = 400L
    let v45 : string = method64(v44, v43)
    let v46 : string = $"%A{v42}"
    let v47 : int64 = 400L
    let v48 : string = method64(v47, v46)
    let v49 : string = "state_core.use_request (15) / result memo / request: " + string v45 + " / state_data: " + string v48 + ""
    let v50 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v51 : bool = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = $"%A{v1}"
    let v53 : int64 = 400L
    let v54 : string = method64(v53, v52)
    let v55 : string = "state_core.use_request (16) / effect / json: " + string v54 + ""
    let v56 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v57 : bool = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v78 : US34 =
        match v1 with
        | US42_1(v75) -> (* Error *)
            US34_1
        | US42_0(v58) -> (* Ok *)
            let v59 : (int32 -> ((US34 []) -> US34 option)) = Array.tryItem
            let v60 : ((US34 []) -> US34 option) = v59 v2
            let v61 : US34 option = v60 v58
            let v62 : US43 option = None
            let _v62 = ref v62 
            match v61 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v63 : US34 = x
            let v64 : US43 = US43_0(v63)
            v64 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v62.Value <- x
            let v65 : US43 option = _v62.Value 
            let v66 : US43 = US43_1
            let v67 : US43 = v65 |> Option.defaultValue v66 
            match v67 with
            | US43_0(v68) -> (* Some *)
                match v68 with
                | US34_0(v69) -> (* Some *)
                    US34_0(v69)
                | _ ->
                    US34_1
            | _ ->
                US34_1
    match v78 with
    | US34_0(v79) -> (* Some *)
        let v80 : string = method33(v79)
        let v81 : string = "&*$0"
        let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v81
        let v83 : string = "serde_json::from_str(&v82)"
        let v84 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : (serde_json_Error -> std_string_String) = method34()
        let v86 : string = "$0.map_err(|x| $1(x))"
        let v87 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v86
        let v88 : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) = method117()
        let v89 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = method118(v87)
        let v90 : string = "v89.map(|x| v88(x))"
        let v91 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v90
        v91
    | _ ->
        match v42 with
        | US32_0(v92) -> (* Some *)
            match v92 with
            | US33_0(v93) -> (* Ok *)
                match v93 with
                | US34_0(v94) -> (* Some *)
                    let v95 : string = method33(v94)
                    let v96 : string = "&*$0"
                    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v95 v96
                    let v98 : string = "serde_json::from_str(&v97)"
                    let v99 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v98
                    let v100 : (serde_json_Error -> std_string_String) = method34()
                    let v101 : string = "$0.map_err(|x| $1(x))"
                    let v102 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v101
                    let v103 : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) = method117()
                    let v104 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = method118(v102)
                    let v105 : string = "v104.map(|x| v103(x))"
                    let v106 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v105
                    v106
                | _ ->
                    let v107 : string = $"%A{struct (v78, v42)}"
                    let v108 : string = "state_core.use_request (17) / json Error / value: " + string v107 + ""
                    let v109 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                    let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109
                    let v111 : crate_model_near_rpc_RpcResponse option = None
                    let v112 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v111
                    v112
            | _ ->
                let v114 : string = $"%A{struct (v78, v42)}"
                let v115 : string = "state_core.use_request (17) / json Error / value: " + string v114 + ""
                let v116 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v117 : bool = Fable.Core.RustInterop.emitRustExpr v115 v116
                let v118 : crate_model_near_rpc_RpcResponse option = None
                let v119 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v118
                v119
        | _ ->
            let v121 : string = $"%A{struct (v78, v42)}"
            let v122 : string = "state_core.use_request (17) / json Error / value: " + string v121 + ""
            let v123 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v124 : bool = Fable.Core.RustInterop.emitRustExpr v122 v123
            let v125 : crate_model_near_rpc_RpcResponse option = None
            let v126 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v125
            v126
and closure129 (v0 : US29, v1 : US42) (v2 : int32) : (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>) =
    closure130(v0, v1, v2)
and method116 (v0 : US29, v1 : US42) : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>)) =
    closure129(v0, v1)
and closure128 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : leptos_Memo<Result<(Heap4 option []), std_string_String> option>, v2 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>>, v3 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) () : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) =
    let v4 : string = $"$0()"
    let v5 : (struct (bool * string * bool * US25 * string) []) = Fable.Core.RustInterop.emitRustExpr v0 v4
    let v6 : string = $"%A{v5}"
    let v7 : string = "state_core.use_requests (13) / result memo / requests: " + string v6 + ""
    let v8 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = $"$0()"
    let v11 : Result<(Heap4 option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v10
    let v12 : US28 option = None
    let _v12 = ref v12 
    match v11 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v13 : Result<(Heap4 option []), std_string_String> = x
    let v14 : US28 = US28_0(v13)
    v14 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v12.Value <- x
    let v15 : US28 option = _v12.Value 
    let v16 : US28 = US28_1
    let v17 : US28 = v15 |> Option.defaultValue v16 
    let v38 : US29 =
        match v17 with
        | US28_1 -> (* None *)
            US29_1
        | US28_0(v18) -> (* Some *)
            let v19 : ((Heap4 option []) -> US31) = closure71()
            let v20 : (std_string_String -> US31) = closure72()
            let v21 : US31 = match v18 with Ok x -> v19 x | Error x -> v20 x
            let v34 : US30 =
                match v21 with
                | US31_1(v31) -> (* Error *)
                    US30_1(v31)
                | US31_0(v22) -> (* Ok *)
                    let v23 : string = "$0.to_vec()"
                    let v24 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v22 v23
                    let v25 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v26 : (Heap4 option -> US27) = closure73()
                    let v27 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v24, v26) v25
                    let v28 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v29 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v27 v28
                    US30_0(v29)
            US29_0(v34)
    let v39 : string = $"%A{v38}"
    let v40 : int64 = 400L
    let v41 : string = method64(v40, v39)
    let v42 : string = "state_core.use_request (14) / result_memo / state_data: " + string v41 + ""
    let v43 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v44 : bool = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = $"leptos::SignalGet::get(&$0)"
    let v46 : Result<(string option []), std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v45
    let v47 : US38 option = None
    let _v47 = ref v47 
    match v46 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v48 : Result<(string option []), std_string_String> = x
    let v49 : US38 = US38_0(v48)
    v49 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v47.Value <- x
    let v50 : US38 option = _v47.Value 
    let v51 : US38 = US38_1
    let v52 : US38 = v50 |> Option.defaultValue v51 
    let v60 : US39 =
        match v52 with
        | US38_1 -> (* None *)
            US39_1
        | US38_0(v53) -> (* Some *)
            let v54 : ((string option []) -> US40) = closure81()
            let v55 : (std_string_String -> US40) = closure82()
            let v56 : US40 = match v53 with Ok x -> v54 x | Error x -> v55 x
            US39_0(v56)
    let v78 : US41 =
        match v60 with
        | US39_1 -> (* None *)
            US41_1
        | US39_0(v61) -> (* Some *)
            let v74 : US42 =
                match v61 with
                | US40_1(v71) -> (* Error *)
                    US42_1(v71)
                | US40_0(v62) -> (* Ok *)
                    let v63 : string = "$0.to_vec()"
                    let v64 : Vec<string option> = Fable.Core.RustInterop.emitRustExpr v62 v63
                    let v65 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v66 : (string option -> US34) = closure83()
                    let v67 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr struct (v64, v66) v65
                    let v68 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v69 : (US34 []) = Fable.Core.RustInterop.emitRustExpr v67 v68
                    US42_0(v69)
            US41_0(v74)
    let v79 : (US34 []) = [||]
    let v83 : US42 =
        match v78 with
        | US41_1 -> (* None *)
            US42_0(v79)
        | US41_0(v80) -> (* Some *)
            v80
    match v83 with
    | US42_1(v90) -> (* Error *)
        ()
    | US42_0(v84) -> (* Ok *)
        let v85 : string = "$0.to_vec()"
        let v86 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr v84 v85
        let v87 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
        let v88 : (US34 -> unit) = closure84(v3)
        let v89 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr struct (v86, v88) v87
        ()
    let v91 : string = "$0.to_vec()"
    let v92 : Vec<struct (bool * string * bool * US25 * string)> = Fable.Core.RustInterop.emitRustExpr v5 v91
    let v93 : (int32 -> (struct (bool * string * bool * US25 * string) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>)) = method116(v38, v83)
    let v94 : Vec<struct (bool * string * bool * US25 * string)> = method86(v92)
    let v95 : string = "v94.iter().enumerate().map(|(i, x)| v93(i.try_into().unwrap())(x.clone())).collect()"
    let v96 : Vec<Result<crate_model_near_rpc_RpcResponse option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v95
    let v97 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v98 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v96 v97
    let v99 : string = $"%A{v98}"
    let v100 : string = "state_core.use_requests (18) / result_func func0 / result: " + string v99 + ""
    let v101 : int32 = v100.Length
    let v102 : bool = v101 <= 200
    let v105 : string =
        if v102 then
            v100
        else
            let v103 : string = v100.[int 0..int 199]
            let v104 : string = v103 + "..."
            v104
    let v106 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v107 : bool = Fable.Core.RustInterop.emitRustExpr v105 v106
    v98
and closure134 (v0 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option))) (v1 : crate_model_near_rpc_RpcResponse option) : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option =
    let v2 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option = None
    let _v2 = ref v2 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v3 : crate_model_near_rpc_RpcResponse = x
    let struct (v4 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option, v5 : std_string_String option, v6 : std_string_String, v7 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) = v0 v3
    struct (v4, v5, v6, v7) 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v2.Value <- x
    let v8 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option = _v2.Value 
    v8
and method119 (v0 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option))) : (crate_model_near_rpc_RpcResponse option -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option) =
    closure134(v0)
and method120 (v0 : Result<crate_model_near_rpc_RpcResponse option, std_string_String>) : Result<crate_model_near_rpc_RpcResponse option, std_string_String> =
    v0
and closure133 (v0 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option))) (v1 : Result<crate_model_near_rpc_RpcResponse option, std_string_String>) : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> =
    let v2 : (crate_model_near_rpc_RpcResponse option -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option) = method119(v0)
    let v3 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = method120(v1)
    let v4 : string = "v3.map(|x| v2(x))"
    let v5 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure132 (v0 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option)), v1 : leptos_Resource<US2, rexie_Rexie>, v2 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>>, v3 : leptos_Memo<(Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])>) () : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> []) =
    let v4 : string = $"leptos::Resource::loading(&$0)"
    let v5 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : string = $"leptos::SignalGet::get(&$0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = $"leptos::Resource::loading(&$0)"
    let v9 : leptos_Signal<bool> = Fable.Core.RustInterop.emitRustExpr v2 v8
    let v10 : string = $"leptos::SignalGet::get(&$0)"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = $"leptos::SignalGet::get(&$0)"
    let v13 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v12
    let v14 : US5 option = None
    let _v14 = ref v14 
    match v13 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v15 : rexie_Rexie = x
    let v16 : US5 = US5_0(v15)
    v16 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v14.Value <- x
    let v17 : US5 option = _v14.Value 
    let v18 : US5 = US5_1
    let v19 : US5 = v17 |> Option.defaultValue v18 
    let v20 : string = $"leptos::SignalGet::get(&$0)"
    let v21 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v20
    let v22 : US44 option = None
    let _v22 = ref v22 
    match v21 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : Result<Vec<Heap4 option>, std_string_String> = x
    let v24 : US44 = US44_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US44 option = _v22.Value 
    let v26 : US44 = US44_1
    let v27 : US44 = v25 |> Option.defaultValue v26 
    let v46 : US29 =
        match v27 with
        | US44_1 -> (* None *)
            US29_1
        | US44_0(v28) -> (* Some *)
            let v29 : (Vec<Heap4 option> -> US45) = closure89()
            let v30 : (std_string_String -> US45) = closure90()
            let v31 : US45 = match v28 with Ok x -> v29 x | Error x -> v30 x
            let v42 : US30 =
                match v31 with
                | US45_1(v39) -> (* Error *)
                    US30_1(v39)
                | US45_0(v32) -> (* Ok *)
                    let v33 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v34 : (Heap4 option -> US27) = closure73()
                    let v35 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v32, v34) v33
                    let v36 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v37 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v35 v36
                    US30_0(v37)
            US29_0(v42)
    let v47 : string = $"%A{v19}"
    let v48 : int64 = 400L
    let v49 : string = method64(v48, v47)
    let v50 : string = $"%A{v46}"
    let v51 : int64 = 400L
    let v52 : string = method64(v51, v50)
    let v53 : string = "state_core.use_request (19) / result move / database: " + string v49 + " / database_loading: " + string v7 + " / state_data: " + string v52 + " / state_data_loading: " + string v11 + ""
    let v54 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v55 : bool = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = $"$0()"
    let v57 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v3 v56
    let v58 : string = "$0.to_vec()"
    let v59 : Vec<Result<crate_model_near_rpc_RpcResponse option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v61 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> -> Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>) = closure133(v0)
    let v62 : Vec<Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v59, v61) v60
    let v63 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v64 : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : string = $"%A{v64}"
    let v66 : string = "state_core.use_requests (20) / result func0 / result: " + string v65 + ""
    let v67 : int32 = v66.Length
    let v68 : bool = v67 <= 200
    let v71 : string =
        if v68 then
            v66
        else
            let v69 : string = v66.[int 0..int 199]
            let v70 : string = v69 + "..."
            v70
    let v72 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v73 : bool = Fable.Core.RustInterop.emitRustExpr v71 v72
    v64
and method115 (v0 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])>, v1 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option))) : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])> =
    let v2 : string = "state_core.use_requests (1)"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "state_core.use_database (1)"
    let v6 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : leptos_Resource<US2, rexie_Rexie> = method5()
    let v9 : string = "$0"
    let v10 : (unit -> rexie_Rexie option) = closure63(v8)
    let v11 : (unit -> rexie_Rexie option) = Fable.Core.RustInterop.emitRustExpr v10 v9
    let v12 : string = "leptos::create_memo(move |_| { v11(()) })"
    let v13 : leptos_Memo<rexie_Rexie option> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_Resource<struct (rexie_Rexie option * (struct (bool * string * bool * US25 * string) [])), Result<Vec<Heap4 option>, std_string_String>> = method62(v0, v8)
    let v15 : string = "$0"
    let v16 : (unit -> Result<(Heap4 option []), std_string_String> option) = closure68(v14)
    let v17 : (unit -> Result<(Heap4 option []), std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v16 v15
    let v18 : string = "leptos::create_memo(move |_| { v17(()) })"
    let v19 : leptos_Memo<Result<(Heap4 option []), std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_Resource<struct ((struct (bool * string * bool * US25 * string) []) * Result<(Heap4 option []), std_string_String> option), Result<(string option []), std_string_String>> = method74(v0, v19)
    let v21 : string = "leptos::create_action(move |value: &std::sync::Arc<Heap4>| $0(value.clone()))"
    let v22 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure77(v0, v13)
    let v23 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v22 v21
    let v24 : string = "$0"
    let v25 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = closure128(v0, v19, v20, v23)
    let v26 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v25 v24
    let v27 : string = "leptos::create_memo(move |_| { v26(()) })"
    let v28 : leptos_Memo<(Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "$0"
    let v30 : (unit -> (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])) = closure132(v1, v8, v14, v28)
    let v31 : (unit -> (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v30 v29
    let v32 : string = "leptos::create_memo(move |_| { v31(()) })"
    let v33 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v32
    v33
and method121 () : string =
    let v0 : string = "https://rpc.mainnet.near.org"
    v0
and closure136 () (v0 : US15) : US61 =
    US61_0(v0)
and closure137 () (v0 : std_string_String) : US61 =
    US61_1(v0)
and closure138 () (v0 : crate_model_near_rpc_RpcResponse) : US63 =
    US63_0(v0)
and closure139 () (v0 : std_string_String) : US63 =
    US63_1(v0)
and method122 (v0 : Result<US60, std_string_String>) : Result<US60, std_string_String> =
    v0
and closure135 () (v0 : Heap6) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>> =
    let v1 : string = $"%A{v0}"
    let v2 : string = "dice_view.render (2) / set_max_action / value: " + string v1 + ""
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    let v6 : string = "&*$0"
    let v7 : string = "2.0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v6
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "&*$0"
    let v12 : string = "dontcare"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v11
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "&*$0"
    let v17 : string = "EXPERIMENTAL_tx_status"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "String::from($0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "&*$0"
    let v22 : string = "9JgptZpFQGtUvusnoF9ysVqHXD8fXCri8mFxPTMnt3kS"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v22 v21
    let v24 : string = "String::from($0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "&*$0"
    let v27 : string = "bowen"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v27 v26
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : (std_string_String []) = [|v25; v30|]
    let v32 : string = "$0.to_vec()"
    let v33 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "crate::model::near::rpc::RpcInput { jsonrpc: v10, id: v15, method: v20, params: v33 }"
    let v35 : crate_model_near_rpc_RpcInput = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : string = method121()
    let v37 : string = "&*$0"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : std_string_String = method81(v40)
    let v42 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.post(v41)"
    let v43 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : string = "reqwest_wasm::RequestBuilder::json(v43, &v35)"
    let v45 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : reqwest_RequestBuilder = method83(v45)
    let v47 : string = "Box::pin(reqwest_wasm::RequestBuilder::send(v46))"
    let v48 : std_pin_Pin<Box<Dyn<std_future_Future<Result<reqwest_Response, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : string = "v48.await"
    let v50 : Result<reqwest_Response, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : (reqwest_Error -> std_string_String) = method84()
    let v52 : string = "$0.map_err(|x| $1(x))"
    let v53 : Result<reqwest_Response, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v50, v51) v52
    let v54 : string = "$0?"
    let v55 : reqwest_Response = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = "Box::pin(reqwest_wasm::Response::text(v55))"
    let v57 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_string_String, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : string = "v57.await"
    let v59 : Result<std_string_String, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v58
    let v60 : (reqwest_Error -> std_string_String) = method84()
    let v61 : string = "$0.map_err(|x| $1(x))"
    let v62 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v59, v60) v61
    let v63 : string = "$0?"
    let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : US15 = US15_0(v64)
    let v66 : Result<US15, std_string_String> = Ok v65
    let v67 : string = $"%A{v66}"
    let v68 : string = "dice_view.render (x) / roll_action create_action / result1 / result: " + string v67 + ""
    let v69 : int32 = v68.Length
    let v70 : bool = v69 <= 200
    let v73 : string =
        if v70 then
            v68
        else
            let v71 : string = v68.[int 0..int 199]
            let v72 : string = v71 + "..."
            v72
    let v74 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v73 v74
    let v76 : (US15 -> US61) = closure136()
    let v77 : (std_string_String -> US61) = closure137()
    let v78 : US61 = match v66 with Ok x -> v76 x | Error x -> v77 x
    let v127 : US62 =
        match v78 with
        | US61_0(v79) -> (* Ok *)
            match v79 with
            | US15_0(v80) -> (* Some *)
                let v81 : string = "fable_library_rust::String_::fromString($0)"
                let v82 : string = Fable.Core.RustInterop.emitRustExpr v80 v81
                let v83 : string = method33(v82)
                let v84 : string = "&*$0"
                let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v84
                let v86 : string = "serde_json::from_str(&v85)"
                let v87 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v86
                let v88 : (serde_json_Error -> std_string_String) = method34()
                let v89 : string = "$0.map_err(|x| $1(x))"
                let v90 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v87, v88) v89
                let v91 : (crate_model_near_rpc_RpcResponse -> US63) = closure138()
                let v92 : (std_string_String -> US63) = closure139()
                let v93 : US63 = match v90 with Ok x -> v91 x | Error x -> v92 x
                let v111 : US64 =
                    match v93 with
                    | US63_1(v108) -> (* Error *)
                        US64_1(v108)
                    | US63_0(v94) -> (* Ok *)
                        let v95 : string = "$0.jsonrpc"
                        let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v95
                        let v97 : string = "$0.result"
                        let v98 : crate_model_near_rpc_TransactionStatus option = Fable.Core.RustInterop.emitRustExpr v94 v97
                        let v99 : (crate_model_near_rpc_TransactionStatus -> struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) []))) = closure118()
                        let v100 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option = v98 |> Option.map v99 
                        let v101 : string = "$0.error"
                        let v102 : crate_model_near_rpc_RpcError option = Fable.Core.RustInterop.emitRustExpr v94 v101
                        let v103 : (crate_model_near_rpc_RpcError -> struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String)) = closure126()
                        let v104 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option = v102 |> Option.map v103 
                        let v105 : string = "$0.id"
                        let v106 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v94 v105
                        US64_0(v104, v106, v96, v100)
                match v111 with
                | US64_1(v118) -> (* Error *)
                    US62_1(v118)
                | US64_0(v112, v113, v114, v115) -> (* Ok *)
                    let v116 : US60 = US60_0(v112, v113, v114, v115)
                    US62_0(v116)
            | _ ->
                let v122 : US60 = US60_1
                US62_0(v122)
        | _ ->
            let v125 : US60 = US60_1
            US62_0(v125)
    let v133 : Result<US60, std_string_String> =
        match v127 with
        | US62_1(v130) -> (* Error *)
            let v131 : Result<US60, std_string_String> = Error v130
            v131
        | US62_0(v128) -> (* Ok *)
            let v129 : Result<US60, std_string_String> = Ok v128
            v129
    let v134 : string = $"%A{v133}"
    let v135 : string = "dice_view.render (x) / roll_action create_action / result2 / result: " + string v134 + ""
    let v136 : int32 = v135.Length
    let v137 : bool = v136 <= 200
    let v140 : string =
        if v137 then
            v135
        else
            let v138 : string = v135.[int 0..int 199]
            let v139 : string = v138 + "..."
            v139
    let v141 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v142 : bool = Fable.Core.RustInterop.emitRustExpr v140 v141
    let v143 : Result<US60, std_string_String> = method122(v133)
    let v144 : string = "v143 }})"
    Fable.Core.RustInterop.emitRustExpr () v144
    let v145 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v145
    let v146 : string = "__result"
    let v147 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v146
    v147
and closure142 () (v0 : US60) : US62 =
    US62_0(v0)
and closure143 () (v0 : std_string_String) : US62 =
    US62_1(v0)
and closure141 () (v0 : Result<US60, std_string_String>) : US62 =
    let v1 : (US60 -> US62) = closure142()
    let v2 : (std_string_String -> US62) = closure143()
    let v3 : US62 = match v0 with Ok x -> v1 x | Error x -> v2 x
    v3
and closure140 (v0 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> =
    let v1 : string = "leptos::Action::value(&$0)"
    let v2 : leptos_RwSignal<Result<US60, std_string_String> option> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : Result<US60, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : (Result<US60, std_string_String> -> US62) = closure141()
    let v6 : US62 option = v4 |> Option.map v5 
    let v7 : US65 option = None
    let _v7 = ref v7 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v8 : US62 = x
    let v9 : US65 = US65_0(v8)
    v9 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v7.Value <- x
    let v10 : US65 option = _v7.Value 
    let v11 : US65 = US65_1
    let v12 : US65 = v10 |> Option.defaultValue v11 
    let v30 : US62 =
        match v12 with
        | US65_0(v13) -> (* Some *)
            match v13 with
            | US62_1(v14) -> (* Error *)
                US62_1(v14)
            | US62_0(v16) -> (* Ok *)
                match v16 with
                | US60_0(v17, v18, v19, v20) -> (* Some *)
                    let v21 : US60 = US60_0(v17, v18, v19, v20)
                    US62_0(v21)
                | _ ->
                    let v23 : US60 = US60_1
                    US62_0(v23)
        | _ ->
            let v28 : US60 = US60_1
            US62_0(v28)
    let v44 : US66 =
        match v30 with
        | US62_1(v41) -> (* Error *)
            US66_1(v41)
        | US62_0(v31) -> (* Ok *)
            let v39 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option =
                match v31 with
                | US60_1 -> (* None *)
                    let v37 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option = None
                    v37
                | US60_0(v32, v33, v34, v35) -> (* Some *)
                    let v36 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option = Some struct (v32, v33, v34, v35) 
                    v36
            US66_0(v39)
    let v50 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> =
        match v44 with
        | US66_1(v47) -> (* Error *)
            let v48 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> = Error v47
            v48
        | US66_0(v45) -> (* Ok *)
            let v46 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> = Ok v45
            v46
    let v51 : string = $"%A{v50}"
    let v52 : string = "dice_view.render (x) / roll create_memo / result: " + string v51 + ""
    let v53 : int32 = v52.Length
    let v54 : bool = v53 <= 200
    let v57 : string =
        if v54 then
            v52
        else
            let v55 : string = v52.[int 0..int 199]
            let v56 : string = v55 + "..."
            v56
    let v58 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v59 : bool = Fable.Core.RustInterop.emitRustExpr v57 v58
    v50
and closure145 () (v0 : struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option) : US66 =
    US66_0(v0)
and closure146 () (v0 : std_string_String) : US66 =
    US66_1(v0)
and closure144 (v0 : leptos_Memo<Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>>) () : string option =
    let v1 : string = $"$0()"
    let v2 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option -> US66) = closure145()
    let v4 : (std_string_String -> US66) = closure146()
    let v5 : US66 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v20 : US62 =
        match v5 with
        | US66_1(v17) -> (* Error *)
            US62_1(v17)
        | US66_0(v6) -> (* Ok *)
            let v7 : US60 option = None
            let _v7 = ref v7 
            match v6 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let struct (v8 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option, v9 : std_string_String option, v10 : std_string_String, v11 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) = x
            let v12 : US60 = US60_0(v8, v9, v10, v11)
            v12 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v7.Value <- x
            let v13 : US60 option = _v7.Value 
            let v14 : US60 = US60_1
            let v15 : US60 = v13 |> Option.defaultValue v14 
            US62_0(v15)
    let v50 : US34 =
        match v20 with
        | US62_0(v21) -> (* Ok *)
            match v21 with
            | US60_0(v22, v23, v24, v25) -> (* Some *)
                let v26 : US67 option = None
                let _v26 = ref v26 
                match v22 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let struct (v27 : struct (std_string_String option * std_string_String option) option, v28 : std_string_String, v29 : int32, v30 : std_string_String, v31 : std_string_String, v32 : std_string_String) = x
                let v33 : US67 = US67_0(v27, v28, v29, v30, v31, v32)
                v33 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v26.Value <- x
                let v34 : US67 option = _v26.Value 
                let v35 : US67 = US67_1
                let v36 : US67 = v34 |> Option.defaultValue v35 
                match v36 with
                | US67_0(v37, v38, v39, v40, v41, v42) -> (* Some *)
                    let v43 : string = string v42 + ": " + string v41 + " - " + string v40 + " (" + string v38 + ")"
                    US34_0(v43)
                | _ ->
                    US34_1
            | _ ->
                US34_1
        | _ ->
            US34_1
    let v55 : string option =
        match v50 with
        | US34_1 -> (* None *)
            let v53 : string option = None
            v53
        | US34_0(v51) -> (* Some *)
            let v52 : string option = Some v51 
            v52
    let v56 : string = $"%A{v55}"
    let v57 : string = "dice_view.render (x) / error_message create_memo / result: " + string v56 + ""
    let v58 : int32 = v57.Length
    let v59 : bool = v58 <= 200
    let v62 : string =
        if v59 then
            v57
        else
            let v60 : string = v57.[int 0..int 199]
            let v61 : string = v60 + "..."
            v61
    let v63 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v64 : bool = Fable.Core.RustInterop.emitRustExpr v62 v63
    v55
and closure147 (v0 : Heap2) () : US34 =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : std_string_String option = v6.l0
    let v8 : US15 option = None
    let _v8 = ref v8 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v9 : std_string_String = x
    let v10 : US15 = US15_0(v9)
    v10 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v8.Value <- x
    let v11 : US15 option = _v8.Value 
    let v12 : US15 = US15_1
    let v13 : US15 = v11 |> Option.defaultValue v12 
    match v13 with
    | US15_1 -> (* None *)
        US34_1
    | US15_0(v14) -> (* Some *)
        let v15 : string = "fable_library_rust::String_::fromString($0)"
        let v16 : string = Fable.Core.RustInterop.emitRustExpr v14 v15
        US34_0(v16)
and closure150 (v0 : int32) (v1 : std_string_String) : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) =
    let v2 : string = $"leptos::create_signal($0)"
    let struct (v3 : leptos_ReadSignal<std_string_String>, v4 : leptos_WriteSignal<std_string_String>) = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v5 : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) = v0, struct (v3, v4)
    v5
and closure149 () (v0 : int32) : (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))) =
    closure150(v0)
and method123 () : (int32 -> (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)))) =
    closure149()
and method124 (v0 : Vec<std_string_String>) : Vec<std_string_String> =
    v0
and closure148 (v0 : Heap2) () : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : Vec<(bool * std_string_String)> = v6.l1
    let v8 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v9 : ((bool * std_string_String) -> struct (bool * std_string_String)) = closure46()
    let v10 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : (struct (bool * std_string_String) -> bool) = method50()
    let v12 : Vec<struct (bool * std_string_String)> = method51(v10)
    let v13 : string = "v12.into_iter().filter(|x| v11(x.clone().clone())).collect()"
    let v14 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v16 : (struct (bool * std_string_String) -> std_string_String) = closure48()
    let v17 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15
    let v18 : (int32 -> (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)))) = method123()
    let v19 : Vec<std_string_String> = method124(v17)
    let v20 : string = "v19.iter().enumerate().map(|(i, x)| v18(i.try_into().unwrap())(x.clone())).collect()"
    let v21 : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> = Fable.Core.RustInterop.emitRustExpr () v20
    v21
and closure152 () (v0 : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))) : struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>) =
    let (a, b) = v0
    let v1 : int32 = a
    let struct (v2 : leptos_ReadSignal<std_string_String>, v3 : leptos_WriteSignal<std_string_String>) = b
    struct (v1, v2, v3)
and closure153 () struct (v0 : int32, v1 : leptos_ReadSignal<std_string_String>, v2 : leptos_WriteSignal<std_string_String>) : struct (int32 * leptos_ReadSignal<std_string_String>) =
    struct (v0, v1)
and closure151 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>>) () : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> =
    let v1 : string = $"$0()"
    let v2 : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v4 : ((int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) -> struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) = closure152()
    let v5 : Vec<struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v7 : (struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>) -> struct (int32 * leptos_ReadSignal<std_string_String>)) = closure153()
    let v8 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    v8
and method125 (v0 : (leptos_View [])) : (leptos_View []) =
    v0
and closure162 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method134 () : (unit -> leptos_Fragment) =
    closure162()
and method135 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    v0
and closure163 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
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
and method136 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure163(v0)
and closure164 () (v0 : leptos_HtmlElement<leptos_svg_Path>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure161 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M6 18L18 6M6 6l12 12\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure164()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method133 () : (unit -> leptos_Fragment) =
    closure161()
and closure160 () () : leptos_Fragment =
    let v0 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v1 : string = "fill=\"none\""
    let v2 : string = "height=\"100%\""
    let v3 : string = "viewBox=\"0 0 24 24\""
    let v4 : string = "stroke-width=\"1.5\""
    let v5 : string = "stroke=\"currentColor\""
    let v6 : string = "class=\"text-red-700\""
    let v7 : (unit -> leptos_Fragment) = method133()
    let v8 : string = ""
    let v9 : string = " " + v0 + v8 + ""
    let v10 : string = " " + v1 + v9 + ""
    let v11 : string = " " + v2 + v10 + ""
    let v12 : string = " " + v3 + v11 + ""
    let v13 : string = " " + v4 + v12 + ""
    let v14 : string = " " + v5 + v13 + ""
    let v15 : string = " " + v6 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v7)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method132 () : (unit -> leptos_Fragment) =
    closure160()
and closure165 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "No data"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method137 () : (unit -> leptos_Fragment) =
    closure165()
and closure159 () () : leptos_Fragment =
    let v0 : string = "class=\"[height:17px]\""
    let v1 : (unit -> leptos_Fragment) = method132()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "span"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Span> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v14 : (unit -> leptos_Fragment) = method137()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method131 () : (unit -> leptos_Fragment) =
    closure159()
and method138 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> =
    v0
and closure166 () struct (v0 : int32, v1 : leptos_ReadSignal<std_string_String>) : int32 =
    v0
and method139 () : (struct (int32 * leptos_ReadSignal<std_string_String>) -> int32) =
    closure166()
and method141 (v0 : std_string_String) : std_string_String =
    v0
and closure168 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : int32, v4 : std_string_String) () : unit =
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
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v21
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : std_string_String option = Some v24 
    let v26 : Heap0 = {l0 = v25; l1 = v14; l2 = v15; l3 = v16; l4 = v17} : Heap0
    let v27 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr struct (v20, v26) v27
    ()
and closure170 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure172 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method144 () : (unit -> leptos_Fragment) =
    closure172()
and closure171 () () : leptos_Fragment =
    let v0 : string = "cx=\"12\""
    let v1 : string = "cy=\"12\""
    let v2 : string = "r=\"9\""
    let v3 : string = "stroke-linecap=\"round\""
    let v4 : string = "stroke-linejoin=\"round\""
    let v5 : (unit -> leptos_Fragment) = method144()
    let v6 : string = ""
    let v7 : string = " " + v0 + v6 + ""
    let v8 : string = " " + v1 + v7 + ""
    let v9 : string = " " + v2 + v8 + ""
    let v10 : string = " " + v3 + v9 + ""
    let v11 : string = " " + v4 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v5)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
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
    let v24 : (unit -> leptos_Fragment) = method134()
    let v25 : string = " " + v21 + v6 + ""
    let v26 : string = " " + v22 + v25 + ""
    let v27 : string = " " + v23 + v26 + ""
    let v28 : (unit -> leptos_Fragment) = method135(v24)
    let v29 : (unit -> leptos_Fragment) = method136(v28)
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
and method143 () : (unit -> leptos_Fragment) =
    closure171()
and closure169 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : std_string_String) () : leptos_Fragment =
    let v4 : string = "fable_library_rust::String_::fromString($0)"
    let v5 : string = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : US70 option = None
    let _v6 = ref v6 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v7 : leptos_Memo<US34> = x
    let v8 : US70 = US70_0(v7)
    v8 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v6.Value <- x
    let v9 : US70 option = _v6.Value 
    let v10 : US70 = US70_1
    let v11 : US70 = v9 |> Option.defaultValue v10 
    let v18 : US43 =
        match v11 with
        | US70_1 -> (* None *)
            US43_1
        | US70_0(v12) -> (* Some *)
            let v13 : string = $"$0()"
            let v14 : US34 = Fable.Core.RustInterop.emitRustExpr v12 v13
            US43_0(v14)
    let v25 : US34 =
        match v18 with
        | US43_0(v19) -> (* Some *)
            match v19 with
            | US34_0(v20) -> (* Some *)
                US34_0(v20)
            | _ ->
                US34_1
        | _ ->
            US34_1
    let v63 : leptos_View =
        match v25 with
        | US34_0(v26) -> (* Some *)
            let v27 : bool = v5 = v26
            if v27 then
                let v28 : string = "$0"
                let v29 : (unit -> string) = closure170()
                let v30 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v29 v28
                let v31 : string = "xmlns=\"http://www.w3.org/2000/svg\""
                let v32 : string = "fill=\"none\""
                let v33 : string = "viewBox=\"0 0 24 24\""
                let v34 : string = "stroke-width=\"1.5\""
                let v35 : string = "stroke=\"currentColor\""
                let v36 : string = "class=move || \" \".to_owned() + &v30(())"
                let v37 : (unit -> leptos_Fragment) = method143()
                let v38 : string = ""
                let v39 : string = " " + v31 + v38 + ""
                let v40 : string = " " + v32 + v39 + ""
                let v41 : string = " " + v33 + v40 + ""
                let v42 : string = " " + v34 + v41 + ""
                let v43 : string = " " + v35 + v42 + ""
                let v44 : string = " " + v36 + v43 + ""
                let v45 : (unit -> leptos_Fragment) = method135(v37)
                let v46 : (unit -> leptos_Fragment) = method136(v45)
                let v47 : string = "svg"
                let v48 : string = "<" + v47 + " " + v44 + ">{v46()}</" + v47 + ">"
                let v49 : string = "leptos::view! { " + v48 + " }"
                let v50 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v49
                let v51 : leptos_HtmlElement<leptos_svg_Svg> = v50 |> unbox
                let v52 : string = "leptos::IntoView::into_view($0)"
                let v53 : leptos_View = Fable.Core.RustInterop.emitRustExpr v51 v52
                v53
            else
                let v54 : (leptos_View []) = [||]
                let v55 : (leptos_View []) = method125(v54)
                let v56 : string = "leptos::CollectView::collect_view($0.to_vec())"
                let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56
                v57
        | _ ->
            let v59 : (leptos_View []) = [||]
            let v60 : (leptos_View []) = method125(v59)
            let v61 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v62 : leptos_View = Fable.Core.RustInterop.emitRustExpr v60 v61
            v62
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v64
    let v66 : string = "String::from($0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "leptos::html::text($0)"
    let v69 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : string = "leptos::IntoView::into_view($0)"
    let v71 : leptos_View = Fable.Core.RustInterop.emitRustExpr v69 v70
    let v72 : (leptos_View []) = [|v63; v71|]
    let v73 : string = "$0.to_vec()"
    let v74 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v72 v73
    let v75 : string = "leptos::Fragment::new($0)"
    let v76 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v74 v75
    v76
and method142 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : std_string_String) : (unit -> leptos_Fragment) =
    closure169(v0, v1, v2, v3)
and closure173 () (v0 : leptos_HtmlElement<leptos_html_Button>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure167 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) struct (v3 : int32, v4 : leptos_ReadSignal<std_string_String>) : leptos_Fragment =
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : std_string_String = method141(v6)
    let v8 : (unit -> unit) = closure168(v0, v1, v2, v3, v6)
    let v9 : string = "let v8 = $0"
    Fable.Core.RustInterop.emitRustExpr v8 v9
    let v10 : string = "class=\"flex flex-1 gap-[10px] [align-items:center] [justify-content:center] inline-block rounded border border-gray-400 hover:bg-gray-100 px-[22px] py-1 text-sm text-gray-900 bg-gray-200 hover:text-gray-600 focus:outline-none focus:ring active:text-gray-500\""
    let v11 : string = "on:click=move |_| v8()"
    let v12 : string = "aria-label=v7"
    let v13 : (unit -> leptos_Fragment) = method142(v0, v1, v2, v6)
    let v14 : string = ""
    let v15 : string = " " + v10 + v14 + ""
    let v16 : string = " " + v11 + v15 + ""
    let v17 : string = " " + v12 + v16 + ""
    let v18 : (unit -> leptos_Fragment) = method135(v13)
    let v19 : (unit -> leptos_Fragment) = method136(v18)
    let v20 : string = "button"
    let v21 : string = "<" + v20 + " " + v17 + ">{v19()}</" + v20 + ">"
    let v22 : string = "leptos::view! { " + v21 + " }"
    let v23 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : leptos_HtmlElement<leptos_html_Button> = v23 |> unbox
    let v25 : (leptos_HtmlElement<leptos_html_Button> []) = [|v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_HtmlElement<leptos_html_Button>> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v29 : (leptos_HtmlElement<leptos_html_Button> -> leptos_View) = closure173()
    let v30 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v28
    let v31 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v32 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method140 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (struct (int32 * leptos_ReadSignal<std_string_String>) -> leptos_Fragment) =
    closure167(v0, v1, v2)
and closure158 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : US68 option = None
    let _v3 = ref v3 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = x
    let v5 : US68 = US68_0(v4)
    v5 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v3.Value <- x
    let v6 : US68 option = _v3.Value 
    let v7 : US68 = US68_1
    let v8 : US68 = v6 |> Option.defaultValue v7 
    let v17 : US69 =
        match v8 with
        | US68_1 -> (* None *)
            US69_1
        | US68_0(v9) -> (* Some *)
            let v10 : string = $"$0()"
            let v11 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr v9 v10
            let v12 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v13 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) = Fable.Core.RustInterop.emitRustExpr v11 v12
            US69_0(v13)
    let v18 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) = [||]
    let v21 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) =
        match v17 with
        | US69_1 -> (* None *)
            v18
        | US69_0(v19) -> (* Some *)
            v19
    let v22 : uint64 = System.Convert.ToUInt64 v21.Length
    let v23 : bool = v22 = 0UL
    if v23 then
        let v24 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
        let v25 : (unit -> leptos_Fragment) = method131()
        let v26 : string = ""
        let v27 : string = " " + v24 + v26 + ""
        let v28 : (unit -> leptos_Fragment) = method135(v25)
        let v29 : (unit -> leptos_Fragment) = method136(v28)
        let v30 : string = "div"
        let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
        let v32 : string = "leptos::view! { " + v31 + " }"
        let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : leptos_HtmlElement<leptos_html_Div> = v33 |> unbox
        let v35 : string = "leptos::IntoView::into_view($0)"
        let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
        let v37 : (leptos_View []) = [|v36|]
        let v38 : string = "$0.to_vec()"
        let v39 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v37 v38
        let v40 : string = "leptos::Fragment::new($0)"
        let v41 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v39 v40
        v41
    else
        let v42 : US68 option = None
        let _v42 = ref v42 
        match v0 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v43 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = x
        let v44 : US68 = US68_0(v43)
        v44 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v42.Value <- x
        let v45 : US68 option = _v42.Value 
        let v46 : US68 = US68_1
        let v47 : US68 = v45 |> Option.defaultValue v46 
        match v47 with
        | US68_1 -> (* None *)
            let v70 : (leptos_View []) = [||]
            let v71 : string = "$0.to_vec()"
            let v72 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v70 v71
            let v73 : string = "leptos::Fragment::new($0)"
            let v74 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v72 v73
            v74
        | US68_0(v48) -> (* Some *)
            let v49 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = method138(v48)
            let v50 : (struct (int32 * leptos_ReadSignal<std_string_String>) -> int32) = method139()
            let v51 : (struct (int32 * leptos_ReadSignal<std_string_String>) -> leptos_Fragment) = method140(v0, v1, v2)
            let v52 : string = "each=v49"
            let v53 : string = "key=move |x| v50(x.to_owned())"
            let v54 : string = "let:x"
            let v55 : string = "children=move |x| v51(x)"
            let v56 : string = ""
            let v57 : string = " " + v52 + v56 + ""
            let v58 : string = " " + v53 + v57 + ""
            let v59 : string = " " + v54 + v58 + ""
            let v60 : string = " " + v55 + v59 + ""
            let v61 : string = "leptos::For"
            let v62 : string = "<" + v61 + " " + v60 + " />"
            let v63 : string = "leptos::IntoView::into_view(leptos::view! { " + v62 + " })"
            let v64 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v63
            let v65 : (leptos_View []) = [|v64|]
            let v66 : string = "$0.to_vec()"
            let v67 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "leptos::Fragment::new($0)"
            let v69 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v67 v68
            v69
and method130 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure158(v0, v1, v2)
and closure157 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : string = "class=\"flex flex-1 flex-col p-[10px] gap-[7px] [border-left-width:1px] [border-bottom-width:1px] border-gray-200 bg-gray-100\""
    let v4 : (unit -> leptos_Fragment) = method130(v0, v1, v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method135(v4)
    let v8 : (unit -> leptos_Fragment) = method136(v7)
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
and method129 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure157(v0, v1, v2)
and closure174 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
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
and method145 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure174(v0)
and closure176 () () : string =
    let v0 : string = "[align-self:flex-start]"
    v0
and closure177 () () : bool =
    false
and closure178 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (leptos_View []) = [|v0|]
    let v2 : string = "$0.to_vec()"
    let v3 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "leptos::Fragment::new($0)"
    let v5 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and method147 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure178(v0)
and closure180 () () : string =
    let v0 : string = "py-[4px]"
    v0
and closure181 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : StaticRef<Str> =
    let v6 : string = ""
    let v7 : string = "r#\"" + v6 + "\"#"
    let v8 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v7
    v8
and closure184 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : string =
    let v3 : US70 option = None
    let _v3 = ref v3 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v4 : leptos_Memo<US34> = x
    let v5 : US70 = US70_0(v4)
    v5 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v3.Value <- x
    let v6 : US70 option = _v3.Value 
    let v7 : US70 = US70_1
    let v8 : US70 = v6 |> Option.defaultValue v7 
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
    match v22 with
    | US34_1 -> (* None *)
        let v24 : string = "Select..."
        v24
    | US34_0(v23) -> (* Some *)
        v23
and method151 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> string) =
    closure184(v0, v1, v2)
and closure185 (v0 : (unit -> string)) () : leptos_Fragment =
    let v1 : string = v0 ()
    let v2 : string = "&*$0"
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
and method152 (v0 : (unit -> string)) : (unit -> leptos_Fragment) =
    closure185(v0)
and closure183 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : (unit -> string) = method151(v0, v1, v2)
    let v4 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v5 : (unit -> leptos_Fragment) = method152(v3)
    let v6 : string = ""
    let v7 : string = " " + v4 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v5)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
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
and method150 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure183(v0, v1, v2)
and closure187 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure188 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure164()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method154 () : (unit -> leptos_Fragment) =
    closure188()
and closure186 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure187()
    let v2 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v4 : string = "viewBox=\"0 0 20 20\""
    let v5 : string = "fill=\"currentColor\""
    let v6 : string = "class=move || \" \".to_owned() + &v2(())"
    let v7 : (unit -> leptos_Fragment) = method154()
    let v8 : string = ""
    let v9 : string = " " + v3 + v8 + ""
    let v10 : string = " " + v4 + v9 + ""
    let v11 : string = " " + v5 + v10 + ""
    let v12 : string = " " + v6 + v11 + ""
    let v13 : (unit -> leptos_Fragment) = method135(v7)
    let v14 : (unit -> leptos_Fragment) = method136(v13)
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
and method153 () : (unit -> leptos_Fragment) =
    closure186()
and closure182 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : string = "class=\"flex items-center gap-2\""
    let v4 : (unit -> leptos_Fragment) = method150(v0, v1, v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method135(v4)
    let v8 : (unit -> leptos_Fragment) = method136(v7)
    let v9 : string = "div"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : leptos_HtmlElement<leptos_html_Div> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v17 : (unit -> leptos_Fragment) = method153()
    let v18 : string = " " + v16 + v5 + ""
    let v19 : (unit -> leptos_Fragment) = method135(v17)
    let v20 : (unit -> leptos_Fragment) = method136(v19)
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
and method149 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure182(v0, v1, v2)
and closure189 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    v0 ()
and method155 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure189(v0)
and closure179 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure180()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> StaticRef<Str>) = closure181(v0, v1, v2)
    let v9 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v9(()) + \" \" + &v6(())"
    let v11 : (unit -> leptos_Fragment) = method149(v0, v1, v2)
    let v12 : string = ""
    let v13 : string = " " + v10 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method135(v11)
    let v15 : (unit -> leptos_Fragment) = method136(v14)
    let v16 : string = "summary"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : leptos_HtmlElement<leptos_html_Summary> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "class=\"flex flex-1 flex-col\""
    let v24 : (unit -> leptos_Fragment) = method155(v3)
    let v25 : string = " " + v23 + v12 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v24)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method148 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure179(v0, v1, v2, v3)
and closure175 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : leptos_View, v4 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure176()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "$0"
    let v9 : (unit -> bool) = closure177()
    let v10 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v12 : (unit -> leptos_Fragment) = method147(v3)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method135(v12)
    let v16 : (unit -> leptos_Fragment) = method136(v15)
    let v17 : string = "div"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Div> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v7(())"
    let v25 : string = "open=move || v10(())"
    let v26 : (unit -> leptos_Fragment) = method148(v0, v1, v2, v4)
    let v27 : string = " " + v24 + v13 + ""
    let v28 : string = " " + v25 + v27 + ""
    let v29 : (unit -> leptos_Fragment) = method135(v26)
    let v30 : (unit -> leptos_Fragment) = method136(v29)
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
and method146 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : leptos_View, v4 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure175(v0, v1, v2, v3, v4)
and closure156 (v0 : Heap2, v1 : leptos_Memo<US34>, v2 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v3 : string = "&*$0"
    let v4 : string = "Account"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v3
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
    let v17 : (leptos_View []) = method125(v16)
    let v18 : string = "leptos::CollectView::collect_view($0.to_vec())"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : (unit -> leptos_Fragment) = method129(v14, v15, v0)
    let v21 : (unit -> leptos_Fragment) = method145(v20)
    let v22 : string = "class=\"flex flex-col [position:relative]\""
    let v23 : (unit -> leptos_Fragment) = method146(v14, v15, v0, v19, v21)
    let v24 : string = ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method128 (v0 : Heap2, v1 : leptos_Memo<US34>, v2 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure156(v0, v1, v2)
and closure191 (v0 : Heap2) () : int32 =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : int32 = v6.l2
    v7
and method157 (v0 : Heap2) : (unit -> int32) =
    closure191(v0)
and closure192 (v0 : Heap2) (v1 : std_string_String) : unit =
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
and method158 (v0 : Heap2) : (std_string_String -> unit) =
    closure192(v0)
and closure193 () () : string =
    let v0 : string = ""
    v0
and closure190 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = "&*$0"
    let v2 : string = "Max"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : (unit -> int32) = method157(v0)
    let v11 : (std_string_String -> unit) = method158(v0)
    let v12 : string = "$0"
    let v13 : (unit -> string) = closure193()
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
and method156 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure190(v0)
and closure195 (v0 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : bool =
    let v1 : string = "leptos::Action::pending(&$0)"
    let v2 : leptos_ReadSignal<bool> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method160 (v0 : Func0<bool>) : Func0<bool> =
    v0
and closure196 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : unit =
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
and closure198 () () : string =
    let v0 : string = "[width:15px] [height:14px]"
    v0
and closure201 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method164 () : (unit -> leptos_Fragment) =
    closure201()
and closure200 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method164()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method135(v6)
    let v15 : (unit -> leptos_Fragment) = method136(v14)
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
    let v29 : (unit -> leptos_Fragment) = method164()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method135(v29)
    let v37 : (unit -> leptos_Fragment) = method136(v36)
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
    let v50 : (unit -> leptos_Fragment) = method164()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method135(v50)
    let v58 : (unit -> leptos_Fragment) = method136(v57)
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
and method163 () : (unit -> leptos_Fragment) =
    closure200()
and closure202 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0.15s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method164()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method135(v6)
    let v15 : (unit -> leptos_Fragment) = method136(v14)
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
    let v29 : (unit -> leptos_Fragment) = method164()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method135(v29)
    let v37 : (unit -> leptos_Fragment) = method136(v36)
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
    let v50 : (unit -> leptos_Fragment) = method164()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method135(v50)
    let v58 : (unit -> leptos_Fragment) = method136(v57)
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
and method165 () : (unit -> leptos_Fragment) =
    closure202()
and closure203 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0.3s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method164()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method135(v6)
    let v15 : (unit -> leptos_Fragment) = method136(v14)
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
    let v29 : (unit -> leptos_Fragment) = method164()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method135(v29)
    let v37 : (unit -> leptos_Fragment) = method136(v36)
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
    let v50 : (unit -> leptos_Fragment) = method164()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method135(v50)
    let v58 : (unit -> leptos_Fragment) = method136(v57)
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
and method166 () : (unit -> leptos_Fragment) =
    closure203()
and closure204 () (v0 : leptos_HtmlElement<leptos_svg_Rect>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure199 () () : leptos_Fragment =
    let v0 : string = "x=\"0\""
    let v1 : string = "y=\"10\""
    let v2 : string = "width=\"4\""
    let v3 : string = "height=\"10\""
    let v4 : string = "fill=\"#333\""
    let v5 : string = "opacity=\"0.2\""
    let v6 : (unit -> leptos_Fragment) = method163()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method135(v6)
    let v15 : (unit -> leptos_Fragment) = method136(v14)
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
    let v27 : (unit -> leptos_Fragment) = method165()
    let v28 : string = " " + v21 + v7 + ""
    let v29 : string = " " + v22 + v28 + ""
    let v30 : string = " " + v23 + v29 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : (unit -> leptos_Fragment) = method135(v27)
    let v35 : (unit -> leptos_Fragment) = method136(v34)
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
    let v46 : (unit -> leptos_Fragment) = method166()
    let v47 : string = " " + v40 + v7 + ""
    let v48 : string = " " + v41 + v47 + ""
    let v49 : string = " " + v42 + v48 + ""
    let v50 : string = " " + v43 + v49 + ""
    let v51 : string = " " + v44 + v50 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : (unit -> leptos_Fragment) = method135(v46)
    let v54 : (unit -> leptos_Fragment) = method136(v53)
    let v55 : string = "<" + v16 + " " + v52 + ">{v54()}</" + v16 + ">"
    let v56 : string = "leptos::view! { " + v55 + " }"
    let v57 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : leptos_HtmlElement<leptos_svg_Rect> = v57 |> unbox
    let v59 : (leptos_HtmlElement<leptos_svg_Rect> []) = [|v20; v39; v58|]
    let v60 : string = "$0.to_vec()"
    let v61 : Vec<leptos_HtmlElement<leptos_svg_Rect>> = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v63 : (leptos_HtmlElement<leptos_svg_Rect> -> leptos_View) = closure204()
    let v64 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v61, v63) v62
    let v65 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v66 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v64 v65
    let v67 : string = "$0.to_vec()"
    let v68 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v66 v67
    let v69 : string = "leptos::Fragment::new($0)"
    let v70 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v68 v69
    v70
and method162 () : (unit -> leptos_Fragment) =
    closure199()
and closure197 (v0 : Func0<bool>) () : leptos_Fragment =
    let v1 : string = "&*$0"
    let v2 : string = "Roll"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0()"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v0 v10
    let v48 : leptos_View =
        if v11 then
            let v12 : string = "$0"
            let v13 : (unit -> string) = closure198()
            let v14 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v13 v12
            let v15 : string = "version=\"1.1\""
            let v16 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v17 : string = "xmlns:xlink=\"http://www.w3.org/1999/xlink\""
            let v18 : string = "x=\"0px\""
            let v19 : string = "y=\"0px\""
            let v20 : string = "viewBox=\"0 0 24 30\""
            let v21 : string = "style=\"enable-background:new 0 0 50 50;\""
            let v22 : string = "xml:space=\"preserve\""
            let v23 : string = "class=move || \" \".to_owned() + &v14(())"
            let v24 : (unit -> leptos_Fragment) = method162()
            let v25 : string = ""
            let v26 : string = " " + v15 + v25 + ""
            let v27 : string = " " + v16 + v26 + ""
            let v28 : string = " " + v17 + v27 + ""
            let v29 : string = " " + v18 + v28 + ""
            let v30 : string = " " + v19 + v29 + ""
            let v31 : string = " " + v20 + v30 + ""
            let v32 : string = " " + v21 + v31 + ""
            let v33 : string = " " + v22 + v32 + ""
            let v34 : string = " " + v23 + v33 + ""
            let v35 : (unit -> leptos_Fragment) = method135(v24)
            let v36 : (unit -> leptos_Fragment) = method136(v35)
            let v37 : string = "svg"
            let v38 : string = "<" + v37 + " " + v34 + ">{v36()}</" + v37 + ">"
            let v39 : string = "leptos::view! { " + v38 + " }"
            let v40 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v39
            let v41 : leptos_HtmlElement<leptos_svg_Svg> = v40 |> unbox
            let v42 : string = "leptos::IntoView::into_view($0)"
            let v43 : leptos_View = Fable.Core.RustInterop.emitRustExpr v41 v42
            v43
        else
            let v44 : (leptos_View []) = [||]
            let v45 : (leptos_View []) = method125(v44)
            let v46 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
            v47
    let v49 : (leptos_View []) = [|v9; v48|]
    let v50 : string = "$0.to_vec()"
    let v51 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "leptos::Fragment::new($0)"
    let v53 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v51 v52
    v53
and method161 (v0 : Func0<bool>) : (unit -> leptos_Fragment) =
    closure197(v0)
and closure206 (v0 : string) () : leptos_Fragment =
    let v1 : string = "&*$0"
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
and method168 (v0 : string) : (unit -> leptos_Fragment) =
    closure206(v0)
and closure205 (v0 : string) () : leptos_Fragment =
    let v1 : string = "class=\"[height:17px]\""
    let v2 : (unit -> leptos_Fragment) = method132()
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v15 : (unit -> leptos_Fragment) = method168(v0)
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v15)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
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
and method167 (v0 : string) : (unit -> leptos_Fragment) =
    closure205(v0)
and closure194 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>) () : leptos_Fragment =
    let v3 : string = "Func0::new(move || $0())"
    let v4 : (unit -> bool) = closure195(v1)
    let v5 : Func0<bool> = Fable.Core.RustInterop.emitRustExpr v4 v3
    let v6 : Func0<bool> = method160(v5)
    let v7 : (unit -> unit) = closure196(v0, v1)
    let v8 : string = "let v7 = $0"
    Fable.Core.RustInterop.emitRustExpr v7 v8
    let v9 : string = "class=\"flex gap-[10px] [align-items:center] inline-block rounded border border-gray-400 hover:bg-gray-400 px-4 py-1 text-sm font-medium text-gray-900 bg-transparent hover:text-gray-600 focus:outline-none focus:ring active:text-gray-500\""
    let v10 : string = "prop:disabled=move || v6()"
    let v11 : string = "on:click=move |_| v7()"
    let v12 : (unit -> leptos_Fragment) = method161(v5)
    let v13 : string = ""
    let v14 : string = " " + v9 + v13 + ""
    let v15 : string = " " + v10 + v14 + ""
    let v16 : string = " " + v11 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v12)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
    let v19 : string = "button"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Button> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = $"$0()"
    let v27 : string option = Fable.Core.RustInterop.emitRustExpr v2 v26
    let v28 : US34 option = None
    let _v28 = ref v28 
    match v27 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v29 : string = x
    let v30 : US34 = US34_0(v29)
    v30 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v28.Value <- x
    let v31 : US34 option = _v28.Value 
    let v32 : US34 = US34_1
    let v33 : US34 = v31 |> Option.defaultValue v32 
    let v51 : leptos_View =
        match v33 with
        | US34_0(v34) -> (* Some *)
            let v35 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v36 : (unit -> leptos_Fragment) = method167(v34)
            let v37 : string = " " + v35 + v13 + ""
            let v38 : (unit -> leptos_Fragment) = method135(v36)
            let v39 : (unit -> leptos_Fragment) = method136(v38)
            let v40 : string = "div"
            let v41 : string = "<" + v40 + " " + v37 + ">{v39()}</" + v40 + ">"
            let v42 : string = "leptos::view! { " + v41 + " }"
            let v43 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v42
            let v44 : leptos_HtmlElement<leptos_html_Div> = v43 |> unbox
            let v45 : string = "leptos::IntoView::into_view($0)"
            let v46 : leptos_View = Fable.Core.RustInterop.emitRustExpr v44 v45
            v46
        | _ ->
            let v47 : (leptos_View []) = [||]
            let v48 : (leptos_View []) = method125(v47)
            let v49 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v50 : leptos_View = Fable.Core.RustInterop.emitRustExpr v48 v49
            v50
    let v52 : (leptos_View []) = [|v25; v51|]
    let v53 : string = "$0.to_vec()"
    let v54 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "leptos::Fragment::new($0)"
    let v56 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v54 v55
    v56
and method159 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>) : (unit -> leptos_Fragment) =
    closure194(v0, v1, v2)
and closure155 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v5 : string = "class=\"flex [flex-direction:column] [gap:2px] [align-items:flex-start]\""
    let v6 : (unit -> leptos_Fragment) = method128(v0, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "div"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Div> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=\"flex [flex-direction:column] [gap:2px] [align-items:flex-start]\""
    let v19 : (unit -> leptos_Fragment) = method156(v0)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
    let v23 : string = "<" + v11 + " " + v20 + ">{v22()}</" + v11 + ">"
    let v24 : string = "leptos::view! { " + v23 + " }"
    let v25 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : leptos_HtmlElement<leptos_html_Div> = v25 |> unbox
    let v27 : string = "leptos::IntoView::into_view($0)"
    let v28 : leptos_View = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "class=\"flex\""
    let v30 : (unit -> leptos_Fragment) = method159(v0, v1, v2)
    let v31 : string = " " + v29 + v7 + ""
    let v32 : (unit -> leptos_Fragment) = method135(v30)
    let v33 : (unit -> leptos_Fragment) = method136(v32)
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
and method127 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure155(v0, v1, v2, v3, v4)
and closure207 () (v0 : leptos_HtmlElement<leptos_html_Div>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure154 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v5 : string = "class=\"flex flex-col p-[10px] gap-[11px]\""
    let v6 : (unit -> leptos_Fragment) = method127(v0, v1, v2, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "div"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Div> = v14 |> unbox
    let v16 : (leptos_HtmlElement<leptos_html_Div> []) = [|v15|]
    let v17 : string = "$0.to_vec()"
    let v18 : Vec<leptos_HtmlElement<leptos_html_Div>> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v20 : (leptos_HtmlElement<leptos_html_Div> -> leptos_View) = closure207()
    let v21 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26
    v27
and method126 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure154(v0, v1, v2, v3, v4)
and closure209 () () : string =
    let v0 : string = ""
    v0
and closure210 () () : bool =
    true
and closure212 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure213 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure216 () () : string =
    let v0 : string = "Roll"
    v0
and method173 () : (unit -> string) =
    closure216()
and closure215 () () : leptos_Fragment =
    let v0 : (unit -> string) = method173()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method152(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method172 () : (unit -> leptos_Fragment) =
    closure215()
and closure214 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method172()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method153()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method171 () : (unit -> leptos_Fragment) =
    closure214()
and closure211 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure212()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure213()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method171()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method135(v8)
    let v12 : (unit -> leptos_Fragment) = method136(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method155(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method135(v21)
    let v24 : (unit -> leptos_Fragment) = method136(v23)
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
and method170 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure211(v0)
and closure208 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure209()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure210()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method147(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method170(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method169 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure208(v0, v1)
and closure219 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "No account selected"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method176 () : (unit -> leptos_Fragment) =
    closure219()
and closure218 () () : leptos_Fragment =
    let v0 : string = "class=\"[height:17px]\""
    let v1 : (unit -> leptos_Fragment) = method132()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "span"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Span> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v14 : (unit -> leptos_Fragment) = method176()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
    closure218()
and closure221 () struct (v0 : std_string_String, v1 : std_string_String option) : struct (string * US34) =
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : US15 option = None
    let _v4 = ref v4 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v5 : std_string_String = x
    let v6 : US15 = US15_0(v5)
    v6 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v4.Value <- x
    let v7 : US15 option = _v4.Value 
    let v8 : US15 = US15_1
    let v9 : US15 = v7 |> Option.defaultValue v8 
    let v16 : US34 =
        match v9 with
        | US15_1 -> (* None *)
            US34_1
        | US15_0(v10) -> (* Some *)
            let v11 : string = "fable_library_rust::String_::fromString($0)"
            let v12 : string = Fable.Core.RustInterop.emitRustExpr v10 v11
            US34_0(v12)
    struct (v3, v16)
and closure222 () struct (v0 : string, v1 : US34) : bool =
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
and method178 () : (struct (string * US34) -> bool) =
    closure222()
and method179 (v0 : Vec<struct (string * US34)>) : Vec<struct (string * US34)> =
    v0
and closure220 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : bool =
    let v3 : (struct (std_string_String * std_string_String option) []) = v2.l0
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v7 : (struct (std_string_String * std_string_String option) -> struct (string * US34)) = closure221()
    let v8 : Vec<struct (string * US34)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : (struct (string * US34) -> bool) = method178()
    let v10 : Vec<struct (string * US34)> = method179(v8)
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
and method177 () : (struct (string * unativeint * Heap5) -> bool) =
    closure220()
and method180 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure224 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Block Timestamp"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method182 () : (unit -> leptos_Fragment) =
    closure224()
and closure225 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Predecessor"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method183 () : (unit -> leptos_Fragment) =
    closure225()
and closure226 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Receiver"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method184 () : (unit -> leptos_Fragment) =
    closure226()
and closure227 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Fee"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method185 () : (unit -> leptos_Fragment) =
    closure227()
and closure228 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Result"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method186 () : (unit -> leptos_Fragment) =
    closure228()
and closure229 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Status"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method187 () : (unit -> leptos_Fragment) =
    closure229()
and closure223 () () : leptos_Fragment =
    let v0 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v1 : (unit -> leptos_Fragment) = method182()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "th"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Th> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v14 : (unit -> leptos_Fragment) = method183()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
    let v18 : string = "<" + v6 + " " + v15 + ">{v17()}</" + v6 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Th> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v25 : (unit -> leptos_Fragment) = method184()
    let v26 : string = " " + v24 + v2 + ""
    let v27 : (unit -> leptos_Fragment) = method135(v25)
    let v28 : (unit -> leptos_Fragment) = method136(v27)
    let v29 : string = "<" + v6 + " " + v26 + ">{v28()}</" + v6 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Th> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v36 : (unit -> leptos_Fragment) = method185()
    let v37 : string = " " + v35 + v2 + ""
    let v38 : (unit -> leptos_Fragment) = method135(v36)
    let v39 : (unit -> leptos_Fragment) = method136(v38)
    let v40 : string = "<" + v6 + " " + v37 + ">{v39()}</" + v6 + ">"
    let v41 : string = "leptos::view! { " + v40 + " }"
    let v42 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : leptos_HtmlElement<leptos_html_Th> = v42 |> unbox
    let v44 : string = "leptos::IntoView::into_view($0)"
    let v45 : leptos_View = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v47 : (unit -> leptos_Fragment) = method186()
    let v48 : string = " " + v46 + v2 + ""
    let v49 : (unit -> leptos_Fragment) = method135(v47)
    let v50 : (unit -> leptos_Fragment) = method136(v49)
    let v51 : string = "<" + v6 + " " + v48 + ">{v50()}</" + v6 + ">"
    let v52 : string = "leptos::view! { " + v51 + " }"
    let v53 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v52
    let v54 : leptos_HtmlElement<leptos_html_Th> = v53 |> unbox
    let v55 : string = "leptos::IntoView::into_view($0)"
    let v56 : leptos_View = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v58 : (unit -> leptos_Fragment) = method187()
    let v59 : string = " " + v57 + v2 + ""
    let v60 : (unit -> leptos_Fragment) = method135(v58)
    let v61 : (unit -> leptos_Fragment) = method136(v60)
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
and method181 () : (unit -> leptos_Fragment) =
    closure223()
and method190 (v0 : int64) : int64 =
    v0
and method191 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method192 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and closure232 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l3
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : int64 = int64 v3
    let v5 : int64 = method190(v4)
    let v6 : int64 = v5 / 1000L
    let v7 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v8 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : US71 option = None
    let _v9 = ref v9 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : chrono_DateTime<chrono_Utc> = x
    let v11 : US71 = US71_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US71 option = _v9.Value 
    let v13 : US71 = US71_1
    let v14 : US71 = v12 |> Option.defaultValue v13 
    let v32 : US34 =
        match v14 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v15) -> (* Some *)
            let v16 : chrono_DateTime<chrono_Utc> = method191(v15)
            let v17 : string = "v16.naive_utc()"
            let v18 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v17
            let v19 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v18)"
            let v20 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : string = "%Y-%m-%d %H:%M:%S"
            let v22 : string = "r#\"" + v21 + "\"#"
            let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v22
            let v24 : chrono_DateTime<chrono_Local> = method192(v20)
            let v25 : string = "v24.format(v23).to_string()"
            let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v25
            let v27 : string = "fable_library_rust::String_::fromString($0)"
            let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27
            US34_0(v28)
    let v38 : US72 =
        match v32 with
        | US34_1 -> (* None *)
            let v35 : string = "resultm.from_option / Option does not have a value."
            US72_1(v35)
        | US34_0(v33) -> (* Some *)
            US72_0(v33)
    let v43 : string =
        match v38 with
        | US72_1(v40) -> (* Error *)
            let v41 : string = "sm'.to_string result / Error: " + v40 + ""
            v41
        | US72_0(v39) -> (* Ok *)
            v39
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "leptos::html::text($0)"
    let v49 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "leptos::IntoView::into_view($0)"
    let v51 : leptos_View = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : (leptos_View []) = [|v51|]
    let v53 : string = "$0.to_vec()"
    let v54 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "leptos::Fragment::new($0)"
    let v56 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v54 v55
    v56
and method189 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure232(v0)
and closure233 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l8
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method193 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure233(v0)
and closure234 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l10
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method194 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure234(v0)
and closure235 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l7
    let v2 : (float -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method195 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure235(v0)
and method197 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure236 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (std_string_String []) = v0.l5
    let v2 : uint64 = System.Convert.ToUInt64 v1.Length
    let v3 : bool = v2 = 0UL
    if v3 then
        let v4 : string = "&*$0"
        let v5 : string = ""
        let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v4
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
        while method197(v18, v20) do
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
        let v45 : string = "&*$0"
        let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v44 v45
        let v47 : string = "String::from($0)"
        let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v46 v47
        let v49 : string = "leptos::html::text($0)"
        let v50 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v48 v49
        let v51 : string = "leptos::IntoView::into_view($0)"
        let v52 : leptos_View = Fable.Core.RustInterop.emitRustExpr v50 v51
        let v53 : (leptos_View []) = [|v52|]
        let v54 : string = "$0.to_vec()"
        let v55 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v53 v54
        let v56 : string = "leptos::Fragment::new($0)"
        let v57 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v55 v56
        v57
and method196 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure236(v0)
and closure237 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>) () : leptos_Fragment =
    let v2 : bool = v0.l6
    let v5 : string =
        if v2 then
            let v3 : string = "Ok"
            v3
        else
            let v4 : string = "Outcome Error"
            v4
    let v6 : (struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option -> US66) = closure145()
    let v7 : (std_string_String -> US66) = closure146()
    let v8 : US66 = match v1 with Ok x -> v6 x | Error x -> v7 x
    let v23 : US62 =
        match v8 with
        | US66_1(v20) -> (* Error *)
            US62_1(v20)
        | US66_0(v9) -> (* Ok *)
            let v10 : US60 option = None
            let _v10 = ref v10 
            match v9 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let struct (v11 : struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option, v12 : std_string_String option, v13 : std_string_String, v14 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) = x
            let v15 : US60 = US60_0(v11, v12, v13, v14)
            v15 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v10.Value <- x
            let v16 : US60 option = _v10.Value 
            let v17 : US60 = US60_1
            let v18 : US60 = v16 |> Option.defaultValue v17 
            US62_0(v18)
    let v91 : US72 =
        match v23 with
        | US62_1(v86) -> (* Error *)
            let v87 : string = "fable_library_rust::String_::fromString($0)"
            let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87
            US72_1(v88)
        | US62_0(v24) -> (* Ok *)
            match v24 with
            | US60_0(v25, v26, v27, v28) -> (* Some *)
                let v29 : US67 option = None
                let _v29 = ref v29 
                match v25 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let struct (v30 : struct (std_string_String option * std_string_String option) option, v31 : std_string_String, v32 : int32, v33 : std_string_String, v34 : std_string_String, v35 : std_string_String) = x
                let v36 : US67 = US67_0(v30, v31, v32, v33, v34, v35)
                v36 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v29.Value <- x
                let v37 : US67 option = _v29.Value 
                let v38 : US67 = US67_1
                let v39 : US67 = v37 |> Option.defaultValue v38 
                match v39 with
                | US67_1 -> (* None *)
                    let v74 : string = $"%A{struct (v25, v26, v27, v28)}"
                    let v75 : int64 = 400L
                    let v76 : string = method64(v75, v74)
                    US72_0(v76)
                | US67_0(v40, v41, v42, v43, v44, v45) -> (* Some *)
                    let v46 : US67 option = None
                    let _v46 = ref v46 
                    match v25 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let struct (v47 : struct (std_string_String option * std_string_String option) option, v48 : std_string_String, v49 : int32, v50 : std_string_String, v51 : std_string_String, v52 : std_string_String) = x
                    let v53 : US67 = US67_0(v47, v48, v49, v50, v51, v52)
                    v53 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v46.Value <- x
                    let v54 : US67 option = _v46.Value 
                    let v55 : US67 = US67_1
                    let v56 : US67 = v54 |> Option.defaultValue v55 
                    let v66 : US34 =
                        match v56 with
                        | US67_0(v57, v58, v59, v60, v61, v62) -> (* Some *)
                            let v63 : string = string v62 + ": " + string v61 + " - " + string v60 + " (" + string v58 + ")"
                            US34_0(v63)
                        | _ ->
                            US34_1
                    let v72 : string =
                        match v66 with
                        | US34_1 -> (* None *)
                            let v68 : string = $"%A{()}"
                            let v69 : int64 = 400L
                            method64(v69, v68)
                        | US34_0(v67) -> (* Some *)
                            v67
                    US72_1(v72)
            | _ ->
                let v80 : string = $"%A{v23}"
                let v81 : int64 = 400L
                let v82 : string = method64(v81, v80)
                let v83 : string = $"RPC Response: {v82}"
                US72_1(v83)
    let v100 : string =
        match v91 with
        | US72_1(v97) -> (* Error *)
            let v98 : string = $"Error: {v97}"
            v98
        | US72_0(v92) -> (* Ok *)
            let v93 : string = $"%A{v92}"
            let v94 : int64 = 400L
            let v95 : string = method64(v94, v93)
            let v96 : string = $"RPC Response: {v95}"
            v96
    let v101 : string = $"{v5} / {v100}"
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v101 v102
    let v104 : string = "String::from($0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v103 v104
    let v106 : string = "leptos::html::text($0)"
    let v107 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v105 v106
    let v108 : string = "leptos::IntoView::into_view($0)"
    let v109 : leptos_View = Fable.Core.RustInterop.emitRustExpr v107 v108
    let v110 : (leptos_View []) = [|v109|]
    let v111 : string = "$0.to_vec()"
    let v112 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v110 v111
    let v113 : string = "leptos::Fragment::new($0)"
    let v114 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v112 v113
    v114
and method198 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>) : (unit -> leptos_Fragment) =
    closure237(v0, v1)
and closure231 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>) () : leptos_Fragment =
    let v2 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v3 : (unit -> leptos_Fragment) = method189(v0)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method135(v3)
    let v7 : (unit -> leptos_Fragment) = method136(v6)
    let v8 : string = "td"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Td> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v16 : (unit -> leptos_Fragment) = method193(v0)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method135(v16)
    let v19 : (unit -> leptos_Fragment) = method136(v18)
    let v20 : string = "<" + v8 + " " + v17 + ">{v19()}</" + v8 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Td> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v27 : (unit -> leptos_Fragment) = method194(v0)
    let v28 : string = " " + v26 + v4 + ""
    let v29 : (unit -> leptos_Fragment) = method135(v27)
    let v30 : (unit -> leptos_Fragment) = method136(v29)
    let v31 : string = "<" + v8 + " " + v28 + ">{v30()}</" + v8 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Td> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v38 : (unit -> leptos_Fragment) = method195(v0)
    let v39 : string = " " + v37 + v4 + ""
    let v40 : (unit -> leptos_Fragment) = method135(v38)
    let v41 : (unit -> leptos_Fragment) = method136(v40)
    let v42 : string = "<" + v8 + " " + v39 + ">{v41()}</" + v8 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : leptos_HtmlElement<leptos_html_Td> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v49 : (unit -> leptos_Fragment) = method196(v0)
    let v50 : string = " " + v48 + v4 + ""
    let v51 : (unit -> leptos_Fragment) = method135(v49)
    let v52 : (unit -> leptos_Fragment) = method136(v51)
    let v53 : string = "<" + v8 + " " + v50 + ">{v52()}</" + v8 + ">"
    let v54 : string = "leptos::view! { " + v53 + " }"
    let v55 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : leptos_HtmlElement<leptos_html_Td> = v55 |> unbox
    let v57 : string = "leptos::IntoView::into_view($0)"
    let v58 : leptos_View = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v60 : (unit -> leptos_Fragment) = method198(v0, v1)
    let v61 : string = " " + v59 + v4 + ""
    let v62 : (unit -> leptos_Fragment) = method135(v60)
    let v63 : (unit -> leptos_Fragment) = method136(v62)
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
and method188 (v0 : Heap5, v1 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>) : (unit -> leptos_Fragment) =
    closure231(v0, v1)
and closure230 (v0 : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])) struct (v1 : string, v2 : unativeint, v3 : Heap5) : leptos_View =
    let v4 : int32 = int32 v2
    let v5 : Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> = v0.[int v4]
    let v6 : string = "class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\""
    let v7 : (unit -> leptos_Fragment) = method188(v3, v5)
    let v8 : string = ""
    let v9 : string = " " + v6 + v8 + ""
    let v10 : (unit -> leptos_Fragment) = method135(v7)
    let v11 : (unit -> leptos_Fragment) = method136(v10)
    let v12 : string = "tr"
    let v13 : string = "<" + v12 + " " + v9 + ">{v11()}</" + v12 + ">"
    let v14 : string = "leptos::view! { " + v13 + " }"
    let v15 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : leptos_HtmlElement<leptos_html_Tr> = v15 |> unbox
    let v17 : string = "leptos::IntoView::into_view($0)"
    let v18 : leptos_View = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and closure239 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method200 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure239(v0)
and closure240 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method201 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure240(v0)
and closure238 (v0 : leptos_Fragment, v1 : leptos_Fragment) () : leptos_Fragment =
    let v2 : string = "class=\"ltr:text-left rtl:text-right\""
    let v3 : (unit -> leptos_Fragment) = method200(v0)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method135(v3)
    let v7 : (unit -> leptos_Fragment) = method136(v6)
    let v8 : string = "thead"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Thead> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "class=\"divide-y divide-gray-200 dark:divide-gray-700\""
    let v16 : (unit -> leptos_Fragment) = method201(v1)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method135(v16)
    let v19 : (unit -> leptos_Fragment) = method136(v18)
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
and method199 (v0 : leptos_Fragment, v1 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure238(v0, v1)
and closure243 () () : string =
    let v0 : string = "[width:24px] [height:30px]"
    v0
and closure242 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure243()
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
    let v12 : (unit -> leptos_Fragment) = method162()
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
    let v23 : (unit -> leptos_Fragment) = method135(v12)
    let v24 : (unit -> leptos_Fragment) = method136(v23)
    let v25 : string = "svg"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_svg_Svg> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "Loading..."
    let v33 : string = "&*$0"
    let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "String::from($0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "leptos::html::text($0)"
    let v38 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "leptos::IntoView::into_view($0)"
    let v40 : leptos_View = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : (leptos_View []) = [|v31; v40|]
    let v42 : string = "$0.to_vec()"
    let v43 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "leptos::Fragment::new($0)"
    let v45 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v43 v44
    v45
and method203 () : (unit -> leptos_Fragment) =
    closure242()
and closure241 () () : leptos_Fragment =
    let v0 : string = "class=\"flex flex-1 [gap:4px] items-center\""
    let v1 : (unit -> leptos_Fragment) = method203()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
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
and method202 () : (unit -> leptos_Fragment) =
    closure241()
and closure217 (v0 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])>, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) () : leptos_Fragment =
    let v3 : string = $"$0()"
    let v4 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v6 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) []) = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : uint64 = System.Convert.ToUInt64 v6.Length
    let v8 : bool = v7 = 0UL
    let v118 : leptos_View =
        if v8 then
            let v9 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v10 : (unit -> leptos_Fragment) = method175()
            let v11 : string = ""
            let v12 : string = " " + v9 + v11 + ""
            let v13 : (unit -> leptos_Fragment) = method135(v10)
            let v14 : (unit -> leptos_Fragment) = method136(v13)
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
            let v24 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure109()
            let v25 : (std_string_String -> US56) = closure110()
            let v26 : US56 = match v23 with Ok x -> v24 x | Error x -> v25 x
            let v38 : US49 =
                match v26 with
                | US56_1(v35) -> (* Error *)
                    US49_1(v35)
                | US56_0(v27) -> (* Ok *)
                    let v28 : US50 option = None
                    let _v28 = ref v28 
                    match v27 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v29 : (struct (string * unativeint * Heap5) []) = x
                    let v30 : US50 = US50_0(v29)
                    v30 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v28.Value <- x
                    let v31 : US50 option = _v28.Value 
                    let v32 : US50 = US50_1
                    let v33 : US50 = v31 |> Option.defaultValue v32 
                    US49_0(v33)
            match v38 with
            | US49_1(v100) -> (* Error *)
                let v101 : string = "fable_library_rust::String_::fromString($0)"
                let v102 : string = Fable.Core.RustInterop.emitRustExpr v100 v101
                let v103 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
                let v104 : (unit -> leptos_Fragment) = method167(v102)
                let v105 : string = ""
                let v106 : string = " " + v103 + v105 + ""
                let v107 : (unit -> leptos_Fragment) = method135(v104)
                let v108 : (unit -> leptos_Fragment) = method136(v107)
                let v109 : string = "div"
                let v110 : string = "<" + v109 + " " + v106 + ">{v108()}</" + v109 + ">"
                let v111 : string = "leptos::view! { " + v110 + " }"
                let v112 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v111
                let v113 : leptos_HtmlElement<leptos_html_Div> = v112 |> unbox
                let v114 : string = "leptos::IntoView::into_view($0)"
                let v115 : leptos_View = Fable.Core.RustInterop.emitRustExpr v113 v114
                v115
            | US49_0(v39) -> (* Ok *)
                match v39 with
                | US50_0(v40) -> (* Some *)
                    let v41 : string = "$0.to_vec()"
                    let v42 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v40 v41
                    let v43 : (struct (string * unativeint * Heap5) -> bool) = method177()
                    let v44 : Vec<struct (string * unativeint * Heap5)> = method180(v42)
                    let v45 : string = "v44.into_iter().filter(|x| v43(x.clone().clone())).collect()"
                    let v46 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v45
                    let v47 : (unit -> leptos_Fragment) = method181()
                    let v48 : (unit -> leptos_Fragment) = method135(v47)
                    let v49 : (unit -> leptos_Fragment) = method136(v48)
                    let v50 : string = "tr"
                    let v51 : string = ""
                    let v52 : string = "<" + v50 + " " + v51 + ">{v49()}</" + v50 + ">"
                    let v53 : string = "leptos::view! { " + v52 + " }"
                    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53
                    let v55 : leptos_HtmlElement<leptos_html_Tr> = v54 |> unbox
                    let v56 : string = "leptos::IntoView::into_view($0)"
                    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56
                    let v58 : (leptos_View []) = [|v57|]
                    let v59 : string = "$0.to_vec()"
                    let v60 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v58 v59
                    let v61 : string = "leptos::Fragment::new($0)"
                    let v62 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v60 v61
                    let v63 : string = $"$0()"
                    let v64 : (Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v0 v63
                    let v65 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v66 : (struct (string * unativeint * Heap5) -> leptos_View) = closure230(v64)
                    let v67 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v46, v66) v65
                    let v68 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v69 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v67 v68
                    let v70 : string = "$0.to_vec()"
                    let v71 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v69 v70
                    let v72 : string = "leptos::Fragment::new($0)"
                    let v73 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v71 v72
                    let v74 : string = "class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\""
                    let v75 : (unit -> leptos_Fragment) = method199(v62, v73)
                    let v76 : string = " " + v74 + v51 + ""
                    let v77 : (unit -> leptos_Fragment) = method135(v75)
                    let v78 : (unit -> leptos_Fragment) = method136(v77)
                    let v79 : string = "table"
                    let v80 : string = "<" + v79 + " " + v76 + ">{v78()}</" + v79 + ">"
                    let v81 : string = "leptos::view! { " + v80 + " }"
                    let v82 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v81
                    let v83 : leptos_HtmlElement<leptos_html_Table> = v82 |> unbox
                    let v84 : string = "leptos::IntoView::into_view($0)"
                    let v85 : leptos_View = Fable.Core.RustInterop.emitRustExpr v83 v84
                    v85
                | _ ->
                    let v86 : string = "class=\"grid place-content-center py-[10vh]\""
                    let v87 : (unit -> leptos_Fragment) = method202()
                    let v88 : string = ""
                    let v89 : string = " " + v86 + v88 + ""
                    let v90 : (unit -> leptos_Fragment) = method135(v87)
                    let v91 : (unit -> leptos_Fragment) = method136(v90)
                    let v92 : string = "div"
                    let v93 : string = "<" + v92 + " " + v89 + ">{v91()}</" + v92 + ">"
                    let v94 : string = "leptos::view! { " + v93 + " }"
                    let v95 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v94
                    let v96 : leptos_HtmlElement<leptos_html_Div> = v95 |> unbox
                    let v97 : string = "leptos::IntoView::into_view($0)"
                    let v98 : leptos_View = Fable.Core.RustInterop.emitRustExpr v96 v97
                    v98
    let v119 : (leptos_View []) = [|v118|]
    let v120 : string = "$0.to_vec()"
    let v121 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v119 v120
    let v122 : string = "leptos::Fragment::new($0)"
    let v123 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v121 v122
    v123
and method174 (v0 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])>, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>) : (unit -> leptos_Fragment) =
    closure217(v0, v1, v2)
and closure246 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure247 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure250 () () : string =
    let v0 : string = "History"
    v0
and method208 () : (unit -> string) =
    closure250()
and closure249 () () : leptos_Fragment =
    let v0 : (unit -> string) = method208()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method152(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method207 () : (unit -> leptos_Fragment) =
    closure249()
and closure248 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method207()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method153()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method206 () : (unit -> leptos_Fragment) =
    closure248()
and closure245 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure246()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure247()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method206()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method135(v8)
    let v12 : (unit -> leptos_Fragment) = method136(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method155(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method135(v21)
    let v24 : (unit -> leptos_Fragment) = method136(v23)
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
and method205 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure245(v0)
and closure244 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure209()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure210()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method147(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method205(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method204 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure244(v0, v1)
and closure253 (v0 : int32) (v1 : (bool * std_string_String)) : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) =
    let v2 : string = $"leptos::create_signal($0)"
    let struct (v3 : leptos_ReadSignal<(bool * std_string_String)>, v4 : leptos_WriteSignal<(bool * std_string_String)>) = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v5 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = v0, struct (v3, v4)
    v5
and closure252 () (v0 : int32) : ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) =
    closure253(v0)
and method209 () : (int32 -> ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)))) =
    closure252()
and method210 (v0 : Vec<(bool * std_string_String)>) : Vec<(bool * std_string_String)> =
    v0
and closure251 (v0 : Heap2) () : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<Heap0> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : Vec<(bool * std_string_String)> = v6.l1
    let v8 : (int32 -> ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)))) = method209()
    let v9 : Vec<(bool * std_string_String)> = method210(v7)
    let v10 : string = "v9.iter().enumerate().map(|(i, x)| v8(i.try_into().unwrap())(x.clone())).collect()"
    let v11 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v10
    v11
and closure255 () (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>) =
    let (a, b) = v0
    let v1 : int32 = a
    let struct (v2 : leptos_ReadSignal<(bool * std_string_String)>, v3 : leptos_WriteSignal<(bool * std_string_String)>) = b
    struct (v1, v2, v3)
and closure256 (v0 : int32) struct (v1 : int32, v2 : leptos_ReadSignal<(bool * std_string_String)>, v3 : leptos_WriteSignal<(bool * std_string_String)>) : struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) =
    struct (v0, v1, v2)
and closure254 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v1 : leptos_ReadSignal<int32>) () : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = $"$0()"
    let v5 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr v0 v4
    let v6 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v7 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = closure255()
    let v8 : Vec<struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v10 : (struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>) -> struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)) = closure256(v3)
    let v11 : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9
    v11
and closure257 (v0 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>) () : int32 =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v4 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) []) = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : int32 = v4.Length
    v5
and method211 (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) =
    v0
and method212 (v0 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    v0
and closure261 () (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : (bool * std_string_String) =
    let (a, b) = v0
    let v1 : int32 = a
    let struct (v2 : leptos_ReadSignal<(bool * std_string_String)>, v3 : leptos_WriteSignal<(bool * std_string_String)>) = b
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v2 v4
    v5
and closure260 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>) (v1 : Heap0) : Heap0 =
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
    let v12 : string = "&*$0"
    let v13 : string = ""
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v12
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : (bool * std_string_String) = false, v16
    let v18 : string = $"leptos::create_signal($0)"
    let struct (v19 : leptos_ReadSignal<(bool * std_string_String)>, v20 : leptos_WriteSignal<(bool * std_string_String)>) = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v21 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = v11, struct (v19, v20)
    let v22 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = method211(v21)
    let v23 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = method212(v8)
    let v24 : string = "true; let mut v23 = v23"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : string = "true; v23.push(v22)"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : string = "v23"
    let v29 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v31 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> (bool * std_string_String)) = closure261()
    let v32 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v30
    {l0 = v2; l1 = v32; l2 = v4; l3 = v5; l4 = v6} : Heap0
and closure262 () (v0 : int32) : int32 =
    let v1 : int32 = 1 + v0
    v1
and closure259 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>) () : unit =
    let v3 : leptos_RwSignal<Heap1> = v0.l0
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : leptos_RwSignal<Heap0> = v5.l1
    let v7 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v8 : (Heap0 -> Heap0) = closure260(v1)
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr struct (v6, v8) v7
    let v10 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v11 : (int32 -> int32) = closure262()
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v11) v10
    ()
and closure258 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>) () : unit =
    let v3 : string = "true; leptos::batch(move || $0());"
    let v4 : (unit -> unit) = closure259(v0, v1, v2)
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v4 v3
    ()
and closure263 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure264 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M12 6v12m6-6H6\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure164()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method213 () : (unit -> leptos_Fragment) =
    closure264()
and closure265 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = " bg-gray-300 hover:bg-gray-200"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure266 (v0 : leptos_HtmlElement<leptos_svg_Svg>) () : leptos_Fragment =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (leptos_View []) = [|v2|]
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "leptos::Fragment::new($0)"
    let v7 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v5 v6
    v7
and method214 (v0 : leptos_HtmlElement<leptos_svg_Svg>) : (unit -> leptos_Fragment) =
    closure266(v0)
and method217 (v0 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>) : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> =
    v0
and closure269 () struct (v0 : int32, v1 : int32, v2 : leptos_ReadSignal<(bool * std_string_String)>) : struct (int32 * int32) =
    struct (v0, v1)
and method218 () : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> struct (int32 * int32)) =
    closure269()
and method221 (v0 : int32) : int32 =
    v0
and closure272 (v0 : int32) () : std_string_String =
    let v1 : string = "account-" + string v0 + ""
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and method224 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure276 (v0 : int32, v1 : int32) (v2 : (bool * std_string_String)) : (bool * std_string_String) =
    let v3 : bool = v1 = v0
    let v4 : bool = method224(v3)
    if v4 then
        v2
    else
        let (a, b) = v2
        let v5 : bool = a
        let v6 : std_string_String = b
        let v7 : bool = v5 = false
        let v8 : (bool * std_string_String) = v7, v6
        v8
and closure275 (v0 : int32) (v1 : int32) : ((bool * std_string_String) -> (bool * std_string_String)) =
    closure276(v0, v1)
and method223 (v0 : int32) : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) =
    closure275(v0)
and closure274 (v0 : Heap2, v1 : int32) (v2 : leptos_ev_Event) : unit =
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
    let v17 : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) = method223(v1)
    let v18 : Vec<(bool * std_string_String)> = method210(v10)
    let v19 : string = "v18.iter().enumerate().map(|(i, x)| v17(i.try_into().unwrap())(x.clone())).collect()"
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : Heap0 = {l0 = v9; l1 = v20; l2 = v11; l3 = v12; l4 = v13} : Heap0
    let v22 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr struct (v16, v21) v22
    ()
and closure277 (v0 : leptos_ReadSignal<(bool * std_string_String)>) () : bool =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v0 v1
    let (a, b) = v2
    let v3 : bool = a
    let v4 : std_string_String = b
    v3
and method225 (v0 : leptos_ReadSignal<(bool * std_string_String)>) : (unit -> bool) =
    closure277(v0)
and method226 (v0 : int32) : (unit -> std_string_String) =
    closure272(v0)
and closure279 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure164()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method228 () : (unit -> leptos_Fragment) =
    closure279()
and closure280 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure164()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method229 () : (unit -> leptos_Fragment) =
    closure280()
and closure281 () (v0 : leptos_HtmlElement<leptos_svg_Svg>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure278 () () : leptos_Fragment =
    let v0 : string = "data-unchecked-icon"
    let v1 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v2 : string = "class=\"h-4 w-4\""
    let v3 : string = "viewBox=\"0 0 20 20\""
    let v4 : string = "fill=\"currentColor\""
    let v5 : (unit -> leptos_Fragment) = method228()
    let v6 : string = ""
    let v7 : string = " " + v0 + v6 + ""
    let v8 : string = " " + v1 + v7 + ""
    let v9 : string = " " + v2 + v8 + ""
    let v10 : string = " " + v3 + v9 + ""
    let v11 : string = " " + v4 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v5)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
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
    let v24 : (unit -> leptos_Fragment) = method229()
    let v25 : string = " " + v19 + v6 + ""
    let v26 : string = " " + v20 + v25 + ""
    let v27 : string = " " + v21 + v26 + ""
    let v28 : string = " " + v22 + v27 + ""
    let v29 : string = " " + v23 + v28 + ""
    let v30 : (unit -> leptos_Fragment) = method135(v24)
    let v31 : (unit -> leptos_Fragment) = method136(v30)
    let v32 : string = "<" + v14 + " " + v29 + ">{v31()}</" + v14 + ">"
    let v33 : string = "leptos::view! { " + v32 + " }"
    let v34 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : leptos_HtmlElement<leptos_svg_Svg> = v34 |> unbox
    let v36 : (leptos_HtmlElement<leptos_svg_Svg> []) = [|v18; v35|]
    let v37 : string = "$0.to_vec()"
    let v38 : Vec<leptos_HtmlElement<leptos_svg_Svg>> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v40 : (leptos_HtmlElement<leptos_svg_Svg> -> leptos_View) = closure281()
    let v41 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v38, v40) v39
    let v42 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v43 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "$0.to_vec()"
    let v45 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "leptos::Fragment::new($0)"
    let v47 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v45 v46
    v47
and method227 () : (unit -> leptos_Fragment) =
    closure278()
and closure282 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method230 () : (unit -> leptos_Fragment) =
    closure282()
and closure273 (v0 : int32, v1 : leptos_ReadSignal<(bool * std_string_String)>, v2 : Heap2) () : leptos_Fragment =
    let v3 : (leptos_ev_Event -> unit) = closure274(v2, v0)
    let v4 : string = "let v3 = $0"
    Fable.Core.RustInterop.emitRustExpr v3 v4
    let v5 : (unit -> bool) = method225(v1)
    let v6 : (unit -> std_string_String) = method226(v0)
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
    let v26 : (unit -> leptos_Fragment) = method227()
    let v27 : string = " " + v25 + v12 + ""
    let v28 : (unit -> leptos_Fragment) = method135(v26)
    let v29 : (unit -> leptos_Fragment) = method136(v28)
    let v30 : string = "span"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Span> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v38 : (unit -> leptos_Fragment) = method230()
    let v39 : string = " " + v37 + v12 + ""
    let v40 : (unit -> leptos_Fragment) = method135(v38)
    let v41 : (unit -> leptos_Fragment) = method136(v40)
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
and method222 (v0 : int32, v1 : leptos_ReadSignal<(bool * std_string_String)>, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure273(v0, v1, v2)
and closure283 (v0 : leptos_ReadSignal<(bool * std_string_String)>) () : std_string_String =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v0 v1
    let (a, b) = v2
    let v3 : bool = a
    let v4 : std_string_String = b
    v4
and method231 (v0 : leptos_ReadSignal<(bool * std_string_String)>) : (unit -> std_string_String) =
    closure283(v0)
and method234 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure286 (v0 : int32, v1 : std_string_String, v2 : int32) (v3 : (bool * std_string_String)) : (bool * std_string_String) =
    let v4 : bool = v2 = v0
    let v5 : bool = method234(v4)
    if v5 then
        v3
    else
        let (a, b) = v3
        let v6 : bool = a
        let v7 : std_string_String = b
        let v8 : (bool * std_string_String) = v6, v1
        v8
and closure285 (v0 : int32, v1 : std_string_String) (v2 : int32) : ((bool * std_string_String) -> (bool * std_string_String)) =
    closure286(v0, v1, v2)
and method233 (v0 : int32, v1 : std_string_String) : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) =
    closure285(v0, v1)
and closure284 (v0 : Heap2, v1 : int32) (v2 : std_string_String) : unit =
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
    let v17 : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) = method233(v1, v2)
    let v18 : Vec<(bool * std_string_String)> = method210(v10)
    let v19 : string = "v18.iter().enumerate().map(|(i, x)| v17(i.try_into().unwrap())(x.clone())).collect()"
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : Heap0 = {l0 = v9; l1 = v20; l2 = v11; l3 = v12; l4 = v13} : Heap0
    let v22 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr struct (v16, v21) v22
    ()
and method232 (v0 : Heap2, v1 : int32) : (std_string_String -> unit) =
    closure284(v0, v1)
and closure287 () () : string =
    let v0 : string = "flex-1"
    v0
and method235 (v0 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    v0
and closure292 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method237 () : (bool -> bool) =
    closure292()
and closure291 (v0 : int32) (v1 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : bool =
    let (a, b) = v1
    let v2 : int32 = a
    let struct (v3 : leptos_ReadSignal<(bool * std_string_String)>, v4 : leptos_WriteSignal<(bool * std_string_String)>) = b
    let v5 : bool = v2 = v0
    let v6 : (bool -> bool) = method237()
    v6 v5
and method236 (v0 : int32) : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> bool) =
    closure291(v0)
and closure290 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v1 : int32) (v2 : Heap0) : Heap0 =
    let v3 : std_string_String option = v2.l0
    let v4 : Vec<(bool * std_string_String)> = v2.l1
    let v5 : int32 = v2.l2
    let v6 : int32 = v2.l3
    let v7 : US1 = v2.l4
    let v8 : string = $"$0()"
    let v9 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr v0 v8
    let v10 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = method235(v9)
    let v11 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> bool) = method236(v1)
    let v12 : string = "true; let mut v10 = v10"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "true; v10.retain(|x| v11(x.clone()))"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "v10"
    let v17 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> (bool * std_string_String)) = closure261()
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    {l0 = v3; l1 = v20; l2 = v5; l3 = v6; l4 = v7} : Heap0
and closure289 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>, v3 : int32) () : unit =
    let v4 : leptos_RwSignal<Heap1> = v0.l0
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap1 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : leptos_RwSignal<Heap0> = v6.l1
    let v8 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v9 : (Heap0 -> Heap0) = closure290(v1, v3)
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v12 : (int32 -> int32) = closure262()
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v12) v11
    ()
and closure288 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>, v3 : int32) () : unit =
    let v4 : string = "true; leptos::batch(move || $0());"
    let v5 : (unit -> unit) = closure289(v0, v1, v2, v3)
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v5 v4
    ()
and closure293 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure294 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M6 6l12 12m0-12L6 18\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure164()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method238 () : (unit -> leptos_Fragment) =
    closure294()
and closure295 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = " pr-[7px] pl-[5px]"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure271 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>, v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : int32) () : leptos_Fragment =
    let v6 : int32 = method221(v5)
    let v7 : (unit -> std_string_String) = closure272(v6)
    let v8 : string = "let v7 = $0"
    Fable.Core.RustInterop.emitRustExpr v7 v8
    let v9 : string = "for=move || v7()"
    let v10 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v11 : (unit -> leptos_Fragment) = method222(v6, v4, v0)
    let v12 : string = ""
    let v13 : string = " " + v9 + v12 + ""
    let v14 : string = " " + v10 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method135(v11)
    let v16 : (unit -> leptos_Fragment) = method136(v15)
    let v17 : string = "label"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Label> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (unit -> std_string_String) = method231(v4)
    let v25 : (std_string_String -> unit) = method232(v0, v6)
    let v26 : string = "$0"
    let v27 : (unit -> string) = closure287()
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
            let v46 : (leptos_View []) = method125(v45)
            let v47 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v48 : leptos_View = Fable.Core.RustInterop.emitRustExpr v46 v47
            v48
        else
            let v49 : (unit -> unit) = closure288(v0, v2, v3, v6)
            let v50 : string = "let v49 = $0"
            Fable.Core.RustInterop.emitRustExpr v49 v50
            let v51 : string = "$0"
            let v52 : (unit -> string) = closure293()
            let v53 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v52 v51
            let v54 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v55 : string = "fill=\"none\""
            let v56 : string = "viewBox=\"0 0 24 24\""
            let v57 : string = "stroke-width=\"1.5\""
            let v58 : string = "stroke=\"currentColor\""
            let v59 : string = "class=move || \" \".to_owned() + &v53(())"
            let v60 : (unit -> leptos_Fragment) = method238()
            let v61 : string = " " + v54 + v12 + ""
            let v62 : string = " " + v55 + v61 + ""
            let v63 : string = " " + v56 + v62 + ""
            let v64 : string = " " + v57 + v63 + ""
            let v65 : string = " " + v58 + v64 + ""
            let v66 : string = " " + v59 + v65 + ""
            let v67 : (unit -> leptos_Fragment) = method135(v60)
            let v68 : (unit -> leptos_Fragment) = method136(v67)
            let v69 : string = "svg"
            let v70 : string = "<" + v69 + " " + v66 + ">{v68()}</" + v69 + ">"
            let v71 : string = "leptos::view! { " + v70 + " }"
            let v72 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v71
            let v73 : leptos_HtmlElement<leptos_svg_Svg> = v72 |> unbox
            let v74 : string = "on:click=move |_| v49()"
            let v75 : string = "aria-label=\"Delete\""
            let v76 : string = "$0"
            let v77 : (unit -> std_string_String) = closure295()
            let v78 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v77 v76
            let v79 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v78(())"
            let v80 : (unit -> leptos_Fragment) = method214(v73)
            let v81 : string = " " + v79 + v12 + ""
            let v82 : string = " " + v74 + v81 + ""
            let v83 : string = " " + v75 + v82 + ""
            let v84 : (unit -> leptos_Fragment) = method135(v80)
            let v85 : (unit -> leptos_Fragment) = method136(v84)
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
and method220 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>, v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : int32) : (unit -> leptos_Fragment) =
    closure271(v0, v1, v2, v3, v4, v5)
and closure270 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>) struct (v4 : int32, v5 : int32, v6 : leptos_ReadSignal<(bool * std_string_String)>) : leptos_Fragment =
    let v7 : string = "class=\"flex gap-[8px] [align-items:center]\""
    let v8 : (unit -> leptos_Fragment) = method220(v0, v1, v2, v3, v6, v5)
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method135(v8)
    let v12 : (unit -> leptos_Fragment) = method136(v11)
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
and method219 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>) : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> leptos_Fragment) =
    closure270(v0, v1, v2, v3)
and closure268 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) () : leptos_Fragment =
    let v5 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> = method217(v1)
    let v6 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> struct (int32 * int32)) = method218()
    let v7 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> leptos_Fragment) = method219(v0, v2, v3, v4)
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
and method216 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) : (unit -> leptos_Fragment) =
    closure268(v0, v1, v2, v3, v4)
and closure267 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) () : leptos_Fragment =
    let v5 : string = "class=\"flex flex-1 flex-col p-[8px] gap-[8px]\""
    let v6 : (unit -> leptos_Fragment) = method216(v0, v1, v2, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
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
and method215 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) : (unit -> leptos_Fragment) =
    closure267(v0, v1, v2, v3, v4)
and closure298 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure299 (v0 : leptos_View) () : StaticRef<Str> =
    let v4 : string = "[margin-right:40px]"
    let v5 : string = "r#\"" + v4 + "\"#"
    let v6 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and closure302 () () : string =
    let v0 : string = "Accounts"
    v0
and method243 (v0 : leptos_View) : (unit -> string) =
    closure302()
and closure301 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (unit -> string) = method243(v0)
    let v2 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v3 : (unit -> leptos_Fragment) = method152(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method135(v3)
    let v7 : (unit -> leptos_Fragment) = method136(v6)
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
and method242 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure301(v0)
and closure300 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : string = "class=\"flex items-center gap-2\""
    let v2 : (unit -> leptos_Fragment) = method242(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v15 : (unit -> leptos_Fragment) = method153()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v15)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
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
and method241 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure300(v0)
and closure297 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure298()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> StaticRef<Str>) = closure299(v0)
    let v7 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v7(()) + \" \" + &v4(())"
    let v9 : (unit -> leptos_Fragment) = method241(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "summary"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Summary> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=\"flex flex-1 flex-col\""
    let v22 : (unit -> leptos_Fragment) = method155(v1)
    let v23 : string = " " + v21 + v10 + ""
    let v24 : (unit -> leptos_Fragment) = method135(v22)
    let v25 : (unit -> leptos_Fragment) = method136(v24)
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
and method240 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure297(v0, v1)
and closure296 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure209()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure210()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method147(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method240(v0, v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method239 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure296(v0, v1)
and closure305 () () : string =
    let v0 : string = "items-center p-0"
    v0
and closure306 () () : string =
    let v0 : string = "pt-[9px] pr-[10px] pb-[11px] pl-[10px]"
    v0
and closure307 () () : string =
    let v0 : string = "sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]"
    v0
and closure308 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Dark Mode"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method246 () : (unit -> leptos_Fragment) =
    closure308()
and closure310 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = "dark-mode"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure313 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure312 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<bool> = v4.l0
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure313()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    ()
and closure314 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<bool> = v3.l0
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method249 (v0 : Heap2) : (unit -> bool) =
    closure314(v0)
and method250 () : (unit -> std_string_String) =
    closure310()
and closure311 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure312(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : (unit -> bool) = method249(v0)
    let v4 : (unit -> std_string_String) = method250()
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
    let v24 : (unit -> leptos_Fragment) = method227()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v24)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method230()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method135(v36)
    let v39 : (unit -> leptos_Fragment) = method136(v38)
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
and method248 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure311(v0)
and closure309 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure310()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method248(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v5)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
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
and method247 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure309(v0)
and closure316 () () : string =
    let v0 : string = "[overflow:auto]"
    v0
and method252 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    v0
and closure315 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method251 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure315(v0, v1)
and closure317 () () : string =
    let v0 : string = "items-center p-0"
    v0
and closure318 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Debug"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method253 () : (unit -> leptos_Fragment) =
    closure318()
and closure320 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = "debug"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure322 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<bool> = v4.l2
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure313()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    ()
and closure323 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : leptos_RwSignal<bool> = v3.l2
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
    v6
and method256 (v0 : Heap2) : (unit -> bool) =
    closure323(v0)
and method257 () : (unit -> std_string_String) =
    closure320()
and closure321 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure322(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : (unit -> bool) = method256(v0)
    let v4 : (unit -> std_string_String) = method257()
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
    let v24 : (unit -> leptos_Fragment) = method227()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v24)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method230()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method135(v36)
    let v39 : (unit -> leptos_Fragment) = method136(v38)
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
and method255 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure321(v0)
and closure319 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure320()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method255(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v5)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
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
and method254 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure319(v0)
and closure324 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method258 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure324(v0, v1)
and closure325 () (v0 : leptos_HtmlElement<leptos_html_Dl>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure304 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure305()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure306()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure307()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : (unit -> leptos_Fragment) = method246()
    let v11 : (unit -> leptos_Fragment) = method247(v0)
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v9(()) + \" \" + &v6(()) + \" \" + &v3(())"
    let v13 : (unit -> leptos_Fragment) = method251(v10, v11)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v13)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
    let v18 : string = "dl"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Dl> = v21 |> unbox
    let v23 : string = "$0"
    let v24 : (unit -> string) = closure317()
    let v25 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v24 v23
    let v26 : string = "$0"
    let v27 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v26
    let v28 : string = "$0"
    let v29 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v28
    let v30 : (unit -> leptos_Fragment) = method253()
    let v31 : (unit -> leptos_Fragment) = method254(v0)
    let v32 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v29(()) + \" \" + &v27(()) + \" \" + &v25(())"
    let v33 : (unit -> leptos_Fragment) = method258(v30, v31)
    let v34 : string = " " + v32 + v14 + ""
    let v35 : (unit -> leptos_Fragment) = method135(v33)
    let v36 : (unit -> leptos_Fragment) = method136(v35)
    let v37 : string = "<" + v18 + " " + v34 + ">{v36()}</" + v18 + ">"
    let v38 : string = "leptos::view! { " + v37 + " }"
    let v39 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : leptos_HtmlElement<leptos_html_Dl> = v39 |> unbox
    let v41 : (leptos_HtmlElement<leptos_html_Dl> []) = [|v22; v40|]
    let v42 : string = "$0.to_vec()"
    let v43 : Vec<leptos_HtmlElement<leptos_html_Dl>> = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v45 : (leptos_HtmlElement<leptos_html_Dl> -> leptos_View) = closure325()
    let v46 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v43, v45) v44
    let v47 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v48 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "$0.to_vec()"
    let v50 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "leptos::Fragment::new($0)"
    let v52 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v50 v51
    v52
and method245 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure304(v0)
and closure303 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col p-[11px] gap-[11px]\""
    let v2 : (unit -> leptos_Fragment) = method245(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method244 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure303(v0)
and closure328 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure329 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure332 () () : string =
    let v0 : string = "View"
    v0
and method263 () : (unit -> string) =
    closure332()
and closure331 () () : leptos_Fragment =
    let v0 : (unit -> string) = method263()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method152(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method262 () : (unit -> leptos_Fragment) =
    closure331()
and closure330 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method262()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method153()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method261 () : (unit -> leptos_Fragment) =
    closure330()
and closure327 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure328()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure329()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method261()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method135(v8)
    let v12 : (unit -> leptos_Fragment) = method136(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method155(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method135(v21)
    let v24 : (unit -> leptos_Fragment) = method136(v23)
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
and method260 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure327(v0)
and closure326 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure209()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure210()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method147(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method260(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method259 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure326(v0, v1)
and closure334 () () : string =
    let v0 : string = ""
    v0
and closure335 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Global State"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method265 () : (unit -> leptos_Fragment) =
    closure335()
and method267 (v0 : Heap2) : Heap2 =
    v0
and closure338 () (v0 : std_string_String) : US73 =
    US73_0(v0)
and closure339 () (v0 : std_string_String) : US73 =
    US73_1(v0)
and closure337 (v0 : Heap2) () : string =
    let v1 : string = "settings_view.global_state_log_render () / global_state_json memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : Heap2 = method267(v0)
    let v5 : string = "serde_json::to_string_pretty(&v4).map_err(|x| x.to_string())"
    let v6 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_string_String -> US73) = closure338()
    let v8 : (std_string_String -> US73) = closure339()
    let v9 : US73 = match v6 with Ok x -> v7 x | Error x -> v8 x
    match v9 with
    | US73_1(v13) -> (* Error *)
        let v14 : string = "Error: " + string v13 + ""
        v14
    | US73_0(v10) -> (* Ok *)
        let v11 : string = "fable_library_rust::String_::fromString($0)"
        let v12 : string = Fable.Core.RustInterop.emitRustExpr v10 v11
        v12
and closure340 () () : string =
    let v0 : string = ""
    v0
and closure341 (v0 : string) () : leptos_Fragment =
    let v1 : string = "&*$0"
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
and method268 (v0 : string) : (unit -> leptos_Fragment) =
    closure341(v0)
and closure336 () () : leptos_Fragment =
    let v0 : string = "settings_view.global_state_log_render ()"
    let v1 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
    let v4 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "$0.unwrap()"
    let v6 : Heap2 = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure337(v6)
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : string = "leptos::create_memo(move |_| { v9(()) })"
    let v11 : leptos_Memo<string> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = $"$0()"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0"
    let v15 : (unit -> string) = closure340()
    let v16 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v15 v14
    let v17 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v16(())"
    let v18 : (unit -> leptos_Fragment) = method268(v13)
    let v19 : string = ""
    let v20 : string = " " + v17 + v19 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v18)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method266 () : (unit -> leptos_Fragment) =
    closure336()
and closure342 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method269 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure342(v0, v1)
and closure333 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure334()
    let v2 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "$0"
    let v4 : (unit -> string) = closure306()
    let v5 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v4 v3
    let v6 : string = "$0"
    let v7 : (unit -> string) = closure307()
    let v8 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v6
    let v9 : (unit -> leptos_Fragment) = method265()
    let v10 : (unit -> leptos_Fragment) = method266()
    let v11 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v8(()) + \" \" + &v5(()) + \" \" + &v2(())"
    let v12 : (unit -> leptos_Fragment) = method269(v9, v10)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method135(v12)
    let v16 : (unit -> leptos_Fragment) = method136(v15)
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
and method264 () : (unit -> leptos_Fragment) =
    closure333()
and closure345 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure346 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure349 () () : string =
    let v0 : string = "Debug"
    v0
and method274 () : (unit -> string) =
    closure349()
and closure348 () () : leptos_Fragment =
    let v0 : (unit -> string) = method274()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method152(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method273 () : (unit -> leptos_Fragment) =
    closure348()
and closure347 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method273()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method153()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method272 () : (unit -> leptos_Fragment) =
    closure347()
and closure344 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure345()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure346()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method272()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method135(v8)
    let v12 : (unit -> leptos_Fragment) = method136(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method155(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method135(v21)
    let v24 : (unit -> leptos_Fragment) = method136(v23)
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
and method271 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure344(v0)
and closure343 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure209()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure210()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method147(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method271(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method270 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure343(v0, v1)
and closure350 (v0 : leptos_WriteSignal<bool>) () : unit =
    let v1 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v2 : (bool -> bool) = closure313()
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1
    ()
and closure351 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure352 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
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
    let v20 : (unit -> leptos_Fragment) = method134()
    let v21 : string = " " + v17 + v4 + ""
    let v22 : string = " " + v18 + v21 + ""
    let v23 : string = " " + v19 + v22 + ""
    let v24 : (unit -> leptos_Fragment) = method135(v20)
    let v25 : (unit -> leptos_Fragment) = method136(v24)
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
and method275 () : (unit -> leptos_Fragment) =
    closure352()
and method276 (v0 : StaticRef<Str>) : StaticRef<Str> =
    v0
and closure353 (v0 : leptos_ReadSignal<bool>) () : std_string_String =
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
    let v10 : StaticRef<Str> = method276(v9)
    let v11 : string = "v10.to_owned() + \" hover:bg-gray-200\""
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11
    v12
and closure356 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Settings"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method279 () : (unit -> leptos_Fragment) =
    closure356()
and closure357 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
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
and method280 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure357(v0)
and closure359 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    v0 ()
and method282 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure359(v0)
and closure360 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method283 () : (unit -> leptos_Fragment) =
    closure360()
and closure358 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "class=\"pr-[15px] [font-size:13px]\""
    let v2 : (unit -> leptos_Fragment) = method282(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"h-px flex-1 bg-gray-300\""
    let v15 : (unit -> leptos_Fragment) = method283()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v15)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
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
and method281 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure358(v0)
and closure361 () () : string =
    let v0 : string = "items-center"
    v0
and closure362 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Table View"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method284 () : (unit -> leptos_Fragment) =
    closure362()
and closure364 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = "table-view"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and closure367 () (v0 : Heap0) : Heap0 =
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
and closure366 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : leptos_RwSignal<Heap0> = v4.l1
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (Heap0 -> Heap0) = closure367()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    ()
and closure368 (v0 : Heap2) () : bool =
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
and method287 (v0 : Heap2) : (unit -> bool) =
    closure368(v0)
and method288 () : (unit -> std_string_String) =
    closure364()
and closure365 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure366(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : (unit -> bool) = method287(v0)
    let v4 : (unit -> std_string_String) = method288()
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
    let v24 : (unit -> leptos_Fragment) = method227()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v24)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method230()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method135(v36)
    let v39 : (unit -> leptos_Fragment) = method136(v38)
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
and method286 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure365(v0)
and closure363 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure364()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method286(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v5)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
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
and method285 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure363(v0)
and closure369 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method289 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure369(v0, v1)
and closure355 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> leptos_Fragment) = method279()
    let v2 : (unit -> leptos_Fragment) = method280(v1)
    let v3 : string = "class=\"flex items-center pb-[6px]\""
    let v4 : (unit -> leptos_Fragment) = method281(v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method135(v4)
    let v8 : (unit -> leptos_Fragment) = method136(v7)
    let v9 : string = "span"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : leptos_HtmlElement<leptos_html_Span> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0"
    let v17 : (unit -> string) = closure361()
    let v18 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "$0"
    let v20 : (unit -> string) = closure306()
    let v21 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v19
    let v22 : string = "$0"
    let v23 : (unit -> string) = closure307()
    let v24 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v23 v22
    let v25 : (unit -> leptos_Fragment) = method284()
    let v26 : (unit -> leptos_Fragment) = method285(v0)
    let v27 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v24(()) + \" \" + &v21(()) + \" \" + &v18(())"
    let v28 : (unit -> leptos_Fragment) = method289(v25, v26)
    let v29 : string = " " + v27 + v5 + ""
    let v30 : (unit -> leptos_Fragment) = method135(v28)
    let v31 : (unit -> leptos_Fragment) = method136(v30)
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
and method278 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure355(v0)
and closure373 (v0 : int64) () : leptos_Fragment =
    let v1 : string = "Transaction " + string (v0 + 1L) + ""
    let v2 : string = "&*$0"
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
and method292 (v0 : int64) : (unit -> leptos_Fragment) =
    closure373(v0)
and closure375 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure376 () () : string =
    let v0 : string = ""
    v0
and closure377 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Account"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method294 () : (unit -> leptos_Fragment) =
    closure377()
and closure378 (v0 : string) () : leptos_Fragment =
    let v1 : string = "&*$0"
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
and method295 (v0 : string) : (unit -> leptos_Fragment) =
    closure378(v0)
and closure379 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method296 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure379(v0, v1)
and closure380 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure381 () () : string =
    let v0 : string = ""
    v0
and closure382 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Block Timestamp"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method297 () : (unit -> leptos_Fragment) =
    closure382()
and closure383 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v3 v12
    let v14 : int64 = int64 v13
    let v15 : int64 = method190(v14)
    let v16 : int64 = v15 / 1000L
    let v17 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v18 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : US71 option = None
    let _v19 = ref v19 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v20 : chrono_DateTime<chrono_Utc> = x
    let v21 : US71 = US71_0(v20)
    v21 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v19.Value <- x
    let v22 : US71 option = _v19.Value 
    let v23 : US71 = US71_1
    let v24 : US71 = v22 |> Option.defaultValue v23 
    let v42 : US34 =
        match v24 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v25) -> (* Some *)
            let v26 : chrono_DateTime<chrono_Utc> = method191(v25)
            let v27 : string = "v26.naive_utc()"
            let v28 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v28)"
            let v30 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v29
            let v31 : string = "%Y-%m-%d %H:%M:%S"
            let v32 : string = "r#\"" + v31 + "\"#"
            let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v32
            let v34 : chrono_DateTime<chrono_Local> = method192(v30)
            let v35 : string = "v34.format(v33).to_string()"
            let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v35
            let v37 : string = "fable_library_rust::String_::fromString($0)"
            let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37
            US34_0(v38)
    let v48 : US72 =
        match v42 with
        | US34_1 -> (* None *)
            let v45 : string = "resultm.from_option / Option does not have a value."
            US72_1(v45)
        | US34_0(v43) -> (* Some *)
            US72_0(v43)
    let v53 : string =
        match v48 with
        | US72_1(v50) -> (* Error *)
            let v51 : string = "sm'.to_string result / Error: " + v50 + ""
            v51
        | US72_0(v49) -> (* Ok *)
            v49
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = "String::from($0)"
    let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "leptos::html::text($0)"
    let v59 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "leptos::IntoView::into_view($0)"
    let v61 : leptos_View = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : (leptos_View []) = [|v61|]
    let v63 : string = "$0.to_vec()"
    let v64 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : string = "leptos::Fragment::new($0)"
    let v66 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v64 v65
    v66
and method298 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure383(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure384 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method299 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure384(v0, v1)
and closure385 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure386 () () : string =
    let v0 : string = ""
    v0
and closure387 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Predecessor"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method300 () : (unit -> leptos_Fragment) =
    closure387()
and closure388 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v8 v12
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method301 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure388(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure389 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method302 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure389(v0, v1)
and closure390 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure391 () () : string =
    let v0 : string = ""
    v0
and closure392 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Receiver"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method303 () : (unit -> leptos_Fragment) =
    closure392()
and closure393 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v10 v12
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method304 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure393(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure394 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method305 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure394(v0, v1)
and closure395 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure396 () () : string =
    let v0 : string = "sm:pr-[10px]"
    v0
and closure397 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Actions"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
    closure397()
and closure400 () () : string =
    let v0 : string = ""
    v0
and closure401 () () : string =
    let v0 : string = "items-center"
    v0
and closure402 () () : string =
    let v0 : string = ""
    v0
and closure403 (v0 : std_string_String) () : leptos_Fragment =
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
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::html::text($0)"
    let v17 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : (leptos_View []) = [|v19|]
    let v21 : string = "$0.to_vec()"
    let v22 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "leptos::Fragment::new($0)"
    let v24 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v22 v23
    v24
and method308 (v0 : std_string_String) : (unit -> leptos_Fragment) =
    closure403(v0)
and closure406 () () : string =
    let v0 : string = ""
    v0
and closure407 () () : string =
    let v0 : string = ""
    v0
and closure408 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Method"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method311 () : (unit -> leptos_Fragment) =
    closure408()
and closure409 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : US15 option = None
    let _v1 = ref v1 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : std_string_String = x
    let v3 : US15 = US15_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v1.Value <- x
    let v4 : US15 option = _v1.Value 
    let v5 : US15 = US15_1
    let v6 : US15 = v4 |> Option.defaultValue v5 
    match v6 with
    | US15_1 -> (* None *)
        let v23 : string = "&*$0"
        let v24 : string = "None"
        let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v24 v23
        let v26 : string = "String::from($0)"
        let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26
        let v28 : string = "leptos::html::text($0)"
        let v29 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v27 v28
        let v30 : string = "leptos::IntoView::into_view($0)"
        let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
        let v32 : (leptos_View []) = [|v31|]
        let v33 : string = "$0.to_vec()"
        let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
        let v35 : string = "leptos::Fragment::new($0)"
        let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
        v36
    | US15_0(v7) -> (* Some *)
        let v8 : string = "fable_library_rust::String_::fromString($0)"
        let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8
        let v10 : string = "&*$0"
        let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
        let v12 : string = "String::from($0)"
        let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
        let v14 : string = "leptos::html::text($0)"
        let v15 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v13 v14
        let v16 : string = "leptos::IntoView::into_view($0)"
        let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
        let v18 : (leptos_View []) = [|v17|]
        let v19 : string = "$0.to_vec()"
        let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19
        let v21 : string = "leptos::Fragment::new($0)"
        let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21
        v22
and method312 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure409(v0)
and closure411 () () : string =
    let v0 : string = ""
    v0
and closure410 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure411()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
    closure410(v0, v1)
and closure405 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure406()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure407()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure307()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : (unit -> leptos_Fragment) = method311()
    let v11 : (unit -> leptos_Fragment) = method312(v0)
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v9(()) + \" \" + &v6(()) + \" \" + &v3(())"
    let v13 : (unit -> leptos_Fragment) = method313(v10, v11)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v13)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method310 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure405(v0)
and closure404 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col\""
    let v2 : (unit -> leptos_Fragment) = method310(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method309 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure404(v0)
and closure413 () () : string =
    let v0 : string = ""
    v0
and closure412 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure413()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method314 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure412(v0, v1)
and closure399 () struct (v0 : std_string_String, v1 : std_string_String option) : leptos_View =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure400()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure401()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "$0"
    let v9 : (unit -> string) = closure402()
    let v10 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : (unit -> leptos_Fragment) = method308(v0)
    let v12 : (unit -> leptos_Fragment) = method309(v1)
    let v13 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v10(()) + \" \" + &v7(()) + \" \" + &v4(())"
    let v14 : (unit -> leptos_Fragment) = method314(v11, v12)
    let v15 : string = ""
    let v16 : string = " " + v13 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v14)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
    let v19 : string = "dl"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Dl> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    v25
and closure398 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v0 v12
    let v14 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v15 : (struct (std_string_String * std_string_String option) -> leptos_View) = closure399()
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14
    let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v18 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "leptos::Fragment::new($0)"
    let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
and method307 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure398(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure415 () () : string =
    let v0 : string = "[flex-direction:column]"
    v0
and closure414 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure415()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method315 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure414(v0, v1)
and closure416 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure417 () () : string =
    let v0 : string = ""
    v0
and closure418 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Deposit"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method316 () : (unit -> leptos_Fragment) =
    closure418()
and closure419 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (float -> string) = _.ToString()
    let v13 : string = v12 v1
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method317 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure419(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure420 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method318 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure420(v0, v1)
and closure421 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure422 () () : string =
    let v0 : string = ""
    v0
and closure423 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Outcome Status"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method319 () : (unit -> leptos_Fragment) =
    closure423()
and closure424 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (bool -> string) = _.ToString()
    let v13 : string = v12 v6
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method320 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure424(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure425 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method321 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure425(v0, v1)
and closure426 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure427 () () : string =
    let v0 : string = ""
    v0
and closure428 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Fee"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method322 () : (unit -> leptos_Fragment) =
    closure428()
and closure429 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (float -> string) = _.ToString()
    let v13 : string = v12 v7
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method323 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure429(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure430 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method324 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure430(v0, v1)
and closure431 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure432 () () : string =
    let v0 : string = ""
    v0
and closure433 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Block Height"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method325 () : (unit -> leptos_Fragment) =
    closure433()
and closure434 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : (uint32 -> string) = _.ToString()
    let v13 : string = v12 v2
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method326 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure434(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure435 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method327 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure435(v0, v1)
and closure436 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure437 () () : string =
    let v0 : string = ""
    v0
and closure438 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Hash"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method328 () : (unit -> leptos_Fragment) =
    closure438()
and closure439 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method329 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure439(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure440 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method330 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure440(v0, v1)
and closure441 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure442 () () : string =
    let v0 : string = ""
    v0
and closure443 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Block Hash"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method331 () : (unit -> leptos_Fragment) =
    closure443()
and closure444 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v4 v12
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method332 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure444(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure445 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method333 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure445(v0, v1)
and closure446 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure447 () () : string =
    let v0 : string = ""
    v0
and closure448 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Receipt ID"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method334 () : (unit -> leptos_Fragment) =
    closure448()
and closure449 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v9 v12
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::html::text($0)"
    let v19 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : (leptos_View []) = [|v21|]
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method335 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure449(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure450 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method336 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure450(v0, v1)
and closure451 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure452 () () : string =
    let v0 : string = ""
    v0
and closure453 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Logs"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method337 () : (unit -> leptos_Fragment) =
    closure453()
and method339 () : string =
    let v0 : string = "\n"
    v0
and closure455 () () : string =
    let v0 : string = "[max-height:20vh]"
    v0
and closure454 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) () : leptos_Fragment =
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v5 v12
    let v14 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v15 : (std_string_String -> string) = closure49()
    let v16 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14
    let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v18 : (string []) = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : ((string []) -> string seq) = Seq.ofArray
    let v20 : string seq = v19 v18
    let v21 : string = method339()
    let v22 : (string -> (string seq -> string)) = String.concat
    let v23 : (string seq -> string) = v22 v21
    let v24 : string = v23 v20
    let v25 : string = "\\n"
    let v26 : string = "\n"
    let v27 : string = v24.Replace (v25, v26)
    let v28 : string = "$0"
    let v29 : (unit -> string) = closure455()
    let v30 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v29 v28
    let v31 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v30(())"
    let v32 : (unit -> leptos_Fragment) = method268(v27)
    let v33 : string = ""
    let v34 : string = " " + v31 + v33 + ""
    let v35 : (unit -> leptos_Fragment) = method135(v32)
    let v36 : (unit -> leptos_Fragment) = method136(v35)
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
and method338 (v0 : (struct (std_string_String * std_string_String option) []), v1 : float, v2 : uint32, v3 : std_string_String, v4 : std_string_String, v5 : (std_string_String []), v6 : bool, v7 : float, v8 : std_string_String, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String) : (unit -> leptos_Fragment) =
    closure454(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure456 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure316()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method252(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method135(v6)
    let v10 : (unit -> leptos_Fragment) = method136(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method252(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v19)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method340 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure456(v0, v1)
and closure374 (v0 : string, v1 : (struct (std_string_String * std_string_String option) []), v2 : float, v3 : uint32, v4 : std_string_String, v5 : std_string_String, v6 : (std_string_String []), v7 : bool, v8 : float, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String) () : leptos_Fragment =
    let v13 : string = "$0"
    let v14 : (unit -> string) = closure375()
    let v15 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v14 v13
    let v16 : string = "$0"
    let v17 : (unit -> string) = closure376()
    let v18 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "$0"
    let v20 : (unit -> string) = closure307()
    let v21 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v19
    let v22 : (unit -> leptos_Fragment) = method294()
    let v23 : (unit -> leptos_Fragment) = method295(v0)
    let v24 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v21(()) + \" \" + &v18(()) + \" \" + &v15(())"
    let v25 : (unit -> leptos_Fragment) = method296(v22, v23)
    let v26 : string = ""
    let v27 : string = " " + v24 + v26 + ""
    let v28 : (unit -> leptos_Fragment) = method135(v25)
    let v29 : (unit -> leptos_Fragment) = method136(v28)
    let v30 : string = "dl"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Dl> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "$0"
    let v38 : (unit -> string) = closure380()
    let v39 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v38 v37
    let v40 : string = "$0"
    let v41 : (unit -> string) = closure381()
    let v42 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v41 v40
    let v43 : string = "$0"
    let v44 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v43
    let v45 : (unit -> leptos_Fragment) = method297()
    let v46 : (unit -> leptos_Fragment) = method298(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v47 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v44(()) + \" \" + &v42(()) + \" \" + &v39(())"
    let v48 : (unit -> leptos_Fragment) = method299(v45, v46)
    let v49 : string = " " + v47 + v26 + ""
    let v50 : (unit -> leptos_Fragment) = method135(v48)
    let v51 : (unit -> leptos_Fragment) = method136(v50)
    let v52 : string = "<" + v30 + " " + v49 + ">{v51()}</" + v30 + ">"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : leptos_HtmlElement<leptos_html_Dl> = v54 |> unbox
    let v56 : string = "leptos::IntoView::into_view($0)"
    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "$0"
    let v59 : (unit -> string) = closure385()
    let v60 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v59 v58
    let v61 : string = "$0"
    let v62 : (unit -> string) = closure386()
    let v63 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v62 v61
    let v64 : string = "$0"
    let v65 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v64
    let v66 : (unit -> leptos_Fragment) = method300()
    let v67 : (unit -> leptos_Fragment) = method301(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v68 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v65(()) + \" \" + &v63(()) + \" \" + &v60(())"
    let v69 : (unit -> leptos_Fragment) = method302(v66, v67)
    let v70 : string = " " + v68 + v26 + ""
    let v71 : (unit -> leptos_Fragment) = method135(v69)
    let v72 : (unit -> leptos_Fragment) = method136(v71)
    let v73 : string = "<" + v30 + " " + v70 + ">{v72()}</" + v30 + ">"
    let v74 : string = "leptos::view! { " + v73 + " }"
    let v75 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v74
    let v76 : leptos_HtmlElement<leptos_html_Dl> = v75 |> unbox
    let v77 : string = "leptos::IntoView::into_view($0)"
    let v78 : leptos_View = Fable.Core.RustInterop.emitRustExpr v76 v77
    let v79 : string = "$0"
    let v80 : (unit -> string) = closure390()
    let v81 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v80 v79
    let v82 : string = "$0"
    let v83 : (unit -> string) = closure391()
    let v84 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v83 v82
    let v85 : string = "$0"
    let v86 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v85
    let v87 : (unit -> leptos_Fragment) = method303()
    let v88 : (unit -> leptos_Fragment) = method304(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v89 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v86(()) + \" \" + &v84(()) + \" \" + &v81(())"
    let v90 : (unit -> leptos_Fragment) = method305(v87, v88)
    let v91 : string = " " + v89 + v26 + ""
    let v92 : (unit -> leptos_Fragment) = method135(v90)
    let v93 : (unit -> leptos_Fragment) = method136(v92)
    let v94 : string = "<" + v30 + " " + v91 + ">{v93()}</" + v30 + ">"
    let v95 : string = "leptos::view! { " + v94 + " }"
    let v96 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v95
    let v97 : leptos_HtmlElement<leptos_html_Dl> = v96 |> unbox
    let v98 : string = "leptos::IntoView::into_view($0)"
    let v99 : leptos_View = Fable.Core.RustInterop.emitRustExpr v97 v98
    let v100 : string = "$0"
    let v101 : (unit -> string) = closure395()
    let v102 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v101 v100
    let v103 : string = "$0"
    let v104 : (unit -> string) = closure396()
    let v105 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v104 v103
    let v106 : string = "$0"
    let v107 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v106
    let v108 : (unit -> leptos_Fragment) = method306()
    let v109 : (unit -> leptos_Fragment) = method307(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v110 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v107(()) + \" \" + &v105(()) + \" \" + &v102(())"
    let v111 : (unit -> leptos_Fragment) = method315(v108, v109)
    let v112 : string = " " + v110 + v26 + ""
    let v113 : (unit -> leptos_Fragment) = method135(v111)
    let v114 : (unit -> leptos_Fragment) = method136(v113)
    let v115 : string = "<" + v30 + " " + v112 + ">{v114()}</" + v30 + ">"
    let v116 : string = "leptos::view! { " + v115 + " }"
    let v117 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v116
    let v118 : leptos_HtmlElement<leptos_html_Dl> = v117 |> unbox
    let v119 : string = "leptos::IntoView::into_view($0)"
    let v120 : leptos_View = Fable.Core.RustInterop.emitRustExpr v118 v119
    let v121 : string = "$0"
    let v122 : (unit -> string) = closure416()
    let v123 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v122 v121
    let v124 : string = "$0"
    let v125 : (unit -> string) = closure417()
    let v126 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v125 v124
    let v127 : string = "$0"
    let v128 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v127
    let v129 : (unit -> leptos_Fragment) = method316()
    let v130 : (unit -> leptos_Fragment) = method317(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v131 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v128(()) + \" \" + &v126(()) + \" \" + &v123(())"
    let v132 : (unit -> leptos_Fragment) = method318(v129, v130)
    let v133 : string = " " + v131 + v26 + ""
    let v134 : (unit -> leptos_Fragment) = method135(v132)
    let v135 : (unit -> leptos_Fragment) = method136(v134)
    let v136 : string = "<" + v30 + " " + v133 + ">{v135()}</" + v30 + ">"
    let v137 : string = "leptos::view! { " + v136 + " }"
    let v138 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v137
    let v139 : leptos_HtmlElement<leptos_html_Dl> = v138 |> unbox
    let v140 : string = "leptos::IntoView::into_view($0)"
    let v141 : leptos_View = Fable.Core.RustInterop.emitRustExpr v139 v140
    let v142 : string = "$0"
    let v143 : (unit -> string) = closure421()
    let v144 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v143 v142
    let v145 : string = "$0"
    let v146 : (unit -> string) = closure422()
    let v147 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v146 v145
    let v148 : string = "$0"
    let v149 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v148
    let v150 : (unit -> leptos_Fragment) = method319()
    let v151 : (unit -> leptos_Fragment) = method320(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v152 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v149(()) + \" \" + &v147(()) + \" \" + &v144(())"
    let v153 : (unit -> leptos_Fragment) = method321(v150, v151)
    let v154 : string = " " + v152 + v26 + ""
    let v155 : (unit -> leptos_Fragment) = method135(v153)
    let v156 : (unit -> leptos_Fragment) = method136(v155)
    let v157 : string = "<" + v30 + " " + v154 + ">{v156()}</" + v30 + ">"
    let v158 : string = "leptos::view! { " + v157 + " }"
    let v159 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v158
    let v160 : leptos_HtmlElement<leptos_html_Dl> = v159 |> unbox
    let v161 : string = "leptos::IntoView::into_view($0)"
    let v162 : leptos_View = Fable.Core.RustInterop.emitRustExpr v160 v161
    let v163 : string = "$0"
    let v164 : (unit -> string) = closure426()
    let v165 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v164 v163
    let v166 : string = "$0"
    let v167 : (unit -> string) = closure427()
    let v168 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v167 v166
    let v169 : string = "$0"
    let v170 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v169
    let v171 : (unit -> leptos_Fragment) = method322()
    let v172 : (unit -> leptos_Fragment) = method323(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v173 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v170(()) + \" \" + &v168(()) + \" \" + &v165(())"
    let v174 : (unit -> leptos_Fragment) = method324(v171, v172)
    let v175 : string = " " + v173 + v26 + ""
    let v176 : (unit -> leptos_Fragment) = method135(v174)
    let v177 : (unit -> leptos_Fragment) = method136(v176)
    let v178 : string = "<" + v30 + " " + v175 + ">{v177()}</" + v30 + ">"
    let v179 : string = "leptos::view! { " + v178 + " }"
    let v180 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v179
    let v181 : leptos_HtmlElement<leptos_html_Dl> = v180 |> unbox
    let v182 : string = "leptos::IntoView::into_view($0)"
    let v183 : leptos_View = Fable.Core.RustInterop.emitRustExpr v181 v182
    let v184 : string = "$0"
    let v185 : (unit -> string) = closure431()
    let v186 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v185 v184
    let v187 : string = "$0"
    let v188 : (unit -> string) = closure432()
    let v189 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v188 v187
    let v190 : string = "$0"
    let v191 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v190
    let v192 : (unit -> leptos_Fragment) = method325()
    let v193 : (unit -> leptos_Fragment) = method326(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v194 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v191(()) + \" \" + &v189(()) + \" \" + &v186(())"
    let v195 : (unit -> leptos_Fragment) = method327(v192, v193)
    let v196 : string = " " + v194 + v26 + ""
    let v197 : (unit -> leptos_Fragment) = method135(v195)
    let v198 : (unit -> leptos_Fragment) = method136(v197)
    let v199 : string = "<" + v30 + " " + v196 + ">{v198()}</" + v30 + ">"
    let v200 : string = "leptos::view! { " + v199 + " }"
    let v201 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v200
    let v202 : leptos_HtmlElement<leptos_html_Dl> = v201 |> unbox
    let v203 : string = "leptos::IntoView::into_view($0)"
    let v204 : leptos_View = Fable.Core.RustInterop.emitRustExpr v202 v203
    let v205 : string = "$0"
    let v206 : (unit -> string) = closure436()
    let v207 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v206 v205
    let v208 : string = "$0"
    let v209 : (unit -> string) = closure437()
    let v210 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v209 v208
    let v211 : string = "$0"
    let v212 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v211
    let v213 : (unit -> leptos_Fragment) = method328()
    let v214 : (unit -> leptos_Fragment) = method329(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v215 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v212(()) + \" \" + &v210(()) + \" \" + &v207(())"
    let v216 : (unit -> leptos_Fragment) = method330(v213, v214)
    let v217 : string = " " + v215 + v26 + ""
    let v218 : (unit -> leptos_Fragment) = method135(v216)
    let v219 : (unit -> leptos_Fragment) = method136(v218)
    let v220 : string = "<" + v30 + " " + v217 + ">{v219()}</" + v30 + ">"
    let v221 : string = "leptos::view! { " + v220 + " }"
    let v222 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v221
    let v223 : leptos_HtmlElement<leptos_html_Dl> = v222 |> unbox
    let v224 : string = "leptos::IntoView::into_view($0)"
    let v225 : leptos_View = Fable.Core.RustInterop.emitRustExpr v223 v224
    let v226 : string = "$0"
    let v227 : (unit -> string) = closure441()
    let v228 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v227 v226
    let v229 : string = "$0"
    let v230 : (unit -> string) = closure442()
    let v231 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v230 v229
    let v232 : string = "$0"
    let v233 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v232
    let v234 : (unit -> leptos_Fragment) = method331()
    let v235 : (unit -> leptos_Fragment) = method332(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v236 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v233(()) + \" \" + &v231(()) + \" \" + &v228(())"
    let v237 : (unit -> leptos_Fragment) = method333(v234, v235)
    let v238 : string = " " + v236 + v26 + ""
    let v239 : (unit -> leptos_Fragment) = method135(v237)
    let v240 : (unit -> leptos_Fragment) = method136(v239)
    let v241 : string = "<" + v30 + " " + v238 + ">{v240()}</" + v30 + ">"
    let v242 : string = "leptos::view! { " + v241 + " }"
    let v243 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v242
    let v244 : leptos_HtmlElement<leptos_html_Dl> = v243 |> unbox
    let v245 : string = "leptos::IntoView::into_view($0)"
    let v246 : leptos_View = Fable.Core.RustInterop.emitRustExpr v244 v245
    let v247 : string = "$0"
    let v248 : (unit -> string) = closure446()
    let v249 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v248 v247
    let v250 : string = "$0"
    let v251 : (unit -> string) = closure447()
    let v252 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v251 v250
    let v253 : string = "$0"
    let v254 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v253
    let v255 : (unit -> leptos_Fragment) = method334()
    let v256 : (unit -> leptos_Fragment) = method335(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v257 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v254(()) + \" \" + &v252(()) + \" \" + &v249(())"
    let v258 : (unit -> leptos_Fragment) = method336(v255, v256)
    let v259 : string = " " + v257 + v26 + ""
    let v260 : (unit -> leptos_Fragment) = method135(v258)
    let v261 : (unit -> leptos_Fragment) = method136(v260)
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
            let v271 : (leptos_View []) = method125(v270)
            let v272 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v273 : leptos_View = Fable.Core.RustInterop.emitRustExpr v271 v272
            v273
        else
            let v274 : string = "$0"
            let v275 : (unit -> string) = closure451()
            let v276 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v275 v274
            let v277 : string = "$0"
            let v278 : (unit -> string) = closure452()
            let v279 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v278 v277
            let v280 : string = "$0"
            let v281 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v20 v280
            let v282 : (unit -> leptos_Fragment) = method337()
            let v283 : (unit -> leptos_Fragment) = method338(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
            let v284 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v281(()) + \" \" + &v279(()) + \" \" + &v276(())"
            let v285 : (unit -> leptos_Fragment) = method340(v282, v283)
            let v286 : string = " " + v284 + v26 + ""
            let v287 : (unit -> leptos_Fragment) = method135(v285)
            let v288 : (unit -> leptos_Fragment) = method136(v287)
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
and method293 (v0 : string, v1 : (struct (std_string_String * std_string_String option) []), v2 : float, v3 : uint32, v4 : std_string_String, v5 : std_string_String, v6 : (std_string_String []), v7 : bool, v8 : float, v9 : std_string_String, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String) : (unit -> leptos_Fragment) =
    closure374(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
and closure372 (v0 : string, v1 : int64, v2 : (struct (std_string_String * std_string_String option) []), v3 : float, v4 : uint32, v5 : std_string_String, v6 : std_string_String, v7 : (std_string_String []), v8 : bool, v9 : float, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String) () : leptos_Fragment =
    let v14 : (unit -> leptos_Fragment) = method292(v1)
    let v15 : (unit -> leptos_Fragment) = method280(v14)
    let v16 : string = "class=\"flex items-center pb-[6px]\""
    let v17 : (unit -> leptos_Fragment) = method281(v15)
    let v18 : string = ""
    let v19 : string = " " + v16 + v18 + ""
    let v20 : (unit -> leptos_Fragment) = method135(v17)
    let v21 : (unit -> leptos_Fragment) = method136(v20)
    let v22 : string = "span"
    let v23 : string = "<" + v22 + " " + v19 + ">{v21()}</" + v22 + ">"
    let v24 : string = "leptos::view! { " + v23 + " }"
    let v25 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : leptos_HtmlElement<leptos_html_Span> = v25 |> unbox
    let v27 : string = "leptos::IntoView::into_view($0)"
    let v28 : leptos_View = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\""
    let v30 : (unit -> leptos_Fragment) = method293(v0, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
    let v31 : string = " " + v29 + v18 + ""
    let v32 : (unit -> leptos_Fragment) = method135(v30)
    let v33 : (unit -> leptos_Fragment) = method136(v32)
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
and method291 (v0 : string, v1 : int64, v2 : (struct (std_string_String * std_string_String option) []), v3 : float, v4 : uint32, v5 : std_string_String, v6 : std_string_String, v7 : (std_string_String []), v8 : bool, v9 : float, v10 : std_string_String, v11 : std_string_String, v12 : std_string_String, v13 : std_string_String) : (unit -> leptos_Fragment) =
    closure372(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
and closure371 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : leptos_View =
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
    let v19 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
    let v20 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "$0.unwrap()"
    let v22 : Heap2 = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "class=\"flex flex-1 flex-col overflow-x-auto\""
    let v24 : (unit -> leptos_Fragment) = method291(v0, v15, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14)
    let v25 : string = ""
    let v26 : string = " " + v23 + v25 + ""
    let v27 : (unit -> leptos_Fragment) = method135(v24)
    let v28 : (unit -> leptos_Fragment) = method136(v27)
    let v29 : string = "div"
    let v30 : string = "<" + v29 + " " + v26 + ">{v28()}</" + v29 + ">"
    let v31 : string = "leptos::view! { " + v30 + " }"
    let v32 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : leptos_HtmlElement<leptos_html_Div> = v32 |> unbox
    let v34 : string = "leptos::IntoView::into_view($0)"
    let v35 : leptos_View = Fable.Core.RustInterop.emitRustExpr v33 v34
    v35
and closure370 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v4 : (struct (string * unativeint * Heap5) -> leptos_View) = closure371()
    let v5 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::Fragment::new($0)"
    let v11 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v9 v10
    v11
and method290 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure370(v0)
and closure459 (v0 : string) () : leptos_Fragment =
    let v1 : string = "&*$0"
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
and method342 (v0 : string) : (unit -> leptos_Fragment) =
    closure459(v0)
and closure460 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l3
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : int64 = int64 v3
    let v5 : int64 = method190(v4)
    let v6 : int64 = v5 / 1000L
    let v7 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v8 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : US71 option = None
    let _v9 = ref v9 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : chrono_DateTime<chrono_Utc> = x
    let v11 : US71 = US71_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US71 option = _v9.Value 
    let v13 : US71 = US71_1
    let v14 : US71 = v12 |> Option.defaultValue v13 
    let v32 : US34 =
        match v14 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v15) -> (* Some *)
            let v16 : chrono_DateTime<chrono_Utc> = method191(v15)
            let v17 : string = "v16.naive_utc()"
            let v18 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v17
            let v19 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v18)"
            let v20 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : string = "%Y-%m-%d %H:%M:%S"
            let v22 : string = "r#\"" + v21 + "\"#"
            let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v22
            let v24 : chrono_DateTime<chrono_Local> = method192(v20)
            let v25 : string = "v24.format(v23).to_string()"
            let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v25
            let v27 : string = "fable_library_rust::String_::fromString($0)"
            let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27
            US34_0(v28)
    let v38 : US72 =
        match v32 with
        | US34_1 -> (* None *)
            let v35 : string = "resultm.from_option / Option does not have a value."
            US72_1(v35)
        | US34_0(v33) -> (* Some *)
            US72_0(v33)
    let v43 : string =
        match v38 with
        | US72_1(v40) -> (* Error *)
            let v41 : string = "sm'.to_string result / Error: " + v40 + ""
            v41
        | US72_0(v39) -> (* Ok *)
            v39
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "leptos::html::text($0)"
    let v49 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "leptos::IntoView::into_view($0)"
    let v51 : leptos_View = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : (leptos_View []) = [|v51|]
    let v53 : string = "$0.to_vec()"
    let v54 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "leptos::Fragment::new($0)"
    let v56 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v54 v55
    v56
and method343 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure460(v0)
and closure461 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l8
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method344 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure461(v0)
and closure462 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l10
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method345 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure462(v0)
and closure464 () struct (v0 : std_string_String, v1 : std_string_String option) : leptos_View =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure400()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure401()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "$0"
    let v9 : (unit -> string) = closure402()
    let v10 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : (unit -> leptos_Fragment) = method308(v0)
    let v12 : (unit -> leptos_Fragment) = method309(v1)
    let v13 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v10(()) + \" \" + &v7(()) + \" \" + &v4(())"
    let v14 : (unit -> leptos_Fragment) = method314(v11, v12)
    let v15 : string = ""
    let v16 : string = " " + v13 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v14)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
    let v19 : string = "dl"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Dl> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    v25
and closure463 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (struct (std_string_String * std_string_String option) []) = v0.l0
    let v2 : string = "$0.to_vec()"
    let v3 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v5 : (struct (std_string_String * std_string_String option) -> leptos_View) = closure464()
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v3, v5) v4
    let v7 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v8 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.to_vec()"
    let v10 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::Fragment::new($0)"
    let v12 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v10 v11
    v12
and method346 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure463(v0)
and closure465 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l1
    let v2 : (float -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method347 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure465(v0)
and closure466 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l7
    let v2 : (float -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method348 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure466(v0)
and closure467 (v0 : Heap5) () : leptos_Fragment =
    let v1 : uint32 = v0.l2
    let v2 : (uint32 -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method349 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure467(v0)
and closure469 () () : string =
    let v0 : string = "[max-height:20vh] [width:100vw] [max-width:100vw]"
    v0
and closure468 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (std_string_String []) = v0.l5
    let v2 : uint64 = System.Convert.ToUInt64 v1.Length
    let v3 : bool = v2 = 0UL
    if v3 then
        let v4 : string = "&*$0"
        let v5 : string = ""
        let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v4
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
        let v20 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
        let v21 : (std_string_String -> string) = closure49()
        let v22 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v19, v21) v20
        let v23 : string = "fable_library_rust::NativeArray_::array_from($0)"
        let v24 : (string []) = Fable.Core.RustInterop.emitRustExpr v22 v23
        let v25 : ((string []) -> string seq) = Seq.ofArray
        let v26 : string seq = v25 v24
        let v27 : string = method339()
        let v28 : (string -> (string seq -> string)) = String.concat
        let v29 : (string seq -> string) = v28 v27
        let v30 : string = v29 v26
        let v31 : string = "\\n"
        let v32 : string = "\n"
        let v33 : string = v30.Replace (v31, v32)
        let v34 : string = "$0"
        let v35 : (unit -> string) = closure469()
        let v36 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v35 v34
        let v37 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v36(())"
        let v38 : (unit -> leptos_Fragment) = method268(v33)
        let v39 : string = ""
        let v40 : string = " " + v37 + v39 + ""
        let v41 : (unit -> leptos_Fragment) = method135(v38)
        let v42 : (unit -> leptos_Fragment) = method136(v41)
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
and method350 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure468(v0)
and closure470 (v0 : Heap5) () : leptos_Fragment =
    let v1 : bool = v0.l6
    let v2 : (bool -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method351 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure470(v0)
and closure471 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l11
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method352 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure471(v0)
and closure472 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l4
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method353 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure472(v0)
and closure473 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l9
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method354 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure473(v0)
and closure458 (v0 : Heap5, v1 : string) () : leptos_Fragment =
    let v2 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v3 : (unit -> leptos_Fragment) = method342(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method135(v3)
    let v7 : (unit -> leptos_Fragment) = method136(v6)
    let v8 : string = "td"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : leptos_HtmlElement<leptos_html_Td> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v16 : (unit -> leptos_Fragment) = method343(v0)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method135(v16)
    let v19 : (unit -> leptos_Fragment) = method136(v18)
    let v20 : string = "<" + v8 + " " + v17 + ">{v19()}</" + v8 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : leptos_HtmlElement<leptos_html_Td> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v27 : (unit -> leptos_Fragment) = method344(v0)
    let v28 : string = " " + v26 + v4 + ""
    let v29 : (unit -> leptos_Fragment) = method135(v27)
    let v30 : (unit -> leptos_Fragment) = method136(v29)
    let v31 : string = "<" + v8 + " " + v28 + ">{v30()}</" + v8 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : leptos_HtmlElement<leptos_html_Td> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v38 : (unit -> leptos_Fragment) = method345(v0)
    let v39 : string = " " + v37 + v4 + ""
    let v40 : (unit -> leptos_Fragment) = method135(v38)
    let v41 : (unit -> leptos_Fragment) = method136(v40)
    let v42 : string = "<" + v8 + " " + v39 + ">{v41()}</" + v8 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : leptos_HtmlElement<leptos_html_Td> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v49 : (unit -> leptos_Fragment) = method346(v0)
    let v50 : string = " " + v48 + v4 + ""
    let v51 : (unit -> leptos_Fragment) = method135(v49)
    let v52 : (unit -> leptos_Fragment) = method136(v51)
    let v53 : string = "<" + v8 + " " + v50 + ">{v52()}</" + v8 + ">"
    let v54 : string = "leptos::view! { " + v53 + " }"
    let v55 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : leptos_HtmlElement<leptos_html_Td> = v55 |> unbox
    let v57 : string = "leptos::IntoView::into_view($0)"
    let v58 : leptos_View = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v60 : (unit -> leptos_Fragment) = method347(v0)
    let v61 : string = " " + v59 + v4 + ""
    let v62 : (unit -> leptos_Fragment) = method135(v60)
    let v63 : (unit -> leptos_Fragment) = method136(v62)
    let v64 : string = "<" + v8 + " " + v61 + ">{v63()}</" + v8 + ">"
    let v65 : string = "leptos::view! { " + v64 + " }"
    let v66 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v65
    let v67 : leptos_HtmlElement<leptos_html_Td> = v66 |> unbox
    let v68 : string = "leptos::IntoView::into_view($0)"
    let v69 : leptos_View = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v71 : (unit -> leptos_Fragment) = method348(v0)
    let v72 : string = " " + v70 + v4 + ""
    let v73 : (unit -> leptos_Fragment) = method135(v71)
    let v74 : (unit -> leptos_Fragment) = method136(v73)
    let v75 : string = "<" + v8 + " " + v72 + ">{v74()}</" + v8 + ">"
    let v76 : string = "leptos::view! { " + v75 + " }"
    let v77 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : leptos_HtmlElement<leptos_html_Td> = v77 |> unbox
    let v79 : string = "leptos::IntoView::into_view($0)"
    let v80 : leptos_View = Fable.Core.RustInterop.emitRustExpr v78 v79
    let v81 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v82 : (unit -> leptos_Fragment) = method349(v0)
    let v83 : string = " " + v81 + v4 + ""
    let v84 : (unit -> leptos_Fragment) = method135(v82)
    let v85 : (unit -> leptos_Fragment) = method136(v84)
    let v86 : string = "<" + v8 + " " + v83 + ">{v85()}</" + v8 + ">"
    let v87 : string = "leptos::view! { " + v86 + " }"
    let v88 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : leptos_HtmlElement<leptos_html_Td> = v88 |> unbox
    let v90 : string = "leptos::IntoView::into_view($0)"
    let v91 : leptos_View = Fable.Core.RustInterop.emitRustExpr v89 v90
    let v92 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]\""
    let v93 : (unit -> leptos_Fragment) = method350(v0)
    let v94 : string = " " + v92 + v4 + ""
    let v95 : (unit -> leptos_Fragment) = method135(v93)
    let v96 : (unit -> leptos_Fragment) = method136(v95)
    let v97 : string = "<" + v8 + " " + v94 + ">{v96()}</" + v8 + ">"
    let v98 : string = "leptos::view! { " + v97 + " }"
    let v99 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v98
    let v100 : leptos_HtmlElement<leptos_html_Td> = v99 |> unbox
    let v101 : string = "leptos::IntoView::into_view($0)"
    let v102 : leptos_View = Fable.Core.RustInterop.emitRustExpr v100 v101
    let v103 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v104 : (unit -> leptos_Fragment) = method351(v0)
    let v105 : string = " " + v103 + v4 + ""
    let v106 : (unit -> leptos_Fragment) = method135(v104)
    let v107 : (unit -> leptos_Fragment) = method136(v106)
    let v108 : string = "<" + v8 + " " + v105 + ">{v107()}</" + v8 + ">"
    let v109 : string = "leptos::view! { " + v108 + " }"
    let v110 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v109
    let v111 : leptos_HtmlElement<leptos_html_Td> = v110 |> unbox
    let v112 : string = "leptos::IntoView::into_view($0)"
    let v113 : leptos_View = Fable.Core.RustInterop.emitRustExpr v111 v112
    let v114 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v115 : (unit -> leptos_Fragment) = method352(v0)
    let v116 : string = " " + v114 + v4 + ""
    let v117 : (unit -> leptos_Fragment) = method135(v115)
    let v118 : (unit -> leptos_Fragment) = method136(v117)
    let v119 : string = "<" + v8 + " " + v116 + ">{v118()}</" + v8 + ">"
    let v120 : string = "leptos::view! { " + v119 + " }"
    let v121 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v120
    let v122 : leptos_HtmlElement<leptos_html_Td> = v121 |> unbox
    let v123 : string = "leptos::IntoView::into_view($0)"
    let v124 : leptos_View = Fable.Core.RustInterop.emitRustExpr v122 v123
    let v125 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v126 : (unit -> leptos_Fragment) = method353(v0)
    let v127 : string = " " + v125 + v4 + ""
    let v128 : (unit -> leptos_Fragment) = method135(v126)
    let v129 : (unit -> leptos_Fragment) = method136(v128)
    let v130 : string = "<" + v8 + " " + v127 + ">{v129()}</" + v8 + ">"
    let v131 : string = "leptos::view! { " + v130 + " }"
    let v132 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v131
    let v133 : leptos_HtmlElement<leptos_html_Td> = v132 |> unbox
    let v134 : string = "leptos::IntoView::into_view($0)"
    let v135 : leptos_View = Fable.Core.RustInterop.emitRustExpr v133 v134
    let v136 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v137 : (unit -> leptos_Fragment) = method354(v0)
    let v138 : string = " " + v136 + v4 + ""
    let v139 : (unit -> leptos_Fragment) = method135(v137)
    let v140 : (unit -> leptos_Fragment) = method136(v139)
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
and method341 (v0 : Heap5, v1 : string) : (unit -> leptos_Fragment) =
    closure458(v0, v1)
and closure457 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : leptos_HtmlElement<leptos_html_Tr> =
    let v3 : string = "transaction.tr_render (1)"
    let v4 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\""
    let v7 : (unit -> leptos_Fragment) = method341(v2, v0)
    let v8 : string = ""
    let v9 : string = " " + v6 + v8 + ""
    let v10 : (unit -> leptos_Fragment) = method135(v7)
    let v11 : (unit -> leptos_Fragment) = method136(v10)
    let v12 : string = "tr"
    let v13 : string = "<" + v12 + " " + v9 + ">{v11()}</" + v12 + ">"
    let v14 : string = "leptos::view! { " + v13 + " }"
    let v15 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : leptos_HtmlElement<leptos_html_Tr> = v15 |> unbox
    v16
and closure474 () (v0 : leptos_HtmlElement<leptos_html_Tr>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure476 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Account"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method356 () : (unit -> leptos_Fragment) =
    closure476()
and closure477 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Block Timestamp"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method357 () : (unit -> leptos_Fragment) =
    closure477()
and closure478 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Predecessor"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method358 () : (unit -> leptos_Fragment) =
    closure478()
and closure479 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Receiver"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method359 () : (unit -> leptos_Fragment) =
    closure479()
and closure480 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Action"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method360 () : (unit -> leptos_Fragment) =
    closure480()
and closure481 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Deposit"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method361 () : (unit -> leptos_Fragment) =
    closure481()
and closure482 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Fee"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
    closure482()
and closure483 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Block Height"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method363 () : (unit -> leptos_Fragment) =
    closure483()
and method366 (v0 : (std_string_String []), v1 : int32) : bool =
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
            method366(v0, v9)
    else
        false
and method365 (v0 : (struct (string * unativeint * Heap5) []), v1 : int32) : bool =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 < v2
    if v3 then
        let struct (v4 : string, v5 : unativeint, v6 : Heap5) = v0.[int v1]
        let v7 : (std_string_String []) = v6.l5
        let v8 : int32 = 0
        let v9 : bool = method366(v7, v8)
        if v9 then
            true
        else
            let v10 : int32 = v1 + 1
            method365(v0, v10)
    else
        false
and closure484 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : int32 = 0
    let v2 : bool = method365(v0, v1)
    let v3 : bool = false = v2
    let v6 : string =
        if v3 then
            let v4 : string = ""
            v4
        else
            let v5 : string = "Logs"
            v5
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "leptos::html::text($0)"
    let v12 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : (leptos_View []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "leptos::Fragment::new($0)"
    let v19 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v17 v18
    v19
and method364 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure484(v0)
and closure485 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Outcome Status"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method367 () : (unit -> leptos_Fragment) =
    closure485()
and closure486 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Hash"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
    closure486()
and closure487 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Block Hash"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method369 () : (unit -> leptos_Fragment) =
    closure487()
and closure488 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Receipt ID"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method370 () : (unit -> leptos_Fragment) =
    closure488()
and closure475 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v2 : (unit -> leptos_Fragment) = method356()
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
    let v7 : string = "th"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Th> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v15 : (unit -> leptos_Fragment) = method357()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v15)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
    let v19 : string = "<" + v7 + " " + v16 + ">{v18()}</" + v7 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Th> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v26 : (unit -> leptos_Fragment) = method358()
    let v27 : string = " " + v25 + v3 + ""
    let v28 : (unit -> leptos_Fragment) = method135(v26)
    let v29 : (unit -> leptos_Fragment) = method136(v28)
    let v30 : string = "<" + v7 + " " + v27 + ">{v29()}</" + v7 + ">"
    let v31 : string = "leptos::view! { " + v30 + " }"
    let v32 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : leptos_HtmlElement<leptos_html_Th> = v32 |> unbox
    let v34 : string = "leptos::IntoView::into_view($0)"
    let v35 : leptos_View = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v37 : (unit -> leptos_Fragment) = method359()
    let v38 : string = " " + v36 + v3 + ""
    let v39 : (unit -> leptos_Fragment) = method135(v37)
    let v40 : (unit -> leptos_Fragment) = method136(v39)
    let v41 : string = "<" + v7 + " " + v38 + ">{v40()}</" + v7 + ">"
    let v42 : string = "leptos::view! { " + v41 + " }"
    let v43 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : leptos_HtmlElement<leptos_html_Th> = v43 |> unbox
    let v45 : string = "leptos::IntoView::into_view($0)"
    let v46 : leptos_View = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v48 : (unit -> leptos_Fragment) = method360()
    let v49 : string = " " + v47 + v3 + ""
    let v50 : (unit -> leptos_Fragment) = method135(v48)
    let v51 : (unit -> leptos_Fragment) = method136(v50)
    let v52 : string = "<" + v7 + " " + v49 + ">{v51()}</" + v7 + ">"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : leptos_HtmlElement<leptos_html_Th> = v54 |> unbox
    let v56 : string = "leptos::IntoView::into_view($0)"
    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v59 : (unit -> leptos_Fragment) = method361()
    let v60 : string = " " + v58 + v3 + ""
    let v61 : (unit -> leptos_Fragment) = method135(v59)
    let v62 : (unit -> leptos_Fragment) = method136(v61)
    let v63 : string = "<" + v7 + " " + v60 + ">{v62()}</" + v7 + ">"
    let v64 : string = "leptos::view! { " + v63 + " }"
    let v65 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : leptos_HtmlElement<leptos_html_Th> = v65 |> unbox
    let v67 : string = "leptos::IntoView::into_view($0)"
    let v68 : leptos_View = Fable.Core.RustInterop.emitRustExpr v66 v67
    let v69 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v70 : (unit -> leptos_Fragment) = method362()
    let v71 : string = " " + v69 + v3 + ""
    let v72 : (unit -> leptos_Fragment) = method135(v70)
    let v73 : (unit -> leptos_Fragment) = method136(v72)
    let v74 : string = "<" + v7 + " " + v71 + ">{v73()}</" + v7 + ">"
    let v75 : string = "leptos::view! { " + v74 + " }"
    let v76 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : leptos_HtmlElement<leptos_html_Th> = v76 |> unbox
    let v78 : string = "leptos::IntoView::into_view($0)"
    let v79 : leptos_View = Fable.Core.RustInterop.emitRustExpr v77 v78
    let v80 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v81 : (unit -> leptos_Fragment) = method363()
    let v82 : string = " " + v80 + v3 + ""
    let v83 : (unit -> leptos_Fragment) = method135(v81)
    let v84 : (unit -> leptos_Fragment) = method136(v83)
    let v85 : string = "<" + v7 + " " + v82 + ">{v84()}</" + v7 + ">"
    let v86 : string = "leptos::view! { " + v85 + " }"
    let v87 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v86
    let v88 : leptos_HtmlElement<leptos_html_Th> = v87 |> unbox
    let v89 : string = "leptos::IntoView::into_view($0)"
    let v90 : leptos_View = Fable.Core.RustInterop.emitRustExpr v88 v89
    let v91 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v92 : (unit -> leptos_Fragment) = method364(v0)
    let v93 : string = " " + v91 + v3 + ""
    let v94 : (unit -> leptos_Fragment) = method135(v92)
    let v95 : (unit -> leptos_Fragment) = method136(v94)
    let v96 : string = "<" + v7 + " " + v93 + ">{v95()}</" + v7 + ">"
    let v97 : string = "leptos::view! { " + v96 + " }"
    let v98 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v97
    let v99 : leptos_HtmlElement<leptos_html_Th> = v98 |> unbox
    let v100 : string = "leptos::IntoView::into_view($0)"
    let v101 : leptos_View = Fable.Core.RustInterop.emitRustExpr v99 v100
    let v102 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v103 : (unit -> leptos_Fragment) = method367()
    let v104 : string = " " + v102 + v3 + ""
    let v105 : (unit -> leptos_Fragment) = method135(v103)
    let v106 : (unit -> leptos_Fragment) = method136(v105)
    let v107 : string = "<" + v7 + " " + v104 + ">{v106()}</" + v7 + ">"
    let v108 : string = "leptos::view! { " + v107 + " }"
    let v109 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v108
    let v110 : leptos_HtmlElement<leptos_html_Th> = v109 |> unbox
    let v111 : string = "leptos::IntoView::into_view($0)"
    let v112 : leptos_View = Fable.Core.RustInterop.emitRustExpr v110 v111
    let v113 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v114 : (unit -> leptos_Fragment) = method368()
    let v115 : string = " " + v113 + v3 + ""
    let v116 : (unit -> leptos_Fragment) = method135(v114)
    let v117 : (unit -> leptos_Fragment) = method136(v116)
    let v118 : string = "<" + v7 + " " + v115 + ">{v117()}</" + v7 + ">"
    let v119 : string = "leptos::view! { " + v118 + " }"
    let v120 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v119
    let v121 : leptos_HtmlElement<leptos_html_Th> = v120 |> unbox
    let v122 : string = "leptos::IntoView::into_view($0)"
    let v123 : leptos_View = Fable.Core.RustInterop.emitRustExpr v121 v122
    let v124 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v125 : (unit -> leptos_Fragment) = method369()
    let v126 : string = " " + v124 + v3 + ""
    let v127 : (unit -> leptos_Fragment) = method135(v125)
    let v128 : (unit -> leptos_Fragment) = method136(v127)
    let v129 : string = "<" + v7 + " " + v126 + ">{v128()}</" + v7 + ">"
    let v130 : string = "leptos::view! { " + v129 + " }"
    let v131 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v130
    let v132 : leptos_HtmlElement<leptos_html_Th> = v131 |> unbox
    let v133 : string = "leptos::IntoView::into_view($0)"
    let v134 : leptos_View = Fable.Core.RustInterop.emitRustExpr v132 v133
    let v135 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v136 : (unit -> leptos_Fragment) = method370()
    let v137 : string = " " + v135 + v3 + ""
    let v138 : (unit -> leptos_Fragment) = method135(v136)
    let v139 : (unit -> leptos_Fragment) = method136(v138)
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
and method355 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure475(v0)
and closure354 (v0 : Heap2, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>, v3 : leptos_ReadSignal<bool>) () : leptos_Fragment =
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v23 : leptos_View =
        if v5 then
            let v6 : string = "class=\"px-[12px] py-[10px]\""
            let v7 : (unit -> leptos_Fragment) = method278(v0)
            let v8 : string = ""
            let v9 : string = " " + v6 + v8 + ""
            let v10 : (unit -> leptos_Fragment) = method135(v7)
            let v11 : (unit -> leptos_Fragment) = method136(v10)
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
            let v20 : (leptos_View []) = method125(v19)
            let v21 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21
            v22
    let v24 : string = $"$0()"
    let v25 : Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)> = Fable.Core.RustInterop.emitRustExpr v2 v24
    let v26 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v27 : (struct (string * Vec<struct (bool * string * bool * US25 * string)>) []) = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : uint64 = System.Convert.ToUInt64 v27.Length
    let v29 : bool = v28 = 0UL
    let v162 : leptos_View =
        if v29 then
            let v30 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v31 : (unit -> leptos_Fragment) = method175()
            let v32 : string = ""
            let v33 : string = " " + v30 + v32 + ""
            let v34 : (unit -> leptos_Fragment) = method135(v31)
            let v35 : (unit -> leptos_Fragment) = method136(v34)
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
            let v45 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure109()
            let v46 : (std_string_String -> US56) = closure110()
            let v47 : US56 = match v44 with Ok x -> v45 x | Error x -> v46 x
            let v59 : US49 =
                match v47 with
                | US56_1(v56) -> (* Error *)
                    US49_1(v56)
                | US56_0(v48) -> (* Ok *)
                    let v49 : US50 option = None
                    let _v49 = ref v49 
                    match v48 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v50 : (struct (string * unativeint * Heap5) []) = x
                    let v51 : US50 = US50_0(v50)
                    v51 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v49.Value <- x
                    let v52 : US50 option = _v49.Value 
                    let v53 : US50 = US50_1
                    let v54 : US50 = v52 |> Option.defaultValue v53 
                    US49_0(v54)
            match v59 with
            | US49_1(v144) -> (* Error *)
                let v145 : string = "fable_library_rust::String_::fromString($0)"
                let v146 : string = Fable.Core.RustInterop.emitRustExpr v144 v145
                let v147 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
                let v148 : (unit -> leptos_Fragment) = method167(v146)
                let v149 : string = ""
                let v150 : string = " " + v147 + v149 + ""
                let v151 : (unit -> leptos_Fragment) = method135(v148)
                let v152 : (unit -> leptos_Fragment) = method136(v151)
                let v153 : string = "div"
                let v154 : string = "<" + v153 + " " + v150 + ">{v152()}</" + v153 + ">"
                let v155 : string = "leptos::view! { " + v154 + " }"
                let v156 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v155
                let v157 : leptos_HtmlElement<leptos_html_Div> = v156 |> unbox
                let v158 : string = "leptos::IntoView::into_view($0)"
                let v159 : leptos_View = Fable.Core.RustInterop.emitRustExpr v157 v158
                v159
            | US49_0(v60) -> (* Ok *)
                match v60 with
                | US50_0(v61) -> (* Some *)
                    let v62 : leptos_RwSignal<Heap1> = v0.l0
                    let v63 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
                    let v64 : Heap1 = Fable.Core.RustInterop.emitRustExpr v62 v63
                    let v65 : leptos_RwSignal<Heap0> = v64.l1
                    let v66 : string = $"leptos::SignalGet::get(&$0)"
                    let v67 : Heap0 = Fable.Core.RustInterop.emitRustExpr v65 v66
                    let v68 : US1 = v67.l4
                    let v70 : bool =
                        match v68 with
                        | US1_0 -> (* Details *)
                            true
                        | _ ->
                            false
                    if v70 then
                        let v71 : string = "class=\"grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]\""
                        let v72 : (unit -> leptos_Fragment) = method290(v61)
                        let v73 : string = ""
                        let v74 : string = " " + v71 + v73 + ""
                        let v75 : (unit -> leptos_Fragment) = method135(v72)
                        let v76 : (unit -> leptos_Fragment) = method136(v75)
                        let v77 : string = "div"
                        let v78 : string = "<" + v77 + " " + v74 + ">{v76()}</" + v77 + ">"
                        let v79 : string = "leptos::view! { " + v78 + " }"
                        let v80 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v79
                        let v81 : leptos_HtmlElement<leptos_html_Div> = v80 |> unbox
                        let v82 : string = "leptos::IntoView::into_view($0)"
                        let v83 : leptos_View = Fable.Core.RustInterop.emitRustExpr v81 v82
                        v83
                    else
                        let v84 : string = "$0.to_vec()"
                        let v85 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v61 v84
                        let v86 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                        let v87 : (struct (string * unativeint * Heap5) -> leptos_HtmlElement<leptos_html_Tr>) = closure457()
                        let v88 : Vec<leptos_HtmlElement<leptos_html_Tr>> = Fable.Core.RustInterop.emitRustExpr struct (v85, v87) v86
                        let v89 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                        let v90 : (leptos_HtmlElement<leptos_html_Tr> -> leptos_View) = closure474()
                        let v91 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v88, v90) v89
                        let v92 : string = "fable_library_rust::NativeArray_::array_from($0)"
                        let v93 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v91 v92
                        let v94 : string = "$0.to_vec()"
                        let v95 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v93 v94
                        let v96 : string = "leptos::Fragment::new($0)"
                        let v97 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v95 v96
                        let v98 : string = "transaction.tr_head_render (1)"
                        let v99 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                        let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99
                        let v101 : (unit -> leptos_Fragment) = method355(v61)
                        let v102 : (unit -> leptos_Fragment) = method135(v101)
                        let v103 : (unit -> leptos_Fragment) = method136(v102)
                        let v104 : string = "tr"
                        let v105 : string = ""
                        let v106 : string = "<" + v104 + " " + v105 + ">{v103()}</" + v104 + ">"
                        let v107 : string = "leptos::view! { " + v106 + " }"
                        let v108 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v107
                        let v109 : leptos_HtmlElement<leptos_html_Tr> = v108 |> unbox
                        let v110 : string = "leptos::IntoView::into_view($0)"
                        let v111 : leptos_View = Fable.Core.RustInterop.emitRustExpr v109 v110
                        let v112 : (leptos_View []) = [|v111|]
                        let v113 : string = "$0.to_vec()"
                        let v114 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v112 v113
                        let v115 : string = "leptos::Fragment::new($0)"
                        let v116 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v114 v115
                        let v117 : string = "class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\""
                        let v118 : (unit -> leptos_Fragment) = method199(v116, v97)
                        let v119 : string = " " + v117 + v105 + ""
                        let v120 : (unit -> leptos_Fragment) = method135(v118)
                        let v121 : (unit -> leptos_Fragment) = method136(v120)
                        let v122 : string = "table"
                        let v123 : string = "<" + v122 + " " + v119 + ">{v121()}</" + v122 + ">"
                        let v124 : string = "leptos::view! { " + v123 + " }"
                        let v125 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v124
                        let v126 : leptos_HtmlElement<leptos_html_Table> = v125 |> unbox
                        let v127 : string = "leptos::IntoView::into_view($0)"
                        let v128 : leptos_View = Fable.Core.RustInterop.emitRustExpr v126 v127
                        v128
                | _ ->
                    let v130 : string = "class=\"grid place-content-center py-[10vh]\""
                    let v131 : (unit -> leptos_Fragment) = method202()
                    let v132 : string = ""
                    let v133 : string = " " + v130 + v132 + ""
                    let v134 : (unit -> leptos_Fragment) = method135(v131)
                    let v135 : (unit -> leptos_Fragment) = method136(v134)
                    let v136 : string = "div"
                    let v137 : string = "<" + v136 + " " + v133 + ">{v135()}</" + v136 + ">"
                    let v138 : string = "leptos::view! { " + v137 + " }"
                    let v139 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v138
                    let v140 : leptos_HtmlElement<leptos_html_Div> = v139 |> unbox
                    let v141 : string = "leptos::IntoView::into_view($0)"
                    let v142 : leptos_View = Fable.Core.RustInterop.emitRustExpr v140 v141
                    v142
    let v163 : (leptos_View []) = [|v23; v162|]
    let v164 : string = "$0.to_vec()"
    let v165 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v163 v164
    let v166 : string = "leptos::Fragment::new($0)"
    let v167 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v165 v166
    v167
and method277 (v0 : Heap2, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>>, v3 : leptos_ReadSignal<bool>) : (unit -> leptos_Fragment) =
    closure354(v0, v1, v2, v3)
and closure491 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure492 (v0 : leptos_View) () : StaticRef<Str> =
    let v4 : string = "[margin-right:40px]"
    let v5 : string = "r#\"" + v4 + "\"#"
    let v6 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and closure495 () () : string =
    let v0 : string = "Transactions"
    v0
and method375 (v0 : leptos_View) : (unit -> string) =
    closure495()
and closure494 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (unit -> string) = method375(v0)
    let v2 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v3 : (unit -> leptos_Fragment) = method152(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method135(v3)
    let v7 : (unit -> leptos_Fragment) = method136(v6)
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
and method374 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure494(v0)
and closure493 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : string = "class=\"flex items-center gap-2\""
    let v2 : (unit -> leptos_Fragment) = method374(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v15 : (unit -> leptos_Fragment) = method153()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v15)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
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
and method373 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure493(v0)
and closure490 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure491()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> StaticRef<Str>) = closure492(v0)
    let v7 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v7(()) + \" \" + &v4(())"
    let v9 : (unit -> leptos_Fragment) = method373(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "summary"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Summary> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=\"flex flex-1 flex-col\""
    let v22 : (unit -> leptos_Fragment) = method155(v1)
    let v23 : string = " " + v21 + v10 + ""
    let v24 : (unit -> leptos_Fragment) = method135(v22)
    let v25 : (unit -> leptos_Fragment) = method136(v24)
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
and method372 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure490(v0, v1)
and closure489 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure209()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure210()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method147(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method372(v0, v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method371 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure489(v0, v1)
and closure497 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Transactions"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
and method377 () : (unit -> leptos_Fragment) =
    closure497()
and closure499 () () : string =
    let v0 : string = "[max-height:70vh]"
    v0
and closure498 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : leptos_Fragment =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{:#?}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{:#?}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v6
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{:#?}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v8
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11 
    #endif
#else
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
    |> fun x -> _v3 <- Some x
    let v13 : std_string_String = _v3.Value
    let v14 : string = "fable_library_rust::String_::fromString($0)"
    let v15 : string = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0"
    let v17 : (unit -> string) = closure499()
    let v18 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v18(())"
    let v20 : (unit -> leptos_Fragment) = method268(v15)
    let v21 : string = ""
    let v22 : string = " " + v19 + v21 + ""
    let v23 : (unit -> leptos_Fragment) = method135(v20)
    let v24 : (unit -> leptos_Fragment) = method136(v23)
    let v25 : string = "pre"
    let v26 : string = "<" + v25 + " " + v22 + ">{v24()}</" + v25 + ">"
    let v27 : string = "leptos::view! { " + v26 + " }"
    let v28 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : leptos_HtmlElement<leptos_html_Pre> = v28 |> unbox
    let v30 : string = "leptos::IntoView::into_view($0)"
    let v31 : leptos_View = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : (leptos_View []) = [|v31|]
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
and method378 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) : (unit -> leptos_Fragment) =
    closure498(v0)
and closure496 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure334()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure306()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure307()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7
    let v10 : (unit -> leptos_Fragment) = method377()
    let v11 : (unit -> leptos_Fragment) = method378(v0)
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v9(()) + \" \" + &v6(()) + \" \" + &v3(())"
    let v13 : (unit -> leptos_Fragment) = method269(v10, v11)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v13)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
    let v18 : string = "dl"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : leptos_HtmlElement<leptos_html_Dl> = v21 |> unbox
    let v23 : (leptos_HtmlElement<leptos_html_Dl> []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_HtmlElement<leptos_html_Dl>> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v27 : (leptos_HtmlElement<leptos_html_Dl> -> leptos_View) = closure325()
    let v28 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v25, v27) v26
    let v29 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v30 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
and method376 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) : (unit -> leptos_Fragment) =
    closure496(v0)
and closure502 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure503 () () : StaticRef<Str> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure506 () () : string =
    let v0 : string = "Debug"
    v0
and method383 () : (unit -> string) =
    closure506()
and closure505 () () : leptos_Fragment =
    let v0 : (unit -> string) = method383()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method152(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method382 () : (unit -> leptos_Fragment) =
    closure505()
and closure504 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method382()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method135(v1)
    let v5 : (unit -> leptos_Fragment) = method136(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method153()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v14)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
and method381 () : (unit -> leptos_Fragment) =
    closure504()
and closure501 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure502()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1
    let v4 : string = "$0"
    let v5 : (unit -> StaticRef<Str>) = closure503()
    let v6 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method381()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method135(v8)
    let v12 : (unit -> leptos_Fragment) = method136(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method155(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method135(v21)
    let v24 : (unit -> leptos_Fragment) = method136(v23)
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
and method380 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure501(v0)
and closure500 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure209()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure210()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method147(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method135(v9)
    let v13 : (unit -> leptos_Fragment) = method136(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method380(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v23)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
and method379 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure500(v0, v1)
and closure507 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method384 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure507(v0)
and closure44 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : US20 = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v483 : US24 =
        match v2 with
        | US20_1(v3) -> (* Dice *)
            let v4 : string = "dice_view.render (1)"
            let v5 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5
            let v7 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
            let v8 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v7
            let v9 : string = "$0.unwrap()"
            let v10 : Heap2 = Fable.Core.RustInterop.emitRustExpr v8 v9
            let v11 : string = "use_transactions.render (1)"
            let v12 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12
            let v14 : string = "$0"
            let v15 : (unit -> Vec<string>) = closure45(v10)
            let v16 : (unit -> Vec<string>) = Fable.Core.RustInterop.emitRustExpr v15 v14
            let v17 : string = "leptos::create_memo(move |_| { v16(()) })"
            let v18 : leptos_Memo<Vec<string>> = Fable.Core.RustInterop.emitRustExpr () v17
            let v19 : string = "$0"
            let v20 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure50(v18)
            let v21 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v20 v19
            let v22 : string = "leptos::create_memo(move |_| { v21(()) })"
            let v23 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v22
            let v24 : string = "$0"
            let v25 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = closure52(v10, v18)
            let v26 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = Fable.Core.RustInterop.emitRustExpr v25 v24
            let v27 : string = "leptos::create_memo(move |_| { v26(()) })"
            let v28 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>> = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : string = "$0"
            let v30 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure55(v28)
            let v31 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v30 v29
            let v32 : string = "leptos::create_memo(move |_| { v31(()) })"
            let v33 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v32
            let v34 : string = "$0"
            let v35 : (unit -> (string [])) = closure57(v28)
            let v36 : (unit -> (string [])) = Fable.Core.RustInterop.emitRustExpr v35 v34
            let v37 : string = "leptos::create_memo(move |_| { v36(()) })"
            let v38 : leptos_Memo<(string [])> = Fable.Core.RustInterop.emitRustExpr () v37
            let v39 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])) = closure60()
            let v40 : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])> = method61(v33, v39)
            let v41 : string = $"%A{v40}"
            let v42 : string = "use_transactions.render (7) / root func0 / result: " + string v41 + ""
            let v43 : int32 = v42.Length
            let v44 : bool = v43 <= 200
            let v47 : string =
                if v44 then
                    v42
                else
                    let v45 : string = v42.[int 0..int 199]
                    let v46 : string = v45 + "..."
                    v46
            let v48 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v49 : bool = Fable.Core.RustInterop.emitRustExpr v47 v48
            let v50 : string = "$0"
            let v51 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = closure93(v38, v40)
            let v52 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v51 v50
            let v53 : string = "leptos::create_memo(move |_| { v52(()) })"
            let v54 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v53
            let v55 : string = "$0"
            let v56 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = closure108(v54)
            let v57 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v56 v55
            let v58 : string = "leptos::create_memo(move |_| { v57(()) })"
            let v59 : leptos_Memo<Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v58
            let v60 : string = "$0"
            let v61 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure114(v59)
            let v62 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v61 v60
            let v63 : string = "leptos::create_memo(move |_| { v62(()) })"
            let v64 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v63
            let v65 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option)) = closure117()
            let v66 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])> = method115(v64, v65)
            let v67 : string = $"%A{v66}"
            let v68 : string = "use_transactions.render (12) / rpc_response func0 / result: " + string v67 + ""
            let v69 : int32 = v68.Length
            let v70 : bool = v69 <= 200
            let v73 : string =
                if v70 then
                    v68
                else
                    let v71 : string = v68.[int 0..int 199]
                    let v72 : string = v71 + "..."
                    v72
            let v74 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v75 : bool = Fable.Core.RustInterop.emitRustExpr v73 v74
            let v76 : string = "leptos::create_action(move |value: &std::sync::Arc<Heap6>| $0(value.clone()))"
            let v77 : (Heap6 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>>) = closure135()
            let v78 : leptos_Action<Heap6, Result<US60, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v77 v76
            let v79 : string = "$0"
            let v80 : (unit -> Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>) = closure140(v78)
            let v81 : (unit -> Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v80 v79
            let v82 : string = "leptos::create_memo(move |_| { v81(()) })"
            let v83 : leptos_Memo<Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v82
            let v84 : string = "$0"
            let v85 : (unit -> string option) = closure144(v83)
            let v86 : (unit -> string option) = Fable.Core.RustInterop.emitRustExpr v85 v84
            let v87 : string = "leptos::create_memo(move |_| { v86(()) })"
            let v88 : leptos_Memo<string option> = Fable.Core.RustInterop.emitRustExpr () v87
            let v89 : string = "$0"
            let v90 : (unit -> US34) = closure147(v10)
            let v91 : (unit -> US34) = Fable.Core.RustInterop.emitRustExpr v90 v89
            let v92 : string = "leptos::create_memo(move |_| { v91(()) })"
            let v93 : leptos_Memo<US34> = Fable.Core.RustInterop.emitRustExpr () v92
            let v94 : string = "$0"
            let v95 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>) = closure148(v10)
            let v96 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>) = Fable.Core.RustInterop.emitRustExpr v95 v94
            let v97 : string = "leptos::create_memo(move |_| { v96(()) })"
            let v98 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>> = Fable.Core.RustInterop.emitRustExpr () v97
            let v99 : string = "$0"
            let v100 : (unit -> Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>) = closure151(v98)
            let v101 : (unit -> Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>) = Fable.Core.RustInterop.emitRustExpr v100 v99
            let v102 : string = "leptos::create_memo(move |_| { v101(()) })"
            let v103 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = Fable.Core.RustInterop.emitRustExpr () v102
            let v104 : (leptos_View []) = [||]
            let v105 : (leptos_View []) = method125(v104)
            let v106 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v107 : leptos_View = Fable.Core.RustInterop.emitRustExpr v105 v106
            let v108 : (unit -> leptos_Fragment) = method126(v10, v78, v88, v93, v103)
            let v109 : (unit -> leptos_Fragment) = method145(v108)
            let v110 : string = "class=\"flex flex-col [position:relative]\""
            let v111 : (unit -> leptos_Fragment) = method169(v107, v109)
            let v112 : string = ""
            let v113 : string = " " + v110 + v112 + ""
            let v114 : (unit -> leptos_Fragment) = method135(v111)
            let v115 : (unit -> leptos_Fragment) = method136(v114)
            let v116 : string = "div"
            let v117 : string = "<" + v116 + " " + v113 + ">{v115()}</" + v116 + ">"
            let v118 : string = "leptos::view! { " + v117 + " }"
            let v119 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v118
            let v120 : leptos_HtmlElement<leptos_html_Div> = v119 |> unbox
            let v121 : string = "leptos::IntoView::into_view($0)"
            let v122 : leptos_View = Fable.Core.RustInterop.emitRustExpr v120 v121
            let v123 : (leptos_View []) = [||]
            let v124 : (leptos_View []) = method125(v123)
            let v125 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v126 : leptos_View = Fable.Core.RustInterop.emitRustExpr v124 v125
            let v127 : (unit -> leptos_Fragment) = method174(v66, v54, v28)
            let v128 : (unit -> leptos_Fragment) = method145(v127)
            let v129 : string = "class=\"flex flex-col [position:relative]\""
            let v130 : (unit -> leptos_Fragment) = method204(v126, v128)
            let v131 : string = " " + v129 + v112 + ""
            let v132 : (unit -> leptos_Fragment) = method135(v130)
            let v133 : (unit -> leptos_Fragment) = method136(v132)
            let v134 : string = "<" + v116 + " " + v131 + ">{v133()}</" + v116 + ">"
            let v135 : string = "leptos::view! { " + v134 + " }"
            let v136 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v135
            let v137 : leptos_HtmlElement<leptos_html_Div> = v136 |> unbox
            let v138 : string = "leptos::IntoView::into_view($0)"
            let v139 : leptos_View = Fable.Core.RustInterop.emitRustExpr v137 v138
            let v140 : (leptos_View []) = [|v122; v139|]
            let v141 : string = "$0.to_vec()"
            let v142 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v140 v141
            let v143 : string = "leptos::Fragment::new($0)"
            let v144 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v142 v143
            US24_0(v144)
        | US20_2 -> (* Lists *)
            let v146 : string = "lists_view.render ()"
            let v147 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v148 : bool = Fable.Core.RustInterop.emitRustExpr v146 v147
            let v149 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
            let v150 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v149
            let v151 : string = "$0.unwrap()"
            let v152 : Heap2 = Fable.Core.RustInterop.emitRustExpr v150 v151
            let v153 : string = "&*$0"
            let v154 : string = "???"
            let v155 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v154 v153
            let v156 : string = "String::from($0)"
            let v157 : std_string_String = Fable.Core.RustInterop.emitRustExpr v155 v156
            let v158 : string = "leptos::html::text($0)"
            let v159 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v157 v158
            let v160 : string = "leptos::IntoView::into_view($0)"
            let v161 : leptos_View = Fable.Core.RustInterop.emitRustExpr v159 v160
            let v162 : (leptos_View []) = [|v161|]
            let v163 : string = "$0.to_vec()"
            let v164 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v162 v163
            let v165 : string = "leptos::Fragment::new($0)"
            let v166 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v164 v165
            US24_0(v166)
        | US20_4 -> (* Settings *)
            let v340 : string = "settings_view.render ()"
            let v341 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v342 : bool = Fable.Core.RustInterop.emitRustExpr v340 v341
            let v343 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
            let v344 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v343
            let v345 : string = "$0.unwrap()"
            let v346 : Heap2 = Fable.Core.RustInterop.emitRustExpr v344 v345
            let v347 : string = "$0"
            let v348 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) = closure251(v346)
            let v349 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) = Fable.Core.RustInterop.emitRustExpr v348 v347
            let v350 : string = "leptos::create_memo(move |_| { v349(()) })"
            let v351 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>> = Fable.Core.RustInterop.emitRustExpr () v350
            let v352 : string = $"leptos::create_signal($0)"
            let struct (v353 : leptos_ReadSignal<int32>, v354 : leptos_WriteSignal<int32>) = Fable.Core.RustInterop.emitRustExpr 0 v352
            let v355 : string = "$0"
            let v356 : (unit -> Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>) = closure254(v351, v353)
            let v357 : (unit -> Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>) = Fable.Core.RustInterop.emitRustExpr v356 v355
            let v358 : string = "leptos::create_memo(move |_| { v357(()) })"
            let v359 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> = Fable.Core.RustInterop.emitRustExpr () v358
            let v360 : string = "$0"
            let v361 : (unit -> int32) = closure257(v359)
            let v362 : (unit -> int32) = Fable.Core.RustInterop.emitRustExpr v361 v360
            let v363 : string = "leptos::create_memo(move |_| { v362(()) })"
            let v364 : leptos_Memo<int32> = Fable.Core.RustInterop.emitRustExpr () v363
            let v365 : (unit -> unit) = closure258(v346, v351, v354)
            let v366 : string = "let v365 = $0"
            Fable.Core.RustInterop.emitRustExpr v365 v366
            let v367 : string = "$0"
            let v368 : (unit -> string) = closure263()
            let v369 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v368 v367
            let v370 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v371 : string = "fill=\"none\""
            let v372 : string = "viewBox=\"0 0 24 24\""
            let v373 : string = "stroke-width=\"1.5\""
            let v374 : string = "stroke=\"currentColor\""
            let v375 : string = "class=move || \" \".to_owned() + &v369(())"
            let v376 : (unit -> leptos_Fragment) = method213()
            let v377 : string = ""
            let v378 : string = " " + v370 + v377 + ""
            let v379 : string = " " + v371 + v378 + ""
            let v380 : string = " " + v372 + v379 + ""
            let v381 : string = " " + v373 + v380 + ""
            let v382 : string = " " + v374 + v381 + ""
            let v383 : string = " " + v375 + v382 + ""
            let v384 : (unit -> leptos_Fragment) = method135(v376)
            let v385 : (unit -> leptos_Fragment) = method136(v384)
            let v386 : string = "svg"
            let v387 : string = "<" + v386 + " " + v383 + ">{v385()}</" + v386 + ">"
            let v388 : string = "leptos::view! { " + v387 + " }"
            let v389 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v388
            let v390 : leptos_HtmlElement<leptos_svg_Svg> = v389 |> unbox
            let v391 : string = "on:click=move |_| v365()"
            let v392 : string = "aria-label=\"Add\""
            let v393 : string = "$0"
            let v394 : (unit -> std_string_String) = closure265()
            let v395 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v394 v393
            let v396 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v395(())"
            let v397 : (unit -> leptos_Fragment) = method214(v390)
            let v398 : string = " " + v396 + v377 + ""
            let v399 : string = " " + v391 + v398 + ""
            let v400 : string = " " + v392 + v399 + ""
            let v401 : (unit -> leptos_Fragment) = method135(v397)
            let v402 : (unit -> leptos_Fragment) = method136(v401)
            let v403 : string = "button"
            let v404 : string = "<" + v403 + " " + v400 + ">{v402()}</" + v403 + ">"
            let v405 : string = "leptos::view! { " + v404 + " }"
            let v406 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v405
            let v407 : leptos_HtmlElement<leptos_html_Button> = v406 |> unbox
            let v408 : string = "leptos::IntoView::into_view($0)"
            let v409 : leptos_View = Fable.Core.RustInterop.emitRustExpr v407 v408
            let v410 : (leptos_View []) = [||]
            let v411 : (leptos_View []) = method125(v410)
            let v412 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v413 : leptos_View = Fable.Core.RustInterop.emitRustExpr v411 v412
            let v414 : (unit -> leptos_Fragment) = method215(v346, v359, v364, v351, v354)
            let v415 : (unit -> leptos_Fragment) = method145(v414)
            let v416 : string = "class=\"flex flex-col [position:relative]\""
            let v417 : (unit -> leptos_Fragment) = method239(v409, v415)
            let v418 : string = " " + v416 + v377 + ""
            let v419 : (unit -> leptos_Fragment) = method135(v417)
            let v420 : (unit -> leptos_Fragment) = method136(v419)
            let v421 : string = "div"
            let v422 : string = "<" + v421 + " " + v418 + ">{v420()}</" + v421 + ">"
            let v423 : string = "leptos::view! { " + v422 + " }"
            let v424 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v423
            let v425 : leptos_HtmlElement<leptos_html_Div> = v424 |> unbox
            let v426 : string = "leptos::IntoView::into_view($0)"
            let v427 : leptos_View = Fable.Core.RustInterop.emitRustExpr v425 v426
            let v428 : (leptos_View []) = [||]
            let v429 : (leptos_View []) = method125(v428)
            let v430 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v431 : leptos_View = Fable.Core.RustInterop.emitRustExpr v429 v430
            let v432 : (unit -> leptos_Fragment) = method244(v346)
            let v433 : (unit -> leptos_Fragment) = method145(v432)
            let v434 : string = "class=\"flex flex-col [position:relative]\""
            let v435 : (unit -> leptos_Fragment) = method259(v431, v433)
            let v436 : string = " " + v434 + v377 + ""
            let v437 : (unit -> leptos_Fragment) = method135(v435)
            let v438 : (unit -> leptos_Fragment) = method136(v437)
            let v439 : string = "<" + v421 + " " + v436 + ">{v438()}</" + v421 + ">"
            let v440 : string = "leptos::view! { " + v439 + " }"
            let v441 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v440
            let v442 : leptos_HtmlElement<leptos_html_Div> = v441 |> unbox
            let v443 : string = "leptos::IntoView::into_view($0)"
            let v444 : leptos_View = Fable.Core.RustInterop.emitRustExpr v442 v443
            let v445 : leptos_RwSignal<Heap1> = v346.l0
            let v446 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v447 : Heap1 = Fable.Core.RustInterop.emitRustExpr v445 v446
            let v448 : leptos_RwSignal<bool> = v447.l2
            let v449 : string = $"leptos::SignalGet::get(&$0)"
            let v450 : bool = Fable.Core.RustInterop.emitRustExpr v448 v449
            let v472 : leptos_View =
                if v450 then
                    let v451 : (leptos_View []) = [||]
                    let v452 : (leptos_View []) = method125(v451)
                    let v453 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v454 : leptos_View = Fable.Core.RustInterop.emitRustExpr v452 v453
                    let v455 : (unit -> leptos_Fragment) = method264()
                    let v456 : (unit -> leptos_Fragment) = method145(v455)
                    let v457 : string = "class=\"flex flex-col [position:relative]\""
                    let v458 : (unit -> leptos_Fragment) = method270(v454, v456)
                    let v459 : string = " " + v457 + v377 + ""
                    let v460 : (unit -> leptos_Fragment) = method135(v458)
                    let v461 : (unit -> leptos_Fragment) = method136(v460)
                    let v462 : string = "<" + v421 + " " + v459 + ">{v461()}</" + v421 + ">"
                    let v463 : string = "leptos::view! { " + v462 + " }"
                    let v464 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v463
                    let v465 : leptos_HtmlElement<leptos_html_Div> = v464 |> unbox
                    let v466 : string = "leptos::IntoView::into_view($0)"
                    let v467 : leptos_View = Fable.Core.RustInterop.emitRustExpr v465 v466
                    v467
                else
                    let v468 : (leptos_View []) = [||]
                    let v469 : (leptos_View []) = method125(v468)
                    let v470 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v471 : leptos_View = Fable.Core.RustInterop.emitRustExpr v469 v470
                    v471
            let v473 : (leptos_View []) = [|v427; v444; v472|]
            let v474 : string = "$0.to_vec()"
            let v475 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v473 v474
            let v476 : string = "leptos::Fragment::new($0)"
            let v477 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v475 v476
            US24_0(v477)
        | US20_3 -> (* Transactions *)
            let v168 : string = "transactions_view.render (1)"
            let v169 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v170 : bool = Fable.Core.RustInterop.emitRustExpr v168 v169
            let v171 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
            let v172 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v171
            let v173 : string = "$0.unwrap()"
            let v174 : Heap2 = Fable.Core.RustInterop.emitRustExpr v172 v173
            let v175 : string = "use_transactions.render (1)"
            let v176 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v177 : bool = Fable.Core.RustInterop.emitRustExpr v175 v176
            let v178 : string = "$0"
            let v179 : (unit -> Vec<string>) = closure45(v174)
            let v180 : (unit -> Vec<string>) = Fable.Core.RustInterop.emitRustExpr v179 v178
            let v181 : string = "leptos::create_memo(move |_| { v180(()) })"
            let v182 : leptos_Memo<Vec<string>> = Fable.Core.RustInterop.emitRustExpr () v181
            let v183 : string = "$0"
            let v184 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure50(v182)
            let v185 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v184 v183
            let v186 : string = "leptos::create_memo(move |_| { v185(()) })"
            let v187 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v186
            let v188 : string = "$0"
            let v189 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = closure52(v174, v182)
            let v190 : (unit -> Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>) = Fable.Core.RustInterop.emitRustExpr v189 v188
            let v191 : string = "leptos::create_memo(move |_| { v190(()) })"
            let v192 : leptos_Memo<Vec<struct (string * Vec<struct (bool * string * bool * US25 * string)>)>> = Fable.Core.RustInterop.emitRustExpr () v191
            let v193 : string = "$0"
            let v194 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure55(v192)
            let v195 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v194 v193
            let v196 : string = "leptos::create_memo(move |_| { v195(()) })"
            let v197 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v196
            let v198 : string = "$0"
            let v199 : (unit -> (string [])) = closure57(v192)
            let v200 : (unit -> (string [])) = Fable.Core.RustInterop.emitRustExpr v199 v198
            let v201 : string = "leptos::create_memo(move |_| { v200(()) })"
            let v202 : leptos_Memo<(string [])> = Fable.Core.RustInterop.emitRustExpr () v201
            let v203 : (crate_model_near_nearblocks_Root -> (struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) [])) = closure60()
            let v204 : leptos_Memo<(Result<(struct ((struct (std_string_String * std_string_String option) []) * float * uint32 * std_string_String * std_string_String * (std_string_String []) * bool * float * std_string_String * std_string_String * std_string_String * std_string_String) []) option, std_string_String> [])> = method61(v197, v203)
            let v205 : string = $"%A{v204}"
            let v206 : string = "use_transactions.render (7) / root func0 / result: " + string v205 + ""
            let v207 : int32 = v206.Length
            let v208 : bool = v207 <= 200
            let v211 : string =
                if v208 then
                    v206
                else
                    let v209 : string = v206.[int 0..int 199]
                    let v210 : string = v209 + "..."
                    v210
            let v212 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v213 : bool = Fable.Core.RustInterop.emitRustExpr v211 v212
            let v214 : string = "$0"
            let v215 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = closure93(v202, v204)
            let v216 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v215 v214
            let v217 : string = "leptos::create_memo(move |_| { v216(()) })"
            let v218 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v217
            let v219 : string = "$0"
            let v220 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = closure108(v218)
            let v221 : (unit -> Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v220 v219
            let v222 : string = "leptos::create_memo(move |_| { v221(()) })"
            let v223 : leptos_Memo<Result<(struct (bool * string * bool * US25 * string) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v222
            let v224 : string = "$0"
            let v225 : (unit -> (struct (bool * string * bool * US25 * string) [])) = closure114(v223)
            let v226 : (unit -> (struct (bool * string * bool * US25 * string) [])) = Fable.Core.RustInterop.emitRustExpr v225 v224
            let v227 : string = "leptos::create_memo(move |_| { v226(()) })"
            let v228 : leptos_Memo<(struct (bool * string * bool * US25 * string) [])> = Fable.Core.RustInterop.emitRustExpr () v227
            let v229 : (crate_model_near_rpc_RpcResponse -> struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option)) = closure117()
            let v230 : leptos_Memo<(Result<struct (struct (struct (std_string_String option * std_string_String option) option * std_string_String * int32 * std_string_String * std_string_String * std_string_String) option * std_string_String option * std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String option * std_string_String * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option) option, std_string_String> [])> = method115(v228, v229)
            let v231 : string = $"%A{v230}"
            let v232 : string = "use_transactions.render (12) / rpc_response func0 / result: " + string v231 + ""
            let v233 : int32 = v232.Length
            let v234 : bool = v233 <= 200
            let v237 : string =
                if v234 then
                    v232
                else
                    let v235 : string = v232.[int 0..int 199]
                    let v236 : string = v235 + "..."
                    v236
            let v238 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v239 : bool = Fable.Core.RustInterop.emitRustExpr v237 v238
            let v240 : string = $"leptos::create_signal($0)"
            let struct (v241 : leptos_ReadSignal<bool>, v242 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr false v240
            let v243 : (unit -> unit) = closure350(v242)
            let v244 : string = "let v243 = $0"
            Fable.Core.RustInterop.emitRustExpr v243 v244
            let v245 : string = "$0"
            let v246 : (unit -> string) = closure351()
            let v247 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v246 v245
            let v248 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v249 : string = "fill=\"none\""
            let v250 : string = "viewBox=\"0 0 24 24\""
            let v251 : string = "stroke-width=\"1.5\""
            let v252 : string = "stroke=\"currentColor\""
            let v253 : string = "class=move || \" \".to_owned() + &v247(())"
            let v254 : (unit -> leptos_Fragment) = method275()
            let v255 : string = ""
            let v256 : string = " " + v248 + v255 + ""
            let v257 : string = " " + v249 + v256 + ""
            let v258 : string = " " + v250 + v257 + ""
            let v259 : string = " " + v251 + v258 + ""
            let v260 : string = " " + v252 + v259 + ""
            let v261 : string = " " + v253 + v260 + ""
            let v262 : (unit -> leptos_Fragment) = method135(v254)
            let v263 : (unit -> leptos_Fragment) = method136(v262)
            let v264 : string = "svg"
            let v265 : string = "<" + v264 + " " + v261 + ">{v263()}</" + v264 + ">"
            let v266 : string = "leptos::view! { " + v265 + " }"
            let v267 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v266
            let v268 : leptos_HtmlElement<leptos_svg_Svg> = v267 |> unbox
            let v269 : string = "on:click=move |_| v243()"
            let v270 : string = "aria-label=\"Settings\""
            let v271 : string = "$0"
            let v272 : (unit -> std_string_String) = closure353(v241)
            let v273 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v272 v271
            let v274 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v273(())"
            let v275 : (unit -> leptos_Fragment) = method214(v268)
            let v276 : string = " " + v274 + v255 + ""
            let v277 : string = " " + v269 + v276 + ""
            let v278 : string = " " + v270 + v277 + ""
            let v279 : (unit -> leptos_Fragment) = method135(v275)
            let v280 : (unit -> leptos_Fragment) = method136(v279)
            let v281 : string = "button"
            let v282 : string = "<" + v281 + " " + v278 + ">{v280()}</" + v281 + ">"
            let v283 : string = "leptos::view! { " + v282 + " }"
            let v284 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v283
            let v285 : leptos_HtmlElement<leptos_html_Button> = v284 |> unbox
            let v286 : string = "leptos::IntoView::into_view($0)"
            let v287 : leptos_View = Fable.Core.RustInterop.emitRustExpr v285 v286
            let v288 : (leptos_View []) = [||]
            let v289 : (leptos_View []) = method125(v288)
            let v290 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v291 : leptos_View = Fable.Core.RustInterop.emitRustExpr v289 v290
            let v292 : (unit -> leptos_Fragment) = method277(v174, v218, v192, v241)
            let v293 : (unit -> leptos_Fragment) = method145(v292)
            let v294 : string = "class=\"flex flex-col [position:relative]\""
            let v295 : (unit -> leptos_Fragment) = method371(v287, v293)
            let v296 : string = " " + v294 + v255 + ""
            let v297 : (unit -> leptos_Fragment) = method135(v295)
            let v298 : (unit -> leptos_Fragment) = method136(v297)
            let v299 : string = "div"
            let v300 : string = "<" + v299 + " " + v296 + ">{v298()}</" + v299 + ">"
            let v301 : string = "leptos::view! { " + v300 + " }"
            let v302 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v301
            let v303 : leptos_HtmlElement<leptos_html_Div> = v302 |> unbox
            let v304 : string = "leptos::IntoView::into_view($0)"
            let v305 : leptos_View = Fable.Core.RustInterop.emitRustExpr v303 v304
            let v306 : leptos_RwSignal<Heap1> = v174.l0
            let v307 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v308 : Heap1 = Fable.Core.RustInterop.emitRustExpr v306 v307
            let v309 : leptos_RwSignal<bool> = v308.l2
            let v310 : string = $"leptos::SignalGet::get(&$0)"
            let v311 : bool = Fable.Core.RustInterop.emitRustExpr v309 v310
            let v333 : leptos_View =
                if v311 then
                    let v312 : (leptos_View []) = [||]
                    let v313 : (leptos_View []) = method125(v312)
                    let v314 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v315 : leptos_View = Fable.Core.RustInterop.emitRustExpr v313 v314
                    let v316 : (unit -> leptos_Fragment) = method376(v218)
                    let v317 : (unit -> leptos_Fragment) = method145(v316)
                    let v318 : string = "class=\"flex flex-col [position:relative]\""
                    let v319 : (unit -> leptos_Fragment) = method379(v315, v317)
                    let v320 : string = " " + v318 + v255 + ""
                    let v321 : (unit -> leptos_Fragment) = method135(v319)
                    let v322 : (unit -> leptos_Fragment) = method136(v321)
                    let v323 : string = "<" + v299 + " " + v320 + ">{v322()}</" + v299 + ">"
                    let v324 : string = "leptos::view! { " + v323 + " }"
                    let v325 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v324
                    let v326 : leptos_HtmlElement<leptos_html_Div> = v325 |> unbox
                    let v327 : string = "leptos::IntoView::into_view($0)"
                    let v328 : leptos_View = Fable.Core.RustInterop.emitRustExpr v326 v327
                    v328
                else
                    let v329 : (leptos_View []) = [||]
                    let v330 : (leptos_View []) = method125(v329)
                    let v331 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v332 : leptos_View = Fable.Core.RustInterop.emitRustExpr v330 v331
                    v332
            let v334 : (leptos_View []) = [|v305; v333|]
            let v335 : string = "$0.to_vec()"
            let v336 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v334 v335
            let v337 : string = "leptos::Fragment::new($0)"
            let v338 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v336 v337
            US24_0(v338)
        | _ ->
            US24_1
    let v503 : leptos_View =
        match v483 with
        | US24_1 -> (* None *)
            let v498 : (leptos_View []) = [||]
            let v499 : (leptos_View []) = method125(v498)
            let v500 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v501 : leptos_View = Fable.Core.RustInterop.emitRustExpr v499 v500
            v501
        | US24_0(v484) -> (* Some *)
            let v485 : string = "class=\"flex flex-1 flex-col [overflow-y:auto]\""
            let v486 : (unit -> leptos_Fragment) = method384(v484)
            let v487 : string = ""
            let v488 : string = " " + v485 + v487 + ""
            let v489 : (unit -> leptos_Fragment) = method135(v486)
            let v490 : (unit -> leptos_Fragment) = method136(v489)
            let v491 : string = "div"
            let v492 : string = "<" + v491 + " " + v488 + ">{v490()}</" + v491 + ">"
            let v493 : string = "leptos::view! { " + v492 + " }"
            let v494 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v493
            let v495 : leptos_HtmlElement<leptos_html_Div> = v494 |> unbox
            let v496 : string = "leptos::IntoView::into_view($0)"
            let v497 : leptos_View = Fable.Core.RustInterop.emitRustExpr v495 v496
            v497
    let v504 : (leptos_View []) = [|v503|]
    let v505 : string = "$0.to_vec()"
    let v506 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v504 v505
    let v507 : string = "leptos::Fragment::new($0)"
    let v508 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v506 v507
    v508
and method49 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure44(v0)
and closure510 () () : leptos_Fragment =
    let v0 : string = "&*$0"
    let v1 : string = "Tab"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0
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
    closure510()
and closure513 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : bool =
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
and method389 (v0 : leptos_ReadSignal<US20>, v1 : US20) : (unit -> bool) =
    closure513(v0, v1)
and closure514 (v0 : string) () : leptos_Fragment =
    let v1 : string = "&*$0"
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
and method390 (v0 : string) : (unit -> leptos_Fragment) =
    closure514(v0)
and closure512 (v0 : leptos_ReadSignal<US20>) (v1 : US20) : leptos_View =
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
    let v13 : (unit -> bool) = method389(v0, v1)
    let v14 : string = "select=v13()"
    let v15 : (unit -> leptos_Fragment) = method390(v12)
    let v16 : string = ""
    let v17 : string = " " + v14 + v16 + ""
    let v18 : (unit -> leptos_Fragment) = method135(v15)
    let v19 : (unit -> leptos_Fragment) = method136(v18)
    let v20 : string = "option"
    let v21 : string = "<" + v20 + " " + v17 + ">{v19()}</" + v20 + ">"
    let v22 : string = "leptos::view! { " + v21 + " }"
    let v23 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : leptos_HtmlElement<leptos_html_Option> = v23 |> unbox
    let v25 : string = "leptos::IntoView::into_view($0)"
    let v26 : leptos_View = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and closure511 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : US21 = US21_0
    let v2 : US20 = US20_1(v1)
    let v3 : US20 = US20_2
    let v4 : US20 = US20_3
    let v5 : US20 = US20_4
    let v6 : (US20 []) = [|v2; v3; v4; v5|]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<US20> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v10 : (US20 -> leptos_View) = closure512(v0)
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9
    let v12 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v13 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16
    v17
and method388 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure511(v0)
and closure509 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "for=\"Tab\""
    let v2 : string = "class=\"sr-only\""
    let v3 : (unit -> leptos_Fragment) = method387()
    let v4 : string = ""
    let v5 : string = " " + v1 + v4 + ""
    let v6 : string = " " + v2 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method135(v3)
    let v8 : (unit -> leptos_Fragment) = method136(v7)
    let v9 : string = "label"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : leptos_HtmlElement<leptos_html_Label> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "id=\"Tab\""
    let v17 : string = "class=\"w-full rounded-md border-gray-200\""
    let v18 : (unit -> leptos_Fragment) = method388(v0)
    let v19 : string = " " + v16 + v4 + ""
    let v20 : string = " " + v17 + v19 + ""
    let v21 : (unit -> leptos_Fragment) = method135(v18)
    let v22 : (unit -> leptos_Fragment) = method136(v21)
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
and method386 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure509(v0)
and closure519 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure521 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method395 () : (unit -> leptos_Fragment) =
    closure521()
and closure520 () () : leptos_Fragment =
    let v0 : string = "x=\"3\""
    let v1 : string = "y=\"3\""
    let v2 : string = "width=\"18\""
    let v3 : string = "height=\"18\""
    let v4 : string = "rx=\"2\""
    let v5 : string = "stroke-linecap=\"round\""
    let v6 : string = "stroke-linejoin=\"round\""
    let v7 : (unit -> leptos_Fragment) = method395()
    let v8 : string = ""
    let v9 : string = " " + v0 + v8 + ""
    let v10 : string = " " + v1 + v9 + ""
    let v11 : string = " " + v2 + v10 + ""
    let v12 : string = " " + v3 + v11 + ""
    let v13 : string = " " + v4 + v12 + ""
    let v14 : string = " " + v5 + v13 + ""
    let v15 : string = " " + v6 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method135(v7)
    let v17 : (unit -> leptos_Fragment) = method136(v16)
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
    let v29 : (unit -> leptos_Fragment) = method144()
    let v30 : string = " " + v25 + v8 + ""
    let v31 : string = " " + v26 + v30 + ""
    let v32 : string = " " + v27 + v31 + ""
    let v33 : string = " " + v28 + v32 + ""
    let v34 : (unit -> leptos_Fragment) = method135(v29)
    let v35 : (unit -> leptos_Fragment) = method136(v34)
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
    let v47 : (unit -> leptos_Fragment) = method144()
    let v48 : string = " " + v43 + v8 + ""
    let v49 : string = " " + v44 + v48 + ""
    let v50 : string = " " + v45 + v49 + ""
    let v51 : string = " " + v46 + v50 + ""
    let v52 : (unit -> leptos_Fragment) = method135(v47)
    let v53 : (unit -> leptos_Fragment) = method136(v52)
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
    let v64 : (unit -> leptos_Fragment) = method144()
    let v65 : string = " " + v60 + v8 + ""
    let v66 : string = " " + v61 + v65 + ""
    let v67 : string = " " + v62 + v66 + ""
    let v68 : string = " " + v63 + v67 + ""
    let v69 : (unit -> leptos_Fragment) = method135(v64)
    let v70 : (unit -> leptos_Fragment) = method136(v69)
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
    let v81 : (unit -> leptos_Fragment) = method144()
    let v82 : string = " " + v77 + v8 + ""
    let v83 : string = " " + v78 + v82 + ""
    let v84 : string = " " + v79 + v83 + ""
    let v85 : string = " " + v80 + v84 + ""
    let v86 : (unit -> leptos_Fragment) = method135(v81)
    let v87 : (unit -> leptos_Fragment) = method136(v86)
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
    let v98 : (unit -> leptos_Fragment) = method144()
    let v99 : string = " " + v94 + v8 + ""
    let v100 : string = " " + v95 + v99 + ""
    let v101 : string = " " + v96 + v100 + ""
    let v102 : string = " " + v97 + v101 + ""
    let v103 : (unit -> leptos_Fragment) = method135(v98)
    let v104 : (unit -> leptos_Fragment) = method136(v103)
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
and method394 () : (unit -> leptos_Fragment) =
    closure520()
and closure522 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M4.75 6.75h14.5M4.75 12h14.5M4.75 17.25h14.5\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
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
    let v21 : (unit -> leptos_Fragment) = method144()
    let v22 : string = " " + v17 + v4 + ""
    let v23 : string = " " + v18 + v22 + ""
    let v24 : string = " " + v19 + v23 + ""
    let v25 : string = " " + v20 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method135(v21)
    let v27 : (unit -> leptos_Fragment) = method136(v26)
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
    let v39 : (unit -> leptos_Fragment) = method144()
    let v40 : string = " " + v35 + v4 + ""
    let v41 : string = " " + v36 + v40 + ""
    let v42 : string = " " + v37 + v41 + ""
    let v43 : string = " " + v38 + v42 + ""
    let v44 : (unit -> leptos_Fragment) = method135(v39)
    let v45 : (unit -> leptos_Fragment) = method136(v44)
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
    let v56 : (unit -> leptos_Fragment) = method144()
    let v57 : string = " " + v52 + v4 + ""
    let v58 : string = " " + v53 + v57 + ""
    let v59 : string = " " + v54 + v58 + ""
    let v60 : string = " " + v55 + v59 + ""
    let v61 : (unit -> leptos_Fragment) = method135(v56)
    let v62 : (unit -> leptos_Fragment) = method136(v61)
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
and method396 () : (unit -> leptos_Fragment) =
    closure522()
and closure523 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M4 12h16m-7-7l7 7-7 7m-2-14l-7 7 7 7\""
    let v3 : (unit -> leptos_Fragment) = method134()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v3)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure164()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25
    v26
and method397 () : (unit -> leptos_Fragment) =
    closure523()
and closure524 (v0 : leptos_Memo<string>, v1 : string) () : std_string_String =
    let v2 : string = $"$0()"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = v3 + "#/" + v1 + ""
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and closure525 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : bool =
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
and closure526 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : StaticRef<Str> =
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
and closure527 (v0 : leptos_Fragment, v1 : string) () : leptos_Fragment =
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "leptos::html::text($0)"
    let v9 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "leptos::IntoView::into_view($0)"
    let v11 : leptos_View = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : (leptos_View []) = [|v3; v11|]
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "leptos::Fragment::new($0)"
    let v16 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
and method398 (v0 : leptos_Fragment, v1 : string) : (unit -> leptos_Fragment) =
    closure527(v0, v1)
and closure518 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) (v2 : US20) : leptos_View =
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
            let v16 : (unit -> string) = closure519()
            let v17 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v16 v15
            let v18 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v19 : string = "fill=\"none\""
            let v20 : string = "viewBox=\"0 0 24 24\""
            let v21 : string = "stroke-width=\"1.5\""
            let v22 : string = "stroke=\"currentColor\""
            let v23 : string = "class=move || \" \".to_owned() + &v17(())"
            let v24 : (unit -> leptos_Fragment) = method394()
            let v25 : string = ""
            let v26 : string = " " + v18 + v25 + ""
            let v27 : string = " " + v19 + v26 + ""
            let v28 : string = " " + v20 + v27 + ""
            let v29 : string = " " + v21 + v28 + ""
            let v30 : string = " " + v22 + v29 + ""
            let v31 : string = " " + v23 + v30 + ""
            let v32 : (unit -> leptos_Fragment) = method135(v24)
            let v33 : (unit -> leptos_Fragment) = method136(v32)
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
            let v47 : (unit -> string) = closure519()
            let v48 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v47 v46
            let v49 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v50 : string = "fill=\"none\""
            let v51 : string = "height=\"100%\""
            let v52 : string = "viewBox=\"0 0 24 24\""
            let v53 : string = "stroke-width=\"1.5\""
            let v54 : string = "stroke=\"currentColor\""
            let v55 : string = "class=move || \"text-gray-700 \".to_owned() + &v48(())"
            let v56 : (unit -> leptos_Fragment) = method396()
            let v57 : string = ""
            let v58 : string = " " + v49 + v57 + ""
            let v59 : string = " " + v50 + v58 + ""
            let v60 : string = " " + v51 + v59 + ""
            let v61 : string = " " + v52 + v60 + ""
            let v62 : string = " " + v53 + v61 + ""
            let v63 : string = " " + v54 + v62 + ""
            let v64 : string = " " + v55 + v63 + ""
            let v65 : (unit -> leptos_Fragment) = method135(v56)
            let v66 : (unit -> leptos_Fragment) = method136(v65)
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
            let v113 : (unit -> string) = closure519()
            let v114 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v113 v112
            let v115 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v116 : string = "fill=\"none\""
            let v117 : string = "viewBox=\"0 0 24 24\""
            let v118 : string = "stroke-width=\"1.5\""
            let v119 : string = "stroke=\"currentColor\""
            let v120 : string = "class=move || \" \".to_owned() + &v114(())"
            let v121 : (unit -> leptos_Fragment) = method275()
            let v122 : string = ""
            let v123 : string = " " + v115 + v122 + ""
            let v124 : string = " " + v116 + v123 + ""
            let v125 : string = " " + v117 + v124 + ""
            let v126 : string = " " + v118 + v125 + ""
            let v127 : string = " " + v119 + v126 + ""
            let v128 : string = " " + v120 + v127 + ""
            let v129 : (unit -> leptos_Fragment) = method135(v121)
            let v130 : (unit -> leptos_Fragment) = method136(v129)
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
            let v80 : (unit -> string) = closure519()
            let v81 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v80 v79
            let v82 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v83 : string = "fill=\"none\""
            let v84 : string = "height=\"100%\""
            let v85 : string = "viewBox=\"0 0 24 24\""
            let v86 : string = "stroke-width=\"1.5\""
            let v87 : string = "stroke=\"currentColor\""
            let v88 : string = "class=move || \"text-gray-700 \".to_owned() + &v81(())"
            let v89 : (unit -> leptos_Fragment) = method397()
            let v90 : string = ""
            let v91 : string = " " + v82 + v90 + ""
            let v92 : string = " " + v83 + v91 + ""
            let v93 : string = " " + v84 + v92 + ""
            let v94 : string = " " + v85 + v93 + ""
            let v95 : string = " " + v86 + v94 + ""
            let v96 : string = " " + v87 + v95 + ""
            let v97 : string = " " + v88 + v96 + ""
            let v98 : (unit -> leptos_Fragment) = method135(v89)
            let v99 : (unit -> leptos_Fragment) = method136(v98)
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
    let v163 : (unit -> std_string_String) = closure524(v1, v13)
    let v164 : string = "let v163 = $0"
    Fable.Core.RustInterop.emitRustExpr v163 v164
    let v165 : string = "$0"
    let v166 : (unit -> bool) = closure525(v0, v2)
    let v167 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v166 v165
    let v168 : string = "$0"
    let v169 : (unit -> StaticRef<Str>) = closure526(v0, v2)
    let v170 : (unit -> StaticRef<Str>) = Fable.Core.RustInterop.emitRustExpr v169 v168
    let v171 : string = "href=move || v163()"
    let v172 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[15px] pl-[15px] text-sm font-medium \".to_owned() + v170(())"
    let v173 : string = "aria-current=move || if v167(()) { \"page\" } else { \"\" }"
    let v174 : (unit -> leptos_Fragment) = method398(v151, v162)
    let v175 : string = ""
    let v176 : string = " " + v171 + v175 + ""
    let v177 : string = " " + v172 + v176 + ""
    let v178 : string = " " + v173 + v177 + ""
    let v179 : (unit -> leptos_Fragment) = method135(v174)
    let v180 : (unit -> leptos_Fragment) = method136(v179)
    let v181 : string = "a"
    let v182 : string = "<" + v181 + " " + v178 + ">{v180()}</" + v181 + ">"
    let v183 : string = "leptos::view! { " + v182 + " }"
    let v184 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v183
    let v185 : leptos_HtmlElement<leptos_html_A> = v184 |> unbox
    let v186 : string = "leptos::IntoView::into_view($0)"
    let v187 : leptos_View = Fable.Core.RustInterop.emitRustExpr v185 v186
    v187
and closure517 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : US21 = US21_0
    let v3 : US20 = US20_1(v2)
    let v4 : US20 = US20_2
    let v5 : US20 = US20_3
    let v6 : US20 = US20_4
    let v7 : (US20 []) = [|v3; v4; v5; v6|]
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<US20> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v11 : (US20 -> leptos_View) = closure518(v0, v1)
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17
    v18
and method393 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure517(v0, v1)
and closure516 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : string = "class=\"-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]\""
    let v3 : string = "aria-label=\"Tabs\""
    let v4 : (unit -> leptos_Fragment) = method393(v0, v1)
    let v5 : string = ""
    let v6 : string = " " + v2 + v5 + ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method135(v4)
    let v9 : (unit -> leptos_Fragment) = method136(v8)
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
and method392 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure516(v0, v1)
and closure515 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : string = "class=\"flex flex-1 border-t border-gray-200\""
    let v3 : (unit -> leptos_Fragment) = method392(v0, v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method135(v3)
    let v7 : (unit -> leptos_Fragment) = method136(v6)
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
and method391 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure515(v0, v1)
and closure508 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "menu_tabs.render ()"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "leptos_router::use_location()"
    let v5 : leptos_router_Location = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "$0"
    let v7 : (unit -> string) = closure37(v5)
    let v8 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v6
    let v9 : string = "leptos::create_memo(move |_| { v8(()) })"
    let v10 : leptos_Memo<string> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "class=\"hidden\""
    let v12 : (unit -> leptos_Fragment) = method386(v0)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method135(v12)
    let v16 : (unit -> leptos_Fragment) = method136(v15)
    let v17 : string = "div"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : leptos_HtmlElement<leptos_html_Div> = v20 |> unbox
    let v22 : string = "class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\""
    let v23 : (unit -> leptos_Fragment) = method391(v0, v10)
    let v24 : string = " " + v22 + v13 + ""
    let v25 : (unit -> leptos_Fragment) = method135(v23)
    let v26 : (unit -> leptos_Fragment) = method136(v25)
    let v27 : string = "<" + v17 + " " + v24 + ">{v26()}</" + v17 + ">"
    let v28 : string = "leptos::view! { " + v27 + " }"
    let v29 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : leptos_HtmlElement<leptos_html_Div> = v29 |> unbox
    let v31 : (leptos_HtmlElement<leptos_html_Div> []) = [|v21; v30|]
    let v32 : string = "$0.to_vec()"
    let v33 : Vec<leptos_HtmlElement<leptos_html_Div>> = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
    let v35 : (leptos_HtmlElement<leptos_html_Div> -> leptos_View) = closure207()
    let v36 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v33, v35) v34
    let v37 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v38 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "$0.to_vec()"
    let v40 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "leptos::Fragment::new($0)"
    let v42 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v40 v41
    v42
and method385 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure508(v0)
and closure43 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col [overflow:hidden]\""
    let v2 : (unit -> leptos_Fragment) = method49(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
    let v7 : string = "main"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : leptos_HtmlElement<leptos_html_Main> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "class=\"flex\""
    let v15 : (unit -> leptos_Fragment) = method385(v0)
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method135(v15)
    let v18 : (unit -> leptos_Fragment) = method136(v17)
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
and method48 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure43(v0)
and closure42 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\""
    let v2 : (unit -> leptos_Fragment) = method48(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method135(v2)
    let v6 : (unit -> leptos_Fragment) = method136(v5)
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
and method47 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure42(v0)
and closure36 () () : leptos_Fragment =
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
    let v10 : (unit -> string) = closure37(v8)
    let v11 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v10 v9
    let v12 : string = "leptos::create_memo(move |_| { v11(()) })"
    let v13 : leptos_Memo<string> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
    let v15 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "$0.unwrap()"
    let v17 : Heap2 = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = $"leptos::create_signal($0)"
    let v19 : US20 = US20_0
    let struct (v20 : leptos_ReadSignal<US20>, v21 : leptos_WriteSignal<US20>) = Fable.Core.RustInterop.emitRustExpr v19 v18
    let v22 : string = $"leptos::create_signal($0)"
    let struct (v23 : leptos_ReadSignal<bool>, v24 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr false v22
    let v25 : string = "$0"
    let v26 : (unit -> unit) = closure38(v4, v6, v13, v17, v24, v23)
    let v27 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v26 v25
    let v28 : string = "true; leptos::create_effect(move |_| { v27(()) })"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : string = "$0"
    let v31 : (unit -> unit) = closure39(v4, v21)
    let v32 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v31 v30
    let v33 : string = "true; leptos::create_effect(move |_| { v32(()) })"
    let v34 : bool = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : string = "class=\"flex flex-1 max-[100px]:[overflow-x:auto]\""
    let v36 : (unit -> leptos_Fragment) = method47(v20)
    let v37 : string = ""
    let v38 : string = " " + v35 + v37 + ""
    let v39 : (unit -> leptos_Fragment) = method135(v36)
    let v40 : (unit -> leptos_Fragment) = method136(v39)
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
and method43 () : (unit -> leptos_Fragment) =
    closure36()
and closure4 () (v0 : int32) : leptos_HtmlElement<leptos_html_Div> =
    let v1 : string = "home.render () / router: " + string v0 + ""
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
    let v5 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "$0.unwrap()"
    let v7 : Heap2 = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "state_core.use_database (1)"
    let v9 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : leptos_Resource<US2, rexie_Rexie> = method5()
    let v12 : string = "state_core.use_core_database (1)"
    let v13 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : leptos_Resource<rexie_Rexie option, US4> = method10(v11)
    let v16 : string = "$0"
    let v17 : (unit -> unit) = closure18(v7, v15)
    let v18 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "true; leptos::create_effect(move |_| { v18(()) })"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "$0"
    let v22 : (unit -> std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>) = closure29(v7)
    let v23 : (unit -> std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>) = Fable.Core.RustInterop.emitRustExpr v22 v21
    let v24 : string = "leptos::create_memo(move |_| { v23(()) })"
    let v25 : leptos_Memo<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : string = $"leptos::create_signal($0)"
    let struct (v27 : leptos_ReadSignal<bool>, v28 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr false v26
    let v29 : string = "leptos::create_action(move |value: &std::sync::Arc<Heap3>| $0(value.clone()))"
    let v30 : (Heap3 -> std_pin_Pin<Box<Dyn<std_future_Future<unit>>>>) = closure30(v11)
    let v31 : leptos_Action<Heap3, unit> = Fable.Core.RustInterop.emitRustExpr v30 v29
    let v32 : string = "$0"
    let v33 : (unit -> unit) = closure33(v7, v25, v28, v27, v31)
    let v34 : (unit -> unit) = Fable.Core.RustInterop.emitRustExpr v33 v32
    let v35 : string = "true; leptos::create_effect(move |_| { v34(()) })"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = "class=\"flex flex-1\""
    let v38 : (unit -> bool) = method42(v7)
    let v39 : string = "class:dark"
    let v40 : string = "" + v39 + "={move || v38()}"
    let v41 : (unit -> leptos_Fragment) = method43()
    let v42 : string = ""
    let v43 : string = " " + v37 + v42 + ""
    let v44 : string = " " + v40 + v43 + ""
    let v45 : (unit -> leptos_Fragment) = method135(v41)
    let v46 : (unit -> leptos_Fragment) = method136(v45)
    let v47 : string = "div"
    let v48 : string = "<" + v47 + " " + v44 + ">{v46()}</" + v47 + ">"
    let v49 : string = "leptos::view! { " + v48 + " }"
    let v50 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : leptos_HtmlElement<leptos_html_Div> = v50 |> unbox
    v51
and method4 () : (int32 -> leptos_HtmlElement<leptos_html_Div>) =
    closure4()
and method399 () : string =
    let v0 : string = ""
    v0
and closure528 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 1
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method400 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure528(v0)
and closure529 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3
    v4
and method401 () : (unit -> leptos_Fragment) =
    closure529()
and method402 () : string =
    let v0 : string = "/"
    v0
and closure530 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 2
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method403 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure530(v0)
and method404 () : string =
    let v0 : string = "/*"
    v0
and closure531 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 3
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method405 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure531(v0)
and method406 () : string =
    let v0 : string = "*"
    v0
and closure532 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 4
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7
    v8
and method407 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure532(v0)
and closure3 () () : leptos_Fragment =
    let v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>) = method4()
    let v1 : string = method399()
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : (unit -> leptos_Fragment) = method400(v0)
    let v7 : (unit -> leptos_Fragment) = method401()
    let v8 : string = "path=v5"
    let v9 : string = "view=move || v6()"
    let v10 : string = "children=Box::new(move || v7())"
    let v11 : string = ""
    let v12 : string = " " + v8 + v11 + ""
    let v13 : string = " " + v9 + v12 + ""
    let v14 : string = " " + v10 + v13 + ""
    let v15 : string = "leptos_router::Route"
    let v16 : string = "<" + v15 + " " + v14 + " />"
    let v17 : string = "leptos::IntoView::into_view(leptos::view! { " + v16 + " })"
    let v18 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = method402()
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : (unit -> leptos_Fragment) = method403(v0)
    let v25 : (unit -> leptos_Fragment) = method401()
    let v26 : string = "path=v23"
    let v27 : string = "view=move || v24()"
    let v28 : string = "children=Box::new(move || v25())"
    let v29 : string = " " + v26 + v11 + ""
    let v30 : string = " " + v27 + v29 + ""
    let v31 : string = " " + v28 + v30 + ""
    let v32 : string = "<" + v15 + " " + v31 + " />"
    let v33 : string = "leptos::IntoView::into_view(leptos::view! { " + v32 + " })"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : string = method404()
    let v36 : string = "&*$0"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : (unit -> leptos_Fragment) = method405(v0)
    let v41 : (unit -> leptos_Fragment) = method401()
    let v42 : string = "path=v39"
    let v43 : string = "view=move || v40()"
    let v44 : string = "children=Box::new(move || v41())"
    let v45 : string = " " + v42 + v11 + ""
    let v46 : string = " " + v43 + v45 + ""
    let v47 : string = " " + v44 + v46 + ""
    let v48 : string = "<" + v15 + " " + v47 + " />"
    let v49 : string = "leptos::IntoView::into_view(leptos::view! { " + v48 + " })"
    let v50 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : string = method406()
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "String::from($0)"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : (unit -> leptos_Fragment) = method407(v0)
    let v57 : (unit -> leptos_Fragment) = method401()
    let v58 : string = "path=v55"
    let v59 : string = "view=move || v56()"
    let v60 : string = "children=Box::new(move || v57())"
    let v61 : string = " " + v58 + v11 + ""
    let v62 : string = " " + v59 + v61 + ""
    let v63 : string = " " + v60 + v62 + ""
    let v64 : string = "<" + v15 + " " + v63 + " />"
    let v65 : string = "leptos::IntoView::into_view(leptos::view! { " + v64 + " })"
    let v66 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v65
    let v67 : (leptos_View []) = [|v18; v34; v50; v66|]
    let v68 : string = "$0.to_vec()"
    let v69 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : string = "leptos::Fragment::new($0)"
    let v71 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v69 v70
    v71
and closure2 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> leptos_Fragment) = closure3()
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
and method3 () : (unit -> leptos_Fragment) =
    closure2()
and closure1 () () : Impl<leptos_IntoView> =
    let v0 : string = "app.render ()"
    let v1 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "true; leptos_meta::provide_meta_context()"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = $"leptos::create_rw_signal($0)"
    let v6 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr false v5
    let v7 : string = $"leptos::create_rw_signal($0)"
    let v8 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr false v7
    let v9 : string = "&*$0"
    let v10 : string = ""
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v10 v9
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = $"leptos::create_rw_signal($0)"
    let v15 : leptos_RwSignal<std_string_String> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "&*$0"
    let v17 : string = "i574n.near"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v16
    let v19 : string = "String::from($0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : (bool * std_string_String) = true, v20
    let v22 : string = "&*$0"
    let v23 : string = "luckier.near"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v23 v22
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
    let v44 : string = $"true; leptos::provide_context::<std::sync::Arc<Heap2>>($0)"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : (unit -> leptos_Fragment) = method3()
    let v47 : string = "children=Box::new(move || v46())"
    let v48 : string = " " + v47 + v10 + ""
    let v49 : string = "leptos_router::Router"
    let v50 : string = "<" + v49 + " " + v48 + " />"
    let v51 : string = "leptos::IntoView::into_view(leptos::view! { " + v50 + " })"
    let v52 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Impl<leptos_IntoView> = v52 |> unbox
    v53
and method2 () : unit =
    let v0 : string = "true; leptos::mount_to_body(|| $0());"
    let v1 : (unit -> Impl<leptos_IntoView>) = closure1()
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v1 v0
    ()
and closure533 () () : unit =
    method2()
and method408 () : (unit -> unit) =
    closure533()
and method409 (v0 : Box<Dyn<FnUnit>>) : Box<Dyn<FnUnit>> =
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
    let v8 : US0 option = None
    let _v8 = ref v8 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v9 : web_sys_HtmlElement = x
    let v10 : US0 = US0_0(v9)
    v10 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v8.Value <- x
    let v11 : US0 option = _v8.Value 
    let v12 : US0 = US0_1
    let v13 : US0 = v11 |> Option.defaultValue v12 
    let v14 : string = $"%A{v13}"
    let v15 : string = "main / mount_to_body / body: " + string v14 + ""
    let v16 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16
    match v13 with
    | US0_0(v18) -> (* Some *)
        let v19 : string = method0()
        let v20 : string = "&*$0"
        let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20
        let v22 : web_sys_HtmlElement = method1(v18)
        let v23 : string = "v22.set_inner_html(v21)"
        Fable.Core.RustInterop.emitRustExpr () v23
        method2()
    | _ ->
        let v24 : (unit -> unit) = method408()
        let v25 : string = "Box::new(move || v24())"
        let v26 : Box<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v25
        let v27 : Box<Dyn<FnUnit>> = method409(v26)
        let v28 : string = "wasm_bindgen::closure::Closure::wrap(v27)"
        let v29 : wasm_bindgen_closure_Closure<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v28
        let v30 : string = "wasm_bindgen::closure::Closure::as_ref(&v29)"
        let v31 : Ref<wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : string = "wasm_bindgen::JsCast::unchecked_ref(v31)"
        let v33 : Ref<js_sys_Function> = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : string = "leptos::document().add_event_listener_with_callback(\"DOMContentLoaded\", v33).unwrap()"
        Fable.Core.RustInterop.emitRustExpr () v34
        let v35 : string = "v29.forget()"
        Fable.Core.RustInterop.emitRustExpr () v35
        ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
